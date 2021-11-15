using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_112() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115390"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.61851165),
        dec: Angle.Degrees(+62.75715520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125576"},
        {"Hipparcos Number", "HIP 69858"},
        {"Geneva Identification System", "GEN# +1.00125576"},
        {"Smithsonian Astrophysical Observation", "SAO 16328"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.44720712),
        dec: Angle.Degrees(+62.75765327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2090"},
        {"Geneva Identification System", "GEN# +0.06100077"},
        {"Smithsonian Astrophysical Observation", "SAO 11191"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.59673777),
        dec: Angle.Degrees(+62.76080638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6416"},
        {"Hipparcos Number", "HIP 5186"},
        {"Geneva Identification System", "GEN# +1.00006416"},
        {"Smithsonian Astrophysical Observation", "SAO 11571"},
        {"Wilson Evans Batten Catalogue", "WEB 1086"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.59452876),
        dec: Angle.Degrees(+62.76146736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78891"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.57241820),
        dec: Angle.Degrees(+62.76278714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104475"},
        {"Smithsonian Astrophysical Observation", "SAO 19227"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.46427676),
        dec: Angle.Degrees(+62.76315959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52951"},
        {"Smithsonian Astrophysical Observation", "SAO 15302"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.44801253),
        dec: Angle.Degrees(+62.76497038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45528"},
        {"Hipparcos Number", "HIP 31154"},
        {"Smithsonian Astrophysical Observation", "SAO 13871"},
        {"Wilson Evans Batten Catalogue", "WEB 6218"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.07040498),
        dec: Angle.Degrees(+62.76529946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3949"},
        {"Hipparcos Number", "HIP 3363"},
        {"Geneva Identification System", "GEN# +1.00003949"},
        {"Smithsonian Astrophysical Observation", "SAO 11342"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.70202572),
        dec: Angle.Degrees(+62.76587730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78915"},
        {"Hipparcos Number", "HIP 45277"},
        {"Geneva Identification System", "GEN# +1.00078915"},
        {"Smithsonian Astrophysical Observation", "SAO 14814"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.42436456),
        dec: Angle.Degrees(+62.76744618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136402"},
        {"Hipparcos Number", "HIP 74808"},
        {"Smithsonian Astrophysical Observation", "SAO 16672"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.32380044),
        dec: Angle.Degrees(+62.77102108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207017"},
        {"Hipparcos Number", "HIP 107276"},
        {"Celescope Catalog", "CEL 5377"},
        {"Geneva Identification System", "GEN# +1.00207017"},
        {"Smithsonian Astrophysical Observation", "SAO 19607"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.93812489),
        dec: Angle.Degrees(+62.77154347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8768 AB"},
        {"Henry Draper", "HD 113809"},
        {"Hipparcos Number", "HIP 63844"},
        {"Smithsonian Astrophysical Observation", "SAO 15976"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.26657818),
        dec: Angle.Degrees(+62.77332594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8736"},
        {"Hipparcos Number", "HIP 6820"},
        {"Geneva Identification System", "GEN# +1.00008736"},
        {"Smithsonian Astrophysical Observation", "SAO 11768"},
        {"Wilson Evans Batten Catalogue", "WEB 1488"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.93594998),
        dec: Angle.Degrees(+62.77342939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217463"},
        {"Hipparcos Number", "HIP 113538"},
        {"Smithsonian Astrophysical Observation", "SAO 20358"},
        {"Wilson Evans Batten Catalogue", "WEB 20185"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.92862911),
        dec: Angle.Degrees(+62.77732035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24514"},
        {"Hipparcos Number", "HIP 18525"},
        {"Geneva Identification System", "GEN# +1.00024514"},
        {"Smithsonian Astrophysical Observation", "SAO 12972"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.41564519),
        dec: Angle.Degrees(+62.77741244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170092"},
        {"Hipparcos Number", "HIP 90118"},
        {"Smithsonian Astrophysical Observation", "SAO 17870"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.85055676),
        dec: Angle.Degrees(+62.78003177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97415"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.99224802),
        dec: Angle.Degrees(+62.78004029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131494"},
        {"Hipparcos Number", "HIP 72624"},
        {"Smithsonian Astrophysical Observation", "SAO 16527"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.72805144),
        dec: Angle.Degrees(+62.78046097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111270"},
        {"Hipparcos Number", "HIP 62402"},
        {"Geneva Identification System", "GEN# +1.00111270"},
        {"Smithsonian Astrophysical Observation", "SAO 15901"},
        {"Wilson Evans Batten Catalogue", "WEB 11080"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.82885595),
        dec: Angle.Degrees(+62.78113875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209960"},
        {"Hipparcos Number", "HIP 109005"},
        {"Fundamental Katalog 5th Edition", "FK5 830"},
        {"Geneva Identification System", "GEN# +1.00209960"},
        {"Smithsonian Astrophysical Observation", "SAO 19847"},
        {"Wilson Evans Batten Catalogue", "WEB 19601"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.25199883),
        dec: Angle.Degrees(+62.78552941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2973"},
        {"Hipparcos Number", "HIP 2656"},
        {"Geneva Identification System", "GEN# +1.00002973"},
        {"Smithsonian Astrophysical Observation", "SAO 11261"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.41428550),
        dec: Angle.Degrees(+62.78882256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38463"},
        {"Smithsonian Astrophysical Observation", "SAO 14348"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.18678466),
        dec: Angle.Degrees(+62.78912951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48714"},
        {"Cincinnati Publication", "Ci 20 553"},
        {"Geneva Identification System", "GEN# +0.06300869"},
        {"Wilson Evans Batten Catalogue", "WEB 9061"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.03774424),
        dec: Angle.Degrees(+62.78988049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -304.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -583.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82719"},
        {"Hipparcos Number", "HIP 47141"},
        {"Geneva Identification System", "GEN# +1.00082719"},
        {"Smithsonian Astrophysical Observation", "SAO 14936"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.08800757),
        dec: Angle.Degrees(+62.79060150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122020"},
        {"Hipparcos Number", "HIP 68142"},
        {"Fundamental Katalog 5th Edition", "FK5 5231"},
        {"Geneva Identification System", "GEN# +1.00122020"},
        {"Smithsonian Astrophysical Observation", "SAO 16229"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.26656035),
        dec: Angle.Degrees(+62.79224207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2657"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.41532753),
        dec: Angle.Degrees(+62.79242483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93672"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.13598344),
        dec: Angle.Degrees(+62.79306809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180842"},
        {"Hipparcos Number", "HIP 94507"},
        {"Smithsonian Astrophysical Observation", "SAO 18230"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.52512376),
        dec: Angle.Degrees(+62.79454000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4684"},
        {"Hipparcos Number", "HIP 3883"},
        {"Geneva Identification System", "GEN# +1.00004684"},
        {"Smithsonian Astrophysical Observation", "SAO 11419"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.46695421),
        dec: Angle.Degrees(+62.79514319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7598"},
        {"Geneva Identification System", "GEN# +0.06200281"},
        {"Smithsonian Astrophysical Observation", "SAO 11877"},
    },
    visualMagnitude: 8.72,
    bvColour: 2.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.46850395),
        dec: Angle.Degrees(+62.79689691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162898"},
        {"Hipparcos Number", "HIP 87211"},
        {"Fundamental Katalog 5th Edition", "FK5 5565"},
        {"Geneva Identification System", "GEN# +1.00162898"},
        {"Smithsonian Astrophysical Observation", "SAO 17645"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.26649708),
        dec: Angle.Degrees(+62.79866572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20362"},
        {"Smithsonian Astrophysical Observation", "SAO 13109"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.41207648),
        dec: Angle.Degrees(+62.79908075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152011"},
        {"Hipparcos Number", "HIP 82136"},
        {"Geneva Identification System", "GEN# +1.00152011"},
        {"Smithsonian Astrophysical Observation", "SAO 17219"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.70307620),
        dec: Angle.Degrees(+62.79909131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95183"},
        {"Smithsonian Astrophysical Observation", "SAO 18308"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.44938429),
        dec: Angle.Degrees(+62.80082991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116655"},
        {"Hipparcos Number", "HIP 65336"},
        {"Geneva Identification System", "GEN# +1.00116655"},
        {"Smithsonian Astrophysical Observation", "SAO 16062"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.86485586),
        dec: Angle.Degrees(+62.80115054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211833"},
        {"Hipparcos Number", "HIP 110103"},
        {"Geneva Identification System", "GEN# +1.00211833"},
        {"Smithsonian Astrophysical Observation", "SAO 19991"},
        {"Wilson Evans Batten Catalogue", "WEB 19763"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.55247853),
        dec: Angle.Degrees(+62.80436392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31188"},
        {"Hipparcos Number", "HIP 23063"},
        {"Smithsonian Astrophysical Observation", "SAO 13320"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.44513905),
        dec: Angle.Degrees(+62.80676943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4376 AB"},
        {"Henry Draper", "HD 38284"},
        {"Hipparcos Number", "HIP 27472"},
        {"Smithsonian Astrophysical Observation", "SAO 13618"},
        {"Wilson Evans Batten Catalogue", "WEB 5395"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.26948786),
        dec: Angle.Degrees(+62.80819575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120816"},
        {"Hipparcos Number", "HIP 67489"},
        {"Smithsonian Astrophysical Observation", "SAO 16188"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.44574067),
        dec: Angle.Degrees(+62.80859186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197509"},
        {"Hipparcos Number", "HIP 102054"},
        {"Geneva Identification System", "GEN# +1.00197509"},
        {"Smithsonian Astrophysical Observation", "SAO 18985"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.22739975),
        dec: Angle.Degrees(+62.80879725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9962"},
        {"Smithsonian Astrophysical Observation", "SAO 12143"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.06242374),
        dec: Angle.Degrees(+62.81446867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218673"},
        {"Hipparcos Number", "HIP 114307"},
        {"Smithsonian Astrophysical Observation", "SAO 20449"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.24475838),
        dec: Angle.Degrees(+62.81559043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76490"},
        {"Smithsonian Astrophysical Observation", "SAO 16786"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.34653457),
        dec: Angle.Degrees(+62.81741519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177002"},
        {"Hipparcos Number", "HIP 93169"},
        {"Smithsonian Astrophysical Observation", "SAO 18095"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.67035309),
        dec: Angle.Degrees(+62.82530799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1287"},
        {"Hipparcos Number", "HIP 1383"},
        {"Celescope Catalog", "CEL 50"},
        {"Geneva Identification System", "GEN# +1.00001287"},
        {"Smithsonian Astrophysical Observation", "SAO 11086"},
        {"Wilson Evans Batten Catalogue", "WEB 250"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.32823260),
        dec: Angle.Degrees(+62.82580060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82286"},
        {"Hipparcos Number", "HIP 46919"},
        {"Geneva Identification System", "GEN# +1.00082286"},
        {"Smithsonian Astrophysical Observation", "SAO 14919"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.44405225),
        dec: Angle.Degrees(+62.82790422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13102"},
        {"Smithsonian Astrophysical Observation", "SAO 12447"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.11054257),
        dec: Angle.Degrees(+62.82839775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7156"},
        {"Hipparcos Number", "HIP 5696"},
        {"Smithsonian Astrophysical Observation", "SAO 11640"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.32325985),
        dec: Angle.Degrees(+62.82894204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63137"},
        {"Hipparcos Number", "HIP 38358"},
        {"Smithsonian Astrophysical Observation", "SAO 14342"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.83923705),
        dec: Angle.Degrees(+62.82929579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62140"},
        {"Hipparcos Number", "HIP 37934"},
        {"Geneva Identification System", "GEN# +1.00062140"},
        {"Renson", "Renson 17050"},
        {"Smithsonian Astrophysical Observation", "SAO 14322"},
        {"Wilson Evans Batten Catalogue", "WEB 7487"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.61442348),
        dec: Angle.Degrees(+62.83067078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104913"},
        {"Geneva Identification System", "GEN# +0.06201916"},
        {"Smithsonian Astrophysical Observation", "SAO 19268"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.77329667),
        dec: Angle.Degrees(+62.84048194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 260.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9498"},
        {"Geneva Identification System", "GEN# +0.06200338J"},
        {"Smithsonian Astrophysical Observation", "SAO 12092"},
        {"Wilson Evans Batten Catalogue", "WEB 1995"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.54768113),
        dec: Angle.Degrees(+62.84196399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79781"},
        {"Hipparcos Number", "HIP 45693"},
        {"Geneva Identification System", "GEN# +1.00079781"},
        {"Renson", "Renson 22680"},
        {"Smithsonian Astrophysical Observation", "SAO 14840"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.72369546),
        dec: Angle.Degrees(+62.84285677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52652"},
        {"Hipparcos Number", "HIP 34274"},
        {"Smithsonian Astrophysical Observation", "SAO 14068"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.58483258),
        dec: Angle.Degrees(+62.84420998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59631"},
        {"Smithsonian Astrophysical Observation", "SAO 15744"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.43839915),
        dec: Angle.Degrees(+62.84671629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77540"},
        {"Hipparcos Number", "HIP 44678"},
        {"Geneva Identification System", "GEN# +1.00077540"},
        {"Smithsonian Astrophysical Observation", "SAO 14763"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.58203723),
        dec: Angle.Degrees(+62.84699758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25753"},
        {"Smithsonian Astrophysical Observation", "SAO 13515"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.48375458),
        dec: Angle.Degrees(+62.84753828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108871"},
        {"Hipparcos Number", "HIP 60986"},
        {"Fundamental Katalog 5th Edition", "FK5 5102"},
        {"Smithsonian Astrophysical Observation", "SAO 15814"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.50627170),
        dec: Angle.Degrees(+62.84764075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120648"},
        {"Hipparcos Number", "HIP 67398"},
        {"Smithsonian Astrophysical Observation", "SAO 16185"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.18790776),
        dec: Angle.Degrees(+62.84801383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199954"},
        {"Hipparcos Number", "HIP 103439"},
        {"Smithsonian Astrophysical Observation", "SAO 19123"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.34351507),
        dec: Angle.Degrees(+62.84888130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114473"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.74630193),
        dec: Angle.Degrees(+62.85002435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41944"},
        {"Smithsonian Astrophysical Observation", "SAO 14586"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.26371004),
        dec: Angle.Degrees(+62.85140169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149748"},
        {"Hipparcos Number", "HIP 81016"},
        {"Geneva Identification System", "GEN# +1.00149748"},
        {"Renson", "Renson 42350"},
        {"Smithsonian Astrophysical Observation", "SAO 17133"},
        {"Wilson Evans Batten Catalogue", "WEB 13702"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.17466562),
        dec: Angle.Degrees(+62.85482321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51648"},
        {"Smithsonian Astrophysical Observation", "SAO 15216"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.28392685),
        dec: Angle.Degrees(+62.85871513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141335"},
        {"Hipparcos Number", "HIP 77122"},
        {"Geneva Identification System", "GEN# +1.00141335"},
        {"Smithsonian Astrophysical Observation", "SAO 16836"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.21690490),
        dec: Angle.Degrees(+62.85999056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56788"},
        {"Hipparcos Number", "HIP 35762"},
        {"Smithsonian Astrophysical Observation", "SAO 14171"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.64934593),
        dec: Angle.Degrees(+62.86601517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156295"},
        {"Hipparcos Number", "HIP 84183"},
        {"Fundamental Katalog 5th Edition", "FK5 3370"},
        {"Geneva Identification System", "GEN# +1.00156295"},
        {"Smithsonian Astrophysical Observation", "SAO 17391"},
        {"Wilson Evans Batten Catalogue", "WEB 14217"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13566410),
        dec: Angle.Degrees(+62.87422062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6734"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.68027094),
        dec: Angle.Degrees(+62.87555241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17816"},
        {"Hipparcos Number", "HIP 13548"},
        {"Smithsonian Astrophysical Observation", "SAO 12501"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.62148898),
        dec: Angle.Degrees(+62.87584596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189635"},
        {"Hipparcos Number", "HIP 98198"},
        {"Geneva Identification System", "GEN# +1.00189635"},
        {"Smithsonian Astrophysical Observation", "SAO 18614"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.31640878),
        dec: Angle.Degrees(+62.87675925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52219"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.03745728),
        dec: Angle.Degrees(+62.88070366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113639"},
        {"Wilson Evans Batten Catalogue", "WEB 20196"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.22731010),
        dec: Angle.Degrees(+62.88166326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17721"},
        {"Smithsonian Astrophysical Observation", "SAO 12905"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.92838624),
        dec: Angle.Degrees(+62.88445890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63455"},
        {"Hipparcos Number", "HIP 38482"},
        {"Geneva Identification System", "GEN# +1.00063455"},
        {"Smithsonian Astrophysical Observation", "SAO 14352"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.21784962),
        dec: Angle.Degrees(+62.88521063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31252"},
        {"Smithsonian Astrophysical Observation", "SAO 13877"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.32281239),
        dec: Angle.Degrees(+62.88610857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103705"},
        {"Hipparcos Number", "HIP 58246"},
        {"Smithsonian Astrophysical Observation", "SAO 15665"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18695821),
        dec: Angle.Degrees(+62.88696358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202518"},
        {"Hipparcos Number", "HIP 104775"},
        {"Smithsonian Astrophysical Observation", "SAO 19254"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.37755889),
        dec: Angle.Degrees(+62.88854239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15022"},
        {"Hipparcos Number", "HIP 11460"},
        {"Smithsonian Astrophysical Observation", "SAO 12289"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.95981460),
        dec: Angle.Degrees(+62.89068626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219486"},
        {"Hipparcos Number", "HIP 114798"},
        {"Smithsonian Astrophysical Observation", "SAO 20514"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80969831),
        dec: Angle.Degrees(+62.89145061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208761"},
        {"Hipparcos Number", "HIP 108283"},
        {"Celescope Catalog", "CEL 5408"},
        {"Geneva Identification System", "GEN# +1.00208761"},
        {"Smithsonian Astrophysical Observation", "SAO 19751"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.06674581),
        dec: Angle.Degrees(+62.89463988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9292"},
        {"Geneva Identification System", "GEN# +0.06200332B"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.84814562),
        dec: Angle.Degrees(+62.90103883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 470 AB"},
        {"Henry Draper", "HD 3067"},
        {"Hipparcos Number", "HIP 2716"},
        {"Geneva Identification System", "GEN# +1.00003067J"},
        {"Smithsonian Astrophysical Observation", "SAO 11269"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.64040952),
        dec: Angle.Degrees(+62.90339141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9297"},
        {"Geneva Identification System", "GEN# +0.06200332A"},
        {"Smithsonian Astrophysical Observation", "SAO 12075"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.86474361),
        dec: Angle.Degrees(+62.90571346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66309"},
        {"Smithsonian Astrophysical Observation", "SAO 16117"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.84812475),
        dec: Angle.Degrees(+62.90802274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -364.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28801"},
        {"Hipparcos Number", "HIP 21450"},
        {"Smithsonian Astrophysical Observation", "SAO 13198"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.09648247),
        dec: Angle.Degrees(+62.90918313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90459"},
        {"Hipparcos Number", "HIP 51268"},
        {"Smithsonian Astrophysical Observation", "SAO 15188"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.08463860),
        dec: Angle.Degrees(+62.91581849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87925"},
        {"Hipparcos Number", "HIP 49829"},
        {"Fundamental Katalog 5th Edition", "FK5 4905"},
        {"Smithsonian Astrophysical Observation", "SAO 15105"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.59285988),
        dec: Angle.Degrees(+62.91604264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133206"},
        {"Hipparcos Number", "HIP 73417"},
        {"Smithsonian Astrophysical Observation", "SAO 16571"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.06080953),
        dec: Angle.Degrees(+62.91703355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107077"},
        {"Smithsonian Astrophysical Observation", "SAO 19581"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.31916133),
        dec: Angle.Degrees(+62.91914808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4842"},
        {"Hipparcos Number", "HIP 4008"},
        {"Smithsonian Astrophysical Observation", "SAO 11434"},
        {"Wilson Evans Batten Catalogue", "WEB 714"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.85849557),
        dec: Angle.Degrees(+62.92080066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201343"},
        {"Hipparcos Number", "HIP 104146"},
        {"Smithsonian Astrophysical Observation", "SAO 19193"},
        {"Wilson Evans Batten Catalogue", "WEB 18971"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.50209777),
        dec: Angle.Degrees(+62.92183479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98803"},
        {"Smithsonian Astrophysical Observation", "SAO 18682"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.99991142),
        dec: Angle.Degrees(+62.92373549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103149"},
        {"Hipparcos Number", "HIP 57943"},
        {"Geneva Identification System", "GEN# +1.00103149"},
        {"Smithsonian Astrophysical Observation", "SAO 15651"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.24633507),
        dec: Angle.Degrees(+62.92376631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4740"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.22256298),
        dec: Angle.Degrees(+62.92377550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83765"},
        {"Hipparcos Number", "HIP 47675"},
        {"Smithsonian Astrophysical Observation", "SAO 14973"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.81468111),
        dec: Angle.Degrees(+62.92686013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2905"},
        {"Hipparcos Number", "HIP 2599"},
        {"Celescope Catalog", "CEL 78"},
        {"Fundamental Katalog 5th Edition", "FK5 16"},
        {"Geneva Identification System", "GEN# +1.00002905"},
        {"Smithsonian Astrophysical Observation", "SAO 11256"},
        {"Wilson Evans Batten Catalogue", "WEB 476"},
    },
    visualMagnitude: 4.17,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.24994391),
        dec: Angle.Degrees(+62.93178781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77834"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.39272825),
        dec: Angle.Degrees(+62.93322888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8417 A"},
        {"Henry Draper", "HD 105043"},
        {"Hipparcos Number", "HIP 58989"},
        {"Geneva Identification System", "GEN# +1.00105043"},
        {"Smithsonian Astrophysical Observation", "SAO 15710"},
        {"Wilson Evans Batten Catalogue", "WEB 10506"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.41567863),
        dec: Angle.Degrees(+62.93329421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22113"},
        {"Hipparcos Number", "HIP 16890"},
        {"Smithsonian Astrophysical Observation", "SAO 12835"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.33522546),
        dec: Angle.Degrees(+62.93449953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126750"},
        {"Hipparcos Number", "HIP 70474"},
        {"Geneva Identification System", "GEN# +1.00126750"},
        {"Smithsonian Astrophysical Observation", "SAO 16372"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.22398521),
        dec: Angle.Degrees(+62.93635272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40380"},
        {"Smithsonian Astrophysical Observation", "SAO 14468"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66548543),
        dec: Angle.Degrees(+62.93650798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10664"},
        {"Hipparcos Number", "HIP 8229"},
        {"Geneva Identification System", "GEN# +1.00010664"},
        {"Smithsonian Astrophysical Observation", "SAO 11963"},
        {"Wilson Evans Batten Catalogue", "WEB 1750"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.49216303),
        dec: Angle.Degrees(+62.93683765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216102"},
        {"Hipparcos Number", "HIP 112635"},
        {"Geneva Identification System", "GEN# +1.00216102"},
        {"Smithsonian Astrophysical Observation", "SAO 20253"},
        {"Wilson Evans Batten Catalogue", "WEB 20080"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.18433198),
        dec: Angle.Degrees(+62.93853133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36834"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61695099),
        dec: Angle.Degrees(+62.94175585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -496.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137643"},
        {"Hipparcos Number", "HIP 75346"},
        {"Smithsonian Astrophysical Observation", "SAO 16720"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.94894294),
        dec: Angle.Degrees(+62.94900837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147426"},
        {"Hipparcos Number", "HIP 79863"},
        {"Smithsonian Astrophysical Observation", "SAO 17034"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.52916978),
        dec: Angle.Degrees(+62.94943541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94396"},
        {"Hipparcos Number", "HIP 53382"},
        {"Fundamental Katalog 5th Edition", "FK5 4964"},
        {"Smithsonian Astrophysical Observation", "SAO 15331"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.76126557),
        dec: Angle.Degrees(+62.94964138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166478"},
        {"Hipparcos Number", "HIP 88696"},
        {"Smithsonian Astrophysical Observation", "SAO 17765"},
        {"Wilson Evans Batten Catalogue", "WEB 15028"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.60781101),
        dec: Angle.Degrees(+62.95230594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89919"},
        {"Smithsonian Astrophysical Observation", "SAO 17861"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.22301526),
        dec: Angle.Degrees(+62.95522846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35144"},
        {"Hipparcos Number", "HIP 25487"},
        {"Smithsonian Astrophysical Observation", "SAO 13495"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.76973297),
        dec: Angle.Degrees(+62.96013675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91691"},
        {"Smithsonian Astrophysical Observation", "SAO 17980"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46835461),
        dec: Angle.Degrees(+62.96142115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47659"},
        {"Hipparcos Number", "HIP 32252"},
        {"Smithsonian Astrophysical Observation", "SAO 13945"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.02173705),
        dec: Angle.Degrees(+62.96303748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189749"},
        {"Hipparcos Number", "HIP 98245"},
        {"Smithsonian Astrophysical Observation", "SAO 18622"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47420003),
        dec: Angle.Degrees(+62.96370523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 135.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10542"},
        {"Hipparcos Number", "HIP 8142"},
        {"Smithsonian Astrophysical Observation", "SAO 11953"},
        {"Wilson Evans Batten Catalogue", "WEB 1739"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.17614663),
        dec: Angle.Degrees(+62.96617937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41886"},
        {"Hipparcos Number", "HIP 29436"},
        {"Smithsonian Astrophysical Observation", "SAO 13752"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.02848948),
        dec: Angle.Degrees(+62.96904700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39305"},
        {"Smithsonian Astrophysical Observation", "SAO 14405"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.54596047),
        dec: Angle.Degrees(+62.97186116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216425"},
        {"Hipparcos Number", "HIP 112876"},
        {"Geneva Identification System", "GEN# +1.00216425"},
        {"Smithsonian Astrophysical Observation", "SAO 20283"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.87271732),
        dec: Angle.Degrees(+62.97230158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60276"},
        {"Smithsonian Astrophysical Observation", "SAO 15779"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.39249495),
        dec: Angle.Degrees(+62.97475012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114216"},
        {"Hipparcos Number", "HIP 64076"},
        {"Smithsonian Astrophysical Observation", "SAO 15990"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97254845),
        dec: Angle.Degrees(+62.98310697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35815"},
        {"Hipparcos Number", "HIP 25907"},
        {"Geneva Identification System", "GEN# +1.00035815"},
        {"Smithsonian Astrophysical Observation", "SAO 13525"},
        {"Wilson Evans Batten Catalogue", "WEB 5033"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.94173512),
        dec: Angle.Degrees(+62.98518354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96759"},
        {"Hipparcos Number", "HIP 54555"},
        {"Geneva Identification System", "GEN# +1.00096759"},
        {"Smithsonian Astrophysical Observation", "SAO 15416"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.44848929),
        dec: Angle.Degrees(+62.98580998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111794"},
        {"Hipparcos Number", "HIP 62695"},
        {"Smithsonian Astrophysical Observation", "SAO 15919"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.70480729),
        dec: Angle.Degrees(+62.98609677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115023"},
        {"Geneva Identification System", "GEN# +0.06202209"},
        {"Smithsonian Astrophysical Observation", "SAO 20541"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.43705059),
        dec: Angle.Degrees(+62.98782986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173998"},
        {"Hipparcos Number", "HIP 91902"},
        {"Geneva Identification System", "GEN# +1.00173998"},
        {"Smithsonian Astrophysical Observation", "SAO 17996"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.03496532),
        dec: Angle.Degrees(+62.98930404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3123"},
        {"Hipparcos Number", "HIP 2756"},
        {"Geneva Identification System", "GEN# +1.00003123"},
        {"Smithsonian Astrophysical Observation", "SAO 11273"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.79716857),
        dec: Angle.Degrees(+62.98938435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9084"},
        {"Geneva Identification System", "GEN# +0.06200325"},
        {"Smithsonian Astrophysical Observation", "SAO 12047"},
        {"Wilson Evans Batten Catalogue", "WEB 1908"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.24321459),
        dec: Angle.Degrees(+62.99007666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224669"},
        {"Hipparcos Number", "HIP 118303"},
        {"Geneva Identification System", "GEN# +1.00224669"},
        {"Smithsonian Astrophysical Observation", "SAO 20985"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.93425593),
        dec: Angle.Degrees(+62.99169087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204211"},
        {"Hipparcos Number", "HIP 105677"},
        {"Celescope Catalog", "CEL 5308"},
        {"Geneva Identification System", "GEN# +1.00204211"},
        {"Smithsonian Astrophysical Observation", "SAO 19386"},
        {"Wilson Evans Batten Catalogue", "WEB 19180"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.06889308),
        dec: Angle.Degrees(+62.99345906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195725"},
        {"Hipparcos Number", "HIP 101093"},
        {"Celescope Catalog", "CEL 5091"},
        {"Fundamental Katalog 5th Edition", "FK5 767"},
        {"Geneva Identification System", "GEN# +1.00195725"},
        {"Renson", "Renson 54530"},
        {"Smithsonian Astrophysical Observation", "SAO 18897"},
        {"Wilson Evans Batten Catalogue", "WEB 18260"},
    },
    visualMagnitude: 4.21,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.39511383),
        dec: Angle.Degrees(+62.99413722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6066 A"},
        {"Henry Draper", "HD 57974"},
        {"Hipparcos Number", "HIP 36237"},
        {"Smithsonian Astrophysical Observation", "SAO 14202"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.93370170),
        dec: Angle.Degrees(+62.99585024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117154"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.26095855),
        dec: Angle.Degrees(+63.00385723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14142"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.58577178),
        dec: Angle.Degrees(+63.00600639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117156"},
        {"Hipparcos Number", "HIP 65591"},
        {"Smithsonian Astrophysical Observation", "SAO 16076"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.72858704),
        dec: Angle.Degrees(+63.00795877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221036"},
        {"Hipparcos Number", "HIP 115832"},
        {"Geneva Identification System", "GEN# +1.00221036"},
        {"Smithsonian Astrophysical Observation", "SAO 20646"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.00236303),
        dec: Angle.Degrees(+63.01405899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11943 AB"},
        {"Henry Draper", "HD 177194"},
        {"Hipparcos Number", "HIP 93241"},
        {"Smithsonian Astrophysical Observation", "SAO 18101"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.89229131),
        dec: Angle.Degrees(+63.01423768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11190"},
        {"Smithsonian Astrophysical Observation", "SAO 12266"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.03433148),
        dec: Angle.Degrees(+63.02332082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197159"},
        {"Hipparcos Number", "HIP 101866"},
        {"Smithsonian Astrophysical Observation", "SAO 18966"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.62871473),
        dec: Angle.Degrees(+63.02576684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18876"},
        {"Hipparcos Number", "HIP 14359"},
        {"Geneva Identification System", "GEN# +1.00018876"},
        {"Smithsonian Astrophysical Observation", "SAO 12595"},
        {"Wilson Evans Batten Catalogue", "WEB 2805"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.31737662),
        dec: Angle.Degrees(+63.02946000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31219"},
        {"Hipparcos Number", "HIP 23093"},
        {"Smithsonian Astrophysical Observation", "SAO 13322"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54749728),
        dec: Angle.Degrees(+63.03073167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107876"},
        {"Hipparcos Number", "HIP 60434"},
        {"Smithsonian Astrophysical Observation", "SAO 15788"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86259437),
        dec: Angle.Degrees(+63.03341131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62552"},
        {"Smithsonian Astrophysical Observation", "SAO 15911"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.25322025),
        dec: Angle.Degrees(+63.03740885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92525"},
        {"Hipparcos Number", "HIP 52383"},
        {"Smithsonian Astrophysical Observation", "SAO 15265"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.60859958),
        dec: Angle.Degrees(+63.03996550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59205"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.12887104),
        dec: Angle.Degrees(+63.04027428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50520"},
        {"Hipparcos Number", "HIP 33518"},
        {"Geneva Identification System", "GEN# +1.00050520"},
        {"Smithsonian Astrophysical Observation", "SAO 14021"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50293316),
        dec: Angle.Degrees(+63.04059588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26111"},
        {"Hipparcos Number", "HIP 19588"},
        {"Geneva Identification System", "GEN# +1.00026111"},
        {"Smithsonian Astrophysical Observation", "SAO 13058"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.97498963),
        dec: Angle.Degrees(+63.04100755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14632"},
        {"Hipparcos Number", "HIP 11209"},
        {"Celescope Catalog", "CEL 267"},
        {"Geneva Identification System", "GEN# +1.00014632"},
        {"Smithsonian Astrophysical Observation", "SAO 12268"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.07376617),
        dec: Angle.Degrees(+63.04226768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57429"},
        {"Smithsonian Astrophysical Observation", "SAO 15628"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.60153633),
        dec: Angle.Degrees(+63.04355796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3572"},
        {"Hipparcos Number", "HIP 3095"},
        {"Smithsonian Astrophysical Observation", "SAO 11314"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.85548318),
        dec: Angle.Degrees(+63.04400016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87215"},
        {"Smithsonian Astrophysical Observation", "SAO 17646"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.27551412),
        dec: Angle.Degrees(+63.04971871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48388"},
        {"Hipparcos Number", "HIP 32545"},
        {"Geneva Identification System", "GEN# +1.00048388"},
        {"Smithsonian Astrophysical Observation", "SAO 13955"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86651630),
        dec: Angle.Degrees(+63.05523233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49115"},
        {"Hipparcos Number", "HIP 32888"},
        {"Smithsonian Astrophysical Observation", "SAO 13978"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.79334229),
        dec: Angle.Degrees(+63.06055221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7402 A"},
        {"Henry Draper", "HD 81937"},
        {"Hipparcos Number", "HIP 46733"},
        {"Fundamental Katalog 5th Edition", "FK5 355"},
        {"Geneva Identification System", "GEN# +1.00081937A"},
        {"Smithsonian Astrophysical Observation", "SAO 14908"},
        {"Wilson Evans Batten Catalogue", "WEB 8813"},
    },
    visualMagnitude: 3.65,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.88154025),
        dec: Angle.Degrees(+63.06179545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115535"},
        {"Hipparcos Number", "HIP 64764"},
        {"Smithsonian Astrophysical Observation", "SAO 16030"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.09143372),
        dec: Angle.Degrees(+63.06285394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125347"},
        {"Hipparcos Number", "HIP 69744"},
        {"Geneva Identification System", "GEN# +1.00125347"},
        {"Smithsonian Astrophysical Observation", "SAO 16324"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.12304431),
        dec: Angle.Degrees(+63.06420989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35583"},
        {"Hipparcos Number", "HIP 25769"},
        {"Fundamental Katalog 5th Edition", "FK5 203"},
        {"Geneva Identification System", "GEN# +1.00035583"},
        {"Smithsonian Astrophysical Observation", "SAO 13518"},
        {"Wilson Evans Batten Catalogue", "WEB 5005"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.54254026),
        dec: Angle.Degrees(+63.06723206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40827"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99345629),
        dec: Angle.Degrees(+63.06981279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201582"},
        {"Hipparcos Number", "HIP 104280"},
        {"Smithsonian Astrophysical Observation", "SAO 19208"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.88940383),
        dec: Angle.Degrees(+63.07070753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163731"},
        {"Hipparcos Number", "HIP 87572"},
        {"Geneva Identification System", "GEN# +1.00163731"},
        {"Smithsonian Astrophysical Observation", "SAO 17672"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.35248031),
        dec: Angle.Degrees(+63.07073365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19169"},
        {"Smithsonian Astrophysical Observation", "SAO 13020"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64796116),
        dec: Angle.Degrees(+63.07092034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87172"},
        {"Hipparcos Number", "HIP 49435"},
        {"Smithsonian Astrophysical Observation", "SAO 15073"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.38739758),
        dec: Angle.Degrees(+63.07203825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24479"},
        {"Hipparcos Number", "HIP 18505"},
        {"Fundamental Katalog 5th Edition", "FK5 2281"},
        {"Geneva Identification System", "GEN# +1.00024479"},
        {"Smithsonian Astrophysical Observation", "SAO 12969"},
        {"Wilson Evans Batten Catalogue", "WEB 3565"},
    },
    visualMagnitude: 4.95,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.35598140),
        dec: Angle.Degrees(+63.07224944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150429"},
        {"Hipparcos Number", "HIP 81358"},
        {"Geneva Identification System", "GEN# +1.00150429"},
        {"Smithsonian Astrophysical Observation", "SAO 17165"},
        {"Wilson Evans Batten Catalogue", "WEB 13750"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.22911407),
        dec: Angle.Degrees(+63.07303811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217312"},
        {"Hipparcos Number", "HIP 113461"},
        {"Celescope Catalog", "CEL 5554"},
        {"Geneva Identification System", "GEN# +9.02004610"},
        {"Geneva Identification System 2", "GEN# +9.00020046"},
        {"Smithsonian Astrophysical Observation", "SAO 20351"},
        {"Wilson Evans Batten Catalogue", "WEB 20176"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.66582952),
        dec: Angle.Degrees(+63.07715690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31864"},
        {"Hipparcos Number", "HIP 23530"},
        {"Cincinnati Publication", "Ci 18 640"},
        {"Smithsonian Astrophysical Observation", "SAO 13347"},
        {"Wilson Evans Batten Catalogue", "WEB 4584"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.87769937),
        dec: Angle.Degrees(+63.07741788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 310.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1233 A"},
        {"Henry Draper", "HD 9546"},
        {"Hipparcos Number", "HIP 7400"},
        {"Smithsonian Astrophysical Observation", "SAO 11846"},
        {"Wilson Evans Batten Catalogue", "WEB 1588"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85122527),
        dec: Angle.Degrees(+63.08197758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31865"},
        {"Hipparcos Number", "HIP 23532"},
        {"Cincinnati Publication", "Ci 18 641"},
        {"Smithsonian Astrophysical Observation", "SAO 13348"},
        {"Wilson Evans Batten Catalogue", "WEB 4585"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.88822036),
        dec: Angle.Degrees(+63.08517472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 315.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103319"},
        {"Smithsonian Astrophysical Observation", "SAO 19106"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.98646062),
        dec: Angle.Degrees(+63.08572325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55671"},
        {"Smithsonian Astrophysical Observation", "SAO 15496"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.10279952),
        dec: Angle.Degrees(+63.08602942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65448"},
        {"Hipparcos Number", "HIP 39340"},
        {"Fundamental Katalog 5th Edition", "FK5 2619"},
        {"Geneva Identification System", "GEN# +1.00065448"},
        {"Smithsonian Astrophysical Observation", "SAO 14407"},
        {"Wilson Evans Batten Catalogue", "WEB 7700"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.62842941),
        dec: Angle.Degrees(+63.09034005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92881"},
        {"Smithsonian Astrophysical Observation", "SAO 18073"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.87826014),
        dec: Angle.Degrees(+63.09268827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73552"},
        {"Hipparcos Number", "HIP 42725"},
        {"Smithsonian Astrophysical Observation", "SAO 14635"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.60542515),
        dec: Angle.Degrees(+63.09677443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153204"},
        {"Hipparcos Number", "HIP 82655"},
        {"Geneva Identification System", "GEN# +1.00153204"},
        {"Smithsonian Astrophysical Observation", "SAO 17261"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.44453228),
        dec: Angle.Degrees(+63.09846082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15417 AB"},
        {"Henry Draper", "HD 208185"},
        {"Hipparcos Number", "HIP 107961"},
        {"Celescope Catalog", "CEL 5399"},
        {"Geneva Identification System", "GEN# +1.00208185J"},
        {"Smithsonian Astrophysical Observation", "SAO 19694"},
        {"Wilson Evans Batten Catalogue", "WEB 19469"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08729172),
        dec: Angle.Degrees(+63.10125325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182713"},
        {"Hipparcos Number", "HIP 95195"},
        {"Smithsonian Astrophysical Observation", "SAO 18309"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.47911619),
        dec: Angle.Degrees(+63.10153748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4811"},
        {"Hipparcos Number", "HIP 3976"},
        {"Smithsonian Astrophysical Observation", "SAO 11427"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.78364090),
        dec: Angle.Degrees(+63.10170783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130288"},
        {"Hipparcos Number", "HIP 72061"},
        {"Geneva Identification System", "GEN# +1.00130288"},
        {"Smithsonian Astrophysical Observation", "SAO 16480"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.09182195),
        dec: Angle.Degrees(+63.10198093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67850"},
        {"Hipparcos Number", "HIP 40298"},
        {"Geneva Identification System", "GEN# +1.00067850"},
        {"Smithsonian Astrophysical Observation", "SAO 14463"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.43991031),
        dec: Angle.Degrees(+63.10368118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111999"},
        {"Smithsonian Astrophysical Observation", "SAO 20206"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.28630805),
        dec: Angle.Degrees(+63.11520863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99402"},
        {"Hipparcos Number", "HIP 55859"},
        {"Geneva Identification System", "GEN# +1.00099402"},
        {"Smithsonian Astrophysical Observation", "SAO 15508"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.72642719),
        dec: Angle.Degrees(+63.11657421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10877"},
        {"Smithsonian Astrophysical Observation", "SAO 12224"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.99311332),
        dec: Angle.Degrees(+63.11661897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9520 A"},
        {"Henry Draper", "HD 134646"},
        {"Hipparcos Number", "HIP 74037"},
        {"Fundamental Katalog 5th Edition", "FK5 5343"},
        {"Geneva Identification System", "GEN# +1.00134646"},
        {"Smithsonian Astrophysical Observation", "SAO 16606"},
        {"Wilson Evans Batten Catalogue", "WEB 12645"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.95899031),
        dec: Angle.Degrees(+63.11710483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209772"},
        {"Hipparcos Number", "HIP 108924"},
        {"Geneva Identification System", "GEN# +1.00209772"},
        {"Smithsonian Astrophysical Observation", "SAO 19828"},
        {"Wilson Evans Batten Catalogue", "WEB 19592"},
    },
    visualMagnitude: 5.26,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.97054172),
        dec: Angle.Degrees(+63.11977885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6807 AB"},
        {"Hipparcos Number", "HIP 41512"},
        {"Smithsonian Astrophysical Observation", "SAO 14560"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98808364),
        dec: Angle.Degrees(+63.12074946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109803"},
        {"Geneva Identification System", "GEN# +0.06202055"},
        {"Smithsonian Astrophysical Observation", "SAO 19957"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.60276705),
        dec: Angle.Degrees(+63.12211857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162554"},
        {"Hipparcos Number", "HIP 87049"},
        {"Smithsonian Astrophysical Observation", "SAO 17635"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.79972309),
        dec: Angle.Degrees(+63.12251249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221611"},
        {"Hipparcos Number", "HIP 116237"},
        {"Geneva Identification System", "GEN# +1.00221611"},
        {"Smithsonian Astrophysical Observation", "SAO 20696"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.27530849),
        dec: Angle.Degrees(+63.12271796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116892"},
        {"Hipparcos Number", "HIP 65471"},
        {"Smithsonian Astrophysical Observation", "SAO 16068"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.29433661),
        dec: Angle.Degrees(+63.12311869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53980"},
        {"Smithsonian Astrophysical Observation", "SAO 15371"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.64109910),
        dec: Angle.Degrees(+63.12371629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21354"},
        {"Hipparcos Number", "HIP 16298"},
        {"Smithsonian Astrophysical Observation", "SAO 12784"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.53012100),
        dec: Angle.Degrees(+63.12528793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156192"},
        {"Hipparcos Number", "HIP 84130"},
        {"Geneva Identification System", "GEN# +1.00156192"},
        {"Smithsonian Astrophysical Observation", "SAO 17384"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.98238392),
        dec: Angle.Degrees(+63.12669581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33441"},
        {"Hipparcos Number", "HIP 24445"},
        {"Geneva Identification System", "GEN# +1.00033441"},
        {"Smithsonian Astrophysical Observation", "SAO 13422"},
        {"Wilson Evans Batten Catalogue", "WEB 4735"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.66081403),
        dec: Angle.Degrees(+63.12695598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137491"},
        {"Hipparcos Number", "HIP 75292"},
        {"Smithsonian Astrophysical Observation", "SAO 16717"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.75489722),
        dec: Angle.Degrees(+63.13022843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114564"},
        {"Smithsonian Astrophysical Observation", "SAO 20486"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.09274093),
        dec: Angle.Degrees(+63.13171183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54486"},
        {"Smithsonian Astrophysical Observation", "SAO 15410"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.20378069),
        dec: Angle.Degrees(+63.13360946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45703"},
        {"Hipparcos Number", "HIP 31259"},
        {"Renson", "Renson 12165"},
        {"Smithsonian Astrophysical Observation", "SAO 13878"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.34381203),
        dec: Angle.Degrees(+63.13915546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152673"},
        {"Hipparcos Number", "HIP 82421"},
        {"Fundamental Katalog 5th Edition", "FK5 5488"},
        {"Geneva Identification System", "GEN# +1.00152673"},
        {"Smithsonian Astrophysical Observation", "SAO 17243"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.65457895),
        dec: Angle.Degrees(+63.13943853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18395"},
        {"Smithsonian Astrophysical Observation", "SAO 12960"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.99192724),
        dec: Angle.Degrees(+63.13977246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212365"},
        {"Hipparcos Number", "HIP 110410"},
        {"Smithsonian Astrophysical Observation", "SAO 20032"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.46561056),
        dec: Angle.Degrees(+63.13994229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142124"},
        {"Hipparcos Number", "HIP 77474"},
        {"Fundamental Katalog 5th Edition", "FK5 5398"},
        {"Geneva Identification System", "GEN# +1.00142124"},
        {"Smithsonian Astrophysical Observation", "SAO 16861"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.27811789),
        dec: Angle.Degrees(+63.14253144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105154"},
        {"Smithsonian Astrophysical Observation", "SAO 19293"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.51324265),
        dec: Angle.Degrees(+63.14312589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78382"},
        {"Smithsonian Astrophysical Observation", "SAO 16917"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.02598948),
        dec: Angle.Degrees(+63.14341904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114776"},
        {"Hipparcos Number", "HIP 64347"},
        {"Geneva Identification System", "GEN# +1.00114776"},
        {"Smithsonian Astrophysical Observation", "SAO 16008"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.84643011),
        dec: Angle.Degrees(+63.14618130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112653"},
        {"Smithsonian Astrophysical Observation", "SAO 20257"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22782458),
        dec: Angle.Degrees(+63.14920547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121824"},
        {"Hipparcos Number", "HIP 68022"},
        {"Geneva Identification System", "GEN# +1.00121824"},
        {"Smithsonian Astrophysical Observation", "SAO 16220"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.94017864),
        dec: Angle.Degrees(+63.14970407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152970"},
        {"Hipparcos Number", "HIP 82552"},
        {"Geneva Identification System", "GEN# +1.00152970"},
        {"Smithsonian Astrophysical Observation", "SAO 17252"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.10499077),
        dec: Angle.Degrees(+63.15016724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40033"},
        {"Smithsonian Astrophysical Observation", "SAO 14452"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.66419354),
        dec: Angle.Degrees(+63.15400185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136709"},
        {"Hipparcos Number", "HIP 74943"},
        {"Smithsonian Astrophysical Observation", "SAO 16682"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.71360964),
        dec: Angle.Degrees(+63.15457633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221585"},
        {"Hipparcos Number", "HIP 116221"},
        {"Cincinnati Publication", "Ci 18 3085"},
        {"Cincinnati Publication 2", "Ci 20 1432"},
        {"Geneva Identification System", "GEN# +1.00221585"},
        {"Smithsonian Astrophysical Observation", "SAO 20692"},
        {"Wilson Evans Batten Catalogue", "WEB 20541"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.22283028),
        dec: Angle.Degrees(+63.15540694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 439.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56199"},
        {"Geneva Identification System", "GEN# +0.06300965"},
        {"Wilson Evans Batten Catalogue", "WEB 10098"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.80419168),
        dec: Angle.Degrees(+63.15747167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211242"},
        {"Hipparcos Number", "HIP 109746"},
        {"Celescope Catalog", "CEL 5456"},
        {"Geneva Identification System", "GEN# +1.00211242"},
        {"Smithsonian Astrophysical Observation", "SAO 19948"},
        {"Wilson Evans Batten Catalogue", "WEB 19716"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.45714350),
        dec: Angle.Degrees(+63.16235674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24956",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3889 AB"},
        {"Henry Draper", "HD 34277"},
        {"Hipparcos Number", "HIP 24956"},
        {"Smithsonian Astrophysical Observation", "SAO 13462"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.17147092),
        dec: Angle.Degrees(+63.16509987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103841"},
        {"Smithsonian Astrophysical Observation", "SAO 19161"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.62086782),
        dec: Angle.Degrees(+63.16960879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4717"},
        {"Hipparcos Number", "HIP 3917"},
        {"Smithsonian Astrophysical Observation", "SAO 11421"},
        {"Wilson Evans Batten Catalogue", "WEB 699"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.56796412),
        dec: Angle.Degrees(+63.17135488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59596"},
        {"Hipparcos Number", "HIP 36871"},
        {"Smithsonian Astrophysical Observation", "SAO 14239"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.70418654),
        dec: Angle.Degrees(+63.17137677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12636"},
        {"Smithsonian Astrophysical Observation", "SAO 12397"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58734790),
        dec: Angle.Degrees(+63.17183478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192932"},
        {"Hipparcos Number", "HIP 99700"},
        {"Smithsonian Astrophysical Observation", "SAO 18771"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.46610558),
        dec: Angle.Degrees(+63.17193943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14850"},
        {"Smithsonian Astrophysical Observation", "SAO 12645"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.94863324),
        dec: Angle.Degrees(+63.17226481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12623"},
        {"Hipparcos Number", "HIP 9799"},
        {"Geneva Identification System", "GEN# +1.00012623"},
        {"Smithsonian Astrophysical Observation", "SAO 12122"},
        {"Wilson Evans Batten Catalogue", "WEB 2058"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.50347504),
        dec: Angle.Degrees(+63.17236865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80605"},
        {"Hipparcos Number", "HIP 46059"},
        {"Fundamental Katalog 5th Edition", "FK5 4835"},
        {"Smithsonian Astrophysical Observation", "SAO 14863"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.88372506),
        dec: Angle.Degrees(+63.17410852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78980"},
        {"Hipparcos Number", "HIP 45323"},
        {"Smithsonian Astrophysical Observation", "SAO 14817"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.54869510),
        dec: Angle.Degrees(+63.17509111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47062"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.86356033),
        dec: Angle.Degrees(+63.17793554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42091"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.68308549),
        dec: Angle.Degrees(+63.17937773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107233"},
        {"Smithsonian Astrophysical Observation", "SAO 19600"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.77141788),
        dec: Angle.Degrees(+63.18029865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127821"},
        {"Hipparcos Number", "HIP 70952"},
        {"Fundamental Katalog 5th Edition", "FK5 3150"},
        {"Geneva Identification System", "GEN# +1.00127821"},
        {"Smithsonian Astrophysical Observation", "SAO 16406"},
        {"Wilson Evans Batten Catalogue", "WEB 12281"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.69291510),
        dec: Angle.Degrees(+63.18576376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19635"},
        {"Hipparcos Number", "HIP 14968"},
        {"Smithsonian Astrophysical Observation", "SAO 12657"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.23684479),
        dec: Angle.Degrees(+63.18677866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15102"},
        {"Hipparcos Number", "HIP 11527"},
        {"Smithsonian Astrophysical Observation", "SAO 12296"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.15981411),
        dec: Angle.Degrees(+63.18769383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111221"},
        {"Smithsonian Astrophysical Observation", "SAO 20132"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.00342487),
        dec: Angle.Degrees(+63.19182459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20984"},
        {"Hipparcos Number", "HIP 16041"},
        {"Geneva Identification System", "GEN# +1.00020984"},
        {"Smithsonian Astrophysical Observation", "SAO 12758"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64494404),
        dec: Angle.Degrees(+63.19519701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188053"},
        {"Hipparcos Number", "HIP 97536"},
        {"Smithsonian Astrophysical Observation", "SAO 18547"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.35760807),
        dec: Angle.Degrees(+63.20386575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 371"},
        {"Hipparcos Number", "HIP 695"},
        {"Celescope Catalog", "CEL 27"},
        {"Geneva Identification System", "GEN# +1.00000371"},
        {"Smithsonian Astrophysical Observation", "SAO 10999"},
        {"Wilson Evans Batten Catalogue", "WEB 117"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.13694986),
        dec: Angle.Degrees(+63.20404897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94760",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12296 AB"},
        {"Henry Draper", "HD 181566"},
        {"Hipparcos Number", "HIP 94760"},
        {"Smithsonian Astrophysical Observation", "SAO 18257"},
        {"Wilson Evans Batten Catalogue", "WEB 16536"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.22118727),
        dec: Angle.Degrees(+63.20743857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89796"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.88394771),
        dec: Angle.Degrees(+63.20808493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197911"},
        {"Hipparcos Number", "HIP 102274"},
        {"Celescope Catalog", "CEL 5159"},
        {"Geneva Identification System", "GEN# +1.00197911"},
        {"Smithsonian Astrophysical Observation", "SAO 19003"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.84009614),
        dec: Angle.Degrees(+63.20913051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125959"},
        {"Hipparcos Number", "HIP 70057"},
        {"Smithsonian Astrophysical Observation", "SAO 16341"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.05455402),
        dec: Angle.Degrees(+63.20936058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106738"},
        {"Smithsonian Astrophysical Observation", "SAO 19533"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.32908661),
        dec: Angle.Degrees(+63.20998746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180160"},
        {"Hipparcos Number", "HIP 94271"},
        {"Smithsonian Astrophysical Observation", "SAO 18201"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.82511312),
        dec: Angle.Degrees(+63.21028415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218342"},
        {"Hipparcos Number", "HIP 114070"},
        {"Celescope Catalog", "CEL 5565"},
        {"Geneva Identification System", "GEN# +9.00020076"},
        {"Smithsonian Astrophysical Observation", "SAO 20422"},
        {"Wilson Evans Batten Catalogue", "WEB 20257"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.53741518),
        dec: Angle.Degrees(+63.21280592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197809"},
        {"Hipparcos Number", "HIP 102215"},
        {"Smithsonian Astrophysical Observation", "SAO 19000"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.66529127),
        dec: Angle.Degrees(+63.21314261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128492"},
        {"Hipparcos Number", "HIP 71267"},
        {"Smithsonian Astrophysical Observation", "SAO 16433"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.62733314),
        dec: Angle.Degrees(+63.21591102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22649"},
        {"Hipparcos Number", "HIP 17296"},
        {"Fundamental Katalog 5th Edition", "FK5 129"},
        {"Geneva Identification System", "GEN# +1.00022649"},
        {"Smithsonian Astrophysical Observation", "SAO 12874"},
        {"Wilson Evans Batten Catalogue", "WEB 3267"},
    },
    visualMagnitude: 5.06,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.53894572),
        dec: Angle.Degrees(+63.21675891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110119"},
        {"Geneva Identification System", "GEN# +1.00211880B"},
        {"Smithsonian Astrophysical Observation", "SAO 19992"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.60436662),
        dec: Angle.Degrees(+63.22004573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3346 AB"},
        {"Henry Draper", "HD 29148"},
        {"Hipparcos Number", "HIP 21695"},
        {"Smithsonian Astrophysical Observation", "SAO 13222"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.86634107),
        dec: Angle.Degrees(+63.22081200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86094"},
        {"Smithsonian Astrophysical Observation", "SAO 17552"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.92236413),
        dec: Angle.Degrees(+63.22187813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211880"},
        {"Hipparcos Number", "HIP 110125"},
        {"Celescope Catalog", "CEL 5464"},
        {"Geneva Identification System", "GEN# +1.00211880A"},
        {"Smithsonian Astrophysical Observation", "SAO 19993"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.61585803),
        dec: Angle.Degrees(+63.22290812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3637"},
        {"Hipparcos Number", "HIP 3136"},
        {"Geneva Identification System", "GEN# +1.00003637"},
        {"Smithsonian Astrophysical Observation", "SAO 11320"},
        {"Wilson Evans Batten Catalogue", "WEB 559"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.96649376),
        dec: Angle.Degrees(+63.22756256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37029"},
        {"Hipparcos Number", "HIP 26663"},
        {"Smithsonian Astrophysical Observation", "SAO 13562"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.00030890),
        dec: Angle.Degrees(+63.22918468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18406"},
        {"Smithsonian Astrophysical Observation", "SAO 12962"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.03021198),
        dec: Angle.Degrees(+63.22952736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28588"},
        {"Hipparcos Number", "HIP 21311"},
        {"Smithsonian Astrophysical Observation", "SAO 13190"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.63351421),
        dec: Angle.Degrees(+63.23278039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13686"},
        {"Hipparcos Number", "HIP 10557"},
        {"Geneva Identification System", "GEN# +1.00013686"},
        {"Smithsonian Astrophysical Observation", "SAO 12195"},
        {"Wilson Evans Batten Catalogue", "WEB 2215"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.98080378),
        dec: Angle.Degrees(+63.23630372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111010"},
        {"Geneva Identification System", "GEN# +0.06202089"},
        {"Smithsonian Astrophysical Observation", "SAO 20101"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34898541),
        dec: Angle.Degrees(+63.23754787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218139"},
        {"Hipparcos Number", "HIP 113947"},
        {"Geneva Identification System", "GEN# +1.00218139"},
        {"Smithsonian Astrophysical Observation", "SAO 20405"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.13606313),
        dec: Angle.Degrees(+63.24058646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15829"},
        {"Hipparcos Number", "HIP 12059"},
        {"Geneva Identification System", "GEN# +1.00015829"},
        {"Smithsonian Astrophysical Observation", "SAO 12346"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.87798320),
        dec: Angle.Degrees(+63.24324290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44397"},
        {"Smithsonian Astrophysical Observation", "SAO 14743"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.65320105),
        dec: Angle.Degrees(+63.24595320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84406"},
        {"Hipparcos Number", "HIP 48034"},
        {"Geneva Identification System", "GEN# +1.00084406"},
        {"Smithsonian Astrophysical Observation", "SAO 14987"},
        {"Wilson Evans Batten Catalogue", "WEB 8984"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.87797388),
        dec: Angle.Degrees(+63.24813717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107357"},
        {"Smithsonian Astrophysical Observation", "SAO 19618"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.17108367),
        dec: Angle.Degrees(+63.25876944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150076"},
        {"Hipparcos Number", "HIP 81162"},
        {"Smithsonian Astrophysical Observation", "SAO 17152"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.64939723),
        dec: Angle.Degrees(+63.25877096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108033"},
        {"Smithsonian Astrophysical Observation", "SAO 19707"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.28956561),
        dec: Angle.Degrees(+63.25877332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97988"},
        {"Hipparcos Number", "HIP 55111"},
        {"Smithsonian Astrophysical Observation", "SAO 15460"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26088092),
        dec: Angle.Degrees(+63.25889752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69010"},
        {"Hipparcos Number", "HIP 40727"},
        {"Geneva Identification System", "GEN# +1.00069010"},
        {"Smithsonian Astrophysical Observation", "SAO 14495"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68809691),
        dec: Angle.Degrees(+63.25892805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29796"},
        {"Hipparcos Number", "HIP 22130"},
        {"Geneva Identification System", "GEN# +1.00029796"},
        {"Smithsonian Astrophysical Observation", "SAO 13255"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.43743747),
        dec: Angle.Degrees(+63.25976944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117043"},
        {"Hipparcos Number", "HIP 65530"},
        {"Cincinnati Publication", "Ci 20 778"},
        {"Geneva Identification System", "GEN# +1.00117043"},
        {"Smithsonian Astrophysical Observation", "SAO 16071"},
        {"Wilson Evans Batten Catalogue", "WEB 11570"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.50153032),
        dec: Angle.Degrees(+63.26073879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -392.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208713"},
        {"Hipparcos Number", "HIP 108257"},
        {"Geneva Identification System", "GEN# +1.00208713"},
        {"Smithsonian Astrophysical Observation", "SAO 19745"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.97381153),
        dec: Angle.Degrees(+63.26112642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209162"},
        {"Hipparcos Number", "HIP 108518"},
        {"Geneva Identification System", "GEN# +1.00209162"},
        {"Smithsonian Astrophysical Observation", "SAO 19776"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.76487158),
        dec: Angle.Degrees(+63.26283067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174546"},
        {"Hipparcos Number", "HIP 92135"},
        {"Smithsonian Astrophysical Observation", "SAO 18016"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.68001757),
        dec: Angle.Degrees(+63.26575969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78088"},
        {"Hipparcos Number", "HIP 44950"},
        {"Smithsonian Astrophysical Observation", "SAO 14779"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.36595994),
        dec: Angle.Degrees(+63.26713912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95674"},
        {"Hipparcos Number", "HIP 54064"},
        {"Smithsonian Astrophysical Observation", "SAO 15383"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.93749185),
        dec: Angle.Degrees(+63.26993324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39301"},
        {"Hipparcos Number", "HIP 28078"},
        {"Fundamental Katalog 5th Edition", "FK5 4542"},
        {"Geneva Identification System", "GEN# +1.00039301"},
        {"Smithsonian Astrophysical Observation", "SAO 13654"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.03285286),
        dec: Angle.Degrees(+63.28182371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8768"},
        {"Hipparcos Number", "HIP 6844"},
        {"Geneva Identification System", "GEN# +2.05591168"},
        {"Geneva Identification System 2", "GEN# +1.00008768"},
        {"Smithsonian Astrophysical Observation", "SAO 11770"},
        {"Wilson Evans Batten Catalogue", "WEB 1492"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.01314411),
        dec: Angle.Degrees(+63.28254881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17226"},
        {"Hipparcos Number", "HIP 13125"},
        {"Geneva Identification System", "GEN# +1.00017226"},
        {"Smithsonian Astrophysical Observation", "SAO 12450"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.21036704),
        dec: Angle.Degrees(+63.28297710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71690"},
        {"Smithsonian Astrophysical Observation", "SAO 16457"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.96671442),
        dec: Angle.Degrees(+63.28356111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2617 A"},
        {"Henry Draper", "HD 21971"},
        {"Hipparcos Number", "HIP 16789"},
        {"Smithsonian Astrophysical Observation", "SAO 12830"},
        {"Wilson Evans Batten Catalogue", "WEB 3194"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.01586874),
        dec: Angle.Degrees(+63.28812241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1447"},
        {"Hipparcos Number", "HIP 1521"},
        {"Geneva Identification System", "GEN# +1.00001447"},
        {"Renson", "Renson 280"},
        {"Smithsonian Astrophysical Observation", "SAO 11101"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.73684247),
        dec: Angle.Degrees(+63.28825327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42139"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.84931328),
        dec: Angle.Degrees(+63.28839380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221584"},
        {"Hipparcos Number", "HIP 116207"},
        {"Geneva Identification System", "GEN# +1.00221584"},
        {"Smithsonian Astrophysical Observation", "SAO 20690"},
        {"Wilson Evans Batten Catalogue", "WEB 20539"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.18648088),
        dec: Angle.Degrees(+63.29063044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211029"},
        {"Hipparcos Number", "HIP 109620"},
        {"Geneva Identification System", "GEN# +1.00211029"},
        {"Smithsonian Astrophysical Observation", "SAO 19937"},
        {"Wilson Evans Batten Catalogue", "WEB 19699"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.09352250),
        dec: Angle.Degrees(+63.29107190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201888"},
        {"Hipparcos Number", "HIP 104449"},
        {"Geneva Identification System", "GEN# +1.00201888"},
        {"Smithsonian Astrophysical Observation", "SAO 19223"},
        {"Wilson Evans Batten Catalogue", "WEB 19013"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.36999401),
        dec: Angle.Degrees(+63.29564943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37857"},
        {"Hipparcos Number", "HIP 27199"},
        {"Geneva Identification System", "GEN# +1.00037857"},
        {"Smithsonian Astrophysical Observation", "SAO 13601"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.47909700),
        dec: Angle.Degrees(+63.29635979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37281"},
        {"Hipparcos Number", "HIP 26829"},
        {"Geneva Identification System", "GEN# +1.00037281"},
        {"Smithsonian Astrophysical Observation", "SAO 13567"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.44784612),
        dec: Angle.Degrees(+63.29647880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109502"},
        {"Smithsonian Astrophysical Observation", "SAO 19920"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.74241684),
        dec: Angle.Degrees(+63.29677733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17891",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "MOAI 1"},
        {"Henry Draper", "HD 23523"},
        {"Hipparcos Number", "HIP 17891"},
        {"Geneva Identification System", "GEN# +1.00023523"},
        {"Smithsonian Astrophysical Observation", "SAO 12917"},
        {"Wilson Evans Batten Catalogue", "WEB 3443"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.40258833),
        dec: Angle.Degrees(+63.29710438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117684"},
        {"Geneva Identification System", "GEN# +0.06202313"},
        {"Smithsonian Astrophysical Observation", "SAO 20899"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.99534902),
        dec: Angle.Degrees(+63.30300056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11959"},
        {"Hipparcos Number", "HIP 9321"},
        {"Geneva Identification System", "GEN# +1.00011959"},
        {"Smithsonian Astrophysical Observation", "SAO 12077"},
        {"Wilson Evans Batten Catalogue", "WEB 1957"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.93103846),
        dec: Angle.Degrees(+63.31418259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12586 AB"},
        {"Henry Draper", "HD 184563"},
        {"Hipparcos Number", "HIP 96002"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.80107032),
        dec: Angle.Degrees(+63.31453504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12586 D"},
        {"Henry Draper", "HD 184562"},
        {"Hipparcos Number", "HIP 95986"},
        {"Smithsonian Astrophysical Observation", "SAO 18378"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.76730475),
        dec: Angle.Degrees(+63.31476106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94091"},
        {"Smithsonian Astrophysical Observation", "SAO 18178"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31331216),
        dec: Angle.Degrees(+63.31670126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223057"},
        {"Hipparcos Number", "HIP 117220"},
        {"Celescope Catalog", "CEL 5668"},
        {"Geneva Identification System", "GEN# +1.00223057"},
        {"Smithsonian Astrophysical Observation", "SAO 20830"},
        {"Wilson Evans Batten Catalogue", "WEB 20655"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50612244),
        dec: Angle.Degrees(+63.31696039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34655",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5818 AB"},
        {"Henry Draper", "HD 53815"},
        {"Hipparcos Number", "HIP 34655"},
        {"Smithsonian Astrophysical Observation", "SAO 14105"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.66162988),
        dec: Angle.Degrees(+63.31774071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30536"},
        {"Smithsonian Astrophysical Observation", "SAO 13830"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.28312470),
        dec: Angle.Degrees(+63.32311540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74717"},
        {"Hipparcos Number", "HIP 43278"},
        {"Geneva Identification System", "GEN# +1.00074717"},
        {"Smithsonian Astrophysical Observation", "SAO 14668"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.24722046),
        dec: Angle.Degrees(+63.32425964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212882"},
        {"Hipparcos Number", "HIP 110706"},
        {"Geneva Identification System", "GEN# +1.00212882"},
        {"Smithsonian Astrophysical Observation", "SAO 20060"},
        {"Wilson Evans Batten Catalogue", "WEB 19835"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.44534129),
        dec: Angle.Degrees(+63.32832567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189206"},
        {"Hipparcos Number", "HIP 98010"},
        {"Smithsonian Astrophysical Observation", "SAO 18596"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.76467984),
        dec: Angle.Degrees(+63.33063650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 423 D"},
        {"Hipparcos Number", "HIP 2466"},
        {"Geneva Identification System", "GEN# +0.06200096"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.84164814),
        dec: Angle.Degrees(+63.33073411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22498"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.60335897),
        dec: Angle.Degrees(+63.33342400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73725"},
        {"Hipparcos Number", "HIP 42801"},
        {"Smithsonian Astrophysical Observation", "SAO 14638"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80846316),
        dec: Angle.Degrees(+63.33445249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54549",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8073 A"},
        {"Henry Draper", "HD 96758"},
        {"Hipparcos Number", "HIP 54549"},
        {"Geneva Identification System", "GEN# +1.00096758"},
        {"Smithsonian Astrophysical Observation", "SAO 15415"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43788886),
        dec: Angle.Degrees(+63.33514826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160606"},
        {"Hipparcos Number", "HIP 86164"},
        {"Geneva Identification System", "GEN# +1.00160606"},
        {"Smithsonian Astrophysical Observation", "SAO 17559"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.11540785),
        dec: Angle.Degrees(+63.33654140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63931"},
        {"Hipparcos Number", "HIP 38699"},
        {"Smithsonian Astrophysical Observation", "SAO 14366"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.84904129),
        dec: Angle.Degrees(+63.33986036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60103"},
        {"Hipparcos Number", "HIP 37073"},
        {"Geneva Identification System", "GEN# +1.00060103"},
        {"Smithsonian Astrophysical Observation", "SAO 14257"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.27382286),
        dec: Angle.Degrees(+63.34019154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217872"},
        {"Hipparcos Number", "HIP 113793"},
        {"Fundamental Katalog 5th Edition", "FK5 6041"},
        {"Geneva Identification System", "GEN# +1.00217872"},
        {"Smithsonian Astrophysical Observation", "SAO 20384"},
        {"Wilson Evans Batten Catalogue", "WEB 20216"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.66268343),
        dec: Angle.Degrees(+63.34084493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137443"},
        {"Hipparcos Number", "HIP 75260"},
        {"Fundamental Katalog 5th Edition", "FK5 3215"},
        {"Geneva Identification System", "GEN# +1.00137443"},
        {"Smithsonian Astrophysical Observation", "SAO 16713"},
        {"Wilson Evans Batten Catalogue", "WEB 12837"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.66014565),
        dec: Angle.Degrees(+63.34166375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 423 A"},
        {"Hipparcos Number", "HIP 2460"},
        {"Geneva Identification System", "GEN# +0.06200093"},
    },
    visualMagnitude: 10.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.82357494),
        dec: Angle.Degrees(+63.34249886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23089"},
        {"Henry Draper 2", "HD 23090"},
        {"Hipparcos Number", "HIP 17587"},
        {"Geneva Identification System", "GEN# +1.00023089"},
        {"Smithsonian Astrophysical Observation", "SAO 12891"},
        {"Wilson Evans Batten Catalogue", "WEB 3342"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.50971937),
        dec: Angle.Degrees(+63.34506772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70421"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09656648),
        dec: Angle.Degrees(+63.34540787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9105"},
        {"Hipparcos Number", "HIP 7088"},
        {"Geneva Identification System", "GEN# +1.00009105"},
        {"Smithsonian Astrophysical Observation", "SAO 11793"},
        {"Wilson Evans Batten Catalogue", "WEB 1528"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.82496885),
        dec: Angle.Degrees(+63.34757679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51435",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7793 A"},
        {"Henry Draper", "HD 90714"},
        {"Hipparcos Number", "HIP 51435"},
        {"Smithsonian Astrophysical Observation", "SAO 15199"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.56702112),
        dec: Angle.Degrees(+63.34873319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197751"},
        {"Hipparcos Number", "HIP 102193"},
        {"Geneva Identification System", "GEN# +1.00197751"},
        {"Smithsonian Astrophysical Observation", "SAO 18997"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.58848320),
        dec: Angle.Degrees(+63.35102604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78105"},
        {"Hipparcos Number", "HIP 44970"},
        {"Smithsonian Astrophysical Observation", "SAO 14782"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.41448335),
        dec: Angle.Degrees(+63.35103265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156279"},
        {"Hipparcos Number", "HIP 84171"},
        {"Smithsonian Astrophysical Observation", "SAO 17390"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09668930),
        dec: Angle.Degrees(+63.35170227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3566"},
        {"Geneva Identification System", "GEN# +8.01630102"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.39610901),
        dec: Angle.Degrees(+63.35206737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76384"},
        {"Hipparcos Number", "HIP 44114"},
        {"Geneva Identification System", "GEN# +1.00076384"},
        {"Smithsonian Astrophysical Observation", "SAO 14727"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.77407791),
        dec: Angle.Degrees(+63.35263095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156649"},
        {"Hipparcos Number", "HIP 84342"},
        {"Smithsonian Astrophysical Observation", "SAO 17402"},
        {"Wilson Evans Batten Catalogue", "WEB 14239"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.64217331),
        dec: Angle.Degrees(+63.35312625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 423 C"},
        {"Hipparcos Number", "HIP 2454"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.81218023),
        dec: Angle.Degrees(+63.35445087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224939"},
        {"Hipparcos Number", "HIP 156"},
        {"Celescope Catalog", "CEL 5756"},
        {"Geneva Identification System", "GEN# +1.00224939"},
        {"Smithsonian Astrophysical Observation", "SAO 21017"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.49688500),
        dec: Angle.Degrees(+63.35784580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4347"},
        {"Hipparcos Number", "HIP 3657"},
        {"Renson", "Renson 1190"},
        {"Smithsonian Astrophysical Observation", "SAO 11386"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.70585220),
        dec: Angle.Degrees(+63.35838768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172557"},
        {"Hipparcos Number", "HIP 91229"},
        {"Geneva Identification System", "GEN# +1.00172557"},
        {"Smithsonian Astrophysical Observation", "SAO 17950"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.14088080),
        dec: Angle.Degrees(+63.36205580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105989"},
        {"Smithsonian Astrophysical Observation", "SAO 19431"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.99756642),
        dec: Angle.Degrees(+63.36723206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3552 AB"},
        {"Henry Draper", "HD 31337"},
        {"Hipparcos Number", "HIP 23170"},
        {"Smithsonian Astrophysical Observation", "SAO 13326"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.77140449),
        dec: Angle.Degrees(+63.36843090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9804"},
        {"Geneva Identification System", "GEN# +8.01630181"},
        {"Geneva Identification System 2", "GEN# +6.10090216"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.53566532),
        dec: Angle.Degrees(+63.36994918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20304"},
        {"Hipparcos Number", "HIP 15472"},
        {"Smithsonian Astrophysical Observation", "SAO 12701"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.87305127),
        dec: Angle.Degrees(+63.37063269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13798"},
        {"Hipparcos Number", "HIP 10639"},
        {"Smithsonian Astrophysical Observation", "SAO 12202"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.23537384),
        dec: Angle.Degrees(+63.37363971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115925"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.30319292),
        dec: Angle.Degrees(+63.37430732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85915"},
        {"Hipparcos Number", "HIP 48819"},
        {"Geneva Identification System", "GEN# +1.00085915"},
        {"Smithsonian Astrophysical Observation", "SAO 15030"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.37526280),
        dec: Angle.Degrees(+63.37624981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201032"},
        {"Hipparcos Number", "HIP 103984"},
        {"Geneva Identification System", "GEN# +1.00201032"},
        {"Renson", "Renson 56058"},
        {"Smithsonian Astrophysical Observation", "SAO 19169"},
        {"Wilson Evans Batten Catalogue", "WEB 18942"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.02676651),
        dec: Angle.Degrees(+63.37962498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28961"},
        {"Smithsonian Astrophysical Observation", "SAO 13716"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67911373),
        dec: Angle.Degrees(+63.38214270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152048"},
        {"Hipparcos Number", "HIP 82145"},
        {"Smithsonian Astrophysical Observation", "SAO 17220"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.72569530),
        dec: Angle.Degrees(+63.38595356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3956 AB"},
        {"Henry Draper", "HD 34839"},
        {"Hipparcos Number", "HIP 25300"},
        {"Smithsonian Astrophysical Observation", "SAO 13482"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.18507421),
        dec: Angle.Degrees(+63.38660393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72836"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.31578274),
        dec: Angle.Degrees(+63.38703794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116707"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.76362183),
        dec: Angle.Degrees(+63.38842436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181357"},
        {"Hipparcos Number", "HIP 94692"},
        {"Smithsonian Astrophysical Observation", "SAO 18247"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.02081987),
        dec: Angle.Degrees(+63.39301343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29548"},
        {"Geneva Identification System", "GEN# +0.06300639"},
        {"Wilson Evans Batten Catalogue", "WEB 5809"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.39608065),
        dec: Angle.Degrees(+63.39464091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218066"},
        {"Hipparcos Number", "HIP 113907"},
        {"Geneva Identification System", "GEN# +9.02006910"},
        {"Geneva Identification System 2", "GEN# +9.00020069"},
        {"Smithsonian Astrophysical Observation", "SAO 20401"},
        {"Wilson Evans Batten Catalogue", "WEB 20232"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.00927497),
        dec: Angle.Degrees(+63.39688015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42731"},
        {"Smithsonian Astrophysical Observation", "SAO 14636"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.62694989),
        dec: Angle.Degrees(+63.39807655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109505",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15712 AB"},
        {"Henry Draper", "HD 210808"},
        {"Hipparcos Number", "HIP 109505"},
        {"Celescope Catalog", "CEL 5451"},
        {"Geneva Identification System", "GEN# +1.00210808"},
        {"Smithsonian Astrophysical Observation", "SAO 19921"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.74815793),
        dec: Angle.Degrees(+63.39958532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135855"},
        {"Hipparcos Number", "HIP 74559"},
        {"Smithsonian Astrophysical Observation", "SAO 16653"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.51018563),
        dec: Angle.Degrees(+63.40217042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31097"},
        {"Hipparcos Number", "HIP 23038"},
        {"Smithsonian Astrophysical Observation", "SAO 13313"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.31620861),
        dec: Angle.Degrees(+63.40255019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8306 AB"},
        {"Hipparcos Number", "HIP 57911"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.17054865),
        dec: Angle.Degrees(+63.40274051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45600"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.41620018),
        dec: Angle.Degrees(+63.40285934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101670"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.12015176),
        dec: Angle.Degrees(+63.40540466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145870"},
        {"Hipparcos Number", "HIP 79161"},
        {"Smithsonian Astrophysical Observation", "SAO 16979"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.34802174),
        dec: Angle.Degrees(+63.40767020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17591"},
        {"Hipparcos Number", "HIP 13394"},
        {"Geneva Identification System", "GEN# +1.00017591"},
        {"Smithsonian Astrophysical Observation", "SAO 12478"},
        {"Wilson Evans Batten Catalogue", "WEB 2682"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.09408668),
        dec: Angle.Degrees(+63.41006580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112983"},
        {"Geneva Identification System", "GEN# +9.00020014"},
        {"Smithsonian Astrophysical Observation", "SAO 20293"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20917763),
        dec: Angle.Degrees(+63.41344954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9695"},
        {"Hipparcos Number", "HIP 7512"},
        {"Geneva Identification System", "GEN# +1.00009695"},
        {"Smithsonian Astrophysical Observation", "SAO 11866"},
        {"Wilson Evans Batten Catalogue", "WEB 1605"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.19591018),
        dec: Angle.Degrees(+63.41448821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32077"},
        {"Smithsonian Astrophysical Observation", "SAO 13928"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.52435697),
        dec: Angle.Degrees(+63.41513356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3250 AB"},
        {"Henry Draper", "HD 28184"},
        {"Hipparcos Number", "HIP 21065"},
        {"Smithsonian Astrophysical Observation", "SAO 13167"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.72657060),
        dec: Angle.Degrees(+63.41574224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83267"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.27534993),
        dec: Angle.Degrees(+63.41708877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 253.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11763"},
        {"Geneva Identification System", "GEN# +0.06200411"},
        {"Smithsonian Astrophysical Observation", "SAO 12317"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.94924031),
        dec: Angle.Degrees(+63.41741675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113051"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.42243953),
        dec: Angle.Degrees(+63.41798418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95256"},
        {"Hipparcos Number", "HIP 53860"},
        {"Geneva Identification System", "GEN# +1.00095256"},
        {"Renson", "Renson 27440"},
        {"Smithsonian Astrophysical Observation", "SAO 15360"},
        {"Wilson Evans Batten Catalogue", "WEB 9753"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.27385829),
        dec: Angle.Degrees(+63.42123499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19787"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.61315020),
        dec: Angle.Degrees(+63.42175350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7106 AB"},
        {"Henry Draper", "HD 76362"},
        {"Hipparcos Number", "HIP 44107"},
        {"Smithsonian Astrophysical Observation", "SAO 14723"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.75266222),
        dec: Angle.Degrees(+63.42864749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194299"},
        {"Hipparcos Number", "HIP 100372"},
        {"Smithsonian Astrophysical Observation", "SAO 18828"},
        {"Wilson Evans Batten Catalogue", "WEB 18114"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.33942091),
        dec: Angle.Degrees(+63.43165068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176968"},
        {"Hipparcos Number", "HIP 93143"},
        {"Geneva Identification System", "GEN# +1.00176968"},
        {"Smithsonian Astrophysical Observation", "SAO 18092"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61021779),
        dec: Angle.Degrees(+63.43323946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185394"},
        {"Hipparcos Number", "HIP 96297"},
        {"Smithsonian Astrophysical Observation", "SAO 18413"},
        {"Wilson Evans Batten Catalogue", "WEB 16886"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.69306823),
        dec: Angle.Degrees(+63.43417949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155479"},
        {"Hipparcos Number", "HIP 83799"},
        {"Geneva Identification System", "GEN# +1.00155479"},
        {"Smithsonian Astrophysical Observation", "SAO 17359"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.89211664),
        dec: Angle.Degrees(+63.43941062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21708"},
        {"Hipparcos Number", "HIP 16610"},
        {"Smithsonian Astrophysical Observation", "SAO 12811"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.44573062),
        dec: Angle.Degrees(+63.44102073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 942"},
        {"Celescope Catalog", "CEL 40"},
        {"Geneva Identification System", "GEN# +0.06200015"},
        {"Smithsonian Astrophysical Observation", "SAO 11026"},
        {"Wilson Evans Batten Catalogue", "WEB 167"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90603532),
        dec: Angle.Degrees(+63.44314203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100816"},
        {"Smithsonian Astrophysical Observation", "SAO 18867"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.61935371),
        dec: Angle.Degrees(+63.44509897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40956"},
        {"Hipparcos Number", "HIP 28951"},
        {"Smithsonian Astrophysical Observation", "SAO 13715"},
        {"Wilson Evans Batten Catalogue", "WEB 5667"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66333712),
        dec: Angle.Degrees(+63.45381713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8693"},
        {"Geneva Identification System", "GEN# +0.06200313"},
        {"Wilson Evans Batten Catalogue", "WEB 1832"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.96036225),
        dec: Angle.Degrees(+63.45406307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73446"},
        {"Hipparcos Number", "HIP 42688"},
        {"Smithsonian Astrophysical Observation", "SAO 14628"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.50692732),
        dec: Angle.Degrees(+63.45550256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17972"},
    },
    visualMagnitude: 11.53,
    bvColour: 2.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64050092),
        dec: Angle.Degrees(+63.45571636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191648"},
        {"Hipparcos Number", "HIP 99105"},
        {"Geneva Identification System", "GEN# +1.00191648"},
        {"Smithsonian Astrophysical Observation", "SAO 18721"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.80993268),
        dec: Angle.Degrees(+63.46009311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145179"},
        {"Hipparcos Number", "HIP 78845"},
        {"Smithsonian Astrophysical Observation", "SAO 16953"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.42201314),
        dec: Angle.Degrees(+63.46125851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8716"},
        {"Geneva Identification System", "GEN# +0.06200314"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04193076),
        dec: Angle.Degrees(+63.46395806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128815"},
        {"Hipparcos Number", "HIP 71416"},
        {"Smithsonian Astrophysical Observation", "SAO 16441"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.07416480),
        dec: Angle.Degrees(+63.46553356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75764"},
        {"Hipparcos Number", "HIP 43793"},
        {"Geneva Identification System", "GEN# +1.00075764"},
        {"Smithsonian Astrophysical Observation", "SAO 14696"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.78691052),
        dec: Angle.Degrees(+63.46862305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68698"},
        {"Smithsonian Astrophysical Observation", "SAO 16269"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.93661107),
        dec: Angle.Degrees(+63.47079080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216926"},
        {"Hipparcos Number", "HIP 113236"},
        {"Geneva Identification System", "GEN# +9.00020035"},
        {"Smithsonian Astrophysical Observation", "SAO 20327"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.96926723),
        dec: Angle.Degrees(+63.47311080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47288"},
        {"Hipparcos Number", "HIP 32105"},
        {"Smithsonian Astrophysical Observation", "SAO 13930"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.60173197),
        dec: Angle.Degrees(+63.47667103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186118"},
        {"Hipparcos Number", "HIP 96616"},
        {"Smithsonian Astrophysical Observation", "SAO 18448"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.65910061),
        dec: Angle.Degrees(+63.48245906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23982"},
        {"Hipparcos Number", "HIP 18172"},
        {"Geneva Identification System", "GEN# +1.00023982"},
        {"Smithsonian Astrophysical Observation", "SAO 12946"},
        {"Wilson Evans Batten Catalogue", "WEB 3505"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.30184521),
        dec: Angle.Degrees(+63.48343657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63113"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.98177966),
        dec: Angle.Degrees(+63.49358315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15937"},
        {"Hipparcos Number", "HIP 12145"},
        {"Smithsonian Astrophysical Observation", "SAO 12356"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.13859242),
        dec: Angle.Degrees(+63.49675005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10267"},
        {"Smithsonian Astrophysical Observation", "SAO 12166"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.04014839),
        dec: Angle.Degrees(+63.49836756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7684 A"},
        {"Hipparcos Number", "HIP 50104"},
        {"Smithsonian Astrophysical Observation", "SAO 15119"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.44218496),
        dec: Angle.Degrees(+63.50143172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115082"},
        {"Geneva Identification System", "GEN# +0.06202210"},
        {"Smithsonian Astrophysical Observation", "SAO 20552"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.63713164),
        dec: Angle.Degrees(+63.50143453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30442"},
        {"Hipparcos Number", "HIP 22626"},
        {"Fundamental Katalog 5th Edition", "FK5 2362"},
        {"Geneva Identification System", "GEN# +1.00030442"},
        {"Smithsonian Astrophysical Observation", "SAO 13291"},
        {"Wilson Evans Batten Catalogue", "WEB 4377"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.02153945),
        dec: Angle.Degrees(+63.50564999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26358"},
        {"Smithsonian Astrophysical Observation", "SAO 13546"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.20295060),
        dec: Angle.Degrees(+63.50849470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187445"},
        {"Hipparcos Number", "HIP 97267"},
        {"Geneva Identification System", "GEN# +1.00187445"},
        {"Smithsonian Astrophysical Observation", "SAO 18518"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.52427489),
        dec: Angle.Degrees(+63.50864216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108902"},
        {"Smithsonian Astrophysical Observation", "SAO 19822"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.89795402),
        dec: Angle.Degrees(+63.50878538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9458"},
    },
    visualMagnitude: 12.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.41724340),
        dec: Angle.Degrees(+63.51117561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45075",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7211 A"},
        {"Henry Draper", "HD 78362"},
        {"Henry Draper 2", "HD 78363"},
        {"Hipparcos Number", "HIP 45075"},
        {"Fundamental Katalog 5th Edition", "FK5 2727"},
        {"Geneva Identification System", "GEN# +1.00078362"},
        {"Renson", "Renson 22190"},
        {"Smithsonian Astrophysical Observation", "SAO 14796"},
        {"Wilson Evans Batten Catalogue", "WEB 8602"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.72887992),
        dec: Angle.Degrees(+63.51378087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5353"},
        {"Cincinnati Publication", "Ci 20 78"},
        {"Geneva Identification System", "GEN# +9.80243062"},
    },
    visualMagnitude: 11.52,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.10751906),
        dec: Angle.Degrees(+63.51587592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1047.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36420"},
        {"Hipparcos Number", "HIP 26297"},
        {"Geneva Identification System", "GEN# +1.00036420"},
        {"Smithsonian Astrophysical Observation", "SAO 13544"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.00473067),
        dec: Angle.Degrees(+63.51904518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98229"},
        {"Hipparcos Number", "HIP 55242"},
        {"Smithsonian Astrophysical Observation", "SAO 15471"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.69938980),
        dec: Angle.Degrees(+63.52127241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213631"},
        {"Hipparcos Number", "HIP 111166"},
        {"Smithsonian Astrophysical Observation", "SAO 20124"},
        {"Wilson Evans Batten Catalogue", "WEB 19895"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.81574901),
        dec: Angle.Degrees(+63.52264963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35416",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5948 AB"},
        {"Hipparcos Number", "HIP 35416"},
        {"Smithsonian Astrophysical Observation", "SAO 14144"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.67712743),
        dec: Angle.Degrees(+63.52415659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112338"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.31537834),
        dec: Angle.Degrees(+63.52424222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192512"},
        {"Hipparcos Number", "HIP 99506"},
        {"Smithsonian Astrophysical Observation", "SAO 18752"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.91397207),
        dec: Angle.Degrees(+63.52742041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153397"},
        {"Hipparcos Number", "HIP 82796"},
        {"Smithsonian Astrophysical Observation", "SAO 17276"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.80629097),
        dec: Angle.Degrees(+63.52815061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120314"},
        {"Hipparcos Number", "HIP 67238"},
        {"Smithsonian Astrophysical Observation", "SAO 16173"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.68036389),
        dec: Angle.Degrees(+63.53083331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152124"},
        {"Hipparcos Number", "HIP 82166"},
        {"Smithsonian Astrophysical Observation", "SAO 17223"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.81642445),
        dec: Angle.Degrees(+63.53134814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11559 A"},
        {"Henry Draper", "HD 172923"},
        {"Hipparcos Number", "HIP 91396"},
        {"Smithsonian Astrophysical Observation", "SAO 17963"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.60101474),
        dec: Angle.Degrees(+63.53282696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82797"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.80707679),
        dec: Angle.Degrees(+63.53342774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189900"},
        {"Hipparcos Number", "HIP 98308"},
        {"Geneva Identification System", "GEN# +1.00189900"},
        {"Smithsonian Astrophysical Observation", "SAO 18627"},
        {"Wilson Evans Batten Catalogue", "WEB 17340"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.61974056),
        dec: Angle.Degrees(+63.53420204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108897"},
        {"Celescope Catalog", "CEL 5428"},
        {"Geneva Identification System", "GEN# +0.06202023"},
        {"Smithsonian Astrophysical Observation", "SAO 19821"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.87906753),
        dec: Angle.Degrees(+63.53459149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14617"},
        {"Hipparcos Number", "HIP 11210"},
        {"Geneva Identification System", "GEN# +1.00014617"},
        {"Smithsonian Astrophysical Observation", "SAO 12267"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.07817099),
        dec: Angle.Degrees(+63.53651174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11559 B"},
        {"Hipparcos Number", "HIP 91393"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.59712218),
        dec: Angle.Degrees(+63.53717201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39856"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.13676700),
        dec: Angle.Degrees(+63.53922054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31422"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76802366),
        dec: Angle.Degrees(+63.54185206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98613"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.44114141),
        dec: Angle.Degrees(+63.54462615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7709"},
        {"Hipparcos Number", "HIP 6105"},
        {"Smithsonian Astrophysical Observation", "SAO 11683"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.59547574),
        dec: Angle.Degrees(+63.54502151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13809"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44786629),
        dec: Angle.Degrees(+63.54693228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49229"},
        {"Smithsonian Astrophysical Observation", "SAO 15056"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.73374840),
        dec: Angle.Degrees(+63.54847490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217979"},
        {"Hipparcos Number", "HIP 113849"},
        {"Celescope Catalog", "CEL 5562"},
        {"Geneva Identification System", "GEN# +9.00020068"},
        {"Smithsonian Astrophysical Observation", "SAO 20395"},
        {"Wilson Evans Batten Catalogue", "WEB 20223"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.83388174),
        dec: Angle.Degrees(+63.55055074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94176"},
        {"Hipparcos Number", "HIP 53256"},
        {"Smithsonian Astrophysical Observation", "SAO 15321"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.37846371),
        dec: Angle.Degrees(+63.55122614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165168"},
        {"Hipparcos Number", "HIP 88150"},
        {"Smithsonian Astrophysical Observation", "SAO 17724"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06643200),
        dec: Angle.Degrees(+63.55140350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1238"},
        {"Hipparcos Number", "HIP 1355"},
        {"Geneva Identification System", "GEN# +1.00001238"},
        {"Smithsonian Astrophysical Observation", "SAO 11083"},
        {"Wilson Evans Batten Catalogue", "WEB 244"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.23899401),
        dec: Angle.Degrees(+63.55298365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40751"},
        {"Smithsonian Astrophysical Observation", "SAO 14497"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78243326),
        dec: Angle.Degrees(+63.56219240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35541"},
        {"Hipparcos Number", "HIP 25754"},
        {"Smithsonian Astrophysical Observation", "SAO 13514"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.49233059),
        dec: Angle.Degrees(+63.56287855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65041"},
        {"Smithsonian Astrophysical Observation", "SAO 16045"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.98430799),
        dec: Angle.Degrees(+63.56765441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212730"},
        {"Hipparcos Number", "HIP 110634"},
        {"Smithsonian Astrophysical Observation", "SAO 20051"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.17215001),
        dec: Angle.Degrees(+63.57037724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149411"},
        {"Hipparcos Number", "HIP 80836"},
        {"Geneva Identification System", "GEN# +1.00149411"},
        {"Smithsonian Astrophysical Observation", "SAO 17118"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.61807800),
        dec: Angle.Degrees(+63.57072683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1522"},
        {"Geneva Identification System", "GEN# +0.06200049"},
        {"Smithsonian Astrophysical Observation", "SAO 11102"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.74120595),
        dec: Angle.Degrees(+63.57199558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99719"},
        {"Hipparcos Number", "HIP 56031"},
        {"Geneva Identification System", "GEN# +1.00099719"},
        {"Smithsonian Astrophysical Observation", "SAO 15518"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.25659210),
        dec: Angle.Degrees(+63.57340468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90329"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.45720232),
        dec: Angle.Degrees(+63.57722439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210011"},
        {"Hipparcos Number", "HIP 109029"},
        {"Geneva Identification System", "GEN# +1.00210011"},
        {"Smithsonian Astrophysical Observation", "SAO 19851"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30773465),
        dec: Angle.Degrees(+63.57841444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214904"},
        {"Hipparcos Number", "HIP 111896"},
        {"Smithsonian Astrophysical Observation", "SAO 20196"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.99111755),
        dec: Angle.Degrees(+63.57973613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214734"},
        {"Hipparcos Number", "HIP 111797"},
        {"Fundamental Katalog 5th Edition", "FK5 853"},
        {"Geneva Identification System", "GEN# +1.00214734"},
        {"Smithsonian Astrophysical Observation", "SAO 20190"},
        {"Wilson Evans Batten Catalogue", "WEB 19969"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.66272750),
        dec: Angle.Degrees(+63.58452120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204598"},
        {"Hipparcos Number", "HIP 105903"},
        {"Smithsonian Astrophysical Observation", "SAO 19413"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.73095693),
        dec: Angle.Degrees(+63.58586071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91543"},
        {"Hipparcos Number", "HIP 51876"},
        {"Smithsonian Astrophysical Observation", "SAO 15234"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.98184279),
        dec: Angle.Degrees(+63.59235978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9250"},
        {"Hipparcos Number", "HIP 7192"},
        {"Geneva Identification System", "GEN# +1.00009250"},
        {"Smithsonian Astrophysical Observation", "SAO 11813"},
        {"Wilson Evans Batten Catalogue", "WEB 1550"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.18010782),
        dec: Angle.Degrees(+63.59380573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8492"},
        {"Hipparcos Number", "HIP 6665"},
        {"Geneva Identification System", "GEN# +1.00008492"},
        {"Smithsonian Astrophysical Observation", "SAO 11749"},
        {"Wilson Evans Batten Catalogue", "WEB 1453"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.38185358),
        dec: Angle.Degrees(+63.59385165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24108",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3723 A"},
        {"Henry Draper", "HD 32893"},
        {"Henry Draper 2", "HD 32893A"},
        {"Hipparcos Number", "HIP 24108"},
        {"Geneva Identification System", "GEN# +1.00032893"},
        {"Renson", "Renson 8390"},
        {"Smithsonian Astrophysical Observation", "SAO 13394"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.67771986),
        dec: Angle.Degrees(+63.59741025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13111"},
        {"Hipparcos Number", "HIP 10160"},
        {"Geneva Identification System", "GEN# +1.00013111"},
        {"Smithsonian Astrophysical Observation", "SAO 12154"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.66518679),
        dec: Angle.Degrees(+63.59834880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38058"},
        {"Hipparcos Number", "HIP 27346"},
        {"Geneva Identification System", "GEN# +1.00038058"},
        {"Smithsonian Astrophysical Observation", "SAO 13608"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.88439682),
        dec: Angle.Degrees(+63.59880015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167894"},
        {"Hipparcos Number", "HIP 89254"},
        {"Smithsonian Astrophysical Observation", "SAO 17816"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.21044368),
        dec: Angle.Degrees(+63.60026369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46684"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.75680090),
        dec: Angle.Degrees(+63.60436082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5915"},
        {"Hipparcos Number", "HIP 4816"},
        {"Geneva Identification System", "GEN# +1.00005915"},
        {"Smithsonian Astrophysical Observation", "SAO 11533"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.45319388),
        dec: Angle.Degrees(+63.60566086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19661"},
        {"Hipparcos Number", "HIP 14998"},
        {"Geneva Identification System", "GEN# +1.00019661"},
        {"Smithsonian Astrophysical Observation", "SAO 12660"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.33830573),
        dec: Angle.Degrees(+63.60800120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68596"},
        {"Smithsonian Astrophysical Observation", "SAO 16257"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63528762),
        dec: Angle.Degrees(+63.60977478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113337"},
        {"Hipparcos Number", "HIP 63584"},
        {"Geneva Identification System", "GEN# +1.00113337"},
        {"Smithsonian Astrophysical Observation", "SAO 15962"},
        {"Wilson Evans Batten Catalogue", "WEB 11252"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.44646690),
        dec: Angle.Degrees(+63.61016308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10586"},
        {"Smithsonian Astrophysical Observation", "SAO 12197"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.07573586),
        dec: Angle.Degrees(+63.61249714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95955",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12577 AB"},
        {"Hipparcos Number", "HIP 95955"},
        {"Smithsonian Astrophysical Observation", "SAO 18375"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.69819537),
        dec: Angle.Degrees(+63.61785814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34641"},
        {"Smithsonian Astrophysical Observation", "SAO 14103"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62448690),
        dec: Angle.Degrees(+63.61931355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115476"},
        {"Hipparcos Number", "HIP 64728"},
        {"Geneva Identification System", "GEN# +1.00115476"},
        {"Smithsonian Astrophysical Observation", "SAO 16027"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01064256),
        dec: Angle.Degrees(+63.61998925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135437"},
        {"Hipparcos Number", "HIP 74355"},
        {"Smithsonian Astrophysical Observation", "SAO 16637"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.93521601),
        dec: Angle.Degrees(+63.62195730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72038"},
        {"Hipparcos Number", "HIP 42045"},
        {"Smithsonian Astrophysical Observation", "SAO 14589"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.55081023),
        dec: Angle.Degrees(+63.62269155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30244"},
        {"Hipparcos Number", "HIP 22476"},
        {"Smithsonian Astrophysical Observation", "SAO 13283"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.54175879),
        dec: Angle.Degrees(+63.62553346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208816"},
        {"Hipparcos Number", "HIP 108317"},
        {"Fundamental Katalog 5th Edition", "FK5 3756"},
        {"Geneva Identification System", "GEN# +1.00208816J"},
        {"Smithsonian Astrophysical Observation", "SAO 19753"},
        {"Wilson Evans Batten Catalogue", "WEB 19512"},
    },
    visualMagnitude: 5.11,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.16310055),
        dec: Angle.Degrees(+63.62556651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20637"},
        {"Smithsonian Astrophysical Observation", "SAO 13137"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.34518549),
        dec: Angle.Degrees(+63.62630546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106811"},
        {"Hipparcos Number", "HIP 59866"},
        {"Cincinnati Publication", "Ci 18 1536"},
        {"Geneva Identification System", "GEN# +1.00106811"},
        {"Smithsonian Astrophysical Observation", "SAO 15754"},
        {"Wilson Evans Batten Catalogue", "WEB 10639"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.16144904),
        dec: Angle.Degrees(+63.62953018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16530 AB"},
        {"Henry Draper", "HD 218537"},
        {"Hipparcos Number", "HIP 114212"},
        {"Celescope Catalog", "CEL 5566"},
        {"Geneva Identification System", "GEN# +9.00020079"},
        {"Smithsonian Astrophysical Observation", "SAO 20439"},
        {"Wilson Evans Batten Catalogue", "WEB 20284"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.94890429),
        dec: Angle.Degrees(+63.63347090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15850"},
        {"Hipparcos Number", "HIP 12081"},
        {"Geneva Identification System", "GEN# +1.00015850"},
        {"Smithsonian Astrophysical Observation", "SAO 12347"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92869504),
        dec: Angle.Degrees(+63.63489123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44349"},
        {"Hipparcos Number", "HIP 30603"},
        {"Geneva Identification System", "GEN# +1.00044349"},
        {"Smithsonian Astrophysical Observation", "SAO 13833"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.47919257),
        dec: Angle.Degrees(+63.64020567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225094"},
        {"Hipparcos Number", "HIP 274"},
        {"Celescope Catalog", "CEL 5"},
        {"Geneva Identification System", "GEN# +1.00225094"},
        {"Smithsonian Astrophysical Observation", "SAO 10942"},
        {"Wilson Evans Batten Catalogue", "WEB 42"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85715406),
        dec: Angle.Degrees(+63.64052431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100534"},
        {"Hipparcos Number", "HIP 56469"},
        {"Smithsonian Astrophysical Observation", "SAO 15556"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.66556429),
        dec: Angle.Degrees(+63.64333742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34425"},
        {"Smithsonian Astrophysical Observation", "SAO 14080"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.04697622),
        dec: Angle.Degrees(+63.64521539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103001"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.01817314),
        dec: Angle.Degrees(+63.64566996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17707"},
        {"Hipparcos Number", "HIP 13471"},
        {"Geneva Identification System", "GEN# +1.00017707"},
        {"Smithsonian Astrophysical Observation", "SAO 12492"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.37558897),
        dec: Angle.Degrees(+63.64623772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56472"},
    },
    visualMagnitude: 11.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.67397147),
        dec: Angle.Degrees(+63.64704924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135466"},
        {"Hipparcos Number", "HIP 74372"},
        {"Smithsonian Astrophysical Observation", "SAO 16638"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.97122360),
        dec: Angle.Degrees(+63.65326491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84179A"},
        {"Henry Draper 2", "HD 84179"},
        {"Hipparcos Number", "HIP 47911"},
        {"Geneva Identification System", "GEN# +1.00084179"},
        {"Smithsonian Astrophysical Observation", "SAO 14980"},
        {"Wilson Evans Batten Catalogue", "WEB 8961"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.48077015),
        dec: Angle.Degrees(+63.65341732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10755"},
        {"Hipparcos Number", "HIP 8307"},
        {"Smithsonian Astrophysical Observation", "SAO 11979"},
        {"Wilson Evans Batten Catalogue", "WEB 1769"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.78958344),
        dec: Angle.Degrees(+63.65383363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53698"},
        {"Smithsonian Astrophysical Observation", "SAO 15356"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.80223558),
        dec: Angle.Degrees(+63.66655873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29741"},
        {"Hipparcos Number", "HIP 22098"},
        {"Smithsonian Astrophysical Observation", "SAO 13252"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.32965988),
        dec: Angle.Degrees(+63.66731377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1625"},
        {"Hipparcos Number", "HIP 1673"},
        {"Smithsonian Astrophysical Observation", "SAO 11125"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.23346296),
        dec: Angle.Degrees(+63.66753423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88617"},
        {"Smithsonian Astrophysical Observation", "SAO 17757"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.39832750),
        dec: Angle.Degrees(+63.66833723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 248.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102443"},
        {"Hipparcos Number", "HIP 57549"},
        {"Smithsonian Astrophysical Observation", "SAO 15635"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.93657459),
        dec: Angle.Degrees(+63.66835407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8886",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Segin"},
        {"Henry Draper", "HD 11415"},
        {"Hipparcos Number", "HIP 8886"},
        {"Celescope Catalog", "CEL 178"},
        {"Fundamental Katalog 5th Edition", "FK5 63"},
        {"Geneva Identification System", "GEN# +1.00011415"},
        {"Renson", "Renson 2870"},
        {"Smithsonian Astrophysical Observation", "SAO 12031"},
        {"Wilson Evans Batten Catalogue", "WEB 1868"},
    },
    visualMagnitude: 3.35,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.59868107),
        dec: Angle.Degrees(+63.67014686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107414"},
        {"Hipparcos Number", "HIP 60192"},
        {"Geneva Identification System", "GEN# +1.00107414"},
        {"Smithsonian Astrophysical Observation", "SAO 15776"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.14928085),
        dec: Angle.Degrees(+63.67026763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27635"},
        {"Hipparcos Number", "HIP 20669"},
        {"Smithsonian Astrophysical Observation", "SAO 13138"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41773000),
        dec: Angle.Degrees(+63.67485336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10728 AB"},
        {"Henry Draper", "HD 161285"},
        {"Hipparcos Number", "HIP 86482"},
        {"Smithsonian Astrophysical Observation", "SAO 17599"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.07536364),
        dec: Angle.Degrees(+63.67501055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51495"},
        {"Hipparcos Number", "HIP 33880"},
        {"Fundamental Katalog 5th Edition", "FK5 2542"},
        {"Geneva Identification System", "GEN# +1.00051495"},
        {"Smithsonian Astrophysical Observation", "SAO 14049"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48723236),
        dec: Angle.Degrees(+63.67697004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15647"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.35405225),
        dec: Angle.Degrees(+63.67932338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108"},
        {"Hipparcos Number", "HIP 505"},
        {"Celescope Catalog", "CEL 15"},
        {"Geneva Identification System", "GEN# +1.00000108"},
        {"Smithsonian Astrophysical Observation", "SAO 10973"},
        {"Wilson Evans Batten Catalogue", "WEB 83"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.51413834),
        dec: Angle.Degrees(+63.67965857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200678"},
        {"Hipparcos Number", "HIP 103765"},
        {"Smithsonian Astrophysical Observation", "SAO 19155"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.40818055),
        dec: Angle.Degrees(+63.68583184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116697"},
        {"Smithsonian Astrophysical Observation", "SAO 20746"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.72487978),
        dec: Angle.Degrees(+63.68736078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6129"},
        {"Hipparcos Number", "HIP 4963"},
        {"Geneva Identification System", "GEN# +1.00006129J"},
        {"Smithsonian Astrophysical Observation", "SAO 11549"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.90490075),
        dec: Angle.Degrees(+63.68778240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17159"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.12476663),
        dec: Angle.Degrees(+63.69004341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27464"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)48, 58.2300),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)41, 48.300)
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
    primaryId: "HIP 91115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11503 A"},
        {"Henry Draper", "HD 172323"},
        {"Hipparcos Number", "HIP 91115"},
        {"Geneva Identification System", "GEN# +1.00172323A"},
        {"Smithsonian Astrophysical Observation", "SAO 17936"},
        {"Wilson Evans Batten Catalogue", "WEB 15642"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.78921927),
        dec: Angle.Degrees(+63.69700715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217919"},
        {"Hipparcos Number", "HIP 113825"},
        {"Geneva Identification System", "GEN# +9.00020066"},
        {"Renson", "Renson 60080"},
        {"Smithsonian Astrophysical Observation", "SAO 20390"},
        {"Wilson Evans Batten Catalogue", "WEB 20220"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.75612006),
        dec: Angle.Degrees(+63.69815796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205947"},
        {"Hipparcos Number", "HIP 106648"},
        {"Smithsonian Astrophysical Observation", "SAO 19525"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.03844243),
        dec: Angle.Degrees(+63.70092538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108275"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.03399493),
        dec: Angle.Degrees(+63.70417284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13392 AB"},
        {"Henry Draper", "HD 191310"},
        {"Hipparcos Number", "HIP 98967"},
        {"Smithsonian Astrophysical Observation", "SAO 18703"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.39583512),
        dec: Angle.Degrees(+63.70491674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217297"},
        {"Hipparcos Number", "HIP 113443"},
        {"Celescope Catalog", "CEL 5552"},
        {"Geneva Identification System", "GEN# +9.00020047"},
        {"Smithsonian Astrophysical Observation", "SAO 20349"},
        {"Wilson Evans Batten Catalogue", "WEB 20174"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.63855556),
        dec: Angle.Degrees(+63.70675124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191564"},
        {"Hipparcos Number", "HIP 99069"},
        {"Geneva Identification System", "GEN# +1.00191564"},
        {"Smithsonian Astrophysical Observation", "SAO 18716"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69273678),
        dec: Angle.Degrees(+63.70681056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36747"},
        {"Smithsonian Astrophysical Observation", "SAO 14232"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.36916729),
        dec: Angle.Degrees(+63.70740091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90928"},
        {"Smithsonian Astrophysical Observation", "SAO 17923"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.22424163),
        dec: Angle.Degrees(+63.70916437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211642"},
        {"Hipparcos Number", "HIP 109981"},
        {"Geneva Identification System", "GEN# +1.00211642"},
        {"Smithsonian Astrophysical Observation", "SAO 19973"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.13449951),
        dec: Angle.Degrees(+63.71239888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5551"},
        {"Hipparcos Number", "HIP 4567"},
        {"Geneva Identification System", "GEN# +1.00005551"},
        {"Smithsonian Astrophysical Observation", "SAO 11503"},
        {"Wilson Evans Batten Catalogue", "WEB 835"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.61181566),
        dec: Angle.Degrees(+63.71362247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1276 AB"},
        {"Henry Draper", "HD 9911"},
        {"Hipparcos Number", "HIP 7670"},
        {"Geneva Identification System", "GEN# +1.00009911"},
        {"Wilson Evans Batten Catalogue", "WEB 1638"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.69424288),
        dec: Angle.Degrees(+63.71664650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213023"},
        {"Hipparcos Number", "HIP 110799"},
        {"Geneva Identification System", "GEN# +1.00213023"},
        {"Smithsonian Astrophysical Observation", "SAO 20071"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.71818836),
        dec: Angle.Degrees(+63.71803917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216173"},
        {"Hipparcos Number", "HIP 112691"},
        {"Geneva Identification System", "GEN# +1.00216173"},
        {"Smithsonian Astrophysical Observation", "SAO 20262"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.31851621),
        dec: Angle.Degrees(+63.71835370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119943"},
        {"Hipparcos Number", "HIP 67045"},
        {"Smithsonian Astrophysical Observation", "SAO 16158"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.10313507),
        dec: Angle.Degrees(+63.71839268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206913"},
        {"Hipparcos Number", "HIP 107191"},
        {"Geneva Identification System", "GEN# +1.00206913"},
        {"Smithsonian Astrophysical Observation", "SAO 19595"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66899426),
        dec: Angle.Degrees(+63.72156423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6312"},
        {"Hipparcos Number", "HIP 5106"},
        {"Geneva Identification System", "GEN# +1.00006312"},
        {"Smithsonian Astrophysical Observation", "SAO 11561"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.35911959),
        dec: Angle.Degrees(+63.72169242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157462"},
        {"Hipparcos Number", "HIP 84705"},
        {"Smithsonian Astrophysical Observation", "SAO 17427"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.72806729),
        dec: Angle.Degrees(+63.72271602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8261"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.60059518),
        dec: Angle.Degrees(+63.72285836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50680"},
        {"Smithsonian Astrophysical Observation", "SAO 15148"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.23693568),
        dec: Angle.Degrees(+63.72427117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72410"},
        {"Smithsonian Astrophysical Observation", "SAO 16509"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.08943690),
        dec: Angle.Degrees(+63.72509420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16911 AB"},
        {"Henry Draper", "HD 222407"},
        {"Hipparcos Number", "HIP 116765"},
        {"Celescope Catalog", "CEL 5646"},
        {"Geneva Identification System", "GEN# +1.00222407J"},
        {"Smithsonian Astrophysical Observation", "SAO 20756"},
        {"Wilson Evans Batten Catalogue", "WEB 20605"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.97027373),
        dec: Angle.Degrees(+63.72543995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68481"},
        {"Hipparcos Number", "HIP 40517"},
        {"Geneva Identification System", "GEN# +1.00068481"},
        {"Smithsonian Astrophysical Observation", "SAO 14480"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.09319858),
        dec: Angle.Degrees(+63.73017686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35186"},
        {"Smithsonian Astrophysical Observation", "SAO 14132"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.07985514),
        dec: Angle.Degrees(+63.73396221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185977"},
        {"Hipparcos Number", "HIP 96543"},
        {"Smithsonian Astrophysical Observation", "SAO 18441"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.41115960),
        dec: Angle.Degrees(+63.73443370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2232",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 371 AB"},
        {"Hipparcos Number", "HIP 2232"},
        {"Smithsonian Astrophysical Observation", "SAO 11215"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.07081540),
        dec: Angle.Degrees(+63.73495256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210386"},
        {"Hipparcos Number", "HIP 109253"},
        {"Geneva Identification System", "GEN# +1.00210386"},
        {"Smithsonian Astrophysical Observation", "SAO 19878"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.00118275),
        dec: Angle.Degrees(+63.73555825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142612"},
        {"Hipparcos Number", "HIP 77687"},
        {"Smithsonian Astrophysical Observation", "SAO 16877"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.90805275),
        dec: Angle.Degrees(+63.73622265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208439"},
        {"Hipparcos Number", "HIP 108083"},
        {"Celescope Catalog", "CEL 5404"},
        {"Geneva Identification System", "GEN# +1.00208439"},
        {"Smithsonian Astrophysical Observation", "SAO 19721"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.47418490),
        dec: Angle.Degrees(+63.73718941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223578"},
        {"Hipparcos Number", "HIP 117553"},
        {"Smithsonian Astrophysical Observation", "SAO 20887"},
        {"Wilson Evans Batten Catalogue", "WEB 20700"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.60184490),
        dec: Angle.Degrees(+63.74363288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214502"},
        {"Hipparcos Number", "HIP 111639"},
        {"Geneva Identification System", "GEN# +1.00214502"},
        {"Smithsonian Astrophysical Observation", "SAO 20177"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.23845994),
        dec: Angle.Degrees(+63.74478009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25453"},
        {"Hipparcos Number", "HIP 19161"},
        {"Smithsonian Astrophysical Observation", "SAO 13018"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.62985334),
        dec: Angle.Degrees(+63.74566952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104802"},
        {"Smithsonian Astrophysical Observation", "SAO 19259"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.47790529),
        dec: Angle.Degrees(+63.74604647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205653"},
        {"Hipparcos Number", "HIP 106491"},
        {"Smithsonian Astrophysical Observation", "SAO 19501"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.54419281),
        dec: Angle.Degrees(+63.75109179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87834"},
        {"Hipparcos Number", "HIP 49800"},
        {"Smithsonian Astrophysical Observation", "SAO 15103"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.48334757),
        dec: Angle.Degrees(+63.75461307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14317"},
        {"Smithsonian Astrophysical Observation", "SAO 12590"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.16719689),
        dec: Angle.Degrees(+63.75731076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109155"},
        {"Hipparcos Number", "HIP 61164"},
        {"Geneva Identification System", "GEN# +1.00109155"},
        {"Smithsonian Astrophysical Observation", "SAO 15823"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.00177458),
        dec: Angle.Degrees(+63.75807597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43745"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.64979503),
        dec: Angle.Degrees(+63.75869607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85125"},
        {"Smithsonian Astrophysical Observation", "SAO 17462"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95421002),
        dec: Angle.Degrees(+63.76240104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18800"},
        {"Hipparcos Number", "HIP 14316"},
        {"Smithsonian Astrophysical Observation", "SAO 12589"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.16272929),
        dec: Angle.Degrees(+63.76305188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214584"},
        {"Hipparcos Number", "HIP 111701"},
        {"Smithsonian Astrophysical Observation", "SAO 20182"},
        {"Wilson Evans Batten Catalogue", "WEB 19961"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.41201317),
        dec: Angle.Degrees(+63.76932448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31696"},
        {"Hipparcos Number", "HIP 23440"},
        {"Smithsonian Astrophysical Observation", "SAO 13343"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.57880027),
        dec: Angle.Degrees(+63.77013299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110345"},
        {"Hipparcos Number", "HIP 61875"},
        {"Geneva Identification System", "GEN# +1.00110345"},
        {"Smithsonian Astrophysical Observation", "SAO 15866"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20312940),
        dec: Angle.Degrees(+63.77141456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190162"},
        {"Hipparcos Number", "HIP 98419"},
        {"Geneva Identification System", "GEN# +1.00190162"},
        {"Smithsonian Astrophysical Observation", "SAO 18645"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.95641302),
        dec: Angle.Degrees(+63.77252062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66036"},
        {"Smithsonian Astrophysical Observation", "SAO 16102"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.07734531),
        dec: Angle.Degrees(+63.77315014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6474"},
        {"Hipparcos Number", "HIP 5239"},
        {"Geneva Identification System", "GEN# +1.00006474"},
        {"Smithsonian Astrophysical Observation", "SAO 11581"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.74893006),
        dec: Angle.Degrees(+63.77316534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159428"},
        {"Hipparcos Number", "HIP 85657"},
        {"Smithsonian Astrophysical Observation", "SAO 17509"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.58201194),
        dec: Angle.Degrees(+63.77744117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201478"},
        {"Hipparcos Number", "HIP 104218"},
        {"Smithsonian Astrophysical Observation", "SAO 19200"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71693679),
        dec: Angle.Degrees(+63.77844037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202250"},
        {"Hipparcos Number", "HIP 104628"},
        {"Smithsonian Astrophysical Observation", "SAO 19241"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.91217163),
        dec: Angle.Degrees(+63.78034991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4841"},
        {"Hipparcos Number", "HIP 4006"},
        {"Geneva Identification System", "GEN# +1.00004841"},
        {"Smithsonian Astrophysical Observation", "SAO 11433"},
        {"Wilson Evans Batten Catalogue", "WEB 713"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.85804247),
        dec: Angle.Degrees(+63.78117106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14206"},
        {"Smithsonian Astrophysical Observation", "SAO 12576"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.79669901),
        dec: Angle.Degrees(+63.78144556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19440"},
        {"Hipparcos Number", "HIP 14780"},
        {"Smithsonian Astrophysical Observation", "SAO 12635"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.70928497),
        dec: Angle.Degrees(+63.78785795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114958"},
        {"Geneva Identification System", "GEN# +0.06301962"},
        {"Smithsonian Astrophysical Observation", "SAO 20534"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.26548308),
        dec: Angle.Degrees(+63.78940260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91467",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11575 A"},
        {"Henry Draper", "HD 173108"},
        {"Hipparcos Number", "HIP 91467"},
        {"Smithsonian Astrophysical Observation", "SAO 17965"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.82834642),
        dec: Angle.Degrees(+63.79214400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108040"},
        {"Hipparcos Number", "HIP 60516"},
        {"Smithsonian Astrophysical Observation", "SAO 15796"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.08400829),
        dec: Angle.Degrees(+63.79329053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68235"},
        {"Smithsonian Astrophysical Observation", "SAO 16233"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.53000192),
        dec: Angle.Degrees(+63.79405922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166091"},
        {"Hipparcos Number", "HIP 88518"},
        {"Geneva Identification System", "GEN# +1.00166091"},
        {"Smithsonian Astrophysical Observation", "SAO 17748"},
        {"Wilson Evans Batten Catalogue", "WEB 14983"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.14076981),
        dec: Angle.Degrees(+63.79619945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108150"},
        {"Hipparcos Number", "HIP 60589"},
        {"Fundamental Katalog 5th Edition", "FK5 2996"},
        {"Geneva Identification System", "GEN# +1.00108150"},
        {"Smithsonian Astrophysical Observation", "SAO 15801"},
        {"Wilson Evans Batten Catalogue", "WEB 10777"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.27659619),
        dec: Angle.Degrees(+63.80277456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69811"},
        {"Smithsonian Astrophysical Observation", "SAO 16325"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.30994437),
        dec: Angle.Degrees(+63.80705816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93551"},
        {"Hipparcos Number", "HIP 52929"},
        {"Smithsonian Astrophysical Observation", "SAO 15300"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.37007598),
        dec: Angle.Degrees(+63.81000057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151252"},
        {"Hipparcos Number", "HIP 81755"},
        {"Smithsonian Astrophysical Observation", "SAO 17193"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.47393531),
        dec: Angle.Degrees(+63.81541358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143433"},
        {"Hipparcos Number", "HIP 78063"},
        {"Geneva Identification System", "GEN# +1.00143433"},
        {"Smithsonian Astrophysical Observation", "SAO 16899"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.08429926),
        dec: Angle.Degrees(+63.81614005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21027"},
        {"Hipparcos Number", "HIP 16081"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.77781981),
        dec: Angle.Degrees(+63.81629097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112289"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.16465272),
        dec: Angle.Degrees(+63.81637203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117387",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17010 A"},
        {"Henry Draper", "HD 223288"},
        {"Hipparcos Number", "HIP 117387"},
        {"Celescope Catalog", "CEL 5677"},
        {"Geneva Identification System", "GEN# +1.00223288"},
        {"Smithsonian Astrophysical Observation", "SAO 20854"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.02609329),
        dec: Angle.Degrees(+63.81739501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213642"},
        {"Hipparcos Number", "HIP 111174"},
        {"Geneva Identification System", "GEN# +1.00213642"},
        {"Smithsonian Astrophysical Observation", "SAO 20126"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82930462),
        dec: Angle.Degrees(+63.81761677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16491"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.09015259),
        dec: Angle.Degrees(+63.81868979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118262"},
        {"Celescope Catalog", "CEL 5734"},
        {"Geneva Identification System", "GEN# +0.06302084"},
        {"Smithsonian Astrophysical Observation", "SAO 20976"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.80797391),
        dec: Angle.Degrees(+63.81954460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214111"},
        {"Hipparcos Number", "HIP 111431"},
        {"Geneva Identification System", "GEN# +1.00214111"},
        {"Smithsonian Astrophysical Observation", "SAO 20158"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.62811964),
        dec: Angle.Degrees(+63.81968802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7173"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.12169211),
        dec: Angle.Degrees(+63.82161879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103591"},
        {"Hipparcos Number", "HIP 58176"},
        {"Smithsonian Astrophysical Observation", "SAO 15659"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.97728627),
        dec: Angle.Degrees(+63.82214353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10436"},
        {"Hipparcos Number", "HIP 8070"},
        {"Cincinnati Publication", "Ci 18 238"},
        {"Cincinnati Publication 2", "Ci 20 121"},
        {"Geneva Identification System", "GEN# +1.00010436"},
        {"Smithsonian Astrophysical Observation", "SAO 11943"},
        {"Wilson Evans Batten Catalogue", "WEB 1726"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.92186046),
        dec: Angle.Degrees(+63.82481469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -581.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105087"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.32339604),
        dec: Angle.Degrees(+63.82957954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42906"},
        {"Smithsonian Astrophysical Observation", "SAO 14646"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.16389931),
        dec: Angle.Degrees(+63.82997052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143774"},
        {"Hipparcos Number", "HIP 78230"},
        {"Smithsonian Astrophysical Observation", "SAO 16906"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.61698332),
        dec: Angle.Degrees(+63.83085070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27184"},
        {"Hipparcos Number", "HIP 20364"},
        {"Smithsonian Astrophysical Observation", "SAO 13108"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.42299919),
        dec: Angle.Degrees(+63.83305862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32745"},
        {"Hipparcos Number", "HIP 24022"},
        {"Geneva Identification System", "GEN# +1.00032745"},
        {"Smithsonian Astrophysical Observation", "SAO 13389"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.44149722),
        dec: Angle.Degrees(+63.83335424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100575"},
        {"Hipparcos Number", "HIP 56512"},
        {"Smithsonian Astrophysical Observation", "SAO 15559"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.78346025),
        dec: Angle.Degrees(+63.83395267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40891"},
        {"Hipparcos Number", "HIP 28935"},
        {"Geneva Identification System", "GEN# +1.00040891"},
        {"Smithsonian Astrophysical Observation", "SAO 13714"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.60285003),
        dec: Angle.Degrees(+63.83590894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19304"},
        {"Smithsonian Astrophysical Observation", "SAO 13033"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.06858724),
        dec: Angle.Degrees(+63.83593530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19392"},
        {"Smithsonian Astrophysical Observation", "SAO 13041"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.30107217),
        dec: Angle.Degrees(+63.84270739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159329"},
        {"Hipparcos Number", "HIP 85620"},
        {"Fundamental Katalog 5th Edition", "FK5 5541"},
        {"Geneva Identification System", "GEN# +1.00159329"},
        {"Smithsonian Astrophysical Observation", "SAO 17504"},
        {"Wilson Evans Batten Catalogue", "WEB 14449"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43519980),
        dec: Angle.Degrees(+63.85309749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10780"},
        {"Hipparcos Number", "HIP 8362"},
        {"Cincinnati Publication", "Ci 20 127"},
        {"Geneva Identification System", "GEN# +1.00010780"},
        {"Smithsonian Astrophysical Observation", "SAO 11983"},
        {"Wilson Evans Batten Catalogue", "WEB 1776"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.93360110),
        dec: Angle.Degrees(+63.85310111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 582.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220638"},
        {"Hipparcos Number", "HIP 115569"},
        {"Geneva Identification System", "GEN# +1.00220638"},
        {"Smithsonian Astrophysical Observation", "SAO 20611"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.14984527),
        dec: Angle.Degrees(+63.85354360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73237"},
        {"Smithsonian Astrophysical Observation", "SAO 16559"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.51965913),
        dec: Angle.Degrees(+63.85609252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89545"},
        {"Hipparcos Number", "HIP 50762"},
        {"Smithsonian Astrophysical Observation", "SAO 15154"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.48911904),
        dec: Angle.Degrees(+63.85641604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187792"},
        {"Hipparcos Number", "HIP 97399"},
        {"Geneva Identification System", "GEN# +1.00187792"},
        {"Smithsonian Astrophysical Observation", "SAO 18536"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.94372078),
        dec: Angle.Degrees(+63.86030722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119390"},
        {"Hipparcos Number", "HIP 66769"},
        {"Smithsonian Astrophysical Observation", "SAO 16140"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.27884223),
        dec: Angle.Degrees(+63.86615812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159265"},
        {"Hipparcos Number", "HIP 85575"},
        {"Smithsonian Astrophysical Observation", "SAO 17500"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.31907203),
        dec: Angle.Degrees(+63.86957900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153265"},
        {"Hipparcos Number", "HIP 82681"},
        {"Smithsonian Astrophysical Observation", "SAO 17266"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51376807),
        dec: Angle.Degrees(+63.87058393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2650 A"},
        {"Henry Draper", "HD 22399"},
        {"Hipparcos Number", "HIP 17118"},
        {"Geneva Identification System", "GEN# +1.00022399A"},
        {"Smithsonian Astrophysical Observation", "SAO 12854"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.99435196),
        dec: Angle.Degrees(+63.87076052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135262"},
        {"Hipparcos Number", "HIP 74280"},
        {"Geneva Identification System", "GEN# +1.00135262"},
        {"Smithsonian Astrophysical Observation", "SAO 16628"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.70748207),
        dec: Angle.Degrees(+63.87393956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14217"},
        {"Hipparcos Number", "HIP 10919"},
        {"Smithsonian Astrophysical Observation", "SAO 12230"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.15237486),
        dec: Angle.Degrees(+63.87395223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58183"},
        {"Hipparcos Number", "HIP 36333"},
        {"Geneva Identification System", "GEN# +1.00058183"},
        {"Smithsonian Astrophysical Observation", "SAO 14208"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17727257),
        dec: Angle.Degrees(+63.87477711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67872"},
        {"Smithsonian Astrophysical Observation", "SAO 16210"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.52396245),
        dec: Angle.Degrees(+63.87488340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17126",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2650 BC"},
        {"Hipparcos Number", "HIP 17126"},
        {"Geneva Identification System", "GEN# +1.00022399J"},
        {"Smithsonian Astrophysical Observation", "SAO 12855"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.02169771),
        dec: Angle.Degrees(+63.87494842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90788"},
        {"Hipparcos Number", "HIP 51470"},
        {"Smithsonian Astrophysical Observation", "SAO 15203"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.70376409),
        dec: Angle.Degrees(+63.87719390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110774"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.63507240),
        dec: Angle.Degrees(+63.87867078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 208.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213908"},
        {"Hipparcos Number", "HIP 111316"},
        {"Smithsonian Astrophysical Observation", "SAO 20146"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.26760905),
        dec: Angle.Degrees(+63.87983790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62106"},
        {"Smithsonian Astrophysical Observation", "SAO 15882"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.92647396),
        dec: Angle.Degrees(+63.88122339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12222"},
        {"Smithsonian Astrophysical Observation", "SAO 12359"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.34399245),
        dec: Angle.Degrees(+63.88141737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6619"},
        {"Smithsonian Astrophysical Observation", "SAO 11744"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24426016),
        dec: Angle.Degrees(+63.88194356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105649"},
        {"Smithsonian Astrophysical Observation", "SAO 19379"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.98598778),
        dec: Angle.Degrees(+63.88322217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105439"},
        {"Hipparcos Number", "HIP 59190"},
        {"Smithsonian Astrophysical Observation", "SAO 15722"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.07909388),
        dec: Angle.Degrees(+63.88650719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21806"},
        {"Hipparcos Number", "HIP 16684"},
        {"Geneva Identification System", "GEN# +1.00021806"},
        {"Smithsonian Astrophysical Observation", "SAO 12820"},
        {"Wilson Evans Batten Catalogue", "WEB 3177"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.66061027),
        dec: Angle.Degrees(+63.88892907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61006"},
        {"Smithsonian Astrophysical Observation", "SAO 15815"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54852037),
        dec: Angle.Degrees(+63.88917440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98872",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13371 A"},
        {"Henry Draper", "HD 191174"},
        {"Hipparcos Number", "HIP 98872"},
        {"Geneva Identification System", "GEN# +1.00191174"},
        {"Smithsonian Astrophysical Observation", "SAO 18692"},
        {"Wilson Evans Batten Catalogue", "WEB 17548"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.18547823),
        dec: Angle.Degrees(+63.89011646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10304"},
        {"Hipparcos Number", "HIP 8001"},
        {"Smithsonian Astrophysical Observation", "SAO 11928"},
        {"Wilson Evans Batten Catalogue", "WEB 1714"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.68740184),
        dec: Angle.Degrees(+63.89102989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39300"},
        {"Hipparcos Number", "HIP 28093"},
        {"Smithsonian Astrophysical Observation", "SAO 13657"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.07559506),
        dec: Angle.Degrees(+63.90243401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48456"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.19262609),
        dec: Angle.Degrees(+63.90642289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9706 AB"},
        {"Henry Draper", "HD 139319"},
        {"Hipparcos Number", "HIP 76196"},
        {"Smithsonian Astrophysical Observation", "SAO 16767"},
        {"Wilson Evans Batten Catalogue", "WEB 12938"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.46268319),
        dec: Angle.Degrees(+63.90708686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3197"},
        {"Geneva Identification System", "GEN# +0.06300070"},
        {"Smithsonian Astrophysical Observation", "SAO 11325"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.18581843),
        dec: Angle.Degrees(+63.91667686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182075"},
        {"Hipparcos Number", "HIP 94897"},
        {"Smithsonian Astrophysical Observation", "SAO 18278"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.67094146),
        dec: Angle.Degrees(+63.92151247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 718 AB"},
        {"Henry Draper", "HD 4994"},
        {"Hipparcos Number", "HIP 4142"},
        {"Geneva Identification System", "GEN# +1.00004994J"},
        {"Smithsonian Astrophysical Observation", "SAO 11442"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.24250604),
        dec: Angle.Degrees(+63.92457132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90601"},
        {"Hipparcos Number", "HIP 51368"},
        {"Smithsonian Astrophysical Observation", "SAO 15193"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37682692),
        dec: Angle.Degrees(+63.92497789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114066"},
        {"Geneva Identification System", "GEN# +6.20030858"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.51923273),
        dec: Angle.Degrees(+63.92635285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112337"},
        {"Hipparcos Number", "HIP 63029"},
        {"Geneva Identification System", "GEN# +1.00112337"},
        {"Smithsonian Astrophysical Observation", "SAO 15938"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73863101),
        dec: Angle.Degrees(+63.92744190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220963"},
        {"Hipparcos Number", "HIP 115788"},
        {"Geneva Identification System", "GEN# +1.00220963"},
        {"Smithsonian Astrophysical Observation", "SAO 20641"},
        {"Wilson Evans Batten Catalogue", "WEB 20490"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85626519),
        dec: Angle.Degrees(+63.92934550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150099"},
        {"Hipparcos Number", "HIP 81167"},
        {"Smithsonian Astrophysical Observation", "SAO 17154"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.67170959),
        dec: Angle.Degrees(+63.93494469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5247"},
        {"Cincinnati Publication", "Ci 18 142"},
        {"Cincinnati Publication 2", "Ci 20 74"},
        {"Geneva Identification System", "GEN# +0.06300137"},
        {"Wilson Evans Batten Catalogue", "WEB 1100"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.77560068),
        dec: Angle.Degrees(+63.94055066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1548.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 319.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63183"},
        {"Hipparcos Number", "HIP 38371"},
        {"Smithsonian Astrophysical Observation", "SAO 14343"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.91988710),
        dec: Angle.Degrees(+63.94094228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80953"},
        {"Hipparcos Number", "HIP 46247"},
        {"Geneva Identification System", "GEN# +1.00080953"},
        {"Smithsonian Astrophysical Observation", "SAO 14875"},
        {"Wilson Evans Batten Catalogue", "WEB 8751"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.43411369),
        dec: Angle.Degrees(+63.94102589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5693"},
        {"Smithsonian Astrophysical Observation", "SAO 11639"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.31191362),
        dec: Angle.Degrees(+63.94632972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51637"},
        {"Hipparcos Number", "HIP 33956"},
        {"Smithsonian Astrophysical Observation", "SAO 14055"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.68123620),
        dec: Angle.Degrees(+63.94661689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71060"},
        {"Smithsonian Astrophysical Observation", "SAO 16415"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.97731971),
        dec: Angle.Degrees(+63.94662200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14037"},
        {"Hipparcos Number", "HIP 10792"},
        {"Smithsonian Astrophysical Observation", "SAO 12215"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.73758517),
        dec: Angle.Degrees(+63.94821134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6559"},
        {"Geneva Identification System", "GEN# +0.06300180"},
        {"Smithsonian Astrophysical Observation", "SAO 11739"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.07608731),
        dec: Angle.Degrees(+63.94988835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116342"},
        {"Hipparcos Number", "HIP 65184"},
        {"Smithsonian Astrophysical Observation", "SAO 16058"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.37950580),
        dec: Angle.Degrees(+63.95037227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87734"},
        {"Hipparcos Number", "HIP 49724"},
        {"Fundamental Katalog 5th Edition", "FK5 2815"},
        {"Geneva Identification System", "GEN# +1.00087734"},
        {"Smithsonian Astrophysical Observation", "SAO 15098"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28189636),
        dec: Angle.Degrees(+63.95242536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35606"},
        {"Hipparcos Number", "HIP 25800"},
        {"Smithsonian Astrophysical Observation", "SAO 13521"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.64810253),
        dec: Angle.Degrees(+63.95495109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213099"},
        {"Hipparcos Number", "HIP 110841"},
        {"Smithsonian Astrophysical Observation", "SAO 20079"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.83560339),
        dec: Angle.Degrees(+63.95627361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164964"},
        {"Hipparcos Number", "HIP 88053"},
        {"Smithsonian Astrophysical Observation", "SAO 17715"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76248765),
        dec: Angle.Degrees(+63.95766060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26894"},
        {"Hipparcos Number", "HIP 20154"},
        {"Geneva Identification System", "GEN# +1.00026894"},
        {"Smithsonian Astrophysical Observation", "SAO 13091"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.80104249),
        dec: Angle.Degrees(+63.95788915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19856"},
        {"Hipparcos Number", "HIP 15138"},
        {"Geneva Identification System", "GEN# +1.00019856"},
        {"Smithsonian Astrophysical Observation", "SAO 12669"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.78593103),
        dec: Angle.Degrees(+63.95823892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100357",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13769 A"},
        {"Henry Draper", "HD 194298"},
        {"Hipparcos Number", "HIP 100357"},
        {"Geneva Identification System", "GEN# +1.00194298J"},
        {"Smithsonian Astrophysical Observation", "SAO 18826"},
        {"Wilson Evans Batten Catalogue", "WEB 18109"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.29798654),
        dec: Angle.Degrees(+63.98008727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33151"},
        {"Smithsonian Astrophysical Observation", "SAO 13999"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53215300),
        dec: Angle.Degrees(+63.98154517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223624"},
        {"Hipparcos Number", "HIP 117602"},
        {"Celescope Catalog", "CEL 5693"},
        {"Geneva Identification System", "GEN# +1.00223624"},
        {"Smithsonian Astrophysical Observation", "SAO 20896"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.74691623),
        dec: Angle.Degrees(+63.98486218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126717"},
        {"Hipparcos Number", "HIP 70429"},
        {"Geneva Identification System", "GEN# +1.00126717"},
        {"Smithsonian Astrophysical Observation", "SAO 16369"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.11781329),
        dec: Angle.Degrees(+63.98497844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198413"},
        {"Hipparcos Number", "HIP 102544"},
        {"Geneva Identification System", "GEN# +1.00198413"},
        {"Smithsonian Astrophysical Observation", "SAO 19035"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.70512258),
        dec: Angle.Degrees(+63.98570165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92524"},
        {"Hipparcos Number", "HIP 52395"},
        {"Smithsonian Astrophysical Observation", "SAO 15267"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.64623245),
        dec: Angle.Degrees(+63.98634269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74996"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86574052),
        dec: Angle.Degrees(+63.98869573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64402"},
        {"Smithsonian Astrophysical Observation", "SAO 16010"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.99521160),
        dec: Angle.Degrees(+63.99033943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127661"},
        {"Hipparcos Number", "HIP 70887"},
        {"Smithsonian Astrophysical Observation", "SAO 16403"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.44298175),
        dec: Angle.Degrees(+63.99163600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70304"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77001675),
        dec: Angle.Degrees(+63.99314689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15527 ABC"},
        {"Henry Draper", "HD 209178"},
        {"Hipparcos Number", "HIP 108519"},
        {"Geneva Identification System", "GEN# +1.00209178"},
        {"Smithsonian Astrophysical Observation", "SAO 19777"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.76551131),
        dec: Angle.Degrees(+63.99869631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101117"},
        {"Smithsonian Astrophysical Observation", "SAO 18899"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.44690240),
        dec: Angle.Degrees(+64.00055134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15108 A"},
        {"Henry Draper", "HD 205664"},
        {"Hipparcos Number", "HIP 106493"},
        {"Smithsonian Astrophysical Observation", "SAO 19502"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.54834022),
        dec: Angle.Degrees(+64.00466154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204720"},
        {"Hipparcos Number", "HIP 105981"},
        {"Geneva Identification System", "GEN# +1.00204720"},
        {"Smithsonian Astrophysical Observation", "SAO 19425"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.96002866),
        dec: Angle.Degrees(+64.01374117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185976"},
        {"Hipparcos Number", "HIP 96540"},
        {"Smithsonian Astrophysical Observation", "SAO 18440"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.40102922),
        dec: Angle.Degrees(+64.01676032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8315"},
    },
    visualMagnitude: 11.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.80699335),
        dec: Angle.Degrees(+64.02091368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15396 AB"},
        {"Henry Draper", "HD 208036"},
        {"Hipparcos Number", "HIP 107862"},
        {"Smithsonian Astrophysical Observation", "SAO 19679"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.78701094),
        dec: Angle.Degrees(+64.02167607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13590"},
        {"Hipparcos Number", "HIP 10486"},
        {"Geneva Identification System", "GEN# +1.00013590"},
        {"Smithsonian Astrophysical Observation", "SAO 12188"},
        {"Wilson Evans Batten Catalogue", "WEB 2200"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.80404191),
        dec: Angle.Degrees(+64.02445541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154711"},
        {"Hipparcos Number", "HIP 83401"},
        {"Geneva Identification System", "GEN# +1.00154711"},
        {"Smithsonian Astrophysical Observation", "SAO 17328"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.68086998),
        dec: Angle.Degrees(+64.02677832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45510"},
        {"Hipparcos Number", "HIP 31176"},
        {"Smithsonian Astrophysical Observation", "SAO 13872"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.12625589),
        dec: Angle.Degrees(+64.02707746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60398"},
        {"Cincinnati Publication", "Ci 20 701"},
        {"Geneva Identification System", "GEN# +6.10010463"},
        {"Wilson Evans Batten Catalogue", "WEB 10742"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.75439425),
        dec: Angle.Degrees(+64.02991823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -667.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 375.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186814"},
        {"Hipparcos Number", "HIP 96963"},
        {"Geneva Identification System", "GEN# +1.00186814"},
        {"Smithsonian Astrophysical Observation", "SAO 18490"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64649337),
        dec: Angle.Degrees(+64.03007367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157222"},
        {"Hipparcos Number", "HIP 84602"},
        {"Geneva Identification System", "GEN# +1.00157222"},
        {"Smithsonian Astrophysical Observation", "SAO 17422"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.40761593),
        dec: Angle.Degrees(+64.03305339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67708"},
        {"Hipparcos Number", "HIP 40249"},
        {"Geneva Identification System", "GEN# +1.00067708"},
        {"Smithsonian Astrophysical Observation", "SAO 14460"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.31233225),
        dec: Angle.Degrees(+64.03734579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9115"},
        {"Geneva Identification System", "GEN# +0.06300261"},
        {"Geneva Identification System 2", "GEN# +6.20055654"},
        {"Smithsonian Astrophysical Observation", "SAO 12050"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.37244025),
        dec: Angle.Degrees(+64.04115438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198781"},
        {"Hipparcos Number", "HIP 102771"},
        {"Celescope Catalog", "CEL 5183"},
        {"Fundamental Katalog 5th Edition", "FK5 3667"},
        {"Geneva Identification System", "GEN# +1.00198781"},
        {"Smithsonian Astrophysical Observation", "SAO 19051"},
        {"Wilson Evans Batten Catalogue", "WEB 18637"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32247907),
        dec: Angle.Degrees(+64.04226879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134319"},
        {"Hipparcos Number", "HIP 73869"},
        {"Geneva Identification System", "GEN# +1.00134319"},
        {"Smithsonian Astrophysical Observation", "SAO 16592"},
        {"Wilson Evans Batten Catalogue", "WEB 12617"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.45861033),
        dec: Angle.Degrees(+64.04693708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14108"},
        {"Smithsonian Astrophysical Observation", "SAO 12567"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.47383395),
        dec: Angle.Degrees(+64.04756862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62195"},
        {"Hipparcos Number", "HIP 37975"},
        {"Smithsonian Astrophysical Observation", "SAO 14326"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.75181115),
        dec: Angle.Degrees(+64.05201517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93269"},
        {"Smithsonian Astrophysical Observation", "SAO 18109"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99093735),
        dec: Angle.Degrees(+64.05406992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77428"},
        {"Hipparcos Number", "HIP 44625"},
        {"Smithsonian Astrophysical Observation", "SAO 14758"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.40575173),
        dec: Angle.Degrees(+64.05459601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19065"},
        {"Hipparcos Number", "HIP 14502"},
        {"Fundamental Katalog 5th Edition", "FK5 2219"},
        {"Geneva Identification System", "GEN# +1.00019065"},
        {"Smithsonian Astrophysical Observation", "SAO 12608"},
        {"Wilson Evans Batten Catalogue", "WEB 2819"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.82923690),
        dec: Angle.Degrees(+64.05760178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2664"},
        {"Hipparcos Number", "HIP 2423"},
        {"Geneva Identification System", "GEN# +1.00002664"},
        {"Smithsonian Astrophysical Observation", "SAO 11237"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.72625339),
        dec: Angle.Degrees(+64.06435996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109263"},
        {"Smithsonian Astrophysical Observation", "SAO 19883"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.04471169),
        dec: Angle.Degrees(+64.07031181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11243 A"},
        {"Henry Draper", "HD 168618"},
        {"Hipparcos Number", "HIP 89541"},
        {"Smithsonian Astrophysical Observation", "SAO 17839"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.06039945),
        dec: Angle.Degrees(+64.07152767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42044"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.55016080),
        dec: Angle.Degrees(+64.07240459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95538"},
        {"Smithsonian Astrophysical Observation", "SAO 18340"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.49407310),
        dec: Angle.Degrees(+64.07354686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61594"},
        {"Smithsonian Astrophysical Observation", "SAO 15839"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.31568528),
        dec: Angle.Degrees(+64.07439448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182486"},
        {"Hipparcos Number", "HIP 95091"},
        {"Geneva Identification System", "GEN# +1.00182486"},
        {"Smithsonian Astrophysical Observation", "SAO 18297"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.18954485),
        dec: Angle.Degrees(+64.07667323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40858"},
        {"Hipparcos Number", "HIP 28914"},
        {"Geneva Identification System", "GEN# +1.00040858"},
        {"Smithsonian Astrophysical Observation", "SAO 13713"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.55005338),
        dec: Angle.Degrees(+64.08182492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134881"},
        {"Hipparcos Number", "HIP 74137"},
        {"Smithsonian Astrophysical Observation", "SAO 16617"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24586437),
        dec: Angle.Degrees(+64.08273509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84569"},
        {"Smithsonian Astrophysical Observation", "SAO 17421"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.32542050),
        dec: Angle.Degrees(+64.08436305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4279"},
        {"Smithsonian Astrophysical Observation", "SAO 11461"},
        {"Wilson Evans Batten Catalogue", "WEB 766"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.69146964),
        dec: Angle.Degrees(+64.08477026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213242"},
        {"Hipparcos Number", "HIP 110919"},
        {"Geneva Identification System", "GEN# +1.00213242"},
        {"Smithsonian Astrophysical Observation", "SAO 20088"},
        {"Wilson Evans Batten Catalogue", "WEB 19860"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.08115262),
        dec: Angle.Degrees(+64.08523169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55621"},
        {"Smithsonian Astrophysical Observation", "SAO 15491"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.92967157),
        dec: Angle.Degrees(+64.08542997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33165"},
        {"Hipparcos Number", "HIP 24300"},
        {"Smithsonian Astrophysical Observation", "SAO 13406"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.21833656),
        dec: Angle.Degrees(+64.09149016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10147"},
        {"Geneva Identification System", "GEN# +0.06300300"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.62893585),
        dec: Angle.Degrees(+64.09198493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148363"},
        {"Hipparcos Number", "HIP 80286"},
        {"Smithsonian Astrophysical Observation", "SAO 17072"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.83974341),
        dec: Angle.Degrees(+64.09361760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104826"},
        {"Hipparcos Number", "HIP 58860"},
        {"Geneva Identification System", "GEN# +1.00104826"},
        {"Smithsonian Astrophysical Observation", "SAO 15700"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07037618),
        dec: Angle.Degrees(+64.09379928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78515"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.43722257),
        dec: Angle.Degrees(+64.09639584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7224"},
    },
    visualMagnitude: 11.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.27242390),
        dec: Angle.Degrees(+64.09690449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87111"},
        {"Smithsonian Astrophysical Observation", "SAO 17638"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.97923452),
        dec: Angle.Degrees(+64.09842452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193699"},
        {"Hipparcos Number", "HIP 100059"},
        {"Geneva Identification System", "GEN# +1.00193699"},
        {"Smithsonian Astrophysical Observation", "SAO 18797"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.50136214),
        dec: Angle.Degrees(+64.10173993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108075"},
        {"Hipparcos Number", "HIP 60536"},
        {"Smithsonian Astrophysical Observation", "SAO 15797"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.15152653),
        dec: Angle.Degrees(+64.10546168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86870"},
        {"Hipparcos Number", "HIP 49291"},
        {"Geneva Identification System", "GEN# +1.00086870"},
        {"Smithsonian Astrophysical Observation", "SAO 15061"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.91537400),
        dec: Angle.Degrees(+64.10559687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3383"},
        {"Smithsonian Astrophysical Observation", "SAO 11345"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.75529556),
        dec: Angle.Degrees(+64.11045711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16037"},
        {"Hipparcos Number", "HIP 12231"},
        {"Geneva Identification System", "GEN# +1.00016037"},
        {"Smithsonian Astrophysical Observation", "SAO 12360"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.36615843),
        dec: Angle.Degrees(+64.11343984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152859"},
        {"Hipparcos Number", "HIP 82499"},
        {"Smithsonian Astrophysical Observation", "SAO 17246"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.91287683),
        dec: Angle.Degrees(+64.11448408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216772"},
        {"Hipparcos Number", "HIP 113114"},
        {"Geneva Identification System", "GEN# +1.00216772"},
        {"Smithsonian Astrophysical Observation", "SAO 20312"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.59745670),
        dec: Angle.Degrees(+64.11512340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163838"},
        {"Hipparcos Number", "HIP 87603"},
        {"Geneva Identification System", "GEN# +1.00163838"},
        {"Wilson Evans Batten Catalogue", "WEB 14784"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.42704938),
        dec: Angle.Degrees(+64.11574568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55893"},
        {"Hipparcos Number", "HIP 35466"},
        {"Smithsonian Astrophysical Observation", "SAO 14146"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.82295022),
        dec: Angle.Degrees(+64.11585695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16638 AB"},
        {"Henry Draper", "HD 219633"},
        {"Hipparcos Number", "HIP 114898"},
        {"Smithsonian Astrophysical Observation", "SAO 20530"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.09800185),
        dec: Angle.Degrees(+64.11624207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94347"},
        {"Hipparcos Number", "HIP 53365"},
        {"Smithsonian Astrophysical Observation", "SAO 15329"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.69200627),
        dec: Angle.Degrees(+64.11742233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114990"},
        {"Geneva Identification System", "GEN# +0.06301964"},
        {"Smithsonian Astrophysical Observation", "SAO 20536"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.33988161),
        dec: Angle.Degrees(+64.12115913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210641"},
        {"Hipparcos Number", "HIP 109393"},
        {"Smithsonian Astrophysical Observation", "SAO 19909"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.43539420),
        dec: Angle.Degrees(+64.12238223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34654"},
        {"Hipparcos Number", "HIP 25222"},
        {"Geneva Identification System", "GEN# +1.00034654"},
        {"Smithsonian Astrophysical Observation", "SAO 13478"},
        {"Wilson Evans Batten Catalogue", "WEB 4889"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.91521285),
        dec: Angle.Degrees(+64.12507449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10068"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39464199),
        dec: Angle.Degrees(+64.13073833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32015"},
        {"Hipparcos Number", "HIP 23622"},
        {"Geneva Identification System", "GEN# +1.00032015"},
        {"Smithsonian Astrophysical Observation", "SAO 13359"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.17488002),
        dec: Angle.Degrees(+64.13243033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116197"},
        {"Smithsonian Astrophysical Observation", "SAO 20688"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.14677110),
        dec: Angle.Degrees(+64.13315420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115047"},
        {"Smithsonian Astrophysical Observation", "SAO 20548"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.51443356),
        dec: Angle.Degrees(+64.13701306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10985 A"},
        {"Henry Draper", "HD 164984"},
        {"Hipparcos Number", "HIP 88071"},
        {"Geneva Identification System", "GEN# +1.00164984"},
        {"Smithsonian Astrophysical Observation", "SAO 17717"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.80713168),
        dec: Angle.Degrees(+64.14254111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10985 B"},
        {"Henry Draper", "HD 164983"},
        {"Hipparcos Number", "HIP 88062"},
        {"Geneva Identification System", "GEN# +1.00164983"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79391014),
        dec: Angle.Degrees(+64.14387496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223209"},
        {"Hipparcos Number", "HIP 117329"},
        {"Celescope Catalog", "CEL 5674"},
        {"Geneva Identification System", "GEN# +1.00223209"},
        {"Smithsonian Astrophysical Observation", "SAO 20850"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.85853861),
        dec: Angle.Degrees(+64.14481947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13185"},
        {"Hipparcos Number", "HIP 10211"},
        {"Geneva Identification System", "GEN# +1.00013185"},
        {"Smithsonian Astrophysical Observation", "SAO 12158"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.83473629),
        dec: Angle.Degrees(+64.14578530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75996"},
        {"Smithsonian Astrophysical Observation", "SAO 16758"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.81100924),
        dec: Angle.Degrees(+64.14591333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57101"},
        {"Hipparcos Number", "HIP 35913"},
        {"Smithsonian Astrophysical Observation", "SAO 14179"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.05404019),
        dec: Angle.Degrees(+64.14785833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10084"},
        {"Hipparcos Number", "HIP 7811"},
        {"Smithsonian Astrophysical Observation", "SAO 11903"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.12700224),
        dec: Angle.Degrees(+64.14811016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129390"},
        {"Hipparcos Number", "HIP 71653"},
        {"Geneva Identification System", "GEN# +1.00129390"},
        {"Smithsonian Astrophysical Observation", "SAO 16455"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.84543991),
        dec: Angle.Degrees(+64.15388721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26408",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4177 A"},
        {"Henry Draper", "HD 36570"},
        {"Hipparcos Number", "HIP 26408"},
        {"Geneva Identification System", "GEN# +1.00036570"},
        {"Smithsonian Astrophysical Observation", "SAO 13550"},
        {"Wilson Evans Batten Catalogue", "WEB 5208"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31278375),
        dec: Angle.Degrees(+64.15485121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69444"},
        {"Smithsonian Astrophysical Observation", "SAO 16309"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.25799126),
        dec: Angle.Degrees(+64.15493065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17857"},
        {"Hipparcos Number", "HIP 13608"},
        {"Geneva Identification System", "GEN# +1.00017857"},
        {"Smithsonian Astrophysical Observation", "SAO 12509"},
        {"Wilson Evans Batten Catalogue", "WEB 2703"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.83731402),
        dec: Angle.Degrees(+64.15744146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89970"},
        {"Hipparcos Number", "HIP 50995"},
        {"Smithsonian Astrophysical Observation", "SAO 15168"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.25431961),
        dec: Angle.Degrees(+64.15794232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77852"},
    },
    visualMagnitude: 11.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.45353164),
        dec: Angle.Degrees(+64.15883645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98184"},
        {"Hipparcos Number", "HIP 55224"},
        {"Smithsonian Astrophysical Observation", "SAO 15469"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.63958130),
        dec: Angle.Degrees(+64.16051745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39372"},
        {"Hipparcos Number", "HIP 28141"},
        {"Smithsonian Astrophysical Observation", "SAO 13659"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20628703),
        dec: Angle.Degrees(+64.16257920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220239"},
        {"Hipparcos Number", "HIP 115320"},
        {"Smithsonian Astrophysical Observation", "SAO 20582"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.36041411),
        dec: Angle.Degrees(+64.16288283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24792"},
        {"Smithsonian Astrophysical Observation", "SAO 13450"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.72920569),
        dec: Angle.Degrees(+64.16758945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97830",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13092 B"},
        {"Hipparcos Number", "HIP 97830"},
        {"Smithsonian Astrophysical Observation", "SAO 18574"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.19777028),
        dec: Angle.Degrees(+64.16838230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28433"},
        {"Hipparcos Number", "HIP 21236"},
        {"Geneva Identification System", "GEN# +1.00028433"},
        {"Smithsonian Astrophysical Observation", "SAO 13181"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.32928819),
        dec: Angle.Degrees(+64.16972269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10125"},
        {"Hipparcos Number", "HIP 7845"},
        {"Geneva Identification System", "GEN# +1.00010125"},
        {"Smithsonian Astrophysical Observation", "SAO 11906"},
        {"Wilson Evans Batten Catalogue", "WEB 1676"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21983123),
        dec: Angle.Degrees(+64.17308668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71956"},
        {"Smithsonian Astrophysical Observation", "SAO 16473"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.75622624),
        dec: Angle.Degrees(+64.17333794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6841"},
        {"Hipparcos Number", "HIP 5506"},
        {"Geneva Identification System", "GEN# +1.00006841"},
        {"Smithsonian Astrophysical Observation", "SAO 11613"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.63427945),
        dec: Angle.Degrees(+64.17464321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13092 A"},
        {"Henry Draper", "HD 188772"},
        {"Hipparcos Number", "HIP 97831"},
        {"Smithsonian Astrophysical Observation", "SAO 18575"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.19864080),
        dec: Angle.Degrees(+64.17610692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101075"},
        {"Hipparcos Number", "HIP 56773"},
        {"Smithsonian Astrophysical Observation", "SAO 15578"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.59362637),
        dec: Angle.Degrees(+64.17682595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180609"},
        {"Hipparcos Number", "HIP 94401"},
        {"Smithsonian Astrophysical Observation", "SAO 18219"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.19668364),
        dec: Angle.Degrees(+64.17701341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117623"},
        {"Hipparcos Number", "HIP 65846"},
        {"Geneva Identification System", "GEN# +1.00117623"},
        {"Smithsonian Astrophysical Observation", "SAO 16092"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.47051700),
        dec: Angle.Degrees(+64.18052168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100513",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13813 AB"},
        {"Henry Draper", "HD 194613"},
        {"Hipparcos Number", "HIP 100513"},
        {"Smithsonian Astrophysical Observation", "SAO 18839"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.72630713),
        dec: Angle.Degrees(+64.18293125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53991"},
        {"Smithsonian Astrophysical Observation", "SAO 15374"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.68757419),
        dec: Angle.Degrees(+64.18591717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8822"},
        {"Geneva Identification System", "GEN# +0.06300253"},
        {"Smithsonian Astrophysical Observation", "SAO 12022"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.35322319),
        dec: Angle.Degrees(+64.18947260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101840"},
        {"Hipparcos Number", "HIP 57195"},
        {"Smithsonian Astrophysical Observation", "SAO 15615"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.91466192),
        dec: Angle.Degrees(+64.19012775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194718"},
        {"Hipparcos Number", "HIP 100553"},
        {"Geneva Identification System", "GEN# +1.00194718"},
        {"Smithsonian Astrophysical Observation", "SAO 18843"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.84880024),
        dec: Angle.Degrees(+64.19117997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104096"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.34695291),
        dec: Angle.Degrees(+64.19289530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38238"},
        {"Smithsonian Astrophysical Observation", "SAO 14336"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.50429327),
        dec: Angle.Degrees(+64.19501324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55236"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.66875721),
        dec: Angle.Degrees(+64.44051185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92100",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11692 AB"},
        {"Hipparcos Number", "HIP 92100"},
        {"Smithsonian Astrophysical Observation", "SAO 18012"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.55568282),
        dec: Angle.Degrees(+64.19581260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144"},
        {"Hipparcos Number", "HIP 531"},
        {"Fundamental Katalog 5th Edition", "FK5 2005"},
        {"Geneva Identification System", "GEN# +1.00000144"},
        {"Smithsonian Astrophysical Observation", "SAO 10978"},
        {"Wilson Evans Batten Catalogue", "WEB 93"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.61052855),
        dec: Angle.Degrees(+64.19616859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112351"},
        {"Hipparcos Number", "HIP 63042"},
        {"Geneva Identification System", "GEN# +1.00112351"},
        {"Smithsonian Astrophysical Observation", "SAO 15939"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.77018668),
        dec: Angle.Degrees(+64.19706116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193215"},
        {"Hipparcos Number", "HIP 99832"},
        {"Smithsonian Astrophysical Observation", "SAO 18780"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.83858986),
        dec: Angle.Degrees(+64.19821274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82624"},
        {"Smithsonian Astrophysical Observation", "SAO 17259"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35828743),
        dec: Angle.Degrees(+64.19921774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42818"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.87464631),
        dec: Angle.Degrees(+64.20171945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6960"},
        {"Hipparcos Number", "HIP 5566"},
        {"Celescope Catalog", "CEL 124"},
        {"Geneva Identification System", "GEN# +1.00006960"},
        {"Smithsonian Astrophysical Observation", "SAO 11615"},
        {"Wilson Evans Batten Catalogue", "WEB 1242"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.85631897),
        dec: Angle.Degrees(+64.20272388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169486"},
        {"Hipparcos Number", "HIP 89867"},
        {"Smithsonian Astrophysical Observation", "SAO 17859"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08174584),
        dec: Angle.Degrees(+64.20294398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99517"},
        {"Hipparcos Number", "HIP 55920"},
        {"Geneva Identification System", "GEN# +1.00099517"},
        {"Smithsonian Astrophysical Observation", "SAO 15514"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91830978),
        dec: Angle.Degrees(+64.20414189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45774"},
        {"Smithsonian Astrophysical Observation", "SAO 14844"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99960276),
        dec: Angle.Degrees(+64.20464410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15321"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.41338171),
        dec: Angle.Degrees(+64.20561695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44432"},
        {"Hipparcos Number", "HIP 30646"},
        {"Smithsonian Astrophysical Observation", "SAO 13836"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.60167386),
        dec: Angle.Degrees(+64.20737167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138852"},
        {"Hipparcos Number", "HIP 75974"},
        {"Fundamental Katalog 5th Edition", "FK5 3225"},
        {"Geneva Identification System", "GEN# +1.00138852"},
        {"Smithsonian Astrophysical Observation", "SAO 16754"},
        {"Wilson Evans Batten Catalogue", "WEB 12918"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.73297739),
        dec: Angle.Degrees(+64.20850517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106019"},
        {"Hipparcos Number", "HIP 59466"},
        {"Smithsonian Astrophysical Observation", "SAO 15734"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.96149730),
        dec: Angle.Degrees(+64.20980670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217848"},
        {"Hipparcos Number", "HIP 113767"},
        {"Smithsonian Astrophysical Observation", "SAO 20382"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.59005878),
        dec: Angle.Degrees(+64.21031466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166578"},
        {"Hipparcos Number", "HIP 88716"},
        {"Smithsonian Astrophysical Observation", "SAO 17768"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.66918225),
        dec: Angle.Degrees(+64.22142272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218560"},
        {"Hipparcos Number", "HIP 114227"},
        {"Fundamental Katalog 5th Edition", "FK5 3853"},
        {"Geneva Identification System", "GEN# +1.00218560"},
        {"Smithsonian Astrophysical Observation", "SAO 20441"},
        {"Wilson Evans Batten Catalogue", "WEB 20287"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.98831300),
        dec: Angle.Degrees(+64.22254354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21930"},
        {"Hipparcos Number", "HIP 16771"},
        {"Geneva Identification System", "GEN# +1.00021930"},
        {"Smithsonian Astrophysical Observation", "SAO 12827"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.95562627),
        dec: Angle.Degrees(+64.22361324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118168"},
        {"Celescope Catalog", "CEL 5730"},
        {"Smithsonian Astrophysical Observation", "SAO 20966"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.55033289),
        dec: Angle.Degrees(+64.22780923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63314"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.63183718),
        dec: Angle.Degrees(+64.23488288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12399"},
        {"Hipparcos Number", "HIP 9635"},
        {"Geneva Identification System", "GEN# +1.00012399"},
        {"Smithsonian Astrophysical Observation", "SAO 12102"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.95469240),
        dec: Angle.Degrees(+64.23748589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145692"},
        {"Hipparcos Number", "HIP 79051"},
        {"Geneva Identification System", "GEN# +1.00145692"},
        {"Smithsonian Astrophysical Observation", "SAO 16971"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.03621240),
        dec: Angle.Degrees(+64.23926545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25122"},
        {"Hipparcos Number", "HIP 18938"},
        {"Smithsonian Astrophysical Observation", "SAO 13001"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.88547347),
        dec: Angle.Degrees(+64.24239324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121490"},
        {"Hipparcos Number", "HIP 67816"},
        {"Geneva Identification System", "GEN# +1.00121490"},
        {"Smithsonian Astrophysical Observation", "SAO 16204"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38422233),
        dec: Angle.Degrees(+64.24536738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124846"},
        {"Hipparcos Number", "HIP 69469"},
        {"Smithsonian Astrophysical Observation", "SAO 16311"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.33386787),
        dec: Angle.Degrees(+64.24576747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28317"},
        {"Hipparcos Number", "HIP 21164"},
        {"Smithsonian Astrophysical Observation", "SAO 13174"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.06234340),
        dec: Angle.Degrees(+64.24697632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4775"},
        {"Henry Draper 2", "HD 4776"},
        {"Hipparcos Number", "HIP 3951"},
        {"Fundamental Katalog 5th Edition", "FK5 29"},
        {"Geneva Identification System", "GEN# +1.00004775"},
        {"Smithsonian Astrophysical Observation", "SAO 11424"},
        {"Wilson Evans Batten Catalogue", "WEB 705"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.68155194),
        dec: Angle.Degrees(+64.24758084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20968"},
        {"Hipparcos Number", "HIP 16046"},
        {"Smithsonian Astrophysical Observation", "SAO 12756"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.65506637),
        dec: Angle.Degrees(+64.24916947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90745"},
        {"Hipparcos Number", "HIP 51448"},
        {"Fundamental Katalog 5th Edition", "FK5 2839"},
        {"Geneva Identification System", "GEN# +1.00090745"},
        {"Smithsonian Astrophysical Observation", "SAO 15200"},
        {"Wilson Evans Batten Catalogue", "WEB 9390"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.61105667),
        dec: Angle.Degrees(+64.25781273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28780"},
        {"Hipparcos Number", "HIP 21452"},
        {"Fundamental Katalog 5th Edition", "FK5 2336"},
        {"Geneva Identification System", "GEN# +1.00028780"},
        {"Smithsonian Astrophysical Observation", "SAO 13196"},
        {"Wilson Evans Batten Catalogue", "WEB 4118"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10096877),
        dec: Angle.Degrees(+64.26162001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74810"},
        {"Hipparcos Number", "HIP 43332"},
        {"Smithsonian Astrophysical Observation", "SAO 14672"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.42172192),
        dec: Angle.Degrees(+64.26476059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219523"},
        {"Hipparcos Number", "HIP 114816"},
        {"Celescope Catalog", "CEL 5587"},
        {"Geneva Identification System", "GEN# +1.00219523"},
        {"Smithsonian Astrophysical Observation", "SAO 20518"},
        {"Wilson Evans Batten Catalogue", "WEB 20351"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.86874750),
        dec: Angle.Degrees(+64.26671682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147203"},
        {"Hipparcos Number", "HIP 79727"},
        {"Smithsonian Astrophysical Observation", "SAO 17019"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.07612035),
        dec: Angle.Degrees(+64.27329587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1240"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.86261234),
        dec: Angle.Degrees(+64.27531505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126439"},
        {"Hipparcos Number", "HIP 70283"},
        {"Smithsonian Astrophysical Observation", "SAO 16360"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.69554868),
        dec: Angle.Degrees(+64.27608346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141564"},
        {"Hipparcos Number", "HIP 77215"},
        {"Smithsonian Astrophysical Observation", "SAO 16845"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.47989031),
        dec: Angle.Degrees(+64.27628638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102300"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.92061816),
        dec: Angle.Degrees(+64.28194099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 310.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22369"},
        {"Hipparcos Number", "HIP 17119"},
        {"Geneva Identification System", "GEN# +1.00022369"},
        {"Smithsonian Astrophysical Observation", "SAO 12853"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.99518645),
        dec: Angle.Degrees(+64.28548417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13059"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.95551646),
        dec: Angle.Degrees(+64.28587021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184677"},
        {"Hipparcos Number", "HIP 96015"},
        {"Fundamental Katalog 5th Edition", "FK5 5718"},
        {"Smithsonian Astrophysical Observation", "SAO 18383"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.83597187),
        dec: Angle.Degrees(+64.28699692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12567"},
        {"Hipparcos Number", "HIP 9765"},
        {"Geneva Identification System", "GEN# +1.00012567"},
        {"Smithsonian Astrophysical Observation", "SAO 12118"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.38258799),
        dec: Angle.Degrees(+64.28703266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33101"},
        {"Hipparcos Number", "HIP 24270"},
        {"Smithsonian Astrophysical Observation", "SAO 13403"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.13492536),
        dec: Angle.Degrees(+64.28718680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3940"},
        {"Hipparcos Number", "HIP 3367"},
        {"Geneva Identification System", "GEN# +1.00003940"},
        {"Smithsonian Astrophysical Observation", "SAO 11343"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.70861211),
        dec: Angle.Degrees(+64.29128139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129333"},
        {"Hipparcos Number", "HIP 71631"},
        {"Geneva Identification System", "GEN# +1.00129333"},
        {"Smithsonian Astrophysical Observation", "SAO 16453"},
        {"Wilson Evans Batten Catalogue", "WEB 12346"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.75165826),
        dec: Angle.Degrees(+64.29168401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90858"},
        {"Hipparcos Number", "HIP 51511"},
        {"Smithsonian Astrophysical Observation", "SAO 15206"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.80108655),
        dec: Angle.Degrees(+64.29426649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218323"},
        {"Hipparcos Number", "HIP 114060"},
        {"Geneva Identification System", "GEN# +9.00020075"},
        {"Smithsonian Astrophysical Observation", "SAO 20421"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.48628362),
        dec: Angle.Degrees(+64.29515712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19267"},
        {"Hipparcos Number", "HIP 14655"},
        {"Geneva Identification System", "GEN# +1.00019267"},
        {"Smithsonian Astrophysical Observation", "SAO 12621"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34230875),
        dec: Angle.Degrees(+64.29969895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1939"},
        {"Hipparcos Number", "HIP 1926"},
        {"Geneva Identification System", "GEN# +1.00001939"},
        {"Smithsonian Astrophysical Observation", "SAO 11165"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07309122),
        dec: Angle.Degrees(+64.30018808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223109"},
        {"Hipparcos Number", "HIP 117257"},
        {"Geneva Identification System", "GEN# +1.00223109"},
        {"Smithsonian Astrophysical Observation", "SAO 20837"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64036373),
        dec: Angle.Degrees(+64.30126267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220868"},
        {"Hipparcos Number", "HIP 115710"},
        {"Geneva Identification System", "GEN# +1.00220868"},
        {"Smithsonian Astrophysical Observation", "SAO 20630"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64848175),
        dec: Angle.Degrees(+64.30473565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6092"},
        {"Geneva Identification System", "GEN# +0.06300167"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.55284398),
        dec: Angle.Degrees(+64.30511272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44021"},
        {"Smithsonian Astrophysical Observation", "SAO 14716"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.47662822),
        dec: Angle.Degrees(+64.31185218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100641"},
        {"Hipparcos Number", "HIP 56534"},
        {"Smithsonian Astrophysical Observation", "SAO 15564"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.87921904),
        dec: Angle.Degrees(+64.31692744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35759"},
        {"Hipparcos Number", "HIP 25883"},
        {"Geneva Identification System", "GEN# +1.00035759"},
        {"Smithsonian Astrophysical Observation", "SAO 13524"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.88912002),
        dec: Angle.Degrees(+64.31899997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155637"},
        {"Hipparcos Number", "HIP 83866"},
        {"Smithsonian Astrophysical Observation", "SAO 17364"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.10208718),
        dec: Angle.Degrees(+64.31908197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38928"},
        {"Smithsonian Astrophysical Observation", "SAO 14386"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.48119115),
        dec: Angle.Degrees(+64.31949492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16806 AB"},
        {"Henry Draper", "HD 221333"},
        {"Hipparcos Number", "HIP 116038"},
        {"Smithsonian Astrophysical Observation", "SAO 20672"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.67779877),
        dec: Angle.Degrees(+64.32181218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39165"},
        {"Hipparcos Number", "HIP 28000"},
        {"Smithsonian Astrophysical Observation", "SAO 13649"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.83808890),
        dec: Angle.Degrees(+64.32196159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24595"},
        {"Hipparcos Number", "HIP 18580"},
        {"Smithsonian Astrophysical Observation", "SAO 12977"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65479954),
        dec: Angle.Degrees(+64.32383890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73108"},
        {"Hipparcos Number", "HIP 42527"},
        {"Fundamental Katalog 5th Edition", "FK5 2677"},
        {"Geneva Identification System", "GEN# +1.00073108"},
        {"Smithsonian Astrophysical Observation", "SAO 14616"},
        {"Wilson Evans Batten Catalogue", "WEB 8197"},
    },
    visualMagnitude: 4.59,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.05374429),
        dec: Angle.Degrees(+64.32787175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110452"},
        {"Smithsonian Astrophysical Observation", "SAO 20037"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.58032906),
        dec: Angle.Degrees(+64.32951770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98772"},
        {"Hipparcos Number", "HIP 55564"},
        {"Fundamental Katalog 5th Edition", "FK5 429"},
        {"Geneva Identification System", "GEN# +1.00098772"},
        {"Smithsonian Astrophysical Observation", "SAO 15486"},
        {"Wilson Evans Batten Catalogue", "WEB 9987"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.71354405),
        dec: Angle.Degrees(+64.33042692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17958"},
        {"Hipparcos Number", "HIP 13700"},
        {"Geneva Identification System", "GEN# +1.00017958"},
        {"Smithsonian Astrophysical Observation", "SAO 12519"},
        {"Wilson Evans Batten Catalogue", "WEB 2716"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.10273130),
        dec: Angle.Degrees(+64.33244427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66609"},
        {"Hipparcos Number", "HIP 39858"},
        {"Smithsonian Astrophysical Observation", "SAO 14439"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14199308),
        dec: Angle.Degrees(+64.33384782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222217"},
        {"Hipparcos Number", "HIP 116648"},
        {"Smithsonian Astrophysical Observation", "SAO 20743"},
        {"Wilson Evans Batten Catalogue", "WEB 20589"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.58450996),
        dec: Angle.Degrees(+64.33410672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14171"},
        {"Hipparcos Number", "HIP 10893"},
        {"Celescope Catalog", "CEL 253"},
        {"Geneva Identification System", "GEN# +1.00014171"},
        {"Renson", "Renson 3600"},
        {"Smithsonian Astrophysical Observation", "SAO 12226"},
        {"Wilson Evans Batten Catalogue", "WEB 2295"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.05364903),
        dec: Angle.Degrees(+64.33693546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49038"},
        {"Hipparcos Number", "HIP 32877"},
        {"Geneva Identification System", "GEN# +1.00049038"},
        {"Smithsonian Astrophysical Observation", "SAO 13977"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.76657000),
        dec: Angle.Degrees(+64.33991772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210743"},
        {"Hipparcos Number", "HIP 109451"},
        {"Celescope Catalog", "CEL 5447"},
        {"Geneva Identification System", "GEN# +1.00210743"},
        {"Smithsonian Astrophysical Observation", "SAO 19918"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.61051842),
        dec: Angle.Degrees(+64.34104081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7364 AB"},
        {"Henry Draper", "HD 81161"},
        {"Hipparcos Number", "HIP 46347"},
        {"Smithsonian Astrophysical Observation", "SAO 14877"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.73816664),
        dec: Angle.Degrees(+64.34320349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91654"},
        {"Hipparcos Number", "HIP 51952"},
        {"Smithsonian Astrophysical Observation", "SAO 15236"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19365922),
        dec: Angle.Degrees(+64.34371462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56816",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8249 AB"},
        {"Henry Draper", "HD 101150"},
        {"Hipparcos Number", "HIP 56816"},
        {"Smithsonian Astrophysical Observation", "SAO 15580"},
        {"Wilson Evans Batten Catalogue", "WEB 10227"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.70466971),
        dec: Angle.Degrees(+64.34696298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112818"},
        {"Smithsonian Astrophysical Observation", "SAO 20276"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.70126749),
        dec: Angle.Degrees(+64.34906643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17835"},
        {"Smithsonian Astrophysical Observation", "SAO 12913"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.24044159),
        dec: Angle.Degrees(+64.34947682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81457"},
        {"Hipparcos Number", "HIP 46468"},
        {"Smithsonian Astrophysical Observation", "SAO 14890"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.16146653),
        dec: Angle.Degrees(+64.35256224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24921"},
        {"Hipparcos Number", "HIP 18799"},
        {"Smithsonian Astrophysical Observation", "SAO 12991"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.41716280),
        dec: Angle.Degrees(+64.35751049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196970"},
        {"Hipparcos Number", "HIP 101721"},
        {"Fundamental Katalog 5th Edition", "FK5 5813"},
        {"Geneva Identification System", "GEN# +1.00196970"},
        {"Smithsonian Astrophysical Observation", "SAO 18949"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.28508589),
        dec: Angle.Degrees(+64.36051299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203837"},
        {"Hipparcos Number", "HIP 105463"},
        {"Smithsonian Astrophysical Observation", "SAO 19352"},
        {"Wilson Evans Batten Catalogue", "WEB 19152"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.43135870),
        dec: Angle.Degrees(+64.36455912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53226"},
        {"Hipparcos Number", "HIP 34480"},
        {"Smithsonian Astrophysical Observation", "SAO 14084"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18720759),
        dec: Angle.Degrees(+64.36877745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125795"},
        {"Hipparcos Number", "HIP 69983"},
        {"Geneva Identification System", "GEN# +1.00125795"},
        {"Smithsonian Astrophysical Observation", "SAO 16336"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.80083644),
        dec: Angle.Degrees(+64.37005453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82702"},
        {"Hipparcos Number", "HIP 47152"},
        {"Geneva Identification System", "GEN# +1.00082702"},
        {"Smithsonian Astrophysical Observation", "SAO 14937"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.12353554),
        dec: Angle.Degrees(+64.37057583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62585"},
        {"Hipparcos Number", "HIP 38141"},
        {"Geneva Identification System", "GEN# +1.00062585"},
        {"Smithsonian Astrophysical Observation", "SAO 14333"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.24748819),
        dec: Angle.Degrees(+64.37093412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68756",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Thuban"},
        {"Henry Draper", "HD 123299"},
        {"Hipparcos Number", "HIP 68756"},
        {"Fundamental Katalog 5th Edition", "FK5 521"},
        {"Geneva Identification System", "GEN# +1.00123299"},
        {"Renson", "Renson 35350"},
        {"Smithsonian Astrophysical Observation", "SAO 16273"},
        {"Wilson Evans Batten Catalogue", "WEB 12028"},
    },
    visualMagnitude: 3.67,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.09760837),
        dec: Angle.Degrees(+64.37580873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108687"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.25780215),
        dec: Angle.Degrees(+64.37831253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86067"},
        {"Smithsonian Astrophysical Observation", "SAO 17550"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.85187850),
        dec: Angle.Degrees(+64.38063290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111496"},
        {"Smithsonian Astrophysical Observation", "SAO 20165"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.83833828),
        dec: Angle.Degrees(+64.38138077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93239"},
        {"Hipparcos Number", "HIP 52790"},
        {"Smithsonian Astrophysical Observation", "SAO 15286"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.89046678),
        dec: Angle.Degrees(+64.38154205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179438"},
        {"Hipparcos Number", "HIP 93985"},
        {"Smithsonian Astrophysical Observation", "SAO 18171"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.03643460),
        dec: Angle.Degrees(+64.38233460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18565"},
        {"Hipparcos Number", "HIP 14154"},
        {"Smithsonian Astrophysical Observation", "SAO 12571"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.61821822),
        dec: Angle.Degrees(+64.38280803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122363"},
        {"Hipparcos Number", "HIP 68326"},
        {"Smithsonian Astrophysical Observation", "SAO 16239"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.79468125),
        dec: Angle.Degrees(+64.38517023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9720",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1635 AB"},
        {"Henry Draper", "HD 12509"},
        {"Hipparcos Number", "HIP 9720"},
        {"Celescope Catalog", "CEL 195"},
        {"Geneva Identification System", "GEN# +1.00012509J"},
        {"Smithsonian Astrophysical Observation", "SAO 12110"},
        {"Wilson Evans Batten Catalogue", "WEB 2042"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.25607674),
        dec: Angle.Degrees(+64.38560093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206311"},
        {"Hipparcos Number", "HIP 106869"},
        {"Smithsonian Astrophysical Observation", "SAO 19550"},
        {"Wilson Evans Batten Catalogue", "WEB 19315"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.67170120),
        dec: Angle.Degrees(+64.38561029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204734"},
        {"Hipparcos Number", "HIP 105992"},
        {"Geneva Identification System", "GEN# +1.00204734"},
        {"Smithsonian Astrophysical Observation", "SAO 19435"},
        {"Wilson Evans Batten Catalogue", "WEB 19215"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.00400503),
        dec: Angle.Degrees(+64.38751380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12301"},
        {"Hipparcos Number", "HIP 9573"},
        {"Celescope Catalog", "CEL 189"},
        {"Geneva Identification System", "GEN# +1.00012301"},
        {"Smithsonian Astrophysical Observation", "SAO 12097"},
        {"Wilson Evans Batten Catalogue", "WEB 2008"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.75078582),
        dec: Angle.Degrees(+64.39002289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182308"},
        {"Hipparcos Number", "HIP 94993"},
        {"Geneva Identification System", "GEN# +1.00182308"},
        {"Renson", "Renson 50400"},
        {"Smithsonian Astrophysical Observation", "SAO 18287"},
        {"Wilson Evans Batten Catalogue", "WEB 16592"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.94225343),
        dec: Angle.Degrees(+64.39078822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114843"},
        {"Smithsonian Astrophysical Observation", "SAO 20522"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.93684482),
        dec: Angle.Degrees(+64.39133494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221325"},
        {"Hipparcos Number", "HIP 116022"},
        {"Geneva Identification System", "GEN# +1.00221325"},
        {"Smithsonian Astrophysical Observation", "SAO 20669"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.63356129),
        dec: Angle.Degrees(+64.39226962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6447"},
        {"Hipparcos Number", "HIP 5210"},
        {"Geneva Identification System", "GEN# +1.00006447"},
        {"Smithsonian Astrophysical Observation", "SAO 11576"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.65897584),
        dec: Angle.Degrees(+64.39312344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102327"},
        {"Hipparcos Number", "HIP 57495"},
        {"Smithsonian Astrophysical Observation", "SAO 15630"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.76822531),
        dec: Angle.Degrees(+64.39325253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12597"},
        {"Smithsonian Astrophysical Observation", "SAO 12392"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.49372189),
        dec: Angle.Degrees(+64.39526455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168151"},
        {"Hipparcos Number", "HIP 89348"},
        {"Fundamental Katalog 5th Edition", "FK5 685"},
        {"Geneva Identification System", "GEN# +1.00168151"},
        {"Smithsonian Astrophysical Observation", "SAO 17828"},
        {"Wilson Evans Batten Catalogue", "WEB 15194"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.47232710),
        dec: Angle.Degrees(+64.39719935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 351.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30957"},
        {"Hipparcos Number", "HIP 22961"},
        {"Smithsonian Astrophysical Observation", "SAO 13309"},
        {"Wilson Evans Batten Catalogue", "WEB 4459"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.10833529),
        dec: Angle.Degrees(+64.40283469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149955"},
        {"Hipparcos Number", "HIP 81086"},
        {"Smithsonian Astrophysical Observation", "SAO 17144"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.42517277),
        dec: Angle.Degrees(+64.40311899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14783 AB"},
        {"Henry Draper", "HD 202582"},
        {"Hipparcos Number", "HIP 104788"},
        {"Geneva Identification System", "GEN# +1.00202582J"},
        {"Smithsonian Astrophysical Observation", "SAO 19257"},
        {"Wilson Evans Batten Catalogue", "WEB 19059"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.42691572),
        dec: Angle.Degrees(+64.40420824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82881"},
        {"Hipparcos Number", "HIP 47229"},
        {"Geneva Identification System", "GEN# +1.00082881"},
        {"Smithsonian Astrophysical Observation", "SAO 14940"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.39449020),
        dec: Angle.Degrees(+64.40886937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87207"},
        {"Hipparcos Number", "HIP 49456"},
        {"Geneva Identification System", "GEN# +1.00087207"},
        {"Smithsonian Astrophysical Observation", "SAO 15074"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46262170),
        dec: Angle.Degrees(+64.41327329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75073"},
        {"Hipparcos Number", "HIP 43477"},
        {"Smithsonian Astrophysical Observation", "SAO 14682"},
        {"Wilson Evans Batten Catalogue", "WEB 8378"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.83803849),
        dec: Angle.Degrees(+64.41852490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18137"},
        {"Hipparcos Number", "HIP 13828"},
        {"Geneva Identification System", "GEN# +1.00018137"},
        {"Smithsonian Astrophysical Observation", "SAO 12536"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.49396537),
        dec: Angle.Degrees(+64.41908503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52651"},
        {"Hipparcos Number", "HIP 34294"},
        {"Geneva Identification System", "GEN# +1.00052651"},
        {"Smithsonian Astrophysical Observation", "SAO 14069"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.64353896),
        dec: Angle.Degrees(+64.42011294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134223"},
        {"Hipparcos Number", "HIP 73825"},
        {"Smithsonian Astrophysical Observation", "SAO 16590"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32838207),
        dec: Angle.Degrees(+64.42055911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1759"},
        {"Henry Draper", "HD 14010"},
        {"Hipparcos Number", "HIP 10780"},
        {"Geneva Identification System", "GEN# +1.00014010"},
        {"Smithsonian Astrophysical Observation", "SAO 12213"},
        {"Wilson Evans Batten Catalogue", "WEB 2270"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.68619815),
        dec: Angle.Degrees(+64.42492866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90860"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.03202067),
        dec: Angle.Degrees(+64.43233888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9730 AB"},
        {"Henry Draper", "HD 139905"},
        {"Hipparcos Number", "HIP 76466"},
        {"Smithsonian Astrophysical Observation", "SAO 16785"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.25153226),
        dec: Angle.Degrees(+64.43981147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28168"},
        {"Hipparcos Number", "HIP 21059"},
        {"Smithsonian Astrophysical Observation", "SAO 13165"},
        {"Wilson Evans Batten Catalogue", "WEB 4050"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.70852871),
        dec: Angle.Degrees(+64.44181815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7650 AB"},
        {"Hipparcos Number", "HIP 49716"},
        {"Smithsonian Astrophysical Observation", "SAO 15097"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.25824428),
        dec: Angle.Degrees(+64.44467248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45163"},
        {"Hipparcos Number", "HIP 31018"},
        {"Geneva Identification System", "GEN# +1.00045163"},
        {"Smithsonian Astrophysical Observation", "SAO 13853"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.62655271),
        dec: Angle.Degrees(+64.44553653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21725"},
        {"Hipparcos Number", "HIP 16633"},
        {"Smithsonian Astrophysical Observation", "SAO 12812"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.50018073),
        dec: Angle.Degrees(+64.44887724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17706"},
        {"Hipparcos Number", "HIP 13487"},
        {"Geneva Identification System", "GEN# +1.00017706J"},
        {"Smithsonian Astrophysical Observation", "SAO 12493"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.41870386),
        dec: Angle.Degrees(+64.45198652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116090"},
        {"Hipparcos Number", "HIP 65038"},
        {"Geneva Identification System", "GEN# +1.00116090"},
        {"Smithsonian Astrophysical Observation", "SAO 16043"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.96523128),
        dec: Angle.Degrees(+64.45793306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82488"},
        {"Hipparcos Number", "HIP 47032"},
        {"Smithsonian Astrophysical Observation", "SAO 14929"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.78294881),
        dec: Angle.Degrees(+64.46016918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80530"},
        {"Smithsonian Astrophysical Observation", "SAO 17089"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.59850944),
        dec: Angle.Degrees(+64.46225901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106072"},
        {"Hipparcos Number", "HIP 59497"},
        {"Smithsonian Astrophysical Observation", "SAO 15736"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.02310764),
        dec: Angle.Degrees(+64.46379776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113289"},
        {"Geneva Identification System", "GEN# +9.00020038"},
        {"Smithsonian Astrophysical Observation", "SAO 20331"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.11021394),
        dec: Angle.Degrees(+64.46496268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92362"},
        {"Smithsonian Astrophysical Observation", "SAO 18036"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.35768725),
        dec: Angle.Degrees(+64.46841076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117996"},
        {"Hipparcos Number", "HIP 66037"},
        {"Smithsonian Astrophysical Observation", "SAO 16103"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.07817843),
        dec: Angle.Degrees(+64.47303977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10034"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.28930148),
        dec: Angle.Degrees(+64.48661125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3022 AB"},
        {"Hipparcos Number", "HIP 19498"},
        {"Smithsonian Astrophysical Observation", "SAO 13048"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67013212),
        dec: Angle.Degrees(+64.49315338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202735"},
        {"Hipparcos Number", "HIP 104900"},
        {"Geneva Identification System", "GEN# +1.00202735"},
        {"Smithsonian Astrophysical Observation", "SAO 19266"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.73415058),
        dec: Angle.Degrees(+64.49780108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59442"},
    },
    visualMagnitude: 11.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.88668975),
        dec: Angle.Degrees(+65.02505238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28616"},
        {"Hipparcos Number", "HIP 21362"},
        {"Smithsonian Astrophysical Observation", "SAO 13193"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.75122095),
        dec: Angle.Degrees(+64.50252462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76334"},
    },
    visualMagnitude: 12.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.88374845),
        dec: Angle.Degrees(+64.50579158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159731"},
        {"Hipparcos Number", "HIP 85777"},
        {"Smithsonian Astrophysical Observation", "SAO 17516"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.91563952),
        dec: Angle.Degrees(+64.51084256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116948",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16940 AB"},
        {"Henry Draper", "HD 222670"},
        {"Hipparcos Number", "HIP 116948"},
        {"Geneva Identification System", "GEN# +1.00222670J"},
        {"Smithsonian Astrophysical Observation", "SAO 20791"},
        {"Wilson Evans Batten Catalogue", "WEB 20629"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.58722466),
        dec: Angle.Degrees(+64.51540275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199738"},
        {"Hipparcos Number", "HIP 103307"},
        {"Smithsonian Astrophysical Observation", "SAO 19105"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.93908123),
        dec: Angle.Degrees(+64.51630451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7678"},
        {"Smithsonian Astrophysical Observation", "SAO 11889"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.71032188),
        dec: Angle.Degrees(+64.51941299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220314"},
        {"Hipparcos Number", "HIP 115362"},
        {"Celescope Catalog", "CEL 5606"},
        {"Geneva Identification System", "GEN# +1.00220314"},
        {"Smithsonian Astrophysical Observation", "SAO 20585"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.51192726),
        dec: Angle.Degrees(+64.51960348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41946"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.26552221),
        dec: Angle.Degrees(+64.51971714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60466"},
        {"Smithsonian Astrophysical Observation", "SAO 15794"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.94422280),
        dec: Angle.Degrees(+64.52748411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213387"},
        {"Hipparcos Number", "HIP 110993"},
        {"Smithsonian Astrophysical Observation", "SAO 20099"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.30189400),
        dec: Angle.Degrees(+64.52753899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111773"},
        {"Geneva Identification System", "GEN# +0.06301873"},
        {"Smithsonian Astrophysical Observation", "SAO 20188"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.61787748),
        dec: Angle.Degrees(+64.53013280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15375"},
        {"Hipparcos Number", "HIP 11725"},
        {"Smithsonian Astrophysical Observation", "SAO 12315"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.84317162),
        dec: Angle.Degrees(+64.53093563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92848",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11866 AB"},
        {"Hipparcos Number", "HIP 92848"},
        {"Smithsonian Astrophysical Observation", "SAO 18070"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.79448741),
        dec: Angle.Degrees(+64.53132362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5392"},
        {"Hipparcos Number", "HIP 4449"},
        {"Geneva Identification System", "GEN# +1.00005392"},
        {"Smithsonian Astrophysical Observation", "SAO 11486"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.23107210),
        dec: Angle.Degrees(+64.53228799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206026"},
        {"Hipparcos Number", "HIP 106689"},
        {"Smithsonian Astrophysical Observation", "SAO 19527"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.14005443),
        dec: Angle.Degrees(+64.53628176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161237"},
        {"Hipparcos Number", "HIP 86438"},
        {"Geneva Identification System", "GEN# +1.00161237"},
        {"Smithsonian Astrophysical Observation", "SAO 17594"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.92275775),
        dec: Angle.Degrees(+64.53661760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202922"},
        {"Hipparcos Number", "HIP 105003"},
        {"Smithsonian Astrophysical Observation", "SAO 19280"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.00276707),
        dec: Angle.Degrees(+64.53671816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94549"},
        {"Hipparcos Number", "HIP 53463"},
        {"Smithsonian Astrophysical Observation", "SAO 15339"},
        {"Wilson Evans Batten Catalogue", "WEB 9701"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.05095878),
        dec: Angle.Degrees(+64.53784442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34027"},
        {"Hipparcos Number", "HIP 24808"},
        {"Smithsonian Astrophysical Observation", "SAO 13452"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.77667783),
        dec: Angle.Degrees(+64.53957731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88059"},
        {"Hipparcos Number", "HIP 49904"},
        {"Smithsonian Astrophysical Observation", "SAO 15111"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84138633),
        dec: Angle.Degrees(+64.54349119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5244"},
        {"Hipparcos Number", "HIP 4318"},
        {"Geneva Identification System", "GEN# +1.00005244"},
        {"Smithsonian Astrophysical Observation", "SAO 11466"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.81175070),
        dec: Angle.Degrees(+64.54580946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8659"},
        {"Smithsonian Astrophysical Observation", "SAO 12011"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90105693),
        dec: Angle.Degrees(+64.54725710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134851"},
        {"Hipparcos Number", "HIP 74107"},
        {"Smithsonian Astrophysical Observation", "SAO 16614"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.18214318),
        dec: Angle.Degrees(+64.54756141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72335"},
        {"Smithsonian Astrophysical Observation", "SAO 16500"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88063620),
        dec: Angle.Degrees(+64.55034012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29202"},
        {"Hipparcos Number", "HIP 21758"},
        {"Geneva Identification System", "GEN# +1.00029202"},
        {"Smithsonian Astrophysical Observation", "SAO 13224"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.08767590),
        dec: Angle.Degrees(+64.55718041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44844"},
        {"Smithsonian Astrophysical Observation", "SAO 14771"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.05335046),
        dec: Angle.Degrees(+64.55796575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216351"},
        {"Hipparcos Number", "HIP 112822"},
        {"Geneva Identification System", "GEN# +1.00216351"},
        {"Smithsonian Astrophysical Observation", "SAO 20278"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.72033342),
        dec: Angle.Degrees(+64.56138178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1009"},
        {"Hipparcos Number", "HIP 1180"},
        {"Geneva Identification System", "GEN# +1.00001009"},
        {"Renson", "Renson 170"},
        {"Smithsonian Astrophysical Observation", "SAO 11060"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.67799018),
        dec: Angle.Degrees(+64.56616939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14719"},
        {"Hipparcos Number", "HIP 11281"},
        {"Smithsonian Astrophysical Observation", "SAO 12275"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.32117932),
        dec: Angle.Degrees(+64.56747713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61601"},
        {"Smithsonian Astrophysical Observation", "SAO 15840"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.34723532),
        dec: Angle.Degrees(+64.57096936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215500"},
        {"Hipparcos Number", "HIP 112245"},
        {"Geneva Identification System", "GEN# +1.00215500"},
        {"Smithsonian Astrophysical Observation", "SAO 20223"},
        {"Wilson Evans Batten Catalogue", "WEB 20030"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02399013),
        dec: Angle.Degrees(+64.57139372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131330"},
        {"Hipparcos Number", "HIP 72540"},
        {"Geneva Identification System", "GEN# +1.00131330"},
        {"Smithsonian Astrophysical Observation", "SAO 16522"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46365859),
        dec: Angle.Degrees(+64.58062237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157877"},
        {"Hipparcos Number", "HIP 84925"},
        {"Smithsonian Astrophysical Observation", "SAO 17447"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.33484847),
        dec: Angle.Degrees(+64.58589959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20797"},
        {"Hipparcos Number", "HIP 15890"},
        {"Fundamental Katalog 5th Edition", "FK5 1096"},
        {"Geneva Identification System", "GEN# +1.00020797"},
        {"Smithsonian Astrophysical Observation", "SAO 12743"},
        {"Wilson Evans Batten Catalogue", "WEB 3034"},
    },
    visualMagnitude: 5.13,
    bvColour: 2.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.16900549),
        dec: Angle.Degrees(+64.58599618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214344"},
        {"Hipparcos Number", "HIP 111542"},
        {"Smithsonian Astrophysical Observation", "SAO 20170"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.96588598),
        dec: Angle.Degrees(+64.58901598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151101"},
        {"Hipparcos Number", "HIP 81660"},
        {"Fundamental Katalog 5th Edition", "FK5 3326"},
        {"Geneva Identification System", "GEN# +1.00151101"},
        {"Smithsonian Astrophysical Observation", "SAO 17188"},
        {"Wilson Evans Batten Catalogue", "WEB 13792"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.22966425),
        dec: Angle.Degrees(+64.58908555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58118"},
        {"Hipparcos Number", "HIP 36327"},
        {"Smithsonian Astrophysical Observation", "SAO 14207"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17055389),
        dec: Angle.Degrees(+64.59044043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68579"},
        {"Hipparcos Number", "HIP 40566"},
        {"Smithsonian Astrophysical Observation", "SAO 14481"},
        {"Wilson Evans Batten Catalogue", "WEB 7892"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.23715639),
        dec: Angle.Degrees(+64.59124542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50630"},
        {"Hipparcos Number", "HIP 33587"},
        {"Geneva Identification System", "GEN# +1.00050630"},
        {"Smithsonian Astrophysical Observation", "SAO 14027"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.66372394),
        dec: Angle.Degrees(+64.59251851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198857"},
        {"Hipparcos Number", "HIP 102824"},
        {"Geneva Identification System", "GEN# +1.00198857"},
        {"Smithsonian Astrophysical Observation", "SAO 19057"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.46535657),
        dec: Angle.Degrees(+64.59303276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8767 AB"},
        {"Hipparcos Number", "HIP 63837"},
        {"Smithsonian Astrophysical Observation", "SAO 15975"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.25229216),
        dec: Angle.Degrees(+64.59489647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6596"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.17787353),
        dec: Angle.Degrees(+64.60000956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154633"},
        {"Hipparcos Number", "HIP 83359"},
        {"Geneva Identification System", "GEN# +1.00154633"},
        {"Smithsonian Astrophysical Observation", "SAO 17324"},
        {"Wilson Evans Batten Catalogue", "WEB 14091"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.56573264),
        dec: Angle.Degrees(+64.60065516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35449"},
        {"Hipparcos Number", "HIP 25707"},
        {"Smithsonian Astrophysical Observation", "SAO 13509"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.34755458),
        dec: Angle.Degrees(+64.60151599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204683"},
        {"Hipparcos Number", "HIP 105950"},
        {"Smithsonian Astrophysical Observation", "SAO 19422"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.86350027),
        dec: Angle.Degrees(+64.60326502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75958"},
        {"Hipparcos Number", "HIP 43903"},
        {"Geneva Identification System", "GEN# +1.00075958"},
        {"Smithsonian Astrophysical Observation", "SAO 14703"},
        {"Wilson Evans Batten Catalogue", "WEB 8440"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.15619484),
        dec: Angle.Degrees(+64.60403054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69676"},
        {"Smithsonian Astrophysical Observation", "SAO 16319"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.93533901),
        dec: Angle.Degrees(+64.60698157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22191"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.60345620),
        dec: Angle.Degrees(+64.60811775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63892"},
        {"Smithsonian Astrophysical Observation", "SAO 15983"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42048220),
        dec: Angle.Degrees(+64.61258381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204753"},
        {"Hipparcos Number", "HIP 105988"},
        {"Smithsonian Astrophysical Observation", "SAO 19434"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.99395325),
        dec: Angle.Degrees(+64.61367183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17431"},
        {"Smithsonian Astrophysical Observation", "SAO 12883"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.01284350),
        dec: Angle.Degrees(+64.61412408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29413"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96005364),
        dec: Angle.Degrees(+64.61669664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9312",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1571 A"},
        {"Henry Draper", "HD 11946"},
        {"Hipparcos Number", "HIP 9312"},
        {"Celescope Catalog", "CEL 184"},
        {"Geneva Identification System", "GEN# +1.00011946"},
        {"Smithsonian Astrophysical Observation", "SAO 12076"},
        {"Wilson Evans Batten Catalogue", "WEB 1953"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.90828959),
        dec: Angle.Degrees(+64.62163894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7083"},
        {"Hipparcos Number", "HIP 5648"},
        {"Celescope Catalog", "CEL 128"},
        {"Geneva Identification System", "GEN# +1.00007083"},
        {"Smithsonian Astrophysical Observation", "SAO 11629"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.13288520),
        dec: Angle.Degrees(+64.62241105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84244"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.31677319),
        dec: Angle.Degrees(+64.62347689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 178.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46672"},
        {"Hipparcos Number", "HIP 31839"},
        {"Smithsonian Astrophysical Observation", "SAO 13913"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.84784457),
        dec: Angle.Degrees(+64.62474365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130600"},
        {"Hipparcos Number", "HIP 72198"},
        {"Renson", "Renson 37175"},
        {"Smithsonian Astrophysical Observation", "SAO 16489"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.50662568),
        dec: Angle.Degrees(+64.62586348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108917",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kurhah"},
        {"Aitken", "ADS 15591"},
        {"Hipparcos Number", "HIP 108917"},
        {"Celescope Catalog", "CEL 5430"},
        {"Geneva Identification System", "GEN# +1.00209790"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.94650782),
        dec: Angle.Degrees(+64.62775425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62215"},
        {"Smithsonian Astrophysical Observation", "SAO 15889"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.26608731),
        dec: Angle.Degrees(+64.62788917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120134"},
        {"Hipparcos Number", "HIP 67129"},
        {"Smithsonian Astrophysical Observation", "SAO 16165"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.37430827),
        dec: Angle.Degrees(+64.63072760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17327"},
        {"Hipparcos Number", "HIP 13208"},
        {"Geneva Identification System", "GEN# +1.00017327J"},
        {"Smithsonian Astrophysical Observation", "SAO 12455"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.49219869),
        dec: Angle.Degrees(+64.63080955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28495"},
        {"Hipparcos Number", "HIP 21276"},
        {"Geneva Identification System", "GEN# +1.00028495"},
        {"Smithsonian Astrophysical Observation", "SAO 13185"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.47655589),
        dec: Angle.Degrees(+64.63309430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190713"},
        {"Hipparcos Number", "HIP 98658"},
        {"Geneva Identification System", "GEN# +1.00190713"},
        {"Smithsonian Astrophysical Observation", "SAO 18669"},
        {"Wilson Evans Batten Catalogue", "WEB 17453"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.58399922),
        dec: Angle.Degrees(+64.63439179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4694"},
        {"Hipparcos Number", "HIP 3887"},
        {"Geneva Identification System", "GEN# +1.00004694"},
        {"Smithsonian Astrophysical Observation", "SAO 11418"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.47198674),
        dec: Angle.Degrees(+64.63779136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2042"},
        {"Hipparcos Number", "HIP 1988"},
        {"Smithsonian Astrophysical Observation", "SAO 11177"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.29226960),
        dec: Angle.Degrees(+64.63868453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60076"},
        {"Hipparcos Number", "HIP 37093"},
        {"Smithsonian Astrophysical Observation", "SAO 14258"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.32978794),
        dec: Angle.Degrees(+64.64331744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48922"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.69823616),
        dec: Angle.Degrees(+64.64537794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132166"},
        {"Hipparcos Number", "HIP 72941"},
        {"Smithsonian Astrophysical Observation", "SAO 16546"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.60685582),
        dec: Angle.Degrees(+64.64639792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 553"},
        {"Hipparcos Number", "HIP 834"},
        {"Smithsonian Astrophysical Observation", "SAO 11013"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.54377402),
        dec: Angle.Degrees(+64.64672491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6312",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1088 A"},
        {"Henry Draper", "HD 8003"},
        {"Hipparcos Number", "HIP 6312"},
        {"Geneva Identification System", "GEN# +1.00008003"},
        {"Smithsonian Astrophysical Observation", "SAO 11712"},
        {"Wilson Evans Batten Catalogue", "WEB 1407"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.27160602),
        dec: Angle.Degrees(+64.65818814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190696"},
        {"Hipparcos Number", "HIP 98647"},
        {"Geneva Identification System", "GEN# +1.00190696"},
        {"Smithsonian Astrophysical Observation", "SAO 18667"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.55515141),
        dec: Angle.Degrees(+64.65882324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140453"},
        {"Hipparcos Number", "HIP 76709"},
        {"Smithsonian Astrophysical Observation", "SAO 16806"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.96029128),
        dec: Angle.Degrees(+64.66183366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206922"},
        {"Hipparcos Number", "HIP 107192"},
        {"Smithsonian Astrophysical Observation", "SAO 19597"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.68018342),
        dec: Angle.Degrees(+64.66561729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17631"},
        {"Hipparcos Number", "HIP 13437"},
        {"Geneva Identification System", "GEN# +1.00017631"},
        {"Smithsonian Astrophysical Observation", "SAO 12481"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24364572),
        dec: Angle.Degrees(+64.67001299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8620 AB"},
        {"Hipparcos Number", "HIP 61770"},
        {"Smithsonian Astrophysical Observation", "SAO 15860"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.90169169),
        dec: Angle.Degrees(+64.67422340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17075"},
        {"Hipparcos Number", "HIP 13041"},
        {"Geneva Identification System", "GEN# +1.00017075"},
        {"Smithsonian Astrophysical Observation", "SAO 12439"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.89609826),
        dec: Angle.Degrees(+64.68535108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211902"},
        {"Hipparcos Number", "HIP 110129"},
        {"Smithsonian Astrophysical Observation", "SAO 19995"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62437675),
        dec: Angle.Degrees(+64.68705008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145310"},
        {"Hipparcos Number", "HIP 78876"},
        {"Smithsonian Astrophysical Observation", "SAO 16958"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.52420312),
        dec: Angle.Degrees(+64.68719755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15896"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.18880495),
        dec: Angle.Degrees(+64.68948818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12679"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.73691745),
        dec: Angle.Degrees(+64.69144861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101420",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14022 AB"},
        {"Henry Draper", "HD 196343"},
        {"Hipparcos Number", "HIP 101420"},
        {"Geneva Identification System", "GEN# +1.00196343"},
        {"Smithsonian Astrophysical Observation", "SAO 18924"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.29571870),
        dec: Angle.Degrees(+64.69170648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194376"},
        {"Hipparcos Number", "HIP 100380"},
        {"Smithsonian Astrophysical Observation", "SAO 18829"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37050957),
        dec: Angle.Degrees(+64.69313920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97364",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12974 AB"},
        {"Henry Draper", "HD 187727"},
        {"Hipparcos Number", "HIP 97364"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.84562802),
        dec: Angle.Degrees(+64.69399342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83275"},
        {"Smithsonian Astrophysical Observation", "SAO 17314"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.29278806),
        dec: Angle.Degrees(+64.69406928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186839"},
        {"Hipparcos Number", "HIP 96953"},
        {"Smithsonian Astrophysical Observation", "SAO 18491"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.63532075),
        dec: Angle.Degrees(+64.69532514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73329"},
        {"Hipparcos Number", "HIP 42657"},
        {"Smithsonian Astrophysical Observation", "SAO 14624"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.40169893),
        dec: Angle.Degrees(+64.70583737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8667"},
        {"Hipparcos Number", "HIP 6779"},
        {"Smithsonian Astrophysical Observation", "SAO 11762"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.78793380),
        dec: Angle.Degrees(+64.71093233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70312"},
        {"Hipparcos Number", "HIP 41275"},
        {"Geneva Identification System", "GEN# +1.00070312"},
        {"Smithsonian Astrophysical Observation", "SAO 14539"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.31342749),
        dec: Angle.Degrees(+64.71345405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24024"},
        {"Hipparcos Number", "HIP 18210"},
        {"Smithsonian Astrophysical Observation", "SAO 12948"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.40726892),
        dec: Angle.Degrees(+64.71355447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211758"},
        {"Hipparcos Number", "HIP 110047"},
        {"Geneva Identification System", "GEN# +1.00211758"},
        {"Smithsonian Astrophysical Observation", "SAO 19984"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.35141232),
        dec: Angle.Degrees(+64.71474567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8143 AB"},
        {"Hipparcos Number", "HIP 55573"},
        {"Smithsonian Astrophysical Observation", "SAO 15487"},
    },
    visualMagnitude: 9.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.75647782),
        dec: Angle.Degrees(+64.71541636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61883"},
        {"Hipparcos Number", "HIP 37866"},
        {"Geneva Identification System", "GEN# +1.00061883"},
        {"Smithsonian Astrophysical Observation", "SAO 14310"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.42930712),
        dec: Angle.Degrees(+64.71673747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157701"},
        {"Hipparcos Number", "HIP 84825"},
        {"Smithsonian Astrophysical Observation", "SAO 17439"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.04851795),
        dec: Angle.Degrees(+64.71703517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88575"},
        {"Hipparcos Number", "HIP 50214"},
        {"Geneva Identification System", "GEN# +1.00088575"},
        {"Smithsonian Astrophysical Observation", "SAO 15126"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.76321366),
        dec: Angle.Degrees(+64.71714273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60964"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.46021414),
        dec: Angle.Degrees(+64.71775295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219063"},
        {"Hipparcos Number", "HIP 114540"},
        {"Celescope Catalog", "CEL 5575"},
        {"Geneva Identification System", "GEN# +1.00219063"},
        {"Smithsonian Astrophysical Observation", "SAO 20483"},
        {"Wilson Evans Batten Catalogue", "WEB 20326"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.00653500),
        dec: Angle.Degrees(+64.71923598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117201"},
        {"Hipparcos Number", "HIP 65613"},
        {"Geneva Identification System", "GEN# +1.00117201"},
        {"Smithsonian Astrophysical Observation", "SAO 16079"},
        {"Wilson Evans Batten Catalogue", "WEB 11603"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.79432816),
        dec: Angle.Degrees(+64.71945155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134645"},
        {"Hipparcos Number", "HIP 74013"},
        {"Smithsonian Astrophysical Observation", "SAO 16603"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.88030426),
        dec: Angle.Degrees(+64.71950537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189231"},
        {"Hipparcos Number", "HIP 97988"},
        {"Geneva Identification System", "GEN# +1.00189231"},
        {"Smithsonian Astrophysical Observation", "SAO 18593"},
        {"Wilson Evans Batten Catalogue", "WEB 17249"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.70594149),
        dec: Angle.Degrees(+64.72124397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208105"},
        {"Hipparcos Number", "HIP 107880"},
        {"Smithsonian Astrophysical Observation", "SAO 19683"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.87215176),
        dec: Angle.Degrees(+64.72128082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67627",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9039 A"},
        {"Henry Draper", "HD 121130"},
        {"Hipparcos Number", "HIP 67627"},
        {"Fundamental Katalog 5th Edition", "FK5 511"},
        {"Geneva Identification System", "GEN# +1.00121130"},
        {"Smithsonian Astrophysical Observation", "SAO 16199"},
        {"Wilson Evans Batten Catalogue", "WEB 11891"},
    },
    visualMagnitude: 4.58,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.85807331),
        dec: Angle.Degrees(+64.72328281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47975"},
        {"Smithsonian Astrophysical Observation", "SAO 14985"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.68095272),
        dec: Angle.Degrees(+64.72460023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25305",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3955 AB"},
        {"Henry Draper", "HD 34804"},
        {"Hipparcos Number", "HIP 25305"},
        {"Smithsonian Astrophysical Observation", "SAO 13481"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.19686743),
        dec: Angle.Degrees(+64.73126287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5236 A"},
        {"Henry Draper", "HD 46463"},
        {"Hipparcos Number", "HIP 31729"},
        {"Fundamental Katalog 5th Edition", "FK5 4603"},
        {"Geneva Identification System", "GEN# +1.00046463"},
        {"Smithsonian Astrophysical Observation", "SAO 13901"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.57816390),
        dec: Angle.Degrees(+64.73500484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111524"},
        {"Hipparcos Number", "HIP 62546"},
        {"Geneva Identification System", "GEN# +1.00111524"},
        {"Smithsonian Astrophysical Observation", "SAO 15910"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.23352336),
        dec: Angle.Degrees(+64.73510054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117200"},
        {"Hipparcos Number", "HIP 65603"},
        {"Geneva Identification System", "GEN# +1.00117200"},
        {"Smithsonian Astrophysical Observation", "SAO 16078"},
        {"Wilson Evans Batten Catalogue", "WEB 11602"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.76959752),
        dec: Angle.Degrees(+64.73544104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45207"},
        {"Smithsonian Astrophysical Observation", "SAO 14804"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.19270388),
        dec: Angle.Degrees(+64.73818784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9811"},
        {"Hipparcos Number", "HIP 7593"},
        {"Geneva Identification System", "GEN# +1.00009811"},
        {"Smithsonian Astrophysical Observation", "SAO 11875"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.44666689),
        dec: Angle.Degrees(+64.73935565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220208"},
        {"Hipparcos Number", "HIP 115304"},
        {"Celescope Catalog", "CEL 5604"},
        {"Geneva Identification System", "GEN# +1.00220208"},
        {"Smithsonian Astrophysical Observation", "SAO 20580"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.29990698),
        dec: Angle.Degrees(+64.74067422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117069"},
        {"Cincinnati Publication", "Ci 20 1448"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99478457),
        dec: Angle.Degrees(+64.74114776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 542.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37503"},
        {"Hipparcos Number", "HIP 27018"},
        {"Geneva Identification System", "GEN# +1.00037503"},
        {"Smithsonian Astrophysical Observation", "SAO 13580"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95845992),
        dec: Angle.Degrees(+64.74265627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144013"},
        {"Hipparcos Number", "HIP 78328"},
        {"Smithsonian Astrophysical Observation", "SAO 16913"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.90794046),
        dec: Angle.Degrees(+64.74513956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126581"},
        {"Hipparcos Number", "HIP 70352"},
        {"Smithsonian Astrophysical Observation", "SAO 16367"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.91739999),
        dec: Angle.Degrees(+64.74620193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64911"},
        {"Hipparcos Number", "HIP 39147"},
        {"Geneva Identification System", "GEN# +1.00064911"},
        {"Smithsonian Astrophysical Observation", "SAO 14394"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09982416),
        dec: Angle.Degrees(+64.74723674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2765 AB"},
        {"Henry Draper", "HD 23406"},
        {"Hipparcos Number", "HIP 17831"},
        {"Geneva Identification System", "GEN# +1.00023406"},
        {"Smithsonian Astrophysical Observation", "SAO 12909"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.23549702),
        dec: Angle.Degrees(+64.74848402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28753"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.07841285),
        dec: Angle.Degrees(+64.74865513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2610"},
        {"Hipparcos Number", "HIP 2371"},
        {"Geneva Identification System", "GEN# +1.00002610"},
        {"Smithsonian Astrophysical Observation", "SAO 11228"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.56810986),
        dec: Angle.Degrees(+64.74898345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202734"},
        {"Hipparcos Number", "HIP 104886"},
        {"Smithsonian Astrophysical Observation", "SAO 19265"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.69394609),
        dec: Angle.Degrees(+64.75033076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168267"},
        {"Hipparcos Number", "HIP 89367"},
        {"Smithsonian Astrophysical Observation", "SAO 17831"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.55110152),
        dec: Angle.Degrees(+64.75230843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48547"},
        {"Hipparcos Number", "HIP 32653"},
        {"Smithsonian Astrophysical Observation", "SAO 13957"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.16856156),
        dec: Angle.Degrees(+64.75434394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218030"},
        {"Hipparcos Number", "HIP 113871"},
        {"Geneva Identification System", "GEN# +1.00218030"},
        {"Smithsonian Astrophysical Observation", "SAO 20397"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.90194376),
        dec: Angle.Degrees(+64.75723329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27289"},
        {"Smithsonian Astrophysical Observation", "SAO 13605"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.74052918),
        dec: Angle.Degrees(+64.75782239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41838"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.93912208),
        dec: Angle.Degrees(+64.75855607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4004"},
        {"Hipparcos Number", "HIP 3415"},
        {"Geneva Identification System", "GEN# +1.00004004"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.86833670),
        dec: Angle.Degrees(+64.75983074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193030"},
        {"Hipparcos Number", "HIP 99731"},
        {"Geneva Identification System", "GEN# +1.00193030"},
        {"Smithsonian Astrophysical Observation", "SAO 18775"},
        {"Wilson Evans Batten Catalogue", "WEB 17899"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.54437676),
        dec: Angle.Degrees(+64.76514727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89311"},
        {"Smithsonian Astrophysical Observation", "SAO 17824"},
    },
    visualMagnitude: 9.43,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.35936248),
        dec: Angle.Degrees(+64.76603890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162897"},
        {"Hipparcos Number", "HIP 87179"},
        {"Smithsonian Astrophysical Observation", "SAO 17642"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.16861330),
        dec: Angle.Degrees(+64.76660988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37856"},
        {"Hipparcos Number", "HIP 27227"},
        {"Smithsonian Astrophysical Observation", "SAO 13602"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.55260283),
        dec: Angle.Degrees(+64.76900885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106878"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.71336386),
        dec: Angle.Degrees(+64.76963154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87457"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.04927842),
        dec: Angle.Degrees(+64.76986513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -347.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94010"},
        {"Hipparcos Number", "HIP 53158"},
        {"Smithsonian Astrophysical Observation", "SAO 15316"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13463874),
        dec: Angle.Degrees(+64.77517918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60173"},
        {"Smithsonian Astrophysical Observation", "SAO 15773"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.08973095),
        dec: Angle.Degrees(+64.77637043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5358"},
        {"Hipparcos Number", "HIP 4421"},
        {"Geneva Identification System", "GEN# +1.00005358"},
        {"Smithsonian Astrophysical Observation", "SAO 11480"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.15813092),
        dec: Angle.Degrees(+64.77653279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44666"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.53641156),
        dec: Angle.Degrees(+64.77954358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55077"},
        {"Hipparcos Number", "HIP 35161"},
        {"Geneva Identification System", "GEN# +1.00055077"},
        {"Smithsonian Astrophysical Observation", "SAO 14129"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.00805295),
        dec: Angle.Degrees(+64.78100867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225273"},
        {"Hipparcos Number", "HIP 402"},
        {"Geneva Identification System", "GEN# +1.00225273"},
        {"Smithsonian Astrophysical Observation", "SAO 10959"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23494365),
        dec: Angle.Degrees(+64.78140759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9122"},
        {"Smithsonian Astrophysical Observation", "SAO 12052"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.40208437),
        dec: Angle.Degrees(+64.78259370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149222"},
        {"Hipparcos Number", "HIP 80738"},
        {"Geneva Identification System", "GEN# +1.00149222"},
        {"Smithsonian Astrophysical Observation", "SAO 17111"},
        {"Wilson Evans Batten Catalogue", "WEB 13656"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.25544248),
        dec: Angle.Degrees(+64.78645188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51529"},
        {"Smithsonian Astrophysical Observation", "SAO 15209"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.87351015),
        dec: Angle.Degrees(+64.78666402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175883"},
        {"Hipparcos Number", "HIP 92673"},
        {"Smithsonian Astrophysical Observation", "SAO 18059"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25553894),
        dec: Angle.Degrees(+64.78764154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212042"},
        {"Hipparcos Number", "HIP 110214"},
        {"Geneva Identification System", "GEN# +1.00212042"},
        {"Smithsonian Astrophysical Observation", "SAO 20010"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.88165411),
        dec: Angle.Degrees(+64.78859934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7556 A"},
        {"Henry Draper", "HD 85360"},
        {"Hipparcos Number", "HIP 48531"},
        {"Smithsonian Astrophysical Observation", "SAO 15013"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.47515221),
        dec: Angle.Degrees(+64.78893538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15727"},
        {"Hipparcos Number", "HIP 11987"},
        {"Geneva Identification System", "GEN# +1.00015727"},
        {"Smithsonian Astrophysical Observation", "SAO 12338"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.65078639),
        dec: Angle.Degrees(+64.78912502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2378"},
        {"Smithsonian Astrophysical Observation", "SAO 11230"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.58690585),
        dec: Angle.Degrees(+64.79026279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68770"},
        {"Hipparcos Number", "HIP 40653"},
        {"Geneva Identification System", "GEN# +1.00068770"},
        {"Smithsonian Astrophysical Observation", "SAO 14490"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.47852985),
        dec: Angle.Degrees(+64.79192730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81872"},
        {"Smithsonian Astrophysical Observation", "SAO 17201"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.83514587),
        dec: Angle.Degrees(+64.79620624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106916"},
        {"Smithsonian Astrophysical Observation", "SAO 19557"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.79363318),
        dec: Angle.Degrees(+64.79907529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142342"},
        {"Hipparcos Number", "HIP 77564"},
        {"Smithsonian Astrophysical Observation", "SAO 16870"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.53342187),
        dec: Angle.Degrees(+64.79967514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96001"},
        {"Hipparcos Number", "HIP 54218"},
        {"Geneva Identification System", "GEN# +1.00096001"},
        {"Smithsonian Astrophysical Observation", "SAO 15393"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.40075047),
        dec: Angle.Degrees(+64.80395785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17073"},
        {"Geneva Identification System", "GEN# +0.06400400"},
        {"Smithsonian Astrophysical Observation", "SAO 12846"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.88570015),
        dec: Angle.Degrees(+64.80501821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27984"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.77442405),
        dec: Angle.Degrees(+64.80556616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174156"},
        {"Hipparcos Number", "HIP 91950"},
        {"Fundamental Katalog 5th Edition", "FK5 5646"},
        {"Smithsonian Astrophysical Observation", "SAO 18003"},
        {"Wilson Evans Batten Catalogue", "WEB 15835"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.14709803),
        dec: Angle.Degrees(+64.80988437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29826"},
        {"Hipparcos Number", "HIP 22190"},
        {"Geneva Identification System", "GEN# +1.00029826"},
        {"Smithsonian Astrophysical Observation", "SAO 13260"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.60208798),
        dec: Angle.Degrees(+64.81042629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73773"},
        {"Cincinnati Publication", "Ci 18 2013"},
        {"Geneva Identification System", "GEN# +0.06501033"},
        {"Smithsonian Astrophysical Observation", "SAO 16589"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.19712447),
        dec: Angle.Degrees(+64.81217396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110093"},
        {"Smithsonian Astrophysical Observation", "SAO 19990"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.52434223),
        dec: Angle.Degrees(+64.81381406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106286"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.91299154),
        dec: Angle.Degrees(+64.81884175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190544"},
        {"Hipparcos Number", "HIP 98583"},
        {"Fundamental Katalog 5th Edition", "FK5 3604"},
        {"Geneva Identification System", "GEN# +1.00190544"},
        {"Smithsonian Astrophysical Observation", "SAO 18658"},
        {"Wilson Evans Batten Catalogue", "WEB 17431"},
    },
    visualMagnitude: 5.22,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.36888221),
        dec: Angle.Degrees(+64.82100457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119476"},
        {"Hipparcos Number", "HIP 66798"},
        {"Fundamental Katalog 5th Edition", "FK5 3088"},
        {"Geneva Identification System", "GEN# +1.00119476"},
        {"Smithsonian Astrophysical Observation", "SAO 16142"},
        {"Wilson Evans Batten Catalogue", "WEB 11777"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.37423739),
        dec: Angle.Degrees(+64.82243969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18611"},
        {"Hipparcos Number", "HIP 14184"},
        {"Smithsonian Astrophysical Observation", "SAO 12574"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.72397532),
        dec: Angle.Degrees(+64.82568830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10173"},
        {"Smithsonian Astrophysical Observation", "SAO 12155"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.70785779),
        dec: Angle.Degrees(+64.82918850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176796"},
        {"Hipparcos Number", "HIP 93062"},
        {"Geneva Identification System", "GEN# +1.00176796"},
        {"Smithsonian Astrophysical Observation", "SAO 18086"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.34811689),
        dec: Angle.Degrees(+64.83083094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42756"},
        {"Hipparcos Number", "HIP 29864"},
        {"Smithsonian Astrophysical Observation", "SAO 13779"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.32788242),
        dec: Angle.Degrees(+64.83193132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
