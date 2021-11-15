using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_43() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104281"},
        {"Hipparcos Number", "HIP 58562"},
        {"Smithsonian Astrophysical Observation", "SAO 180372"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.12255606),
        dec: Angle.Degrees(-21.87993006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152516"},
        {"Hipparcos Number", "HIP 82734"},
        {"Geneva Identification System", "GEN# +1.00152516"},
        {"Smithsonian Astrophysical Observation", "SAO 184782"},
        {"Wilson Evans Batten Catalogue", "WEB 13983"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.65997558),
        dec: Angle.Degrees(-21.87958479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138123"},
        {"Hipparcos Number", "HIP 75948"},
        {"Geneva Identification System", "GEN# +1.00138123"},
        {"Smithsonian Astrophysical Observation", "SAO 183534"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.67849835),
        dec: Angle.Degrees(-21.87860402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149421"},
        {"Hipparcos Number", "HIP 81235"},
        {"Smithsonian Astrophysical Observation", "SAO 184478"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.87117319),
        dec: Angle.Degrees(-21.87761144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28027"},
        {"Hipparcos Number", "HIP 20596"},
        {"Smithsonian Astrophysical Observation", "SAO 169416"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.17248671),
        dec: Angle.Degrees(-21.87275694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51110"},
        {"Hipparcos Number", "HIP 33260"},
        {"Celescope Catalog", "CEL 1436"},
        {"Geneva Identification System", "GEN# +1.00051110"},
        {"Smithsonian Astrophysical Observation", "SAO 172573"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.79890786),
        dec: Angle.Degrees(-21.87193161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14767"},
        {"Hipparcos Number", "HIP 11051"},
        {"Smithsonian Astrophysical Observation", "SAO 167734"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.56763771),
        dec: Angle.Degrees(-21.87129926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51011"},
        {"Hipparcos Number", "HIP 33216"},
        {"Geneva Identification System", "GEN# +1.00051011"},
        {"Smithsonian Astrophysical Observation", "SAO 172559"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.68855258),
        dec: Angle.Degrees(-21.87091248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212890"},
        {"Hipparcos Number", "HIP 110881"},
        {"Smithsonian Astrophysical Observation", "SAO 191158"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.96148128),
        dec: Angle.Degrees(-21.86963261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59498"},
        {"Hipparcos Number", "HIP 36397"},
        {"Geneva Identification System", "GEN# +1.00059498"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.34491584),
        dec: Angle.Degrees(-21.86922488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144451"},
        {"Hipparcos Number", "HIP 78937"},
        {"Smithsonian Astrophysical Observation", "SAO 184125"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.71420438),
        dec: Angle.Degrees(-21.86382700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42581"},
        {"Hipparcos Number", "HIP 29295"},
        {"Cincinnati Publication", "Ci 20 377"},
        {"Cincinnati Publication 2", "Ci 18 771"},
        {"Geneva Identification System", "GEN# +1.00042581"},
        {"Smithsonian Astrophysical Observation", "SAO 171334"},
        {"Wilson Evans Batten Catalogue", "WEB 5749"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.64458964),
        dec: Angle.Degrees(-21.86290752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -714.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48574"},
        {"Hipparcos Number", "HIP 32193"},
        {"Smithsonian Astrophysical Observation", "SAO 172221"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80979942),
        dec: Angle.Degrees(-21.86239666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59497"},
        {"Hipparcos Number", "HIP 36404"},
        {"Celescope Catalog", "CEL 1887"},
        {"Geneva Identification System", "GEN# +1.00059497"},
        {"Smithsonian Astrophysical Observation", "SAO 173847"},
        {"Wilson Evans Batten Catalogue", "WEB 7248"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.36655617),
        dec: Angle.Degrees(-21.85863082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156079"},
        {"Hipparcos Number", "HIP 84491"},
        {"Geneva Identification System", "GEN# +1.00156079"},
        {"Smithsonian Astrophysical Observation", "SAO 185220"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.09973879),
        dec: Angle.Degrees(-21.85754888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118377"},
        {"Hipparcos Number", "HIP 66424"},
        {"Geneva Identification System", "GEN# +1.00118377"},
        {"Smithsonian Astrophysical Observation", "SAO 181795"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.26391886),
        dec: Angle.Degrees(-21.85408456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3019"},
        {"Hipparcos Number", "HIP 2623"},
        {"Geneva Identification System", "GEN# +1.00003019"},
        {"Smithsonian Astrophysical Observation", "SAO 166358"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.32072098),
        dec: Angle.Degrees(-21.85403316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151658"},
        {"Hipparcos Number", "HIP 82351"},
        {"Fundamental Katalog 5th Edition", "FK5 1437"},
        {"Geneva Identification System", "GEN# +1.00151658"},
        {"Smithsonian Astrophysical Observation", "SAO 184681"},
        {"Wilson Evans Batten Catalogue", "WEB 13901"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.39580450),
        dec: Angle.Degrees(-21.85229465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14176"},
        {"Hipparcos Number", "HIP 10649"},
        {"Smithsonian Astrophysical Observation", "SAO 167677"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26698715),
        dec: Angle.Degrees(-21.84707109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19012"},
        {"Hipparcos Number", "HIP 14186"},
        {"Geneva Identification System", "GEN# +1.00019012"},
        {"Smithsonian Astrophysical Observation", "SAO 168256"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.73070326),
        dec: Angle.Degrees(-21.84523201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129758"},
        {"Hipparcos Number", "HIP 72093"},
        {"Smithsonian Astrophysical Observation", "SAO 182838"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.22471155),
        dec: Angle.Degrees(-21.84236875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95595"},
        {"Hipparcos Number", "HIP 53905"},
        {"Geneva Identification System", "GEN# +1.00095595"},
        {"Smithsonian Astrophysical Observation", "SAO 179445"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.45019399),
        dec: Angle.Degrees(-21.84191629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147119"},
        {"Hipparcos Number", "HIP 80085"},
        {"Smithsonian Astrophysical Observation", "SAO 184331"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.18039330),
        dec: Angle.Degrees(-21.84065273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144254"},
        {"Hipparcos Number", "HIP 78847"},
        {"Geneva Identification System", "GEN# +1.00144254"},
        {"Smithsonian Astrophysical Observation", "SAO 184106"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.43082644),
        dec: Angle.Degrees(-21.83874699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8389 A"},
        {"Henry Draper", "HD 104307"},
        {"Hipparcos Number", "HIP 58574"},
        {"Geneva Identification System", "GEN# +1.00104307"},
        {"Smithsonian Astrophysical Observation", "SAO 180374"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.17595167),
        dec: Angle.Degrees(-21.83748019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19640"},
        {"Hipparcos Number", "HIP 14638"},
        {"Smithsonian Astrophysical Observation", "SAO 168334"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.28468225),
        dec: Angle.Degrees(-21.83700807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50562"},
        {"Hipparcos Number", "HIP 33035"},
        {"Celescope Catalog", "CEL 1418"},
        {"Geneva Identification System", "GEN# +1.00050562"},
        {"Smithsonian Astrophysical Observation", "SAO 172499"},
        {"Wilson Evans Batten Catalogue", "WEB 6652"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24361676),
        dec: Angle.Degrees(-21.83528528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1396"},
        {"Hipparcos Number", "HIP 1449"},
        {"Smithsonian Astrophysical Observation", "SAO 166172"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.50952300),
        dec: Angle.Degrees(-21.83174177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204016"},
        {"Hipparcos Number", "HIP 105839"},
        {"Smithsonian Astrophysical Observation", "SAO 190335"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.55927356),
        dec: Angle.Degrees(-21.83013680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133014"},
        {"Hipparcos Number", "HIP 73611"},
        {"Smithsonian Astrophysical Observation", "SAO 183113"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.69012959),
        dec: Angle.Degrees(-21.83010581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38638"},
        {"Hipparcos Number", "HIP 27235"},
        {"Smithsonian Astrophysical Observation", "SAO 170811"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.57665028),
        dec: Angle.Degrees(-21.82974167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69704"},
        {"Hipparcos Number", "HIP 40605"},
        {"Smithsonian Astrophysical Observation", "SAO 175517"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.34687357),
        dec: Angle.Degrees(-21.82908955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125081"},
        {"Hipparcos Number", "HIP 69848"},
        {"Geneva Identification System", "GEN# +1.00125081"},
        {"Renson", "Renson 35740"},
        {"Smithsonian Astrophysical Observation", "SAO 182422"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.42425897),
        dec: Angle.Degrees(-21.82883340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176126"},
        {"Hipparcos Number", "HIP 93242"},
        {"Smithsonian Astrophysical Observation", "SAO 187546"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90007720),
        dec: Angle.Degrees(-21.82824105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97383",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12917 AB"},
        {"Henry Draper", "HD 186828"},
        {"Hipparcos Number", "HIP 97383"},
        {"Smithsonian Astrophysical Observation", "SAO 188569"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.87830232),
        dec: Angle.Degrees(-21.82774216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38700"},
        {"Hipparcos Number", "HIP 27260"},
        {"Smithsonian Astrophysical Observation", "SAO 170824"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.67669775),
        dec: Angle.Degrees(-21.82679822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61428"},
        {"Hipparcos Number", "HIP 37190"},
        {"Smithsonian Astrophysical Observation", "SAO 174179"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60673464),
        dec: Angle.Degrees(-21.82544938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11840"},
        {"Hipparcos Number", "HIP 9006"},
        {"Smithsonian Astrophysical Observation", "SAO 167406"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.98643230),
        dec: Angle.Degrees(-21.82541799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34676"},
        {"Hipparcos Number", "HIP 24741"},
        {"Smithsonian Astrophysical Observation", "SAO 170290"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.57929647),
        dec: Angle.Degrees(-21.82451532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81167"},
        {"Hipparcos Number", "HIP 46061"},
        {"Smithsonian Astrophysical Observation", "SAO 177382"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.88929923),
        dec: Angle.Degrees(-21.82164780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66739"},
        {"Hipparcos Number", "HIP 39476"},
        {"Geneva Identification System", "GEN# +1.00066739"},
        {"Smithsonian Astrophysical Observation", "SAO 175093"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.02405651),
        dec: Angle.Degrees(-21.81645698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100489"},
        {"Hipparcos Number", "HIP 56398"},
        {"Smithsonian Astrophysical Observation", "SAO 179989"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.43632506),
        dec: Angle.Degrees(-21.81616963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202224"},
        {"Hipparcos Number", "HIP 104908"},
        {"Smithsonian Astrophysical Observation", "SAO 190165"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.76316002),
        dec: Angle.Degrees(-21.81531793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140543"},
        {"Hipparcos Number", "HIP 77131"},
        {"Geneva Identification System", "GEN# +1.00140543"},
        {"Smithsonian Astrophysical Observation", "SAO 183753"},
        {"Wilson Evans Batten Catalogue", "WEB 13077"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23608903),
        dec: Angle.Degrees(-21.81496619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137764"},
        {"Hipparcos Number", "HIP 75755"},
        {"Smithsonian Astrophysical Observation", "SAO 183499"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.13478760),
        dec: Angle.Degrees(-21.81382546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41933"},
        {"Hipparcos Number", "HIP 28984"},
        {"Geneva Identification System", "GEN# +1.00041933"},
        {"Smithsonian Astrophysical Observation", "SAO 171251"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73965420),
        dec: Angle.Degrees(-21.81229045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7739"},
        {"Hipparcos Number", "HIP 5975"},
        {"Geneva Identification System", "GEN# +1.00007739"},
        {"Smithsonian Astrophysical Observation", "SAO 166923"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.19678652),
        dec: Angle.Degrees(-21.81142093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192879"},
        {"Hipparcos Number", "HIP 100062"},
        {"Fundamental Katalog 5th Edition", "FK5 1529"},
        {"Geneva Identification System", "GEN# +1.00192879"},
        {"Smithsonian Astrophysical Observation", "SAO 189114"},
        {"Wilson Evans Batten Catalogue", "WEB 18015"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.50573017),
        dec: Angle.Degrees(-21.80990013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15097"},
        {"Hipparcos Number", "HIP 11287"},
        {"Geneva Identification System", "GEN# +1.00015097"},
        {"Smithsonian Astrophysical Observation", "SAO 167774"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.35115148),
        dec: Angle.Degrees(-21.80985461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1540"},
        {"Hipparcos Number", "HIP 1570"},
        {"Smithsonian Astrophysical Observation", "SAO 166190"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.89272682),
        dec: Angle.Degrees(-21.80725878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204381"},
        {"Hipparcos Number", "HIP 106039"},
        {"Geneva Identification System", "GEN# +1.00204381"},
        {"Smithsonian Astrophysical Observation", "SAO 190374"},
        {"Wilson Evans Batten Catalogue", "WEB 19221"},
    },
    visualMagnitude: 4.50,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.18048346),
        dec: Angle.Degrees(-21.80716659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115984"},
        {"Hipparcos Number", "HIP 65152"},
        {"Geneva Identification System", "GEN# +1.00115984"},
        {"Smithsonian Astrophysical Observation", "SAO 181578"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.27358130),
        dec: Angle.Degrees(-21.80593571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5863 BC"},
        {"Hipparcos Number", "HIP 34716"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)11, 19.8500),
        dec: Angle.DegreesMinutesSeconds((int)-21, (int)48, 20.500)
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
    primaryId: "HIP 36329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59344"},
        {"Hipparcos Number", "HIP 36329"},
        {"Smithsonian Astrophysical Observation", "SAO 173823"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17121875),
        dec: Angle.Degrees(-21.80468291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52349"},
        {"Hipparcos Number", "HIP 33695"},
        {"Celescope Catalog", "CEL 1490"},
        {"Geneva Identification System", "GEN# +1.00052349"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.01626616),
        dec: Angle.Degrees(-21.80466043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5863 A"},
        {"Henry Draper", "HD 55271"},
        {"Hipparcos Number", "HIP 34718"},
        {"Fundamental Katalog 5th Edition", "FK5 4650"},
        {"Smithsonian Astrophysical Observation", "SAO 173152"},
        {"Wilson Evans Batten Catalogue", "WEB 6939"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83724594),
        dec: Angle.Degrees(-21.80329432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221416"},
        {"Hipparcos Number", "HIP 116158"},
        {"Geneva Identification System", "GEN# +1.00221416"},
        {"Smithsonian Astrophysical Observation", "SAO 191976"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.03388803),
        dec: Angle.Degrees(-21.80154457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45697"},
        {"Hipparcos Number", "HIP 30780"},
        {"Smithsonian Astrophysical Observation", "SAO 171797"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.01179981),
        dec: Angle.Degrees(-21.79811564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214322"},
        {"Hipparcos Number", "HIP 111697"},
        {"Smithsonian Astrophysical Observation", "SAO 191274"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.40013860),
        dec: Angle.Degrees(-21.79736505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148087"},
        {"Hipparcos Number", "HIP 80534"},
        {"Smithsonian Astrophysical Observation", "SAO 184389"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.62381084),
        dec: Angle.Degrees(-21.79452309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110395"},
        {"Hipparcos Number", "HIP 61963"},
        {"Smithsonian Astrophysical Observation", "SAO 181027"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.47893243),
        dec: Angle.Degrees(-21.79363685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155006"},
        {"Hipparcos Number", "HIP 83969"},
        {"Smithsonian Astrophysical Observation", "SAO 185091"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.46008655),
        dec: Angle.Degrees(-21.79216312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83989"},
        {"Hipparcos Number", "HIP 47535"},
        {"Geneva Identification System", "GEN# +1.00083989"},
        {"Smithsonian Astrophysical Observation", "SAO 177844"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.36642697),
        dec: Angle.Degrees(-21.79130511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155378"},
        {"Hipparcos Number", "HIP 84135"},
        {"Smithsonian Astrophysical Observation", "SAO 185136"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.01529622),
        dec: Angle.Degrees(-21.79093569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41311"},
        {"Hipparcos Number", "HIP 28687"},
        {"Geneva Identification System", "GEN# +1.00041311"},
        {"Smithsonian Astrophysical Observation", "SAO 171183"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.85395919),
        dec: Angle.Degrees(-21.79014360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115323"},
        {"Hipparcos Number", "HIP 64793"},
        {"Smithsonian Astrophysical Observation", "SAO 181510"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.19572180),
        dec: Angle.Degrees(-21.78901665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124991"},
        {"Hipparcos Number", "HIP 69810"},
        {"Geneva Identification System", "GEN# +1.00124991"},
        {"Smithsonian Astrophysical Observation", "SAO 182407"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.30212121),
        dec: Angle.Degrees(-21.78689763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47784"},
        {"Hipparcos Number", "HIP 31844"},
        {"Smithsonian Astrophysical Observation", "SAO 172097"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.87070108),
        dec: Angle.Degrees(-21.78569048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209475"},
        {"Hipparcos Number", "HIP 108935"},
        {"Renson", "Renson 58284"},
        {"Smithsonian Astrophysical Observation", "SAO 190860"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.04142316),
        dec: Angle.Degrees(-21.77999528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79535"},
        {"Hipparcos Number", "HIP 45318"},
        {"Geneva Identification System", "GEN# +1.00079535"},
        {"Smithsonian Astrophysical Observation", "SAO 177147"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53935410),
        dec: Angle.Degrees(-21.77872772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182629"},
        {"Hipparcos Number", "HIP 95564"},
        {"Fundamental Katalog 5th Edition", "FK5 3553"},
        {"Geneva Identification System", "GEN# +1.00182629"},
        {"Smithsonian Astrophysical Observation", "SAO 188121"},
        {"Wilson Evans Batten Catalogue", "WEB 16710"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.57972363),
        dec: Angle.Degrees(-21.77668185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204972"},
        {"Hipparcos Number", "HIP 106371"},
        {"Renson", "Renson 57104"},
        {"Smithsonian Astrophysical Observation", "SAO 190426"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.16255772),
        dec: Angle.Degrees(-21.77649081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152999"},
        {"Hipparcos Number", "HIP 83005"},
        {"Smithsonian Astrophysical Observation", "SAO 184836"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42475228),
        dec: Angle.Degrees(-21.77518338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117886"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.69304607),
        dec: Angle.Degrees(-21.77482015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16727 A"},
        {"Henry Draper", "HD 220466"},
        {"Hipparcos Number", "HIP 115522"},
        {"Geneva Identification System", "GEN# +1.00220466"},
        {"Smithsonian Astrophysical Observation", "SAO 191873"},
        {"Wilson Evans Batten Catalogue", "WEB 20449"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01675838),
        dec: Angle.Degrees(-21.77422317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33559"},
        {"Hipparcos Number", "HIP 24070"},
        {"Smithsonian Astrophysical Observation", "SAO 170143"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.57733170),
        dec: Angle.Degrees(-21.77356763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53371"},
        {"Hipparcos Number", "HIP 34074"},
        {"Celescope Catalog", "CEL 1547"},
        {"Geneva Identification System", "GEN# +1.00053371"},
        {"Smithsonian Astrophysical Observation", "SAO 172882"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00331586),
        dec: Angle.Degrees(-21.77311603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27723"},
        {"Hipparcos Number", "HIP 20375"},
        {"Geneva Identification System", "GEN# +1.00027723"},
        {"Smithsonian Astrophysical Observation", "SAO 169372"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.44761215),
        dec: Angle.Degrees(-21.77077155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162758"},
        {"Hipparcos Number", "HIP 87578"},
        {"Smithsonian Astrophysical Observation", "SAO 185903"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37287511),
        dec: Angle.Degrees(-21.76855158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110952"},
        {"Hipparcos Number", "HIP 62285"},
        {"Smithsonian Astrophysical Observation", "SAO 181086"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.46907473),
        dec: Angle.Degrees(-21.76824238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2472 A"},
        {"Henry Draper", "HD 20720"},
        {"Hipparcos Number", "HIP 15474"},
        {"Geneva Identification System", "GEN# +1.00020720J"},
        {"Smithsonian Astrophysical Observation", "SAO 168460"},
        {"Wilson Evans Batten Catalogue", "WEB 2975"},
    },
    visualMagnitude: 3.70,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.87904033),
        dec: Angle.Degrees(-21.75794210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180387"},
        {"Hipparcos Number", "HIP 94784"},
        {"Smithsonian Astrophysical Observation", "SAO 187917"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.29527149),
        dec: Angle.Degrees(-21.75670076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173229"},
        {"Hipparcos Number", "HIP 91998"},
        {"Smithsonian Astrophysical Observation", "SAO 187228"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26609973),
        dec: Angle.Degrees(-21.75643343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90498"},
        {"Hipparcos Number", "HIP 51114"},
        {"Smithsonian Astrophysical Observation", "SAO 178821"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.64618318),
        dec: Angle.Degrees(-21.75610283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12911"},
        {"Hipparcos Number", "HIP 9797"},
        {"Smithsonian Astrophysical Observation", "SAO 167549"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.49504227),
        dec: Angle.Degrees(-21.75576566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84609"},
        {"Hipparcos Number", "HIP 47910"},
        {"Smithsonian Astrophysical Observation", "SAO 177948"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.47818117),
        dec: Angle.Degrees(-21.75563027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14128",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2306 AB"},
        {"Henry Draper", "HD 18945"},
        {"Hipparcos Number", "HIP 14128"},
        {"Smithsonian Astrophysical Observation", "SAO 168244"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.55442138),
        dec: Angle.Degrees(-21.75126595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207691"},
        {"Hipparcos Number", "HIP 107873"},
        {"Smithsonian Astrophysical Observation", "SAO 190686"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.84393549),
        dec: Angle.Degrees(-21.75055140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97428"},
        {"Hipparcos Number", "HIP 54749"},
        {"Geneva Identification System", "GEN# +1.00097428"},
        {"Smithsonian Astrophysical Observation", "SAO 179638"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.14496693),
        dec: Angle.Degrees(-21.74935077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20261"},
        {"Hipparcos Number", "HIP 15101"},
        {"Smithsonian Astrophysical Observation", "SAO 168402"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.69969786),
        dec: Angle.Degrees(-21.74894301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138973"},
        {"Hipparcos Number", "HIP 76392"},
        {"Geneva Identification System", "GEN# +1.00138973"},
        {"Smithsonian Astrophysical Observation", "SAO 183608"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.03430518),
        dec: Angle.Degrees(-21.74628333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197711"},
        {"Henry Draper 2", "HD 197711A"},
        {"Hipparcos Number", "HIP 102486"},
        {"Geneva Identification System", "GEN# +1.00197711"},
        {"Smithsonian Astrophysical Observation", "SAO 189666"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.54010857),
        dec: Angle.Degrees(-21.74511345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43803"},
        {"Hipparcos Number", "HIP 29863"},
        {"Geneva Identification System", "GEN# +1.00043803"},
        {"Smithsonian Astrophysical Observation", "SAO 171510"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.32580566),
        dec: Angle.Degrees(-21.74253579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80841"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.63035986),
        dec: Angle.Degrees(-21.74199001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93683",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11996 A"},
        {"Henry Draper", "HD 177241"},
        {"Hipparcos Number", "HIP 93683"},
        {"Geneva Identification System", "GEN# +1.00177241"},
        {"Smithsonian Astrophysical Observation", "SAO 187643"},
        {"Wilson Evans Batten Catalogue", "WEB 16278"},
    },
    visualMagnitude: 3.76,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.17055765),
        dec: Angle.Degrees(-21.74135451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202578"},
        {"Hipparcos Number", "HIP 105083"},
        {"Geneva Identification System", "GEN# +1.00202578"},
        {"Smithsonian Astrophysical Observation", "SAO 190197"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.31511272),
        dec: Angle.Degrees(-21.74125631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16753 A"},
        {"Henry Draper", "HD 220766"},
        {"Hipparcos Number", "HIP 115709"},
        {"Smithsonian Astrophysical Observation", "SAO 191907"},
        {"Wilson Evans Batten Catalogue", "WEB 20477"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64765987),
        dec: Angle.Degrees(-21.74083208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175776"},
        {"Hipparcos Number", "HIP 93089"},
        {"Smithsonian Astrophysical Observation", "SAO 187506"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.44714603),
        dec: Angle.Degrees(-21.73953178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20572"},
        {"Smithsonian Astrophysical Observation", "SAO 169412"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.10641783),
        dec: Angle.Degrees(-21.73809272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112069"},
    },
    visualMagnitude: 10.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.49551676),
        dec: Angle.Degrees(-21.73627455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117082"},
        {"Hipparcos Number", "HIP 65705"},
        {"Smithsonian Astrophysical Observation", "SAO 181679"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.07162534),
        dec: Angle.Degrees(-21.73333357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144311"},
        {"Hipparcos Number", "HIP 78872"},
        {"Wilson Evans Batten Catalogue", "WEB 13332"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.50294804),
        dec: Angle.Degrees(-21.73320181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74143"},
    },
    visualMagnitude: 11.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26151349),
        dec: Angle.Degrees(-21.72993144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221870"},
        {"Hipparcos Number", "HIP 116447"},
        {"Smithsonian Astrophysical Observation", "SAO 192024"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.93924506),
        dec: Angle.Degrees(-21.72988742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7552"},
        {"Hipparcos Number", "HIP 5871"},
        {"Smithsonian Astrophysical Observation", "SAO 166909"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.84067805),
        dec: Angle.Degrees(-21.72934684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12486"},
        {"Hipparcos Number", "HIP 9484"},
        {"Smithsonian Astrophysical Observation", "SAO 167504"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.50508639),
        dec: Angle.Degrees(-21.72853543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88871"},
        {"Hipparcos Number", "HIP 50182"},
        {"Smithsonian Astrophysical Observation", "SAO 178562"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.65700658),
        dec: Angle.Degrees(-21.72817105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204313"},
        {"Hipparcos Number", "HIP 106006"},
        {"Geneva Identification System", "GEN# +1.00204313"},
        {"Smithsonian Astrophysical Observation", "SAO 190362"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.05075067),
        dec: Angle.Degrees(-21.72559552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134172"},
        {"Hipparcos Number", "HIP 74142"},
        {"Geneva Identification System", "GEN# +1.00134172"},
        {"Smithsonian Astrophysical Observation", "SAO 183216"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.25754743),
        dec: Angle.Degrees(-21.72540261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109350"},
        {"Hipparcos Number", "HIP 61350"},
        {"Renson", "Renson 31735"},
        {"Smithsonian Astrophysical Observation", "SAO 180911"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.55561233),
        dec: Angle.Degrees(-21.72425221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4622"},
        {"Hipparcos Number", "HIP 3741"},
        {"Fundamental Katalog 5th Edition", "FK5 1018"},
        {"Geneva Identification System", "GEN# +1.00004622"},
        {"Smithsonian Astrophysical Observation", "SAO 166585"},
        {"Wilson Evans Batten Catalogue", "WEB 667"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.00437854),
        dec: Angle.Degrees(-21.72247464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17679"},
        {"Hipparcos Number", "HIP 13190"},
        {"Smithsonian Astrophysical Observation", "SAO 168078"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.42913856),
        dec: Angle.Degrees(-21.71993902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7864",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1332 AB"},
        {"Henry Draper", "HD 10412"},
        {"Hipparcos Number", "HIP 7864"},
        {"Smithsonian Astrophysical Observation", "SAO 167228"},
    },
    visualMagnitude: 8.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.29157119),
        dec: Angle.Degrees(-21.71976931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163573"},
        {"Hipparcos Number", "HIP 87925"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.42067185),
        dec: Angle.Degrees(-21.71930029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207986"},
        {"Hipparcos Number", "HIP 108059"},
        {"Smithsonian Astrophysical Observation", "SAO 190715"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.40047579),
        dec: Angle.Degrees(-21.71826237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82359"},
        {"Hipparcos Number", "HIP 46665"},
        {"Smithsonian Astrophysical Observation", "SAO 177585"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.71780820),
        dec: Angle.Degrees(-21.71798916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33020"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.20064774),
        dec: Angle.Degrees(-21.71761279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205903"},
        {"Hipparcos Number", "HIP 106911"},
        {"Smithsonian Astrophysical Observation", "SAO 190522"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.78620129),
        dec: Angle.Degrees(-21.71378304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167036"},
        {"Hipparcos Number", "HIP 89369"},
        {"Geneva Identification System", "GEN# +1.00167036"},
        {"Smithsonian Astrophysical Observation", "SAO 186509"},
        {"Wilson Evans Batten Catalogue", "WEB 15200"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.56629234),
        dec: Angle.Degrees(-21.71310708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131367"},
        {"Hipparcos Number", "HIP 72878"},
        {"Smithsonian Astrophysical Observation", "SAO 182972"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.43172959),
        dec: Angle.Degrees(-21.71268603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66918"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.71093608),
        dec: Angle.Degrees(-21.71078542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -278.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55761"},
        {"Hipparcos Number", "HIP 34911"},
        {"Smithsonian Astrophysical Observation", "SAO 173229"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.34461835),
        dec: Angle.Degrees(-21.71046961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216334"},
        {"Hipparcos Number", "HIP 112936"},
        {"Smithsonian Astrophysical Observation", "SAO 191453"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.09911321),
        dec: Angle.Degrees(-21.70816330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222735"},
        {"Hipparcos Number", "HIP 117025"},
        {"Smithsonian Astrophysical Observation", "SAO 192108"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.85127995),
        dec: Angle.Degrees(-21.70648187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118348"},
        {"Hipparcos Number", "HIP 66407"},
        {"Smithsonian Astrophysical Observation", "SAO 181792"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.21511773),
        dec: Angle.Degrees(-21.70275895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90702"},
        {"Hipparcos Number", "HIP 51237"},
        {"Geneva Identification System", "GEN# +1.00090702"},
        {"Smithsonian Astrophysical Observation", "SAO 178849"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.98311935),
        dec: Angle.Degrees(-21.70167269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15575 AB"},
        {"Henry Draper", "HD 209385"},
        {"Hipparcos Number", "HIP 108893"},
        {"Renson", "Renson 58256"},
        {"Smithsonian Astrophysical Observation", "SAO 190854"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.86620873),
        dec: Angle.Degrees(-21.70160983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84803"},
        {"Hipparcos Number", "HIP 48005"},
        {"Geneva Identification System", "GEN# +1.00084803"},
        {"Smithsonian Astrophysical Observation", "SAO 177984"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.78283309),
        dec: Angle.Degrees(-21.70073034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67799"},
        {"Hipparcos Number", "HIP 39889"},
        {"Smithsonian Astrophysical Observation", "SAO 175259"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.21379147),
        dec: Angle.Degrees(-21.69989128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74644"},
        {"Hipparcos Number", "HIP 42894"},
        {"Smithsonian Astrophysical Observation", "SAO 176390"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.11876594),
        dec: Angle.Degrees(-21.69936332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51382"},
        {"Hipparcos Number", "HIP 33362"},
        {"Geneva Identification System", "GEN# +1.00051382"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.08121003),
        dec: Angle.Degrees(-21.69839891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19775"},
        {"Hipparcos Number", "HIP 14737"},
        {"Smithsonian Astrophysical Observation", "SAO 168348"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.57571078),
        dec: Angle.Degrees(-21.69419274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12860"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.31144672),
        dec: Angle.Degrees(-21.69060085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4527 A"},
        {"Henry Draper", "HD 40100"},
        {"Hipparcos Number", "HIP 28047"},
        {"Geneva Identification System", "GEN# +1.00040100"},
        {"Smithsonian Astrophysical Observation", "SAO 171023"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.97026624),
        dec: Angle.Degrees(-21.68918640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147911"},
        {"Hipparcos Number", "HIP 80458"},
        {"Geneva Identification System", "GEN# +1.00147911"},
        {"Smithsonian Astrophysical Observation", "SAO 184378"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.35046735),
        dec: Angle.Degrees(-21.68847541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30430"},
        {"Hipparcos Number", "HIP 22228"},
        {"Renson", "Renson 7850"},
        {"Smithsonian Astrophysical Observation", "SAO 169756"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.71207876),
        dec: Angle.Degrees(-21.68788782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221504"},
        {"Hipparcos Number", "HIP 116217"},
        {"Geneva Identification System", "GEN# +1.00221504"},
        {"Smithsonian Astrophysical Observation", "SAO 191982"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.21102184),
        dec: Angle.Degrees(-21.68766656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217815"},
        {"Hipparcos Number", "HIP 113865"},
        {"Smithsonian Astrophysical Observation", "SAO 191611"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.89121350),
        dec: Angle.Degrees(-21.68624923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160915"},
        {"Hipparcos Number", "HIP 86736"},
        {"Fundamental Katalog 5th Edition", "FK5 1463"},
        {"Geneva Identification System", "GEN# +1.00160915"},
        {"Smithsonian Astrophysical Observation", "SAO 185660"},
        {"Wilson Evans Batten Catalogue", "WEB 14624"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.85772897),
        dec: Angle.Degrees(-21.68308566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201203"},
        {"Hipparcos Number", "HIP 104367"},
        {"Geneva Identification System", "GEN# +1.00201203"},
        {"Smithsonian Astrophysical Observation", "SAO 190052"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.15372050),
        dec: Angle.Degrees(-21.68301039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11899"},
        {"Smithsonian Astrophysical Observation", "SAO 167876"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.38937373),
        dec: Angle.Degrees(-21.67844583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49754"},
        {"Smithsonian Astrophysical Observation", "SAO 178476"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.34534075),
        dec: Angle.Degrees(-21.66270754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190617"},
        {"Hipparcos Number", "HIP 99046"},
        {"Geneva Identification System", "GEN# +1.00190617"},
        {"Smithsonian Astrophysical Observation", "SAO 188917"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.63635972),
        dec: Angle.Degrees(-21.67657817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16868 AB"},
        {"Henry Draper", "HD 222011"},
        {"Hipparcos Number", "HIP 116533"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.26099267),
        dec: Angle.Degrees(-21.67583050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165131"},
        {"Hipparcos Number", "HIP 88595"},
        {"Smithsonian Astrophysical Observation", "SAO 186253"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.34485371),
        dec: Angle.Degrees(-21.67286791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2257"},
        {"Hipparcos Number", "HIP 2079"},
        {"Geneva Identification System", "GEN# +1.00002257"},
        {"Smithsonian Astrophysical Observation", "SAO 166267"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.56711626),
        dec: Angle.Degrees(-21.67275336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128832"},
        {"Hipparcos Number", "HIP 71689"},
        {"Smithsonian Astrophysical Observation", "SAO 182745"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.96488334),
        dec: Angle.Degrees(-21.67274905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222194"},
        {"Hipparcos Number", "HIP 116661"},
        {"Smithsonian Astrophysical Observation", "SAO 192055"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.61659042),
        dec: Angle.Degrees(-21.67265074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26057"},
        {"Hipparcos Number", "HIP 19191"},
        {"Smithsonian Astrophysical Observation", "SAO 169131"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.68784413),
        dec: Angle.Degrees(-21.67182297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88198"},
        {"Hipparcos Number", "HIP 49785"},
        {"Smithsonian Astrophysical Observation", "SAO 178484"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.44057708),
        dec: Angle.Degrees(-21.67127996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150309"},
        {"Hipparcos Number", "HIP 81668"},
        {"Smithsonian Astrophysical Observation", "SAO 184542"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.24534746),
        dec: Angle.Degrees(-21.67003789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207302"},
        {"Hipparcos Number", "HIP 107661"},
        {"Smithsonian Astrophysical Observation", "SAO 190640"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.11419704),
        dec: Angle.Degrees(-21.66918653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32324"},
        {"Hipparcos Number", "HIP 23373"},
        {"Smithsonian Astrophysical Observation", "SAO 169985"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.37521400),
        dec: Angle.Degrees(-21.66420727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169038"},
        {"Hipparcos Number", "HIP 90130"},
        {"Smithsonian Astrophysical Observation", "SAO 186757"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.89554631),
        dec: Angle.Degrees(-21.66398810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108061"},
        {"Hipparcos Number", "HIP 60579"},
        {"Smithsonian Astrophysical Observation", "SAO 180781"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.25185287),
        dec: Angle.Degrees(-21.66327670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206274"},
        {"Hipparcos Number", "HIP 107093"},
        {"Smithsonian Astrophysical Observation", "SAO 190553"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.38705776),
        dec: Angle.Degrees(-21.66310293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203911"},
        {"Hipparcos Number", "HIP 105806"},
        {"Geneva Identification System", "GEN# +1.00203911"},
        {"Smithsonian Astrophysical Observation", "SAO 190325"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.42260002),
        dec: Angle.Degrees(-21.66284786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31259"},
        {"Hipparcos Number", "HIP 22731"},
        {"Smithsonian Astrophysical Observation", "SAO 169851"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.34815054),
        dec: Angle.Degrees(-21.66208469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122492"},
        {"Hipparcos Number", "HIP 68609"},
        {"Smithsonian Astrophysical Observation", "SAO 182188"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.66741563),
        dec: Angle.Degrees(-21.66168267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17350"},
        {"Hipparcos Number", "HIP 12941"},
        {"Geneva Identification System", "GEN# +1.00017350"},
        {"Smithsonian Astrophysical Observation", "SAO 168038"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.60868380),
        dec: Angle.Degrees(-21.66104727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27103",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4339 A"},
        {"Henry Draper", "HD 38426"},
        {"Hipparcos Number", "HIP 27103"},
        {"Smithsonian Astrophysical Observation", "SAO 170770"},
        {"Wilson Evans Batten Catalogue", "WEB 5332"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.21112958),
        dec: Angle.Degrees(-21.65922473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103616"},
        {"Hipparcos Number", "HIP 58172"},
        {"Geneva Identification System", "GEN# +1.00103616"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.96418251),
        dec: Angle.Degrees(-21.65911237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207081"},
        {"Hipparcos Number", "HIP 107562"},
        {"Smithsonian Astrophysical Observation", "SAO 190621"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.77765236),
        dec: Angle.Degrees(-21.65864930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4050"},
        {"Hipparcos Number", "HIP 3368"},
        {"Fundamental Katalog 5th Edition", "FK5 4061"},
        {"Smithsonian Astrophysical Observation", "SAO 166507"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.71031812),
        dec: Angle.Degrees(-21.65845728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47103"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.00645894),
        dec: Angle.Degrees(-21.65839234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -989.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179201"},
        {"Hipparcos Number", "HIP 94372"},
        {"Geneva Identification System", "GEN# +1.00179201"},
        {"Smithsonian Astrophysical Observation", "SAO 187816"},
        {"Wilson Evans Batten Catalogue", "WEB 16442"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.11674670),
        dec: Angle.Degrees(-21.65832764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215081"},
        {"Hipparcos Number", "HIP 112162"},
        {"Fundamental Katalog 5th Edition", "FK5 6002"},
        {"Smithsonian Astrophysical Observation", "SAO 191349"},
        {"Wilson Evans Batten Catalogue", "WEB 20012"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75700287),
        dec: Angle.Degrees(-21.65751822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116963"},
        {"Hipparcos Number", "HIP 65636"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.85438455),
        dec: Angle.Degrees(-21.65529304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34122"},
        {"Hipparcos Number", "HIP 24401"},
        {"Smithsonian Astrophysical Observation", "SAO 170218"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.51873801),
        dec: Angle.Degrees(-21.64999324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118108"},
        {"Smithsonian Astrophysical Observation", "SAO 192265"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.37019200),
        dec: Angle.Degrees(-21.64784283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51496"},
        {"Geneva Identification System", "GEN# -0.02003198"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)31, 02.7000),
        dec: Angle.DegreesMinutesSeconds((int)-21, (int)38, 48.000)
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
    primaryId: "HIP 95193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181581"},
        {"Hipparcos Number", "HIP 95193"},
        {"Smithsonian Astrophysical Observation", "SAO 188027"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.47293682),
        dec: Angle.Degrees(-21.64422166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187367"},
        {"Hipparcos Number", "HIP 97610"},
        {"Smithsonian Astrophysical Observation", "SAO 188615"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.58727062),
        dec: Angle.Degrees(-21.64247083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221894"},
        {"Hipparcos Number", "HIP 116467"},
        {"Smithsonian Astrophysical Observation", "SAO 192027"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.98714059),
        dec: Angle.Degrees(-21.64225458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157380"},
        {"Hipparcos Number", "HIP 85121"},
        {"Smithsonian Astrophysical Observation", "SAO 185355"},
    },
    visualMagnitude: 8.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95113952),
        dec: Angle.Degrees(-21.64095501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17390"},
        {"Hipparcos Number", "HIP 12964"},
        {"Geneva Identification System", "GEN# +1.00017390"},
        {"Smithsonian Astrophysical Observation", "SAO 168045"},
        {"Wilson Evans Batten Catalogue", "WEB 2623"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.68773623),
        dec: Angle.Degrees(-21.63956244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67375"},
        {"Hipparcos Number", "HIP 39698"},
        {"Geneva Identification System", "GEN# +1.00067375"},
        {"Smithsonian Astrophysical Observation", "SAO 175190"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.70262267),
        dec: Angle.Degrees(-21.63858195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103014"},
        {"Hipparcos Number", "HIP 57827"},
        {"Geneva Identification System", "GEN# +1.00103014"},
        {"Smithsonian Astrophysical Observation", "SAO 180244"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.88683917),
        dec: Angle.Degrees(-21.63575493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87505"},
        {"Hipparcos Number", "HIP 49388"},
        {"Smithsonian Astrophysical Observation", "SAO 178379"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.23979986),
        dec: Angle.Degrees(-21.63538567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106255"},
        {"Hipparcos Number", "HIP 59623"},
        {"Smithsonian Astrophysical Observation", "SAO 180580"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.40460388),
        dec: Angle.Degrees(-21.63470476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198156"},
        {"Hipparcos Number", "HIP 102743"},
        {"Smithsonian Astrophysical Observation", "SAO 189731"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.27774266),
        dec: Angle.Degrees(-21.63318949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22203"},
        {"Hipparcos Number", "HIP 16611"},
        {"Fundamental Katalog 5th Edition", "FK5 1099"},
        {"Geneva Identification System", "GEN# +1.00022203"},
        {"Smithsonian Astrophysical Observation", "SAO 168634"},
        {"Wilson Evans Batten Catalogue", "WEB 3169"},
    },
    visualMagnitude: 4.26,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.44686638),
        dec: Angle.Degrees(-21.63281597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224108"},
        {"Hipparcos Number", "HIP 117929"},
        {"Geneva Identification System", "GEN# +1.00224108"},
        {"Smithsonian Astrophysical Observation", "SAO 192236"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.81234947),
        dec: Angle.Degrees(-21.63267149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157691"},
        {"Hipparcos Number", "HIP 85285"},
        {"Smithsonian Astrophysical Observation", "SAO 185389"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.40259256),
        dec: Angle.Degrees(-21.63169752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2178"},
        {"Hipparcos Number", "HIP 2027"},
        {"Geneva Identification System", "GEN# +1.00002178"},
        {"Smithsonian Astrophysical Observation", "SAO 166260"},
        {"Wilson Evans Batten Catalogue", "WEB 387"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.42714243),
        dec: Angle.Degrees(-21.63148935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215797"},
        {"Hipparcos Number", "HIP 112578"},
        {"Geneva Identification System", "GEN# +1.00215797"},
        {"Smithsonian Astrophysical Observation", "SAO 191415"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.02515627),
        dec: Angle.Degrees(-21.62938961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1184 A"},
        {"Henry Draper", "HD 9132"},
        {"Hipparcos Number", "HIP 6960"},
        {"Fundamental Katalog 5th Edition", "FK5 1043"},
        {"Geneva Identification System", "GEN# +1.00009132"},
        {"Smithsonian Astrophysical Observation", "SAO 167086"},
        {"Wilson Evans Batten Catalogue", "WEB 1508"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.40041765),
        dec: Angle.Degrees(-21.62934677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56339"},
        {"Hipparcos Number", "HIP 35141"},
        {"Smithsonian Astrophysical Observation", "SAO 173320"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96387209),
        dec: Angle.Degrees(-21.62866221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208754"},
        {"Hipparcos Number", "HIP 108510"},
        {"Smithsonian Astrophysical Observation", "SAO 190788"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.73913040),
        dec: Angle.Degrees(-21.62577473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217356"},
        {"Hipparcos Number", "HIP 113586"},
        {"Smithsonian Astrophysical Observation", "SAO 191564"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.09018787),
        dec: Angle.Degrees(-21.62312207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223921"},
        {"Hipparcos Number", "HIP 117821"},
        {"Smithsonian Astrophysical Observation", "SAO 192223"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.43187710),
        dec: Angle.Degrees(-21.62163137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8039",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1358 A"},
        {"Henry Draper", "HD 10611"},
        {"Hipparcos Number", "HIP 8039"},
        {"Smithsonian Astrophysical Observation", "SAO 167249"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.80956779),
        dec: Angle.Degrees(-21.61974631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2827"},
        {"Geneva Identification System", "GEN# -0.02200099"},
        {"Smithsonian Astrophysical Observation", "SAO 166394"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.97043429),
        dec: Angle.Degrees(-21.61911053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6766"},
        {"Hipparcos Number", "HIP 5323"},
        {"Smithsonian Astrophysical Observation", "SAO 166827"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.01882159),
        dec: Angle.Degrees(-21.61619791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1358 B"},
        {"Henry Draper", "HD 10611B"},
        {"Hipparcos Number", "HIP 8038"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.80892640),
        dec: Angle.Degrees(-21.61563186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223429"},
        {"Hipparcos Number", "HIP 117488"},
        {"Fundamental Katalog 5th Edition", "FK5 1624"},
        {"Smithsonian Astrophysical Observation", "SAO 192176"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.35818775),
        dec: Angle.Degrees(-21.61399226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 860"},
        {"Henry Draper", "HD 6156"},
        {"Hipparcos Number", "HIP 4855"},
        {"Geneva Identification System", "GEN# +1.00006156J"},
        {"Smithsonian Astrophysical Observation", "SAO 166761"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.61490694),
        dec: Angle.Degrees(-21.61050013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6124"},
        {"Hipparcos Number", "HIP 4835"},
        {"Smithsonian Astrophysical Observation", "SAO 166759"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.54614811),
        dec: Angle.Degrees(-21.60904418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218432"},
        {"Hipparcos Number", "HIP 114246"},
        {"Smithsonian Astrophysical Observation", "SAO 191673"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07253866),
        dec: Angle.Degrees(-21.60725541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4158"},
        {"Smithsonian Astrophysical Observation", "SAO 166650"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.28237833),
        dec: Angle.Degrees(-21.60719190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80317"},
        {"Hipparcos Number", "HIP 45666"},
        {"Smithsonian Astrophysical Observation", "SAO 177247"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.62778721),
        dec: Angle.Degrees(-21.60627109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155469"},
        {"Hipparcos Number", "HIP 84198"},
        {"Geneva Identification System", "GEN# +1.00155469"},
        {"Smithsonian Astrophysical Observation", "SAO 185150"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.16461722),
        dec: Angle.Degrees(-21.60604385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96723"},
        {"Smithsonian Astrophysical Observation", "SAO 188406"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.93420611),
        dec: Angle.Degrees(-21.60597336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131291"},
        {"Hipparcos Number", "HIP 72840"},
        {"Fundamental Katalog 5th Edition", "FK5 5319"},
        {"Geneva Identification System", "GEN# +1.00131291"},
        {"Smithsonian Astrophysical Observation", "SAO 182964"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.32570520),
        dec: Angle.Degrees(-21.60464880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139765"},
        {"Hipparcos Number", "HIP 76790"},
        {"Smithsonian Astrophysical Observation", "SAO 183696"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.18298241),
        dec: Angle.Degrees(-21.60459724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52273"},
        {"Hipparcos Number", "HIP 33666"},
        {"Celescope Catalog", "CEL 1483"},
        {"Geneva Identification System", "GEN# +1.00052273"},
        {"Smithsonian Astrophysical Observation", "SAO 172700"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.91356967),
        dec: Angle.Degrees(-21.60289593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1245"},
        {"Hipparcos Number", "HIP 1323"},
        {"Geneva Identification System", "GEN# +1.00001245"},
        {"Smithsonian Astrophysical Observation", "SAO 166165"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.15588905),
        dec: Angle.Degrees(-21.60054162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125716"},
        {"Hipparcos Number", "HIP 70197"},
        {"Geneva Identification System", "GEN# +1.00125716"},
        {"Smithsonian Astrophysical Observation", "SAO 182466"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.43518587),
        dec: Angle.Degrees(-21.59918906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213487"},
        {"Hipparcos Number", "HIP 111225"},
        {"Geneva Identification System", "GEN# +1.00213487"},
        {"Smithsonian Astrophysical Observation", "SAO 191209"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.01375982),
        dec: Angle.Degrees(-21.59906431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212562"},
        {"Hipparcos Number", "HIP 110693"},
        {"Smithsonian Astrophysical Observation", "SAO 191128"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.40678325),
        dec: Angle.Degrees(-21.59854592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212010"},
        {"Hipparcos Number", "HIP 110391"},
        {"Fundamental Katalog 5th Edition", "FK5 1584"},
        {"Geneva Identification System", "GEN# +1.00212010"},
        {"Smithsonian Astrophysical Observation", "SAO 191083"},
        {"Wilson Evans Batten Catalogue", "WEB 19797"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.39823108),
        dec: Angle.Degrees(-21.59802435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20451"},
        {"Smithsonian Astrophysical Observation", "SAO 169386"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.72271092),
        dec: Angle.Degrees(-21.59739302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212399"},
        {"Hipparcos Number", "HIP 110590"},
        {"Smithsonian Astrophysical Observation", "SAO 191115"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.06786979),
        dec: Angle.Degrees(-21.59715683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219244"},
        {"Hipparcos Number", "HIP 114747"},
        {"Smithsonian Astrophysical Observation", "SAO 191748"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.66123311),
        dec: Angle.Degrees(-21.59623264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24785"},
        {"Hipparcos Number", "HIP 18373"},
        {"Geneva Identification System", "GEN# +1.00024785"},
        {"Smithsonian Astrophysical Observation", "SAO 168959"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91220001),
        dec: Angle.Degrees(-21.59606546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210016"},
        {"Hipparcos Number", "HIP 109241"},
        {"Geneva Identification System", "GEN# +1.00210016"},
        {"Smithsonian Astrophysical Observation", "SAO 190907"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.96267276),
        dec: Angle.Degrees(-21.59298594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146743"},
        {"Hipparcos Number", "HIP 79910"},
        {"Geneva Identification System", "GEN# +1.00146743"},
        {"Smithsonian Astrophysical Observation", "SAO 184306"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.66312696),
        dec: Angle.Degrees(-21.59278638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193602"},
        {"Hipparcos Number", "HIP 100423"},
        {"Smithsonian Astrophysical Observation", "SAO 189199"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.45021253),
        dec: Angle.Degrees(-21.59076570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89280"},
        {"Hipparcos Number", "HIP 50417"},
        {"Smithsonian Astrophysical Observation", "SAO 178630"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.41746566),
        dec: Angle.Degrees(-21.58899220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145390"},
        {"Hipparcos Number", "HIP 79335"},
        {"Smithsonian Astrophysical Observation", "SAO 184207"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.87243854),
        dec: Angle.Degrees(-21.58711473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214136"},
        {"Hipparcos Number", "HIP 111596"},
        {"Smithsonian Astrophysical Observation", "SAO 191264"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.12951512),
        dec: Angle.Degrees(-21.58495215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23506"},
        {"Hipparcos Number", "HIP 17508"},
        {"Smithsonian Astrophysical Observation", "SAO 168791"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.23777291),
        dec: Angle.Degrees(-21.58321467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36058"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47085085),
        dec: Angle.Degrees(-21.58319597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83844"},
        {"Hipparcos Number", "HIP 47472"},
        {"Smithsonian Astrophysical Observation", "SAO 177828"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.15884162),
        dec: Angle.Degrees(-21.58166171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142768"},
        {"Hipparcos Number", "HIP 78123"},
        {"Smithsonian Astrophysical Observation", "SAO 183967"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.28369602),
        dec: Angle.Degrees(-21.58049076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77543"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.49437780),
        dec: Angle.Degrees(-21.58028648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3693"},
        {"Hipparcos Number", "HIP 3118"},
        {"Smithsonian Astrophysical Observation", "SAO 166461"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.91524845),
        dec: Angle.Degrees(-21.57913787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16752"},
        {"Hipparcos Number", "HIP 12480"},
        {"Geneva Identification System", "GEN# +1.00016752"},
        {"Smithsonian Astrophysical Observation", "SAO 167966"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15694624),
        dec: Angle.Degrees(-21.57832023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67882"},
        {"Hipparcos Number", "HIP 39926"},
        {"Geneva Identification System", "GEN# +1.00067882"},
        {"Smithsonian Astrophysical Observation", "SAO 175271"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.31479382),
        dec: Angle.Degrees(-21.57633375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23927"},
        {"Hipparcos Number", "HIP 17761"},
        {"Geneva Identification System", "GEN# +1.00023927"},
        {"Smithsonian Astrophysical Observation", "SAO 168842"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.03551563),
        dec: Angle.Degrees(-21.57604664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57526"},
        {"Hipparcos Number", "HIP 35608"},
        {"Geneva Identification System", "GEN# +1.00057526"},
        {"Renson", "Renson 15710"},
        {"Smithsonian Astrophysical Observation", "SAO 173514"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.21968610),
        dec: Angle.Degrees(-21.57507065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31159"},
        {"Hipparcos Number", "HIP 22671"},
        {"Smithsonian Astrophysical Observation", "SAO 169833"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14546631),
        dec: Angle.Degrees(-21.57370129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15495"},
        {"Hipparcos Number", "HIP 11566"},
        {"Smithsonian Astrophysical Observation", "SAO 167820"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.25726172),
        dec: Angle.Degrees(-21.57234972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135811"},
        {"Hipparcos Number", "HIP 74849"},
        {"Smithsonian Astrophysical Observation", "SAO 183348"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.43328065),
        dec: Angle.Degrees(-21.57154443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74965"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.78573274),
        dec: Angle.Degrees(-21.57149935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24753"},
        {"Hipparcos Number", "HIP 18349"},
        {"Smithsonian Astrophysical Observation", "SAO 168953"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.84169795),
        dec: Angle.Degrees(-21.57134665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10257 AB"},
        {"Henry Draper", "HD 152655"},
        {"Hipparcos Number", "HIP 82822"},
        {"Geneva Identification System", "GEN# +1.00152655"},
        {"Smithsonian Astrophysical Observation", "SAO 184804"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.88558952),
        dec: Angle.Degrees(-21.56949817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148516"},
        {"Hipparcos Number", "HIP 80756"},
        {"Geneva Identification System", "GEN# +1.00148516"},
        {"Smithsonian Astrophysical Observation", "SAO 184416"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.33193453),
        dec: Angle.Degrees(-21.56890614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6515"},
        {"Hipparcos Number", "HIP 5143"},
        {"Geneva Identification System", "GEN# +1.00006515"},
        {"Smithsonian Astrophysical Observation", "SAO 166794"},
        {"Wilson Evans Batten Catalogue", "WEB 1069"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.46315088),
        dec: Angle.Degrees(-21.56647665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142287"},
        {"Hipparcos Number", "HIP 77895"},
        {"Smithsonian Astrophysical Observation", "SAO 183910"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.61160861),
        dec: Angle.Degrees(-21.56508318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154418"},
        {"Hipparcos Number", "HIP 83684"},
        {"Fundamental Katalog 5th Edition", "FK5 3358"},
        {"Geneva Identification System", "GEN# +1.00154418"},
        {"Renson", "Renson 43640"},
        {"Smithsonian Astrophysical Observation", "SAO 185024"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54919394),
        dec: Angle.Degrees(-21.56440204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71398"},
        {"Hipparcos Number", "HIP 41381"},
        {"Smithsonian Astrophysical Observation", "SAO 175826"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.63445915),
        dec: Angle.Degrees(-21.56270556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189540"},
        {"Hipparcos Number", "HIP 98559"},
        {"Smithsonian Astrophysical Observation", "SAO 188825"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.30620255),
        dec: Angle.Degrees(-21.55925810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107427"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37365017),
        dec: Angle.Degrees(-21.55829512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8984"},
        {"Hipparcos Number", "HIP 6853"},
        {"Smithsonian Astrophysical Observation", "SAO 167067"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02989077),
        dec: Angle.Degrees(-21.55773987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13575"},
        {"Hipparcos Number", "HIP 10264"},
        {"Smithsonian Astrophysical Observation", "SAO 167625"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.02078112),
        dec: Angle.Degrees(-21.55748118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199431"},
        {"Hipparcos Number", "HIP 103469"},
        {"Smithsonian Astrophysical Observation", "SAO 189879"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.44407732),
        dec: Angle.Degrees(-21.55657628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100061"},
        {"Hipparcos Number", "HIP 56161"},
        {"Geneva Identification System", "GEN# +1.00100061"},
        {"Smithsonian Astrophysical Observation", "SAO 179946"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.68833816),
        dec: Angle.Degrees(-21.55496804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171201"},
        {"Hipparcos Number", "HIP 91046"},
        {"Geneva Identification System", "GEN# +1.00171201"},
        {"Smithsonian Astrophysical Observation", "SAO 186992"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.58616097),
        dec: Angle.Degrees(-21.55367711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45536"},
        {"Hipparcos Number", "HIP 30707"},
        {"Smithsonian Astrophysical Observation", "SAO 171764"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.78570438),
        dec: Angle.Degrees(-21.55252790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2247"},
        {"Hipparcos Number", "HIP 2069"},
        {"Smithsonian Astrophysical Observation", "SAO 166266"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.54755358),
        dec: Angle.Degrees(-21.54855113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112709"},
        {"Hipparcos Number", "HIP 63359"},
        {"Smithsonian Astrophysical Observation", "SAO 181284"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.74051915),
        dec: Angle.Degrees(-21.54668947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182578"},
        {"Hipparcos Number", "HIP 95554"},
        {"Smithsonian Astrophysical Observation", "SAO 188118"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52976674),
        dec: Angle.Degrees(-21.54424856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40537"},
        {"Hipparcos Number", "HIP 28284"},
        {"Geneva Identification System", "GEN# +1.00040537"},
        {"Smithsonian Astrophysical Observation", "SAO 171090"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.64740112),
        dec: Angle.Degrees(-21.54399249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37905"},
        {"Hipparcos Number", "HIP 26747"},
        {"Geneva Identification System", "GEN# +1.00037905"},
        {"Smithsonian Astrophysical Observation", "SAO 170686"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24783006),
        dec: Angle.Degrees(-21.54383316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8844 AB"},
        {"Henry Draper", "HD 115428"},
        {"Hipparcos Number", "HIP 64829"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.34937052),
        dec: Angle.Degrees(-21.53797565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200331"},
        {"Hipparcos Number", "HIP 103927"},
        {"Smithsonian Astrophysical Observation", "SAO 189971"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.84987610),
        dec: Angle.Degrees(-21.53686518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46721"},
        {"Hipparcos Number", "HIP 31322"},
        {"Smithsonian Astrophysical Observation", "SAO 171959"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.52893318),
        dec: Angle.Degrees(-21.53612818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181340"},
        {"Hipparcos Number", "HIP 95105"},
        {"Smithsonian Astrophysical Observation", "SAO 187999"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22228735),
        dec: Angle.Degrees(-21.53563649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220322"},
        {"Hipparcos Number", "HIP 115436"},
        {"Smithsonian Astrophysical Observation", "SAO 191857"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.73989599),
        dec: Angle.Degrees(-21.53515850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8312"},
        {"Hipparcos Number", "HIP 6388"},
        {"Geneva Identification System", "GEN# +1.00008312"},
        {"Smithsonian Astrophysical Observation", "SAO 166993"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.52411375),
        dec: Angle.Degrees(-21.53394958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78130"},
        {"Hipparcos Number", "HIP 44657"},
        {"Geneva Identification System", "GEN# +1.00078130"},
        {"Smithsonian Astrophysical Observation", "SAO 176946"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.48986124),
        dec: Angle.Degrees(-21.53254916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58629",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8394 AB"},
        {"Henry Draper", "HD 104415"},
        {"Hipparcos Number", "HIP 58629"},
        {"Wilson Evans Batten Catalogue", "WEB 10460"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.34834931),
        dec: Angle.Degrees(-21.53251444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11989 AB"},
        {"Henry Draper", "HD 177166"},
        {"Hipparcos Number", "HIP 93661"},
        {"Geneva Identification System", "GEN# +1.00177166J"},
        {"Smithsonian Astrophysical Observation", "SAO 187634"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.08437483),
        dec: Angle.Degrees(-21.53136030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10467 AB"},
        {"Henry Draper", "HD 156701"},
        {"Hipparcos Number", "HIP 84798"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.99351129),
        dec: Angle.Degrees(-21.53068233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41973"},
        {"Hipparcos Number", "HIP 29007"},
        {"Geneva Identification System", "GEN# +1.00041973"},
        {"Smithsonian Astrophysical Observation", "SAO 171259"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.81300876),
        dec: Angle.Degrees(-21.52980561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90243"},
        {"Hipparcos Number", "HIP 50974"},
        {"Renson", "Renson 25950"},
        {"Smithsonian Astrophysical Observation", "SAO 178784"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.17913394),
        dec: Angle.Degrees(-21.52843795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130712"},
        {"Hipparcos Number", "HIP 72562"},
        {"Smithsonian Astrophysical Observation", "SAO 182912"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.55519033),
        dec: Angle.Degrees(-21.52628450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108839"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72499174),
        dec: Angle.Degrees(-21.52554771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187331"},
        {"Hipparcos Number", "HIP 97588"},
        {"Smithsonian Astrophysical Observation", "SAO 188610"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.53277697),
        dec: Angle.Degrees(-21.52433009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7947 A"},
        {"Henry Draper", "HD 94073"},
        {"Hipparcos Number", "HIP 53050"},
        {"Smithsonian Astrophysical Observation", "SAO 179272"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.81074782),
        dec: Angle.Degrees(-21.52430397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12887 AB"},
        {"Henry Draper", "HD 186666"},
        {"Hipparcos Number", "HIP 97301"},
        {"Renson", "Renson 51460"},
        {"Smithsonian Astrophysical Observation", "SAO 188551"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.62660480),
        dec: Angle.Degrees(-21.52300930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113566"},
        {"Hipparcos Number", "HIP 63827"},
        {"Smithsonian Astrophysical Observation", "SAO 181370"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.21899879),
        dec: Angle.Degrees(-21.51980360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96696"},
        {"Hipparcos Number", "HIP 54420"},
        {"Smithsonian Astrophysical Observation", "SAO 179565"},
        {"Wilson Evans Batten Catalogue", "WEB 9827"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.04248504),
        dec: Angle.Degrees(-21.51861586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183841"},
        {"Hipparcos Number", "HIP 96096"},
        {"Renson", "Renson 50773"},
        {"Smithsonian Astrophysical Observation", "SAO 188252"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.06582794),
        dec: Angle.Degrees(-21.51687526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197725"},
        {"Hipparcos Number", "HIP 102487"},
        {"Fundamental Katalog 5th Edition", "FK5 3659"},
        {"Geneva Identification System", "GEN# +1.00197725"},
        {"Smithsonian Astrophysical Observation", "SAO 189667"},
        {"Wilson Evans Batten Catalogue", "WEB 18563"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.54155712),
        dec: Angle.Degrees(-21.51399111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11023"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.49130561),
        dec: Angle.Degrees(-21.51186588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161487"},
        {"Hipparcos Number", "HIP 86998"},
        {"Smithsonian Astrophysical Observation", "SAO 185737"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66804117),
        dec: Angle.Degrees(-21.51119561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223143"},
        {"Hipparcos Number", "HIP 117307"},
        {"Smithsonian Astrophysical Observation", "SAO 192149"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.79080973),
        dec: Angle.Degrees(-21.50983341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147083"},
        {"Hipparcos Number", "HIP 80059"},
        {"Geneva Identification System", "GEN# +1.00147083"},
        {"Smithsonian Astrophysical Observation", "SAO 184326"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.11723913),
        dec: Angle.Degrees(-21.50896008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188375"},
        {"Hipparcos Number", "HIP 98050"},
        {"Geneva Identification System", "GEN# +1.00188375"},
        {"Smithsonian Astrophysical Observation", "SAO 188720"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.88186206),
        dec: Angle.Degrees(-21.50840550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28222"},
        {"Hipparcos Number", "HIP 20717"},
        {"Smithsonian Astrophysical Observation", "SAO 169444"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.59558051),
        dec: Angle.Degrees(-21.50762166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121270"},
        {"Hipparcos Number", "HIP 67945"},
        {"Geneva Identification System", "GEN# +1.00121270"},
        {"Smithsonian Astrophysical Observation", "SAO 182072"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.71325100),
        dec: Angle.Degrees(-21.50685154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62678"},
        {"Hipparcos Number", "HIP 37743"},
        {"Geneva Identification System", "GEN# +1.00062678"},
        {"Wilson Evans Batten Catalogue", "WEB 7460"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.12259178),
        dec: Angle.Degrees(-21.50677880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51340"},
        {"Hipparcos Number", "HIP 33343"},
        {"Celescope Catalog", "CEL 1445"},
        {"Geneva Identification System", "GEN# +1.00051340J"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.01811010),
        dec: Angle.Degrees(-21.50592278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87000"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66977775),
        dec: Angle.Degrees(-21.50539034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165446"},
        {"Hipparcos Number", "HIP 88730"},
        {"Geneva Identification System", "GEN# +1.00165446"},
        {"Smithsonian Astrophysical Observation", "SAO 186294"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.71331197),
        dec: Angle.Degrees(-21.50533068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3247"},
        {"Henry Draper", "HD 28396"},
        {"Hipparcos Number", "HIP 20836"},
        {"Smithsonian Astrophysical Observation", "SAO 169475"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.98074092),
        dec: Angle.Degrees(-21.50394549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205577"},
        {"Hipparcos Number", "HIP 106699"},
        {"Smithsonian Astrophysical Observation", "SAO 190487"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.18187279),
        dec: Angle.Degrees(-21.50271481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171"},
        {"Hipparcos Number", "HIP 537"},
        {"Geneva Identification System", "GEN# +1.00000171"},
        {"Smithsonian Astrophysical Observation", "SAO 166047"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.63047980),
        dec: Angle.Degrees(-21.50128389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42915"},
        {"Hipparcos Number", "HIP 29470"},
        {"Smithsonian Astrophysical Observation", "SAO 171382"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.13455262),
        dec: Angle.Degrees(-21.49828022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127151"},
        {"Hipparcos Number", "HIP 70932"},
        {"Smithsonian Astrophysical Observation", "SAO 182607"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.60200908),
        dec: Angle.Degrees(-21.49781765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95628"},
        {"Hipparcos Number", "HIP 53922"},
        {"Geneva Identification System", "GEN# +1.00095628"},
        {"Smithsonian Astrophysical Observation", "SAO 179448"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.50713829),
        dec: Angle.Degrees(-21.49731118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180332"},
        {"Hipparcos Number", "HIP 94765"},
        {"Smithsonian Astrophysical Observation", "SAO 187913"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24107807),
        dec: Angle.Degrees(-21.49617420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171771"},
        {"Hipparcos Number", "HIP 91304"},
        {"Renson", "Renson 48120"},
        {"Smithsonian Astrophysical Observation", "SAO 187061"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.36546829),
        dec: Angle.Degrees(-21.49601527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75944"},
        {"Hipparcos Number", "HIP 43572"},
        {"Smithsonian Astrophysical Observation", "SAO 176608"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.10518382),
        dec: Angle.Degrees(-21.49253704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141466"},
        {"Hipparcos Number", "HIP 77539"},
        {"Smithsonian Astrophysical Observation", "SAO 183837"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.48572422),
        dec: Angle.Degrees(-21.49068913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38978",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6495 A"},
        {"Henry Draper", "HD 65566"},
        {"Hipparcos Number", "HIP 38978"},
        {"Geneva Identification System", "GEN# +1.00065566"},
        {"Smithsonian Astrophysical Observation", "SAO 174906"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.64276665),
        dec: Angle.Degrees(-21.48773384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142805"},
        {"Hipparcos Number", "HIP 78129"},
        {"Geneva Identification System", "GEN# +1.00142805"},
        {"Smithsonian Astrophysical Observation", "SAO 183969"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.30285266),
        dec: Angle.Degrees(-21.48564747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101017"},
        {"Hipparcos Number", "HIP 56684"},
        {"Smithsonian Astrophysical Observation", "SAO 180043"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.34007522),
        dec: Angle.Degrees(-21.46336482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158596"},
        {"Hipparcos Number", "HIP 85724"},
        {"Geneva Identification System", "GEN# +1.00158596"},
        {"Renson", "Renson 44630"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.76445093),
        dec: Angle.Degrees(-21.48526040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186056"},
        {"Hipparcos Number", "HIP 97004"},
        {"Smithsonian Astrophysical Observation", "SAO 188478"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.74291741),
        dec: Angle.Degrees(-21.48304677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7663"},
        {"Hipparcos Number", "HIP 5924"},
        {"Smithsonian Astrophysical Observation", "SAO 166918"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.04602146),
        dec: Angle.Degrees(-21.48285708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48856"},
        {"Smithsonian Astrophysical Observation", "SAO 178238"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48084463),
        dec: Angle.Degrees(-21.47984517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147296"},
        {"Hipparcos Number", "HIP 80169"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.47953151),
        dec: Angle.Degrees(-21.47819808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102361"},
        {"Hipparcos Number", "HIP 57468"},
        {"Geneva Identification System", "GEN# +1.00102361"},
        {"Smithsonian Astrophysical Observation", "SAO 180180"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.70432865),
        dec: Angle.Degrees(-21.47493260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102165"},
        {"Hipparcos Number", "HIP 57345"},
        {"Geneva Identification System", "GEN# +1.00102165"},
        {"Smithsonian Astrophysical Observation", "SAO 180164"},
        {"Wilson Evans Batten Catalogue", "WEB 10307"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.36709055),
        dec: Angle.Degrees(-21.47391095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5300"},
        {"Hipparcos Number", "HIP 4272"},
        {"Smithsonian Astrophysical Observation", "SAO 166670"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.66493715),
        dec: Angle.Degrees(-21.47308717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42748"},
        {"Hipparcos Number", "HIP 29387"},
        {"Smithsonian Astrophysical Observation", "SAO 171361"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.90053507),
        dec: Angle.Degrees(-21.47163702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71140"},
        {"Hipparcos Number", "HIP 41259"},
        {"Smithsonian Astrophysical Observation", "SAO 175779"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.26065861),
        dec: Angle.Degrees(-21.47146786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33258"},
        {"Hipparcos Number", "HIP 23902"},
        {"Smithsonian Astrophysical Observation", "SAO 170099"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02955248),
        dec: Angle.Degrees(-21.47128686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157862"},
        {"Hipparcos Number", "HIP 85376"},
        {"Geneva Identification System", "GEN# +1.00157862"},
        {"Smithsonian Astrophysical Observation", "SAO 185402"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.67745039),
        dec: Angle.Degrees(-21.46936003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178496"},
        {"Hipparcos Number", "HIP 94129"},
        {"Cincinnati Publication", "Ci 20 1132"},
        {"Geneva Identification System", "GEN# +1.00178496A"},
        {"Smithsonian Astrophysical Observation", "SAO 187750"},
        {"Wilson Evans Batten Catalogue", "WEB 16395"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.41420044),
        dec: Angle.Degrees(-21.46874911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -380.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221028"},
        {"Hipparcos Number", "HIP 115881"},
        {"Smithsonian Astrophysical Observation", "SAO 191935"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.16883607),
        dec: Angle.Degrees(-21.46823077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148898"},
        {"Hipparcos Number", "HIP 80975"},
        {"Fundamental Katalog 5th Edition", "FK5 3307"},
        {"Geneva Identification System", "GEN# +1.00148898"},
        {"Renson", "Renson 42070"},
        {"Smithsonian Astrophysical Observation", "SAO 184450"},
        {"Wilson Evans Batten Catalogue", "WEB 13695"},
    },
    visualMagnitude: 4.45,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.03411079),
        dec: Angle.Degrees(-21.46647783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111167"},
        {"Hipparcos Number", "HIP 62413"},
        {"Smithsonian Astrophysical Observation", "SAO 181101"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.86112670),
        dec: Angle.Degrees(-21.46409958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189513"},
        {"Hipparcos Number", "HIP 98550"},
        {"Geneva Identification System", "GEN# +1.00189513"},
        {"Smithsonian Astrophysical Observation", "SAO 188823"},
        {"Wilson Evans Batten Catalogue", "WEB 17414"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.28997034),
        dec: Angle.Degrees(-21.46292360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85367"},
        {"Hipparcos Number", "HIP 48296"},
        {"Geneva Identification System", "GEN# +1.00085367"},
        {"Smithsonian Astrophysical Observation", "SAO 178082"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.70260027),
        dec: Angle.Degrees(-21.46276376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2671"},
        {"Hipparcos Number", "HIP 2363"},
        {"Smithsonian Astrophysical Observation", "SAO 166313"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.54379636),
        dec: Angle.Degrees(-21.46200348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153438"},
        {"Hipparcos Number", "HIP 83224"},
        {"Smithsonian Astrophysical Observation", "SAO 184906"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.12385193),
        dec: Angle.Degrees(-21.46146398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168082"},
        {"Hipparcos Number", "HIP 89744"},
        {"Smithsonian Astrophysical Observation", "SAO 186634"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.72138303),
        dec: Angle.Degrees(-21.46085596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72932"},
        {"Hipparcos Number", "HIP 42099"},
        {"Geneva Identification System", "GEN# +1.00072932"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.71926419),
        dec: Angle.Degrees(-21.45905403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15653"},
        {"Geneva Identification System", "GEN# -0.02100613"},
        {"Smithsonian Astrophysical Observation", "SAO 168483"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.37486563),
        dec: Angle.Degrees(-21.45743440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34361"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84499498),
        dec: Angle.Degrees(-21.45707442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218279"},
        {"Hipparcos Number", "HIP 114135"},
        {"Geneva Identification System", "GEN# +1.00218279"},
        {"Smithsonian Astrophysical Observation", "SAO 191656"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.72649004),
        dec: Angle.Degrees(-21.45688102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8072"},
        {"Hipparcos Number", "HIP 6225"},
        {"Geneva Identification System", "GEN# +1.00008072"},
        {"Smithsonian Astrophysical Observation", "SAO 166963"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.95028864),
        dec: Angle.Degrees(-21.45400398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25882"},
        {"Hipparcos Number", "HIP 19066"},
        {"Smithsonian Astrophysical Observation", "SAO 169104"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.29252576),
        dec: Angle.Degrees(-21.45284399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148701"},
        {"Hipparcos Number", "HIP 80851"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.66763949),
        dec: Angle.Degrees(-21.45218760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2739"},
        {"Smithsonian Astrophysical Observation", "SAO 166378"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.74943846),
        dec: Angle.Degrees(-21.45123469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203163"},
        {"Hipparcos Number", "HIP 105407"},
        {"Geneva Identification System", "GEN# +1.00203163"},
        {"Smithsonian Astrophysical Observation", "SAO 190250"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.25597175),
        dec: Angle.Degrees(-21.45027694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53672"},
        {"Hipparcos Number", "HIP 34166"},
        {"Smithsonian Astrophysical Observation", "SAO 172922"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.27539531),
        dec: Angle.Degrees(-21.45026144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9931"},
        {"Hipparcos Number", "HIP 7507"},
        {"Geneva Identification System", "GEN# +1.00009931A"},
        {"Smithsonian Astrophysical Observation", "SAO 167173"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.18776193),
        dec: Angle.Degrees(-21.44964251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165784"},
        {"Hipparcos Number", "HIP 88876"},
        {"Geneva Identification System", "GEN# +1.00165784"},
        {"Smithsonian Astrophysical Observation", "SAO 186343"},
        {"Wilson Evans Batten Catalogue", "WEB 15069"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.16077780),
        dec: Angle.Degrees(-21.44955654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91845"},
        {"Hipparcos Number", "HIP 51875"},
        {"Smithsonian Astrophysical Observation", "SAO 179008"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.98058807),
        dec: Angle.Degrees(-21.44877373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165516"},
        {"Hipparcos Number", "HIP 88760"},
        {"Celescope Catalog", "CEL 4622"},
        {"Fundamental Katalog 5th Edition", "FK5 3438"},
        {"Geneva Identification System", "GEN# +1.00165516"},
        {"Smithsonian Astrophysical Observation", "SAO 186302"},
        {"Wilson Evans Batten Catalogue", "WEB 15036"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.79730511),
        dec: Angle.Degrees(-21.44393246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220568"},
        {"Hipparcos Number", "HIP 115587"},
        {"Smithsonian Astrophysical Observation", "SAO 191882"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.19750043),
        dec: Angle.Degrees(-21.44274751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90607"},
        {"Hipparcos Number", "HIP 51196"},
        {"Geneva Identification System", "GEN# +1.00090607"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85748696),
        dec: Angle.Degrees(-21.44185477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10522 AB"},
        {"Henry Draper", "HD 157527"},
        {"Hipparcos Number", "HIP 85207"},
        {"Geneva Identification System", "GEN# +1.00157527J"},
        {"Smithsonian Astrophysical Observation", "SAO 185367"},
        {"Wilson Evans Batten Catalogue", "WEB 14390"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17516721),
        dec: Angle.Degrees(-21.44141348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191956"},
        {"Hipparcos Number", "HIP 99632"},
        {"Geneva Identification System", "GEN# +1.00191956"},
        {"Smithsonian Astrophysical Observation", "SAO 189035"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.31134295),
        dec: Angle.Degrees(-21.44105258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53160"},
        {"Hipparcos Number", "HIP 33991"},
        {"Smithsonian Astrophysical Observation", "SAO 172843"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.79265792),
        dec: Angle.Degrees(-21.43991928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202370"},
        {"Hipparcos Number", "HIP 104993"},
        {"Geneva Identification System", "GEN# +1.00202370"},
        {"Smithsonian Astrophysical Observation", "SAO 190177"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.96892121),
        dec: Angle.Degrees(-21.43982220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5097"},
        {"Hipparcos Number", "HIP 4106"},
        {"Smithsonian Astrophysical Observation", "SAO 166646"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16918245),
        dec: Angle.Degrees(-21.43852822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98455"},
        {"Hipparcos Number", "HIP 55294"},
        {"Smithsonian Astrophysical Observation", "SAO 179767"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.86017881),
        dec: Angle.Degrees(-21.43294887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126399"},
        {"Hipparcos Number", "HIP 70535"},
        {"Smithsonian Astrophysical Observation", "SAO 182536"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.44172062),
        dec: Angle.Degrees(-21.43120815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42910"},
        {"Geneva Identification System", "GEN# -0.02002665"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.17082208),
        dec: Angle.Degrees(-21.43000297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28560"},
        {"Hipparcos Number", "HIP 20937"},
        {"Smithsonian Astrophysical Observation", "SAO 169496"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.33894935),
        dec: Angle.Degrees(-21.42935580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38295"},
        {"Hipparcos Number", "HIP 27011"},
        {"Geneva Identification System", "GEN# +1.00038295"},
        {"Smithsonian Astrophysical Observation", "SAO 170740"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.94375130),
        dec: Angle.Degrees(-21.42863356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211546"},
        {"Hipparcos Number", "HIP 110107"},
        {"Smithsonian Astrophysical Observation", "SAO 191034"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.55857921),
        dec: Angle.Degrees(-21.42658415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113003"},
        {"Hipparcos Number", "HIP 63519"},
        {"Geneva Identification System", "GEN# +1.00113003"},
        {"Smithsonian Astrophysical Observation", "SAO 181313"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.24089560),
        dec: Angle.Degrees(-21.42627133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8380"},
        {"Hipparcos Number", "HIP 6443"},
        {"Geneva Identification System", "GEN# +1.00008380"},
        {"Renson", "Renson 2030"},
        {"Smithsonian Astrophysical Observation", "SAO 166997"},
        {"Wilson Evans Batten Catalogue", "WEB 1425"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.68429425),
        dec: Angle.Degrees(-21.42625367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196473"},
        {"Hipparcos Number", "HIP 101849"},
        {"Smithsonian Astrophysical Observation", "SAO 189515"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58717680),
        dec: Angle.Degrees(-21.42417127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21736"},
        {"Hipparcos Number", "HIP 16265"},
        {"Geneva Identification System", "GEN# +1.00021736"},
        {"Smithsonian Astrophysical Observation", "SAO 168583"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.41117818),
        dec: Angle.Degrees(-21.42082110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56470"},
        {"Hipparcos Number", "HIP 35184"},
        {"Smithsonian Astrophysical Observation", "SAO 173337"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.06939128),
        dec: Angle.Degrees(-21.42081127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32901"},
        {"Hipparcos Number", "HIP 23698"},
        {"Geneva Identification System", "GEN# +1.00032901"},
        {"Smithsonian Astrophysical Observation", "SAO 170055"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.39369661),
        dec: Angle.Degrees(-21.42038105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5530"},
        {"Smithsonian Astrophysical Observation", "SAO 166853"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.69654166),
        dec: Angle.Degrees(-21.41962336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103723"},
        {"Hipparcos Number", "HIP 58229"},
        {"Geneva Identification System", "GEN# +1.00103723"},
        {"Smithsonian Astrophysical Observation", "SAO 180319"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.15071602),
        dec: Angle.Degrees(-21.41925857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193565"},
        {"Hipparcos Number", "HIP 100394"},
        {"Geneva Identification System", "GEN# +1.00193565"},
        {"Smithsonian Astrophysical Observation", "SAO 189195"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38700107),
        dec: Angle.Degrees(-21.41867275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78893"},
        {"Hipparcos Number", "HIP 45009"},
        {"Renson", "Renson 22343"},
        {"Smithsonian Astrophysical Observation", "SAO 177058"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.51107976),
        dec: Angle.Degrees(-21.41822359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25622"},
        {"Hipparcos Number", "HIP 18917"},
        {"Smithsonian Astrophysical Observation", "SAO 169068"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.81570602),
        dec: Angle.Degrees(-21.41749711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13533"},
        {"Hipparcos Number", "HIP 10236"},
        {"Smithsonian Astrophysical Observation", "SAO 167619"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.90487856),
        dec: Angle.Degrees(-21.41670507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26610"},
        {"Hipparcos Number", "HIP 19578"},
        {"Smithsonian Astrophysical Observation", "SAO 169209"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.93208114),
        dec: Angle.Degrees(-21.41666825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40762"},
        {"Hipparcos Number", "HIP 28407"},
        {"Smithsonian Astrophysical Observation", "SAO 171110"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.00113358),
        dec: Angle.Degrees(-21.41433236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116261"},
        {"Hipparcos Number", "HIP 65286"},
        {"Geneva Identification System", "GEN# +1.00116261"},
        {"Smithsonian Astrophysical Observation", "SAO 181604"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.70762128),
        dec: Angle.Degrees(-21.41412408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154018"},
        {"Hipparcos Number", "HIP 83482"},
        {"Smithsonian Astrophysical Observation", "SAO 184973"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.92604957),
        dec: Angle.Degrees(-21.41314109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162675"},
        {"Hipparcos Number", "HIP 87546"},
        {"Geneva Identification System", "GEN# +1.00162675"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.27950000),
        dec: Angle.Degrees(-21.41237511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144641"},
        {"Hipparcos Number", "HIP 79020"},
        {"Geneva Identification System", "GEN# +1.00144641"},
        {"Smithsonian Astrophysical Observation", "SAO 184141"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93602923),
        dec: Angle.Degrees(-21.41209562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210931"},
        {"Hipparcos Number", "HIP 109775"},
        {"Geneva Identification System", "GEN# +1.00210931"},
        {"Smithsonian Astrophysical Observation", "SAO 190983"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.52768740),
        dec: Angle.Degrees(-21.41133368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73184",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9446 A"},
        {"Henry Draper", "HD 131977"},
        {"Hipparcos Number", "HIP 73184"},
        {"Cincinnati Publication", "Ci 20 900"},
        {"Fundamental Katalog 5th Edition", "FK5 1391"},
        {"Geneva Identification System", "GEN# +1.00131977A"},
        {"Smithsonian Astrophysical Observation", "SAO 183040"},
        {"Wilson Evans Batten Catalogue", "WEB 12542"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.36396501),
        dec: Angle.Degrees(-21.41128090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1034.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1725.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95680"},
        {"Hipparcos Number", "HIP 53970"},
        {"Smithsonian Astrophysical Observation", "SAO 179457"},
        {"Wilson Evans Batten Catalogue", "WEB 9763"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.61145900),
        dec: Angle.Degrees(-21.41118459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46911"},
        {"Hipparcos Number", "HIP 31426"},
        {"Smithsonian Astrophysical Observation", "SAO 171983"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.77958809),
        dec: Angle.Degrees(-21.40976639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36432"},
        {"Hipparcos Number", "HIP 25819"},
        {"Smithsonian Astrophysical Observation", "SAO 170497"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70307864),
        dec: Angle.Degrees(-21.40780939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73182",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9446 B"},
        {"Henry Draper", "HD 131976"},
        {"Hipparcos Number", "HIP 73182"},
        {"Cincinnati Publication", "Ci 20 899"},
        {"Geneva Identification System", "GEN# +1.00131976"},
        {"Smithsonian Astrophysical Observation", "SAO 183039"},
        {"Wilson Evans Batten Catalogue", "WEB 12541"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.35801834),
        dec: Angle.Degrees(-21.40746858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 987.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1666.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19192"},
        {"Hipparcos Number", "HIP 14314"},
        {"Smithsonian Astrophysical Observation", "SAO 168282"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.15286067),
        dec: Angle.Degrees(-21.40640994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210780"},
        {"Hipparcos Number", "HIP 109689"},
        {"Smithsonian Astrophysical Observation", "SAO 190971"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.28923187),
        dec: Angle.Degrees(-21.40599272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4260"},
        {"Hipparcos Number", "HIP 3516"},
        {"Geneva Identification System", "GEN# +1.00004260"},
        {"Smithsonian Astrophysical Observation", "SAO 166531"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.22751307),
        dec: Angle.Degrees(-21.40560914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46270"},
        {"Hipparcos Number", "HIP 31092"},
        {"Geneva Identification System", "GEN# +1.00046270"},
        {"Smithsonian Astrophysical Observation", "SAO 171884"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.87289322),
        dec: Angle.Degrees(-21.40560430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12108",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1978 B"},
        {"Hipparcos Number", "HIP 12108"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.00196909),
        dec: Angle.Degrees(-21.40427269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224849"},
        {"Hipparcos Number", "HIP 97"},
        {"Smithsonian Astrophysical Observation", "SAO 192321"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.30733362),
        dec: Angle.Degrees(-21.40404527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1978 A"},
        {"Henry Draper", "HD 16263"},
        {"Hipparcos Number", "HIP 12105"},
        {"Geneva Identification System", "GEN# +1.00016263"},
        {"Smithsonian Astrophysical Observation", "SAO 167903"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.99761157),
        dec: Angle.Degrees(-21.40370825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146897"},
        {"Hipparcos Number", "HIP 79977"},
        {"Geneva Identification System", "GEN# +1.00146897"},
        {"Smithsonian Astrophysical Observation", "SAO 184312"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.87187254),
        dec: Angle.Degrees(-21.40362386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142989"},
        {"Hipparcos Number", "HIP 78233"},
        {"Smithsonian Astrophysical Observation", "SAO 183981"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.62213303),
        dec: Angle.Degrees(-21.40106612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99407"},
        {"Hipparcos Number", "HIP 55813"},
        {"Geneva Identification System", "GEN# +1.00099407"},
        {"Smithsonian Astrophysical Observation", "SAO 179877"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.56372070),
        dec: Angle.Degrees(-21.40049050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83330"},
        {"Hipparcos Number", "HIP 47194"},
        {"Smithsonian Astrophysical Observation", "SAO 177750"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.27915838),
        dec: Angle.Degrees(-21.40037449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145809"},
        {"Hipparcos Number", "HIP 79524"},
        {"Geneva Identification System", "GEN# +1.00145809"},
        {"Smithsonian Astrophysical Observation", "SAO 184240"},
        {"Wilson Evans Batten Catalogue", "WEB 13459"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.41841694),
        dec: Angle.Degrees(-21.39998062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15122"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.74310187),
        dec: Angle.Degrees(-21.39923080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171856"},
        {"Hipparcos Number", "HIP 91347"},
        {"Fundamental Katalog 5th Edition", "FK5 1485"},
        {"Geneva Identification System", "GEN# +1.00171856"},
        {"Renson", "Renson 48160"},
        {"Smithsonian Astrophysical Observation", "SAO 187071"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.47678201),
        dec: Angle.Degrees(-21.39756504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21532"},
        {"Hipparcos Number", "HIP 16130"},
        {"Geneva Identification System", "GEN# +1.00021532"},
        {"Smithsonian Astrophysical Observation", "SAO 168560"},
    },
    visualMagnitude: 9.88,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.94314868),
        dec: Angle.Degrees(-21.39742079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 681 AB"},
        {"Henry Draper", "HD 4731"},
        {"Hipparcos Number", "HIP 3845"},
        {"Smithsonian Astrophysical Observation", "SAO 166603"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.32628851),
        dec: Angle.Degrees(-21.39738310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 681 C"},
        {"Henry Draper", "HD 4731C"},
        {"Hipparcos Number", "HIP 3843"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.32340724),
        dec: Angle.Degrees(-21.39590487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23217"},
        {"Smithsonian Astrophysical Observation", "SAO 169953"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.94340909),
        dec: Angle.Degrees(-21.39448458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61135"},
        {"Hipparcos Number", "HIP 37065"},
        {"Geneva Identification System", "GEN# +1.00061135"},
        {"Smithsonian Astrophysical Observation", "SAO 174123"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.25055058),
        dec: Angle.Degrees(-21.39403023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34751"},
        {"Henry Draper 2", "HD 34751A"},
        {"Hipparcos Number", "HIP 24783"},
        {"Geneva Identification System", "GEN# +1.00034751"},
        {"Wilson Evans Batten Catalogue", "WEB 4796"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.69699088),
        dec: Angle.Degrees(-21.39366593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82724"},
        {"Hipparcos Number", "HIP 46890"},
        {"Geneva Identification System", "GEN# +1.00082724"},
        {"Smithsonian Astrophysical Observation", "SAO 177647"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.32368452),
        dec: Angle.Degrees(-21.39201084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47993"},
        {"Hipparcos Number", "HIP 31935"},
        {"Smithsonian Astrophysical Observation", "SAO 172135"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.10468262),
        dec: Angle.Degrees(-21.39006502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215432"},
        {"Hipparcos Number", "HIP 112357"},
        {"Smithsonian Astrophysical Observation", "SAO 191381"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.36750298),
        dec: Angle.Degrees(-21.38936735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 511"},
        {"Hipparcos Number", "HIP 777"},
        {"Smithsonian Astrophysical Observation", "SAO 166085"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.39674740),
        dec: Angle.Degrees(-21.38186598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137339"},
        {"Hipparcos Number", "HIP 75552"},
        {"Smithsonian Astrophysical Observation", "SAO 183466"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52245539),
        dec: Angle.Degrees(-21.38027418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5664 AB"},
        {"Henry Draper", "HD 52165"},
        {"Hipparcos Number", "HIP 33635"},
        {"Celescope Catalog", "CEL 1478"},
        {"Geneva Identification System", "GEN# +1.00052165J"},
        {"Smithsonian Astrophysical Observation", "SAO 172688"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.81079414),
        dec: Angle.Degrees(-21.37968958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66722"},
        {"Hipparcos Number", "HIP 39474"},
        {"Smithsonian Astrophysical Observation", "SAO 175092"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.02096858),
        dec: Angle.Degrees(-21.37639870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35991"},
        {"Hipparcos Number", "HIP 25532"},
        {"Geneva Identification System", "GEN# +1.00035991"},
        {"Smithsonian Astrophysical Observation", "SAO 170445"},
        {"Wilson Evans Batten Catalogue", "WEB 4956"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90203760),
        dec: Angle.Degrees(-21.37579099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29011"},
        {"Hipparcos Number", "HIP 21237"},
        {"Smithsonian Astrophysical Observation", "SAO 169564"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.33257014),
        dec: Angle.Degrees(-21.37576688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28707"},
        {"Hipparcos Number", "HIP 21054"},
        {"Smithsonian Astrophysical Observation", "SAO 169523"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.69843862),
        dec: Angle.Degrees(-21.37430919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84621"},
        {"Hipparcos Number", "HIP 47931"},
        {"Smithsonian Astrophysical Observation", "SAO 177952"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.51660255),
        dec: Angle.Degrees(-21.37308309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21679"},
        {"Hipparcos Number", "HIP 16237"},
        {"Smithsonian Astrophysical Observation", "SAO 168579"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.32235480),
        dec: Angle.Degrees(-21.37116263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221357"},
        {"Hipparcos Number", "HIP 116118"},
        {"Fundamental Katalog 5th Edition", "FK5 3885"},
        {"Geneva Identification System", "GEN# +1.00221357"},
        {"Smithsonian Astrophysical Observation", "SAO 191970"},
        {"Wilson Evans Batten Catalogue", "WEB 20527"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.92517450),
        dec: Angle.Degrees(-21.36944011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26741"},
        {"Hipparcos Number", "HIP 19674"},
        {"Geneva Identification System", "GEN# +1.00026741"},
        {"Smithsonian Astrophysical Observation", "SAO 169230"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.21725525),
        dec: Angle.Degrees(-21.36925515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193901"},
        {"Hipparcos Number", "HIP 100568"},
        {"Cincinnati Publication", "Ci 20 1205"},
        {"Geneva Identification System", "GEN# +1.00193901"},
        {"Smithsonian Astrophysical Observation", "SAO 189226"},
        {"Wilson Evans Batten Catalogue", "WEB 18168"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.89795340),
        dec: Angle.Degrees(-21.36805062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 539.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1055.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115049"},
        {"Hipparcos Number", "HIP 64633"},
        {"Smithsonian Astrophysical Observation", "SAO 181479"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.72009106),
        dec: Angle.Degrees(-21.36742522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74715"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.03614131),
        dec: Angle.Degrees(-21.36654202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66180"},
        {"Hipparcos Number", "HIP 39240"},
        {"Smithsonian Astrophysical Observation", "SAO 175001"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.38303226),
        dec: Angle.Degrees(-21.36465218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63060"},
        {"Geneva Identification System", "GEN# -0.02003740"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.81160294),
        dec: Angle.Degrees(-21.36298485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16290"},
        {"Hipparcos Number", "HIP 12133"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.07222251),
        dec: Angle.Degrees(-21.36192959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2326 A"},
        {"Henry Draper", "HD 19096"},
        {"Hipparcos Number", "HIP 14249"},
        {"Geneva Identification System", "GEN# +1.00019096"},
        {"Smithsonian Astrophysical Observation", "SAO 168268"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.94547433),
        dec: Angle.Degrees(-21.36137001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63067"},
        {"Geneva Identification System", "GEN# -0.02003741"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.83671332),
        dec: Angle.Degrees(-21.36021758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174947"},
        {"Hipparcos Number", "HIP 92747"},
        {"Geneva Identification System", "GEN# +1.00174947"},
        {"Smithsonian Astrophysical Observation", "SAO 187422"},
        {"Wilson Evans Batten Catalogue", "WEB 16050"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.50037663),
        dec: Angle.Degrees(-21.35979587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99459"},
        {"Hipparcos Number", "HIP 55830"},
        {"Fundamental Katalog 5th Edition", "FK5 5008"},
        {"Geneva Identification System", "GEN# +1.00099459"},
        {"Smithsonian Astrophysical Observation", "SAO 179887"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.64186113),
        dec: Angle.Degrees(-21.35650343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102332"},
        {"Geneva Identification System", "GEN# -0.02105811"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.00258297),
        dec: Angle.Degrees(-21.35511949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26125"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56910542),
        dec: Angle.Degrees(-21.35257624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2783"},
        {"Hipparcos Number", "HIP 2451"},
        {"Geneva Identification System", "GEN# +1.00002783"},
        {"Smithsonian Astrophysical Observation", "SAO 166327"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.79994948),
        dec: Angle.Degrees(-21.35119816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13131"},
        {"Hipparcos Number", "HIP 9943"},
        {"Geneva Identification System", "GEN# +1.00013131"},
        {"Smithsonian Astrophysical Observation", "SAO 167574"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.99972116),
        dec: Angle.Degrees(-21.34756105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150621"},
        {"Hipparcos Number", "HIP 81844"},
        {"Geneva Identification System", "GEN# +1.00150621"},
        {"Smithsonian Astrophysical Observation", "SAO 184570"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.75608486),
        dec: Angle.Degrees(-21.34404890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61572"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.24766129),
        dec: Angle.Degrees(-21.34384164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99933"},
        {"Hipparcos Number", "HIP 56084"},
        {"Smithsonian Astrophysical Observation", "SAO 179937"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.43260599),
        dec: Angle.Degrees(-21.34211062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42711"},
        {"Smithsonian Astrophysical Observation", "SAO 176334"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.56680904),
        dec: Angle.Degrees(-21.34067838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29263"},
        {"Hipparcos Number", "HIP 21414"},
        {"Geneva Identification System", "GEN# +1.00029263"},
        {"Smithsonian Astrophysical Observation", "SAO 169592"},
        {"Wilson Evans Batten Catalogue", "WEB 4110"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.94008897),
        dec: Angle.Degrees(-21.33983521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183309"},
        {"Hipparcos Number", "HIP 95855"},
        {"Smithsonian Astrophysical Observation", "SAO 188191"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.43077112),
        dec: Angle.Degrees(-21.33870591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97342"},
        {"Hipparcos Number", "HIP 54707"},
        {"Geneva Identification System", "GEN# +1.00097342"},
        {"Smithsonian Astrophysical Observation", "SAO 179631"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.01255944),
        dec: Angle.Degrees(-21.33796005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27584"},
        {"Hipparcos Number", "HIP 20256"},
        {"Geneva Identification System", "GEN# +1.00027584"},
        {"Smithsonian Astrophysical Observation", "SAO 169350"},
        {"Wilson Evans Batten Catalogue", "WEB 3869"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.10808250),
        dec: Angle.Degrees(-21.33600618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196373"},
        {"Hipparcos Number", "HIP 101774"},
        {"Geneva Identification System", "GEN# +1.00196373"},
        {"Smithsonian Astrophysical Observation", "SAO 189497"},
        {"Wilson Evans Batten Catalogue", "WEB 18388"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.39945483),
        dec: Angle.Degrees(-21.33533893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199506"},
        {"Hipparcos Number", "HIP 103507"},
        {"Smithsonian Astrophysical Observation", "SAO 189889"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.55764581),
        dec: Angle.Degrees(-21.33531232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223587"},
        {"Hipparcos Number", "HIP 117583"},
        {"Smithsonian Astrophysical Observation", "SAO 192199"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.68860047),
        dec: Angle.Degrees(-21.33492000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200125"},
        {"Hipparcos Number", "HIP 103808"},
        {"Smithsonian Astrophysical Observation", "SAO 189951"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.53219965),
        dec: Angle.Degrees(-21.33222618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216554"},
        {"Hipparcos Number", "HIP 113078"},
        {"Smithsonian Astrophysical Observation", "SAO 191477"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.51891612),
        dec: Angle.Degrees(-21.33103889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152055"},
        {"Hipparcos Number", "HIP 82519"},
        {"Smithsonian Astrophysical Observation", "SAO 184728"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.98503233),
        dec: Angle.Degrees(-21.33059506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166167"},
        {"Hipparcos Number", "HIP 89029"},
        {"Geneva Identification System", "GEN# +1.00166167"},
        {"Smithsonian Astrophysical Observation", "SAO 186396"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.55884734),
        dec: Angle.Degrees(-21.32716570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130157"},
        {"Hipparcos Number", "HIP 72310"},
        {"Geneva Identification System", "GEN# +1.00130157"},
        {"Smithsonian Astrophysical Observation", "SAO 182873"},
        {"Wilson Evans Batten Catalogue", "WEB 12436"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.80690878),
        dec: Angle.Degrees(-21.32487794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69589"},
        {"Hipparcos Number", "HIP 40561"},
        {"Geneva Identification System", "GEN# +1.00069589"},
        {"Smithsonian Astrophysical Observation", "SAO 175497"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22596665),
        dec: Angle.Degrees(-21.32066802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14019"},
        {"Hipparcos Number", "HIP 10537"},
        {"Geneva Identification System", "GEN# +1.00014019"},
        {"Smithsonian Astrophysical Observation", "SAO 167666"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.93660828),
        dec: Angle.Degrees(-21.31863291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13616 A"},
        {"Henry Draper", "HD 192737"},
        {"Hipparcos Number", "HIP 99990"},
        {"Geneva Identification System", "GEN# +1.00192737"},
        {"Wilson Evans Batten Catalogue", "WEB 17999"},
    },
    visualMagnitude: 6.97,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.27718889),
        dec: Angle.Degrees(-21.31787900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29312"},
        {"Hipparcos Number", "HIP 21440"},
        {"Geneva Identification System", "GEN# +1.00029312"},
        {"Smithsonian Astrophysical Observation", "SAO 169602"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.06971600),
        dec: Angle.Degrees(-21.31780613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76550"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.51002494),
        dec: Angle.Degrees(-21.31775132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -586.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17004"},
        {"Smithsonian Astrophysical Observation", "SAO 168698"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.67893975),
        dec: Angle.Degrees(-21.31568368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83679"},
        {"Smithsonian Astrophysical Observation", "SAO 185023"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54345437),
        dec: Angle.Degrees(-21.31561339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77504"},
        {"Hipparcos Number", "HIP 44378"},
        {"Smithsonian Astrophysical Observation", "SAO 176854"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.58450102),
        dec: Angle.Degrees(-21.31543486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31"},
        {"Hipparcos Number", "HIP 442"},
        {"Geneva Identification System", "GEN# +1.00000031"},
        {"Smithsonian Astrophysical Observation", "SAO 166038"},
        {"Wilson Evans Batten Catalogue", "WEB 70"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.33346262),
        dec: Angle.Degrees(-21.31530277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190283"},
        {"Hipparcos Number", "HIP 98896"},
        {"Fundamental Katalog 5th Edition", "FK5 3607"},
        {"Geneva Identification System", "GEN# +1.00190283"},
        {"Smithsonian Astrophysical Observation", "SAO 188889"},
        {"Wilson Evans Batten Catalogue", "WEB 17555"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.24170436),
        dec: Angle.Degrees(-21.31400204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122751"},
        {"Hipparcos Number", "HIP 68727"},
        {"Geneva Identification System", "GEN# +1.00122751"},
        {"Smithsonian Astrophysical Observation", "SAO 182209"},
        {"Wilson Evans Batten Catalogue", "WEB 12027"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02982825),
        dec: Angle.Degrees(-21.31370965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11324",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1848 A"},
        {"Henry Draper", "HD 15146B"},
        {"Hipparcos Number", "HIP 11324"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.43725514),
        dec: Angle.Degrees(-21.31335954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183545"},
        {"Hipparcos Number", "HIP 95965"},
        {"Geneva Identification System", "GEN# +1.00183545"},
        {"Smithsonian Astrophysical Observation", "SAO 188219"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.72515764),
        dec: Angle.Degrees(-21.31218388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198420"},
        {"Hipparcos Number", "HIP 102908"},
        {"Geneva Identification System", "GEN# +1.00198420"},
        {"Smithsonian Astrophysical Observation", "SAO 189763"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.72559133),
        dec: Angle.Degrees(-21.31216181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138651"},
        {"Hipparcos Number", "HIP 76216"},
        {"Smithsonian Astrophysical Observation", "SAO 183575"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.53986207),
        dec: Angle.Degrees(-21.31126775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134632"},
        {"Hipparcos Number", "HIP 74332"},
        {"Fundamental Katalog 5th Edition", "FK5 5349"},
        {"Smithsonian Astrophysical Observation", "SAO 183253"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.88713204),
        dec: Angle.Degrees(-21.31028580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11323",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1848 B"},
        {"Henry Draper", "HD 15146"},
        {"Henry Draper 2", "HD 15146A"},
        {"Hipparcos Number", "HIP 11323"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.43609210),
        dec: Angle.Degrees(-21.30924000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109695"},
        {"Hipparcos Number", "HIP 61548"},
        {"Smithsonian Astrophysical Observation", "SAO 180951"},
        {"Wilson Evans Batten Catalogue", "WEB 10952"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.16820739),
        dec: Angle.Degrees(-21.30662927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60601"},
        {"Hipparcos Number", "HIP 36847"},
        {"Smithsonian Astrophysical Observation", "SAO 174026"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.64312765),
        dec: Angle.Degrees(-21.30649751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159054"},
        {"Hipparcos Number", "HIP 85908"},
        {"Smithsonian Astrophysical Observation", "SAO 185500"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.33570295),
        dec: Angle.Degrees(-21.30453699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146416"},
        {"Hipparcos Number", "HIP 79785"},
        {"Geneva Identification System", "GEN# +1.00146416"},
        {"Smithsonian Astrophysical Observation", "SAO 184285"},
        {"Wilson Evans Batten Catalogue", "WEB 13504"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.24489835),
        dec: Angle.Degrees(-21.30406946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185534"},
        {"Hipparcos Number", "HIP 96778"},
        {"Geneva Identification System", "GEN# +1.00185534"},
        {"Smithsonian Astrophysical Observation", "SAO 188422"},
        {"Wilson Evans Batten Catalogue", "WEB 16977"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.06913229),
        dec: Angle.Degrees(-21.30223318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191695"},
        {"Hipparcos Number", "HIP 99535"},
        {"Renson", "Renson 53430"},
        {"Smithsonian Astrophysical Observation", "SAO 189011"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01038657),
        dec: Angle.Degrees(-21.30078898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202284"},
        {"Hipparcos Number", "HIP 104926"},
        {"Geneva Identification System", "GEN# +1.00202284"},
        {"Smithsonian Astrophysical Observation", "SAO 190168"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.81145303),
        dec: Angle.Degrees(-21.29491489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314446"},
        {"Hipparcos Number", "HIP 90145"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.94719139),
        dec: Angle.Degrees(-21.29157094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145295"},
        {"Hipparcos Number", "HIP 79300"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.75545482),
        dec: Angle.Degrees(-21.29149335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2186 AB"},
        {"Henry Draper", "HD 17881"},
        {"Hipparcos Number", "HIP 13349"},
        {"Smithsonian Astrophysical Observation", "SAO 168103"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.94218494),
        dec: Angle.Degrees(-21.28974518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87724"},
        {"Hipparcos Number", "HIP 49510"},
        {"Geneva Identification System", "GEN# +1.00087724"},
        {"Smithsonian Astrophysical Observation", "SAO 178415"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.63155920),
        dec: Angle.Degrees(-21.28554549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63719"},
        {"Hipparcos Number", "HIP 38197"},
        {"Smithsonian Astrophysical Observation", "SAO 174609"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.38510396),
        dec: Angle.Degrees(-21.28495879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3570"},
        {"Hipparcos Number", "HIP 3024"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63214888),
        dec: Angle.Degrees(-21.28421533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30238"},
        {"Hipparcos Number", "HIP 22086"},
        {"Geneva Identification System", "GEN# +1.00030238"},
        {"Smithsonian Astrophysical Observation", "SAO 169727"},
        {"Wilson Evans Batten Catalogue", "WEB 4247"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.26729443),
        dec: Angle.Degrees(-21.28334113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147490"},
        {"Hipparcos Number", "HIP 80276"},
        {"Smithsonian Astrophysical Observation", "SAO 184352"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.79700434),
        dec: Angle.Degrees(-21.28326286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88491"},
        {"Hipparcos Number", "HIP 49952"},
        {"Smithsonian Astrophysical Observation", "SAO 178524"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.98736658),
        dec: Angle.Degrees(-21.28280089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62535"},
        {"Hipparcos Number", "HIP 37652"},
        {"Geneva Identification System", "GEN# +1.00062535"},
        {"Renson", "Renson 17160"},
        {"Smithsonian Astrophysical Observation", "SAO 174386"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.89881582),
        dec: Angle.Degrees(-21.28159641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24328"},
        {"Hipparcos Number", "HIP 18052"},
        {"Smithsonian Astrophysical Observation", "SAO 168888"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.87982930),
        dec: Angle.Degrees(-21.28095894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71961"},
        {"Hipparcos Number", "HIP 41649"},
        {"Smithsonian Astrophysical Observation", "SAO 175938"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.38828957),
        dec: Angle.Degrees(-21.28082155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38294"},
        {"Hipparcos Number", "HIP 27021"},
        {"Geneva Identification System", "GEN# +1.00038294"},
        {"Smithsonian Astrophysical Observation", "SAO 170742"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.96946899),
        dec: Angle.Degrees(-21.27976964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202840"},
        {"Hipparcos Number", "HIP 105248"},
        {"Smithsonian Astrophysical Observation", "SAO 190225"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.77258333),
        dec: Angle.Degrees(-21.27865216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207555"},
        {"Hipparcos Number", "HIP 107803"},
        {"Smithsonian Astrophysical Observation", "SAO 190670"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.58494817),
        dec: Angle.Degrees(-21.27698197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211168"},
        {"Hipparcos Number", "HIP 109915"},
        {"Smithsonian Astrophysical Observation", "SAO 191005"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.91931160),
        dec: Angle.Degrees(-21.27655485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205079"},
        {"Hipparcos Number", "HIP 106431"},
        {"Smithsonian Astrophysical Observation", "SAO 190438"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.35602022),
        dec: Angle.Degrees(-21.27627786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89913"},
        {"Hipparcos Number", "HIP 50781"},
        {"Smithsonian Astrophysical Observation", "SAO 178737"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53954135),
        dec: Angle.Degrees(-21.27608240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10148"},
        {"Hipparcos Number", "HIP 7679"},
        {"Fundamental Katalog 5th Edition", "FK5 2113"},
        {"Geneva Identification System", "GEN# +1.00010148"},
        {"Smithsonian Astrophysical Observation", "SAO 167198"},
        {"Wilson Evans Batten Catalogue", "WEB 1644"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.71544923),
        dec: Angle.Degrees(-21.27547447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94839"},
        {"Hipparcos Number", "HIP 53495"},
        {"Smithsonian Astrophysical Observation", "SAO 179362"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.15508752),
        dec: Angle.Degrees(-21.27536056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43088"},
        {"Hipparcos Number", "HIP 29539"},
        {"Smithsonian Astrophysical Observation", "SAO 171417"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.36756445),
        dec: Angle.Degrees(-21.26700963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53433"},
        {"Hipparcos Number", "HIP 34099"},
        {"Celescope Catalog", "CEL 1551"},
        {"Geneva Identification System", "GEN# +1.00053433"},
        {"Smithsonian Astrophysical Observation", "SAO 172890"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.05653053),
        dec: Angle.Degrees(-21.26602031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99058"},
        {"Hipparcos Number", "HIP 55636"},
        {"Geneva Identification System", "GEN# +1.00099058"},
        {"Smithsonian Astrophysical Observation", "SAO 179837"},
        {"Wilson Evans Batten Catalogue", "WEB 10000"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.96477593),
        dec: Angle.Degrees(-21.26392634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32855"},
        {"Hipparcos Number", "HIP 23671"},
        {"Smithsonian Astrophysical Observation", "SAO 170047"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.32210162),
        dec: Angle.Degrees(-21.25844955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159842"},
        {"Hipparcos Number", "HIP 86274"},
        {"Geneva Identification System", "GEN# +1.00159842"},
        {"Smithsonian Astrophysical Observation", "SAO 185564"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.42533226),
        dec: Angle.Degrees(-21.25638417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32450"},
        {"Hipparcos Number", "HIP 23452"},
        {"Geneva Identification System", "GEN# +1.00032450"},
        {"Smithsonian Astrophysical Observation", "SAO 170003"},
        {"Wilson Evans Batten Catalogue", "WEB 4564"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.61879215),
        dec: Angle.Degrees(-21.25610576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87810"},
        {"Hipparcos Number", "HIP 49561"},
        {"Geneva Identification System", "GEN# +1.00087810"},
        {"Smithsonian Astrophysical Observation", "SAO 178431"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78153218),
        dec: Angle.Degrees(-21.25574290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195701"},
        {"Hipparcos Number", "HIP 101445"},
        {"Smithsonian Astrophysical Observation", "SAO 189429"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.39472734),
        dec: Angle.Degrees(-21.25523724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86207"},
        {"Hipparcos Number", "HIP 48747"},
        {"Smithsonian Astrophysical Observation", "SAO 178207"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.14150007),
        dec: Angle.Degrees(-21.25485350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165763"},
        {"Hipparcos Number", "HIP 88856"},
        {"Geneva Identification System", "GEN# +1.00165763"},
        {"Smithsonian Astrophysical Observation", "SAO 186341"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.11861981),
        dec: Angle.Degrees(-21.25310295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185591"},
        {"Hipparcos Number", "HIP 96792"},
        {"Smithsonian Astrophysical Observation", "SAO 188427"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14132913),
        dec: Angle.Degrees(-21.25305391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11608"},
        {"Hipparcos Number", "HIP 8830"},
        {"Geneva Identification System", "GEN# +1.00011608"},
        {"Smithsonian Astrophysical Observation", "SAO 167380"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.38099868),
        dec: Angle.Degrees(-21.25212502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104340"},
        {"Hipparcos Number", "HIP 58596"},
        {"Smithsonian Astrophysical Observation", "SAO 180379"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.23864002),
        dec: Angle.Degrees(-21.25066160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27262"},
        {"Hipparcos Number", "HIP 20017"},
        {"Smithsonian Astrophysical Observation", "SAO 169307"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.40904453),
        dec: Angle.Degrees(-21.25016281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53085"},
        {"Geneva Identification System", "GEN# -0.02003283"},
        {"Smithsonian Astrophysical Observation", "SAO 179278"},
        {"Wilson Evans Batten Catalogue", "WEB 9647"},
    },
    visualMagnitude: 7.00,
    bvColour: 2.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.90526457),
        dec: Angle.Degrees(-21.25009563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221385"},
        {"Hipparcos Number", "HIP 116125"},
        {"Geneva Identification System", "GEN# +1.00221385"},
        {"Smithsonian Astrophysical Observation", "SAO 191971"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.95173823),
        dec: Angle.Degrees(-21.25004242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170659"},
        {"Hipparcos Number", "HIP 90811"},
        {"Smithsonian Astrophysical Observation", "SAO 186914"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.87078931),
        dec: Angle.Degrees(-21.24942279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314217"},
        {"Hipparcos Number", "HIP 89687"},
        {"Geneva Identification System", "GEN# +1.00314217"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.54246046),
        dec: Angle.Degrees(-21.24881170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27666"},
        {"Hipparcos Number", "HIP 20313"},
        {"Geneva Identification System", "GEN# +1.00027666"},
        {"Smithsonian Astrophysical Observation", "SAO 169359"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.27265321),
        dec: Angle.Degrees(-21.24821618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18428"},
        {"Hipparcos Number", "HIP 13764"},
        {"Smithsonian Astrophysical Observation", "SAO 168176"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.29009586),
        dec: Angle.Degrees(-21.24763085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3375 AB"},
        {"Henry Draper", "HD 29674"},
        {"Hipparcos Number", "HIP 21704"},
        {"Smithsonian Astrophysical Observation", "SAO 169640"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.90424264),
        dec: Angle.Degrees(-21.24759919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21996"},
        {"Hipparcos Number", "HIP 16466"},
        {"Geneva Identification System", "GEN# +1.00021996"},
        {"Smithsonian Astrophysical Observation", "SAO 168614"},
        {"Wilson Evans Batten Catalogue", "WEB 3147"},
    },
    visualMagnitude: 9.36,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.01985408),
        dec: Angle.Degrees(-21.24757030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182648"},
        {"Hipparcos Number", "HIP 95577"},
        {"Smithsonian Astrophysical Observation", "SAO 188123"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61520489),
        dec: Angle.Degrees(-21.24589214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68783"},
        {"Hipparcos Number", "HIP 40243"},
        {"Smithsonian Astrophysical Observation", "SAO 175395"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.29654352),
        dec: Angle.Degrees(-21.24142912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21702",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3375 C"},
        {"Hipparcos Number", "HIP 21702"},
        {"Smithsonian Astrophysical Observation", "SAO 169639"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.89562039),
        dec: Angle.Degrees(-21.23976128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24927",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3930 A"},
        {"Henry Draper", "HD 34968"},
        {"Hipparcos Number", "HIP 24927"},
        {"Geneva Identification System", "GEN# +1.00034968"},
        {"Renson", "Renson 8933"},
        {"Smithsonian Astrophysical Observation", "SAO 170327"},
        {"Wilson Evans Batten Catalogue", "WEB 4828"},
    },
    visualMagnitude: 4.70,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.11213225),
        dec: Angle.Degrees(-21.23973932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170016"},
        {"Hipparcos Number", "HIP 90516"},
        {"Smithsonian Astrophysical Observation", "SAO 186852"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.04225122),
        dec: Angle.Degrees(-21.23869952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23134"},
        {"Hipparcos Number", "HIP 17284"},
        {"Geneva Identification System", "GEN# +1.00023134"},
        {"Smithsonian Astrophysical Observation", "SAO 168750"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50820084),
        dec: Angle.Degrees(-21.23720332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79743"},
    },
    visualMagnitude: 12.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.11967706),
        dec: Angle.Degrees(-21.23711715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51443"},
        {"Geneva Identification System", "GEN# -0.02003194"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.59269340),
        dec: Angle.Degrees(-21.23666638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -446.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132818"},
        {"Hipparcos Number", "HIP 73527"},
        {"Smithsonian Astrophysical Observation", "SAO 183095"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.43199001),
        dec: Angle.Degrees(-21.23555172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179770"},
        {"Hipparcos Number", "HIP 94550"},
        {"Smithsonian Astrophysical Observation", "SAO 187868"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.65551833),
        dec: Angle.Degrees(-21.23552322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77360",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9784 A"},
        {"Henry Draper", "HD 141029"},
        {"Hipparcos Number", "HIP 77360"},
        {"Geneva Identification System", "GEN# +1.00141029"},
        {"Smithsonian Astrophysical Observation", "SAO 183793"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.88026114),
        dec: Angle.Degrees(-21.23363891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197355"},
        {"Hipparcos Number", "HIP 102310"},
        {"Geneva Identification System", "GEN# +1.00197355"},
        {"Smithsonian Astrophysical Observation", "SAO 189621"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.94884550),
        dec: Angle.Degrees(-21.23343884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90518"},
    },
    visualMagnitude: 10.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)28, 10.8100),
        dec: Angle.DegreesMinutesSeconds((int)-21, (int)13, 58.200)
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
    primaryId: "HIP 109509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210464"},
        {"Hipparcos Number", "HIP 109509"},
        {"Geneva Identification System", "GEN# +1.00210464"},
        {"Smithsonian Astrophysical Observation", "SAO 190945"},
        {"Wilson Evans Batten Catalogue", "WEB 19676"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.75960052),
        dec: Angle.Degrees(-21.23268636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17977"},
        {"Hipparcos Number", "HIP 13416"},
        {"Geneva Identification System", "GEN# +1.00017977"},
        {"Smithsonian Astrophysical Observation", "SAO 168116"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.18685932),
        dec: Angle.Degrees(-21.23138636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198649"},
        {"Hipparcos Number", "HIP 103027"},
        {"Smithsonian Astrophysical Observation", "SAO 189794"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.08996199),
        dec: Angle.Degrees(-21.23092014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176063"},
        {"Hipparcos Number", "HIP 93213"},
        {"Smithsonian Astrophysical Observation", "SAO 187538"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.80480471),
        dec: Angle.Degrees(-21.23064249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37861"},
        {"Hipparcos Number", "HIP 26715"},
        {"Smithsonian Astrophysical Observation", "SAO 170679"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.16774439),
        dec: Angle.Degrees(-21.23001939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55758",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8156 AB"},
        {"Henry Draper", "HD 99308"},
        {"Hipparcos Number", "HIP 55758"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.37499698),
        dec: Angle.Degrees(-21.22838539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139497"},
        {"Hipparcos Number", "HIP 76657"},
        {"Geneva Identification System", "GEN# +1.00139497"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.80676680),
        dec: Angle.Degrees(-21.22742328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108429"},
        {"Hipparcos Number", "HIP 60785"},
        {"Smithsonian Astrophysical Observation", "SAO 180812"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.87647841),
        dec: Angle.Degrees(-21.22659023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91121"},
        {"Hipparcos Number", "HIP 51477"},
        {"Geneva Identification System", "GEN# +1.00091121"},
        {"Smithsonian Astrophysical Observation", "SAO 178915"},
        {"Wilson Evans Batten Catalogue", "WEB 9395"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.71590722),
        dec: Angle.Degrees(-21.22596730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37217"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.66947798),
        dec: Angle.Degrees(-21.22342385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 454.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -474.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119591"},
        {"Hipparcos Number", "HIP 67048"},
        {"Smithsonian Astrophysical Observation", "SAO 181918"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.11243996),
        dec: Angle.Degrees(-21.22328235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32776"},
        {"Hipparcos Number", "HIP 23620"},
        {"Smithsonian Astrophysical Observation", "SAO 170039"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.17390977),
        dec: Angle.Degrees(-21.22089892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64059"},
        {"Hipparcos Number", "HIP 38339"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80008383),
        dec: Angle.Degrees(-21.21962094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121080"},
        {"Hipparcos Number", "HIP 67845"},
        {"Smithsonian Astrophysical Observation", "SAO 182057"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.45907801),
        dec: Angle.Degrees(-21.21853178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31599"},
        {"Hipparcos Number", "HIP 22952"},
        {"Geneva Identification System", "GEN# +1.00031599"},
        {"Wilson Evans Batten Catalogue", "WEB 4458"},
    },
    visualMagnitude: 10.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.07483245),
        dec: Angle.Degrees(-21.21708381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4339"},
        {"Hipparcos Number", "HIP 3580"},
        {"Geneva Identification System", "GEN# +1.00004339"},
        {"Smithsonian Astrophysical Observation", "SAO 166544"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.43116954),
        dec: Angle.Degrees(-21.21689995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77232"},
        {"Hipparcos Number", "HIP 44246"},
        {"Geneva Identification System", "GEN# +1.00077232"},
        {"Smithsonian Astrophysical Observation", "SAO 176820"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.15853383),
        dec: Angle.Degrees(-21.21594048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119462"},
        {"Hipparcos Number", "HIP 66991"},
        {"Smithsonian Astrophysical Observation", "SAO 181909"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.93694672),
        dec: Angle.Degrees(-21.21282702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109132"},
        {"Hipparcos Number", "HIP 61208"},
        {"Fundamental Katalog 5th Edition", "FK5 3003"},
        {"Smithsonian Astrophysical Observation", "SAO 180879"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.13705492),
        dec: Angle.Degrees(-21.21200466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30439"},
        {"Hipparcos Number", "HIP 22231"},
        {"Fundamental Katalog 5th Edition", "FK5 2357"},
        {"Geneva Identification System", "GEN# +1.00030439"},
        {"Smithsonian Astrophysical Observation", "SAO 169760"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.73841181),
        dec: Angle.Degrees(-21.21148124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28075"},
        {"Hipparcos Number", "HIP 20617"},
        {"Geneva Identification System", "GEN# +1.00028075"},
        {"Smithsonian Astrophysical Observation", "SAO 169422"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.25567915),
        dec: Angle.Degrees(-21.21126259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137725"},
        {"Hipparcos Number", "HIP 75732"},
        {"Geneva Identification System", "GEN# +1.00137725"},
        {"Smithsonian Astrophysical Observation", "SAO 183495"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.07758871),
        dec: Angle.Degrees(-21.20956718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 452"},
        {"Hipparcos Number", "HIP 724"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.24674499),
        dec: Angle.Degrees(-21.20630061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219553"},
        {"Hipparcos Number", "HIP 114933"},
        {"Fundamental Katalog 5th Edition", "FK5 6057"},
        {"Smithsonian Astrophysical Observation", "SAO 191787"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20705088),
        dec: Angle.Degrees(-21.20297193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72854"},
        {"Hipparcos Number", "HIP 42062"},
        {"Geneva Identification System", "GEN# +1.00072854"},
        {"Smithsonian Astrophysical Observation", "SAO 176095"},
        {"Wilson Evans Batten Catalogue", "WEB 8086"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.60602934),
        dec: Angle.Degrees(-21.20222615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165553"},
        {"Hipparcos Number", "HIP 88768"},
        {"Geneva Identification System", "GEN# +1.00165553"},
        {"Smithsonian Astrophysical Observation", "SAO 186305"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83418133),
        dec: Angle.Degrees(-21.20161448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9796"},
        {"Hipparcos Number", "HIP 7396"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.83701944),
        dec: Angle.Degrees(-21.20091563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41990"},
        {"Hipparcos Number", "HIP 29018"},
        {"Smithsonian Astrophysical Observation", "SAO 171264"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.84776631),
        dec: Angle.Degrees(-21.19972892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90700"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.57554500),
        dec: Angle.Degrees(-21.19921187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87060"},
        {"Smithsonian Astrophysical Observation", "SAO 185756"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.85504403),
        dec: Angle.Degrees(-21.19893166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79915"},
        {"Hipparcos Number", "HIP 45491"},
        {"Geneva Identification System", "GEN# +1.00079915"},
        {"Smithsonian Astrophysical Observation", "SAO 177191"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.04217550),
        dec: Angle.Degrees(-21.19731760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10337"},
        {"Geneva Identification System", "GEN# -0.02100397"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.29970594),
        dec: Angle.Degrees(-21.19658781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 377.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123697"},
        {"Hipparcos Number", "HIP 69179"},
        {"Smithsonian Astrophysical Observation", "SAO 182296"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.40614942),
        dec: Angle.Degrees(-21.19657474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34294"},
        {"Hipparcos Number", "HIP 24519"},
        {"Smithsonian Astrophysical Observation", "SAO 170241"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.90526776),
        dec: Angle.Degrees(-21.19647454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1000"},
        {"Hipparcos Number", "HIP 1147"},
        {"Cincinnati Publication", "Ci 18 20"},
        {"Geneva Identification System", "GEN# +1.00001000"},
        {"Smithsonian Astrophysical Observation", "SAO 166138"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58685990),
        dec: Angle.Degrees(-21.19639424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204139"},
        {"Hipparcos Number", "HIP 105928"},
        {"Geneva Identification System", "GEN# +1.00204139"},
        {"Smithsonian Astrophysical Observation", "SAO 190349"},
        {"Wilson Evans Batten Catalogue", "WEB 19208"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.81181113),
        dec: Angle.Degrees(-21.19612774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18195"},
        {"Hipparcos Number", "HIP 13564"},
        {"Smithsonian Astrophysical Observation", "SAO 168137"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.68045588),
        dec: Angle.Degrees(-21.19529687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123413"},
        {"Hipparcos Number", "HIP 69034"},
        {"Smithsonian Astrophysical Observation", "SAO 182269"},
        {"Wilson Evans Batten Catalogue", "WEB 12056"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.97535606),
        dec: Angle.Degrees(-21.19528321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129345"},
        {"Hipparcos Number", "HIP 71916"},
        {"Geneva Identification System", "GEN# +1.00129345"},
        {"Smithsonian Astrophysical Observation", "SAO 182786"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64547775),
        dec: Angle.Degrees(-21.19378337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201184"},
        {"Hipparcos Number", "HIP 104365"},
        {"Fundamental Katalog 5th Edition", "FK5 3690"},
        {"Geneva Identification System", "GEN# +1.00201184"},
        {"Renson", "Renson 56140"},
        {"Smithsonian Astrophysical Observation", "SAO 190050"},
        {"Wilson Evans Batten Catalogue", "WEB 19001"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.14005380),
        dec: Angle.Degrees(-21.19352539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220765"},
        {"Hipparcos Number", "HIP 115702"},
        {"Smithsonian Astrophysical Observation", "SAO 191906"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.63017124),
        dec: Angle.Degrees(-21.18998845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56634"},
        {"Hipparcos Number", "HIP 35255"},
        {"Smithsonian Astrophysical Observation", "SAO 173373"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.26801886),
        dec: Angle.Degrees(-21.18897892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102810"},
        {"Hipparcos Number", "HIP 57717"},
        {"Smithsonian Astrophysical Observation", "SAO 180226"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.54747785),
        dec: Angle.Degrees(-21.18847403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50491"},
        {"Hipparcos Number", "HIP 33007"},
        {"Celescope Catalog", "CEL 1416"},
        {"Geneva Identification System", "GEN# +1.00050491"},
        {"Smithsonian Astrophysical Observation", "SAO 172486"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.16962545),
        dec: Angle.Degrees(-21.18428796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113833"},
        {"Hipparcos Number", "HIP 63985"},
        {"Smithsonian Astrophysical Observation", "SAO 181390"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.67436917),
        dec: Angle.Degrees(-21.18345118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216333"},
        {"Hipparcos Number", "HIP 112944"},
        {"Geneva Identification System", "GEN# +1.00216333"},
        {"Smithsonian Astrophysical Observation", "SAO 191455"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.11846365),
        dec: Angle.Degrees(-21.18303494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208735"},
        {"Hipparcos Number", "HIP 108494"},
        {"Fundamental Katalog 5th Edition", "FK5 3757"},
        {"Geneva Identification System", "GEN# +1.00208735"},
        {"Smithsonian Astrophysical Observation", "SAO 190786"},
        {"Wilson Evans Batten Catalogue", "WEB 19534"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.68240204),
        dec: Angle.Degrees(-21.18292943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86391"},
        {"Hipparcos Number", "HIP 48845"},
        {"Geneva Identification System", "GEN# +1.00086391"},
        {"Smithsonian Astrophysical Observation", "SAO 178235"},
        {"Wilson Evans Batten Catalogue", "WEB 9078"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.44601725),
        dec: Angle.Degrees(-21.18217014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49846"},
        {"Hipparcos Number", "HIP 32721"},
        {"Celescope Catalog", "CEL 1397"},
        {"Geneva Identification System", "GEN# +1.00049846"},
        {"Smithsonian Astrophysical Observation", "SAO 172379"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39648779),
        dec: Angle.Degrees(-21.18124700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5669"},
        {"Hipparcos Number", "HIP 4539"},
        {"Geneva Identification System", "GEN# +1.00005669"},
        {"Smithsonian Astrophysical Observation", "SAO 166712"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.53629140),
        dec: Angle.Degrees(-21.17953664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93640"},
        {"Hipparcos Number", "HIP 52844"},
        {"Geneva Identification System", "GEN# +1.00093640"},
        {"Smithsonian Astrophysical Observation", "SAO 179238"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.08076663),
        dec: Angle.Degrees(-21.17694505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129980"},
        {"Hipparcos Number", "HIP 72217"},
        {"Geneva Identification System", "GEN# +1.00129980J"},
        {"Smithsonian Astrophysical Observation", "SAO 182858"},
        {"Wilson Evans Batten Catalogue", "WEB 12425"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.54548169),
        dec: Angle.Degrees(-21.17571461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35997",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6065 AB"},
        {"Henry Draper", "HD 58510"},
        {"Hipparcos Number", "HIP 35997"},
        {"Celescope Catalog", "CEL 1837"},
        {"Geneva Identification System", "GEN# +1.00058510J"},
        {"Smithsonian Astrophysical Observation", "SAO 173684"},
        {"Wilson Evans Batten Catalogue", "WEB 7170"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.28319954),
        dec: Angle.Degrees(-21.17386366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101245"},
        {"Hipparcos Number", "HIP 56823"},
        {"Renson", "Renson 29180"},
        {"Smithsonian Astrophysical Observation", "SAO 180064"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.72563620),
        dec: Angle.Degrees(-21.17380567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64152"},
        {"Hipparcos Number", "HIP 38375"},
        {"Geneva Identification System", "GEN# +1.00064152"},
        {"Smithsonian Astrophysical Observation", "SAO 174679"},
        {"Wilson Evans Batten Catalogue", "WEB 7547"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.92939105),
        dec: Angle.Degrees(-21.17374245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218594"},
        {"Hipparcos Number", "HIP 114341"},
        {"Fundamental Katalog 5th Edition", "FK5 873"},
        {"Geneva Identification System", "GEN# +1.00218594"},
        {"Smithsonian Astrophysical Observation", "SAO 191683"},
        {"Wilson Evans Batten Catalogue", "WEB 20300"},
    },
    visualMagnitude: 3.68,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.36150879),
        dec: Angle.Degrees(-21.17248555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16875"},
        {"Hipparcos Number", "HIP 12576"},
        {"Smithsonian Astrophysical Observation", "SAO 167975"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.42916220),
        dec: Angle.Degrees(-21.17183192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194021"},
        {"Hipparcos Number", "HIP 100608"},
        {"Smithsonian Astrophysical Observation", "SAO 189240"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02353171),
        dec: Angle.Degrees(-21.17161271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11761"},
    },
    visualMagnitude: 11.54,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.93902828),
        dec: Angle.Degrees(-21.16960574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74706"},
        {"Hipparcos Number", "HIP 42928"},
        {"Fundamental Katalog 5th Edition", "FK5 1229"},
        {"Geneva Identification System", "GEN# +1.00074706"},
        {"Smithsonian Astrophysical Observation", "SAO 176404"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.22984766),
        dec: Angle.Degrees(-21.16783642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96403"},
        {"Hipparcos Number", "HIP 54302"},
        {"Smithsonian Astrophysical Observation", "SAO 179537"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.63707798),
        dec: Angle.Degrees(-21.16687754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74063"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.04444083),
        dec: Angle.Degrees(-21.16676930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18486"},
        {"Smithsonian Astrophysical Observation", "SAO 168982"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.27235331),
        dec: Angle.Degrees(-21.15853538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7618"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.53423237),
        dec: Angle.Degrees(-21.15803111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 496.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -657.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194268"},
        {"Hipparcos Number", "HIP 100740"},
        {"Smithsonian Astrophysical Observation", "SAO 189267"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.36565977),
        dec: Angle.Degrees(-21.15731849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143438"},
        {"Hipparcos Number", "HIP 78467"},
        {"Fundamental Katalog 5th Edition", "FK5 5415"},
        {"Smithsonian Astrophysical Observation", "SAO 184029"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.27437239),
        dec: Angle.Degrees(-21.15560921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84285"},
        {"Hipparcos Number", "HIP 47726"},
        {"Smithsonian Astrophysical Observation", "SAO 177898"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93715711),
        dec: Angle.Degrees(-21.15549053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162779"},
        {"Hipparcos Number", "HIP 87588"},
        {"Smithsonian Astrophysical Observation", "SAO 185907"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.38989723),
        dec: Angle.Degrees(-21.15416677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4714"},
        {"Hipparcos Number", "HIP 3825"},
        {"Geneva Identification System", "GEN# +1.00004714"},
        {"Smithsonian Astrophysical Observation", "SAO 166601"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.27593677),
        dec: Angle.Degrees(-21.15105220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40883"},
        {"Hipparcos Number", "HIP 28486"},
        {"Smithsonian Astrophysical Observation", "SAO 171126"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.20721331),
        dec: Angle.Degrees(-21.14828176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51515"},
        {"Hipparcos Number", "HIP 33403"},
        {"Geneva Identification System", "GEN# +1.00051515"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.21269088),
        dec: Angle.Degrees(-21.14760027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59076"},
        {"Henry Draper 2", "HD 59077"},
        {"Hipparcos Number", "HIP 36223"},
        {"Geneva Identification System", "GEN# +1.00059076"},
        {"Smithsonian Astrophysical Observation", "SAO 173770"},
        {"Wilson Evans Batten Catalogue", "WEB 7214"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.89149298),
        dec: Angle.Degrees(-21.14603566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75628"},
        {"Hipparcos Number", "HIP 43398"},
        {"Smithsonian Astrophysical Observation", "SAO 176549"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.60325604),
        dec: Angle.Degrees(-21.14480469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55835"},
        {"Hipparcos Number", "HIP 34949"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.47154290),
        dec: Angle.Degrees(-21.14441088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155447"},
        {"Hipparcos Number", "HIP 84178"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.11953616),
        dec: Angle.Degrees(-21.14286635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33404"},
    },
    visualMagnitude: 12.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.21301064),
        dec: Angle.Degrees(-21.14147005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208271"},
        {"Hipparcos Number", "HIP 108236"},
        {"Smithsonian Astrophysical Observation", "SAO 190741"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.90995743),
        dec: Angle.Degrees(-21.13989696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 251 AB"},
        {"Henry Draper", "HD 1431"},
        {"Hipparcos Number", "HIP 1464"},
        {"Geneva Identification System", "GEN# +1.00001431J"},
        {"Smithsonian Astrophysical Observation", "SAO 166174"},
        {"Wilson Evans Batten Catalogue", "WEB 271"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57061289),
        dec: Angle.Degrees(-21.13845530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53269"},
        {"Hipparcos Number", "HIP 34117"},
        {"Celescope Catalog", "CEL 1538"},
        {"Geneva Identification System", "GEN# +1.00053269"},
    },
    visualMagnitude: 11.08,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.11268786),
        dec: Angle.Degrees(-21.13746092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28995"},
        {"Hipparcos Number", "HIP 21232"},
        {"Geneva Identification System", "GEN# +1.00028995"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.31754383),
        dec: Angle.Degrees(-21.13485632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84132"},
        {"Hipparcos Number", "HIP 47607"},
        {"Geneva Identification System", "GEN# +1.00084132"},
        {"Smithsonian Astrophysical Observation", "SAO 177870"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.61561243),
        dec: Angle.Degrees(-21.13436254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122391"},
        {"Hipparcos Number", "HIP 68552"},
        {"Smithsonian Astrophysical Observation", "SAO 182179"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.49969624),
        dec: Angle.Degrees(-21.13311660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37511"},
        {"Wilson Evans Batten Catalogue", "WEB 7421"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.47871497),
        dec: Angle.Degrees(-21.13307797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12155"},
        {"Hipparcos Number", "HIP 9249"},
        {"Geneva Identification System", "GEN# +1.00012155"},
        {"Smithsonian Astrophysical Observation", "SAO 167448"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72721758),
        dec: Angle.Degrees(-21.13285072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186952"},
        {"Hipparcos Number", "HIP 97427"},
        {"Smithsonian Astrophysical Observation", "SAO 188584"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.01929761),
        dec: Angle.Degrees(-21.13098802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85244"},
        {"Hipparcos Number", "HIP 48231"},
        {"Renson", "Renson 24350"},
        {"Smithsonian Astrophysical Observation", "SAO 178063"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.50191253),
        dec: Angle.Degrees(-21.12949234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26238"},
        {"Hipparcos Number", "HIP 19310"},
        {"Geneva Identification System", "GEN# +1.00026238"},
        {"Smithsonian Astrophysical Observation", "SAO 169161"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.08862283),
        dec: Angle.Degrees(-21.12886290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4783"},
        {"Hipparcos Number", "HIP 3872"},
        {"Smithsonian Astrophysical Observation", "SAO 166609"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.42795270),
        dec: Angle.Degrees(-21.12885558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8422"},
        {"Hipparcos Number", "HIP 6460"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.77112915),
        dec: Angle.Degrees(-21.12715407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96050"},
        {"Hipparcos Number", "HIP 54138"},
        {"Geneva Identification System", "GEN# +1.00096050"},
        {"Smithsonian Astrophysical Observation", "SAO 179500"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.13343669),
        dec: Angle.Degrees(-21.12650634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195040"},
        {"Hipparcos Number", "HIP 101098"},
        {"Smithsonian Astrophysical Observation", "SAO 189349"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.40355929),
        dec: Angle.Degrees(-21.12628885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40138"},
        {"Hipparcos Number", "HIP 28081"},
        {"Smithsonian Astrophysical Observation", "SAO 171031"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.04436269),
        dec: Angle.Degrees(-21.12262854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35507"},
        {"Hipparcos Number", "HIP 25272"},
        {"Smithsonian Astrophysical Observation", "SAO 170392"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.06792269),
        dec: Angle.Degrees(-21.12181076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140258"},
        {"Hipparcos Number", "HIP 77000"},
        {"Smithsonian Astrophysical Observation", "SAO 183736"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.83128744),
        dec: Angle.Degrees(-21.12022359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14118"},
        {"Hipparcos Number", "HIP 10608"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.14228222),
        dec: Angle.Degrees(-21.11909192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82734"},
        {"Hipparcos Number", "HIP 46880"},
        {"Fundamental Katalog 5th Edition", "FK5 1247"},
        {"Geneva Identification System", "GEN# +1.00082734"},
        {"Smithsonian Astrophysical Observation", "SAO 177642"},
        {"Wilson Evans Batten Catalogue", "WEB 8837"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.30196880),
        dec: Angle.Degrees(-21.11575904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156897"},
        {"Hipparcos Number", "HIP 84893"},
        {"Geneva Identification System", "GEN# +1.00156897"},
        {"Smithsonian Astrophysical Observation", "SAO 185296"},
        {"Wilson Evans Batten Catalogue", "WEB 14338"},
    },
    visualMagnitude: 4.39,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.25087615),
        dec: Angle.Degrees(-21.11243499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48354"},
        {"Hipparcos Number", "HIP 32087"},
        {"Smithsonian Astrophysical Observation", "SAO 172186"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.55034254),
        dec: Angle.Degrees(-21.11228164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218970"},
        {"Hipparcos Number", "HIP 114569"},
        {"Geneva Identification System", "GEN# +1.00218970"},
        {"Renson", "Renson 60220"},
        {"Smithsonian Astrophysical Observation", "SAO 191720"},
    },
    visualMagnitude: 9.74,
    bvColour: -0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.12750287),
        dec: Angle.Degrees(-21.11214930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94768"},
        {"Hipparcos Number", "HIP 53458"},
        {"Geneva Identification System", "GEN# +1.00094768"},
        {"Smithsonian Astrophysical Observation", "SAO 179352"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.03569939),
        dec: Angle.Degrees(-21.11036497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132780"},
        {"Hipparcos Number", "HIP 73513"},
        {"Smithsonian Astrophysical Observation", "SAO 183092"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.37650566),
        dec: Angle.Degrees(-21.11002456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5057"},
        {"Hipparcos Number", "HIP 4073"},
        {"Geneva Identification System", "GEN# +1.00005057"},
        {"Smithsonian Astrophysical Observation", "SAO 166638"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.05492976),
        dec: Angle.Degrees(-21.10789802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145964"},
        {"Hipparcos Number", "HIP 79599"},
        {"Geneva Identification System", "GEN# +1.00145964"},
        {"Smithsonian Astrophysical Observation", "SAO 184253"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.62038964),
        dec: Angle.Degrees(-21.10756359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30128"},
        {"Hipparcos Number", "HIP 22018"},
        {"Geneva Identification System", "GEN# +1.00030128"},
        {"Smithsonian Astrophysical Observation", "SAO 169704"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.01301498),
        dec: Angle.Degrees(-21.10693569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34993"},
        {"Smithsonian Astrophysical Observation", "SAO 173267"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.60815763),
        dec: Angle.Degrees(-21.10690293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175775"},
        {"Hipparcos Number", "HIP 93085"},
        {"Fundamental Katalog 5th Edition", "FK5 710"},
        {"Geneva Identification System", "GEN# +1.00175775"},
        {"Smithsonian Astrophysical Observation", "SAO 187504"},
        {"Wilson Evans Batten Catalogue", "WEB 16125"},
    },
    visualMagnitude: 3.52,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.43241556),
        dec: Angle.Degrees(-21.10662433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23435"},
        {"Hipparcos Number", "HIP 17449"},
        {"Smithsonian Astrophysical Observation", "SAO 168785"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.08997410),
        dec: Angle.Degrees(-21.10641835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145467"},
        {"Hipparcos Number", "HIP 79369"},
        {"Smithsonian Astrophysical Observation", "SAO 184214"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.98134913),
        dec: Angle.Degrees(-21.10494511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149544"},
        {"Hipparcos Number", "HIP 81295"},
        {"Smithsonian Astrophysical Observation", "SAO 184489"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.06899154),
        dec: Angle.Degrees(-21.10193324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51549"},
        {"Hipparcos Number", "HIP 33412"},
        {"Celescope Catalog", "CEL 1450"},
        {"Geneva Identification System", "GEN# +1.00051549"},
        {"Smithsonian Astrophysical Observation", "SAO 172617"},
        {"Wilson Evans Batten Catalogue", "WEB 6716"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.23027959),
        dec: Angle.Degrees(-21.10137423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20965"},
        {"Hipparcos Number", "HIP 15702"},
        {"Geneva Identification System", "GEN# +1.00020965"},
        {"Smithsonian Astrophysical Observation", "SAO 168492"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.56843834),
        dec: Angle.Degrees(-21.10007618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34432"},
        {"Hipparcos Number", "HIP 24592"},
        {"Smithsonian Astrophysical Observation", "SAO 170260"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.12726137),
        dec: Angle.Degrees(-21.10007375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32488"},
        {"Hipparcos Number", "HIP 23472"},
        {"Geneva Identification System", "GEN# +1.00032488"},
        {"Smithsonian Astrophysical Observation", "SAO 170009"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68503991),
        dec: Angle.Degrees(-21.09935655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8616"},
        {"Hipparcos Number", "HIP 6590"},
        {"Geneva Identification System", "GEN# +1.00008616"},
        {"Smithsonian Astrophysical Observation", "SAO 167027"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.16671835),
        dec: Angle.Degrees(-21.09534172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87064"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.86927779),
        dec: Angle.Degrees(-21.09525602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202"},
        {"Hipparcos Number", "HIP 553"},
        {"Geneva Identification System", "GEN# +1.00000202"},
        {"Smithsonian Astrophysical Observation", "SAO 166052"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69021404),
        dec: Angle.Degrees(-21.09148372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -246.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -433.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222734"},
        {"Hipparcos Number", "HIP 117017"},
        {"Smithsonian Astrophysical Observation", "SAO 192105"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.82666607),
        dec: Angle.Degrees(-21.09015504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214172"},
        {"Hipparcos Number", "HIP 111622"},
        {"Geneva Identification System", "GEN# +1.00214172"},
        {"Smithsonian Astrophysical Observation", "SAO 191265"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.19495337),
        dec: Angle.Degrees(-21.08963197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189743"},
        {"Hipparcos Number", "HIP 98650"},
        {"Smithsonian Astrophysical Observation", "SAO 188840"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.55744544),
        dec: Angle.Degrees(-21.08832726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9497"},
        {"Hipparcos Number", "HIP 7208"},
        {"Geneva Identification System", "GEN# +1.00009497"},
        {"Smithsonian Astrophysical Observation", "SAO 167127"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21619464),
        dec: Angle.Degrees(-21.08807720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109222"},
        {"Hipparcos Number", "HIP 61259"},
        {"Smithsonian Astrophysical Observation", "SAO 180891"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.31619323),
        dec: Angle.Degrees(-21.08504970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72332"},
        {"Hipparcos Number", "HIP 41819"},
        {"Geneva Identification System", "GEN# +1.00072332"},
        {"Smithsonian Astrophysical Observation", "SAO 175996"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.88480341),
        dec: Angle.Degrees(-21.07810094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12274"},
        {"Hipparcos Number", "HIP 9347"},
        {"Fundamental Katalog 5th Edition", "FK5 71"},
        {"Geneva Identification System", "GEN# +1.00012274"},
        {"Smithsonian Astrophysical Observation", "SAO 167471"},
        {"Wilson Evans Batten Catalogue", "WEB 1962"},
    },
    visualMagnitude: 3.99,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.00093670),
        dec: Angle.Degrees(-21.07777193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15753 AB"},
        {"Aitken 2", "ADS 15753"},
        {"Henry Draper", "HD 210960"},
        {"Hipparcos Number", "HIP 109786"},
        {"Geneva Identification System", "GEN# +1.00210960"},
        {"Smithsonian Astrophysical Observation", "SAO 190986"},
        {"Wilson Evans Batten Catalogue", "WEB 19720"},
    },
    visualMagnitude: 5.33,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.57507383),
        dec: Angle.Degrees(-21.07470081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106254"},
        {"Hipparcos Number", "HIP 59619"},
        {"Smithsonian Astrophysical Observation", "SAO 180578"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.39584068),
        dec: Angle.Degrees(-21.07406079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21272"},
        {"Hipparcos Number", "HIP 15932"},
        {"Geneva Identification System", "GEN# +1.00021272"},
        {"Smithsonian Astrophysical Observation", "SAO 168528"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30281676),
        dec: Angle.Degrees(-21.07275492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23928"},
        {"Smithsonian Astrophysical Observation", "SAO 170107"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.13274434),
        dec: Angle.Degrees(-21.07054038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85404"},
        {"Hipparcos Number", "HIP 48323"},
        {"Geneva Identification System", "GEN# +1.00085404"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.75681302),
        dec: Angle.Degrees(-21.06838019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82846"},
        {"Hipparcos Number", "HIP 46948"},
        {"Smithsonian Astrophysical Observation", "SAO 177665"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.53037362),
        dec: Angle.Degrees(-21.06820874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37080"},
        {"Hipparcos Number", "HIP 26191"},
        {"Smithsonian Astrophysical Observation", "SAO 170576"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.74039128),
        dec: Angle.Degrees(-21.06768210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35295"},
        {"Geneva Identification System", "GEN# -0.02001834"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36864624),
        dec: Angle.Degrees(-21.06669957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187857"},
        {"Hipparcos Number", "HIP 97836"},
        {"Smithsonian Astrophysical Observation", "SAO 188669"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.21905823),
        dec: Angle.Degrees(-21.06650453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124575"},
        {"Hipparcos Number", "HIP 69613"},
        {"Geneva Identification System", "GEN# +1.00124575"},
        {"Smithsonian Astrophysical Observation", "SAO 182371"},
        {"Wilson Evans Batten Catalogue", "WEB 12121"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.71638727),
        dec: Angle.Degrees(-21.06476022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89341",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Polis"},
        {"Aitken", "ADS 11169 A"},
        {"Henry Draper", "HD 166937"},
        {"Hipparcos Number", "HIP 89341"},
        {"Fundamental Katalog 5th Edition", "FK5 682"},
        {"Geneva Identification System", "GEN# +1.00166937A"},
        {"Geneva Identification System 2", "GEN# +1.00314059A"},
        {"Smithsonian Astrophysical Observation", "SAO 186497"},
        {"Wilson Evans Batten Catalogue", "WEB 15190"},
    },
    visualMagnitude: 3.84,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.44086963),
        dec: Angle.Degrees(-21.05883031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162435"},
        {"Hipparcos Number", "HIP 87411"},
        {"Fundamental Katalog 5th Edition", "FK5 5570"},
        {"Geneva Identification System", "GEN# +1.00162435"},
        {"Smithsonian Astrophysical Observation", "SAO 185855"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.95681056),
        dec: Angle.Degrees(-21.05870806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106855"},
        {"Hipparcos Number", "HIP 59914"},
        {"Geneva Identification System", "GEN# +1.00106855"},
        {"Smithsonian Astrophysical Observation", "SAO 180648"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.35018700),
        dec: Angle.Degrees(-21.05800440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105605"},
        {"Hipparcos Number", "HIP 59275"},
        {"Smithsonian Astrophysical Observation", "SAO 180521"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.38347011),
        dec: Angle.Degrees(-21.05312067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174890"},
        {"Hipparcos Number", "HIP 92721"},
        {"Smithsonian Astrophysical Observation", "SAO 187416"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.40997035),
        dec: Angle.Degrees(-21.05151421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172051"},
        {"Hipparcos Number", "HIP 91438"},
        {"Geneva Identification System", "GEN# +1.00172051"},
        {"Smithsonian Astrophysical Observation", "SAO 187086"},
        {"Wilson Evans Batten Catalogue", "WEB 15715"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.72269706),
        dec: Angle.Degrees(-21.05150199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75495"},
        {"Hipparcos Number", "HIP 43338"},
        {"Geneva Identification System", "GEN# +1.00075495"},
        {"Smithsonian Astrophysical Observation", "SAO 176535"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.43724727),
        dec: Angle.Degrees(-21.04830272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95220"},
        {"Hipparcos Number", "HIP 53715"},
        {"Smithsonian Astrophysical Observation", "SAO 179403"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.85831204),
        dec: Angle.Degrees(-21.04684077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71196"},
        {"Hipparcos Number", "HIP 41282"},
        {"Geneva Identification System", "GEN# +1.00071196"},
        {"Smithsonian Astrophysical Observation", "SAO 175792"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32926230),
        dec: Angle.Degrees(-21.04610608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201353"},
        {"Hipparcos Number", "HIP 104455"},
        {"Smithsonian Astrophysical Observation", "SAO 190070"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39435610),
        dec: Angle.Degrees(-21.04597539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163935"},
        {"Hipparcos Number", "HIP 88095"},
        {"Smithsonian Astrophysical Observation", "SAO 186057"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.88207371),
        dec: Angle.Degrees(-21.04563848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58855"},
    },
    visualMagnitude: 10.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.06408709),
        dec: Angle.Degrees(-21.04423089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63869"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.35508321),
        dec: Angle.Degrees(-21.04342640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3596"},
        {"Hipparcos Number", "HIP 3051"},
        {"Geneva Identification System", "GEN# +1.00003596"},
        {"Smithsonian Astrophysical Observation", "SAO 166441"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.68878839),
        dec: Angle.Degrees(-21.04010918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183665"},
        {"Hipparcos Number", "HIP 96021"},
        {"Smithsonian Astrophysical Observation", "SAO 188234"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.85252382),
        dec: Angle.Degrees(-21.04002201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35021"},
        {"Hipparcos Number", "HIP 24974"},
        {"Smithsonian Astrophysical Observation", "SAO 170335"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.22986762),
        dec: Angle.Degrees(-21.03989753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36237"},
        {"Hipparcos Number", "HIP 25720"},
        {"Smithsonian Astrophysical Observation", "SAO 170480"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.37913695),
        dec: Angle.Degrees(-21.03979187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205638"},
        {"Hipparcos Number", "HIP 106729"},
        {"Smithsonian Astrophysical Observation", "SAO 190492"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.28775203),
        dec: Angle.Degrees(-21.03940687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104835"},
        {"Hipparcos Number", "HIP 58861"},
        {"Smithsonian Astrophysical Observation", "SAO 180426"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07132670),
        dec: Angle.Degrees(-21.03913650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314329"},
        {"Hipparcos Number", "HIP 89751"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.73564001),
        dec: Angle.Degrees(-21.03841104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101936"},
        {"Hipparcos Number", "HIP 57199"},
        {"Geneva Identification System", "GEN# +1.00101936"},
        {"Smithsonian Astrophysical Observation", "SAO 180138"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94630719),
        dec: Angle.Degrees(-21.03833242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16549"},
        {"Hipparcos Number", "HIP 12317"},
        {"Smithsonian Astrophysical Observation", "SAO 167940"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65092888),
        dec: Angle.Degrees(-21.03821049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15515"},
        {"Hipparcos Number", "HIP 11586"},
        {"Smithsonian Astrophysical Observation", "SAO 167823"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.32878411),
        dec: Angle.Degrees(-21.03790145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81109"},
        {"Hipparcos Number", "HIP 46027"},
        {"Smithsonian Astrophysical Observation", "SAO 177371"},
        {"Wilson Evans Batten Catalogue", "WEB 8720"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.81081990),
        dec: Angle.Degrees(-21.03776671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9607"},
        {"Hipparcos Number", "HIP 7284"},
        {"Geneva Identification System", "GEN# +1.00009607"},
        {"Smithsonian Astrophysical Observation", "SAO 167138"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.46641124),
        dec: Angle.Degrees(-21.03414393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64612"},
        {"Hipparcos Number", "HIP 38579"},
        {"Smithsonian Astrophysical Observation", "SAO 174756"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.49040928),
        dec: Angle.Degrees(-21.03226071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89312"},
        {"Hipparcos Number", "HIP 50439"},
        {"Fundamental Katalog 5th Edition", "FK5 4914"},
        {"Smithsonian Astrophysical Observation", "SAO 178638"},
        {"Wilson Evans Batten Catalogue", "WEB 9256"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.47240265),
        dec: Angle.Degrees(-21.02623901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5930 AB"},
        {"Henry Draper", "HD 56093"},
        {"Hipparcos Number", "HIP 35036"},
        {"Celescope Catalog", "CEL 1706"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70116022),
        dec: Angle.Degrees(-21.02407005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77936"},
        {"Hipparcos Number", "HIP 44570"},
        {"Smithsonian Astrophysical Observation", "SAO 176913"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.21051085),
        dec: Angle.Degrees(-21.02395676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94141",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Albaldah"},
        {"Henry Draper", "HD 178524"},
        {"Hipparcos Number", "HIP 94141"},
        {"Fundamental Katalog 5th Edition", "FK5 720"},
        {"Geneva Identification System", "GEN# +1.00178524J"},
        {"Smithsonian Astrophysical Observation", "SAO 187756"},
        {"Wilson Evans Batten Catalogue", "WEB 16397"},
    },
    visualMagnitude: 2.88,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.44097404),
        dec: Angle.Degrees(-21.02352534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38679"},
        {"Hipparcos Number", "HIP 27256"},
        {"Smithsonian Astrophysical Observation", "SAO 170820"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.66299650),
        dec: Angle.Degrees(-21.02225728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46446"},
        {"Hipparcos Number", "HIP 31178"},
        {"Smithsonian Astrophysical Observation", "SAO 171913"},
        {"Wilson Evans Batten Catalogue", "WEB 6229"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.13520806),
        dec: Angle.Degrees(-21.02180942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25467"},
        {"Hipparcos Number", "HIP 18816"},
        {"Smithsonian Astrophysical Observation", "SAO 169046"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.48101820),
        dec: Angle.Degrees(-21.02071272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218771"},
        {"Hipparcos Number", "HIP 114459"},
        {"Geneva Identification System", "GEN# +1.00218771"},
        {"Smithsonian Astrophysical Observation", "SAO 191705"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.71430518),
        dec: Angle.Degrees(-21.01807032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139329"},
        {"Hipparcos Number", "HIP 76569"},
        {"Geneva Identification System", "GEN# +1.00139329"},
        {"Smithsonian Astrophysical Observation", "SAO 183646"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56767525),
        dec: Angle.Degrees(-21.01615303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49333"},
        {"Hipparcos Number", "HIP 32504"},
        {"Geneva Identification System", "GEN# +2.22870109"},
        {"Geneva Identification System 2", "GEN# +5.11210037"},
        {"Renson", "Renson 13340"},
        {"Smithsonian Astrophysical Observation", "SAO 172318"},
        {"Wilson Evans Batten Catalogue", "WEB 6557"},
        {"New General Catalogue", "NGC 2287 109"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.75621912),
        dec: Angle.Degrees(-21.01541689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24541"},
        {"Hipparcos Number", "HIP 18191"},
        {"Smithsonian Astrophysical Observation", "SAO 168922"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.37649970),
        dec: Angle.Degrees(-21.01350038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73962"},
        {"Hipparcos Number", "HIP 42558"},
        {"Smithsonian Astrophysical Observation", "SAO 176268"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.11971850),
        dec: Angle.Degrees(-21.01310253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201809"},
        {"Hipparcos Number", "HIP 104708"},
        {"Smithsonian Astrophysical Observation", "SAO 190125"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.15309416),
        dec: Angle.Degrees(-21.01192469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14071"},
        {"Hipparcos Number", "HIP 10579"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.03866672),
        dec: Angle.Degrees(-21.00819871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28808"},
        {"Hipparcos Number", "HIP 21129"},
        {"Smithsonian Astrophysical Observation", "SAO 169537"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.93057701),
        dec: Angle.Degrees(-21.00814257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4602 B"},
        {"Hipparcos Number", "HIP 28488"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.21338542),
        dec: Angle.Degrees(-21.00786284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138821"},
        {"Hipparcos Number", "HIP 76302"},
        {"Renson", "Renson 39553"},
        {"Smithsonian Astrophysical Observation", "SAO 183595"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.79719169),
        dec: Angle.Degrees(-21.00782835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45109"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)11, 26.1100),
        dec: Angle.DegreesMinutesSeconds((int)-21, (int)00, 27.700)
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
    primaryId: "HIP 8439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11098"},
        {"Hipparcos Number", "HIP 8439"},
        {"Smithsonian Astrophysical Observation", "SAO 167317"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.20291367),
        dec: Angle.Degrees(-21.00658855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13288",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Angetenar"},
        {"Aitken", "ADS 2179 A"},
        {"Henry Draper", "HD 17824"},
        {"Hipparcos Number", "HIP 13288"},
        {"Fundamental Katalog 5th Edition", "FK5 102"},
        {"Geneva Identification System", "GEN# +1.00017824"},
        {"Smithsonian Astrophysical Observation", "SAO 168094"},
        {"Wilson Evans Batten Catalogue", "WEB 2665"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.75977464),
        dec: Angle.Degrees(-21.00397890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4602 A"},
        {"Henry Draper", "HD 40882"},
        {"Hipparcos Number", "HIP 28491"},
        {"Smithsonian Astrophysical Observation", "SAO 171128"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.21638347),
        dec: Angle.Degrees(-21.00374923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102913"},
        {"Hipparcos Number", "HIP 57771"},
        {"Smithsonian Astrophysical Observation", "SAO 180237"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.70900974),
        dec: Angle.Degrees(-21.00304602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218875"},
        {"Hipparcos Number", "HIP 114509"},
        {"Geneva Identification System", "GEN# +1.00218875"},
        {"Smithsonian Astrophysical Observation", "SAO 191713"},
        {"Wilson Evans Batten Catalogue", "WEB 20322"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.90047996),
        dec: Angle.Degrees(-21.00302224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173282"},
        {"Hipparcos Number", "HIP 92016"},
        {"Geneva Identification System", "GEN# +1.00173282"},
        {"Smithsonian Astrophysical Observation", "SAO 187234"},
        {"Wilson Evans Batten Catalogue", "WEB 15852"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.32767265),
        dec: Angle.Degrees(-21.00154643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13692"},
        {"Hipparcos Number", "HIP 10326"},
        {"Geneva Identification System", "GEN# +1.00013692"},
        {"Smithsonian Astrophysical Observation", "SAO 167637"},
        {"Wilson Evans Batten Catalogue", "WEB 2157"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.25396814),
        dec: Angle.Degrees(-21.00023660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190525"},
        {"Hipparcos Number", "HIP 99016"},
        {"Smithsonian Astrophysical Observation", "SAO 188911"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.53203241),
        dec: Angle.Degrees(-21.00013138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159454"},
        {"Hipparcos Number", "HIP 86089"},
        {"Smithsonian Astrophysical Observation", "SAO 185533"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.89797406),
        dec: Angle.Degrees(-20.99924543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204029"},
        {"Hipparcos Number", "HIP 105853"},
        {"Smithsonian Astrophysical Observation", "SAO 190337"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.59165526),
        dec: Angle.Degrees(-20.99907571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5078"},
        {"Hipparcos Number", "HIP 4093"},
        {"Geneva Identification System", "GEN# +1.00005078"},
        {"Smithsonian Astrophysical Observation", "SAO 166644"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.13304691),
        dec: Angle.Degrees(-20.99605992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210361"},
        {"Hipparcos Number", "HIP 109438"},
        {"Smithsonian Astrophysical Observation", "SAO 190938"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.57580520),
        dec: Angle.Degrees(-20.99404117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196495"},
        {"Hipparcos Number", "HIP 101858"},
        {"Smithsonian Astrophysical Observation", "SAO 189516"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.60594250),
        dec: Angle.Degrees(-20.99398131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111288"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.17401756),
        dec: Angle.Degrees(-20.99269108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 344.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178222"},
        {"Hipparcos Number", "HIP 94026"},
        {"Smithsonian Astrophysical Observation", "SAO 187724"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.14129716),
        dec: Angle.Degrees(-20.99140399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155429"},
        {"Hipparcos Number", "HIP 84154"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08107688),
        dec: Angle.Degrees(-20.99118711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164224"},
        {"Hipparcos Number", "HIP 88219"},
        {"Geneva Identification System", "GEN# +1.00164224"},
        {"Renson", "Renson 46430"},
        {"Smithsonian Astrophysical Observation", "SAO 186098"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24005601),
        dec: Angle.Degrees(-20.98808453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6400"},
        {"Hipparcos Number", "HIP 5056"},
        {"Smithsonian Astrophysical Observation", "SAO 166784"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.17798229),
        dec: Angle.Degrees(-20.98783787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120623"},
        {"Hipparcos Number", "HIP 67588"},
        {"Geneva Identification System", "GEN# +1.00120623"},
        {"Smithsonian Astrophysical Observation", "SAO 182020"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.73734402),
        dec: Angle.Degrees(-20.98486044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84169"},
        {"Hipparcos Number", "HIP 47637"},
        {"Smithsonian Astrophysical Observation", "SAO 177877"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.69208056),
        dec: Angle.Degrees(-20.98419596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142883"},
        {"Hipparcos Number", "HIP 78168"},
        {"Celescope Catalog", "CEL 4407"},
        {"Geneva Identification System", "GEN# +1.00142883"},
        {"Smithsonian Astrophysical Observation", "SAO 183972"},
        {"Wilson Evans Batten Catalogue", "WEB 13220"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.41862315),
        dec: Angle.Degrees(-20.98302564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98506"},
        {"Hipparcos Number", "HIP 55326"},
        {"Smithsonian Astrophysical Observation", "SAO 179774"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.94415828),
        dec: Angle.Degrees(-20.98205307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109035"},
        {"Hipparcos Number", "HIP 61155"},
        {"Smithsonian Astrophysical Observation", "SAO 180867"},
        {"Wilson Evans Batten Catalogue", "WEB 10889"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.97152407),
        dec: Angle.Degrees(-20.98177023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82272"},
        {"Hipparcos Number", "HIP 46628"},
        {"Geneva Identification System", "GEN# +1.00082272"},
        {"Smithsonian Astrophysical Observation", "SAO 177571"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.62931578),
        dec: Angle.Degrees(-20.97950382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159591"},
        {"Hipparcos Number", "HIP 86158"},
        {"Smithsonian Astrophysical Observation", "SAO 185544"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.09679703),
        dec: Angle.Degrees(-20.97723179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93262"},
        {"Hipparcos Number", "HIP 52640"},
        {"Geneva Identification System", "GEN# +1.00093262"},
        {"Smithsonian Astrophysical Observation", "SAO 179202"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46687078),
        dec: Angle.Degrees(-20.97466780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29961"},
        {"Henry Draper 2", "HD 29962"},
        {"Hipparcos Number", "HIP 21900"},
        {"Geneva Identification System", "GEN# +1.00029961"},
        {"Smithsonian Astrophysical Observation", "SAO 169681"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.63217923),
        dec: Angle.Degrees(-20.97310968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45304"},
        {"Hipparcos Number", "HIP 30592"},
        {"Smithsonian Astrophysical Observation", "SAO 171729"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.44074890),
        dec: Angle.Degrees(-20.97306113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11548"},
        {"Hipparcos Number", "HIP 8793"},
        {"Smithsonian Astrophysical Observation", "SAO 167377"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.26387668),
        dec: Angle.Degrees(-20.97156778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173141"},
        {"Hipparcos Number", "HIP 91954"},
        {"Smithsonian Astrophysical Observation", "SAO 187214"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.15921666),
        dec: Angle.Degrees(-20.97119718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139710"},
        {"Hipparcos Number", "HIP 76758"},
        {"Smithsonian Astrophysical Observation", "SAO 183689"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09595742),
        dec: Angle.Degrees(-20.97094416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155846"},
        {"Hipparcos Number", "HIP 84366"},
        {"Smithsonian Astrophysical Observation", "SAO 185190"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.72196794),
        dec: Angle.Degrees(-20.96946111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106350"},
    },
    visualMagnitude: 11.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.08819494),
        dec: Angle.Degrees(-20.96920313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100934"},
        {"Hipparcos Number", "HIP 56645"},
        {"Smithsonian Astrophysical Observation", "SAO 180034"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.23292903),
        dec: Angle.Degrees(-20.96779375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117121"},
    },
    visualMagnitude: 11.60,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.16256901),
        dec: Angle.Degrees(-20.96734063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 338.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51819"},
        {"Hipparcos Number", "HIP 33522"},
        {"Celescope Catalog", "CEL 1458"},
        {"Geneva Identification System", "GEN# +1.00051819"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50524451),
        dec: Angle.Degrees(-20.96684032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10561 AB"},
        {"Henry Draper", "HD 158122"},
        {"Hipparcos Number", "HIP 85491"},
        {"Geneva Identification System", "GEN# +1.00158122J"},
        {"Smithsonian Astrophysical Observation", "SAO 185428"},
        {"Wilson Evans Batten Catalogue", "WEB 14437"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.06746666),
        dec: Angle.Degrees(-20.96376124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173788"},
        {"Hipparcos Number", "HIP 92242"},
        {"Smithsonian Astrophysical Observation", "SAO 187297"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.98654093),
        dec: Angle.Degrees(-20.96321919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28221"},
        {"Hipparcos Number", "HIP 20721"},
        {"Geneva Identification System", "GEN# +1.00028221"},
        {"Smithsonian Astrophysical Observation", "SAO 169446"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.60853642),
        dec: Angle.Degrees(-20.96087606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196778"},
        {"Hipparcos Number", "HIP 101994"},
        {"Smithsonian Astrophysical Observation", "SAO 189551"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.04414900),
        dec: Angle.Degrees(-20.96054898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186938"},
        {"Hipparcos Number", "HIP 97417"},
        {"Geneva Identification System", "GEN# +1.00186938"},
        {"Smithsonian Astrophysical Observation", "SAO 188580"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.99990339),
        dec: Angle.Degrees(-20.95758846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204941"},
        {"Hipparcos Number", "HIP 106353"},
        {"Smithsonian Astrophysical Observation", "SAO 190421"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.09868346),
        dec: Angle.Degrees(-20.95711934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61940"},
        {"Hipparcos Number", "HIP 37401"},
        {"Smithsonian Astrophysical Observation", "SAO 174271"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.19210392),
        dec: Angle.Degrees(-20.95557992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44005"},
        {"Smithsonian Astrophysical Observation", "SAO 176745"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.40538782),
        dec: Angle.Degrees(-20.95555642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36562"},
        {"Hipparcos Number", "HIP 25912"},
        {"Smithsonian Astrophysical Observation", "SAO 170516"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.95418103),
        dec: Angle.Degrees(-20.95542755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224143"},
        {"Hipparcos Number", "HIP 117958"},
        {"Geneva Identification System", "GEN# +1.00224143"},
        {"Smithsonian Astrophysical Observation", "SAO 192241"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.89568959),
        dec: Angle.Degrees(-20.95328368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35940"},
        {"Geneva Identification System", "GEN# +2.23830008"},
        {"New General Catalogue", "NGC 2383 8"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.13321046),
        dec: Angle.Degrees(-20.95277363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90710"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.60964510),
        dec: Angle.Degrees(-20.95177614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117639"},
        {"Hipparcos Number", "HIP 66016"},
        {"Smithsonian Astrophysical Observation", "SAO 181729"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.01396773),
        dec: Angle.Degrees(-20.95089422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193151"},
        {"Hipparcos Number", "HIP 100201"},
        {"Geneva Identification System", "GEN# +1.00193151"},
        {"Renson", "Renson 53900"},
        {"Smithsonian Astrophysical Observation", "SAO 189142"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.85747764),
        dec: Angle.Degrees(-20.95076653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71833"},
        {"Hipparcos Number", "HIP 41603"},
        {"Geneva Identification System", "GEN# +1.00071833A"},
        {"Renson", "Renson 19830"},
        {"Smithsonian Astrophysical Observation", "SAO 175912"},
        {"Wilson Evans Batten Catalogue", "WEB 8028"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.22262147),
        dec: Angle.Degrees(-20.95036098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198994"},
        {"Hipparcos Number", "HIP 103218"},
        {"Smithsonian Astrophysical Observation", "SAO 189827"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.68173332),
        dec: Angle.Degrees(-20.94925963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87672"},
        {"Hipparcos Number", "HIP 49481"},
        {"Smithsonian Astrophysical Observation", "SAO 178403"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.53639106),
        dec: Angle.Degrees(-20.94867109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2798"},
        {"Hipparcos Number", "HIP 2461"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.81867980),
        dec: Angle.Degrees(-20.94806971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209066"},
        {"Hipparcos Number", "HIP 108694"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.27562514),
        dec: Angle.Degrees(-20.94800538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127456"},
        {"Hipparcos Number", "HIP 71071"},
        {"Smithsonian Astrophysical Observation", "SAO 182639"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00909374),
        dec: Angle.Degrees(-20.94768112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151451"},
        {"Hipparcos Number", "HIP 82244"},
        {"Smithsonian Astrophysical Observation", "SAO 184653"},
        {"Wilson Evans Batten Catalogue", "WEB 13886"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.05265679),
        dec: Angle.Degrees(-20.94741956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134833"},
        {"Hipparcos Number", "HIP 74423"},
        {"Smithsonian Astrophysical Observation", "SAO 183263"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.14611598),
        dec: Angle.Degrees(-20.94720324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215033"},
        {"Hipparcos Number", "HIP 112119"},
        {"Smithsonian Astrophysical Observation", "SAO 191340"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.65754673),
        dec: Angle.Degrees(-20.94549000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44894"},
        {"Hipparcos Number", "HIP 30398"},
        {"Smithsonian Astrophysical Observation", "SAO 171669"},
        {"Wilson Evans Batten Catalogue", "WEB 6048"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.87913482),
        dec: Angle.Degrees(-20.94218643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216245"},
        {"Hipparcos Number", "HIP 112886"},
        {"Geneva Identification System", "GEN# +1.00216245"},
        {"Smithsonian Astrophysical Observation", "SAO 191449"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.91076532),
        dec: Angle.Degrees(-20.93948403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135443"},
        {"Hipparcos Number", "HIP 74684"},
        {"Smithsonian Astrophysical Observation", "SAO 183322"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.94408994),
        dec: Angle.Degrees(-20.93909557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214046"},
        {"Hipparcos Number", "HIP 111551"},
        {"Geneva Identification System", "GEN# +1.00214046"},
        {"Smithsonian Astrophysical Observation", "SAO 191252"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.97478762),
        dec: Angle.Degrees(-20.93471343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192670"},
        {"Hipparcos Number", "HIP 99952"},
        {"Fundamental Katalog 5th Edition", "FK5 5788"},
        {"Smithsonian Astrophysical Observation", "SAO 189097"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.19772518),
        dec: Angle.Degrees(-20.93340902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222040"},
        {"Hipparcos Number", "HIP 116560"},
        {"Geneva Identification System", "GEN# +1.00222040"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.32365416),
        dec: Angle.Degrees(-20.93192040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21144"},
        {"Hipparcos Number", "HIP 15847"},
        {"Fundamental Katalog 5th Edition", "FK5 4308"},
        {"Geneva Identification System", "GEN# +1.00021144"},
        {"Smithsonian Astrophysical Observation", "SAO 168514"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.03266024),
        dec: Angle.Degrees(-20.93128381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87230"},
        {"Hipparcos Number", "HIP 49250"},
        {"Smithsonian Astrophysical Observation", "SAO 178348"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80242338),
        dec: Angle.Degrees(-20.93080302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83526"},
        {"Hipparcos Number", "HIP 47319"},
        {"Smithsonian Astrophysical Observation", "SAO 177779"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.63149392),
        dec: Angle.Degrees(-20.92790861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78734"},
        {"Hipparcos Number", "HIP 44934"},
        {"Fundamental Katalog 5th Edition", "FK5 4816"},
        {"Smithsonian Astrophysical Observation", "SAO 177030"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.29024283),
        dec: Angle.Degrees(-20.92726407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62838"},
        {"Smithsonian Astrophysical Observation", "SAO 181182"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.15172266),
        dec: Angle.Degrees(-20.92681303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44081"},
        {"Hipparcos Number", "HIP 30011"},
        {"Geneva Identification System", "GEN# +1.00044081"},
        {"Smithsonian Astrophysical Observation", "SAO 171549"},
        {"Wilson Evans Batten Catalogue", "WEB 5962"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74573891),
        dec: Angle.Degrees(-20.92562047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18166"},
        {"Hipparcos Number", "HIP 13545"},
        {"Renson", "Renson 4510"},
        {"Smithsonian Astrophysical Observation", "SAO 168135"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.61171106),
        dec: Angle.Degrees(-20.92490583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65381",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8885 AB"},
        {"Henry Draper", "HD 116429"},
        {"Hipparcos Number", "HIP 65381"},
        {"Smithsonian Astrophysical Observation", "SAO 181615"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.98793854),
        dec: Angle.Degrees(-20.92453837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46602"},
        {"Hipparcos Number", "HIP 31266"},
        {"Geneva Identification System", "GEN# +1.00046602"},
        {"Smithsonian Astrophysical Observation", "SAO 171940"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36118059),
        dec: Angle.Degrees(-20.92389414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42343"},
        {"Hipparcos Number", "HIP 29176"},
        {"Smithsonian Astrophysical Observation", "SAO 171304"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.33095232),
        dec: Angle.Degrees(-20.92185875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184579"},
        {"Hipparcos Number", "HIP 96393"},
        {"Smithsonian Astrophysical Observation", "SAO 188324"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.96644040),
        dec: Angle.Degrees(-20.92170260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106253"},
        {"Hipparcos Number", "HIP 59615"},
        {"Geneva Identification System", "GEN# +1.00106253"},
        {"Smithsonian Astrophysical Observation", "SAO 180577"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.38045482),
        dec: Angle.Degrees(-20.91988939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172905"},
        {"Hipparcos Number", "HIP 91849"},
        {"Smithsonian Astrophysical Observation", "SAO 187189"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.88647901),
        dec: Angle.Degrees(-20.91890117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35973"},
        {"Hipparcos Number", "HIP 25531"},
        {"Smithsonian Astrophysical Observation", "SAO 170444"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90163055),
        dec: Angle.Degrees(-20.91585024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27701"},
        {"Hipparcos Number", "HIP 20342"},
        {"Smithsonian Astrophysical Observation", "SAO 169366"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.36949811),
        dec: Angle.Degrees(-20.91541053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221565"},
        {"Hipparcos Number", "HIP 116247"},
        {"Geneva Identification System", "GEN# +1.00221565"},
        {"Smithsonian Astrophysical Observation", "SAO 191988"},
        {"Wilson Evans Batten Catalogue", "WEB 20543"},
    },
    visualMagnitude: 4.70,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.31927128),
        dec: Angle.Degrees(-20.91452506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50118"},
        {"Hipparcos Number", "HIP 32856"},
        {"Geneva Identification System", "GEN# +1.00050118"},
        {"Smithsonian Astrophysical Observation", "SAO 172425"},
        {"Wilson Evans Batten Catalogue", "WEB 6612"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.71945871),
        dec: Angle.Degrees(-20.91038372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60266"},
        {"Hipparcos Number", "HIP 36685"},
        {"Geneva Identification System", "GEN# +1.00060266"},
        {"Smithsonian Astrophysical Observation", "SAO 173973"},
        {"Wilson Evans Batten Catalogue", "WEB 7296"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19597392),
        dec: Angle.Degrees(-20.90969440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58764"},
        {"Hipparcos Number", "HIP 36101"},
        {"Smithsonian Astrophysical Observation", "SAO 173725"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.55570094),
        dec: Angle.Degrees(-20.90627299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23978"},
        {"Hipparcos Number", "HIP 17798"},
        {"Geneva Identification System", "GEN# +1.00023978"},
        {"Smithsonian Astrophysical Observation", "SAO 168851"},
        {"Wilson Evans Batten Catalogue", "WEB 3414"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.14884582),
        dec: Angle.Degrees(-20.90293608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194944"},
        {"Hipparcos Number", "HIP 101039"},
        {"Smithsonian Astrophysical Observation", "SAO 189335"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.25140985),
        dec: Angle.Degrees(-20.90150376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211610"},
        {"Hipparcos Number", "HIP 110146"},
        {"Wilson Evans Batten Catalogue", "WEB 19768"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.66384125),
        dec: Angle.Degrees(-20.90111551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41489"},
        {"Hipparcos Number", "HIP 28788"},
        {"Smithsonian Astrophysical Observation", "SAO 171205"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16576064),
        dec: Angle.Degrees(-20.89994336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12416"},
        {"Hipparcos Number", "HIP 9442"},
        {"Smithsonian Astrophysical Observation", "SAO 167491"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.32330378),
        dec: Angle.Degrees(-20.89931862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195678"},
        {"Hipparcos Number", "HIP 101437"},
        {"Fundamental Katalog 5th Edition", "FK5 5811"},
        {"Geneva Identification System", "GEN# +1.00195678"},
        {"Smithsonian Astrophysical Observation", "SAO 189423"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.35847853),
        dec: Angle.Degrees(-20.89692632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28681"},
        {"Hipparcos Number", "HIP 21031"},
        {"Smithsonian Astrophysical Observation", "SAO 169520"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.64014240),
        dec: Angle.Degrees(-20.89313548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8447"},
        {"Geneva Identification System", "GEN# -0.02100311"},
        {"Wilson Evans Batten Catalogue", "WEB 1798"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.22548425),
        dec: Angle.Degrees(-20.89290494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14218 AB"},
        {"Henry Draper", "HD 197523"},
        {"Hipparcos Number", "HIP 102386"},
        {"Smithsonian Astrophysical Observation", "SAO 189638"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.20511605),
        dec: Angle.Degrees(-20.89283317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180954"},
        {"Hipparcos Number", "HIP 94948"},
        {"Smithsonian Astrophysical Observation", "SAO 187963"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.81741551),
        dec: Angle.Degrees(-20.89177482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217169"},
        {"Hipparcos Number", "HIP 113482"},
        {"Smithsonian Astrophysical Observation", "SAO 191545"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.72919973),
        dec: Angle.Degrees(-20.89035374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210737"},
        {"Hipparcos Number", "HIP 109652"},
        {"Geneva Identification System", "GEN# +1.00210737"},
        {"Smithsonian Astrophysical Observation", "SAO 190963"},
        {"Wilson Evans Batten Catalogue", "WEB 19701"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.19455219),
        dec: Angle.Degrees(-20.89033628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83212"},
        {"Hipparcos Number", "HIP 47139"},
        {"Geneva Identification System", "GEN# +1.00083212"},
        {"Smithsonian Astrophysical Observation", "SAO 177727"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.08317892),
        dec: Angle.Degrees(-20.88738336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16599"},
        {"Hipparcos Number", "HIP 12352"},
        {"Smithsonian Astrophysical Observation", "SAO 167946"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.76005256),
        dec: Angle.Degrees(-20.88667008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32967"},
        {"Hipparcos Number", "HIP 23736"},
        {"Smithsonian Astrophysical Observation", "SAO 170063"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53666398),
        dec: Angle.Degrees(-20.88631760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114662"},
        {"Hipparcos Number", "HIP 64419"},
        {"Geneva Identification System", "GEN# +1.00114662"},
        {"Smithsonian Astrophysical Observation", "SAO 181452"},
        {"Wilson Evans Batten Catalogue", "WEB 11386"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.04138485),
        dec: Angle.Degrees(-20.88440910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55344"},
        {"Hipparcos Number", "HIP 34758"},
        {"Celescope Catalog", "CEL 1655"},
        {"Fundamental Katalog 5th Edition", "FK5 2556"},
        {"Geneva Identification System", "GEN# +1.00055344"},
        {"Smithsonian Astrophysical Observation", "SAO 173168"},
        {"Wilson Evans Batten Catalogue", "WEB 6948"},
    },
    visualMagnitude: 5.84,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.92337859),
        dec: Angle.Degrees(-20.88311563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223511"},
        {"Hipparcos Number", "HIP 117544"},
        {"Geneva Identification System", "GEN# +1.00223511"},
        {"Renson", "Renson 61240"},
        {"Smithsonian Astrophysical Observation", "SAO 192189"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.56498575),
        dec: Angle.Degrees(-20.88159389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32151"},
        {"Hipparcos Number", "HIP 23258"},
        {"Smithsonian Astrophysical Observation", "SAO 169962"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.07255722),
        dec: Angle.Degrees(-20.88134917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52997"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.61790410),
        dec: Angle.Degrees(-20.88092480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115906"},
        {"Hipparcos Number", "HIP 65101"},
        {"Geneva Identification System", "GEN# +1.00115906"},
        {"Smithsonian Astrophysical Observation", "SAO 181567"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12705918),
        dec: Angle.Degrees(-20.88075325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34675"},
        {"Hipparcos Number", "HIP 24750"},
        {"Smithsonian Astrophysical Observation", "SAO 170294"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.60951363),
        dec: Angle.Degrees(-20.87795445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39364"},
        {"Hipparcos Number", "HIP 27654"},
        {"Cincinnati Publication", "Ci 20 354"},
        {"Fundamental Katalog 5th Edition", "FK5 222"},
        {"Geneva Identification System", "GEN# +1.00039364"},
        {"Smithsonian Astrophysical Observation", "SAO 170926"},
        {"Wilson Evans Batten Catalogue", "WEB 5429"},
    },
    visualMagnitude: 3.76,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.82980343),
        dec: Angle.Degrees(-20.87751376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -647.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125427"},
        {"Hipparcos Number", "HIP 70033"},
        {"Geneva Identification System", "GEN# +1.00125427"},
        {"Smithsonian Astrophysical Observation", "SAO 182445"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.95237166),
        dec: Angle.Degrees(-20.87480977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24082"},
        {"Hipparcos Number", "HIP 17859"},
        {"Geneva Identification System", "GEN# +1.00024082"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.33715500),
        dec: Angle.Degrees(-20.87423832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314428"},
        {"Hipparcos Number", "HIP 90211"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.10836147),
        dec: Angle.Degrees(-20.87229133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224961"},
        {"Hipparcos Number", "HIP 170"},
        {"Smithsonian Astrophysical Observation", "SAO 192331"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.53767720),
        dec: Angle.Degrees(-20.87164212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136179"},
        {"Hipparcos Number", "HIP 75023"},
        {"Geneva Identification System", "GEN# +1.00136179"},
        {"Smithsonian Astrophysical Observation", "SAO 183380"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.95102307),
        dec: Angle.Degrees(-20.87118701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167225"},
        {"Hipparcos Number", "HIP 89425"},
        {"Smithsonian Astrophysical Observation", "SAO 186535"},
        {"Wilson Evans Batten Catalogue", "WEB 15211"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.75909761),
        dec: Angle.Degrees(-20.87118065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217703"},
        {"Hipparcos Number", "HIP 113801"},
        {"Geneva Identification System", "GEN# +1.00217703"},
        {"Smithsonian Astrophysical Observation", "SAO 191604"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68453003),
        dec: Angle.Degrees(-20.87039619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120516"},
        {"Hipparcos Number", "HIP 67533"},
        {"Smithsonian Astrophysical Observation", "SAO 182004"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.56136721),
        dec: Angle.Degrees(-20.86931986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144608"},
        {"Hipparcos Number", "HIP 78990"},
        {"Geneva Identification System", "GEN# +1.00144608"},
        {"Smithsonian Astrophysical Observation", "SAO 184135"},
        {"Wilson Evans Batten Catalogue", "WEB 13350"},
    },
    visualMagnitude: 4.31,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.85125058),
        dec: Angle.Degrees(-20.86865410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41385"},
        {"Hipparcos Number", "HIP 28717"},
        {"Renson", "Renson 11060"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.98936561),
        dec: Angle.Degrees(-20.86847205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112562"},
        {"Hipparcos Number", "HIP 63261"},
        {"Smithsonian Astrophysical Observation", "SAO 181269"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.44733063),
        dec: Angle.Degrees(-20.86812696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132299"},
        {"Hipparcos Number", "HIP 73305"},
        {"Smithsonian Astrophysical Observation", "SAO 183063"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.71123059),
        dec: Angle.Degrees(-20.86778917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222212"},
        {"Hipparcos Number", "HIP 116675"},
        {"Geneva Identification System", "GEN# +1.00222212"},
        {"Smithsonian Astrophysical Observation", "SAO 192056"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.67346985),
        dec: Angle.Degrees(-20.86738882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160458"},
        {"Hipparcos Number", "HIP 86519"},
        {"Geneva Identification System", "GEN# +1.00160458"},
        {"Smithsonian Astrophysical Observation", "SAO 185615"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.21331774),
        dec: Angle.Degrees(-20.86432541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36473"},
        {"Hipparcos Number", "HIP 25853"},
        {"Geneva Identification System", "GEN# +1.00036473"},
        {"Smithsonian Astrophysical Observation", "SAO 170506"},
        {"Wilson Evans Batten Catalogue", "WEB 5018"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.78176520),
        dec: Angle.Degrees(-20.86355455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218531"},
        {"Hipparcos Number", "HIP 114304"},
        {"Smithsonian Astrophysical Observation", "SAO 191679"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.23701767),
        dec: Angle.Degrees(-20.86183572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135909"},
        {"Hipparcos Number", "HIP 74892"},
        {"Smithsonian Astrophysical Observation", "SAO 183354"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.58244900),
        dec: Angle.Degrees(-20.86085600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66273"},
        {"Hipparcos Number", "HIP 39283"},
        {"Geneva Identification System", "GEN# +1.00066273"},
        {"Renson", "Renson 18270"},
        {"Smithsonian Astrophysical Observation", "SAO 175015"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.49098851),
        dec: Angle.Degrees(-20.85938131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5823 A"},
        {"Henry Draper", "HD 54519"},
        {"Hipparcos Number", "HIP 34438"},
        {"Geneva Identification System", "GEN# +1.00054519"},
        {"Smithsonian Astrophysical Observation", "SAO 173041"},
        {"Wilson Evans Batten Catalogue", "WEB 6901"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09120548),
        dec: Angle.Degrees(-20.85936003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189362"},
        {"Hipparcos Number", "HIP 98477"},
        {"Fundamental Katalog 5th Edition", "FK5 5762"},
        {"Smithsonian Astrophysical Observation", "SAO 188807"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.09488250),
        dec: Angle.Degrees(-20.85702982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5423"},
        {"Hipparcos Number", "HIP 4361"},
        {"Geneva Identification System", "GEN# +1.00005423"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.97156651),
        dec: Angle.Degrees(-20.85650387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119949"},
        {"Hipparcos Number", "HIP 67240"},
        {"Geneva Identification System", "GEN# +1.00119949"},
        {"Smithsonian Astrophysical Observation", "SAO 181947"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.69051474),
        dec: Angle.Degrees(-20.85285323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49068"},
        {"Hipparcos Number", "HIP 32393"},
        {"Geneva Identification System", "GEN# +2.22870075"},
        {"Smithsonian Astrophysical Observation", "SAO 172286"},
        {"Wilson Evans Batten Catalogue", "WEB 6533"},
        {"New General Catalogue", "NGC 2287 75"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.42922774),
        dec: Angle.Degrees(-20.85266423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203638"},
        {"Hipparcos Number", "HIP 105665"},
        {"Fundamental Katalog 5th Edition", "FK5 3707"},
        {"Geneva Identification System", "GEN# +1.00203638"},
        {"Smithsonian Astrophysical Observation", "SAO 190295"},
        {"Wilson Evans Batten Catalogue", "WEB 19178"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.03999238),
        dec: Angle.Degrees(-20.85156019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19165"},
        {"Cincinnati Publication", "Ci 18 554"},
        {"Cincinnati Publication 2", "Ci 20 280"},
        {"Geneva Identification System", "GEN# -0.02100784"},
        {"Smithsonian Astrophysical Observation", "SAO 169128"},
        {"Wilson Evans Batten Catalogue", "WEB 3685"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64503704),
        dec: Angle.Degrees(-20.85122581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -779.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68296"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.71267601),
        dec: Angle.Degrees(-20.85070715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92358"},
        {"Hipparcos Number", "HIP 52166"},
        {"Smithsonian Astrophysical Observation", "SAO 179085"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.87198034),
        dec: Angle.Degrees(-20.84994380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220125"},
        {"Hipparcos Number", "HIP 115315"},
        {"Smithsonian Astrophysical Observation", "SAO 191842"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.33185040),
        dec: Angle.Degrees(-20.84914464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48204"},
        {"Hipparcos Number", "HIP 32026"},
        {"Geneva Identification System", "GEN# +1.00048204"},
        {"Smithsonian Astrophysical Observation", "SAO 172164"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.35013097),
        dec: Angle.Degrees(-20.84811533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128945"},
        {"Hipparcos Number", "HIP 71730"},
        {"Renson", "Renson 36716"},
        {"Smithsonian Astrophysical Observation", "SAO 182754"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.10152305),
        dec: Angle.Degrees(-20.84804236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111017"},
        {"Hipparcos Number", "HIP 62337"},
        {"Smithsonian Astrophysical Observation", "SAO 181090"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61460861),
        dec: Angle.Degrees(-20.84800234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54768"},
        {"Hipparcos Number", "HIP 34535"},
        {"Smithsonian Astrophysical Observation", "SAO 173080"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33314289),
        dec: Angle.Degrees(-20.84634518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10998"},
        {"Hipparcos Number", "HIP 8347"},
        {"Geneva Identification System", "GEN# +1.00010998"},
        {"Smithsonian Astrophysical Observation", "SAO 167298"},
        {"Wilson Evans Batten Catalogue", "WEB 1774"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91173970),
        dec: Angle.Degrees(-20.84506213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106485"},
        {"Hipparcos Number", "HIP 59728"},
        {"Geneva Identification System", "GEN# +1.00106485"},
        {"Smithsonian Astrophysical Observation", "SAO 180602"},
        {"Wilson Evans Batten Catalogue", "WEB 10611"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.74825968),
        dec: Angle.Degrees(-20.84423329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71581"},
        {"Hipparcos Number", "HIP 41475"},
        {"Geneva Identification System", "GEN# +1.00071581J"},
        {"Smithsonian Astrophysical Observation", "SAO 175870"},
        {"Wilson Evans Batten Catalogue", "WEB 8018"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88861161),
        dec: Angle.Degrees(-20.84392121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136958"},
        {"Hipparcos Number", "HIP 75376"},
        {"Smithsonian Astrophysical Observation", "SAO 183435"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.04326324),
        dec: Angle.Degrees(-20.84241399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29522"},
        {"Hipparcos Number", "HIP 21596"},
        {"Smithsonian Astrophysical Observation", "SAO 169627"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54938203),
        dec: Angle.Degrees(-20.84175172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106991"},
        {"Hipparcos Number", "HIP 59993"},
        {"Geneva Identification System", "GEN# +1.00106991"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.55727153),
        dec: Angle.Degrees(-20.84048397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171369"},
        {"Hipparcos Number", "HIP 91132"},
        {"Geneva Identification System", "GEN# +1.00171369"},
        {"Smithsonian Astrophysical Observation", "SAO 187012"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.83880126),
        dec: Angle.Degrees(-20.84043868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161644"},
        {"Hipparcos Number", "HIP 87068"},
        {"Smithsonian Astrophysical Observation", "SAO 185760"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.88083430),
        dec: Angle.Degrees(-20.83731102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39405"},
        {"Hipparcos Number", "HIP 27680"},
        {"Smithsonian Astrophysical Observation", "SAO 170933"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.90323642),
        dec: Angle.Degrees(-20.83691564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50072"},
        {"Hipparcos Number", "HIP 32841"},
        {"Celescope Catalog", "CEL 1407"},
        {"Geneva Identification System", "GEN# +1.00050072"},
        {"Smithsonian Astrophysical Observation", "SAO 172422"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.68841799),
        dec: Angle.Degrees(-20.83586051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34514"},
        {"Hipparcos Number", "HIP 24643"},
        {"Renson", "Renson 8810"},
        {"Smithsonian Astrophysical Observation", "SAO 170278"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.31504657),
        dec: Angle.Degrees(-20.83450996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183449"},
        {"Hipparcos Number", "HIP 95912"},
        {"Smithsonian Astrophysical Observation", "SAO 188206"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.58174834),
        dec: Angle.Degrees(-20.83434937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214450"},
        {"Hipparcos Number", "HIP 111786"},
        {"Smithsonian Astrophysical Observation", "SAO 191289"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.63482843),
        dec: Angle.Degrees(-20.83369086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224349"},
        {"Hipparcos Number", "HIP 118081"},
        {"Smithsonian Astrophysical Observation", "SAO 192264"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.29222947),
        dec: Angle.Degrees(-20.83360870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190821"},
        {"Hipparcos Number", "HIP 99140"},
        {"Geneva Identification System", "GEN# +1.00190821"},
        {"Smithsonian Astrophysical Observation", "SAO 188934"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.91394249),
        dec: Angle.Degrees(-20.83280607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6368 AB"},
        {"Henry Draper", "HD 63165"},
        {"Hipparcos Number", "HIP 37954"},
        {"Celescope Catalog", "CEL 2025"},
        {"Smithsonian Astrophysical Observation", "SAO 174516"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.69183037),
        dec: Angle.Degrees(-20.83126465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161983"},
        {"Hipparcos Number", "HIP 87235"},
        {"Smithsonian Astrophysical Observation", "SAO 185801"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.36345308),
        dec: Angle.Degrees(-20.83088360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28719"},
        {"Hipparcos Number", "HIP 21061"},
        {"Smithsonian Astrophysical Observation", "SAO 169525"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.71375609),
        dec: Angle.Degrees(-20.83033797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53598"},
        {"Hipparcos Number", "HIP 34152"},
        {"Geneva Identification System", "GEN# +1.00053598"},
        {"Smithsonian Astrophysical Observation", "SAO 172911"},
        {"Wilson Evans Batten Catalogue", "WEB 6844"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.22338827),
        dec: Angle.Degrees(-20.83009720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212066"},
        {"Hipparcos Number", "HIP 110418"},
        {"Smithsonian Astrophysical Observation", "SAO 191088"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.48960029),
        dec: Angle.Degrees(-20.82837774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14517"},
        {"Hipparcos Number", "HIP 10887"},
        {"Smithsonian Astrophysical Observation", "SAO 167710"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.03127554),
        dec: Angle.Degrees(-20.82819878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12255"},
        {"Hipparcos Number", "HIP 9326"},
        {"Geneva Identification System", "GEN# +1.00012255"},
        {"Smithsonian Astrophysical Observation", "SAO 167466"},
        {"Wilson Evans Batten Catalogue", "WEB 1961"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.94245126),
        dec: Angle.Degrees(-20.82457549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148715"},
        {"Hipparcos Number", "HIP 80877"},
        {"Smithsonian Astrophysical Observation", "SAO 184434"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.71743628),
        dec: Angle.Degrees(-20.82276486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165033"},
        {"Hipparcos Number", "HIP 88548"},
        {"Smithsonian Astrophysical Observation", "SAO 186238"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20740172),
        dec: Angle.Degrees(-20.82146000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17561"},
        {"Hipparcos Number", "HIP 13113"},
        {"Geneva Identification System", "GEN# +1.00017561"},
        {"Smithsonian Astrophysical Observation", "SAO 168066"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.16007368),
        dec: Angle.Degrees(-20.82105584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203142"},
        {"Hipparcos Number", "HIP 105410"},
        {"Geneva Identification System", "GEN# +1.00203142"},
        {"Smithsonian Astrophysical Observation", "SAO 190252"},
        {"Wilson Evans Batten Catalogue", "WEB 19141"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.26307597),
        dec: Angle.Degrees(-20.82104595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208980"},
        {"Hipparcos Number", "HIP 108637"},
        {"Smithsonian Astrophysical Observation", "SAO 190819"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.12892900),
        dec: Angle.Degrees(-20.81894628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184986"},
        {"Hipparcos Number", "HIP 96552"},
        {"Smithsonian Astrophysical Observation", "SAO 188361"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.43725073),
        dec: Angle.Degrees(-20.81575250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131071"},
        {"Hipparcos Number", "HIP 72728"},
        {"Smithsonian Astrophysical Observation", "SAO 182945"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.04247399),
        dec: Angle.Degrees(-20.81419404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49212"},
        {"Hipparcos Number", "HIP 32467"},
        {"Geneva Identification System", "GEN# +2.22870107"},
        {"Smithsonian Astrophysical Observation", "SAO 172306"},
        {"New General Catalogue", "NGC 2287 107"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63866590),
        dec: Angle.Degrees(-20.81184070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169991"},
        {"Hipparcos Number", "HIP 90508"},
        {"Smithsonian Astrophysical Observation", "SAO 186850"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02598918),
        dec: Angle.Degrees(-20.81111735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77098"},
        {"Hipparcos Number", "HIP 44171"},
        {"Smithsonian Astrophysical Observation", "SAO 176804"},
        {"Wilson Evans Batten Catalogue", "WEB 8485"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.94609437),
        dec: Angle.Degrees(-20.81059464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62866"},
        {"Hipparcos Number", "HIP 37816"},
        {"Geneva Identification System", "GEN# +1.00062866"},
        {"Smithsonian Astrophysical Observation", "SAO 174452"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.30396103),
        dec: Angle.Degrees(-20.81037042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107003"},
        {"Hipparcos Number", "HIP 60011"},
        {"Smithsonian Astrophysical Observation", "SAO 180666"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.61111687),
        dec: Angle.Degrees(-20.80975545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3459 AB"},
        {"Henry Draper", "HD 30537"},
        {"Hipparcos Number", "HIP 22277"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.94403334),
        dec: Angle.Degrees(-20.80971380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104497"},
        {"Hipparcos Number", "HIP 58679"},
        {"Smithsonian Astrophysical Observation", "SAO 180395"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.51089980),
        dec: Angle.Degrees(-20.80857545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59737"},
        {"Hipparcos Number", "HIP 36486"},
        {"Smithsonian Astrophysical Observation", "SAO 173885"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.61186797),
        dec: Angle.Degrees(-20.80798973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79085"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.14934736),
        dec: Angle.Degrees(-20.80743248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49151"},
        {"Hipparcos Number", "HIP 32440"},
        {"Geneva Identification System", "GEN# +2.22870044"},
        {"New General Catalogue", "NGC 2287 44"},
    },
    visualMagnitude: 8.47,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.56225694),
        dec: Angle.Degrees(-20.80494455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72396"},
        {"Hipparcos Number", "HIP 41852"},
        {"Smithsonian Astrophysical Observation", "SAO 176017"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.00082846),
        dec: Angle.Degrees(-20.80270918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13993",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ayeyarwady"},
        {"Henry Draper", "HD 18742"},
        {"Hipparcos Number", "HIP 13993"},
        {"Geneva Identification System", "GEN# +1.00018742"},
        {"Smithsonian Astrophysical Observation", "SAO 168212"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.04445286),
        dec: Angle.Degrees(-20.80254974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170015"},
        {"Hipparcos Number", "HIP 90515"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.03531334),
        dec: Angle.Degrees(-20.80187664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177116"},
        {"Hipparcos Number", "HIP 93646"},
        {"Smithsonian Astrophysical Observation", "SAO 187631"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.04241833),
        dec: Angle.Degrees(-20.80095401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85724"},
        {"Hipparcos Number", "HIP 48480"},
        {"Smithsonian Astrophysical Observation", "SAO 178137"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.31328885),
        dec: Angle.Degrees(-20.80082753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7395 AB"},
        {"Henry Draper", "HD 82000"},
        {"Hipparcos Number", "HIP 46475"},
        {"Smithsonian Astrophysical Observation", "SAO 177506"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.17699725),
        dec: Angle.Degrees(-20.79991608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70482"},
        {"Hipparcos Number", "HIP 40958"},
        {"Smithsonian Astrophysical Observation", "SAO 175660"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.37646191),
        dec: Angle.Degrees(-20.79445562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152570"},
        {"Hipparcos Number", "HIP 82760"},
        {"Smithsonian Astrophysical Observation", "SAO 184790"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.71629708),
        dec: Angle.Degrees(-20.79379249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101861"},
        {"Hipparcos Number", "HIP 57155"},
        {"Smithsonian Astrophysical Observation", "SAO 180132"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.82690842),
        dec: Angle.Degrees(-20.79367965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34219",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5783 AB"},
        {"Henry Draper", "HD 53808"},
        {"Hipparcos Number", "HIP 34219"},
        {"Celescope Catalog", "CEL 1572"},
        {"Smithsonian Astrophysical Observation", "SAO 172940"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.42318851),
        dec: Angle.Degrees(-20.79265277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142380"},
        {"Hipparcos Number", "HIP 77948"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.76648339),
        dec: Angle.Degrees(-20.79241173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52115"},
        {"Hipparcos Number", "HIP 33621"},
        {"Celescope Catalog", "CEL 1476"},
        {"Geneva Identification System", "GEN# +1.00052115"},
        {"Smithsonian Astrophysical Observation", "SAO 172684"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.77994360),
        dec: Angle.Degrees(-20.79224418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60265"},
        {"Hipparcos Number", "HIP 36683"},
        {"Geneva Identification System", "GEN# +1.00060265"},
        {"Smithsonian Astrophysical Observation", "SAO 173970"},
        {"Wilson Evans Batten Catalogue", "WEB 7295"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19269038),
        dec: Angle.Degrees(-20.79206641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19976"},
        {"Hipparcos Number", "HIP 14873"},
        {"Smithsonian Astrophysical Observation", "SAO 168369"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.00500548),
        dec: Angle.Degrees(-20.79158801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215625"},
        {"Hipparcos Number", "HIP 112462"},
        {"Geneva Identification System", "GEN# +1.00215625"},
        {"Smithsonian Astrophysical Observation", "SAO 191396"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70937424),
        dec: Angle.Degrees(-20.79063922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99568"},
        {"Hipparcos Number", "HIP 55887"},
        {"Smithsonian Astrophysical Observation", "SAO 179895"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.81886773),
        dec: Angle.Degrees(-20.78950055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202206"},
        {"Hipparcos Number", "HIP 104903"},
        {"Geneva Identification System", "GEN# +1.00202206"},
        {"Smithsonian Astrophysical Observation", "SAO 190163"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.74080489),
        dec: Angle.Degrees(-20.78891836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75162"},
        {"Hipparcos Number", "HIP 43178"},
        {"Smithsonian Astrophysical Observation", "SAO 176477"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.92180628),
        dec: Angle.Degrees(-20.78883896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80396"},
        {"Hipparcos Number", "HIP 45696"},
        {"Geneva Identification System", "GEN# +1.00080396"},
        {"Smithsonian Astrophysical Observation", "SAO 177259"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.73304131),
        dec: Angle.Degrees(-20.78817541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186331"},
        {"Hipparcos Number", "HIP 97130"},
        {"Geneva Identification System", "GEN# +1.00186331"},
        {"Smithsonian Astrophysical Observation", "SAO 188508"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.11294040),
        dec: Angle.Degrees(-20.78784220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153150"},
        {"Hipparcos Number", "HIP 83070"},
        {"Smithsonian Astrophysical Observation", "SAO 184859"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.61762467),
        dec: Angle.Degrees(-20.78564095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214925"},
        {"Hipparcos Number", "HIP 112070"},
        {"Geneva Identification System", "GEN# +1.00214925"},
        {"Smithsonian Astrophysical Observation", "SAO 191333"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.49759142),
        dec: Angle.Degrees(-20.78426317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198079"},
        {"Hipparcos Number", "HIP 102702"},
        {"Smithsonian Astrophysical Observation", "SAO 189717"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.14391946),
        dec: Angle.Degrees(-20.78395898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146973"},
        {"Hipparcos Number", "HIP 80009"},
        {"Geneva Identification System", "GEN# +1.00146973"},
        {"Smithsonian Astrophysical Observation", "SAO 184316"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.98066354),
        dec: Angle.Degrees(-20.78234945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223654"},
        {"Hipparcos Number", "HIP 117645"},
        {"Smithsonian Astrophysical Observation", "SAO 192204"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.88630361),
        dec: Angle.Degrees(-20.78215269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116283"},
        {"Geneva Identification System", "GEN# +6.10165950"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.40436607),
        dec: Angle.Degrees(-20.78204996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184509"},
        {"Hipparcos Number", "HIP 96370"},
        {"Geneva Identification System", "GEN# +1.00184509"},
        {"Smithsonian Astrophysical Observation", "SAO 188317"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.89884607),
        dec: Angle.Degrees(-20.78168328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113052"},
        {"Hipparcos Number", "HIP 63538"},
        {"Geneva Identification System", "GEN# +1.00113052"},
        {"Smithsonian Astrophysical Observation", "SAO 181319"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.30678341),
        dec: Angle.Degrees(-20.77755120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141404"},
        {"Hipparcos Number", "HIP 77521"},
        {"Geneva Identification System", "GEN# +1.00141404"},
        {"Smithsonian Astrophysical Observation", "SAO 183833"},
        {"Wilson Evans Batten Catalogue", "WEB 13126"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.41769970),
        dec: Angle.Degrees(-20.77747371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100219"},
        {"Hipparcos Number", "HIP 56245"},
        {"Fundamental Katalog 5th Edition", "FK5 2919"},
        {"Geneva Identification System", "GEN# +1.00100219"},
        {"Smithsonian Astrophysical Observation", "SAO 179964"},
        {"Wilson Evans Batten Catalogue", "WEB 10106"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.94843846),
        dec: Angle.Degrees(-20.77656734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180303"},
        {"Hipparcos Number", "HIP 94749"},
        {"Renson", "Renson 50050"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.19512768),
        dec: Angle.Degrees(-20.77645187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5437"},
        {"Henry Draper", "HD 49091"},
        {"Hipparcos Number", "HIP 32406"},
        {"Geneva Identification System", "GEN# +2.22870021"},
        {"Smithsonian Astrophysical Observation", "SAO 172290"},
        {"New General Catalogue", "NGC 2287 21"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.48943131),
        dec: Angle.Degrees(-20.77504109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22721",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3511 A"},
        {"Henry Draper", "HD 31225"},
        {"Hipparcos Number", "HIP 22721"},
        {"Geneva Identification System", "GEN# +1.00031225"},
        {"Renson", "Renson 8010"},
        {"Smithsonian Astrophysical Observation", "SAO 169847"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.30087485),
        dec: Angle.Degrees(-20.77212066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85352"},
        {"Hipparcos Number", "HIP 48291"},
        {"Smithsonian Astrophysical Observation", "SAO 178081"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.68591779),
        dec: Angle.Degrees(-20.77017345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16342"},
        {"Hipparcos Number", "HIP 12164"},
        {"Smithsonian Astrophysical Observation", "SAO 167916"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.19627600),
        dec: Angle.Degrees(-20.76918373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213056"},
        {"Hipparcos Number", "HIP 110989"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.28931072),
        dec: Angle.Degrees(-20.76870572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98174"},
        {"Hipparcos Number", "HIP 55152"},
        {"Geneva Identification System", "GEN# +1.00098174"},
        {"Smithsonian Astrophysical Observation", "SAO 179742"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.37067684),
        dec: Angle.Degrees(-20.76644676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13359"},
        {"Hipparcos Number", "HIP 10114"},
        {"Geneva Identification System", "GEN# +1.00013359"},
        {"Smithsonian Astrophysical Observation", "SAO 167605"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.52927434),
        dec: Angle.Degrees(-20.76431129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81583"},
        {"Hipparcos Number", "HIP 46258"},
        {"Smithsonian Astrophysical Observation", "SAO 177437"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.48272191),
        dec: Angle.Degrees(-20.76169686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63043"},
        {"Hipparcos Number", "HIP 37907"},
        {"Smithsonian Astrophysical Observation", "SAO 174486"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.52749389),
        dec: Angle.Degrees(-20.75946046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209979"},
        {"Hipparcos Number", "HIP 109223"},
        {"Smithsonian Astrophysical Observation", "SAO 190902"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.90961084),
        dec: Angle.Degrees(-20.75925427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25606",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nihal"},
        {"Aitken", "ADS 4066 AB"},
        {"Henry Draper", "HD 36079"},
        {"Hipparcos Number", "HIP 25606"},
        {"Fundamental Katalog 5th Edition", "FK5 204"},
        {"Geneva Identification System", "GEN# +1.00036079J"},
        {"Smithsonian Astrophysical Observation", "SAO 170457"},
        {"Wilson Evans Batten Catalogue", "WEB 4967"},
    },
    visualMagnitude: 2.81,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.06135971),
        dec: Angle.Degrees(-20.75923214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3337"},
        {"Hipparcos Number", "HIP 2853"},
        {"Geneva Identification System", "GEN# +1.00003337"},
        {"Smithsonian Astrophysical Observation", "SAO 166399"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.03140187),
        dec: Angle.Degrees(-20.75859012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144822"},
        {"Hipparcos Number", "HIP 79083"},
        {"Geneva Identification System", "GEN# +1.00144822"},
        {"Smithsonian Astrophysical Observation", "SAO 184159"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.14644744),
        dec: Angle.Degrees(-20.75817670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125063"},
        {"Hipparcos Number", "HIP 69842"},
        {"Smithsonian Astrophysical Observation", "SAO 182419"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.40805329),
        dec: Angle.Degrees(-20.75806687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125862"},
        {"Hipparcos Number", "HIP 70261"},
        {"Smithsonian Astrophysical Observation", "SAO 182474"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.64481346),
        dec: Angle.Degrees(-20.75765330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69844"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.41330400),
        dec: Angle.Degrees(-20.75596604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143590"},
        {"Hipparcos Number", "HIP 78543"},
        {"Smithsonian Astrophysical Observation", "SAO 184044"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.52402451),
        dec: Angle.Degrees(-20.75558841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5437 AB"},
        {"Henry Draper", "HD 49126"},
        {"Hipparcos Number", "HIP 32426"},
        {"Geneva Identification System", "GEN# +2.22870102"},
        {"Smithsonian Astrophysical Observation", "SAO 172296"},
        {"New General Catalogue", "NGC 2287 102"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.53005123),
        dec: Angle.Degrees(-20.75431674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53122"},
        {"Hipparcos Number", "HIP 33981"},
        {"Celescope Catalog", "CEL 1534"},
        {"Geneva Identification System", "GEN# +1.00053122"},
        {"Smithsonian Astrophysical Observation", "SAO 172838"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.76742673),
        dec: Angle.Degrees(-20.75280464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148946"},
        {"Hipparcos Number", "HIP 80992"},
        {"Smithsonian Astrophysical Observation", "SAO 184453"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.10894244),
        dec: Angle.Degrees(-20.75214759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101385"},
        {"Hipparcos Number", "HIP 56903"},
        {"Geneva Identification System", "GEN# +1.00101385"},
        {"Smithsonian Astrophysical Observation", "SAO 180077"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.97225189),
        dec: Angle.Degrees(-20.75194408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120001"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.67678760),
        dec: Angle.Degrees(-20.75082956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82077"},
        {"Hipparcos Number", "HIP 46511"},
        {"Geneva Identification System", "GEN# +1.00082077"},
        {"Smithsonian Astrophysical Observation", "SAO 177521"},
        {"Wilson Evans Batten Catalogue", "WEB 8778"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.30272565),
        dec: Angle.Degrees(-20.74914438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119010"},
        {"Hipparcos Number", "HIP 66759"},
        {"Smithsonian Astrophysical Observation", "SAO 181855"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.24968666),
        dec: Angle.Degrees(-20.74859034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33628"},
        {"Hipparcos Number", "HIP 24112"},
        {"Renson", "Renson 8550"},
        {"Smithsonian Astrophysical Observation", "SAO 170149"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.68120983),
        dec: Angle.Degrees(-20.74841093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120302"},
        {"Hipparcos Number", "HIP 67411"},
        {"Smithsonian Astrophysical Observation", "SAO 181980"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.23843901),
        dec: Angle.Degrees(-20.74824800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200418"},
        {"Hipparcos Number", "HIP 103967"},
        {"Smithsonian Astrophysical Observation", "SAO 189980"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.97115554),
        dec: Angle.Degrees(-20.74818007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86083"},
        {"Hipparcos Number", "HIP 48693"},
        {"Geneva Identification System", "GEN# +1.00086083"},
        {"Smithsonian Astrophysical Observation", "SAO 178190"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.94848886),
        dec: Angle.Degrees(-20.74715011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187247"},
        {"Hipparcos Number", "HIP 97559"},
        {"Smithsonian Astrophysical Observation", "SAO 188606"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.43672908),
        dec: Angle.Degrees(-20.74578009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29197"},
        {"Hipparcos Number", "HIP 21367"},
        {"Geneva Identification System", "GEN# +1.00029197"},
        {"Smithsonian Astrophysical Observation", "SAO 169586"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.76839675),
        dec: Angle.Degrees(-20.74346696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13287"},
        {"Hipparcos Number", "HIP 10051"},
        {"Geneva Identification System", "GEN# +1.00013287"},
        {"Smithsonian Astrophysical Observation", "SAO 167594"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.34616622),
        dec: Angle.Degrees(-20.74263105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137497"},
        {"Hipparcos Number", "HIP 75623"},
        {"Smithsonian Astrophysical Observation", "SAO 183479"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.77593095),
        dec: Angle.Degrees(-20.74085006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41869"},
        {"Geneva Identification System", "GEN# -0.02002583"},
        {"Smithsonian Astrophysical Observation", "SAO 176028"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.05900677),
        dec: Angle.Degrees(-20.74050349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211600"},
        {"Hipparcos Number", "HIP 110135"},
        {"Smithsonian Astrophysical Observation", "SAO 191043"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.64240451),
        dec: Angle.Degrees(-20.73995246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77162"},
        {"Hipparcos Number", "HIP 44201"},
        {"Smithsonian Astrophysical Observation", "SAO 176810"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.05961821),
        dec: Angle.Degrees(-20.73814976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164581"},
        {"Hipparcos Number", "HIP 88362"},
        {"Celescope Catalog", "CEL 4598"},
        {"Fundamental Katalog 5th Edition", "FK5 5588"},
        {"Geneva Identification System", "GEN# +1.00164581"},
        {"Smithsonian Astrophysical Observation", "SAO 186158"},
        {"Wilson Evans Batten Catalogue", "WEB 14937"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65549776),
        dec: Angle.Degrees(-20.73761517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8408"},
        {"Hipparcos Number", "HIP 6450"},
        {"Geneva Identification System", "GEN# +1.00008408"},
        {"Smithsonian Astrophysical Observation", "SAO 167001"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.72164862),
        dec: Angle.Degrees(-20.73644052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105171"},
        {"Hipparcos Number", "HIP 59053"},
        {"Smithsonian Astrophysical Observation", "SAO 180470"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.64933761),
        dec: Angle.Degrees(-20.73627543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104222"},
        {"Hipparcos Number", "HIP 58532"},
        {"Geneva Identification System", "GEN# +1.00104222"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.05247218),
        dec: Angle.Degrees(-20.73568767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46257"},
        {"Hipparcos Number", "HIP 31094"},
        {"Smithsonian Astrophysical Observation", "SAO 171882"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.87630097),
        dec: Angle.Degrees(-20.73429422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6412"},
        {"Hipparcos Number", "HIP 5068"},
        {"Geneva Identification System", "GEN# +1.00006412"},
        {"Smithsonian Astrophysical Observation", "SAO 166785"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20609635),
        dec: Angle.Degrees(-20.73246754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138105"},
        {"Hipparcos Number", "HIP 75939"},
        {"Geneva Identification System", "GEN# +1.00138105"},
        {"Renson", "Renson 39300"},
        {"Smithsonian Astrophysical Observation", "SAO 183533"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.65103151),
        dec: Angle.Degrees(-20.72848221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167264"},
        {"Hipparcos Number", "HIP 89439"},
        {"Geneva Identification System", "GEN# +1.00167264"},
        {"Smithsonian Astrophysical Observation", "SAO 186543"},
        {"Wilson Evans Batten Catalogue", "WEB 15215"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.80377287),
        dec: Angle.Degrees(-20.72826670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35441"},
        {"Hipparcos Number", "HIP 25243"},
        {"Smithsonian Astrophysical Observation", "SAO 170386"},
        {"Wilson Evans Batten Catalogue", "WEB 4897"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96914719),
        dec: Angle.Degrees(-20.72773199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75241"},
        {"Smithsonian Astrophysical Observation", "SAO 183413"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.62112124),
        dec: Angle.Degrees(-20.72613934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26916"},
        {"Hipparcos Number", "HIP 19784"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60876103),
        dec: Angle.Degrees(-20.72537434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 911"},
    },
    visualMagnitude: 11.80,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.82272582),
        dec: Angle.Degrees(-20.72529839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 302.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187172"},
        {"Hipparcos Number", "HIP 97522"},
        {"Smithsonian Astrophysical Observation", "SAO 188604"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.31305987),
        dec: Angle.Degrees(-20.72471335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49106"},
        {"Hipparcos Number", "HIP 32417"},
        {"Geneva Identification System", "GEN# +2.22870002"},
        {"New General Catalogue", "NGC 2287 2"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51326664),
        dec: Angle.Degrees(-20.72183671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64172"},
        {"Hipparcos Number", "HIP 38388"},
        {"Geneva Identification System", "GEN# +1.00064172"},
        {"Smithsonian Astrophysical Observation", "SAO 174682"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.95482475),
        dec: Angle.Degrees(-20.72057262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127250"},
        {"Hipparcos Number", "HIP 70961"},
        {"Smithsonian Astrophysical Observation", "SAO 182620"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.71632781),
        dec: Angle.Degrees(-20.71820675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141574"},
        {"Hipparcos Number", "HIP 77601"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.64035138),
        dec: Angle.Degrees(-20.71804376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19123"},
        {"Hipparcos Number", "HIP 14279"},
        {"Smithsonian Astrophysical Observation", "SAO 168274"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.01660457),
        dec: Angle.Degrees(-20.71753545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149527"},
        {"Hipparcos Number", "HIP 81287"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.03949631),
        dec: Angle.Degrees(-20.71542970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27362"},
        {"Hipparcos Number", "HIP 20075"},
        {"Geneva Identification System", "GEN# +1.00027362"},
        {"Smithsonian Astrophysical Observation", "SAO 169317"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56697503),
        dec: Angle.Degrees(-20.71530624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4042 AB"},
        {"Henry Draper", "HD 35796"},
        {"Hipparcos Number", "HIP 25437"},
        {"Smithsonian Astrophysical Observation", "SAO 170424"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.60041570),
        dec: Angle.Degrees(-20.71529322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45932"},
        {"Smithsonian Astrophysical Observation", "SAO 177337"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.48649473),
        dec: Angle.Degrees(-20.71398957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166443"},
        {"Hipparcos Number", "HIP 89129"},
        {"Geneva Identification System", "GEN# +1.00166443"},
        {"Smithsonian Astrophysical Observation", "SAO 186430"},
        {"Wilson Evans Batten Catalogue", "WEB 15134"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.85129601),
        dec: Angle.Degrees(-20.71249765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25344"},
        {"Hipparcos Number", "HIP 18746"},
        {"Smithsonian Astrophysical Observation", "SAO 169029"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.22820959),
        dec: Angle.Degrees(-20.71243994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58416"},
        {"Hipparcos Number", "HIP 35955"},
        {"Geneva Identification System", "GEN# +1.00058416"},
        {"Smithsonian Astrophysical Observation", "SAO 173670"},
        {"Wilson Evans Batten Catalogue", "WEB 7160"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.17934614),
        dec: Angle.Degrees(-20.71177533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195222"},
        {"Hipparcos Number", "HIP 101192"},
        {"Smithsonian Astrophysical Observation", "SAO 189370"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.67099508),
        dec: Angle.Degrees(-20.70966087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58232"},
        {"Hipparcos Number", "HIP 35885"},
        {"Smithsonian Astrophysical Observation", "SAO 173633"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.97451732),
        dec: Angle.Degrees(-20.70932309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159721"},
        {"Hipparcos Number", "HIP 86213"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.26554803),
        dec: Angle.Degrees(-20.70928033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213845"},
        {"Hipparcos Number", "HIP 111449"},
        {"Fundamental Katalog 5th Edition", "FK5 849"},
        {"Geneva Identification System", "GEN# +1.00213845"},
        {"Smithsonian Astrophysical Observation", "SAO 191235"},
        {"Wilson Evans Batten Catalogue", "WEB 19926"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.67291135),
        dec: Angle.Degrees(-20.70785949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224841"},
        {"Hipparcos Number", "HIP 92"},
        {"Geneva Identification System", "GEN# +1.00224841"},
        {"Smithsonian Astrophysical Observation", "SAO 192320"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.29062512),
        dec: Angle.Degrees(-20.70558648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98401"},
        {"Hipparcos Number", "HIP 55264"},
        {"Geneva Identification System", "GEN# +1.00098401"},
        {"Smithsonian Astrophysical Observation", "SAO 179765"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.77896786),
        dec: Angle.Degrees(-20.70486379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9422"},
        {"Hipparcos Number", "HIP 7159"},
        {"Geneva Identification System", "GEN# +1.00009422"},
        {"Smithsonian Astrophysical Observation", "SAO 167117"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.06841978),
        dec: Angle.Degrees(-20.70449760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26338"},
        {"Hipparcos Number", "HIP 19387"},
        {"Fundamental Katalog 5th Edition", "FK5 4374"},
        {"Smithsonian Astrophysical Observation", "SAO 169172"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.29083691),
        dec: Angle.Degrees(-20.70439618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45801"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.08522473),
        dec: Angle.Degrees(-20.70429788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57346"},
        {"Hipparcos Number", "HIP 35544"},
        {"Celescope Catalog", "CEL 1788"},
        {"Smithsonian Astrophysical Observation", "SAO 173487"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.02003436),
        dec: Angle.Degrees(-20.70406563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219895"},
        {"Hipparcos Number", "HIP 115156"},
        {"Smithsonian Astrophysical Observation", "SAO 191821"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.88800161),
        dec: Angle.Degrees(-20.70382530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5444"},
        {"Hipparcos Number", "HIP 4376"},
        {"Geneva Identification System", "GEN# +1.00005444"},
        {"Smithsonian Astrophysical Observation", "SAO 166688"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.01561251),
        dec: Angle.Degrees(-20.70197212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28859"},
        {"Hipparcos Number", "HIP 21147"},
        {"Smithsonian Astrophysical Observation", "SAO 169542"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.99920714),
        dec: Angle.Degrees(-20.69940067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96420"},
        {"Hipparcos Number", "HIP 54308"},
        {"Smithsonian Astrophysical Observation", "SAO 179540"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.65180687),
        dec: Angle.Degrees(-20.69811819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150713"},
        {"Hipparcos Number", "HIP 81887"},
        {"Geneva Identification System", "GEN# +1.00150713"},
        {"Smithsonian Astrophysical Observation", "SAO 184579"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.90707619),
        dec: Angle.Degrees(-20.69666354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102036"},
        {"Hipparcos Number", "HIP 57253"},
        {"Smithsonian Astrophysical Observation", "SAO 180152"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.09916174),
        dec: Angle.Degrees(-20.69574674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134136"},
        {"Hipparcos Number", "HIP 74111"},
        {"Smithsonian Astrophysical Observation", "SAO 183209"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.19785121),
        dec: Angle.Degrees(-20.69447556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18791"},
        {"Hipparcos Number", "HIP 14038"},
        {"Fundamental Katalog 5th Edition", "FK5 4276"},
        {"Smithsonian Astrophysical Observation", "SAO 168220"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.20171788),
        dec: Angle.Degrees(-20.69374532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63064"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.82202557),
        dec: Angle.Degrees(-20.69035732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98019"},
        {"Hipparcos Number", "HIP 55056"},
        {"Smithsonian Astrophysical Observation", "SAO 179713"},
        {"Wilson Evans Batten Catalogue", "WEB 9932"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.06425731),
        dec: Angle.Degrees(-20.69002528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40163"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.03830539),
        dec: Angle.Degrees(-20.68891047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29506"},
        {"Hipparcos Number", "HIP 21576"},
        {"Smithsonian Astrophysical Observation", "SAO 169624"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.49651619),
        dec: Angle.Degrees(-20.68802828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70524"},
        {"Hipparcos Number", "HIP 40978"},
        {"Geneva Identification System", "GEN# +1.00070524"},
        {"Smithsonian Astrophysical Observation", "SAO 175671"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42990631),
        dec: Angle.Degrees(-20.68800760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20492"},
        {"Hipparcos Number", "HIP 15286"},
        {"Geneva Identification System", "GEN# +1.00020492"},
        {"Smithsonian Astrophysical Observation", "SAO 168440"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.31120866),
        dec: Angle.Degrees(-20.68544906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219605"},
        {"Hipparcos Number", "HIP 114968"},
        {"Geneva Identification System", "GEN# +1.00219605"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.28490347),
        dec: Angle.Degrees(-20.68490953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51282"},
        {"Smithsonian Astrophysical Observation", "SAO 178857"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.11855232),
        dec: Angle.Degrees(-20.68173231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29172"},
        {"Smithsonian Astrophysical Observation", "SAO 171302"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.30637374),
        dec: Angle.Degrees(-20.68112991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49023"},
        {"Hipparcos Number", "HIP 32390"},
        {"Geneva Identification System", "GEN# +2.22870103"},
        {"Renson", "Renson 13160"},
        {"Smithsonian Astrophysical Observation", "SAO 172279"},
        {"New General Catalogue", "NGC 2287 103"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.39798220),
        dec: Angle.Degrees(-20.68093426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155048"},
        {"Hipparcos Number", "HIP 83976"},
        {"Geneva Identification System", "GEN# +1.00155048"},
        {"Smithsonian Astrophysical Observation", "SAO 185095"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.48860521),
        dec: Angle.Degrees(-20.68008022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50192"},
        {"Hipparcos Number", "HIP 32902"},
        {"Geneva Identification System", "GEN# +1.00050192"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.83185511),
        dec: Angle.Degrees(-20.67982078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114595"},
        {"Hipparcos Number", "HIP 64380"},
        {"Smithsonian Astrophysical Observation", "SAO 181448"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.93082225),
        dec: Angle.Degrees(-20.67725652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5643"},
        {"Hipparcos Number", "HIP 4525"},
        {"Geneva Identification System", "GEN# +1.00005643"},
        {"Smithsonian Astrophysical Observation", "SAO 166710"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.49142186),
        dec: Angle.Degrees(-20.67606559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205044"},
        {"Hipparcos Number", "HIP 106414"},
        {"Geneva Identification System", "GEN# +1.00205044"},
        {"Smithsonian Astrophysical Observation", "SAO 190436"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.30078047),
        dec: Angle.Degrees(-20.67558605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52486"},
        {"Hipparcos Number", "HIP 33758"},
        {"Smithsonian Astrophysical Observation", "SAO 172742"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.17261425),
        dec: Angle.Degrees(-20.67553293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51056"},
        {"Hipparcos Number", "HIP 33246"},
        {"Geneva Identification System", "GEN# +1.00051056"},
    },
    visualMagnitude: 9.87,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.75893414),
        dec: Angle.Degrees(-20.67431874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84501"},
        {"Hipparcos Number", "HIP 47856"},
        {"Geneva Identification System", "GEN# +1.00084501"},
        {"Smithsonian Astrophysical Observation", "SAO 177934"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31346110),
        dec: Angle.Degrees(-20.67210690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7711 A"},
        {"Henry Draper", "HD 89169"},
        {"Hipparcos Number", "HIP 50340"},
        {"Geneva Identification System", "GEN# +1.00089169"},
        {"Smithsonian Astrophysical Observation", "SAO 178610"},
        {"Wilson Evans Batten Catalogue", "WEB 9244"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.19137654),
        dec: Angle.Degrees(-20.66964643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144470"},
        {"Hipparcos Number", "HIP 78933"},
        {"Celescope Catalog", "CEL 4413"},
        {"Geneva Identification System", "GEN# +1.00144470"},
        {"Smithsonian Astrophysical Observation", "SAO 184123"},
        {"Wilson Evans Batten Catalogue", "WEB 13343"},
    },
    visualMagnitude: 3.93,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.70180197),
        dec: Angle.Degrees(-20.66913479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94619"},
        {"Hipparcos Number", "HIP 53387"},
        {"Fundamental Katalog 5th Edition", "FK5 2872"},
        {"Geneva Identification System", "GEN# +1.00094619"},
        {"Smithsonian Astrophysical Observation", "SAO 179334"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.79824702),
        dec: Angle.Degrees(-20.66497238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
