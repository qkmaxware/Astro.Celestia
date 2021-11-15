using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_115() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4993"},
        {"Hipparcos Number", "HIP 4179"},
        {"Smithsonian Astrophysical Observation", "SAO 11446"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.34284217),
        dec: Angle.Degrees(+69.95608861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90893"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.10394743),
        dec: Angle.Degrees(+69.95744672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31264"},
        {"Hipparcos Number", "HIP 23246"},
        {"Smithsonian Astrophysical Observation", "SAO 13331"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.03670996),
        dec: Angle.Degrees(+69.95885036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71880"},
        {"Hipparcos Number", "HIP 42086"},
        {"Smithsonian Astrophysical Observation", "SAO 6584"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.67023703),
        dec: Angle.Degrees(+69.96836764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114445"},
        {"Hipparcos Number", "HIP 64152"},
        {"Smithsonian Astrophysical Observation", "SAO 7760"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.21678793),
        dec: Angle.Degrees(+69.96913134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19906"},
        {"Hipparcos Number", "HIP 15246"},
        {"Smithsonian Astrophysical Observation", "SAO 12676"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.16562527),
        dec: Angle.Degrees(+69.97920727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7229 AB"},
        {"Henry Draper", "HD 78696"},
        {"Hipparcos Number", "HIP 45284"},
        {"Smithsonian Astrophysical Observation", "SAO 6783"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.43836855),
        dec: Angle.Degrees(+69.97984677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36768"},
        {"Hipparcos Number", "HIP 26682"},
        {"Smithsonian Astrophysical Observation", "SAO 13559"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.05564348),
        dec: Angle.Degrees(+69.98184166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210550"},
        {"Hipparcos Number", "HIP 109275"},
        {"Geneva Identification System", "GEN# +1.00210550"},
        {"Smithsonian Astrophysical Observation", "SAO 19893"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07165159),
        dec: Angle.Degrees(+69.98231886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59248"},
        {"Smithsonian Astrophysical Observation", "SAO 7511"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.30467144),
        dec: Angle.Degrees(+69.98901332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94902"},
        {"Hipparcos Number", "HIP 53682"},
        {"Geneva Identification System", "GEN# +1.00094902"},
        {"Smithsonian Astrophysical Observation", "SAO 7250"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.75734870),
        dec: Angle.Degrees(+69.98906821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204373"},
        {"Hipparcos Number", "HIP 105691"},
        {"Smithsonian Astrophysical Observation", "SAO 19392"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.09955804),
        dec: Angle.Degrees(+69.99316117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107546"},
        {"Smithsonian Astrophysical Observation", "SAO 19644"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.73356466),
        dec: Angle.Degrees(+69.99673029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88865"},
        {"Hipparcos Number", "HIP 50418"},
        {"Smithsonian Astrophysical Observation", "SAO 7097"},
        {"Wilson Evans Batten Catalogue", "WEB 9252"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.41842313),
        dec: Angle.Degrees(+70.00362973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94574"},
        {"Hipparcos Number", "HIP 53514"},
        {"Geneva Identification System", "GEN# +1.00094574"},
        {"Smithsonian Astrophysical Observation", "SAO 7241"},
        {"Wilson Evans Batten Catalogue", "WEB 9715"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.21105073),
        dec: Angle.Degrees(+70.01077531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169282"},
        {"Hipparcos Number", "HIP 89664"},
        {"Geneva Identification System", "GEN# +1.00169282"},
        {"Smithsonian Astrophysical Observation", "SAO 17848"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46674392),
        dec: Angle.Degrees(+70.01134257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9165"},
        {"Hipparcos Number", "HIP 7182"},
        {"Smithsonian Astrophysical Observation", "SAO 11804"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13554151),
        dec: Angle.Degrees(+70.01945109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109551"},
        {"Hipparcos Number", "HIP 61384"},
        {"Geneva Identification System", "GEN# +1.00109551"},
        {"Smithsonian Astrophysical Observation", "SAO 7600"},
        {"Wilson Evans Batten Catalogue", "WEB 10926"},
    },
    visualMagnitude: 4.95,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.68360523),
        dec: Angle.Degrees(+70.02177318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16731"},
        {"Smithsonian Astrophysical Observation", "SAO 12819"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.81311417),
        dec: Angle.Degrees(+70.02700062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202719"},
        {"Hipparcos Number", "HIP 104791"},
        {"Smithsonian Astrophysical Observation", "SAO 19261"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.44638512),
        dec: Angle.Degrees(+70.02764258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95572"},
        {"Hipparcos Number", "HIP 54038"},
        {"Smithsonian Astrophysical Observation", "SAO 7272"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.86402783),
        dec: Angle.Degrees(+70.03082091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56323"},
        {"Hipparcos Number", "HIP 35744"},
        {"Smithsonian Astrophysical Observation", "SAO 6163"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.58895658),
        dec: Angle.Degrees(+70.03309783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47620"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.64995255),
        dec: Angle.Degrees(+70.03453903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -670.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24230"},
        {"Smithsonian Astrophysical Observation", "SAO 13398"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.03406653),
        dec: Angle.Degrees(+70.03491226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47650"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.72030897),
        dec: Angle.Degrees(+70.04005591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -668.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85533"},
        {"Hipparcos Number", "HIP 48691"},
        {"Geneva Identification System", "GEN# +1.00085533"},
        {"Smithsonian Astrophysical Observation", "SAO 7000"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.94561876),
        dec: Angle.Degrees(+70.04108727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8821",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1485 A"},
        {"Hipparcos Number", "HIP 8821"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.34751108),
        dec: Angle.Degrees(+70.04261131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102711"},
        {"Hipparcos Number", "HIP 57693"},
        {"Smithsonian Astrophysical Observation", "SAO 7432"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.47519190),
        dec: Angle.Degrees(+70.04358738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30425"},
        {"Hipparcos Number", "HIP 22739"},
        {"Smithsonian Astrophysical Observation", "SAO 13293"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.37877653),
        dec: Angle.Degrees(+70.04553492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1540"},
        {"Smithsonian Astrophysical Observation", "SAO 11107"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.80132466),
        dec: Angle.Degrees(+70.04946611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11179"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.98035668),
        dec: Angle.Degrees(+70.05149836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3551 AB"},
        {"Henry Draper", "HD 31231"},
        {"Hipparcos Number", "HIP 23234"},
        {"Smithsonian Astrophysical Observation", "SAO 13327"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.99075948),
        dec: Angle.Degrees(+70.05433396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99855"},
        {"Smithsonian Astrophysical Observation", "SAO 18787"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.87782480),
        dec: Angle.Degrees(+70.05710496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211867"},
        {"Hipparcos Number", "HIP 110062"},
        {"Geneva Identification System", "GEN# +1.00211867"},
        {"Smithsonian Astrophysical Observation", "SAO 19986"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.38421655),
        dec: Angle.Degrees(+70.05899162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124532"},
        {"Hipparcos Number", "HIP 69268"},
        {"Smithsonian Astrophysical Observation", "SAO 7963"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.70991600),
        dec: Angle.Degrees(+70.06377301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31674"},
        {"Hipparcos Number", "HIP 23545"},
        {"Smithsonian Astrophysical Observation", "SAO 5406"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.94817398),
        dec: Angle.Degrees(+70.07197511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36764"},
        {"Smithsonian Astrophysical Observation", "SAO 6236"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.42483853),
        dec: Angle.Degrees(+70.07252306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169905"},
        {"Hipparcos Number", "HIP 89911"},
        {"Geneva Identification System", "GEN# +1.00169905"},
        {"Smithsonian Astrophysical Observation", "SAO 9083"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.20471386),
        dec: Angle.Degrees(+70.07320570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87851"},
        {"Fundamental Katalog 5th Edition", "FK5 5581"},
        {"Smithsonian Astrophysical Observation", "SAO 8967"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.20428294),
        dec: Angle.Degrees(+70.08137259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50036"},
        {"Hipparcos Number", "HIP 33454"},
        {"Smithsonian Astrophysical Observation", "SAO 6016"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.33410159),
        dec: Angle.Degrees(+70.08792786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30616"},
        {"Smithsonian Astrophysical Observation", "SAO 5842"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.51186076),
        dec: Angle.Degrees(+70.09180236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116249"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.33113013),
        dec: Angle.Degrees(+70.09423498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20724"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.60940110),
        dec: Angle.Degrees(+70.09494325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117072"},
        {"Smithsonian Astrophysical Observation", "SAO 20809"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99751440),
        dec: Angle.Degrees(+70.10603277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64024"},
        {"Fundamental Katalog 5th Edition", "FK5 5160"},
        {"Smithsonian Astrophysical Observation", "SAO 7749"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.79995904),
        dec: Angle.Degrees(+70.10668131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7383"},
        {"Hipparcos Number", "HIP 5908"},
        {"Smithsonian Astrophysical Observation", "SAO 11660"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.98071653),
        dec: Angle.Degrees(+70.10827523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78617"},
        {"Smithsonian Astrophysical Observation", "SAO 8401"},
        {"Wilson Evans Batten Catalogue", "WEB 13288"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.74968161),
        dec: Angle.Degrees(+70.11395364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39210"},
        {"Smithsonian Astrophysical Observation", "SAO 6386"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30476416),
        dec: Angle.Degrees(+70.11584380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118524"},
        {"Hipparcos Number", "HIP 66269"},
        {"Smithsonian Astrophysical Observation", "SAO 7847"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.73572032),
        dec: Angle.Degrees(+70.11899266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117448"},
        {"Hipparcos Number", "HIP 65684"},
        {"Smithsonian Astrophysical Observation", "SAO 7823"},
        {"Wilson Evans Batten Catalogue", "WEB 11625"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.01688399),
        dec: Angle.Degrees(+70.12616606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15381"},
        {"Hipparcos Number", "HIP 11817"},
        {"Geneva Identification System", "GEN# +1.00015381"},
        {"Smithsonian Astrophysical Observation", "SAO 12318"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09769411),
        dec: Angle.Degrees(+70.12729661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70311"},
        {"Hipparcos Number", "HIP 41365"},
        {"Geneva Identification System", "GEN# +1.00070311"},
        {"Smithsonian Astrophysical Observation", "SAO 6535"},
        {"Wilson Evans Batten Catalogue", "WEB 8000"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.58204510),
        dec: Angle.Degrees(+70.12801468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32783"},
        {"Hipparcos Number", "HIP 24188"},
        {"Smithsonian Astrophysical Observation", "SAO 5454"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.89784757),
        dec: Angle.Degrees(+70.12886585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15719 A"},
        {"Henry Draper", "HD 210884"},
        {"Hipparcos Number", "HIP 109474"},
        {"Geneva Identification System", "GEN# +1.00210884A"},
        {"Smithsonian Astrophysical Observation", "SAO 19922"},
        {"Wilson Evans Batten Catalogue", "WEB 19673"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.66209270),
        dec: Angle.Degrees(+70.13251390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113377"},
        {"Hipparcos Number", "HIP 63579"},
        {"Smithsonian Astrophysical Observation", "SAO 7726"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42918479),
        dec: Angle.Degrees(+70.13768790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211319"},
        {"Hipparcos Number", "HIP 109724"},
        {"Geneva Identification System", "GEN# +1.00211319"},
        {"Smithsonian Astrophysical Observation", "SAO 19950"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.39618853),
        dec: Angle.Degrees(+70.14097361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92030"},
        {"Hipparcos Number", "HIP 52193"},
        {"Geneva Identification System", "GEN# +1.00092030"},
        {"Smithsonian Astrophysical Observation", "SAO 7181"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.94638377),
        dec: Angle.Degrees(+70.14098417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163465"},
        {"Hipparcos Number", "HIP 87295"},
        {"Smithsonian Astrophysical Observation", "SAO 8937"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.54957021),
        dec: Angle.Degrees(+70.14258643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2120"},
        {"Geneva Identification System", "GEN# +6.10010021"},
        {"Geneva Identification System 2", "GEN# +6.00117100"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72057388),
        dec: Angle.Degrees(+70.14277688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8498 AB"},
        {"Henry Draper", "HD 106831"},
        {"Hipparcos Number", "HIP 59878"},
        {"Smithsonian Astrophysical Observation", "SAO 7536"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.19593102),
        dec: Angle.Degrees(+70.14604901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194707"},
        {"Hipparcos Number", "HIP 100442"},
        {"Smithsonian Astrophysical Observation", "SAO 18835"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.54138346),
        dec: Angle.Degrees(+70.14620128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135045"},
        {"Hipparcos Number", "HIP 74097"},
        {"Geneva Identification System", "GEN# +1.00135045"},
        {"Smithsonian Astrophysical Observation", "SAO 8173"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.14926787),
        dec: Angle.Degrees(+70.14679427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207636"},
        {"Hipparcos Number", "HIP 107555"},
        {"Geneva Identification System", "GEN# +1.00207636"},
        {"Smithsonian Astrophysical Observation", "SAO 19646"},
        {"Wilson Evans Batten Catalogue", "WEB 19413"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.75361584),
        dec: Angle.Degrees(+70.15094328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20129"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.74047845),
        dec: Angle.Degrees(+70.15953855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73392"},
        {"Hipparcos Number", "HIP 42779"},
        {"Smithsonian Astrophysical Observation", "SAO 6620"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.75256060),
        dec: Angle.Degrees(+70.16463276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162"},
        {"Hipparcos Number", "HIP 548"},
        {"Smithsonian Astrophysical Observation", "SAO 10980"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.66696429),
        dec: Angle.Degrees(+70.16926509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213571"},
        {"Hipparcos Number", "HIP 111064"},
        {"Geneva Identification System", "GEN# +1.00213571"},
        {"Smithsonian Astrophysical Observation", "SAO 20113"},
        {"Wilson Evans Batten Catalogue", "WEB 19886"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.50139470),
        dec: Angle.Degrees(+70.17146695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108152"},
        {"Smithsonian Astrophysical Observation", "SAO 19737"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68008821),
        dec: Angle.Degrees(+70.17187242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10230"},
        {"Hipparcos Number", "HIP 7992"},
        {"Smithsonian Astrophysical Observation", "SAO 11922"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.65547155),
        dec: Angle.Degrees(+70.17366107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68435"},
        {"Hipparcos Number", "HIP 40620"},
        {"Smithsonian Astrophysical Observation", "SAO 6482"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.39178773),
        dec: Angle.Degrees(+70.17715086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109822"},
        {"Hipparcos Number", "HIP 61564"},
        {"Smithsonian Astrophysical Observation", "SAO 7611"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.21895631),
        dec: Angle.Degrees(+70.18474102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104890"},
        {"Smithsonian Astrophysical Observation", "SAO 19275"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.70663913),
        dec: Angle.Degrees(+70.19719822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13956"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.93690220),
        dec: Angle.Degrees(+70.19821306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106574"},
        {"Hipparcos Number", "HIP 59746"},
        {"Fundamental Katalog 5th Edition", "FK5 2980"},
        {"Geneva Identification System", "GEN# +1.00106574"},
        {"Smithsonian Astrophysical Observation", "SAO 7532"},
        {"Wilson Evans Batten Catalogue", "WEB 10616"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.78555700),
        dec: Angle.Degrees(+70.20007671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19655"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.17642696),
        dec: Angle.Degrees(+70.20148712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11570"},
        {"Hipparcos Number", "HIP 9042"},
        {"Smithsonian Astrophysical Observation", "SAO 12043"},
    },
    visualMagnitude: 7.24,
    bvColour: 2.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.13204902),
        dec: Angle.Degrees(+70.20379220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61994"},
        {"Hipparcos Number", "HIP 38018"},
        {"Fundamental Katalog 5th Edition", "FK5 2604"},
        {"Geneva Identification System", "GEN# +1.00061994"},
        {"Smithsonian Astrophysical Observation", "SAO 6310"},
        {"Wilson Evans Batten Catalogue", "WEB 7498"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.87808988),
        dec: Angle.Degrees(+70.20703482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66526"},
        {"Hipparcos Number", "HIP 39942"},
        {"Smithsonian Astrophysical Observation", "SAO 6430"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.36892210),
        dec: Angle.Degrees(+70.20810611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84747"},
        {"Hipparcos Number", "HIP 48285"},
        {"Geneva Identification System", "GEN# +1.00084747"},
        {"Smithsonian Astrophysical Observation", "SAO 6977"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.66634682),
        dec: Angle.Degrees(+70.20874807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15460"},
        {"Hipparcos Number", "HIP 11874"},
        {"Geneva Identification System", "GEN# +1.00015460"},
        {"Smithsonian Astrophysical Observation", "SAO 12323"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.29742056),
        dec: Angle.Degrees(+70.21332691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23102"},
        {"Hipparcos Number", "HIP 17715"},
        {"Geneva Identification System", "GEN# +1.00023102"},
        {"Smithsonian Astrophysical Observation", "SAO 4990"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.91211115),
        dec: Angle.Degrees(+70.21352201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18980"},
        {"Hipparcos Number", "HIP 14529"},
        {"Smithsonian Astrophysical Observation", "SAO 4826"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.90598987),
        dec: Angle.Degrees(+70.22244141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48026"},
        {"Hipparcos Number", "HIP 32555"},
        {"Smithsonian Astrophysical Observation", "SAO 5973"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.89002466),
        dec: Angle.Degrees(+70.22313249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34886"},
        {"Hipparcos Number", "HIP 25468"},
        {"Fundamental Katalog 5th Edition", "FK5 4499"},
        {"Geneva Identification System", "GEN# +1.00034886"},
        {"Smithsonian Astrophysical Observation", "SAO 5533"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.69580618),
        dec: Angle.Degrees(+70.22826046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86940"},
        {"Hipparcos Number", "HIP 49392"},
        {"Geneva Identification System", "GEN# +1.00086940"},
        {"Smithsonian Astrophysical Observation", "SAO 7043"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.25072880),
        dec: Angle.Degrees(+70.22920559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151234"},
        {"Hipparcos Number", "HIP 81627"},
        {"Smithsonian Astrophysical Observation", "SAO 8593"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.08902202),
        dec: Angle.Degrees(+70.23762488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104316"},
        {"Hipparcos Number", "HIP 58591"},
        {"Fundamental Katalog 5th Edition", "FK5 2962"},
        {"Geneva Identification System", "GEN# +1.00104316"},
        {"Smithsonian Astrophysical Observation", "SAO 7480"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21957234),
        dec: Angle.Degrees(+70.23782292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 234"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73358145),
        dec: Angle.Degrees(+70.23800778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88295"},
        {"Smithsonian Astrophysical Observation", "SAO 8985"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.45878521),
        dec: Angle.Degrees(+70.23809150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210640"},
        {"Hipparcos Number", "HIP 109324"},
        {"Geneva Identification System", "GEN# +1.00210640"},
        {"Smithsonian Astrophysical Observation", "SAO 19900"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23169748),
        dec: Angle.Degrees(+70.24026404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16841"},
        {"Hipparcos Number", "HIP 12924"},
        {"Smithsonian Astrophysical Observation", "SAO 4725"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.55850163),
        dec: Angle.Degrees(+70.24257062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214393"},
        {"Hipparcos Number", "HIP 111521"},
        {"Smithsonian Astrophysical Observation", "SAO 20171"},
        {"Wilson Evans Batten Catalogue", "WEB 19934"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.91767276),
        dec: Angle.Degrees(+70.24288761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112442"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.65724168),
        dec: Angle.Degrees(+70.24336849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128164"},
        {"Hipparcos Number", "HIP 71029"},
        {"Geneva Identification System", "GEN# +1.00128164"},
        {"Smithsonian Astrophysical Observation", "SAO 8041"},
        {"Wilson Evans Batten Catalogue", "WEB 12286"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.90851251),
        dec: Angle.Degrees(+70.24601197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41303"},
        {"Hipparcos Number", "HIP 29303"},
        {"Smithsonian Astrophysical Observation", "SAO 5766"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.66487322),
        dec: Angle.Degrees(+70.24837325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212439"},
        {"Hipparcos Number", "HIP 110399"},
        {"Smithsonian Astrophysical Observation", "SAO 10331"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.42870809),
        dec: Angle.Degrees(+70.25820071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185600"},
        {"Hipparcos Number", "HIP 96251"},
        {"Smithsonian Astrophysical Observation", "SAO 9463"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57328017),
        dec: Angle.Degrees(+70.25972511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145309"},
        {"Hipparcos Number", "HIP 78761"},
        {"Fundamental Katalog 5th Edition", "FK5 3272"},
        {"Geneva Identification System", "GEN# +1.00145309"},
        {"Smithsonian Astrophysical Observation", "SAO 8415"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20395078),
        dec: Angle.Degrees(+70.26165298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20633"},
        {"Hipparcos Number", "HIP 15851"},
        {"Smithsonian Astrophysical Observation", "SAO 4901"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.04892749),
        dec: Angle.Degrees(+70.26213520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9021"},
        {"Hipparcos Number", "HIP 7078"},
        {"Fundamental Katalog 5th Edition", "FK5 1042"},
        {"Geneva Identification System", "GEN# +1.00009021"},
        {"Smithsonian Astrophysical Observation", "SAO 4422"},
        {"Wilson Evans Batten Catalogue", "WEB 1526"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.80632718),
        dec: Angle.Degrees(+70.26478860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82839"},
        {"Hipparcos Number", "HIP 47293"},
        {"Geneva Identification System", "GEN# +1.00082839"},
        {"Smithsonian Astrophysical Observation", "SAO 6918"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.57116227),
        dec: Angle.Degrees(+70.26611008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97433",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tyl"},
        {"Aitken", "ADS 13007 A"},
        {"Henry Draper", "HD 188119A"},
        {"Henry Draper 2", "HD 188119"},
        {"Hipparcos Number", "HIP 97433"},
        {"Geneva Identification System", "GEN# +1.00188119"},
        {"Smithsonian Astrophysical Observation", "SAO 9540"},
        {"Wilson Evans Batten Catalogue", "WEB 17123"},
    },
    visualMagnitude: 3.84,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.04255658),
        dec: Angle.Degrees(+70.26783533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6166"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.77454437),
        dec: Angle.Degrees(+70.26843670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9556"},
        {"Hipparcos Number", "HIP 7471"},
        {"Smithsonian Astrophysical Observation", "SAO 4442"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04907352),
        dec: Angle.Degrees(+70.27085886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83838"},
        {"Hipparcos Number", "HIP 47801"},
        {"Smithsonian Astrophysical Observation", "SAO 6951"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.17407186),
        dec: Angle.Degrees(+70.28303449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66578"},
        {"Geneva Identification System", "GEN# +6.20020102"},
        {"Geneva Identification System 2", "GEN# +9.80238044"},
    },
    visualMagnitude: 12.79,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.71321916),
        dec: Angle.Degrees(+70.28551338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -403.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123262"},
        {"Hipparcos Number", "HIP 68662"},
        {"Smithsonian Astrophysical Observation", "SAO 7934"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.83473954),
        dec: Angle.Degrees(+70.28800500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103674"},
        {"Hipparcos Number", "HIP 58219"},
        {"Smithsonian Astrophysical Observation", "SAO 7460"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.10673439),
        dec: Angle.Degrees(+70.28905486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60519"},
        {"Hipparcos Number", "HIP 37392"},
        {"Smithsonian Astrophysical Observation", "SAO 6269"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.13279573),
        dec: Angle.Degrees(+70.29724896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216925"},
        {"Hipparcos Number", "HIP 113195"},
        {"Geneva Identification System", "GEN# +1.00216925"},
        {"Smithsonian Astrophysical Observation", "SAO 10550"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.85356786),
        dec: Angle.Degrees(+70.29728189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83141"},
        {"Hipparcos Number", "HIP 47443"},
        {"Geneva Identification System", "GEN# +1.00083141"},
        {"Smithsonian Astrophysical Observation", "SAO 6927"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.03646224),
        dec: Angle.Degrees(+70.29795716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74904"},
        {"Hipparcos Number", "HIP 43489"},
        {"Geneva Identification System", "GEN# +1.00074904"},
        {"Smithsonian Astrophysical Observation", "SAO 6667"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.87176144),
        dec: Angle.Degrees(+70.29938157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155262"},
        {"Hipparcos Number", "HIP 83532"},
        {"Geneva Identification System", "GEN# +1.00155262"},
        {"Smithsonian Astrophysical Observation", "SAO 8702"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.07956450),
        dec: Angle.Degrees(+70.30383008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225114"},
        {"Hipparcos Number", "HIP 292"},
        {"Renson", "Renson 61736"},
        {"Smithsonian Astrophysical Observation", "SAO 4024"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.90870678),
        dec: Angle.Degrees(+70.30603307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64629"},
        {"Geneva Identification System", "GEN# +0.07100646"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.70676394),
        dec: Angle.Degrees(+70.30993054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20021"},
        {"Hipparcos Number", "HIP 15326"},
        {"Smithsonian Astrophysical Observation", "SAO 4870"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.42437872),
        dec: Angle.Degrees(+70.31276313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117317"},
        {"Hipparcos Number", "HIP 65616"},
        {"Geneva Identification System", "GEN# +1.00117317"},
        {"Smithsonian Astrophysical Observation", "SAO 7817"},
        {"Wilson Evans Batten Catalogue", "WEB 11604"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.80043493),
        dec: Angle.Degrees(+70.31658151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34219"},
        {"Hipparcos Number", "HIP 25065"},
        {"Smithsonian Astrophysical Observation", "SAO 5508"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48859603),
        dec: Angle.Degrees(+70.31943769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6015"},
        {"Hipparcos Number", "HIP 4916"},
        {"Smithsonian Astrophysical Observation", "SAO 4307"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.78066195),
        dec: Angle.Degrees(+70.32190278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107841"},
        {"Hipparcos Number", "HIP 60393"},
        {"Smithsonian Astrophysical Observation", "SAO 7553"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.74998645),
        dec: Angle.Degrees(+70.32356697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25774"},
        {"Hipparcos Number", "HIP 19500"},
        {"Fundamental Katalog 5th Edition", "FK5 4380"},
        {"Geneva Identification System", "GEN# +1.00025774"},
        {"Smithsonian Astrophysical Observation", "SAO 5114"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67127446),
        dec: Angle.Degrees(+70.32884935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175783"},
        {"Hipparcos Number", "HIP 92483"},
        {"Geneva Identification System", "GEN# +1.00175783"},
        {"Smithsonian Astrophysical Observation", "SAO 9265"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.73142552),
        dec: Angle.Degrees(+70.32986026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84088"},
        {"Smithsonian Astrophysical Observation", "SAO 8731"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.86293818),
        dec: Angle.Degrees(+70.33495468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38047"},
        {"Smithsonian Astrophysical Observation", "SAO 6316"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98526480),
        dec: Angle.Degrees(+70.33501879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123011"},
        {"Hipparcos Number", "HIP 68555"},
        {"Smithsonian Astrophysical Observation", "SAO 7930"},
        {"Wilson Evans Batten Catalogue", "WEB 12005"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.50346106),
        dec: Angle.Degrees(+70.33633745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28020"},
        {"Hipparcos Number", "HIP 21083"},
        {"Smithsonian Astrophysical Observation", "SAO 5226"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.78180864),
        dec: Angle.Degrees(+70.33902470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14382"},
        {"Hipparcos Number", "HIP 11120"},
        {"Smithsonian Astrophysical Observation", "SAO 4635"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.76958699),
        dec: Angle.Degrees(+70.34323464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28414"},
        {"Hipparcos Number", "HIP 21325"},
        {"Smithsonian Astrophysical Observation", "SAO 5246"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65989874),
        dec: Angle.Degrees(+70.34635148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207485"},
        {"Hipparcos Number", "HIP 107457"},
        {"Smithsonian Astrophysical Observation", "SAO 10143"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.46846152),
        dec: Angle.Degrees(+70.34786556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80842"},
        {"Hipparcos Number", "HIP 46280"},
        {"Geneva Identification System", "GEN# +1.00080842"},
        {"Smithsonian Astrophysical Observation", "SAO 6854"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.54762330),
        dec: Angle.Degrees(+70.34943305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69839"},
        {"Smithsonian Astrophysical Observation", "SAO 7980"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.39194454),
        dec: Angle.Degrees(+70.35845791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220974"},
        {"Hipparcos Number", "HIP 115770"},
        {"Smithsonian Astrophysical Observation", "SAO 10737"},
        {"Wilson Evans Batten Catalogue", "WEB 20488"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.81840911),
        dec: Angle.Degrees(+70.35979323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36554"},
        {"Hipparcos Number", "HIP 26548"},
        {"Smithsonian Astrophysical Observation", "SAO 5594"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.68512390),
        dec: Angle.Degrees(+70.36453132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190252"},
        {"Hipparcos Number", "HIP 98333"},
        {"Geneva Identification System", "GEN# +1.00190252"},
        {"Smithsonian Astrophysical Observation", "SAO 9592"},
        {"Wilson Evans Batten Catalogue", "WEB 17347"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.67409575),
        dec: Angle.Degrees(+70.36680747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116272"},
        {"Smithsonian Astrophysical Observation", "SAO 10779"},
        {"Wilson Evans Batten Catalogue", "WEB 20547"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37888568),
        dec: Angle.Degrees(+70.36724881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148004"},
        {"Hipparcos Number", "HIP 79981"},
        {"Geneva Identification System", "GEN# +1.00148004"},
        {"Smithsonian Astrophysical Observation", "SAO 8475"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.88622836),
        dec: Angle.Degrees(+70.36850534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190316"},
        {"Hipparcos Number", "HIP 98365"},
        {"Smithsonian Astrophysical Observation", "SAO 9598"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.77615696),
        dec: Angle.Degrees(+70.37208012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214019"},
        {"Hipparcos Number", "HIP 111325"},
        {"Geneva Identification System", "GEN# +1.00214019A"},
        {"Smithsonian Astrophysical Observation", "SAO 10418"},
        {"Wilson Evans Batten Catalogue", "WEB 19915"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.31983037),
        dec: Angle.Degrees(+70.37368142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142006"},
        {"Hipparcos Number", "HIP 77290"},
        {"Geneva Identification System", "GEN# +1.00142006"},
        {"Smithsonian Astrophysical Observation", "SAO 8335"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.70427318),
        dec: Angle.Degrees(+70.37423700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114825"},
        {"Smithsonian Astrophysical Observation", "SAO 10670"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.89948474),
        dec: Angle.Degrees(+70.38410620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138900"},
        {"Hipparcos Number", "HIP 75886"},
        {"Smithsonian Astrophysical Observation", "SAO 8262"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.50061903),
        dec: Angle.Degrees(+70.38614560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8545"},
        {"Hipparcos Number", "HIP 6737"},
        {"Geneva Identification System", "GEN# +1.00008545"},
        {"Smithsonian Astrophysical Observation", "SAO 4404"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.68332913),
        dec: Angle.Degrees(+70.38729298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174895"},
        {"Hipparcos Number", "HIP 92141"},
        {"Geneva Identification System", "GEN# +1.00174895"},
        {"Smithsonian Astrophysical Observation", "SAO 9244"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69699201),
        dec: Angle.Degrees(+70.39025367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62630"},
        {"Smithsonian Astrophysical Observation", "SAO 7675"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.50092837),
        dec: Angle.Degrees(+70.39086866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95396"},
        {"Hipparcos Number", "HIP 53956"},
        {"Smithsonian Astrophysical Observation", "SAO 7268"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.59422096),
        dec: Angle.Degrees(+70.39997966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6382"},
        {"Smithsonian Astrophysical Observation", "SAO 4389"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.50782056),
        dec: Angle.Degrees(+70.40477582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79720"},
        {"Hipparcos Number", "HIP 45752"},
        {"Smithsonian Astrophysical Observation", "SAO 6819"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.94863170),
        dec: Angle.Degrees(+70.41235914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11656"},
        {"Smithsonian Astrophysical Observation", "SAO 4660"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.58403428),
        dec: Angle.Degrees(+70.41322368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36711"},
        {"Smithsonian Astrophysical Observation", "SAO 6232"},
    },
    visualMagnitude: 9.99,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.26579275),
        dec: Angle.Degrees(+70.41866939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115097"},
        {"Fundamental Katalog 5th Edition", "FK5 6061"},
        {"Smithsonian Astrophysical Observation", "SAO 10691"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.68851655),
        dec: Angle.Degrees(+70.42182572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170929"},
        {"Hipparcos Number", "HIP 90328"},
        {"Smithsonian Astrophysical Observation", "SAO 9120"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.45321466),
        dec: Angle.Degrees(+70.42205517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117962"},
        {"Hipparcos Number", "HIP 65962"},
        {"Geneva Identification System", "GEN# +1.00117962"},
        {"Smithsonian Astrophysical Observation", "SAO 7833"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.86771610),
        dec: Angle.Degrees(+70.42253833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58786"},
        {"Geneva Identification System", "GEN# +0.07100600"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.85414629),
        dec: Angle.Degrees(+70.43214180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83696"},
        {"Hipparcos Number", "HIP 47737"},
        {"Geneva Identification System", "GEN# +1.00083696"},
        {"Smithsonian Astrophysical Observation", "SAO 6944"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.97320089),
        dec: Angle.Degrees(+70.43402301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213502"},
        {"Hipparcos Number", "HIP 111018"},
        {"Smithsonian Astrophysical Observation", "SAO 10394"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.37646833),
        dec: Angle.Degrees(+70.43572134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38417"},
        {"Smithsonian Astrophysical Observation", "SAO 6334"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.05670060),
        dec: Angle.Degrees(+70.43640244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150870"},
        {"Hipparcos Number", "HIP 81429"},
        {"Smithsonian Astrophysical Observation", "SAO 8575"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.47902022),
        dec: Angle.Degrees(+70.43953958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202432"},
        {"Hipparcos Number", "HIP 104632"},
        {"Smithsonian Astrophysical Observation", "SAO 9984"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.91822782),
        dec: Angle.Degrees(+70.44107676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80730"},
        {"Hipparcos Number", "HIP 46220"},
        {"Geneva Identification System", "GEN# +1.00080730"},
        {"Smithsonian Astrophysical Observation", "SAO 6848"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.35025602),
        dec: Angle.Degrees(+70.44486482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162466"},
        {"Hipparcos Number", "HIP 86876"},
        {"Geneva Identification System", "GEN# +1.00162466"},
        {"Smithsonian Astrophysical Observation", "SAO 8901"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.24739605),
        dec: Angle.Degrees(+70.44854791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4635"},
        {"Hipparcos Number", "HIP 3876"},
        {"Cincinnati Publication", "Ci 20 57"},
        {"Geneva Identification System", "GEN# +1.00004635"},
        {"Smithsonian Astrophysical Observation", "SAO 4239"},
        {"Wilson Evans Batten Catalogue", "WEB 689"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.44099553),
        dec: Angle.Degrees(+70.44899713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 370.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24580"},
        {"Hipparcos Number", "HIP 18672"},
        {"Smithsonian Astrophysical Observation", "SAO 5054"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.97928173),
        dec: Angle.Degrees(+70.45021377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5333"},
        {"Hipparcos Number", "HIP 4419"},
        {"Fundamental Katalog 5th Edition", "FK5 4085"},
        {"Geneva Identification System", "GEN# +1.00005333"},
        {"Smithsonian Astrophysical Observation", "SAO 4268"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.15532412),
        dec: Angle.Degrees(+70.45350446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13315 AB"},
        {"Henry Draper", "HD 190833"},
        {"Hipparcos Number", "HIP 98594"},
        {"Smithsonian Astrophysical Observation", "SAO 9608"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.39155252),
        dec: Angle.Degrees(+70.45446832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25318"},
        {"Hipparcos Number", "HIP 19195"},
        {"Smithsonian Astrophysical Observation", "SAO 5093"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.70556789),
        dec: Angle.Degrees(+70.46056179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39372"},
        {"Smithsonian Astrophysical Observation", "SAO 6396"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.73495462),
        dec: Angle.Degrees(+70.46292183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206507"},
        {"Hipparcos Number", "HIP 106888"},
        {"Geneva Identification System", "GEN# +1.00206507"},
        {"Smithsonian Astrophysical Observation", "SAO 10111"},
        {"Wilson Evans Batten Catalogue", "WEB 19320"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74246738),
        dec: Angle.Degrees(+70.46297663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153596"},
        {"Hipparcos Number", "HIP 82718"},
        {"Fundamental Katalog 5th Edition", "FK5 3345"},
        {"Geneva Identification System", "GEN# +1.00153596"},
        {"Smithsonian Astrophysical Observation", "SAO 8657"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61879809),
        dec: Angle.Degrees(+70.46409545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86568"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.36386650),
        dec: Angle.Degrees(+70.46420783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70321"},
        {"Smithsonian Astrophysical Observation", "SAO 8004"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.81440112),
        dec: Angle.Degrees(+70.46539122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67446"},
        {"Hipparcos Number", "HIP 40261"},
        {"Smithsonian Astrophysical Observation", "SAO 6458"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.33554307),
        dec: Angle.Degrees(+70.46543747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172803"},
        {"Hipparcos Number", "HIP 91177"},
        {"Smithsonian Astrophysical Observation", "SAO 9178"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.01510997),
        dec: Angle.Degrees(+70.46705872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37135"},
        {"Hipparcos Number", "HIP 26905"},
        {"Smithsonian Astrophysical Observation", "SAO 5624"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.67696388),
        dec: Angle.Degrees(+70.46977865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196358"},
        {"Hipparcos Number", "HIP 101314"},
        {"Smithsonian Astrophysical Observation", "SAO 9801"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02946506),
        dec: Angle.Degrees(+70.47242852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204521"},
        {"Hipparcos Number", "HIP 105766"},
        {"Geneva Identification System", "GEN# +1.00204521"},
        {"Smithsonian Astrophysical Observation", "SAO 10045"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.31969271),
        dec: Angle.Degrees(+70.47744396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11442"},
        {"Hipparcos Number", "HIP 8960"},
        {"Geneva Identification System", "GEN# +1.00011442"},
        {"Smithsonian Astrophysical Observation", "SAO 4515"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.85976634),
        dec: Angle.Degrees(+70.48568194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101023"},
        {"Hipparcos Number", "HIP 56767"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.58059162),
        dec: Angle.Degrees(+70.48770627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13630"},
        {"Hipparcos Number", "HIP 10595"},
        {"Smithsonian Astrophysical Observation", "SAO 4608"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.10679687),
        dec: Angle.Degrees(+70.49273313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17157"},
        {"Hipparcos Number", "HIP 13167"},
        {"Smithsonian Astrophysical Observation", "SAO 4736"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.33248123),
        dec: Angle.Degrees(+70.49487141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5490"},
        {"Hipparcos Number", "HIP 4550"},
        {"Smithsonian Astrophysical Observation", "SAO 4278"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.55294302),
        dec: Angle.Degrees(+70.49636927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148344"},
        {"Hipparcos Number", "HIP 80154"},
        {"Smithsonian Astrophysical Observation", "SAO 8490"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.41176151),
        dec: Angle.Degrees(+70.49767575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45967"},
        {"Hipparcos Number", "HIP 31606"},
        {"Smithsonian Astrophysical Observation", "SAO 5903"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.22438808),
        dec: Angle.Degrees(+70.50355447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54684"},
        {"Hipparcos Number", "HIP 35134"},
        {"Geneva Identification System", "GEN# +1.00054684"},
        {"Smithsonian Astrophysical Observation", "SAO 6125"},
        {"Wilson Evans Batten Catalogue", "WEB 7019"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.94954114),
        dec: Angle.Degrees(+70.50611184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23602"},
        {"Hipparcos Number", "HIP 18070"},
        {"Smithsonian Astrophysical Observation", "SAO 5015"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.93243592),
        dec: Angle.Degrees(+70.50812473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13595"},
        {"Smithsonian Astrophysical Observation", "SAO 4764"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.78953572),
        dec: Angle.Degrees(+70.51206500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117811"},
        {"Smithsonian Astrophysical Observation", "SAO 10885"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.40395762),
        dec: Angle.Degrees(+70.51648650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5837"},
        {"Henry Draper 2", "HD 5838"},
        {"Hipparcos Number", "HIP 4800"},
        {"Geneva Identification System", "GEN# +1.00005837"},
        {"Smithsonian Astrophysical Observation", "SAO 4294"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.40794367),
        dec: Angle.Degrees(+70.52135177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152171"},
        {"Hipparcos Number", "HIP 82066"},
        {"Geneva Identification System", "GEN# +1.00152171"},
        {"Smithsonian Astrophysical Observation", "SAO 8616"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.44854883),
        dec: Angle.Degrees(+70.52178165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72470"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27922586),
        dec: Angle.Degrees(+70.52609671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12818"},
        {"Hipparcos Number", "HIP 10011"},
        {"Smithsonian Astrophysical Observation", "SAO 4586"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.23211324),
        dec: Angle.Degrees(+70.52675444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29909"},
        {"Hipparcos Number", "HIP 22345"},
        {"Geneva Identification System", "GEN# +1.00029909"},
        {"Smithsonian Astrophysical Observation", "SAO 5314"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16892095),
        dec: Angle.Degrees(+70.52691351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37866"},
        {"Hipparcos Number", "HIP 27375"},
        {"Smithsonian Astrophysical Observation", "SAO 5658"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.97250128),
        dec: Angle.Degrees(+70.52890114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196420"},
        {"Hipparcos Number", "HIP 101349"},
        {"Smithsonian Astrophysical Observation", "SAO 9804"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.10491456),
        dec: Angle.Degrees(+70.53213690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30794",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5039 AB"},
        {"Henry Draper", "HD 44472"},
        {"Hipparcos Number", "HIP 30794"},
        {"Smithsonian Astrophysical Observation", "SAO 5861"},
        {"Wilson Evans Batten Catalogue", "WEB 6138"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.06035770),
        dec: Angle.Degrees(+70.53529114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206772"},
        {"Hipparcos Number", "HIP 107055"},
        {"Geneva Identification System", "GEN# +1.00206772"},
        {"Smithsonian Astrophysical Observation", "SAO 10122"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.23925664),
        dec: Angle.Degrees(+70.53918871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23101"},
        {"Hipparcos Number", "HIP 17728"},
        {"Smithsonian Astrophysical Observation", "SAO 4991"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.94422584),
        dec: Angle.Degrees(+70.54936506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82522"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.99321711),
        dec: Angle.Degrees(+70.55991712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106032",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alfirk"},
        {"Aitken", "ADS 15032 A"},
        {"Henry Draper", "HD 205021"},
        {"Hipparcos Number", "HIP 106032"},
        {"Fundamental Katalog 5th Edition", "FK5 809"},
        {"Geneva Identification System", "GEN# +1.00205021A"},
        {"Smithsonian Astrophysical Observation", "SAO 10057"},
        {"Wilson Evans Batten Catalogue", "WEB 19222"},
    },
    visualMagnitude: 3.23,
    bvColour: -0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.16489595),
        dec: Angle.Degrees(+70.56069481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85973"},
        {"Smithsonian Astrophysical Observation", "SAO 8847"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.56101878),
        dec: Angle.Degrees(+70.56469798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174102"},
        {"Hipparcos Number", "HIP 91765"},
        {"Smithsonian Astrophysical Observation", "SAO 9217"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.68916526),
        dec: Angle.Degrees(+70.56866380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151286"},
        {"Hipparcos Number", "HIP 81640"},
        {"Geneva Identification System", "GEN# +1.00151286"},
        {"Smithsonian Astrophysical Observation", "SAO 8596"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.15759451),
        dec: Angle.Degrees(+70.57075584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28121"},
        {"Hipparcos Number", "HIP 21142"},
        {"Smithsonian Astrophysical Observation", "SAO 5230"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.98742276),
        dec: Angle.Degrees(+70.57584046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39718"},
        {"Smithsonian Astrophysical Observation", "SAO 6419"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.77544047),
        dec: Angle.Degrees(+70.58244039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11328"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.44567293),
        dec: Angle.Degrees(+70.58360347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46979"},
        {"Hipparcos Number", "HIP 32114"},
        {"Smithsonian Astrophysical Observation", "SAO 5942"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.61507327),
        dec: Angle.Degrees(+70.58881389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112987"},
        {"Hipparcos Number", "HIP 63370"},
        {"Smithsonian Astrophysical Observation", "SAO 7715"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.77307649),
        dec: Angle.Degrees(+70.59681616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14410"},
        {"Smithsonian Astrophysical Observation", "SAO 4818"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.47794024),
        dec: Angle.Degrees(+70.59928203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77385"},
        {"Smithsonian Astrophysical Observation", "SAO 8339"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.95242492),
        dec: Angle.Degrees(+70.60717202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101165"},
        {"Smithsonian Astrophysical Observation", "SAO 9794"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.58806513),
        dec: Angle.Degrees(+70.61152644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183097"},
        {"Hipparcos Number", "HIP 95200"},
        {"Smithsonian Astrophysical Observation", "SAO 9400"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.50641463),
        dec: Angle.Degrees(+70.61368334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133482"},
        {"Hipparcos Number", "HIP 73412"},
        {"Geneva Identification System", "GEN# +1.00133482"},
        {"Smithsonian Astrophysical Observation", "SAO 8138"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.04268458),
        dec: Angle.Degrees(+70.61396292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10250"},
        {"Hipparcos Number", "HIP 8016"},
        {"Geneva Identification System", "GEN# +1.00010250"},
        {"Smithsonian Astrophysical Observation", "SAO 4470"},
        {"Wilson Evans Batten Catalogue", "WEB 1716"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.73220374),
        dec: Angle.Degrees(+70.62255881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94202"},
        {"Hipparcos Number", "HIP 53320"},
        {"Smithsonian Astrophysical Observation", "SAO 7234"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.59052639),
        dec: Angle.Degrees(+70.62414921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15722"},
        {"Smithsonian Astrophysical Observation", "SAO 4889"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.63050836),
        dec: Angle.Degrees(+70.62822975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30604"},
        {"Hipparcos Number", "HIP 22879"},
        {"Cincinnati Publication", "Ci 18 618"},
        {"Geneva Identification System", "GEN# +1.00030604"},
        {"Smithsonian Astrophysical Observation", "SAO 5350"},
        {"Wilson Evans Batten Catalogue", "WEB 4435"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.82166533),
        dec: Angle.Degrees(+70.63400133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218169"},
        {"Hipparcos Number", "HIP 113933"},
        {"Geneva Identification System", "GEN# +1.00218169"},
        {"Smithsonian Astrophysical Observation", "SAO 10609"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.08215527),
        dec: Angle.Degrees(+70.63434662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161477"},
        {"Hipparcos Number", "HIP 86421"},
        {"Smithsonian Astrophysical Observation", "SAO 8872"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87666948),
        dec: Angle.Degrees(+70.63750590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51885"},
        {"Hipparcos Number", "HIP 34169"},
        {"Smithsonian Astrophysical Observation", "SAO 6070"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.28740373),
        dec: Angle.Degrees(+70.64509388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42963"},
        {"Smithsonian Astrophysical Observation", "SAO 6628"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.36049049),
        dec: Angle.Degrees(+70.64972747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58525",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8379 A"},
        {"Henry Draper", "HD 104202"},
        {"Hipparcos Number", "HIP 58525"},
        {"Renson", "Renson 30120"},
        {"Smithsonian Astrophysical Observation", "SAO 7477"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.03508355),
        dec: Angle.Degrees(+70.65148720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76023"},
        {"Hipparcos Number", "HIP 44052"},
        {"Geneva Identification System", "GEN# +1.00076023"},
        {"Smithsonian Astrophysical Observation", "SAO 6699"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.57313795),
        dec: Angle.Degrees(+70.65473779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48578"},
        {"Smithsonian Astrophysical Observation", "SAO 6993"},
    },
    visualMagnitude: 11.31,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.61608406),
        dec: Angle.Degrees(+70.68930355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14248",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2291 AB"},
        {"Henry Draper", "HD 18576"},
        {"Hipparcos Number", "HIP 14248"},
        {"Smithsonian Astrophysical Observation", "SAO 4808"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.94478240),
        dec: Angle.Degrees(+70.65719921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8379 C"},
        {"Hipparcos Number", "HIP 58522"},
        {"Smithsonian Astrophysical Observation", "SAO 7476"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.02495748),
        dec: Angle.Degrees(+70.65943579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191804"},
        {"Hipparcos Number", "HIP 99037"},
        {"Geneva Identification System", "GEN# +1.00191804"},
        {"Smithsonian Astrophysical Observation", "SAO 9642"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.61525233),
        dec: Angle.Degrees(+70.65983393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218535"},
        {"Hipparcos Number", "HIP 114180"},
        {"Smithsonian Astrophysical Observation", "SAO 10623"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.84279307),
        dec: Angle.Degrees(+70.66096640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91653"},
        {"Hipparcos Number", "HIP 51994"},
        {"Smithsonian Astrophysical Observation", "SAO 7172"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33628990),
        dec: Angle.Degrees(+70.66177189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42061"},
        {"Hipparcos Number", "HIP 29669"},
        {"Geneva Identification System", "GEN# +1.00042061"},
        {"Smithsonian Astrophysical Observation", "SAO 5785"},
        {"Wilson Evans Batten Catalogue", "WEB 5843"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.75155641),
        dec: Angle.Degrees(+70.66778576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103650"},
        {"Geneva Identification System", "GEN# +0.07001157"},
        {"Smithsonian Astrophysical Observation", "SAO 9925"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.01322358),
        dec: Angle.Degrees(+70.66879186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44229"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.12749446),
        dec: Angle.Degrees(+70.66962034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -499.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12698"},
        {"Hipparcos Number", "HIP 9910"},
        {"Smithsonian Astrophysical Observation", "SAO 4580"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.89215169),
        dec: Angle.Degrees(+70.66991277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31423"},
        {"Smithsonian Astrophysical Observation", "SAO 5895"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.77529698),
        dec: Angle.Degrees(+70.67839134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77559",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9820 AB"},
        {"Hipparcos Number", "HIP 77559"},
        {"Smithsonian Astrophysical Observation", "SAO 8349"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.52581345),
        dec: Angle.Degrees(+70.67962093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138733"},
        {"Hipparcos Number", "HIP 75782"},
        {"Smithsonian Astrophysical Observation", "SAO 8259"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.21306239),
        dec: Angle.Degrees(+70.68129928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6610"},
        {"Hipparcos Number", "HIP 5370"},
        {"Smithsonian Astrophysical Observation", "SAO 4334"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.17025836),
        dec: Angle.Degrees(+70.68156999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26476"},
        {"Hipparcos Number", "HIP 19973"},
        {"Smithsonian Astrophysical Observation", "SAO 5139"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.24382877),
        dec: Angle.Degrees(+70.68484251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115678",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16754 A"},
        {"Henry Draper", "HD 220841"},
        {"Hipparcos Number", "HIP 115678"},
        {"Geneva Identification System", "GEN# +1.00220841"},
        {"Renson", "Renson 60530"},
        {"Smithsonian Astrophysical Observation", "SAO 10732"},
        {"Wilson Evans Batten Catalogue", "WEB 20472"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.54907893),
        dec: Angle.Degrees(+70.68540877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56818"},
        {"Hipparcos Number", "HIP 35942"},
        {"Smithsonian Astrophysical Observation", "SAO 6175"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.13950751),
        dec: Angle.Degrees(+70.68648331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210401"},
        {"Hipparcos Number", "HIP 109197"},
        {"Geneva Identification System", "GEN# +1.00210401"},
        {"Smithsonian Astrophysical Observation", "SAO 10251"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.80986869),
        dec: Angle.Degrees(+70.69414299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177620"},
        {"Hipparcos Number", "HIP 93237"},
        {"Smithsonian Astrophysical Observation", "SAO 9295"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.86973640),
        dec: Angle.Degrees(+70.69731226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3660"},
        {"Hipparcos Number", "HIP 3172"},
        {"Smithsonian Astrophysical Observation", "SAO 4181"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.10681126),
        dec: Angle.Degrees(+70.70827316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27240"},
        {"Smithsonian Astrophysical Observation", "SAO 5647"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.60681442),
        dec: Angle.Degrees(+70.71054443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102715"},
        {"Smithsonian Astrophysical Observation", "SAO 9886"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.19887183),
        dec: Angle.Degrees(+70.72284910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52030"},
        {"Hipparcos Number", "HIP 34238"},
        {"Smithsonian Astrophysical Observation", "SAO 6074"},
        {"Wilson Evans Batten Catalogue", "WEB 6858"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.46506343),
        dec: Angle.Degrees(+70.73194016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177827"},
        {"Hipparcos Number", "HIP 93306"},
        {"Smithsonian Astrophysical Observation", "SAO 9298"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.07241647),
        dec: Angle.Degrees(+70.73322251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101074"},
        {"Hipparcos Number", "HIP 56800"},
        {"Smithsonian Astrophysical Observation", "SAO 7403"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.66138651),
        dec: Angle.Degrees(+70.73788337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96512"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.30927038),
        dec: Angle.Degrees(+70.74182172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61316"},
        {"Hipparcos Number", "HIP 37741"},
        {"Geneva Identification System", "GEN# +1.00061316"},
        {"Smithsonian Astrophysical Observation", "SAO 6294"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.11286549),
        dec: Angle.Degrees(+70.74467733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51356"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.34657403),
        dec: Angle.Degrees(+70.74638222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47675"},
        {"Hipparcos Number", "HIP 32428"},
        {"Smithsonian Astrophysical Observation", "SAO 5962"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.53828787),
        dec: Angle.Degrees(+70.74846625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14442"},
        {"Smithsonian Astrophysical Observation", "SAO 4821"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.60484672),
        dec: Angle.Degrees(+70.74930814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11114"},
        {"Hipparcos Number", "HIP 8719"},
        {"Geneva Identification System", "GEN# +1.00011114"},
        {"Smithsonian Astrophysical Observation", "SAO 4506"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04395434),
        dec: Angle.Degrees(+70.75137860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117921",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17097 AB"},
        {"Henry Draper", "HD 224115"},
        {"Hipparcos Number", "HIP 117921"},
        {"Smithsonian Astrophysical Observation", "SAO 10896"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.77147511),
        dec: Angle.Degrees(+70.75466402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112704"},
        {"Hipparcos Number", "HIP 63216"},
        {"Geneva Identification System", "GEN# +1.00112704"},
        {"Smithsonian Astrophysical Observation", "SAO 7707"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.28935230),
        dec: Angle.Degrees(+70.75530368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87311"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.60468897),
        dec: Angle.Degrees(+70.76006892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86559"},
        {"Hipparcos Number", "HIP 49208"},
        {"Geneva Identification System", "GEN# +1.00086559"},
        {"Smithsonian Astrophysical Observation", "SAO 7035"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.65068376),
        dec: Angle.Degrees(+70.76458276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134350"},
        {"Hipparcos Number", "HIP 73784"},
        {"Smithsonian Astrophysical Observation", "SAO 8154"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.21994168),
        dec: Angle.Degrees(+70.76587778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213022"},
        {"Hipparcos Number", "HIP 110725"},
        {"Fundamental Katalog 5th Edition", "FK5 3794"},
        {"Geneva Identification System", "GEN# +1.00213022"},
        {"Smithsonian Astrophysical Observation", "SAO 10366"},
        {"Wilson Evans Batten Catalogue", "WEB 19839"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.50326220),
        dec: Angle.Degrees(+70.77088542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4667"},
        {"Hipparcos Number", "HIP 3901"},
        {"Smithsonian Astrophysical Observation", "SAO 4244"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.50936195),
        dec: Angle.Degrees(+70.77417543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61822"},
        {"Smithsonian Astrophysical Observation", "SAO 7627"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.04619832),
        dec: Angle.Degrees(+70.78204901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42250"},
        {"Hipparcos Number", "HIP 29761"},
        {"Cincinnati Publication", "Ci 18 769"},
        {"Cincinnati Publication 2", "Ci 20 376"},
        {"Geneva Identification System", "GEN# +1.00042250"},
        {"Smithsonian Astrophysical Observation", "SAO 5793"},
        {"Wilson Evans Batten Catalogue", "WEB 5872"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.01126215),
        dec: Angle.Degrees(+70.78265278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -443.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222405"},
        {"Hipparcos Number", "HIP 116757"},
        {"Smithsonian Astrophysical Observation", "SAO 10821"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.94390778),
        dec: Angle.Degrees(+70.78369782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206730"},
        {"Hipparcos Number", "HIP 107025"},
        {"Smithsonian Astrophysical Observation", "SAO 10118"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13365714),
        dec: Angle.Degrees(+70.78603290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194031"},
        {"Hipparcos Number", "HIP 100073"},
        {"Geneva Identification System", "GEN# +1.00194031"},
        {"Smithsonian Astrophysical Observation", "SAO 9720"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.54403365),
        dec: Angle.Degrees(+70.78662106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157774"},
        {"Hipparcos Number", "HIP 84711"},
        {"Fundamental Katalog 5th Edition", "FK5 3380"},
        {"Geneva Identification System", "GEN# +1.00157774"},
        {"Smithsonian Astrophysical Observation", "SAO 8763"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.73962751),
        dec: Angle.Degrees(+70.78779666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67080"},
        {"Smithsonian Astrophysical Observation", "SAO 7878"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.23291994),
        dec: Angle.Degrees(+70.78845470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16849"},
        {"Smithsonian Astrophysical Observation", "SAO 4948"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.20973344),
        dec: Angle.Degrees(+70.78950547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174205"},
        {"Hipparcos Number", "HIP 91811"},
        {"Smithsonian Astrophysical Observation", "SAO 9222"},
        {"Wilson Evans Batten Catalogue", "WEB 15797"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79309753),
        dec: Angle.Degrees(+70.79286156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70992"},
        {"Smithsonian Astrophysical Observation", "SAO 8039"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80271054),
        dec: Angle.Degrees(+70.79415006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7067 AB"},
        {"Henry Draper", "HD 75632"},
        {"Hipparcos Number", "HIP 43820"},
        {"Cincinnati Publication", "Ci 20 495"},
        {"Cincinnati Publication 2", "Ci 18 1040"},
        {"Geneva Identification System", "GEN# +1.00075632"},
        {"Smithsonian Astrophysical Observation", "SAO 6682"},
        {"Wilson Evans Batten Catalogue", "WEB 8430"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55, 26.5900),
        dec: Angle.DegreesMinutesSeconds((int)+70, (int)47, 41.500)
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
    primaryId: "HIP 80263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148570"},
        {"Hipparcos Number", "HIP 80263"},
        {"Smithsonian Astrophysical Observation", "SAO 8503"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77778823),
        dec: Angle.Degrees(+70.79682338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213290"},
        {"Hipparcos Number", "HIP 110885"},
        {"Smithsonian Astrophysical Observation", "SAO 10378"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.97166016),
        dec: Angle.Degrees(+70.80163521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8224 AB"},
        {"Henry Draper", "HD 100574"},
        {"Hipparcos Number", "HIP 56522"},
        {"Smithsonian Astrophysical Observation", "SAO 7382"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.82669781),
        dec: Angle.Degrees(+70.80242245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50885"},
        {"Hipparcos Number", "HIP 33827"},
        {"Geneva Identification System", "GEN# +1.00050885"},
        {"Smithsonian Astrophysical Observation", "SAO 6041"},
        {"Wilson Evans Batten Catalogue", "WEB 6792"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.33914914),
        dec: Angle.Degrees(+70.80833421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37764"},
        {"Hipparcos Number", "HIP 27337"},
        {"Smithsonian Astrophysical Observation", "SAO 5655"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.85490598),
        dec: Angle.Degrees(+70.81036580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4076 AB"},
        {"Henry Draper", "HD 35598"},
        {"Hipparcos Number", "HIP 25949"},
        {"Smithsonian Astrophysical Observation", "SAO 5559"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.05980427),
        dec: Angle.Degrees(+70.81532924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205372"},
        {"Hipparcos Number", "HIP 106226"},
        {"Smithsonian Astrophysical Observation", "SAO 10069"},
        {"Wilson Evans Batten Catalogue", "WEB 19245"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.74638923),
        dec: Angle.Degrees(+70.82322495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4042"},
        {"Hipparcos Number", "HIP 3445"},
        {"Smithsonian Astrophysical Observation", "SAO 4202"},
        {"Wilson Evans Batten Catalogue", "WEB 608"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.01252779),
        dec: Angle.Degrees(+70.82348009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31607"},
        {"Hipparcos Number", "HIP 23525"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.85924636),
        dec: Angle.Degrees(+70.82497191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202431"},
        {"Hipparcos Number", "HIP 104615"},
        {"Renson", "Renson 56406"},
        {"Smithsonian Astrophysical Observation", "SAO 9982"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.88500978),
        dec: Angle.Degrees(+70.82539753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52493"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.97531390),
        dec: Angle.Degrees(+70.82614223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42347"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.50303391),
        dec: Angle.Degrees(+70.82665439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73135",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9460 AB"},
        {"Henry Draper", "HD 132844"},
        {"Hipparcos Number", "HIP 73135"},
        {"Smithsonian Astrophysical Observation", "SAO 8125"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.19895938),
        dec: Angle.Degrees(+70.83324587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155089"},
        {"Hipparcos Number", "HIP 83442"},
        {"Fundamental Katalog 5th Edition", "FK5 5503"},
        {"Smithsonian Astrophysical Observation", "SAO 8700"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.81523680),
        dec: Angle.Degrees(+70.83422046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168600"},
        {"Hipparcos Number", "HIP 89368"},
        {"Smithsonian Astrophysical Observation", "SAO 9054"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.56008972),
        dec: Angle.Degrees(+70.83444926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147202"},
        {"Hipparcos Number", "HIP 79612"},
        {"Smithsonian Astrophysical Observation", "SAO 8458"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.68429766),
        dec: Angle.Degrees(+70.83678342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95255"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.70553451),
        dec: Angle.Degrees(+74.35791441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87897"},
        {"Hipparcos Number", "HIP 49881"},
        {"Smithsonian Astrophysical Observation", "SAO 7067"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.77607919),
        dec: Angle.Degrees(+70.83997573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99774"},
        {"Cincinnati Publication", "Ci 18 2651"},
        {"Smithsonian Astrophysical Observation", "SAO 9692"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.64581312),
        dec: Angle.Degrees(+70.84294055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27135"},
        {"Hipparcos Number", "HIP 20448"},
        {"Geneva Identification System", "GEN# +1.00027135"},
        {"Smithsonian Astrophysical Observation", "SAO 5179"},
        {"Wilson Evans Batten Catalogue", "WEB 3911"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.71339434),
        dec: Angle.Degrees(+70.84530040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24904"},
        {"Smithsonian Astrophysical Observation", "SAO 5499"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.06847309),
        dec: Angle.Degrees(+70.84556815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58651",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8395 A"},
        {"Henry Draper", "HD 104435"},
        {"Hipparcos Number", "HIP 58651"},
        {"Smithsonian Astrophysical Observation", "SAO 7485"},
        {"Wilson Evans Batten Catalogue", "WEB 10462"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.40789413),
        dec: Angle.Degrees(+70.84983909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108587"},
        {"Smithsonian Astrophysical Observation", "SAO 10220"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.95639677),
        dec: Angle.Degrees(+70.86606895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86839"},
        {"Hipparcos Number", "HIP 49344"},
        {"Cincinnati Publication", "Ci 18 1192"},
        {"Geneva Identification System", "GEN# +1.00086839"},
        {"Smithsonian Astrophysical Observation", "SAO 7042"},
        {"Wilson Evans Batten Catalogue", "WEB 9123"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.09816291),
        dec: Angle.Degrees(+70.86733865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23277"},
        {"Hipparcos Number", "HIP 17854"},
        {"Geneva Identification System", "GEN# +1.00023277"},
        {"Renson", "Renson 5920"},
        {"Smithsonian Astrophysical Observation", "SAO 5000"},
        {"Wilson Evans Batten Catalogue", "WEB 3426"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.30708659),
        dec: Angle.Degrees(+70.87120237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106249"},
        {"Hipparcos Number", "HIP 59587"},
        {"Smithsonian Astrophysical Observation", "SAO 7527"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30154263),
        dec: Angle.Degrees(+70.87604010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30529"},
        {"Hipparcos Number", "HIP 22820"},
        {"Smithsonian Astrophysical Observation", "SAO 5345"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.66179975),
        dec: Angle.Degrees(+70.88039916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116829"},
        {"Smithsonian Astrophysical Observation", "SAO 10829"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.18925686),
        dec: Angle.Degrees(+70.88079756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108500"},
        {"Fundamental Katalog 5th Edition", "FK5 5942"},
        {"Smithsonian Astrophysical Observation", "SAO 10213"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.70779403),
        dec: Angle.Degrees(+70.88525217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68106"},
        {"Smithsonian Astrophysical Observation", "SAO 7914"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.15033468),
        dec: Angle.Degrees(+70.88660568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85417"},
        {"Smithsonian Astrophysical Observation", "SAO 8807"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.81978217),
        dec: Angle.Degrees(+70.88739300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219586"},
        {"Hipparcos Number", "HIP 114831"},
        {"Fundamental Katalog 5th Edition", "FK5 3862"},
        {"Geneva Identification System", "GEN# +1.00219586"},
        {"Smithsonian Astrophysical Observation", "SAO 10671"},
        {"Wilson Evans Batten Catalogue", "WEB 20353"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.90711543),
        dec: Angle.Degrees(+70.88808538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56093"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.47594397),
        dec: Angle.Degrees(+70.89243265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9878 A"},
        {"Henry Draper", "HD 144061"},
        {"Hipparcos Number", "HIP 78217"},
        {"Cincinnati Publication", "Ci 18 2145"},
        {"Geneva Identification System", "GEN# +1.00144061"},
        {"Smithsonian Astrophysical Observation", "SAO 8382"},
        {"Wilson Evans Batten Catalogue", "WEB 13229"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.58805474),
        dec: Angle.Degrees(+70.89382782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 253.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113235"},
        {"Smithsonian Astrophysical Observation", "SAO 10554"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.96787276),
        dec: Angle.Degrees(+70.89901954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1606"},
        {"Smithsonian Astrophysical Observation", "SAO 4093"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.02381117),
        dec: Angle.Degrees(+70.89912723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10403"},
        {"Hipparcos Number", "HIP 8112"},
        {"Smithsonian Astrophysical Observation", "SAO 4478"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.06446970),
        dec: Angle.Degrees(+70.90173795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182270"},
        {"Hipparcos Number", "HIP 94843"},
        {"Smithsonian Astrophysical Observation", "SAO 9375"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.47641781),
        dec: Angle.Degrees(+70.90701853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1598 AB"},
        {"Henry Draper", "HD 12111"},
        {"Hipparcos Number", "HIP 9480"},
        {"Geneva Identification System", "GEN# +1.00012111J"},
        {"Smithsonian Astrophysical Observation", "SAO 4554"},
        {"Wilson Evans Batten Catalogue", "WEB 1986"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.48979079),
        dec: Angle.Degrees(+70.90704605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33573"},
        {"Smithsonian Astrophysical Observation", "SAO 6023"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.64647542),
        dec: Angle.Degrees(+70.91419238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55253"},
        {"Hipparcos Number", "HIP 35368"},
        {"Geneva Identification System", "GEN# +1.00055253"},
        {"Smithsonian Astrophysical Observation", "SAO 6141"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.58713978),
        dec: Angle.Degrees(+70.91938236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224854"},
        {"Hipparcos Number", "HIP 105"},
        {"Geneva Identification System", "GEN# +1.00224854"},
        {"Smithsonian Astrophysical Observation", "SAO 10931"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.32784438),
        dec: Angle.Degrees(+70.92895780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147231"},
        {"Hipparcos Number", "HIP 79619"},
        {"Cincinnati Publication", "Ci 18 2183"},
        {"Geneva Identification System", "GEN# +1.00147231"},
        {"Smithsonian Astrophysical Observation", "SAO 8459"},
        {"Wilson Evans Batten Catalogue", "WEB 13475"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.70938466),
        dec: Angle.Degrees(+70.93035842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6414"},
        {"Hipparcos Number", "HIP 5233"},
        {"Smithsonian Astrophysical Observation", "SAO 4327"},
        {"Wilson Evans Batten Catalogue", "WEB 1097"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.72912007),
        dec: Angle.Degrees(+70.93142932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102616"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91795962),
        dec: Angle.Degrees(+70.93266065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 335.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 536.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149928"},
        {"Hipparcos Number", "HIP 80946"},
        {"Geneva Identification System", "GEN# +1.00149928"},
        {"Smithsonian Astrophysical Observation", "SAO 8543"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.92899815),
        dec: Angle.Degrees(+70.93323241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30085"},
        {"Hipparcos Number", "HIP 22508"},
        {"Fundamental Katalog 5th Edition", "FK5 2358"},
        {"Geneva Identification System", "GEN# +1.00030085"},
        {"Smithsonian Astrophysical Observation", "SAO 5326"},
        {"Wilson Evans Batten Catalogue", "WEB 4340"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.65160710),
        dec: Angle.Degrees(+70.94157737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73991"},
        {"Hipparcos Number", "HIP 43045"},
        {"Smithsonian Astrophysical Observation", "SAO 6632"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.55156179),
        dec: Angle.Degrees(+70.94421963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111420"},
        {"Hipparcos Number", "HIP 62455"},
        {"Geneva Identification System", "GEN# +1.00111420"},
        {"Smithsonian Astrophysical Observation", "SAO 7663"},
        {"Wilson Evans Batten Catalogue", "WEB 11089"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.99724586),
        dec: Angle.Degrees(+70.94658415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98343"},
        {"Hipparcos Number", "HIP 55348"},
        {"Geneva Identification System", "GEN# +1.00098343"},
        {"Smithsonian Astrophysical Observation", "SAO 7337"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01391212),
        dec: Angle.Degrees(+70.94891999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17267"},
        {"Hipparcos Number", "HIP 13263"},
        {"Smithsonian Astrophysical Observation", "SAO 4741"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.65987836),
        dec: Angle.Degrees(+70.94962466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187070"},
        {"Hipparcos Number", "HIP 96928"},
        {"Geneva Identification System", "GEN# +1.00187070"},
        {"Smithsonian Astrophysical Observation", "SAO 9511"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.55218278),
        dec: Angle.Degrees(+70.94973101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184825"},
        {"Hipparcos Number", "HIP 95916"},
        {"Smithsonian Astrophysical Observation", "SAO 9442"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.59706344),
        dec: Angle.Degrees(+70.95146284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15472"},
        {"Hipparcos Number", "HIP 11894"},
        {"Geneva Identification System", "GEN# +1.00015472"},
        {"Smithsonian Astrophysical Observation", "SAO 4673"},
        {"Wilson Evans Batten Catalogue", "WEB 2460"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.36084825),
        dec: Angle.Degrees(+70.95651137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28061"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.99734299),
        dec: Angle.Degrees(+70.96415087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200506"},
        {"Hipparcos Number", "HIP 103592"},
        {"Smithsonian Astrophysical Observation", "SAO 9922"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.84153876),
        dec: Angle.Degrees(+70.96553556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32935"},
        {"Hipparcos Number", "HIP 24307"},
        {"Smithsonian Astrophysical Observation", "SAO 5461"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.24188069),
        dec: Angle.Degrees(+70.97028975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43891"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.12148977),
        dec: Angle.Degrees(+70.97101607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175009"},
        {"Hipparcos Number", "HIP 92160"},
        {"Smithsonian Astrophysical Observation", "SAO 9246"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.75198249),
        dec: Angle.Degrees(+70.97314004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210952"},
        {"Hipparcos Number", "HIP 109517"},
        {"Smithsonian Astrophysical Observation", "SAO 10274"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.77757624),
        dec: Angle.Degrees(+70.97554930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122795"},
        {"Hipparcos Number", "HIP 68449"},
        {"Smithsonian Astrophysical Observation", "SAO 7925"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.20022866),
        dec: Angle.Degrees(+70.97725473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8424"},
        {"Hipparcos Number", "HIP 6685"},
        {"Geneva Identification System", "GEN# +1.00008424"},
        {"Smithsonian Astrophysical Observation", "SAO 4401"},
        {"Wilson Evans Batten Catalogue", "WEB 1459"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.44292737),
        dec: Angle.Degrees(+70.97992123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2904"},
        {"Hipparcos Number", "HIP 2628"},
        {"Fundamental Katalog 5th Edition", "FK5 2034"},
        {"Geneva Identification System", "GEN# +1.00002904"},
        {"Smithsonian Astrophysical Observation", "SAO 4142"},
        {"Wilson Evans Batten Catalogue", "WEB 479"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.33001511),
        dec: Angle.Degrees(+70.98184763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5715"},
        {"Hipparcos Number", "HIP 4709"},
        {"Fundamental Katalog 5th Edition", "FK5 2063"},
        {"Geneva Identification System", "GEN# +1.00005715"},
        {"Smithsonian Astrophysical Observation", "SAO 4288"},
        {"Wilson Evans Batten Catalogue", "WEB 885"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.12861453),
        dec: Angle.Degrees(+70.98300424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184958"},
        {"Hipparcos Number", "HIP 95978"},
        {"Fundamental Katalog 5th Edition", "FK5 3561"},
        {"Geneva Identification System", "GEN# +1.00184958"},
        {"Smithsonian Astrophysical Observation", "SAO 9447"},
        {"Wilson Evans Batten Catalogue", "WEB 16811"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.75121058),
        dec: Angle.Degrees(+70.98925874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205328"},
        {"Hipparcos Number", "HIP 106205"},
        {"Renson", "Renson 57210"},
        {"Smithsonian Astrophysical Observation", "SAO 10066"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.68421020),
        dec: Angle.Degrees(+70.99966696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135594"},
        {"Hipparcos Number", "HIP 74306"},
        {"Smithsonian Astrophysical Observation", "SAO 8187"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.81621066),
        dec: Angle.Degrees(+71.01203844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13138"},
        {"Smithsonian Astrophysical Observation", "SAO 4733"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.24175286),
        dec: Angle.Degrees(+71.02241685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71222"},
        {"Hipparcos Number", "HIP 41808"},
        {"Fundamental Katalog 5th Edition", "FK5 4768"},
        {"Geneva Identification System", "GEN# +1.00071222"},
        {"Smithsonian Astrophysical Observation", "SAO 6563"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.86098749),
        dec: Angle.Degrees(+71.02456544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40497"},
        {"Hipparcos Number", "HIP 28868"},
        {"Smithsonian Astrophysical Observation", "SAO 5737"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.42518944),
        dec: Angle.Degrees(+71.02598870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3187"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13858671),
        dec: Angle.Degrees(+71.02732373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 337.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27081"},
        {"Hipparcos Number", "HIP 20437"},
        {"Smithsonian Astrophysical Observation", "SAO 5178"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.67103527),
        dec: Angle.Degrees(+71.04457720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212825"},
        {"Hipparcos Number", "HIP 110610"},
        {"Smithsonian Astrophysical Observation", "SAO 10352"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.13698452),
        dec: Angle.Degrees(+71.04686410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10484"},
        {"Hipparcos Number", "HIP 8183"},
        {"Smithsonian Astrophysical Observation", "SAO 4480"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.29527956),
        dec: Angle.Degrees(+71.05115571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41385"},
        {"Smithsonian Astrophysical Observation", "SAO 6537"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.64288076),
        dec: Angle.Degrees(+71.05157029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50435",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7705 B"},
        {"Henry Draper", "HD 88850"},
        {"Hipparcos Number", "HIP 50435"},
        {"Geneva Identification System", "GEN# +1.00088850"},
        {"Renson", "Renson 25440"},
        {"Smithsonian Astrophysical Observation", "SAO 7100"},
        {"Wilson Evans Batten Catalogue", "WEB 9255"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.46400601),
        dec: Angle.Degrees(+71.05629730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36210"},
        {"Hipparcos Number", "HIP 26361"},
        {"Smithsonian Astrophysical Observation", "SAO 5582"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.21161740),
        dec: Angle.Degrees(+71.06017513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50433",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7705 A"},
        {"Henry Draper", "HD 88849"},
        {"Hipparcos Number", "HIP 50433"},
        {"Geneva Identification System", "GEN# +1.00088849"},
        {"Renson", "Renson 25430"},
        {"Smithsonian Astrophysical Observation", "SAO 7099"},
        {"Wilson Evans Batten Catalogue", "WEB 9253"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.46089571),
        dec: Angle.Degrees(+71.06080630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155057"},
        {"Hipparcos Number", "HIP 83407"},
        {"Smithsonian Astrophysical Observation", "SAO 8699"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.71903664),
        dec: Angle.Degrees(+71.06148080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53736"},
        {"Smithsonian Astrophysical Observation", "SAO 7257"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.91992915),
        dec: Angle.Degrees(+71.06891962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63347"},
        {"Hipparcos Number", "HIP 38608"},
        {"Renson", "Renson 17473"},
        {"Smithsonian Astrophysical Observation", "SAO 6349"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.58559709),
        dec: Angle.Degrees(+71.07932504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85457"},
        {"Hipparcos Number", "HIP 48660"},
        {"Geneva Identification System", "GEN# +1.00085457"},
        {"Smithsonian Astrophysical Observation", "SAO 6996"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.85015809),
        dec: Angle.Degrees(+71.08102430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61575"},
        {"Smithsonian Astrophysical Observation", "SAO 7612"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.26800831),
        dec: Angle.Degrees(+71.08438429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82171"},
        {"Hipparcos Number", "HIP 46971"},
        {"Smithsonian Astrophysical Observation", "SAO 6895"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.59889264),
        dec: Angle.Degrees(+71.08809010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39356"},
        {"Smithsonian Astrophysical Observation", "SAO 6394"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.67091188),
        dec: Angle.Degrees(+71.09788396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7239"},
        {"Hipparcos Number", "HIP 5816"},
        {"Smithsonian Astrophysical Observation", "SAO 4352"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.66569716),
        dec: Angle.Degrees(+71.10105896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193138"},
        {"Hipparcos Number", "HIP 99640"},
        {"Geneva Identification System", "GEN# +1.00193138"},
        {"Renson", "Renson 53890"},
        {"Smithsonian Astrophysical Observation", "SAO 9683"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.32688773),
        dec: Angle.Degrees(+71.10833886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129753"},
        {"Hipparcos Number", "HIP 71717"},
        {"Smithsonian Astrophysical Observation", "SAO 8068"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.04389884),
        dec: Angle.Degrees(+71.10898517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102881"},
        {"Hipparcos Number", "HIP 57797"},
        {"Smithsonian Astrophysical Observation", "SAO 7435"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.76948166),
        dec: Angle.Degrees(+71.11061260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7360"},
        {"Hipparcos Number", "HIP 5903"},
        {"Smithsonian Astrophysical Observation", "SAO 4355"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.95537797),
        dec: Angle.Degrees(+71.11193857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221131"},
        {"Hipparcos Number", "HIP 115859"},
        {"Smithsonian Astrophysical Observation", "SAO 10747"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.10673930),
        dec: Angle.Degrees(+71.11608696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145197"},
        {"Hipparcos Number", "HIP 78701"},
        {"Smithsonian Astrophysical Observation", "SAO 8411"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.99644589),
        dec: Angle.Degrees(+71.11990950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2464"},
        {"Smithsonian Astrophysical Observation", "SAO 4132"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.82251955),
        dec: Angle.Degrees(+71.12200393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46293"},
        {"Hipparcos Number", "HIP 31808"},
        {"Smithsonian Astrophysical Observation", "SAO 5922"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.75288734),
        dec: Angle.Degrees(+71.12450419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210902"},
        {"Hipparcos Number", "HIP 109479"},
        {"Geneva Identification System", "GEN# +1.00210902"},
        {"Smithsonian Astrophysical Observation", "SAO 10272"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.68239090),
        dec: Angle.Degrees(+71.12842883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8988"},
        {"Hipparcos Number", "HIP 7066"},
        {"Smithsonian Astrophysical Observation", "SAO 4419"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.76083972),
        dec: Angle.Degrees(+71.12992466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41476"},
        {"Hipparcos Number", "HIP 29421"},
        {"Geneva Identification System", "GEN# +1.00041476"},
        {"Smithsonian Astrophysical Observation", "SAO 5774"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.97572069),
        dec: Angle.Degrees(+71.13071708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88490"},
        {"Smithsonian Astrophysical Observation", "SAO 9001"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.03582205),
        dec: Angle.Degrees(+71.13083754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111585"},
        {"Smithsonian Astrophysical Observation", "SAO 10430"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.08762901),
        dec: Angle.Degrees(+71.13364914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100043"},
        {"Smithsonian Astrophysical Observation", "SAO 9716"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.44261130),
        dec: Angle.Degrees(+71.14445567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35654"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.35135955),
        dec: Angle.Degrees(+71.14843972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140342"},
        {"Hipparcos Number", "HIP 76530"},
        {"Smithsonian Astrophysical Observation", "SAO 8300"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.44109771),
        dec: Angle.Degrees(+71.15365096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326"},
        {"Hipparcos Number", "HIP 660"},
        {"Smithsonian Astrophysical Observation", "SAO 4040"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.04168060),
        dec: Angle.Degrees(+71.15948850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3009"},
        {"Smithsonian Astrophysical Observation", "SAO 4167"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.57287209),
        dec: Angle.Degrees(+71.16801107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197442"},
        {"Hipparcos Number", "HIP 101890"},
        {"Smithsonian Astrophysical Observation", "SAO 9833"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.72483919),
        dec: Angle.Degrees(+71.16896345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4652"},
        {"Hipparcos Number", "HIP 3892"},
        {"Smithsonian Astrophysical Observation", "SAO 4241"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.48212259),
        dec: Angle.Degrees(+71.17577038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11111"},
        {"Cincinnati Publication", "Ci 18 298"},
        {"Cincinnati Publication 2", "Ci 20 167"},
        {"Cincinnati Publication 3", "Ci 16 298"},
        {"Geneva Identification System", "GEN# +0.07000169"},
        {"Smithsonian Astrophysical Observation", "SAO 4632"},
        {"Wilson Evans Batten Catalogue", "WEB 2337"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.74880964),
        dec: Angle.Degrees(+71.17732665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 533.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115868"},
        {"Smithsonian Astrophysical Observation", "SAO 10748"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.12821976),
        dec: Angle.Degrees(+71.18718634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16332"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.63414692),
        dec: Angle.Degrees(+71.19207610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34803"},
        {"Hipparcos Number", "HIP 25447"},
        {"Smithsonian Astrophysical Observation", "SAO 5528"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.63766284),
        dec: Angle.Degrees(+71.19299131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29340"},
        {"Hipparcos Number", "HIP 21974"},
        {"Smithsonian Astrophysical Observation", "SAO 5284"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.84853324),
        dec: Angle.Degrees(+71.19400698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62627"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.48592497),
        dec: Angle.Degrees(+71.19468436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34082"},
        {"Cincinnati Publication", "Ci 20 406"},
        {"Cincinnati Publication 2", "Ci 18 845"},
        {"Smithsonian Astrophysical Observation", "SAO 6058"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01249642),
        dec: Angle.Degrees(+71.19587277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -410.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86804"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06397781),
        dec: Angle.Degrees(+71.19733449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136727"},
        {"Hipparcos Number", "HIP 74806"},
        {"Geneva Identification System", "GEN# +1.00136727"},
        {"Smithsonian Astrophysical Observation", "SAO 8208"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.32006331),
        dec: Angle.Degrees(+71.21119907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12350"},
        {"Hipparcos Number", "HIP 9665"},
        {"Geneva Identification System", "GEN# +1.00012350"},
        {"Smithsonian Astrophysical Observation", "SAO 4563"},
        {"Wilson Evans Batten Catalogue", "WEB 2027"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.07957122),
        dec: Angle.Degrees(+71.21150342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39645"},
        {"Smithsonian Astrophysical Observation", "SAO 6416"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51830561),
        dec: Angle.Degrees(+71.21255882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26220"},
        {"Hipparcos Number", "HIP 19802"},
        {"Smithsonian Astrophysical Observation", "SAO 5131"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.68154520),
        dec: Angle.Degrees(+71.21543478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24985",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3875 A"},
        {"Henry Draper", "HD 34061"},
        {"Hipparcos Number", "HIP 24985"},
        {"Geneva Identification System", "GEN# +1.00034061"},
        {"Smithsonian Astrophysical Observation", "SAO 5502"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.25317811),
        dec: Angle.Degrees(+71.22096875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62921"},
        {"Hipparcos Number", "HIP 38412"},
        {"Smithsonian Astrophysical Observation", "SAO 6333"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.04307035),
        dec: Angle.Degrees(+71.22647479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58359"},
        {"Hipparcos Number", "HIP 36575"},
        {"Smithsonian Astrophysical Observation", "SAO 6219"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.84988926),
        dec: Angle.Degrees(+71.23608901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118904"},
        {"Hipparcos Number", "HIP 66435"},
        {"Fundamental Katalog 5th Edition", "FK5 505"},
        {"Geneva Identification System", "GEN# +1.00118904"},
        {"Smithsonian Astrophysical Observation", "SAO 7854"},
        {"Wilson Evans Batten Catalogue", "WEB 11729"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.29605970),
        dec: Angle.Degrees(+71.24226650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1709"},
        {"Hipparcos Number", "HIP 1733"},
        {"Smithsonian Astrophysical Observation", "SAO 4099"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.47862916),
        dec: Angle.Degrees(+71.24425334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53480"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.10261610),
        dec: Angle.Degrees(+71.24459430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115849"},
        {"Hipparcos Number", "HIP 64856"},
        {"Geneva Identification System", "GEN# +1.00115849"},
        {"Smithsonian Astrophysical Observation", "SAO 7790"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40640698),
        dec: Angle.Degrees(+71.24661794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160077"},
        {"Hipparcos Number", "HIP 85762"},
        {"Smithsonian Astrophysical Observation", "SAO 8830"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.86534880),
        dec: Angle.Degrees(+71.24797290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50842"},
        {"Smithsonian Astrophysical Observation", "SAO 7125"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71970273),
        dec: Angle.Degrees(+71.25875253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43203"},
        {"Hipparcos Number", "HIP 30224"},
        {"Smithsonian Astrophysical Observation", "SAO 5821"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.38519993),
        dec: Angle.Degrees(+71.26041250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66285"},
        {"Hipparcos Number", "HIP 39854"},
        {"Geneva Identification System", "GEN# +1.00066285"},
        {"Smithsonian Astrophysical Observation", "SAO 6425"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.13204906),
        dec: Angle.Degrees(+71.26977620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159711"},
        {"Hipparcos Number", "HIP 85612"},
        {"Smithsonian Astrophysical Observation", "SAO 8818"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.42259506),
        dec: Angle.Degrees(+71.27031332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20523"},
        {"Hipparcos Number", "HIP 15754"},
        {"Geneva Identification System", "GEN# +1.00020523"},
        {"Smithsonian Astrophysical Observation", "SAO 4891"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.74044939),
        dec: Angle.Degrees(+71.28056653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10336"},
        {"Smithsonian Astrophysical Observation", "SAO 4600"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.29692695),
        dec: Angle.Degrees(+71.28524424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153165"},
        {"Hipparcos Number", "HIP 82491"},
        {"Smithsonian Astrophysical Observation", "SAO 8639"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88904483),
        dec: Angle.Degrees(+71.28596506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38438"},
        {"Hipparcos Number", "HIP 27730"},
        {"Fundamental Katalog 5th Edition", "FK5 2436"},
        {"Geneva Identification System", "GEN# +1.00038438"},
        {"Smithsonian Astrophysical Observation", "SAO 5673"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07206073),
        dec: Angle.Degrees(+71.28940689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42956"},
        {"Smithsonian Astrophysical Observation", "SAO 6627"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.34239005),
        dec: Angle.Degrees(+71.29285117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15533"},
        {"Hipparcos Number", "HIP 11930"},
        {"Fundamental Katalog 5th Edition", "FK5 2175"},
        {"Geneva Identification System", "GEN# +1.00015533"},
        {"Smithsonian Astrophysical Observation", "SAO 4677"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.49314401),
        dec: Angle.Degrees(+71.29441507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10374"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41866724),
        dec: Angle.Degrees(+71.29506722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176524"},
        {"Hipparcos Number", "HIP 92782"},
        {"Fundamental Katalog 5th Edition", "FK5 714"},
        {"Geneva Identification System", "GEN# +1.00176524"},
        {"Smithsonian Astrophysical Observation", "SAO 9283"},
        {"Wilson Evans Batten Catalogue", "WEB 16055"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.59902616),
        dec: Angle.Degrees(+71.29708956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109051"},
        {"Hipparcos Number", "HIP 61058"},
        {"Smithsonian Astrophysical Observation", "SAO 7575"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.72345033),
        dec: Angle.Degrees(+71.29995848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212775"},
        {"Hipparcos Number", "HIP 110588"},
        {"Smithsonian Astrophysical Observation", "SAO 10349"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.06090544),
        dec: Angle.Degrees(+71.30087679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12235"},
        {"Geneva Identification System", "GEN# +0.07000193"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.38154792),
        dec: Angle.Degrees(+71.30447257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76905"},
        {"Hipparcos Number", "HIP 44499"},
        {"Geneva Identification System", "GEN# +1.00076905"},
        {"Smithsonian Astrophysical Observation", "SAO 6729"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99324802),
        dec: Angle.Degrees(+71.30553913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26971"},
        {"Hipparcos Number", "HIP 20377"},
        {"Smithsonian Astrophysical Observation", "SAO 5175"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.45042312),
        dec: Angle.Degrees(+71.30728287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146508"},
        {"Hipparcos Number", "HIP 79284"},
        {"Geneva Identification System", "GEN# +1.00146508"},
        {"Smithsonian Astrophysical Observation", "SAO 8443"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.72284216),
        dec: Angle.Degrees(+71.30735970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206554"},
        {"Hipparcos Number", "HIP 106914"},
        {"Geneva Identification System", "GEN# +1.00206554"},
        {"Smithsonian Astrophysical Observation", "SAO 10113"},
        {"Wilson Evans Batten Catalogue", "WEB 19321"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.79127478),
        dec: Angle.Degrees(+71.30906145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114297"},
        {"Smithsonian Astrophysical Observation", "SAO 10631"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.22314299),
        dec: Angle.Degrees(+71.31031110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206952"},
        {"Hipparcos Number", "HIP 107119"},
        {"Fundamental Katalog 5th Edition", "FK5 817"},
        {"Geneva Identification System", "GEN# +1.00206952"},
        {"Smithsonian Astrophysical Observation", "SAO 10126"},
        {"Wilson Evans Batten Catalogue", "WEB 19348"},
    },
    visualMagnitude: 4.55,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.47948373),
        dec: Angle.Degrees(+71.31118695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6543"},
        {"Smithsonian Astrophysical Observation", "SAO 4394"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.02293414),
        dec: Angle.Degrees(+71.31290302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201249"},
        {"Hipparcos Number", "HIP 103948"},
        {"Smithsonian Astrophysical Observation", "SAO 9944"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.92905179),
        dec: Angle.Degrees(+71.31426205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109384"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.40405809),
        dec: Angle.Degrees(+71.31454447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45897"},
        {"Hipparcos Number", "HIP 31600"},
        {"Smithsonian Astrophysical Observation", "SAO 5901"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.20325750),
        dec: Angle.Degrees(+71.32866586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86340"},
        {"Cincinnati Publication", "Ci 18 2361"},
        {"Geneva Identification System", "GEN# +0.07100851"},
        {"Smithsonian Astrophysical Observation", "SAO 8866"},
        {"Wilson Evans Batten Catalogue", "WEB 14567"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.64302793),
        dec: Angle.Degrees(+71.33155313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 314.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23401"},
        {"Hipparcos Number", "HIP 17959"},
        {"Fundamental Katalog 5th Edition", "FK5 138"},
        {"Geneva Identification System", "GEN# +1.00023401"},
        {"Smithsonian Astrophysical Observation", "SAO 5006"},
        {"Wilson Evans Batten Catalogue", "WEB 3458"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.58948256),
        dec: Angle.Degrees(+71.33236777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28320"},
        {"Smithsonian Astrophysical Observation", "SAO 5707"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.75113346),
        dec: Angle.Degrees(+71.33408811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89908",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11311 AB"},
        {"Henry Draper", "HD 170000"},
        {"Hipparcos Number", "HIP 89908"},
        {"Geneva Identification System", "GEN# +1.00170000"},
        {"Renson", "Renson 47620"},
        {"Smithsonian Astrophysical Observation", "SAO 9084"},
        {"Wilson Evans Batten Catalogue", "WEB 15353"},
    },
    visualMagnitude: 4.22,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.18933831),
        dec: Angle.Degrees(+71.33772734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11462 AB"},
        {"Hipparcos Number", "HIP 90829"},
        {"Smithsonian Astrophysical Observation", "SAO 9153"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.93555478),
        dec: Angle.Degrees(+71.33934537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138301"},
        {"Hipparcos Number", "HIP 75539"},
        {"Smithsonian Astrophysical Observation", "SAO 8248"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.48600135),
        dec: Angle.Degrees(+71.33958406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28516"},
        {"Hipparcos Number", "HIP 21419"},
        {"Smithsonian Astrophysical Observation", "SAO 5254"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.96137662),
        dec: Angle.Degrees(+71.34225156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25528"},
        {"Hipparcos Number", "HIP 19377"},
        {"Smithsonian Astrophysical Observation", "SAO 5105"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.26299482),
        dec: Angle.Degrees(+71.34368596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214555"},
        {"Hipparcos Number", "HIP 111604"},
        {"Smithsonian Astrophysical Observation", "SAO 10435"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15371127),
        dec: Angle.Degrees(+71.34434840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45082"},
        {"Smithsonian Astrophysical Observation", "SAO 6769"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.75329182),
        dec: Angle.Degrees(+71.34594213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35542"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01541761),
        dec: Angle.Degrees(+71.34637346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182189"},
        {"Hipparcos Number", "HIP 94802"},
        {"Geneva Identification System", "GEN# +1.00182189"},
        {"Smithsonian Astrophysical Observation", "SAO 9371"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.34291458),
        dec: Angle.Degrees(+71.34713536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142924"},
        {"Hipparcos Number", "HIP 77692"},
        {"Smithsonian Astrophysical Observation", "SAO 8354"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.92362642),
        dec: Angle.Degrees(+71.34913635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216877"},
        {"Hipparcos Number", "HIP 113157"},
        {"Geneva Identification System", "GEN# +1.00216877"},
        {"Smithsonian Astrophysical Observation", "SAO 10545"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.71546133),
        dec: Angle.Degrees(+71.35550857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57571"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.00819640),
        dec: Angle.Degrees(+71.35786786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225044"},
        {"Hipparcos Number", "HIP 233"},
        {"Smithsonian Astrophysical Observation", "SAO 4017"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73197615),
        dec: Angle.Degrees(+71.35854324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86637"},
        {"Hipparcos Number", "HIP 49235"},
        {"Smithsonian Astrophysical Observation", "SAO 7038"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.76491649),
        dec: Angle.Degrees(+71.36305820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58545"},
        {"Hipparcos Number", "HIP 36645"},
        {"Smithsonian Astrophysical Observation", "SAO 6226"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.04920952),
        dec: Angle.Degrees(+71.36372884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78103"},
        {"Hipparcos Number", "HIP 45084"},
        {"Smithsonian Astrophysical Observation", "SAO 6770"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.75996275),
        dec: Angle.Degrees(+71.36433650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3891"},
        {"Hipparcos Number", "HIP 3348"},
        {"Smithsonian Astrophysical Observation", "SAO 4191"},
        {"Wilson Evans Batten Catalogue", "WEB 593"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.66670323),
        dec: Angle.Degrees(+71.36590704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 235"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73646864),
        dec: Angle.Degrees(+71.36804423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81825"},
        {"Smithsonian Astrophysical Observation", "SAO 8603"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.70950778),
        dec: Angle.Degrees(+71.37024862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101685"},
        {"Hipparcos Number", "HIP 57123"},
    },
    visualMagnitude: 9.89,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.67612092),
        dec: Angle.Degrees(+71.37764219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201833"},
        {"Hipparcos Number", "HIP 104302"},
        {"Smithsonian Astrophysical Observation", "SAO 9965"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.94544529),
        dec: Angle.Degrees(+71.38181233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30933"},
        {"Hipparcos Number", "HIP 23091"},
        {"Smithsonian Astrophysical Observation", "SAO 5367"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54407897),
        dec: Angle.Degrees(+71.38345806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148941"},
        {"Hipparcos Number", "HIP 80467"},
        {"Geneva Identification System", "GEN# +1.00148941"},
        {"Smithsonian Astrophysical Observation", "SAO 8513"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.37162177),
        dec: Angle.Degrees(+71.38465537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114215"},
        {"Hipparcos Number", "HIP 64029"},
        {"Smithsonian Astrophysical Observation", "SAO 7751"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.82719772),
        dec: Angle.Degrees(+71.39430360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191489"},
        {"Hipparcos Number", "HIP 98865"},
        {"Smithsonian Astrophysical Observation", "SAO 9626"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.15676550),
        dec: Angle.Degrees(+71.40797430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20566"},
        {"Hipparcos Number", "HIP 15796"},
        {"Smithsonian Astrophysical Observation", "SAO 4896"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.88792470),
        dec: Angle.Degrees(+71.41854715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44323"},
        {"Smithsonian Astrophysical Observation", "SAO 6712"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.40353341),
        dec: Angle.Degrees(+71.42551740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206616"},
        {"Hipparcos Number", "HIP 106948"},
        {"Smithsonian Astrophysical Observation", "SAO 10115"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.90411694),
        dec: Angle.Degrees(+71.42624097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201636"},
        {"Hipparcos Number", "HIP 104171"},
        {"Fundamental Katalog 5th Edition", "FK5 3693"},
        {"Geneva Identification System", "GEN# +1.00201636"},
        {"Smithsonian Astrophysical Observation", "SAO 9957"},
        {"Wilson Evans Batten Catalogue", "WEB 18977"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.59746974),
        dec: Angle.Degrees(+71.43207905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3882"},
        {"Smithsonian Astrophysical Observation", "SAO 4240"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.45832119),
        dec: Angle.Degrees(+71.43267263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83868"},
        {"Hipparcos Number", "HIP 47843"},
        {"Smithsonian Astrophysical Observation", "SAO 6952"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.27377404),
        dec: Angle.Degrees(+71.43550279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60234"},
        {"Smithsonian Astrophysical Observation", "SAO 7547"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.27773372),
        dec: Angle.Degrees(+71.43962926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97551"},
        {"Smithsonian Astrophysical Observation", "SAO 9549"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.41658278),
        dec: Angle.Degrees(+71.44369936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73443"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.12703361),
        dec: Angle.Degrees(+71.44706333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56195"},
        {"Smithsonian Astrophysical Observation", "SAO 7368"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.79457391),
        dec: Angle.Degrees(+71.45091738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51803"},
        {"Hipparcos Number", "HIP 34171"},
        {"Smithsonian Astrophysical Observation", "SAO 6068"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.29966011),
        dec: Angle.Degrees(+71.45901514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70192"},
        {"Smithsonian Astrophysical Observation", "SAO 7998"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.41179457),
        dec: Angle.Degrees(+71.46033614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78177"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.43933072),
        dec: Angle.Degrees(+71.46148645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154159"},
        {"Hipparcos Number", "HIP 82964"},
        {"Geneva Identification System", "GEN# +1.00154159"},
        {"Smithsonian Astrophysical Observation", "SAO 8671"},
        {"Wilson Evans Batten Catalogue", "WEB 14027"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.30704545),
        dec: Angle.Degrees(+71.46301761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31217"},
        {"Hipparcos Number", "HIP 23271"},
        {"Smithsonian Astrophysical Observation", "SAO 5381"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10237397),
        dec: Angle.Degrees(+71.46503290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28760"},
        {"Hipparcos Number", "HIP 21587"},
        {"Smithsonian Astrophysical Observation", "SAO 5263"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.53722302),
        dec: Angle.Degrees(+71.46999709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21598"},
    },
    visualMagnitude: 10.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.55181637),
        dec: Angle.Degrees(+71.47584462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50975"},
        {"Smithsonian Astrophysical Observation", "SAO 7135"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.18603027),
        dec: Angle.Degrees(+71.48668326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223951"},
        {"Hipparcos Number", "HIP 117812"},
        {"Smithsonian Astrophysical Observation", "SAO 10886"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.40910099),
        dec: Angle.Degrees(+71.49057946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180003"},
        {"Hipparcos Number", "HIP 94015"},
        {"Smithsonian Astrophysical Observation", "SAO 9332"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.11314714),
        dec: Angle.Degrees(+71.49525474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223265"},
        {"Hipparcos Number", "HIP 117355"},
        {"Smithsonian Astrophysical Observation", "SAO 10859"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.92814630),
        dec: Angle.Degrees(+71.49612615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19109"},
        {"Hipparcos Number", "HIP 14654"},
        {"Smithsonian Astrophysical Observation", "SAO 4835"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34152154),
        dec: Angle.Degrees(+71.50782348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1731"},
        {"Hipparcos Number", "HIP 1756"},
        {"Smithsonian Astrophysical Observation", "SAO 4101"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.55966033),
        dec: Angle.Degrees(+71.50815650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177875"},
        {"Hipparcos Number", "HIP 93294"},
        {"Smithsonian Astrophysical Observation", "SAO 9299"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.04141841),
        dec: Angle.Degrees(+71.51086852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125641"},
        {"Hipparcos Number", "HIP 69808"},
        {"Smithsonian Astrophysical Observation", "SAO 7978"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.29620084),
        dec: Angle.Degrees(+71.51116073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201088"},
        {"Hipparcos Number", "HIP 103875"},
        {"Smithsonian Astrophysical Observation", "SAO 9940"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.72550154),
        dec: Angle.Degrees(+71.51431316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169666"},
        {"Hipparcos Number", "HIP 89770"},
        {"Geneva Identification System", "GEN# +1.00169666"},
        {"Smithsonian Astrophysical Observation", "SAO 9072"},
        {"Wilson Evans Batten Catalogue", "WEB 15310"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.78479832),
        dec: Angle.Degrees(+71.51776438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18855"},
        {"Hipparcos Number", "HIP 14474"},
        {"Smithsonian Astrophysical Observation", "SAO 4823"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.70101762),
        dec: Angle.Degrees(+71.52029926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99187"},
        {"Smithsonian Astrophysical Observation", "SAO 9654"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03916265),
        dec: Angle.Degrees(+71.52660008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94582"},
        {"Cincinnati Publication", "Ci 18 2525"},
        {"Smithsonian Astrophysical Observation", "SAO 9360"},
        {"Wilson Evans Batten Catalogue", "WEB 16482"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.73092958),
        dec: Angle.Degrees(+71.52876821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61201"},
        {"Smithsonian Astrophysical Observation", "SAO 7586"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.12120277),
        dec: Angle.Degrees(+71.53945030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32442"},
        {"Hipparcos Number", "HIP 24024"},
        {"Smithsonian Astrophysical Observation", "SAO 5445"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.44455888),
        dec: Angle.Degrees(+71.54428923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216035"},
        {"Hipparcos Number", "HIP 112509"},
        {"Geneva Identification System", "GEN# +1.00216035"},
        {"Smithsonian Astrophysical Observation", "SAO 10499"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.84695207),
        dec: Angle.Degrees(+71.54837825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12800"},
        {"Hipparcos Number", "HIP 10031"},
        {"Geneva Identification System", "GEN# +1.00012800"},
        {"Smithsonian Astrophysical Observation", "SAO 4588"},
        {"Wilson Evans Batten Catalogue", "WEB 2101"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.28206230),
        dec: Angle.Degrees(+71.55258863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 308.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9222"},
        {"Hipparcos Number", "HIP 7248"},
        {"Geneva Identification System", "GEN# +1.00009222"},
        {"Smithsonian Astrophysical Observation", "SAO 4430"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.34768849),
        dec: Angle.Degrees(+71.55456442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14944",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2377 AB"},
        {"Henry Draper", "HD 19475"},
        {"Hipparcos Number", "HIP 14944"},
        {"Smithsonian Astrophysical Observation", "SAO 4846"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.16292866),
        dec: Angle.Degrees(+71.55575001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41934"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22905084),
        dec: Angle.Degrees(+71.55884742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101337"},
        {"Smithsonian Astrophysical Observation", "SAO 9805"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.08198555),
        dec: Angle.Degrees(+71.56085028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63920"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.49220798),
        dec: Angle.Degrees(+71.56279464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8255"},
        {"Geneva Identification System", "GEN# +5.14630012"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.56869220),
        dec: Angle.Degrees(+71.56730859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6598"},
        {"Smithsonian Astrophysical Observation", "SAO 4398"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.18317436),
        dec: Angle.Degrees(+71.56994493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112125"},
        {"Hipparcos Number", "HIP 62848"},
        {"Geneva Identification System", "GEN# +1.00112125"},
        {"Smithsonian Astrophysical Observation", "SAO 7686"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.20859243),
        dec: Angle.Degrees(+71.57153308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50014"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.15952682),
        dec: Angle.Degrees(+71.57636699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70983"},
        {"Hipparcos Number", "HIP 41715"},
        {"Geneva Identification System", "GEN# +1.00070983"},
        {"Smithsonian Astrophysical Observation", "SAO 6553"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.59877574),
        dec: Angle.Degrees(+71.57768384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104112"},
        {"Hipparcos Number", "HIP 58483"},
        {"Geneva Identification System", "GEN# +1.00104112"},
        {"Smithsonian Astrophysical Observation", "SAO 7472"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.89798240),
        dec: Angle.Degrees(+71.57823635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128546"},
        {"Hipparcos Number", "HIP 71174"},
        {"Geneva Identification System", "GEN# +1.00128546"},
        {"Smithsonian Astrophysical Observation", "SAO 8048"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.35000467),
        dec: Angle.Degrees(+71.58114359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17442"},
        {"Hipparcos Number", "HIP 13390"},
        {"Smithsonian Astrophysical Observation", "SAO 4748"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.08626048),
        dec: Angle.Degrees(+71.58288217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160228"},
        {"Hipparcos Number", "HIP 85828"},
        {"Smithsonian Astrophysical Observation", "SAO 8833"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.06494533),
        dec: Angle.Degrees(+71.58579277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58985"},
        {"Hipparcos Number", "HIP 36811"},
        {"Smithsonian Astrophysical Observation", "SAO 6238"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.56121420),
        dec: Angle.Degrees(+71.59017346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131207"},
        {"Hipparcos Number", "HIP 72358"},
        {"Geneva Identification System", "GEN# +1.00131207"},
        {"Smithsonian Astrophysical Observation", "SAO 8085"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93688711),
        dec: Angle.Degrees(+71.60125652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157439"},
        {"Hipparcos Number", "HIP 84516"},
        {"Smithsonian Astrophysical Observation", "SAO 8751"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.15666867),
        dec: Angle.Degrees(+71.60166740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96264",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12690 AB"},
        {"Henry Draper", "HD 185713"},
        {"Hipparcos Number", "HIP 96264"},
        {"Renson", "Renson 51240"},
        {"Smithsonian Astrophysical Observation", "SAO 9467"},
        {"Wilson Evans Batten Catalogue", "WEB 16872"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.60492808),
        dec: Angle.Degrees(+71.60552976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29872"},
        {"Smithsonian Astrophysical Observation", "SAO 5802"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.34232046),
        dec: Angle.Degrees(+71.60690466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31096"},
        {"Hipparcos Number", "HIP 23195"},
        {"Smithsonian Astrophysical Observation", "SAO 5376"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.87232052),
        dec: Angle.Degrees(+71.60792557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208361"},
        {"Hipparcos Number", "HIP 107966"},
        {"Smithsonian Astrophysical Observation", "SAO 10184"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.10196348),
        dec: Angle.Degrees(+71.60922056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97190"},
        {"Hipparcos Number", "HIP 54773"},
        {"Smithsonian Astrophysical Observation", "SAO 7309"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.20214501),
        dec: Angle.Degrees(+71.61307274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17602",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2718 A"},
        {"Henry Draper", "HD 22912"},
        {"Hipparcos Number", "HIP 17602"},
        {"Geneva Identification System", "GEN# +1.00022912"},
        {"Smithsonian Astrophysical Observation", "SAO 4984"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.55785649),
        dec: Angle.Degrees(+71.61810704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16383"},
        {"Hipparcos Number", "HIP 12592"},
        {"Smithsonian Astrophysical Observation", "SAO 4709"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.48486374),
        dec: Angle.Degrees(+71.62640420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22289"},
        {"Hipparcos Number", "HIP 17178"},
        {"Smithsonian Astrophysical Observation", "SAO 4963"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.19051847),
        dec: Angle.Degrees(+71.63328276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165500"},
        {"Hipparcos Number", "HIP 88102"},
        {"Smithsonian Astrophysical Observation", "SAO 8974"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90360964),
        dec: Angle.Degrees(+71.63411378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4880"},
        {"Hipparcos Number", "HIP 4080"},
        {"Smithsonian Astrophysical Observation", "SAO 4254"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.07839405),
        dec: Angle.Degrees(+71.63830124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221861"},
        {"Hipparcos Number", "HIP 116380"},
        {"Fundamental Katalog 5th Edition", "FK5 3893"},
        {"Geneva Identification System", "GEN# +1.00221861"},
        {"Smithsonian Astrophysical Observation", "SAO 10790"},
        {"Wilson Evans Batten Catalogue", "WEB 20561"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.74596038),
        dec: Angle.Degrees(+71.64204906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26851",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4238 B"},
        {"Hipparcos Number", "HIP 26851"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.51017415),
        dec: Angle.Degrees(+71.64380717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4238 A"},
        {"Henry Draper", "HD 36990"},
        {"Hipparcos Number", "HIP 26847"},
        {"Smithsonian Astrophysical Observation", "SAO 5616"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.50295246),
        dec: Angle.Degrees(+71.64575812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27753"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11549273),
        dec: Angle.Degrees(+71.65245652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36357"},
        {"Hipparcos Number", "HIP 26474"},
        {"Geneva Identification System", "GEN# +1.00036357"},
        {"Smithsonian Astrophysical Observation", "SAO 5587"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.46721467),
        dec: Angle.Degrees(+71.65447438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78633"},
        {"Hipparcos Number", "HIP 45306"},
        {"Fundamental Katalog 5th Edition", "FK5 2729"},
        {"Geneva Identification System", "GEN# +1.00078633"},
        {"Smithsonian Astrophysical Observation", "SAO 6784"},
        {"Wilson Evans Batten Catalogue", "WEB 8630"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.51353764),
        dec: Angle.Degrees(+71.65592451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93148"},
        {"Hipparcos Number", "HIP 52796"},
        {"Geneva Identification System", "GEN# +1.00093148"},
        {"Smithsonian Astrophysical Observation", "SAO 7206"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.91022710),
        dec: Angle.Degrees(+71.65595921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79608"},
        {"Hipparcos Number", "HIP 45750"},
        {"Smithsonian Astrophysical Observation", "SAO 6818"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.93724074),
        dec: Angle.Degrees(+71.66100482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32696"},
        {"Hipparcos Number", "HIP 24185"},
        {"Smithsonian Astrophysical Observation", "SAO 5453"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.89323030),
        dec: Angle.Degrees(+71.66287727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72726"},
        {"Cincinnati Publication", "Ci 20 897"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.03789372),
        dec: Angle.Degrees(+71.66346741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -868.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -409.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27758"},
        {"Hipparcos Number", "HIP 20918"},
        {"Smithsonian Astrophysical Observation", "SAO 5210"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.25574379),
        dec: Angle.Degrees(+71.66382220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104601"},
        {"Geneva Identification System", "GEN# +0.07101053"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.84392772),
        dec: Angle.Degrees(+71.66686978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 234.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77267"},
        {"Smithsonian Astrophysical Observation", "SAO 8333"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.63180198),
        dec: Angle.Degrees(+71.66725300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211693"},
        {"Hipparcos Number", "HIP 109935"},
        {"Smithsonian Astrophysical Observation", "SAO 10296"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.99009878),
        dec: Angle.Degrees(+71.66995347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37393"},
        {"Smithsonian Astrophysical Observation", "SAO 6267"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.13352104),
        dec: Angle.Degrees(+71.67463653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63887"},
        {"Hipparcos Number", "HIP 38857"},
        {"Smithsonian Astrophysical Observation", "SAO 6364"},
        {"Wilson Evans Batten Catalogue", "WEB 7608"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.28159028),
        dec: Angle.Degrees(+71.68015992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4856"},
        {"Cincinnati Publication", "Ci 20 66"},
        {"Geneva Identification System", "GEN# +9.80242076"},
        {"Geneva Identification System 2", "GEN# +0.07000068"},
        {"Wilson Evans Batten Catalogue", "WEB 928"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.62080367),
        dec: Angle.Degrees(+71.68074123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1745.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -380.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85213"},
        {"Hipparcos Number", "HIP 48545"},
        {"Smithsonian Astrophysical Observation", "SAO 6990"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.51071306),
        dec: Angle.Degrees(+71.68144078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95993"},
        {"Smithsonian Astrophysical Observation", "SAO 9449"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77873524),
        dec: Angle.Degrees(+71.68154494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201817"},
        {"Hipparcos Number", "HIP 104284"},
        {"Geneva Identification System", "GEN# +1.00201817"},
        {"Smithsonian Astrophysical Observation", "SAO 9963"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.90263655),
        dec: Angle.Degrees(+71.68177160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205284"},
        {"Hipparcos Number", "HIP 106167"},
        {"Smithsonian Astrophysical Observation", "SAO 10064"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.57391739),
        dec: Angle.Degrees(+71.68406870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20710"},
        {"Hipparcos Number", "HIP 15959"},
        {"Geneva Identification System", "GEN# +1.00020710"},
        {"Smithsonian Astrophysical Observation", "SAO 4902"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.36102220),
        dec: Angle.Degrees(+71.68477181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87582"},
        {"Hipparcos Number", "HIP 49733"},
        {"Smithsonian Astrophysical Observation", "SAO 7058"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.29176186),
        dec: Angle.Degrees(+71.68771822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8154"},
        {"Geneva Identification System", "GEN# +5.14630017"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.21819744),
        dec: Angle.Degrees(+71.69083407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212310"},
        {"Hipparcos Number", "HIP 110318"},
        {"Smithsonian Astrophysical Observation", "SAO 10325"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16571392),
        dec: Angle.Degrees(+71.69209504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31947"},
        {"Smithsonian Astrophysical Observation", "SAO 5926"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.13844112),
        dec: Angle.Degrees(+71.70023557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77005"},
        {"Hipparcos Number", "HIP 44536"},
        {"Geneva Identification System", "GEN# +1.00077005"},
        {"Smithsonian Astrophysical Observation", "SAO 6732"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.11504568),
        dec: Angle.Degrees(+71.70139715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34004"},
        {"Hipparcos Number", "HIP 24948"},
        {"Fundamental Katalog 5th Edition", "FK5 2396"},
        {"Geneva Identification System", "GEN# +1.00034004"},
        {"Smithsonian Astrophysical Observation", "SAO 5501"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15973223),
        dec: Angle.Degrees(+71.71471793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66011"},
        {"Smithsonian Astrophysical Observation", "SAO 7837"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.00676436),
        dec: Angle.Degrees(+71.71704246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28304"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72338555),
        dec: Angle.Degrees(+71.71823810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66020"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.02379182),
        dec: Angle.Degrees(+71.71885708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113592"},
        {"Hipparcos Number", "HIP 63675"},
        {"Geneva Identification System", "GEN# +1.00113592"},
        {"Smithsonian Astrophysical Observation", "SAO 7731"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.74690997),
        dec: Angle.Degrees(+71.72054708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16906"},
        {"Hipparcos Number", "HIP 12996"},
        {"Geneva Identification System", "GEN# +1.00016906"},
        {"Smithsonian Astrophysical Observation", "SAO 4728"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.77991118),
        dec: Angle.Degrees(+71.72270098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11609"},
        {"Hipparcos Number", "HIP 9097"},
        {"Smithsonian Astrophysical Observation", "SAO 4522"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.29609705),
        dec: Angle.Degrees(+71.72497288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36144"},
        {"Smithsonian Astrophysical Observation", "SAO 6192"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.67761237),
        dec: Angle.Degrees(+71.72970508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112232"},
        {"Hipparcos Number", "HIP 62926"},
        {"Smithsonian Astrophysical Observation", "SAO 7690"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42887274),
        dec: Angle.Degrees(+71.73066610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171044"},
        {"Hipparcos Number", "HIP 90335"},
        {"Geneva Identification System", "GEN# +1.00171044"},
        {"Smithsonian Astrophysical Observation", "SAO 9124"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.47602728),
        dec: Angle.Degrees(+71.73164482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8487"},
        {"Geneva Identification System", "GEN# +5.14630007"},
        {"Smithsonian Astrophysical Observation", "SAO 4497"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.36078918),
        dec: Angle.Degrees(+71.73983097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7389"},
        {"Hipparcos Number", "HIP 5926"},
        {"Geneva Identification System", "GEN# +1.00007389"},
        {"Smithsonian Astrophysical Observation", "SAO 4358"},
        {"Wilson Evans Batten Catalogue", "WEB 1346"},
    },
    visualMagnitude: 5.87,
    bvColour: 2.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.04959061),
        dec: Angle.Degrees(+71.74384538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136324"},
        {"Hipparcos Number", "HIP 74644"},
        {"Smithsonian Astrophysical Observation", "SAO 8202"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.76350764),
        dec: Angle.Degrees(+71.74850975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46509"},
        {"Hipparcos Number", "HIP 31946"},
        {"Fundamental Katalog 5th Edition", "FK5 2511"},
        {"Geneva Identification System", "GEN# +1.00046509"},
        {"Smithsonian Astrophysical Observation", "SAO 5925"},
        {"Wilson Evans Batten Catalogue", "WEB 6420"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.13434964),
        dec: Angle.Degrees(+71.74875988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119495"},
        {"Hipparcos Number", "HIP 66723"},
        {"Smithsonian Astrophysical Observation", "SAO 7864"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.15975820),
        dec: Angle.Degrees(+71.75035403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13192",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nushagak"},
        {"Henry Draper", "HD 17156"},
        {"Hipparcos Number", "HIP 13192"},
        {"Smithsonian Astrophysical Observation", "SAO 4737"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.43465843),
        dec: Angle.Degrees(+71.75331104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83186"},
        {"Hipparcos Number", "HIP 47469"},
        {"Geneva Identification System", "GEN# +1.00083186"},
        {"Smithsonian Astrophysical Observation", "SAO 6929"},
        {"Wilson Evans Batten Catalogue", "WEB 8905"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.14684578),
        dec: Angle.Degrees(+71.75553234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152027"},
        {"Hipparcos Number", "HIP 81961"},
        {"Smithsonian Astrophysical Observation", "SAO 8611"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.15085866),
        dec: Angle.Degrees(+71.75666083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51370"},
        {"Hipparcos Number", "HIP 34024"},
        {"Geneva Identification System", "GEN# +1.00051370"},
        {"Smithsonian Astrophysical Observation", "SAO 6054"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.88963281),
        dec: Angle.Degrees(+71.75799381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105387"},
        {"Hipparcos Number", "HIP 59157"},
        {"Smithsonian Astrophysical Observation", "SAO 7508"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.97019293),
        dec: Angle.Degrees(+71.76022898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69004"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.90512801),
        dec: Angle.Degrees(+71.76191588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2339 D"},
        {"Hipparcos Number", "HIP 14543"},
    },
    visualMagnitude: 12.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.94177562),
        dec: Angle.Degrees(+75.78966882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193983"},
        {"Hipparcos Number", "HIP 100039"},
        {"Smithsonian Astrophysical Observation", "SAO 9717"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43773890),
        dec: Angle.Degrees(+71.76279816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133621"},
        {"Hipparcos Number", "HIP 73440"},
        {"Cincinnati Publication", "Ci 20 906"},
        {"Fundamental Katalog 5th Edition", "FK5 3189"},
        {"Geneva Identification System", "GEN# +1.00133621"},
        {"Smithsonian Astrophysical Observation", "SAO 8140"},
        {"Wilson Evans Batten Catalogue", "WEB 12569"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.11543779),
        dec: Angle.Degrees(+71.76526079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -405.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198511"},
        {"Hipparcos Number", "HIP 102464"},
        {"Fundamental Katalog 5th Edition", "FK5 5829"},
        {"Smithsonian Astrophysical Observation", "SAO 9872"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45237561),
        dec: Angle.Degrees(+71.77314255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199019"},
        {"Hipparcos Number", "HIP 102791"},
        {"Smithsonian Astrophysical Observation", "SAO 9890"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.37117575),
        dec: Angle.Degrees(+71.77454365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27546"},
        {"Hipparcos Number", "HIP 20779"},
        {"Smithsonian Astrophysical Observation", "SAO 5198"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.76452942),
        dec: Angle.Degrees(+71.78139837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9985 AB"},
        {"Henry Draper", "HD 147055"},
        {"Hipparcos Number", "HIP 79514"},
        {"Smithsonian Astrophysical Observation", "SAO 8455"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.38802940),
        dec: Angle.Degrees(+71.78406437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62965"},
        {"Hipparcos Number", "HIP 38454"},
        {"Geneva Identification System", "GEN# +1.00062965"},
        {"Smithsonian Astrophysical Observation", "SAO 6336"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.15892828),
        dec: Angle.Degrees(+71.78422365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176282"},
        {"Hipparcos Number", "HIP 92672"},
        {"Smithsonian Astrophysical Observation", "SAO 9276"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25373930),
        dec: Angle.Degrees(+71.78719243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65754"},
        {"Hipparcos Number", "HIP 39636"},
        {"Smithsonian Astrophysical Observation", "SAO 6415"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.49715127),
        dec: Angle.Degrees(+71.79024221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157370"},
        {"Hipparcos Number", "HIP 84477"},
        {"Smithsonian Astrophysical Observation", "SAO 8748"},
        {"Wilson Evans Batten Catalogue", "WEB 14258"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.05495709),
        dec: Angle.Degrees(+71.79236985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118018"},
        {"Hipparcos Number", "HIP 65974"},
        {"Smithsonian Astrophysical Observation", "SAO 7836"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.89473561),
        dec: Angle.Degrees(+71.79375515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2083"},
        {"Hipparcos Number", "HIP 2036"},
        {"Geneva Identification System", "GEN# +1.00002083"},
        {"Smithsonian Astrophysical Observation", "SAO 4114"},
        {"Wilson Evans Batten Catalogue", "WEB 388"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.46350133),
        dec: Angle.Degrees(+71.80712256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54070"},
        {"Hipparcos Number", "HIP 34956"},
        {"Fundamental Katalog 5th Edition", "FK5 2552"},
        {"Geneva Identification System", "GEN# +1.00054070"},
        {"Smithsonian Astrophysical Observation", "SAO 6115"},
        {"Wilson Evans Batten Catalogue", "WEB 6989"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.49163280),
        dec: Angle.Degrees(+71.81653915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58381"},
        {"Hipparcos Number", "HIP 36600"},
        {"Geneva Identification System", "GEN# +1.00058381"},
        {"Smithsonian Astrophysical Observation", "SAO 6221"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.91169403),
        dec: Angle.Degrees(+71.82094771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2932"},
        {"Smithsonian Astrophysical Observation", "SAO 4161"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.30377209),
        dec: Angle.Degrees(+71.82151409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24164"},
        {"Hipparcos Number", "HIP 18438"},
        {"Fundamental Katalog 5th Edition", "FK5 2277"},
        {"Geneva Identification System", "GEN# +1.00024164"},
        {"Renson", "Renson 6200"},
        {"Smithsonian Astrophysical Observation", "SAO 5040"},
        {"Wilson Evans Batten Catalogue", "WEB 3552"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.12639054),
        dec: Angle.Degrees(+71.82163081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74793",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pherkad Minor"},
        {"Henry Draper", "HD 136726"},
        {"Hipparcos Number", "HIP 74793"},
        {"Geneva Identification System", "GEN# +1.00136726"},
        {"Smithsonian Astrophysical Observation", "SAO 8207"},
        {"Wilson Evans Batten Catalogue", "WEB 12760"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.27450664),
        dec: Angle.Degrees(+71.82387844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52440"},
        {"Smithsonian Astrophysical Observation", "SAO 7196"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.79699726),
        dec: Angle.Degrees(+71.83161964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131649"},
        {"Hipparcos Number", "HIP 72576"},
        {"Smithsonian Astrophysical Observation", "SAO 8098"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.58892078),
        dec: Angle.Degrees(+71.83330598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75097",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pherkad"},
        {"Henry Draper", "HD 137422"},
        {"Hipparcos Number", "HIP 75097"},
        {"Fundamental Katalog 5th Edition", "FK5 569"},
        {"Geneva Identification System", "GEN# +1.00137422"},
        {"Smithsonian Astrophysical Observation", "SAO 8220"},
        {"Wilson Evans Batten Catalogue", "WEB 12807"},
    },
    visualMagnitude: 3.00,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.18228840),
        dec: Angle.Degrees(+71.83397308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135694"},
        {"Hipparcos Number", "HIP 74326"},
        {"Cincinnati Publication", "Ci 18 2034"},
        {"Geneva Identification System", "GEN# +1.00135694"},
        {"Smithsonian Astrophysical Observation", "SAO 8189"},
        {"Wilson Evans Batten Catalogue", "WEB 12688"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.87194689),
        dec: Angle.Degrees(+71.84075663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12715"},
        {"Hipparcos Number", "HIP 9949"},
        {"Smithsonian Astrophysical Observation", "SAO 4583"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.02101984),
        dec: Angle.Degrees(+71.84118162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63748"},
        {"Hipparcos Number", "HIP 38811"},
        {"Geneva Identification System", "GEN# +1.00063748"},
        {"Smithsonian Astrophysical Observation", "SAO 6359"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.14208000),
        dec: Angle.Degrees(+71.84695179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222527"},
        {"Hipparcos Number", "HIP 116840"},
        {"Smithsonian Astrophysical Observation", "SAO 10831"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.24464032),
        dec: Angle.Degrees(+71.84833539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197830"},
        {"Henry Draper 2", "HD 197837"},
        {"Hipparcos Number", "HIP 102067"},
        {"Smithsonian Astrophysical Observation", "SAO 9846"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.26268130),
        dec: Angle.Degrees(+71.85394863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21179"},
        {"Hipparcos Number", "HIP 16319"},
        {"Geneva Identification System", "GEN# +1.00021179"},
        {"Smithsonian Astrophysical Observation", "SAO 4917"},
        {"Wilson Evans Batten Catalogue", "WEB 3113"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.58078888),
        dec: Angle.Degrees(+71.86389717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158537"},
        {"Hipparcos Number", "HIP 85076"},
        {"Smithsonian Astrophysical Observation", "SAO 8787"},
        {"Wilson Evans Batten Catalogue", "WEB 14365"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.81468258),
        dec: Angle.Degrees(+71.86989789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116513"},
        {"Hipparcos Number", "HIP 65209"},
        {"Smithsonian Astrophysical Observation", "SAO 7802"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.45756913),
        dec: Angle.Degrees(+71.87186670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96702"},
        {"Geneva Identification System", "GEN# +9.80260030"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.88843753),
        dec: Angle.Degrees(+71.87306594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -443.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160964"},
        {"Hipparcos Number", "HIP 86141"},
        {"Geneva Identification System", "GEN# +1.00160964"},
        {"Smithsonian Astrophysical Observation", "SAO 8855"},
        {"Wilson Evans Batten Catalogue", "WEB 14529"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.05493764),
        dec: Angle.Degrees(+71.87844695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134585"},
        {"Hipparcos Number", "HIP 73864"},
        {"Geneva Identification System", "GEN# +1.00134585"},
        {"Smithsonian Astrophysical Observation", "SAO 8162"},
        {"Wilson Evans Batten Catalogue", "WEB 12618"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.44170001),
        dec: Angle.Degrees(+71.88266236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49632"},
        {"Hipparcos Number", "HIP 33335"},
        {"Smithsonian Astrophysical Observation", "SAO 6006"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.99415011),
        dec: Angle.Degrees(+71.88276973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208265"},
        {"Hipparcos Number", "HIP 107891"},
        {"Geneva Identification System", "GEN# +1.00208265"},
        {"Smithsonian Astrophysical Observation", "SAO 10178"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.89726277),
        dec: Angle.Degrees(+71.88568108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32313"},
        {"Wilson Evans Batten Catalogue", "WEB 6519"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.19132778),
        dec: Angle.Degrees(+71.88896431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -549.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10483"},
        {"Hipparcos Number", "HIP 8180"},
        {"Geneva Identification System", "GEN# +5.14630001"},
        {"Smithsonian Astrophysical Observation", "SAO 4479"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.28818291),
        dec: Angle.Degrees(+71.89036008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28702"},
        {"Hipparcos Number", "HIP 21555"},
        {"Geneva Identification System", "GEN# +1.00028702"},
        {"Smithsonian Astrophysical Observation", "SAO 5258"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.42477079),
        dec: Angle.Degrees(+71.89442573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190693"},
        {"Hipparcos Number", "HIP 98469"},
        {"Smithsonian Astrophysical Observation", "SAO 9604"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08376231),
        dec: Angle.Degrees(+71.90019022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121859"},
        {"Hipparcos Number", "HIP 67948"},
        {"Smithsonian Astrophysical Observation", "SAO 7905"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.72211469),
        dec: Angle.Degrees(+71.90321956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183382"},
        {"Hipparcos Number", "HIP 95269"},
        {"Geneva Identification System", "GEN# +1.00183382"},
        {"Smithsonian Astrophysical Observation", "SAO 9406"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.74573387),
        dec: Angle.Degrees(+71.90400215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114684"},
        {"Fundamental Katalog 5th Edition", "FK5 6053"},
        {"Smithsonian Astrophysical Observation", "SAO 10659"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.48769701),
        dec: Angle.Degrees(+71.90896180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58026",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8344 AB"},
        {"Henry Draper", "HD 103321"},
        {"Hipparcos Number", "HIP 58026"},
        {"Geneva Identification System", "GEN# +1.00103321J"},
        {"Smithsonian Astrophysical Observation", "SAO 7446"},
        {"Wilson Evans Batten Catalogue", "WEB 10394"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.51815605),
        dec: Angle.Degrees(+71.92419959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35362"},
        {"Hipparcos Number", "HIP 25838"},
        {"Smithsonian Astrophysical Observation", "SAO 5553"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.74188586),
        dec: Angle.Degrees(+71.92434275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66171"},
        {"Hipparcos Number", "HIP 39822"},
        {"Cincinnati Publication", "Ci 18 952"},
        {"Cincinnati Publication 2", "Ci 20 456"},
        {"Geneva Identification System", "GEN# +1.00066171"},
        {"Smithsonian Astrophysical Observation", "SAO 6424"},
        {"Wilson Evans Batten Catalogue", "WEB 7764"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.04579230),
        dec: Angle.Degrees(+71.92552031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -448.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76024"},
        {"Smithsonian Astrophysical Observation", "SAO 8270"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.91661550),
        dec: Angle.Degrees(+71.92939968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108399"},
        {"Hipparcos Number", "HIP 60699"},
        {"Fundamental Katalog 5th Edition", "FK5 2998"},
        {"Geneva Identification System", "GEN# +1.00108399"},
        {"Smithsonian Astrophysical Observation", "SAO 7563"},
        {"Wilson Evans Batten Catalogue", "WEB 10796"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.60197202),
        dec: Angle.Degrees(+71.92988373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1300"},
        {"Smithsonian Astrophysical Observation", "SAO 4072"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.08628939),
        dec: Angle.Degrees(+71.93096665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50273"},
        {"Hipparcos Number", "HIP 33607"},
        {"Smithsonian Astrophysical Observation", "SAO 6024"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.74512905),
        dec: Angle.Degrees(+71.93198301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37534"},
        {"Hipparcos Number", "HIP 27223"},
        {"Geneva Identification System", "GEN# +1.00037534"},
        {"Smithsonian Astrophysical Observation", "SAO 5644"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.54809780),
        dec: Angle.Degrees(+71.93378917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222376"},
        {"Hipparcos Number", "HIP 116725"},
        {"Smithsonian Astrophysical Observation", "SAO 10815"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.83529834),
        dec: Angle.Degrees(+71.94733093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96391"},
        {"Hipparcos Number", "HIP 54442"},
        {"Fundamental Katalog 5th Edition", "FK5 2888"},
        {"Geneva Identification System", "GEN# +1.00096391"},
        {"Renson", "Renson 27770"},
        {"Smithsonian Astrophysical Observation", "SAO 7287"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.09111399),
        dec: Angle.Degrees(+71.95902631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52762"},
        {"Hipparcos Number", "HIP 34513"},
        {"Smithsonian Astrophysical Observation", "SAO 6092"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.27283685),
        dec: Angle.Degrees(+71.95943861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130834"},
        {"Hipparcos Number", "HIP 72181"},
        {"Fundamental Katalog 5th Edition", "FK5 5307"},
        {"Geneva Identification System", "GEN# +1.00130834"},
        {"Smithsonian Astrophysical Observation", "SAO 8081"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.46320123),
        dec: Angle.Degrees(+71.96609864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145222"},
        {"Hipparcos Number", "HIP 78691"},
        {"Smithsonian Astrophysical Observation", "SAO 8410"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.95785891),
        dec: Angle.Degrees(+71.96655750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 360"},
        {"Smithsonian Astrophysical Observation", "SAO 4027"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.14551227),
        dec: Angle.Degrees(+71.96854252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7878"},
        {"Geneva Identification System", "GEN# +5.14630036"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32943755),
        dec: Angle.Degrees(+71.97269294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111597"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.13254831),
        dec: Angle.Degrees(+71.97344174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81102"},
        {"Smithsonian Astrophysical Observation", "SAO 8559"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.47666244),
        dec: Angle.Degrees(+71.97793335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221421"},
        {"Hipparcos Number", "HIP 116095"},
        {"Geneva Identification System", "GEN# +1.00221421"},
        {"Smithsonian Astrophysical Observation", "SAO 10770"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85775768),
        dec: Angle.Degrees(+71.98430032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87961"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52217164),
        dec: Angle.Degrees(+71.98632503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208510"},
        {"Hipparcos Number", "HIP 108034"},
        {"Smithsonian Astrophysical Observation", "SAO 10188"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.29972065),
        dec: Angle.Degrees(+71.98971366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42856"},
        {"Hipparcos Number", "HIP 30087"},
        {"Smithsonian Astrophysical Observation", "SAO 5813"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.98169645),
        dec: Angle.Degrees(+71.99240885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86923"},
        {"Smithsonian Astrophysical Observation", "SAO 8912"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.41549555),
        dec: Angle.Degrees(+71.99242700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93059"},
        {"Smithsonian Astrophysical Observation", "SAO 9291"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.33877539),
        dec: Angle.Degrees(+71.99852351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79063"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.08093372),
        dec: Angle.Degrees(+72.00027145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221583"},
        {"Hipparcos Number", "HIP 116188"},
        {"Smithsonian Astrophysical Observation", "SAO 10774"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.12207528),
        dec: Angle.Degrees(+72.00098082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71828"},
        {"Hipparcos Number", "HIP 42105"},
        {"Smithsonian Astrophysical Observation", "SAO 6583"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.74287467),
        dec: Angle.Degrees(+72.00421632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164613"},
        {"Hipparcos Number", "HIP 87728"},
        {"Fundamental Katalog 5th Edition", "FK5 3429"},
        {"Geneva Identification System", "GEN# +1.00164613"},
        {"Smithsonian Astrophysical Observation", "SAO 8961"},
        {"Wilson Evans Batten Catalogue", "WEB 14805"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.79640765),
        dec: Angle.Degrees(+72.00513388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97537"},
        {"Hipparcos Number", "HIP 54935"},
        {"Geneva Identification System", "GEN# +1.00097537"},
        {"Smithsonian Astrophysical Observation", "SAO 7318"},
        {"Wilson Evans Batten Catalogue", "WEB 9913"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.74379017),
        dec: Angle.Degrees(+72.00839537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45821"},
        {"Hipparcos Number", "HIP 31575"},
        {"Cincinnati Publication", "Ci 18 809"},
        {"Geneva Identification System", "GEN# +1.00045821"},
        {"Smithsonian Astrophysical Observation", "SAO 5898"},
        {"Wilson Evans Batten Catalogue", "WEB 6318"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.12763461),
        dec: Angle.Degrees(+72.00981613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18417"},
        {"Hipparcos Number", "HIP 14149"},
        {"Smithsonian Astrophysical Observation", "SAO 4795"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.60699788),
        dec: Angle.Degrees(+72.01401238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217034"},
        {"Hipparcos Number", "HIP 113230"},
        {"Smithsonian Astrophysical Observation", "SAO 10553"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.95128550),
        dec: Angle.Degrees(+72.01601209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43265"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.20396467),
        dec: Angle.Degrees(+72.01758363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21289"},
        {"Hipparcos Number", "HIP 16432"},
        {"Smithsonian Astrophysical Observation", "SAO 4925"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.89098823),
        dec: Angle.Degrees(+72.01771706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74358"},
        {"Hipparcos Number", "HIP 43270"},
        {"Smithsonian Astrophysical Observation", "SAO 6649"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.22534728),
        dec: Angle.Degrees(+72.02051491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44646"},
        {"Hipparcos Number", "HIP 30946"},
        {"Smithsonian Astrophysical Observation", "SAO 5869"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.43131146),
        dec: Angle.Degrees(+72.02134544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2962 A"},
        {"Hipparcos Number", "HIP 19164"},
        {"Smithsonian Astrophysical Observation", "SAO 5086"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64146610),
        dec: Angle.Degrees(+72.03496438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205509"},
        {"Hipparcos Number", "HIP 106294"},
        {"Geneva Identification System", "GEN# +1.00205509"},
        {"Smithsonian Astrophysical Observation", "SAO 10075"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.92805584),
        dec: Angle.Degrees(+72.03783032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212908"},
        {"Hipparcos Number", "HIP 110651"},
        {"Smithsonian Astrophysical Observation", "SAO 10356"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.24380059),
        dec: Angle.Degrees(+72.04137100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82578"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.22081128),
        dec: Angle.Degrees(+72.05030767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205494"},
        {"Hipparcos Number", "HIP 106274"},
        {"Geneva Identification System", "GEN# +1.00205494"},
        {"Smithsonian Astrophysical Observation", "SAO 10073"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88469379),
        dec: Angle.Degrees(+72.05051966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161095"},
        {"Hipparcos Number", "HIP 86192"},
        {"Smithsonian Astrophysical Observation", "SAO 8860"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.20224820),
        dec: Angle.Degrees(+72.05468119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204087"},
        {"Hipparcos Number", "HIP 105490"},
        {"Smithsonian Astrophysical Observation", "SAO 10032"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49304040),
        dec: Angle.Degrees(+72.05922804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20452"},
        {"Hipparcos Number", "HIP 15735"},
        {"Smithsonian Astrophysical Observation", "SAO 4888"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.68355970),
        dec: Angle.Degrees(+72.06568514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110868"},
        {"Hipparcos Number", "HIP 62122"},
        {"Geneva Identification System", "GEN# +1.00110868"},
        {"Smithsonian Astrophysical Observation", "SAO 7643"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.97223010),
        dec: Angle.Degrees(+72.07064322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12113 AB"},
        {"Henry Draper", "HD 179729"},
        {"Hipparcos Number", "HIP 93876"},
        {"Smithsonian Astrophysical Observation", "SAO 9323"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77649526),
        dec: Angle.Degrees(+72.07396495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20337"},
        {"Smithsonian Astrophysical Observation", "SAO 5172"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.35185099),
        dec: Angle.Degrees(+72.07598119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82602"},
        {"Hipparcos Number", "HIP 47198"},
        {"Geneva Identification System", "GEN# +1.00082602"},
        {"Smithsonian Astrophysical Observation", "SAO 6908"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.28994707),
        dec: Angle.Degrees(+72.08057235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136095"},
        {"Hipparcos Number", "HIP 74518"},
        {"Smithsonian Astrophysical Observation", "SAO 8197"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.41035727),
        dec: Angle.Degrees(+72.08253489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32087"},
        {"Hipparcos Number", "HIP 23822"},
        {"Smithsonian Astrophysical Observation", "SAO 5425"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.82118157),
        dec: Angle.Degrees(+72.08567712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224311"},
        {"Hipparcos Number", "HIP 118037"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.14290583),
        dec: Angle.Degrees(+72.08750604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70083"},
        {"Smithsonian Astrophysical Observation", "SAO 7993"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.12939205),
        dec: Angle.Degrees(+72.08775240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8913"},
        {"Smithsonian Astrophysical Observation", "SAO 4511"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.68049914),
        dec: Angle.Degrees(+72.09392346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57387"},
        {"Geneva Identification System", "GEN# +0.07200545"},
        {"Smithsonian Astrophysical Observation", "SAO 7422"},
        {"Wilson Evans Batten Catalogue", "WEB 10314"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.48380110),
        dec: Angle.Degrees(+72.09554138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120931"},
        {"Hipparcos Number", "HIP 67447"},
        {"Geneva Identification System", "GEN# +1.00120931"},
        {"Smithsonian Astrophysical Observation", "SAO 7886"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.33723862),
        dec: Angle.Degrees(+72.10057695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182951"},
        {"Hipparcos Number", "HIP 95093"},
        {"Smithsonian Astrophysical Observation", "SAO 9397"},
        {"Wilson Evans Batten Catalogue", "WEB 16611"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19324946),
        dec: Angle.Degrees(+72.10172386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210873"},
        {"Hipparcos Number", "HIP 109434"},
        {"Geneva Identification System", "GEN# +1.00210873"},
        {"Renson", "Renson 58580"},
        {"Smithsonian Astrophysical Observation", "SAO 10267"},
        {"Wilson Evans Batten Catalogue", "WEB 19664"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.56381546),
        dec: Angle.Degrees(+72.11131792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81759"},
        {"Hipparcos Number", "HIP 46763"},
        {"Geneva Identification System", "GEN# +1.00081759"},
        {"Smithsonian Astrophysical Observation", "SAO 6884"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.97134748),
        dec: Angle.Degrees(+72.11142443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204290"},
        {"Hipparcos Number", "HIP 105600"},
        {"Smithsonian Astrophysical Observation", "SAO 10035"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83331328),
        dec: Angle.Degrees(+72.12077348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96231"},
        {"Hipparcos Number", "HIP 54379"},
        {"Geneva Identification System", "GEN# +1.00096231"},
        {"Smithsonian Astrophysical Observation", "SAO 7281"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.88848787),
        dec: Angle.Degrees(+72.12492536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26076"},
        {"Hipparcos Number", "HIP 19730"},
        {"Geneva Identification System", "GEN# +1.00026076"},
        {"Smithsonian Astrophysical Observation", "SAO 5125"},
        {"Wilson Evans Batten Catalogue", "WEB 3763"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.43669669),
        dec: Angle.Degrees(+72.12623040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110042"},
        {"Hipparcos Number", "HIP 61648"},
        {"Fundamental Katalog 5th Edition", "FK5 5114"},
        {"Smithsonian Astrophysical Observation", "SAO 7619"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57161914),
        dec: Angle.Degrees(+72.12635017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14863"},
        {"Hipparcos Number", "HIP 11462"},
        {"Geneva Identification System", "GEN# +1.00014863"},
        {"Smithsonian Astrophysical Observation", "SAO 4652"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.96237754),
        dec: Angle.Degrees(+72.13322284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156011"},
        {"Hipparcos Number", "HIP 83870"},
        {"Smithsonian Astrophysical Observation", "SAO 8720"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.12352226),
        dec: Angle.Degrees(+72.13346110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114256"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.08818873),
        dec: Angle.Degrees(+72.13685855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64708"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.93573268),
        dec: Angle.Degrees(+72.14414473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216327"},
        {"Hipparcos Number", "HIP 112749"},
        {"Smithsonian Astrophysical Observation", "SAO 10512"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.50343488),
        dec: Angle.Degrees(+72.14503552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42951"},
        {"Hipparcos Number", "HIP 30153"},
        {"Smithsonian Astrophysical Observation", "SAO 5817"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.17526141),
        dec: Angle.Degrees(+72.14599586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111559"},
        {"Hipparcos Number", "HIP 62515"},
        {"Smithsonian Astrophysical Observation", "SAO 7667"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.17447660),
        dec: Angle.Degrees(+72.14829540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103350"},
        {"Hipparcos Number", "HIP 58047"},
        {"Geneva Identification System", "GEN# +1.00103350"},
        {"Smithsonian Astrophysical Observation", "SAO 7448"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.57632868),
        dec: Angle.Degrees(+72.14916351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86614",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dziban"},
        {"Aitken", "ADS 10759 A"},
        {"Henry Draper", "HD 162003"},
        {"Hipparcos Number", "HIP 86614"},
        {"Fundamental Katalog 5th Edition", "FK5 670"},
        {"Geneva Identification System", "GEN# +1.00162003"},
        {"Smithsonian Astrophysical Observation", "SAO 8890"},
        {"Wilson Evans Batten Catalogue", "WEB 14603"},
    },
    visualMagnitude: 4.57,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48461270),
        dec: Angle.Degrees(+72.14949916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29036"},
        {"Wilson Evans Batten Catalogue", "WEB 5684"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.88759077),
        dec: Angle.Degrees(+72.15217685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167534"},
        {"Hipparcos Number", "HIP 88901"},
        {"Geneva Identification System", "GEN# +1.00167534"},
        {"Smithsonian Astrophysical Observation", "SAO 9028"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22117473),
        dec: Angle.Degrees(+72.15271600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17982"},
        {"Hipparcos Number", "HIP 13838"},
        {"Smithsonian Astrophysical Observation", "SAO 4783"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.53433084),
        dec: Angle.Degrees(+72.15388256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86620",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10759 B"},
        {"Henry Draper", "HD 162004"},
        {"Hipparcos Number", "HIP 86620"},
        {"Geneva Identification System", "GEN# +1.00162004"},
        {"Smithsonian Astrophysical Observation", "SAO 8891"},
        {"Wilson Evans Batten Catalogue", "WEB 14609"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49182676),
        dec: Angle.Degrees(+72.15757591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207484"},
        {"Hipparcos Number", "HIP 107420"},
        {"Smithsonian Astrophysical Observation", "SAO 10142"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.36636655),
        dec: Angle.Degrees(+72.16625626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31548"},
        {"Hipparcos Number", "HIP 23524"},
        {"Smithsonian Astrophysical Observation", "SAO 5399"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.85805400),
        dec: Angle.Degrees(+72.16735068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21288"},
        {"Hipparcos Number", "HIP 16420"},
        {"Smithsonian Astrophysical Observation", "SAO 4922"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85394978),
        dec: Angle.Degrees(+72.16992821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89535"},
        {"Hipparcos Number", "HIP 50838"},
        {"Smithsonian Astrophysical Observation", "SAO 7124"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71348063),
        dec: Angle.Degrees(+72.17037124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36614"},
        {"Hipparcos Number", "HIP 26652"},
        {"Geneva Identification System", "GEN# +1.00036614"},
        {"Smithsonian Astrophysical Observation", "SAO 5602"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.96555775),
        dec: Angle.Degrees(+72.17717551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3430"},
        {"Geneva Identification System", "GEN# +0.07100031"},
        {"Wilson Evans Batten Catalogue", "WEB 606"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.93221484),
        dec: Angle.Degrees(+72.17842041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 324.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109178"},
        {"Hipparcos Number", "HIP 61156"},
        {"Smithsonian Astrophysical Observation", "SAO 7580"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.97497361),
        dec: Angle.Degrees(+72.17885898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11679"},
        {"Cincinnati Publication", "Ci 18 317"},
        {"Smithsonian Astrophysical Observation", "SAO 4661"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.66171776),
        dec: Angle.Degrees(+72.18484010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79338"},
        {"Hipparcos Number", "HIP 45629"},
        {"Smithsonian Astrophysical Observation", "SAO 6806"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.51700781),
        dec: Angle.Degrees(+72.19021827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87352"},
        {"Hipparcos Number", "HIP 49639"},
        {"Smithsonian Astrophysical Observation", "SAO 7051"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.97769986),
        dec: Angle.Degrees(+72.19609126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101568"},
        {"Smithsonian Astrophysical Observation", "SAO 9816"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.76820925),
        dec: Angle.Degrees(+72.19614084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6258"},
        {"Hipparcos Number", "HIP 5113"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.38023299),
        dec: Angle.Degrees(+72.19800325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82189"},
        {"Hipparcos Number", "HIP 47013"},
        {"Geneva Identification System", "GEN# +1.00082189"},
        {"Smithsonian Astrophysical Observation", "SAO 6898"},
        {"Wilson Evans Batten Catalogue", "WEB 8859"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.72245250),
        dec: Angle.Degrees(+72.20586410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20831"},
        {"Hipparcos Number", "HIP 16048"},
        {"Geneva Identification System", "GEN# +1.00020831"},
        {"Smithsonian Astrophysical Observation", "SAO 4905"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.66857747),
        dec: Angle.Degrees(+72.20615669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77623"},
        {"Geneva Identification System", "GEN# +0.07200699"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.70594347),
        dec: Angle.Degrees(+72.21130715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15162"},
        {"Hipparcos Number", "HIP 11675"},
        {"Smithsonian Astrophysical Observation", "SAO 4662"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.65407979),
        dec: Angle.Degrees(+72.22375436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210369"},
        {"Hipparcos Number", "HIP 109163"},
        {"Smithsonian Astrophysical Observation", "SAO 10248"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.68051144),
        dec: Angle.Degrees(+72.22815572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221167"},
        {"Hipparcos Number", "HIP 115894"},
        {"Geneva Identification System", "GEN# +1.00221167"},
        {"Smithsonian Astrophysical Observation", "SAO 10752"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.20558236),
        dec: Angle.Degrees(+72.22997505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224891"},
        {"Hipparcos Number", "HIP 123"},
        {"Smithsonian Astrophysical Observation", "SAO 10933"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.40024110),
        dec: Angle.Degrees(+72.23660619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68682"},
        {"Hipparcos Number", "HIP 40753"},
        {"Smithsonian Astrophysical Observation", "SAO 6490"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78442806),
        dec: Angle.Degrees(+72.24109181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27836"},
        {"Smithsonian Astrophysical Observation", "SAO 5677"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.35439989),
        dec: Angle.Degrees(+72.24238105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180372"},
        {"Hipparcos Number", "HIP 94146"},
        {"Geneva Identification System", "GEN# +1.00180372"},
        {"Smithsonian Astrophysical Observation", "SAO 9338"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.45655490),
        dec: Angle.Degrees(+72.24332767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10083"},
        {"Hipparcos Number", "HIP 7890"},
        {"Geneva Identification System", "GEN# +5.14630030"},
        {"Smithsonian Astrophysical Observation", "SAO 4465"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.37223171),
        dec: Angle.Degrees(+72.24762736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72962"},
        {"Hipparcos Number", "HIP 42609"},
        {"Geneva Identification System", "GEN# +1.00072962"},
        {"Smithsonian Astrophysical Observation", "SAO 6611"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.26461665),
        dec: Angle.Degrees(+72.24929345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57348"},
        {"Wilson Evans Batten Catalogue", "WEB 10308"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.37170376),
        dec: Angle.Degrees(+72.24958067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83506"},
        {"Hipparcos Number", "HIP 47654"},
        {"Fundamental Katalog 5th Edition", "FK5 2772"},
        {"Geneva Identification System", "GEN# +1.00083506"},
        {"Smithsonian Astrophysical Observation", "SAO 6936"},
        {"Wilson Evans Batten Catalogue", "WEB 8931"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.73849356),
        dec: Angle.Degrees(+72.25268512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77993"},
        {"Hipparcos Number", "HIP 45062"},
        {"Smithsonian Astrophysical Observation", "SAO 6766"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.67124679),
        dec: Angle.Degrees(+72.25418797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127910"},
        {"Hipparcos Number", "HIP 70891"},
        {"Smithsonian Astrophysical Observation", "SAO 8032"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.45632453),
        dec: Angle.Degrees(+72.25870282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179932"},
        {"Hipparcos Number", "HIP 93965"},
        {"Smithsonian Astrophysical Observation", "SAO 9329"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.98531049),
        dec: Angle.Degrees(+72.26707633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53415"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.89634835),
        dec: Angle.Degrees(+72.26819952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184824"},
        {"Hipparcos Number", "HIP 95875"},
        {"Smithsonian Astrophysical Observation", "SAO 9441"},
        {"Wilson Evans Batten Catalogue", "WEB 16788"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48585377),
        dec: Angle.Degrees(+72.27258910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117113"},
        {"Hipparcos Number", "HIP 65512"},
        {"Smithsonian Astrophysical Observation", "SAO 7812"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.43274579),
        dec: Angle.Degrees(+72.27328761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172783"},
        {"Hipparcos Number", "HIP 91121"},
        {"Smithsonian Astrophysical Observation", "SAO 9176"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81293002),
        dec: Angle.Degrees(+72.27421828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20039"},
        {"Hipparcos Number", "HIP 15405"},
        {"Cincinnati Publication", "Ci 18 423"},
        {"Smithsonian Astrophysical Observation", "SAO 4874"},
        {"Wilson Evans Batten Catalogue", "WEB 2961"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.65867565),
        dec: Angle.Degrees(+72.27574633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55214"},
        {"Smithsonian Astrophysical Observation", "SAO 7333"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.60788807),
        dec: Angle.Degrees(+72.27676511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149683"},
        {"Hipparcos Number", "HIP 80802"},
        {"Wilson Evans Batten Catalogue", "WEB 13664"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.49112491),
        dec: Angle.Degrees(+72.28028663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92880"},
        {"Hipparcos Number", "HIP 52639"},
        {"Geneva Identification System", "GEN# +1.00092880"},
        {"Smithsonian Astrophysical Observation", "SAO 7199"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46638593),
        dec: Angle.Degrees(+72.28795824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34267"},
        {"Hipparcos Number", "HIP 25165"},
        {"Smithsonian Astrophysical Observation", "SAO 5511"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76047910),
        dec: Angle.Degrees(+72.28852954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129599"},
        {"Hipparcos Number", "HIP 71627"},
        {"Geneva Identification System", "GEN# +1.00129599"},
        {"Smithsonian Astrophysical Observation", "SAO 8061"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.74082142),
        dec: Angle.Degrees(+72.29019594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71147"},
        {"Hipparcos Number", "HIP 41809"},
        {"Smithsonian Astrophysical Observation", "SAO 6562"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.86462269),
        dec: Angle.Degrees(+72.29126500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10534"},
        {"Smithsonian Astrophysical Observation", "SAO 4604"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.92875524),
        dec: Angle.Degrees(+72.29602735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37094"},
        {"Hipparcos Number", "HIP 26929"},
        {"Smithsonian Astrophysical Observation", "SAO 5623"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.73506392),
        dec: Angle.Degrees(+72.30159325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16182"},
        {"Hipparcos Number", "HIP 12448"},
        {"Smithsonian Astrophysical Observation", "SAO 4703"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.06988165),
        dec: Angle.Degrees(+72.30428205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77724"},
        {"Hipparcos Number", "HIP 44932"},
        {"Geneva Identification System", "GEN# +1.00077724"},
        {"Smithsonian Astrophysical Observation", "SAO 6759"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.28616563),
        dec: Angle.Degrees(+72.30486084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81474"},
        {"Hipparcos Number", "HIP 46605"},
        {"Geneva Identification System", "GEN# +1.00081474"},
        {"Smithsonian Astrophysical Observation", "SAO 6877"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.55005219),
        dec: Angle.Degrees(+72.31660075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148361"},
        {"Hipparcos Number", "HIP 80099"},
        {"Geneva Identification System", "GEN# +1.00148361"},
        {"Renson", "Renson 41930"},
        {"Smithsonian Astrophysical Observation", "SAO 8486"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.26802438),
        dec: Angle.Degrees(+72.31686725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207130"},
        {"Hipparcos Number", "HIP 107230"},
        {"Geneva Identification System", "GEN# +1.00207130"},
        {"Smithsonian Astrophysical Observation", "SAO 10131"},
        {"Wilson Evans Batten Catalogue", "WEB 19367"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.76719016),
        dec: Angle.Degrees(+72.32018258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200447"},
        {"Hipparcos Number", "HIP 103543"},
        {"Geneva Identification System", "GEN# +1.00200447"},
        {"Smithsonian Astrophysical Observation", "SAO 9921"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.67248355),
        dec: Angle.Degrees(+72.32992000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210807"},
        {"Hipparcos Number", "HIP 109400"},
        {"Fundamental Katalog 5th Edition", "FK5 837"},
        {"Geneva Identification System", "GEN# +1.00210807"},
        {"Smithsonian Astrophysical Observation", "SAO 10265"},
        {"Wilson Evans Batten Catalogue", "WEB 19656"},
    },
    visualMagnitude: 4.79,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.45152906),
        dec: Angle.Degrees(+72.34119936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13770"},
        {"Hipparcos Number", "HIP 10715"},
        {"Smithsonian Astrophysical Observation", "SAO 4612"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.49604908),
        dec: Angle.Degrees(+72.34406068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17026"},
        {"Hipparcos Number", "HIP 13115"},
        {"Smithsonian Astrophysical Observation", "SAO 4731"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.17348763),
        dec: Angle.Degrees(+72.34423162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58693",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8397 A"},
        {"Hipparcos Number", "HIP 58693"},
        {"Smithsonian Astrophysical Observation", "SAO 7488"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.56662876),
        dec: Angle.Degrees(+72.36195802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187339"},
        {"Hipparcos Number", "HIP 97034"},
        {"Smithsonian Astrophysical Observation", "SAO 9519"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.81197662),
        dec: Angle.Degrees(+72.36259683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8397 B"},
        {"Hipparcos Number", "HIP 58695"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.57355987),
        dec: Angle.Degrees(+72.36460300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83884"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.17263164),
        dec: Angle.Degrees(+72.36564863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135143"},
        {"Hipparcos Number", "HIP 74092"},
        {"Geneva Identification System", "GEN# +1.00135143"},
        {"Smithsonian Astrophysical Observation", "SAO 8174"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.12587332),
        dec: Angle.Degrees(+72.36935966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210431"},
        {"Hipparcos Number", "HIP 109191"},
        {"Smithsonian Astrophysical Observation", "SAO 10253"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.79472173),
        dec: Angle.Degrees(+72.37274194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60469"},
        {"Hipparcos Number", "HIP 37427"},
        {"Smithsonian Astrophysical Observation", "SAO 6270"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.24114944),
        dec: Angle.Degrees(+72.37298044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150747"},
        {"Hipparcos Number", "HIP 81307"},
        {"Smithsonian Astrophysical Observation", "SAO 8567"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09690246),
        dec: Angle.Degrees(+72.37377233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172922"},
        {"Hipparcos Number", "HIP 91163"},
        {"Smithsonian Astrophysical Observation", "SAO 9181"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97810034),
        dec: Angle.Degrees(+72.38021591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108173"},
        {"Hipparcos Number", "HIP 60568"},
        {"Smithsonian Astrophysical Observation", "SAO 7559"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.22974532),
        dec: Angle.Degrees(+72.38156761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50517"},
        {"Smithsonian Astrophysical Observation", "SAO 7105"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.75520147),
        dec: Angle.Degrees(+72.38472274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74072"},
        {"Hipparcos Number", "HIP 43131"},
        {"Geneva Identification System", "GEN# +1.00074072"},
        {"Smithsonian Astrophysical Observation", "SAO 6638"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.78607227),
        dec: Angle.Degrees(+72.38526280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148083"},
        {"Hipparcos Number", "HIP 79971"},
        {"Geneva Identification System", "GEN# +1.00148083"},
        {"Smithsonian Astrophysical Observation", "SAO 8476"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.85186304),
        dec: Angle.Degrees(+72.38801054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103474"},
        {"Hipparcos Number", "HIP 58115"},
        {"Geneva Identification System", "GEN# +1.00103474"},
        {"Smithsonian Astrophysical Observation", "SAO 7452"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.78692088),
        dec: Angle.Degrees(+72.38898909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117187"},
        {"Hipparcos Number", "HIP 65536"},
        {"Fundamental Katalog 5th Edition", "FK5 499"},
        {"Geneva Identification System", "GEN# +1.00117187"},
        {"Smithsonian Astrophysical Observation", "SAO 7814"},
        {"Wilson Evans Batten Catalogue", "WEB 11572"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53343022),
        dec: Angle.Degrees(+72.39149824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143641"},
        {"Hipparcos Number", "HIP 77998"},
        {"Fundamental Katalog 5th Edition", "FK5 5407"},
        {"Smithsonian Astrophysical Observation", "SAO 8375"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92069600),
        dec: Angle.Degrees(+72.39200799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146585"},
        {"Hipparcos Number", "HIP 79262"},
        {"Smithsonian Astrophysical Observation", "SAO 8442"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65565958),
        dec: Angle.Degrees(+72.39322112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55456"},
        {"Hipparcos Number", "HIP 35505"},
        {"Smithsonian Astrophysical Observation", "SAO 6147"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.91318923),
        dec: Angle.Degrees(+72.39455096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40469"},
        {"Hipparcos Number", "HIP 28892"},
        {"Smithsonian Astrophysical Observation", "SAO 5738"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.49604798),
        dec: Angle.Degrees(+72.39945434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7655"},
        {"Hipparcos Number", "HIP 6139"},
        {"Smithsonian Astrophysical Observation", "SAO 4372"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.69139722),
        dec: Angle.Degrees(+72.40145519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113759"},
        {"Hipparcos Number", "HIP 63755"},
        {"Smithsonian Astrophysical Observation", "SAO 7737"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.01255351),
        dec: Angle.Degrees(+72.40256453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171213"},
        {"Hipparcos Number", "HIP 90389"},
        {"Smithsonian Astrophysical Observation", "SAO 9131"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.65155703),
        dec: Angle.Degrees(+72.40374938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94039"},
        {"Hipparcos Number", "HIP 53248"},
        {"Smithsonian Astrophysical Observation", "SAO 7228"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.36236567),
        dec: Angle.Degrees(+72.40507546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6724 A"},
        {"Henry Draper", "HD 68951"},
        {"Hipparcos Number", "HIP 40889"},
        {"Geneva Identification System", "GEN# +1.00068951A"},
        {"Smithsonian Astrophysical Observation", "SAO 6504"},
        {"Wilson Evans Batten Catalogue", "WEB 7929"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.16798187),
        dec: Angle.Degrees(+72.40729324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86390"},
        {"Hipparcos Number", "HIP 49144"},
        {"Smithsonian Astrophysical Observation", "SAO 7033"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.44811546),
        dec: Angle.Degrees(+72.41084085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172611"},
        {"Hipparcos Number", "HIP 91039"},
        {"Smithsonian Astrophysical Observation", "SAO 9169"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.56712064),
        dec: Angle.Degrees(+72.41120377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31433"},
        {"Hipparcos Number", "HIP 23463"},
        {"Geneva Identification System", "GEN# +1.00031433"},
        {"Smithsonian Astrophysical Observation", "SAO 5393"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.65433639),
        dec: Angle.Degrees(+72.41576285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161897"},
        {"Hipparcos Number", "HIP 86540"},
        {"Cincinnati Publication", "Ci 18 2367"},
        {"Geneva Identification System", "GEN# +1.00161897"},
        {"Smithsonian Astrophysical Observation", "SAO 8880"},
        {"Wilson Evans Batten Catalogue", "WEB 14594"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.27889573),
        dec: Angle.Degrees(+72.41962037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 297.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12216"},
        {"Hipparcos Number", "HIP 9598"},
        {"Fundamental Katalog 5th Edition", "FK5 70"},
        {"Geneva Identification System", "GEN# +1.00012216"},
        {"Smithsonian Astrophysical Observation", "SAO 4560"},
        {"Wilson Evans Batten Catalogue", "WEB 2016"},
    },
    visualMagnitude: 3.95,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85912643),
        dec: Angle.Degrees(+72.42123962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51744"},
        {"Smithsonian Astrophysical Observation", "SAO 7162"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58190722),
        dec: Angle.Degrees(+72.42909881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26458"},
        {"Hipparcos Number", "HIP 20007"},
        {"Smithsonian Astrophysical Observation", "SAO 5141"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.34708206),
        dec: Angle.Degrees(+72.43074663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11762 A"},
        {"Henry Draper", "HD 175423"},
        {"Hipparcos Number", "HIP 92284"},
        {"Smithsonian Astrophysical Observation", "SAO 9257"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.12763998),
        dec: Angle.Degrees(+72.43301887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88998"},
        {"Hipparcos Number", "HIP 50526"},
        {"Smithsonian Astrophysical Observation", "SAO 7107"},
        {"Wilson Evans Batten Catalogue", "WEB 9269"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.80078838),
        dec: Angle.Degrees(+72.43726190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25518"},
        {"Smithsonian Astrophysical Observation", "SAO 5534"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.85388004),
        dec: Angle.Degrees(+72.43945345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1226 AB"},
        {"Henry Draper", "HD 9454"},
        {"Hipparcos Number", "HIP 7413"},
        {"Smithsonian Astrophysical Observation", "SAO 4441"},
        {"Wilson Evans Batten Catalogue", "WEB 1590"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.88898226),
        dec: Angle.Degrees(+72.44202117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9268"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.77503600),
        dec: Angle.Degrees(+72.45080526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53363"},
        {"Smithsonian Astrophysical Observation", "SAO 7236"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.69003988),
        dec: Angle.Degrees(+72.45226961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28704"},
        {"Smithsonian Astrophysical Observation", "SAO 5723"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.94167293),
        dec: Angle.Degrees(+72.45420588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161178"},
        {"Hipparcos Number", "HIP 86219"},
        {"Geneva Identification System", "GEN# +1.00161178"},
        {"Smithsonian Astrophysical Observation", "SAO 8862"},
        {"Wilson Evans Batten Catalogue", "WEB 14540"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.28682150),
        dec: Angle.Degrees(+72.45575693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117928"},
        {"Smithsonian Astrophysical Observation", "SAO 10898"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.79323010),
        dec: Angle.Degrees(+72.46029127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215174"},
        {"Hipparcos Number", "HIP 111986"},
        {"Smithsonian Astrophysical Observation", "SAO 10457"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.24956910),
        dec: Angle.Degrees(+72.46087346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188013"},
        {"Hipparcos Number", "HIP 97332"},
        {"Fundamental Katalog 5th Edition", "FK5 5745"},
        {"Smithsonian Astrophysical Observation", "SAO 9535"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.72543150),
        dec: Angle.Degrees(+72.46454445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26247"},
        {"Wilson Evans Batten Catalogue", "WEB 5146"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86318577),
        dec: Angle.Degrees(+72.46599082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202595"},
        {"Hipparcos Number", "HIP 104682"},
        {"Geneva Identification System", "GEN# +1.00202595"},
        {"Smithsonian Astrophysical Observation", "SAO 9985"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.07284108),
        dec: Angle.Degrees(+72.47160948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184396"},
        {"Hipparcos Number", "HIP 95693"},
        {"Smithsonian Astrophysical Observation", "SAO 9430"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.95703932),
        dec: Angle.Degrees(+72.47758091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38374"},
        {"Hipparcos Number", "HIP 27728"},
        {"Geneva Identification System", "GEN# +1.00038374"},
        {"Smithsonian Astrophysical Observation", "SAO 5670"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.06656112),
        dec: Angle.Degrees(+72.47787375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109413"},
        {"Hipparcos Number", "HIP 61293"},
        {"Geneva Identification System", "GEN# +1.00109413"},
        {"Smithsonian Astrophysical Observation", "SAO 7594"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39156877),
        dec: Angle.Degrees(+72.47919638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113490"},
        {"Hipparcos Number", "HIP 63614"},
        {"Geneva Identification System", "GEN# +1.00113490"},
        {"Smithsonian Astrophysical Observation", "SAO 7729"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.56515351),
        dec: Angle.Degrees(+72.48524760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163787"},
        {"Hipparcos Number", "HIP 87354"},
        {"Geneva Identification System", "GEN# +1.00163787"},
        {"Smithsonian Astrophysical Observation", "SAO 8940"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.74377414),
        dec: Angle.Degrees(+72.48631965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208375"},
        {"Hipparcos Number", "HIP 107955"},
        {"Smithsonian Astrophysical Observation", "SAO 10183"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.07198526),
        dec: Angle.Degrees(+72.48987312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7176"},
        {"Hipparcos Number", "HIP 5788"},
        {"Smithsonian Astrophysical Observation", "SAO 4350"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.56233660),
        dec: Angle.Degrees(+72.49519444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73112"},
        {"Smithsonian Astrophysical Observation", "SAO 8124"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.13728125),
        dec: Angle.Degrees(+72.49861273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3162"},
        {"Hipparcos Number", "HIP 2838"},
        {"Smithsonian Astrophysical Observation", "SAO 4155"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.99866123),
        dec: Angle.Degrees(+72.49880690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47624"},
        {"Smithsonian Astrophysical Observation", "SAO 6935"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.66560702),
        dec: Angle.Degrees(+72.50796380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18000"},
        {"Smithsonian Astrophysical Observation", "SAO 5008"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.72066379),
        dec: Angle.Degrees(+72.51526111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89343"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.45024119),
        dec: Angle.Degrees(+72.52142574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 826"},
        {"Hipparcos Number", "HIP 1041"},
        {"Wilson Evans Batten Catalogue", "WEB 179"},
        {"New General Catalogue", "NGC 40"},
    },
    visualMagnitude: 10.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.25429565),
        dec: Angle.Degrees(+72.52195758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3267 A"},
        {"Henry Draper", "HD 28204"},
        {"Hipparcos Number", "HIP 21247"},
        {"Fundamental Katalog 5th Edition", "FK5 2333"},
        {"Geneva Identification System", "GEN# +1.00028204"},
        {"Renson", "Renson 7180"},
        {"Smithsonian Astrophysical Observation", "SAO 5238"},
        {"Wilson Evans Batten Catalogue", "WEB 4080"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.37758981),
        dec: Angle.Degrees(+72.52882555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2590"},
        {"Hipparcos Number", "HIP 2385"},
        {"Smithsonian Astrophysical Observation", "SAO 4129"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.60950282),
        dec: Angle.Degrees(+72.53102600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196142"},
        {"Hipparcos Number", "HIP 101134"},
        {"Fundamental Katalog 5th Edition", "FK5 1538"},
        {"Geneva Identification System", "GEN# +1.00196142"},
        {"Smithsonian Astrophysical Observation", "SAO 9793"},
        {"Wilson Evans Batten Catalogue", "WEB 18266"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.50299582),
        dec: Angle.Degrees(+72.53176245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52544"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.14283490),
        dec: Angle.Degrees(+72.54260794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -352.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19016"},
        {"Hipparcos Number", "HIP 14618"},
        {"Smithsonian Astrophysical Observation", "SAO 4832"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.20131735),
        dec: Angle.Degrees(+72.54871234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101225"},
        {"Hipparcos Number", "HIP 56879"},
        {"Geneva Identification System", "GEN# +1.00101225"},
        {"Smithsonian Astrophysical Observation", "SAO 7409"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90833872),
        dec: Angle.Degrees(+72.54997969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100104"},
        {"Hipparcos Number", "HIP 56261"},
        {"Smithsonian Astrophysical Observation", "SAO 7370"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.98748724),
        dec: Angle.Degrees(+72.55057350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106677"},
        {"Hipparcos Number", "HIP 59796"},
        {"Geneva Identification System", "GEN# +1.00106677"},
        {"Smithsonian Astrophysical Observation", "SAO 7533"},
        {"Wilson Evans Batten Catalogue", "WEB 10624"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.92295178),
        dec: Angle.Degrees(+72.55125754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43978"},
        {"Hipparcos Number", "HIP 30635"},
        {"Smithsonian Astrophysical Observation", "SAO 5838"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.58120619),
        dec: Angle.Degrees(+72.58115990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34760"},
        {"Smithsonian Astrophysical Observation", "SAO 6100"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.93450518),
        dec: Angle.Degrees(+72.58133979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9775"},
        {"Hipparcos Number", "HIP 7629"},
        {"Smithsonian Astrophysical Observation", "SAO 4451"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.57325715),
        dec: Angle.Degrees(+72.58277209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183609"},
        {"Hipparcos Number", "HIP 95349"},
        {"Smithsonian Astrophysical Observation", "SAO 9410"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.97848106),
        dec: Angle.Degrees(+72.58336754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24798"},
        {"Smithsonian Astrophysical Observation", "SAO 5488"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.74807838),
        dec: Angle.Degrees(+72.58990823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40219"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.21405246),
        dec: Angle.Degrees(+72.58994034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124567"},
        {"Hipparcos Number", "HIP 69240"},
        {"Smithsonian Astrophysical Observation", "SAO 7962"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.62273114),
        dec: Angle.Degrees(+72.59039916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216368"},
        {"Hipparcos Number", "HIP 112771"},
        {"Geneva Identification System", "GEN# +1.00216368"},
        {"Smithsonian Astrophysical Observation", "SAO 10515"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.56696271),
        dec: Angle.Degrees(+72.59124361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216978"},
        {"Hipparcos Number", "HIP 113197"},
        {"Geneva Identification System", "GEN# +1.00216978"},
        {"Smithsonian Astrophysical Observation", "SAO 10551"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.85964513),
        dec: Angle.Degrees(+72.59824189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14167",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2276 AB"},
        {"Henry Draper", "HD 18424"},
        {"Hipparcos Number", "HIP 14167"},
        {"Smithsonian Astrophysical Observation", "SAO 4797"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.66593483),
        dec: Angle.Degrees(+72.59934355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40561"},
        {"Hipparcos Number", "HIP 28963"},
        {"Geneva Identification System", "GEN# +1.00040561"},
        {"Smithsonian Astrophysical Observation", "SAO 5742"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.68185642),
        dec: Angle.Degrees(+72.60313266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193533"},
        {"Hipparcos Number", "HIP 99805"},
        {"Smithsonian Astrophysical Observation", "SAO 9696"},
        {"Wilson Evans Batten Catalogue", "WEB 17928"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.73489462),
        dec: Angle.Degrees(+72.60551520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107223"},
        {"Smithsonian Astrophysical Observation", "SAO 10130"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.75485112),
        dec: Angle.Degrees(+72.60860657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87297"},
        {"Hipparcos Number", "HIP 49594"},
        {"Smithsonian Astrophysical Observation", "SAO 7049"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.86331731),
        dec: Angle.Degrees(+72.61157416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150010"},
        {"Hipparcos Number", "HIP 80920"},
        {"Geneva Identification System", "GEN# +1.00150010"},
        {"Smithsonian Astrophysical Observation", "SAO 8544"},
        {"Wilson Evans Batten Catalogue", "WEB 13689"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.86791790),
        dec: Angle.Degrees(+72.61220286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69506"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44125886),
        dec: Angle.Degrees(+72.61662482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220855"},
        {"Hipparcos Number", "HIP 115679"},
        {"Smithsonian Astrophysical Observation", "SAO 10733"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.54935891),
        dec: Angle.Degrees(+72.61839873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98861"},
        {"Hipparcos Number", "HIP 55647"},
        {"Geneva Identification System", "GEN# +1.00098861"},
        {"Smithsonian Astrophysical Observation", "SAO 7353"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.99651872),
        dec: Angle.Degrees(+72.63031110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33589"},
        {"Smithsonian Astrophysical Observation", "SAO 6021"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.67299783),
        dec: Angle.Degrees(+72.64312109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65155"},
        {"Hipparcos Number", "HIP 39435"},
        {"Geneva Identification System", "GEN# +1.00065155"},
        {"Smithsonian Astrophysical Observation", "SAO 6402"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.91740090),
        dec: Angle.Degrees(+72.65388649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54686"},
        {"Smithsonian Astrophysical Observation", "SAO 7302"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.93064718),
        dec: Angle.Degrees(+72.65780317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34154",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5701 AB"},
        {"Henry Draper", "HD 51609"},
        {"Hipparcos Number", "HIP 34154"},
        {"Smithsonian Astrophysical Observation", "SAO 6064"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.22915494),
        dec: Angle.Degrees(+72.66944535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151481"},
        {"Hipparcos Number", "HIP 81646"},
        {"Smithsonian Astrophysical Observation", "SAO 8598"},
        {"Wilson Evans Batten Catalogue", "WEB 13789"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.17713646),
        dec: Angle.Degrees(+72.67164618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17992"},
        {"Hipparcos Number", "HIP 13853"},
        {"Fundamental Katalog 5th Edition", "FK5 4270"},
        {"Geneva Identification System", "GEN# +1.00017992"},
        {"Smithsonian Astrophysical Observation", "SAO 4784"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.59542991),
        dec: Angle.Degrees(+72.67285649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4440"},
        {"Hipparcos Number", "HIP 3750"},
        {"Geneva Identification System", "GEN# +1.00004440"},
        {"Smithsonian Astrophysical Observation", "SAO 4229"},
        {"Wilson Evans Batten Catalogue", "WEB 668"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.03698124),
        dec: Angle.Degrees(+72.67445774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53609"},
        {"Hipparcos Number", "HIP 34835"},
        {"Smithsonian Astrophysical Observation", "SAO 6105"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14148205),
        dec: Angle.Degrees(+72.67529531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74344"},
        {"Hipparcos Number", "HIP 43273"},
        {"Smithsonian Astrophysical Observation", "SAO 6648"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.23389101),
        dec: Angle.Degrees(+72.67673988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48249"},
        {"Hipparcos Number", "HIP 32704"},
        {"Smithsonian Astrophysical Observation", "SAO 5979"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.34790386),
        dec: Angle.Degrees(+72.69025171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71207"},
        {"Hipparcos Number", "HIP 41842"},
        {"Smithsonian Astrophysical Observation", "SAO 6564"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.97314805),
        dec: Angle.Degrees(+72.69211213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36213"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.86677255),
        dec: Angle.Degrees(+72.70354060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116367"},
        {"Smithsonian Astrophysical Observation", "SAO 10789"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.70397604),
        dec: Angle.Degrees(+72.70854980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217523"},
        {"Hipparcos Number", "HIP 113517"},
        {"Geneva Identification System", "GEN# +1.00217523"},
        {"Smithsonian Astrophysical Observation", "SAO 10575"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.85610822),
        dec: Angle.Degrees(+72.71228935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47771"},
        {"Hipparcos Number", "HIP 32534"},
        {"Geneva Identification System", "GEN# +1.00047771"},
        {"Smithsonian Astrophysical Observation", "SAO 5968"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.83282488),
        dec: Angle.Degrees(+72.72034483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24296"},
        {"Hipparcos Number", "HIP 18545"},
        {"Smithsonian Astrophysical Observation", "SAO 5046"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.51123438),
        dec: Angle.Degrees(+72.72457709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16191 AB"},
        {"Aitken 2", "ADS 16191"},
        {"Henry Draper", "HD 215223"},
        {"Hipparcos Number", "HIP 112006"},
        {"Smithsonian Astrophysical Observation", "SAO 10460"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.32009799),
        dec: Angle.Degrees(+72.72781188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217903"},
        {"Hipparcos Number", "HIP 113758"},
        {"Geneva Identification System", "GEN# +1.00217903"},
        {"Smithsonian Astrophysical Observation", "SAO 10593"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.56558431),
        dec: Angle.Degrees(+72.73040797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170153"},
        {"Hipparcos Number", "HIP 89937"},
        {"Cincinnati Publication", "Ci 20 1087"},
        {"Fundamental Katalog 5th Edition", "FK5 695"},
        {"Geneva Identification System", "GEN# +1.00170153"},
        {"Smithsonian Astrophysical Observation", "SAO 9087"},
        {"Wilson Evans Batten Catalogue", "WEB 15359"},
    },
    visualMagnitude: 3.55,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25974572),
        dec: Angle.Degrees(+72.73369763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 531.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63136"},
        {"Hipparcos Number", "HIP 38559"},
        {"Fundamental Katalog 5th Edition", "FK5 4710"},
        {"Smithsonian Astrophysical Observation", "SAO 6344"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.43070895),
        dec: Angle.Degrees(+72.74107317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32765"},
        {"Hipparcos Number", "HIP 24260"},
        {"Smithsonian Astrophysical Observation", "SAO 5457"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.11255230),
        dec: Angle.Degrees(+72.74371070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68061"},
        {"Hipparcos Number", "HIP 40550"},
        {"Geneva Identification System", "GEN# +1.00068061"},
        {"Smithsonian Astrophysical Observation", "SAO 6475"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.20211986),
        dec: Angle.Degrees(+72.74484622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82951"},
        {"Hipparcos Number", "HIP 47405"},
        {"Smithsonian Astrophysical Observation", "SAO 6924"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.87264266),
        dec: Angle.Degrees(+72.74677229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52030"},
        {"Smithsonian Astrophysical Observation", "SAO 7176"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.45831996),
        dec: Angle.Degrees(+72.75733739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210615"},
        {"Hipparcos Number", "HIP 109273"},
        {"Geneva Identification System", "GEN# +1.00210615"},
        {"Smithsonian Astrophysical Observation", "SAO 10258"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.06861066),
        dec: Angle.Degrees(+72.76853662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12165"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.19780646),
        dec: Angle.Degrees(+72.77035190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204"},
        {"Hipparcos Number", "HIP 589"},
        {"Smithsonian Astrophysical Observation", "SAO 4037"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.78773802),
        dec: Angle.Degrees(+72.77522493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191634"},
        {"Hipparcos Number", "HIP 98889"},
        {"Smithsonian Astrophysical Observation", "SAO 9634"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22167564),
        dec: Angle.Degrees(+72.78245087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16256"},
        {"Hipparcos Number", "HIP 12510"},
        {"Smithsonian Astrophysical Observation", "SAO 4706"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.24540375),
        dec: Angle.Degrees(+72.78758347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39009"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.74535839),
        dec: Angle.Degrees(+72.78765457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76902"},
    },
    visualMagnitude: 10.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.54706763),
        dec: Angle.Degrees(+72.78886962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20004"},
        {"Hipparcos Number", "HIP 15372"},
        {"Geneva Identification System", "GEN# +1.00020004"},
        {"Smithsonian Astrophysical Observation", "SAO 4872"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.55105419),
        dec: Angle.Degrees(+72.79357270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115227"},
        {"Hipparcos Number", "HIP 64527"},
        {"Fundamental Katalog 5th Edition", "FK5 3057"},
        {"Geneva Identification System", "GEN# +1.00115227"},
        {"Smithsonian Astrophysical Observation", "SAO 7782"},
        {"Wilson Evans Batten Catalogue", "WEB 11410"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.38311624),
        dec: Angle.Degrees(+72.79913223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132751"},
        {"Hipparcos Number", "HIP 73063"},
        {"Smithsonian Astrophysical Observation", "SAO 8122"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.96836085),
        dec: Angle.Degrees(+72.80308030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115498"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.94296548),
        dec: Angle.Degrees(+72.80472744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 304.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159218"},
        {"Hipparcos Number", "HIP 85350"},
        {"Smithsonian Astrophysical Observation", "SAO 8803"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.61392073),
        dec: Angle.Degrees(+72.80599495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51212"},
        {"Hipparcos Number", "HIP 34014"},
        {"Geneva Identification System", "GEN# +1.00051212"},
        {"Smithsonian Astrophysical Observation", "SAO 6051"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87325341),
        dec: Angle.Degrees(+72.81009343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5594"},
        {"Hipparcos Number", "HIP 4635"},
        {"Smithsonian Astrophysical Observation", "SAO 4283"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.86831301),
        dec: Angle.Degrees(+72.81388999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23836"},
        {"Hipparcos Number", "HIP 18259"},
        {"Smithsonian Astrophysical Observation", "SAO 5025"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.58897076),
        dec: Angle.Degrees(+72.81559370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15920"},
        {"Hipparcos Number", "HIP 12273"},
        {"Fundamental Katalog 5th Edition", "FK5 87"},
        {"Geneva Identification System", "GEN# +1.00015920"},
        {"Smithsonian Astrophysical Observation", "SAO 4694"},
        {"Wilson Evans Batten Catalogue", "WEB 2515"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.50870051),
        dec: Angle.Degrees(+72.81821481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32599"},
        {"Smithsonian Astrophysical Observation", "SAO 5974"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.01594997),
        dec: Angle.Degrees(+72.81944732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18841"},
        {"Hipparcos Number", "HIP 14485"},
        {"Smithsonian Astrophysical Observation", "SAO 4822"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.74793920),
        dec: Angle.Degrees(+72.82578235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82014"},
        {"Smithsonian Astrophysical Observation", "SAO 8615"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.30753750),
        dec: Angle.Degrees(+72.82590125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24841"},
        {"Hipparcos Number", "HIP 18916"},
        {"Geneva Identification System", "GEN# +1.00024841"},
        {"Smithsonian Astrophysical Observation", "SAO 5066"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.80981985),
        dec: Angle.Degrees(+72.82902826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195628"},
        {"Hipparcos Number", "HIP 100841"},
        {"Smithsonian Astrophysical Observation", "SAO 9772"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.69638232),
        dec: Angle.Degrees(+72.83184046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62276"},
        {"Smithsonian Astrophysical Observation", "SAO 7655"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.42775446),
        dec: Angle.Degrees(+72.83699463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16393 AB"},
        {"Henry Draper", "HD 217085"},
        {"Hipparcos Number", "HIP 113273"},
        {"Geneva Identification System", "GEN# +1.00217085"},
        {"Smithsonian Astrophysical Observation", "SAO 10560"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.05469457),
        dec: Angle.Degrees(+72.83735549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41962"},
        {"Hipparcos Number", "HIP 29691"},
        {"Smithsonian Astrophysical Observation", "SAO 5783"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.82359321),
        dec: Angle.Degrees(+72.83946783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93080"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.41062487),
        dec: Angle.Degrees(+72.84027716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 353.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16384 AB"},
        {"Henry Draper", "HD 217049"},
        {"Hipparcos Number", "HIP 113225"},
        {"Geneva Identification System", "GEN# +1.00217049"},
        {"Smithsonian Astrophysical Observation", "SAO 10555"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.94438811),
        dec: Angle.Degrees(+72.84322821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114691"},
        {"Smithsonian Astrophysical Observation", "SAO 10661"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.50315407),
        dec: Angle.Degrees(+72.84616675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6547",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1107 AB"},
        {"Henry Draper", "HD 8226"},
        {"Hipparcos Number", "HIP 6547"},
        {"Renson", "Renson 1990"},
        {"Smithsonian Astrophysical Observation", "SAO 4393"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.03391702),
        dec: Angle.Degrees(+72.84709187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138230"},
        {"Hipparcos Number", "HIP 75484"},
        {"Fundamental Katalog 5th Edition", "FK5 5365"},
        {"Smithsonian Astrophysical Observation", "SAO 8246"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.30125503),
        dec: Angle.Degrees(+72.84747661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46045"},
        {"Hipparcos Number", "HIP 31723"},
        {"Fundamental Katalog 5th Edition", "FK5 4602"},
        {"Smithsonian Astrophysical Observation", "SAO 5915"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.54619514),
        dec: Angle.Degrees(+72.85096792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213916"},
        {"Hipparcos Number", "HIP 111236"},
        {"Smithsonian Astrophysical Observation", "SAO 10409"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.04313143),
        dec: Angle.Degrees(+72.85599909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118093",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17118 AB"},
        {"Henry Draper", "HD 224395"},
        {"Hipparcos Number", "HIP 118093"},
        {"Geneva Identification System", "GEN# +1.00224395J"},
        {"Smithsonian Astrophysical Observation", "SAO 10909"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33334974),
        dec: Angle.Degrees(+72.85917165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71918"},
        {"Smithsonian Astrophysical Observation", "SAO 8073"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64732227),
        dec: Angle.Degrees(+72.85990066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135868"},
        {"Hipparcos Number", "HIP 74383"},
        {"Smithsonian Astrophysical Observation", "SAO 8191"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.00821939),
        dec: Angle.Degrees(+72.87123890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111575",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16111 D"},
        {"Hipparcos Number", "HIP 111575"},
        {"Geneva Identification System", "GEN# +0.07201051"},
        {"Geneva Identification System 2", "GEN# +1.00214511D"},
        {"Smithsonian Astrophysical Observation", "SAO 10431"},
        {"Wilson Evans Batten Catalogue", "WEB 19947"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.06333806),
        dec: Angle.Degrees(+72.87231865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93959",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12133 AB"},
        {"Henry Draper", "HD 179955"},
        {"Hipparcos Number", "HIP 93959"},
        {"Smithsonian Astrophysical Observation", "SAO 9330"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.97168565),
        dec: Angle.Degrees(+72.87336420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8955"},
        {"Hipparcos Number", "HIP 7061"},
        {"Smithsonian Astrophysical Observation", "SAO 4417"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.75805746),
        dec: Angle.Degrees(+72.87788142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7646"},
        {"Hipparcos Number", "HIP 6133"},
        {"Smithsonian Astrophysical Observation", "SAO 4371"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.67580670),
        dec: Angle.Degrees(+72.87795850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85841"},
        {"Hipparcos Number", "HIP 48893"},
        {"Fundamental Katalog 5th Edition", "FK5 372"},
        {"Geneva Identification System", "GEN# +1.00085841"},
        {"Smithsonian Astrophysical Observation", "SAO 7009"},
        {"Wilson Evans Batten Catalogue", "WEB 9083"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.59545794),
        dec: Angle.Degrees(+72.87959798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193942"},
        {"Hipparcos Number", "HIP 99989"},
        {"Geneva Identification System", "GEN# +1.00193942"},
        {"Smithsonian Astrophysical Observation", "SAO 9713"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.26980069),
        dec: Angle.Degrees(+72.88077359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16111 AB"},
        {"Henry Draper", "HD 214511"},
        {"Hipparcos Number", "HIP 111570"},
        {"Geneva Identification System", "GEN# +1.00214511J"},
        {"Smithsonian Astrophysical Observation", "SAO 10429"},
        {"Wilson Evans Batten Catalogue", "WEB 19945"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.03605164),
        dec: Angle.Degrees(+72.88085550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2204 AB"},
        {"Henry Draper", "HD 17785"},
        {"Hipparcos Number", "HIP 13677"},
        {"Smithsonian Astrophysical Observation", "SAO 4776"},
        {"Wilson Evans Batten Catalogue", "WEB 2713"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.04717747),
        dec: Angle.Degrees(+72.88621666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43906"},
        {"Smithsonian Astrophysical Observation", "SAO 6688"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.17167453),
        dec: Angle.Degrees(+72.88666255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48090"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.07288903),
        dec: Angle.Degrees(+72.88847952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117271"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.69501733),
        dec: Angle.Degrees(+72.89405363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90097"},
        {"Smithsonian Astrophysical Observation", "SAO 9104"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.80183667),
        dec: Angle.Degrees(+72.89457522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77009"},
        {"Smithsonian Astrophysical Observation", "SAO 8319"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85872429),
        dec: Angle.Degrees(+72.89458772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 516 A"},
        {"Henry Draper", "HD 3366"},
        {"Hipparcos Number", "HIP 2968"},
        {"Geneva Identification System", "GEN# +1.00003366"},
        {"Smithsonian Astrophysical Observation", "SAO 4165"},
        {"Wilson Evans Batten Catalogue", "WEB 536"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.44035009),
        dec: Angle.Degrees(+72.89485477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193265"},
        {"Hipparcos Number", "HIP 99647"},
        {"Geneva Identification System", "GEN# +1.00193265"},
        {"Smithsonian Astrophysical Observation", "SAO 9684"},
        {"Wilson Evans Batten Catalogue", "WEB 17859"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33666972),
        dec: Angle.Degrees(+72.89706966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19953"},
        {"Hipparcos Number", "HIP 15336"},
        {"Smithsonian Astrophysical Observation", "SAO 4868"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.44135503),
        dec: Angle.Degrees(+72.89926699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137825"},
        {"Hipparcos Number", "HIP 75248"},
        {"Geneva Identification System", "GEN# +1.00137825"},
        {"Smithsonian Astrophysical Observation", "SAO 8232"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.64629814),
        dec: Angle.Degrees(+72.90422077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108653"},
        {"Smithsonian Astrophysical Observation", "SAO 10224"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.16619141),
        dec: Angle.Degrees(+72.91428649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2135 A"},
        {"Henry Draper", "HD 17179"},
        {"Hipparcos Number", "HIP 13221"},
        {"Geneva Identification System", "GEN# +1.00017179"},
        {"Smithsonian Astrophysical Observation", "SAO 4738"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.55013641),
        dec: Angle.Degrees(+72.91434829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221774"},
        {"Hipparcos Number", "HIP 116321"},
        {"Smithsonian Astrophysical Observation", "SAO 10785"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.53265061),
        dec: Angle.Degrees(+72.91456401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22480"},
        {"Fundamental Katalog 5th Edition", "FK5 4443"},
        {"Smithsonian Astrophysical Observation", "SAO 5320"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.55224697),
        dec: Angle.Degrees(+72.91756059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67101"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.30097747),
        dec: Angle.Degrees(+72.92231586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158832"},
        {"Hipparcos Number", "HIP 85170"},
        {"Smithsonian Astrophysical Observation", "SAO 8794"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.08183106),
        dec: Angle.Degrees(+72.93574584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139152"},
        {"Hipparcos Number", "HIP 75963"},
        {"Smithsonian Astrophysical Observation", "SAO 8266"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70955661),
        dec: Angle.Degrees(+72.93643261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123154"},
        {"Hipparcos Number", "HIP 68577"},
        {"Geneva Identification System", "GEN# +1.00123154"},
        {"Smithsonian Astrophysical Observation", "SAO 7933"},
        {"Wilson Evans Batten Catalogue", "WEB 12010"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58729176),
        dec: Angle.Degrees(+72.93707926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190021"},
        {"Hipparcos Number", "HIP 98141"},
        {"Geneva Identification System", "GEN# +1.00190021"},
        {"Smithsonian Astrophysical Observation", "SAO 9581"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.18031979),
        dec: Angle.Degrees(+72.93833000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28372"},
        {"Hipparcos Number", "HIP 21372"},
        {"Smithsonian Astrophysical Observation", "SAO 5247"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.79712988),
        dec: Angle.Degrees(+72.94427400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123397"},
        {"Hipparcos Number", "HIP 68703"},
        {"Geneva Identification System", "GEN# +1.00123397"},
        {"Smithsonian Astrophysical Observation", "SAO 7937"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.96083467),
        dec: Angle.Degrees(+72.94559973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78935"},
        {"Hipparcos Number", "HIP 45461"},
        {"Geneva Identification System", "GEN# +1.00078935"},
        {"Renson", "Renson 22380"},
        {"Smithsonian Astrophysical Observation", "SAO 6792"},
        {"Wilson Evans Batten Catalogue", "WEB 8648"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.96979130),
        dec: Angle.Degrees(+72.94646226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 243 AB"},
        {"Henry Draper", "HD 1360"},
        {"Hipparcos Number", "HIP 1461"},
        {"Smithsonian Astrophysical Observation", "SAO 4079"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.56125588),
        dec: Angle.Degrees(+72.94678997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32172"},
        {"Hipparcos Number", "HIP 23912"},
        {"Geneva Identification System", "GEN# +1.00032172"},
        {"Smithsonian Astrophysical Observation", "SAO 5431"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.06607942),
        dec: Angle.Degrees(+72.94737331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199329"},
        {"Hipparcos Number", "HIP 102933"},
        {"Geneva Identification System", "GEN# +1.00199329"},
        {"Smithsonian Astrophysical Observation", "SAO 9897"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.81547649),
        dec: Angle.Degrees(+72.94800153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42506"},
        {"Hipparcos Number", "HIP 29957"},
        {"Geneva Identification System", "GEN# +1.00042506"},
        {"Smithsonian Astrophysical Observation", "SAO 5807"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.59063096),
        dec: Angle.Degrees(+72.95086233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22973"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.15267713),
        dec: Angle.Degrees(+72.95117200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54394"},
        {"Smithsonian Astrophysical Observation", "SAO 7284"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.94735148),
        dec: Angle.Degrees(+72.95375040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173579"},
        {"Hipparcos Number", "HIP 91450"},
        {"Smithsonian Astrophysical Observation", "SAO 9200"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.76974778),
        dec: Angle.Degrees(+72.95943773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205758"},
        {"Hipparcos Number", "HIP 106418"},
        {"Geneva Identification System", "GEN# +1.00205758"},
        {"Smithsonian Astrophysical Observation", "SAO 10084"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.32013457),
        dec: Angle.Degrees(+72.96023059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63367"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.76163670),
        dec: Angle.Degrees(+72.96305759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61974"},
        {"Cincinnati Publication", "Ci 18 1612"},
        {"Geneva Identification System", "GEN# +0.07300566"},
        {"Smithsonian Astrophysical Observation", "SAO 7636"},
        {"Wilson Evans Batten Catalogue", "WEB 11023"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.50297224),
        dec: Angle.Degrees(+72.96419867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161711"},
        {"Hipparcos Number", "HIP 86450"},
        {"Geneva Identification System", "GEN# +1.00161711"},
        {"Smithsonian Astrophysical Observation", "SAO 8879"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.96156560),
        dec: Angle.Degrees(+72.96472734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137894"},
        {"Hipparcos Number", "HIP 75305"},
        {"Smithsonian Astrophysical Observation", "SAO 8238"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.78960811),
        dec: Angle.Degrees(+72.96488015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197923"},
        {"Hipparcos Number", "HIP 102090"},
        {"Smithsonian Astrophysical Observation", "SAO 9849"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.34111484),
        dec: Angle.Degrees(+72.97440979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175368"},
        {"Hipparcos Number", "HIP 92258"},
        {"Smithsonian Astrophysical Observation", "SAO 9255"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.02114612),
        dec: Angle.Degrees(+72.97541777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50129"},
        {"Smithsonian Astrophysical Observation", "SAO 7082"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.50463803),
        dec: Angle.Degrees(+72.97795097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29213"},
        {"Hipparcos Number", "HIP 21913"},
        {"Geneva Identification System", "GEN# +1.00029213"},
        {"Smithsonian Astrophysical Observation", "SAO 5280"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.69281903),
        dec: Angle.Degrees(+72.97832837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18875"},
        {"Hipparcos Number", "HIP 14511"},
        {"Geneva Identification System", "GEN# +1.00018875"},
        {"Smithsonian Astrophysical Observation", "SAO 4825"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.84085586),
        dec: Angle.Degrees(+72.98649788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13401 AB"},
        {"Henry Draper", "HD 191633"},
        {"Hipparcos Number", "HIP 98874"},
        {"Smithsonian Astrophysical Observation", "SAO 9633"},
        {"Wilson Evans Batten Catalogue", "WEB 17549"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19085881),
        dec: Angle.Degrees(+72.99624020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103863"},
        {"Hipparcos Number", "HIP 58330"},
        {"Smithsonian Astrophysical Observation", "SAO 7463"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.43869292),
        dec: Angle.Degrees(+72.99964472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110234"},
        {"Hipparcos Number", "HIP 61759"},
        {"Smithsonian Astrophysical Observation", "SAO 7621"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.86105955),
        dec: Angle.Degrees(+73.00157284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78048"},
        {"Hipparcos Number", "HIP 45089"},
        {"Smithsonian Astrophysical Observation", "SAO 6768"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.77690182),
        dec: Angle.Degrees(+73.00628930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84446"},
        {"Smithsonian Astrophysical Observation", "SAO 8747"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.96991805),
        dec: Angle.Degrees(+73.01167517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158209"},
        {"Hipparcos Number", "HIP 84886"},
        {"Cincinnati Publication", "Ci 18 2327"},
        {"Smithsonian Astrophysical Observation", "SAO 8779"},
        {"Wilson Evans Batten Catalogue", "WEB 14337"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.22510061),
        dec: Angle.Degrees(+73.01335120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 208.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44534"},
        {"Hipparcos Number", "HIP 30937"},
        {"Geneva Identification System", "GEN# +1.00044534"},
        {"Smithsonian Astrophysical Observation", "SAO 5865"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.39537764),
        dec: Angle.Degrees(+73.01447427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41523"},
        {"Smithsonian Astrophysical Observation", "SAO 6543"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.02489972),
        dec: Angle.Degrees(+73.02301768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8772 AB"},
        {"Henry Draper", "HD 113889"},
        {"Hipparcos Number", "HIP 63822"},
        {"Smithsonian Astrophysical Observation", "SAO 7741"},
        {"Wilson Evans Batten Catalogue", "WEB 11286"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.20742517),
        dec: Angle.Degrees(+73.02495241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82008"},
        {"Hipparcos Number", "HIP 46920"},
        {"Geneva Identification System", "GEN# +1.00082008"},
        {"Smithsonian Astrophysical Observation", "SAO 6890"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.44805310),
        dec: Angle.Degrees(+73.02562011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131710"},
        {"Hipparcos Number", "HIP 72575"},
        {"Geneva Identification System", "GEN# +1.00131710"},
        {"Smithsonian Astrophysical Observation", "SAO 8099"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.58565223),
        dec: Angle.Degrees(+73.02777412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56290"},
        {"Hipparcos Number", "HIP 35828"},
        {"Smithsonian Astrophysical Observation", "SAO 6166"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.82923206),
        dec: Angle.Degrees(+73.02839534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22811"},
        {"Hipparcos Number", "HIP 17580"},
        {"Geneva Identification System", "GEN# +1.00022811"},
        {"Smithsonian Astrophysical Observation", "SAO 4979"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.48954931),
        dec: Angle.Degrees(+73.03486773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7664 AB"},
        {"Henry Draper", "HD 87851"},
        {"Hipparcos Number", "HIP 49905"},
        {"Smithsonian Astrophysical Observation", "SAO 7068"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84088863),
        dec: Angle.Degrees(+73.03679063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7650",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1268 A"},
        {"Henry Draper", "HD 9774"},
        {"Hipparcos Number", "HIP 7650"},
        {"Fundamental Katalog 5th Edition", "FK5 51"},
        {"Geneva Identification System", "GEN# +1.00009774A"},
        {"Smithsonian Astrophysical Observation", "SAO 4453"},
        {"Wilson Evans Batten Catalogue", "WEB 1635"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.62892127),
        dec: Angle.Degrees(+73.04007203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212238"},
        {"Hipparcos Number", "HIP 110232"},
        {"Smithsonian Astrophysical Observation", "SAO 10320"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.93890758),
        dec: Angle.Degrees(+73.04058049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24139"},
        {"Smithsonian Astrophysical Observation", "SAO 5448"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.76273733),
        dec: Angle.Degrees(+73.04287307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30388"},
        {"Hipparcos Number", "HIP 22788"},
        {"Geneva Identification System", "GEN# +1.00030388"},
        {"Smithsonian Astrophysical Observation", "SAO 5342"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.52420667),
        dec: Angle.Degrees(+73.04862621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70771"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.11723945),
        dec: Angle.Degrees(+73.05187352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118287"},
        {"Hipparcos Number", "HIP 66106"},
        {"Smithsonian Astrophysical Observation", "SAO 7842"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.26639038),
        dec: Angle.Degrees(+73.05280607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133767"},
        {"Hipparcos Number", "HIP 73474"},
        {"Geneva Identification System", "GEN# +1.00133767"},
        {"Smithsonian Astrophysical Observation", "SAO 8144"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.24895809),
        dec: Angle.Degrees(+73.05309007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127713"},
        {"Hipparcos Number", "HIP 70783"},
        {"Smithsonian Astrophysical Observation", "SAO 8027"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13258833),
        dec: Angle.Degrees(+73.05510699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40000"},
        {"Hipparcos Number", "HIP 28694"},
        {"Smithsonian Astrophysical Observation", "SAO 5718"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.87323950),
        dec: Angle.Degrees(+73.07153710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88815"},
        {"Hipparcos Number", "HIP 50447"},
        {"Geneva Identification System", "GEN# +1.00088815"},
        {"Smithsonian Astrophysical Observation", "SAO 7098"},
        {"Wilson Evans Batten Catalogue", "WEB 9257"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.50494877),
        dec: Angle.Degrees(+73.07367910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27190"},
        {"Hipparcos Number", "HIP 20564"},
        {"Smithsonian Astrophysical Observation", "SAO 5186"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.07199211),
        dec: Angle.Degrees(+73.07390842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161000"},
        {"Hipparcos Number", "HIP 86102"},
        {"Smithsonian Astrophysical Observation", "SAO 8854"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.94911883),
        dec: Angle.Degrees(+73.07748272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199392"},
        {"Hipparcos Number", "HIP 102969"},
        {"Smithsonian Astrophysical Observation", "SAO 9898"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.93099404),
        dec: Angle.Degrees(+73.08029407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47260",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7446 AB"},
        {"Henry Draper", "HD 82685"},
        {"Hipparcos Number", "HIP 47260"},
        {"Smithsonian Astrophysical Observation", "SAO 6915"},
        {"Wilson Evans Batten Catalogue", "WEB 8884"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.48453548),
        dec: Angle.Degrees(+73.08044385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76022"},
        {"Hipparcos Number", "HIP 44104"},
        {"Geneva Identification System", "GEN# +1.00076022"},
        {"Smithsonian Astrophysical Observation", "SAO 6700"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.74415547),
        dec: Angle.Degrees(+73.08096472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36132",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6028 AB"},
        {"Henry Draper", "HD 57044"},
        {"Hipparcos Number", "HIP 36132"},
        {"Geneva Identification System", "GEN# +1.00057044J"},
        {"Smithsonian Astrophysical Observation", "SAO 6187"},
        {"Wilson Evans Batten Catalogue", "WEB 7194"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.64628160),
        dec: Angle.Degrees(+73.08263547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172083"},
        {"Hipparcos Number", "HIP 90760"},
        {"Geneva Identification System", "GEN# +1.00172083"},
        {"Smithsonian Astrophysical Observation", "SAO 9149"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.76249635),
        dec: Angle.Degrees(+73.08355959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6028 C"},
        {"Henry Draper", "HD 57128"},
        {"Hipparcos Number", "HIP 36142"},
        {"Geneva Identification System", "GEN# +1.00057128"},
        {"Smithsonian Astrophysical Observation", "SAO 6190"},
        {"Wilson Evans Batten Catalogue", "WEB 7195"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.67613895),
        dec: Angle.Degrees(+73.08360157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21854"},
        {"Hipparcos Number", "HIP 16887"},
        {"Cincinnati Publication", "Ci 18 463"},
        {"Smithsonian Astrophysical Observation", "SAO 4949"},
        {"Wilson Evans Batten Catalogue", "WEB 3211"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.32791215),
        dec: Angle.Degrees(+73.08393306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11140"},
        {"Smithsonian Astrophysical Observation", "SAO 4634"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84486703),
        dec: Angle.Degrees(+73.09428468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95498"},
        {"Hipparcos Number", "HIP 54033"},
        {"Geneva Identification System", "GEN# +1.00095498"},
        {"Smithsonian Astrophysical Observation", "SAO 7270"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.82743396),
        dec: Angle.Degrees(+73.11223558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164462"},
        {"Hipparcos Number", "HIP 87630"},
        {"Smithsonian Astrophysical Observation", "SAO 8958"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.50566041),
        dec: Angle.Degrees(+73.12123914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5517"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.66010669),
        dec: Angle.Degrees(+73.12144061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1467"},
        {"Hipparcos Number", "HIP 1549"},
        {"Smithsonian Astrophysical Observation", "SAO 4086"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.82558413),
        dec: Angle.Degrees(+73.12261950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154099"},
        {"Hipparcos Number", "HIP 82880"},
        {"Fundamental Katalog 5th Edition", "FK5 3351"},
        {"Geneva Identification System", "GEN# +1.00154099"},
        {"Smithsonian Astrophysical Observation", "SAO 8667"},
        {"Wilson Evans Batten Catalogue", "WEB 14012"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06973909),
        dec: Angle.Degrees(+73.12791647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76146"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.29154978),
        dec: Angle.Degrees(+73.13238594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163183"},
        {"Hipparcos Number", "HIP 87079"},
        {"Geneva Identification System", "GEN# +1.00163183"},
        {"Smithsonian Astrophysical Observation", "SAO 8927"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.90862720),
        dec: Angle.Degrees(+73.13284529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217295"},
        {"Hipparcos Number", "HIP 113387"},
        {"Fundamental Katalog 5th Edition", "FK5 3837"},
        {"Geneva Identification System", "GEN# +1.00217295"},
        {"Smithsonian Astrophysical Observation", "SAO 10566"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.45050082),
        dec: Angle.Degrees(+73.13357387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123030"},
        {"Hipparcos Number", "HIP 68528"},
        {"Smithsonian Astrophysical Observation", "SAO 7931"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43535204),
        dec: Angle.Degrees(+73.13900587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101950"},
        {"Hipparcos Number", "HIP 57277"},
        {"Smithsonian Astrophysical Observation", "SAO 7416"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.17759685),
        dec: Angle.Degrees(+73.14679519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145368"},
        {"Hipparcos Number", "HIP 78703"},
        {"Geneva Identification System", "GEN# +1.00145368"},
        {"Smithsonian Astrophysical Observation", "SAO 8412"},
        {"Wilson Evans Batten Catalogue", "WEB 13304"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.00163196),
        dec: Angle.Degrees(+73.14814981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194931"},
        {"Hipparcos Number", "HIP 100464"},
        {"Geneva Identification System", "GEN# +1.00194931"},
        {"Smithsonian Astrophysical Observation", "SAO 9745"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.59501579),
        dec: Angle.Degrees(+73.15095619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11755"},
        {"Hipparcos Number", "HIP 9242"},
        {"Geneva Identification System", "GEN# +1.00011755"},
        {"Smithsonian Astrophysical Observation", "SAO 4536"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.70918077),
        dec: Angle.Degrees(+73.15252392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156159"},
        {"Hipparcos Number", "HIP 83914"},
        {"Smithsonian Astrophysical Observation", "SAO 8723"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.24821561),
        dec: Angle.Degrees(+73.15336123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53552"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.33124573),
        dec: Angle.Degrees(+73.15637782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73190"},
        {"Hipparcos Number", "HIP 42760"},
        {"Geneva Identification System", "GEN# +1.00073190"},
        {"Smithsonian Astrophysical Observation", "SAO 6618"},
        {"Wilson Evans Batten Catalogue", "WEB 8259"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.71373774),
        dec: Angle.Degrees(+73.16921648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202920"},
        {"Hipparcos Number", "HIP 104847"},
        {"Smithsonian Astrophysical Observation", "SAO 9997"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.58298778),
        dec: Angle.Degrees(+73.17334469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225093"},
        {"Hipparcos Number", "HIP 270"},
        {"Renson", "Renson 61726"},
        {"Smithsonian Astrophysical Observation", "SAO 4020"},
        {"Wilson Evans Batten Catalogue", "WEB 41"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85005688),
        dec: Angle.Degrees(+73.17449052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80028"},
        {"Smithsonian Astrophysical Observation", "SAO 8484"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.04401454),
        dec: Angle.Degrees(+73.17830977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209369"},
        {"Hipparcos Number", "HIP 108535"},
        {"Geneva Identification System", "GEN# +1.00209369"},
        {"Smithsonian Astrophysical Observation", "SAO 10216"},
        {"Wilson Evans Batten Catalogue", "WEB 19541"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.81293227),
        dec: Angle.Degrees(+73.18028413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38976"},
        {"Hipparcos Number", "HIP 28143"},
        {"Geneva Identification System", "GEN# +1.00038976"},
        {"Smithsonian Astrophysical Observation", "SAO 5694"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.21339562),
        dec: Angle.Degrees(+73.19117261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154790"},
        {"Hipparcos Number", "HIP 83219"},
        {"Smithsonian Astrophysical Observation", "SAO 8686"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11633257),
        dec: Angle.Degrees(+73.19424658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201503"},
        {"Hipparcos Number", "HIP 104076"},
        {"Cincinnati Publication", "Ci 18 2742"},
        {"Smithsonian Astrophysical Observation", "SAO 9954"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.28554649),
        dec: Angle.Degrees(+73.20276814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20709"},
        {"Hipparcos Number", "HIP 15983"},
        {"Geneva Identification System", "GEN# +1.00020709"},
        {"Smithsonian Astrophysical Observation", "SAO 4903"},
        {"Wilson Evans Batten Catalogue", "WEB 3050"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.45720390),
        dec: Angle.Degrees(+73.20760240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219"},
        {"Hipparcos Number", "HIP 597"},
        {"Geneva Identification System", "GEN# +1.00000219"},
        {"Smithsonian Astrophysical Observation", "SAO 4038"},
        {"Wilson Evans Batten Catalogue", "WEB 103"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.80711473),
        dec: Angle.Degrees(+73.21031615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219325"},
        {"Hipparcos Number", "HIP 114649"},
        {"Smithsonian Astrophysical Observation", "SAO 10656"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.37800487),
        dec: Angle.Degrees(+73.21222838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23620"},
        {"Hipparcos Number", "HIP 18148"},
        {"Smithsonian Astrophysical Observation", "SAO 5018"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.19897079),
        dec: Angle.Degrees(+73.21279675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45503"},
        {"Geneva Identification System", "GEN# +0.07300453"},
        {"Smithsonian Astrophysical Observation", "SAO 6796"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.08581799),
        dec: Angle.Degrees(+73.21763597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78100"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.20054132),
        dec: Angle.Degrees(+73.21958894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194904"},
        {"Hipparcos Number", "HIP 100458"},
        {"Geneva Identification System", "GEN# +1.00194904"},
        {"Smithsonian Astrophysical Observation", "SAO 9744"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.57835988),
        dec: Angle.Degrees(+73.23012897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10158"},
        {"Smithsonian Astrophysical Observation", "SAO 4591"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.65930113),
        dec: Angle.Degrees(+73.24445924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107760"},
        {"Hipparcos Number", "HIP 60331"},
        {"Cincinnati Publication", "Ci 20 699"},
        {"Cincinnati Publication 2", "Ci 18 1557"},
        {"Geneva Identification System", "GEN# +1.00107760"},
        {"Smithsonian Astrophysical Observation", "SAO 7552"},
        {"Wilson Evans Batten Catalogue", "WEB 10731"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.55273473),
        dec: Angle.Degrees(+73.24803460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -455.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215250"},
        {"Hipparcos Number", "HIP 112025"},
        {"Smithsonian Astrophysical Observation", "SAO 10464"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35980770),
        dec: Angle.Degrees(+73.25691153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115534"},
        {"Hipparcos Number", "HIP 64683"},
        {"Smithsonian Astrophysical Observation", "SAO 7785"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.85876783),
        dec: Angle.Degrees(+73.26058826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33541"},
        {"Hipparcos Number", "HIP 24732"},
        {"Geneva Identification System", "GEN# +1.00033541"},
        {"Smithsonian Astrophysical Observation", "SAO 5483"},
        {"Wilson Evans Batten Catalogue", "WEB 4781"},
    },
    visualMagnitude: 5.81,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.55521962),
        dec: Angle.Degrees(+73.26813649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80711"},
        {"Hipparcos Number", "HIP 46266"},
        {"Smithsonian Astrophysical Observation", "SAO 6849"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.50001720),
        dec: Angle.Degrees(+73.26947293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88514"},
        {"Smithsonian Astrophysical Observation", "SAO 9006"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.11558956),
        dec: Angle.Degrees(+73.27266118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59201"},
        {"Hipparcos Number", "HIP 36954"},
        {"Cincinnati Publication", "Ci 18 897"},
        {"Geneva Identification System", "GEN# +1.00059201"},
        {"Smithsonian Astrophysical Observation", "SAO 6248"},
        {"Wilson Evans Batten Catalogue", "WEB 7331"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.96036867),
        dec: Angle.Degrees(+73.27513607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 334.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17441"},
        {"Hipparcos Number", "HIP 13428"},
        {"Smithsonian Astrophysical Observation", "SAO 4750"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.22661323),
        dec: Angle.Degrees(+73.27724653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16820 AB"},
        {"Hipparcos Number", "HIP 116133"},
        {"Smithsonian Astrophysical Observation", "SAO 10773"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96635535),
        dec: Angle.Degrees(+73.28011528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172975"},
        {"Hipparcos Number", "HIP 91151"},
        {"Geneva Identification System", "GEN# +1.00172975"},
        {"Smithsonian Astrophysical Observation", "SAO 9182"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.94090717),
        dec: Angle.Degrees(+73.28092542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27124"},
        {"Smithsonian Astrophysical Observation", "SAO 5634"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.27839152),
        dec: Angle.Degrees(+73.28316531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103203"},
        {"Hipparcos Number", "HIP 57964"},
        {"Smithsonian Astrophysical Observation", "SAO 7443"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.33966007),
        dec: Angle.Degrees(+73.29178136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73797"},
        {"Hipparcos Number", "HIP 43014"},
        {"Smithsonian Astrophysical Observation", "SAO 6629"},
        {"Wilson Evans Batten Catalogue", "WEB 8308"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.48669863),
        dec: Angle.Degrees(+73.29253075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87609"},
        {"Smithsonian Astrophysical Observation", "SAO 8956"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.45594244),
        dec: Angle.Degrees(+73.29599517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30894"},
        {"Smithsonian Astrophysical Observation", "SAO 5862"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.27436761),
        dec: Angle.Degrees(+73.29799384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109659",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15764 A"},
        {"Henry Draper", "HD 211300"},
        {"Hipparcos Number", "HIP 109659"},
        {"Geneva Identification System", "GEN# +1.00211300A"},
        {"Smithsonian Astrophysical Observation", "SAO 10284"},
        {"Wilson Evans Batten Catalogue", "WEB 19703"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.21967953),
        dec: Angle.Degrees(+73.30714314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154928"},
        {"Hipparcos Number", "HIP 83291"},
        {"Smithsonian Astrophysical Observation", "SAO 8693"},
        {"Wilson Evans Batten Catalogue", "WEB 14077"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.32487395),
        dec: Angle.Degrees(+73.31247163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121811"},
        {"Hipparcos Number", "HIP 67897"},
        {"Smithsonian Astrophysical Observation", "SAO 7903"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.58926120),
        dec: Angle.Degrees(+73.31330760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15764 B"},
        {"Henry Draper", "HD 211300B"},
        {"Hipparcos Number", "HIP 109657"},
        {"Geneva Identification System", "GEN# +1.00211300B"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.21345783),
        dec: Angle.Degrees(+73.31495302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33235"},
        {"Smithsonian Astrophysical Observation", "SAO 6001"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72588941),
        dec: Angle.Degrees(+73.31547030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143077"},
        {"Hipparcos Number", "HIP 77696"},
        {"Geneva Identification System", "GEN# +1.00143077"},
        {"Smithsonian Astrophysical Observation", "SAO 8355"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.95093421),
        dec: Angle.Degrees(+73.31725606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188232"},
        {"Hipparcos Number", "HIP 97391"},
        {"Smithsonian Astrophysical Observation", "SAO 9541"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.91540413),
        dec: Angle.Degrees(+73.32117051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54451"},
        {"Hipparcos Number", "HIP 35157"},
        {"Geneva Identification System", "GEN# +1.00054451"},
        {"Smithsonian Astrophysical Observation", "SAO 6123"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.99915715),
        dec: Angle.Degrees(+73.32244048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151084"},
        {"Hipparcos Number", "HIP 81453"},
        {"Geneva Identification System", "GEN# +1.00151084"},
        {"Smithsonian Astrophysical Observation", "SAO 8582"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.54382375),
        dec: Angle.Degrees(+73.32649805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
