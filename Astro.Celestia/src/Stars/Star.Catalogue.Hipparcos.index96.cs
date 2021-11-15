using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_96() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217800"},
        {"Hipparcos Number", "HIP 113804"},
        {"Smithsonian Astrophysical Observation", "SAO 72952"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.69006971),
        dec: Angle.Degrees(+39.89125351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90809"},
        {"Smithsonian Astrophysical Observation", "SAO 67076"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.86867964),
        dec: Angle.Degrees(+39.89143524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59366",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8446 AB"},
        {"Henry Draper", "HD 105824"},
        {"Hipparcos Number", "HIP 59366"},
        {"Geneva Identification System", "GEN# +1.00105824J"},
        {"Smithsonian Astrophysical Observation", "SAO 44064"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.69726579),
        dec: Angle.Degrees(+39.89153702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4553"},
        {"Smithsonian Astrophysical Observation", "SAO 54302"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.56097210),
        dec: Angle.Degrees(+39.89190877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71027"},
        {"Hipparcos Number", "HIP 41406"},
        {"Fundamental Katalog 5th Edition", "FK5 4759"},
        {"Geneva Identification System", "GEN# +1.00071027"},
        {"Smithsonian Astrophysical Observation", "SAO 42360"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.69614599),
        dec: Angle.Degrees(+39.89225290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129310"},
        {"Hipparcos Number", "HIP 71753"},
        {"Geneva Identification System", "GEN# +1.00129310"},
        {"Smithsonian Astrophysical Observation", "SAO 45164"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.15888776),
        dec: Angle.Degrees(+39.89233792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62638"},
        {"Geneva Identification System", "GEN# +0.04002579"},
        {"Smithsonian Astrophysical Observation", "SAO 44347"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.53052267),
        dec: Angle.Degrees(+39.89339539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108254"},
        {"Hipparcos Number", "HIP 60671"},
        {"Geneva Identification System", "GEN# +1.00108254"},
        {"Smithsonian Astrophysical Observation", "SAO 44176"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.51074519),
        dec: Angle.Degrees(+39.89428531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16219"},
        {"Hipparcos Number", "HIP 12218"},
        {"Geneva Identification System", "GEN# +1.00016219"},
        {"Smithsonian Astrophysical Observation", "SAO 55715"},
        {"Wilson Evans Batten Catalogue", "WEB 2509"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.33679508),
        dec: Angle.Degrees(+39.89612673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83904"},
        {"Smithsonian Astrophysical Observation", "SAO 65826"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.22475285),
        dec: Angle.Degrees(+39.89632990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64928"},
        {"Smithsonian Astrophysical Observation", "SAO 44557"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.61585143),
        dec: Angle.Degrees(+39.89831610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225786"},
        {"Hipparcos Number", "HIP 97334"},
        {"Smithsonian Astrophysical Observation", "SAO 68848"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.73914428),
        dec: Angle.Degrees(+39.89937474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21912"},
        {"Hipparcos Number", "HIP 16591"},
        {"Fundamental Katalog 5th Edition", "FK5 2254"},
        {"Geneva Identification System", "GEN# +1.00021912"},
        {"Renson", "Renson 5510"},
        {"Smithsonian Astrophysical Observation", "SAO 56538"},
        {"Wilson Evans Batten Catalogue", "WEB 3165"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.39592658),
        dec: Angle.Degrees(+39.89959026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213117"},
        {"Hipparcos Number", "HIP 110928"},
        {"Smithsonian Astrophysical Observation", "SAO 72382"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.11865268),
        dec: Angle.Degrees(+39.89986391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67354"},
        {"Wilson Evans Batten Catalogue", "WEB 11849"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.06640153),
        dec: Angle.Degrees(+39.90094195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 776"},
        {"Hipparcos Number", "HIP 986"},
        {"Geneva Identification System", "GEN# +1.00000776"},
        {"Smithsonian Astrophysical Observation", "SAO 53715"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.05769033),
        dec: Angle.Degrees(+39.90157203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47100"},
        {"Hipparcos Number", "HIP 31789"},
        {"Geneva Identification System", "GEN# +1.00047100"},
        {"Smithsonian Astrophysical Observation", "SAO 59319"},
        {"Wilson Evans Batten Catalogue", "WEB 6380"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.70494411),
        dec: Angle.Degrees(+39.90258791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138339"},
        {"Hipparcos Number", "HIP 75894"},
        {"Geneva Identification System", "GEN# +1.00138339"},
        {"Smithsonian Astrophysical Observation", "SAO 45569"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.52300357),
        dec: Angle.Degrees(+39.90901113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20042"},
        {"Hipparcos Number", "HIP 15094"},
        {"Smithsonian Astrophysical Observation", "SAO 56277"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.68333395),
        dec: Angle.Degrees(+39.91015729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65542"},
        {"Hipparcos Number", "HIP 39189"},
        {"Smithsonian Astrophysical Observation", "SAO 42123"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.23146849),
        dec: Angle.Degrees(+39.91023530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177592"},
        {"Hipparcos Number", "HIP 93594"},
        {"Smithsonian Astrophysical Observation", "SAO 67757"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91353807),
        dec: Angle.Degrees(+39.91091229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27454"},
        {"Smithsonian Astrophysical Observation", "SAO 58458"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.19727725),
        dec: Angle.Degrees(+39.91214871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127615"},
        {"Hipparcos Number", "HIP 71000"},
        {"Geneva Identification System", "GEN# +1.00127615"},
        {"Smithsonian Astrophysical Observation", "SAO 45086"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.81434207),
        dec: Angle.Degrees(+39.91248519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125374"},
        {"Hipparcos Number", "HIP 69876"},
        {"Geneva Identification System", "GEN# +1.00125374"},
        {"Smithsonian Astrophysical Observation", "SAO 44980"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.49169511),
        dec: Angle.Degrees(+39.91262022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3122 AB"},
        {"Henry Draper", "HD 27225"},
        {"Hipparcos Number", "HIP 20196"},
        {"Smithsonian Astrophysical Observation", "SAO 57154"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.92992689),
        dec: Angle.Degrees(+39.91555562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81888"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.90918719),
        dec: Angle.Degrees(+39.91765799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56760"},
        {"Hipparcos Number", "HIP 35558"},
        {"Smithsonian Astrophysical Observation", "SAO 41699"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.05722717),
        dec: Angle.Degrees(+39.91800755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92903"},
        {"Hipparcos Number", "HIP 52510"},
        {"Geneva Identification System", "GEN# +1.00092903"},
        {"Smithsonian Astrophysical Observation", "SAO 43454"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.05121412),
        dec: Angle.Degrees(+39.91931604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32132"},
        {"Smithsonian Astrophysical Observation", "SAO 59389"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.65595007),
        dec: Angle.Degrees(+39.92029861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47164"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.16354353),
        dec: Angle.Degrees(+39.92124084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61222"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.18712017),
        dec: Angle.Degrees(+39.92228933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166276"},
        {"Hipparcos Number", "HIP 88834"},
        {"Fundamental Katalog 5th Edition", "FK5 5599"},
        {"Geneva Identification System", "GEN# +1.00166276"},
        {"Smithsonian Astrophysical Observation", "SAO 66669"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.99702547),
        dec: Angle.Degrees(+39.92329311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8420"},
        {"Hipparcos Number", "HIP 6533"},
        {"Smithsonian Astrophysical Observation", "SAO 54659"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.99308125),
        dec: Angle.Degrees(+39.92428168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65938"},
        {"Geneva Identification System", "GEN# +0.04002661"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.76862824),
        dec: Angle.Degrees(+39.92437365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65586"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.69590991),
        dec: Angle.Degrees(+39.92531922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89809"},
        {"Hipparcos Number", "HIP 50830"},
        {"Smithsonian Astrophysical Observation", "SAO 43312"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.68646731),
        dec: Angle.Degrees(+39.92581640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181878"},
        {"Hipparcos Number", "HIP 95056"},
        {"Geneva Identification System", "GEN# +1.00181878"},
        {"Smithsonian Astrophysical Observation", "SAO 68166"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.11290387),
        dec: Angle.Degrees(+39.92620726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102427"},
        {"Hipparcos Number", "HIP 57535"},
        {"Geneva Identification System", "GEN# +1.00102427"},
        {"Smithsonian Astrophysical Observation", "SAO 43891"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.87707826),
        dec: Angle.Degrees(+39.92788523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49904"},
        {"Hipparcos Number", "HIP 33002"},
        {"Smithsonian Astrophysical Observation", "SAO 59566"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.15128252),
        dec: Angle.Degrees(+39.92894479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102519"},
        {"Geneva Identification System", "GEN# +0.03904313"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.63950103),
        dec: Angle.Degrees(+39.93007218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29714"},
        {"Smithsonian Astrophysical Observation", "SAO 58901"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.88090812),
        dec: Angle.Degrees(+39.93194392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118020"},
        {"Hipparcos Number", "HIP 66135"},
        {"Geneva Identification System", "GEN# +1.00118020"},
        {"Smithsonian Astrophysical Observation", "SAO 44656"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.36042112),
        dec: Angle.Degrees(+39.93363386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20395",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3155 A"},
        {"Henry Draper", "HD 27495"},
        {"Hipparcos Number", "HIP 20395"},
        {"Geneva Identification System", "GEN# +1.00027495"},
        {"Smithsonian Astrophysical Observation", "SAO 57186"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.50108584),
        dec: Angle.Degrees(+39.93424726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208342"},
        {"Hipparcos Number", "HIP 108155"},
        {"Smithsonian Astrophysical Observation", "SAO 71828"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68625103),
        dec: Angle.Degrees(+39.93543126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183679"},
        {"Hipparcos Number", "HIP 95792"},
        {"Geneva Identification System", "GEN# +1.00183679"},
        {"Smithsonian Astrophysical Observation", "SAO 68382"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.25318518),
        dec: Angle.Degrees(+39.93615548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71388"},
        {"Hipparcos Number", "HIP 41592"},
        {"Geneva Identification System", "GEN# +1.00071388"},
        {"Smithsonian Astrophysical Observation", "SAO 42384"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.18707823),
        dec: Angle.Degrees(+39.93677548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195689"},
        {"Hipparcos Number", "HIP 101252"},
        {"Celescope Catalog", "CEL 5094"},
        {"Geneva Identification System", "GEN# +1.00195689"},
        {"Smithsonian Astrophysical Observation", "SAO 70152"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.85975292),
        dec: Angle.Degrees(+39.93877500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49703"},
        {"Smithsonian Astrophysical Observation", "SAO 43210"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.19176652),
        dec: Angle.Degrees(+39.93886046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26537"},
        {"Smithsonian Astrophysical Observation", "SAO 58277"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65978384),
        dec: Angle.Degrees(+39.94031092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183585"},
        {"Hipparcos Number", "HIP 95764"},
        {"Geneva Identification System", "GEN# +1.00183585"},
        {"Smithsonian Astrophysical Observation", "SAO 68373"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16050606),
        dec: Angle.Degrees(+39.94085004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33396"},
        {"Hipparcos Number", "HIP 24209"},
        {"Smithsonian Astrophysical Observation", "SAO 57730"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.97548765),
        dec: Angle.Degrees(+39.94528227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11607"},
        {"Hipparcos Number", "HIP 8911"},
        {"Geneva Identification System", "GEN# +1.00011607"},
        {"Smithsonian Astrophysical Observation", "SAO 55077"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.67672673),
        dec: Angle.Degrees(+39.94926314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49403"},
        {"Hipparcos Number", "HIP 32792"},
        {"Smithsonian Astrophysical Observation", "SAO 41376"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.54944359),
        dec: Angle.Degrees(+39.95314355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69891"},
        {"Smithsonian Astrophysical Observation", "SAO 44984"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.54587982),
        dec: Angle.Degrees(+39.95325790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133855"},
        {"Hipparcos Number", "HIP 73829"},
        {"Smithsonian Astrophysical Observation", "SAO 45367"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33384596),
        dec: Angle.Degrees(+39.95379467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41998"},
        {"Smithsonian Astrophysical Observation", "SAO 42429"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.40785411),
        dec: Angle.Degrees(+39.95428786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107015"},
        {"Hipparcos Number", "HIP 59994"},
        {"Smithsonian Astrophysical Observation", "SAO 44112"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.56307570),
        dec: Angle.Degrees(+39.95584023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47054",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7438 B"},
        {"Hipparcos Number", "HIP 47054"},
        {"Geneva Identification System", "GEN# +1.00082780B"},
        {"Smithsonian Astrophysical Observation", "SAO 42932"},
        {"Wilson Evans Batten Catalogue", "WEB 8864"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.84839750),
        dec: Angle.Degrees(+39.95727905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135122"},
        {"Hipparcos Number", "HIP 74384"},
        {"Smithsonian Astrophysical Observation", "SAO 45427"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.00886587),
        dec: Angle.Degrees(+39.95742089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -252.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51432"},
        {"Smithsonian Astrophysical Observation", "SAO 43364"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.56149201),
        dec: Angle.Degrees(+39.95776285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8131",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1368 AB"},
        {"Henry Draper", "HD 10629"},
        {"Hipparcos Number", "HIP 8131"},
        {"Smithsonian Astrophysical Observation", "SAO 54946"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.12821522),
        dec: Angle.Degrees(+39.95865673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57204"},
        {"Hipparcos Number", "HIP 35702"},
        {"Geneva Identification System", "GEN# +1.00057204"},
        {"Smithsonian Astrophysical Observation", "SAO 41716"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.49953625),
        dec: Angle.Degrees(+39.96007467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31913"},
        {"Hipparcos Number", "HIP 23360"},
        {"Geneva Identification System", "GEN# +1.00031913"},
        {"Smithsonian Astrophysical Observation", "SAO 57573"},
        {"Wilson Evans Batten Catalogue", "WEB 4535"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.34661515),
        dec: Angle.Degrees(+39.96040144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48053"},
        {"Hipparcos Number", "HIP 32211"},
        {"Smithsonian Astrophysical Observation", "SAO 41293"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.85324310),
        dec: Angle.Degrees(+39.96082164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183204"},
        {"Hipparcos Number", "HIP 95605"},
        {"Celescope Catalog", "CEL 4758"},
        {"Geneva Identification System", "GEN# +1.00183204"},
        {"Smithsonian Astrophysical Observation", "SAO 68318"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.68430120),
        dec: Angle.Degrees(+39.96150716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7438 A"},
        {"Henry Draper", "HD 82780"},
        {"Hipparcos Number", "HIP 47053"},
        {"Geneva Identification System", "GEN# +1.00082780A"},
        {"Smithsonian Astrophysical Observation", "SAO 42931"},
        {"Wilson Evans Batten Catalogue", "WEB 8863"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.84374080),
        dec: Angle.Degrees(+39.96323722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1053 A"},
        {"Henry Draper", "HD 7864"},
        {"Hipparcos Number", "HIP 6144"},
        {"Geneva Identification System", "GEN# +1.00007864"},
        {"Smithsonian Astrophysical Observation", "SAO 54593"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.72147053),
        dec: Angle.Degrees(+39.96334070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12186"},
        {"Hipparcos Number", "HIP 9378"},
        {"Geneva Identification System", "GEN# +1.00012186"},
        {"Smithsonian Astrophysical Observation", "SAO 55182"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.12671135),
        dec: Angle.Degrees(+39.96701157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156679"},
        {"Hipparcos Number", "HIP 84559"},
        {"Smithsonian Astrophysical Observation", "SAO 46603"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.28251150),
        dec: Angle.Degrees(+39.96824334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32377"},
        {"Hipparcos Number", "HIP 23613"},
        {"Celescope Catalog", "CEL 523"},
        {"Geneva Identification System", "GEN# +1.00032377"},
        {"Smithsonian Astrophysical Observation", "SAO 57611"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15655527),
        dec: Angle.Degrees(+39.96920782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28197"},
        {"Smithsonian Astrophysical Observation", "SAO 58605"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.37612632),
        dec: Angle.Degrees(+39.96928659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74061"},
        {"Wilson Evans Batten Catalogue", "WEB 12653"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.03833630),
        dec: Angle.Degrees(+39.97009678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104002"},
        {"Geneva Identification System", "GEN# +0.03904423"},
        {"Wilson Evans Batten Catalogue", "WEB 18945"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.06932633),
        dec: Angle.Degrees(+39.97226194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109913"},
        {"Hipparcos Number", "HIP 61644"},
        {"Geneva Identification System", "GEN# +1.00109913"},
        {"Smithsonian Astrophysical Observation", "SAO 44261"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.56084123),
        dec: Angle.Degrees(+39.97389118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159239"},
        {"Hipparcos Number", "HIP 85785"},
        {"Geneva Identification System", "GEN# +1.00159239"},
        {"Smithsonian Astrophysical Observation", "SAO 46776"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.94255239),
        dec: Angle.Degrees(+39.97465760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157482"},
        {"Hipparcos Number", "HIP 84949"},
        {"Geneva Identification System", "GEN# +1.00157482"},
        {"Smithsonian Astrophysical Observation", "SAO 46664"},
        {"Wilson Evans Batten Catalogue", "WEB 14347"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.43172028),
        dec: Angle.Degrees(+39.97480822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97560"},
        {"Hipparcos Number", "HIP 54858"},
        {"Cincinnati Publication", "Ci 18 1370"},
        {"Geneva Identification System", "GEN# +1.00097560"},
        {"Smithsonian Astrophysical Observation", "SAO 43651"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.47917681),
        dec: Angle.Degrees(+39.97804247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81012"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.16341478),
        dec: Angle.Degrees(+39.98004259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123281"},
        {"Hipparcos Number", "HIP 68841"},
        {"Smithsonian Astrophysical Observation", "SAO 44881"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.44317522),
        dec: Angle.Degrees(+39.98008244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162208"},
        {"Hipparcos Number", "HIP 87118"},
        {"Geneva Identification System", "GEN# +1.00162208"},
        {"Smithsonian Astrophysical Observation", "SAO 66344"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.99402903),
        dec: Angle.Degrees(+39.98049443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101023"},
        {"Geneva Identification System", "GEN# +0.03904208"},
    },
    visualMagnitude: 8.22,
    bvColour: 2.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.21080422),
        dec: Angle.Degrees(+39.98179721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162989"},
        {"Hipparcos Number", "HIP 87445"},
        {"Fundamental Katalog 5th Edition", "FK5 3419"},
        {"Geneva Identification System", "GEN# +1.00162989"},
        {"Smithsonian Astrophysical Observation", "SAO 66402"},
        {"Wilson Evans Batten Catalogue", "WEB 14750"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01970821),
        dec: Angle.Degrees(+39.98196397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86588"},
        {"Smithsonian Astrophysical Observation", "SAO 46888"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.43521879),
        dec: Angle.Degrees(+39.98654387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68252"},
        {"Hipparcos Number", "HIP 40245"},
        {"Smithsonian Astrophysical Observation", "SAO 42231"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.29947307),
        dec: Angle.Degrees(+39.98706628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81015"},
        {"Smithsonian Astrophysical Observation", "SAO 46153"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.17002750),
        dec: Angle.Degrees(+39.98725317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106329"},
        {"Hipparcos Number", "HIP 59648"},
        {"Geneva Identification System", "GEN# +1.00106329"},
        {"Smithsonian Astrophysical Observation", "SAO 44084"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.48649177),
        dec: Angle.Degrees(+39.98776772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105370"},
        {"Hipparcos Number", "HIP 59161"},
        {"Smithsonian Astrophysical Observation", "SAO 44042"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.99129313),
        dec: Angle.Degrees(+39.98870436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7438 C"},
        {"Henry Draper", "HD 82767"},
        {"Hipparcos Number", "HIP 47046"},
        {"Geneva Identification System", "GEN# +1.00082767"},
        {"Smithsonian Astrophysical Observation", "SAO 42930"},
        {"Wilson Evans Batten Catalogue", "WEB 8862"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.81821075),
        dec: Angle.Degrees(+39.98911925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119112"},
        {"Hipparcos Number", "HIP 66715"},
        {"Geneva Identification System", "GEN# +1.00119112"},
        {"Smithsonian Astrophysical Observation", "SAO 44705"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.12993623),
        dec: Angle.Degrees(+39.98991757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6314"},
        {"Hipparcos Number", "HIP 5045"},
        {"Geneva Identification System", "GEN# +1.00006314"},
        {"Smithsonian Astrophysical Observation", "SAO 54398"},
        {"Wilson Evans Batten Catalogue", "WEB 1032"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.15166564),
        dec: Angle.Degrees(+39.99116315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225054"},
        {"Hipparcos Number", "HIP 244"},
        {"Geneva Identification System", "GEN# +1.00225054"},
        {"Smithsonian Astrophysical Observation", "SAO 53600"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.75886478),
        dec: Angle.Degrees(+39.99515242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90525"},
        {"Smithsonian Astrophysical Observation", "SAO 67008"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.07844961),
        dec: Angle.Degrees(+39.99680887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186505"},
        {"Hipparcos Number", "HIP 97018"},
        {"Celescope Catalog", "CEL 4828"},
        {"Geneva Identification System", "GEN# +1.00186505"},
        {"Smithsonian Astrophysical Observation", "SAO 68748"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76874198),
        dec: Angle.Degrees(+39.99707659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227626"},
        {"Hipparcos Number", "HIP 98982"},
        {"Smithsonian Astrophysical Observation", "SAO 69395"},
        {"Wilson Evans Batten Catalogue", "WEB 17580"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42767022),
        dec: Angle.Degrees(+39.99759230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79031"},
        {"Hipparcos Number", "HIP 45211"},
        {"Smithsonian Astrophysical Observation", "SAO 42746"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.19948954),
        dec: Angle.Degrees(+39.99966655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104128"},
        {"Hipparcos Number", "HIP 58486"},
        {"Geneva Identification System", "GEN# +1.00104128"},
        {"Smithsonian Astrophysical Observation", "SAO 43986"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.91447414),
        dec: Angle.Degrees(+39.99993174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34501"},
        {"Smithsonian Astrophysical Observation", "SAO 41585"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.22694579),
        dec: Angle.Degrees(+40.00140956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114612",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16599 A"},
        {"Henry Draper", "HD 219127"},
        {"Hipparcos Number", "HIP 114612"},
        {"Geneva Identification System", "GEN# +1.00219127"},
        {"Smithsonian Astrophysical Observation", "SAO 73090"},
        {"Wilson Evans Batten Catalogue", "WEB 20332"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.27631438),
        dec: Angle.Degrees(+40.00281153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55718"},
        {"Geneva Identification System", "GEN# +6.20030039"},
        {"Wilson Evans Batten Catalogue", "WEB 10013"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24944172),
        dec: Angle.Degrees(+40.00356544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16599 B"},
        {"Hipparcos Number", "HIP 114611"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.27133091),
        dec: Angle.Degrees(+40.00383446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54105"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.06685308),
        dec: Angle.Degrees(+40.00486798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87563",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10875 A"},
        {"Henry Draper", "HD 163217"},
        {"Hipparcos Number", "HIP 87563"},
        {"Geneva Identification System", "GEN# +1.00163217"},
        {"Smithsonian Astrophysical Observation", "SAO 47037"},
        {"Wilson Evans Batten Catalogue", "WEB 14771"},
    },
    visualMagnitude: 5.17,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.32509092),
        dec: Angle.Degrees(+40.00783707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28503"},
        {"Hipparcos Number", "HIP 21108"},
        {"Geneva Identification System", "GEN# +1.00028503J"},
        {"Smithsonian Astrophysical Observation", "SAO 57278"},
        {"Wilson Evans Batten Catalogue", "WEB 4059"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.85040925),
        dec: Angle.Degrees(+40.01021496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2888 A"},
        {"Henry Draper", "HD 24760"},
        {"Hipparcos Number", "HIP 18532"},
        {"Celescope Catalog", "CEL 373"},
        {"Fundamental Katalog 5th Edition", "FK5 147"},
        {"Geneva Identification System", "GEN# +1.00024760A"},
        {"Smithsonian Astrophysical Observation", "SAO 56840"},
        {"Wilson Evans Batten Catalogue", "WEB 3572"},
    },
    visualMagnitude: 2.90,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.46342138),
        dec: Angle.Degrees(+40.01027315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54870"},
        {"Hipparcos Number", "HIP 34822"},
        {"Smithsonian Astrophysical Observation", "SAO 41621"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.11365563),
        dec: Angle.Degrees(+40.01086883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25022"},
        {"Hipparcos Number", "HIP 18688"},
        {"Geneva Identification System", "GEN# +1.00025022"},
        {"Smithsonian Astrophysical Observation", "SAO 56876"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.04352861),
        dec: Angle.Degrees(+40.01371803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84403"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.83511476),
        dec: Angle.Degrees(+40.01420512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91687"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46203162),
        dec: Angle.Degrees(+40.01565608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275982"},
        {"Hipparcos Number", "HIP 18652"},
        {"Smithsonian Astrophysical Observation", "SAO 56863"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.89098131),
        dec: Angle.Degrees(+40.01576064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73637"},
        {"Hipparcos Number", "HIP 42590"},
        {"Geneva Identification System", "GEN# +1.00073637"},
        {"Smithsonian Astrophysical Observation", "SAO 42488"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.20973851),
        dec: Angle.Degrees(+40.01778377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203856"},
        {"Hipparcos Number", "HIP 105624"},
        {"Smithsonian Astrophysical Observation", "SAO 71278"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.89795056),
        dec: Angle.Degrees(+40.01859952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51930"},
        {"Hipparcos Number", "HIP 33806"},
        {"Geneva Identification System", "GEN# +1.00051930"},
        {"Smithsonian Astrophysical Observation", "SAO 41499"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.28523383),
        dec: Angle.Degrees(+40.01872946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5088"},
        {"Smithsonian Astrophysical Observation", "SAO 54408"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.29839824),
        dec: Angle.Degrees(+40.01891347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82290"},
        {"Hipparcos Number", "HIP 46800"},
        {"Smithsonian Astrophysical Observation", "SAO 42908"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.05054654),
        dec: Angle.Degrees(+40.01940733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71554"},
        {"Smithsonian Astrophysical Observation", "SAO 45144"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.51989184),
        dec: Angle.Degrees(+40.02103034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186255"},
        {"Hipparcos Number", "HIP 96887"},
        {"Geneva Identification System", "GEN# +1.00186255"},
        {"Smithsonian Astrophysical Observation", "SAO 68708"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.41582380),
        dec: Angle.Degrees(+40.02231075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144015"},
        {"Hipparcos Number", "HIP 78537"},
        {"Geneva Identification System", "GEN# +1.00144015"},
        {"Smithsonian Astrophysical Observation", "SAO 45855"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.50889337),
        dec: Angle.Degrees(+40.02277331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60654"},
        {"Hipparcos Number", "HIP 37091"},
        {"Fundamental Katalog 5th Edition", "FK5 2589"},
        {"Geneva Identification System", "GEN# +1.00060654"},
        {"Smithsonian Astrophysical Observation", "SAO 41887"},
        {"Wilson Evans Batten Catalogue", "WEB 7354"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.32418974),
        dec: Angle.Degrees(+40.02550216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26883"},
        {"Hipparcos Number", "HIP 19943"},
        {"Smithsonian Astrophysical Observation", "SAO 57119"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.16252373),
        dec: Angle.Degrees(+40.02640433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186410"},
        {"Hipparcos Number", "HIP 96958"},
        {"Celescope Catalog", "CEL 4822"},
        {"Geneva Identification System", "GEN# +1.00186410"},
        {"Smithsonian Astrophysical Observation", "SAO 68731"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64268659),
        dec: Angle.Degrees(+40.02651506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12143"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.13551850),
        dec: Angle.Degrees(+40.02738350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12662 AB"},
        {"Henry Draper", "HD 185036"},
        {"Hipparcos Number", "HIP 96371"},
        {"Smithsonian Astrophysical Observation", "SAO 68549"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.90184449),
        dec: Angle.Degrees(+40.02750323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98603"},
        {"Wilson Evans Batten Catalogue", "WEB 17434"},
    },
    visualMagnitude: 10.09,
    bvColour: 2.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.41739041),
        dec: Angle.Degrees(+40.02902639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203438"},
        {"Hipparcos Number", "HIP 105398"},
        {"Smithsonian Astrophysical Observation", "SAO 71232"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.23105669),
        dec: Angle.Degrees(+40.03202784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40184"},
        {"Hipparcos Number", "HIP 28338"},
        {"Geneva Identification System", "GEN# +1.00040184"},
        {"Smithsonian Astrophysical Observation", "SAO 40747"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.82095357),
        dec: Angle.Degrees(+40.03342177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38892"},
        {"Cincinnati Publication", "Ci 20 445"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.38667134),
        dec: Angle.Degrees(+40.03567803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -602.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33516"},
        {"Smithsonian Astrophysical Observation", "SAO 41470"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50079789),
        dec: Angle.Degrees(+40.03732633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3678 AB"},
        {"Henry Draper", "HD 32632"},
        {"Hipparcos Number", "HIP 23762"},
        {"Smithsonian Astrophysical Observation", "SAO 57635"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.61245590),
        dec: Angle.Degrees(+40.03751758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146871"},
        {"Hipparcos Number", "HIP 79765"},
        {"Smithsonian Astrophysical Observation", "SAO 46006"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.19364024),
        dec: Angle.Degrees(+40.03831005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123913"},
        {"Hipparcos Number", "HIP 69158"},
        {"Smithsonian Astrophysical Observation", "SAO 44914"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.35473766),
        dec: Angle.Degrees(+40.03931076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221903"},
        {"Hipparcos Number", "HIP 116449"},
        {"Smithsonian Astrophysical Observation", "SAO 73363"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.94141409),
        dec: Angle.Degrees(+40.03998934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38895"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.40668683),
        dec: Angle.Degrees(+40.04071687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28712"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.96097724),
        dec: Angle.Degrees(+40.04210574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102830"},
        {"Smithsonian Astrophysical Observation", "SAO 70556"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.48837010),
        dec: Angle.Degrees(+40.04284918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44191"},
        {"Hipparcos Number", "HIP 30311"},
        {"Smithsonian Astrophysical Observation", "SAO 41053"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.62265229),
        dec: Angle.Degrees(+40.04328556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20971"},
        {"Hipparcos Number", "HIP 15871"},
        {"Smithsonian Astrophysical Observation", "SAO 56417"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.11034953),
        dec: Angle.Degrees(+40.04389482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50313",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7702 AB"},
        {"Hipparcos Number", "HIP 50313"},
        {"Smithsonian Astrophysical Observation", "SAO 43260"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.10212575),
        dec: Angle.Degrees(+40.04391274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76132"},
        {"Hipparcos Number", "HIP 43829"},
        {"Geneva Identification System", "GEN# +1.00076132"},
        {"Smithsonian Astrophysical Observation", "SAO 42599"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.90316071),
        dec: Angle.Degrees(+40.04488762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94734"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.14539391),
        dec: Angle.Degrees(+40.04689590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66085"},
        {"Geneva Identification System", "GEN# +0.04002664"},
        {"Smithsonian Astrophysical Observation", "SAO 44648"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.20048585),
        dec: Angle.Degrees(+40.04809671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145312"},
        {"Hipparcos Number", "HIP 79088"},
        {"Smithsonian Astrophysical Observation", "SAO 45908"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.15771157),
        dec: Angle.Degrees(+40.05310468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129617"},
        {"Hipparcos Number", "HIP 71891"},
        {"Smithsonian Astrophysical Observation", "SAO 45179"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.56334436),
        dec: Angle.Degrees(+40.05539809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71844"},
        {"Hipparcos Number", "HIP 41768"},
        {"Geneva Identification System", "GEN# +1.00071844"},
        {"Smithsonian Astrophysical Observation", "SAO 42406"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76566490),
        dec: Angle.Degrees(+40.05560847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9632"},
        {"Smithsonian Astrophysical Observation", "SAO 55231"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.95077411),
        dec: Angle.Degrees(+40.05566077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37105"},
        {"Smithsonian Astrophysical Observation", "SAO 41891"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.37509252),
        dec: Angle.Degrees(+40.05624140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30821"},
        {"Smithsonian Astrophysical Observation", "SAO 41119"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.12265566),
        dec: Angle.Degrees(+40.05700755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31500"},
        {"Hipparcos Number", "HIP 23100"},
        {"Geneva Identification System", "GEN# +1.00031500"},
        {"Smithsonian Astrophysical Observation", "SAO 57533"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.55395495),
        dec: Angle.Degrees(+40.05711487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174482"},
        {"Hipparcos Number", "HIP 92313"},
        {"Smithsonian Astrophysical Observation", "SAO 47825"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.22350087),
        dec: Angle.Degrees(+40.05968916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190991"},
        {"Hipparcos Number", "HIP 99008"},
        {"Celescope Catalog", "CEL 4930"},
        {"Geneva Identification System", "GEN# +1.00190991"},
        {"Smithsonian Astrophysical Observation", "SAO 69409"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.50296466),
        dec: Angle.Degrees(+40.06499169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15057 AB"},
        {"Henry Draper", "HD 205024"},
        {"Hipparcos Number", "HIP 106263"},
        {"Smithsonian Astrophysical Observation", "SAO 71424"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.84711078),
        dec: Angle.Degrees(+40.06516251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25947"},
        {"Geneva Identification System", "GEN# +0.03901328"},
        {"Wilson Evans Batten Catalogue", "WEB 5048"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.05770672),
        dec: Angle.Degrees(+40.06608028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47488"},
        {"Smithsonian Astrophysical Observation", "SAO 42974"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.20365842),
        dec: Angle.Degrees(+40.06872267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103655"},
        {"Cincinnati Publication", "Ci 20 1250"},
        {"Wilson Evans Batten Catalogue", "WEB 18863"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.02032565),
        dec: Angle.Degrees(+40.07087912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 614.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46110"},
        {"Wilson Evans Batten Catalogue", "WEB 8732"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.05401098),
        dec: Angle.Degrees(+40.07135735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162826"},
        {"Hipparcos Number", "HIP 87382"},
        {"Geneva Identification System", "GEN# +1.00162826"},
        {"Smithsonian Astrophysical Observation", "SAO 47009"},
        {"Wilson Evans Batten Catalogue", "WEB 14740"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.80847849),
        dec: Angle.Degrees(+40.07243924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154225"},
        {"Hipparcos Number", "HIP 83370"},
        {"Geneva Identification System", "GEN# +1.00154225"},
        {"Renson", "Renson 43588"},
        {"Smithsonian Astrophysical Observation", "SAO 46445"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.58827224),
        dec: Angle.Degrees(+40.07310538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33373"},
        {"Cincinnati Publication", "Ci 18 837"},
        {"Cincinnati Publication 2", "Ci 20 402"},
        {"Geneva Identification System", "GEN# +0.04001758A"},
        {"Smithsonian Astrophysical Observation", "SAO 41448"},
        {"Wilson Evans Batten Catalogue", "WEB 6709"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.11679381),
        dec: Angle.Degrees(+40.07539020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -436.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32234"},
        {"Hipparcos Number", "HIP 23526"},
        {"Celescope Catalog", "CEL 515"},
        {"Geneva Identification System", "GEN# +1.00032234"},
        {"Smithsonian Astrophysical Observation", "SAO 39981"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.86398901),
        dec: Angle.Degrees(+40.07666176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131448"},
        {"Hipparcos Number", "HIP 72765"},
        {"Geneva Identification System", "GEN# +1.00131448"},
        {"Smithsonian Astrophysical Observation", "SAO 45251"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12740555),
        dec: Angle.Degrees(+40.07677152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24500"},
        {"Wilson Evans Batten Catalogue", "WEB 4748"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.84159373),
        dec: Angle.Degrees(+40.07802395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66641"},
        {"Geneva Identification System", "GEN# +0.04002674"},
        {"Smithsonian Astrophysical Observation", "SAO 44699"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.89928489),
        dec: Angle.Degrees(+40.07813854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279"},
        {"Hipparcos Number", "HIP 625"},
        {"Smithsonian Astrophysical Observation", "SAO 53660"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90698995),
        dec: Angle.Degrees(+40.07851976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54345"},
        {"Smithsonian Astrophysical Observation", "SAO 43615"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.76659590),
        dec: Angle.Degrees(+40.07917616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23231"},
        {"Hipparcos Number", "HIP 17521"},
        {"Geneva Identification System", "GEN# +1.00023231"},
        {"Smithsonian Astrophysical Observation", "SAO 56681"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.26797853),
        dec: Angle.Degrees(+40.07951377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101918"},
        {"Hipparcos Number", "HIP 57223"},
        {"Geneva Identification System", "GEN# +1.00101918"},
        {"Smithsonian Astrophysical Observation", "SAO 43877"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00226800),
        dec: Angle.Degrees(+40.08275293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165567"},
        {"Hipparcos Number", "HIP 88533"},
        {"Geneva Identification System", "GEN# +1.00165567"},
        {"Smithsonian Astrophysical Observation", "SAO 47193"},
        {"Wilson Evans Batten Catalogue", "WEB 14990"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.17991043),
        dec: Angle.Degrees(+40.08412485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133030"},
        {"Hipparcos Number", "HIP 73476"},
        {"Geneva Identification System", "GEN# +1.00133030"},
        {"Smithsonian Astrophysical Observation", "SAO 45328"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25287076),
        dec: Angle.Degrees(+40.08442088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15684"},
        {"Hipparcos Number", "HIP 11816"},
        {"Smithsonian Astrophysical Observation", "SAO 55640"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09676982),
        dec: Angle.Degrees(+40.08533448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214243"},
        {"Hipparcos Number", "HIP 111576"},
        {"Celescope Catalog", "CEL 5493"},
        {"Fundamental Katalog 5th Edition", "FK5 5995"},
        {"Geneva Identification System", "GEN# +1.00214243"},
        {"Smithsonian Astrophysical Observation", "SAO 72523"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.06944728),
        dec: Angle.Degrees(+40.08877589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22353"},
        {"Hipparcos Number", "HIP 16897"},
        {"Geneva Identification System", "GEN# +1.00022353"},
        {"Smithsonian Astrophysical Observation", "SAO 56585"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.34699383),
        dec: Angle.Degrees(+40.08977982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111538"},
        {"Celescope Catalog", "CEL 5490"},
        {"Smithsonian Astrophysical Observation", "SAO 72506"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.95023586),
        dec: Angle.Degrees(+40.09095897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38232"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.49084745),
        dec: Angle.Degrees(+40.09133129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84946"},
        {"Smithsonian Astrophysical Observation", "SAO 46663"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.42305082),
        dec: Angle.Degrees(+40.09190679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25142"},
        {"Hipparcos Number", "HIP 18770"},
        {"Geneva Identification System", "GEN# +1.00025142"},
        {"Smithsonian Astrophysical Observation", "SAO 56896"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.31929583),
        dec: Angle.Degrees(+40.09478037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14798"},
        {"Hipparcos Number", "HIP 11193"},
        {"Smithsonian Astrophysical Observation", "SAO 55513"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.04179299),
        dec: Angle.Degrees(+40.09481120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37488"},
        {"Geneva Identification System", "GEN# +0.04001926"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.42908546),
        dec: Angle.Degrees(+40.09529814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100113"},
        {"Hipparcos Number", "HIP 56221"},
        {"Geneva Identification System", "GEN# +1.00100113"},
        {"Smithsonian Astrophysical Observation", "SAO 43795"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.88315985),
        dec: Angle.Degrees(+40.09666947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3886 A"},
        {"Henry Draper", "HD 34411"},
        {"Hipparcos Number", "HIP 24813"},
        {"Cincinnati Publication", "Ci 20 326"},
        {"Fundamental Katalog 5th Edition", "FK5 1145"},
        {"Geneva Identification System", "GEN# +1.00034411"},
        {"Smithsonian Astrophysical Observation", "SAO 40233"},
        {"Wilson Evans Batten Catalogue", "WEB 4798"},
    },
    visualMagnitude: 4.69,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.78365993),
        dec: Angle.Degrees(+40.10066732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 519.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -664.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33462"},
        {"Hipparcos Number", "HIP 24239"},
        {"Celescope Catalog", "CEL 561"},
        {"Geneva Identification System", "GEN# +1.00033462"},
        {"Smithsonian Astrophysical Observation", "SAO 40110"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.06236218),
        dec: Angle.Degrees(+40.10157460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72132"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.32206653),
        dec: Angle.Degrees(+40.10194027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142977"},
        {"Hipparcos Number", "HIP 78050"},
        {"Smithsonian Astrophysical Observation", "SAO 45793"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.03236754),
        dec: Angle.Degrees(+40.10553662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 463"},
        {"Aitken 2", "ADS 463 AB"},
        {"Henry Draper", "HD 2993"},
        {"Hipparcos Number", "HIP 2643"},
        {"Smithsonian Astrophysical Observation", "SAO 53983"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.37487039),
        dec: Angle.Degrees(+40.10561610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122813"},
        {"Hipparcos Number", "HIP 68645"},
        {"Geneva Identification System", "GEN# +1.00122813"},
        {"Smithsonian Astrophysical Observation", "SAO 44863"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.77523181),
        dec: Angle.Degrees(+40.10685185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112418"},
        {"Geneva Identification System", "GEN# +0.03904926"},
        {"Smithsonian Astrophysical Observation", "SAO 72704"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.54678849),
        dec: Angle.Degrees(+40.10731200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61707"},
        {"Smithsonian Astrophysical Observation", "SAO 44268"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.72270298),
        dec: Angle.Degrees(+40.10736994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134191"},
        {"Hipparcos Number", "HIP 73983"},
        {"Geneva Identification System", "GEN# +1.00134191"},
        {"Smithsonian Astrophysical Observation", "SAO 45383"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.78889109),
        dec: Angle.Degrees(+40.10789030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31964"},
        {"Smithsonian Astrophysical Observation", "SAO 41263"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.19873251),
        dec: Angle.Degrees(+40.10881140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53110"},
        {"Smithsonian Astrophysical Observation", "SAO 43499"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.98547584),
        dec: Angle.Degrees(+40.10954578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225192"},
        {"Hipparcos Number", "HIP 344"},
        {"Wilson Evans Batten Catalogue", "WEB 49"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.08364803),
        dec: Angle.Degrees(+40.10995515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90013"},
        {"Smithsonian Astrophysical Observation", "SAO 47421"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.50289535),
        dec: Angle.Degrees(+40.11133254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87971"},
        {"Smithsonian Astrophysical Observation", "SAO 47098"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.54375848),
        dec: Angle.Degrees(+40.11208073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10111 AB"},
        {"Henry Draper", "HD 149379"},
        {"Hipparcos Number", "HIP 81001"},
        {"Smithsonian Astrophysical Observation", "SAO 46152"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.13817908),
        dec: Angle.Degrees(+40.11334621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180582"},
        {"Hipparcos Number", "HIP 94619"},
        {"Renson", "Renson 50098"},
        {"Smithsonian Astrophysical Observation", "SAO 48238"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.82185502),
        dec: Angle.Degrees(+40.11369461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177697"},
        {"Hipparcos Number", "HIP 93631"},
        {"Fundamental Katalog 5th Edition", "FK5 5678"},
        {"Geneva Identification System", "GEN# +1.00177697"},
        {"Smithsonian Astrophysical Observation", "SAO 48044"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.00701105),
        dec: Angle.Degrees(+40.11628142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53350"},
        {"Smithsonian Astrophysical Observation", "SAO 43521"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.66558452),
        dec: Angle.Degrees(+40.11668643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145514"},
        {"Hipparcos Number", "HIP 79186"},
        {"Geneva Identification System", "GEN# +1.00145514"},
        {"Smithsonian Astrophysical Observation", "SAO 45920"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.42205942),
        dec: Angle.Degrees(+40.11842799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 263.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19981"},
        {"Hipparcos Number", "HIP 15065"},
        {"Smithsonian Astrophysical Observation", "SAO 56274"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.53525337),
        dec: Angle.Degrees(+40.11907505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219918"},
        {"Hipparcos Number", "HIP 115134"},
        {"Geneva Identification System", "GEN# +1.00219918"},
        {"Smithsonian Astrophysical Observation", "SAO 73168"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.80825005),
        dec: Angle.Degrees(+40.12125059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193323"},
        {"Hipparcos Number", "HIP 100077"},
        {"Smithsonian Astrophysical Observation", "SAO 69796"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55415717),
        dec: Angle.Degrees(+40.12184607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36443"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.49834670),
        dec: Angle.Degrees(+40.12460890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12028 A"},
        {"Henry Draper", "HD 177982"},
        {"Hipparcos Number", "HIP 93730"},
        {"Geneva Identification System", "GEN# +1.00177982"},
        {"Smithsonian Astrophysical Observation", "SAO 48062"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.27416988),
        dec: Angle.Degrees(+40.12589015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79209"},
        {"Smithsonian Astrophysical Observation", "SAO 45925"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.49888892),
        dec: Angle.Degrees(+40.12644722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8480 AB"},
        {"Henry Draper", "HD 106592"},
        {"Hipparcos Number", "HIP 59776"},
        {"Geneva Identification System", "GEN# +1.00106592J"},
        {"Smithsonian Astrophysical Observation", "SAO 44093"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.85927067),
        dec: Angle.Degrees(+40.12808698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103140"},
        {"Hipparcos Number", "HIP 57908"},
        {"Geneva Identification System", "GEN# +1.00103140"},
        {"Smithsonian Astrophysical Observation", "SAO 43927"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.16200209),
        dec: Angle.Degrees(+40.13144841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40546"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.19523291),
        dec: Angle.Degrees(+40.13145762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33861"},
        {"Hipparcos Number", "HIP 24476"},
        {"Smithsonian Astrophysical Observation", "SAO 40163"},
        {"Wilson Evans Batten Catalogue", "WEB 4742"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79150970),
        dec: Angle.Degrees(+40.13247511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75933"},
        {"Hipparcos Number", "HIP 43737"},
        {"Geneva Identification System", "GEN# +1.00075933"},
        {"Smithsonian Astrophysical Observation", "SAO 42592"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.62537522),
        dec: Angle.Degrees(+40.13365943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60500"},
        {"Hipparcos Number", "HIP 37020"},
        {"Smithsonian Astrophysical Observation", "SAO 41880"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.12923475),
        dec: Angle.Degrees(+40.13388651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85672"},
        {"Smithsonian Astrophysical Observation", "SAO 46760"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.61889255),
        dec: Angle.Degrees(+40.13422655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106614"},
        {"Smithsonian Astrophysical Observation", "SAO 71495"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.91537508),
        dec: Angle.Degrees(+40.13456471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12455 A"},
        {"Henry Draper", "HD 183160"},
        {"Hipparcos Number", "HIP 95587"},
        {"Smithsonian Astrophysical Observation", "SAO 48444"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.63434662),
        dec: Angle.Degrees(+40.13589410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8359"},
        {"Smithsonian Astrophysical Observation", "SAO 54979"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.92861025),
        dec: Angle.Degrees(+40.13623738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62161"},
        {"Smithsonian Astrophysical Observation", "SAO 44306"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.09464403),
        dec: Angle.Degrees(+40.13664761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17720"},
        {"Hipparcos Number", "HIP 13352"},
        {"Geneva Identification System", "GEN# +1.00017720"},
        {"Smithsonian Astrophysical Observation", "SAO 55949"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.94772475),
        dec: Angle.Degrees(+40.13725702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92861"},
        {"Smithsonian Astrophysical Observation", "SAO 47916"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.83339261),
        dec: Angle.Degrees(+40.13883037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111157"},
        {"Smithsonian Astrophysical Observation", "SAO 72424"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.79828675),
        dec: Angle.Degrees(+40.13983818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149861"},
        {"Hipparcos Number", "HIP 81250"},
        {"Smithsonian Astrophysical Observation", "SAO 46175"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.92706052),
        dec: Angle.Degrees(+40.14468683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65755"},
        {"Hipparcos Number", "HIP 39267"},
        {"Geneva Identification System", "GEN# +1.00065755"},
        {"Smithsonian Astrophysical Observation", "SAO 42132"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.44779905),
        dec: Angle.Degrees(+40.14513380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28435"},
        {"Hipparcos Number", "HIP 21052"},
        {"Geneva Identification System", "GEN# +1.00028435"},
        {"Smithsonian Astrophysical Observation", "SAO 39576"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.69259458),
        dec: Angle.Degrees(+40.14659734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 82 A"},
        {"Henry Draper", "HD 290"},
        {"Hipparcos Number", "HIP 626"},
        {"Geneva Identification System", "GEN# +1.00000290"},
        {"Smithsonian Astrophysical Observation", "SAO 53661"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90808924),
        dec: Angle.Degrees(+40.14799609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4456 AB"},
        {"Henry Draper", "HD 39154"},
        {"Hipparcos Number", "HIP 27761"},
        {"Smithsonian Astrophysical Observation", "SAO 40669"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.12747063),
        dec: Angle.Degrees(+40.14876402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111699"},
        {"Smithsonian Astrophysical Observation", "SAO 72549"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.40222803),
        dec: Angle.Degrees(+40.14976617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202032"},
        {"Hipparcos Number", "HIP 104678"},
        {"Smithsonian Astrophysical Observation", "SAO 71058"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.05364490),
        dec: Angle.Degrees(+40.15017245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116010"},
        {"Hipparcos Number", "HIP 65072"},
        {"Fundamental Katalog 5th Edition", "FK5 1346"},
        {"Geneva Identification System", "GEN# +1.00116010"},
        {"Smithsonian Astrophysical Observation", "SAO 44570"},
        {"Wilson Evans Batten Catalogue", "WEB 11495"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.07914877),
        dec: Angle.Degrees(+40.15055594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166069"},
        {"Hipparcos Number", "HIP 88751"},
        {"Smithsonian Astrophysical Observation", "SAO 47226"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.77193649),
        dec: Angle.Degrees(+40.15145036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115004"},
        {"Hipparcos Number", "HIP 64540"},
        {"Geneva Identification System", "GEN# +1.00115004"},
        {"Smithsonian Astrophysical Observation", "SAO 44519"},
        {"Wilson Evans Batten Catalogue", "WEB 11416"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.42908954),
        dec: Angle.Degrees(+40.15284766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35001"},
        {"Hipparcos Number", "HIP 25198"},
        {"Smithsonian Astrophysical Observation", "SAO 40298"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.86675950),
        dec: Angle.Degrees(+40.15354963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100691",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13833 AB"},
        {"Henry Draper", "HD 194558"},
        {"Hipparcos Number", "HIP 100691"},
        {"Geneva Identification System", "GEN# +1.00194558J"},
        {"Smithsonian Astrophysical Observation", "SAO 69986"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.20330495),
        dec: Angle.Degrees(+40.15360284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5741"},
        {"Hipparcos Number", "HIP 4630"},
        {"Smithsonian Astrophysical Observation", "SAO 54321"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.85919898),
        dec: Angle.Degrees(+40.15518117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126926"},
        {"Hipparcos Number", "HIP 70684"},
        {"Smithsonian Astrophysical Observation", "SAO 45057"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.85644115),
        dec: Angle.Degrees(+40.15520917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78477"},
        {"Hipparcos Number", "HIP 44988"},
        {"Smithsonian Astrophysical Observation", "SAO 42727"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.45443444),
        dec: Angle.Degrees(+40.15625379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56461"},
        {"Cincinnati Publication", "Ci 20 647"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.64981062),
        dec: Angle.Degrees(+40.15750366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -436.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -487.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171485"},
        {"Hipparcos Number", "HIP 90954"},
        {"Geneva Identification System", "GEN# +1.00171485A"},
        {"Smithsonian Astrophysical Observation", "SAO 47587"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.31090654),
        dec: Angle.Degrees(+40.15951249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58957"},
        {"Geneva Identification System", "GEN# +0.04002496"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.33676257),
        dec: Angle.Degrees(+40.15999557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212677"},
        {"Hipparcos Number", "HIP 110678"},
        {"Smithsonian Astrophysical Observation", "SAO 72320"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.33625867),
        dec: Angle.Degrees(+40.16022324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19389",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3015 AB"},
        {"Henry Draper", "HD 26051"},
        {"Hipparcos Number", "HIP 19389"},
        {"Smithsonian Astrophysical Observation", "SAO 39342"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.29286732),
        dec: Angle.Degrees(+40.16155116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73185",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9451 A"},
        {"Henry Draper", "HD 132357"},
        {"Hipparcos Number", "HIP 73185"},
        {"Smithsonian Astrophysical Observation", "SAO 45298"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.36607563),
        dec: Angle.Degrees(+40.16173237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90951"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.30172136),
        dec: Angle.Degrees(+40.16404965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66674"},
        {"Geneva Identification System", "GEN# +0.04002676"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.02049684),
        dec: Angle.Degrees(+40.16407130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75157"},
        {"Smithsonian Astrophysical Observation", "SAO 45503"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.38566075),
        dec: Angle.Degrees(+40.16415581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73186",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9451 B"},
        {"Hipparcos Number", "HIP 73186"},
        {"Smithsonian Astrophysical Observation", "SAO 45299"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.36916204),
        dec: Angle.Degrees(+40.16430492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44046"},
        {"Smithsonian Astrophysical Observation", "SAO 42624"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.55900960),
        dec: Angle.Degrees(+40.16583386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216538"},
        {"Hipparcos Number", "HIP 113009"},
        {"Geneva Identification System", "GEN# +1.00216538"},
        {"Smithsonian Astrophysical Observation", "SAO 72812"},
        {"Wilson Evans Batten Catalogue", "WEB 20120"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.29737555),
        dec: Angle.Degrees(+40.16738320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15473"},
        {"Hipparcos Number", "HIP 11682"},
        {"Smithsonian Astrophysical Observation", "SAO 55614"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.66971695),
        dec: Angle.Degrees(+40.16766441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47467"},
        {"Hipparcos Number", "HIP 31956"},
        {"Geneva Identification System", "GEN# +1.00047467"},
        {"Smithsonian Astrophysical Observation", "SAO 41261"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.17717559),
        dec: Angle.Degrees(+40.16851352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109535",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15707 AB"},
        {"Henry Draper", "HD 210683"},
        {"Hipparcos Number", "HIP 109535"},
        {"Smithsonian Astrophysical Observation", "SAO 72106"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81656652),
        dec: Angle.Degrees(+40.16877450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31314"},
        {"Hipparcos Number", "HIP 22966"},
        {"Celescope Catalog", "CEL 491"},
        {"Geneva Identification System", "GEN# +1.00031314"},
        {"Smithsonian Astrophysical Observation", "SAO 39882"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.13091933),
        dec: Angle.Degrees(+40.16919250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21400"},
        {"Hipparcos Number", "HIP 16186"},
        {"Smithsonian Astrophysical Observation", "SAO 56476"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.12576553),
        dec: Angle.Degrees(+40.17108798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94177"},
        {"Hipparcos Number", "HIP 53182"},
        {"Smithsonian Astrophysical Observation", "SAO 43503"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.17733446),
        dec: Angle.Degrees(+40.17128513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188875"},
        {"Hipparcos Number", "HIP 98058"},
        {"Geneva Identification System", "GEN# +1.00188875"},
        {"Smithsonian Astrophysical Observation", "SAO 48982"},
        {"Wilson Evans Batten Catalogue", "WEB 17275"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.91919502),
        dec: Angle.Degrees(+40.17289193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190359"},
        {"Hipparcos Number", "HIP 98717"},
        {"Smithsonian Astrophysical Observation", "SAO 49122"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.75857747),
        dec: Angle.Degrees(+40.17318989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98823"},
        {"Hipparcos Number", "HIP 55549"},
        {"Geneva Identification System", "GEN# +1.00098823"},
        {"Smithsonian Astrophysical Observation", "SAO 43717"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.67412119),
        dec: Angle.Degrees(+40.17546602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49289"},
        {"Hipparcos Number", "HIP 32719"},
        {"Geneva Identification System", "GEN# +1.00049289"},
        {"Smithsonian Astrophysical Observation", "SAO 41368"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39120370),
        dec: Angle.Degrees(+40.17585817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175841"},
        {"Hipparcos Number", "HIP 92869"},
        {"Smithsonian Astrophysical Observation", "SAO 47918"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.85689766),
        dec: Angle.Degrees(+40.17714943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103433"},
        {"Geneva Identification System", "GEN# +0.03904379"},
        {"Smithsonian Astrophysical Observation", "SAO 70716"},
        {"Wilson Evans Batten Catalogue", "WEB 18811"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.33679738),
        dec: Angle.Degrees(+40.17751162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141068"},
        {"Hipparcos Number", "HIP 77180"},
        {"Geneva Identification System", "GEN# +1.00141068"},
        {"Smithsonian Astrophysical Observation", "SAO 45711"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.39056564),
        dec: Angle.Degrees(+40.17755798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11001 AB"},
        {"Henry Draper", "HD 164941"},
        {"Hipparcos Number", "HIP 88284"},
        {"Smithsonian Astrophysical Observation", "SAO 47149"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.42155658),
        dec: Angle.Degrees(+40.17827862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103985"},
        {"Hipparcos Number", "HIP 58413"},
        {"Geneva Identification System", "GEN# +1.00103985"},
        {"Smithsonian Astrophysical Observation", "SAO 43981"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.65088025),
        dec: Angle.Degrees(+40.18011354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36891"},
        {"Hipparcos Number", "HIP 26363"},
        {"Geneva Identification System", "GEN# +1.00036891"},
        {"Smithsonian Astrophysical Observation", "SAO 40481"},
        {"Wilson Evans Batten Catalogue", "WEB 5199"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.21841371),
        dec: Angle.Degrees(+40.18238543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114352"},
        {"Smithsonian Astrophysical Observation", "SAO 73045"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.39461281),
        dec: Angle.Degrees(+40.18358625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49964"},
        {"Smithsonian Astrophysical Observation", "SAO 43231"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.00947874),
        dec: Angle.Degrees(+40.18424135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40939"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.32466579),
        dec: Angle.Degrees(+40.18515869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2553 A"},
        {"Henry Draper", "HD 21449"},
        {"Hipparcos Number", "HIP 16220"},
        {"Geneva Identification System", "GEN# +1.00021449"},
        {"Smithsonian Astrophysical Observation", "SAO 38870"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.23836153),
        dec: Angle.Degrees(+40.18646604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31120"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.95657672),
        dec: Angle.Degrees(+40.18676572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38484"},
        {"Smithsonian Astrophysical Observation", "SAO 42046"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.22173235),
        dec: Angle.Degrees(+40.18753811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43353"},
        {"Hipparcos Number", "HIP 29904"},
        {"Smithsonian Astrophysical Observation", "SAO 41007"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.44477943),
        dec: Angle.Degrees(+40.18863245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3765"},
        {"Hipparcos Number", "HIP 3206"},
        {"Cincinnati Publication", "Ci 20 44"},
        {"Geneva Identification System", "GEN# +1.00003765"},
        {"Smithsonian Astrophysical Observation", "SAO 54074"},
        {"Wilson Evans Batten Catalogue", "WEB 573"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.20415817),
        dec: Angle.Degrees(+40.18879925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 355.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -668.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103502"},
    },
    visualMagnitude: 10.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.54702582),
        dec: Angle.Degrees(+40.19089987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16218",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2553 B"},
        {"Henry Draper", "HD 21449B"},
        {"Hipparcos Number", "HIP 16218"},
    },
    visualMagnitude: 10.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)28, 56.7800),
        dec: Angle.DegreesMinutesSeconds((int)+40, (int)11, 34.700)
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
    primaryId: "HIP 55587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55587"},
        {"Smithsonian Astrophysical Observation", "SAO 43722"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.79716410),
        dec: Angle.Degrees(+40.19326711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33604"},
        {"Hipparcos Number", "HIP 24326"},
        {"Celescope Catalog", "CEL 565"},
        {"Geneva Identification System", "GEN# +1.00033604"},
        {"Smithsonian Astrophysical Observation", "SAO 40133"},
        {"Wilson Evans Batten Catalogue", "WEB 4718"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.30555659),
        dec: Angle.Degrees(+40.19354156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16739"},
        {"Hipparcos Number", "HIP 12623"},
        {"Fundamental Katalog 5th Edition", "FK5 2187"},
        {"Geneva Identification System", "GEN# +1.00016739"},
        {"Smithsonian Astrophysical Observation", "SAO 55793"},
        {"Wilson Evans Batten Catalogue", "WEB 2571"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.56220350),
        dec: Angle.Degrees(+40.19438688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51639"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.24708017),
        dec: Angle.Degrees(+40.19440596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106608"},
        {"Smithsonian Astrophysical Observation", "SAO 71493"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.88503297),
        dec: Angle.Degrees(+40.19596567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112198"},
        {"Smithsonian Astrophysical Observation", "SAO 72664"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.85842335),
        dec: Angle.Degrees(+40.19600813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108503"},
        {"Smithsonian Astrophysical Observation", "SAO 71903"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.71258641),
        dec: Angle.Degrees(+40.19683867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85176"},
        {"Hipparcos Number", "HIP 48345"},
        {"Smithsonian Astrophysical Observation", "SAO 43070"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.82804353),
        dec: Angle.Degrees(+40.19822608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7079"},
        {"Smithsonian Astrophysical Observation", "SAO 54753"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.80686832),
        dec: Angle.Degrees(+40.19855721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223636"},
        {"Hipparcos Number", "HIP 117622"},
        {"Fundamental Katalog 5th Edition", "FK5 3916"},
        {"Geneva Identification System", "GEN# +1.00223636"},
        {"Smithsonian Astrophysical Observation", "SAO 73556"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.82722267),
        dec: Angle.Degrees(+40.19868305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92765"},
        {"Hipparcos Number", "HIP 52449"},
        {"Geneva Identification System", "GEN# +1.00092765"},
        {"Smithsonian Astrophysical Observation", "SAO 43441"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.83195405),
        dec: Angle.Degrees(+40.19874213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213421"},
        {"Hipparcos Number", "HIP 111106"},
        {"Geneva Identification System", "GEN# +1.00213421"},
        {"Renson", "Renson 59180"},
        {"Smithsonian Astrophysical Observation", "SAO 72415"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.62452126),
        dec: Angle.Degrees(+40.20106686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76292"},
        {"Hipparcos Number", "HIP 43894"},
        {"Fundamental Katalog 5th Edition", "FK5 2706"},
        {"Geneva Identification System", "GEN# +1.00076292"},
        {"Smithsonian Astrophysical Observation", "SAO 42611"},
        {"Wilson Evans Batten Catalogue", "WEB 8439"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.12740931),
        dec: Angle.Degrees(+40.20156718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80715"},
        {"Hipparcos Number", "HIP 45963"},
        {"Cincinnati Publication", "Ci 18 1104"},
        {"Cincinnati Publication 2", "Ci 20 520"},
        {"Geneva Identification System", "GEN# +1.00080715"},
        {"Smithsonian Astrophysical Observation", "SAO 42826"},
        {"Wilson Evans Batten Catalogue", "WEB 8716"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.60919142),
        dec: Angle.Degrees(+40.20193252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -341.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14505"},
        {"Smithsonian Astrophysical Observation", "SAO 38586"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83168000),
        dec: Angle.Degrees(+40.20218553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175902"},
        {"Hipparcos Number", "HIP 92906"},
        {"Smithsonian Astrophysical Observation", "SAO 47923"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94489957),
        dec: Angle.Degrees(+40.20286713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55913"},
        {"Cincinnati Publication", "Ci 18 1406"},
        {"Smithsonian Astrophysical Observation", "SAO 43745"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.90872378),
        dec: Angle.Degrees(+40.20426949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16097"},
        {"Hipparcos Number", "HIP 12136"},
        {"Smithsonian Astrophysical Observation", "SAO 55695"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.07869942),
        dec: Angle.Degrees(+40.20487012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49930"},
        {"Smithsonian Astrophysical Observation", "SAO 43227"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.90901909),
        dec: Angle.Degrees(+40.20675089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51269"},
        {"Smithsonian Astrophysical Observation", "SAO 43354"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.08683219),
        dec: Angle.Degrees(+40.21061378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116093"},
        {"Smithsonian Astrophysical Observation", "SAO 73313"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85487974),
        dec: Angle.Degrees(+40.21178367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185374"},
        {"Hipparcos Number", "HIP 96501"},
        {"Geneva Identification System", "GEN# +1.00185374"},
        {"Smithsonian Astrophysical Observation", "SAO 48655"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.28690522),
        dec: Angle.Degrees(+40.21389178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65395"},
        {"Geneva Identification System", "GEN# +0.04002656"},
        {"Smithsonian Astrophysical Observation", "SAO 44597"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.04293504),
        dec: Angle.Degrees(+40.21621855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1855"},
        {"Smithsonian Astrophysical Observation", "SAO 53852"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.85640043),
        dec: Angle.Degrees(+40.22200768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7831"},
        {"Hipparcos Number", "HIP 6120"},
        {"Smithsonian Astrophysical Observation", "SAO 54588"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.64247639),
        dec: Angle.Degrees(+40.22444235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71866"},
        {"Hipparcos Number", "HIP 41782"},
        {"Geneva Identification System", "GEN# +1.00071866"},
        {"Renson", "Renson 19850"},
        {"Smithsonian Astrophysical Observation", "SAO 42408"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.79442283),
        dec: Angle.Degrees(+40.22495021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214993"},
        {"Hipparcos Number", "HIP 112031"},
        {"Celescope Catalog", "CEL 5512"},
        {"Geneva Identification System", "GEN# +1.00214993"},
        {"Smithsonian Astrophysical Observation", "SAO 72627"},
        {"Wilson Evans Batten Catalogue", "WEB 20001"},
    },
    visualMagnitude: 5.25,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.36938127),
        dec: Angle.Degrees(+40.22546314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193426"},
        {"Hipparcos Number", "HIP 100124"},
        {"Geneva Identification System", "GEN# +1.00193426"},
        {"Smithsonian Astrophysical Observation", "SAO 49453"},
        {"Wilson Evans Batten Catalogue", "WEB 18033"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.66563096),
        dec: Angle.Degrees(+40.22692702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1442"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.49036207),
        dec: Angle.Degrees(+40.22750372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42782"},
        {"Smithsonian Astrophysical Observation", "SAO 42510"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.76167824),
        dec: Angle.Degrees(+40.23027470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3447 AB"},
        {"Henry Draper", "HD 30245"},
        {"Hipparcos Number", "HIP 22272"},
        {"Smithsonian Astrophysical Observation", "SAO 39759"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.92956518),
        dec: Angle.Degrees(+40.23253739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220447"},
        {"Hipparcos Number", "HIP 115479"},
        {"Smithsonian Astrophysical Observation", "SAO 73220"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.89640285),
        dec: Angle.Degrees(+40.23383029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221756"},
        {"Hipparcos Number", "HIP 116354"},
        {"Fundamental Katalog 5th Edition", "FK5 1616"},
        {"Geneva Identification System", "GEN# +1.00221756"},
        {"Smithsonian Astrophysical Observation", "SAO 73346"},
        {"Wilson Evans Batten Catalogue", "WEB 20558"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.65646146),
        dec: Angle.Degrees(+40.23655244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216962"},
        {"Hipparcos Number", "HIP 113308"},
        {"Smithsonian Astrophysical Observation", "SAO 72870"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.20158200),
        dec: Angle.Degrees(+40.23795450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48749"},
        {"Hipparcos Number", "HIP 32486"},
        {"Smithsonian Astrophysical Observation", "SAO 41336"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.69528805),
        dec: Angle.Degrees(+40.23823539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83287"},
        {"Hipparcos Number", "HIP 47300"},
        {"Geneva Identification System", "GEN# +1.00083287"},
        {"Smithsonian Astrophysical Observation", "SAO 42958"},
        {"Wilson Evans Batten Catalogue", "WEB 8890"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59077851),
        dec: Angle.Degrees(+40.23976693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111859"},
        {"Hipparcos Number", "HIP 62789"},
        {"Geneva Identification System", "GEN# +1.00111859"},
        {"Smithsonian Astrophysical Observation", "SAO 44361"},
        {"Wilson Evans Batten Catalogue", "WEB 11133"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.99447162),
        dec: Angle.Degrees(+40.24152987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26909"},
        {"Smithsonian Astrophysical Observation", "SAO 40551"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.69420765),
        dec: Angle.Degrees(+40.24342790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5065"},
        {"Hipparcos Number", "HIP 4127"},
        {"Geneva Identification System", "GEN# +1.00005065"},
        {"Smithsonian Astrophysical Observation", "SAO 54224"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.21592800),
        dec: Angle.Degrees(+40.24544245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43424"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.67487698),
        dec: Angle.Degrees(+40.24552914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120435"},
        {"Hipparcos Number", "HIP 67375"},
        {"Geneva Identification System", "GEN# +1.00120435"},
        {"Smithsonian Astrophysical Observation", "SAO 44757"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13759780),
        dec: Angle.Degrees(+40.24687998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106171"},
        {"Hipparcos Number", "HIP 59570"},
        {"Geneva Identification System", "GEN# +1.00106171"},
        {"Smithsonian Astrophysical Observation", "SAO 44081"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23694458),
        dec: Angle.Degrees(+40.24945646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277278"},
        {"Hipparcos Number", "HIP 23144"},
        {"Smithsonian Astrophysical Observation", "SAO 39907"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.69618721),
        dec: Angle.Degrees(+40.25033063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84112"},
        {"Smithsonian Astrophysical Observation", "SAO 46552"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.93662885),
        dec: Angle.Degrees(+40.25087362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101194"},
        {"Hipparcos Number", "HIP 56826"},
        {"Geneva Identification System", "GEN# +1.00101194"},
        {"Smithsonian Astrophysical Observation", "SAO 43843"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.73581944),
        dec: Angle.Degrees(+40.25184951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105631"},
        {"Hipparcos Number", "HIP 59280"},
        {"Cincinnati Publication", "Ci 18 1511"},
        {"Geneva Identification System", "GEN# +1.00105631"},
        {"Smithsonian Astrophysical Observation", "SAO 44058"},
        {"Wilson Evans Batten Catalogue", "WEB 10543"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.40623465),
        dec: Angle.Degrees(+40.25218003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128526"},
        {"Hipparcos Number", "HIP 71411"},
        {"Smithsonian Astrophysical Observation", "SAO 45128"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.04985349),
        dec: Angle.Degrees(+40.25238824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18245"},
        {"Hipparcos Number", "HIP 13753"},
        {"Geneva Identification System", "GEN# +1.00018245"},
        {"Smithsonian Astrophysical Observation", "SAO 38464"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.26108704),
        dec: Angle.Degrees(+40.25254896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53483"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.11969599),
        dec: Angle.Degrees(+40.25320696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186307"},
        {"Hipparcos Number", "HIP 96907"},
        {"Celescope Catalog", "CEL 4819"},
        {"Geneva Identification System", "GEN# +1.00186307J"},
        {"Smithsonian Astrophysical Observation", "SAO 48737"},
        {"Wilson Evans Batten Catalogue", "WEB 17006"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.49010781),
        dec: Angle.Degrees(+40.25405313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168295"},
        {"Hipparcos Number", "HIP 89603"},
        {"Smithsonian Astrophysical Observation", "SAO 47358"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.27908857),
        dec: Angle.Degrees(+40.25584553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2057 B"},
        {"Hipparcos Number", "HIP 12645"},
        {"Renson", "Renson 4250"},
        {"Smithsonian Astrophysical Observation", "SAO 38264"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.61839696),
        dec: Angle.Degrees(+40.25585482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100453",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "SADR"},
        {"Aitken", "ADS 13765 A"},
        {"Henry Draper", "HD 194093"},
        {"Hipparcos Number", "HIP 100453"},
        {"Fundamental Katalog 5th Edition", "FK5 765"},
        {"Geneva Identification System", "GEN# +1.00194093"},
        {"Smithsonian Astrophysical Observation", "SAO 49528"},
        {"Wilson Evans Batten Catalogue", "WEB 18138"},
    },
    visualMagnitude: 2.23,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55708346),
        dec: Angle.Degrees(+40.25668150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277559"},
        {"Hipparcos Number", "HIP 23688"},
        {"Geneva Identification System", "GEN# +1.00277559"},
        {"Smithsonian Astrophysical Observation", "SAO 40012"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.36863304),
        dec: Angle.Degrees(+40.25749696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 308.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200077"},
        {"Hipparcos Number", "HIP 103641"},
        {"Cincinnati Publication", "Ci 18 2718"},
        {"Geneva Identification System", "GEN# +1.00200077"},
        {"Smithsonian Astrophysical Observation", "SAO 50331"},
        {"Wilson Evans Batten Catalogue", "WEB 18857"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.97958038),
        dec: Angle.Degrees(+40.25831099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 210.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147428"},
        {"Hipparcos Number", "HIP 80039"},
        {"Geneva Identification System", "GEN# +1.00147428"},
        {"Smithsonian Astrophysical Observation", "SAO 46031"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.07065999),
        dec: Angle.Degrees(+40.25945190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35093"},
        {"Smithsonian Astrophysical Observation", "SAO 41642"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.86137803),
        dec: Angle.Degrees(+40.25984255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84648"},
        {"Hipparcos Number", "HIP 48061"},
        {"Smithsonian Astrophysical Observation", "SAO 43041"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96239778),
        dec: Angle.Degrees(+40.25991415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26850"},
        {"Smithsonian Astrophysical Observation", "SAO 40542"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.50569483),
        dec: Angle.Degrees(+40.26013788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2057 A"},
        {"Henry Draper", "HD 16772"},
        {"Hipparcos Number", "HIP 12648"},
        {"Smithsonian Astrophysical Observation", "SAO 38265"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.62278822),
        dec: Angle.Degrees(+40.26130922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14076"},
        {"Smithsonian Astrophysical Observation", "SAO 38513"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.34655031),
        dec: Angle.Degrees(+40.26285880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210607"},
        {"Hipparcos Number", "HIP 109473"},
        {"Geneva Identification System", "GEN# +1.00210607"},
        {"Smithsonian Astrophysical Observation", "SAO 51726"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.65979757),
        dec: Angle.Degrees(+40.26365036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48998"},
        {"Smithsonian Astrophysical Observation", "SAO 43133"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.94490601),
        dec: Angle.Degrees(+40.26407526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216428"},
        {"Hipparcos Number", "HIP 112931"},
        {"Smithsonian Astrophysical Observation", "SAO 72800"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.08494805),
        dec: Angle.Degrees(+40.26550217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181681"},
        {"Hipparcos Number", "HIP 94977"},
        {"Smithsonian Astrophysical Observation", "SAO 48333"},
        {"Wilson Evans Batten Catalogue", "WEB 16586"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.90766800),
        dec: Angle.Degrees(+40.26716775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192281"},
        {"Hipparcos Number", "HIP 99580"},
        {"Celescope Catalog", "CEL 4973"},
        {"Geneva Identification System", "GEN# +1.00192281"},
        {"Smithsonian Astrophysical Observation", "SAO 49319"},
        {"Wilson Evans Batten Catalogue", "WEB 17823"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.13802537),
        dec: Angle.Degrees(+40.26818531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15683"},
        {"Hipparcos Number", "HIP 11812"},
        {"Smithsonian Astrophysical Observation", "SAO 38099"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09295895),
        dec: Angle.Degrees(+40.27250268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1763 A"},
        {"Henry Draper", "HD 14189"},
        {"Hipparcos Number", "HIP 10772"},
        {"Geneva Identification System", "GEN# +1.00014189A"},
        {"Smithsonian Astrophysical Observation", "SAO 37940"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.65113187),
        dec: Angle.Degrees(+40.27880834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92093"},
        {"Fundamental Katalog 5th Edition", "FK5 5648"},
        {"Smithsonian Astrophysical Observation", "SAO 47777"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.53531777),
        dec: Angle.Degrees(+40.27983966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1763 B"},
        {"Hipparcos Number", "HIP 10769"},
        {"Geneva Identification System", "GEN# +1.00014189B"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.64740950),
        dec: Angle.Degrees(+40.28002289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98682"},
        {"Hipparcos Number", "HIP 55475"},
        {"Smithsonian Astrophysical Observation", "SAO 43710"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.41008258),
        dec: Angle.Degrees(+40.28082481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10023"},
        {"Hipparcos Number", "HIP 7664"},
        {"Geneva Identification System", "GEN# +1.00010023"},
        {"Smithsonian Astrophysical Observation", "SAO 37399"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.66297746),
        dec: Angle.Degrees(+40.28184461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80508"},
        {"Hipparcos Number", "HIP 45892"},
        {"Geneva Identification System", "GEN# +1.00080508"},
        {"Smithsonian Astrophysical Observation", "SAO 42822"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35571760),
        dec: Angle.Degrees(+40.28393809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56590"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.03021039),
        dec: Angle.Degrees(+40.28432898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82105"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56799471),
        dec: Angle.Degrees(+40.28625632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110279"},
        {"Hipparcos Number", "HIP 61854"},
        {"Smithsonian Astrophysical Observation", "SAO 44277"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.15588872),
        dec: Angle.Degrees(+40.28788323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103770"},
        {"Hipparcos Number", "HIP 58277"},
        {"Geneva Identification System", "GEN# +1.00103770"},
        {"Smithsonian Astrophysical Observation", "SAO 43961"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.27800683),
        dec: Angle.Degrees(+40.28897862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18971"},
        {"Hipparcos Number", "HIP 14303"},
        {"Smithsonian Astrophysical Observation", "SAO 38551"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.11600867),
        dec: Angle.Degrees(+40.29283414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109050"},
        {"Smithsonian Astrophysical Observation", "SAO 51633"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.36852678),
        dec: Angle.Degrees(+40.29457225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103109"},
        {"Hipparcos Number", "HIP 57896"},
        {"Smithsonian Astrophysical Observation", "SAO 43925"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.12210684),
        dec: Angle.Degrees(+40.29537309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28006"},
        {"Hipparcos Number", "HIP 20775"},
        {"Fundamental Katalog 5th Edition", "FK5 4406"},
        {"Geneva Identification System", "GEN# +1.00028006"},
        {"Smithsonian Astrophysical Observation", "SAO 39538"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.76061832),
        dec: Angle.Degrees(+40.29882149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13271 A"},
        {"Henry Draper", "HD 190046"},
        {"Hipparcos Number", "HIP 98582"},
        {"Celescope Catalog", "CEL 4916"},
        {"Geneva Identification System", "GEN# +1.00190046"},
        {"Smithsonian Astrophysical Observation", "SAO 49094"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.36788857),
        dec: Angle.Degrees(+40.29890477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13271 B"},
        {"Hipparcos Number", "HIP 98580"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.36363115),
        dec: Angle.Degrees(+40.29955536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3853"},
        {"Smithsonian Astrophysical Observation", "SAO 36694"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.37318564),
        dec: Angle.Degrees(+40.29957139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199356"},
        {"Hipparcos Number", "HIP 103277"},
        {"Celescope Catalog", "CEL 5208"},
        {"Geneva Identification System", "GEN# +1.00199356"},
        {"Smithsonian Astrophysical Observation", "SAO 50230"},
        {"Wilson Evans Batten Catalogue", "WEB 18770"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.84629018),
        dec: Angle.Degrees(+40.30003137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121147"},
        {"Hipparcos Number", "HIP 67752"},
        {"Geneva Identification System", "GEN# +1.00121147"},
        {"Smithsonian Astrophysical Observation", "SAO 44783"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.20030333),
        dec: Angle.Degrees(+40.30015681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64446"},
        {"Hipparcos Number", "HIP 38720"},
        {"Smithsonian Astrophysical Observation", "SAO 42075"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.91071077),
        dec: Angle.Degrees(+40.30018666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78769"},
        {"Hipparcos Number", "HIP 45104"},
        {"Smithsonian Astrophysical Observation", "SAO 42734"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.82754982),
        dec: Angle.Degrees(+40.30042664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25595"},
        {"Hipparcos Number", "HIP 19083"},
        {"Smithsonian Astrophysical Observation", "SAO 39304"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.36974207),
        dec: Angle.Degrees(+40.30156392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41263"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.27526938),
        dec: Angle.Degrees(+40.30166999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65221"},
        {"Geneva Identification System", "GEN# +0.04102386"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.49654031),
        dec: Angle.Degrees(+40.30191343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27617"},
        {"Smithsonian Astrophysical Observation", "SAO 40648"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.71211650),
        dec: Angle.Degrees(+40.30322795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168439"},
        {"Hipparcos Number", "HIP 89654"},
        {"Smithsonian Astrophysical Observation", "SAO 47364"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.45165637),
        dec: Angle.Degrees(+40.30351725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204674"},
        {"Hipparcos Number", "HIP 106069"},
        {"Smithsonian Astrophysical Observation", "SAO 50923"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.26926713),
        dec: Angle.Degrees(+40.30438797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54037"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.85457328),
        dec: Angle.Degrees(+40.30629565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43332"},
        {"Hipparcos Number", "HIP 29891"},
        {"Geneva Identification System", "GEN# +1.00043332"},
        {"Smithsonian Astrophysical Observation", "SAO 41004"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.41296976),
        dec: Angle.Degrees(+40.30999566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73311"},
        {"Hipparcos Number", "HIP 42451"},
        {"Smithsonian Astrophysical Observation", "SAO 42473"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.82312080),
        dec: Angle.Degrees(+40.31032215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200388"},
        {"Hipparcos Number", "HIP 103793"},
        {"Smithsonian Astrophysical Observation", "SAO 50369"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47945446),
        dec: Angle.Degrees(+40.31111322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76459"},
        {"Smithsonian Astrophysical Observation", "SAO 45641"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.22703152),
        dec: Angle.Degrees(+40.31195944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30138"},
        {"Hipparcos Number", "HIP 22220"},
        {"Geneva Identification System", "GEN# +1.00030138"},
        {"Smithsonian Astrophysical Observation", "SAO 39746"},
        {"Wilson Evans Batten Catalogue", "WEB 4275"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.68529906),
        dec: Angle.Degrees(+40.31268034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107158"},
        {"Hipparcos Number", "HIP 60073"},
        {"Geneva Identification System", "GEN# +1.00107158"},
        {"Smithsonian Astrophysical Observation", "SAO 44121"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77691242),
        dec: Angle.Degrees(+40.31276723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213191"},
        {"Hipparcos Number", "HIP 110972"},
        {"Geneva Identification System", "GEN# +1.00213191"},
        {"Smithsonian Astrophysical Observation", "SAO 52048"},
        {"Wilson Evans Batten Catalogue", "WEB 19869"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.25380990),
        dec: Angle.Degrees(+40.31552403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275458"},
        {"Hipparcos Number", "HIP 16343"},
        {"Geneva Identification System", "GEN# +1.00275458"},
        {"Smithsonian Astrophysical Observation", "SAO 38897"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65868013),
        dec: Angle.Degrees(+40.31944909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201212"},
        {"Hipparcos Number", "HIP 104215"},
        {"Smithsonian Astrophysical Observation", "SAO 50459"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71363733),
        dec: Angle.Degrees(+40.31963132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139322"},
        {"Hipparcos Number", "HIP 76381"},
        {"Smithsonian Astrophysical Observation", "SAO 45629"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.00635332),
        dec: Angle.Degrees(+40.32108519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92075"},
        {"Hipparcos Number", "HIP 52088"},
        {"Smithsonian Astrophysical Observation", "SAO 43415"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.65361046),
        dec: Angle.Degrees(+40.32212826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88265",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10999 AB"},
        {"Henry Draper", "HD 164899"},
        {"Hipparcos Number", "HIP 88265"},
        {"Smithsonian Astrophysical Observation", "SAO 47144"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.37226543),
        dec: Angle.Degrees(+40.32371312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175537"},
        {"Hipparcos Number", "HIP 92739"},
        {"Geneva Identification System", "GEN# +1.00175537"},
        {"Smithsonian Astrophysical Observation", "SAO 47897"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.47573683),
        dec: Angle.Degrees(+40.32371821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141607"},
        {"Hipparcos Number", "HIP 77431"},
        {"Smithsonian Astrophysical Observation", "SAO 45738"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.10212855),
        dec: Angle.Degrees(+40.32437444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199054"},
        {"Hipparcos Number", "HIP 103084"},
        {"Smithsonian Astrophysical Observation", "SAO 50177"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.30567174),
        dec: Angle.Degrees(+40.32841215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192660"},
        {"Hipparcos Number", "HIP 99760"},
        {"Geneva Identification System", "GEN# +1.00192660"},
        {"Smithsonian Astrophysical Observation", "SAO 49346"},
        {"Wilson Evans Batten Catalogue", "WEB 17914"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60868279),
        dec: Angle.Degrees(+40.32919500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192143"},
        {"Hipparcos Number", "HIP 99515"},
        {"Celescope Catalog", "CEL 4969"},
        {"Geneva Identification System", "GEN# +1.00192143"},
        {"Smithsonian Astrophysical Observation", "SAO 49301"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94743583),
        dec: Angle.Degrees(+40.32999840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171945"},
        {"Hipparcos Number", "HIP 91144"},
        {"Smithsonian Astrophysical Observation", "SAO 47625"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.90349617),
        dec: Angle.Degrees(+40.33141248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3431"},
        {"Hipparcos Number", "HIP 2948"},
        {"Celescope Catalog", "CEL 81"},
        {"Geneva Identification System", "GEN# +1.00003431"},
        {"Smithsonian Astrophysical Observation", "SAO 36517"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.36004985),
        dec: Angle.Degrees(+40.33238095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68931"},
        {"Hipparcos Number", "HIP 40507"},
        {"Geneva Identification System", "GEN# +1.00068931"},
        {"Smithsonian Astrophysical Observation", "SAO 42259"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.05352717),
        dec: Angle.Degrees(+40.33337600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8837"},
        {"Hipparcos Number", "HIP 6823"},
        {"Geneva Identification System", "GEN# +1.00008837"},
        {"Smithsonian Astrophysical Observation", "SAO 37234"},
        {"Wilson Evans Batten Catalogue", "WEB 1490"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.94535203),
        dec: Angle.Degrees(+40.33582488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121197"},
        {"Hipparcos Number", "HIP 67778"},
        {"Geneva Identification System", "GEN# +1.00121197"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.28517972),
        dec: Angle.Degrees(+40.33800224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53076"},
        {"Hipparcos Number", "HIP 34198"},
        {"Smithsonian Astrophysical Observation", "SAO 41545"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38138122),
        dec: Angle.Degrees(+40.33874828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229244"},
        {"Hipparcos Number", "HIP 100606"},
        {"Smithsonian Astrophysical Observation", "SAO 49578"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.01581385),
        dec: Angle.Degrees(+40.33975078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97337"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.79245489),
        dec: Angle.Degrees(+40.34028305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 391.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82973"},
        {"Smithsonian Astrophysical Observation", "SAO 46389"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.33652528),
        dec: Angle.Degrees(+40.34203729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103799"},
        {"Hipparcos Number", "HIP 58287"},
        {"Fundamental Katalog 5th Edition", "FK5 2954"},
        {"Geneva Identification System", "GEN# +1.00103799"},
        {"Smithsonian Astrophysical Observation", "SAO 43963"},
        {"Wilson Evans Batten Catalogue", "WEB 10426"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31126898),
        dec: Angle.Degrees(+40.34388969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203454"},
        {"Hipparcos Number", "HIP 105406"},
        {"Geneva Identification System", "GEN# +1.00203454"},
        {"Smithsonian Astrophysical Observation", "SAO 50739"},
        {"Wilson Evans Batten Catalogue", "WEB 19142"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.25599353),
        dec: Angle.Degrees(+40.34557430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194908"},
        {"Hipparcos Number", "HIP 100833"},
        {"Celescope Catalog", "CEL 5064"},
        {"Smithsonian Astrophysical Observation", "SAO 49626"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.68234253),
        dec: Angle.Degrees(+40.34722313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40928"},
        {"Smithsonian Astrophysical Observation", "SAO 42305"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.28527202),
        dec: Angle.Degrees(+40.34839723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146278"},
        {"Hipparcos Number", "HIP 79542"},
        {"Smithsonian Astrophysical Observation", "SAO 45974"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.46444026),
        dec: Angle.Degrees(+40.34905109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68745"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.07775814),
        dec: Angle.Degrees(+40.35022965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153846"},
        {"Hipparcos Number", "HIP 83189"},
        {"Geneva Identification System", "GEN# +1.00153846"},
        {"Smithsonian Astrophysical Observation", "SAO 46427"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03190984),
        dec: Angle.Degrees(+40.35088678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278241"},
        {"Hipparcos Number", "HIP 25584"},
        {"Geneva Identification System", "GEN# +0.04001295"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00833252),
        dec: Angle.Degrees(+40.35150663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139641"},
        {"Hipparcos Number", "HIP 76534"},
        {"Fundamental Katalog 5th Edition", "FK5 580"},
        {"Geneva Identification System", "GEN# +1.00139641"},
        {"Smithsonian Astrophysical Observation", "SAO 45643"},
        {"Wilson Evans Batten Catalogue", "WEB 12989"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.45646241),
        dec: Angle.Degrees(+40.35328811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278240"},
        {"Hipparcos Number", "HIP 25587"},
        {"Geneva Identification System", "GEN# +1.00278240"},
        {"Smithsonian Astrophysical Observation", "SAO 40356"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.02581789),
        dec: Angle.Degrees(+40.35363580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8358 AB"},
        {"Henry Draper", "HD 103739"},
        {"Hipparcos Number", "HIP 58261"},
        {"Smithsonian Astrophysical Observation", "SAO 43958"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.22455937),
        dec: Angle.Degrees(+40.35598444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146758"},
        {"Hipparcos Number", "HIP 79719"},
        {"Smithsonian Astrophysical Observation", "SAO 45999"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.05005942),
        dec: Angle.Degrees(+40.35632776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64386"},
        {"Hipparcos Number", "HIP 38696"},
        {"Smithsonian Astrophysical Observation", "SAO 42072"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.83879109),
        dec: Angle.Degrees(+40.35671791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44902"},
        {"Hipparcos Number", "HIP 30643"},
        {"Smithsonian Astrophysical Observation", "SAO 41101"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.59635786),
        dec: Angle.Degrees(+40.35839582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14478"},
        {"Wilson Evans Batten Catalogue", "WEB 2818"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.71514731),
        dec: Angle.Degrees(+40.35978274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -383.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180682"},
        {"Hipparcos Number", "HIP 94659"},
        {"Geneva Identification System", "GEN# +1.00180682"},
        {"Smithsonian Astrophysical Observation", "SAO 48251"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.93228133),
        dec: Angle.Degrees(+40.36003641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181521"},
        {"Hipparcos Number", "HIP 94923"},
        {"Celescope Catalog", "CEL 4735"},
        {"Fundamental Katalog 5th Edition", "FK5 3543"},
        {"Geneva Identification System", "GEN# +1.00181521"},
        {"Smithsonian Astrophysical Observation", "SAO 48316"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.74211539),
        dec: Angle.Degrees(+40.36043925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11074 AB"},
        {"Henry Draper", "HD 165941"},
        {"Hipparcos Number", "HIP 88703"},
        {"Smithsonian Astrophysical Observation", "SAO 47220"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.62672118),
        dec: Angle.Degrees(+40.36098921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13640 A"},
        {"Henry Draper", "HD 193092"},
        {"Hipparcos Number", "HIP 99968"},
        {"Geneva Identification System", "GEN# +1.00193092"},
        {"Smithsonian Astrophysical Observation", "SAO 49410"},
        {"Wilson Evans Batten Catalogue", "WEB 17990"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23034999),
        dec: Angle.Degrees(+40.36507960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24165"},
        {"Hipparcos Number", "HIP 18123"},
        {"Geneva Identification System", "GEN# +1.00024165"},
        {"Smithsonian Astrophysical Observation", "SAO 39167"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.13789813),
        dec: Angle.Degrees(+40.36563175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35618"},
        {"Hipparcos Number", "HIP 25585"},
        {"Geneva Identification System", "GEN# +1.00035618"},
        {"Smithsonian Astrophysical Observation", "SAO 40354"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.01735832),
        dec: Angle.Degrees(+40.36674699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44531"},
        {"Smithsonian Astrophysical Observation", "SAO 42675"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.10480007),
        dec: Angle.Degrees(+40.36746008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189178"},
        {"Hipparcos Number", "HIP 98194"},
        {"Fundamental Katalog 5th Edition", "FK5 3593"},
        {"Geneva Identification System", "GEN# +1.00189178"},
        {"Renson", "Renson 52400"},
        {"Smithsonian Astrophysical Observation", "SAO 49011"},
        {"Wilson Evans Batten Catalogue", "WEB 17314"},
    },
    visualMagnitude: 5.46,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30776056),
        dec: Angle.Degrees(+40.36782505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278239"},
        {"Hipparcos Number", "HIP 25597"},
        {"Geneva Identification System", "GEN# +1.00278239"},
        {"Smithsonian Astrophysical Observation", "SAO 40357"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04587754),
        dec: Angle.Degrees(+40.36814217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171214"},
        {"Hipparcos Number", "HIP 90817"},
        {"Smithsonian Astrophysical Observation", "SAO 47564"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.89332240),
        dec: Angle.Degrees(+40.36868235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2384"},
        {"Smithsonian Astrophysical Observation", "SAO 36423"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.60929487),
        dec: Angle.Degrees(+40.36916613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62719",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.32,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51, 11.5000),
        dec: Angle.DegreesMinutesSeconds((int)+40, (int)22, 12.400)
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
    primaryId: "HIP 41702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41702"},
        {"Smithsonian Astrophysical Observation", "SAO 42396"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.56346033),
        dec: Angle.Degrees(+40.37048030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125275"},
        {"Hipparcos Number", "HIP 69822"},
        {"Smithsonian Astrophysical Observation", "SAO 44973"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.34437090),
        dec: Angle.Degrees(+40.37371250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63992",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8782 AB"},
        {"Hipparcos Number", "HIP 63992"},
        {"Smithsonian Astrophysical Observation", "SAO 44474"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.70570924),
        dec: Angle.Degrees(+40.37398500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110295"},
        {"Smithsonian Astrophysical Observation", "SAO 51892"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.10817196),
        dec: Angle.Degrees(+40.37480203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169356"},
        {"Hipparcos Number", "HIP 90040"},
        {"Smithsonian Astrophysical Observation", "SAO 47425"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.59638607),
        dec: Angle.Degrees(+40.37537731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216646"},
        {"Hipparcos Number", "HIP 113084"},
        {"Geneva Identification System", "GEN# +1.00216646"},
        {"Smithsonian Astrophysical Observation", "SAO 52471"},
        {"Wilson Evans Batten Catalogue", "WEB 20131"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52879493),
        dec: Angle.Degrees(+40.37683633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85397"},
        {"Hipparcos Number", "HIP 48439"},
        {"Smithsonian Astrophysical Observation", "SAO 43083"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.14735477),
        dec: Angle.Degrees(+40.37687451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10438"},
        {"Hipparcos Number", "HIP 7991"},
        {"Smithsonian Astrophysical Observation", "SAO 37452"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.65452871),
        dec: Angle.Degrees(+40.37736879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92990"},
        {"Hipparcos Number", "HIP 52571"},
        {"Geneva Identification System", "GEN# +1.00092990"},
        {"Smithsonian Astrophysical Observation", "SAO 43458"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.23865573),
        dec: Angle.Degrees(+40.38173759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4331",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 766 AB"},
        {"Henry Draper", "HD 5314"},
        {"Hipparcos Number", "HIP 4331"},
        {"Smithsonian Astrophysical Observation", "SAO 36771"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.86000812),
        dec: Angle.Degrees(+40.38249009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81296"},
        {"Smithsonian Astrophysical Observation", "SAO 46183"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.07227309),
        dec: Angle.Degrees(+40.38283444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16100 AB"},
        {"Henry Draper", "HD 214283"},
        {"Hipparcos Number", "HIP 111588"},
        {"Celescope Catalog", "CEL 5494"},
        {"Geneva Identification System", "GEN# +1.00214283"},
        {"Smithsonian Astrophysical Observation", "SAO 52178"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.09265437),
        dec: Angle.Degrees(+40.38431884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48629"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.74982341),
        dec: Angle.Degrees(+40.38472548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 257.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45885"},
        {"Smithsonian Astrophysical Observation", "SAO 42821"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.34036695),
        dec: Angle.Degrees(+40.38472584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112213"},
        {"Celescope Catalog", "CEL 5518"},
        {"Smithsonian Astrophysical Observation", "SAO 52304"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.90287970),
        dec: Angle.Degrees(+40.38510929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79044"},
        {"Hipparcos Number", "HIP 45218"},
        {"Geneva Identification System", "GEN# +1.00079044"},
        {"Smithsonian Astrophysical Observation", "SAO 42748"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.23094572),
        dec: Angle.Degrees(+40.38520110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138354"},
        {"Hipparcos Number", "HIP 75896"},
        {"Smithsonian Astrophysical Observation", "SAO 45570"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.52989469),
        dec: Angle.Degrees(+40.38525035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220807"},
        {"Hipparcos Number", "HIP 115696"},
        {"Geneva Identification System", "GEN# +1.00220807"},
        {"Smithsonian Astrophysical Observation", "SAO 53019"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.61389834),
        dec: Angle.Degrees(+40.38693949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79530"},
        {"Hipparcos Number", "HIP 45475"},
        {"Smithsonian Astrophysical Observation", "SAO 42777"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.00060502),
        dec: Angle.Degrees(+40.38744599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27893"},
        {"Smithsonian Astrophysical Observation", "SAO 40688"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.52886319),
        dec: Angle.Degrees(+40.38807672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73555",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nekkar"},
        {"Henry Draper", "HD 133208"},
        {"Hipparcos Number", "HIP 73555"},
        {"Fundamental Katalog 5th Edition", "FK5 555"},
        {"Geneva Identification System", "GEN# +1.00133208"},
        {"Smithsonian Astrophysical Observation", "SAO 45337"},
        {"Wilson Evans Batten Catalogue", "WEB 12582"},
    },
    visualMagnitude: 3.49,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48663804),
        dec: Angle.Degrees(+40.39063671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188891"},
        {"Hipparcos Number", "HIP 98061"},
        {"Geneva Identification System", "GEN# +1.00188891"},
        {"Smithsonian Astrophysical Observation", "SAO 48983"},
        {"Wilson Evans Batten Catalogue", "WEB 17276"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.93651896),
        dec: Angle.Degrees(+40.39175466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111222"},
        {"Smithsonian Astrophysical Observation", "SAO 52111"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.01194449),
        dec: Angle.Degrees(+40.39464108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72928"},
        {"Smithsonian Astrophysical Observation", "SAO 45267"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.58177128),
        dec: Angle.Degrees(+40.39625892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11189"},
        {"Hipparcos Number", "HIP 8584"},
        {"Smithsonian Astrophysical Observation", "SAO 37555"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.70103412),
        dec: Angle.Degrees(+40.39850436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 711"},
        {"Hipparcos Number", "HIP 926"},
        {"Smithsonian Astrophysical Observation", "SAO 36144"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.87971208),
        dec: Angle.Degrees(+40.39896612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65642"},
        {"Hipparcos Number", "HIP 39219"},
        {"Geneva Identification System", "GEN# +1.00065642"},
        {"Smithsonian Astrophysical Observation", "SAO 42127"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.33163361),
        dec: Angle.Degrees(+40.40087927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194789"},
        {"Hipparcos Number", "HIP 100784"},
        {"Celescope Catalog", "CEL 5061"},
        {"Geneva Identification System", "GEN# +1.00194789"},
        {"Smithsonian Astrophysical Observation", "SAO 49612"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.51605435),
        dec: Angle.Degrees(+40.40170386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174983"},
        {"Hipparcos Number", "HIP 92539"},
        {"Smithsonian Astrophysical Observation", "SAO 47861"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.86558799),
        dec: Angle.Degrees(+40.40259109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31143"},
        {"Geneva Identification System", "GEN# +0.04001623"},
        {"Smithsonian Astrophysical Observation", "SAO 41154"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.01146362),
        dec: Angle.Degrees(+40.40285466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47709"},
        {"Smithsonian Astrophysical Observation", "SAO 42999"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90772027),
        dec: Angle.Degrees(+40.40309121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125121"},
        {"Hipparcos Number", "HIP 69740"},
        {"Smithsonian Astrophysical Observation", "SAO 44964"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.11405522),
        dec: Angle.Degrees(+40.40318469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61276"},
        {"Geneva Identification System", "GEN# +0.04102303"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.36087655),
        dec: Angle.Degrees(+40.40417012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33088"},
        {"Smithsonian Astrophysical Observation", "SAO 41410"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.37280749),
        dec: Angle.Degrees(+40.40419703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37977"},
        {"Hipparcos Number", "HIP 27067"},
        {"Geneva Identification System", "GEN# +1.00037977"},
        {"Smithsonian Astrophysical Observation", "SAO 40573"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.10281216),
        dec: Angle.Degrees(+40.40488757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5404"},
        {"Smithsonian Astrophysical Observation", "SAO 36967"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.29321022),
        dec: Angle.Degrees(+40.40683518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205237"},
        {"Hipparcos Number", "HIP 106390"},
        {"Geneva Identification System", "GEN# +1.00205237"},
        {"Smithsonian Astrophysical Observation", "SAO 51009"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.22294928),
        dec: Angle.Degrees(+40.40744985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27070"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.11018989),
        dec: Angle.Degrees(+40.40755605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197867"},
        {"Hipparcos Number", "HIP 102397"},
        {"Smithsonian Astrophysical Observation", "SAO 50016"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.24352330),
        dec: Angle.Degrees(+40.41173834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205835"},
        {"Hipparcos Number", "HIP 106711"},
        {"Celescope Catalog", "CEL 5351"},
        {"Fundamental Katalog 5th Edition", "FK5 811"},
        {"Geneva Identification System", "GEN# +1.00205835"},
        {"Smithsonian Astrophysical Observation", "SAO 51101"},
        {"Wilson Evans Batten Catalogue", "WEB 19294"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.23740434),
        dec: Angle.Degrees(+40.41349052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104074"},
        {"Smithsonian Astrophysical Observation", "SAO 50428"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.27775563),
        dec: Angle.Degrees(+40.41637983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18614"},
        {"Hipparcos Number", "HIP 14051"},
        {"Smithsonian Astrophysical Observation", "SAO 38508"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.23147734),
        dec: Angle.Degrees(+40.41793292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110"},
        {"Hipparcos Number", "HIP 508"},
        {"Geneva Identification System", "GEN# +1.00000110"},
        {"Smithsonian Astrophysical Observation", "SAO 36057"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.51773179),
        dec: Angle.Degrees(+40.41853643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208222"},
        {"Hipparcos Number", "HIP 108071"},
        {"Geneva Identification System", "GEN# +1.00208222"},
        {"Smithsonian Astrophysical Observation", "SAO 51406"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.43983244),
        dec: Angle.Degrees(+40.41945550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122574"},
        {"Hipparcos Number", "HIP 68536"},
        {"Geneva Identification System", "GEN# +1.00122574"},
        {"Smithsonian Astrophysical Observation", "SAO 44851"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.45577340),
        dec: Angle.Degrees(+40.42005851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39302"},
        {"Hipparcos Number", "HIP 27853"},
        {"Smithsonian Astrophysical Observation", "SAO 40684"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.39277114),
        dec: Angle.Degrees(+40.42012701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119890"},
        {"Hipparcos Number", "HIP 67106"},
        {"Smithsonian Astrophysical Observation", "SAO 44733"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.31303421),
        dec: Angle.Degrees(+40.42148673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107429"},
        {"Smithsonian Astrophysical Observation", "SAO 51262"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37770499),
        dec: Angle.Degrees(+40.42529253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51658",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7826 A"},
        {"Henry Draper", "HD 91312"},
        {"Hipparcos Number", "HIP 51658"},
        {"Fundamental Katalog 5th Edition", "FK5 2844"},
        {"Geneva Identification System", "GEN# +1.00091312"},
        {"Smithsonian Astrophysical Observation", "SAO 43379"},
        {"Wilson Evans Batten Catalogue", "WEB 9421"},
    },
    visualMagnitude: 4.72,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.30832166),
        dec: Angle.Degrees(+40.42554046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195629"},
        {"Hipparcos Number", "HIP 101220"},
        {"Celescope Catalog", "CEL 5093"},
        {"Geneva Identification System", "GEN# +1.00195629"},
        {"Smithsonian Astrophysical Observation", "SAO 49729"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.76151199),
        dec: Angle.Degrees(+40.42655663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62501"},
        {"Geneva Identification System", "GEN# +0.04102331"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.11331845),
        dec: Angle.Degrees(+40.42739766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228038"},
        {"Hipparcos Number", "HIP 99331"},
        {"Smithsonian Astrophysical Observation", "SAO 49253"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.41903014),
        dec: Angle.Degrees(+40.42841105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179583"},
        {"Hipparcos Number", "HIP 94280"},
        {"Celescope Catalog", "CEL 4716"},
        {"Geneva Identification System", "GEN# +1.00179583"},
        {"Smithsonian Astrophysical Observation", "SAO 48168"},
        {"Wilson Evans Batten Catalogue", "WEB 16421"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.84647990),
        dec: Angle.Degrees(+40.42915794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81854"},
        {"Hipparcos Number", "HIP 46528"},
        {"Smithsonian Astrophysical Observation", "SAO 42887"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.34865058),
        dec: Angle.Degrees(+40.42977592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53721",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Chalawan"},
        {"Henry Draper", "HD 95128"},
        {"Hipparcos Number", "HIP 53721"},
        {"Fundamental Katalog 5th Edition", "FK5 1282"},
        {"Geneva Identification System", "GEN# +1.00095128"},
        {"Smithsonian Astrophysical Observation", "SAO 43557"},
        {"Wilson Evans Batten Catalogue", "WEB 9731"},
    },
    visualMagnitude: 5.03,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.86756582),
        dec: Angle.Degrees(+40.43012281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -315.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98681"},
        {"Hipparcos Number", "HIP 55470"},
        {"Geneva Identification System", "GEN# +1.00098681"},
        {"Smithsonian Astrophysical Observation", "SAO 43709"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.39921096),
        dec: Angle.Degrees(+40.43111813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4127"},
        {"Hipparcos Number", "HIP 3448"},
        {"Geneva Identification System", "GEN# +1.00004127"},
        {"Smithsonian Astrophysical Observation", "SAO 36610"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.02118450),
        dec: Angle.Degrees(+40.43395835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91999"},
        {"Hipparcos Number", "HIP 52047"},
        {"Geneva Identification System", "GEN# +1.00091999"},
        {"Smithsonian Astrophysical Observation", "SAO 43413"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.53163070),
        dec: Angle.Degrees(+40.43726488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219856"},
        {"Hipparcos Number", "HIP 115106"},
        {"Geneva Identification System", "GEN# +1.00219856"},
        {"Smithsonian Astrophysical Observation", "SAO 52888"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.71388007),
        dec: Angle.Degrees(+40.43778585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202973"},
        {"Hipparcos Number", "HIP 105158"},
        {"Smithsonian Astrophysical Observation", "SAO 50679"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.53035452),
        dec: Angle.Degrees(+40.43974850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59241"},
        {"Hipparcos Number", "HIP 36533"},
        {"Smithsonian Astrophysical Observation", "SAO 41828"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73471227),
        dec: Angle.Degrees(+40.44291266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222986"},
        {"Hipparcos Number", "HIP 117184"},
        {"Smithsonian Astrophysical Observation", "SAO 53350"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.39548426),
        dec: Angle.Degrees(+40.44343199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70273"},
        {"Hipparcos Number", "HIP 41056"},
        {"Geneva Identification System", "GEN# +1.00070273"},
        {"Smithsonian Astrophysical Observation", "SAO 42318"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.66237617),
        dec: Angle.Degrees(+40.44392505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86817",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10760 A"},
        {"Henry Draper", "HD 161549"},
        {"Hipparcos Number", "HIP 86817"},
        {"Smithsonian Astrophysical Observation", "SAO 46920"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.09186190),
        dec: Angle.Degrees(+40.44753425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163565"},
        {"Hipparcos Number", "HIP 87713"},
        {"Smithsonian Astrophysical Observation", "SAO 47061"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.75256663),
        dec: Angle.Degrees(+40.44850259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3201"},
        {"Hipparcos Number", "HIP 2792"},
        {"Smithsonian Astrophysical Observation", "SAO 36493"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.89321959),
        dec: Angle.Degrees(+40.45039367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116783"},
        {"Hipparcos Number", "HIP 65473"},
        {"Geneva Identification System", "GEN# +1.00116783"},
        {"Smithsonian Astrophysical Observation", "SAO 44600"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.29519067),
        dec: Angle.Degrees(+40.45147868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37795"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.24881142),
        dec: Angle.Degrees(+40.45211294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202237"},
        {"Hipparcos Number", "HIP 104754"},
        {"Celescope Catalog", "CEL 5277"},
        {"Geneva Identification System", "GEN# +1.00202237"},
        {"Smithsonian Astrophysical Observation", "SAO 50585"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.33353889),
        dec: Angle.Degrees(+40.45764597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129846"},
        {"Hipparcos Number", "HIP 72012"},
        {"Fundamental Katalog 5th Edition", "FK5 3166"},
        {"Geneva Identification System", "GEN# +1.00129846"},
        {"Smithsonian Astrophysical Observation", "SAO 45190"},
        {"Wilson Evans Batten Catalogue", "WEB 12396"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.93518566),
        dec: Angle.Degrees(+40.45920338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152086"},
        {"Hipparcos Number", "HIP 82343"},
        {"Smithsonian Astrophysical Observation", "SAO 46306"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.37850079),
        dec: Angle.Degrees(+40.45921416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34332"},
        {"Hipparcos Number", "HIP 24771"},
        {"Geneva Identification System", "GEN# +1.00034332"},
        {"Smithsonian Astrophysical Observation", "SAO 40224"},
        {"Wilson Evans Batten Catalogue", "WEB 4791"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.66801388),
        dec: Angle.Degrees(+40.46515715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14408"},
        {"Hipparcos Number", "HIP 10922"},
        {"Smithsonian Astrophysical Observation", "SAO 37956"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.16584574),
        dec: Angle.Degrees(+40.46574244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163399"},
        {"Hipparcos Number", "HIP 87647"},
        {"Smithsonian Astrophysical Observation", "SAO 47045"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.54058305),
        dec: Angle.Degrees(+40.46675698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116800"},
        {"Hipparcos Number", "HIP 65484"},
        {"Smithsonian Astrophysical Observation", "SAO 44601"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.32194688),
        dec: Angle.Degrees(+40.46691271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112808"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.68347355),
        dec: Angle.Degrees(+40.46699581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204655"},
        {"Hipparcos Number", "HIP 106061"},
        {"Smithsonian Astrophysical Observation", "SAO 50921"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.24467207),
        dec: Angle.Degrees(+40.46850215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90860"},
        {"Hipparcos Number", "HIP 51414"},
        {"Geneva Identification System", "GEN# +1.00090860"},
        {"Smithsonian Astrophysical Observation", "SAO 43362"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.51835803),
        dec: Angle.Degrees(+40.46994017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50949"},
        {"Smithsonian Astrophysical Observation", "SAO 43322"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.07766118),
        dec: Angle.Degrees(+40.47299649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112929"},
        {"Hipparcos Number", "HIP 63418"},
        {"Geneva Identification System", "GEN# +1.00112929"},
        {"Smithsonian Astrophysical Observation", "SAO 44418"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.93324870),
        dec: Angle.Degrees(+40.47486622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173024"},
        {"Hipparcos Number", "HIP 91658"},
        {"Geneva Identification System", "GEN# +1.00173024"},
        {"Smithsonian Astrophysical Observation", "SAO 47704"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.36432627),
        dec: Angle.Degrees(+40.47632013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55992"},
        {"Smithsonian Astrophysical Observation", "SAO 43759"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.12284950),
        dec: Angle.Degrees(+40.47904786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196522"},
        {"Hipparcos Number", "HIP 101677"},
        {"Celescope Catalog", "CEL 5125"},
        {"Geneva Identification System", "GEN# +1.00196522"},
        {"Smithsonian Astrophysical Observation", "SAO 49849"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.14859185),
        dec: Angle.Degrees(+40.47919615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50588"},
        {"Smithsonian Astrophysical Observation", "SAO 43287"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.01374785),
        dec: Angle.Degrees(+40.47922447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57104"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.59678991),
        dec: Angle.Degrees(+40.47931296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17467"},
        {"Hipparcos Number", "HIP 13162"},
        {"Smithsonian Astrophysical Observation", "SAO 38364"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.31910090),
        dec: Angle.Degrees(+40.47999208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15282",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2443 AB"},
        {"Henry Draper", "HD 20283"},
        {"Hipparcos Number", "HIP 15282"},
        {"Smithsonian Astrophysical Observation", "SAO 38700"},
        {"Wilson Evans Batten Catalogue", "WEB 2943"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.29769270),
        dec: Angle.Degrees(+40.48305429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26673"},
        {"Henry Draper 2", "HD 26674"},
        {"Hipparcos Number", "HIP 19811"},
        {"Fundamental Katalog 5th Edition", "FK5 2306"},
        {"Geneva Identification System", "GEN# +1.00026673"},
        {"Smithsonian Astrophysical Observation", "SAO 39409"},
        {"Wilson Evans Batten Catalogue", "WEB 3785"},
    },
    visualMagnitude: 4.67,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.72212566),
        dec: Angle.Degrees(+40.48372394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110865"},
    },
    visualMagnitude: 10.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.92427479),
        dec: Angle.Degrees(+40.48490224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171065"},
        {"Hipparcos Number", "HIP 90736"},
        {"Geneva Identification System", "GEN# +1.00171065"},
        {"Smithsonian Astrophysical Observation", "SAO 47551"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.70181261),
        dec: Angle.Degrees(+40.48848094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68032"},
        {"Geneva Identification System", "GEN# +0.04102441"},
        {"Smithsonian Astrophysical Observation", "SAO 44805"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.96125414),
        dec: Angle.Degrees(+40.48861369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75083"},
        {"Smithsonian Astrophysical Observation", "SAO 45493"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.14714116),
        dec: Angle.Degrees(+40.49316728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 414"},
        {"Hipparcos Number", "HIP 714"},
        {"Smithsonian Astrophysical Observation", "SAO 36097"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.20832630),
        dec: Angle.Degrees(+40.49456869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5496 A"},
        {"Hipparcos Number", "HIP 32892"},
        {"Smithsonian Astrophysical Observation", "SAO 41388"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.79926737),
        dec: Angle.Degrees(+40.49529868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211097"},
        {"Hipparcos Number", "HIP 109766"},
        {"Smithsonian Astrophysical Observation", "SAO 51784"},
    },
    visualMagnitude: 9.25,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.49533264),
        dec: Angle.Degrees(+40.49681569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226571"},
        {"Hipparcos Number", "HIP 98037"},
        {"Smithsonian Astrophysical Observation", "SAO 48977"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83092637),
        dec: Angle.Degrees(+40.49929592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56229"},
        {"Geneva Identification System", "GEN# +0.04102201"},
        {"Wilson Evans Batten Catalogue", "WEB 10103"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.90209236),
        dec: Angle.Degrees(+40.50041244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8820 AB"},
        {"Henry Draper", "HD 114878"},
        {"Hipparcos Number", "HIP 64464"},
        {"Smithsonian Astrophysical Observation", "SAO 44508"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.19895581),
        dec: Angle.Degrees(+40.50418259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95691"},
        {"Hipparcos Number", "HIP 54020"},
        {"Smithsonian Astrophysical Observation", "SAO 43591"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.77316603),
        dec: Angle.Degrees(+40.50457015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60234"},
        {"Hipparcos Number", "HIP 36906"},
        {"Geneva Identification System", "GEN# +1.00060234"},
        {"Smithsonian Astrophysical Observation", "SAO 41869"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.81720828),
        dec: Angle.Degrees(+40.50640013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193246"},
        {"Hipparcos Number", "HIP 100037"},
        {"Geneva Identification System", "GEN# +1.00193246"},
        {"Smithsonian Astrophysical Observation", "SAO 49432"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43518532),
        dec: Angle.Degrees(+40.50686577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38189"},
        {"Hipparcos Number", "HIP 27192"},
        {"Geneva Identification System", "GEN# +1.00038189"},
        {"Renson", "Renson 10280"},
        {"Smithsonian Astrophysical Observation", "SAO 40584"},
        {"Wilson Evans Batten Catalogue", "WEB 5345"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.45636894),
        dec: Angle.Degrees(+40.50724268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13531"},
        {"Henry Draper 2", "HD 13531A"},
        {"Hipparcos Number", "HIP 10339"},
        {"Geneva Identification System", "GEN# +1.00013531"},
        {"Smithsonian Astrophysical Observation", "SAO 37868"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.30537928),
        dec: Angle.Degrees(+40.50782151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74778"},
        {"Hipparcos Number", "HIP 43160"},
        {"Smithsonian Astrophysical Observation", "SAO 42547"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.85841732),
        dec: Angle.Degrees(+40.50861036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61029"},
    },
    visualMagnitude: 12.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.61545841),
        dec: Angle.Degrees(+40.50896167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276552"},
        {"Hipparcos Number", "HIP 21234"},
        {"Smithsonian Astrophysical Observation", "SAO 39603"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.32155535),
        dec: Angle.Degrees(+40.51179556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116637"},
        {"Smithsonian Astrophysical Observation", "SAO 53217"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.54303150),
        dec: Angle.Degrees(+40.51274513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184056"},
        {"Hipparcos Number", "HIP 95964"},
        {"Smithsonian Astrophysical Observation", "SAO 48534"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.72228229),
        dec: Angle.Degrees(+40.51340184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216122"},
        {"Hipparcos Number", "HIP 112722"},
        {"Smithsonian Astrophysical Observation", "SAO 52401"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.42262412),
        dec: Angle.Degrees(+40.51532024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155102"},
        {"Hipparcos Number", "HIP 83816"},
        {"Fundamental Katalog 5th Edition", "FK5 636"},
        {"Geneva Identification System", "GEN# +1.00155102"},
        {"Renson", "Renson 43780"},
        {"Smithsonian Astrophysical Observation", "SAO 46502"},
        {"Wilson Evans Batten Catalogue", "WEB 14164"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.94461556),
        dec: Angle.Degrees(+40.51613969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76208"},
        {"Smithsonian Astrophysical Observation", "SAO 45612"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.50985597),
        dec: Angle.Degrees(+40.51626467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29222"},
        {"Smithsonian Astrophysical Observation", "SAO 40901"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.42743856),
        dec: Angle.Degrees(+40.51664051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13150"},
        {"Smithsonian Astrophysical Observation", "SAO 38360"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.28493076),
        dec: Angle.Degrees(+40.51855052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2271"},
        {"Hipparcos Number", "HIP 2108"},
        {"Smithsonian Astrophysical Observation", "SAO 36372"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.69508853),
        dec: Angle.Degrees(+40.51867349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29374"},
        {"Hipparcos Number", "HIP 21690"},
        {"Smithsonian Astrophysical Observation", "SAO 39672"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.84913152),
        dec: Angle.Degrees(+40.51971717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44413"},
        {"Hipparcos Number", "HIP 30408"},
        {"Geneva Identification System", "GEN# +1.00044413"},
        {"Smithsonian Astrophysical Observation", "SAO 41062"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.91170519),
        dec: Angle.Degrees(+40.52139084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44853"},
        {"Smithsonian Astrophysical Observation", "SAO 42710"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.07889273),
        dec: Angle.Degrees(+40.52157277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110314"},
        {"Hipparcos Number", "HIP 61880"},
        {"Geneva Identification System", "GEN# +1.00110314"},
        {"Smithsonian Astrophysical Observation", "SAO 44279"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20839581),
        dec: Angle.Degrees(+40.52184026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15059"},
        {"Smithsonian Astrophysical Observation", "SAO 38666"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.51209108),
        dec: Angle.Degrees(+40.52260894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84738"},
        {"Hipparcos Number", "HIP 48092"},
        {"Smithsonian Astrophysical Observation", "SAO 43044"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.08259476),
        dec: Angle.Degrees(+40.52508757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206569"},
        {"Hipparcos Number", "HIP 107116"},
        {"Geneva Identification System", "GEN# +1.00206569"},
        {"Smithsonian Astrophysical Observation", "SAO 51196"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.45317866),
        dec: Angle.Degrees(+40.52557522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107631"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.01573245),
        dec: Angle.Degrees(+40.52590331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115654"},
        {"Hipparcos Number", "HIP 64889"},
        {"Geneva Identification System", "GEN# +1.00115654"},
        {"Smithsonian Astrophysical Observation", "SAO 44553"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.51955800),
        dec: Angle.Degrees(+40.52970839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97906"},
        {"Hipparcos Number", "HIP 55047"},
        {"Smithsonian Astrophysical Observation", "SAO 43671"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.03532041),
        dec: Angle.Degrees(+40.52998105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23596"},
        {"Hipparcos Number", "HIP 17747"},
        {"Geneva Identification System", "GEN# +1.00023596"},
        {"Smithsonian Astrophysical Observation", "SAO 39110"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00138686),
        dec: Angle.Degrees(+40.53058407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201761"},
        {"Hipparcos Number", "HIP 104527"},
        {"Smithsonian Astrophysical Observation", "SAO 50532"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.61424183),
        dec: Angle.Degrees(+40.53120373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171484"},
        {"Hipparcos Number", "HIP 90948"},
        {"Smithsonian Astrophysical Observation", "SAO 47586"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.28517799),
        dec: Angle.Degrees(+40.53231511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40128"},
        {"Smithsonian Astrophysical Observation", "SAO 42221"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.94956911),
        dec: Angle.Degrees(+40.53352994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97333"},
        {"Hipparcos Number", "HIP 54747"},
        {"Geneva Identification System", "GEN# +1.00097333"},
        {"Renson", "Renson 28080"},
        {"Smithsonian Astrophysical Observation", "SAO 43643"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.14302805),
        dec: Angle.Degrees(+40.53433465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42152"},
        {"Hipparcos Number", "HIP 29336"},
        {"Renson", "Renson 11263"},
        {"Smithsonian Astrophysical Observation", "SAO 40922"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.77142957),
        dec: Angle.Degrees(+40.53567126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50720"},
        {"Hipparcos Number", "HIP 33355"},
        {"Geneva Identification System", "GEN# +1.00050720"},
        {"Smithsonian Astrophysical Observation", "SAO 41445"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.06141545),
        dec: Angle.Degrees(+40.53698097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22352"},
        {"Hipparcos Number", "HIP 16894"},
        {"Smithsonian Astrophysical Observation", "SAO 38988"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.34362989),
        dec: Angle.Degrees(+40.53814054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57244"},
        {"Geneva Identification System", "GEN# +6.20017023"},
    },
    visualMagnitude: 12.02,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.07357937),
        dec: Angle.Degrees(+40.53893978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109461"},
        {"Hipparcos Number", "HIP 61370"},
        {"Geneva Identification System", "GEN# +1.00109461"},
        {"Smithsonian Astrophysical Observation", "SAO 44235"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.64793217),
        dec: Angle.Degrees(+40.53938810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218394"},
        {"Hipparcos Number", "HIP 114168"},
        {"Geneva Identification System", "GEN# +1.00218394"},
        {"Smithsonian Astrophysical Observation", "SAO 52705"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.81213756),
        dec: Angle.Degrees(+40.55036911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14105"},
        {"Hipparcos Number", "HIP 10708"},
        {"Smithsonian Astrophysical Observation", "SAO 37930"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.46808908),
        dec: Angle.Degrees(+40.55050084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122384"},
        {"Hipparcos Number", "HIP 68433"},
        {"Geneva Identification System", "GEN# +1.00122384"},
        {"Smithsonian Astrophysical Observation", "SAO 44840"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.14909796),
        dec: Angle.Degrees(+40.55107879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39846"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.11297089),
        dec: Angle.Degrees(+40.55110370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112293"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.18049199),
        dec: Angle.Degrees(+40.55447458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222556"},
        {"Hipparcos Number", "HIP 116882"},
        {"Geneva Identification System", "GEN# +1.00222556"},
        {"Smithsonian Astrophysical Observation", "SAO 53277"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.37342822),
        dec: Angle.Degrees(+40.55466753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12904 AB"},
        {"Henry Draper", "HD 186978"},
        {"Hipparcos Number", "HIP 97240"},
        {"Celescope Catalog", "CEL 4837"},
        {"Geneva Identification System", "GEN# +1.00186978J"},
        {"Smithsonian Astrophysical Observation", "SAO 48807"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.45316843),
        dec: Angle.Degrees(+40.55524482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145605"},
        {"Hipparcos Number", "HIP 79234"},
        {"Geneva Identification System", "GEN# +1.00145605"},
        {"Smithsonian Astrophysical Observation", "SAO 45929"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.56582729),
        dec: Angle.Degrees(+40.55548565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63303"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.58951765),
        dec: Angle.Degrees(+40.55672521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114941"},
        {"Hipparcos Number", "HIP 64508"},
        {"Geneva Identification System", "GEN# +1.00114941"},
        {"Smithsonian Astrophysical Observation", "SAO 44515"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.33248265),
        dec: Angle.Degrees(+40.56094308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51717"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.50056823),
        dec: Angle.Degrees(+40.56099584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40488"},
        {"Smithsonian Astrophysical Observation", "SAO 42258"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99789104),
        dec: Angle.Degrees(+40.56124147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26498"},
        {"Hipparcos Number", "HIP 19699"},
        {"Smithsonian Astrophysical Observation", "SAO 39391"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.30182466),
        dec: Angle.Degrees(+40.56209812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65844"},
        {"Geneva Identification System", "GEN# +0.04102402"},
        {"Smithsonian Astrophysical Observation", "SAO 44629"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.46044688),
        dec: Angle.Degrees(+40.56304283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129428"},
        {"Hipparcos Number", "HIP 71801"},
        {"Smithsonian Astrophysical Observation", "SAO 45170"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.30386317),
        dec: Angle.Degrees(+40.56380987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109632"},
        {"Smithsonian Astrophysical Observation", "SAO 51760"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.12659667),
        dec: Angle.Degrees(+40.56486300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31304"},
        {"Smithsonian Astrophysical Observation", "SAO 41182"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.46729972),
        dec: Angle.Degrees(+40.56883305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86415"},
        {"Hipparcos Number", "HIP 48968"},
        {"Smithsonian Astrophysical Observation", "SAO 43127"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.84145455),
        dec: Angle.Degrees(+40.57200886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115604"},
        {"Hipparcos Number", "HIP 64844"},
        {"Fundamental Katalog 5th Edition", "FK5 494"},
        {"Geneva Identification System", "GEN# +1.00115604"},
        {"Renson", "Renson 33430"},
        {"Smithsonian Astrophysical Observation", "SAO 44549"},
        {"Wilson Evans Batten Catalogue", "WEB 11464"},
    },
    visualMagnitude: 4.72,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.38598801),
        dec: Angle.Degrees(+40.57256275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1311 A"},
        {"Henry Draper", "HD 10205"},
        {"Hipparcos Number", "HIP 7818"},
        {"Geneva Identification System", "GEN# +1.00010205A"},
        {"Smithsonian Astrophysical Observation", "SAO 37418"},
        {"Wilson Evans Batten Catalogue", "WEB 1672"},
    },
    visualMagnitude: 4.96,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.14501739),
        dec: Angle.Degrees(+40.57710624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42065"},
        {"Hipparcos Number", "HIP 29299"},
        {"Geneva Identification System", "GEN# +1.00042065"},
        {"Smithsonian Astrophysical Observation", "SAO 40912"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.65742066),
        dec: Angle.Degrees(+40.57755531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77310"},
        {"Hipparcos Number", "HIP 44434"},
        {"Smithsonian Astrophysical Observation", "SAO 42659"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.79846131),
        dec: Angle.Degrees(+40.57797131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68640"},
        {"Hipparcos Number", "HIP 40403"},
        {"Smithsonian Astrophysical Observation", "SAO 42243"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.72520654),
        dec: Angle.Degrees(+40.57858100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110392"},
        {"Hipparcos Number", "HIP 61925"},
        {"Geneva Identification System", "GEN# +1.00110392"},
        {"Smithsonian Astrophysical Observation", "SAO 44285"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.36241151),
        dec: Angle.Degrees(+40.57937434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212440"},
        {"Hipparcos Number", "HIP 110533"},
        {"Smithsonian Astrophysical Observation", "SAO 51952"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.88541390),
        dec: Angle.Degrees(+40.57944071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14126 AB"},
        {"Henry Draper", "HD 197018"},
        {"Hipparcos Number", "HIP 101949"},
        {"Celescope Catalog", "CEL 5136"},
        {"Geneva Identification System", "GEN# +1.00197018J"},
        {"Renson", "Renson 54940"},
        {"Smithsonian Astrophysical Observation", "SAO 49899"},
        {"Wilson Evans Batten Catalogue", "WEB 18430"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.88879736),
        dec: Angle.Degrees(+40.57965647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52654"},
        {"Hipparcos Number", "HIP 34068"},
        {"Smithsonian Astrophysical Observation", "SAO 41536"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.99322461),
        dec: Angle.Degrees(+40.58214693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19066"},
        {"Hipparcos Number", "HIP 14365"},
        {"Geneva Identification System", "GEN# +1.00019066"},
        {"Smithsonian Astrophysical Observation", "SAO 38559"},
        {"Wilson Evans Batten Catalogue", "WEB 2806"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.33762269),
        dec: Angle.Degrees(+40.58219109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7738"},
        {"Smithsonian Astrophysical Observation", "SAO 37412"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.91316402),
        dec: Angle.Degrees(+40.58375091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181680"},
        {"Hipparcos Number", "HIP 94973"},
        {"Smithsonian Astrophysical Observation", "SAO 48332"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.90042723),
        dec: Angle.Degrees(+40.58538437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109681"},
        {"Hipparcos Number", "HIP 61514"},
        {"Geneva Identification System", "GEN# +1.00109681"},
        {"Smithsonian Astrophysical Observation", "SAO 44243"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.05161069),
        dec: Angle.Degrees(+40.58639395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84672"},
        {"Smithsonian Astrophysical Observation", "SAO 46625"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.65566136),
        dec: Angle.Degrees(+40.58642075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66545"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.61604013),
        dec: Angle.Degrees(+40.58889730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185457"},
        {"Hipparcos Number", "HIP 96528"},
        {"Geneva Identification System", "GEN# +1.00185457"},
        {"Smithsonian Astrophysical Observation", "SAO 48658"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.36545517),
        dec: Angle.Degrees(+40.58893275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193159"},
        {"Hipparcos Number", "HIP 99997"},
        {"Celescope Catalog", "CEL 5014"},
        {"Geneva Identification System", "GEN# +1.00193159"},
        {"Smithsonian Astrophysical Observation", "SAO 49421"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.30219376),
        dec: Angle.Degrees(+40.59139424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113075"},
        {"Smithsonian Astrophysical Observation", "SAO 52467"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50768385),
        dec: Angle.Degrees(+40.59195848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162230"},
        {"Hipparcos Number", "HIP 87130"},
        {"Smithsonian Astrophysical Observation", "SAO 46961"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.03167914),
        dec: Angle.Degrees(+40.59218892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45560"},
        {"Smithsonian Astrophysical Observation", "SAO 42789"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.28972968),
        dec: Angle.Degrees(+40.59445155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75588"},
        {"Smithsonian Astrophysical Observation", "SAO 45542"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.64257234),
        dec: Angle.Degrees(+40.59473921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15980"},
        {"Hipparcos Number", "HIP 12042"},
        {"Geneva Identification System", "GEN# +1.00015980"},
        {"Renson", "Renson 3980"},
        {"Smithsonian Astrophysical Observation", "SAO 38143"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.80830638),
        dec: Angle.Degrees(+40.59673597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77530"},
        {"Hipparcos Number", "HIP 44537"},
        {"Smithsonian Astrophysical Observation", "SAO 42676"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.11714154),
        dec: Angle.Degrees(+40.59781627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187879"},
        {"Hipparcos Number", "HIP 97634"},
        {"Celescope Catalog", "CEL 4859"},
        {"Fundamental Katalog 5th Edition", "FK5 3584"},
        {"Geneva Identification System", "GEN# +1.00187879"},
        {"Smithsonian Astrophysical Observation", "SAO 48892"},
        {"Wilson Evans Batten Catalogue", "WEB 17167"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.65553824),
        dec: Angle.Degrees(+40.59977800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73554"},
        {"Smithsonian Astrophysical Observation", "SAO 45336"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48585196),
        dec: Angle.Degrees(+40.60060985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68150"},
        {"Smithsonian Astrophysical Observation", "SAO 44814"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27963455),
        dec: Angle.Degrees(+40.60089177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94952"},
        {"Smithsonian Astrophysical Observation", "SAO 48326"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.82792372),
        dec: Angle.Degrees(+40.60228212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30586"},
        {"Hipparcos Number", "HIP 22521"},
        {"Smithsonian Astrophysical Observation", "SAO 39794"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.69342859),
        dec: Angle.Degrees(+40.60691044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12116"},
        {"Smithsonian Astrophysical Observation", "SAO 38157"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03012123),
        dec: Angle.Degrees(+40.60895862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106384"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.20579221),
        dec: Angle.Degrees(+40.60929979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8330"},
        {"Hipparcos Number", "HIP 6469"},
        {"Smithsonian Astrophysical Observation", "SAO 37165"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.80357748),
        dec: Angle.Degrees(+40.61042538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17102"},
        {"Hipparcos Number", "HIP 12911"},
        {"Smithsonian Astrophysical Observation", "SAO 38311"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.49766327),
        dec: Angle.Degrees(+40.61202912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32631"},
        {"Hipparcos Number", "HIP 23764"},
        {"Geneva Identification System", "GEN# +1.00032631"},
        {"Smithsonian Astrophysical Observation", "SAO 40027"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.62409920),
        dec: Angle.Degrees(+40.61419709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213659"},
        {"Hipparcos Number", "HIP 111252"},
        {"Geneva Identification System", "GEN# +1.00213659"},
        {"Renson", "Renson 59270"},
        {"Smithsonian Astrophysical Observation", "SAO 52115"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.08921911),
        dec: Angle.Degrees(+40.61504995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200325"},
        {"Hipparcos Number", "HIP 103749"},
        {"Geneva Identification System", "GEN# +1.00200325"},
        {"Smithsonian Astrophysical Observation", "SAO 50360"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.35869498),
        dec: Angle.Degrees(+40.61794713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107688"},
        {"Smithsonian Astrophysical Observation", "SAO 51325"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.21847871),
        dec: Angle.Degrees(+40.62040054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66931"},
        {"Geneva Identification System", "GEN# +0.04102418"},
        {"Smithsonian Astrophysical Observation", "SAO 44723"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.75143730),
        dec: Angle.Degrees(+40.62098836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5379 B"},
        {"Hipparcos Number", "HIP 32277"},
        {"Smithsonian Astrophysical Observation", "SAO 41306"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.08091758),
        dec: Angle.Degrees(+40.62302955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5379 A"},
        {"Henry Draper", "HD 48228"},
        {"Hipparcos Number", "HIP 32275"},
        {"Geneva Identification System", "GEN# +1.00048228"},
        {"Smithsonian Astrophysical Observation", "SAO 41305"},
        {"Wilson Evans Batten Catalogue", "WEB 6506"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.07247595),
        dec: Angle.Degrees(+40.62331775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142126"},
        {"Hipparcos Number", "HIP 77651"},
        {"Smithsonian Astrophysical Observation", "SAO 45760"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.79093779),
        dec: Angle.Degrees(+40.62589905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185780"},
        {"Hipparcos Number", "HIP 96659"},
        {"Celescope Catalog", "CEL 4807"},
        {"Geneva Identification System", "GEN# +1.00185780"},
        {"Smithsonian Astrophysical Observation", "SAO 48681"},
        {"Wilson Evans Batten Catalogue", "WEB 16956"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.78149220),
        dec: Angle.Degrees(+40.62684896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145201"},
        {"Hipparcos Number", "HIP 79039"},
        {"Smithsonian Astrophysical Observation", "SAO 45903"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.00424923),
        dec: Angle.Degrees(+40.62755277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197589"},
        {"Hipparcos Number", "HIP 102254"},
        {"Smithsonian Astrophysical Observation", "SAO 49977"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.79702385),
        dec: Angle.Degrees(+40.62892036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90039"},
        {"Hipparcos Number", "HIP 50946"},
        {"Smithsonian Astrophysical Observation", "SAO 43321"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.06306207),
        dec: Angle.Degrees(+40.63542386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206197"},
        {"Hipparcos Number", "HIP 106933"},
        {"Celescope Catalog", "CEL 5358"},
        {"Geneva Identification System", "GEN# +1.00206197"},
        {"Smithsonian Astrophysical Observation", "SAO 51151"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.85401458),
        dec: Angle.Degrees(+40.63711254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102571"},
        {"Hipparcos Number", "HIP 57600"},
        {"Geneva Identification System", "GEN# +1.00102571"},
        {"Smithsonian Astrophysical Observation", "SAO 43899"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.14132788),
        dec: Angle.Degrees(+40.63729395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151353"},
        {"Hipparcos Number", "HIP 82002"},
        {"Smithsonian Astrophysical Observation", "SAO 46260"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.27414996),
        dec: Angle.Degrees(+40.63815652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105043"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.15765205),
        dec: Angle.Degrees(+40.63929339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110045"},
        {"Smithsonian Astrophysical Observation", "SAO 51839"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.33891101),
        dec: Angle.Degrees(+40.64261248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53251"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.36935352),
        dec: Angle.Degrees(+40.64454974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59212"},
        {"Geneva Identification System", "GEN# +0.04102274"},
        {"Smithsonian Astrophysical Observation", "SAO 44050"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.15609301),
        dec: Angle.Degrees(+40.64615598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103612"},
        {"Hipparcos Number", "HIP 58193"},
        {"Geneva Identification System", "GEN# +1.00103612"},
        {"Smithsonian Astrophysical Observation", "SAO 43949"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.01482739),
        dec: Angle.Degrees(+40.64768768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8212"},
        {"Smithsonian Astrophysical Observation", "SAO 37489"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.43817737),
        dec: Angle.Degrees(+40.64877742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31657"},
        {"Smithsonian Astrophysical Observation", "SAO 41216"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.38418492),
        dec: Angle.Degrees(+40.65005514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94170"},
        {"Smithsonian Astrophysical Observation", "SAO 48143"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.54380424),
        dec: Angle.Degrees(+40.65047278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11579"},
        {"Hipparcos Number", "HIP 8902"},
        {"Smithsonian Astrophysical Observation", "SAO 37604"},
        {"Wilson Evans Batten Catalogue", "WEB 1871"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.65788975),
        dec: Angle.Degrees(+40.65598516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190587"},
        {"Hipparcos Number", "HIP 98802"},
        {"Smithsonian Astrophysical Observation", "SAO 49141"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.99773466),
        dec: Angle.Degrees(+40.65654477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58595"},
        {"Hipparcos Number", "HIP 36285"},
        {"Geneva Identification System", "GEN# +1.00058595"},
        {"Smithsonian Astrophysical Observation", "SAO 41789"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.04384095),
        dec: Angle.Degrees(+40.65667157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59827",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8489 B"},
        {"Hipparcos Number", "HIP 59827"},
        {"Geneva Identification System", "GEN# +1.00106690B"},
        {"Wilson Evans Batten Catalogue", "WEB 10633"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.02723849),
        dec: Angle.Degrees(+40.65967452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159411"},
        {"Hipparcos Number", "HIP 85857"},
        {"Geneva Identification System", "GEN# +1.00159411"},
        {"Smithsonian Astrophysical Observation", "SAO 46787"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18040839),
        dec: Angle.Degrees(+40.65972538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8489 A"},
        {"Henry Draper", "HD 106690"},
        {"Hipparcos Number", "HIP 59831"},
        {"Fundamental Katalog 5th Edition", "FK5 458"},
        {"Geneva Identification System", "GEN# +1.00106690A"},
        {"Smithsonian Astrophysical Observation", "SAO 44097"},
        {"Wilson Evans Batten Catalogue", "WEB 10630"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.03140154),
        dec: Angle.Degrees(+40.66025851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88161"},
        {"Hipparcos Number", "HIP 49870"},
        {"Geneva Identification System", "GEN# +1.00088161"},
        {"Smithsonian Astrophysical Observation", "SAO 43220"},
        {"Wilson Evans Batten Catalogue", "WEB 9183"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.74573467),
        dec: Angle.Degrees(+40.66160239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109173"},
        {"Smithsonian Astrophysical Observation", "SAO 51659"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.73239637),
        dec: Angle.Degrees(+40.66434703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195529"},
        {"Hipparcos Number", "HIP 101170"},
        {"Geneva Identification System", "GEN# +1.00195529"},
        {"Smithsonian Astrophysical Observation", "SAO 49715"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.59690761),
        dec: Angle.Degrees(+40.66473469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87225"},
        {"Hipparcos Number", "HIP 49355"},
        {"Smithsonian Astrophysical Observation", "SAO 43170"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.13661025),
        dec: Angle.Degrees(+40.66526734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110412",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15874 A"},
        {"Henry Draper", "HD 212212"},
        {"Hipparcos Number", "HIP 110412"},
        {"Smithsonian Astrophysical Observation", "SAO 51919"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.47012425),
        dec: Angle.Degrees(+40.66642436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13507"},
        {"Hipparcos Number", "HIP 10321"},
        {"Geneva Identification System", "GEN# +1.00013507"},
        {"Smithsonian Astrophysical Observation", "SAO 37865"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.22900055),
        dec: Angle.Degrees(+40.66860420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214806"},
        {"Hipparcos Number", "HIP 111907"},
        {"Smithsonian Astrophysical Observation", "SAO 52247"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.02399183),
        dec: Angle.Degrees(+40.67020117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3077",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 542 AB"},
        {"Hipparcos Number", "HIP 3077"},
        {"Smithsonian Astrophysical Observation", "SAO 36548"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.75134395),
        dec: Angle.Degrees(+40.67114458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61107"},
        {"Hipparcos Number", "HIP 37292"},
        {"Geneva Identification System", "GEN# +1.00061107"},
        {"Smithsonian Astrophysical Observation", "SAO 41915"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.85757769),
        dec: Angle.Degrees(+40.67134454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23729"},
        {"Hipparcos Number", "HIP 17834"},
        {"Smithsonian Astrophysical Observation", "SAO 39126"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.23910312),
        dec: Angle.Degrees(+40.67151138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47090"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.95050829),
        dec: Angle.Degrees(+40.67197741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45553",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7273 AB"},
        {"Hipparcos Number", "HIP 45553"},
        {"Smithsonian Astrophysical Observation", "SAO 42787"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.26528118),
        dec: Angle.Degrees(+40.67229286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57669"},
        {"Hipparcos Number", "HIP 35907"},
        {"Fundamental Katalog 5th Edition", "FK5 1191"},
        {"Geneva Identification System", "GEN# +1.00057669"},
        {"Smithsonian Astrophysical Observation", "SAO 41738"},
        {"Wilson Evans Batten Catalogue", "WEB 7149"},
    },
    visualMagnitude: 5.23,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.03529509),
        dec: Angle.Degrees(+40.67244066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70432"},
        {"Hipparcos Number", "HIP 41141"},
        {"Geneva Identification System", "GEN# +1.00070432"},
        {"Smithsonian Astrophysical Observation", "SAO 42331"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.90972778),
        dec: Angle.Degrees(+40.67502638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102508"},
        {"Hipparcos Number", "HIP 57573"},
        {"Fundamental Katalog 5th Edition", "FK5 5041"},
        {"Geneva Identification System", "GEN# +1.00102508"},
        {"Smithsonian Astrophysical Observation", "SAO 43894"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.01000955),
        dec: Angle.Degrees(+40.67529978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277924"},
        {"Hipparcos Number", "HIP 24880"},
        {"Smithsonian Astrophysical Observation", "SAO 40245"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00490638),
        dec: Angle.Degrees(+40.67713508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208221"},
        {"Hipparcos Number", "HIP 108075"},
        {"Smithsonian Astrophysical Observation", "SAO 51409"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.45658304),
        dec: Angle.Degrees(+40.67734883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116358"},
        {"Smithsonian Astrophysical Observation", "SAO 53158"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.66586315),
        dec: Angle.Degrees(+40.67811350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93177",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11910 A"},
        {"Henry Draper", "HD 176502"},
        {"Hipparcos Number", "HIP 93177"},
        {"Celescope Catalog", "CEL 4679"},
        {"Geneva Identification System", "GEN# +1.00176502A"},
        {"Smithsonian Astrophysical Observation", "SAO 47965"},
        {"Wilson Evans Batten Catalogue", "WEB 16148"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.69411182),
        dec: Angle.Degrees(+40.67919507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4174"},
        {"Hipparcos Number", "HIP 3494"},
        {"Geneva Identification System", "GEN# +1.00004174"},
        {"Smithsonian Astrophysical Observation", "SAO 36618"},
        {"Wilson Evans Batten Catalogue", "WEB 616"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.15491629),
        dec: Angle.Degrees(+40.67939958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32282"},
        {"Hipparcos Number", "HIP 23556"},
        {"Celescope Catalog", "CEL 518"},
        {"Geneva Identification System", "GEN# +1.00032282"},
        {"Smithsonian Astrophysical Observation", "SAO 39986"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.97488653),
        dec: Angle.Degrees(+40.68332684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10155"},
        {"Hipparcos Number", "HIP 7775"},
        {"Geneva Identification System", "GEN# +1.00010155"},
        {"Smithsonian Astrophysical Observation", "SAO 37416"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.01823471),
        dec: Angle.Degrees(+40.68382175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176844"},
        {"Hipparcos Number", "HIP 93309"},
        {"Smithsonian Astrophysical Observation", "SAO 47993"},
        {"Wilson Evans Batten Catalogue", "WEB 16180"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.07941783),
        dec: Angle.Degrees(+40.68403680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4143"},
        {"Hipparcos Number", "HIP 3461"},
        {"Smithsonian Astrophysical Observation", "SAO 36615"},
        {"Wilson Evans Batten Catalogue", "WEB 613"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.06969294),
        dec: Angle.Degrees(+40.68521625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157616"},
        {"Hipparcos Number", "HIP 85001"},
        {"Smithsonian Astrophysical Observation", "SAO 46675"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.60532880),
        dec: Angle.Degrees(+40.68549261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3914"},
        {"Hipparcos Number", "HIP 3293"},
        {"Geneva Identification System", "GEN# +1.00003914"},
        {"Smithsonian Astrophysical Observation", "SAO 36585"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.50597309),
        dec: Angle.Degrees(+40.68841020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41258"},
        {"Hipparcos Number", "HIP 28885"},
        {"Geneva Identification System", "GEN# +1.00041258"},
        {"Smithsonian Astrophysical Observation", "SAO 40848"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.48120953),
        dec: Angle.Degrees(+40.68900555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155523"},
        {"Hipparcos Number", "HIP 84004"},
        {"Smithsonian Astrophysical Observation", "SAO 46531"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.57713891),
        dec: Angle.Degrees(+40.68987184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25857"},
        {"Smithsonian Astrophysical Observation", "SAO 40389"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.79750750),
        dec: Angle.Degrees(+40.69013213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75698"},
        {"Smithsonian Astrophysical Observation", "SAO 45553"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.96802351),
        dec: Angle.Degrees(+40.69257384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86040"},
        {"Smithsonian Astrophysical Observation", "SAO 46812"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.75813140),
        dec: Angle.Degrees(+40.69506664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92124"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.64687795),
        dec: Angle.Degrees(+40.69529347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47937"},
        {"Smithsonian Astrophysical Observation", "SAO 43024"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.52800510),
        dec: Angle.Degrees(+40.69613978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203731"},
        {"Hipparcos Number", "HIP 105565"},
        {"Geneva Identification System", "GEN# +1.00203731"},
        {"Smithsonian Astrophysical Observation", "SAO 50772"},
        {"Wilson Evans Batten Catalogue", "WEB 19168"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.71311809),
        dec: Angle.Degrees(+40.69725924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199872"},
        {"Hipparcos Number", "HIP 103535"},
        {"Geneva Identification System", "GEN# +1.00199872"},
        {"Smithsonian Astrophysical Observation", "SAO 50302"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.63085383),
        dec: Angle.Degrees(+40.69877925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72665"},
        {"Smithsonian Astrophysical Observation", "SAO 45240"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.86233913),
        dec: Angle.Degrees(+40.69940088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57448"},
        {"Hipparcos Number", "HIP 35811"},
        {"Smithsonian Astrophysical Observation", "SAO 41731"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.78549056),
        dec: Angle.Degrees(+40.69987109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15489"},
        {"Hipparcos Number", "HIP 11685"},
        {"Smithsonian Astrophysical Observation", "SAO 38080"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.67675134),
        dec: Angle.Degrees(+40.70170035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11613"},
        {"Hipparcos Number", "HIP 8922"},
        {"Geneva Identification System", "GEN# +1.00011613"},
        {"Smithsonian Astrophysical Observation", "SAO 37607"},
        {"Wilson Evans Batten Catalogue", "WEB 1875"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.72395703),
        dec: Angle.Degrees(+40.70220085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53832"},
        {"Geneva Identification System", "GEN# +0.04102150"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20234328),
        dec: Angle.Degrees(+40.70294109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14413 A"},
        {"Henry Draper", "HD 199218"},
        {"Hipparcos Number", "HIP 103189"},
        {"Celescope Catalog", "CEL 5200"},
        {"Geneva Identification System", "GEN# +1.00199218J"},
        {"Smithsonian Astrophysical Observation", "SAO 50209"},
        {"Wilson Evans Batten Catalogue", "WEB 18742"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.59270054),
        dec: Angle.Degrees(+40.70295651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9696"},
        {"Smithsonian Astrophysical Observation", "SAO 37744"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.17950442),
        dec: Angle.Degrees(+40.70535499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37481"},
        {"Smithsonian Astrophysical Observation", "SAO 41941"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.41374829),
        dec: Angle.Degrees(+40.70629127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152952"},
        {"Hipparcos Number", "HIP 82741"},
        {"Smithsonian Astrophysical Observation", "SAO 46363"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.67766972),
        dec: Angle.Degrees(+40.70881199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107597"},
        {"Hipparcos Number", "HIP 60295"},
        {"Geneva Identification System", "GEN# +1.00107597"},
        {"Smithsonian Astrophysical Observation", "SAO 44140"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.45802958),
        dec: Angle.Degrees(+40.70933765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118144"},
        {"Hipparcos Number", "HIP 66213"},
        {"Geneva Identification System", "GEN# +1.00118144"},
        {"Smithsonian Astrophysical Observation", "SAO 44666"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.56883068),
        dec: Angle.Degrees(+40.71147568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90415"},
        {"Geneva Identification System", "GEN# +0.04003374"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73056964),
        dec: Angle.Degrees(+40.71326601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 318.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41964"},
        {"Smithsonian Astrophysical Observation", "SAO 42424"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.30439336),
        dec: Angle.Degrees(+40.71419358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194194"},
        {"Hipparcos Number", "HIP 100497"},
        {"Celescope Catalog", "CEL 5042"},
        {"Geneva Identification System", "GEN# +2.69100001"},
        {"Smithsonian Astrophysical Observation", "SAO 49545"},
        {"Wilson Evans Batten Catalogue", "WEB 18149"},
        {"New General Catalogue", "NGC 6910 1"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68650400),
        dec: Angle.Degrees(+40.71464094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121211"},
        {"Hipparcos Number", "HIP 67790"},
        {"Geneva Identification System", "GEN# +1.00121211"},
        {"Smithsonian Astrophysical Observation", "SAO 44786"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30984898),
        dec: Angle.Degrees(+40.71554153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186776"},
        {"Hipparcos Number", "HIP 97151"},
        {"Geneva Identification System", "GEN# +1.00186776"},
        {"Smithsonian Astrophysical Observation", "SAO 48789"},
        {"Wilson Evans Batten Catalogue", "WEB 17055"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.20455325),
        dec: Angle.Degrees(+40.71686361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70109"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.18936959),
        dec: Angle.Degrees(+40.71741709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35527"},
        {"Smithsonian Astrophysical Observation", "SAO 41697"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98375932),
        dec: Angle.Degrees(+40.71779926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173086"},
        {"Hipparcos Number", "HIP 91674"},
        {"Geneva Identification System", "GEN# +1.00173086"},
        {"Smithsonian Astrophysical Observation", "SAO 47708"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.42045791),
        dec: Angle.Degrees(+40.71792798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107905"},
        {"Hipparcos Number", "HIP 60477"},
        {"Geneva Identification System", "GEN# +1.00107905"},
        {"Smithsonian Astrophysical Observation", "SAO 44156"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.97473845),
        dec: Angle.Degrees(+40.71949624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192381"},
        {"Hipparcos Number", "HIP 99614"},
        {"Celescope Catalog", "CEL 4976"},
        {"Geneva Identification System", "GEN# +1.00192381"},
        {"Smithsonian Astrophysical Observation", "SAO 49325"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.23707304),
        dec: Angle.Degrees(+40.72118900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12831 AB"},
        {"Henry Draper", "HD 186465"},
        {"Hipparcos Number", "HIP 97001"},
        {"Celescope Catalog", "CEL 4826"},
        {"Geneva Identification System", "GEN# +1.00186465"},
        {"Smithsonian Astrophysical Observation", "SAO 48756"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.73440148),
        dec: Angle.Degrees(+40.72175702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213472"},
        {"Hipparcos Number", "HIP 111136"},
        {"Geneva Identification System", "GEN# +1.00213472"},
        {"Smithsonian Astrophysical Observation", "SAO 52090"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.70891653),
        dec: Angle.Degrees(+40.72195942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69765"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.16859556),
        dec: Angle.Degrees(+40.72737534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109304"},
        {"Hipparcos Number", "HIP 61277"},
        {"Geneva Identification System", "GEN# +1.00109304"},
        {"Smithsonian Astrophysical Observation", "SAO 44227"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.36201268),
        dec: Angle.Degrees(+40.72760086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1527"},
        {"Hipparcos Number", "HIP 1575"},
        {"Geneva Identification System", "GEN# +1.00001527"},
        {"Smithsonian Astrophysical Observation", "SAO 36269"},
        {"Wilson Evans Batten Catalogue", "WEB 285"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.92324681),
        dec: Angle.Degrees(+40.72950687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117261"},
        {"Hipparcos Number", "HIP 65723"},
        {"Geneva Identification System", "GEN# +1.00117261"},
        {"Smithsonian Astrophysical Observation", "SAO 44621"},
        {"Wilson Evans Batten Catalogue", "WEB 11633"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.10930095),
        dec: Angle.Degrees(+40.72978568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11428"},
        {"Hipparcos Number", "HIP 8814"},
        {"Fundamental Katalog 5th Edition", "FK5 2124"},
        {"Geneva Identification System", "GEN# +1.00011428"},
        {"Smithsonian Astrophysical Observation", "SAO 37587"},
        {"Wilson Evans Batten Catalogue", "WEB 1856"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.32229965),
        dec: Angle.Degrees(+40.72979974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80439"},
    },
    visualMagnitude: 11.31,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.29523288),
        dec: Angle.Degrees(+40.73175370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100069",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13672 AB"},
        {"Henry Draper", "HD 193322"},
        {"Hipparcos Number", "HIP 100069"},
        {"Celescope Catalog", "CEL 5019"},
        {"Geneva Identification System", "GEN# +1.00193322J"},
        {"Smithsonian Astrophysical Observation", "SAO 49438"},
        {"Wilson Evans Batten Catalogue", "WEB 18020"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.52912505),
        dec: Angle.Degrees(+40.73209817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51735"},
        {"Smithsonian Astrophysical Observation", "SAO 43388"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.56384051),
        dec: Angle.Degrees(+40.73218783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214022"},
        {"Hipparcos Number", "HIP 111458"},
        {"Geneva Identification System", "GEN# +1.00214022"},
        {"Smithsonian Astrophysical Observation", "SAO 52159"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.71027689),
        dec: Angle.Degrees(+40.73254687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226195"},
        {"Hipparcos Number", "HIP 97706"},
        {"Smithsonian Astrophysical Observation", "SAO 48906"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.85316998),
        dec: Angle.Degrees(+40.73530562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174677"},
        {"Hipparcos Number", "HIP 92404"},
        {"Smithsonian Astrophysical Observation", "SAO 47834"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.45808737),
        dec: Angle.Degrees(+40.73603376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149025"},
        {"Hipparcos Number", "HIP 80827"},
        {"Geneva Identification System", "GEN# +1.00149025"},
        {"Smithsonian Astrophysical Observation", "SAO 46127"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.59421627),
        dec: Angle.Degrees(+40.73656849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93350"},
        {"Hipparcos Number", "HIP 52760"},
        {"Smithsonian Astrophysical Observation", "SAO 43472"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.82747583),
        dec: Angle.Degrees(+40.73837135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86275"},
        {"Hipparcos Number", "HIP 48894"},
        {"Smithsonian Astrophysical Observation", "SAO 43123"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.60649623),
        dec: Angle.Degrees(+40.74299349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86616"},
    },
    visualMagnitude: 12.18,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48933330),
        dec: Angle.Degrees(+40.74425462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 200.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223717"},
        {"Hipparcos Number", "HIP 117679"},
        {"Smithsonian Astrophysical Observation", "SAO 53431"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.98283989),
        dec: Angle.Degrees(+40.74509775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135047"},
        {"Hipparcos Number", "HIP 74351"},
        {"Smithsonian Astrophysical Observation", "SAO 45425"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.92265326),
        dec: Angle.Degrees(+40.74635737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1361"},
        {"Hipparcos Number", "HIP 1445"},
        {"Smithsonian Astrophysical Observation", "SAO 36246"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.49781357),
        dec: Angle.Degrees(+40.74679871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31136"},
        {"Hipparcos Number", "HIP 22863"},
        {"Geneva Identification System", "GEN# +1.00031136"},
        {"Smithsonian Astrophysical Observation", "SAO 39856"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.77984182),
        dec: Angle.Degrees(+40.74778101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144543"},
        {"Hipparcos Number", "HIP 78768"},
        {"Smithsonian Astrophysical Observation", "SAO 45881"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.21559402),
        dec: Angle.Degrees(+40.75069511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54699"},
        {"Smithsonian Astrophysical Observation", "SAO 43642"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.97548096),
        dec: Angle.Degrees(+40.75242780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74231"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.54613703),
        dec: Angle.Degrees(+40.75589759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194279"},
        {"Hipparcos Number", "HIP 100548"},
        {"Geneva Identification System", "GEN# +2.69100002"},
        {"Smithsonian Astrophysical Observation", "SAO 49563"},
        {"Wilson Evans Batten Catalogue", "WEB 18165"},
        {"New General Catalogue", "NGC 6910 2"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.82569740),
        dec: Angle.Degrees(+40.75906868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21684"},
        {"Hipparcos Number", "HIP 16425"},
        {"Geneva Identification System", "GEN# +1.00021684"},
        {"Smithsonian Astrophysical Observation", "SAO 38910"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.87615022),
        dec: Angle.Degrees(+40.76003616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10032"},
        {"Hipparcos Number", "HIP 7672"},
        {"Geneva Identification System", "GEN# +1.00010032"},
        {"Smithsonian Astrophysical Observation", "SAO 37400"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.70028436),
        dec: Angle.Degrees(+40.76078942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11907"},
        {"Hipparcos Number", "HIP 9151"},
        {"Geneva Identification System", "GEN# +1.00011907"},
        {"Smithsonian Astrophysical Observation", "SAO 37652"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48075757),
        dec: Angle.Degrees(+40.76081521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2513 AB"},
        {"Henry Draper", "HD 20987"},
        {"Hipparcos Number", "HIP 15895"},
        {"Smithsonian Astrophysical Observation", "SAO 38798"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.18709156),
        dec: Angle.Degrees(+40.76087662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115208"},
        {"Smithsonian Astrophysical Observation", "SAO 52919"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.02389755),
        dec: Angle.Degrees(+40.76165111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140252"},
        {"Hipparcos Number", "HIP 76819"},
        {"Geneva Identification System", "GEN# +1.00140252"},
        {"Smithsonian Astrophysical Observation", "SAO 45680"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.26748986),
        dec: Angle.Degrees(+40.76220864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31689"},
        {"Smithsonian Astrophysical Observation", "SAO 41221"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.45055450),
        dec: Angle.Degrees(+40.76227505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275604"},
        {"Hipparcos Number", "HIP 16920"},
        {"Renson", "Renson 5685"},
        {"Wilson Evans Batten Catalogue", "WEB 3222"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.43834069),
        dec: Angle.Degrees(+40.76370200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41082"},
        {"Smithsonian Astrophysical Observation", "SAO 42323"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.73071594),
        dec: Angle.Degrees(+40.76718481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123508"},
        {"Hipparcos Number", "HIP 68963"},
        {"Smithsonian Astrophysical Observation", "SAO 44893"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.77089083),
        dec: Angle.Degrees(+40.76815061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171944"},
        {"Hipparcos Number", "HIP 91145"},
        {"Geneva Identification System", "GEN# +1.00171944"},
        {"Smithsonian Astrophysical Observation", "SAO 47626"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.90460475),
        dec: Angle.Degrees(+40.76965357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95465"},
        {"Hipparcos Number", "HIP 53895"},
        {"Smithsonian Astrophysical Observation", "SAO 43580"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.41486242),
        dec: Angle.Degrees(+40.77109902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112273"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12083405),
        dec: Angle.Degrees(+40.77196172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201977"},
        {"Hipparcos Number", "HIP 104647"},
        {"Celescope Catalog", "CEL 5265"},
        {"Geneva Identification System", "GEN# +1.00201977"},
        {"Smithsonian Astrophysical Observation", "SAO 50556"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.97813804),
        dec: Angle.Degrees(+40.77428894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213976"},
        {"Hipparcos Number", "HIP 111429"},
        {"Celescope Catalog", "CEL 5487"},
        {"Geneva Identification System", "GEN# +1.00213976"},
        {"Smithsonian Astrophysical Observation", "SAO 52155"},
        {"Wilson Evans Batten Catalogue", "WEB 19924"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.62578279),
        dec: Angle.Degrees(+40.77490688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56751"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52480655),
        dec: Angle.Degrees(+40.77620391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34743"},
        {"Wilson Evans Batten Catalogue", "WEB 6945"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.89594721),
        dec: Angle.Degrees(+40.77700288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155410"},
        {"Hipparcos Number", "HIP 83947"},
        {"Fundamental Katalog 5th Edition", "FK5 3365"},
        {"Geneva Identification System", "GEN# +1.00155410"},
        {"Smithsonian Astrophysical Observation", "SAO 46524"},
        {"Wilson Evans Batten Catalogue", "WEB 14183"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.38867303),
        dec: Angle.Degrees(+40.77701519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124018"},
        {"Hipparcos Number", "HIP 69198"},
        {"Geneva Identification System", "GEN# +1.00124018"},
        {"Smithsonian Astrophysical Observation", "SAO 44919"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.49884932),
        dec: Angle.Degrees(+40.77821552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34787"},
        {"Geneva Identification System", "GEN# +0.04101609"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.02302334),
        dec: Angle.Degrees(+40.77901345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146080"},
        {"Hipparcos Number", "HIP 79436"},
        {"Smithsonian Astrophysical Observation", "SAO 45965"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.18005571),
        dec: Angle.Degrees(+40.78170241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53714"},
        {"Hipparcos Number", "HIP 34402"},
        {"Smithsonian Astrophysical Observation", "SAO 41578"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.98833914),
        dec: Angle.Degrees(+40.78263747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7502 AB"},
        {"Hipparcos Number", "HIP 47776"},
        {"Smithsonian Astrophysical Observation", "SAO 43005"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.10492463),
        dec: Angle.Degrees(+40.78457470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29866"},
        {"Hipparcos Number", "HIP 22034"},
        {"Celescope Catalog", "CEL 459"},
        {"Geneva Identification System", "GEN# +1.00029866"},
        {"Smithsonian Astrophysical Observation", "SAO 39715"},
        {"Wilson Evans Batten Catalogue", "WEB 4234"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.05421366),
        dec: Angle.Degrees(+40.78651068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40037"},
        {"Hipparcos Number", "HIP 28263"},
        {"Celescope Catalog", "CEL 1045"},
        {"Geneva Identification System", "GEN# +1.00040037"},
        {"Smithsonian Astrophysical Observation", "SAO 40735"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.57860426),
        dec: Angle.Degrees(+40.78682820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182615"},
        {"Hipparcos Number", "HIP 95336"},
        {"Geneva Identification System", "GEN# +1.00182615"},
        {"Smithsonian Astrophysical Observation", "SAO 48396"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.93594408),
        dec: Angle.Degrees(+40.78721759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81257"},
        {"Smithsonian Astrophysical Observation", "SAO 46179"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95415836),
        dec: Angle.Degrees(+40.78892845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29457"},
        {"Hipparcos Number", "HIP 21749"},
        {"Geneva Identification System", "GEN# +1.00029457"},
        {"Smithsonian Astrophysical Observation", "SAO 39679"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.04609538),
        dec: Angle.Degrees(+40.78906385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13564"},
        {"Hipparcos Number", "HIP 10355"},
        {"Fundamental Katalog 5th Edition", "FK5 4204"},
        {"Geneva Identification System", "GEN# +1.00013564"},
        {"Smithsonian Astrophysical Observation", "SAO 37871"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.37210780),
        dec: Angle.Degrees(+40.79024279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47243"},
        {"Fundamental Katalog 5th Edition", "FK5 4852"},
        {"Smithsonian Astrophysical Observation", "SAO 42951"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.44915584),
        dec: Angle.Degrees(+40.79199106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78340"},
        {"Smithsonian Astrophysical Observation", "SAO 45825"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.93853513),
        dec: Angle.Degrees(+40.79212486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224575"},
        {"Hipparcos Number", "HIP 118238"},
        {"Geneva Identification System", "GEN# +1.00224575"},
        {"Smithsonian Astrophysical Observation", "SAO 53544"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.74082536),
        dec: Angle.Degrees(+40.79219777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114674"},
        {"Hipparcos Number", "HIP 64355"},
        {"Geneva Identification System", "GEN# +1.00114674"},
        {"Smithsonian Astrophysical Observation", "SAO 44499"},
        {"Wilson Evans Batten Catalogue", "WEB 11377"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.86965413),
        dec: Angle.Degrees(+40.79251077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65407"},
        {"Hipparcos Number", "HIP 39129"},
        {"Geneva Identification System", "GEN# +1.00065407"},
        {"Smithsonian Astrophysical Observation", "SAO 42118"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06905510),
        dec: Angle.Degrees(+40.79314804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109651",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15741 AB"},
        {"Henry Draper", "HD 210906"},
        {"Hipparcos Number", "HIP 109651"},
        {"Smithsonian Astrophysical Observation", "SAO 51765"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.19270936),
        dec: Angle.Degrees(+40.79387971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1671 A"},
        {"Henry Draper", "HD 13078"},
        {"Hipparcos Number", "HIP 10027"},
        {"Geneva Identification System", "GEN# +1.00013078"},
        {"Smithsonian Astrophysical Observation", "SAO 37805"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.26423209),
        dec: Angle.Degrees(+40.79423340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219346"},
        {"Hipparcos Number", "HIP 114757"},
        {"Smithsonian Astrophysical Observation", "SAO 52832"},
        {"Wilson Evans Batten Catalogue", "WEB 20346"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.68416716),
        dec: Angle.Degrees(+40.79427275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18641"},
        {"Hipparcos Number", "HIP 14063"},
        {"Smithsonian Astrophysical Observation", "SAO 38512"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.29759503),
        dec: Angle.Degrees(+40.79664472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1671 B"},
        {"Henry Draper", "HD 13078B"},
        {"Hipparcos Number", "HIP 10030"},
        {"Geneva Identification System", "GEN# +1.00013078B"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.27045455),
        dec: Angle.Degrees(+40.79701022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18095",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2815 AB"},
        {"Henry Draper", "HD 24117"},
        {"Hipparcos Number", "HIP 18095"},
        {"Smithsonian Astrophysical Observation", "SAO 39161"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.01949747),
        dec: Angle.Degrees(+40.79752037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39968"},
        {"Hipparcos Number", "HIP 28231"},
        {"Geneva Identification System", "GEN# +1.00039968"},
        {"Smithsonian Astrophysical Observation", "SAO 40731"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.47068474),
        dec: Angle.Degrees(+40.79785170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219225"},
        {"Hipparcos Number", "HIP 114681"},
        {"Smithsonian Astrophysical Observation", "SAO 52814"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.47939755),
        dec: Angle.Degrees(+40.79882429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71597"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.64335893),
        dec: Angle.Degrees(+40.80033856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206538"},
        {"Hipparcos Number", "HIP 107097"},
        {"Celescope Catalog", "CEL 5367"},
        {"Geneva Identification System", "GEN# +1.00206538"},
        {"Smithsonian Astrophysical Observation", "SAO 51189"},
        {"Wilson Evans Batten Catalogue", "WEB 19346"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.39278610),
        dec: Angle.Degrees(+40.80533757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4806"},
        {"Hipparcos Number", "HIP 3928"},
        {"Smithsonian Astrophysical Observation", "SAO 36704"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.61079947),
        dec: Angle.Degrees(+40.80827293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44474"},
        {"Hipparcos Number", "HIP 30432"},
        {"Smithsonian Astrophysical Observation", "SAO 41066"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.97470465),
        dec: Angle.Degrees(+40.80869188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79564"},
        {"Hipparcos Number", "HIP 45492"},
        {"Geneva Identification System", "GEN# +1.00079564"},
        {"Smithsonian Astrophysical Observation", "SAO 42780"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.04397733),
        dec: Angle.Degrees(+40.80900469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4322"},
        {"Hipparcos Number", "HIP 3597"},
        {"Fundamental Katalog 5th Edition", "FK5 4067"},
        {"Geneva Identification System", "GEN# +1.00004322"},
        {"Smithsonian Astrophysical Observation", "SAO 36638"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.51320210),
        dec: Angle.Degrees(+40.80905639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148434"},
        {"Hipparcos Number", "HIP 80528"},
        {"Geneva Identification System", "GEN# +1.00148434"},
        {"Smithsonian Astrophysical Observation", "SAO 46085"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.58944804),
        dec: Angle.Degrees(+40.80961760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122345"},
        {"Hipparcos Number", "HIP 68420"},
        {"Geneva Identification System", "GEN# +1.00122345"},
        {"Smithsonian Astrophysical Observation", "SAO 44838"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.09994562),
        dec: Angle.Degrees(+40.81018496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190812"},
        {"Hipparcos Number", "HIP 98923"},
        {"Geneva Identification System", "GEN# +1.00190812"},
        {"Smithsonian Astrophysical Observation", "SAO 49159"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.29306287),
        dec: Angle.Degrees(+40.81391206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113212"},
        {"Hipparcos Number", "HIP 63574"},
        {"Smithsonian Astrophysical Observation", "SAO 44431"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42055968),
        dec: Angle.Degrees(+40.81519820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134281"},
        {"Hipparcos Number", "HIP 74015"},
        {"Smithsonian Astrophysical Observation", "SAO 45386"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.88618183),
        dec: Angle.Degrees(+40.81589568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131599"},
        {"Hipparcos Number", "HIP 72835"},
        {"Geneva Identification System", "GEN# +1.00131599"},
        {"Smithsonian Astrophysical Observation", "SAO 45260"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.31572389),
        dec: Angle.Degrees(+40.81666070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38073"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.03277321),
        dec: Angle.Degrees(+40.81780154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213835"},
        {"Hipparcos Number", "HIP 111355"},
        {"Smithsonian Astrophysical Observation", "SAO 52140"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.39420102),
        dec: Angle.Degrees(+40.81901488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17554"},
        {"Hipparcos Number", "HIP 13226"},
        {"Smithsonian Astrophysical Observation", "SAO 38381"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.56304595),
        dec: Angle.Degrees(+40.81974753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82541"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.07775151),
        dec: Angle.Degrees(+40.82008514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66462"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.38543161),
        dec: Angle.Degrees(+40.82017018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208514"},
        {"Hipparcos Number", "HIP 108238"},
        {"Smithsonian Astrophysical Observation", "SAO 51449"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.91417423),
        dec: Angle.Degrees(+40.82345365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205286"},
        {"Hipparcos Number", "HIP 106407"},
        {"Smithsonian Astrophysical Observation", "SAO 51015"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.28639768),
        dec: Angle.Degrees(+40.82464524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59462"},
        {"Geneva Identification System", "GEN# +0.04102277"},
        {"Smithsonian Astrophysical Observation", "SAO 44072"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.94968770),
        dec: Angle.Degrees(+40.82553520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60350"},
        {"Renson", "Renson 31250"},
    },
    visualMagnitude: 11.60,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.62340589),
        dec: Angle.Degrees(+40.82650746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132503"},
        {"Hipparcos Number", "HIP 73240"},
        {"Smithsonian Astrophysical Observation", "SAO 45307"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.53149496),
        dec: Angle.Degrees(+40.82903754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51047"},
        {"Hipparcos Number", "HIP 33494"},
        {"Smithsonian Astrophysical Observation", "SAO 41464"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.42996033),
        dec: Angle.Degrees(+40.82909129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111294"},
        {"Smithsonian Astrophysical Observation", "SAO 52124"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.19188741),
        dec: Angle.Degrees(+40.83023750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108872"},
        {"Hipparcos Number", "HIP 61021"},
        {"Geneva Identification System", "GEN# +1.00108872"},
        {"Smithsonian Astrophysical Observation", "SAO 44205"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.58654464),
        dec: Angle.Degrees(+40.83041320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165372"},
        {"Hipparcos Number", "HIP 88466"},
        {"Smithsonian Astrophysical Observation", "SAO 47180"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.96416147),
        dec: Angle.Degrees(+40.83083795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138481"},
        {"Hipparcos Number", "HIP 75973"},
        {"Fundamental Katalog 5th Edition", "FK5 573"},
        {"Geneva Identification System", "GEN# +1.00138481"},
        {"Smithsonian Astrophysical Observation", "SAO 45580"},
        {"Wilson Evans Batten Catalogue", "WEB 12917"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.73229511),
        dec: Angle.Degrees(+40.83306815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23210"},
        {"Geneva Identification System", "GEN# +0.04001122"},
        {"Wilson Evans Batten Catalogue", "WEB 4510"},
    },
    visualMagnitude: 10.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.92307510),
        dec: Angle.Degrees(+40.83603871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98152"},
        {"Hipparcos Number", "HIP 55182"},
        {"Geneva Identification System", "GEN# +1.00098152"},
        {"Smithsonian Astrophysical Observation", "SAO 43686"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.47978986),
        dec: Angle.Degrees(+40.83733670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99688",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13556 AB"},
        {"Henry Draper", "HD 228446"},
        {"Hipparcos Number", "HIP 99688"},
        {"Wilson Evans Batten Catalogue", "WEB 17883"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.43620967),
        dec: Angle.Degrees(+40.83875355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127932"},
        {"Hipparcos Number", "HIP 71138"},
        {"Smithsonian Astrophysical Observation", "SAO 45104"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.23340364),
        dec: Angle.Degrees(+40.83984395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 105 C"},
        {"Henry Draper", "HD 413"},
        {"Hipparcos Number", "HIP 712"},
        {"Geneva Identification System", "GEN# +1.00000413"},
        {"Smithsonian Astrophysical Observation", "SAO 36098"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.20791519),
        dec: Angle.Degrees(+40.84104758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2550"},
        {"Hipparcos Number", "HIP 2305"},
        {"Geneva Identification System", "GEN# +1.00002550"},
        {"Smithsonian Astrophysical Observation", "SAO 36412"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.34814782),
        dec: Angle.Degrees(+40.84182236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 737",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 105 A"},
        {"Henry Draper", "HD 445"},
        {"Hipparcos Number", "HIP 737"},
        {"Smithsonian Astrophysical Observation", "SAO 36104"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26490408),
        dec: Angle.Degrees(+40.84327725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33202"},
        {"Hipparcos Number", "HIP 24096"},
        {"Geneva Identification System", "GEN# +1.00033202"},
        {"Smithsonian Astrophysical Observation", "SAO 40078"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.64193450),
        dec: Angle.Degrees(+40.84413551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126326"},
        {"Hipparcos Number", "HIP 70356"},
        {"Geneva Identification System", "GEN# +1.00126326"},
        {"Smithsonian Astrophysical Observation", "SAO 45028"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.92480204),
        dec: Angle.Degrees(+40.84438531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104709"},
        {"Hipparcos Number", "HIP 58792"},
        {"Smithsonian Astrophysical Observation", "SAO 44015"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.88529199),
        dec: Angle.Degrees(+40.84511249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122037"},
        {"Hipparcos Number", "HIP 68252"},
        {"Geneva Identification System", "GEN# +1.00122037"},
        {"Smithsonian Astrophysical Observation", "SAO 44820"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.59360499),
        dec: Angle.Degrees(+40.84562307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115271"},
        {"Hipparcos Number", "HIP 64692"},
        {"Geneva Identification System", "GEN# +1.00115271"},
        {"Renson", "Renson 33307"},
        {"Smithsonian Astrophysical Observation", "SAO 44531"},
        {"Wilson Evans Batten Catalogue", "WEB 11438"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.88352117),
        dec: Angle.Degrees(+40.85517240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65641"},
        {"Hipparcos Number", "HIP 39224"},
        {"Geneva Identification System", "GEN# +1.00065641"},
        {"Smithsonian Astrophysical Observation", "SAO 42128"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.34422445),
        dec: Angle.Degrees(+40.85687145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195647"},
        {"Hipparcos Number", "HIP 101226"},
        {"Smithsonian Astrophysical Observation", "SAO 49730"},
        {"Wilson Evans Batten Catalogue", "WEB 18286"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.77872273),
        dec: Angle.Degrees(+40.85792229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4967"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.91679114),
        dec: Angle.Degrees(+40.85852326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190130"},
        {"Hipparcos Number", "HIP 98620"},
        {"Smithsonian Astrophysical Observation", "SAO 49106"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46434956),
        dec: Angle.Degrees(+40.85880769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68912"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62305832),
        dec: Angle.Degrees(+40.86224882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275921"},
        {"Hipparcos Number", "HIP 18421"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.07725649),
        dec: Angle.Degrees(+40.86225934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75675"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.91293653),
        dec: Angle.Degrees(+40.86535444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 278.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6733 AB"},
        {"Henry Draper", "HD 69580"},
        {"Hipparcos Number", "HIP 40770"},
        {"Smithsonian Astrophysical Observation", "SAO 42287"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81835329),
        dec: Angle.Degrees(+40.86553428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276542"},
        {"Hipparcos Number", "HIP 21217"},
        {"Smithsonian Astrophysical Observation", "SAO 39598"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.26805249),
        dec: Angle.Degrees(+40.86641815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225327"},
        {"Hipparcos Number", "HIP 96751"},
        {"Smithsonian Astrophysical Observation", "SAO 48703"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.01633871),
        dec: Angle.Degrees(+40.86729220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32916",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nervia"},
        {"Henry Draper", "HD 49674"},
        {"Hipparcos Number", "HIP 32916"},
        {"Geneva Identification System", "GEN# +1.00049674"},
        {"Smithsonian Astrophysical Observation", "SAO 41390"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.87703924),
        dec: Angle.Degrees(+40.86805498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2972"},
        {"Smithsonian Astrophysical Observation", "SAO 36526"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46136932),
        dec: Angle.Degrees(+40.87162795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109980"},
        {"Hipparcos Number", "HIP 61692"},
        {"Geneva Identification System", "GEN# +1.00109980"},
        {"Smithsonian Astrophysical Observation", "SAO 44265"},
        {"Wilson Evans Batten Catalogue", "WEB 10974"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.69290042),
        dec: Angle.Degrees(+40.87469516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217967"},
        {"Hipparcos Number", "HIP 113892"},
        {"Smithsonian Astrophysical Observation", "SAO 52644"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.97996165),
        dec: Angle.Degrees(+40.87492163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229196"},
        {"Hipparcos Number", "HIP 100542"},
        {"Geneva Identification System", "GEN# +2.69100004"},
        {"Smithsonian Astrophysical Observation", "SAO 49559"},
        {"Wilson Evans Batten Catalogue", "WEB 18162"},
        {"New General Catalogue", "NGC 6910 4"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.79494773),
        dec: Angle.Degrees(+40.87496920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91576"},
        {"Hipparcos Number", "HIP 51820"},
        {"Smithsonian Astrophysical Observation", "SAO 43392"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.80127496),
        dec: Angle.Degrees(+40.87640556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60105"},
        {"Hipparcos Number", "HIP 36873"},
        {"Smithsonian Astrophysical Observation", "SAO 41863"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.70663902),
        dec: Angle.Degrees(+40.87677774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16656"},
        {"Hipparcos Number", "HIP 12552"},
        {"Smithsonian Astrophysical Observation", "SAO 38228"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37024152),
        dec: Angle.Degrees(+40.88088417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37515"},
        {"Hipparcos Number", "HIP 26764"},
        {"Geneva Identification System", "GEN# +1.00037515"},
        {"Smithsonian Astrophysical Observation", "SAO 40534"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.27557910),
        dec: Angle.Degrees(+40.88259841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217316"},
        {"Hipparcos Number", "HIP 113516"},
        {"Smithsonian Astrophysical Observation", "SAO 52563"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.84155083),
        dec: Angle.Degrees(+40.88317293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56221"},
        {"Hipparcos Number", "HIP 35341"},
        {"Fundamental Katalog 5th Edition", "FK5 276"},
        {"Geneva Identification System", "GEN# +1.00056221"},
        {"Smithsonian Astrophysical Observation", "SAO 41679"},
        {"Wilson Evans Batten Catalogue", "WEB 7052"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.50927066),
        dec: Angle.Degrees(+40.88336298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34625"},
        {"Hipparcos Number", "HIP 24973"},
        {"Celescope Catalog", "CEL 622"},
        {"Fundamental Katalog 5th Edition", "FK5 4486"},
        {"Geneva Identification System", "GEN# +1.00034625"},
        {"Smithsonian Astrophysical Observation", "SAO 40261"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.22809480),
        dec: Angle.Degrees(+40.88486462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7591"},
        {"Hipparcos Number", "HIP 5941"},
        {"Smithsonian Astrophysical Observation", "SAO 37068"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.11425351),
        dec: Angle.Degrees(+40.88525262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79065"},
        {"Hipparcos Number", "HIP 45233"},
        {"Smithsonian Astrophysical Observation", "SAO 42749"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.27646239),
        dec: Angle.Degrees(+40.88662986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43281"},
        {"Hipparcos Number", "HIP 29865"},
        {"Smithsonian Astrophysical Observation", "SAO 40998"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.32941639),
        dec: Angle.Degrees(+40.88772339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228911"},
        {"Hipparcos Number", "HIP 100193"},
        {"Smithsonian Astrophysical Observation", "SAO 49467"},
        {"Wilson Evans Batten Catalogue", "WEB 18053"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.84047662),
        dec: Angle.Degrees(+40.88792042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149889"},
        {"Hipparcos Number", "HIP 81261"},
        {"Cincinnati Publication", "Ci 18 2213"},
        {"Smithsonian Astrophysical Observation", "SAO 46180"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95815109),
        dec: Angle.Degrees(+40.88864559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11572"},
        {"Hipparcos Number", "HIP 8893"},
        {"Smithsonian Astrophysical Observation", "SAO 37602"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.61772083),
        dec: Angle.Degrees(+40.88974425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50226"},
        {"Hipparcos Number", "HIP 33159"},
        {"Geneva Identification System", "GEN# +1.00050226"},
        {"Smithsonian Astrophysical Observation", "SAO 41417"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54696803),
        dec: Angle.Degrees(+40.89025670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62911"},
        {"Geneva Identification System", "GEN# +0.04102339"},
        {"Smithsonian Astrophysical Observation", "SAO 44377"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.40265771),
        dec: Angle.Degrees(+40.89041789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14983"},
        {"Hipparcos Number", "HIP 11344"},
        {"Geneva Identification System", "GEN# +1.00014983"},
        {"Smithsonian Astrophysical Observation", "SAO 38021"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.48716589),
        dec: Angle.Degrees(+40.89240257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143643"},
        {"Hipparcos Number", "HIP 78363"},
        {"Smithsonian Astrophysical Observation", "SAO 45828"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.98572052),
        dec: Angle.Degrees(+40.89308261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145"},
        {"Hipparcos Number", "HIP 525"},
        {"Smithsonian Astrophysical Observation", "SAO 36061"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.58393383),
        dec: Angle.Degrees(+40.89871965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76041",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9688 AB"},
        {"Henry Draper", "HD 138629"},
        {"Hipparcos Number", "HIP 76041"},
        {"Geneva Identification System", "GEN# +1.00138629J"},
        {"Smithsonian Astrophysical Observation", "SAO 45590"},
        {"Wilson Evans Batten Catalogue", "WEB 12926"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.94580142),
        dec: Angle.Degrees(+40.89936876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101741"},
        {"Hipparcos Number", "HIP 57125"},
        {"Geneva Identification System", "GEN# +1.00101741"},
        {"Smithsonian Astrophysical Observation", "SAO 43873"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.68229725),
        dec: Angle.Degrees(+40.90012877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89261"},
        {"Smithsonian Astrophysical Observation", "SAO 47309"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23156926),
        dec: Angle.Degrees(+40.90066522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4409"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12596295),
        dec: Angle.Degrees(+40.90120394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199179"},
        {"Hipparcos Number", "HIP 103163"},
        {"Smithsonian Astrophysical Observation", "SAO 50201"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.51855317),
        dec: Angle.Degrees(+40.90129368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9443"},
        {"Hipparcos Number", "HIP 7262"},
        {"Geneva Identification System", "GEN# +1.00009443"},
        {"Smithsonian Astrophysical Observation", "SAO 37310"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.39109986),
        dec: Angle.Degrees(+40.90155386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195230"},
        {"Hipparcos Number", "HIP 100993"},
        {"Smithsonian Astrophysical Observation", "SAO 49671"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.13949606),
        dec: Angle.Degrees(+40.90186363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62336"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61455692),
        dec: Angle.Degrees(+40.90238242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65145"},
        {"Smithsonian Astrophysical Observation", "SAO 44575"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.24321406),
        dec: Angle.Degrees(+40.90513651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275972"},
        {"Hipparcos Number", "HIP 18674"},
        {"Smithsonian Astrophysical Observation", "SAO 39236"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.98163017),
        dec: Angle.Degrees(+40.90553436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159796"},
        {"Hipparcos Number", "HIP 86009"},
        {"Smithsonian Astrophysical Observation", "SAO 46806"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.67241104),
        dec: Angle.Degrees(+40.90921198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90224"},
        {"Hipparcos Number", "HIP 51042"},
        {"Smithsonian Astrophysical Observation", "SAO 43333"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.42129506),
        dec: Angle.Degrees(+40.91095818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7138"},
        {"Hipparcos Number", "HIP 5628"},
        {"Geneva Identification System", "GEN# +1.00007138"},
        {"Smithsonian Astrophysical Observation", "SAO 37020"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.07095454),
        dec: Angle.Degrees(+40.91111958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17076"},
        {"Hipparcos Number", "HIP 12901"},
        {"Smithsonian Astrophysical Observation", "SAO 38306"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.46289345),
        dec: Angle.Degrees(+40.91117922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103309"},
        {"Hipparcos Number", "HIP 58003"},
        {"Geneva Identification System", "GEN# +1.00103309"},
        {"Smithsonian Astrophysical Observation", "SAO 43939"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46033177),
        dec: Angle.Degrees(+40.91304740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26321"},
        {"Hipparcos Number", "HIP 19563"},
        {"Geneva Identification System", "GEN# +1.00026321"},
        {"Smithsonian Astrophysical Observation", "SAO 39366"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.86215704),
        dec: Angle.Degrees(+40.91334550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11970"},
        {"Hipparcos Number", "HIP 9199"},
        {"Geneva Identification System", "GEN# +1.00011970"},
        {"Smithsonian Astrophysical Observation", "SAO 37664"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60091482),
        dec: Angle.Degrees(+40.91368935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148491"},
        {"Hipparcos Number", "HIP 80549"},
        {"Fundamental Katalog 5th Edition", "FK5 5453"},
        {"Smithsonian Astrophysical Observation", "SAO 46089"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.68103605),
        dec: Angle.Degrees(+40.91405547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166300"},
        {"Hipparcos Number", "HIP 88840"},
        {"Smithsonian Astrophysical Observation", "SAO 47246"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.02191141),
        dec: Angle.Degrees(+40.91464582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198481"},
        {"Hipparcos Number", "HIP 102749"},
        {"Geneva Identification System", "GEN# +1.00198481"},
        {"Smithsonian Astrophysical Observation", "SAO 50101"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28671619),
        dec: Angle.Degrees(+40.91553988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107085"},
        {"Hipparcos Number", "HIP 60023"},
        {"Geneva Identification System", "GEN# +1.00107085"},
        {"Smithsonian Astrophysical Observation", "SAO 44117"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.64982533),
        dec: Angle.Degrees(+40.91635410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109420"},
        {"Geneva Identification System", "GEN# +0.04004745"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.53236140),
        dec: Angle.Degrees(+40.91961839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21795"},
        {"Hipparcos Number", "HIP 16487"},
        {"Smithsonian Astrophysical Observation", "SAO 38925"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.07326350),
        dec: Angle.Degrees(+40.92076196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111038"},
        {"Smithsonian Astrophysical Observation", "SAO 52058"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.42786507),
        dec: Angle.Degrees(+40.92198265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1603"},
        {"Hipparcos Number", "HIP 1634"},
        {"Geneva Identification System", "GEN# +1.00001603"},
        {"Smithsonian Astrophysical Observation", "SAO 36276"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.11847601),
        dec: Angle.Degrees(+40.92217204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113892"},
        {"Hipparcos Number", "HIP 63937"},
        {"Geneva Identification System", "GEN# +1.00113892"},
        {"Smithsonian Astrophysical Observation", "SAO 44470"},
        {"Wilson Evans Batten Catalogue", "WEB 11298"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.55625667),
        dec: Angle.Degrees(+40.92251371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52263"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.18003659),
        dec: Angle.Degrees(+40.92268568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103812"},
        {"Hipparcos Number", "HIP 58305"},
        {"Smithsonian Astrophysical Observation", "SAO 43969"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.35190979),
        dec: Angle.Degrees(+40.92346632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87485"},
        {"Hipparcos Number", "HIP 49491"},
        {"Geneva Identification System", "GEN# +1.00087485"},
        {"Smithsonian Astrophysical Observation", "SAO 43187"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.56327013),
        dec: Angle.Degrees(+40.92512131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189349"},
        {"Hipparcos Number", "HIP 98269"},
        {"Geneva Identification System", "GEN# +1.00189349"},
        {"Smithsonian Astrophysical Observation", "SAO 49034"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.50990218),
        dec: Angle.Degrees(+40.92680399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54270"},
        {"Smithsonian Astrophysical Observation", "SAO 43611"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53307764),
        dec: Angle.Degrees(+40.92702748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168654"},
        {"Hipparcos Number", "HIP 89764"},
        {"Geneva Identification System", "GEN# +1.00168654"},
        {"Smithsonian Astrophysical Observation", "SAO 47382"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76811849),
        dec: Angle.Degrees(+40.92733505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89718"},
        {"Hipparcos Number", "HIP 50771"},
        {"Smithsonian Astrophysical Observation", "SAO 43307"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.51339709),
        dec: Angle.Degrees(+40.93002553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76705"},
        {"Hipparcos Number", "HIP 44121"},
        {"Smithsonian Astrophysical Observation", "SAO 42632"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.78834617),
        dec: Angle.Degrees(+40.93199083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203712"},
        {"Hipparcos Number", "HIP 105562"},
        {"Smithsonian Astrophysical Observation", "SAO 50770"},
        {"Wilson Evans Batten Catalogue", "WEB 19165"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.70259444),
        dec: Angle.Degrees(+40.93261131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116162"},
        {"Smithsonian Astrophysical Observation", "SAO 53126"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.05196342),
        dec: Angle.Degrees(+40.93288689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172671"},
        {"Hipparcos Number", "HIP 91491"},
        {"Celescope Catalog", "CEL 4637"},
        {"Geneva Identification System", "GEN# +1.00172671"},
        {"Smithsonian Astrophysical Observation", "SAO 47676"},
        {"Wilson Evans Batten Catalogue", "WEB 15723"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.88760628),
        dec: Angle.Degrees(+40.93506238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6901"},
        {"Hipparcos Number", "HIP 5486"},
        {"Smithsonian Astrophysical Observation", "SAO 36982"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.55465494),
        dec: Angle.Degrees(+40.93533378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168322"},
        {"Hipparcos Number", "HIP 89604"},
        {"Geneva Identification System", "GEN# +1.00168322"},
        {"Smithsonian Astrophysical Observation", "SAO 47359"},
        {"Wilson Evans Batten Catalogue", "WEB 15262"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.27895133),
        dec: Angle.Degrees(+40.93657224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99284"},
        {"Hipparcos Number", "HIP 55784"},
        {"Smithsonian Astrophysical Observation", "SAO 43738"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.44822745),
        dec: Angle.Degrees(+40.93748820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23192"},
        {"Hipparcos Number", "HIP 17490"},
        {"Smithsonian Astrophysical Observation", "SAO 39073"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.20095311),
        dec: Angle.Degrees(+40.93869586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107224"},
        {"Hipparcos Number", "HIP 60101"},
        {"Geneva Identification System", "GEN# +1.00107224"},
        {"Smithsonian Astrophysical Observation", "SAO 44124"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.88118066),
        dec: Angle.Degrees(+40.93950056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15139"},
        {"Hipparcos Number", "HIP 11428"},
        {"Smithsonian Astrophysical Observation", "SAO 38037"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.85398648),
        dec: Angle.Degrees(+40.93958074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4114"},
        {"Geneva Identification System", "GEN# +0.04000184"},
        {"Smithsonian Astrophysical Observation", "SAO 36737"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.18283717),
        dec: Angle.Degrees(+40.94038296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77092"},
        {"Hipparcos Number", "HIP 44318"},
        {"Geneva Identification System", "GEN# +1.00077092"},
        {"Smithsonian Astrophysical Observation", "SAO 42647"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38667501),
        dec: Angle.Degrees(+40.94070386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75372"},
        {"Hipparcos Number", "HIP 43452"},
        {"Geneva Identification System", "GEN# +1.00075372"},
        {"Smithsonian Astrophysical Observation", "SAO 42568"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.75203123),
        dec: Angle.Degrees(+40.94105921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5729"},
        {"Hipparcos Number", "HIP 4626"},
        {"Smithsonian Astrophysical Observation", "SAO 36823"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.85058887),
        dec: Angle.Degrees(+40.94219873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42897"},
        {"Smithsonian Astrophysical Observation", "SAO 42521"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.12635580),
        dec: Angle.Degrees(+40.94486400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192002"},
        {"Hipparcos Number", "HIP 99444"},
        {"Smithsonian Astrophysical Observation", "SAO 49283"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.76363639),
        dec: Angle.Degrees(+40.94491151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56122"},
        {"Hipparcos Number", "HIP 35314"},
        {"Smithsonian Astrophysical Observation", "SAO 41670"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.41911072),
        dec: Angle.Degrees(+40.94516970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140228"},
        {"Hipparcos Number", "HIP 76802"},
        {"Fundamental Katalog 5th Edition", "FK5 5387"},
        {"Geneva Identification System", "GEN# +1.00140228"},
        {"Smithsonian Astrophysical Observation", "SAO 45677"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.22887819),
        dec: Angle.Degrees(+40.94626463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1368"},
        {"Cincinnati Publication", "Ci 20 16"},
        {"Geneva Identification System", "GEN# +0.04000045"},
        {"Wilson Evans Batten Catalogue", "WEB 246"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27473316),
        dec: Angle.Degrees(+40.94809407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 567.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43210"},
        {"Smithsonian Astrophysical Observation", "SAO 42554"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.03818539),
        dec: Angle.Degrees(+40.95007032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11906"},
        {"Hipparcos Number", "HIP 9160"},
        {"Smithsonian Astrophysical Observation", "SAO 37654"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48536683),
        dec: Angle.Degrees(+40.95019094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67249"},
        {"Geneva Identification System", "GEN# +0.04102426"},
        {"Smithsonian Astrophysical Observation", "SAO 44747"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.74620439),
        dec: Angle.Degrees(+40.95081120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37211"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.65812900),
        dec: Angle.Degrees(+40.95140357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21047"},
        {"Hipparcos Number", "HIP 15944"},
        {"Renson", "Renson 5250"},
        {"Smithsonian Astrophysical Observation", "SAO 38812"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.33133630),
        dec: Angle.Degrees(+40.95336389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154375"},
        {"Hipparcos Number", "HIP 83441"},
        {"Geneva Identification System", "GEN# +1.00154375"},
        {"Smithsonian Astrophysical Observation", "SAO 46457"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.80702060),
        dec: Angle.Degrees(+40.95371351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3333"},
        {"Smithsonian Astrophysical Observation", "SAO 36590"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.62861147),
        dec: Angle.Degrees(+40.95384910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219625"},
        {"Hipparcos Number", "HIP 114936"},
        {"Smithsonian Astrophysical Observation", "SAO 52856"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20749595),
        dec: Angle.Degrees(+40.95525560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79591"},
        {"Smithsonian Astrophysical Observation", "SAO 45981"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.57058286),
        dec: Angle.Degrees(+40.95557468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14576",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Algol"},
        {"Common Name 2", "Algol B"},
        {"Common Name 3", "Algol C"},
        {"Common Name 4", "Algol A"},
        {"Aitken", "ADS 2362 A"},
        {"Henry Draper", "HD 19356"},
        {"Hipparcos Number", "HIP 14576"},
        {"Celescope Catalog", "CEL 301"},
        {"Fundamental Katalog 5th Edition", "FK5 111"},
        {"Geneva Identification System", "GEN# +1.00019356"},
        {"Smithsonian Astrophysical Observation", "SAO 38592"},
        {"Wilson Evans Batten Catalogue", "WEB 2833"},
        {"Wilson Evans Batten Catalogue 2", "WEB 2834"},
    },
    visualMagnitude: 2.09,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.04220716),
        dec: Angle.Degrees(+40.95565120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6341"},
        {"Smithsonian Astrophysical Observation", "SAO 37146"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.37006385),
        dec: Angle.Degrees(+40.95818201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200021"},
        {"Hipparcos Number", "HIP 103603"},
        {"Smithsonian Astrophysical Observation", "SAO 50321"},
        {"Wilson Evans Batten Catalogue", "WEB 18851"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.86767356),
        dec: Angle.Degrees(+40.96023953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72463"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.26654755),
        dec: Angle.Degrees(+40.96056541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276274"},
        {"Hipparcos Number", "HIP 20550"},
        {"Smithsonian Astrophysical Observation", "SAO 39505"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.04637386),
        dec: Angle.Degrees(+40.96087026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80093"},
        {"Geneva Identification System", "GEN# +0.04102695"},
        {"Smithsonian Astrophysical Observation", "SAO 46038"},
        {"Wilson Evans Batten Catalogue", "WEB 13559"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.21979056),
        dec: Angle.Degrees(+40.96117561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49040"},
        {"Hipparcos Number", "HIP 32626"},
        {"Geneva Identification System", "GEN# +2.22810065"},
        {"Renson", "Renson 13200"},
        {"Smithsonian Astrophysical Observation", "SAO 41355"},
        {"New General Catalogue", "NGC 2281 65"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09216294),
        dec: Angle.Degrees(+40.96254518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222730"},
        {"Hipparcos Number", "HIP 116999"},
        {"Smithsonian Astrophysical Observation", "SAO 53311"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.78163052),
        dec: Angle.Degrees(+40.96305680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39076"},
        {"Hipparcos Number", "HIP 27717"},
        {"Geneva Identification System", "GEN# +1.00039076"},
        {"Smithsonian Astrophysical Observation", "SAO 40663"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.04158247),
        dec: Angle.Degrees(+40.96311039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192968"},
        {"Hipparcos Number", "HIP 99905"},
        {"Celescope Catalog", "CEL 5004"},
        {"Geneva Identification System", "GEN# +1.00192968"},
        {"Smithsonian Astrophysical Observation", "SAO 49399"},
        {"Wilson Evans Batten Catalogue", "WEB 17969"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.05759201),
        dec: Angle.Degrees(+40.96336534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15996 A"},
        {"Henry Draper", "HD 213391"},
        {"Hipparcos Number", "HIP 111081"},
        {"Smithsonian Astrophysical Observation", "SAO 52071"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.55368580),
        dec: Angle.Degrees(+40.96558803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110033"},
        {"Smithsonian Astrophysical Observation", "SAO 51835"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.30018965),
        dec: Angle.Degrees(+40.96799503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222219"},
        {"Hipparcos Number", "HIP 116668"},
        {"Smithsonian Astrophysical Observation", "SAO 53227"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.64466641),
        dec: Angle.Degrees(+40.96888293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31928",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5296 AB"},
        {"Henry Draper", "HD 47412"},
        {"Hipparcos Number", "HIP 31928"},
        {"Smithsonian Astrophysical Observation", "SAO 41253"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.08877067),
        dec: Angle.Degrees(+40.96970638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7546 AB"},
        {"Henry Draper", "HD 85346"},
        {"Hipparcos Number", "HIP 48418"},
        {"Smithsonian Astrophysical Observation", "SAO 43080"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06468274),
        dec: Angle.Degrees(+40.97038606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36314"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.12705457),
        dec: Angle.Degrees(+40.97039200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7489 A"},
        {"Henry Draper", "HD 83870"},
        {"Hipparcos Number", "HIP 47611"},
        {"Geneva Identification System", "GEN# +1.00083870"},
        {"Smithsonian Astrophysical Observation", "SAO 42989"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.62152399),
        dec: Angle.Degrees(+40.97367400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275445"},
        {"Hipparcos Number", "HIP 16632"},
        {"Smithsonian Astrophysical Observation", "SAO 38948"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.49997136),
        dec: Angle.Degrees(+40.97472117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64913"},
        {"Hipparcos Number", "HIP 38926"},
        {"Geneva Identification System", "GEN# +1.00064913"},
        {"Smithsonian Astrophysical Observation", "SAO 42092"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47839670),
        dec: Angle.Degrees(+40.97482355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203519"},
        {"Hipparcos Number", "HIP 105453"},
        {"Smithsonian Astrophysical Observation", "SAO 50753"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.38502988),
        dec: Angle.Degrees(+40.97502174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171008"},
        {"Hipparcos Number", "HIP 90720"},
        {"Smithsonian Astrophysical Observation", "SAO 47547"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.63687107),
        dec: Angle.Degrees(+40.97581359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201090"},
        {"Hipparcos Number", "HIP 104159"},
        {"Smithsonian Astrophysical Observation", "SAO 50448"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.54840850),
        dec: Angle.Degrees(+40.97694969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275168"},
        {"Hipparcos Number", "HIP 15494"},
        {"Smithsonian Astrophysical Observation", "SAO 38725"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.91339938),
        dec: Angle.Degrees(+40.97854228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30416"},
        {"Smithsonian Astrophysical Observation", "SAO 41063"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.93591681),
        dec: Angle.Degrees(+40.98094934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10781"},
        {"Hipparcos Number", "HIP 8258"},
        {"Geneva Identification System", "GEN# +1.00010781"},
        {"Smithsonian Astrophysical Observation", "SAO 37494"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.58140619),
        dec: Angle.Degrees(+40.98334432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110065"},
        {"Hipparcos Number", "HIP 61725"},
        {"Geneva Identification System", "GEN# +1.00110065"},
        {"Smithsonian Astrophysical Observation", "SAO 44270"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.78293912),
        dec: Angle.Degrees(+40.98349786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95072"},
        {"Hipparcos Number", "HIP 53688"},
        {"Geneva Identification System", "GEN# +1.00095072"},
        {"Smithsonian Astrophysical Observation", "SAO 43553"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.77537510),
        dec: Angle.Degrees(+40.98354546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136580"},
        {"Hipparcos Number", "HIP 75039"},
        {"Geneva Identification System", "GEN# +1.00136580"},
        {"Smithsonian Astrophysical Observation", "SAO 45491"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.00973385),
        dec: Angle.Degrees(+40.98373083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194092"},
        {"Hipparcos Number", "HIP 100438"},
        {"Celescope Catalog", "CEL 5039"},
        {"Geneva Identification System", "GEN# +1.00194092"},
        {"Smithsonian Astrophysical Observation", "SAO 49525"},
        {"Wilson Evans Batten Catalogue", "WEB 18135"},
        {"New General Catalogue", "NGC 6910 167"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.52268555),
        dec: Angle.Degrees(+40.98561924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276078"},
        {"Hipparcos Number", "HIP 19521"},
        {"Smithsonian Astrophysical Observation", "SAO 39357"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.73658997),
        dec: Angle.Degrees(+40.99241138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23000"},
        {"Hipparcos Number", "HIP 17369"},
        {"Geneva Identification System", "GEN# +1.00023000"},
        {"Smithsonian Astrophysical Observation", "SAO 39056"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.78019518),
        dec: Angle.Degrees(+40.99388574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187234"},
        {"Hipparcos Number", "HIP 97360"},
        {"Geneva Identification System", "GEN# +1.00187234"},
        {"Smithsonian Astrophysical Observation", "SAO 48837"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.83243861),
        dec: Angle.Degrees(+40.99429708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7266"},
        {"Smithsonian Astrophysical Observation", "SAO 37311"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.40176333),
        dec: Angle.Degrees(+40.99508156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175404"},
        {"Hipparcos Number", "HIP 92700"},
        {"Smithsonian Astrophysical Observation", "SAO 47891"},
        {"Wilson Evans Batten Catalogue", "WEB 16035"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.32708394),
        dec: Angle.Degrees(+40.99514612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84279"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.43312276),
        dec: Angle.Degrees(+40.99537216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33232"},
        {"Hipparcos Number", "HIP 24118"},
        {"Celescope Catalog", "CEL 553"},
        {"Geneva Identification System", "GEN# +1.00033232"},
        {"Smithsonian Astrophysical Observation", "SAO 40080"},
        {"Wilson Evans Batten Catalogue", "WEB 4689"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.70084472),
        dec: Angle.Degrees(+41.00290299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177780"},
        {"Hipparcos Number", "HIP 93657"},
        {"Geneva Identification System", "GEN# +1.00177780"},
        {"Smithsonian Astrophysical Observation", "SAO 48053"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06818823),
        dec: Angle.Degrees(+41.00319661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27175"},
        {"Hipparcos Number", "HIP 20159"},
        {"Smithsonian Astrophysical Observation", "SAO 39462"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.80899781),
        dec: Angle.Degrees(+41.00510213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111682"},
        {"Celescope Catalog", "CEL 5499"},
        {"Geneva Identification System", "GEN# +0.04004862J"},
        {"Smithsonian Astrophysical Observation", "SAO 52195"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.36735203),
        dec: Angle.Degrees(+41.00528427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109967"},
        {"Hipparcos Number", "HIP 61678"},
        {"Smithsonian Astrophysical Observation", "SAO 44264"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.65377231),
        dec: Angle.Degrees(+41.00766190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200841"},
        {"Hipparcos Number", "HIP 104042"},
        {"Geneva Identification System", "GEN# +1.00200841"},
        {"Smithsonian Astrophysical Observation", "SAO 50420"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.17760665),
        dec: Angle.Degrees(+41.00801099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12687 AB"},
        {"Henry Draper", "HD 185266"},
        {"Hipparcos Number", "HIP 96448"},
        {"Smithsonian Astrophysical Observation", "SAO 48640"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.13449150),
        dec: Angle.Degrees(+41.00973922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160420"},
        {"Hipparcos Number", "HIP 86292"},
        {"Fundamental Katalog 5th Edition", "FK5 5546"},
        {"Geneva Identification System", "GEN# +1.00160420"},
        {"Smithsonian Astrophysical Observation", "SAO 46852"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.47957204),
        dec: Angle.Degrees(+41.01082151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7744"},
        {"Hipparcos Number", "HIP 6059"},
        {"Smithsonian Astrophysical Observation", "SAO 37088"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.44028694),
        dec: Angle.Degrees(+41.01362068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105009"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.03380896),
        dec: Angle.Degrees(+41.01926181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55194"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.50887546),
        dec: Angle.Degrees(+41.01995049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41472"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88147757),
        dec: Angle.Degrees(+41.02049454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64069"},
        {"Hipparcos Number", "HIP 38567"},
        {"Smithsonian Astrophysical Observation", "SAO 42051"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.45034882),
        dec: Angle.Degrees(+41.02222863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72543"},
        {"Hipparcos Number", "HIP 42111"},
        {"Fundamental Katalog 5th Edition", "FK5 4772"},
        {"Geneva Identification System", "GEN# +1.00072543"},
        {"Smithsonian Astrophysical Observation", "SAO 42436"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.76260174),
        dec: Angle.Degrees(+41.02383223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81439"},
        {"Hipparcos Number", "HIP 46337"},
        {"Geneva Identification System", "GEN# +1.00081439"},
        {"Smithsonian Astrophysical Observation", "SAO 42863"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.70457465),
        dec: Angle.Degrees(+41.02430130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104158"},
        {"Smithsonian Astrophysical Observation", "SAO 50446"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.53551251),
        dec: Angle.Degrees(+41.02476379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126943"},
        {"Hipparcos Number", "HIP 70685"},
        {"Geneva Identification System", "GEN# +1.00126943"},
        {"Smithsonian Astrophysical Observation", "SAO 45058"},
        {"Wilson Evans Batten Catalogue", "WEB 12248"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.86464754),
        dec: Angle.Degrees(+41.02496446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161129"},
        {"Hipparcos Number", "HIP 86609"},
        {"Smithsonian Astrophysical Observation", "SAO 46892"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48024255),
        dec: Angle.Degrees(+41.02497713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103707"},
        {"Hipparcos Number", "HIP 58235"},
        {"Geneva Identification System", "GEN# +1.00103707"},
        {"Smithsonian Astrophysical Observation", "SAO 43954"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.16904070),
        dec: Angle.Degrees(+41.02512698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194193"},
        {"Hipparcos Number", "HIP 100501"},
        {"Geneva Identification System", "GEN# +1.00194193"},
        {"Smithsonian Astrophysical Observation", "SAO 49546"},
        {"Wilson Evans Batten Catalogue", "WEB 18152"},
        {"New General Catalogue", "NGC 6910 158"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68872891),
        dec: Angle.Degrees(+41.02613288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98735"},
        {"Hipparcos Number", "HIP 55503"},
        {"Geneva Identification System", "GEN# +1.00098735"},
        {"Smithsonian Astrophysical Observation", "SAO 43714"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.50780156),
        dec: Angle.Degrees(+41.02742864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114238"},
        {"Smithsonian Astrophysical Observation", "SAO 52716"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.05392675),
        dec: Angle.Degrees(+41.02777780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72115"},
        {"Wilson Evans Batten Catalogue", "WEB 12406"},
    },
    visualMagnitude: 11.51,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.27477469),
        dec: Angle.Degrees(+41.02905761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34904"},
        {"Hipparcos Number", "HIP 25143"},
        {"Celescope Catalog", "CEL 648"},
        {"Geneva Identification System", "GEN# +1.00034904"},
        {"Smithsonian Astrophysical Observation", "SAO 40290"},
        {"Wilson Evans Batten Catalogue", "WEB 4873"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.70968545),
        dec: Angle.Degrees(+41.02925326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 995"},
        {"Hipparcos Number", "HIP 1164"},
        {"Smithsonian Astrophysical Observation", "SAO 36190"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.64038545),
        dec: Angle.Degrees(+41.03258105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18482"},
        {"Hipparcos Number", "HIP 13949"},
        {"Geneva Identification System", "GEN# +1.00018482"},
        {"Smithsonian Astrophysical Observation", "SAO 38492"},
        {"Wilson Evans Batten Catalogue", "WEB 2751"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.91611677),
        dec: Angle.Degrees(+41.03305347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 905"},
        {"Hipparcos Number", "HIP 1086"},
        {"Fundamental Katalog 5th Edition", "FK5 2010"},
        {"Geneva Identification System", "GEN# +1.00000905"},
        {"Smithsonian Astrophysical Observation", "SAO 36173"},
        {"Wilson Evans Batten Catalogue", "WEB 189"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.37889713),
        dec: Angle.Degrees(+41.03572671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209558"},
        {"Hipparcos Number", "HIP 108873"},
        {"Smithsonian Astrophysical Observation", "SAO 51599"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.82804038),
        dec: Angle.Degrees(+41.03735553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214977"},
        {"Hipparcos Number", "HIP 112017"},
        {"Celescope Catalog", "CEL 5511"},
        {"Geneva Identification System", "GEN# +1.00214977"},
        {"Smithsonian Astrophysical Observation", "SAO 52265"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.34888749),
        dec: Angle.Degrees(+41.03778215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9020 AB"},
        {"Henry Draper", "HD 120022"},
        {"Hipparcos Number", "HIP 67178"},
        {"Geneva Identification System", "GEN# +1.00120022"},
        {"Smithsonian Astrophysical Observation", "SAO 44740"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.51156802),
        dec: Angle.Degrees(+41.03792222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78741"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.12196262),
        dec: Angle.Degrees(+41.03946115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120683"},
        {"Hipparcos Number", "HIP 67518"},
        {"Smithsonian Astrophysical Observation", "SAO 44771"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52170430),
        dec: Angle.Degrees(+41.03950168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126394"},
        {"Hipparcos Number", "HIP 70390"},
        {"Geneva Identification System", "GEN# +1.00126394"},
        {"Smithsonian Astrophysical Observation", "SAO 45033"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02866072),
        dec: Angle.Degrees(+41.03952733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14849 A"},
        {"Henry Draper", "HD 203096"},
        {"Hipparcos Number", "HIP 105229"},
        {"Geneva Identification System", "GEN# +1.00203096"},
        {"Renson", "Renson 56557"},
        {"Smithsonian Astrophysical Observation", "SAO 50699"},
        {"Wilson Evans Batten Catalogue", "WEB 19112"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.73055559),
        dec: Angle.Degrees(+41.04052946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160637"},
        {"Hipparcos Number", "HIP 86396"},
        {"Smithsonian Astrophysical Observation", "SAO 46865"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.80760382),
        dec: Angle.Degrees(+41.04195283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196503"},
        {"Hipparcos Number", "HIP 101668"},
        {"Smithsonian Astrophysical Observation", "SAO 49847"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.11614621),
        dec: Angle.Degrees(+41.04433377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7631 AB"},
        {"Henry Draper", "HD 87411"},
        {"Hipparcos Number", "HIP 49448"},
        {"Smithsonian Astrophysical Observation", "SAO 43178"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.43164391),
        dec: Angle.Degrees(+41.04520363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220834"},
        {"Hipparcos Number", "HIP 115723"},
        {"Geneva Identification System", "GEN# +1.00220834"},
        {"Smithsonian Astrophysical Observation", "SAO 53028"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68053923),
        dec: Angle.Degrees(+41.04594385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107177",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15251 AB"},
        {"Henry Draper", "HD 206656"},
        {"Hipparcos Number", "HIP 107177"},
        {"Geneva Identification System", "GEN# +1.00206656"},
        {"Smithsonian Astrophysical Observation", "SAO 51212"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.63921106),
        dec: Angle.Degrees(+41.04749448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80076",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hunor"},
        {"Henry Draper", "HD 147506"},
        {"Hipparcos Number", "HIP 80076"},
        {"Smithsonian Astrophysical Observation", "SAO 46035"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.15152258),
        dec: Angle.Degrees(+41.04815592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15726"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.64850954),
        dec: Angle.Degrees(+41.33201632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15151"},
        {"Hipparcos Number", "HIP 11436"},
        {"Smithsonian Astrophysical Observation", "SAO 38039"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86964049),
        dec: Angle.Degrees(+41.04840304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199122"},
        {"Hipparcos Number", "HIP 103126"},
        {"Celescope Catalog", "CEL 5196"},
        {"Geneva Identification System", "GEN# +1.00199122"},
        {"Renson", "Renson 55433"},
        {"Smithsonian Astrophysical Observation", "SAO 50189"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41615853),
        dec: Angle.Degrees(+41.04956900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178591"},
        {"Hipparcos Number", "HIP 93907"},
        {"Celescope Catalog", "CEL 4703"},
        {"Geneva Identification System", "GEN# +1.00178591"},
        {"Renson", "Renson 49677"},
        {"Smithsonian Astrophysical Observation", "SAO 48102"},
        {"Wilson Evans Batten Catalogue", "WEB 16341"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.82990902),
        dec: Angle.Degrees(+41.05411386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113535"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.91187008),
        dec: Angle.Degrees(+41.05418743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86146"},
        {"Hipparcos Number", "HIP 48833"},
        {"Fundamental Katalog 5th Edition", "FK5 374"},
        {"Geneva Identification System", "GEN# +1.00086146"},
        {"Smithsonian Astrophysical Observation", "SAO 43115"},
        {"Wilson Evans Batten Catalogue", "WEB 9075"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.42143543),
        dec: Angle.Degrees(+41.05569741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41636"},
        {"Hipparcos Number", "HIP 29114"},
        {"Geneva Identification System", "GEN# +1.00041636"},
        {"Smithsonian Astrophysical Observation", "SAO 40881"},
        {"Wilson Evans Batten Catalogue", "WEB 5700"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.09639645),
        dec: Angle.Degrees(+41.05584589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59378"},
        {"Geneva Identification System", "GEN# +6.20030636"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.73701589),
        dec: Angle.Degrees(+41.05721814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 231.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87094"},
        {"Smithsonian Astrophysical Observation", "SAO 46956"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93327270),
        dec: Angle.Degrees(+41.05945642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85494"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.08067115),
        dec: Angle.Degrees(+41.06249616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49817"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.55069150),
        dec: Angle.Degrees(+41.06276598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207770"},
        {"Hipparcos Number", "HIP 107807"},
        {"Smithsonian Astrophysical Observation", "SAO 51355"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.61126841),
        dec: Angle.Degrees(+41.06282133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64702"},
        {"Hipparcos Number", "HIP 38839"},
        {"Geneva Identification System", "GEN# +1.00064702"},
        {"Smithsonian Astrophysical Observation", "SAO 42085"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.22575885),
        dec: Angle.Degrees(+41.06359758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104636"},
        {"Hipparcos Number", "HIP 58752"},
        {"Geneva Identification System", "GEN# +1.00104636"},
        {"Smithsonian Astrophysical Observation", "SAO 44010"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.74979514),
        dec: Angle.Degrees(+41.06535280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49098"},
        {"Hipparcos Number", "HIP 32654"},
        {"Geneva Identification System", "GEN# +2.22810086"},
        {"Renson", "Renson 13220"},
        {"Smithsonian Astrophysical Observation", "SAO 41356"},
        {"New General Catalogue", "NGC 2281 86"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.17021798),
        dec: Angle.Degrees(+41.06651666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1338"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)16, 44.8700),
        dec: Angle.DegreesMinutesSeconds((int)+41, (int)04, 08.700)
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
    primaryId: "HIP 23453",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Saclateni"},
        {"Henry Draper", "HD 32068"},
        {"Henry Draper 2", "HD 32069"},
        {"Hipparcos Number", "HIP 23453"},
        {"Celescope Catalog", "CEL 510"},
        {"Fundamental Katalog 5th Edition", "FK5 1137"},
        {"Geneva Identification System", "GEN# +1.00032068"},
        {"Smithsonian Astrophysical Observation", "SAO 39966"},
        {"Wilson Evans Batten Catalogue", "WEB 4563"},
    },
    visualMagnitude: 3.69,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.61950025),
        dec: Angle.Degrees(+41.07588953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9712"},
        {"Hipparcos Number", "HIP 7444"},
        {"Geneva Identification System", "GEN# +1.00009712"},
        {"Smithsonian Astrophysical Observation", "SAO 37344"},
        {"Wilson Evans Batten Catalogue", "WEB 1592"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96859930),
        dec: Angle.Degrees(+41.07641867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3324 A"},
        {"Henry Draper", "HD 29096"},
        {"Hipparcos Number", "HIP 21469"},
        {"Smithsonian Astrophysical Observation", "SAO 39638"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.16303615),
        dec: Angle.Degrees(+41.07686007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206644"},
        {"Hipparcos Number", "HIP 107162"},
        {"Celescope Catalog", "CEL 5370"},
        {"Geneva Identification System", "GEN# +1.00206644"},
        {"Smithsonian Astrophysical Observation", "SAO 51207"},
        {"Wilson Evans Batten Catalogue", "WEB 19356"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.59558607),
        dec: Angle.Degrees(+41.07702304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204119"},
        {"Hipparcos Number", "HIP 105762"},
        {"Geneva Identification System", "GEN# +1.00204119"},
        {"Smithsonian Astrophysical Observation", "SAO 50819"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.30713911),
        dec: Angle.Degrees(+41.07702918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209270"},
        {"Hipparcos Number", "HIP 108697"},
        {"Smithsonian Astrophysical Observation", "SAO 51555"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.28670462),
        dec: Angle.Degrees(+41.07863798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4727"},
        {"Hipparcos Number", "HIP 3881"},
        {"Celescope Catalog", "CEL 92"},
        {"Fundamental Katalog 5th Edition", "FK5 1021"},
        {"Geneva Identification System", "GEN# +1.00004727"},
        {"Smithsonian Astrophysical Observation", "SAO 36699"},
        {"Wilson Evans Batten Catalogue", "WEB 690"},
    },
    visualMagnitude: 4.53,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.45345723),
        dec: Angle.Degrees(+41.07895474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3324 B"},
        {"Hipparcos Number", "HIP 21470"},
    },
    visualMagnitude: 10.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.16530482),
        dec: Angle.Degrees(+41.07964020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188307"},
        {"Hipparcos Number", "HIP 97837"},
        {"Geneva Identification System", "GEN# +1.00188307"},
        {"Smithsonian Astrophysical Observation", "SAO 48932"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.21907547),
        dec: Angle.Degrees(+41.08035696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186074"},
        {"Hipparcos Number", "HIP 96810"},
        {"Smithsonian Astrophysical Observation", "SAO 48713"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18556982),
        dec: Angle.Degrees(+41.08140132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205998"},
        {"Hipparcos Number", "HIP 106815"},
        {"Smithsonian Astrophysical Observation", "SAO 51120"},
        {"Wilson Evans Batten Catalogue", "WEB 19309"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.50514622),
        dec: Angle.Degrees(+41.08152360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4685"},
        {"Hipparcos Number", "HIP 3840"},
        {"Geneva Identification System", "GEN# +1.00004685"},
        {"Smithsonian Astrophysical Observation", "SAO 36690"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.31732471),
        dec: Angle.Degrees(+41.08181697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215871"},
        {"Hipparcos Number", "HIP 112552"},
        {"Smithsonian Astrophysical Observation", "SAO 52367"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93840125),
        dec: Angle.Degrees(+41.08196805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109740"},
        {"Hipparcos Number", "HIP 61554"},
        {"Geneva Identification System", "GEN# +1.00109740"},
        {"Smithsonian Astrophysical Observation", "SAO 44248"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.18584448),
        dec: Angle.Degrees(+41.08387378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34557"},
        {"Hipparcos Number", "HIP 24902"},
        {"Celescope Catalog", "CEL 613"},
        {"Geneva Identification System", "GEN# +1.00034557"},
        {"Smithsonian Astrophysical Observation", "SAO 40248"},
        {"Wilson Evans Batten Catalogue", "WEB 4821"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.06118220),
        dec: Angle.Degrees(+41.08633916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8093 AB"},
        {"Henry Draper", "HD 97501"},
        {"Hipparcos Number", "HIP 54842"},
        {"Geneva Identification System", "GEN# +1.00097501J"},
        {"Smithsonian Astrophysical Observation", "SAO 43649"},
        {"Wilson Evans Batten Catalogue", "WEB 9895"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.41709505),
        dec: Angle.Degrees(+41.08879703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120047"},
        {"Hipparcos Number", "HIP 67194"},
        {"Geneva Identification System", "GEN# +1.00120047"},
        {"Smithsonian Astrophysical Observation", "SAO 44742"},
        {"Wilson Evans Batten Catalogue", "WEB 11826"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.55680620),
        dec: Angle.Degrees(+41.08884885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87484"},
        {"Hipparcos Number", "HIP 49482"},
        {"Geneva Identification System", "GEN# +1.00087484"},
        {"Smithsonian Astrophysical Observation", "SAO 43183"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.53922375),
        dec: Angle.Degrees(+41.09043888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64593"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.59453621),
        dec: Angle.Degrees(+41.09099094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189958"},
        {"Hipparcos Number", "HIP 98552"},
        {"Smithsonian Astrophysical Observation", "SAO 49084"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.29081290),
        dec: Angle.Degrees(+41.09195693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43691"},
        {"Hipparcos Number", "HIP 30057"},
        {"Geneva Identification System", "GEN# +1.00043691"},
        {"Smithsonian Astrophysical Observation", "SAO 41025"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.89441004),
        dec: Angle.Degrees(+41.09243515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132545"},
        {"Hipparcos Number", "HIP 73257"},
        {"Fundamental Katalog 5th Edition", "FK5 5326"},
        {"Geneva Identification System", "GEN# +1.00132545J"},
        {"Smithsonian Astrophysical Observation", "SAO 45310"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.57972600),
        dec: Angle.Degrees(+41.09287499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145435"},
        {"Hipparcos Number", "HIP 79152"},
        {"Fundamental Katalog 5th Edition", "FK5 5423"},
        {"Geneva Identification System", "GEN# +1.00145435"},
        {"Smithsonian Astrophysical Observation", "SAO 45913"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.32353499),
        dec: Angle.Degrees(+41.09504003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
