using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_51() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95502"},
        {"Hipparcos Number", "HIP 53879"},
        {"Geneva Identification System", "GEN# +1.00095502"},
        {"Smithsonian Astrophysical Observation", "SAO 156402"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.34705616),
        dec: Angle.Degrees(-12.05947077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121865"},
        {"Hipparcos Number", "HIP 68263"},
        {"Geneva Identification System", "GEN# +1.00121865"},
        {"Smithsonian Astrophysical Observation", "SAO 158267"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.61150396),
        dec: Angle.Degrees(-12.05891836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23393"},
        {"Hipparcos Number", "HIP 17455"},
        {"Geneva Identification System", "GEN# +1.00023393"},
        {"Renson", "Renson 5984"},
        {"Smithsonian Astrophysical Observation", "SAO 149137"},
        {"Wilson Evans Batten Catalogue", "WEB 3309"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.12242629),
        dec: Angle.Degrees(-12.05860452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70709"},
        {"Hipparcos Number", "HIP 41101"},
        {"Smithsonian Astrophysical Observation", "SAO 154182"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76747388),
        dec: Angle.Degrees(-12.05800244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156999"},
        {"Hipparcos Number", "HIP 84913"},
        {"Geneva Identification System", "GEN# +1.00156999"},
        {"Smithsonian Astrophysical Observation", "SAO 160489"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.29839470),
        dec: Angle.Degrees(-12.05703683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5185 AB"},
        {"Henry Draper", "HD 46428"},
        {"Hipparcos Number", "HIP 31212"},
        {"Smithsonian Astrophysical Observation", "SAO 151627"},
        {"Wilson Evans Batten Catalogue", "WEB 6235"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.21013889),
        dec: Angle.Degrees(-12.05663387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125926"},
        {"Hipparcos Number", "HIP 70281"},
        {"Geneva Identification System", "GEN# +1.00125926"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.69055942),
        dec: Angle.Degrees(-12.05600774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83127"},
        {"Smithsonian Astrophysical Observation", "SAO 160212"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.82044183),
        dec: Angle.Degrees(-12.05497898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72927"},
        {"Hipparcos Number", "HIP 42118"},
        {"Smithsonian Astrophysical Observation", "SAO 154427"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.78878084),
        dec: Angle.Degrees(-12.05297631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13917"},
        {"Hipparcos Number", "HIP 10484"},
        {"Geneva Identification System", "GEN# +1.00013917"},
        {"Smithsonian Astrophysical Observation", "SAO 148290"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.79954620),
        dec: Angle.Degrees(-12.05198970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172106"},
        {"Hipparcos Number", "HIP 91431"},
        {"Smithsonian Astrophysical Observation", "SAO 161692"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.68868334),
        dec: Angle.Degrees(-12.05187255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134048"},
        {"Hipparcos Number", "HIP 74059"},
        {"Geneva Identification System", "GEN# +1.00134048"},
        {"Smithsonian Astrophysical Observation", "SAO 159042"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.02704755),
        dec: Angle.Degrees(-12.05127242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4891 AB"},
        {"Henry Draper", "HD 43628"},
        {"Hipparcos Number", "HIP 29811"},
        {"Smithsonian Astrophysical Observation", "SAO 151303"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.17346899),
        dec: Angle.Degrees(-12.04718548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205827"},
        {"Hipparcos Number", "HIP 106833"},
        {"Smithsonian Astrophysical Observation", "SAO 164540"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.56895206),
        dec: Angle.Degrees(-12.04486329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48602"},
        {"Smithsonian Astrophysical Observation", "SAO 155586"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.67655272),
        dec: Angle.Degrees(-12.04474663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30729"},
        {"Hipparcos Number", "HIP 22435"},
        {"Smithsonian Astrophysical Observation", "SAO 149914"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42334950),
        dec: Angle.Degrees(-12.04315964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206471"},
        {"Hipparcos Number", "HIP 107182"},
        {"Smithsonian Astrophysical Observation", "SAO 164594"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.65341894),
        dec: Angle.Degrees(-12.04239843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10174"},
        {"Hipparcos Number", "HIP 7716"},
        {"Smithsonian Astrophysical Observation", "SAO 147932"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83308807),
        dec: Angle.Degrees(-12.04223864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19522"},
        {"Hipparcos Number", "HIP 14563"},
        {"Geneva Identification System", "GEN# +1.00019522"},
        {"Smithsonian Astrophysical Observation", "SAO 148785"},
        {"Wilson Evans Batten Catalogue", "WEB 2829"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.00497764),
        dec: Angle.Degrees(-12.04143634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55137"},
        {"Hipparcos Number", "HIP 34710"},
        {"Geneva Identification System", "GEN# +1.00055137"},
        {"Smithsonian Astrophysical Observation", "SAO 152527"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82400727),
        dec: Angle.Degrees(-12.04118426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1294"},
        {"Hipparcos Number", "HIP 1369"},
        {"Geneva Identification System", "GEN# +1.00001294"},
        {"Smithsonian Astrophysical Observation", "SAO 147201"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27857284),
        dec: Angle.Degrees(-12.04024566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100748"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.39320645),
        dec: Angle.Degrees(-12.04018999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50778"},
        {"Hipparcos Number", "HIP 33160"},
        {"Fundamental Katalog 5th Edition", "FK5 266"},
        {"Geneva Identification System", "GEN# +1.00050778"},
        {"Smithsonian Astrophysical Observation", "SAO 152071"},
        {"Wilson Evans Batten Catalogue", "WEB 6669"},
    },
    visualMagnitude: 4.08,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54783633),
        dec: Angle.Degrees(-12.03859273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88962"},
        {"Geneva Identification System", "GEN# -0.01204935"},
        {"Wilson Evans Batten Catalogue", "WEB 15088"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.38842541),
        dec: Angle.Degrees(-12.03838322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41971"},
        {"Hipparcos Number", "HIP 29046"},
        {"Smithsonian Astrophysical Observation", "SAO 151139"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.92168306),
        dec: Angle.Degrees(-12.03737010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122474"},
        {"Hipparcos Number", "HIP 68573"},
        {"Geneva Identification System", "GEN# +1.00122474"},
        {"Smithsonian Astrophysical Observation", "SAO 158297"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58364037),
        dec: Angle.Degrees(-12.03712601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 770"},
        {"Smithsonian Astrophysical Observation", "SAO 147109"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.36753959),
        dec: Angle.Degrees(-12.03518146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47690"},
        {"Hipparcos Number", "HIP 31842"},
        {"Smithsonian Astrophysical Observation", "SAO 151754"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.86378746),
        dec: Angle.Degrees(-12.03514482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100363"},
        {"Hipparcos Number", "HIP 56327"},
        {"Geneva Identification System", "GEN# +1.00100363"},
        {"Smithsonian Astrophysical Observation", "SAO 156747"},
        {"Wilson Evans Batten Catalogue", "WEB 10127"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.21478122),
        dec: Angle.Degrees(-12.03477352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5956 AB"},
        {"Aitken 2", "ADS 5956"},
        {"Henry Draper", "HD 56593"},
        {"Hipparcos Number", "HIP 35261"},
        {"Geneva Identification System", "GEN# +1.00056593J"},
        {"Smithsonian Astrophysical Observation", "SAO 152660"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.27899207),
        dec: Angle.Degrees(-12.03376909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154865"},
        {"Hipparcos Number", "HIP 83867"},
        {"Geneva Identification System", "GEN# +1.00154865"},
        {"Smithsonian Astrophysical Observation", "SAO 160310"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.10453579),
        dec: Angle.Degrees(-12.03332619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108597"},
        {"Hipparcos Number", "HIP 60878"},
        {"Smithsonian Astrophysical Observation", "SAO 157314"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.15587376),
        dec: Angle.Degrees(-12.03218744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66781"},
        {"Hipparcos Number", "HIP 39531"},
        {"Smithsonian Astrophysical Observation", "SAO 153793"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.18182020),
        dec: Angle.Degrees(-12.02934121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7049"},
        {"Hipparcos Number", "HIP 5528"},
        {"Smithsonian Astrophysical Observation", "SAO 147651"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.69058456),
        dec: Angle.Degrees(-12.02773718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16213"},
        {"Hipparcos Number", "HIP 12085"},
        {"Smithsonian Astrophysical Observation", "SAO 148488"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.94045272),
        dec: Angle.Degrees(-12.02706608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88584"},
        {"Hipparcos Number", "HIP 50022"},
        {"Geneva Identification System", "GEN# +1.00088584"},
        {"Smithsonian Astrophysical Observation", "SAO 155821"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.18933672),
        dec: Angle.Degrees(-12.02648561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147235"},
        {"Hipparcos Number", "HIP 80107"},
        {"Geneva Identification System", "GEN# +1.00147235"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.28139585),
        dec: Angle.Degrees(-12.02637138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102275"},
        {"Hipparcos Number", "HIP 57414"},
        {"Renson", "Renson 29490"},
        {"Smithsonian Astrophysical Observation", "SAO 156876"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.56173546),
        dec: Angle.Degrees(-12.02536145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109556"},
        {"Hipparcos Number", "HIP 61466"},
        {"Smithsonian Astrophysical Observation", "SAO 157384"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.93231019),
        dec: Angle.Degrees(-12.02500142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15907"},
        {"Hipparcos Number", "HIP 11861"},
        {"Smithsonian Astrophysical Observation", "SAO 148455"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.26659492),
        dec: Angle.Degrees(-12.02340286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109545"},
        {"Hipparcos Number", "HIP 61449"},
        {"Geneva Identification System", "GEN# +1.00109545"},
        {"Smithsonian Astrophysical Observation", "SAO 157379"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.88827654),
        dec: Angle.Degrees(-12.02103922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78424"},
        {"Hipparcos Number", "HIP 44793"},
        {"Smithsonian Astrophysical Observation", "SAO 154927"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93205238),
        dec: Angle.Degrees(-12.02074487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106697"},
        {"Hipparcos Number", "HIP 59839"},
        {"Smithsonian Astrophysical Observation", "SAO 157179"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.05866172),
        dec: Angle.Degrees(-12.02071459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93432"},
        {"Hipparcos Number", "HIP 52750"},
        {"Smithsonian Astrophysical Observation", "SAO 156225"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.77871389),
        dec: Angle.Degrees(-12.02012858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161152"},
        {"Hipparcos Number", "HIP 86818"},
        {"Smithsonian Astrophysical Observation", "SAO 160791"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.09496488),
        dec: Angle.Degrees(-12.01900213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130801"},
        {"Hipparcos Number", "HIP 72596"},
        {"Geneva Identification System", "GEN# +1.00130801"},
        {"Smithsonian Astrophysical Observation", "SAO 158835"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.65087189),
        dec: Angle.Degrees(-12.01820834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61465"},
        {"Smithsonian Astrophysical Observation", "SAO 157383"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.93111898),
        dec: Angle.Degrees(-12.01745860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87624"},
        {"Hipparcos Number", "HIP 49455"},
        {"Smithsonian Astrophysical Observation", "SAO 155722"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46053820),
        dec: Angle.Degrees(-12.01731453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148"},
        {"Hipparcos Number", "HIP 524"},
        {"Smithsonian Astrophysical Observation", "SAO 147082"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.58300753),
        dec: Angle.Degrees(-12.01719883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223800"},
        {"Hipparcos Number", "HIP 117747"},
        {"Smithsonian Astrophysical Observation", "SAO 165936"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.19819082),
        dec: Angle.Degrees(-12.01685326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196453"},
        {"Hipparcos Number", "HIP 101809"},
        {"Smithsonian Astrophysical Observation", "SAO 163750"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.46767371),
        dec: Angle.Degrees(-12.01628075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115679"},
        {"Hipparcos Number", "HIP 64953"},
        {"Smithsonian Astrophysical Observation", "SAO 157848"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.70839746),
        dec: Angle.Degrees(-12.01547864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169033"},
        {"Hipparcos Number", "HIP 90096"},
        {"Fundamental Katalog 5th Edition", "FK5 3459"},
        {"Geneva Identification System", "GEN# +1.00169033"},
        {"Smithsonian Astrophysical Observation", "SAO 161415"},
        {"Wilson Evans Batten Catalogue", "WEB 15403"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.80069792),
        dec: Angle.Degrees(-12.01470763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8645 A"},
        {"Henry Draper", "HD 110662"},
        {"Hipparcos Number", "HIP 62109"},
        {"Smithsonian Astrophysical Observation", "SAO 157473"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.94861972),
        dec: Angle.Degrees(-12.01417283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52890"},
        {"Smithsonian Astrophysical Observation", "SAO 156252"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.25604534),
        dec: Angle.Degrees(-12.01345767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20838"},
        {"Smithsonian Astrophysical Observation", "SAO 149654"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.98592756),
        dec: Angle.Degrees(-12.01308248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4145"},
        {"Hipparcos Number", "HIP 3436"},
        {"Geneva Identification System", "GEN# +1.00004145"},
        {"Smithsonian Astrophysical Observation", "SAO 147422"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.95870230),
        dec: Angle.Degrees(-12.01130744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1775"},
        {"Hipparcos Number", "HIP 1739"},
        {"Geneva Identification System", "GEN# +1.00001775"},
        {"Smithsonian Astrophysical Observation", "SAO 147231"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.50000271),
        dec: Angle.Degrees(-12.01053077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159613"},
        {"Hipparcos Number", "HIP 86132"},
        {"Smithsonian Astrophysical Observation", "SAO 160679"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.03752164),
        dec: Angle.Degrees(-12.00956294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12450"},
        {"Hipparcos Number", "HIP 9464"},
        {"Smithsonian Astrophysical Observation", "SAO 148156"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.45179873),
        dec: Angle.Degrees(-12.00813501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21205"},
        {"Hipparcos Number", "HIP 15916"},
        {"Smithsonian Astrophysical Observation", "SAO 148949"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.24151461),
        dec: Angle.Degrees(-12.00764991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18511"},
        {"Hipparcos Number", "HIP 13843"},
        {"Geneva Identification System", "GEN# +1.00018511"},
        {"Smithsonian Astrophysical Observation", "SAO 148690"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.55226007),
        dec: Angle.Degrees(-12.00579638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33693",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5674 AB"},
        {"Henry Draper", "HD 52271"},
        {"Hipparcos Number", "HIP 33693"},
        {"Geneva Identification System", "GEN# +1.00052271J"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.01434325),
        dec: Angle.Degrees(-12.00564144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58625"},
        {"Hipparcos Number", "HIP 36072"},
        {"Geneva Identification System", "GEN# +1.00058625"},
        {"Smithsonian Astrophysical Observation", "SAO 152857"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48911065),
        dec: Angle.Degrees(-12.00447360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47904"},
        {"Wilson Evans Batten Catalogue", "WEB 8960"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.44522878),
        dec: Angle.Degrees(-12.00401907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28377"},
        {"Hipparcos Number", "HIP 20849"},
        {"Geneva Identification System", "GEN# +1.00028377"},
        {"Smithsonian Astrophysical Observation", "SAO 149658"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01673834),
        dec: Angle.Degrees(-12.00211962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57797"},
        {"Hipparcos Number", "HIP 35745"},
        {"Smithsonian Astrophysical Observation", "SAO 152775"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.59039007),
        dec: Angle.Degrees(-11.99601614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139078"},
        {"Hipparcos Number", "HIP 76420"},
        {"Geneva Identification System", "GEN# +1.00139078"},
        {"Smithsonian Astrophysical Observation", "SAO 159378"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11638263),
        dec: Angle.Degrees(-11.99561341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24183"},
        {"Hipparcos Number", "HIP 17977"},
        {"Geneva Identification System", "GEN# +1.00024183"},
        {"Smithsonian Astrophysical Observation", "SAO 149203"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64651806),
        dec: Angle.Degrees(-11.99560543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26325"},
        {"Hipparcos Number", "HIP 19409"},
        {"Smithsonian Astrophysical Observation", "SAO 149413"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.35934895),
        dec: Angle.Degrees(-11.99381346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1260",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 206 A"},
        {"Henry Draper", "HD 1154"},
        {"Hipparcos Number", "HIP 1260"},
        {"Geneva Identification System", "GEN# +1.00001154A"},
        {"Smithsonian Astrophysical Observation", "SAO 147186"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.95387522),
        dec: Angle.Degrees(-11.99015480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221531"},
        {"Hipparcos Number", "HIP 116233"},
        {"Geneva Identification System", "GEN# +1.00221531"},
        {"Renson", "Renson 60720"},
        {"Smithsonian Astrophysical Observation", "SAO 165759"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.24583060),
        dec: Angle.Degrees(-11.98756013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20358"},
        {"Hipparcos Number", "HIP 15224"},
        {"Smithsonian Astrophysical Observation", "SAO 148873"},
        {"Wilson Evans Batten Catalogue", "WEB 2936"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.06370764),
        dec: Angle.Degrees(-11.98590320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156636"},
        {"Hipparcos Number", "HIP 84729"},
        {"Smithsonian Astrophysical Observation", "SAO 160456"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.79042692),
        dec: Angle.Degrees(-11.98564468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71265"},
        {"Hipparcos Number", "HIP 41341"},
        {"Geneva Identification System", "GEN# +1.00071265"},
        {"Smithsonian Astrophysical Observation", "SAO 154249"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.52244521),
        dec: Angle.Degrees(-11.98423367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181477"},
        {"Hipparcos Number", "HIP 95122"},
        {"Smithsonian Astrophysical Observation", "SAO 162501"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.26469649),
        dec: Angle.Degrees(-11.98015049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15336"},
        {"Hipparcos Number", "HIP 11451"},
        {"Smithsonian Astrophysical Observation", "SAO 148401"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.93721226),
        dec: Angle.Degrees(-11.97899520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35336"},
        {"Hipparcos Number", "HIP 25208"},
        {"Smithsonian Astrophysical Observation", "SAO 150398"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.89237985),
        dec: Angle.Degrees(-11.97795696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7715"},
        {"Hipparcos Number", "HIP 5973"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.19543469),
        dec: Angle.Degrees(-11.97518189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80499"},
        {"Hipparcos Number", "HIP 45751"},
        {"Fundamental Katalog 5th Edition", "FK5 2741"},
        {"Geneva Identification System", "GEN# +1.00080499J"},
        {"Smithsonian Astrophysical Observation", "SAO 155096"},
        {"Wilson Evans Batten Catalogue", "WEB 8680"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.94332821),
        dec: Angle.Degrees(-11.97488214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104560"},
        {"Hipparcos Number", "HIP 58710"},
        {"Smithsonian Astrophysical Observation", "SAO 157054"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.62539707),
        dec: Angle.Degrees(-11.97461876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15721"},
        {"Hipparcos Number", "HIP 11718"},
        {"Smithsonian Astrophysical Observation", "SAO 148436"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.81332600),
        dec: Angle.Degrees(-11.97407149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208208"},
        {"Hipparcos Number", "HIP 108180"},
        {"Renson", "Renson 57886"},
        {"Smithsonian Astrophysical Observation", "SAO 164738"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.75755339),
        dec: Angle.Degrees(-11.97024880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24338"},
        {"Hipparcos Number", "HIP 18083"},
        {"Smithsonian Astrophysical Observation", "SAO 149218"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.98091899),
        dec: Angle.Degrees(-11.96812705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74190"},
        {"Hipparcos Number", "HIP 42701"},
        {"Geneva Identification System", "GEN# +1.00074190"},
        {"Renson", "Renson 20670"},
        {"Smithsonian Astrophysical Observation", "SAO 154558"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.54095780),
        dec: Angle.Degrees(-11.96597346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13406"},
        {"Smithsonian Astrophysical Observation", "SAO 148649"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.15558131),
        dec: Angle.Degrees(-11.96590856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22010"},
        {"Hipparcos Number", "HIP 16501"},
        {"Smithsonian Astrophysical Observation", "SAO 149023"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10997042),
        dec: Angle.Degrees(-11.96515235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224973"},
        {"Hipparcos Number", "HIP 177"},
        {"Geneva Identification System", "GEN# +1.00224973"},
        {"Renson", "Renson 61690"},
        {"Smithsonian Astrophysical Observation", "SAO 166006"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.56020401),
        dec: Angle.Degrees(-11.96434717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140492"},
        {"Hipparcos Number", "HIP 77071"},
        {"Geneva Identification System", "GEN# +1.00140492"},
        {"Smithsonian Astrophysical Observation", "SAO 159473"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.06647775),
        dec: Angle.Degrees(-11.96412532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224847"},
        {"Hipparcos Number", "HIP 95"},
        {"Smithsonian Astrophysical Observation", "SAO 166000"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.30203883),
        dec: Angle.Degrees(-11.96400015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190367"},
        {"Hipparcos Number", "HIP 98903"},
        {"Geneva Identification System", "GEN# +1.00190367"},
        {"Smithsonian Astrophysical Observation", "SAO 163242"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.26142311),
        dec: Angle.Degrees(-11.96393242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153099"},
        {"Hipparcos Number", "HIP 83016"},
        {"Smithsonian Astrophysical Observation", "SAO 160191"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.46299875),
        dec: Angle.Degrees(-11.96194544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80105"},
        {"Hipparcos Number", "HIP 45588"},
        {"Geneva Identification System", "GEN# +1.00080105"},
        {"Smithsonian Astrophysical Observation", "SAO 155064"},
        {"Wilson Evans Batten Catalogue", "WEB 8665"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.37175846),
        dec: Angle.Degrees(-11.96186550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93782"},
        {"Hipparcos Number", "HIP 52937"},
        {"Smithsonian Astrophysical Observation", "SAO 156255"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.38700135),
        dec: Angle.Degrees(-11.96090219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50341"},
        {"Geneva Identification System", "GEN# +9.80162038"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.19249019),
        dec: Angle.Degrees(-11.96031015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -417.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -604.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99269"},
        {"Hipparcos Number", "HIP 55745"},
        {"Smithsonian Astrophysical Observation", "SAO 156665"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.32454205),
        dec: Angle.Degrees(-11.95976816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222531"},
        {"Hipparcos Number", "HIP 116878"},
        {"Smithsonian Astrophysical Observation", "SAO 165832"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.36707266),
        dec: Angle.Degrees(-11.95854182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3252 A"},
        {"Henry Draper", "HD 28437"},
        {"Hipparcos Number", "HIP 20893"},
        {"Geneva Identification System", "GEN# +1.00028437"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.16327482),
        dec: Angle.Degrees(-11.95850871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200879"},
        {"Hipparcos Number", "HIP 104186"},
        {"Smithsonian Astrophysical Observation", "SAO 164137"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.62688004),
        dec: Angle.Degrees(-11.95538512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199523"},
        {"Hipparcos Number", "HIP 103487"},
        {"Smithsonian Astrophysical Observation", "SAO 164018"},
        {"Wilson Evans Batten Catalogue", "WEB 18824"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.50806231),
        dec: Angle.Degrees(-11.95489473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224132"},
        {"Hipparcos Number", "HIP 117948"},
        {"Smithsonian Astrophysical Observation", "SAO 165952"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.86575867),
        dec: Angle.Degrees(-11.95396362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123983"},
        {"Hipparcos Number", "HIP 69305"},
        {"Smithsonian Astrophysical Observation", "SAO 158405"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.78226119),
        dec: Angle.Degrees(-11.95256938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22140"},
        {"Smithsonian Astrophysical Observation", "SAO 149867"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.46273556),
        dec: Angle.Degrees(-11.94939322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221398"},
        {"Hipparcos Number", "HIP 116128"},
        {"Smithsonian Astrophysical Observation", "SAO 165740"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96264483),
        dec: Angle.Degrees(-11.94805318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202053"},
        {"Hipparcos Number", "HIP 104795"},
        {"Smithsonian Astrophysical Observation", "SAO 164230"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.45522111),
        dec: Angle.Degrees(-11.94794143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30981"},
        {"Hipparcos Number", "HIP 22592"},
        {"Geneva Identification System", "GEN# +1.00030981"},
        {"Smithsonian Astrophysical Observation", "SAO 149942"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.92291458),
        dec: Angle.Degrees(-11.94761804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157029"},
        {"Hipparcos Number", "HIP 84928"},
        {"Smithsonian Astrophysical Observation", "SAO 160491"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.34106198),
        dec: Angle.Degrees(-11.94697734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45712"},
        {"Hipparcos Number", "HIP 30826"},
        {"Smithsonian Astrophysical Observation", "SAO 151541"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.13999907),
        dec: Angle.Degrees(-11.94651911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83086"},
        {"Hipparcos Number", "HIP 47086"},
        {"Smithsonian Astrophysical Observation", "SAO 155324"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.93752063),
        dec: Angle.Degrees(-11.94592158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225088"},
        {"Hipparcos Number", "HIP 266"},
        {"Smithsonian Astrophysical Observation", "SAO 147055"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.83535989),
        dec: Angle.Degrees(-11.94520986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112433"},
        {"Hipparcos Number", "HIP 63189"},
        {"Smithsonian Astrophysical Observation", "SAO 157613"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.17931436),
        dec: Angle.Degrees(-11.94363457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9808"},
        {"Hipparcos Number", "HIP 7417"},
        {"Smithsonian Astrophysical Observation", "SAO 147897"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.89969177),
        dec: Angle.Degrees(-11.94178411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84706"},
        {"Hipparcos Number", "HIP 47980"},
        {"Smithsonian Astrophysical Observation", "SAO 155471"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.69728976),
        dec: Angle.Degrees(-11.93881974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224578"},
        {"Hipparcos Number", "HIP 118247"},
        {"Geneva Identification System", "GEN# +1.00224578"},
        {"Smithsonian Astrophysical Observation", "SAO 165979"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.76190500),
        dec: Angle.Degrees(-11.93814708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204837"},
        {"Hipparcos Number", "HIP 106281"},
        {"Smithsonian Astrophysical Observation", "SAO 164452"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.89561733),
        dec: Angle.Degrees(-11.93801137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42744"},
        {"Hipparcos Number", "HIP 29423"},
        {"Smithsonian Astrophysical Observation", "SAO 151211"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.98253419),
        dec: Angle.Degrees(-11.93578774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104542"},
        {"Hipparcos Number", "HIP 58704"},
        {"Smithsonian Astrophysical Observation", "SAO 157053"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.61052589),
        dec: Angle.Degrees(-11.93416161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16579 AB"},
        {"Henry Draper", "HD 218928"},
        {"Hipparcos Number", "HIP 114536"},
        {"Smithsonian Astrophysical Observation", "SAO 165551"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.99814943),
        dec: Angle.Degrees(-11.93348897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111428"},
        {"Hipparcos Number", "HIP 62579"},
        {"Smithsonian Astrophysical Observation", "SAO 157531"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.33995619),
        dec: Angle.Degrees(-11.93239603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122269"},
        {"Hipparcos Number", "HIP 68481"},
        {"Smithsonian Astrophysical Observation", "SAO 158293"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.29861271),
        dec: Angle.Degrees(-11.93040206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7365"},
        {"Hipparcos Number", "HIP 5733"},
        {"Smithsonian Astrophysical Observation", "SAO 147678"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.42622421),
        dec: Angle.Degrees(-11.92928348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204309"},
        {"Hipparcos Number", "HIP 105999"},
        {"Smithsonian Astrophysical Observation", "SAO 164411"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.02106883),
        dec: Angle.Degrees(-11.92845975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114544"},
        {"Hipparcos Number", "HIP 64340"},
        {"Smithsonian Astrophysical Observation", "SAO 157777"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.82725883),
        dec: Angle.Degrees(-11.92778579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73940"},
        {"Hipparcos Number", "HIP 42581"},
        {"Geneva Identification System", "GEN# +1.00073940"},
        {"Smithsonian Astrophysical Observation", "SAO 154533"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18243037),
        dec: Angle.Degrees(-11.92718651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210845"},
        {"Hipparcos Number", "HIP 109720"},
        {"Geneva Identification System", "GEN# +1.00210845"},
        {"Smithsonian Astrophysical Observation", "SAO 164935"},
        {"Wilson Evans Batten Catalogue", "WEB 19710"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.35986531),
        dec: Angle.Degrees(-11.92607286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79913"},
        {"Hipparcos Number", "HIP 45507"},
        {"Smithsonian Astrophysical Observation", "SAO 155046"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.10773341),
        dec: Angle.Degrees(-11.92363010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54361"},
        {"Hipparcos Number", "HIP 34413"},
        {"Geneva Identification System", "GEN# +1.00054361A"},
        {"Smithsonian Astrophysical Observation", "SAO 152427"},
        {"Wilson Evans Batten Catalogue", "WEB 6895"},
    },
    visualMagnitude: 6.65,
    bvColour: 2.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.01433246),
        dec: Angle.Degrees(-11.92328376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90004",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alasia"},
        {"Henry Draper", "HD 168746"},
        {"Hipparcos Number", "HIP 90004"},
        {"Geneva Identification System", "GEN# +1.00168746"},
        {"Smithsonian Astrophysical Observation", "SAO 161386"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45748495),
        dec: Angle.Degrees(-11.92251503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14668"},
        {"Hipparcos Number", "HIP 11006"},
        {"Smithsonian Astrophysical Observation", "SAO 148352"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44633736),
        dec: Angle.Degrees(-11.92248704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146792"},
        {"Hipparcos Number", "HIP 79899"},
        {"Geneva Identification System", "GEN# +1.00146792"},
        {"Smithsonian Astrophysical Observation", "SAO 159841"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.62666573),
        dec: Angle.Degrees(-11.92061358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144726"},
        {"Hipparcos Number", "HIP 79021"},
        {"Geneva Identification System", "GEN# +1.00144726"},
        {"Smithsonian Astrophysical Observation", "SAO 159720"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93714581),
        dec: Angle.Degrees(-11.92025677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211749"},
        {"Hipparcos Number", "HIP 110217"},
        {"Smithsonian Astrophysical Observation", "SAO 164999"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.89001035),
        dec: Angle.Degrees(-11.91651423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54306"},
        {"Hipparcos Number", "HIP 34395"},
        {"Celescope Catalog", "CEL 1601"},
        {"Geneva Identification System", "GEN# +1.00054306"},
        {"Geneva Identification System 2", "GEN# +1.00054361B"},
        {"Smithsonian Astrophysical Observation", "SAO 152424"},
        {"Wilson Evans Batten Catalogue", "WEB 6892"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.97050342),
        dec: Angle.Degrees(-11.91400818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109084"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46440393),
        dec: Angle.Degrees(-11.91374790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91816"},
        {"Hipparcos Number", "HIP 51884"},
        {"Geneva Identification System", "GEN# +1.00091816"},
        {"Smithsonian Astrophysical Observation", "SAO 156090"},
        {"Wilson Evans Batten Catalogue", "WEB 9462"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.00886208),
        dec: Angle.Degrees(-11.91268042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223170"},
        {"Hipparcos Number", "HIP 117314"},
        {"Geneva Identification System", "GEN# +1.00223170"},
        {"Smithsonian Astrophysical Observation", "SAO 165880"},
        {"Wilson Evans Batten Catalogue", "WEB 20671"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.81642211),
        dec: Angle.Degrees(-11.91089898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212574"},
        {"Hipparcos Number", "HIP 110688"},
        {"Geneva Identification System", "GEN# +1.00212574"},
        {"Smithsonian Astrophysical Observation", "SAO 165063"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.37948261),
        dec: Angle.Degrees(-11.90802157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43393"},
        {"Hipparcos Number", "HIP 29699"},
        {"Geneva Identification System", "GEN# +1.00043393"},
        {"Smithsonian Astrophysical Observation", "SAO 151272"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.84857205),
        dec: Angle.Degrees(-11.90447627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172792"},
        {"Hipparcos Number", "HIP 91748"},
        {"Smithsonian Astrophysical Observation", "SAO 161750"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.64098015),
        dec: Angle.Degrees(-11.90138120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83376"},
        {"Smithsonian Astrophysical Observation", "SAO 160240"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.60882403),
        dec: Angle.Degrees(-11.90097165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35850"},
        {"Hipparcos Number", "HIP 25486"},
        {"Fundamental Katalog 5th Edition", "FK5 2409"},
        {"Geneva Identification System", "GEN# +1.00035850"},
        {"Smithsonian Astrophysical Observation", "SAO 150461"},
        {"Wilson Evans Batten Catalogue", "WEB 4944"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.76980376),
        dec: Angle.Degrees(-11.90084379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169206"},
        {"Hipparcos Number", "HIP 90180"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.03713920),
        dec: Angle.Degrees(-11.89875721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131530"},
        {"Hipparcos Number", "HIP 72934"},
        {"Geneva Identification System", "GEN# +1.00131530"},
        {"Smithsonian Astrophysical Observation", "SAO 158887"},
        {"Wilson Evans Batten Catalogue", "WEB 12517"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.59544161),
        dec: Angle.Degrees(-11.89833043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147775"},
        {"Hipparcos Number", "HIP 80354"},
        {"Geneva Identification System", "GEN# +1.00147775"},
        {"Smithsonian Astrophysical Observation", "SAO 159896"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.04988553),
        dec: Angle.Degrees(-11.89770083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17032"},
        {"Hipparcos Number", "HIP 12736"},
        {"Smithsonian Astrophysical Observation", "SAO 148570"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.92949277),
        dec: Angle.Degrees(-11.89746460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12177"},
        {"Hipparcos Number", "HIP 9280"},
        {"Smithsonian Astrophysical Observation", "SAO 148143"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.82422759),
        dec: Angle.Degrees(-11.89702129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177758"},
        {"Hipparcos Number", "HIP 93827"},
        {"Cincinnati Publication", "Ci 20 1127"},
        {"Geneva Identification System", "GEN# +1.00177758"},
        {"Smithsonian Astrophysical Observation", "SAO 162195"},
        {"Wilson Evans Batten Catalogue", "WEB 16315"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.60595985),
        dec: Angle.Degrees(-11.89639381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -415.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88135"},
        {"Hipparcos Number", "HIP 49774"},
        {"Smithsonian Astrophysical Observation", "SAO 155773"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.40833401),
        dec: Angle.Degrees(-11.89513590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153851"},
        {"Hipparcos Number", "HIP 83373"},
        {"Geneva Identification System", "GEN# +1.00153851"},
        {"Smithsonian Astrophysical Observation", "SAO 160238"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.59540739),
        dec: Angle.Degrees(-11.89351608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152718"},
        {"Hipparcos Number", "HIP 82815"},
        {"Smithsonian Astrophysical Observation", "SAO 160165"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.87073462),
        dec: Angle.Degrees(-11.89246803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124072"},
        {"Hipparcos Number", "HIP 69348"},
        {"Smithsonian Astrophysical Observation", "SAO 158413"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.89814430),
        dec: Angle.Degrees(-11.89212629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41194"},
        {"Hipparcos Number", "HIP 28657"},
        {"Smithsonian Astrophysical Observation", "SAO 151061"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.77081009),
        dec: Angle.Degrees(-11.89136199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212948"},
        {"Hipparcos Number", "HIP 110902"},
        {"Smithsonian Astrophysical Observation", "SAO 165098"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.03485034),
        dec: Angle.Degrees(-11.89029725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170678"},
        {"Hipparcos Number", "HIP 90774"},
        {"Geneva Identification System", "GEN# +1.00170678"},
        {"Smithsonian Astrophysical Observation", "SAO 161558"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79629473),
        dec: Angle.Degrees(-11.89021798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108214"},
        {"Hipparcos Number", "HIP 60660"},
        {"Smithsonian Astrophysical Observation", "SAO 157281"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.49367808),
        dec: Angle.Degrees(-11.88985863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195435"},
        {"Hipparcos Number", "HIP 101277"},
        {"Geneva Identification System", "GEN# +1.00195435"},
        {"Wilson Evans Batten Catalogue", "WEB 18298"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.92896976),
        dec: Angle.Degrees(-11.88433398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186710"},
        {"Hipparcos Number", "HIP 97297"},
        {"Geneva Identification System", "GEN# +1.00186710"},
        {"Smithsonian Astrophysical Observation", "SAO 162967"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.61172307),
        dec: Angle.Degrees(-11.88406077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70038"},
        {"Hipparcos Number", "HIP 40786"},
        {"Geneva Identification System", "GEN# +1.00070038"},
        {"Smithsonian Astrophysical Observation", "SAO 154111"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.87288144),
        dec: Angle.Degrees(-11.88294011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13130"},
        {"Hipparcos Number", "HIP 9954"},
        {"Geneva Identification System", "GEN# +1.00013130"},
        {"Smithsonian Astrophysical Observation", "SAO 148228"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.03571975),
        dec: Angle.Degrees(-11.88054690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33080"},
        {"Hipparcos Number", "HIP 23829"},
        {"Smithsonian Astrophysical Observation", "SAO 150158"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.84808848),
        dec: Angle.Degrees(-11.87467824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72023"},
        {"Geneva Identification System", "GEN# +9.85740048"},
    },
    visualMagnitude: 11.53,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.98521228),
        dec: Angle.Degrees(-11.87439307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -482.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132614"},
        {"Hipparcos Number", "HIP 73445"},
        {"Smithsonian Astrophysical Observation", "SAO 158964"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.13221684),
        dec: Angle.Degrees(-11.87432546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163827"},
        {"Hipparcos Number", "HIP 88016"},
        {"Smithsonian Astrophysical Observation", "SAO 160956"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66821025),
        dec: Angle.Degrees(-11.87376890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84323"},
        {"Hipparcos Number", "HIP 47760"},
        {"Geneva Identification System", "GEN# +1.00084323"},
        {"Smithsonian Astrophysical Observation", "SAO 155441"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.05906079),
        dec: Angle.Degrees(-11.87244883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3678"},
        {"Geneva Identification System", "GEN# -0.01200134"},
        {"New General Catalogue", "NGC 246"},
    },
    visualMagnitude: 11.77,
    bvColour: -0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.76396773),
        dec: Angle.Degrees(-11.87191699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16620"},
        {"Hipparcos Number", "HIP 12390"},
        {"Geneva Identification System", "GEN# +1.00016620"},
        {"Smithsonian Astrophysical Observation", "SAO 148528"},
        {"Wilson Evans Batten Catalogue", "WEB 2539"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.89054885),
        dec: Angle.Degrees(-11.87158159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196397"},
        {"Hipparcos Number", "HIP 101760"},
        {"Smithsonian Astrophysical Observation", "SAO 163743"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.35668178),
        dec: Angle.Degrees(-11.87052427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56039"},
        {"Hipparcos Number", "HIP 35059"},
        {"Celescope Catalog", "CEL 1707"},
        {"Geneva Identification System", "GEN# +1.00056039"},
        {"Smithsonian Astrophysical Observation", "SAO 152613"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.74964931),
        dec: Angle.Degrees(-11.87041733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127374"},
        {"Hipparcos Number", "HIP 71005"},
        {"Smithsonian Astrophysical Observation", "SAO 158613"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.82740518),
        dec: Angle.Degrees(-11.87014169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5040"},
        {"Hipparcos Number", "HIP 4074"},
        {"Smithsonian Astrophysical Observation", "SAO 147489"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.06039262),
        dec: Angle.Degrees(-11.86981122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149807"},
        {"Hipparcos Number", "HIP 81400"},
        {"Geneva Identification System", "GEN# +1.00149807"},
        {"Smithsonian Astrophysical Observation", "SAO 160011"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.37471194),
        dec: Angle.Degrees(-11.86979132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24244",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3778 A"},
        {"Henry Draper", "HD 33802"},
        {"Henry Draper 2", "HD 33802A"},
        {"Hipparcos Number", "HIP 24244"},
        {"Geneva Identification System", "GEN# +1.00033802A"},
        {"Smithsonian Astrophysical Observation", "SAO 150223"},
        {"Wilson Evans Batten Catalogue", "WEB 4706"},
    },
    visualMagnitude: 4.45,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.07453075),
        dec: Angle.Degrees(-11.86914287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139908"},
        {"Hipparcos Number", "HIP 76828"},
        {"Smithsonian Astrophysical Observation", "SAO 159437"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.29191737),
        dec: Angle.Degrees(-11.86895185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15170"},
        {"Hipparcos Number", "HIP 11353"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.54171702),
        dec: Angle.Degrees(-11.86706813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183596"},
        {"Hipparcos Number", "HIP 95949"},
        {"Smithsonian Astrophysical Observation", "SAO 162706"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.68488781),
        dec: Angle.Degrees(-11.85996239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12702"},
        {"Hipparcos Number", "HIP 9655"},
        {"Smithsonian Astrophysical Observation", "SAO 148180"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.05181354),
        dec: Angle.Degrees(-11.85976239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144071"},
        {"Hipparcos Number", "HIP 78736"},
        {"Geneva Identification System", "GEN# +1.00144071"},
        {"Smithsonian Astrophysical Observation", "SAO 159667"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.10593530),
        dec: Angle.Degrees(-11.85726179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20528"},
        {"Hipparcos Number", "HIP 15342"},
        {"Smithsonian Astrophysical Observation", "SAO 148888"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.46058671),
        dec: Angle.Degrees(-11.85694842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8440 AB"},
        {"Henry Draper", "HD 105590"},
        {"Hipparcos Number", "HIP 59272"},
        {"Geneva Identification System", "GEN# +1.00105590J"},
        {"Smithsonian Astrophysical Observation", "SAO 157111"},
        {"Wilson Evans Batten Catalogue", "WEB 10541"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.36810459),
        dec: Angle.Degrees(-11.85666577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 320.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8440 C"},
        {"Hipparcos Number", "HIP 59273"},
        {"Smithsonian Astrophysical Observation", "SAO 157112"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)09, 29.0200),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)51, 15.000)
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
    primaryId: "HIP 37520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62128"},
        {"Hipparcos Number", "HIP 37520"},
        {"Geneva Identification System", "GEN# +1.00062128"},
        {"Smithsonian Astrophysical Observation", "SAO 153264"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.50826091),
        dec: Angle.Degrees(-11.85283536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54439"},
        {"Hipparcos Number", "HIP 34443"},
        {"Celescope Catalog", "CEL 1605"},
        {"Geneva Identification System", "GEN# +1.00054439"},
        {"Smithsonian Astrophysical Observation", "SAO 152438"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09665978),
        dec: Angle.Degrees(-11.85238061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49570"},
        {"Hipparcos Number", "HIP 32640"},
        {"Smithsonian Astrophysical Observation", "SAO 151953"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.13600918),
        dec: Angle.Degrees(-11.85233313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189606"},
        {"Hipparcos Number", "HIP 98554"},
        {"Smithsonian Astrophysical Observation", "SAO 163186"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.29648492),
        dec: Angle.Degrees(-11.85143520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127601"},
        {"Hipparcos Number", "HIP 71120"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.15551405),
        dec: Angle.Degrees(-11.85104884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11676"},
        {"Hipparcos Number", "HIP 8880"},
        {"Geneva Identification System", "GEN# +1.00011676"},
        {"Smithsonian Astrophysical Observation", "SAO 148095"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.58685350),
        dec: Angle.Degrees(-11.85098750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138789"},
        {"Hipparcos Number", "HIP 76258"},
        {"Smithsonian Astrophysical Observation", "SAO 159357"},
    },
    visualMagnitude: 9.22,
    bvColour: 2.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.65412319),
        dec: Angle.Degrees(-11.85087675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33664"},
        {"Hipparcos Number", "HIP 24169"},
        {"Geneva Identification System", "GEN# +1.00033664"},
        {"Smithsonian Astrophysical Observation", "SAO 150206"},
        {"Wilson Evans Batten Catalogue", "WEB 4694"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.84521813),
        dec: Angle.Degrees(-11.84922715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13681"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.05814797),
        dec: Angle.Degrees(-11.84703869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 257.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111702"},
        {"Hipparcos Number", "HIP 62740"},
        {"Geneva Identification System", "GEN# +1.00111702"},
        {"Renson", "Renson 32410"},
        {"Smithsonian Astrophysical Observation", "SAO 157548"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.83323358),
        dec: Angle.Degrees(-11.84510164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80823"},
        {"Smithsonian Astrophysical Observation", "SAO 159952"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.57260295),
        dec: Angle.Degrees(-11.84490752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146455"},
        {"Hipparcos Number", "HIP 79766"},
        {"Geneva Identification System", "GEN# +1.00146455"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.20045678),
        dec: Angle.Degrees(-11.84114459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12407 AB"},
        {"Henry Draper", "HD 182386"},
        {"Hipparcos Number", "HIP 95442"},
        {"Smithsonian Astrophysical Observation", "SAO 162583"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.21693715),
        dec: Angle.Degrees(-11.84106755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150382"},
        {"Hipparcos Number", "HIP 81680"},
        {"Smithsonian Astrophysical Observation", "SAO 160043"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.28252843),
        dec: Angle.Degrees(-11.83856422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124401"},
        {"Hipparcos Number", "HIP 69500"},
        {"Geneva Identification System", "GEN# +1.00124401"},
        {"Smithsonian Astrophysical Observation", "SAO 158439"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42907929),
        dec: Angle.Degrees(-11.83834252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145897"},
        {"Hipparcos Number", "HIP 79540"},
        {"Geneva Identification System", "GEN# +1.00145897"},
        {"Smithsonian Astrophysical Observation", "SAO 159793"},
        {"Wilson Evans Batten Catalogue", "WEB 13462"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.46211879),
        dec: Angle.Degrees(-11.83772219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57633"},
        {"Hipparcos Number", "HIP 35675"},
        {"Smithsonian Astrophysical Observation", "SAO 152761"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.41516106),
        dec: Angle.Degrees(-11.83371740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123160"},
        {"Hipparcos Number", "HIP 68878"},
        {"Smithsonian Astrophysical Observation", "SAO 158350"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.55361506),
        dec: Angle.Degrees(-11.83271643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7397"},
        {"Hipparcos Number", "HIP 5769"},
        {"Smithsonian Astrophysical Observation", "SAO 147683"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.51590862),
        dec: Angle.Degrees(-11.83206359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110154"},
        {"Hipparcos Number", "HIP 61823"},
        {"Smithsonian Astrophysical Observation", "SAO 157433"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.04713740),
        dec: Angle.Degrees(-11.83038685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14987"},
        {"Hipparcos Number", "HIP 11235"},
        {"Smithsonian Astrophysical Observation", "SAO 148377"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.16121762),
        dec: Angle.Degrees(-11.83005972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123523"},
        {"Hipparcos Number", "HIP 69092"},
        {"Smithsonian Astrophysical Observation", "SAO 158379"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.12080336),
        dec: Angle.Degrees(-11.82943235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38136"},
        {"Hipparcos Number", "HIP 26941"},
        {"Fundamental Katalog 5th Edition", "FK5 4524"},
        {"Smithsonian Astrophysical Observation", "SAO 150733"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75459243),
        dec: Angle.Degrees(-11.82438061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102392"},
        {"Hipparcos Number", "HIP 57494"},
        {"Geneva Identification System", "GEN# +1.00102392"},
        {"Smithsonian Astrophysical Observation", "SAO 156885"},
        {"Wilson Evans Batten Catalogue", "WEB 10325"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.76648871),
        dec: Angle.Degrees(-11.82390048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224817"},
        {"Hipparcos Number", "HIP 80"},
        {"Cincinnati Publication", "Ci 20 1471"},
        {"Geneva Identification System", "GEN# +1.00224817"},
        {"Smithsonian Astrophysical Observation", "SAO 165997"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.24179216),
        dec: Angle.Degrees(-11.82353722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 419.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12460"},
        {"Hipparcos Number", "HIP 9474"},
        {"Geneva Identification System", "GEN# +1.00012460"},
        {"Smithsonian Astrophysical Observation", "SAO 148159"},
        {"Wilson Evans Batten Catalogue", "WEB 1985"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.47508672),
        dec: Angle.Degrees(-11.82188422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187662"},
        {"Hipparcos Number", "HIP 97722"},
        {"Smithsonian Astrophysical Observation", "SAO 163047"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.88854262),
        dec: Angle.Degrees(-11.82121736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44394"},
        {"Hipparcos Number", "HIP 30190"},
        {"Smithsonian Astrophysical Observation", "SAO 151391"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.27262116),
        dec: Angle.Degrees(-11.81732932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111031"},
        {"Hipparcos Number", "HIP 62345"},
        {"Cincinnati Publication", "Ci 18 1623"},
        {"Geneva Identification System", "GEN# +1.00111031"},
        {"Smithsonian Astrophysical Observation", "SAO 157502"},
        {"Wilson Evans Batten Catalogue", "WEB 11072"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.62921655),
        dec: Angle.Degrees(-11.81257452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107814"},
        {"Hipparcos Number", "HIP 60421"},
        {"Geneva Identification System", "GEN# +1.00107814"},
        {"Smithsonian Astrophysical Observation", "SAO 157253"},
        {"Wilson Evans Batten Catalogue", "WEB 10744"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.82873989),
        dec: Angle.Degrees(-11.81209173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125000"},
        {"Hipparcos Number", "HIP 69800"},
        {"Smithsonian Astrophysical Observation", "SAO 158464"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.27879249),
        dec: Angle.Degrees(-11.81147028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45977"},
        {"Hipparcos Number", "HIP 30979"},
        {"Geneva Identification System", "GEN# +1.00045977"},
        {"Smithsonian Astrophysical Observation", "SAO 151572"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.53081151),
        dec: Angle.Degrees(-11.80913399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218358"},
        {"Hipparcos Number", "HIP 114182"},
        {"Smithsonian Astrophysical Observation", "SAO 165504"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.85145994),
        dec: Angle.Degrees(-11.80661670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3975"},
        {"Hipparcos Number", "HIP 3316"},
        {"Fundamental Katalog 5th Edition", "FK5 4060"},
        {"Smithsonian Astrophysical Observation", "SAO 147408"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.56045187),
        dec: Angle.Degrees(-11.80479985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103834"},
        {"Hipparcos Number", "HIP 58304"},
        {"Smithsonian Astrophysical Observation", "SAO 157007"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.34659494),
        dec: Angle.Degrees(-11.80422324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24240"},
        {"Geneva Identification System", "GEN# -0.01101100"},
        {"Smithsonian Astrophysical Observation", "SAO 150222"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.06830594),
        dec: Angle.Degrees(-11.80297251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54879"},
        {"Hipparcos Number", "HIP 34612"},
        {"Celescope Catalog", "CEL 1633"},
        {"Geneva Identification System", "GEN# +1.00054879"},
        {"Smithsonian Astrophysical Observation", "SAO 152491"},
        {"Wilson Evans Batten Catalogue", "WEB 6927"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53396061),
        dec: Angle.Degrees(-11.80273624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23010"},
        {"Hipparcos Number", "HIP 17214"},
        {"Geneva Identification System", "GEN# +1.00023010"},
        {"Smithsonian Astrophysical Observation", "SAO 149107"},
        {"Wilson Evans Batten Catalogue", "WEB 3259"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.30729338),
        dec: Angle.Degrees(-11.80249015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65609"},
        {"Hipparcos Number", "HIP 39027"},
        {"Smithsonian Astrophysical Observation", "SAO 153667"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.78012757),
        dec: Angle.Degrees(-11.80148136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37238"},
        {"Hipparcos Number", "HIP 26346"},
        {"Smithsonian Astrophysical Observation", "SAO 150605"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.14997038),
        dec: Angle.Degrees(-11.80129582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72118"},
        {"Hipparcos Number", "HIP 41747"},
        {"Fundamental Katalog 5th Edition", "FK5 4766"},
        {"Smithsonian Astrophysical Observation", "SAO 154333"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.69389565),
        dec: Angle.Degrees(-11.79972335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195220"},
        {"Hipparcos Number", "HIP 101167"},
        {"Smithsonian Astrophysical Observation", "SAO 163636"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.59226580),
        dec: Angle.Degrees(-11.79916869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25792"},
        {"Hipparcos Number", "HIP 19053"},
        {"Smithsonian Astrophysical Observation", "SAO 149358"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.23439598),
        dec: Angle.Degrees(-11.79903483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36962"},
        {"Hipparcos Number", "HIP 26168"},
        {"Smithsonian Astrophysical Observation", "SAO 150582"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.68592749),
        dec: Angle.Degrees(-11.79853168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83514"},
        {"Hipparcos Number", "HIP 47327"},
        {"Smithsonian Astrophysical Observation", "SAO 155367"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.66747653),
        dec: Angle.Degrees(-11.79737574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50267"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95924095),
        dec: Angle.Degrees(-11.79633631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -296.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194917"},
        {"Hipparcos Number", "HIP 100992"},
        {"Smithsonian Astrophysical Observation", "SAO 163610"},
        {"Wilson Evans Batten Catalogue", "WEB 18243"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.13820543),
        dec: Angle.Degrees(-11.79616530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8411"},
        {"Smithsonian Astrophysical Observation", "SAO 148019"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.12554708),
        dec: Angle.Degrees(-11.79475395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152585"},
        {"Hipparcos Number", "HIP 82737"},
        {"Geneva Identification System", "GEN# +1.00152585"},
        {"Renson", "Renson 43225"},
        {"Smithsonian Astrophysical Observation", "SAO 160159"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.66757022),
        dec: Angle.Degrees(-11.79243237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134193"},
        {"Hipparcos Number", "HIP 74127"},
        {"Geneva Identification System", "GEN# +1.00134193"},
        {"Smithsonian Astrophysical Observation", "SAO 159049"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23629999),
        dec: Angle.Degrees(-11.79046223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205424"},
        {"Hipparcos Number", "HIP 106610"},
        {"Geneva Identification System", "GEN# +1.00205424"},
        {"Smithsonian Astrophysical Observation", "SAO 164503"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.89226993),
        dec: Angle.Degrees(-11.78951661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174133"},
        {"Hipparcos Number", "HIP 92364"},
        {"Smithsonian Astrophysical Observation", "SAO 161873"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36105843),
        dec: Angle.Degrees(-11.78846040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 602"},
        {"Hipparcos Number", "HIP 847"},
        {"Geneva Identification System", "GEN# +1.00000602"},
        {"Smithsonian Astrophysical Observation", "SAO 147124"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.59596953),
        dec: Angle.Degrees(-11.78583365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122123"},
        {"Hipparcos Number", "HIP 68393"},
        {"Smithsonian Astrophysical Observation", "SAO 158282"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01499410),
        dec: Angle.Degrees(-11.78552862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85129"},
        {"Hipparcos Number", "HIP 48198"},
        {"Smithsonian Astrophysical Observation", "SAO 155515"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.38825095),
        dec: Angle.Degrees(-11.78496965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8014 AB"},
        {"Henry Draper", "HD 95332"},
        {"Hipparcos Number", "HIP 53786"},
        {"Smithsonian Astrophysical Observation", "SAO 156384"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.07361622),
        dec: Angle.Degrees(-11.78486493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106609"},
    },
    visualMagnitude: 11.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.88549078),
        dec: Angle.Degrees(-11.78173408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48478"},
        {"Hipparcos Number", "HIP 32183"},
        {"Renson", "Renson 12960"},
        {"Smithsonian Astrophysical Observation", "SAO 151831"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.78852086),
        dec: Angle.Degrees(-11.77878598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37306"},
        {"Hipparcos Number", "HIP 26395"},
        {"Fundamental Katalog 5th Edition", "FK5 2421"},
        {"Geneva Identification System", "GEN# +1.00037306"},
        {"Smithsonian Astrophysical Observation", "SAO 150617"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.28650077),
        dec: Angle.Degrees(-11.77546037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71357"},
        {"Hipparcos Number", "HIP 41393"},
        {"Geneva Identification System", "GEN# +1.00071357"},
        {"Smithsonian Astrophysical Observation", "SAO 154255"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.66945385),
        dec: Angle.Degrees(-11.77472960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39853"},
        {"Hipparcos Number", "HIP 27938"},
        {"Geneva Identification System", "GEN# +1.00039853"},
        {"Smithsonian Astrophysical Observation", "SAO 150932"},
        {"Wilson Evans Batten Catalogue", "WEB 5473"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.68160633),
        dec: Angle.Degrees(-11.77426082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64818"},
        {"Hipparcos Number", "HIP 38694"},
        {"Smithsonian Astrophysical Observation", "SAO 153585"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.83335324),
        dec: Angle.Degrees(-11.77374188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30214",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4978 AB"},
        {"Henry Draper", "HD 44458"},
        {"Hipparcos Number", "HIP 30214"},
        {"Celescope Catalog", "CEL 1194"},
        {"Geneva Identification System", "GEN# +1.00044458J"},
        {"Smithsonian Astrophysical Observation", "SAO 151401"},
        {"Wilson Evans Batten Catalogue", "WEB 6010"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.35299081),
        dec: Angle.Degrees(-11.77324372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206739"},
        {"Hipparcos Number", "HIP 107337"},
        {"Geneva Identification System", "GEN# +1.00206739"},
        {"Smithsonian Astrophysical Observation", "SAO 164618"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09967113),
        dec: Angle.Degrees(-11.77293337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50984"},
        {"Hipparcos Number", "HIP 33247"},
        {"Geneva Identification System", "GEN# +1.00050984"},
        {"Smithsonian Astrophysical Observation", "SAO 152094"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.75922207),
        dec: Angle.Degrees(-11.77054613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8129 AB"},
        {"Henry Draper", "HD 98378"},
        {"Hipparcos Number", "HIP 55247"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.72200587),
        dec: Angle.Degrees(-11.76832883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145438"},
        {"Hipparcos Number", "HIP 79324"},
        {"Smithsonian Astrophysical Observation", "SAO 159758"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.84018435),
        dec: Angle.Degrees(-11.76807588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48439"},
        {"Hipparcos Number", "HIP 32160"},
        {"Smithsonian Astrophysical Observation", "SAO 151825"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.73683924),
        dec: Angle.Degrees(-11.76608480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26133"},
        {"Smithsonian Astrophysical Observation", "SAO 150576"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.58952096),
        dec: Angle.Degrees(-11.76544928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98490"},
        {"Hipparcos Number", "HIP 55314"},
        {"Smithsonian Astrophysical Observation", "SAO 156608"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92014061),
        dec: Angle.Degrees(-11.76479047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196692"},
        {"Hipparcos Number", "HIP 101935"},
        {"Smithsonian Astrophysical Observation", "SAO 163772"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.84720741),
        dec: Angle.Degrees(-11.76418895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62726"},
        {"Hipparcos Number", "HIP 37801"},
        {"Geneva Identification System", "GEN# +1.00062726"},
        {"Smithsonian Astrophysical Observation", "SAO 153344"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.26337970),
        dec: Angle.Degrees(-11.76417673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13079"},
        {"Geneva Identification System", "GEN# -0.01200525"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.02737616),
        dec: Angle.Degrees(-11.76263184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114114"},
        {"Hipparcos Number", "HIP 64118"},
        {"Smithsonian Astrophysical Observation", "SAO 157745"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.11638008),
        dec: Angle.Degrees(-11.76258610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40191"},
        {"Hipparcos Number", "HIP 28133"},
        {"Smithsonian Astrophysical Observation", "SAO 150963"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.19981007),
        dec: Angle.Degrees(-11.76224181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96108"},
        {"Hipparcos Number", "HIP 54172"},
        {"Geneva Identification System", "GEN# +1.00096108"},
        {"Smithsonian Astrophysical Observation", "SAO 156442"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.22390569),
        dec: Angle.Degrees(-11.75935636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61750"},
        {"Hipparcos Number", "HIP 37375"},
        {"Smithsonian Astrophysical Observation", "SAO 153224"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.08758062),
        dec: Angle.Degrees(-11.75251794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30600"},
        {"Hipparcos Number", "HIP 22326"},
        {"Geneva Identification System", "GEN# +1.00030600"},
        {"Smithsonian Astrophysical Observation", "SAO 149900"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.13877704),
        dec: Angle.Degrees(-11.75221900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152394"},
        {"Hipparcos Number", "HIP 82638"},
        {"Smithsonian Astrophysical Observation", "SAO 160146"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39116321),
        dec: Angle.Degrees(-11.74971526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91992"},
        {"Hipparcos Number", "HIP 51974"},
        {"Geneva Identification System", "GEN# +1.00091992"},
        {"Smithsonian Astrophysical Observation", "SAO 156105"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.29809067),
        dec: Angle.Degrees(-11.74853852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16598"},
        {"Hipparcos Number", "HIP 12374"},
        {"Smithsonian Astrophysical Observation", "SAO 148525"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.82159176),
        dec: Angle.Degrees(-11.74814903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30741"},
        {"Hipparcos Number", "HIP 22447"},
        {"Smithsonian Astrophysical Observation", "SAO 149917"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.45098401),
        dec: Angle.Degrees(-11.74756128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116112"},
        {"Hipparcos Number", "HIP 65191"},
        {"Smithsonian Astrophysical Observation", "SAO 157881"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.39727312),
        dec: Angle.Degrees(-11.74701959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128113"},
        {"Hipparcos Number", "HIP 71340"},
        {"Smithsonian Astrophysical Observation", "SAO 158662"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.83843417),
        dec: Angle.Degrees(-11.74681369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -273.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16433"},
        {"Hipparcos Number", "HIP 12267"},
        {"Smithsonian Astrophysical Observation", "SAO 148512"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.48905941),
        dec: Angle.Degrees(-11.74463253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73431"},
        {"Hipparcos Number", "HIP 42348"},
        {"Geneva Identification System", "GEN# +1.00073431"},
        {"Smithsonian Astrophysical Observation", "SAO 154475"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.50688389),
        dec: Angle.Degrees(-11.74373017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165967"},
        {"Hipparcos Number", "HIP 88916"},
        {"Smithsonian Astrophysical Observation", "SAO 161113"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.24962349),
        dec: Angle.Degrees(-11.74367859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24134"},
        {"Hipparcos Number", "HIP 17949"},
        {"Smithsonian Astrophysical Observation", "SAO 149196"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.56271049),
        dec: Angle.Degrees(-11.74180704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145938"},
        {"Hipparcos Number", "HIP 79561"},
        {"Smithsonian Astrophysical Observation", "SAO 159796"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.51645985),
        dec: Angle.Degrees(-11.73756330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27373"},
        {"Hipparcos Number", "HIP 20115"},
        {"Fundamental Katalog 5th Edition", "FK5 4397"},
        {"Smithsonian Astrophysical Observation", "SAO 149529"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.69790140),
        dec: Angle.Degrees(-11.73704992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214248"},
        {"Hipparcos Number", "HIP 111652"},
        {"Smithsonian Astrophysical Observation", "SAO 165198"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.27622327),
        dec: Angle.Degrees(-11.73100877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19621"},
        {"Hipparcos Number", "HIP 14645"},
        {"Smithsonian Astrophysical Observation", "SAO 148794"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.31583040),
        dec: Angle.Degrees(-11.73059873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137810"},
        {"Hipparcos Number", "HIP 75832"},
        {"Smithsonian Astrophysical Observation", "SAO 159291"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.35582388),
        dec: Angle.Degrees(-11.73035100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87424"},
        {"Hipparcos Number", "HIP 49366"},
        {"Fundamental Katalog 5th Edition", "FK5 4894"},
        {"Smithsonian Astrophysical Observation", "SAO 155709"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.15738731),
        dec: Angle.Degrees(-11.72964083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201590"},
        {"Hipparcos Number", "HIP 104559"},
        {"Smithsonian Astrophysical Observation", "SAO 164196"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.70049217),
        dec: Angle.Degrees(-11.72917599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194958"},
        {"Hipparcos Number", "HIP 101019"},
        {"Geneva Identification System", "GEN# +1.00194958"},
        {"Smithsonian Astrophysical Observation", "SAO 163615"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.20025090),
        dec: Angle.Degrees(-11.72651160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166144"},
        {"Hipparcos Number", "HIP 88984"},
        {"Geneva Identification System", "GEN# +1.00166144"},
        {"Smithsonian Astrophysical Observation", "SAO 161127"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.43904268),
        dec: Angle.Degrees(-11.72467096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223728"},
        {"Hipparcos Number", "HIP 117696"},
        {"Smithsonian Astrophysical Observation", "SAO 165925"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.04252044),
        dec: Angle.Degrees(-11.72060733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75963"},
        {"Hipparcos Number", "HIP 43608"},
        {"Geneva Identification System", "GEN# +1.00075963"},
        {"Smithsonian Astrophysical Observation", "SAO 154710"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.21782981),
        dec: Angle.Degrees(-11.71788463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26390"},
        {"Smithsonian Astrophysical Observation", "SAO 150615"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.27266461),
        dec: Angle.Degrees(-11.71743656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81323"},
        {"Smithsonian Astrophysical Observation", "SAO 160001"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.14170554),
        dec: Angle.Degrees(-11.71706244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189286"},
        {"Hipparcos Number", "HIP 98398"},
        {"Geneva Identification System", "GEN# +1.00189286"},
        {"Smithsonian Astrophysical Observation", "SAO 163166"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.89166081),
        dec: Angle.Degrees(-11.71689428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15391"},
        {"Hipparcos Number", "HIP 11504"},
        {"Geneva Identification System", "GEN# +1.00015391"},
        {"Smithsonian Astrophysical Observation", "SAO 148403"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07945675),
        dec: Angle.Degrees(-11.71639637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180058"},
        {"Hipparcos Number", "HIP 94633"},
        {"Renson", "Renson 50000"},
        {"Smithsonian Astrophysical Observation", "SAO 162372"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85784910),
        dec: Angle.Degrees(-11.71490900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213181"},
        {"Hipparcos Number", "HIP 111044"},
        {"Smithsonian Astrophysical Observation", "SAO 165119"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.43987830),
        dec: Angle.Degrees(-11.71428161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126035"},
        {"Hipparcos Number", "HIP 70336"},
        {"Fundamental Katalog 5th Edition", "FK5 1374"},
        {"Geneva Identification System", "GEN# +1.00126035"},
        {"Smithsonian Astrophysical Observation", "SAO 158528"},
        {"Wilson Evans Batten Catalogue", "WEB 12210"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.85679335),
        dec: Angle.Degrees(-11.71390001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219659"},
        {"Hipparcos Number", "HIP 115015"},
        {"Geneva Identification System", "GEN# +1.00219659"},
        {"Smithsonian Astrophysical Observation", "SAO 165609"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.41691068),
        dec: Angle.Degrees(-11.71295483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23263"},
        {"Hipparcos Number", "HIP 17381"},
        {"Smithsonian Astrophysical Observation", "SAO 149130"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.84074434),
        dec: Angle.Degrees(-11.71220794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8444"},
        {"Hipparcos Number", "HIP 6499"},
        {"Smithsonian Astrophysical Observation", "SAO 147775"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.87351761),
        dec: Angle.Degrees(-11.71129362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2065"},
        {"Hipparcos Number", "HIP 1964"},
        {"Geneva Identification System", "GEN# +1.00002065"},
        {"Smithsonian Astrophysical Observation", "SAO 147257"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.20856180),
        dec: Angle.Degrees(-11.71083712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18259"},
        {"Hipparcos Number", "HIP 13630"},
        {"Smithsonian Astrophysical Observation", "SAO 148667"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88244433),
        dec: Angle.Degrees(-11.70578214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194285"},
        {"Hipparcos Number", "HIP 100716"},
        {"Geneva Identification System", "GEN# +1.00194285"},
        {"Smithsonian Astrophysical Observation", "SAO 163549"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.28356434),
        dec: Angle.Degrees(-11.70459796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10515 AB"},
        {"Henry Draper", "HD 157499"},
        {"Hipparcos Number", "HIP 85151"},
        {"Smithsonian Astrophysical Observation", "SAO 160518"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.01164833),
        dec: Angle.Degrees(-11.70191865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20964"},
        {"Hipparcos Number", "HIP 15727"},
        {"Smithsonian Astrophysical Observation", "SAO 148924"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.64867345),
        dec: Angle.Degrees(-11.70077762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113519"},
        {"Hipparcos Number", "HIP 63782"},
        {"Smithsonian Astrophysical Observation", "SAO 157696"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.09506989),
        dec: Angle.Degrees(-11.69893150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137396"},
        {"Hipparcos Number", "HIP 75554"},
        {"Geneva Identification System", "GEN# +1.00137396"},
        {"Smithsonian Astrophysical Observation", "SAO 159257"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52467754),
        dec: Angle.Degrees(-11.69877077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32724"},
        {"Hipparcos Number", "HIP 23627"},
        {"Geneva Identification System", "GEN# +1.00032724"},
        {"Smithsonian Astrophysical Observation", "SAO 150123"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.19800085),
        dec: Angle.Degrees(-11.69850172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77916"},
        {"Hipparcos Number", "HIP 44580"},
        {"Smithsonian Astrophysical Observation", "SAO 154886"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.24179121),
        dec: Angle.Degrees(-11.69813058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31851",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5309 AB"},
        {"Henry Draper", "HD 47714"},
        {"Hipparcos Number", "HIP 31851"},
        {"Renson", "Renson 12810"},
        {"Smithsonian Astrophysical Observation", "SAO 151758"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.88606729),
        dec: Angle.Degrees(-11.69769106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207061"},
        {"Hipparcos Number", "HIP 107527"},
        {"Geneva Identification System", "GEN# +1.00207061"},
        {"Smithsonian Astrophysical Observation", "SAO 164640"},
        {"Wilson Evans Batten Catalogue", "WEB 19408"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.67529714),
        dec: Angle.Degrees(-11.69752642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200157"},
        {"Hipparcos Number", "HIP 103801"},
        {"Geneva Identification System", "GEN# +1.00200157"},
        {"Smithsonian Astrophysical Observation", "SAO 164074"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.49935543),
        dec: Angle.Degrees(-11.69619563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192564"},
        {"Hipparcos Number", "HIP 99883"},
        {"Smithsonian Astrophysical Observation", "SAO 163396"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.97994469),
        dec: Angle.Degrees(-11.69618622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121185"},
        {"Hipparcos Number", "HIP 67876"},
        {"Smithsonian Astrophysical Observation", "SAO 158223"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.53301151),
        dec: Angle.Degrees(-11.69541647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53140"},
        {"Smithsonian Astrophysical Observation", "SAO 156283"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04981555),
        dec: Angle.Degrees(-11.69330453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 821"},
        {"Hipparcos Number", "HIP 1005"},
        {"Smithsonian Astrophysical Observation", "SAO 147148"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.13814549),
        dec: Angle.Degrees(-11.69298041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224525"},
        {"Hipparcos Number", "HIP 118208"},
        {"Smithsonian Astrophysical Observation", "SAO 165976"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.66826345),
        dec: Angle.Degrees(-11.68881194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63068"},
        {"Hipparcos Number", "HIP 37941"},
        {"Smithsonian Astrophysical Observation", "SAO 153385"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.64523748),
        dec: Angle.Degrees(-11.68800627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105204"},
        {"Hipparcos Number", "HIP 59065"},
        {"Smithsonian Astrophysical Observation", "SAO 157084"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69254317),
        dec: Angle.Degrees(-11.68241091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13019"},
        {"Hipparcos Number", "HIP 9887"},
        {"Geneva Identification System", "GEN# +1.00013019"},
        {"Smithsonian Astrophysical Observation", "SAO 148215"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.80129313),
        dec: Angle.Degrees(-11.68229493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138903"},
        {"Hipparcos Number", "HIP 76322"},
        {"Geneva Identification System", "GEN# +1.00138903"},
        {"Smithsonian Astrophysical Observation", "SAO 159367"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.84509292),
        dec: Angle.Degrees(-11.68223884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107758"},
        {"Cincinnati Publication", "Ci 20 1315"},
        {"Geneva Identification System", "GEN# +9.80026032"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.44215285),
        dec: Angle.Degrees(-11.68176984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -304.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222493"},
        {"Hipparcos Number", "HIP 116853"},
        {"Geneva Identification System", "GEN# +1.00222493"},
        {"Smithsonian Astrophysical Observation", "SAO 165828"},
        {"Wilson Evans Batten Catalogue", "WEB 20615"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.28696291),
        dec: Angle.Degrees(-11.68066248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6927"},
        {"Hipparcos Number", "HIP 5442"},
        {"Smithsonian Astrophysical Observation", "SAO 147641"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.40006557),
        dec: Angle.Degrees(-11.67854603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96906"},
        {"Hipparcos Number", "HIP 54523"},
        {"Smithsonian Astrophysical Observation", "SAO 156498"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.32943886),
        dec: Angle.Degrees(-11.67777541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16242"},
        {"Geneva Identification System", "GEN# -0.01200662"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.33233109),
        dec: Angle.Degrees(-11.67762800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44858"},
        {"Hipparcos Number", "HIP 30412"},
        {"Smithsonian Astrophysical Observation", "SAO 151444"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.91780542),
        dec: Angle.Degrees(-11.67550087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65023",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8858 AB"},
        {"Henry Draper", "HD 115813"},
        {"Hipparcos Number", "HIP 65023"},
        {"Smithsonian Astrophysical Observation", "SAO 157860"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.93384474),
        dec: Angle.Degrees(-11.67293545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152329"},
        {"Hipparcos Number", "HIP 82602"},
        {"Smithsonian Astrophysical Observation", "SAO 160145"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.29435251),
        dec: Angle.Degrees(-11.67249855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131481"},
        {"Hipparcos Number", "HIP 72919"},
        {"Smithsonian Astrophysical Observation", "SAO 158884"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.54229996),
        dec: Angle.Degrees(-11.67194134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6305"},
        {"Hipparcos Number", "HIP 4977"},
        {"Geneva Identification System", "GEN# +1.00006305"},
        {"Smithsonian Astrophysical Observation", "SAO 147587"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.94427681),
        dec: Angle.Degrees(-11.67135692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70452",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9254 AB"},
        {"Henry Draper", "HD 126251"},
        {"Hipparcos Number", "HIP 70452"},
        {"Geneva Identification System", "GEN# +1.00126251"},
        {"Smithsonian Astrophysical Observation", "SAO 158550"},
        {"Wilson Evans Batten Catalogue", "WEB 12223"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.17040452),
        dec: Angle.Degrees(-11.66964736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204268"},
        {"Hipparcos Number", "HIP 105965"},
        {"Geneva Identification System", "GEN# +1.00204268"},
        {"Smithsonian Astrophysical Observation", "SAO 164405"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.91039295),
        dec: Angle.Degrees(-11.66678817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133410"},
        {"Hipparcos Number", "HIP 73760"},
        {"Smithsonian Astrophysical Observation", "SAO 159007"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.16681085),
        dec: Angle.Degrees(-11.66491936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185589"},
        {"Hipparcos Number", "HIP 96769"},
        {"Smithsonian Astrophysical Observation", "SAO 162878"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05227549),
        dec: Angle.Degrees(-11.66188550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32600"},
        {"Hipparcos Number", "HIP 23549"},
        {"Smithsonian Astrophysical Observation", "SAO 150107"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.96486027),
        dec: Angle.Degrees(-11.66183389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106093"},
        {"Hipparcos Number", "HIP 59526"},
        {"Smithsonian Astrophysical Observation", "SAO 157147"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10319773),
        dec: Angle.Degrees(-11.65914961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2438"},
        {"Hipparcos Number", "HIP 2215"},
        {"Fundamental Katalog 5th Edition", "FK5 1011"},
        {"Geneva Identification System", "GEN# +1.00002438"},
        {"Smithsonian Astrophysical Observation", "SAO 147289"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.00218240),
        dec: Angle.Degrees(-11.65876340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56266"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.01062865),
        dec: Angle.Degrees(-11.65802145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198865"},
        {"Hipparcos Number", "HIP 103125"},
        {"Smithsonian Astrophysical Observation", "SAO 163960"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41609674),
        dec: Angle.Degrees(-11.65469010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74048"},
        {"Smithsonian Astrophysical Observation", "SAO 159041"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98793340),
        dec: Angle.Degrees(-11.65158964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170834"},
        {"Hipparcos Number", "HIP 90849"},
        {"Smithsonian Astrophysical Observation", "SAO 161574"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.99987770),
        dec: Angle.Degrees(-11.64927099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177708"},
        {"Hipparcos Number", "HIP 93809"},
        {"Geneva Identification System", "GEN# +1.00177708"},
        {"Smithsonian Astrophysical Observation", "SAO 162189"},
        {"Wilson Evans Batten Catalogue", "WEB 16310"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.57577912),
        dec: Angle.Degrees(-11.64917435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211360"},
        {"Hipparcos Number", "HIP 109998"},
        {"Geneva Identification System", "GEN# +1.00211360"},
        {"Smithsonian Astrophysical Observation", "SAO 164973"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.18911671),
        dec: Angle.Degrees(-11.64900438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33550"},
        {"Hipparcos Number", "HIP 24099"},
        {"Smithsonian Astrophysical Observation", "SAO 150194"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.64218571),
        dec: Angle.Degrees(-11.64863513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112131"},
        {"Hipparcos Number", "HIP 62983"},
        {"Geneva Identification System", "GEN# +1.00112131"},
        {"Smithsonian Astrophysical Observation", "SAO 157584"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.57809243),
        dec: Angle.Degrees(-11.64859567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19761"},
        {"Hipparcos Number", "HIP 14755"},
        {"Smithsonian Astrophysical Observation", "SAO 148807"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.63925741),
        dec: Angle.Degrees(-11.64691471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4458 AB"},
        {"Henry Draper", "HD 39319"},
        {"Hipparcos Number", "HIP 27657"},
        {"Smithsonian Astrophysical Observation", "SAO 150869"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.84010936),
        dec: Angle.Degrees(-11.64619989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21779"},
        {"Hipparcos Number", "HIP 16308"},
        {"Geneva Identification System", "GEN# +1.00021779"},
        {"Smithsonian Astrophysical Observation", "SAO 148994"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55506605),
        dec: Angle.Degrees(-11.64610765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38072"},
        {"Hipparcos Number", "HIP 26892"},
        {"Smithsonian Astrophysical Observation", "SAO 150721"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.63558218),
        dec: Angle.Degrees(-11.64439819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128354"},
        {"Hipparcos Number", "HIP 71451"},
        {"Smithsonian Astrophysical Observation", "SAO 158675"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.17925340),
        dec: Angle.Degrees(-11.64332404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197364"},
        {"Hipparcos Number", "HIP 102291"},
        {"Geneva Identification System", "GEN# +1.00197364"},
        {"Smithsonian Astrophysical Observation", "SAO 163830"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.89486589),
        dec: Angle.Degrees(-11.64145253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79814"},
        {"Hipparcos Number", "HIP 45457"},
        {"Smithsonian Astrophysical Observation", "SAO 155040"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.96248639),
        dec: Angle.Degrees(-11.64000575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31742"},
        {"Hipparcos Number", "HIP 23073"},
        {"Smithsonian Astrophysical Observation", "SAO 150031"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.46971814),
        dec: Angle.Degrees(-11.63893742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144214"},
        {"Hipparcos Number", "HIP 78790"},
        {"Geneva Identification System", "GEN# +1.00144214"},
        {"Smithsonian Astrophysical Observation", "SAO 159679"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.27016035),
        dec: Angle.Degrees(-11.63811753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192349"},
        {"Hipparcos Number", "HIP 99795"},
        {"Smithsonian Astrophysical Observation", "SAO 163379"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.71410527),
        dec: Angle.Degrees(-11.63657268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29125"},
        {"Hipparcos Number", "HIP 21329"},
        {"Smithsonian Astrophysical Observation", "SAO 149739"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.66519763),
        dec: Angle.Degrees(-11.63580757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90979"},
        {"Cincinnati Publication", "Ci 20 1091"},
        {"Geneva Identification System", "GEN# -0.01104672"},
        {"Smithsonian Astrophysical Observation", "SAO 161603"},
        {"Wilson Evans Batten Catalogue", "WEB 15609"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37084801),
        dec: Angle.Degrees(-11.63546130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -285.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168206"},
        {"Hipparcos Number", "HIP 89769"},
        {"Geneva Identification System", "GEN# +1.00168206"},
        {"Smithsonian Astrophysical Observation", "SAO 161325"},
        {"Wilson Evans Batten Catalogue", "WEB 15308"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.78068103),
        dec: Angle.Degrees(-11.63309734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219404"},
        {"Hipparcos Number", "HIP 114829"},
        {"Smithsonian Astrophysical Observation", "SAO 165592"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.90243889),
        dec: Angle.Degrees(-11.63219218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87708",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10878 AB"},
        {"Henry Draper", "HD 163117"},
        {"Hipparcos Number", "HIP 87708"},
        {"Smithsonian Astrophysical Observation", "SAO 160899"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.73215670),
        dec: Angle.Degrees(-11.63191983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11663"},
        {"Hipparcos Number", "HIP 8874"},
        {"Smithsonian Astrophysical Observation", "SAO 148093"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.56193778),
        dec: Angle.Degrees(-11.62855108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25898"},
        {"Hipparcos Number", "HIP 19106"},
        {"Geneva Identification System", "GEN# +1.00025898"},
        {"Smithsonian Astrophysical Observation", "SAO 149366"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42925405),
        dec: Angle.Degrees(-11.62746001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64332"},
        {"Hipparcos Number", "HIP 38502"},
        {"Geneva Identification System", "GEN# +1.00064332"},
        {"Smithsonian Astrophysical Observation", "SAO 153536"},
        {"Wilson Evans Batten Catalogue", "WEB 7566"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.27197082),
        dec: Angle.Degrees(-11.62480144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145234"},
        {"Hipparcos Number", "HIP 79228"},
        {"Smithsonian Astrophysical Observation", "SAO 159749"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.54026264),
        dec: Angle.Degrees(-11.62215365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109271"},
        {"Hipparcos Number", "HIP 61300"},
        {"Geneva Identification System", "GEN# +1.00109271"},
        {"Smithsonian Astrophysical Observation", "SAO 157362"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39856586),
        dec: Angle.Degrees(-11.62206563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158524"},
        {"Hipparcos Number", "HIP 85658"},
        {"Smithsonian Astrophysical Observation", "SAO 160588"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.58186641),
        dec: Angle.Degrees(-11.62153367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129679"},
        {"Hipparcos Number", "HIP 72053"},
        {"Smithsonian Astrophysical Observation", "SAO 158766"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.07028309),
        dec: Angle.Degrees(-11.61729175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9073"},
        {"Hipparcos Number", "HIP 6926"},
        {"Smithsonian Astrophysical Observation", "SAO 147833"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.30382679),
        dec: Angle.Degrees(-11.61708182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78902"},
        {"Hipparcos Number", "HIP 45030"},
        {"Smithsonian Astrophysical Observation", "SAO 154969"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.58250281),
        dec: Angle.Degrees(-11.61667873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216494"},
        {"Hipparcos Number", "HIP 113031"},
        {"Geneva Identification System", "GEN# +1.00216494"},
        {"Renson", "Renson 59790"},
        {"Smithsonian Astrophysical Observation", "SAO 165359"},
        {"Wilson Evans Batten Catalogue", "WEB 20122"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.36954639),
        dec: Angle.Degrees(-11.61651887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20000"},
        {"Hipparcos Number", "HIP 14919"},
        {"Smithsonian Astrophysical Observation", "SAO 148833"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.11997157),
        dec: Angle.Degrees(-11.61538775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34981"},
        {"Hipparcos Number", "HIP 24982"},
        {"Smithsonian Astrophysical Observation", "SAO 150361"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.24264842),
        dec: Angle.Degrees(-11.61494690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210151"},
        {"Hipparcos Number", "HIP 109298"},
        {"Smithsonian Astrophysical Observation", "SAO 164883"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.14218468),
        dec: Angle.Degrees(-11.61349038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267"},
        {"Hipparcos Number", "HIP 609"},
        {"Renson", "Renson 16"},
        {"Smithsonian Astrophysical Observation", "SAO 147092"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.84680800),
        dec: Angle.Degrees(-11.61292585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60260"},
        {"Hipparcos Number", "HIP 36722"},
        {"Geneva Identification System", "GEN# +1.00060260"},
        {"Smithsonian Astrophysical Observation", "SAO 153052"},
        {"Wilson Evans Batten Catalogue", "WEB 7299"},
    },
    visualMagnitude: 9.04,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.29685487),
        dec: Angle.Degrees(-11.61172761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155487"},
        {"Hipparcos Number", "HIP 84161"},
        {"Smithsonian Astrophysical Observation", "SAO 160357"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08511211),
        dec: Angle.Degrees(-11.61135193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108107"},
        {"Hipparcos Number", "HIP 60595"},
        {"Geneva Identification System", "GEN# +1.00108107"},
        {"Smithsonian Astrophysical Observation", "SAO 157272"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.29917028),
        dec: Angle.Degrees(-11.61051268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223572"},
        {"Hipparcos Number", "HIP 117579"},
        {"Smithsonian Astrophysical Observation", "SAO 165907"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.67510771),
        dec: Angle.Degrees(-11.60925056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207550"},
        {"Hipparcos Number", "HIP 107778"},
        {"Geneva Identification System", "GEN# +1.00207550"},
        {"Smithsonian Astrophysical Observation", "SAO 164684"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52023482),
        dec: Angle.Degrees(-11.60728037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14547"},
        {"Hipparcos Number", "HIP 10928"},
        {"Geneva Identification System", "GEN# +1.00014547"},
        {"Smithsonian Astrophysical Observation", "SAO 148340"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.18223121),
        dec: Angle.Degrees(-11.60674614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214745"},
        {"Hipparcos Number", "HIP 111930"},
        {"Smithsonian Astrophysical Observation", "SAO 165228"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.08632423),
        dec: Angle.Degrees(-11.60520129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151295"},
        {"Hipparcos Number", "HIP 82151"},
        {"Smithsonian Astrophysical Observation", "SAO 160093"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.74434802),
        dec: Angle.Degrees(-11.60424995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197454"},
        {"Hipparcos Number", "HIP 102342"},
        {"Smithsonian Astrophysical Observation", "SAO 163837"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.03803133),
        dec: Angle.Degrees(-11.60363906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55516"},
        {"Hipparcos Number", "HIP 34864"},
        {"Smithsonian Astrophysical Observation", "SAO 152559"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20914303),
        dec: Angle.Degrees(-11.60030676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190390"},
        {"Hipparcos Number", "HIP 98910"},
        {"Geneva Identification System", "GEN# +1.00190390"},
        {"Smithsonian Astrophysical Observation", "SAO 163245"},
        {"Wilson Evans Batten Catalogue", "WEB 17557"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27256290),
        dec: Angle.Degrees(-11.59937704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2553"},
        {"Hipparcos Number", "HIP 2283"},
        {"Smithsonian Astrophysical Observation", "SAO 147299"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.29345951),
        dec: Angle.Degrees(-11.59812043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218459"},
        {"Hipparcos Number", "HIP 114255"},
        {"Smithsonian Astrophysical Observation", "SAO 165509"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.08801386),
        dec: Angle.Degrees(-11.59697134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43995"},
        {"Hipparcos Number", "HIP 29983"},
        {"Smithsonian Astrophysical Observation", "SAO 151341"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.67992287),
        dec: Angle.Degrees(-11.59467084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128784"},
        {"Hipparcos Number", "HIP 71646"},
        {"Smithsonian Astrophysical Observation", "SAO 158701"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81678398),
        dec: Angle.Degrees(-11.59462730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80295"},
        {"Geneva Identification System", "GEN# -0.01104126"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.86251148),
        dec: Angle.Degrees(-11.59431685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29871"},
        {"Hipparcos Number", "HIP 21853"},
        {"Smithsonian Astrophysical Observation", "SAO 149833"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.49250270),
        dec: Angle.Degrees(-11.59342282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10150"},
        {"Smithsonian Astrophysical Observation", "SAO 148252"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.64487660),
        dec: Angle.Degrees(-11.59131193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123118"},
        {"Hipparcos Number", "HIP 68861"},
        {"Smithsonian Astrophysical Observation", "SAO 158346"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.50910301),
        dec: Angle.Degrees(-11.59067801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210929"},
        {"Hipparcos Number", "HIP 109762"},
        {"Smithsonian Astrophysical Observation", "SAO 164940"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.48099073),
        dec: Angle.Degrees(-11.58959288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1491"},
        {"Hipparcos Number", "HIP 1517"},
        {"Smithsonian Astrophysical Observation", "SAO 147213"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.73162303),
        dec: Angle.Degrees(-11.58912140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4443"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.21060461),
        dec: Angle.Degrees(-11.58825278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97876"},
        {"Hipparcos Number", "HIP 54974"},
        {"Smithsonian Astrophysical Observation", "SAO 156565"},
        {"Wilson Evans Batten Catalogue", "WEB 9921"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.84828866),
        dec: Angle.Degrees(-11.58810792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113425"},
        {"Hipparcos Number", "HIP 63732"},
        {"Geneva Identification System", "GEN# +1.00113425"},
        {"Smithsonian Astrophysical Observation", "SAO 157687"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.90431228),
        dec: Angle.Degrees(-11.58239791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8236"},
        {"Hipparcos Number", "HIP 6353"},
        {"Smithsonian Astrophysical Observation", "SAO 147757"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.39566517),
        dec: Angle.Degrees(-11.58223164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67770"},
        {"Hipparcos Number", "HIP 39923"},
        {"Smithsonian Astrophysical Observation", "SAO 153892"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.30215657),
        dec: Angle.Degrees(-11.58147300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34910"},
        {"Hipparcos Number", "HIP 24926"},
        {"Smithsonian Astrophysical Observation", "SAO 150352"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.11039128),
        dec: Angle.Degrees(-11.58076263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143634"},
        {"Hipparcos Number", "HIP 78536"},
        {"Geneva Identification System", "GEN# +1.00143634"},
        {"Smithsonian Astrophysical Observation", "SAO 159644"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.50615785),
        dec: Angle.Degrees(-11.58005481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110620"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15117444),
        dec: Angle.Degrees(-11.57833786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16845 AB"},
        {"Henry Draper", "HD 221789"},
        {"Hipparcos Number", "HIP 116398"},
        {"Renson", "Renson 60794"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.80016489),
        dec: Angle.Degrees(-11.57763965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103988"},
        {"Hipparcos Number", "HIP 58407"},
        {"Geneva Identification System", "GEN# +1.00103988"},
        {"Smithsonian Astrophysical Observation", "SAO 157022"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.63531042),
        dec: Angle.Degrees(-11.57557870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134337"},
        {"Hipparcos Number", "HIP 74194"},
        {"Smithsonian Astrophysical Observation", "SAO 159057"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.40926962),
        dec: Angle.Degrees(-11.57548193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55014"},
        {"Hipparcos Number", "HIP 34666"},
        {"Celescope Catalog", "CEL 1643"},
        {"Geneva Identification System", "GEN# +1.00055014"},
        {"Smithsonian Astrophysical Observation", "SAO 152512"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.69218770),
        dec: Angle.Degrees(-11.57406145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198802"},
        {"Hipparcos Number", "HIP 103077"},
        {"Geneva Identification System", "GEN# +1.00198802"},
        {"Smithsonian Astrophysical Observation", "SAO 163953"},
        {"Wilson Evans Batten Catalogue", "WEB 18714"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.27321911),
        dec: Angle.Degrees(-11.57376168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78667"},
        {"Hipparcos Number", "HIP 44933"},
        {"Smithsonian Astrophysical Observation", "SAO 154949"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.28631610),
        dec: Angle.Degrees(-11.57225716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52225"},
        {"Smithsonian Astrophysical Observation", "SAO 156143"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05419323),
        dec: Angle.Degrees(-11.57084362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180295"},
        {"Hipparcos Number", "HIP 94722"},
        {"Smithsonian Astrophysical Observation", "SAO 162391"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.11428342),
        dec: Angle.Degrees(-11.56848204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204363"},
        {"Hipparcos Number", "HIP 106007"},
        {"Geneva Identification System", "GEN# +1.00204363"},
        {"Smithsonian Astrophysical Observation", "SAO 164415"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.05807593),
        dec: Angle.Degrees(-11.56817350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219363"},
        {"Hipparcos Number", "HIP 114804"},
        {"Smithsonian Astrophysical Observation", "SAO 165586"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.83704241),
        dec: Angle.Degrees(-11.56543371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210424"},
        {"Hipparcos Number", "HIP 109472"},
        {"Fundamental Katalog 5th Edition", "FK5 3771"},
        {"Geneva Identification System", "GEN# +1.00210424"},
        {"Renson", "Renson 58510"},
        {"Smithsonian Astrophysical Observation", "SAO 164910"},
        {"Wilson Evans Batten Catalogue", "WEB 19669"},
    },
    visualMagnitude: 5.43,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.65610232),
        dec: Angle.Degrees(-11.56495901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141591"},
        {"Hipparcos Number", "HIP 77572"},
        {"Geneva Identification System", "GEN# +1.00141591"},
        {"Smithsonian Astrophysical Observation", "SAO 159524"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.55543445),
        dec: Angle.Degrees(-11.56463550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61551"},
        {"Hipparcos Number", "HIP 37296"},
        {"Smithsonian Astrophysical Observation", "SAO 153200"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86347738),
        dec: Angle.Degrees(-11.56397386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30332"},
        {"Hipparcos Number", "HIP 22169"},
        {"Geneva Identification System", "GEN# +1.00030332"},
        {"Smithsonian Astrophysical Observation", "SAO 149871"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.53953930),
        dec: Angle.Degrees(-11.56122051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28610"},
        {"Hipparcos Number", "HIP 21003"},
        {"Geneva Identification System", "GEN# +1.00028610"},
        {"Smithsonian Astrophysical Observation", "SAO 149683"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.56387697),
        dec: Angle.Degrees(-11.56070962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211674"},
        {"Hipparcos Number", "HIP 110169"},
        {"Smithsonian Astrophysical Observation", "SAO 164994"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.73070091),
        dec: Angle.Degrees(-11.55722973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36251",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6104 AB"},
        {"Hipparcos Number", "HIP 36251"},
        {"Geneva Identification System", "GEN# +1.00059067J"},
        {"Smithsonian Astrophysical Observation", "SAO 152909"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.96526084),
        dec: Angle.Degrees(-11.55686168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53179"},
        {"Hipparcos Number", "HIP 34042"},
        {"Celescope Catalog", "CEL 1536"},
        {"Geneva Identification System", "GEN# +1.00053179"},
        {"Smithsonian Astrophysical Observation", "SAO 152302"},
        {"Wilson Evans Batten Catalogue", "WEB 6823"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.92986289),
        dec: Angle.Degrees(-11.55173312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130177"},
        {"Hipparcos Number", "HIP 72301"},
        {"Smithsonian Astrophysical Observation", "SAO 158800"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77397725),
        dec: Angle.Degrees(-11.55113533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179380"},
        {"Hipparcos Number", "HIP 94390"},
        {"Smithsonian Astrophysical Observation", "SAO 162313"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18272838),
        dec: Angle.Degrees(-11.55035058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10254 AB"},
        {"Henry Draper", "HD 152616"},
        {"Hipparcos Number", "HIP 82752"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70312444),
        dec: Angle.Degrees(-11.54969643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112806"},
        {"Hipparcos Number", "HIP 63400"},
        {"Smithsonian Astrophysical Observation", "SAO 157638"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.87828940),
        dec: Angle.Degrees(-11.54883509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2654 AB"},
        {"Henry Draper", "HD 22606"},
        {"Hipparcos Number", "HIP 16931"},
        {"Smithsonian Astrophysical Observation", "SAO 149073"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.47253847),
        dec: Angle.Degrees(-11.54865315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84211"},
        {"Hipparcos Number", "HIP 47674"},
        {"Smithsonian Astrophysical Observation", "SAO 155431"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.81262149),
        dec: Angle.Degrees(-11.54751000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194654"},
        {"Hipparcos Number", "HIP 100869"},
        {"Geneva Identification System", "GEN# +1.00194654"},
        {"Smithsonian Astrophysical Observation", "SAO 163588"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.78535993),
        dec: Angle.Degrees(-11.54734817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221427"},
        {"Hipparcos Number", "HIP 116163"},
        {"Smithsonian Astrophysical Observation", "SAO 165746"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.05280124),
        dec: Angle.Degrees(-11.54452363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51196"},
        {"Hipparcos Number", "HIP 33336"},
        {"Geneva Identification System", "GEN# +1.00051196"},
        {"Smithsonian Astrophysical Observation", "SAO 152119"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.99881869),
        dec: Angle.Degrees(-11.53927519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215554"},
        {"Hipparcos Number", "HIP 112413"},
        {"Smithsonian Astrophysical Observation", "SAO 165282"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.53053537),
        dec: Angle.Degrees(-11.53871658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53931"},
        {"Hipparcos Number", "HIP 34287"},
        {"Celescope Catalog", "CEL 1583"},
        {"Geneva Identification System", "GEN# +1.00053931"},
        {"Smithsonian Astrophysical Observation", "SAO 152388"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.62697449),
        dec: Angle.Degrees(-11.53787169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8947 A"},
        {"Henry Draper", "HD 118008"},
        {"Hipparcos Number", "HIP 66216"},
        {"Smithsonian Astrophysical Observation", "SAO 158011"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.57453396),
        dec: Angle.Degrees(-11.53723336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121784"},
        {"Hipparcos Number", "HIP 68205"},
        {"Smithsonian Astrophysical Observation", "SAO 158261"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.44764997),
        dec: Angle.Degrees(-11.53679956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17749"},
        {"Hipparcos Number", "HIP 13249"},
        {"Smithsonian Astrophysical Observation", "SAO 148634"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.63121105),
        dec: Angle.Degrees(-11.53471575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163625"},
        {"Hipparcos Number", "HIP 87921"},
        {"Geneva Identification System", "GEN# +1.00163625"},
        {"Smithsonian Astrophysical Observation", "SAO 160941"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.39897610),
        dec: Angle.Degrees(-11.53355773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60006"},
        {"Hipparcos Number", "HIP 36644"},
        {"Smithsonian Astrophysical Observation", "SAO 153018"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.03479179),
        dec: Angle.Degrees(-11.53330565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17727"},
        {"Hipparcos Number", "HIP 13236"},
        {"Smithsonian Astrophysical Observation", "SAO 148633"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.59528256),
        dec: Angle.Degrees(-11.53277132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9014"},
        {"Hipparcos Number", "HIP 6880"},
        {"Geneva Identification System", "GEN# +1.00009014"},
        {"Smithsonian Astrophysical Observation", "SAO 147827"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.15202127),
        dec: Angle.Degrees(-11.53244424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147147"},
        {"Hipparcos Number", "HIP 80058"},
        {"Geneva Identification System", "GEN# +1.00147147"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.11493390),
        dec: Angle.Degrees(-11.53186270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44951"},
        {"Hipparcos Number", "HIP 30457"},
        {"Fundamental Katalog 5th Edition", "FK5 1171"},
        {"Geneva Identification System", "GEN# +1.00044951"},
        {"Smithsonian Astrophysical Observation", "SAO 151458"},
        {"Wilson Evans Batten Catalogue", "WEB 6065"},
    },
    visualMagnitude: 5.21,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.04313846),
        dec: Angle.Degrees(-11.53000982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7874"},
        {"Hipparcos Number", "HIP 6098"},
        {"Smithsonian Astrophysical Observation", "SAO 147728"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.57011645),
        dec: Angle.Degrees(-11.52733728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70995"},
        {"Hipparcos Number", "HIP 41221"},
        {"Smithsonian Astrophysical Observation", "SAO 154220"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.16483254),
        dec: Angle.Degrees(-11.52448924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53456"},
        {"Hipparcos Number", "HIP 34133"},
        {"Celescope Catalog", "CEL 1554"},
        {"Geneva Identification System", "GEN# +1.00053456J"},
        {"Smithsonian Astrophysical Observation", "SAO 152324"},
        {"Wilson Evans Batten Catalogue", "WEB 6843"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.15960113),
        dec: Angle.Degrees(-11.52406758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109874"},
        {"Hipparcos Number", "HIP 61654"},
        {"Smithsonian Astrophysical Observation", "SAO 157410"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57595788),
        dec: Angle.Degrees(-11.52380403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101743"},
        {"Hipparcos Number", "HIP 57105"},
        {"Smithsonian Astrophysical Observation", "SAO 156843"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.60428051),
        dec: Angle.Degrees(-11.51793110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109875"},
        {"Hipparcos Number", "HIP 61656"},
        {"Fundamental Katalog 5th Edition", "FK5 5115"},
        {"Smithsonian Astrophysical Observation", "SAO 157411"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.58313208),
        dec: Angle.Degrees(-11.51698289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65561"},
        {"Hipparcos Number", "HIP 39008"},
        {"Smithsonian Astrophysical Observation", "SAO 153661"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.74471193),
        dec: Angle.Degrees(-11.51509237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20101"},
        {"Hipparcos Number", "HIP 15014"},
        {"Smithsonian Astrophysical Observation", "SAO 148844"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.38913679),
        dec: Angle.Degrees(-11.51357549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182498"},
        {"Hipparcos Number", "HIP 95481"},
        {"Geneva Identification System", "GEN# +1.00182498"},
        {"Smithsonian Astrophysical Observation", "SAO 162596"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.32802074),
        dec: Angle.Degrees(-11.51341593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201767"},
        {"Hipparcos Number", "HIP 104654"},
        {"Geneva Identification System", "GEN# +1.00201767"},
        {"Smithsonian Astrophysical Observation", "SAO 164209"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.98883367),
        dec: Angle.Degrees(-11.51206052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11731"},
        {"Hipparcos Number", "HIP 8923"},
        {"Smithsonian Astrophysical Observation", "SAO 148101"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.72520820),
        dec: Angle.Degrees(-11.51132073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92003"},
        {"Hipparcos Number", "HIP 51987"},
        {"Smithsonian Astrophysical Observation", "SAO 156107"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.32858830),
        dec: Angle.Degrees(-11.51086138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92114"},
        {"Hipparcos Number", "HIP 52039"},
        {"Geneva Identification System", "GEN# +1.00092114"},
        {"Smithsonian Astrophysical Observation", "SAO 156116"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.48873018),
        dec: Angle.Degrees(-11.50964157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223301"},
        {"Hipparcos Number", "HIP 117411"},
        {"Smithsonian Astrophysical Observation", "SAO 165892"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.11747697),
        dec: Angle.Degrees(-11.50872420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58894"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.17737481),
        dec: Angle.Degrees(-11.50816741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10727"},
        {"Hipparcos Number", "HIP 8140"},
        {"Smithsonian Astrophysical Observation", "SAO 147992"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.16708394),
        dec: Angle.Degrees(-11.50795953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49810"},
        {"Hipparcos Number", "HIP 32758"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45936226),
        dec: Angle.Degrees(-11.50664833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175906"},
        {"Hipparcos Number", "HIP 93103"},
        {"Smithsonian Astrophysical Observation", "SAO 162029"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50544028),
        dec: Angle.Degrees(-11.50469838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112708"},
        {"Hipparcos Number", "HIP 63349"},
        {"Smithsonian Astrophysical Observation", "SAO 157635"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.71255511),
        dec: Angle.Degrees(-11.50461659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54574"},
        {"Hipparcos Number", "HIP 34499"},
        {"Celescope Catalog", "CEL 1612"},
        {"Geneva Identification System", "GEN# +1.00054574"},
        {"Smithsonian Astrophysical Observation", "SAO 152460"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.22436319),
        dec: Angle.Degrees(-11.50151156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17133"},
        {"Hipparcos Number", "HIP 12809"},
        {"Smithsonian Astrophysical Observation", "SAO 148578"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.15271068),
        dec: Angle.Degrees(-11.49816834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117363"},
        {"Hipparcos Number", "HIP 65849"},
        {"Smithsonian Astrophysical Observation", "SAO 157966"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.47857246),
        dec: Angle.Degrees(-11.49596528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122817"},
        {"Hipparcos Number", "HIP 68754"},
        {"Smithsonian Astrophysical Observation", "SAO 158324"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.09618385),
        dec: Angle.Degrees(-11.49492048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79237"},
        {"Hipparcos Number", "HIP 45193"},
        {"Smithsonian Astrophysical Observation", "SAO 154999"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.14420256),
        dec: Angle.Degrees(-11.49466870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58928"},
        {"Hipparcos Number", "HIP 36203"},
        {"Smithsonian Astrophysical Observation", "SAO 152895"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.83687722),
        dec: Angle.Degrees(-11.49189169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23746"},
        {"Hipparcos Number", "HIP 17672"},
        {"Geneva Identification System", "GEN# +1.00023746"},
        {"Smithsonian Astrophysical Observation", "SAO 149167"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.78174506),
        dec: Angle.Degrees(-11.48944229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56450"},
        {"Hipparcos Number", "HIP 35212"},
        {"Geneva Identification System", "GEN# +1.00056450"},
        {"Smithsonian Astrophysical Observation", "SAO 152649"},
        {"Wilson Evans Batten Catalogue", "WEB 7031"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.15682137),
        dec: Angle.Degrees(-11.48731050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148115"},
        {"Hipparcos Number", "HIP 80524"},
        {"Smithsonian Astrophysical Observation", "SAO 159913"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.57755447),
        dec: Angle.Degrees(-11.48619260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183631"},
        {"Hipparcos Number", "HIP 95973"},
        {"Geneva Identification System", "GEN# +1.00183631"},
        {"Smithsonian Astrophysical Observation", "SAO 162712"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.74163468),
        dec: Angle.Degrees(-11.48462495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115446"},
        {"Hipparcos Number", "HIP 64828"},
        {"Renson", "Renson 33350"},
        {"Smithsonian Astrophysical Observation", "SAO 157836"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.34173037),
        dec: Angle.Degrees(-11.48354663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215233"},
        {"Hipparcos Number", "HIP 112232"},
        {"Smithsonian Astrophysical Observation", "SAO 165255"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.96140163),
        dec: Angle.Degrees(-11.48327712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165515"},
        {"Hipparcos Number", "HIP 88719"},
        {"Smithsonian Astrophysical Observation", "SAO 161082"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.69059419),
        dec: Angle.Degrees(-11.48193887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79082"},
        {"Hipparcos Number", "HIP 45123"},
        {"Smithsonian Astrophysical Observation", "SAO 154983"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.89743832),
        dec: Angle.Degrees(-11.47989956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97322"},
        {"Smithsonian Astrophysical Observation", "SAO 162974"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.67214019),
        dec: Angle.Degrees(-11.47974814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218731"},
        {"Hipparcos Number", "HIP 114419"},
        {"Smithsonian Astrophysical Observation", "SAO 165531"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.58730809),
        dec: Angle.Degrees(-11.47957747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8523 B"},
        {"Hipparcos Number", "HIP 60237"},
        {"Smithsonian Astrophysical Observation", "SAO 157230"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.28580424),
        dec: Angle.Degrees(-11.47933721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60027"},
        {"Hipparcos Number", "HIP 36650"},
        {"Smithsonian Astrophysical Observation", "SAO 153022"},
    },
    visualMagnitude: 9.28,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.06063465),
        dec: Angle.Degrees(-11.47628869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8523 A"},
        {"Henry Draper", "HD 107452"},
        {"Hipparcos Number", "HIP 60236"},
        {"Geneva Identification System", "GEN# +1.00107452"},
        {"Renson", "Renson 31140"},
        {"Smithsonian Astrophysical Observation", "SAO 157229"},
        {"Wilson Evans Batten Catalogue", "WEB 10711"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.28532155),
        dec: Angle.Degrees(-11.47569242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111136"},
        {"Hipparcos Number", "HIP 62395"},
        {"Smithsonian Astrophysical Observation", "SAO 157507"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.80973641),
        dec: Angle.Degrees(-11.47530637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7782"},
        {"Smithsonian Astrophysical Observation", "SAO 147943"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.03989101),
        dec: Angle.Degrees(-11.47334594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131182"},
        {"Hipparcos Number", "HIP 72750"},
        {"Smithsonian Astrophysical Observation", "SAO 158868"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.08781193),
        dec: Angle.Degrees(-11.47297910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68406"},
        {"Hipparcos Number", "HIP 40146"},
        {"Smithsonian Astrophysical Observation", "SAO 153954"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.97537489),
        dec: Angle.Degrees(-11.47258129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134649"},
        {"Hipparcos Number", "HIP 74311"},
        {"Smithsonian Astrophysical Observation", "SAO 159077"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.83611243),
        dec: Angle.Degrees(-11.47142775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57281"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.18706992),
        dec: Angle.Degrees(-11.47121882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116841"},
        {"Smithsonian Astrophysical Observation", "SAO 165826"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.24810026),
        dec: Angle.Degrees(-11.47048976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88298"},
        {"Hipparcos Number", "HIP 49848"},
        {"Smithsonian Astrophysical Observation", "SAO 155787"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.66827736),
        dec: Angle.Degrees(-11.47018413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6276"},
        {"Smithsonian Astrophysical Observation", "SAO 147747"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13417401),
        dec: Angle.Degrees(-11.46736892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160348"},
        {"Hipparcos Number", "HIP 86452"},
        {"Smithsonian Astrophysical Observation", "SAO 160731"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.97457530),
        dec: Angle.Degrees(-11.46625153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45857"},
        {"Hipparcos Number", "HIP 30931"},
        {"Smithsonian Astrophysical Observation", "SAO 151558"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36806680),
        dec: Angle.Degrees(-11.46414677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205693"},
        {"Hipparcos Number", "HIP 106739"},
        {"Smithsonian Astrophysical Observation", "SAO 164525"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.33335374),
        dec: Angle.Degrees(-11.46068681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200002"},
        {"Hipparcos Number", "HIP 103716"},
        {"Smithsonian Astrophysical Observation", "SAO 164062"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.25831522),
        dec: Angle.Degrees(-11.46052900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18741"},
        {"Hipparcos Number", "HIP 14006"},
        {"Geneva Identification System", "GEN# +1.00018741"},
        {"Smithsonian Astrophysical Observation", "SAO 148712"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.07881667),
        dec: Angle.Degrees(-11.45903540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224468"},
        {"Hipparcos Number", "HIP 118171"},
        {"Geneva Identification System", "GEN# +1.00224468"},
        {"Smithsonian Astrophysical Observation", "SAO 165971"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.56725552),
        dec: Angle.Degrees(-11.45847331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117449"},
        {"Smithsonian Astrophysical Observation", "SAO 165899"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.21206760),
        dec: Angle.Degrees(-11.45835345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203249"},
        {"Hipparcos Number", "HIP 105451"},
        {"Geneva Identification System", "GEN# +1.00203249"},
        {"Smithsonian Astrophysical Observation", "SAO 164332"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37596616),
        dec: Angle.Degrees(-11.45822973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173320"},
        {"Hipparcos Number", "HIP 92000"},
        {"Smithsonian Astrophysical Observation", "SAO 161788"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26813021),
        dec: Angle.Degrees(-11.45497603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198258"},
        {"Hipparcos Number", "HIP 102785"},
        {"Geneva Identification System", "GEN# +1.00198258"},
        {"Smithsonian Astrophysical Observation", "SAO 163913"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.35447347),
        dec: Angle.Degrees(-11.45494006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136819"},
        {"Hipparcos Number", "HIP 75300"},
        {"Smithsonian Astrophysical Observation", "SAO 159214"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.77461687),
        dec: Angle.Degrees(-11.45468193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52942"},
        {"Hipparcos Number", "HIP 33953"},
        {"Geneva Identification System", "GEN# +1.00052942"},
        {"Smithsonian Astrophysical Observation", "SAO 152277"},
        {"Wilson Evans Batten Catalogue", "WEB 6812"},
        {"Wilson Evans Batten Catalogue 2", "WEB 6813"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.67757087),
        dec: Angle.Degrees(-11.45321850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4395"},
        {"Hipparcos Number", "HIP 3610"},
        {"Geneva Identification System", "GEN# +1.00004395"},
        {"Smithsonian Astrophysical Observation", "SAO 147438"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.55755101),
        dec: Angle.Degrees(-11.45228498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7749"},
        {"Hipparcos Number", "HIP 5999"},
        {"Smithsonian Astrophysical Observation", "SAO 147712"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.28565594),
        dec: Angle.Degrees(-11.45063341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115969"},
        {"Hipparcos Number", "HIP 65122"},
        {"Smithsonian Astrophysical Observation", "SAO 157876"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.18849889),
        dec: Angle.Degrees(-11.45037281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78739",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9910 B"},
        {"Aitken 2", "ADS 9910 P"},
        {"Henry Draper", "HD 144088"},
        {"Hipparcos Number", "HIP 78739"},
        {"Geneva Identification System", "GEN# +1.00144088"},
        {"Smithsonian Astrophysical Observation", "SAO 159670"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.11146471),
        dec: Angle.Degrees(-11.44982493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220957"},
        {"Hipparcos Number", "HIP 115839"},
        {"Fundamental Katalog 5th Edition", "FK5 6073"},
        {"Geneva Identification System", "GEN# +1.00220957"},
        {"Smithsonian Astrophysical Observation", "SAO 165708"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.02140081),
        dec: Angle.Degrees(-11.44969884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78738",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9910 A"},
        {"Henry Draper", "HD 144087"},
        {"Hipparcos Number", "HIP 78738"},
        {"Geneva Identification System", "GEN# +1.00144087A"},
        {"Smithsonian Astrophysical Observation", "SAO 159668"},
        {"Wilson Evans Batten Catalogue", "WEB 13312"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.10817896),
        dec: Angle.Degrees(-11.44932956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137779"},
        {"Hipparcos Number", "HIP 75729"},
        {"Smithsonian Astrophysical Observation", "SAO 159281"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05731297),
        dec: Angle.Degrees(-11.44886524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135423"},
        {"Hipparcos Number", "HIP 74659"},
        {"Smithsonian Astrophysical Observation", "SAO 159128"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.84986397),
        dec: Angle.Degrees(-11.44699433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21709"},
        {"Geneva Identification System", "GEN# -0.01100930"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.92571442),
        dec: Angle.Degrees(-11.44620759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36272"},
        {"Hipparcos Number", "HIP 25765"},
        {"Geneva Identification System", "GEN# +1.00036272"},
        {"Smithsonian Astrophysical Observation", "SAO 150500"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.52927498),
        dec: Angle.Degrees(-11.44025095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198647"},
        {"Hipparcos Number", "HIP 102994"},
        {"Smithsonian Astrophysical Observation", "SAO 163940"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.00297362),
        dec: Angle.Degrees(-11.43949013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70903"},
        {"Hipparcos Number", "HIP 41178"},
        {"Smithsonian Astrophysical Observation", "SAO 154209"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.04353577),
        dec: Angle.Degrees(-11.43909904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174838"},
        {"Hipparcos Number", "HIP 92667"},
        {"Smithsonian Astrophysical Observation", "SAO 161936"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.24756846),
        dec: Angle.Degrees(-11.43731828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119566"},
        {"Hipparcos Number", "HIP 67034"},
        {"Smithsonian Astrophysical Observation", "SAO 158125"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.06475977),
        dec: Angle.Degrees(-11.43678835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139104"},
        {"Hipparcos Number", "HIP 76436"},
        {"Geneva Identification System", "GEN# +1.00139104"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.17098878),
        dec: Angle.Degrees(-11.43502114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26042"},
        {"Smithsonian Astrophysical Observation", "SAO 150555"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32781285),
        dec: Angle.Degrees(-11.43489818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25103"},
        {"Hipparcos Number", "HIP 18616"},
        {"Smithsonian Astrophysical Observation", "SAO 149293"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.74486992),
        dec: Angle.Degrees(-11.43484635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175622"},
        {"Hipparcos Number", "HIP 92993"},
        {"Smithsonian Astrophysical Observation", "SAO 162011"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.17291403),
        dec: Angle.Degrees(-11.43379123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67860"},
        {"Hipparcos Number", "HIP 39959"},
        {"Smithsonian Astrophysical Observation", "SAO 153900"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.39847932),
        dec: Angle.Degrees(-11.43100161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5643 A"},
        {"Henry Draper", "HD 51848"},
        {"Hipparcos Number", "HIP 33567"},
        {"Smithsonian Astrophysical Observation", "SAO 152181"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61640222),
        dec: Angle.Degrees(-11.43094271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33569",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5643 B"},
        {"Hipparcos Number", "HIP 33569"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.62214310),
        dec: Angle.Degrees(-11.43086125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63593"},
        {"Hipparcos Number", "HIP 38174"},
        {"Smithsonian Astrophysical Observation", "SAO 153447"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.33278631),
        dec: Angle.Degrees(-11.42920536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91248"},
        {"Hipparcos Number", "HIP 51575"},
        {"Geneva Identification System", "GEN# +1.00091248"},
        {"Smithsonian Astrophysical Observation", "SAO 156040"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00577583),
        dec: Angle.Degrees(-11.42430934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94268"},
        {"Hipparcos Number", "HIP 53186"},
        {"Geneva Identification System", "GEN# +1.00094268"},
        {"Smithsonian Astrophysical Observation", "SAO 156292"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.18577396),
        dec: Angle.Degrees(-11.42318329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129923"},
        {"Hipparcos Number", "HIP 72168"},
        {"Smithsonian Astrophysical Observation", "SAO 158780"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.41385562),
        dec: Angle.Degrees(-11.42238469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118761"},
        {"Hipparcos Number", "HIP 66596"},
        {"Smithsonian Astrophysical Observation", "SAO 158065"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.76342432),
        dec: Angle.Degrees(-11.41840509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25492"},
        {"Hipparcos Number", "HIP 18854"},
        {"Smithsonian Astrophysical Observation", "SAO 149328"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.63092733),
        dec: Angle.Degrees(-11.41391597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15873"},
        {"Hipparcos Number", "HIP 11835"},
        {"Smithsonian Astrophysical Observation", "SAO 148450"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.20593950),
        dec: Angle.Degrees(-11.41333900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48868"},
        {"Hipparcos Number", "HIP 32344"},
        {"Smithsonian Astrophysical Observation", "SAO 151876"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.27632113),
        dec: Angle.Degrees(-11.41326909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131918"},
        {"Hipparcos Number", "HIP 73133"},
        {"Fundamental Katalog 5th Edition", "FK5 1390"},
        {"Geneva Identification System", "GEN# +1.00131918"},
        {"Smithsonian Astrophysical Observation", "SAO 158915"},
        {"Wilson Evans Batten Catalogue", "WEB 12534"},
    },
    visualMagnitude: 5.48,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.19211288),
        dec: Angle.Degrees(-11.40972790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20693"},
        {"Hipparcos Number", "HIP 15483"},
        {"Geneva Identification System", "GEN# +1.00020693"},
        {"Smithsonian Astrophysical Observation", "SAO 148903"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89728264),
        dec: Angle.Degrees(-11.40917544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187306"},
        {"Hipparcos Number", "HIP 97561"},
        {"Smithsonian Astrophysical Observation", "SAO 163020"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.44466216),
        dec: Angle.Degrees(-11.40869558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97558"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.43280685),
        dec: Angle.Degrees(-11.40541054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167677"},
        {"Hipparcos Number", "HIP 89583"},
        {"Geneva Identification System", "GEN# +1.00167677"},
        {"Smithsonian Astrophysical Observation", "SAO 161256"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.20627539),
        dec: Angle.Degrees(-11.40534169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128188"},
        {"Hipparcos Number", "HIP 71375"},
        {"Geneva Identification System", "GEN# +1.00128188"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94511303),
        dec: Angle.Degrees(-11.40338294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37323"},
        {"Hipparcos Number", "HIP 26406"},
        {"Smithsonian Astrophysical Observation", "SAO 150621"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31224188),
        dec: Angle.Degrees(-11.40046111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125676"},
        {"Hipparcos Number", "HIP 70153"},
        {"Geneva Identification System", "GEN# +1.00125676"},
        {"Smithsonian Astrophysical Observation", "SAO 158507"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.31730045),
        dec: Angle.Degrees(-11.39850760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173912"},
        {"Hipparcos Number", "HIP 92272"},
        {"Geneva Identification System", "GEN# +1.00173912"},
        {"Smithsonian Astrophysical Observation", "SAO 161844"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.08375586),
        dec: Angle.Degrees(-11.39193259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76053"},
        {"Hipparcos Number", "HIP 43651"},
        {"Smithsonian Astrophysical Observation", "SAO 154719"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.37232842),
        dec: Angle.Degrees(-11.39191075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77935"},
        {"Hipparcos Number", "HIP 44589"},
        {"Smithsonian Astrophysical Observation", "SAO 154887"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.25930836),
        dec: Angle.Degrees(-11.38770598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2003 A"},
        {"Henry Draper", "HD 16454"},
        {"Hipparcos Number", "HIP 12279"},
        {"Smithsonian Astrophysical Observation", "SAO 148514"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.54209777),
        dec: Angle.Degrees(-11.38498155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7077"},
        {"Hipparcos Number", "HIP 5538"},
        {"Smithsonian Astrophysical Observation", "SAO 147652"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.75476787),
        dec: Angle.Degrees(-11.38355106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113552"},
        {"Geneva Identification System", "GEN# -0.01206393"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.97296760),
        dec: Angle.Degrees(-11.38152618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31457"},
        {"Hipparcos Number", "HIP 22902"},
        {"Smithsonian Astrophysical Observation", "SAO 149994"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.89130953),
        dec: Angle.Degrees(-11.38133451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5722"},
        {"Hipparcos Number", "HIP 4587"},
        {"Geneva Identification System", "GEN# +1.00005722"},
        {"Smithsonian Astrophysical Observation", "SAO 147546"},
        {"Wilson Evans Batten Catalogue", "WEB 842"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68286462),
        dec: Angle.Degrees(-11.37993895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89454"},
        {"Hipparcos Number", "HIP 50534"},
        {"Geneva Identification System", "GEN# +1.00089454"},
        {"Smithsonian Astrophysical Observation", "SAO 155893"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.81799646),
        dec: Angle.Degrees(-11.37835139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76243"},
        {"Hipparcos Number", "HIP 43746"},
        {"Smithsonian Astrophysical Observation", "SAO 154732"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.65937977),
        dec: Angle.Degrees(-11.37745981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2237"},
        {"Hipparcos Number", "HIP 2066"},
        {"Smithsonian Astrophysical Observation", "SAO 147273"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.53600426),
        dec: Angle.Degrees(-11.37688604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46990"},
        {"Hipparcos Number", "HIP 31510"},
        {"Smithsonian Astrophysical Observation", "SAO 151680"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97570317),
        dec: Angle.Degrees(-11.37427404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76059"},
        {"Cincinnati Publication", "Ci 20 935"},
    },
    visualMagnitude: 12.13,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)32, 00.3900),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)22, 26.200)
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
    primaryId: "HIP 78727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9909 AB"},
        {"Hipparcos Number", "HIP 78727"},
        {"Smithsonian Astrophysical Observation", "SAO 159665"},
    },
    visualMagnitude: 4.16,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)04, 21.6300),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)22, 24.800)
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
    primaryId: "HIP 104459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201381"},
        {"Hipparcos Number", "HIP 104459"},
        {"Fundamental Katalog 5th Edition", "FK5 794"},
        {"Geneva Identification System", "GEN# +1.00201381"},
        {"Smithsonian Astrophysical Observation", "SAO 164182"},
        {"Wilson Evans Batten Catalogue", "WEB 19015"},
    },
    visualMagnitude: 4.50,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39830336),
        dec: Angle.Degrees(-11.37165474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76352"},
        {"Hipparcos Number", "HIP 43805"},
        {"Smithsonian Astrophysical Observation", "SAO 154743"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.82126479),
        dec: Angle.Degrees(-11.37163694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7310"},
        {"Geneva Identification System", "GEN# -0.01200290"},
        {"Renson", "Renson 2340"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.52366557),
        dec: Angle.Degrees(-11.37028476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130193"},
        {"Hipparcos Number", "HIP 72299"},
        {"Smithsonian Astrophysical Observation", "SAO 158801"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77334009),
        dec: Angle.Degrees(-11.36916440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9219"},
        {"Smithsonian Astrophysical Observation", "SAO 148138"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.63678272),
        dec: Angle.Degrees(-11.36872076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115080"},
        {"Hipparcos Number", "HIP 64638"},
        {"Geneva Identification System", "GEN# +1.00115080J"},
        {"Smithsonian Astrophysical Observation", "SAO 157815"},
        {"Wilson Evans Batten Catalogue", "WEB 11432"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.73271773),
        dec: Angle.Degrees(-11.36870113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3834"},
        {"Hipparcos Number", "HIP 3201"},
        {"Smithsonian Astrophysical Observation", "SAO 147399"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19570501),
        dec: Angle.Degrees(-11.36709800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187820"},
        {"Hipparcos Number", "HIP 97794"},
        {"Geneva Identification System", "GEN# +1.00187820"},
        {"Smithsonian Astrophysical Observation", "SAO 163067"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.08744295),
        dec: Angle.Degrees(-11.36684999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210241"},
        {"Hipparcos Number", "HIP 109357"},
        {"Smithsonian Astrophysical Observation", "SAO 164891"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.32556690),
        dec: Angle.Degrees(-11.36610323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207052"},
        {"Hipparcos Number", "HIP 107517"},
        {"Fundamental Katalog 5th Edition", "FK5 818"},
        {"Geneva Identification System", "GEN# +1.00207052"},
        {"Renson", "Renson 57620"},
        {"Smithsonian Astrophysical Observation", "SAO 164639"},
        {"Wilson Evans Batten Catalogue", "WEB 19405"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.63366745),
        dec: Angle.Degrees(-11.36593201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129156"},
        {"Hipparcos Number", "HIP 71808"},
        {"Smithsonian Astrophysical Observation", "SAO 158732"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.32921572),
        dec: Angle.Degrees(-11.36426369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208112"},
        {"Hipparcos Number", "HIP 108117"},
        {"Smithsonian Astrophysical Observation", "SAO 164732"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.56747778),
        dec: Angle.Degrees(-11.36414661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169371"},
        {"Hipparcos Number", "HIP 90244"},
        {"Smithsonian Astrophysical Observation", "SAO 161448"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.20081098),
        dec: Angle.Degrees(-11.36410439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103992",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Saturn Nebula"},
        {"Henry Draper", "HD 200516"},
        {"Hipparcos Number", "HIP 103992"},
        {"Wilson Evans Batten Catalogue", "WEB 18944"},
        {"New General Catalogue", "NGC 7009"},
    },
    visualMagnitude: 9.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04, 10.7900),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)21, 47.700)
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
    primaryId: "HIP 56271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100257"},
        {"Hipparcos Number", "HIP 56271"},
        {"Smithsonian Astrophysical Observation", "SAO 156737"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.03779629),
        dec: Angle.Degrees(-11.36324160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97038"},
        {"Hipparcos Number", "HIP 54580"},
        {"Geneva Identification System", "GEN# +1.00097038"},
        {"Smithsonian Astrophysical Observation", "SAO 156506"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.54971027),
        dec: Angle.Degrees(-11.35996064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14612"},
        {"Hipparcos Number", "HIP 10971"},
        {"Smithsonian Astrophysical Observation", "SAO 148345"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.33575113),
        dec: Angle.Degrees(-11.35973195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36844"},
        {"Hipparcos Number", "HIP 26110"},
        {"Geneva Identification System", "GEN# +1.00036844"},
        {"Smithsonian Astrophysical Observation", "SAO 150570"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.52089854),
        dec: Angle.Degrees(-11.35968309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120622"},
        {"Hipparcos Number", "HIP 67574"},
        {"Smithsonian Astrophysical Observation", "SAO 158194"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70448328),
        dec: Angle.Degrees(-11.35877061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169754"},
        {"Hipparcos Number", "HIP 90402"},
        {"Geneva Identification System", "GEN# +1.00169754"},
        {"Smithsonian Astrophysical Observation", "SAO 161476"},
        {"Wilson Evans Batten Catalogue", "WEB 15477"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.67772375),
        dec: Angle.Degrees(-11.35689369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191404"},
        {"Hipparcos Number", "HIP 99366"},
        {"Renson", "Renson 53304"},
        {"Smithsonian Astrophysical Observation", "SAO 163309"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.53200862),
        dec: Angle.Degrees(-11.35687573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84529"},
        {"Hipparcos Number", "HIP 47895"},
        {"Smithsonian Astrophysical Observation", "SAO 155459"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.42274874),
        dec: Angle.Degrees(-11.35617141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39404"},
        {"Hipparcos Number", "HIP 27704"},
        {"Smithsonian Astrophysical Observation", "SAO 150883"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.99630779),
        dec: Angle.Degrees(-11.35559621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11508 AB"},
        {"Henry Draper", "HD 171935"},
        {"Hipparcos Number", "HIP 91340"},
        {"Smithsonian Astrophysical Observation", "SAO 161684"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.45548955),
        dec: Angle.Degrees(-11.35475398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19931"},
        {"Hipparcos Number", "HIP 14856"},
        {"Geneva Identification System", "GEN# +1.00019931"},
        {"Wilson Evans Batten Catalogue", "WEB 2870"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.96707995),
        dec: Angle.Degrees(-11.35378465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19306"},
        {"Hipparcos Number", "HIP 14411"},
        {"Smithsonian Astrophysical Observation", "SAO 148761"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.47958264),
        dec: Angle.Degrees(-11.35271941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34318"},
        {"Henry Draper 2", "HD 34319"},
        {"Hipparcos Number", "HIP 24560"},
        {"Geneva Identification System", "GEN# +1.00034318"},
        {"Smithsonian Astrophysical Observation", "SAO 150286"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.04399535),
        dec: Angle.Degrees(-11.35256415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156759"},
        {"Hipparcos Number", "HIP 84789"},
        {"Smithsonian Astrophysical Observation", "SAO 160466"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.96642541),
        dec: Angle.Degrees(-11.35173463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11783 A"},
        {"Henry Draper", "HD 174887"},
        {"Hipparcos Number", "HIP 92695"},
        {"Renson", "Renson 48950"},
        {"Smithsonian Astrophysical Observation", "SAO 161939"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.31115203),
        dec: Angle.Degrees(-11.35078651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203160"},
        {"Hipparcos Number", "HIP 105387"},
        {"Smithsonian Astrophysical Observation", "SAO 164323"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.20472201),
        dec: Angle.Degrees(-11.34958412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62165"},
        {"Hipparcos Number", "HIP 37536"},
        {"Geneva Identification System", "GEN# +1.00062165"},
        {"Smithsonian Astrophysical Observation", "SAO 153269"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.55529284),
        dec: Angle.Degrees(-11.34953320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216018"},
        {"Hipparcos Number", "HIP 112705"},
        {"Geneva Identification System", "GEN# +1.00216018"},
        {"Renson", "Renson 59680"},
        {"Smithsonian Astrophysical Observation", "SAO 165316"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.36038167),
        dec: Angle.Degrees(-11.34925539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152734"},
        {"Hipparcos Number", "HIP 82824"},
        {"Smithsonian Astrophysical Observation", "SAO 160166"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89028723),
        dec: Angle.Degrees(-11.34924952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41169"},
        {"Hipparcos Number", "HIP 28643"},
        {"Smithsonian Astrophysical Observation", "SAO 151058"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.72364214),
        dec: Angle.Degrees(-11.34862878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115079"},
        {"Hipparcos Number", "HIP 64643"},
        {"Smithsonian Astrophysical Observation", "SAO 157816"},
        {"Wilson Evans Batten Catalogue", "WEB 11433"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.75365679),
        dec: Angle.Degrees(-11.34845572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21020"},
        {"Hipparcos Number", "HIP 15772"},
        {"Geneva Identification System", "GEN# +1.00021020"},
        {"Smithsonian Astrophysical Observation", "SAO 148930"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.81693351),
        dec: Angle.Degrees(-11.34707151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15432"},
        {"Hipparcos Number", "HIP 11543"},
        {"Geneva Identification System", "GEN# +1.00015432"},
        {"Smithsonian Astrophysical Observation", "SAO 148408"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.19343420),
        dec: Angle.Degrees(-11.34660408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196077"},
        {"Hipparcos Number", "HIP 101590"},
        {"Smithsonian Astrophysical Observation", "SAO 163709"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.83029684),
        dec: Angle.Degrees(-11.34464671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13964"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.95630874),
        dec: Angle.Degrees(-11.34413923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -377.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209107"},
        {"Hipparcos Number", "HIP 108703"},
        {"Geneva Identification System", "GEN# +1.00209107"},
        {"Smithsonian Astrophysical Observation", "SAO 164815"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.30024542),
        dec: Angle.Degrees(-11.34356394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207568"},
        {"Hipparcos Number", "HIP 107793"},
        {"Fundamental Katalog 5th Edition", "FK5 5927"},
        {"Smithsonian Astrophysical Observation", "SAO 164688"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.54776393),
        dec: Angle.Degrees(-11.34309411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161981"},
        {"Hipparcos Number", "HIP 87213"},
        {"Smithsonian Astrophysical Observation", "SAO 160835"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.26881363),
        dec: Angle.Degrees(-11.34142918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149758"},
        {"Hipparcos Number", "HIP 81383"},
        {"Fundamental Katalog 5th Edition", "FK5 5470"},
        {"Smithsonian Astrophysical Observation", "SAO 160007"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.31401332),
        dec: Angle.Degrees(-11.34121485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85461"},
        {"Hipparcos Number", "HIP 48375"},
        {"Geneva Identification System", "GEN# +1.00085461"},
        {"Smithsonian Astrophysical Observation", "SAO 155545"},
        {"Wilson Evans Batten Catalogue", "WEB 9022"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.92165514),
        dec: Angle.Degrees(-11.34040999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67725"},
        {"Hipparcos Number", "HIP 39898"},
        {"Geneva Identification System", "GEN# +1.00067725"},
        {"Smithsonian Astrophysical Observation", "SAO 153887"},
        {"Wilson Evans Batten Catalogue", "WEB 7776"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.23689529),
        dec: Angle.Degrees(-11.33964517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10872 A"},
        {"Henry Draper", "HD 162956"},
        {"Hipparcos Number", "HIP 87642"},
        {"Smithsonian Astrophysical Observation", "SAO 160896"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.53149727),
        dec: Angle.Degrees(-11.33753175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172982"},
        {"Hipparcos Number", "HIP 91847"},
        {"Smithsonian Astrophysical Observation", "SAO 161766"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.88177952),
        dec: Angle.Degrees(-11.33700885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26465"},
        {"Hipparcos Number", "HIP 19506"},
        {"Smithsonian Astrophysical Observation", "SAO 149430"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.68416546),
        dec: Angle.Degrees(-11.33143074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8220"},
        {"Smithsonian Astrophysical Observation", "SAO 148002"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.46097620),
        dec: Angle.Degrees(-11.32948955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162532"},
        {"Hipparcos Number", "HIP 87424"},
        {"Smithsonian Astrophysical Observation", "SAO 160871"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.98907396),
        dec: Angle.Degrees(-11.32915844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207937"},
        {"Hipparcos Number", "HIP 108015"},
        {"Smithsonian Astrophysical Observation", "SAO 164710"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.24593391),
        dec: Angle.Degrees(-11.32855246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16946 AB"},
        {"Henry Draper", "HD 222676"},
        {"Hipparcos Number", "HIP 116975"},
        {"Smithsonian Astrophysical Observation", "SAO 165843"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.69928205),
        dec: Angle.Degrees(-11.32847466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206103"},
        {"Hipparcos Number", "HIP 106988"},
        {"Renson", "Renson 57400"},
        {"Smithsonian Astrophysical Observation", "SAO 164561"},
    },
    visualMagnitude: 9.40,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02537188),
        dec: Angle.Degrees(-11.32829195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126765"},
        {"Hipparcos Number", "HIP 70720"},
        {"Geneva Identification System", "GEN# +1.00126765"},
        {"Smithsonian Astrophysical Observation", "SAO 158579"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.94779449),
        dec: Angle.Degrees(-11.32763883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34325",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5799 AB"},
        {"Henry Draper", "HD 54025"},
        {"Hipparcos Number", "HIP 34325"},
        {"Celescope Catalog", "CEL 1591"},
        {"Geneva Identification System", "GEN# +1.00054025J"},
        {"Smithsonian Astrophysical Observation", "SAO 152399"},
        {"Wilson Evans Batten Catalogue", "WEB 6873"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.73515759),
        dec: Angle.Degrees(-11.32735042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70150"},
        {"Hipparcos Number", "HIP 40850"},
        {"Smithsonian Astrophysical Observation", "SAO 154123"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.03025799),
        dec: Angle.Degrees(-11.32687662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1339"},
        {"Henry Draper", "HD 10453"},
        {"Hipparcos Number", "HIP 7916"},
        {"Geneva Identification System", "GEN# +1.00010453"},
        {"Smithsonian Astrophysical Observation", "SAO 147962"},
        {"Wilson Evans Batten Catalogue", "WEB 1690"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.43665870),
        dec: Angle.Degrees(-11.32366816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -411.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175562"},
        {"Hipparcos Number", "HIP 92965"},
        {"Smithsonian Astrophysical Observation", "SAO 162005"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.09665245),
        dec: Angle.Degrees(-11.32326468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110765"},
        {"Hipparcos Number", "HIP 62164"},
        {"Smithsonian Astrophysical Observation", "SAO 157480"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10169188),
        dec: Angle.Degrees(-11.31880914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96976"},
        {"Hipparcos Number", "HIP 54551"},
        {"Smithsonian Astrophysical Observation", "SAO 156501"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43939842),
        dec: Angle.Degrees(-11.31874639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151854"},
        {"Hipparcos Number", "HIP 82409"},
        {"Smithsonian Astrophysical Observation", "SAO 160124"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.62020149),
        dec: Angle.Degrees(-11.31545737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80447"},
        {"Hipparcos Number", "HIP 45744"},
        {"Geneva Identification System", "GEN# +1.00080447"},
        {"Smithsonian Astrophysical Observation", "SAO 155090"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.89135802),
        dec: Angle.Degrees(-11.31499624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199128"},
        {"Hipparcos Number", "HIP 103280"},
        {"Smithsonian Astrophysical Observation", "SAO 163983"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.85183083),
        dec: Angle.Degrees(-11.31434036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20552"},
        {"Hipparcos Number", "HIP 15351"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.48971027),
        dec: Angle.Degrees(-11.31410803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4017 A"},
        {"Henry Draper", "HD 35564A"},
        {"Hipparcos Number", "HIP 25342"},
        {"Smithsonian Astrophysical Observation", "SAO 150424"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.30445916),
        dec: Angle.Degrees(-11.31238500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5342 AB"},
        {"Henry Draper", "HD 48127"},
        {"Hipparcos Number", "HIP 32029"},
        {"Smithsonian Astrophysical Observation", "SAO 151792"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.35845405),
        dec: Angle.Degrees(-11.31235564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217666"},
        {"Hipparcos Number", "HIP 113769"},
        {"Smithsonian Astrophysical Observation", "SAO 165453"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.59889671),
        dec: Angle.Degrees(-11.31226690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 967"},
        {"Hipparcos Number", "HIP 1128"},
        {"Cincinnati Publication", "Ci 18 19"},
        {"Cincinnati Publication 2", "Ci 20 14"},
        {"Geneva Identification System", "GEN# +1.00000967"},
        {"Smithsonian Astrophysical Observation", "SAO 147161"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.51761320),
        dec: Angle.Degrees(-11.31111824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 423.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103085"},
        {"Hipparcos Number", "HIP 57869"},
        {"Smithsonian Astrophysical Observation", "SAO 156947"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04246435),
        dec: Angle.Degrees(-11.30981479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112325"},
        {"Hipparcos Number", "HIP 63126"},
        {"Smithsonian Astrophysical Observation", "SAO 157602"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.01197938),
        dec: Angle.Degrees(-11.30960542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166521"},
        {"Hipparcos Number", "HIP 89136"},
        {"Geneva Identification System", "GEN# +1.00166521"},
        {"Smithsonian Astrophysical Observation", "SAO 161157"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.86697441),
        dec: Angle.Degrees(-11.30938684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83655"},
        {"Smithsonian Astrophysical Observation", "SAO 160272"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.46827930),
        dec: Angle.Degrees(-11.30769685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120249"},
        {"Hipparcos Number", "HIP 67369"},
        {"Smithsonian Astrophysical Observation", "SAO 158175"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13059328),
        dec: Angle.Degrees(-11.30651281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152680"},
        {"Hipparcos Number", "HIP 82794"},
        {"Geneva Identification System", "GEN# +1.00152680"},
        {"Smithsonian Astrophysical Observation", "SAO 160162"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.80249765),
        dec: Angle.Degrees(-11.30558992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76887"},
        {"Smithsonian Astrophysical Observation", "SAO 159445"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49823590),
        dec: Angle.Degrees(-11.30492559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115903"},
        {"Hipparcos Number", "HIP 65074"},
        {"Geneva Identification System", "GEN# +1.00115903"},
        {"Smithsonian Astrophysical Observation", "SAO 157869"},
        {"Wilson Evans Batten Catalogue", "WEB 11494"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.08355165),
        dec: Angle.Degrees(-11.30411836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8037 AB"},
        {"Henry Draper", "HD 95808"},
        {"Hipparcos Number", "HIP 54029"},
        {"Geneva Identification System", "GEN# +1.00095808J"},
        {"Smithsonian Astrophysical Observation", "SAO 156421"},
        {"Wilson Evans Batten Catalogue", "WEB 9770"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.81220090),
        dec: Angle.Degrees(-11.30320923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119352"},
        {"Hipparcos Number", "HIP 66926"},
        {"Smithsonian Astrophysical Observation", "SAO 158111"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.74050259),
        dec: Angle.Degrees(-11.30218058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5713 AB"},
        {"Henry Draper", "HD 52721"},
        {"Hipparcos Number", "HIP 33868"},
        {"Celescope Catalog", "CEL 1515"},
        {"Geneva Identification System", "GEN# +1.00052721J"},
        {"Smithsonian Astrophysical Observation", "SAO 152255"},
        {"Wilson Evans Batten Catalogue", "WEB 6800"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.45630240),
        dec: Angle.Degrees(-11.30093428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181423"},
        {"Hipparcos Number", "HIP 95104"},
        {"Smithsonian Astrophysical Observation", "SAO 162498"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.21529534),
        dec: Angle.Degrees(-11.30092084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12116"},
        {"Hipparcos Number", "HIP 9237"},
        {"Geneva Identification System", "GEN# +1.00012116"},
        {"Smithsonian Astrophysical Observation", "SAO 148139"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.69147870),
        dec: Angle.Degrees(-11.30074034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32075"},
        {"Hipparcos Number", "HIP 23256"},
        {"Smithsonian Astrophysical Observation", "SAO 150069"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.06769031),
        dec: Angle.Degrees(-11.29971025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1832"},
        {"Smithsonian Astrophysical Observation", "SAO 147244"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.80692663),
        dec: Angle.Degrees(-11.29903759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119060"},
        {"Hipparcos Number", "HIP 66776"},
        {"Smithsonian Astrophysical Observation", "SAO 158087"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.29844847),
        dec: Angle.Degrees(-11.29804607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5795 AB"},
        {"Henry Draper", "HD 53974"},
        {"Hipparcos Number", "HIP 34301"},
        {"Celescope Catalog", "CEL 1585"},
        {"Geneva Identification System", "GEN# +1.00053974"},
        {"Smithsonian Astrophysical Observation", "SAO 152394"},
        {"Wilson Evans Batten Catalogue", "WEB 6872"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.66986950),
        dec: Angle.Degrees(-11.29401875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69156"},
        {"Hipparcos Number", "HIP 40437"},
        {"Smithsonian Astrophysical Observation", "SAO 154032"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.85363002),
        dec: Angle.Degrees(-11.29289665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143633"},
        {"Hipparcos Number", "HIP 78534"},
        {"Smithsonian Astrophysical Observation", "SAO 159643"},
    },
    visualMagnitude: 9.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.50174222),
        dec: Angle.Degrees(-11.29236250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73048"},
        {"Hipparcos Number", "HIP 42176"},
        {"Smithsonian Astrophysical Observation", "SAO 154434"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96629630),
        dec: Angle.Degrees(-11.29141862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146832"},
        {"Hipparcos Number", "HIP 79915"},
        {"Smithsonian Astrophysical Observation", "SAO 159843"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.68115080),
        dec: Angle.Degrees(-11.28948961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168393"},
        {"Hipparcos Number", "HIP 89828"},
        {"Geneva Identification System", "GEN# +1.00168393"},
        {"Smithsonian Astrophysical Observation", "SAO 161345"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.96718040),
        dec: Angle.Degrees(-11.28748424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21530"},
        {"Hipparcos Number", "HIP 16142"},
        {"Geneva Identification System", "GEN# +1.00021530"},
        {"Smithsonian Astrophysical Observation", "SAO 148972"},
        {"Wilson Evans Batten Catalogue", "WEB 3078"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.00395041),
        dec: Angle.Degrees(-11.28648689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208791"},
        {"Hipparcos Number", "HIP 108516"},
        {"Smithsonian Astrophysical Observation", "SAO 164785"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.75543879),
        dec: Angle.Degrees(-11.28426502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3127"},
        {"Hipparcos Number", "HIP 2704"},
        {"Smithsonian Astrophysical Observation", "SAO 147343"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.59753532),
        dec: Angle.Degrees(-11.28288519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89980"},
        {"Hipparcos Number", "HIP 50850"},
        {"Fundamental Katalog 5th Edition", "FK5 4922"},
        {"Smithsonian Astrophysical Observation", "SAO 155942"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.74879172),
        dec: Angle.Degrees(-11.28095664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22931"},
        {"Hipparcos Number", "HIP 17163"},
        {"Smithsonian Astrophysical Observation", "SAO 149097"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.14057074),
        dec: Angle.Degrees(-11.27687896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183870"},
        {"Hipparcos Number", "HIP 96085"},
        {"Geneva Identification System", "GEN# +1.00183870"},
        {"Smithsonian Astrophysical Observation", "SAO 162730"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.02735301),
        dec: Angle.Degrees(-11.27498601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83209"},
        {"Hipparcos Number", "HIP 47153"},
        {"Smithsonian Astrophysical Observation", "SAO 155335"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.12956090),
        dec: Angle.Degrees(-11.27419082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2819"},
        {"Hipparcos Number", "HIP 2483"},
        {"Smithsonian Astrophysical Observation", "SAO 147323"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88216341),
        dec: Angle.Degrees(-11.27324041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111678"},
        {"Hipparcos Number", "HIP 62715"},
        {"Smithsonian Astrophysical Observation", "SAO 157546"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.78710626),
        dec: Angle.Degrees(-11.26703878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160276"},
        {"Hipparcos Number", "HIP 86416"},
        {"Geneva Identification System", "GEN# +1.00160276"},
        {"Smithsonian Astrophysical Observation", "SAO 160725"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.86717997),
        dec: Angle.Degrees(-11.26696424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5437"},
        {"Hipparcos Number", "HIP 4371"},
        {"Geneva Identification System", "GEN# +1.00005437"},
        {"Smithsonian Astrophysical Observation", "SAO 147519"},
        {"Wilson Evans Batten Catalogue", "WEB 781"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.00627513),
        dec: Angle.Degrees(-11.26650685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97181"},
        {"Hipparcos Number", "HIP 54645"},
        {"Smithsonian Astrophysical Observation", "SAO 156515"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.76836067),
        dec: Angle.Degrees(-11.26607607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217681"},
        {"Hipparcos Number", "HIP 113779"},
        {"Smithsonian Astrophysical Observation", "SAO 165454"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63305044),
        dec: Angle.Degrees(-11.26565725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59129"},
        {"Hipparcos Number", "HIP 36296"},
        {"Smithsonian Astrophysical Observation", "SAO 152919"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.07041049),
        dec: Angle.Degrees(-11.26528887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219678"},
        {"Hipparcos Number", "HIP 115031"},
        {"Smithsonian Astrophysical Observation", "SAO 165613"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47445017),
        dec: Angle.Degrees(-11.26385805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50674"},
        {"Hipparcos Number", "HIP 33112"},
        {"Smithsonian Astrophysical Observation", "SAO 152065"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.44864886),
        dec: Angle.Degrees(-11.26364704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145466"},
        {"Hipparcos Number", "HIP 79339"},
        {"Smithsonian Astrophysical Observation", "SAO 159761"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.88210955),
        dec: Angle.Degrees(-11.26329941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45764"},
        {"Hipparcos Number", "HIP 30881"},
        {"Celescope Catalog", "CEL 1261"},
        {"Geneva Identification System", "GEN# +1.00045764"},
        {"Smithsonian Astrophysical Observation", "SAO 151550"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.23484426),
        dec: Angle.Degrees(-11.26284863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164164"},
        {"Hipparcos Number", "HIP 88158"},
        {"Smithsonian Astrophysical Observation", "SAO 160983"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.08315557),
        dec: Angle.Degrees(-11.25964111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117676"},
        {"Hipparcos Number", "HIP 66018"},
        {"Smithsonian Astrophysical Observation", "SAO 157989"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.01970331),
        dec: Angle.Degrees(-11.25618811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208354"},
        {"Hipparcos Number", "HIP 108265"},
        {"Smithsonian Astrophysical Observation", "SAO 164749"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.00554027),
        dec: Angle.Degrees(-11.25404965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14149"},
        {"Hipparcos Number", "HIP 10645"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26279897),
        dec: Angle.Degrees(-11.25321071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55589"},
        {"Hipparcos Number", "HIP 34888"},
        {"Fundamental Katalog 5th Edition", "FK5 2557"},
        {"Geneva Identification System", "GEN# +1.00055589"},
        {"Smithsonian Astrophysical Observation", "SAO 152570"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27998092),
        dec: Angle.Degrees(-11.25136060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138310"},
        {"Hipparcos Number", "HIP 76020"},
        {"Geneva Identification System", "GEN# +1.00138310"},
        {"Smithsonian Astrophysical Observation", "SAO 159319"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.90893806),
        dec: Angle.Degrees(-11.24371645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57367"},
        {"Hipparcos Number", "HIP 35570"},
        {"Smithsonian Astrophysical Observation", "SAO 152742"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.12369715),
        dec: Angle.Degrees(-11.24285491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159358"},
        {"Hipparcos Number", "HIP 86019"},
        {"Fundamental Katalog 5th Edition", "FK5 1461"},
        {"Geneva Identification System", "GEN# +1.00159358"},
        {"Smithsonian Astrophysical Observation", "SAO 160653"},
        {"Wilson Evans Batten Catalogue", "WEB 14513"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.69312162),
        dec: Angle.Degrees(-11.24200693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184810"},
        {"Hipparcos Number", "HIP 96454"},
        {"Smithsonian Astrophysical Observation", "SAO 162812"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15283186),
        dec: Angle.Degrees(-11.24033688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213936"},
        {"Hipparcos Number", "HIP 111475"},
        {"Smithsonian Astrophysical Observation", "SAO 165173"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.77594289),
        dec: Angle.Degrees(-11.23929089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101197"},
        {"Hipparcos Number", "HIP 56798"},
        {"Geneva Identification System", "GEN# +1.00101197"},
        {"Smithsonian Astrophysical Observation", "SAO 156801"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.65913205),
        dec: Angle.Degrees(-11.23926001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8121"},
        {"Hipparcos Number", "HIP 6272"},
        {"Fundamental Katalog 5th Edition", "FK5 2088"},
        {"Geneva Identification System", "GEN# +1.00008121"},
        {"Smithsonian Astrophysical Observation", "SAO 147746"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.11599020),
        dec: Angle.Degrees(-11.23881490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77316"},
        {"Hipparcos Number", "HIP 44311"},
        {"Smithsonian Astrophysical Observation", "SAO 154842"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.35938285),
        dec: Angle.Degrees(-11.23840062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2488"},
        {"Hipparcos Number", "HIP 2246"},
        {"Smithsonian Astrophysical Observation", "SAO 147292"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.13813952),
        dec: Angle.Degrees(-11.23721888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5212 AB"},
        {"Henry Draper", "HD 46716"},
        {"Hipparcos Number", "HIP 31356"},
        {"Geneva Identification System", "GEN# +1.00046716J"},
        {"Smithsonian Astrophysical Observation", "SAO 151653"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.63345287),
        dec: Angle.Degrees(-11.22972636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179601"},
        {"Hipparcos Number", "HIP 94463"},
        {"Smithsonian Astrophysical Observation", "SAO 162334"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.39783968),
        dec: Angle.Degrees(-11.22914277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212741"},
        {"Hipparcos Number", "HIP 110786"},
        {"Smithsonian Astrophysical Observation", "SAO 165079"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.67352265),
        dec: Angle.Degrees(-11.22817087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50533"},
        {"Hipparcos Number", "HIP 33075"},
        {"Smithsonian Astrophysical Observation", "SAO 152049"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.32301258),
        dec: Angle.Degrees(-11.22570190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2795"},
        {"Hipparcos Number", "HIP 2467"},
        {"Geneva Identification System", "GEN# +1.00002795"},
        {"Smithsonian Astrophysical Observation", "SAO 147322"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.83437403),
        dec: Angle.Degrees(-11.22379992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194957"},
        {"Hipparcos Number", "HIP 101014"},
        {"Smithsonian Astrophysical Observation", "SAO 163613"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18595973),
        dec: Angle.Degrees(-11.22315223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114611"},
        {"Hipparcos Number", "HIP 64378"},
        {"Smithsonian Astrophysical Observation", "SAO 157785"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.91913114),
        dec: Angle.Degrees(-11.22164893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119852"},
        {"Hipparcos Number", "HIP 67169"},
        {"Geneva Identification System", "GEN# +1.00119852"},
        {"Smithsonian Astrophysical Observation", "SAO 158151"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46825789),
        dec: Angle.Degrees(-11.22127929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80356"},
        {"Geneva Identification System", "GEN# -0.01004311"},
        {"Smithsonian Astrophysical Observation", "SAO 159897"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.05520462),
        dec: Angle.Degrees(-11.21832484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182597"},
        {"Hipparcos Number", "HIP 95525"},
        {"Smithsonian Astrophysical Observation", "SAO 162604"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.45887298),
        dec: Angle.Degrees(-11.21752564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173726"},
        {"Hipparcos Number", "HIP 92179"},
        {"Smithsonian Astrophysical Observation", "SAO 161824"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.80633979),
        dec: Angle.Degrees(-11.21621992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37622"},
        {"Hipparcos Number", "HIP 26612"},
        {"Geneva Identification System", "GEN# +1.00037622"},
        {"Smithsonian Astrophysical Observation", "SAO 150653"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.85454549),
        dec: Angle.Degrees(-11.21022653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3610 AB"},
        {"Henry Draper", "HD 32222"},
        {"Hipparcos Number", "HIP 23326"},
        {"Smithsonian Astrophysical Observation", "SAO 150078"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.26251011),
        dec: Angle.Degrees(-11.20807362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102946"},
        {"Hipparcos Number", "HIP 57800"},
        {"Smithsonian Astrophysical Observation", "SAO 156937"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.77694718),
        dec: Angle.Degrees(-11.20781825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124823"},
        {"Hipparcos Number", "HIP 69691"},
        {"Smithsonian Astrophysical Observation", "SAO 158455"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.98425107),
        dec: Angle.Degrees(-11.20505445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50255"},
        {"Hipparcos Number", "HIP 32971"},
        {"Geneva Identification System", "GEN# +1.00050255"},
        {"Smithsonian Astrophysical Observation", "SAO 152024"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.01006786),
        dec: Angle.Degrees(-11.20453583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131195"},
        {"Hipparcos Number", "HIP 72758"},
        {"Smithsonian Astrophysical Observation", "SAO 158869"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.11402036),
        dec: Angle.Degrees(-11.20368970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89033"},
        {"Hipparcos Number", "HIP 50292"},
        {"Geneva Identification System", "GEN# +1.00089033J"},
        {"Smithsonian Astrophysical Observation", "SAO 155855"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03755048),
        dec: Angle.Degrees(-11.20341702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22657"},
        {"Hipparcos Number", "HIP 16977"},
        {"Geneva Identification System", "GEN# +1.00022657"},
        {"Smithsonian Astrophysical Observation", "SAO 149077"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.58517137),
        dec: Angle.Degrees(-11.20153556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87513"},
        {"Hipparcos Number", "HIP 49425"},
        {"Geneva Identification System", "GEN# +1.00087513"},
        {"Smithsonian Astrophysical Observation", "SAO 155716"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.33288485),
        dec: Angle.Degrees(-11.20105467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37828"},
        {"Hipparcos Number", "HIP 26740"},
        {"Geneva Identification System", "GEN# +1.00037828"},
        {"Smithsonian Astrophysical Observation", "SAO 150685"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.22759534),
        dec: Angle.Degrees(-11.19993681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53035"},
        {"Hipparcos Number", "HIP 33987"},
        {"Celescope Catalog", "CEL 1532"},
        {"Geneva Identification System", "GEN# +1.00053035"},
        {"Smithsonian Astrophysical Observation", "SAO 152288"},
        {"Wilson Evans Batten Catalogue", "WEB 6817"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.78236202),
        dec: Angle.Degrees(-11.19915623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58996"},
        {"Hipparcos Number", "HIP 36229"},
        {"Smithsonian Astrophysical Observation", "SAO 152904"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.90758510),
        dec: Angle.Degrees(-11.19877735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1990 AB"},
        {"Henry Draper", "HD 16355"},
        {"Hipparcos Number", "HIP 12204"},
        {"Smithsonian Astrophysical Observation", "SAO 148505"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.28583003),
        dec: Angle.Degrees(-11.19761141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133669"},
        {"Hipparcos Number", "HIP 73888"},
        {"Smithsonian Astrophysical Observation", "SAO 159020"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.52601714),
        dec: Angle.Degrees(-11.19661485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57115"},
        {"Hipparcos Number", "HIP 35479"},
        {"Smithsonian Astrophysical Observation", "SAO 152721"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84704041),
        dec: Angle.Degrees(-11.19657543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22409"},
        {"Hipparcos Number", "HIP 16780"},
        {"Geneva Identification System", "GEN# +1.00022409"},
        {"Smithsonian Astrophysical Observation", "SAO 149057"},
        {"Wilson Evans Batten Catalogue", "WEB 3193"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.99021710),
        dec: Angle.Degrees(-11.19397792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211359"},
        {"Hipparcos Number", "HIP 109994"},
        {"Smithsonian Astrophysical Observation", "SAO 164970"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.17521408),
        dec: Angle.Degrees(-11.19240705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177011"},
        {"Hipparcos Number", "HIP 93548"},
        {"Smithsonian Astrophysical Observation", "SAO 162139"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.80373519),
        dec: Angle.Degrees(-11.18959443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54261"},
        {"Smithsonian Astrophysical Observation", "SAO 156451"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.51326077),
        dec: Angle.Degrees(-11.18841543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88972"},
        {"Hipparcos Number", "HIP 50250"},
        {"Geneva Identification System", "GEN# +1.00088972"},
        {"Smithsonian Astrophysical Observation", "SAO 155850"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.91002862),
        dec: Angle.Degrees(-11.18825168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158659"},
        {"Hipparcos Number", "HIP 85720"},
        {"Geneva Identification System", "GEN# +1.00158659"},
        {"Wilson Evans Batten Catalogue", "WEB 14466"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.74730507),
        dec: Angle.Degrees(-11.18658020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178288"},
        {"Hipparcos Number", "HIP 94017"},
        {"Smithsonian Astrophysical Observation", "SAO 162233"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.12362211),
        dec: Angle.Degrees(-11.18556041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89418"},
        {"Hipparcos Number", "HIP 50515"},
        {"Geneva Identification System", "GEN# +1.00089418"},
        {"Smithsonian Astrophysical Observation", "SAO 155887"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.75086932),
        dec: Angle.Degrees(-11.18476135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82558"},
        {"Hipparcos Number", "HIP 46816"},
        {"Cincinnati Publication", "Ci 18 1133"},
        {"Geneva Identification System", "GEN# +1.00082558"},
        {"Smithsonian Astrophysical Observation", "SAO 155272"},
        {"Wilson Evans Batten Catalogue", "WEB 8829"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.10714949),
        dec: Angle.Degrees(-11.18471992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46899"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.36077119),
        dec: Angle.Degrees(-11.18318792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73929"},
        {"Smithsonian Astrophysical Observation", "SAO 159025"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.61573837),
        dec: Angle.Degrees(-11.18227707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202095"},
        {"Hipparcos Number", "HIP 104808"},
        {"Geneva Identification System", "GEN# +1.00202095"},
        {"Smithsonian Astrophysical Observation", "SAO 164236"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.50646626),
        dec: Angle.Degrees(-11.18162348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63540"},
        {"Hipparcos Number", "HIP 38150"},
        {"Geneva Identification System", "GEN# +1.00063540"},
        {"Smithsonian Astrophysical Observation", "SAO 153441"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.27573517),
        dec: Angle.Degrees(-11.18115840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167518"},
        {"Hipparcos Number", "HIP 89524"},
        {"Geneva Identification System", "GEN# +1.00167518"},
        {"Smithsonian Astrophysical Observation", "SAO 161242"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.01934404),
        dec: Angle.Degrees(-11.17980331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136232"},
        {"Hipparcos Number", "HIP 75028"},
        {"Smithsonian Astrophysical Observation", "SAO 159177"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.96388501),
        dec: Angle.Degrees(-11.17974293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127915"},
        {"Hipparcos Number", "HIP 71252"},
        {"Smithsonian Astrophysical Observation", "SAO 158649"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.56929099),
        dec: Angle.Degrees(-11.17726580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109695",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 56"},
        {"Aitken", "ADS 15739 AB"},
        {"Henry Draper", "HD 210803"},
        {"Hipparcos Number", "HIP 109695"},
        {"Geneva Identification System", "GEN# +1.00210803"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29410487),
        dec: Angle.Degrees(-11.17715721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 273.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212586"},
        {"Hipparcos Number", "HIP 110691"},
        {"Geneva Identification System", "GEN# +1.00212586"},
        {"Smithsonian Astrophysical Observation", "SAO 165064"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.39781344),
        dec: Angle.Degrees(-11.17572508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150620"},
        {"Hipparcos Number", "HIP 81812"},
        {"Smithsonian Astrophysical Observation", "SAO 160057"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.64762134),
        dec: Angle.Degrees(-11.17458057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41814"},
        {"Hipparcos Number", "HIP 28973"},
        {"Fundamental Katalog 5th Edition", "FK5 4558"},
        {"Geneva Identification System", "GEN# +1.00041814"},
        {"Smithsonian Astrophysical Observation", "SAO 151126"},
        {"Wilson Evans Batten Catalogue", "WEB 5672"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.71621808),
        dec: Angle.Degrees(-11.17359662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63977"},
        {"Hipparcos Number", "HIP 38350"},
        {"Smithsonian Astrophysical Observation", "SAO 153490"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.82393173),
        dec: Angle.Degrees(-11.17185406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126917"},
        {"Hipparcos Number", "HIP 70797"},
        {"Smithsonian Astrophysical Observation", "SAO 158589"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.17866602),
        dec: Angle.Degrees(-11.17168805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29481"},
        {"Hipparcos Number", "HIP 21584"},
        {"Smithsonian Astrophysical Observation", "SAO 149778"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.52889074),
        dec: Angle.Degrees(-11.16815410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1610"},
        {"Hipparcos Number", "HIP 1622"},
        {"Geneva Identification System", "GEN# +1.00001610"},
        {"Smithsonian Astrophysical Observation", "SAO 147224"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.07051992),
        dec: Angle.Degrees(-11.16783017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46407"},
        {"Hipparcos Number", "HIP 31205"},
        {"Geneva Identification System", "GEN# +1.00046407"},
        {"Smithsonian Astrophysical Observation", "SAO 151625"},
        {"Wilson Evans Batten Catalogue", "WEB 6234"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.19534629),
        dec: Angle.Degrees(-11.16639661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215553"},
        {"Hipparcos Number", "HIP 112420"},
        {"Smithsonian Astrophysical Observation", "SAO 165285"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.55928272),
        dec: Angle.Degrees(-11.16622970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 757"},
        {"Hipparcos Number", "HIP 962"},
        {"Geneva Identification System", "GEN# +1.00000757"},
        {"Smithsonian Astrophysical Observation", "SAO 147140"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.97473845),
        dec: Angle.Degrees(-11.16484347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4504"},
        {"Hipparcos Number", "HIP 3670"},
        {"Geneva Identification System", "GEN# +1.00004504"},
        {"Smithsonian Astrophysical Observation", "SAO 147446"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.74215031),
        dec: Angle.Degrees(-11.16293546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65474",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Spica"},
        {"Henry Draper", "HD 116658"},
        {"Hipparcos Number", "HIP 65474"},
        {"Fundamental Katalog 5th Edition", "FK5 498"},
        {"Geneva Identification System", "GEN# +1.00116658"},
        {"Smithsonian Astrophysical Observation", "SAO 157923"},
        {"Wilson Evans Batten Catalogue", "WEB 11556"},
    },
    visualMagnitude: 0.98,
    bvColour: -0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.29835230),
        dec: Angle.Degrees(-11.16124491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52159"},
        {"Hipparcos Number", "HIP 33670"},
        {"Geneva Identification System", "GEN# +1.00052159"},
        {"Smithsonian Astrophysical Observation", "SAO 152213"},
    },
    visualMagnitude: 9.69,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.92769821),
        dec: Angle.Degrees(-11.15738962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53691"},
        {"Hipparcos Number", "HIP 34213"},
        {"Celescope Catalog", "CEL 1568"},
        {"Geneva Identification System", "GEN# +1.00053691"},
        {"Smithsonian Astrophysical Observation", "SAO 152358"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.40675619),
        dec: Angle.Degrees(-11.15726966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80395"},
        {"Hipparcos Number", "HIP 45720"},
        {"Smithsonian Astrophysical Observation", "SAO 155085"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.80737428),
        dec: Angle.Degrees(-11.15725412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113080"},
        {"Hipparcos Number", "HIP 63555"},
        {"Fundamental Katalog 5th Edition", "FK5 5148"},
        {"Smithsonian Astrophysical Observation", "SAO 157658"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.34923596),
        dec: Angle.Degrees(-11.15688243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220686"},
        {"Hipparcos Number", "HIP 115657"},
        {"Smithsonian Astrophysical Observation", "SAO 165684"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.44966328),
        dec: Angle.Degrees(-11.15563019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132230"},
        {"Hipparcos Number", "HIP 73249"},
        {"Geneva Identification System", "GEN# +1.00132230"},
        {"Smithsonian Astrophysical Observation", "SAO 158935"},
        {"Wilson Evans Batten Catalogue", "WEB 12552"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.55590463),
        dec: Angle.Degrees(-11.15474025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76477"},
        {"Hipparcos Number", "HIP 43859"},
        {"Renson", "Renson 21550"},
        {"Smithsonian Astrophysical Observation", "SAO 154762"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.01958825),
        dec: Angle.Degrees(-11.15370096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123423"},
        {"Hipparcos Number", "HIP 69029"},
        {"Geneva Identification System", "GEN# +1.00123423"},
        {"Smithsonian Astrophysical Observation", "SAO 158369"},
        {"Wilson Evans Batten Catalogue", "WEB 12057"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.96856187),
        dec: Angle.Degrees(-11.15207895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64794"},
        {"Hipparcos Number", "HIP 38691"},
        {"Geneva Identification System", "GEN# +1.00064794"},
        {"Smithsonian Astrophysical Observation", "SAO 153583"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.82148262),
        dec: Angle.Degrees(-11.15147408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186147"},
        {"Hipparcos Number", "HIP 97026"},
        {"Smithsonian Astrophysical Observation", "SAO 162927"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.78121219),
        dec: Angle.Degrees(-11.15130392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3708"},
        {"Hipparcos Number", "HIP 3122"},
        {"Geneva Identification System", "GEN# +1.00003708"},
        {"Smithsonian Astrophysical Observation", "SAO 147387"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93184864),
        dec: Angle.Degrees(-11.15047993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115766"},
        {"Hipparcos Number", "HIP 65004"},
        {"Smithsonian Astrophysical Observation", "SAO 157855"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.86046401),
        dec: Angle.Degrees(-11.14837812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2577 AB"},
        {"Henry Draper", "HD 21735"},
        {"Hipparcos Number", "HIP 16291"},
        {"Smithsonian Astrophysical Observation", "SAO 148989"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.49606889),
        dec: Angle.Degrees(-11.14633359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4741 A"},
        {"Henry Draper", "HD 42116"},
        {"Hipparcos Number", "HIP 29118"},
        {"Smithsonian Astrophysical Observation", "SAO 151154"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.10577945),
        dec: Angle.Degrees(-11.14625666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9456 A"},
        {"Henry Draper", "HD 132345"},
        {"Hipparcos Number", "HIP 73310"},
        {"Geneva Identification System", "GEN# +1.00132345A"},
        {"Smithsonian Astrophysical Observation", "SAO 158946"},
        {"Wilson Evans Batten Catalogue", "WEB 12556"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.72351684),
        dec: Angle.Degrees(-11.14386422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43567"},
        {"Hipparcos Number", "HIP 29803"},
        {"Smithsonian Astrophysical Observation", "SAO 151298"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.11884483),
        dec: Angle.Degrees(-11.14322024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140069"},
        {"Hipparcos Number", "HIP 76888"},
        {"Geneva Identification System", "GEN# +1.00140069"},
        {"Smithsonian Astrophysical Observation", "SAO 159446"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49976824),
        dec: Angle.Degrees(-11.14093007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43269"},
        {"Hipparcos Number", "HIP 29653"},
        {"Geneva Identification System", "GEN# +1.00043269"},
        {"Smithsonian Astrophysical Observation", "SAO 151264"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.71615802),
        dec: Angle.Degrees(-11.13974289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53060"},
        {"Hipparcos Number", "HIP 33998"},
        {"Geneva Identification System", "GEN# +1.00053060"},
        {"Smithsonian Astrophysical Observation", "SAO 152295"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.80919458),
        dec: Angle.Degrees(-11.13741206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140070"},
        {"Hipparcos Number", "HIP 76891"},
        {"Smithsonian Astrophysical Observation", "SAO 159447"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50493091),
        dec: Angle.Degrees(-11.13698160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27397"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.07196957),
        dec: Angle.Degrees(-11.13553202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 374.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88518"},
        {"Hipparcos Number", "HIP 49985"},
        {"Smithsonian Astrophysical Observation", "SAO 155809"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.07241802),
        dec: Angle.Degrees(-11.13518063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109221"},
        {"Hipparcos Number", "HIP 61255"},
        {"Smithsonian Astrophysical Observation", "SAO 157357"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.29500996),
        dec: Angle.Degrees(-11.13417708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132683"},
        {"Hipparcos Number", "HIP 73457"},
        {"Cincinnati Publication", "Ci 20 903"},
        {"Geneva Identification System", "GEN# +1.00132683"},
        {"Smithsonian Astrophysical Observation", "SAO 158967"},
        {"Wilson Evans Batten Catalogue", "WEB 12571"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.18092714),
        dec: Angle.Degrees(-11.13396143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -480.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145169"},
        {"Hipparcos Number", "HIP 79196"},
        {"Geneva Identification System", "GEN# +1.00145169"},
        {"Smithsonian Astrophysical Observation", "SAO 159747"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.46173952),
        dec: Angle.Degrees(-11.13227720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217077"},
        {"Hipparcos Number", "HIP 113412"},
        {"Smithsonian Astrophysical Observation", "SAO 165409"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.52997829),
        dec: Angle.Degrees(-11.13196584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148632"},
        {"Hipparcos Number", "HIP 80795"},
        {"Smithsonian Astrophysical Observation", "SAO 159949"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.45198461),
        dec: Angle.Degrees(-11.12951989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318"},
        {"Hipparcos Number", "HIP 639"},
        {"Smithsonian Astrophysical Observation", "SAO 147094"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.95164360),
        dec: Angle.Degrees(-11.12904586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33371"},
        {"Hipparcos Number", "HIP 23985"},
        {"Geneva Identification System", "GEN# +1.00033371"},
        {"Smithsonian Astrophysical Observation", "SAO 150181"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.34177249),
        dec: Angle.Degrees(-11.12883409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63894"},
        {"Hipparcos Number", "HIP 38307"},
        {"Fundamental Katalog 5th Edition", "FK5 2609"},
        {"Geneva Identification System", "GEN# +1.00063894"},
        {"Smithsonian Astrophysical Observation", "SAO 153479"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.73016385),
        dec: Angle.Degrees(-11.12852084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3400"},
        {"Hipparcos Number", "HIP 2910"},
        {"Geneva Identification System", "GEN# +1.00003400"},
        {"Smithsonian Astrophysical Observation", "SAO 147370"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.21529341),
        dec: Angle.Degrees(-11.12736091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60568"},
        {"Hipparcos Number", "HIP 36865"},
        {"Smithsonian Astrophysical Observation", "SAO 153088"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.68509575),
        dec: Angle.Degrees(-11.12662433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19810"},
        {"Hipparcos Number", "HIP 14781"},
        {"Geneva Identification System", "GEN# +1.00019810"},
        {"Smithsonian Astrophysical Observation", "SAO 148810"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.71447907),
        dec: Angle.Degrees(-11.12482810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99111"},
        {"Hipparcos Number", "HIP 55656"},
        {"Smithsonian Astrophysical Observation", "SAO 156653"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.04355607),
        dec: Angle.Degrees(-11.12438381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28357"},
        {"Hipparcos Number", "HIP 20829"},
        {"Geneva Identification System", "GEN# +1.00028357"},
        {"Smithsonian Astrophysical Observation", "SAO 149650"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.94792243),
        dec: Angle.Degrees(-11.12435258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84728"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.79696092),
        dec: Angle.Degrees(-11.12432612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26693"},
        {"Hipparcos Number", "HIP 19678"},
        {"Smithsonian Astrophysical Observation", "SAO 149459"},
    },
    visualMagnitude: 8.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.23467319),
        dec: Angle.Degrees(-11.12307847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22785"},
        {"Smithsonian Astrophysical Observation", "SAO 149969"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51694978),
        dec: Angle.Degrees(-11.11894330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51542"},
        {"Hipparcos Number", "HIP 33457"},
        {"Geneva Identification System", "GEN# +1.00051542"},
        {"Smithsonian Astrophysical Observation", "SAO 152159"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.33841920),
        dec: Angle.Degrees(-11.11764447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53010"},
        {"Hipparcos Number", "HIP 33979"},
        {"Geneva Identification System", "GEN# +1.00053010"},
        {"Smithsonian Astrophysical Observation", "SAO 152287"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.75938249),
        dec: Angle.Degrees(-11.11711456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87978"},
        {"Hipparcos Number", "HIP 49674"},
        {"Geneva Identification System", "GEN# +1.00087978"},
        {"Smithsonian Astrophysical Observation", "SAO 155758"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.11118634),
        dec: Angle.Degrees(-11.11529562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172771"},
        {"Hipparcos Number", "HIP 91740"},
        {"Smithsonian Astrophysical Observation", "SAO 161748"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.61936566),
        dec: Angle.Degrees(-11.11073641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94206"},
        {"Hipparcos Number", "HIP 53145"},
        {"Geneva Identification System", "GEN# +1.00094206"},
        {"Smithsonian Astrophysical Observation", "SAO 156285"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.07266774),
        dec: Angle.Degrees(-11.10998828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49438"},
        {"Hipparcos Number", "HIP 32585"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.98900990),
        dec: Angle.Degrees(-11.10839769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172317"},
        {"Hipparcos Number", "HIP 91530"},
        {"Geneva Identification System", "GEN# +1.00172317"},
        {"Smithsonian Astrophysical Observation", "SAO 161706"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.98539375),
        dec: Angle.Degrees(-11.10700280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10489"},
        {"Hipparcos Number", "HIP 7959"},
        {"Cincinnati Publication", "Ci 18 239"},
        {"Geneva Identification System", "GEN# +1.00010489"},
        {"Smithsonian Astrophysical Observation", "SAO 147968"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.55218298),
        dec: Angle.Degrees(-11.10510833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223509"},
        {"Hipparcos Number", "HIP 117528"},
        {"Geneva Identification System", "GEN# +1.00223509"},
        {"Smithsonian Astrophysical Observation", "SAO 165909"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.52523964),
        dec: Angle.Degrees(-11.10310015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118661"},
        {"Hipparcos Number", "HIP 66548"},
        {"Smithsonian Astrophysical Observation", "SAO 158058"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.62448337),
        dec: Angle.Degrees(-11.10305250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79994"},
        {"Hipparcos Number", "HIP 45543"},
        {"Smithsonian Astrophysical Observation", "SAO 155056"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.23772305),
        dec: Angle.Degrees(-11.10294324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15492"},
        {"Hipparcos Number", "HIP 11589"},
        {"Geneva Identification System", "GEN# +1.00015492"},
        {"Smithsonian Astrophysical Observation", "SAO 148415"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.33984716),
        dec: Angle.Degrees(-11.10029361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76560"},
        {"Hipparcos Number", "HIP 43896"},
        {"Smithsonian Astrophysical Observation", "SAO 154770"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.13407273),
        dec: Angle.Degrees(-11.09797485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126231"},
        {"Hipparcos Number", "HIP 70438"},
        {"Smithsonian Astrophysical Observation", "SAO 158547"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.14475865),
        dec: Angle.Degrees(-11.09698621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98530"},
        {"Hipparcos Number", "HIP 55345"},
        {"Smithsonian Astrophysical Observation", "SAO 156612"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01058776),
        dec: Angle.Degrees(-11.09540975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132884"},
        {"Hipparcos Number", "HIP 73541"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.46255388),
        dec: Angle.Degrees(-11.09429863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142313"},
        {"Hipparcos Number", "HIP 77878"},
        {"Smithsonian Astrophysical Observation", "SAO 159571"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.55729983),
        dec: Angle.Degrees(-11.09015839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185764"},
        {"Hipparcos Number", "HIP 96841"},
        {"Smithsonian Astrophysical Observation", "SAO 162891"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.27431736),
        dec: Angle.Degrees(-11.08967283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18107"},
        {"Hipparcos Number", "HIP 13527"},
        {"Smithsonian Astrophysical Observation", "SAO 148661"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.55795706),
        dec: Angle.Degrees(-11.08941818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53568",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7989"},
        {"Henry Draper", "HD 94941"},
        {"Hipparcos Number", "HIP 53568"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.37747202),
        dec: Angle.Degrees(-11.08921682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96220"},
        {"Hipparcos Number", "HIP 54214"},
        {"Fundamental Katalog 5th Edition", "FK5 1286"},
        {"Geneva Identification System", "GEN# +1.00096220"},
        {"Smithsonian Astrophysical Observation", "SAO 156448"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.39158166),
        dec: Angle.Degrees(-11.08872717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154212"},
        {"Hipparcos Number", "HIP 83555"},
        {"Smithsonian Astrophysical Observation", "SAO 160264"},
        {"Wilson Evans Batten Catalogue", "WEB 14124"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.13895355),
        dec: Angle.Degrees(-11.08845644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194942"},
        {"Hipparcos Number", "HIP 100997"},
        {"Smithsonian Astrophysical Observation", "SAO 163611"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.15393370),
        dec: Angle.Degrees(-11.08827455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27477"},
        {"Smithsonian Astrophysical Observation", "SAO 150837"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.27798305),
        dec: Angle.Degrees(-11.08279252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79194"},
        {"Hipparcos Number", "HIP 45171"},
        {"Geneva Identification System", "GEN# +1.00079194"},
        {"Smithsonian Astrophysical Observation", "SAO 154993"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.07760489),
        dec: Angle.Degrees(-11.07892613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10610"},
        {"Hipparcos Number", "HIP 8050"},
        {"Smithsonian Astrophysical Observation", "SAO 147976"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83479052),
        dec: Angle.Degrees(-11.07685983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61125",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8585 B"},
        {"Henry Draper", "HD 91168"},
        {"Hipparcos Number", "HIP 61125"},
        {"Geneva Identification System", "GEN# +1.00091168"},
        {"Smithsonian Astrophysical Observation", "SAO 157338"},
        {"Wilson Evans Batten Catalogue", "WEB 10884"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90098813),
        dec: Angle.Degrees(-11.07643813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153542"},
        {"Hipparcos Number", "HIP 83233"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.14719915),
        dec: Angle.Degrees(-11.07604950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22343"},
        {"Hipparcos Number", "HIP 16755"},
        {"Smithsonian Astrophysical Observation", "SAO 149055"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.88643125),
        dec: Angle.Degrees(-11.07517211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86500"},
        {"Hipparcos Number", "HIP 48913"},
        {"Geneva Identification System", "GEN# +1.00086500"},
        {"Smithsonian Astrophysical Observation", "SAO 155632"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.67305365),
        dec: Angle.Degrees(-11.07382162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8585 A"},
        {"Henry Draper", "HD 109005"},
        {"Henry Draper 2", "HD 91169"},
        {"Hipparcos Number", "HIP 61127"},
        {"Geneva Identification System", "GEN# +1.00109005"},
        {"Renson", "Renson 31630"},
        {"Smithsonian Astrophysical Observation", "SAO 157339"},
        {"Wilson Evans Batten Catalogue", "WEB 10879"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90204900),
        dec: Angle.Degrees(-11.07225514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44483"},
        {"Hipparcos Number", "HIP 30231"},
        {"Renson", "Renson 11811"},
        {"Smithsonian Astrophysical Observation", "SAO 151406"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.40573046),
        dec: Angle.Degrees(-11.06982124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36049"},
        {"Hipparcos Number", "HIP 25631"},
        {"Smithsonian Astrophysical Observation", "SAO 150481"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.12460766),
        dec: Angle.Degrees(-11.06900854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34882"},
        {"Hipparcos Number", "HIP 24901"},
        {"Smithsonian Astrophysical Observation", "SAO 150348"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.06066576),
        dec: Angle.Degrees(-11.06863986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210687"},
        {"Hipparcos Number", "HIP 109613"},
        {"Smithsonian Astrophysical Observation", "SAO 164922"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.07038251),
        dec: Angle.Degrees(-11.06555226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99668"},
        {"Hipparcos Number", "HIP 55942"},
        {"Smithsonian Astrophysical Observation", "SAO 156695"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.97953009),
        dec: Angle.Degrees(-11.06128675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141552"},
        {"Hipparcos Number", "HIP 77546"},
        {"Smithsonian Astrophysical Observation", "SAO 159523"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50162477),
        dec: Angle.Degrees(-11.06098723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92859"},
        {"Hipparcos Number", "HIP 52443"},
        {"Smithsonian Astrophysical Observation", "SAO 156175"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.80553843),
        dec: Angle.Degrees(-11.05931200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125522"},
        {"Hipparcos Number", "HIP 70049"},
        {"Geneva Identification System", "GEN# +1.00125522"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.03422522),
        dec: Angle.Degrees(-11.05831016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28463"},
        {"Hipparcos Number", "HIP 20913"},
        {"Smithsonian Astrophysical Observation", "SAO 149670"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.22812294),
        dec: Angle.Degrees(-11.05785565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134648"},
        {"Hipparcos Number", "HIP 74313"},
        {"Smithsonian Astrophysical Observation", "SAO 159078"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.83890110),
        dec: Angle.Degrees(-11.05594405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31556"},
        {"Hipparcos Number", "HIP 22956"},
        {"Geneva Identification System", "GEN# +1.00031556"},
        {"Smithsonian Astrophysical Observation", "SAO 150007"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.09191523),
        dec: Angle.Degrees(-11.05181865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92069"},
        {"Hipparcos Number", "HIP 52023"},
        {"Geneva Identification System", "GEN# +1.00092069"},
        {"Smithsonian Astrophysical Observation", "SAO 156114"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.43481221),
        dec: Angle.Degrees(-11.04969730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103449"},
        {"Hipparcos Number", "HIP 58081"},
        {"Smithsonian Astrophysical Observation", "SAO 156977"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.67264879),
        dec: Angle.Degrees(-11.04958759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12379"},
        {"Hipparcos Number", "HIP 9427"},
        {"Geneva Identification System", "GEN# +1.00012379"},
        {"Smithsonian Astrophysical Observation", "SAO 148153"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.27287423),
        dec: Angle.Degrees(-11.04932196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200342"},
        {"Hipparcos Number", "HIP 103900"},
        {"Smithsonian Astrophysical Observation", "SAO 164097"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.78573757),
        dec: Angle.Degrees(-11.04823133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60446"},
        {"Hipparcos Number", "HIP 36794"},
        {"Smithsonian Astrophysical Observation", "SAO 153076"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.51263890),
        dec: Angle.Degrees(-11.04736166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146213"},
        {"Hipparcos Number", "HIP 79663"},
        {"Geneva Identification System", "GEN# +1.00146213"},
        {"Smithsonian Astrophysical Observation", "SAO 159814"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.85395699),
        dec: Angle.Degrees(-11.04688596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70438"},
        {"Hipparcos Number", "HIP 40965"},
        {"Geneva Identification System", "GEN# +1.00070438"},
        {"Smithsonian Astrophysical Observation", "SAO 154152"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.40125713),
        dec: Angle.Degrees(-11.04567281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57712"},
        {"Smithsonian Astrophysical Observation", "SAO 156922"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.53328099),
        dec: Angle.Degrees(-11.04529627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92016"},
        {"Hipparcos Number", "HIP 52000"},
        {"Smithsonian Astrophysical Observation", "SAO 156108"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.35483966),
        dec: Angle.Degrees(-11.04404195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40476"},
        {"Hipparcos Number", "HIP 28286"},
        {"Smithsonian Astrophysical Observation", "SAO 150989"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.65563318),
        dec: Angle.Degrees(-11.04373021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176986"},
        {"Hipparcos Number", "HIP 93540"},
        {"Smithsonian Astrophysical Observation", "SAO 162137"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.77478523),
        dec: Angle.Degrees(-11.04335177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216468"},
        {"Hipparcos Number", "HIP 113014"},
        {"Smithsonian Astrophysical Observation", "SAO 165357"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.30974021),
        dec: Angle.Degrees(-11.04043650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40937"},
        {"Hipparcos Number", "HIP 28550"},
        {"Smithsonian Astrophysical Observation", "SAO 151030"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.40615678),
        dec: Angle.Degrees(-11.03853244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137090"},
        {"Hipparcos Number", "HIP 75419"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.13487458),
        dec: Angle.Degrees(-11.03853086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21556"},
        {"Geneva Identification System", "GEN# -0.01100916"},
        {"Wilson Evans Batten Catalogue", "WEB 4138"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.42500270),
        dec: Angle.Degrees(-11.03840438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54740"},
        {"Hipparcos Number", "HIP 34574"},
        {"Celescope Catalog", "CEL 1623"},
        {"Geneva Identification System", "GEN# +1.00054740"},
        {"Smithsonian Astrophysical Observation", "SAO 152476"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.40946768),
        dec: Angle.Degrees(-11.03791446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159228"},
        {"Hipparcos Number", "HIP 85946"},
        {"Smithsonian Astrophysical Observation", "SAO 160643"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.48754123),
        dec: Angle.Degrees(-11.03535426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34815"},
        {"Hipparcos Number", "HIP 24853"},
        {"Fundamental Katalog 5th Edition", "FK5 4483"},
        {"Smithsonian Astrophysical Observation", "SAO 150341"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.92062007),
        dec: Angle.Degrees(-11.03492828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85961"},
        {"Hipparcos Number", "HIP 48649"},
        {"Smithsonian Astrophysical Observation", "SAO 155593"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.80674462),
        dec: Angle.Degrees(-11.03435548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266"},
        {"Hipparcos Number", "HIP 608"},
        {"Smithsonian Astrophysical Observation", "SAO 147091"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.84541576),
        dec: Angle.Degrees(-11.03336416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196469"},
        {"Hipparcos Number", "HIP 101811"},
        {"Smithsonian Astrophysical Observation", "SAO 163752"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.48273698),
        dec: Angle.Degrees(-11.03303709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220787"},
        {"Hipparcos Number", "HIP 115729"},
        {"Geneva Identification System", "GEN# +1.00220787"},
        {"Smithsonian Astrophysical Observation", "SAO 165696"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68954721),
        dec: Angle.Degrees(-11.03259622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64114"},
        {"Hipparcos Number", "HIP 38392"},
        {"Geneva Identification System", "GEN# +1.00064114"},
        {"Smithsonian Astrophysical Observation", "SAO 153509"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.98303279),
        dec: Angle.Degrees(-11.03255449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136330"},
        {"Hipparcos Number", "HIP 75075"},
        {"Smithsonian Astrophysical Observation", "SAO 159184"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.13001763),
        dec: Angle.Degrees(-11.03252033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26582"},
        {"Smithsonian Astrophysical Observation", "SAO 150649"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.76382900),
        dec: Angle.Degrees(-11.03172737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197579"},
        {"Hipparcos Number", "HIP 102391"},
        {"Smithsonian Astrophysical Observation", "SAO 163846"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.23725945),
        dec: Angle.Degrees(-11.03074797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183405"},
        {"Hipparcos Number", "HIP 95862"},
        {"Smithsonian Astrophysical Observation", "SAO 162679"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.45345914),
        dec: Angle.Degrees(-11.03030432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11682"},
        {"Hipparcos Number", "HIP 8892"},
        {"Smithsonian Astrophysical Observation", "SAO 148098"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.61407535),
        dec: Angle.Degrees(-11.02882064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133333"},
        {"Hipparcos Number", "HIP 73729"},
        {"Smithsonian Astrophysical Observation", "SAO 159002"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.07201548),
        dec: Angle.Degrees(-11.02475543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205736"},
        {"Hipparcos Number", "HIP 106761"},
        {"Smithsonian Astrophysical Observation", "SAO 164529"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.39332006),
        dec: Angle.Degrees(-11.02419712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147753"},
        {"Hipparcos Number", "HIP 80340"},
        {"Geneva Identification System", "GEN# +1.00147753"},
        {"Smithsonian Astrophysical Observation", "SAO 159894"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.01611865),
        dec: Angle.Degrees(-11.02367745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108596"},
        {"Hipparcos Number", "HIP 60876"},
        {"Smithsonian Astrophysical Observation", "SAO 157313"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.15265606),
        dec: Angle.Degrees(-11.02221698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165244"},
        {"Hipparcos Number", "HIP 88608"},
        {"Geneva Identification System", "GEN# +1.00165244"},
        {"Smithsonian Astrophysical Observation", "SAO 161057"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38038812),
        dec: Angle.Degrees(-11.02010470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75410"},
        {"Hipparcos Number", "HIP 43315"},
        {"Smithsonian Astrophysical Observation", "SAO 154661"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.36284322),
        dec: Angle.Degrees(-11.01906302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2595"},
        {"Hipparcos Number", "HIP 2311"},
        {"Smithsonian Astrophysical Observation", "SAO 147305"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.36855475),
        dec: Angle.Degrees(-11.01701602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223860"},
        {"Hipparcos Number", "HIP 117789"},
        {"Cincinnati Publication", "Ci 18 3128"},
        {"Smithsonian Astrophysical Observation", "SAO 165941"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.30664282),
        dec: Angle.Degrees(-11.01462034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135701"},
        {"Hipparcos Number", "HIP 74774"},
        {"Smithsonian Astrophysical Observation", "SAO 159149"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.22406081),
        dec: Angle.Degrees(-11.01311102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172529"},
        {"Hipparcos Number", "HIP 91625"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.29422087),
        dec: Angle.Degrees(-11.01224837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106931"},
        {"Hipparcos Number", "HIP 59956"},
        {"Smithsonian Astrophysical Observation", "SAO 157192"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.46096133),
        dec: Angle.Degrees(-11.00965031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19159"},
        {"Hipparcos Number", "HIP 14305"},
        {"Smithsonian Astrophysical Observation", "SAO 148747"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.13453745),
        dec: Angle.Degrees(-11.00918534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199897"},
        {"Hipparcos Number", "HIP 103671"},
        {"Geneva Identification System", "GEN# +1.00199897"},
        {"Smithsonian Astrophysical Observation", "SAO 164057"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.08495718),
        dec: Angle.Degrees(-11.00839333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135027"},
        {"Hipparcos Number", "HIP 74488"},
        {"Smithsonian Astrophysical Observation", "SAO 159107"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.31159974),
        dec: Angle.Degrees(-11.00698161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43035",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7026 AB"},
        {"Henry Draper", "HD 74860"},
        {"Hipparcos Number", "HIP 43035"},
        {"Geneva Identification System", "GEN# +1.00074860J"},
        {"Smithsonian Astrophysical Observation", "SAO 154615"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.52871402),
        dec: Angle.Degrees(-11.00680266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174326"},
        {"Hipparcos Number", "HIP 92453"},
        {"Smithsonian Astrophysical Observation", "SAO 161894"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.61796568),
        dec: Angle.Degrees(-11.00630457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26102"},
        {"Smithsonian Astrophysical Observation", "SAO 150568"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.50700156),
        dec: Angle.Degrees(-11.00233322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48670"},
        {"Hipparcos Number", "HIP 32255"},
        {"Geneva Identification System", "GEN# +1.00048670"},
        {"Smithsonian Astrophysical Observation", "SAO 151854"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.03858511),
        dec: Angle.Degrees(-10.99948344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110837"},
        {"Hipparcos Number", "HIP 62217"},
        {"Smithsonian Astrophysical Observation", "SAO 157488"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.26797214),
        dec: Angle.Degrees(-10.99945452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221472"},
        {"Hipparcos Number", "HIP 116183"},
        {"Fundamental Katalog 5th Edition", "FK5 3886"},
        {"Geneva Identification System", "GEN# +1.00221472"},
        {"Smithsonian Astrophysical Observation", "SAO 165754"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.10786923),
        dec: Angle.Degrees(-10.99877018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63520"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.24309886),
        dec: Angle.Degrees(-10.99726329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221397"},
        {"Hipparcos Number", "HIP 116143"},
        {"Smithsonian Astrophysical Observation", "SAO 165742"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98454661),
        dec: Angle.Degrees(-10.99456526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157857"},
        {"Hipparcos Number", "HIP 85331"},
        {"Geneva Identification System", "GEN# +1.00157857"},
        {"Smithsonian Astrophysical Observation", "SAO 160545"},
        {"Wilson Evans Batten Catalogue", "WEB 14408"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.57224565),
        dec: Angle.Degrees(-10.99299713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35504"},
        {"Hipparcos Number", "HIP 25295"},
        {"Smithsonian Astrophysical Observation", "SAO 150417"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.17026735),
        dec: Angle.Degrees(-10.99128504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144411"},
        {"Hipparcos Number", "HIP 78883"},
        {"Geneva Identification System", "GEN# +1.00144411"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.54734824),
        dec: Angle.Degrees(-10.99107722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137228"},
        {"Hipparcos Number", "HIP 75487"},
        {"Geneva Identification System", "GEN# +1.00137228"},
        {"Smithsonian Astrophysical Observation", "SAO 159246"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.30562486),
        dec: Angle.Degrees(-10.99004337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76312"},
        {"Hipparcos Number", "HIP 43776"},
        {"Smithsonian Astrophysical Observation", "SAO 154735"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74486659),
        dec: Angle.Degrees(-10.98554775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6546"},
        {"Hipparcos Number", "HIP 5169"},
        {"Geneva Identification System", "GEN# +1.00006546"},
        {"Smithsonian Astrophysical Observation", "SAO 147608"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52642005),
        dec: Angle.Degrees(-10.98537698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117093"},
        {"Smithsonian Astrophysical Observation", "SAO 165855"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.06522203),
        dec: Angle.Degrees(-10.98498164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31985"},
        {"Hipparcos Number", "HIP 23208"},
        {"Geneva Identification System", "GEN# +1.00031985"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.90846614),
        dec: Angle.Degrees(-10.98388084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 383.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193542"},
        {"Hipparcos Number", "HIP 100347"},
        {"Smithsonian Astrophysical Observation", "SAO 163484"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.25470746),
        dec: Angle.Degrees(-10.98275925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192771"},
        {"Hipparcos Number", "HIP 99971"},
        {"Smithsonian Astrophysical Observation", "SAO 163413"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23226548),
        dec: Angle.Degrees(-10.98157182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3881 AB"},
        {"Henry Draper", "HD 34526"},
        {"Hipparcos Number", "HIP 24687"},
        {"Smithsonian Astrophysical Observation", "SAO 150305"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.43142003),
        dec: Angle.Degrees(-10.97934588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171391"},
        {"Hipparcos Number", "HIP 91105"},
        {"Fundamental Katalog 5th Edition", "FK5 3477"},
        {"Geneva Identification System", "GEN# +1.00171391"},
        {"Smithsonian Astrophysical Observation", "SAO 161632"},
        {"Wilson Evans Batten Catalogue", "WEB 15635"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.75984804),
        dec: Angle.Degrees(-10.97719406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111277"},
        {"Hipparcos Number", "HIP 62480"},
        {"Smithsonian Astrophysical Observation", "SAO 157517"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.06489321),
        dec: Angle.Degrees(-10.97662698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2323 AB"},
        {"Henry Draper", "HD 19063"},
        {"Hipparcos Number", "HIP 14235"},
        {"Smithsonian Astrophysical Observation", "SAO 148739"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.88338236),
        dec: Angle.Degrees(-10.97480777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92544"},
        {"Hipparcos Number", "HIP 52280"},
        {"Smithsonian Astrophysical Observation", "SAO 156158"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.24318268),
        dec: Angle.Degrees(-10.97457578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7967"},
        {"Hipparcos Number", "HIP 6158"},
        {"Smithsonian Astrophysical Observation", "SAO 147733"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.74228745),
        dec: Angle.Degrees(-10.97416042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94757",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12244 A"},
        {"Henry Draper", "HD 180409"},
        {"Hipparcos Number", "HIP 94757"},
        {"Geneva Identification System", "GEN# +1.00180409"},
        {"Smithsonian Astrophysical Observation", "SAO 162401"},
        {"Wilson Evans Batten Catalogue", "WEB 16533"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.21717717),
        dec: Angle.Degrees(-10.97179907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85741",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10605 AB"},
        {"Henry Draper", "HD 158719"},
        {"Hipparcos Number", "HIP 85741"},
        {"Smithsonian Astrophysical Observation", "SAO 160610"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.82423954),
        dec: Angle.Degrees(-10.97130087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30916"},
        {"Hipparcos Number", "HIP 22554"},
        {"Fundamental Katalog 5th Edition", "FK5 4445"},
        {"Smithsonian Astrophysical Observation", "SAO 149935"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80907977),
        dec: Angle.Degrees(-10.97026649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197211"},
        {"Hipparcos Number", "HIP 102218"},
        {"Geneva Identification System", "GEN# +1.00197211"},
        {"Smithsonian Astrophysical Observation", "SAO 163815"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.66915064),
        dec: Angle.Degrees(-10.96971113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122658"},
        {"Hipparcos Number", "HIP 68671"},
        {"Smithsonian Astrophysical Observation", "SAO 158312"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.86317449),
        dec: Angle.Degrees(-10.96729883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72682"},
        {"Hipparcos Number", "HIP 42015"},
        {"Smithsonian Astrophysical Observation", "SAO 154399"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.46346120),
        dec: Angle.Degrees(-10.96445535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153021"},
        {"Hipparcos Number", "HIP 82979"},
        {"Geneva Identification System", "GEN# +1.00153021"},
        {"Smithsonian Astrophysical Observation", "SAO 160186"},
        {"Wilson Evans Batten Catalogue", "WEB 14029"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.35833565),
        dec: Angle.Degrees(-10.96315727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9640"},
        {"Henry Draper", "HD 137631"},
        {"Hipparcos Number", "HIP 75663"},
        {"Geneva Identification System", "GEN# +1.00137631"},
        {"Smithsonian Astrophysical Observation", "SAO 159271"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.87630033),
        dec: Angle.Degrees(-10.96245250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4770"},
        {"Hipparcos Number", "HIP 3861"},
        {"Geneva Identification System", "GEN# +1.00004770"},
        {"Smithsonian Astrophysical Observation", "SAO 147465"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.39433043),
        dec: Angle.Degrees(-10.96136471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33755"},
        {"Hipparcos Number", "HIP 24212"},
        {"Smithsonian Astrophysical Observation", "SAO 150215"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.98873782),
        dec: Angle.Degrees(-10.96100740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216332"},
        {"Hipparcos Number", "HIP 112926"},
        {"Smithsonian Astrophysical Observation", "SAO 165346"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.04503601),
        dec: Angle.Degrees(-10.95827318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46663"},
        {"Hipparcos Number", "HIP 31332"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.54905257),
        dec: Angle.Degrees(-10.95756287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 270.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32221"},
        {"Hipparcos Number", "HIP 23331"},
        {"Smithsonian Astrophysical Observation", "SAO 150079"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.28163704),
        dec: Angle.Degrees(-10.95667317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187840"},
        {"Hipparcos Number", "HIP 97801"},
        {"Smithsonian Astrophysical Observation", "SAO 163070"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.10789871),
        dec: Angle.Degrees(-10.95623355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1119"},
        {"Smithsonian Astrophysical Observation", "SAO 147159"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.49998896),
        dec: Angle.Degrees(-10.95370289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97214"},
        {"Hipparcos Number", "HIP 54651"},
        {"Geneva Identification System", "GEN# +1.00097214"},
        {"Wilson Evans Batten Catalogue", "WEB 9864"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.79692025),
        dec: Angle.Degrees(-10.95232784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -942.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 592.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153870"},
        {"Hipparcos Number", "HIP 83372"},
        {"Smithsonian Astrophysical Observation", "SAO 160239"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.59424975),
        dec: Angle.Degrees(-10.95217417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152907"},
        {"Hipparcos Number", "HIP 82921"},
        {"Smithsonian Astrophysical Observation", "SAO 160177"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.18560442),
        dec: Angle.Degrees(-10.95139406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18573"},
        {"Hipparcos Number", "HIP 13896"},
        {"Smithsonian Astrophysical Observation", "SAO 148694"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.73133441),
        dec: Angle.Degrees(-10.94957259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1509",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 258 A"},
        {"Henry Draper", "HD 1472"},
        {"Hipparcos Number", "HIP 1509"},
        {"Fundamental Katalog 5th Edition", "FK5 4034"},
        {"Geneva Identification System", "GEN# +1.00001472"},
        {"Smithsonian Astrophysical Observation", "SAO 147212"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.69806253),
        dec: Angle.Degrees(-10.94934512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187696"},
        {"Hipparcos Number", "HIP 97737"},
        {"Geneva Identification System", "GEN# +1.00187696"},
        {"Smithsonian Astrophysical Observation", "SAO 163054"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.92780537),
        dec: Angle.Degrees(-10.94923260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102378"},
        {"Hipparcos Number", "HIP 57482"},
        {"Smithsonian Astrophysical Observation", "SAO 156884"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.74539672),
        dec: Angle.Degrees(-10.94904659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22854"},
        {"Hipparcos Number", "HIP 17107"},
        {"Geneva Identification System", "GEN# +1.00022854"},
        {"Smithsonian Astrophysical Observation", "SAO 149087"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.97176569),
        dec: Angle.Degrees(-10.94676114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197089"},
        {"Hipparcos Number", "HIP 102130"},
        {"Geneva Identification System", "GEN# +1.00197089"},
        {"Smithsonian Astrophysical Observation", "SAO 163803"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.44018609),
        dec: Angle.Degrees(-10.94547966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51541"},
        {"Hipparcos Number", "HIP 33458"},
        {"Geneva Identification System", "GEN# +1.00051541"},
        {"Smithsonian Astrophysical Observation", "SAO 152160"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.33950858),
        dec: Angle.Degrees(-10.94532245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59113"},
        {"Hipparcos Number", "HIP 36283"},
        {"Smithsonian Astrophysical Observation", "SAO 152914"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.03819162),
        dec: Angle.Degrees(-10.94491014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143179"},
        {"Hipparcos Number", "HIP 78293"},
        {"Fundamental Katalog 5th Edition", "FK5 5410"},
        {"Smithsonian Astrophysical Observation", "SAO 159621"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.80441380),
        dec: Angle.Degrees(-10.94414452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58718"},
        {"Hipparcos Number", "HIP 36126"},
        {"Smithsonian Astrophysical Observation", "SAO 152873"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.62000928),
        dec: Angle.Degrees(-10.94359805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145026"},
        {"Hipparcos Number", "HIP 79135"},
        {"Geneva Identification System", "GEN# +1.00145026"},
        {"Smithsonian Astrophysical Observation", "SAO 159735"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.28922676),
        dec: Angle.Degrees(-10.94358359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213563"},
        {"Hipparcos Number", "HIP 111261"},
        {"Smithsonian Astrophysical Observation", "SAO 165153"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.11110034),
        dec: Angle.Degrees(-10.94068390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7202"},
        {"Hipparcos Number", "HIP 5625"},
        {"Smithsonian Astrophysical Observation", "SAO 147669"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.06593358),
        dec: Angle.Degrees(-10.94018538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72215"},
        {"Hipparcos Number", "HIP 41783"},
        {"Smithsonian Astrophysical Observation", "SAO 154347"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.79494924),
        dec: Angle.Degrees(-10.93760081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127521"},
        {"Hipparcos Number", "HIP 71083"},
        {"Fundamental Katalog 5th Edition", "FK5 5284"},
        {"Geneva Identification System", "GEN# +1.00127521"},
        {"Smithsonian Astrophysical Observation", "SAO 158624"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.04979697),
        dec: Angle.Degrees(-10.93532018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81376"},
        {"Hipparcos Number", "HIP 46167"},
        {"Smithsonian Astrophysical Observation", "SAO 155157"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.22826303),
        dec: Angle.Degrees(-10.93471721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32308"},
        {"Hipparcos Number", "HIP 23405"},
        {"Geneva Identification System", "GEN# +1.00032308"},
        {"Smithsonian Astrophysical Observation", "SAO 150086"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.44843369),
        dec: Angle.Degrees(-10.93389100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168348"},
        {"Henry Draper 2", "HD 168349"},
        {"Hipparcos Number", "HIP 89800"},
        {"Geneva Identification System", "GEN# +1.00168348"},
        {"Geneva Identification System 2", "GEN# +1.00168349"},
        {"Smithsonian Astrophysical Observation", "SAO 161336"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.90487363),
        dec: Angle.Degrees(-10.93345372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30523"},
        {"Hipparcos Number", "HIP 22288"},
        {"Geneva Identification System", "GEN# +1.00030523"},
        {"Smithsonian Astrophysical Observation", "SAO 149893"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.00455258),
        dec: Angle.Degrees(-10.93338106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140283"},
        {"Hipparcos Number", "HIP 76976"},
        {"Cincinnati Publication", "Ci 20 942"},
        {"Geneva Identification System", "GEN# +1.00140283"},
        {"Smithsonian Astrophysical Observation", "SAO 159459"},
        {"Wilson Evans Batten Catalogue", "WEB 13056"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.76566410),
        dec: Angle.Degrees(-10.93276129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1115.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5048 AB"},
        {"Henry Draper", "HD 45140"},
        {"Hipparcos Number", "HIP 30543"},
        {"Smithsonian Astrophysical Observation", "SAO 151478"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.31138100),
        dec: Angle.Degrees(-10.93187724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21869"},
        {"Hipparcos Number", "HIP 16402"},
        {"Smithsonian Astrophysical Observation", "SAO 149009"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.80880976),
        dec: Angle.Degrees(-10.93149901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101166"},
        {"Hipparcos Number", "HIP 56778"},
        {"Smithsonian Astrophysical Observation", "SAO 156799"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.61307594),
        dec: Angle.Degrees(-10.93051725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180977"},
        {"Hipparcos Number", "HIP 94925"},
        {"Smithsonian Astrophysical Observation", "SAO 162463"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.74622782),
        dec: Angle.Degrees(-10.92987878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69613"},
        {"Hipparcos Number", "HIP 40601"},
        {"Smithsonian Astrophysical Observation", "SAO 154073"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.34105699),
        dec: Angle.Degrees(-10.92634547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160018"},
        {"Hipparcos Number", "HIP 86313"},
        {"Geneva Identification System", "GEN# +1.00160018"},
        {"Smithsonian Astrophysical Observation", "SAO 160708"},
        {"Wilson Evans Batten Catalogue", "WEB 14565"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.53963734),
        dec: Angle.Degrees(-10.92624683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109656"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.21130804),
        dec: Angle.Degrees(-10.92492978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121767"},
        {"Hipparcos Number", "HIP 68198"},
        {"Fundamental Katalog 5th Edition", "FK5 5234"},
        {"Smithsonian Astrophysical Observation", "SAO 158260"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.43591902),
        dec: Angle.Degrees(-10.92457262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198951"},
        {"Hipparcos Number", "HIP 103162"},
        {"Smithsonian Astrophysical Observation", "SAO 163966"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.51299095),
        dec: Angle.Degrees(-10.92424024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151092"},
        {"Hipparcos Number", "HIP 82047"},
        {"Smithsonian Astrophysical Observation", "SAO 160083"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.39877578),
        dec: Angle.Degrees(-10.92358958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111999"},
        {"Hipparcos Number", "HIP 62889"},
        {"Smithsonian Astrophysical Observation", "SAO 157574"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.33139633),
        dec: Angle.Degrees(-10.92120351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205247"},
        {"Hipparcos Number", "HIP 106511"},
        {"Smithsonian Astrophysical Observation", "SAO 164486"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.59242052),
        dec: Angle.Degrees(-10.92083958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16249"},
        {"Hipparcos Number", "HIP 12118"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03238653),
        dec: Angle.Degrees(-10.91876675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204071"},
        {"Hipparcos Number", "HIP 105859"},
        {"Smithsonian Astrophysical Observation", "SAO 164389"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61035515),
        dec: Angle.Degrees(-10.91750431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33549"},
        {"Hipparcos Number", "HIP 24102"},
        {"Smithsonian Astrophysical Observation", "SAO 150196"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.66354914),
        dec: Angle.Degrees(-10.91451817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165011"},
        {"Hipparcos Number", "HIP 88502"},
        {"Geneva Identification System", "GEN# +1.00165011"},
        {"Smithsonian Astrophysical Observation", "SAO 161038"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.08522066),
        dec: Angle.Degrees(-10.91050326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93063"},
        {"Hipparcos Number", "HIP 52560"},
        {"Smithsonian Astrophysical Observation", "SAO 156195"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.19301172),
        dec: Angle.Degrees(-10.90947250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16131"},
        {"Hipparcos Number", "HIP 12035"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79519504),
        dec: Angle.Degrees(-10.90607280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213464"},
        {"Hipparcos Number", "HIP 111200"},
        {"Geneva Identification System", "GEN# +1.00213464"},
        {"Renson", "Renson 59200"},
        {"Smithsonian Astrophysical Observation", "SAO 165147"},
        {"Wilson Evans Batten Catalogue", "WEB 19898"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.92199244),
        dec: Angle.Degrees(-10.90546457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4594"},
        {"Hipparcos Number", "HIP 3725"},
        {"Smithsonian Astrophysical Observation", "SAO 147452"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.95949536),
        dec: Angle.Degrees(-10.90421694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1162 AB"},
        {"Henry Draper", "HD 8921"},
        {"Hipparcos Number", "HIP 6822"},
        {"Geneva Identification System", "GEN# +1.00008921"},
        {"Smithsonian Astrophysical Observation", "SAO 147819"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.94348544),
        dec: Angle.Degrees(-10.90162048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162757"},
        {"Hipparcos Number", "HIP 87540"},
        {"Geneva Identification System", "GEN# +1.00162757"},
        {"Smithsonian Astrophysical Observation", "SAO 160885"},
        {"Wilson Evans Batten Catalogue", "WEB 14767"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.26463725),
        dec: Angle.Degrees(-10.89948880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156248"},
        {"Hipparcos Number", "HIP 84539"},
        {"Geneva Identification System", "GEN# +1.00156248"},
        {"Smithsonian Astrophysical Observation", "SAO 160425"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.24216033),
        dec: Angle.Degrees(-10.89888599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9280"},
        {"Hipparcos Number", "HIP 7080"},
        {"Geneva Identification System", "GEN# +1.00009280"},
        {"Smithsonian Astrophysical Observation", "SAO 147853"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.80805715),
        dec: Angle.Degrees(-10.89662492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77349"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.85350085),
        dec: Angle.Degrees(-10.89563601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -326.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -356.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15150 AB"},
        {"Henry Draper", "HD 205826"},
        {"Hipparcos Number", "HIP 106828"},
        {"Geneva Identification System", "GEN# +1.00205826"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.54545575),
        dec: Angle.Degrees(-10.89467657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187775"},
        {"Hipparcos Number", "HIP 97776"},
        {"Smithsonian Astrophysical Observation", "SAO 163064"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.03082663),
        dec: Angle.Degrees(-10.89269049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171587"},
        {"Hipparcos Number", "HIP 91187"},
        {"Cincinnati Publication", "Ci 18 2436"},
        {"Geneva Identification System", "GEN# +1.00171587"},
        {"Smithsonian Astrophysical Observation", "SAO 161652"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03810403),
        dec: Angle.Degrees(-10.89024290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192348"},
        {"Hipparcos Number", "HIP 99790"},
        {"Smithsonian Astrophysical Observation", "SAO 163378"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.70195695),
        dec: Angle.Degrees(-10.89022878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56134"},
        {"Hipparcos Number", "HIP 35092"},
        {"Smithsonian Astrophysical Observation", "SAO 152617"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.85947146),
        dec: Angle.Degrees(-10.88988407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178577"},
        {"Hipparcos Number", "HIP 94119"},
        {"Smithsonian Astrophysical Observation", "SAO 162259"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.39113010),
        dec: Angle.Degrees(-10.88960099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218158"},
        {"Hipparcos Number", "HIP 114051"},
        {"Smithsonian Astrophysical Observation", "SAO 165487"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.45760307),
        dec: Angle.Degrees(-10.88955091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142850"},
        {"Hipparcos Number", "HIP 78122"},
        {"Smithsonian Astrophysical Observation", "SAO 159600"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.28315232),
        dec: Angle.Degrees(-10.88792535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4009"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.86031733),
        dec: Angle.Degrees(-10.88769599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41680"},
        {"Hipparcos Number", "HIP 28915"},
        {"Smithsonian Astrophysical Observation", "SAO 151108"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.55019153),
        dec: Angle.Degrees(-10.88709500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160185"},
        {"Hipparcos Number", "HIP 86370"},
        {"Smithsonian Astrophysical Observation", "SAO 160718"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.72973101),
        dec: Angle.Degrees(-10.88641617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217289"},
        {"Hipparcos Number", "HIP 113545"},
        {"Smithsonian Astrophysical Observation", "SAO 165428"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.95196695),
        dec: Angle.Degrees(-10.88488647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88024"},
        {"Hipparcos Number", "HIP 49701"},
        {"Geneva Identification System", "GEN# +1.00088024"},
        {"Smithsonian Astrophysical Observation", "SAO 155765"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.19023917),
        dec: Angle.Degrees(-10.88478665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75391"},
        {"Hipparcos Number", "HIP 43309"},
        {"Smithsonian Astrophysical Observation", "SAO 154659"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34304256),
        dec: Angle.Degrees(-10.88442903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209571"},
        {"Hipparcos Number", "HIP 108979"},
        {"Smithsonian Astrophysical Observation", "SAO 164845"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.16594769),
        dec: Angle.Degrees(-10.88438047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139804"},
        {"Hipparcos Number", "HIP 76774"},
        {"Smithsonian Astrophysical Observation", "SAO 159428"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.13333182),
        dec: Angle.Degrees(-10.88403026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47713"},
        {"Hipparcos Number", "HIP 31855"},
        {"Smithsonian Astrophysical Observation", "SAO 151761"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.89544167),
        dec: Angle.Degrees(-10.88341128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193931"},
        {"Hipparcos Number", "HIP 100544"},
        {"Smithsonian Astrophysical Observation", "SAO 163517"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.80028360),
        dec: Angle.Degrees(-10.88327085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112464"},
        {"Hipparcos Number", "HIP 63202"},
        {"Geneva Identification System", "GEN# +1.00112464"},
        {"Smithsonian Astrophysical Observation", "SAO 157617"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.24113845),
        dec: Angle.Degrees(-10.88290189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5712 AB"},
        {"Henry Draper", "HD 52694"},
        {"Hipparcos Number", "HIP 33869"},
        {"Geneva Identification System", "GEN# +1.00052694J"},
        {"Smithsonian Astrophysical Observation", "SAO 152256"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.45800743),
        dec: Angle.Degrees(-10.88237424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44241"},
        {"Hipparcos Number", "HIP 30119"},
        {"Smithsonian Astrophysical Observation", "SAO 151368"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.07113874),
        dec: Angle.Degrees(-10.88210816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84128"},
        {"Hipparcos Number", "HIP 47621"},
        {"Smithsonian Astrophysical Observation", "SAO 155424"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.66096048),
        dec: Angle.Degrees(-10.88094268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 899"},
        {"Smithsonian Astrophysical Observation", "SAO 147131"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.76872400),
        dec: Angle.Degrees(-10.87786557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155212"},
        {"Hipparcos Number", "HIP 84026"},
        {"Smithsonian Astrophysical Observation", "SAO 160335"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.65293503),
        dec: Angle.Degrees(-10.87695040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128005"},
        {"Hipparcos Number", "HIP 71290"},
        {"Smithsonian Astrophysical Observation", "SAO 158653"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.68609549),
        dec: Angle.Degrees(-10.87634162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40430"},
        {"Hipparcos Number", "HIP 28265"},
        {"Geneva Identification System", "GEN# +1.00040430"},
        {"Smithsonian Astrophysical Observation", "SAO 150982"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.58501134),
        dec: Angle.Degrees(-10.87474415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187195"},
        {"Hipparcos Number", "HIP 97499"},
        {"Geneva Identification System", "GEN# +1.00187195"},
        {"Smithsonian Astrophysical Observation", "SAO 163012"},
        {"Wilson Evans Batten Catalogue", "WEB 17140"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.25910696),
        dec: Angle.Degrees(-10.87071152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98157"},
        {"Hipparcos Number", "HIP 55145"},
        {"Smithsonian Astrophysical Observation", "SAO 156586"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.35189018),
        dec: Angle.Degrees(-10.86907261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62771"},
        {"Hipparcos Number", "HIP 37821"},
        {"Smithsonian Astrophysical Observation", "SAO 153351"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.32239267),
        dec: Angle.Degrees(-10.86782179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75337"},
        {"Hipparcos Number", "HIP 43288"},
        {"Smithsonian Astrophysical Observation", "SAO 154650"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.27101098),
        dec: Angle.Degrees(-10.86713414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21087"},
        {"Hipparcos Number", "HIP 15826"},
        {"Smithsonian Astrophysical Observation", "SAO 148939"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97429284),
        dec: Angle.Degrees(-10.86655067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93216"},
        {"Hipparcos Number", "HIP 52626"},
        {"Geneva Identification System", "GEN# +1.00093216"},
        {"Smithsonian Astrophysical Observation", "SAO 156201"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.42999052),
        dec: Angle.Degrees(-10.86637444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224190"},
        {"Hipparcos Number", "HIP 117988"},
        {"Smithsonian Astrophysical Observation", "SAO 165958"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.98533041),
        dec: Angle.Degrees(-10.86575284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221384"},
        {"Hipparcos Number", "HIP 116126"},
        {"Smithsonian Astrophysical Observation", "SAO 165739"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.95711196),
        dec: Angle.Degrees(-10.86468122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69558"},
        {"Hipparcos Number", "HIP 40578"},
        {"Smithsonian Astrophysical Observation", "SAO 154067"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.27703303),
        dec: Angle.Degrees(-10.86403226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170566"},
        {"Hipparcos Number", "HIP 90717"},
        {"Geneva Identification System", "GEN# +1.00170566"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.63440271),
        dec: Angle.Degrees(-10.86400387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88196"},
        {"Hipparcos Number", "HIP 49807"},
        {"Geneva Identification System", "GEN# +1.00088196"},
        {"Smithsonian Astrophysical Observation", "SAO 155778"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.50896552),
        dec: Angle.Degrees(-10.86222207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220161"},
        {"Hipparcos Number", "HIP 115342"},
        {"Smithsonian Astrophysical Observation", "SAO 165649"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.43496969),
        dec: Angle.Degrees(-10.86178258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99167"},
        {"Hipparcos Number", "HIP 55687"},
        {"Geneva Identification System", "GEN# +1.00099167"},
        {"Smithsonian Astrophysical Observation", "SAO 156658"},
        {"Wilson Evans Batten Catalogue", "WEB 10009"},
    },
    visualMagnitude: 4.81,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.15252245),
        dec: Angle.Degrees(-10.85938276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20372"},
        {"Hipparcos Number", "HIP 15223"},
        {"Smithsonian Astrophysical Observation", "SAO 148871"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.06269547),
        dec: Angle.Degrees(-10.85896966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24833"},
        {"Hipparcos Number", "HIP 18440"},
        {"Geneva Identification System", "GEN# +1.00024833"},
        {"Smithsonian Astrophysical Observation", "SAO 149268"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.13148392),
        dec: Angle.Degrees(-10.85318367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94638"},
        {"Hipparcos Number", "HIP 53398"},
        {"Smithsonian Astrophysical Observation", "SAO 156326"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.83129069),
        dec: Angle.Degrees(-10.85192745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9719",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1644 AB"},
        {"Henry Draper", "HD 12775"},
        {"Hipparcos Number", "HIP 9719"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.25679296),
        dec: Angle.Degrees(-10.85111792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20886"},
        {"Hipparcos Number", "HIP 15658"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.40813248),
        dec: Angle.Degrees(-10.85092492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49545"},
        {"Hipparcos Number", "HIP 32641"},
        {"Smithsonian Astrophysical Observation", "SAO 151952"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.13868066),
        dec: Angle.Degrees(-10.84953159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212123"},
        {"Hipparcos Number", "HIP 110439"},
        {"Smithsonian Astrophysical Observation", "SAO 165025"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.54844933),
        dec: Angle.Degrees(-10.84803124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18619"},
        {"Hipparcos Number", "HIP 13919"},
        {"Smithsonian Astrophysical Observation", "SAO 148699"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.82830585),
        dec: Angle.Degrees(-10.84444316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9213"},
        {"Hipparcos Number", "HIP 7031"},
        {"Smithsonian Astrophysical Observation", "SAO 147848"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.64865319),
        dec: Angle.Degrees(-10.84168397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40464"},
        {"Hipparcos Number", "HIP 28278"},
        {"Smithsonian Astrophysical Observation", "SAO 150988"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.62882559),
        dec: Angle.Degrees(-10.83979546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191953"},
        {"Hipparcos Number", "HIP 99597"},
        {"Smithsonian Astrophysical Observation", "SAO 163349"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.18699956),
        dec: Angle.Degrees(-10.83967635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54145"},
        {"Smithsonian Astrophysical Observation", "SAO 156437"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.14746965),
        dec: Angle.Degrees(-10.83581189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68530"},
        {"Hipparcos Number", "HIP 40180"},
        {"Smithsonian Astrophysical Observation", "SAO 153967"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.10143871),
        dec: Angle.Degrees(-10.83293035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74859"},
        {"Hipparcos Number", "HIP 43039"},
        {"Smithsonian Astrophysical Observation", "SAO 154616"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.53982244),
        dec: Angle.Degrees(-10.82986706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110070"},
        {"Hipparcos Number", "HIP 61776"},
        {"Smithsonian Astrophysical Observation", "SAO 157426"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.91734710),
        dec: Angle.Degrees(-10.82727554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9395 AB"},
        {"Henry Draper", "HD 130558"},
        {"Hipparcos Number", "HIP 72478"},
        {"Smithsonian Astrophysical Observation", "SAO 158817"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.29532786),
        dec: Angle.Degrees(-10.82722221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73515"},
        {"Hipparcos Number", "HIP 42378"},
        {"Smithsonian Astrophysical Observation", "SAO 154480"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.60784355),
        dec: Angle.Degrees(-10.82512539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51480"},
        {"Hipparcos Number", "HIP 33436"},
        {"Geneva Identification System", "GEN# +1.00051480"},
        {"Smithsonian Astrophysical Observation", "SAO 152149"},
        {"Wilson Evans Batten Catalogue", "WEB 6724"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.28910004),
        dec: Angle.Degrees(-10.82446268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166101"},
        {"Hipparcos Number", "HIP 88963"},
        {"Smithsonian Astrophysical Observation", "SAO 161122"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.38873905),
        dec: Angle.Degrees(-10.82226837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210422"},
        {"Hipparcos Number", "HIP 109460"},
        {"Geneva Identification System", "GEN# +1.00210422"},
        {"Smithsonian Astrophysical Observation", "SAO 164907"},
        {"Wilson Evans Batten Catalogue", "WEB 19667"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63225649),
        dec: Angle.Degrees(-10.82046179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207034"},
        {"Hipparcos Number", "HIP 107508"},
        {"Smithsonian Astrophysical Observation", "SAO 164638"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.61026483),
        dec: Angle.Degrees(-10.82034474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81126"},
        {"Hipparcos Number", "HIP 46060"},
        {"Geneva Identification System", "GEN# +1.00081126"},
        {"Smithsonian Astrophysical Observation", "SAO 155142"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.88898020),
        dec: Angle.Degrees(-10.81595011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10010"},
        {"Hipparcos Number", "HIP 7578"},
        {"Smithsonian Astrophysical Observation", "SAO 147918"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.40253126),
        dec: Angle.Degrees(-10.81589983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77737"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06866417),
        dec: Angle.Degrees(-10.81546741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202700"},
        {"Hipparcos Number", "HIP 105139"},
        {"Smithsonian Astrophysical Observation", "SAO 164287"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.48367801),
        dec: Angle.Degrees(-10.81501195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114430"},
        {"Hipparcos Number", "HIP 64288"},
        {"Smithsonian Astrophysical Observation", "SAO 157768"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.63257055),
        dec: Angle.Degrees(-10.81460924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201312"},
        {"Hipparcos Number", "HIP 104405"},
        {"Smithsonian Astrophysical Observation", "SAO 164174"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.26318612),
        dec: Angle.Degrees(-10.80936693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91062"},
        {"Hipparcos Number", "HIP 51452"},
        {"Smithsonian Astrophysical Observation", "SAO 156027"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.63701428),
        dec: Angle.Degrees(-10.80795179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154545"},
        {"Hipparcos Number", "HIP 83711"},
        {"Smithsonian Astrophysical Observation", "SAO 160281"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62316665),
        dec: Angle.Degrees(-10.80635058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10184"},
        {"Hipparcos Number", "HIP 7726"},
        {"Smithsonian Astrophysical Observation", "SAO 147936"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.85784887),
        dec: Angle.Degrees(-10.80560936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8691"},
        {"Cincinnati Publication", "Ci 20 130"},
        {"Wilson Evans Batten Catalogue", "WEB 1833"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.95145439),
        dec: Angle.Degrees(-10.80215939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 568.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -537.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144348"},
        {"Hipparcos Number", "HIP 78852"},
        {"Smithsonian Astrophysical Observation", "SAO 159686"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.44213811),
        dec: Angle.Degrees(-10.80152182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50643"},
        {"Smithsonian Astrophysical Observation", "SAO 155914"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.14593944),
        dec: Angle.Degrees(-10.80126555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10491"},
        {"Geneva Identification System", "GEN# -0.01100427"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.81203313),
        dec: Angle.Degrees(-10.80014922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
