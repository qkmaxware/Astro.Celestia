using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_94() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1996 A"},
        {"Henry Draper", "HD 16327"},
        {"Hipparcos Number", "HIP 12287"},
        {"Geneva Identification System", "GEN# +1.00016327A"},
        {"Smithsonian Astrophysical Observation", "SAO 55729"},
        {"Wilson Evans Batten Catalogue", "WEB 2519"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.57440986),
        dec: Angle.Degrees(+37.72682260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25975"},
        {"Hipparcos Number", "HIP 19302"},
        {"Geneva Identification System", "GEN# +1.00025975"},
        {"Smithsonian Astrophysical Observation", "SAO 57000"},
        {"Wilson Evans Batten Catalogue", "WEB 3710"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.06442382),
        dec: Angle.Degrees(+37.72797171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90877"},
        {"Hipparcos Number", "HIP 51433"},
        {"Smithsonian Astrophysical Observation", "SAO 62078"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.56316481),
        dec: Angle.Degrees(+37.72820781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2116 A"},
        {"Henry Draper", "HD 17239"},
        {"Hipparcos Number", "HIP 13001"},
        {"Smithsonian Astrophysical Observation", "SAO 55874"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78570053),
        dec: Angle.Degrees(+37.72908554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214295"},
        {"Hipparcos Number", "HIP 111605"},
        {"Smithsonian Astrophysical Observation", "SAO 72530"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15485972),
        dec: Angle.Degrees(+37.72932809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41674"},
        {"Hipparcos Number", "HIP 29110"},
        {"Geneva Identification System", "GEN# +1.00041674"},
        {"Smithsonian Astrophysical Observation", "SAO 58778"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.08210174),
        dec: Angle.Degrees(+37.73117731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103095"},
        {"Hipparcos Number", "HIP 57939"},
        {"Cincinnati Publication", "Ci 20 666"},
        {"Fundamental Katalog 5th Edition", "FK5 1307"},
        {"Geneva Identification System", "GEN# +1.00103095"},
        {"Smithsonian Astrophysical Observation", "SAO 62738"},
        {"Wilson Evans Batten Catalogue", "WEB 10381"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.23256802),
        dec: Angle.Degrees(+37.73280827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4003.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5813.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190863"},
        {"Hipparcos Number", "HIP 98963"},
        {"Smithsonian Astrophysical Observation", "SAO 69389"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.38928782),
        dec: Angle.Degrees(+37.73491658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130214"},
        {"Hipparcos Number", "HIP 72175"},
        {"Smithsonian Astrophysical Observation", "SAO 64312"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43789518),
        dec: Angle.Degrees(+37.73616299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69498"},
        {"Hipparcos Number", "HIP 40718"},
        {"Smithsonian Astrophysical Observation", "SAO 60716"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.67818330),
        dec: Angle.Degrees(+37.73722129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28600"},
        {"Smithsonian Astrophysical Observation", "SAO 58675"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.54633893),
        dec: Angle.Degrees(+37.73752646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30016"},
        {"Hipparcos Number", "HIP 22115"},
        {"Geneva Identification System", "GEN# +1.00030016"},
        {"Smithsonian Astrophysical Observation", "SAO 57414"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.39642299),
        dec: Angle.Degrees(+37.73809390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222088"},
        {"Hipparcos Number", "HIP 116576"},
        {"Smithsonian Astrophysical Observation", "SAO 73382"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.35554429),
        dec: Angle.Degrees(+37.73948799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12967"},
        {"Smithsonian Astrophysical Observation", "SAO 55864"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.69899069),
        dec: Angle.Degrees(+37.74056850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17985"},
        {"Hipparcos Number", "HIP 13555"},
        {"Geneva Identification System", "GEN# +1.00017985"},
        {"Smithsonian Astrophysical Observation", "SAO 55989"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.65372318),
        dec: Angle.Degrees(+37.74212097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185620"},
        {"Hipparcos Number", "HIP 96609"},
        {"Smithsonian Astrophysical Observation", "SAO 68615"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.62154683),
        dec: Angle.Degrees(+37.74321127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86811"},
        {"Hipparcos Number", "HIP 49157"},
        {"Smithsonian Astrophysical Observation", "SAO 61817"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.48276415),
        dec: Angle.Degrees(+37.74344358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7483"},
        {"Hipparcos Number", "HIP 5881"},
        {"Geneva Identification System", "GEN# +1.00007483"},
        {"Smithsonian Astrophysical Observation", "SAO 54557"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.88025814),
        dec: Angle.Degrees(+37.74350026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33568"},
        {"Hipparcos Number", "HIP 24303"},
        {"Geneva Identification System", "GEN# +1.00033568"},
        {"Smithsonian Astrophysical Observation", "SAO 57745"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.22278398),
        dec: Angle.Degrees(+37.74374801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228391"},
        {"Hipparcos Number", "HIP 99648"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33949544),
        dec: Angle.Degrees(+37.74551386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109784",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15766 AB"},
        {"Hipparcos Number", "HIP 109784"},
        {"Smithsonian Astrophysical Observation", "SAO 72159"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.56466425),
        dec: Angle.Degrees(+37.74591078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80206"},
        {"Smithsonian Astrophysical Observation", "SAO 65260"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.60970651),
        dec: Angle.Degrees(+37.74846006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211388"},
        {"Hipparcos Number", "HIP 109937"},
        {"Geneva Identification System", "GEN# +1.00211388"},
        {"Smithsonian Astrophysical Observation", "SAO 72191"},
        {"Wilson Evans Batten Catalogue", "WEB 19739"},
    },
    visualMagnitude: 4.14,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.99237570),
        dec: Angle.Degrees(+37.74873483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72007",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9362 AB"},
        {"Hipparcos Number", "HIP 72007"},
        {"Smithsonian Astrophysical Observation", "SAO 64296"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.91037146),
        dec: Angle.Degrees(+37.74969356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125142"},
        {"Hipparcos Number", "HIP 69760"},
        {"Smithsonian Astrophysical Observation", "SAO 64044"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.15586879),
        dec: Angle.Degrees(+37.75137886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199581"},
        {"Hipparcos Number", "HIP 103410"},
        {"Smithsonian Astrophysical Observation", "SAO 70710"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.26986554),
        dec: Angle.Degrees(+37.75185591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207701"},
        {"Hipparcos Number", "HIP 107769"},
        {"Smithsonian Astrophysical Observation", "SAO 71748"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.49202483),
        dec: Angle.Degrees(+37.75390220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68501"},
        {"Hipparcos Number", "HIP 40338"},
        {"Smithsonian Astrophysical Observation", "SAO 60658"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.54300110),
        dec: Angle.Degrees(+37.75438569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80313"},
        {"Hipparcos Number", "HIP 45788"},
        {"Geneva Identification System", "GEN# +1.00080313"},
        {"Smithsonian Astrophysical Observation", "SAO 61405"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.03015838),
        dec: Angle.Degrees(+37.75565730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36661"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.13646391),
        dec: Angle.Degrees(+37.75959065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30617"},
        {"Hipparcos Number", "HIP 22529"},
        {"Geneva Identification System", "GEN# +1.00030617"},
        {"Smithsonian Astrophysical Observation", "SAO 57452"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.72134391),
        dec: Angle.Degrees(+37.76040972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1770"},
        {"Hipparcos Number", "HIP 1760"},
        {"Geneva Identification System", "GEN# +1.00001770"},
        {"Smithsonian Astrophysical Observation", "SAO 53842"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.57192628),
        dec: Angle.Degrees(+37.76130546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61141"},
        {"Geneva Identification System", "GEN# +0.03802346"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.93827344),
        dec: Angle.Degrees(+37.76341498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93286"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.01116570),
        dec: Angle.Degrees(+37.76478941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15828 B"},
        {"Hipparcos Number", "HIP 110170"},
        {"Geneva Identification System", "GEN# +1.00211797B"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.73272175),
        dec: Angle.Degrees(+37.76489673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80541"},
        {"Smithsonian Astrophysical Observation", "SAO 65304"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.65914585),
        dec: Angle.Degrees(+37.76489739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147216"},
        {"Hipparcos Number", "HIP 79939"},
        {"Smithsonian Astrophysical Observation", "SAO 65223"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.75243129),
        dec: Angle.Degrees(+37.76582610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156909"},
        {"Hipparcos Number", "HIP 84667"},
        {"Geneva Identification System", "GEN# +1.00156909"},
        {"Smithsonian Astrophysical Observation", "SAO 65931"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.63557179),
        dec: Angle.Degrees(+37.76678641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121843"},
        {"Hipparcos Number", "HIP 68159"},
        {"Smithsonian Astrophysical Observation", "SAO 63854"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.30538855),
        dec: Angle.Degrees(+37.76756038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70944"},
        {"Smithsonian Astrophysical Observation", "SAO 64189"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.66795252),
        dec: Angle.Degrees(+37.76914543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110171",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15828 A"},
        {"Henry Draper", "HD 211797"},
        {"Hipparcos Number", "HIP 110171"},
        {"Geneva Identification System", "GEN# +1.00211797A"},
        {"Renson", "Renson 58790"},
        {"Smithsonian Astrophysical Observation", "SAO 72228"},
        {"Wilson Evans Batten Catalogue", "WEB 19773"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.73402774),
        dec: Angle.Degrees(+37.76918003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52954"},
        {"Hipparcos Number", "HIP 34150"},
        {"Smithsonian Astrophysical Observation", "SAO 59749"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.21827293),
        dec: Angle.Degrees(+37.77013133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9125"},
        {"Geneva Identification System", "GEN# +2.07520213"},
        {"Smithsonian Astrophysical Observation", "SAO 55134"},
        {"New General Catalogue", "NGC 752 213"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.41226270),
        dec: Angle.Degrees(+37.77014538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54334"},
        {"Smithsonian Astrophysical Observation", "SAO 62411"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.72187335),
        dec: Angle.Degrees(+37.77031742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65913"},
        {"Geneva Identification System", "GEN# +0.03802454"},
        {"Smithsonian Astrophysical Observation", "SAO 63576"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.68305270),
        dec: Angle.Degrees(+37.77499443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180123"},
        {"Hipparcos Number", "HIP 94468"},
        {"Geneva Identification System", "GEN# +1.00180123"},
        {"Smithsonian Astrophysical Observation", "SAO 68005"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.40823719),
        dec: Angle.Degrees(+37.77568357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165801"},
        {"Hipparcos Number", "HIP 88674"},
        {"Geneva Identification System", "GEN# +1.00165801"},
        {"Smithsonian Astrophysical Observation", "SAO 66631"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.53841465),
        dec: Angle.Degrees(+37.77627252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48564"},
        {"Hipparcos Number", "HIP 32394"},
        {"Smithsonian Astrophysical Observation", "SAO 59453"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.44333650),
        dec: Angle.Degrees(+37.77818012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155178"},
        {"Hipparcos Number", "HIP 83860"},
        {"Smithsonian Astrophysical Observation", "SAO 65818"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.08282869),
        dec: Angle.Degrees(+37.77977400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172243"},
        {"Hipparcos Number", "HIP 91310"},
        {"Smithsonian Astrophysical Observation", "SAO 67180"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38021536),
        dec: Angle.Degrees(+37.78061318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202349"},
        {"Hipparcos Number", "HIP 104814"},
        {"Celescope Catalog", "CEL 5279"},
        {"Geneva Identification System", "GEN# +1.00202349"},
        {"Smithsonian Astrophysical Observation", "SAO 71104"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.52275982),
        dec: Angle.Degrees(+37.78161511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136419"},
        {"Hipparcos Number", "HIP 74977"},
        {"Smithsonian Astrophysical Observation", "SAO 64629"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.82878403),
        dec: Angle.Degrees(+37.78460613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61488"},
        {"Geneva Identification System", "GEN# +0.03802350"},
        {"Smithsonian Astrophysical Observation", "SAO 63091"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.97271998),
        dec: Angle.Degrees(+37.78640355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158084"},
        {"Hipparcos Number", "HIP 85276"},
        {"Smithsonian Astrophysical Observation", "SAO 66035"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.37270680),
        dec: Angle.Degrees(+37.78658470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17269"},
        {"Hipparcos Number", "HIP 13028"},
        {"Smithsonian Astrophysical Observation", "SAO 55879"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.86544980),
        dec: Angle.Degrees(+37.79109742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5854"},
        {"Hipparcos Number", "HIP 4710"},
        {"Geneva Identification System", "GEN# +1.00005854"},
        {"Smithsonian Astrophysical Observation", "SAO 54339"},
        {"Wilson Evans Batten Catalogue", "WEB 889"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13083693),
        dec: Angle.Degrees(+37.79150416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275682"},
        {"Hipparcos Number", "HIP 17094"},
        {"Geneva Identification System", "GEN# +1.00275682"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.92237711),
        dec: Angle.Degrees(+37.79233291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179143"},
        {"Henry Draper 2", "HD 179144"},
        {"Hipparcos Number", "HIP 94142"},
        {"Geneva Identification System", "GEN# +1.00179143"},
        {"Renson", "Renson 49770"},
        {"Smithsonian Astrophysical Observation", "SAO 67896"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.44197876),
        dec: Angle.Degrees(+37.79427953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21944"},
        {"Hipparcos Number", "HIP 16603"},
        {"Smithsonian Astrophysical Observation", "SAO 56540"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.43158306),
        dec: Angle.Degrees(+37.79601068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74506"},
        {"Smithsonian Astrophysical Observation", "SAO 64569"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.38269254),
        dec: Angle.Degrees(+37.79651220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224656"},
        {"Hipparcos Number", "HIP 118297"},
        {"Smithsonian Astrophysical Observation", "SAO 73657"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.91470040),
        dec: Angle.Degrees(+37.79962740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221757"},
        {"Hipparcos Number", "HIP 116360"},
        {"Geneva Identification System", "GEN# +1.00221757"},
        {"Smithsonian Astrophysical Observation", "SAO 73347"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.67144947),
        dec: Angle.Degrees(+37.79966963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215191"},
        {"Hipparcos Number", "HIP 112144"},
        {"Geneva Identification System", "GEN# +1.00215191"},
        {"Smithsonian Astrophysical Observation", "SAO 72652"},
        {"Wilson Evans Batten Catalogue", "WEB 20010"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.73103152),
        dec: Angle.Degrees(+37.80274748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163967"},
        {"Hipparcos Number", "HIP 87883"},
        {"Smithsonian Astrophysical Observation", "SAO 66505"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.28743723),
        dec: Angle.Degrees(+37.80288395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279484"},
        {"Hipparcos Number", "HIP 19566"},
        {"Smithsonian Astrophysical Observation", "SAO 57053"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.86814251),
        dec: Angle.Degrees(+37.80315967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43982"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.34438392),
        dec: Angle.Degrees(+37.80632847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11165"},
        {"Hipparcos Number", "HIP 8575"},
        {"Geneva Identification System", "GEN# +1.00011165"},
        {"Smithsonian Astrophysical Observation", "SAO 55019"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.64734695),
        dec: Angle.Degrees(+37.81001715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19280"},
        {"Hipparcos Number", "HIP 14509"},
        {"Smithsonian Astrophysical Observation", "SAO 56171"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83936600),
        dec: Angle.Degrees(+37.81038491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130817"},
        {"Hipparcos Number", "HIP 72469"},
        {"Fundamental Katalog 5th Edition", "FK5 1386"},
        {"Geneva Identification System", "GEN# +1.00130817"},
        {"Smithsonian Astrophysical Observation", "SAO 64344"},
        {"Wilson Evans Batten Catalogue", "WEB 12454"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27887478),
        dec: Angle.Degrees(+37.81091287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36070"},
        {"Hipparcos Number", "HIP 25817"},
        {"Renson", "Renson 9310"},
        {"Smithsonian Astrophysical Observation", "SAO 58131"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70278591),
        dec: Angle.Degrees(+37.81172669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177250"},
        {"Hipparcos Number", "HIP 93474"},
        {"Smithsonian Astrophysical Observation", "SAO 67725"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.54290996),
        dec: Angle.Degrees(+37.81194310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78828"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.37201675),
        dec: Angle.Degrees(+37.81216245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190275"},
        {"Hipparcos Number", "HIP 98697"},
        {"Geneva Identification System", "GEN# +1.00190275"},
        {"Renson", "Renson 52880"},
        {"Smithsonian Astrophysical Observation", "SAO 69310"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.69419411),
        dec: Angle.Degrees(+37.81278047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75352"},
        {"Hipparcos Number", "HIP 43440"},
        {"Smithsonian Astrophysical Observation", "SAO 61079"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.70999417),
        dec: Angle.Degrees(+37.81396750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61614"},
        {"Geneva Identification System", "GEN# +0.03802351"},
        {"Smithsonian Astrophysical Observation", "SAO 63107"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.39597682),
        dec: Angle.Degrees(+37.81418306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26360"},
        {"Smithsonian Astrophysical Observation", "SAO 58248"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.20539655),
        dec: Angle.Degrees(+37.81482455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275835"},
        {"Hipparcos Number", "HIP 17741"},
        {"Smithsonian Astrophysical Observation", "SAO 56708"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.99192440),
        dec: Angle.Degrees(+37.81527836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9245"},
        {"Geneva Identification System", "GEN# +2.07520311"},
        {"Smithsonian Astrophysical Observation", "SAO 55164"},
        {"New General Catalogue", "NGC 752 311"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72039865),
        dec: Angle.Degrees(+37.81592529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112869"},
        {"Hipparcos Number", "HIP 63389"},
        {"Geneva Identification System", "GEN# +1.00112869"},
        {"Smithsonian Astrophysical Observation", "SAO 63280"},
        {"Wilson Evans Batten Catalogue", "WEB 11222"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.84439946),
        dec: Angle.Degrees(+37.81773232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174321"},
        {"Hipparcos Number", "HIP 92276"},
        {"Smithsonian Astrophysical Observation", "SAO 67405"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.09003109),
        dec: Angle.Degrees(+37.82016094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213012"},
        {"Hipparcos Number", "HIP 110874"},
        {"Smithsonian Astrophysical Observation", "SAO 72370"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.94663540),
        dec: Angle.Degrees(+37.82241256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58185"},
        {"Hipparcos Number", "HIP 36091"},
        {"Smithsonian Astrophysical Observation", "SAO 60070"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.53784552),
        dec: Angle.Degrees(+37.82308764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15193 AB"},
        {"Hipparcos Number", "HIP 106960"},
        {"Smithsonian Astrophysical Observation", "SAO 71570"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.95288741),
        dec: Angle.Degrees(+37.82360704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66862"},
        {"Geneva Identification System", "GEN# +0.03802471"},
        {"Smithsonian Astrophysical Observation", "SAO 63697"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56509521),
        dec: Angle.Degrees(+37.82462219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187880"},
        {"Hipparcos Number", "HIP 97651"},
        {"Geneva Identification System", "GEN# +1.00187880"},
        {"Smithsonian Astrophysical Observation", "SAO 68953"},
        {"Wilson Evans Batten Catalogue", "WEB 17174"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69528937),
        dec: Angle.Degrees(+37.82631382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143328"},
        {"Hipparcos Number", "HIP 78222"},
        {"Geneva Identification System", "GEN# +1.00143328"},
        {"Smithsonian Astrophysical Observation", "SAO 64994"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.60111547),
        dec: Angle.Degrees(+37.82749832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68908"},
        {"Geneva Identification System", "GEN# +0.03802514"},
        {"Wilson Evans Batten Catalogue", "WEB 12043"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.61664193),
        dec: Angle.Degrees(+37.82822587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68097"},
        {"Smithsonian Astrophysical Observation", "SAO 63843"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.12865690),
        dec: Angle.Degrees(+37.83003432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106629"},
        {"Smithsonian Astrophysical Observation", "SAO 71499"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.96793494),
        dec: Angle.Degrees(+37.83022562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68428"},
        {"Smithsonian Astrophysical Observation", "SAO 63882"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.13320030),
        dec: Angle.Degrees(+37.83107764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39094"},
        {"Hipparcos Number", "HIP 27706"},
        {"Geneva Identification System", "GEN# +1.00039094"},
        {"Smithsonian Astrophysical Observation", "SAO 58517"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.99863419),
        dec: Angle.Degrees(+37.83282316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165540"},
        {"Hipparcos Number", "HIP 88545"},
        {"Geneva Identification System", "GEN# +1.00165540"},
        {"Smithsonian Astrophysical Observation", "SAO 66613"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20523942),
        dec: Angle.Degrees(+37.83407628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141990"},
        {"Hipparcos Number", "HIP 77598"},
        {"Geneva Identification System", "GEN# +1.00141990"},
        {"Smithsonian Astrophysical Observation", "SAO 64941"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.63537046),
        dec: Angle.Degrees(+37.83540699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92266"},
        {"Hipparcos Number", "HIP 52197"},
        {"Smithsonian Astrophysical Observation", "SAO 62186"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.96070619),
        dec: Angle.Degrees(+37.83917976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88428"},
        {"Smithsonian Astrophysical Observation", "SAO 66589"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.80629447),
        dec: Angle.Degrees(+37.83984251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77407"},
        {"Hipparcos Number", "HIP 44458"},
        {"Geneva Identification System", "GEN# +1.00077407"},
        {"Smithsonian Astrophysical Observation", "SAO 61224"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.86310725),
        dec: Angle.Degrees(+37.84138814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214263"},
        {"Hipparcos Number", "HIP 111589"},
        {"Geneva Identification System", "GEN# +1.00214263"},
        {"Smithsonian Astrophysical Observation", "SAO 72525"},
        {"Wilson Evans Batten Catalogue", "WEB 19948"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.09302670),
        dec: Angle.Degrees(+37.84224024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116843"},
        {"Hipparcos Number", "HIP 65513"},
        {"Geneva Identification System", "GEN# +1.00116843"},
        {"Smithsonian Astrophysical Observation", "SAO 63532"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.43433516),
        dec: Angle.Degrees(+37.84252734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153777"},
        {"Hipparcos Number", "HIP 83167"},
        {"Geneva Identification System", "GEN# +1.00153777"},
        {"Smithsonian Astrophysical Observation", "SAO 65712"},
        {"Wilson Evans Batten Catalogue", "WEB 14055"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.95812245),
        dec: Angle.Degrees(+37.84945210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188592"},
        {"Hipparcos Number", "HIP 97951"},
        {"Smithsonian Astrophysical Observation", "SAO 69063"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61147149),
        dec: Angle.Degrees(+37.84966843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117691"},
        {"Smithsonian Astrophysical Observation", "SAO 73567"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.03130959),
        dec: Angle.Degrees(+37.85025634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196179"},
        {"Hipparcos Number", "HIP 101518"},
        {"Smithsonian Astrophysical Observation", "SAO 70214"},
        {"Wilson Evans Batten Catalogue", "WEB 18345"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.59482180),
        dec: Angle.Degrees(+37.85051046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31597"},
        {"Geneva Identification System", "GEN# +0.03701545"},
        {"Smithsonian Astrophysical Observation", "SAO 59288"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.19350717),
        dec: Angle.Degrees(+37.85236498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105516"},
        {"Hipparcos Number", "HIP 59226"},
        {"Geneva Identification System", "GEN# +1.00105516"},
        {"Smithsonian Astrophysical Observation", "SAO 62861"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.20659243),
        dec: Angle.Degrees(+37.85529053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116156"},
        {"Hipparcos Number", "HIP 65159"},
        {"Geneva Identification System", "GEN# +1.00116156"},
        {"Smithsonian Astrophysical Observation", "SAO 63491"},
        {"Wilson Evans Batten Catalogue", "WEB 11505"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.29530754),
        dec: Angle.Degrees(+37.85709767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13041"},
        {"Hipparcos Number", "HIP 9977"},
        {"Celescope Catalog", "CEL 207"},
        {"Fundamental Katalog 5th Edition", "FK5 2145"},
        {"Geneva Identification System", "GEN# +1.00013041"},
        {"Smithsonian Astrophysical Observation", "SAO 55289"},
        {"Wilson Evans Batten Catalogue", "WEB 2090"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.12144102),
        dec: Angle.Degrees(+37.85918337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161001"},
        {"Hipparcos Number", "HIP 86570"},
        {"Smithsonian Astrophysical Observation", "SAO 66259"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.36658826),
        dec: Angle.Degrees(+37.86165991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280238"},
        {"Hipparcos Number", "HIP 23013"},
        {"Smithsonian Astrophysical Observation", "SAO 57519"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24564843),
        dec: Angle.Degrees(+37.86597045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67204"},
        {"Hipparcos Number", "HIP 39836"},
        {"Smithsonian Astrophysical Observation", "SAO 60591"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.08926067),
        dec: Angle.Degrees(+37.86767923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69287"},
        {"Hipparcos Number", "HIP 40641"},
        {"Geneva Identification System", "GEN# +1.00069287"},
        {"Smithsonian Astrophysical Observation", "SAO 60704"},
        {"Wilson Evans Batten Catalogue", "WEB 7899"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.44782001),
        dec: Angle.Degrees(+37.86769601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86865",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10767 AB"},
        {"Henry Draper", "HD 161601"},
        {"Hipparcos Number", "HIP 86865"},
        {"Smithsonian Astrophysical Observation", "SAO 66302"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.22010600),
        dec: Angle.Degrees(+37.86893626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122316"},
        {"Hipparcos Number", "HIP 68417"},
        {"Geneva Identification System", "GEN# +1.00122316"},
        {"Smithsonian Astrophysical Observation", "SAO 63879"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.09323282),
        dec: Angle.Degrees(+37.87117438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160863"},
        {"Hipparcos Number", "HIP 86503"},
        {"Smithsonian Astrophysical Observation", "SAO 66246"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.16086469),
        dec: Angle.Degrees(+37.87186297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23885"},
        {"Hipparcos Number", "HIP 17930"},
        {"Geneva Identification System", "GEN# +1.00023885"},
        {"Smithsonian Astrophysical Observation", "SAO 56730"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51423104),
        dec: Angle.Degrees(+37.87399936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95024"},
        {"Wilson Evans Batten Catalogue", "WEB 16596"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.01643388),
        dec: Angle.Degrees(+37.87430323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81776"},
        {"Smithsonian Astrophysical Observation", "SAO 65496"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.54391533),
        dec: Angle.Degrees(+37.87549594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75285"},
        {"Smithsonian Astrophysical Observation", "SAO 64672"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.72551458),
        dec: Angle.Degrees(+37.87562311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49750"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.33853373),
        dec: Angle.Degrees(+37.87641690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205697"},
        {"Hipparcos Number", "HIP 106647"},
        {"Smithsonian Astrophysical Observation", "SAO 71504"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.03704167),
        dec: Angle.Degrees(+37.87646146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104017"},
        {"Hipparcos Number", "HIP 58422"},
        {"Geneva Identification System", "GEN# +1.00104017"},
        {"Smithsonian Astrophysical Observation", "SAO 62781"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.68830633),
        dec: Angle.Degrees(+37.87715617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2256 A"},
        {"Henry Draper", "HD 18483"},
        {"Hipparcos Number", "HIP 13936"},
        {"Smithsonian Astrophysical Observation", "SAO 56056"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.88544995),
        dec: Angle.Degrees(+37.87823481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167043"},
        {"Hipparcos Number", "HIP 89159"},
        {"Geneva Identification System", "GEN# +1.00167043"},
        {"Smithsonian Astrophysical Observation", "SAO 66739"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94506612),
        dec: Angle.Degrees(+37.88739639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81246"},
        {"Hipparcos Number", "HIP 46243"},
        {"Fundamental Katalog 5th Edition", "FK5 4842"},
        {"Geneva Identification System", "GEN# +1.00081246"},
        {"Smithsonian Astrophysical Observation", "SAO 61477"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.41259061),
        dec: Angle.Degrees(+37.88903029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47803"},
        {"Smithsonian Astrophysical Observation", "SAO 61662"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.17518022),
        dec: Angle.Degrees(+37.88936055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67856"},
        {"Smithsonian Astrophysical Observation", "SAO 63814"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48009116),
        dec: Angle.Degrees(+37.88991356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23179",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3572 A"},
        {"Henry Draper", "HD 31647A"},
        {"Henry Draper 2", "HD 31647"},
        {"Hipparcos Number", "HIP 23179"},
        {"Geneva Identification System", "GEN# +1.00031647"},
        {"Smithsonian Astrophysical Observation", "SAO 57548"},
        {"Wilson Evans Batten Catalogue", "WEB 4498"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.81406425),
        dec: Angle.Degrees(+37.89048240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117673",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17054 AB"},
        {"Henry Draper", "HD 223718"},
        {"Hipparcos Number", "HIP 117673"},
        {"Geneva Identification System", "GEN# +1.00223718"},
        {"Smithsonian Astrophysical Observation", "SAO 73565"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.96855501),
        dec: Angle.Degrees(+37.89141041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120245"},
        {"Hipparcos Number", "HIP 67300"},
        {"Geneva Identification System", "GEN# +1.00120245"},
        {"Smithsonian Astrophysical Observation", "SAO 63747"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.88143049),
        dec: Angle.Degrees(+37.89331350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86966"},
        {"Hipparcos Number", "HIP 49228"},
        {"Geneva Identification System", "GEN# +1.00086966"},
        {"Smithsonian Astrophysical Observation", "SAO 61825"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.73360092),
        dec: Angle.Degrees(+37.89338472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218894"},
        {"Hipparcos Number", "HIP 114494"},
        {"Smithsonian Astrophysical Observation", "SAO 73065"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.83139511),
        dec: Angle.Degrees(+37.89584259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210086"},
        {"Hipparcos Number", "HIP 109184"},
        {"Smithsonian Astrophysical Observation", "SAO 72043"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.77560473),
        dec: Angle.Degrees(+37.90077336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4168 AB"},
        {"Henry Draper", "HD 36706"},
        {"Hipparcos Number", "HIP 26249"},
        {"Renson", "Renson 9610"},
        {"Smithsonian Astrophysical Observation", "SAO 58210"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86533247),
        dec: Angle.Degrees(+37.90200352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8516 A"},
        {"Henry Draper", "HD 107341"},
        {"Hipparcos Number", "HIP 60161"},
        {"Geneva Identification System", "GEN# +1.00107341A"},
        {"Smithsonian Astrophysical Observation", "SAO 62953"},
        {"Wilson Evans Batten Catalogue", "WEB 10695"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.05643784),
        dec: Angle.Degrees(+37.90215574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31183"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.14789462),
        dec: Angle.Degrees(+37.90339428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206698"},
        {"Hipparcos Number", "HIP 107216"},
        {"Smithsonian Astrophysical Observation", "SAO 71635"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.73364574),
        dec: Angle.Degrees(+37.90488633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57689"},
        {"Smithsonian Astrophysical Observation", "SAO 62719"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46732289),
        dec: Angle.Degrees(+37.90542419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280859"},
        {"Hipparcos Number", "HIP 24885"},
        {"Smithsonian Astrophysical Observation", "SAO 57904"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.01905251),
        dec: Angle.Degrees(+37.90919016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92168"},
        {"Hipparcos Number", "HIP 52139"},
        {"Fundamental Katalog 5th Edition", "FK5 2852"},
        {"Geneva Identification System", "GEN# +1.00092168"},
        {"Smithsonian Astrophysical Observation", "SAO 62178"},
        {"Wilson Evans Batten Catalogue", "WEB 9503"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.78248119),
        dec: Angle.Degrees(+37.91011130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73612"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.69198348),
        dec: Angle.Degrees(+37.91015699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94024",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12090 A"},
        {"Henry Draper", "HD 178848"},
        {"Hipparcos Number", "HIP 94024"},
        {"Smithsonian Astrophysical Observation", "SAO 67865"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.14053359),
        dec: Angle.Degrees(+37.91026918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108351"},
        {"Smithsonian Astrophysical Observation", "SAO 71868"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.26774758),
        dec: Angle.Degrees(+37.91047522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83128"},
        {"Hipparcos Number", "HIP 47215"},
        {"Geneva Identification System", "GEN# +1.00083128"},
        {"Smithsonian Astrophysical Observation", "SAO 61599"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.33510972),
        dec: Angle.Degrees(+37.91227641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40423"},
        {"Smithsonian Astrophysical Observation", "SAO 60674"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.80023086),
        dec: Angle.Degrees(+37.91362516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76202"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.47845382),
        dec: Angle.Degrees(+37.91399720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85373"},
        {"Hipparcos Number", "HIP 48428"},
        {"Fundamental Katalog 5th Edition", "FK5 2787"},
        {"Geneva Identification System", "GEN# +1.00085373"},
        {"Smithsonian Astrophysical Observation", "SAO 61725"},
        {"Wilson Evans Batten Catalogue", "WEB 9031"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.09027585),
        dec: Angle.Degrees(+37.91451828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9164"},
        {"Geneva Identification System", "GEN# +2.07520238"},
        {"New General Catalogue", "NGC 752 238"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.49724685),
        dec: Angle.Degrees(+37.91502066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5574 A"},
        {"Henry Draper", "HD 50576"},
        {"Hipparcos Number", "HIP 33291"},
        {"Smithsonian Astrophysical Observation", "SAO 59609"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88310653),
        dec: Angle.Degrees(+37.91543849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5574 B"},
        {"Hipparcos Number", "HIP 33296"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88976707),
        dec: Angle.Degrees(+37.91568971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94022",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12090 B"},
        {"Hipparcos Number", "HIP 94022"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.13776281),
        dec: Angle.Degrees(+37.91592573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201776"},
        {"Hipparcos Number", "HIP 104547"},
        {"Celescope Catalog", "CEL 5257"},
        {"Smithsonian Astrophysical Observation", "SAO 71017"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.65994441),
        dec: Angle.Degrees(+37.91601859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21061"},
        {"Hipparcos Number", "HIP 15942"},
        {"Geneva Identification System", "GEN# +1.00021061"},
        {"Smithsonian Astrophysical Observation", "SAO 56428"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.32171030),
        dec: Angle.Degrees(+37.91875216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102552"},
        {"Smithsonian Astrophysical Observation", "SAO 70493"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.73032289),
        dec: Angle.Degrees(+37.92067444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102055"},
        {"Hipparcos Number", "HIP 57290"},
        {"Smithsonian Astrophysical Observation", "SAO 62686"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21045149),
        dec: Angle.Degrees(+37.92279204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81379"},
        {"Smithsonian Astrophysical Observation", "SAO 65436"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.30285965),
        dec: Angle.Degrees(+37.92550612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103044"},
        {"Smithsonian Astrophysical Observation", "SAO 70617"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.15810245),
        dec: Angle.Degrees(+37.92813549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199957"},
        {"Hipparcos Number", "HIP 103580"},
        {"Smithsonian Astrophysical Observation", "SAO 70761"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.80861849),
        dec: Angle.Degrees(+37.93010105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37005"},
        {"Smithsonian Astrophysical Observation", "SAO 60214"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.07509821),
        dec: Angle.Degrees(+37.93136975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225573"},
        {"Hipparcos Number", "HIP 97103"},
        {"Geneva Identification System", "GEN# +1.00225573"},
        {"Renson", "Renson 51437"},
        {"Smithsonian Astrophysical Observation", "SAO 68773"},
        {"Wilson Evans Batten Catalogue", "WEB 17046"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.01769562),
        dec: Angle.Degrees(+37.93259388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18802"},
        {"Hipparcos Number", "HIP 14173"},
        {"Smithsonian Astrophysical Observation", "SAO 56109"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.68953122),
        dec: Angle.Degrees(+37.93286110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52851"},
        {"Smithsonian Astrophysical Observation", "SAO 62258"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.10357882),
        dec: Angle.Degrees(+37.93505669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99579"},
        {"Hipparcos Number", "HIP 55930"},
        {"Geneva Identification System", "GEN# +1.00099579"},
        {"Smithsonian Astrophysical Observation", "SAO 62564"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.93676944),
        dec: Angle.Degrees(+37.93842226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216598"},
        {"Hipparcos Number", "HIP 113052"},
        {"Geneva Identification System", "GEN# +1.00216598"},
        {"Smithsonian Astrophysical Observation", "SAO 72820"},
        {"Wilson Evans Batten Catalogue", "WEB 20125"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.42330105),
        dec: Angle.Degrees(+37.93847734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51705"},
        {"Smithsonian Astrophysical Observation", "SAO 62123"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.46965783),
        dec: Angle.Degrees(+37.93949844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51348"},
        {"Smithsonian Astrophysical Observation", "SAO 62065"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.32972983),
        dec: Angle.Degrees(+37.93982542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85469"},
        {"Smithsonian Astrophysical Observation", "SAO 66072"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.98057519),
        dec: Angle.Degrees(+37.93991363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183362"},
        {"Hipparcos Number", "HIP 95673"},
        {"Celescope Catalog", "CEL 4765"},
        {"Geneva Identification System", "GEN# +1.00183362"},
        {"Smithsonian Astrophysical Observation", "SAO 68346"},
        {"Wilson Evans Batten Catalogue", "WEB 16734"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.90165150),
        dec: Angle.Degrees(+37.94120774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71303"},
        {"Smithsonian Astrophysical Observation", "SAO 64229"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.72772059),
        dec: Angle.Degrees(+37.94467258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228277"},
        {"Hipparcos Number", "HIP 99556"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.05903078),
        dec: Angle.Degrees(+37.94640166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142908"},
        {"Hipparcos Number", "HIP 78012"},
        {"Fundamental Katalog 5th Edition", "FK5 3259"},
        {"Geneva Identification System", "GEN# +1.00142908"},
        {"Smithsonian Astrophysical Observation", "SAO 64974"},
        {"Wilson Evans Batten Catalogue", "WEB 13192"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.94818797),
        dec: Angle.Degrees(+37.94676324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70028"},
        {"Smithsonian Astrophysical Observation", "SAO 64071"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.94655801),
        dec: Angle.Degrees(+37.94702756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88723"},
        {"Hipparcos Number", "HIP 50192"},
        {"Fundamental Katalog 5th Edition", "FK5 4911"},
        {"Geneva Identification System", "GEN# +1.00088723"},
        {"Smithsonian Astrophysical Observation", "SAO 61948"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.68689487),
        dec: Angle.Degrees(+37.94804518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222649"},
        {"Hipparcos Number", "HIP 116947"},
        {"Smithsonian Astrophysical Observation", "SAO 73449"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.58615082),
        dec: Angle.Degrees(+37.94821790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27595"},
        {"Hipparcos Number", "HIP 20452"},
        {"Smithsonian Astrophysical Observation", "SAO 57195"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.72323383),
        dec: Angle.Degrees(+37.95139025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103353"},
        {"Hipparcos Number", "HIP 58028"},
        {"Geneva Identification System", "GEN# +1.00103353"},
        {"Smithsonian Astrophysical Observation", "SAO 62747"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.52005988),
        dec: Angle.Degrees(+37.95221061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152379"},
        {"Hipparcos Number", "HIP 82477"},
        {"Smithsonian Astrophysical Observation", "SAO 65608"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.84175370),
        dec: Angle.Degrees(+37.95278512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10975"},
        {"Hipparcos Number", "HIP 8423"},
        {"Geneva Identification System", "GEN# +1.00010975"},
        {"Smithsonian Astrophysical Observation", "SAO 54991"},
        {"Wilson Evans Batten Catalogue", "WEB 1794"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16184118),
        dec: Angle.Degrees(+37.95293583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99956"},
        {"Hipparcos Number", "HIP 56121"},
        {"Smithsonian Astrophysical Observation", "SAO 62582"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.56823507),
        dec: Angle.Degrees(+37.95385477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65794"},
        {"Geneva Identification System", "GEN# +0.03802450"},
        {"Smithsonian Astrophysical Observation", "SAO 63564"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.31004676),
        dec: Angle.Degrees(+37.95558198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10589 AB"},
        {"Henry Draper", "HD 158755"},
        {"Hipparcos Number", "HIP 85580"},
        {"Smithsonian Astrophysical Observation", "SAO 66084"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.32878646),
        dec: Angle.Degrees(+37.95998852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46583"},
        {"Smithsonian Astrophysical Observation", "SAO 61517"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.48804266),
        dec: Angle.Degrees(+37.96045154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90061"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.68104190),
        dec: Angle.Degrees(+37.96418090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -394.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4649 A"},
        {"Henry Draper", "HD 41162"},
        {"Hipparcos Number", "HIP 28820"},
        {"Geneva Identification System", "GEN# +1.00041162"},
        {"Smithsonian Astrophysical Observation", "SAO 58716"},
        {"Wilson Evans Batten Catalogue", "WEB 5634"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26076660),
        dec: Angle.Degrees(+37.96428777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18628"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.80415398),
        dec: Angle.Degrees(+37.96505699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204920"},
        {"Hipparcos Number", "HIP 106216"},
        {"Smithsonian Astrophysical Observation", "SAO 71417"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.70277503),
        dec: Angle.Degrees(+37.96644601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26605"},
        {"Hipparcos Number", "HIP 19746"},
        {"Smithsonian Astrophysical Observation", "SAO 57081"},
        {"Wilson Evans Batten Catalogue", "WEB 3768"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.49887528),
        dec: Angle.Degrees(+37.96713609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81272"},
        {"Geneva Identification System", "GEN# +0.03802803"},
        {"Smithsonian Astrophysical Observation", "SAO 65424"},
        {"Wilson Evans Batten Catalogue", "WEB 13734"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98870158),
        dec: Angle.Degrees(+37.96726388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1671"},
        {"Hipparcos Number", "HIP 1686"},
        {"Fundamental Katalog 5th Edition", "FK5 1009"},
        {"Geneva Identification System", "GEN# +1.00001671"},
        {"Smithsonian Astrophysical Observation", "SAO 53828"},
        {"Wilson Evans Batten Catalogue", "WEB 308"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.28010785),
        dec: Angle.Degrees(+37.96869954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191397"},
        {"Hipparcos Number", "HIP 99194"},
        {"Geneva Identification System", "GEN# +1.00191397"},
        {"Smithsonian Astrophysical Observation", "SAO 69481"},
        {"Wilson Evans Batten Catalogue", "WEB 17662"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.06217834),
        dec: Angle.Degrees(+37.96953622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11591"},
        {"Smithsonian Astrophysical Observation", "SAO 55599"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.34449517),
        dec: Angle.Degrees(+37.97207926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25411"},
        {"Hipparcos Number", "HIP 18963"},
        {"Smithsonian Astrophysical Observation", "SAO 56934"},
    },
    visualMagnitude: 7.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.95170183),
        dec: Angle.Degrees(+37.97218430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62910",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8697 A"},
        {"Henry Draper", "HD 112083"},
        {"Hipparcos Number", "HIP 62910"},
        {"Geneva Identification System", "GEN# +1.00112083"},
        {"Smithsonian Astrophysical Observation", "SAO 63238"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.39693394),
        dec: Angle.Degrees(+37.97246038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141526"},
        {"Hipparcos Number", "HIP 77402"},
        {"Smithsonian Astrophysical Observation", "SAO 64918"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.02673630),
        dec: Angle.Degrees(+37.97292162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107553"},
        {"Smithsonian Astrophysical Observation", "SAO 71700"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.74934386),
        dec: Angle.Degrees(+37.97352765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132028"},
        {"Hipparcos Number", "HIP 73048"},
        {"Fundamental Katalog 5th Edition", "FK5 5322"},
        {"Geneva Identification System", "GEN# +1.00132028"},
        {"Smithsonian Astrophysical Observation", "SAO 64406"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.93435959),
        dec: Angle.Degrees(+37.97418789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209025"},
        {"Hipparcos Number", "HIP 108564"},
        {"Smithsonian Astrophysical Observation", "SAO 71915"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.87640152),
        dec: Angle.Degrees(+37.97531845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8697 B"},
        {"Henry Draper", "HD 112083B"},
        {"Hipparcos Number", "HIP 62909"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.39554836),
        dec: Angle.Degrees(+37.97630962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37266"},
        {"Hipparcos Number", "HIP 26585"},
        {"Celescope Catalog", "CEL 879"},
        {"Geneva Identification System", "GEN# +1.00037266"},
        {"Smithsonian Astrophysical Observation", "SAO 58287"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.76781060),
        dec: Angle.Degrees(+37.97664625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17412",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2715 A"},
        {"Henry Draper", "HD 23091"},
        {"Hipparcos Number", "HIP 17412"},
        {"Smithsonian Astrophysical Observation", "SAO 56665"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.96772235),
        dec: Angle.Degrees(+37.97825851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8988 AB"},
        {"Hipparcos Number", "HIP 66664"},
        {"Smithsonian Astrophysical Observation", "SAO 63674"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.99616627),
        dec: Angle.Degrees(+37.97859148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115750"},
        {"Smithsonian Astrophysical Observation", "SAO 73261"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.76505838),
        dec: Angle.Degrees(+37.97986124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89668"},
        {"Fundamental Katalog 5th Edition", "FK5 5610"},
        {"Geneva Identification System", "GEN# +0.03703070"},
        {"Smithsonian Astrophysical Observation", "SAO 66837"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.47338942),
        dec: Angle.Degrees(+37.98000123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194356"},
        {"Hipparcos Number", "HIP 100577"},
        {"Geneva Identification System", "GEN# +1.00194356"},
        {"Smithsonian Astrophysical Observation", "SAO 69953"},
        {"Wilson Evans Batten Catalogue", "WEB 18172"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.94620935),
        dec: Angle.Degrees(+37.98274035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4709 AB"},
        {"Henry Draper", "HD 41637"},
        {"Hipparcos Number", "HIP 29090"},
        {"Smithsonian Astrophysical Observation", "SAO 58776"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.04873024),
        dec: Angle.Degrees(+37.98274780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175425"},
        {"Hipparcos Number", "HIP 92720"},
        {"Geneva Identification System", "GEN# +1.00175425"},
        {"Smithsonian Astrophysical Observation", "SAO 67535"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.40894882),
        dec: Angle.Degrees(+37.98545004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180429"},
        {"Hipparcos Number", "HIP 94577"},
        {"Smithsonian Astrophysical Observation", "SAO 68032"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70898245),
        dec: Angle.Degrees(+37.98791843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51272"},
        {"Hipparcos Number", "HIP 33553"},
        {"Smithsonian Astrophysical Observation", "SAO 59649"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.59523570),
        dec: Angle.Degrees(+37.98804622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37339"},
        {"Hipparcos Number", "HIP 26632"},
        {"Celescope Catalog", "CEL 888"},
        {"Geneva Identification System", "GEN# +1.00037339"},
        {"Smithsonian Astrophysical Observation", "SAO 58296"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.90334409),
        dec: Angle.Degrees(+37.98888886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198784"},
        {"Hipparcos Number", "HIP 102953"},
        {"Celescope Catalog", "CEL 5186"},
        {"Geneva Identification System", "GEN# +1.00198784"},
        {"Smithsonian Astrophysical Observation", "SAO 70590"},
        {"Wilson Evans Batten Catalogue", "WEB 18680"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.87892081),
        dec: Angle.Degrees(+37.98950185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275494"},
        {"Hipparcos Number", "HIP 16309"},
        {"Geneva Identification System", "GEN# +1.00275494"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55590670),
        dec: Angle.Degrees(+37.98952835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172649"},
        {"Hipparcos Number", "HIP 91507"},
        {"Geneva Identification System", "GEN# +1.00172649"},
        {"Smithsonian Astrophysical Observation", "SAO 67221"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.92556120),
        dec: Angle.Degrees(+37.99296638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149659"},
        {"Hipparcos Number", "HIP 81160"},
        {"Geneva Identification System", "GEN# +1.00149659"},
        {"Smithsonian Astrophysical Observation", "SAO 65401"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.64554811),
        dec: Angle.Degrees(+37.99565113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176799"},
        {"Hipparcos Number", "HIP 93311"},
        {"Smithsonian Astrophysical Observation", "SAO 67691"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.09225701),
        dec: Angle.Degrees(+37.99578201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27214"},
        {"Hipparcos Number", "HIP 20176"},
        {"Geneva Identification System", "GEN# +1.00027214"},
        {"Smithsonian Astrophysical Observation", "SAO 57151"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.87601020),
        dec: Angle.Degrees(+37.99840602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18065"},
        {"Hipparcos Number", "HIP 13614"},
        {"Fundamental Katalog 5th Edition", "FK5 4264"},
        {"Geneva Identification System", "GEN# +1.00018065"},
        {"Smithsonian Astrophysical Observation", "SAO 55997"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.85381907),
        dec: Angle.Degrees(+37.99938931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104783"},
        {"Hipparcos Number", "HIP 58839"},
        {"Geneva Identification System", "GEN# +1.00104783"},
        {"Smithsonian Astrophysical Observation", "SAO 62821"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02188461),
        dec: Angle.Degrees(+37.99983549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124086"},
        {"Hipparcos Number", "HIP 69238"},
        {"Geneva Identification System", "GEN# +1.00124086"},
        {"Smithsonian Astrophysical Observation", "SAO 63969"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.62085896),
        dec: Angle.Degrees(+38.00374560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52906"},
        {"Geneva Identification System", "GEN# +0.03802182"},
    },
    visualMagnitude: 11.23,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.30381889),
        dec: Angle.Degrees(+38.00412077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1647 A"},
        {"Henry Draper", "HD 12744"},
        {"Hipparcos Number", "HIP 9781"},
        {"Smithsonian Astrophysical Observation", "SAO 55258"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.44401246),
        dec: Angle.Degrees(+38.00626901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102760"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31201912),
        dec: Angle.Degrees(+38.00637223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63857"},
        {"Geneva Identification System", "GEN# +0.03802400"},
        {"Smithsonian Astrophysical Observation", "SAO 63337"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.30942581),
        dec: Angle.Degrees(+38.00659102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186636"},
        {"Hipparcos Number", "HIP 97100"},
        {"Smithsonian Astrophysical Observation", "SAO 68771"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.00426766),
        dec: Angle.Degrees(+38.00692345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95466"},
        {"Hipparcos Number", "HIP 53897"},
        {"Smithsonian Astrophysical Observation", "SAO 62359"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.42212085),
        dec: Angle.Degrees(+38.00832184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75731"},
        {"Smithsonian Astrophysical Observation", "SAO 64716"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.06692468),
        dec: Angle.Degrees(+38.01059454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159993"},
        {"Hipparcos Number", "HIP 86112"},
        {"Smithsonian Astrophysical Observation", "SAO 66170"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.97363425),
        dec: Angle.Degrees(+38.01230174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128197"},
        {"Hipparcos Number", "HIP 71268"},
        {"Geneva Identification System", "GEN# +1.00128197"},
        {"Renson", "Renson 36400"},
        {"Smithsonian Astrophysical Observation", "SAO 64226"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.62815071),
        dec: Angle.Degrees(+38.01249976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22114"},
        {"Hipparcos Number", "HIP 16724"},
        {"Geneva Identification System", "GEN# +1.00022114"},
        {"Renson", "Renson 5550"},
        {"Smithsonian Astrophysical Observation", "SAO 56561"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.79947166),
        dec: Angle.Degrees(+38.01519735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218355"},
        {"Hipparcos Number", "HIP 114136"},
        {"Geneva Identification System", "GEN# +1.00218355"},
        {"Smithsonian Astrophysical Observation", "SAO 73004"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.73077369),
        dec: Angle.Degrees(+38.01632753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72184"},
        {"Hipparcos Number", "HIP 41935"},
        {"Fundamental Katalog 5th Edition", "FK5 320"},
        {"Geneva Identification System", "GEN# +1.00072184"},
        {"Smithsonian Astrophysical Observation", "SAO 60890"},
        {"Wilson Evans Batten Catalogue", "WEB 8068"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22939892),
        dec: Angle.Degrees(+38.01678677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206750"},
        {"Hipparcos Number", "HIP 107242"},
        {"Smithsonian Astrophysical Observation", "SAO 71642"},
        {"Wilson Evans Batten Catalogue", "WEB 19370"},
    },
    visualMagnitude: 7.67,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.81805788),
        dec: Angle.Degrees(+38.01750944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3520"},
        {"Hipparcos Number", "HIP 3021"},
        {"Geneva Identification System", "GEN# +1.00003520"},
        {"Smithsonian Astrophysical Observation", "SAO 54047"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.61848662),
        dec: Angle.Degrees(+38.01922291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36721"},
        {"Hipparcos Number", "HIP 26261"},
        {"Celescope Catalog", "CEL 805"},
        {"Smithsonian Astrophysical Observation", "SAO 58211"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.89126714),
        dec: Angle.Degrees(+38.01974236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184217"},
        {"Hipparcos Number", "HIP 96051"},
        {"Smithsonian Astrophysical Observation", "SAO 68450"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.94097884),
        dec: Angle.Degrees(+38.01999953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7621 A"},
        {"Henry Draper", "HD 87127"},
        {"Hipparcos Number", "HIP 49308"},
        {"Geneva Identification System", "GEN# +1.00087127A"},
        {"Smithsonian Astrophysical Observation", "SAO 61837"},
        {"Wilson Evans Batten Catalogue", "WEB 9120"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.97319913),
        dec: Angle.Degrees(+38.02073887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63280"},
        {"Hipparcos Number", "HIP 38215"},
        {"Smithsonian Astrophysical Observation", "SAO 60367"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.43415705),
        dec: Angle.Degrees(+38.02211986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9938"},
        {"Hipparcos Number", "HIP 7594"},
        {"Geneva Identification System", "GEN# +1.00009938"},
        {"Smithsonian Astrophysical Observation", "SAO 54847"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.46061907),
        dec: Angle.Degrees(+38.02230271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107485"},
        {"Hipparcos Number", "HIP 60231"},
        {"Geneva Identification System", "GEN# +1.00107485"},
        {"Smithsonian Astrophysical Observation", "SAO 62961"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.26707377),
        dec: Angle.Degrees(+38.02382626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11224"},
        {"Hipparcos Number", "HIP 8618"},
        {"Smithsonian Astrophysical Observation", "SAO 55030"},
        {"New General Catalogue", "NGC 752 1531"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.78871641),
        dec: Angle.Degrees(+38.02395641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16843 A"},
        {"Henry Draper", "HD 221776"},
        {"Hipparcos Number", "HIP 116365"},
        {"Geneva Identification System", "GEN# +1.00221776"},
        {"Smithsonian Astrophysical Observation", "SAO 73351"},
        {"Wilson Evans Batten Catalogue", "WEB 20560"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.69472703),
        dec: Angle.Degrees(+38.02397291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87621"},
        {"Hipparcos Number", "HIP 49548"},
        {"Geneva Identification System", "GEN# +1.00087621"},
        {"Smithsonian Astrophysical Observation", "SAO 61868"},
        {"Wilson Evans Batten Catalogue", "WEB 9139"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.75208848),
        dec: Angle.Degrees(+38.02419147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61747"},
        {"Smithsonian Astrophysical Observation", "SAO 63119"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82011442),
        dec: Angle.Degrees(+38.02427074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41457"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.83184096),
        dec: Angle.Degrees(+38.02593100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32066"},
        {"Smithsonian Astrophysical Observation", "SAO 59373"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.49541993),
        dec: Angle.Degrees(+38.02664499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111168"},
        {"Renson", "Renson 59210"},
        {"Smithsonian Astrophysical Observation", "SAO 72426"},
    },
    visualMagnitude: 10.17,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82070340),
        dec: Angle.Degrees(+38.02735173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139690"},
        {"Hipparcos Number", "HIP 76558"},
        {"Smithsonian Astrophysical Observation", "SAO 64820"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.53822559),
        dec: Angle.Degrees(+38.02803787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56766"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.57858913),
        dec: Angle.Degrees(+38.02849485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6612"},
        {"Hipparcos Number", "HIP 5270"},
        {"Smithsonian Astrophysical Observation", "SAO 54438"},
        {"Wilson Evans Batten Catalogue", "WEB 1117"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.84413843),
        dec: Angle.Degrees(+38.02890985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57648"},
        {"Hipparcos Number", "HIP 35878"},
        {"Geneva Identification System", "GEN# +1.00057648"},
        {"Smithsonian Astrophysical Observation", "SAO 60042"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.95667384),
        dec: Angle.Degrees(+38.03118220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59671"},
        {"Smithsonian Astrophysical Observation", "SAO 62908"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.55462671),
        dec: Angle.Degrees(+38.03265753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32658"},
        {"Smithsonian Astrophysical Observation", "SAO 59502"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.18293365),
        dec: Angle.Degrees(+38.03282834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193237"},
        {"Hipparcos Number", "HIP 100044"},
        {"Celescope Catalog", "CEL 5017"},
        {"Geneva Identification System", "GEN# +1.00193237"},
        {"Smithsonian Astrophysical Observation", "SAO 69773"},
        {"Wilson Evans Batten Catalogue", "WEB 18014"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.44668519),
        dec: Angle.Degrees(+38.03294710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79865"},
        {"Smithsonian Astrophysical Observation", "SAO 65214"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.53478936),
        dec: Angle.Degrees(+38.03367491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8100"},
        {"Hipparcos Number", "HIP 6309"},
        {"Cincinnati Publication", "Ci 18 172"},
        {"Geneva Identification System", "GEN# +1.00008100"},
        {"Smithsonian Astrophysical Observation", "SAO 54620"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.26571679),
        dec: Angle.Degrees(+38.03416304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157948"},
        {"Henry Draper 2", "HD 157948A"},
        {"Hipparcos Number", "HIP 85209"},
        {"Smithsonian Astrophysical Observation", "SAO 66024"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17697180),
        dec: Angle.Degrees(+38.03673172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58052"},
        {"Geneva Identification System", "GEN# +0.03802289"},
        {"Smithsonian Astrophysical Observation", "SAO 62750"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.60241197),
        dec: Angle.Degrees(+38.03764559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201154"},
        {"Hipparcos Number", "HIP 104190"},
        {"Geneva Identification System", "GEN# +1.00201154"},
        {"Smithsonian Astrophysical Observation", "SAO 70918"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.64320377),
        dec: Angle.Degrees(+38.03945241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25998"},
        {"Hipparcos Number", "HIP 19335"},
        {"Fundamental Katalog 5th Edition", "FK5 2297"},
        {"Geneva Identification System", "GEN# +1.00025998"},
        {"Smithsonian Astrophysical Observation", "SAO 57006"},
        {"Wilson Evans Batten Catalogue", "WEB 3714"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.15206221),
        dec: Angle.Degrees(+38.04022796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74700"},
        {"Hipparcos Number", "HIP 43113"},
        {"Smithsonian Astrophysical Observation", "SAO 61046"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70488268),
        dec: Angle.Degrees(+38.04225243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4869"},
        {"Hipparcos Number", "HIP 3981"},
        {"Smithsonian Astrophysical Observation", "SAO 54198"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.80102170),
        dec: Angle.Degrees(+38.04231291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21292"},
        {"Hipparcos Number", "HIP 16102"},
        {"Geneva Identification System", "GEN# +1.00021292"},
        {"Smithsonian Astrophysical Observation", "SAO 56462"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.85875112),
        dec: Angle.Degrees(+38.04255043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104887",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14787 AB"},
        {"Henry Draper", "HD 202444"},
        {"Hipparcos Number", "HIP 104887"},
        {"Celescope Catalog", "CEL 5280"},
        {"Cincinnati Publication", "Ci 20 1271"},
        {"Geneva Identification System", "GEN# +1.00202444J"},
        {"Smithsonian Astrophysical Observation", "SAO 71121"},
        {"Wilson Evans Batten Catalogue", "WEB 19071"},
    },
    visualMagnitude: 3.74,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.69727757),
        dec: Angle.Degrees(+38.04432043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 410.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92619"},
        {"Hipparcos Number", "HIP 52374"},
        {"Geneva Identification System", "GEN# +1.00092619"},
        {"Smithsonian Astrophysical Observation", "SAO 62208"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.57763034),
        dec: Angle.Degrees(+38.04471992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4004 A"},
        {"Henry Draper", "HD 35313"},
        {"Hipparcos Number", "HIP 25370"},
        {"Smithsonian Astrophysical Observation", "SAO 58006"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.41040720),
        dec: Angle.Degrees(+38.04476012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92850"},
        {"Smithsonian Astrophysical Observation", "SAO 67576"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81193619),
        dec: Angle.Degrees(+38.04580273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113168"},
        {"Hipparcos Number", "HIP 63551"},
        {"Geneva Identification System", "GEN# +1.00113168"},
        {"Smithsonian Astrophysical Observation", "SAO 63305"},
        {"Wilson Evans Batten Catalogue", "WEB 11245"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.33423484),
        dec: Angle.Degrees(+38.04820955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44834"},
        {"Hipparcos Number", "HIP 30589"},
        {"Geneva Identification System", "GEN# +1.00044834"},
        {"Smithsonian Astrophysical Observation", "SAO 59068"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.42952193),
        dec: Angle.Degrees(+38.05027771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51440"},
        {"Hipparcos Number", "HIP 33614"},
        {"Fundamental Katalog 5th Edition", "FK5 2538"},
        {"Geneva Identification System", "GEN# +1.00051440"},
        {"Smithsonian Astrophysical Observation", "SAO 59658"},
        {"Wilson Evans Batten Catalogue", "WEB 6758"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.76199195),
        dec: Angle.Degrees(+38.05261545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45229"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.26086806),
        dec: Angle.Degrees(+38.05291661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38738"},
        {"Smithsonian Astrophysical Observation", "SAO 60454"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.96097763),
        dec: Angle.Degrees(+38.05343063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25354"},
        {"Hipparcos Number", "HIP 18912"},
        {"Geneva Identification System", "GEN# +1.00025354"},
        {"Renson", "Renson 6460"},
        {"Smithsonian Astrophysical Observation", "SAO 56925"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.79526547),
        dec: Angle.Degrees(+38.05480931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43457"},
        {"Smithsonian Astrophysical Observation", "SAO 61082"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.76738250),
        dec: Angle.Degrees(+38.06082250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10093 AB"},
        {"Henry Draper", "HD 149083"},
        {"Hipparcos Number", "HIP 80885"},
        {"Smithsonian Astrophysical Observation", "SAO 65355"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.73214057),
        dec: Angle.Degrees(+38.06449778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46493"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.23769861),
        dec: Angle.Degrees(+38.06597169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17044"},
        {"Hipparcos Number", "HIP 12861"},
        {"Smithsonian Astrophysical Observation", "SAO 55842"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.33164167),
        dec: Angle.Degrees(+38.06873222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109305"},
        {"Hipparcos Number", "HIP 61283"},
        {"Fundamental Katalog 5th Edition", "FK5 5107"},
        {"Geneva Identification System", "GEN# +1.00109305"},
        {"Smithsonian Astrophysical Observation", "SAO 63066"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37447640),
        dec: Angle.Degrees(+38.06907047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19664"},
        {"Hipparcos Number", "HIP 14824"},
        {"Smithsonian Astrophysical Observation", "SAO 56225"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.84878025),
        dec: Angle.Degrees(+38.06943386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224101"},
        {"Hipparcos Number", "HIP 117916"},
        {"Smithsonian Astrophysical Observation", "SAO 73608"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.76539286),
        dec: Angle.Degrees(+38.06983639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161163"},
        {"Hipparcos Number", "HIP 86642"},
        {"Geneva Identification System", "GEN# +1.00161163"},
        {"Smithsonian Astrophysical Observation", "SAO 66273"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55556057),
        dec: Angle.Degrees(+38.07041019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146135"},
        {"Hipparcos Number", "HIP 79480"},
        {"Geneva Identification System", "GEN# +1.00146135"},
        {"Smithsonian Astrophysical Observation", "SAO 65153"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30391106),
        dec: Angle.Degrees(+38.07235477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2995 AB"},
        {"Henry Draper", "HD 25893"},
        {"Hipparcos Number", "HIP 19255"},
        {"Geneva Identification System", "GEN# +1.00025893"},
        {"Smithsonian Astrophysical Observation", "SAO 56982"},
        {"Wilson Evans Batten Catalogue", "WEB 3695"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.89260309),
        dec: Angle.Degrees(+38.07508767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5188 A"},
        {"Henry Draper", "HD 46296"},
        {"Hipparcos Number", "HIP 31340"},
        {"Geneva Identification System", "GEN# +1.00046296"},
        {"Smithsonian Astrophysical Observation", "SAO 59230"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.58069943),
        dec: Angle.Degrees(+38.07602228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81204"},
        {"Smithsonian Astrophysical Observation", "SAO 65407"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.79011425),
        dec: Angle.Degrees(+38.07758148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18950"},
        {"Hipparcos Number", "HIP 14287"},
        {"Smithsonian Astrophysical Observation", "SAO 56124"},
        {"Wilson Evans Batten Catalogue", "WEB 2797"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.03918193),
        dec: Angle.Degrees(+38.07951302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42306"},
        {"Smithsonian Astrophysical Observation", "SAO 60926"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.38280519),
        dec: Angle.Degrees(+38.08011133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36260"},
        {"Hipparcos Number", "HIP 25942"},
        {"Geneva Identification System", "GEN# +1.00036260"},
        {"Smithsonian Astrophysical Observation", "SAO 58151"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.04355515),
        dec: Angle.Degrees(+38.08026505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85902"},
        {"Hipparcos Number", "HIP 48701"},
        {"Geneva Identification System", "GEN# +1.00085902"},
        {"Smithsonian Astrophysical Observation", "SAO 61763"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.98696971),
        dec: Angle.Degrees(+38.08170530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41542"},
        {"Hipparcos Number", "HIP 29033"},
        {"Smithsonian Astrophysical Observation", "SAO 58763"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.88140510),
        dec: Angle.Degrees(+38.08228594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1757 AB"},
        {"Henry Draper", "HD 14106"},
        {"Hipparcos Number", "HIP 10711"},
        {"Smithsonian Astrophysical Observation", "SAO 55435"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.48374074),
        dec: Angle.Degrees(+38.08231265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164094"},
        {"Hipparcos Number", "HIP 87941"},
        {"Smithsonian Astrophysical Observation", "SAO 66517"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.47546198),
        dec: Angle.Degrees(+38.08408101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38376"},
        {"Hipparcos Number", "HIP 27300"},
        {"Smithsonian Astrophysical Observation", "SAO 58424"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76287559),
        dec: Angle.Degrees(+38.08467956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108517"},
        {"Smithsonian Astrophysical Observation", "SAO 71908"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.76159612),
        dec: Angle.Degrees(+38.08613564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73888"},
        {"Hipparcos Number", "HIP 42696"},
        {"Smithsonian Astrophysical Observation", "SAO 60990"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.52901117),
        dec: Angle.Degrees(+38.08617882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77930"},
        {"Hipparcos Number", "HIP 44707"},
        {"Geneva Identification System", "GEN# +1.00077930"},
        {"Smithsonian Astrophysical Observation", "SAO 61255"},
        {"Wilson Evans Batten Catalogue", "WEB 8550"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63967237),
        dec: Angle.Degrees(+38.08866676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16350"},
        {"Hipparcos Number", "HIP 12305"},
        {"Geneva Identification System", "GEN# +1.00016350"},
        {"Smithsonian Astrophysical Observation", "SAO 55735"},
        {"Wilson Evans Batten Catalogue", "WEB 2523"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.61643512),
        dec: Angle.Degrees(+38.08916502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80023"},
        {"Hipparcos Number", "HIP 45669"},
        {"Smithsonian Astrophysical Observation", "SAO 61388"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.63776236),
        dec: Angle.Degrees(+38.09037265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149504"},
        {"Hipparcos Number", "HIP 81085"},
        {"Geneva Identification System", "GEN# +1.00149504"},
        {"Smithsonian Astrophysical Observation", "SAO 65390"},
        {"Wilson Evans Batten Catalogue", "WEB 13711"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.42436173),
        dec: Angle.Degrees(+38.09086128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55651"},
        {"Smithsonian Astrophysical Observation", "SAO 62534"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.02781647),
        dec: Angle.Degrees(+38.09118956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76027"},
        {"Smithsonian Astrophysical Observation", "SAO 64757"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92727321),
        dec: Angle.Degrees(+38.09499142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279993"},
        {"Hipparcos Number", "HIP 21565"},
        {"Smithsonian Astrophysical Observation", "SAO 57343"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43610220),
        dec: Angle.Degrees(+38.09690636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196643"},
        {"Hipparcos Number", "HIP 101754"},
        {"Geneva Identification System", "GEN# +1.00196643"},
        {"Smithsonian Astrophysical Observation", "SAO 70286"},
        {"Wilson Evans Batten Catalogue", "WEB 18380"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.34445620),
        dec: Angle.Degrees(+38.09843426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44455"},
        {"Smithsonian Astrophysical Observation", "SAO 61222"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.85072919),
        dec: Angle.Degrees(+38.09845556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64273"},
        {"Hipparcos Number", "HIP 38636"},
        {"Geneva Identification System", "GEN# +1.00064273"},
        {"Smithsonian Astrophysical Observation", "SAO 60429"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.66827658),
        dec: Angle.Degrees(+38.09943770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36953"},
        {"Smithsonian Astrophysical Observation", "SAO 60207"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.95954584),
        dec: Angle.Degrees(+38.09965441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44693"},
        {"Hipparcos Number", "HIP 30512"},
        {"Smithsonian Astrophysical Observation", "SAO 59052"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.20302422),
        dec: Angle.Degrees(+38.10017459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41556"},
        {"Smithsonian Astrophysical Observation", "SAO 60837"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09676301),
        dec: Angle.Degrees(+38.10020743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98423"},
        {"Hipparcos Number", "HIP 55316"},
        {"Geneva Identification System", "GEN# +1.00098423"},
        {"Smithsonian Astrophysical Observation", "SAO 62496"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92310346),
        dec: Angle.Degrees(+38.10104273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111590"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.09578176),
        dec: Angle.Degrees(+38.10511227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13198 AB"},
        {"Henry Draper", "HD 189432"},
        {"Hipparcos Number", "HIP 98320"},
        {"Celescope Catalog", "CEL 4893"},
        {"Geneva Identification System", "GEN# +1.00189432J"},
        {"Smithsonian Astrophysical Observation", "SAO 69193"},
        {"Wilson Evans Batten Catalogue", "WEB 17344"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.64314255),
        dec: Angle.Degrees(+38.10569103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177781"},
        {"Hipparcos Number", "HIP 93665"},
        {"Geneva Identification System", "GEN# +1.00177781"},
        {"Smithsonian Astrophysical Observation", "SAO 67774"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.09907205),
        dec: Angle.Degrees(+38.10753611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55200"},
        {"Hipparcos Number", "HIP 34930"},
        {"Smithsonian Astrophysical Observation", "SAO 59895"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.41910044),
        dec: Angle.Degrees(+38.10841219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33656"},
        {"Hipparcos Number", "HIP 24352"},
        {"Geneva Identification System", "GEN# +1.00033656"},
        {"Smithsonian Astrophysical Observation", "SAO 57759"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38457739),
        dec: Angle.Degrees(+38.10968996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129170"},
        {"Hipparcos Number", "HIP 71698"},
        {"Geneva Identification System", "GEN# +1.00129170"},
        {"Smithsonian Astrophysical Observation", "SAO 64261"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.99784377),
        dec: Angle.Degrees(+38.11045160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90752"},
        {"Smithsonian Astrophysical Observation", "SAO 67062"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74767761),
        dec: Angle.Degrees(+38.11099735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182634"},
        {"Hipparcos Number", "HIP 95353"},
        {"Smithsonian Astrophysical Observation", "SAO 68254"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.98934095),
        dec: Angle.Degrees(+38.11439126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189301"},
        {"Hipparcos Number", "HIP 98242"},
        {"Geneva Identification System", "GEN# +1.00189301"},
        {"Smithsonian Astrophysical Observation", "SAO 69166"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.46523013),
        dec: Angle.Degrees(+38.12113876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93014"},
        {"Hipparcos Number", "HIP 52579"},
        {"Geneva Identification System", "GEN# +1.00093014"},
        {"Smithsonian Astrophysical Observation", "SAO 62227"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.26865326),
        dec: Angle.Degrees(+38.12138490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9369"},
        {"Hipparcos Number", "HIP 7204"},
        {"Geneva Identification System", "GEN# +1.00009369"},
        {"Smithsonian Astrophysical Observation", "SAO 54773"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21035510),
        dec: Angle.Degrees(+38.12148002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56366"},
        {"Geneva Identification System", "GEN# +0.03802256"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.31449609),
        dec: Angle.Degrees(+38.12167777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1919 A"},
        {"Henry Draper", "HD 15625"},
        {"Hipparcos Number", "HIP 11765"},
        {"Smithsonian Astrophysical Observation", "SAO 55630"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.95898879),
        dec: Angle.Degrees(+38.12190770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40101",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6639 AB"},
        {"Hipparcos Number", "HIP 40101"},
        {"Smithsonian Astrophysical Observation", "SAO 60627"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.87690324),
        dec: Angle.Degrees(+38.12390579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5450",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 948 AB"},
        {"Henry Draper", "HD 6859"},
        {"Hipparcos Number", "HIP 5450"},
        {"Smithsonian Astrophysical Observation", "SAO 54473"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.43870313),
        dec: Angle.Degrees(+38.12455956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13919 A"},
        {"Henry Draper", "HD 195406"},
        {"Hipparcos Number", "HIP 101109"},
        {"Celescope Catalog", "CEL 5082"},
        {"Geneva Identification System", "GEN# +1.00195406A"},
        {"Smithsonian Astrophysical Observation", "SAO 70107"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.42990932),
        dec: Angle.Degrees(+38.12541496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50947"},
        {"Geneva Identification System", "GEN# +0.03802134"},
        {"Smithsonian Astrophysical Observation", "SAO 62020"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.06762120),
        dec: Angle.Degrees(+38.12575769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213786"},
        {"Hipparcos Number", "HIP 111335"},
        {"Smithsonian Astrophysical Observation", "SAO 72458"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34398523),
        dec: Angle.Degrees(+38.12681091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194153"},
        {"Hipparcos Number", "HIP 100484"},
        {"Geneva Identification System", "GEN# +1.00194153"},
        {"Smithsonian Astrophysical Observation", "SAO 69920"},
        {"Wilson Evans Batten Catalogue", "WEB 18147"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.64821653),
        dec: Angle.Degrees(+38.12937943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13919 B"},
        {"Hipparcos Number", "HIP 101110"},
        {"Geneva Identification System", "GEN# +1.00195406B"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.43306837),
        dec: Angle.Degrees(+38.12948657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29056"},
        {"Smithsonian Astrophysical Observation", "SAO 58765"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.94111975),
        dec: Angle.Degrees(+38.12972025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191396"},
        {"Hipparcos Number", "HIP 99202"},
        {"Celescope Catalog", "CEL 4943"},
        {"Geneva Identification System", "GEN# +1.00191396"},
        {"Smithsonian Astrophysical Observation", "SAO 69486"},
        {"Wilson Evans Batten Catalogue", "WEB 17666"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.07976037),
        dec: Angle.Degrees(+38.13068729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18552"},
        {"Hipparcos Number", "HIP 13997"},
        {"Geneva Identification System", "GEN# +1.00018552"},
        {"Smithsonian Astrophysical Observation", "SAO 56067"},
        {"Wilson Evans Batten Catalogue", "WEB 2760"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.04950134),
        dec: Angle.Degrees(+38.13180775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109315"},
        {"Smithsonian Astrophysical Observation", "SAO 72059"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.19241639),
        dec: Angle.Degrees(+38.13228872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29260"},
        {"Smithsonian Astrophysical Observation", "SAO 58812"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.54115454),
        dec: Angle.Degrees(+38.13299060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180809"},
        {"Hipparcos Number", "HIP 94713"},
        {"Fundamental Katalog 5th Edition", "FK5 724"},
        {"Geneva Identification System", "GEN# +1.00180809"},
        {"Smithsonian Astrophysical Observation", "SAO 68065"},
        {"Wilson Evans Batten Catalogue", "WEB 16518"},
    },
    visualMagnitude: 4.35,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.09206426),
        dec: Angle.Degrees(+38.13372778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191424"},
        {"Hipparcos Number", "HIP 99196"},
        {"Smithsonian Astrophysical Observation", "SAO 69487"},
        {"Wilson Evans Batten Catalogue", "WEB 17668"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.09133554),
        dec: Angle.Degrees(+38.13887949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217228"},
        {"Hipparcos Number", "HIP 113472"},
        {"Smithsonian Astrophysical Observation", "SAO 72898"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.69904378),
        dec: Angle.Degrees(+38.14090897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61580"},
        {"Hipparcos Number", "HIP 37485"},
        {"Smithsonian Astrophysical Observation", "SAO 60274"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.42701548),
        dec: Angle.Degrees(+38.14118933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34493"},
        {"Hipparcos Number", "HIP 24837"},
        {"Geneva Identification System", "GEN# +1.00034493"},
        {"Smithsonian Astrophysical Observation", "SAO 57892"},
        {"Wilson Evans Batten Catalogue", "WEB 4812"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.87718615),
        dec: Angle.Degrees(+38.14235656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33982"},
        {"Geneva Identification System", "GEN# +0.03801670"},
        {"Smithsonian Astrophysical Observation", "SAO 59716"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.77029834),
        dec: Angle.Degrees(+38.14286624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13984"},
        {"Hipparcos Number", "HIP 10643"},
        {"Smithsonian Astrophysical Observation", "SAO 55418"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.24618896),
        dec: Angle.Degrees(+38.14650237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199851"},
        {"Hipparcos Number", "HIP 103540"},
        {"Geneva Identification System", "GEN# +1.00199851"},
        {"Smithsonian Astrophysical Observation", "SAO 70746"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.66305493),
        dec: Angle.Degrees(+38.14981706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82440"},
        {"Geneva Identification System", "GEN# +0.03802847"},
        {"Smithsonian Astrophysical Observation", "SAO 65602"},
        {"Wilson Evans Batten Catalogue", "WEB 13918"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.72643688),
        dec: Angle.Degrees(+38.15021313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129354"},
        {"Hipparcos Number", "HIP 71777"},
        {"Geneva Identification System", "GEN# +1.00129354"},
        {"Smithsonian Astrophysical Observation", "SAO 64272"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.24260488),
        dec: Angle.Degrees(+38.15028414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200616"},
        {"Hipparcos Number", "HIP 103915"},
        {"Celescope Catalog", "CEL 5237"},
        {"Geneva Identification System", "GEN# +1.00200616"},
        {"Smithsonian Astrophysical Observation", "SAO 70837"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.82283469),
        dec: Angle.Degrees(+38.15270594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95654"},
        {"Smithsonian Astrophysical Observation", "SAO 68340"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.85218751),
        dec: Angle.Degrees(+38.15539886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73615"},
        {"Hipparcos Number", "HIP 42580"},
        {"Smithsonian Astrophysical Observation", "SAO 60974"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18205115),
        dec: Angle.Degrees(+38.15916089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115968"},
        {"Hipparcos Number", "HIP 65049"},
        {"Cincinnati Publication", "Ci 20 772"},
        {"Cincinnati Publication 2", "Ci 18 1720"},
        {"Geneva Identification System", "GEN# +1.00115968"},
        {"Smithsonian Astrophysical Observation", "SAO 63483"},
        {"Wilson Evans Batten Catalogue", "WEB 11492"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.00757439),
        dec: Angle.Degrees(+38.15939294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -405.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39440"},
        {"Smithsonian Astrophysical Observation", "SAO 60533"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.93337067),
        dec: Angle.Degrees(+38.15954916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193515"},
        {"Hipparcos Number", "HIP 100172"},
        {"Smithsonian Astrophysical Observation", "SAO 69825"},
        {"Wilson Evans Batten Catalogue", "WEB 18045"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.78548490),
        dec: Angle.Degrees(+38.16122130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275490"},
        {"Hipparcos Number", "HIP 16562"},
        {"Geneva Identification System", "GEN# +1.00275490"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30604426),
        dec: Angle.Degrees(+38.16149616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9682 AB"},
        {"Henry Draper", "HD 138439"},
        {"Hipparcos Number", "HIP 75949"},
        {"Smithsonian Astrophysical Observation", "SAO 64747"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.68727965),
        dec: Angle.Degrees(+38.16353776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108955"},
        {"Hipparcos Number", "HIP 61073"},
        {"Geneva Identification System", "GEN# +1.00108955"},
        {"Smithsonian Astrophysical Observation", "SAO 63038"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.75577642),
        dec: Angle.Degrees(+38.16461461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111602"},
        {"Renson", "Renson 59370"},
        {"Smithsonian Astrophysical Observation", "SAO 72529"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15161947),
        dec: Angle.Degrees(+38.16748287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59106"},
        {"Hipparcos Number", "HIP 36463"},
        {"Geneva Identification System", "GEN# +1.00059106"},
        {"Smithsonian Astrophysical Observation", "SAO 60131"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.54300391),
        dec: Angle.Degrees(+38.16961503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36714"},
        {"Smithsonian Astrophysical Observation", "SAO 60166"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.27146245),
        dec: Angle.Degrees(+38.17148332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73247"},
        {"Hipparcos Number", "HIP 42405"},
        {"Smithsonian Astrophysical Observation", "SAO 60944"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.69733194),
        dec: Angle.Degrees(+38.17194558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155039"},
        {"Hipparcos Number", "HIP 83791"},
        {"Smithsonian Astrophysical Observation", "SAO 65803"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87501341),
        dec: Angle.Degrees(+38.17237746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 34 AB"},
        {"Hipparcos Number", "HIP 385"},
        {"Geneva Identification System", "GEN# +0.03704930"},
        {"Smithsonian Astrophysical Observation", "SAO 53619"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.19515384),
        dec: Angle.Degrees(+38.17382611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50556"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.90862647),
        dec: Angle.Degrees(+38.17755343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52895"},
        {"Smithsonian Astrophysical Observation", "SAO 62266"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.27902993),
        dec: Angle.Degrees(+38.17763324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8090 A"},
        {"Hipparcos Number", "HIP 54812"},
    },
    visualMagnitude: 9.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13, 15.5300),
        dec: Angle.DegreesMinutesSeconds((int)+38, (int)10, 40.900)
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
    primaryId: "HIP 99060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227708"},
        {"Hipparcos Number", "HIP 99060"},
        {"Smithsonian Astrophysical Observation", "SAO 69427"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.67048127),
        dec: Angle.Degrees(+38.18231266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220117"},
        {"Hipparcos Number", "HIP 115280"},
        {"Fundamental Katalog 5th Edition", "FK5 1610"},
        {"Geneva Identification System", "GEN# +1.00220117"},
        {"Smithsonian Astrophysical Observation", "SAO 73190"},
        {"Wilson Evans Batten Catalogue", "WEB 20421"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.22153629),
        dec: Angle.Degrees(+38.18247497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107218"},
        {"Smithsonian Astrophysical Observation", "SAO 71637"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.73791868),
        dec: Angle.Degrees(+38.18463094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98353"},
        {"Hipparcos Number", "HIP 55266"},
        {"Fundamental Katalog 5th Edition", "FK5 1293"},
        {"Geneva Identification System", "GEN# +1.00098353"},
        {"Smithsonian Astrophysical Observation", "SAO 62491"},
        {"Wilson Evans Batten Catalogue", "WEB 9954"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.78309755),
        dec: Angle.Degrees(+38.18572227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1712"},
        {"Hipparcos Number", "HIP 1715"},
        {"Smithsonian Astrophysical Observation", "SAO 53835"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.39614307),
        dec: Angle.Degrees(+38.18715974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137368"},
        {"Hipparcos Number", "HIP 75390"},
        {"Smithsonian Astrophysical Observation", "SAO 64685"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.07748382),
        dec: Angle.Degrees(+38.18795238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7307 AB"},
        {"Henry Draper", "HD 80441"},
        {"Hipparcos Number", "HIP 45858"},
        {"Geneva Identification System", "GEN# +1.00080441"},
        {"Smithsonian Astrophysical Observation", "SAO 61411"},
        {"Wilson Evans Batten Catalogue", "WEB 8694"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.24751937),
        dec: Angle.Degrees(+38.18831027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37614"},
        {"Henry Draper 2", "HD 37615"},
        {"Hipparcos Number", "HIP 26803"},
        {"Celescope Catalog", "CEL 917"},
        {"Geneva Identification System", "GEN# +1.00037614J"},
        {"Smithsonian Astrophysical Observation", "SAO 58334"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.37956108),
        dec: Angle.Degrees(+38.18832715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82970"},
        {"Smithsonian Astrophysical Observation", "SAO 65672"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.32634649),
        dec: Angle.Degrees(+38.19050489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8909"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.67302978),
        dec: Angle.Degrees(+38.19171948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54615"},
        {"Hipparcos Number", "HIP 34695"},
        {"Smithsonian Astrophysical Observation", "SAO 59853"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.79508955),
        dec: Angle.Degrees(+38.19494924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12577"},
        {"Smithsonian Astrophysical Observation", "SAO 55790"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.42932794),
        dec: Angle.Degrees(+38.19570326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8906"},
        {"Geneva Identification System", "GEN# +2.07520400"},
        {"Smithsonian Astrophysical Observation", "SAO 55076"},
        {"New General Catalogue", "NGC 752 2054"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.66519103),
        dec: Angle.Degrees(+38.19600093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150491"},
        {"Hipparcos Number", "HIP 81591"},
        {"Smithsonian Astrophysical Observation", "SAO 65469"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.94081941),
        dec: Angle.Degrees(+38.19678923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37766"},
        {"Hipparcos Number", "HIP 26910"},
        {"Smithsonian Astrophysical Observation", "SAO 58355"},
        {"Wilson Evans Batten Catalogue", "WEB 5306"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.69772963),
        dec: Angle.Degrees(+38.19801511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227454"},
        {"Hipparcos Number", "HIP 98818"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.02348775),
        dec: Angle.Degrees(+38.19903101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65903"},
        {"Smithsonian Astrophysical Observation", "SAO 63573"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.64036302),
        dec: Angle.Degrees(+38.20184053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 572"},
        {"Smithsonian Astrophysical Observation", "SAO 53648"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.73390197),
        dec: Angle.Degrees(+38.20259978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4702"},
        {"Hipparcos Number", "HIP 3859"},
        {"Geneva Identification System", "GEN# +1.00004702"},
        {"Smithsonian Astrophysical Observation", "SAO 54169"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.39023026),
        dec: Angle.Degrees(+38.20496538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113082"},
        {"Smithsonian Astrophysical Observation", "SAO 72826"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52425852),
        dec: Angle.Degrees(+38.20879759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64387"},
        {"Hipparcos Number", "HIP 38693"},
        {"Smithsonian Astrophysical Observation", "SAO 60446"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.82758700),
        dec: Angle.Degrees(+38.21008276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114994"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.35664291),
        dec: Angle.Degrees(+38.21114528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64533"},
        {"Geneva Identification System", "GEN# +0.03802413"},
        {"Smithsonian Astrophysical Observation", "SAO 63417"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.41175290),
        dec: Angle.Degrees(+38.21325219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83520"},
        {"Smithsonian Astrophysical Observation", "SAO 65772"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.03738207),
        dec: Angle.Degrees(+38.21397545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16576 AB"},
        {"Henry Draper", "HD 218917"},
        {"Hipparcos Number", "HIP 114504"},
        {"Smithsonian Astrophysical Observation", "SAO 73068"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.85762599),
        dec: Angle.Degrees(+38.21980876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15348"},
        {"Hipparcos Number", "HIP 11583"},
        {"Smithsonian Astrophysical Observation", "SAO 55597"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.32235786),
        dec: Angle.Degrees(+38.22522435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33816"},
        {"Hipparcos Number", "HIP 24437"},
        {"Geneva Identification System", "GEN# +1.00033816"},
        {"Smithsonian Astrophysical Observation", "SAO 57782"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.63879123),
        dec: Angle.Degrees(+38.22557244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 271 A"},
        {"Henry Draper", "HD 1562"},
        {"Hipparcos Number", "HIP 1598"},
        {"Geneva Identification System", "GEN# +1.00001562"},
        {"Smithsonian Astrophysical Observation", "SAO 53817"},
        {"Wilson Evans Batten Catalogue", "WEB 290"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.00213822),
        dec: Angle.Degrees(+38.22806865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15025"},
        {"Hipparcos Number", "HIP 11366"},
        {"Geneva Identification System", "GEN# +1.00015025"},
        {"Smithsonian Astrophysical Observation", "SAO 55554"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.60068470),
        dec: Angle.Degrees(+38.23088551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162209"},
        {"Hipparcos Number", "HIP 87135"},
        {"Geneva Identification System", "GEN# +1.00162209"},
        {"Smithsonian Astrophysical Observation", "SAO 66346"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.05433312),
        dec: Angle.Degrees(+38.23277366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54047"},
        {"Smithsonian Astrophysical Observation", "SAO 62379"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.89717804),
        dec: Angle.Degrees(+38.23385889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43558"},
        {"Hipparcos Number", "HIP 29977"},
        {"Smithsonian Astrophysical Observation", "SAO 58968"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66339012),
        dec: Angle.Degrees(+38.23562601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208328"},
        {"Hipparcos Number", "HIP 108154"},
        {"Smithsonian Astrophysical Observation", "SAO 71826"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68115348),
        dec: Angle.Degrees(+38.23564053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193183"},
        {"Hipparcos Number", "HIP 100009"},
        {"Geneva Identification System", "GEN# +1.00193183"},
        {"Smithsonian Astrophysical Observation", "SAO 69763"},
        {"Wilson Evans Batten Catalogue", "WEB 18002"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.34485015),
        dec: Angle.Degrees(+38.23568691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105269",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14859 AB"},
        {"Henry Draper", "HD 203156"},
        {"Hipparcos Number", "HIP 105269"},
        {"Celescope Catalog", "CEL 5293"},
        {"Geneva Identification System", "GEN# +1.00203156"},
        {"Smithsonian Astrophysical Observation", "SAO 71203"},
        {"Wilson Evans Batten Catalogue", "WEB 19119"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.84241818),
        dec: Angle.Degrees(+38.23748156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197328"},
        {"Hipparcos Number", "HIP 102118"},
        {"Smithsonian Astrophysical Observation", "SAO 70386"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42324331),
        dec: Angle.Degrees(+38.23941437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77126"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.22455022),
        dec: Angle.Degrees(+38.24108181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8046 A"},
        {"Henry Draper", "HD 95934"},
        {"Hipparcos Number", "HIP 54136"},
        {"Fundamental Katalog 5th Edition", "FK5 2882"},
        {"Geneva Identification System", "GEN# +1.00095934"},
        {"Renson", "Renson 27625"},
        {"Smithsonian Astrophysical Observation", "SAO 62387"},
        {"Wilson Evans Batten Catalogue", "WEB 9783"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.13033202),
        dec: Angle.Degrees(+38.24136150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21118"},
        {"Hipparcos Number", "HIP 15985"},
        {"Geneva Identification System", "GEN# +1.00021118"},
        {"Smithsonian Astrophysical Observation", "SAO 56441"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.46994069),
        dec: Angle.Degrees(+38.24294267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218354"},
        {"Hipparcos Number", "HIP 114133"},
        {"Geneva Identification System", "GEN# +1.00218354"},
        {"Smithsonian Astrophysical Observation", "SAO 73003"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.72347778),
        dec: Angle.Degrees(+38.24348866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225083"},
        {"Hipparcos Number", "HIP 264"},
        {"Smithsonian Astrophysical Observation", "SAO 53605"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.83207925),
        dec: Angle.Degrees(+38.24401553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27427"},
        {"Hipparcos Number", "HIP 20326"},
        {"Geneva Identification System", "GEN# +1.00027427"},
        {"Smithsonian Astrophysical Observation", "SAO 57180"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.31938662),
        dec: Angle.Degrees(+38.24432340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15909 A"},
        {"Henry Draper", "HD 212524"},
        {"Hipparcos Number", "HIP 110583"},
        {"Smithsonian Astrophysical Observation", "SAO 72302"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.05145151),
        dec: Angle.Degrees(+38.24636750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59331"},
        {"Smithsonian Astrophysical Observation", "SAO 62873"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.56656698),
        dec: Angle.Degrees(+38.24648067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121367"},
        {"Hipparcos Number", "HIP 67884"},
        {"Geneva Identification System", "GEN# +1.00121367"},
        {"Smithsonian Astrophysical Observation", "SAO 63819"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.55085118),
        dec: Angle.Degrees(+38.24656320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43560"},
        {"Smithsonian Astrophysical Observation", "SAO 61095"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.07068185),
        dec: Angle.Degrees(+38.24782062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3265"},
        {"Hipparcos Number", "HIP 2851"},
        {"Smithsonian Astrophysical Observation", "SAO 54015"},
        {"Wilson Evans Batten Catalogue", "WEB 513"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.02766976),
        dec: Angle.Degrees(+38.25199607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119562"},
        {"Hipparcos Number", "HIP 66945"},
        {"Geneva Identification System", "GEN# +1.00119562"},
        {"Smithsonian Astrophysical Observation", "SAO 63706"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.81096412),
        dec: Angle.Degrees(+38.25216842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88378"},
        {"Smithsonian Astrophysical Observation", "SAO 66582"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.71034919),
        dec: Angle.Degrees(+38.25219676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14685"},
        {"Hipparcos Number", "HIP 11135"},
        {"Fundamental Katalog 5th Edition", "FK5 4223"},
        {"Smithsonian Astrophysical Observation", "SAO 55503"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.82216997),
        dec: Angle.Degrees(+38.25274544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275122"},
        {"Hipparcos Number", "HIP 15366"},
        {"Cincinnati Publication", "Ci 20 221"},
        {"Geneva Identification System", "GEN# +1.00275122"},
        {"Wilson Evans Batten Catalogue", "WEB 2955"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.52978849),
        dec: Angle.Degrees(+38.25345803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 443.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -570.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29923"},
        {"Hipparcos Number", "HIP 22055"},
        {"Geneva Identification System", "GEN# +1.00029923"},
        {"Smithsonian Astrophysical Observation", "SAO 57401"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.14722014),
        dec: Angle.Degrees(+38.25497826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193814"},
        {"Hipparcos Number", "HIP 100328"},
        {"Celescope Catalog", "CEL 5034"},
        {"Geneva Identification System", "GEN# +1.00193814"},
        {"Smithsonian Astrophysical Observation", "SAO 69867"},
        {"Wilson Evans Batten Catalogue", "WEB 18096"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.20141022),
        dec: Angle.Degrees(+38.25644213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60847"},
        {"Hipparcos Number", "HIP 37153"},
        {"Smithsonian Astrophysical Observation", "SAO 60234"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.53069407),
        dec: Angle.Degrees(+38.25888060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76493"},
        {"Hipparcos Number", "HIP 44014"},
        {"Geneva Identification System", "GEN# +1.00076493"},
        {"Smithsonian Astrophysical Observation", "SAO 61155"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.44440638),
        dec: Angle.Degrees(+38.25908954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109954"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.03282384),
        dec: Angle.Degrees(+38.26077285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35410"},
        {"Smithsonian Astrophysical Observation", "SAO 59971"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.66744232),
        dec: Angle.Degrees(+38.26129575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70779"},
        {"Smithsonian Astrophysical Observation", "SAO 64164"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12940407),
        dec: Angle.Degrees(+38.26150788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135402"},
        {"Hipparcos Number", "HIP 74514"},
        {"Fundamental Katalog 5th Edition", "FK5 3202"},
        {"Geneva Identification System", "GEN# +1.00135402"},
        {"Smithsonian Astrophysical Observation", "SAO 64572"},
        {"Wilson Evans Batten Catalogue", "WEB 12713"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.39827998),
        dec: Angle.Degrees(+38.26481607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10251"},
        {"Hipparcos Number", "HIP 7854"},
        {"Geneva Identification System", "GEN# +1.00010251"},
        {"Smithsonian Astrophysical Observation", "SAO 54899"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.25186663),
        dec: Angle.Degrees(+38.26589429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176318"},
        {"Hipparcos Number", "HIP 93104"},
        {"Celescope Catalog", "CEL 4673"},
        {"Geneva Identification System", "GEN# +1.00176318"},
        {"Smithsonian Astrophysical Observation", "SAO 67642"},
        {"Wilson Evans Batten Catalogue", "WEB 16127"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50792438),
        dec: Angle.Degrees(+38.26618277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47093"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.95888124),
        dec: Angle.Degrees(+38.26689116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8223"},
        {"Smithsonian Astrophysical Observation", "SAO 54956"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.47026666),
        dec: Angle.Degrees(+38.26950023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9304"},
        {"Hipparcos Number", "HIP 7157"},
        {"Geneva Identification System", "GEN# +1.00009304"},
        {"Smithsonian Astrophysical Observation", "SAO 54765"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.06481202),
        dec: Angle.Degrees(+38.27194062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62628"},
        {"Hipparcos Number", "HIP 37945"},
        {"Smithsonian Astrophysical Observation", "SAO 60327"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.65816764),
        dec: Angle.Degrees(+38.27215043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147113"},
        {"Hipparcos Number", "HIP 79879"},
        {"Smithsonian Astrophysical Observation", "SAO 65216"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.56747903),
        dec: Angle.Degrees(+38.27527893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96106"},
        {"Hipparcos Number", "HIP 54210"},
        {"Smithsonian Astrophysical Observation", "SAO 62398"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.38394707),
        dec: Angle.Degrees(+38.27585177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114905"},
        {"Hipparcos Number", "HIP 64484"},
        {"Geneva Identification System", "GEN# +1.00114905"},
        {"Smithsonian Astrophysical Observation", "SAO 63408"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.26457518),
        dec: Angle.Degrees(+38.27738359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70836"},
        {"Smithsonian Astrophysical Observation", "SAO 64169"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.28808290),
        dec: Angle.Degrees(+38.27826670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77967"},
        {"Hipparcos Number", "HIP 44728"},
        {"Geneva Identification System", "GEN# +1.00077967"},
        {"Smithsonian Astrophysical Observation", "SAO 61261"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.71266330),
        dec: Angle.Degrees(+38.27847590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112733"},
        {"Hipparcos Number", "HIP 63317"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.63361514),
        dec: Angle.Degrees(+38.27887228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3804"},
        {"Hipparcos Number", "HIP 3228"},
        {"Smithsonian Astrophysical Observation", "SAO 54077"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.27244133),
        dec: Angle.Degrees(+38.27913274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100146",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13686 AB"},
        {"Henry Draper", "HD 193443"},
        {"Hipparcos Number", "HIP 100146"},
        {"Geneva Identification System", "GEN# +1.00193443"},
        {"Smithsonian Astrophysical Observation", "SAO 69815"},
        {"Wilson Evans Batten Catalogue", "WEB 18038"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.71546321),
        dec: Angle.Degrees(+38.27959672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112733B"},
        {"Hipparcos Number", "HIP 63322"},
        {"Smithsonian Astrophysical Observation", "SAO 63275"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.64623286),
        dec: Angle.Degrees(+38.28022826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29645"},
        {"Hipparcos Number", "HIP 21847"},
        {"Fundamental Katalog 5th Edition", "FK5 2348"},
        {"Geneva Identification System", "GEN# +1.00029645"},
        {"Smithsonian Astrophysical Observation", "SAO 57377"},
        {"Wilson Evans Batten Catalogue", "WEB 4203"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.45865407),
        dec: Angle.Degrees(+38.28042013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140229"},
        {"Hipparcos Number", "HIP 76814"},
        {"Fundamental Katalog 5th Edition", "FK5 5388"},
        {"Geneva Identification System", "GEN# +1.00140229"},
        {"Smithsonian Astrophysical Observation", "SAO 64846"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.25355709),
        dec: Angle.Degrees(+38.28140696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164504"},
        {"Hipparcos Number", "HIP 88115"},
        {"Smithsonian Astrophysical Observation", "SAO 66544"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.94217457),
        dec: Angle.Degrees(+38.28182098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206774"},
        {"Hipparcos Number", "HIP 107253"},
        {"Geneva Identification System", "GEN# +1.00206774J"},
        {"Smithsonian Astrophysical Observation", "SAO 71643"},
        {"Wilson Evans Batten Catalogue", "WEB 19371"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.85677886),
        dec: Angle.Degrees(+38.28360055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8921"},
        {"Smithsonian Astrophysical Observation", "SAO 55080"},
        {"New General Catalogue", "NGC 752 400"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.72099078),
        dec: Angle.Degrees(+38.28542308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39845"},
        {"Hipparcos Number", "HIP 28152"},
        {"Smithsonian Astrophysical Observation", "SAO 58593"},
        {"Wilson Evans Batten Catalogue", "WEB 5506"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.23082894),
        dec: Angle.Degrees(+38.28733473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86120"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.00485723),
        dec: Angle.Degrees(+38.28853534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71867"},
        {"Hipparcos Number", "HIP 41771"},
        {"Smithsonian Astrophysical Observation", "SAO 60862"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76867768),
        dec: Angle.Degrees(+38.29158164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62573"},
        {"Smithsonian Astrophysical Observation", "SAO 63209"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.31278996),
        dec: Angle.Degrees(+38.29259921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87666"},
        {"Hipparcos Number", "HIP 49586"},
        {"Cincinnati Publication", "Ci 18 1202"},
        {"Smithsonian Astrophysical Observation", "SAO 61873"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.84052755),
        dec: Angle.Degrees(+38.29338740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155394"},
        {"Hipparcos Number", "HIP 83950"},
        {"Fundamental Katalog 5th Edition", "FK5 5513"},
        {"Geneva Identification System", "GEN# +1.00155394"},
        {"Smithsonian Astrophysical Observation", "SAO 65838"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.39868249),
        dec: Angle.Degrees(+38.29340502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4690"},
        {"Smithsonian Astrophysical Observation", "SAO 54333"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.07211632),
        dec: Angle.Degrees(+38.29470868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41905"},
        {"Hipparcos Number", "HIP 29204"},
        {"Smithsonian Astrophysical Observation", "SAO 58801"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39303007),
        dec: Angle.Degrees(+38.29588409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187278"},
        {"Hipparcos Number", "HIP 97388"},
        {"Smithsonian Astrophysical Observation", "SAO 68865"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.90921596),
        dec: Angle.Degrees(+38.29767686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217864"},
        {"Hipparcos Number", "HIP 113847"},
        {"Smithsonian Astrophysical Observation", "SAO 72962"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.82897511),
        dec: Angle.Degrees(+38.29863929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112627"},
    },
    visualMagnitude: 10.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.16508790),
        dec: Angle.Degrees(+38.29970494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74631",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9553 AB"},
        {"Henry Draper", "HD 135631"},
        {"Hipparcos Number", "HIP 74631"},
        {"Geneva Identification System", "GEN# +1.00135631"},
        {"Smithsonian Astrophysical Observation", "SAO 64585"},
        {"Wilson Evans Batten Catalogue", "WEB 12735"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.73582248),
        dec: Angle.Degrees(+38.30100357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169532"},
        {"Hipparcos Number", "HIP 90117"},
        {"Smithsonian Astrophysical Observation", "SAO 66928"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.84771346),
        dec: Angle.Degrees(+38.30237971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64568"},
    },
    visualMagnitude: 11.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.51620823),
        dec: Angle.Degrees(+38.30272771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11152"},
        {"Hipparcos Number", "HIP 8567"},
        {"Geneva Identification System", "GEN# +1.00011152"},
        {"Smithsonian Astrophysical Observation", "SAO 55016"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62415994),
        dec: Angle.Degrees(+38.30330785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224721"},
        {"Hipparcos Number", "HIP 19"},
        {"Geneva Identification System", "GEN# +1.00224721"},
        {"Smithsonian Astrophysical Observation", "SAO 73668"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.05331696),
        dec: Angle.Degrees(+38.30408636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206807"},
        {"Hipparcos Number", "HIP 107268"},
        {"Geneva Identification System", "GEN# +1.00206807"},
        {"Smithsonian Astrophysical Observation", "SAO 71646"},
        {"Wilson Evans Batten Catalogue", "WEB 19373"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.90262373),
        dec: Angle.Degrees(+38.30462747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112628"},
        {"Smithsonian Astrophysical Observation", "SAO 72742"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.16562206),
        dec: Angle.Degrees(+38.30478846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66284"},
        {"Geneva Identification System", "GEN# +0.03902659"},
        {"Smithsonian Astrophysical Observation", "SAO 63625"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.78088298),
        dec: Angle.Degrees(+38.30608915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221442"},
        {"Hipparcos Number", "HIP 116144"},
        {"Smithsonian Astrophysical Observation", "SAO 73319"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98941259),
        dec: Angle.Degrees(+38.30659968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71075",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Seginus"},
        {"Aitken", "ADS 9300 A"},
        {"Henry Draper", "HD 127762"},
        {"Hipparcos Number", "HIP 71075"},
        {"Fundamental Katalog 5th Edition", "FK5 535"},
        {"Geneva Identification System", "GEN# +1.00127762"},
        {"Renson", "Renson 36300"},
        {"Smithsonian Astrophysical Observation", "SAO 64203"},
        {"Wilson Evans Batten Catalogue", "WEB 12291"},
    },
    visualMagnitude: 3.04,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.01982421),
        dec: Angle.Degrees(+38.30788348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84832"},
        {"Smithsonian Astrophysical Observation", "SAO 65957"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.07666697),
        dec: Angle.Degrees(+38.30790638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84382"},
        {"Smithsonian Astrophysical Observation", "SAO 65893"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.77150283),
        dec: Angle.Degrees(+38.31127114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25771"},
        {"Smithsonian Astrophysical Observation", "SAO 58117"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.54841698),
        dec: Angle.Degrees(+38.31130210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50163"},
        {"Hipparcos Number", "HIP 33105"},
        {"Smithsonian Astrophysical Observation", "SAO 59585"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.42748538),
        dec: Angle.Degrees(+38.31243792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24516"},
        {"Hipparcos Number", "HIP 18358"},
        {"Geneva Identification System", "GEN# +1.00024516"},
        {"Smithsonian Astrophysical Observation", "SAO 56813"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.87683214),
        dec: Angle.Degrees(+38.31409833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63121",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8706 B"},
        {"Henry Draper", "HD 112412"},
        {"Hipparcos Number", "HIP 63121"},
        {"Geneva Identification System", "GEN# +1.00112412"},
        {"Renson", "Renson 32640"},
        {"Smithsonian Astrophysical Observation", "SAO 63256"},
        {"Wilson Evans Batten Catalogue", "WEB 11191"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.00251587),
        dec: Angle.Degrees(+38.31469771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201274"},
        {"Hipparcos Number", "HIP 104233"},
        {"Smithsonian Astrophysical Observation", "SAO 70935"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.78165251),
        dec: Angle.Degrees(+38.31495937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92007",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11656 A"},
        {"Henry Draper", "HD 173741"},
        {"Hipparcos Number", "HIP 92007"},
        {"Smithsonian Astrophysical Observation", "SAO 67330"},
        {"Wilson Evans Batten Catalogue", "WEB 15851"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.29516551),
        dec: Angle.Degrees(+38.31516909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280146"},
        {"Hipparcos Number", "HIP 22423"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38677281),
        dec: Angle.Degrees(+38.31821545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63125",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cor Caroli"},
        {"Aitken", "ADS 8706 A"},
        {"Henry Draper", "HD 112413"},
        {"Hipparcos Number", "HIP 63125"},
        {"Fundamental Katalog 5th Edition", "FK5 485"},
        {"Geneva Identification System", "GEN# +1.00112413"},
        {"Renson", "Renson 32650"},
        {"Smithsonian Astrophysical Observation", "SAO 63257"},
        {"Wilson Evans Batten Catalogue", "WEB 11192"},
    },
    visualMagnitude: 2.89,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.00767051),
        dec: Angle.Degrees(+38.31824617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108076"},
        {"Hipparcos Number", "HIP 60551"},
        {"Cincinnati Publication", "Ci 18 1564"},
        {"Cincinnati Publication 2", "Ci 20 704"},
        {"Geneva Identification System", "GEN# +1.00108076"},
        {"Smithsonian Astrophysical Observation", "SAO 62989"},
        {"Wilson Evans Batten Catalogue", "WEB 10766"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.19302339),
        dec: Angle.Degrees(+38.31858319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -587.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17584"},
        {"Hipparcos Number", "HIP 13254"},
        {"Fundamental Katalog 5th Edition", "FK5 2194"},
        {"Geneva Identification System", "GEN# +1.00017584"},
        {"Smithsonian Astrophysical Observation", "SAO 55928"},
        {"Wilson Evans Batten Catalogue", "WEB 2658"},
    },
    visualMagnitude: 4.22,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.64547584),
        dec: Angle.Degrees(+38.31890838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36148"},
        {"Hipparcos Number", "HIP 25877"},
        {"Smithsonian Astrophysical Observation", "SAO 58139"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.86135624),
        dec: Angle.Degrees(+38.31969459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92114"},
        {"Smithsonian Astrophysical Observation", "SAO 67368"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.60076835),
        dec: Angle.Degrees(+38.32162244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97083",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12851 AB"},
        {"Henry Draper", "HD 186605"},
        {"Hipparcos Number", "HIP 97083"},
        {"Celescope Catalog", "CEL 4831"},
        {"Geneva Identification System", "GEN# +1.00186605J"},
        {"Smithsonian Astrophysical Observation", "SAO 68767"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.94621896),
        dec: Angle.Degrees(+38.32235431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141265"},
        {"Hipparcos Number", "HIP 77284"},
        {"Wilson Evans Batten Catalogue", "WEB 13095"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.68211996),
        dec: Angle.Degrees(+38.32243224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161619"},
        {"Hipparcos Number", "HIP 86863"},
        {"Smithsonian Astrophysical Observation", "SAO 66301"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.21629161),
        dec: Angle.Degrees(+38.32354696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2611"},
        {"Hipparcos Number", "HIP 2336"},
        {"Geneva Identification System", "GEN# +1.00002611"},
        {"Smithsonian Astrophysical Observation", "SAO 53939"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46541710),
        dec: Angle.Degrees(+38.32435177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13318 A"},
        {"Henry Draper", "HD 190466"},
        {"Hipparcos Number", "HIP 98773"},
        {"Geneva Identification System", "GEN# +1.00190466"},
        {"Smithsonian Astrophysical Observation", "SAO 69335"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91461871),
        dec: Angle.Degrees(+38.32733066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102079"},
        {"Hipparcos Number", "HIP 57314"},
        {"Smithsonian Astrophysical Observation", "SAO 62689"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.27268134),
        dec: Angle.Degrees(+38.32826897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92916"},
    },
    visualMagnitude: 12.07,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.96664789),
        dec: Angle.Degrees(+38.32836400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196642"},
        {"Hipparcos Number", "HIP 101756"},
        {"Geneva Identification System", "GEN# +1.00196642"},
        {"Smithsonian Astrophysical Observation", "SAO 70288"},
        {"Wilson Evans Batten Catalogue", "WEB 18379"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.34822512),
        dec: Angle.Degrees(+38.32877208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190628"},
        {"Hipparcos Number", "HIP 98848"},
        {"Smithsonian Astrophysical Observation", "SAO 69361"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.10508230),
        dec: Angle.Degrees(+38.33242695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111165"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.81537067),
        dec: Angle.Degrees(+38.33246170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69554"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.56243521),
        dec: Angle.Degrees(+38.33285719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6278"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13726009),
        dec: Angle.Degrees(+38.33314951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94162"},
        {"Hipparcos Number", "HIP 53166"},
        {"Geneva Identification System", "GEN# +1.00094162"},
        {"Smithsonian Astrophysical Observation", "SAO 62290"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.14643735),
        dec: Angle.Degrees(+38.33451860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31992"},
        {"Hipparcos Number", "HIP 23407"},
        {"Smithsonian Astrophysical Observation", "SAO 57581"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.45339905),
        dec: Angle.Degrees(+38.33471394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45405"},
        {"Smithsonian Astrophysical Observation", "SAO 61356"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78856886),
        dec: Angle.Degrees(+38.33490121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13318 B"},
        {"Henry Draper", "HD 227402"},
        {"Hipparcos Number", "HIP 98770"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91105307),
        dec: Angle.Degrees(+38.33490934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13711 A"},
        {"Henry Draper", "HD 193611"},
        {"Hipparcos Number", "HIP 100227"},
        {"Smithsonian Astrophysical Observation", "SAO 69836"},
        {"Wilson Evans Batten Catalogue", "WEB 18059"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.91146012),
        dec: Angle.Degrees(+38.33590266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2200 AB"},
        {"Henry Draper", "HD 17904"},
        {"Hipparcos Number", "HIP 13490"},
        {"Geneva Identification System", "GEN# +1.00017904"},
        {"Smithsonian Astrophysical Observation", "SAO 55975"},
        {"Wilson Evans Batten Catalogue", "WEB 2693"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.42740906),
        dec: Angle.Degrees(+38.33767914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79469"},
        {"Smithsonian Astrophysical Observation", "SAO 65151"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.26704850),
        dec: Angle.Degrees(+38.34109347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36337"},
        {"Smithsonian Astrophysical Observation", "SAO 60105"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.18551443),
        dec: Angle.Degrees(+38.34187176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36949"},
        {"Hipparcos Number", "HIP 26364"},
        {"Fundamental Katalog 5th Edition", "FK5 4508"},
        {"Smithsonian Astrophysical Observation", "SAO 58249"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22189825),
        dec: Angle.Degrees(+38.34232276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193634"},
        {"Hipparcos Number", "HIP 100240"},
        {"Geneva Identification System", "GEN# +1.00193634"},
        {"Smithsonian Astrophysical Observation", "SAO 69844"},
        {"Wilson Evans Batten Catalogue", "WEB 18067"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.95493401),
        dec: Angle.Degrees(+38.34273381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58625"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.33854906),
        dec: Angle.Degrees(+38.34309193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208097"},
        {"Hipparcos Number", "HIP 108014"},
        {"Smithsonian Astrophysical Observation", "SAO 71797"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.24508690),
        dec: Angle.Degrees(+38.34344296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80844"},
        {"Hipparcos Number", "HIP 46033"},
        {"Smithsonian Astrophysical Observation", "SAO 61439"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.82986835),
        dec: Angle.Degrees(+38.34439006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61294"},
        {"Hipparcos Number", "HIP 37369"},
        {"Geneva Identification System", "GEN# +1.00061294"},
        {"Smithsonian Astrophysical Observation", "SAO 60257"},
        {"Wilson Evans Batten Catalogue", "WEB 7396"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.06134304),
        dec: Angle.Degrees(+38.34456671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10138 D"},
        {"Henry Draper", "HD 150391"},
        {"Hipparcos Number", "HIP 81529"},
        {"Geneva Identification System", "GEN# +1.00150391"},
        {"Renson", "Renson 42543"},
        {"Smithsonian Astrophysical Observation", "SAO 65461"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.78733468),
        dec: Angle.Degrees(+38.34499243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11317 A"},
        {"Henry Draper", "HD 169617"},
        {"Hipparcos Number", "HIP 90140"},
        {"Smithsonian Astrophysical Observation", "SAO 66933"},
        {"Wilson Evans Batten Catalogue", "WEB 15412"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.93361502),
        dec: Angle.Degrees(+38.34507437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75052"},
        {"Hipparcos Number", "HIP 43279"},
        {"Smithsonian Astrophysical Observation", "SAO 61060"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.25146356),
        dec: Angle.Degrees(+38.34524757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78698"},
        {"Hipparcos Number", "HIP 45067"},
        {"Geneva Identification System", "GEN# +1.00078698"},
        {"Smithsonian Astrophysical Observation", "SAO 61304"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.69028732),
        dec: Angle.Degrees(+38.34554963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19567"},
        {"Hipparcos Number", "HIP 14713"},
        {"Smithsonian Astrophysical Observation", "SAO 56213"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.52624658),
        dec: Angle.Degrees(+38.34555041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69896"},
        {"Hipparcos Number", "HIP 40883"},
        {"Smithsonian Astrophysical Observation", "SAO 60740"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.14199997),
        dec: Angle.Degrees(+38.34571119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30098"},
        {"Geneva Identification System", "GEN# +0.03801456"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.01571057),
        dec: Angle.Degrees(+38.34603246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80838",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ogma"},
        {"Henry Draper", "HD 149026"},
        {"Hipparcos Number", "HIP 80838"},
        {"Geneva Identification System", "GEN# +1.00149026"},
        {"Smithsonian Astrophysical Observation", "SAO 65349"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.62365236),
        dec: Angle.Degrees(+38.34717994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207622"},
        {"Hipparcos Number", "HIP 107722"},
        {"Smithsonian Astrophysical Observation", "SAO 71736"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.32259047),
        dec: Angle.Degrees(+38.34773220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108174"},
        {"Hipparcos Number", "HIP 60619"},
        {"Geneva Identification System", "GEN# +1.00108174"},
        {"Smithsonian Astrophysical Observation", "SAO 62998"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.36102331),
        dec: Angle.Degrees(+38.34789464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92122",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11680 AB"},
        {"Henry Draper", "HD 173950"},
        {"Hipparcos Number", "HIP 92122"},
        {"Geneva Identification System", "GEN# +1.00173950J"},
        {"Smithsonian Astrophysical Observation", "SAO 67373"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.64423687),
        dec: Angle.Degrees(+38.35111906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47600"},
        {"Smithsonian Astrophysical Observation", "SAO 61641"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.58365615),
        dec: Angle.Degrees(+38.35168109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74440"},
        {"Hipparcos Number", "HIP 42971"},
        {"Smithsonian Astrophysical Observation", "SAO 61028"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37509582),
        dec: Angle.Degrees(+38.35257862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192163"},
        {"Hipparcos Number", "HIP 99546"},
        {"Celescope Catalog", "CEL 4971"},
        {"Geneva Identification System", "GEN# +1.00192163"},
        {"Smithsonian Astrophysical Observation", "SAO 69592"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02728233),
        dec: Angle.Degrees(+38.35495648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90306"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.38327301),
        dec: Angle.Degrees(+38.35532929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -743.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153722"},
        {"Hipparcos Number", "HIP 83140"},
        {"Smithsonian Astrophysical Observation", "SAO 65703"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.85505718),
        dec: Angle.Degrees(+38.35620960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2818"},
        {"Smithsonian Astrophysical Observation", "SAO 54012"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96461001),
        dec: Angle.Degrees(+38.35738851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85862"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18609884),
        dec: Angle.Degrees(+38.35768419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110987"},
        {"Hipparcos Number", "HIP 62273"},
        {"Smithsonian Astrophysical Observation", "SAO 63181"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.42140555),
        dec: Angle.Degrees(+38.35835359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116406"},
        {"Hipparcos Number", "HIP 65295"},
        {"Geneva Identification System", "GEN# +1.00116406"},
        {"Smithsonian Astrophysical Observation", "SAO 63506"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.73618436),
        dec: Angle.Degrees(+38.35990484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75720",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9663 A"},
        {"Hipparcos Number", "HIP 75720"},
        {"Smithsonian Astrophysical Observation", "SAO 64715"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.04115177),
        dec: Angle.Degrees(+38.36051791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56246"},
        {"Hipparcos Number", "HIP 35338"},
        {"Smithsonian Astrophysical Observation", "SAO 59958"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.50268023),
        dec: Angle.Degrees(+38.36421393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172741"},
        {"Hipparcos Number", "HIP 91552"},
        {"Geneva Identification System", "GEN# +1.00172741"},
        {"Renson", "Renson 48430"},
        {"Smithsonian Astrophysical Observation", "SAO 67233"},
        {"Wilson Evans Batten Catalogue", "WEB 15742"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.05077302),
        dec: Angle.Degrees(+38.36717856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111539"},
        {"Hipparcos Number", "HIP 62603"},
        {"Geneva Identification System", "GEN# +1.00111539"},
        {"Smithsonian Astrophysical Observation", "SAO 63214"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.42648386),
        dec: Angle.Degrees(+38.36804388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67689"},
        {"Hipparcos Number", "HIP 40037"},
        {"Smithsonian Astrophysical Observation", "SAO 60619"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.67039552),
        dec: Angle.Degrees(+38.36872612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62762"},
        {"Geneva Identification System", "GEN# +0.03902571"},
        {"Smithsonian Astrophysical Observation", "SAO 63224"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.91851344),
        dec: Angle.Degrees(+38.36872626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115954"},
        {"Hipparcos Number", "HIP 65042"},
        {"Geneva Identification System", "GEN# +1.00115954"},
        {"Smithsonian Astrophysical Observation", "SAO 63482"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.98601204),
        dec: Angle.Degrees(+38.36899414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173365"},
        {"Hipparcos Number", "HIP 91814"},
        {"Smithsonian Astrophysical Observation", "SAO 67285"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.80469018),
        dec: Angle.Degrees(+38.36949111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217423"},
        {"Hipparcos Number", "HIP 113567"},
        {"Geneva Identification System", "GEN# +1.00217423"},
        {"Smithsonian Astrophysical Observation", "SAO 72917"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.03984796),
        dec: Angle.Degrees(+38.36984395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33151"},
        {"Hipparcos Number", "HIP 24043"},
        {"Geneva Identification System", "GEN# +1.00033151"},
        {"Smithsonian Astrophysical Observation", "SAO 57699"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51410302),
        dec: Angle.Degrees(+38.37360364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2717 A"},
        {"Henry Draper", "HD 23107"},
        {"Hipparcos Number", "HIP 17424"},
        {"Smithsonian Astrophysical Observation", "SAO 56667"},
        {"Wilson Evans Batten Catalogue", "WEB 3295"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.99551526),
        dec: Angle.Degrees(+38.37377479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139284"},
        {"Hipparcos Number", "HIP 76366"},
        {"Smithsonian Astrophysical Observation", "SAO 64797"},
        {"Wilson Evans Batten Catalogue", "WEB 12961"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.95494368),
        dec: Angle.Degrees(+38.37394659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2717 B"},
        {"Henry Draper", "HD 23108"},
        {"Hipparcos Number", "HIP 17428"},
        {"Geneva Identification System", "GEN# +1.00023108"},
        {"Smithsonian Astrophysical Observation", "SAO 56668"},
        {"Wilson Evans Batten Catalogue", "WEB 3296"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.00711942),
        dec: Angle.Degrees(+38.37484653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197008"},
        {"Hipparcos Number", "HIP 101946"},
        {"Smithsonian Astrophysical Observation", "SAO 70338"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.88623243),
        dec: Angle.Degrees(+38.37558268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180683"},
        {"Hipparcos Number", "HIP 94666"},
        {"Geneva Identification System", "GEN# +1.00180683"},
        {"Smithsonian Astrophysical Observation", "SAO 68054"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.95318392),
        dec: Angle.Degrees(+38.37970911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 242.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118849"},
        {"Hipparcos Number", "HIP 66569"},
        {"Geneva Identification System", "GEN# +1.00118849"},
        {"Smithsonian Astrophysical Observation", "SAO 63658"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68198226),
        dec: Angle.Degrees(+38.37985274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110445"},
        {"Smithsonian Astrophysical Observation", "SAO 72271"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57031478),
        dec: Angle.Degrees(+38.38020608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48493"},
        {"Hipparcos Number", "HIP 32379"},
        {"Geneva Identification System", "GEN# +1.00048493"},
        {"Smithsonian Astrophysical Observation", "SAO 59447"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.36530589),
        dec: Angle.Degrees(+38.38266401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185330"},
        {"Hipparcos Number", "HIP 96491"},
        {"Celescope Catalog", "CEL 4805"},
        {"Geneva Identification System", "GEN# +1.00185330"},
        {"Renson", "Renson 51200"},
        {"Smithsonian Astrophysical Observation", "SAO 68585"},
        {"Wilson Evans Batten Catalogue", "WEB 16930"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.23602466),
        dec: Angle.Degrees(+38.38382946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110375"},
        {"Hipparcos Number", "HIP 61920"},
        {"Geneva Identification System", "GEN# +1.00110375"},
        {"Smithsonian Astrophysical Observation", "SAO 63138"},
        {"Wilson Evans Batten Catalogue", "WEB 11009"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.35541222),
        dec: Angle.Degrees(+38.38911279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29723"},
        {"Hipparcos Number", "HIP 21902"},
        {"Smithsonian Astrophysical Observation", "SAO 57383"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65302709),
        dec: Angle.Degrees(+38.38963856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126597"},
        {"Hipparcos Number", "HIP 70517"},
        {"Fundamental Katalog 5th Edition", "FK5 3142"},
        {"Geneva Identification System", "GEN# +1.00126597"},
        {"Smithsonian Astrophysical Observation", "SAO 64137"},
        {"Wilson Evans Batten Catalogue", "WEB 12231"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.37144931),
        dec: Angle.Degrees(+38.39310009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227310"},
        {"Hipparcos Number", "HIP 98691"},
        {"Celescope Catalog", "CEL 4920"},
        {"Geneva Identification System", "GEN# +1.00227310"},
        {"Wilson Evans Batten Catalogue", "WEB 17474"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.67376933),
        dec: Angle.Degrees(+38.39336417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96161"},
        {"Hipparcos Number", "HIP 54235"},
        {"Smithsonian Astrophysical Observation", "SAO 62401"},
        {"Wilson Evans Batten Catalogue", "WEB 9799"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45170189),
        dec: Angle.Degrees(+38.39439532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52423"},
        {"Smithsonian Astrophysical Observation", "SAO 62214"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.76174102),
        dec: Angle.Degrees(+38.39562844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11071 AB"},
        {"Hipparcos Number", "HIP 88685"},
        {"Smithsonian Astrophysical Observation", "SAO 66634"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.56805361),
        dec: Angle.Degrees(+38.40043037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184105"},
        {"Hipparcos Number", "HIP 96010"},
        {"Smithsonian Astrophysical Observation", "SAO 68431"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81756734),
        dec: Angle.Degrees(+38.40080716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202254"},
        {"Hipparcos Number", "HIP 104763"},
        {"Smithsonian Astrophysical Observation", "SAO 71087"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.35457907),
        dec: Angle.Degrees(+38.40222049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113829"},
        {"Hipparcos Number", "HIP 63919"},
        {"Geneva Identification System", "GEN# +1.00113829"},
        {"Smithsonian Astrophysical Observation", "SAO 63341"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.48629329),
        dec: Angle.Degrees(+38.40238686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92321"},
        {"Hipparcos Number", "HIP 52223"},
        {"Smithsonian Astrophysical Observation", "SAO 62190"},
        {"Wilson Evans Batten Catalogue", "WEB 9513"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05201479),
        dec: Angle.Degrees(+38.40320106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18418"},
        {"Hipparcos Number", "HIP 13895"},
        {"Smithsonian Astrophysical Observation", "SAO 56051"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.72777021),
        dec: Angle.Degrees(+38.40356463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131333"},
        {"Hipparcos Number", "HIP 72694"},
        {"Smithsonian Astrophysical Observation", "SAO 64367"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.94151289),
        dec: Angle.Degrees(+38.40410673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131449"},
        {"Hipparcos Number", "HIP 72760"},
        {"Smithsonian Astrophysical Observation", "SAO 64371"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.11675170),
        dec: Angle.Degrees(+38.40632400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13637"},
        {"Hipparcos Number", "HIP 10398"},
        {"Smithsonian Astrophysical Observation", "SAO 55365"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.48667614),
        dec: Angle.Degrees(+38.40736408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12944 A"},
        {"Henry Draper", "HD 187235"},
        {"Hipparcos Number", "HIP 97376"},
        {"Geneva Identification System", "GEN# +1.00187235"},
        {"Smithsonian Astrophysical Observation", "SAO 68859"},
        {"Wilson Evans Batten Catalogue", "WEB 17114"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86573441),
        dec: Angle.Degrees(+38.40761671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18881"},
        {"Hipparcos Number", "HIP 14234"},
        {"Geneva Identification System", "GEN# +1.00018881"},
        {"Smithsonian Astrophysical Observation", "SAO 56114"},
        {"Wilson Evans Batten Catalogue", "WEB 2788"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.88308663),
        dec: Angle.Degrees(+38.41005026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8047 AB"},
        {"Henry Draper", "HD 96016"},
        {"Hipparcos Number", "HIP 54178"},
        {"Geneva Identification System", "GEN# +1.00096016"},
        {"Smithsonian Astrophysical Observation", "SAO 62395"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.23871014),
        dec: Angle.Degrees(+38.41062474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74969"},
        {"Smithsonian Astrophysical Observation", "SAO 64628"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.80012157),
        dec: Angle.Degrees(+38.41254445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88096"},
        {"Hipparcos Number", "HIP 49826"},
        {"Smithsonian Astrophysical Observation", "SAO 61905"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.57825335),
        dec: Angle.Degrees(+38.41343068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36011"},
        {"Smithsonian Astrophysical Observation", "SAO 60062"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32244745),
        dec: Angle.Degrees(+38.41366198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31879"},
        {"Hipparcos Number", "HIP 23323"},
        {"Smithsonian Astrophysical Observation", "SAO 57567"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.25770941),
        dec: Angle.Degrees(+38.41416601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47603"},
        {"Smithsonian Astrophysical Observation", "SAO 61643"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.59534233),
        dec: Angle.Degrees(+38.41468607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 823"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.52192137),
        dec: Angle.Degrees(+38.41489409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210747"},
        {"Hipparcos Number", "HIP 109569"},
        {"Smithsonian Astrophysical Observation", "SAO 72115"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.93723057),
        dec: Angle.Degrees(+38.41587191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68262"},
        {"Smithsonian Astrophysical Observation", "SAO 63862"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.61099534),
        dec: Angle.Degrees(+38.41710091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62159"},
        {"Geneva Identification System", "GEN# +0.03902554"},
        {"Smithsonian Astrophysical Observation", "SAO 63169"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.08900259),
        dec: Angle.Degrees(+38.41726598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9111 A"},
        {"Henry Draper", "HD 123399"},
        {"Hipparcos Number", "HIP 68905"},
        {"Fundamental Katalog 5th Edition", "FK5 1367"},
        {"Geneva Identification System", "GEN# +1.00123399"},
        {"Smithsonian Astrophysical Observation", "SAO 63933"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.61185660),
        dec: Angle.Degrees(+38.41756304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53946"},
        {"Smithsonian Astrophysical Observation", "SAO 62365"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.56916076),
        dec: Angle.Degrees(+38.41867910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50051"},
        {"Smithsonian Astrophysical Observation", "SAO 61933"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.28374973),
        dec: Angle.Degrees(+38.41917342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46079"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.95634108),
        dec: Angle.Degrees(+38.42055517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9111 B"},
        {"Hipparcos Number", "HIP 68907"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.61619077),
        dec: Angle.Degrees(+38.42119654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181880"},
        {"Hipparcos Number", "HIP 95064"},
        {"Smithsonian Astrophysical Observation", "SAO 68169"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.13432430),
        dec: Angle.Degrees(+38.42537536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96612"},
        {"Hipparcos Number", "HIP 54426"},
        {"Smithsonian Astrophysical Observation", "SAO 62417"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.05905563),
        dec: Angle.Degrees(+38.42653265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29742"},
        {"Hipparcos Number", "HIP 21915"},
        {"Geneva Identification System", "GEN# +1.00029742"},
        {"Smithsonian Astrophysical Observation", "SAO 57385"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.69846794),
        dec: Angle.Degrees(+38.42664470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174601"},
        {"Hipparcos Number", "HIP 92387"},
        {"Smithsonian Astrophysical Observation", "SAO 67444"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.40866288),
        dec: Angle.Degrees(+38.42768351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207955"},
        {"Hipparcos Number", "HIP 107926"},
        {"Smithsonian Astrophysical Observation", "SAO 71779"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.99311877),
        dec: Angle.Degrees(+38.42990191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87955"},
        {"Hipparcos Number", "HIP 49746"},
        {"Geneva Identification System", "GEN# +1.00087955"},
        {"Smithsonian Astrophysical Observation", "SAO 61900"},
        {"Wilson Evans Batten Catalogue", "WEB 9169"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.33066272),
        dec: Angle.Degrees(+38.43074357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106192"},
        {"Smithsonian Astrophysical Observation", "SAO 71413"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.64688834),
        dec: Angle.Degrees(+38.43320492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63779"},
        {"Geneva Identification System", "GEN# +0.03902597"},
        {"Smithsonian Astrophysical Observation", "SAO 63326"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.08961221),
        dec: Angle.Degrees(+38.43336184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61167"},
        {"Smithsonian Astrophysical Observation", "SAO 63051"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.00953944),
        dec: Angle.Degrees(+38.43357858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4922 AB"},
        {"Henry Draper", "HD 43739"},
        {"Hipparcos Number", "HIP 30074"},
        {"Smithsonian Astrophysical Observation", "SAO 58985"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.93182006),
        dec: Angle.Degrees(+38.43528043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6746"},
        {"Hipparcos Number", "HIP 5375"},
        {"Geneva Identification System", "GEN# +1.00006746"},
        {"Smithsonian Astrophysical Observation", "SAO 54456"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.19393932),
        dec: Angle.Degrees(+38.43542051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48364"},
        {"Smithsonian Astrophysical Observation", "SAO 61716"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.89590091),
        dec: Angle.Degrees(+38.43806583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50037"},
        {"Hipparcos Number", "HIP 33064"},
        {"Geneva Identification System", "GEN# +1.00050037"},
        {"Smithsonian Astrophysical Observation", "SAO 59576"},
        {"Wilson Evans Batten Catalogue", "WEB 6657"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30570458),
        dec: Angle.Degrees(+38.43844844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195050"},
        {"Hipparcos Number", "HIP 100907"},
        {"Celescope Catalog", "CEL 5069"},
        {"Geneva Identification System", "GEN# +1.00195050"},
        {"Smithsonian Astrophysical Observation", "SAO 70056"},
        {"Wilson Evans Batten Catalogue", "WEB 18229"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.89281213),
        dec: Angle.Degrees(+38.44052275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169952"},
        {"Hipparcos Number", "HIP 90293"},
        {"Geneva Identification System", "GEN# +1.00169952"},
        {"Renson", "Renson 47600"},
        {"Smithsonian Astrophysical Observation", "SAO 66955"},
        {"Wilson Evans Batten Catalogue", "WEB 15450"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.34634683),
        dec: Angle.Degrees(+38.44094316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210943"},
        {"Hipparcos Number", "HIP 109681"},
        {"Smithsonian Astrophysical Observation", "SAO 72141"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.27196260),
        dec: Angle.Degrees(+38.44154265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162807"},
        {"Hipparcos Number", "HIP 87371"},
        {"Geneva Identification System", "GEN# +1.00162807"},
        {"Smithsonian Astrophysical Observation", "SAO 66386"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78233719),
        dec: Angle.Degrees(+38.44251476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84099"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.89412267),
        dec: Angle.Degrees(+38.44286912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216575"},
        {"Hipparcos Number", "HIP 113036"},
        {"Geneva Identification System", "GEN# +1.00216575"},
        {"Smithsonian Astrophysical Observation", "SAO 72816"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.38018048),
        dec: Angle.Degrees(+38.44466069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46687"},
        {"Hipparcos Number", "HIP 31579"},
        {"Geneva Identification System", "GEN# +1.00046687"},
        {"Smithsonian Astrophysical Observation", "SAO 59280"},
        {"Wilson Evans Batten Catalogue", "WEB 6319"},
    },
    visualMagnitude: 5.40,
    bvColour: 2.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.13682373),
        dec: Angle.Degrees(+38.44555210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29308"},
        {"Hipparcos Number", "HIP 21628"},
        {"Geneva Identification System", "GEN# +1.00029308"},
        {"Smithsonian Astrophysical Observation", "SAO 57354"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.66130779),
        dec: Angle.Degrees(+38.44863468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115461"},
        {"Hipparcos Number", "HIP 64787"},
        {"Smithsonian Astrophysical Observation", "SAO 63443"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.17949908),
        dec: Angle.Degrees(+38.45093750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77912"},
        {"Hipparcos Number", "HIP 44700"},
        {"Fundamental Katalog 5th Edition", "FK5 1237"},
        {"Geneva Identification System", "GEN# +1.00077912"},
        {"Smithsonian Astrophysical Observation", "SAO 61254"},
        {"Wilson Evans Batten Catalogue", "WEB 8549"},
    },
    visualMagnitude: 4.56,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63245022),
        dec: Angle.Degrees(+38.45225024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47286"},
        {"Smithsonian Astrophysical Observation", "SAO 61607"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55337905),
        dec: Angle.Degrees(+38.45259023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25821"},
        {"Hipparcos Number", "HIP 19215"},
        {"Geneva Identification System", "GEN# +1.00025821"},
        {"Smithsonian Astrophysical Observation", "SAO 56975"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.78225540),
        dec: Angle.Degrees(+38.45432196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70416"},
        {"Smithsonian Astrophysical Observation", "SAO 64126"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.08844516),
        dec: Angle.Degrees(+38.45488535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163468"},
        {"Hipparcos Number", "HIP 87680"},
        {"Geneva Identification System", "GEN# +1.00163468"},
        {"Smithsonian Astrophysical Observation", "SAO 66455"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.62850503),
        dec: Angle.Degrees(+38.45596722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186200"},
        {"Hipparcos Number", "HIP 96866"},
        {"Celescope Catalog", "CEL 4817"},
        {"Geneva Identification System", "GEN# +1.00186200"},
        {"Smithsonian Astrophysical Observation", "SAO 68700"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.34676213),
        dec: Angle.Degrees(+38.45796950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138853"},
        {"Hipparcos Number", "HIP 76160"},
        {"Geneva Identification System", "GEN# +1.00138853"},
        {"Smithsonian Astrophysical Observation", "SAO 64774"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.32783485),
        dec: Angle.Degrees(+38.45798198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189235"},
        {"Hipparcos Number", "HIP 98213"},
        {"Smithsonian Astrophysical Observation", "SAO 69155"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.37094410),
        dec: Angle.Degrees(+38.45824671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84180"},
        {"Hipparcos Number", "HIP 47764"},
        {"Smithsonian Astrophysical Observation", "SAO 61660"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.06949153),
        dec: Angle.Degrees(+38.45838900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166620"},
        {"Hipparcos Number", "HIP 88972"},
        {"Cincinnati Publication", "Ci 20 1078"},
        {"Cincinnati Publication 2", "Ci 18 2403"},
        {"Geneva Identification System", "GEN# +1.00166620"},
        {"Smithsonian Astrophysical Observation", "SAO 66700"},
        {"Wilson Evans Batten Catalogue", "WEB 15090"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.40688326),
        dec: Angle.Degrees(+38.45891534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -316.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -468.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1028 A"},
        {"Henry Draper", "HD 7639"},
        {"Hipparcos Number", "HIP 5982"},
        {"Geneva Identification System", "GEN# +1.00007639"},
        {"Smithsonian Astrophysical Observation", "SAO 54576"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.23783168),
        dec: Angle.Degrees(+38.46077848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70533"},
        {"Hipparcos Number", "HIP 41165"},
        {"Smithsonian Astrophysical Observation", "SAO 60782"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.98165312),
        dec: Angle.Degrees(+38.46249581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1028 B"},
        {"Hipparcos Number", "HIP 5981"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.23491359),
        dec: Angle.Degrees(+38.46380501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229227"},
        {"Hipparcos Number", "HIP 100600"},
        {"Geneva Identification System", "GEN# +2.69130005"},
        {"Wilson Evans Batten Catalogue", "WEB 18179"},
        {"New General Catalogue", "NGC 6913 5"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97927635),
        dec: Angle.Degrees(+38.46636342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72387"},
        {"Geneva Identification System", "GEN# +0.03902801"},
        {"Wilson Evans Batten Catalogue", "WEB 12444"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.00614567),
        dec: Angle.Degrees(+38.46654972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202599"},
        {"Hipparcos Number", "HIP 104972"},
        {"Smithsonian Astrophysical Observation", "SAO 71135"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.93576615),
        dec: Angle.Degrees(+38.46763907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26604"},
        {"Hipparcos Number", "HIP 19755"},
        {"Geneva Identification System", "GEN# +1.00026604"},
        {"Smithsonian Astrophysical Observation", "SAO 57083"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.52872769),
        dec: Angle.Degrees(+38.46950838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31877"},
        {"Smithsonian Astrophysical Observation", "SAO 59338"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.95098444),
        dec: Angle.Degrees(+38.47022921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89729"},
        {"Hipparcos Number", "HIP 50767"},
        {"Geneva Identification System", "GEN# +1.00089729"},
        {"Smithsonian Astrophysical Observation", "SAO 62000"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.50355065),
        dec: Angle.Degrees(+38.47516064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98921",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13348 A"},
        {"Henry Draper", "HD 190771"},
        {"Hipparcos Number", "HIP 98921"},
        {"Geneva Identification System", "GEN# +1.00190771"},
        {"Smithsonian Astrophysical Observation", "SAO 69377"},
        {"Wilson Evans Batten Catalogue", "WEB 17559"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.28994567),
        dec: Angle.Degrees(+38.47818576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148111"},
        {"Hipparcos Number", "HIP 80362"},
        {"Smithsonian Astrophysical Observation", "SAO 65279"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.06840924),
        dec: Angle.Degrees(+38.47826361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126140"},
        {"Hipparcos Number", "HIP 70274"},
        {"Geneva Identification System", "GEN# +1.00126140"},
        {"Smithsonian Astrophysical Observation", "SAO 64106"},
        {"Wilson Evans Batten Catalogue", "WEB 12203"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.67470832),
        dec: Angle.Degrees(+38.48177779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41357"},
        {"Hipparcos Number", "HIP 28946"},
        {"Fundamental Katalog 5th Edition", "FK5 2465"},
        {"Geneva Identification System", "GEN# +1.00041357"},
        {"Renson", "Renson 11040"},
        {"Smithsonian Astrophysical Observation", "SAO 58749"},
        {"Wilson Evans Batten Catalogue", "WEB 5664"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.64620701),
        dec: Angle.Degrees(+38.48277233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33641"},
        {"Hipparcos Number", "HIP 24340"},
        {"Celescope Catalog", "CEL 566"},
        {"Fundamental Katalog 5th Edition", "FK5 192"},
        {"Geneva Identification System", "GEN# +1.00033641"},
        {"Renson", "Renson 8570"},
        {"Smithsonian Astrophysical Observation", "SAO 57755"},
        {"Wilson Evans Batten Catalogue", "WEB 4724"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.35721486),
        dec: Angle.Degrees(+38.48467394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36465"},
        {"Smithsonian Astrophysical Observation", "SAO 60132"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.55137431),
        dec: Angle.Degrees(+38.48485338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74654"},
        {"Hipparcos Number", "HIP 43091"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.64840042),
        dec: Angle.Degrees(+38.48584065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1009 AB"},
        {"Henry Draper", "HD 7475"},
        {"Hipparcos Number", "HIP 5874"},
        {"Smithsonian Astrophysical Observation", "SAO 54552"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.85737521),
        dec: Angle.Degrees(+38.48655028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188892"},
        {"Hipparcos Number", "HIP 98068"},
        {"Geneva Identification System", "GEN# +1.00188892"},
        {"Smithsonian Astrophysical Observation", "SAO 69101"},
        {"Wilson Evans Batten Catalogue", "WEB 17282"},
    },
    visualMagnitude: 4.95,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.96567172),
        dec: Angle.Degrees(+38.48670392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26235"},
        {"Hipparcos Number", "HIP 19497"},
        {"Smithsonian Astrophysical Observation", "SAO 57040"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.65346158),
        dec: Angle.Degrees(+38.48706865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229239"},
        {"Hipparcos Number", "HIP 100612"},
        {"Geneva Identification System", "GEN# +2.69130003"},
        {"Wilson Evans Batten Catalogue", "WEB 18186"},
        {"New General Catalogue", "NGC 6913 3"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02728785),
        dec: Angle.Degrees(+38.49256272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194378"},
        {"Hipparcos Number", "HIP 100586"},
        {"Geneva Identification System", "GEN# +2.69130010"},
        {"Smithsonian Astrophysical Observation", "SAO 69957"},
        {"Wilson Evans Batten Catalogue", "WEB 18174"},
        {"New General Catalogue", "NGC 6913 10"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96256303),
        dec: Angle.Degrees(+38.49288597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78334"},
        {"Smithsonian Astrophysical Observation", "SAO 65010"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.92420175),
        dec: Angle.Degrees(+38.49449951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154958"},
        {"Hipparcos Number", "HIP 83752"},
        {"Smithsonian Astrophysical Observation", "SAO 65801"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.76314046),
        dec: Angle.Degrees(+38.49455672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38092"},
        {"Hipparcos Number", "HIP 27112"},
        {"Smithsonian Astrophysical Observation", "SAO 58388"},
        {"Wilson Evans Batten Catalogue", "WEB 5334"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.23701041),
        dec: Angle.Degrees(+38.49868736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64246",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8805 A"},
        {"Henry Draper", "HD 114447"},
        {"Hipparcos Number", "HIP 64246"},
        {"Fundamental Katalog 5th Edition", "FK5 491"},
        {"Geneva Identification System", "GEN# +1.00114447"},
        {"Smithsonian Astrophysical Observation", "SAO 63380"},
        {"Wilson Evans Batten Catalogue", "WEB 11359"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.51361945),
        dec: Angle.Degrees(+38.49887224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4436",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 788 A"},
        {"Henry Draper", "HD 5448"},
        {"Hipparcos Number", "HIP 4436"},
        {"Fundamental Katalog 5th Edition", "FK5 33"},
        {"Geneva Identification System", "GEN# +1.00005448"},
        {"Renson", "Renson 1450"},
        {"Smithsonian Astrophysical Observation", "SAO 54281"},
        {"Wilson Evans Batten Catalogue", "WEB 793"},
    },
    visualMagnitude: 3.86,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18790699),
        dec: Angle.Degrees(+38.49925513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215635"},
        {"Hipparcos Number", "HIP 112410"},
        {"Smithsonian Astrophysical Observation", "SAO 72702"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.52599693),
        dec: Angle.Degrees(+38.49953029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66639"},
        {"Smithsonian Astrophysical Observation", "SAO 63672"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.89418930),
        dec: Angle.Degrees(+38.50181743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120048"},
        {"Hipparcos Number", "HIP 67210"},
        {"Geneva Identification System", "GEN# +1.00120048"},
        {"Smithsonian Astrophysical Observation", "SAO 63735"},
        {"Wilson Evans Batten Catalogue", "WEB 11828"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57957701),
        dec: Angle.Degrees(+38.50365610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50204"},
        {"Hipparcos Number", "HIP 33133"},
        {"Geneva Identification System", "GEN# +1.00050204"},
        {"Renson", "Renson 13740"},
        {"Smithsonian Astrophysical Observation", "SAO 59589"},
        {"Wilson Evans Batten Catalogue", "WEB 6663"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48780858),
        dec: Angle.Degrees(+38.50508594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280188"},
        {"Hipparcos Number", "HIP 22670"},
        {"Geneva Identification System", "GEN# +1.00280188"},
        {"Smithsonian Astrophysical Observation", "SAO 57472"},
        {"Wilson Evans Batten Catalogue", "WEB 4385"},
    },
    visualMagnitude: 8.63,
    bvColour: 2.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14530928),
        dec: Angle.Degrees(+38.50554711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11004",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1799 AB"},
        {"Henry Draper", "HD 14521"},
        {"Hipparcos Number", "HIP 11004"},
        {"Smithsonian Astrophysical Observation", "SAO 55487"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44357152),
        dec: Angle.Degrees(+38.50818751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178875"},
        {"Hipparcos Number", "HIP 94031"},
        {"Geneva Identification System", "GEN# +1.00178875"},
        {"Renson", "Renson 49730"},
        {"Smithsonian Astrophysical Observation", "SAO 67868"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.15850499),
        dec: Angle.Degrees(+38.50884096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98773"},
        {"Hipparcos Number", "HIP 55525"},
        {"Smithsonian Astrophysical Observation", "SAO 62518"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.58738696),
        dec: Angle.Degrees(+38.50945538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41930"},
        {"Smithsonian Astrophysical Observation", "SAO 60889"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22591020),
        dec: Angle.Degrees(+38.51039915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7915 AB"},
        {"Hipparcos Number", "HIP 52600"},
        {"Geneva Identification System", "GEN# +0.03902376"},
        {"Smithsonian Astrophysical Observation", "SAO 62230"},
        {"Wilson Evans Batten Catalogue", "WEB 9584"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.33964291),
        dec: Angle.Degrees(+38.51140325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31806"},
        {"Smithsonian Astrophysical Observation", "SAO 59322"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.74483282),
        dec: Angle.Degrees(+38.51236754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10450"},
        {"Hipparcos Number", "HIP 7994"},
        {"Geneva Identification System", "GEN# +1.00010450"},
        {"Smithsonian Astrophysical Observation", "SAO 54922"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.67052038),
        dec: Angle.Degrees(+38.51548385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89022"},
        {"Hipparcos Number", "HIP 50369"},
        {"Smithsonian Astrophysical Observation", "SAO 61964"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25932538),
        dec: Angle.Degrees(+38.51600508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9913"},
        {"Hipparcos Number", "HIP 7572"},
        {"Geneva Identification System", "GEN# +1.00009913"},
        {"Smithsonian Astrophysical Observation", "SAO 54844"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.38352401),
        dec: Angle.Degrees(+38.51617642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204187"},
        {"Hipparcos Number", "HIP 105817"},
        {"Smithsonian Astrophysical Observation", "SAO 71330"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.45851632),
        dec: Angle.Degrees(+38.51622345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11723"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.83327660),
        dec: Angle.Degrees(+38.51686474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20163"},
        {"Hipparcos Number", "HIP 15182"},
        {"Smithsonian Astrophysical Observation", "SAO 56289"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.92247440),
        dec: Angle.Degrees(+38.51741112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67363"},
        {"Smithsonian Astrophysical Observation", "SAO 63758"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.10187318),
        dec: Angle.Degrees(+38.51791110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132582"},
        {"Hipparcos Number", "HIP 73286"},
        {"Geneva Identification System", "GEN# +1.00132582"},
        {"Smithsonian Astrophysical Observation", "SAO 64433"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.66783415),
        dec: Angle.Degrees(+38.51928637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10600"},
        {"Hipparcos Number", "HIP 8105"},
        {"Geneva Identification System", "GEN# +1.00010600"},
        {"Smithsonian Astrophysical Observation", "SAO 54942"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.03908702),
        dec: Angle.Degrees(+38.52195902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85879"},
        {"Smithsonian Astrophysical Observation", "SAO 66131"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.25707662),
        dec: Angle.Degrees(+38.52221063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32672"},
        {"Hipparcos Number", "HIP 23774"},
        {"Celescope Catalog", "CEL 533"},
        {"Geneva Identification System", "GEN# +1.00032672"},
        {"Smithsonian Astrophysical Observation", "SAO 57638"},
        {"Wilson Evans Batten Catalogue", "WEB 4639"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.64289123),
        dec: Angle.Degrees(+38.52225509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67174"},
        {"Hipparcos Number", "HIP 39832"},
        {"Smithsonian Astrophysical Observation", "SAO 60590"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.07838244),
        dec: Angle.Degrees(+38.52486973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63471"},
        {"Hipparcos Number", "HIP 38289"},
        {"Smithsonian Astrophysical Observation", "SAO 60372"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.66924940),
        dec: Angle.Degrees(+38.52665661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24354"},
        {"Hipparcos Number", "HIP 18240"},
        {"Smithsonian Astrophysical Observation", "SAO 56797"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.52124187),
        dec: Angle.Degrees(+38.52669373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101978"},
        {"Hipparcos Number", "HIP 57250"},
        {"Geneva Identification System", "GEN# +1.00101978"},
        {"Smithsonian Astrophysical Observation", "SAO 62680"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.08443390),
        dec: Angle.Degrees(+38.52767659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201398"},
        {"Hipparcos Number", "HIP 104334"},
        {"Geneva Identification System", "GEN# +1.00201398"},
        {"Smithsonian Astrophysical Observation", "SAO 70959"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.02664892),
        dec: Angle.Degrees(+38.52911459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91684"},
        {"Hipparcos Number", "HIP 51871"},
        {"Geneva Identification System", "GEN# +1.00091684"},
        {"Smithsonian Astrophysical Observation", "SAO 62140"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.96541112),
        dec: Angle.Degrees(+38.53126969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30018"},
        {"Geneva Identification System", "GEN# +0.03801451"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.75519720),
        dec: Angle.Degrees(+38.53165150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -309.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34603"},
        {"Geneva Identification System", "GEN# +6.10010268"},
        {"Geneva Identification System 2", "GEN# +9.80087026"},
        {"Wilson Evans Batten Catalogue", "WEB 6924"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.50900471),
        dec: Angle.Degrees(+38.53176545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -439.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -948.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98641"},
        {"Hipparcos Number", "HIP 55445"},
        {"Smithsonian Astrophysical Observation", "SAO 62506"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.32345356),
        dec: Angle.Degrees(+38.53251444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173525"},
        {"Hipparcos Number", "HIP 91898"},
        {"Smithsonian Astrophysical Observation", "SAO 67302"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.02146593),
        dec: Angle.Degrees(+38.53304638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205512"},
        {"Hipparcos Number", "HIP 106551"},
        {"Fundamental Katalog 5th Edition", "FK5 3722"},
        {"Geneva Identification System", "GEN# +1.00205512"},
        {"Smithsonian Astrophysical Observation", "SAO 71480"},
        {"Wilson Evans Batten Catalogue", "WEB 19278"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.69365589),
        dec: Angle.Degrees(+38.53382684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8805 BC"},
        {"Henry Draper", "HD 114376"},
        {"Hipparcos Number", "HIP 64217"},
        {"Geneva Identification System", "GEN# +1.00114376"},
        {"Smithsonian Astrophysical Observation", "SAO 63374"},
        {"Wilson Evans Batten Catalogue", "WEB 11352"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.42517501),
        dec: Angle.Degrees(+38.53387060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117077"},
        {"Hipparcos Number", "HIP 65622"},
        {"Geneva Identification System", "GEN# +1.00117077"},
        {"Smithsonian Astrophysical Observation", "SAO 63544"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.81128584),
        dec: Angle.Degrees(+38.53410165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51817"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.79406610),
        dec: Angle.Degrees(+38.53771888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19749"},
        {"Hipparcos Number", "HIP 14869"},
        {"Smithsonian Astrophysical Observation", "SAO 56240"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.99017370),
        dec: Angle.Degrees(+38.53818348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31373",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5191"},
        {"Henry Draper", "HD 46359"},
        {"Hipparcos Number", "HIP 31373"},
        {"Smithsonian Astrophysical Observation", "SAO 59239"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.67417539),
        dec: Angle.Degrees(+38.54016739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120164"},
        {"Hipparcos Number", "HIP 67250"},
        {"Fundamental Katalog 5th Edition", "FK5 3094"},
        {"Geneva Identification System", "GEN# +1.00120164A"},
        {"Smithsonian Astrophysical Observation", "SAO 63739"},
        {"Wilson Evans Batten Catalogue", "WEB 11834"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.74947851),
        dec: Angle.Degrees(+38.54274988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12425"},
        {"Hipparcos Number", "HIP 9541"},
        {"Geneva Identification System", "GEN# +1.00012425"},
        {"Smithsonian Astrophysical Observation", "SAO 55215"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.65888137),
        dec: Angle.Degrees(+38.54399608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55172"},
        {"Smithsonian Astrophysical Observation", "SAO 62480"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.44212124),
        dec: Angle.Degrees(+38.54571199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24353"},
        {"Hipparcos Number", "HIP 18238"},
        {"Geneva Identification System", "GEN# +1.00024353"},
        {"Smithsonian Astrophysical Observation", "SAO 56796"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.51697416),
        dec: Angle.Degrees(+38.54784221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5066"},
        {"Hipparcos Number", "HIP 4129"},
        {"Geneva Identification System", "GEN# +1.00005066"},
        {"Smithsonian Astrophysical Observation", "SAO 54225"},
        {"Wilson Evans Batten Catalogue", "WEB 736"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22233391),
        dec: Angle.Degrees(+38.54885598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140297"},
        {"Hipparcos Number", "HIP 76844"},
        {"Smithsonian Astrophysical Observation", "SAO 64848"},
        {"Wilson Evans Batten Catalogue", "WEB 13035"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.35922431),
        dec: Angle.Degrees(+38.55746652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35344"},
        {"Hipparcos Number", "HIP 25380"},
        {"Smithsonian Astrophysical Observation", "SAO 58008"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.45230346),
        dec: Angle.Degrees(+38.55883288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112334"},
    },
    visualMagnitude: 12.15,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.29930096),
        dec: Angle.Degrees(+38.55981156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4452 AB"},
        {"Henry Draper", "HD 39114"},
        {"Hipparcos Number", "HIP 27723"},
        {"Smithsonian Astrophysical Observation", "SAO 58520"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.05780246),
        dec: Angle.Degrees(+38.56018077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11105"},
        {"Hipparcos Number", "HIP 8540"},
        {"Geneva Identification System", "GEN# +1.00011105"},
        {"Smithsonian Astrophysical Observation", "SAO 55008"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.52482118),
        dec: Angle.Degrees(+38.56102721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202088"},
        {"Hipparcos Number", "HIP 104699"},
        {"Celescope Catalog", "CEL 5271"},
        {"Geneva Identification System", "GEN# +1.00202088"},
        {"Smithsonian Astrophysical Observation", "SAO 71065"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12297530),
        dec: Angle.Degrees(+38.56650046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209271"},
        {"Hipparcos Number", "HIP 108709"},
        {"Smithsonian Astrophysical Observation", "SAO 71951"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.31677015),
        dec: Angle.Degrees(+38.56685453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74509"},
        {"Wilson Evans Batten Catalogue", "WEB 12712"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.38568854),
        dec: Angle.Degrees(+38.56826137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35108"},
        {"Hipparcos Number", "HIP 25260"},
        {"Celescope Catalog", "CEL 667"},
        {"Geneva Identification System", "GEN# +1.00035108"},
        {"Smithsonian Astrophysical Observation", "SAO 57975"},
        {"Wilson Evans Batten Catalogue", "WEB 4898"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.03460372),
        dec: Angle.Degrees(+38.56827188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44614"},
        {"Hipparcos Number", "HIP 30486"},
        {"Geneva Identification System", "GEN# +1.00044614"},
        {"Smithsonian Astrophysical Observation", "SAO 59046"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.12831995),
        dec: Angle.Degrees(+38.56939367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218289"},
        {"Hipparcos Number", "HIP 114087"},
        {"Smithsonian Astrophysical Observation", "SAO 72993"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.59769880),
        dec: Angle.Degrees(+38.56975623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93469"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.53345029),
        dec: Angle.Degrees(+38.57010735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200529"},
        {"Hipparcos Number", "HIP 103873"},
        {"Smithsonian Astrophysical Observation", "SAO 70826"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.70857152),
        dec: Angle.Degrees(+38.57074506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9221"},
        {"Geneva Identification System", "GEN# +0.03700442"},
        {"Renson", "Renson 3070"},
    },
    visualMagnitude: 10.01,
    bvColour: -0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.63934387),
        dec: Angle.Degrees(+38.57330845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212487"},
        {"Hipparcos Number", "HIP 110566"},
        {"Geneva Identification System", "GEN# +1.00212487"},
        {"Smithsonian Astrophysical Observation", "SAO 72296"},
        {"Wilson Evans Batten Catalogue", "WEB 19816"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.97525489),
        dec: Angle.Degrees(+38.57331176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41075"},
        {"Hipparcos Number", "HIP 28787"},
        {"Smithsonian Astrophysical Observation", "SAO 58709"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16558728),
        dec: Angle.Degrees(+38.57512972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5853"},
        {"Hipparcos Number", "HIP 4712"},
        {"Smithsonian Astrophysical Observation", "SAO 54340"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13305864),
        dec: Angle.Degrees(+38.57655552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1967"},
        {"Hipparcos Number", "HIP 1901"},
        {"Geneva Identification System", "GEN# +1.00001967"},
        {"Smithsonian Astrophysical Observation", "SAO 53860"},
        {"Wilson Evans Batten Catalogue", "WEB 340"},
    },
    visualMagnitude: 10.71,
    bvColour: 2.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.00816265),
        dec: Angle.Degrees(+38.57712054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27381"},
        {"Hipparcos Number", "HIP 20291"},
        {"Geneva Identification System", "GEN# +1.00027381"},
        {"Smithsonian Astrophysical Observation", "SAO 57175"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22973511),
        dec: Angle.Degrees(+38.57715446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39814"},
        {"Hipparcos Number", "HIP 28131"},
        {"Smithsonian Astrophysical Observation", "SAO 58591"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.19434511),
        dec: Angle.Degrees(+38.57758200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275401"},
        {"Hipparcos Number", "HIP 16104"},
        {"Smithsonian Astrophysical Observation", "SAO 56463"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.86212832),
        dec: Angle.Degrees(+38.57791019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73374"},
        {"Hipparcos Number", "HIP 42475"},
        {"Smithsonian Astrophysical Observation", "SAO 60961"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.89365931),
        dec: Angle.Degrees(+38.58032659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67065"},
        {"Hipparcos Number", "HIP 39785"},
        {"Geneva Identification System", "GEN# +1.00067065"},
        {"Smithsonian Astrophysical Observation", "SAO 60578"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.95222555),
        dec: Angle.Degrees(+38.58066982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220148"},
        {"Hipparcos Number", "HIP 115313"},
        {"Geneva Identification System", "GEN# +1.00220148"},
        {"Smithsonian Astrophysical Observation", "SAO 73196"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.32249508),
        dec: Angle.Degrees(+38.58229867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10531 AB"},
        {"Henry Draper", "HD 157853"},
        {"Hipparcos Number", "HIP 85149"},
        {"Geneva Identification System", "GEN# +1.00157853J"},
        {"Smithsonian Astrophysical Observation", "SAO 66006"},
        {"Wilson Evans Batten Catalogue", "WEB 14378"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.00942844),
        dec: Angle.Degrees(+38.58269551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14007 AB"},
        {"Henry Draper", "HD 196092"},
        {"Hipparcos Number", "HIP 101456"},
        {"Geneva Identification System", "GEN# +1.00196092J"},
        {"Smithsonian Astrophysical Observation", "SAO 70198"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.42838226),
        dec: Angle.Degrees(+38.58312980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32943"},
        {"Smithsonian Astrophysical Observation", "SAO 59552"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.93446795),
        dec: Angle.Degrees(+38.58424028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22090"},
        {"Hipparcos Number", "HIP 16719"},
        {"Geneva Identification System", "GEN# +1.00022090"},
        {"Smithsonian Astrophysical Observation", "SAO 56558"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.77585389),
        dec: Angle.Degrees(+38.58574065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103003"},
        {"Smithsonian Astrophysical Observation", "SAO 70604"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.02739591),
        dec: Angle.Degrees(+38.58745414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63470"},
        {"Hipparcos Number", "HIP 38295"},
        {"Smithsonian Astrophysical Observation", "SAO 60373"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69379625),
        dec: Angle.Degrees(+38.58811523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124185"},
        {"Hipparcos Number", "HIP 69293"},
        {"Smithsonian Astrophysical Observation", "SAO 63977"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75150279),
        dec: Angle.Degrees(+38.59364309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185397"},
        {"Hipparcos Number", "HIP 96517"},
        {"Geneva Identification System", "GEN# +1.00185397"},
        {"Smithsonian Astrophysical Observation", "SAO 68592"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.32329362),
        dec: Angle.Degrees(+38.59419311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11170 AB"},
        {"Hipparcos Number", "HIP 89237"},
        {"Smithsonian Astrophysical Observation", "SAO 66754"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.15300606),
        dec: Angle.Degrees(+38.59753122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12175"},
        {"Hipparcos Number", "HIP 9363"},
        {"Geneva Identification System", "GEN# +1.00012175"},
        {"Smithsonian Astrophysical Observation", "SAO 55176"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.07298083),
        dec: Angle.Degrees(+38.59758506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34240"},
        {"Smithsonian Astrophysical Observation", "SAO 59763"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.47009454),
        dec: Angle.Degrees(+38.60063324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19197"},
        {"Hipparcos Number", "HIP 14458"},
        {"Smithsonian Astrophysical Observation", "SAO 56157"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.64605981),
        dec: Angle.Degrees(+38.60209893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75518"},
        {"Smithsonian Astrophysical Observation", "SAO 64697"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.42235392),
        dec: Angle.Degrees(+38.60240304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73172"},
        {"Smithsonian Astrophysical Observation", "SAO 64422"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.31850074),
        dec: Angle.Degrees(+38.60334212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133725"},
        {"Hipparcos Number", "HIP 73765"},
        {"Geneva Identification System", "GEN# +1.00133725"},
        {"Smithsonian Astrophysical Observation", "SAO 64491"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.18138145),
        dec: Angle.Degrees(+38.60514499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74907"},
        {"Hipparcos Number", "HIP 43213"},
        {"Smithsonian Astrophysical Observation", "SAO 61055"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.04673624),
        dec: Angle.Degrees(+38.60608891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192766"},
        {"Hipparcos Number", "HIP 99821"},
        {"Celescope Catalog", "CEL 4995"},
        {"Smithsonian Astrophysical Observation", "SAO 69699"},
        {"Wilson Evans Batten Catalogue", "WEB 17938"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.80174913),
        dec: Angle.Degrees(+38.60878950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79392"},
        {"Hipparcos Number", "HIP 45389"},
        {"Geneva Identification System", "GEN# +1.00079392"},
        {"Smithsonian Astrophysical Observation", "SAO 61353"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.74147752),
        dec: Angle.Degrees(+38.60913277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48992"},
        {"Smithsonian Astrophysical Observation", "SAO 61800"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.93199821),
        dec: Angle.Degrees(+38.61112913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54073"},
        {"Hipparcos Number", "HIP 34523"},
        {"Geneva Identification System", "GEN# +1.00054073"},
        {"Smithsonian Astrophysical Observation", "SAO 59821"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.30514660),
        dec: Angle.Degrees(+38.61186524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86965"},
        {"Hipparcos Number", "HIP 49232"},
        {"Geneva Identification System", "GEN# +1.00086965"},
        {"Smithsonian Astrophysical Observation", "SAO 61826"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.74452913),
        dec: Angle.Degrees(+38.61264605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18339"},
        {"Hipparcos Number", "HIP 13832"},
        {"Geneva Identification System", "GEN# +1.00018339"},
        {"Smithsonian Astrophysical Observation", "SAO 56036"},
        {"Wilson Evans Batten Catalogue", "WEB 2735"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.50971566),
        dec: Angle.Degrees(+38.61496884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216512"},
        {"Hipparcos Number", "HIP 112987"},
        {"Smithsonian Astrophysical Observation", "SAO 72806"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.22598006),
        dec: Angle.Degrees(+38.61604394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111813"},
        {"Smithsonian Astrophysical Observation", "SAO 72567"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.72581404),
        dec: Angle.Degrees(+38.61824523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12638",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2056 A"},
        {"Henry Draper", "HD 16760"},
        {"Hipparcos Number", "HIP 12638"},
        {"Geneva Identification System", "GEN# +1.00016760"},
        {"Smithsonian Astrophysical Observation", "SAO 55798"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58855043),
        dec: Angle.Degrees(+38.61893682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2056 B"},
        {"Henry Draper", "HD 16760B"},
        {"Hipparcos Number", "HIP 12635"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58703320),
        dec: Angle.Degrees(+38.62280619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151253"},
        {"Hipparcos Number", "HIP 81967"},
        {"Smithsonian Astrophysical Observation", "SAO 65521"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.16712146),
        dec: Angle.Degrees(+38.62314938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163638"},
        {"Hipparcos Number", "HIP 87743"},
        {"Smithsonian Astrophysical Observation", "SAO 66473"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.84747362),
        dec: Angle.Degrees(+38.62455158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28354"},
        {"Smithsonian Astrophysical Observation", "SAO 58629"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.86961439),
        dec: Angle.Degrees(+38.62459895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72429"},
        {"Smithsonian Astrophysical Observation", "SAO 64338"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.14660404),
        dec: Angle.Degrees(+38.62531403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174912"},
        {"Hipparcos Number", "HIP 92532"},
        {"Cincinnati Publication", "Ci 18 2467"},
        {"Geneva Identification System", "GEN# +1.00174912"},
        {"Smithsonian Astrophysical Observation", "SAO 67481"},
        {"Wilson Evans Batten Catalogue", "WEB 16004"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.85390681),
        dec: Angle.Degrees(+38.62646410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 323.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217398"},
        {"Hipparcos Number", "HIP 113551"},
        {"Smithsonian Astrophysical Observation", "SAO 72913"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.97165547),
        dec: Angle.Degrees(+38.62791735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51382"},
        {"Smithsonian Astrophysical Observation", "SAO 62070"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.41257874),
        dec: Angle.Degrees(+38.63184168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105601"},
        {"Hipparcos Number", "HIP 59271"},
        {"Fundamental Katalog 5th Edition", "FK5 5076"},
        {"Geneva Identification System", "GEN# +1.00105601"},
        {"Renson", "Renson 30550"},
        {"Smithsonian Astrophysical Observation", "SAO 62866"},
        {"Wilson Evans Batten Catalogue", "WEB 10542"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.36593932),
        dec: Angle.Degrees(+38.63198689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144872"},
        {"Hipparcos Number", "HIP 78913"},
        {"Cincinnati Publication", "Ci 18 2160"},
        {"Cincinnati Publication 2", "Ci 20 967"},
        {"Geneva Identification System", "GEN# +1.00144872"},
        {"Smithsonian Astrophysical Observation", "SAO 65081"},
        {"Wilson Evans Batten Catalogue", "WEB 13338"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.62260618),
        dec: Angle.Degrees(+38.63354279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -536.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203696"},
        {"Hipparcos Number", "HIP 105561"},
        {"Geneva Identification System", "GEN# +1.00203696"},
        {"Smithsonian Astrophysical Observation", "SAO 71266"},
        {"Wilson Evans Batten Catalogue", "WEB 19164"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.69516471),
        dec: Angle.Degrees(+38.63432127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196850"},
        {"Hipparcos Number", "HIP 101875"},
        {"Geneva Identification System", "GEN# +1.00196850"},
        {"Smithsonian Astrophysical Observation", "SAO 70321"},
        {"Wilson Evans Batten Catalogue", "WEB 18409"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.66683330),
        dec: Angle.Degrees(+38.63556258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15329",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2446 AB"},
        {"Henry Draper", "HD 20347"},
        {"Hipparcos Number", "HIP 15329"},
        {"Geneva Identification System", "GEN# +1.00020347"},
        {"Smithsonian Astrophysical Observation", "SAO 56320"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43306393),
        dec: Angle.Degrees(+38.63931076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66197"},
        {"Hipparcos Number", "HIP 39466"},
        {"Geneva Identification System", "GEN# +1.00066197"},
        {"Smithsonian Astrophysical Observation", "SAO 60536"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.00434963),
        dec: Angle.Degrees(+38.63954093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69963"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.74822419),
        dec: Angle.Degrees(+38.64121471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -702.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148069"},
        {"Hipparcos Number", "HIP 80327"},
        {"Smithsonian Astrophysical Observation", "SAO 65275"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98985726),
        dec: Angle.Degrees(+38.64172953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221189"},
        {"Hipparcos Number", "HIP 115956"},
        {"Smithsonian Astrophysical Observation", "SAO 73295"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.40010075),
        dec: Angle.Degrees(+38.64337438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146828"},
        {"Hipparcos Number", "HIP 79753"},
        {"Smithsonian Astrophysical Observation", "SAO 65195"},
        {"Wilson Evans Batten Catalogue", "WEB 13496"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.17723599),
        dec: Angle.Degrees(+38.64499381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87705"},
        {"Hipparcos Number", "HIP 49621"},
        {"Geneva Identification System", "GEN# +1.00087705"},
        {"Smithsonian Astrophysical Observation", "SAO 61876"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.90508478),
        dec: Angle.Degrees(+38.64810588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207516"},
        {"Hipparcos Number", "HIP 107664"},
        {"Geneva Identification System", "GEN# +1.00207516"},
        {"Renson", "Renson 57735"},
        {"Smithsonian Astrophysical Observation", "SAO 71722"},
        {"Wilson Evans Batten Catalogue", "WEB 19424"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.12225557),
        dec: Angle.Degrees(+38.64857876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101163"},
        {"Hipparcos Number", "HIP 56805"},
        {"Geneva Identification System", "GEN# +1.00101163"},
        {"Smithsonian Astrophysical Observation", "SAO 62639"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.68317635),
        dec: Angle.Degrees(+38.64950072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81775"},
        {"Hipparcos Number", "HIP 46483"},
        {"Smithsonian Astrophysical Observation", "SAO 61510"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.19857161),
        dec: Angle.Degrees(+38.65009885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 918 AB"},
        {"Henry Draper", "HD 6586"},
        {"Hipparcos Number", "HIP 5249"},
        {"Geneva Identification System", "GEN# +1.00006586J"},
        {"Smithsonian Astrophysical Observation", "SAO 54434"},
        {"Wilson Evans Batten Catalogue", "WEB 1102"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.78815745),
        dec: Angle.Degrees(+38.65048417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7671",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1284 AB"},
        {"Henry Draper", "HD 10033"},
        {"Hipparcos Number", "HIP 7671"},
        {"Smithsonian Astrophysical Observation", "SAO 54863"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.69473067),
        dec: Angle.Degrees(+38.65195475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106886"},
        {"Hipparcos Number", "HIP 59915"},
        {"Geneva Identification System", "GEN# +1.00106886"},
        {"Smithsonian Astrophysical Observation", "SAO 62936"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.35444846),
        dec: Angle.Degrees(+38.65211329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106090"},
        {"Smithsonian Astrophysical Observation", "SAO 71388"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.35677371),
        dec: Angle.Degrees(+38.65288508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77189"},
        {"Hipparcos Number", "HIP 44375"},
        {"Smithsonian Astrophysical Observation", "SAO 61213"},
        {"Wilson Evans Batten Catalogue", "WEB 8507"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.57898773),
        dec: Angle.Degrees(+38.65667281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104997"},
        {"Hipparcos Number", "HIP 58961"},
        {"Geneva Identification System", "GEN# +1.00104997"},
        {"Smithsonian Astrophysical Observation", "SAO 62834"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.34937251),
        dec: Angle.Degrees(+38.65716241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200577"},
        {"Hipparcos Number", "HIP 103894"},
        {"Geneva Identification System", "GEN# +1.00200577"},
        {"Smithsonian Astrophysical Observation", "SAO 70832"},
        {"Wilson Evans Batten Catalogue", "WEB 18922"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.77010794),
        dec: Angle.Degrees(+38.65742938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106593"},
        {"Hipparcos Number", "HIP 59783"},
        {"Geneva Identification System", "GEN# +1.00106593"},
        {"Smithsonian Astrophysical Observation", "SAO 62922"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.87120146),
        dec: Angle.Degrees(+38.65982209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53326"},
        {"Smithsonian Astrophysical Observation", "SAO 62305"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.60919384),
        dec: Angle.Degrees(+38.66017800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76115"},
        {"Smithsonian Astrophysical Observation", "SAO 64770"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.19247467),
        dec: Angle.Degrees(+38.66130189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221293"},
        {"Hipparcos Number", "HIP 116030"},
        {"Geneva Identification System", "GEN# +1.00221293"},
        {"Smithsonian Astrophysical Observation", "SAO 73308"},
        {"Wilson Evans Batten Catalogue", "WEB 20517"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66474266),
        dec: Angle.Degrees(+38.66221205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58882"},
        {"Geneva Identification System", "GEN# +0.03902489"},
        {"Smithsonian Astrophysical Observation", "SAO 62824"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.15700482),
        dec: Angle.Degrees(+38.66454219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135323"},
        {"Hipparcos Number", "HIP 74487"},
        {"Geneva Identification System", "GEN# +1.00135323"},
        {"Smithsonian Astrophysical Observation", "SAO 64564"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.31040530),
        dec: Angle.Degrees(+38.66540770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2932 A"},
        {"Henry Draper", "HD 25184"},
        {"Hipparcos Number", "HIP 18793"},
        {"Smithsonian Astrophysical Observation", "SAO 56902"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.39510505),
        dec: Angle.Degrees(+38.66549199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58497"},
        {"Hipparcos Number", "HIP 36224"},
        {"Geneva Identification System", "GEN# +1.00058497"},
        {"Smithsonian Astrophysical Observation", "SAO 60088"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.89213081),
        dec: Angle.Degrees(+38.66614553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54591"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.58105734),
        dec: Angle.Degrees(+38.66628190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2932 B"},
        {"Henry Draper", "HD 276034"},
        {"Hipparcos Number", "HIP 18789"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.38676193),
        dec: Angle.Degrees(+38.66774010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44791"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.92904020),
        dec: Angle.Degrees(+38.66828852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135077"},
        {"Hipparcos Number", "HIP 74382"},
        {"Smithsonian Astrophysical Observation", "SAO 64551"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.99991375),
        dec: Angle.Degrees(+38.67013757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186506"},
        {"Hipparcos Number", "HIP 97029"},
        {"Smithsonian Astrophysical Observation", "SAO 68751"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.79483942),
        dec: Angle.Degrees(+38.67171285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188284"},
        {"Hipparcos Number", "HIP 97839"},
        {"Smithsonian Astrophysical Observation", "SAO 69021"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.22262194),
        dec: Angle.Degrees(+38.67191101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135076"},
        {"Hipparcos Number", "HIP 74378"},
        {"Smithsonian Astrophysical Observation", "SAO 64550"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.98933630),
        dec: Angle.Degrees(+38.67195505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56482"},
        {"Hipparcos Number", "HIP 35431"},
        {"Geneva Identification System", "GEN# +1.00056482"},
        {"Smithsonian Astrophysical Observation", "SAO 59972"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71885762),
        dec: Angle.Degrees(+38.67357817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23301"},
        {"Hipparcos Number", "HIP 17558"},
        {"Geneva Identification System", "GEN# +1.00023301"},
        {"Smithsonian Astrophysical Observation", "SAO 56685"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.40463454),
        dec: Angle.Degrees(+38.67621890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29605"},
        {"Smithsonian Astrophysical Observation", "SAO 58878"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.58243349),
        dec: Angle.Degrees(+38.67702974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57793"},
        {"Smithsonian Astrophysical Observation", "SAO 62727"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.76286871),
        dec: Angle.Degrees(+38.67705866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215502"},
        {"Hipparcos Number", "HIP 112323"},
        {"Geneva Identification System", "GEN# +1.00215502"},
        {"Renson", "Renson 59536"},
        {"Smithsonian Astrophysical Observation", "SAO 72684"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.26278500),
        dec: Angle.Degrees(+38.67766945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1280"},
        {"Hipparcos Number", "HIP 1366"},
        {"Geneva Identification System", "GEN# +1.00001280"},
        {"Smithsonian Astrophysical Observation", "SAO 53777"},
        {"Wilson Evans Batten Catalogue", "WEB 248"},
    },
    visualMagnitude: 4.61,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27306518),
        dec: Angle.Degrees(+38.68167915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192102"},
        {"Hipparcos Number", "HIP 99513"},
        {"Celescope Catalog", "CEL 4967"},
        {"Geneva Identification System", "GEN# +1.00192102"},
        {"Smithsonian Astrophysical Observation", "SAO 69583"},
        {"Wilson Evans Batten Catalogue", "WEB 17800"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94331695),
        dec: Angle.Degrees(+38.68282504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68272"},
        {"Geneva Identification System", "GEN# +0.03902706"},
        {"Smithsonian Astrophysical Observation", "SAO 63863"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.65170936),
        dec: Angle.Degrees(+38.68319743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12231"},
        {"Hipparcos Number", "HIP 9413"},
        {"Smithsonian Astrophysical Observation", "SAO 55188"},
        {"New General Catalogue", "NGC 752 1608"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.23496194),
        dec: Angle.Degrees(+38.68415070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109839"},
        {"Hipparcos Number", "HIP 61619"},
        {"Geneva Identification System", "GEN# +1.00109839"},
        {"Smithsonian Astrophysical Observation", "SAO 63108"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.41300088),
        dec: Angle.Degrees(+38.68455831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213371"},
        {"Hipparcos Number", "HIP 111084"},
        {"Geneva Identification System", "GEN# +1.00213371"},
        {"Renson", "Renson 59150"},
        {"Smithsonian Astrophysical Observation", "SAO 72411"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.56391605),
        dec: Angle.Degrees(+38.68458903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163011"},
        {"Hipparcos Number", "HIP 87463"},
        {"Smithsonian Astrophysical Observation", "SAO 66408"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.06636073),
        dec: Angle.Degrees(+38.68485992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33089"},
        {"Hipparcos Number", "HIP 24002"},
        {"Geneva Identification System", "GEN# +1.00033089"},
        {"Smithsonian Astrophysical Observation", "SAO 57687"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.40178829),
        dec: Angle.Degrees(+38.68552597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17078 C"},
        {"Hipparcos Number", "HIP 117748"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20123511),
        dec: Angle.Degrees(+38.68633815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70745"},
        {"Smithsonian Astrophysical Observation", "SAO 64156"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.00789195),
        dec: Angle.Degrees(+38.68701160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17078 AB"},
        {"Hipparcos Number", "HIP 117752"},
        {"Smithsonian Astrophysical Observation", "SAO 73578"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20644735),
        dec: Angle.Degrees(+38.68784061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216342"},
        {"Hipparcos Number", "HIP 112884"},
        {"Smithsonian Astrophysical Observation", "SAO 72787"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.89814527),
        dec: Angle.Degrees(+38.68813007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6262"},
        {"Hipparcos Number", "HIP 5002"},
        {"Geneva Identification System", "GEN# +1.00006262"},
        {"Smithsonian Astrophysical Observation", "SAO 54393"},
        {"Wilson Evans Batten Catalogue", "WEB 1014"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.01880512),
        dec: Angle.Degrees(+38.68854162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196119"},
        {"Hipparcos Number", "HIP 101471"},
        {"Celescope Catalog", "CEL 5115"},
        {"Geneva Identification System", "GEN# +1.00196119"},
        {"Smithsonian Astrophysical Observation", "SAO 70204"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47175253),
        dec: Angle.Degrees(+38.68906439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152926"},
        {"Hipparcos Number", "HIP 82743"},
        {"Smithsonian Astrophysical Observation", "SAO 65649"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.67866142),
        dec: Angle.Degrees(+38.69006999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123914"},
        {"Hipparcos Number", "HIP 69166"},
        {"Geneva Identification System", "GEN# +1.00123914"},
        {"Smithsonian Astrophysical Observation", "SAO 63959"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.37139941),
        dec: Angle.Degrees(+38.69101417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98969"},
        {"Hipparcos Number", "HIP 55613"},
        {"Fundamental Katalog 5th Edition", "FK5 5003"},
        {"Geneva Identification System", "GEN# +1.00098969"},
        {"Smithsonian Astrophysical Observation", "SAO 62530"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.90533927),
        dec: Angle.Degrees(+38.69371445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38731"},
        {"Hipparcos Number", "HIP 27525"},
        {"Geneva Identification System", "GEN# +1.00038731"},
        {"Smithsonian Astrophysical Observation", "SAO 58478"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.42308286),
        dec: Angle.Degrees(+38.69735972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37730"},
        {"Smithsonian Astrophysical Observation", "SAO 60306"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.07756439),
        dec: Angle.Degrees(+38.70222802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59977"},
        {"Hipparcos Number", "HIP 36790"},
        {"Smithsonian Astrophysical Observation", "SAO 60186"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.50718994),
        dec: Angle.Degrees(+38.70577879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217543"},
        {"Hipparcos Number", "HIP 113640"},
        {"Geneva Identification System", "GEN# +1.00217543"},
        {"Smithsonian Astrophysical Observation", "SAO 72929"},
        {"Wilson Evans Batten Catalogue", "WEB 20195"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.22812255),
        dec: Angle.Degrees(+38.70786290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203713"},
        {"Hipparcos Number", "HIP 105573"},
        {"Smithsonian Astrophysical Observation", "SAO 71267"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.72789473),
        dec: Angle.Degrees(+38.70848754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43895"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.13321957),
        dec: Angle.Degrees(+38.70939336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12992 A"},
        {"Henry Draper", "HD 187638"},
        {"Hipparcos Number", "HIP 97538"},
        {"Geneva Identification System", "GEN# +1.00187638"},
        {"Smithsonian Astrophysical Observation", "SAO 68909"},
        {"Wilson Evans Batten Catalogue", "WEB 17154"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.36457758),
        dec: Angle.Degrees(+38.71017237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34363"},
        {"Hipparcos Number", "HIP 24770"},
        {"Geneva Identification System", "GEN# +1.00034363"},
        {"Smithsonian Astrophysical Observation", "SAO 57867"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.66790485),
        dec: Angle.Degrees(+38.71055638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180552"},
        {"Hipparcos Number", "HIP 94629"},
        {"Geneva Identification System", "GEN# +1.00180552"},
        {"Smithsonian Astrophysical Observation", "SAO 68043"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.84393842),
        dec: Angle.Degrees(+38.71136411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22537"},
        {"Hipparcos Number", "HIP 17019"},
        {"Smithsonian Astrophysical Observation", "SAO 56601"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.73581850),
        dec: Angle.Degrees(+38.71277768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179070"},
        {"Hipparcos Number", "HIP 94112"},
        {"Smithsonian Astrophysical Observation", "SAO 67891"},
        {"Wilson Evans Batten Catalogue", "WEB 16388"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.36172453),
        dec: Angle.Degrees(+38.71394634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2310"},
        {"Geneva Identification System", "GEN# +6.20030359"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.36659139),
        dec: Angle.Degrees(+38.71502873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20692"},
        {"Hipparcos Number", "HIP 15629"},
        {"Geneva Identification System", "GEN# +1.00020692"},
        {"Smithsonian Astrophysical Observation", "SAO 56369"},
        {"Wilson Evans Batten Catalogue", "WEB 2999"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.32104410),
        dec: Angle.Degrees(+38.71690446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140155"},
        {"Hipparcos Number", "HIP 76791"},
        {"Smithsonian Astrophysical Observation", "SAO 64844"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.18876771),
        dec: Angle.Degrees(+38.71857650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189941"},
        {"Hipparcos Number", "HIP 98537"},
        {"Smithsonian Astrophysical Observation", "SAO 69262"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.26419458),
        dec: Angle.Degrees(+38.72011694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4597 AB"},
        {"Henry Draper", "HD 40669"},
        {"Hipparcos Number", "HIP 28588"},
        {"Geneva Identification System", "GEN# +1.00040669J"},
        {"Smithsonian Astrophysical Observation", "SAO 58671"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.52227499),
        dec: Angle.Degrees(+38.72019949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 313"},
        {"Hipparcos Number", "HIP 640"},
        {"Geneva Identification System", "GEN# +1.00000313"},
        {"Smithsonian Astrophysical Observation", "SAO 53666"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.96245593),
        dec: Angle.Degrees(+38.72179052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39554"},
        {"Smithsonian Astrophysical Observation", "SAO 60545"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.23435041),
        dec: Angle.Degrees(+38.72215062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13014 A"},
        {"Henry Draper", "HD 187849"},
        {"Hipparcos Number", "HIP 97630"},
        {"Geneva Identification System", "GEN# +1.00187849"},
        {"Smithsonian Astrophysical Observation", "SAO 68947"},
        {"Wilson Evans Batten Catalogue", "WEB 17166"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.64161019),
        dec: Angle.Degrees(+38.72216211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138100"},
        {"Hipparcos Number", "HIP 75752"},
        {"Geneva Identification System", "GEN# +1.00138100"},
        {"Smithsonian Astrophysical Observation", "SAO 64721"},
        {"Wilson Evans Batten Catalogue", "WEB 12897"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.13025823),
        dec: Angle.Degrees(+38.72372960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114427"},
        {"Hipparcos Number", "HIP 64244"},
        {"Geneva Identification System", "GEN# +1.00114427"},
        {"Smithsonian Astrophysical Observation", "SAO 63377"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.50549620),
        dec: Angle.Degrees(+38.72375261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111065"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.50558854),
        dec: Angle.Degrees(+38.72524204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75358"},
        {"Smithsonian Astrophysical Observation", "SAO 64683"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.99651719),
        dec: Angle.Degrees(+38.72561780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111939"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11552090),
        dec: Angle.Degrees(+38.72640265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3561 A"},
        {"Henry Draper", "HD 31536"},
        {"Hipparcos Number", "HIP 23110"},
        {"Smithsonian Astrophysical Observation", "SAO 57536"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.59078841),
        dec: Angle.Degrees(+38.72675446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192443"},
        {"Hipparcos Number", "HIP 99653"},
        {"Geneva Identification System", "GEN# +1.00192443"},
        {"Smithsonian Astrophysical Observation", "SAO 69636"},
        {"Wilson Evans Batten Catalogue", "WEB 17865"},
    },
    visualMagnitude: 7.61,
    bvColour: 2.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34856446),
        dec: Angle.Degrees(+38.72901601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201561"},
        {"Hipparcos Number", "HIP 104417"},
        {"Smithsonian Astrophysical Observation", "SAO 70977"},
        {"Wilson Evans Batten Catalogue", "WEB 19007"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.28466500),
        dec: Angle.Degrees(+38.72921201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65345"},
        {"Smithsonian Astrophysical Observation", "SAO 63512"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88989829),
        dec: Angle.Degrees(+38.72993788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142679"},
        {"Hipparcos Number", "HIP 77886"},
        {"Geneva Identification System", "GEN# +1.00142679"},
        {"Smithsonian Astrophysical Observation", "SAO 64969"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.59617367),
        dec: Angle.Degrees(+38.73045516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111298"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.20096053),
        dec: Angle.Degrees(+38.73080330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67827"},
        {"Hipparcos Number", "HIP 40093"},
        {"Fundamental Katalog 5th Edition", "FK5 2635"},
        {"Geneva Identification System", "GEN# +1.00067827"},
        {"Smithsonian Astrophysical Observation", "SAO 60625"},
        {"Wilson Evans Batten Catalogue", "WEB 7824"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.84054540),
        dec: Angle.Degrees(+38.73149889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193576"},
        {"Hipparcos Number", "HIP 100214"},
        {"Geneva Identification System", "GEN# +1.00193576"},
        {"Smithsonian Astrophysical Observation", "SAO 69833"},
        {"Wilson Evans Batten Catalogue", "WEB 18055"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.88510217),
        dec: Angle.Degrees(+38.73166436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16176"},
        {"Hipparcos Number", "HIP 12181"},
        {"Geneva Identification System", "GEN# +1.00016176"},
        {"Smithsonian Astrophysical Observation", "SAO 55705"},
        {"Wilson Evans Batten Catalogue", "WEB 2500"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.23782977),
        dec: Angle.Degrees(+38.73398283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14636 B"},
        {"Henry Draper", "HD 201092"},
        {"Hipparcos Number", "HIP 104217"},
        {"Cincinnati Publication", "Ci 20 1260"},
        {"Geneva Identification System", "GEN# +1.00201092"},
        {"Wilson Evans Batten Catalogue", "WEB 18981"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71746843),
        dec: Angle.Degrees(+38.73441392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4107.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3143.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15865"},
        {"Hipparcos Number", "HIP 11947"},
        {"Smithsonian Astrophysical Observation", "SAO 55662"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.53457865),
        dec: Angle.Degrees(+38.73504956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190088"},
        {"Hipparcos Number", "HIP 98612"},
        {"Celescope Catalog", "CEL 4917"},
        {"Geneva Identification System", "GEN# +1.00190088"},
        {"Smithsonian Astrophysical Observation", "SAO 69284"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43940259),
        dec: Angle.Degrees(+38.73526121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106557"},
        {"Hipparcos Number", "HIP 59766"},
        {"Geneva Identification System", "GEN# +1.00106557"},
        {"Smithsonian Astrophysical Observation", "SAO 62918"},
        {"Wilson Evans Batten Catalogue", "WEB 10619"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.83624638),
        dec: Angle.Degrees(+38.73585657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155480"},
        {"Hipparcos Number", "HIP 83989"},
        {"Geneva Identification System", "GEN# +1.00155480"},
        {"Smithsonian Astrophysical Observation", "SAO 65843"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54295552),
        dec: Angle.Degrees(+38.73631515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28518"},
        {"Hipparcos Number", "HIP 21111"},
        {"Smithsonian Astrophysical Observation", "SAO 57280"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.86580722),
        dec: Angle.Degrees(+38.73663882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38686"},
        {"Hipparcos Number", "HIP 27497"},
        {"Geneva Identification System", "GEN# +1.00038686"},
        {"Smithsonian Astrophysical Observation", "SAO 58472"},
        {"Wilson Evans Batten Catalogue", "WEB 5400"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.34093765),
        dec: Angle.Degrees(+38.73834460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222031"},
        {"Hipparcos Number", "HIP 116535"},
        {"Fundamental Katalog 5th Edition", "FK5 6091"},
        {"Geneva Identification System", "GEN# +1.00222031"},
        {"Smithsonian Astrophysical Observation", "SAO 73375"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.26294091),
        dec: Angle.Degrees(+38.73856211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4754"},
        {"Hipparcos Number", "HIP 3900"},
        {"Smithsonian Astrophysical Observation", "SAO 54180"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.50442809),
        dec: Angle.Degrees(+38.73901723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114146"},
        {"Hipparcos Number", "HIP 64104"},
        {"Geneva Identification System", "GEN# +1.00114146J"},
        {"Smithsonian Astrophysical Observation", "SAO 63362"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.05658245),
        dec: Angle.Degrees(+38.73917218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90163",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11320 A"},
        {"Henry Draper", "HD 169646"},
        {"Hipparcos Number", "HIP 90163"},
        {"Smithsonian Astrophysical Observation", "SAO 66936"},
        {"Wilson Evans Batten Catalogue", "WEB 15417"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98864382),
        dec: Angle.Degrees(+38.73917674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72734"},
        {"Smithsonian Astrophysical Observation", "SAO 64370"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.05792706),
        dec: Angle.Degrees(+38.74092010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104214",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14636 A"},
        {"Henry Draper", "HD 201091"},
        {"Hipparcos Number", "HIP 104214"},
        {"Cincinnati Publication", "Ci 20 1259"},
        {"Geneva Identification System", "GEN# +1.00201091A"},
        {"Smithsonian Astrophysical Observation", "SAO 70919"},
        {"Wilson Evans Batten Catalogue", "WEB 18980"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71181258),
        dec: Angle.Degrees(+38.74149446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4155.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3258.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77443"},
        {"Hipparcos Number", "HIP 44481"},
        {"Geneva Identification System", "GEN# +1.00077443"},
        {"Smithsonian Astrophysical Observation", "SAO 61226"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.94633412),
        dec: Angle.Degrees(+38.74217468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177877"},
        {"Hipparcos Number", "HIP 93700"},
        {"Celescope Catalog", "CEL 4696"},
        {"Geneva Identification System", "GEN# +1.00177877"},
        {"Smithsonian Astrophysical Observation", "SAO 67785"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.20406018),
        dec: Angle.Degrees(+38.74264074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109436"},
        {"Smithsonian Astrophysical Observation", "SAO 72087"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.56729230),
        dec: Angle.Degrees(+38.74391880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216429"},
        {"Hipparcos Number", "HIP 112928"},
        {"Geneva Identification System", "GEN# +1.00216429"},
        {"Renson", "Renson 59780"},
        {"Smithsonian Astrophysical Observation", "SAO 72799"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.06165917),
        dec: Angle.Degrees(+38.74573796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85555"},
        {"Smithsonian Astrophysical Observation", "SAO 66080"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.26000402),
        dec: Angle.Degrees(+38.74574209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67866"},
        {"Geneva Identification System", "GEN# +0.03902695"},
        {"Smithsonian Astrophysical Observation", "SAO 63817"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.50803897),
        dec: Angle.Degrees(+38.74809581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214712"},
        {"Hipparcos Number", "HIP 111866"},
        {"Celescope Catalog", "CEL 5505"},
        {"Geneva Identification System", "GEN# +1.00214712"},
        {"Smithsonian Astrophysical Observation", "SAO 72580"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.88754245),
        dec: Angle.Degrees(+38.74848459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10821"},
        {"Hipparcos Number", "HIP 8292"},
        {"Geneva Identification System", "GEN# +1.00010821"},
        {"Smithsonian Astrophysical Observation", "SAO 54974"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.71074689),
        dec: Angle.Degrees(+38.74884738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39250"},
        {"Smithsonian Astrophysical Observation", "SAO 60517"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.40499044),
        dec: Angle.Degrees(+38.74946438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29912"},
        {"Hipparcos Number", "HIP 22049"},
        {"Geneva Identification System", "GEN# +1.00029912"},
        {"Smithsonian Astrophysical Observation", "SAO 57398"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.13684171),
        dec: Angle.Degrees(+38.74950649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38967"},
        {"Smithsonian Astrophysical Observation", "SAO 60485"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.59781948),
        dec: Angle.Degrees(+38.75118653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1831"},
        {"Hipparcos Number", "HIP 1809"},
        {"Geneva Identification System", "GEN# +1.00001831"},
        {"Smithsonian Astrophysical Observation", "SAO 53849"},
        {"Wilson Evans Batten Catalogue", "WEB 324"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.73901787),
        dec: Angle.Degrees(+38.75427442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8246 A"},
        {"Henry Draper", "HD 101108"},
        {"Hipparcos Number", "HIP 56768"},
        {"Geneva Identification System", "GEN# +1.00101108"},
        {"Smithsonian Astrophysical Observation", "SAO 62634"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.58071205),
        dec: Angle.Degrees(+38.75467304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31417"},
        {"Smithsonian Astrophysical Observation", "SAO 59253"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76546724),
        dec: Angle.Degrees(+38.75520709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103520"},
        {"Hipparcos Number", "HIP 58129"},
        {"Geneva Identification System", "GEN# +1.00103520"},
        {"Smithsonian Astrophysical Observation", "SAO 62756"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.84391232),
        dec: Angle.Degrees(+38.75696671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106248"},
        {"Smithsonian Astrophysical Observation", "SAO 71422"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.79824211),
        dec: Angle.Degrees(+38.75846419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197074"},
        {"Hipparcos Number", "HIP 101970"},
        {"Smithsonian Astrophysical Observation", "SAO 70344"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.97605346),
        dec: Angle.Degrees(+38.75850595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52034"},
        {"Smithsonian Astrophysical Observation", "SAO 62166"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.47437688),
        dec: Angle.Degrees(+38.75877688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1149"},
        {"Hipparcos Number", "HIP 1273"},
        {"Geneva Identification System", "GEN# +1.00001149"},
        {"Smithsonian Astrophysical Observation", "SAO 53764"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.99381520),
        dec: Angle.Degrees(+38.75896447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203663"},
        {"Hipparcos Number", "HIP 105543"},
        {"Smithsonian Astrophysical Observation", "SAO 71260"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.63908418),
        dec: Angle.Degrees(+38.76152012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184603"},
        {"Hipparcos Number", "HIP 96195"},
        {"Geneva Identification System", "GEN# +1.00184603"},
        {"Smithsonian Astrophysical Observation", "SAO 68499"},
        {"Wilson Evans Batten Catalogue", "WEB 16858"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.40179271),
        dec: Angle.Degrees(+38.76191852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88037"},
        {"Smithsonian Astrophysical Observation", "SAO 66538"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.72948381),
        dec: Angle.Degrees(+38.76322150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105823"},
        {"Smithsonian Astrophysical Observation", "SAO 71331"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.49346956),
        dec: Angle.Degrees(+38.76479150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182806"},
        {"Hipparcos Number", "HIP 95423"},
        {"Geneva Identification System", "GEN# +1.00182806"},
        {"Smithsonian Astrophysical Observation", "SAO 68277"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17055906),
        dec: Angle.Degrees(+38.76516433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192422"},
        {"Hipparcos Number", "HIP 99649"},
        {"Celescope Catalog", "CEL 4977"},
        {"Geneva Identification System", "GEN# +1.00192422"},
        {"Smithsonian Astrophysical Observation", "SAO 69635"},
        {"Wilson Evans Batten Catalogue", "WEB 17864"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34368058),
        dec: Angle.Degrees(+38.76542723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202420"},
        {"Hipparcos Number", "HIP 104862"},
        {"Smithsonian Astrophysical Observation", "SAO 71117"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.63099445),
        dec: Angle.Degrees(+38.76683422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9223"},
        {"Hipparcos Number", "HIP 7095"},
        {"Smithsonian Astrophysical Observation", "SAO 54754"},
        {"Wilson Evans Batten Catalogue", "WEB 1530"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.85959338),
        dec: Angle.Degrees(+38.76713345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125538"},
        {"Hipparcos Number", "HIP 69955"},
        {"Geneva Identification System", "GEN# +1.00125538"},
        {"Smithsonian Astrophysical Observation", "SAO 64064"},
        {"Wilson Evans Batten Catalogue", "WEB 12165"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.73203593),
        dec: Angle.Degrees(+38.76736124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106003"},
        {"Hipparcos Number", "HIP 59471"},
        {"Geneva Identification System", "GEN# +1.00106003"},
        {"Smithsonian Astrophysical Observation", "SAO 62889"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.97069909),
        dec: Angle.Degrees(+38.76781405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71800"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.30087694),
        dec: Angle.Degrees(+38.76832185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170595"},
        {"Hipparcos Number", "HIP 90550"},
        {"Smithsonian Astrophysical Observation", "SAO 67010"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.14603529),
        dec: Angle.Degrees(+38.76862626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215211"},
        {"Hipparcos Number", "HIP 112167"},
        {"Celescope Catalog", "CEL 5515"},
        {"Geneva Identification System", "GEN# +1.00215211"},
        {"Smithsonian Astrophysical Observation", "SAO 72654"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76396222),
        dec: Angle.Degrees(+38.76864757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280183"},
        {"Hipparcos Number", "HIP 22760"},
        {"Smithsonian Astrophysical Observation", "SAO 57484"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.45451353),
        dec: Angle.Degrees(+38.77201686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188326"},
        {"Hipparcos Number", "HIP 97846"},
        {"Cincinnati Publication", "Ci 18 2596"},
        {"Geneva Identification System", "GEN# +1.00188326A"},
        {"Smithsonian Astrophysical Observation", "SAO 69027"},
        {"Wilson Evans Batten Catalogue", "WEB 17213"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.25655645),
        dec: Angle.Degrees(+38.77254410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 342.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167370"},
        {"Hipparcos Number", "HIP 89279"},
        {"Fundamental Katalog 5th Edition", "FK5 3451"},
        {"Geneva Identification System", "GEN# +1.00167370"},
        {"Smithsonian Astrophysical Observation", "SAO 66765"},
        {"Wilson Evans Batten Catalogue", "WEB 15177"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.27009912),
        dec: Angle.Degrees(+38.77347463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205716"},
        {"Hipparcos Number", "HIP 106657"},
        {"Smithsonian Astrophysical Observation", "SAO 71507"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.05348593),
        dec: Angle.Degrees(+38.77495344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59469"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.96559879),
        dec: Angle.Degrees(+38.77496307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185562"},
        {"Hipparcos Number", "HIP 96585"},
        {"Smithsonian Astrophysical Observation", "SAO 68605"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.52010931),
        dec: Angle.Degrees(+38.77507050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227048"},
        {"Hipparcos Number", "HIP 98445"},
        {"Renson", "Renson 52620"},
        {"Smithsonian Astrophysical Observation", "SAO 69239"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.04330797),
        dec: Angle.Degrees(+38.77766567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2312"},
        {"Hipparcos Number", "HIP 2145"},
        {"Smithsonian Astrophysical Observation", "SAO 53904"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.78291010),
        dec: Angle.Degrees(+38.77808360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6658"},
        {"Smithsonian Astrophysical Observation", "SAO 54682"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.35425927),
        dec: Angle.Degrees(+38.77808983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32304"},
        {"Smithsonian Astrophysical Observation", "SAO 59432"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.17161391),
        dec: Angle.Degrees(+38.77817656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7033"},
        {"Smithsonian Astrophysical Observation", "SAO 54745"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.65237020),
        dec: Angle.Degrees(+38.77938158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201839"},
        {"Hipparcos Number", "HIP 104566"},
        {"Smithsonian Astrophysical Observation", "SAO 71030"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.73796209),
        dec: Angle.Degrees(+38.77976012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197140"},
        {"Hipparcos Number", "HIP 102016"},
        {"Geneva Identification System", "GEN# +1.00197140"},
        {"Smithsonian Astrophysical Observation", "SAO 70349"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.08663706),
        dec: Angle.Degrees(+38.78021730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12145 ABC"},
        {"Henry Draper", "HD 179484"},
        {"Hipparcos Number", "HIP 94252"},
        {"Cincinnati Publication", "Ci 18 2507"},
        {"Geneva Identification System", "GEN# +1.00179484J"},
        {"Smithsonian Astrophysical Observation", "SAO 67936"},
        {"Wilson Evans Batten Catalogue", "WEB 16416"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.78361463),
        dec: Angle.Degrees(+38.78035706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113113"},
        {"Hipparcos Number", "HIP 63516"},
        {"Smithsonian Astrophysical Observation", "SAO 63299"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.23795173),
        dec: Angle.Degrees(+38.78228360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108974"},
        {"Hipparcos Number", "HIP 61085"},
        {"Smithsonian Astrophysical Observation", "SAO 63045"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.79927484),
        dec: Angle.Degrees(+38.78276996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29452"},
        {"Smithsonian Astrophysical Observation", "SAO 58849"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.09018348),
        dec: Angle.Degrees(+38.78284698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91262",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Vega"},
        {"Aitken", "ADS 11510 A"},
        {"Henry Draper", "HD 172167"},
        {"Hipparcos Number", "HIP 91262"},
        {"Celescope Catalog", "CEL 4636"},
        {"Fundamental Katalog 5th Edition", "FK5 699"},
        {"Geneva Identification System", "GEN# +1.00172167"},
        {"Smithsonian Astrophysical Observation", "SAO 67174"},
        {"Wilson Evans Batten Catalogue", "WEB 15681"},
    },
    visualMagnitude: 0.03,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.23410832),
        dec: Angle.Degrees(+38.78299311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 287.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33479"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.39481071),
        dec: Angle.Degrees(+38.78304287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219016"},
        {"Hipparcos Number", "HIP 114554"},
        {"Smithsonian Astrophysical Observation", "SAO 73083"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.06270565),
        dec: Angle.Degrees(+38.78308209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158097"},
        {"Hipparcos Number", "HIP 85280"},
        {"Smithsonian Astrophysical Observation", "SAO 66036"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.38072470),
        dec: Angle.Degrees(+38.78385865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36423"},
        {"Hipparcos Number", "HIP 26051"},
        {"Celescope Catalog", "CEL 774"},
        {"Geneva Identification System", "GEN# +1.00036423"},
        {"Smithsonian Astrophysical Observation", "SAO 58176"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36184091),
        dec: Angle.Degrees(+38.78394223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225259"},
        {"Hipparcos Number", "HIP 387"},
        {"Smithsonian Astrophysical Observation", "SAO 53621"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.20814095),
        dec: Angle.Degrees(+38.78622411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186199"},
        {"Hipparcos Number", "HIP 96864"},
        {"Geneva Identification System", "GEN# +1.00186199"},
        {"Smithsonian Astrophysical Observation", "SAO 68699"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.34163650),
        dec: Angle.Degrees(+38.78682611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46705"},
        {"Hipparcos Number", "HIP 31596"},
        {"Smithsonian Astrophysical Observation", "SAO 59284"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.18601737),
        dec: Angle.Degrees(+38.78753279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31977"},
        {"Hipparcos Number", "HIP 23393"},
        {"Geneva Identification System", "GEN# +1.00031977"},
        {"Smithsonian Astrophysical Observation", "SAO 57580"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.42769967),
        dec: Angle.Degrees(+38.78917919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60067"},
        {"Smithsonian Astrophysical Observation", "SAO 62946"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.76164071),
        dec: Angle.Degrees(+38.78918307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8956 A"},
        {"Henry Draper", "HD 118156"},
        {"Hipparcos Number", "HIP 66223"},
        {"Geneva Identification System", "GEN# +1.00118156"},
        {"Smithsonian Astrophysical Observation", "SAO 63616"},
        {"Wilson Evans Batten Catalogue", "WEB 11700"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.59104226),
        dec: Angle.Degrees(+38.78920930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181986"},
        {"Hipparcos Number", "HIP 95115"},
        {"Geneva Identification System", "GEN# +1.00181986"},
        {"Smithsonian Astrophysical Observation", "SAO 68180"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.24645619),
        dec: Angle.Degrees(+38.78987836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135926"},
        {"Hipparcos Number", "HIP 74738"},
        {"Geneva Identification System", "GEN# +1.00135926"},
        {"Smithsonian Astrophysical Observation", "SAO 64605"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.11462543),
        dec: Angle.Degrees(+38.79026791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102799"},
        {"Hipparcos Number", "HIP 57716"},
        {"Smithsonian Astrophysical Observation", "SAO 62721"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.54720222),
        dec: Angle.Degrees(+38.79046743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53539"},
        {"Smithsonian Astrophysical Observation", "SAO 62326"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29574837),
        dec: Angle.Degrees(+38.79116713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147265"},
        {"Hipparcos Number", "HIP 79956"},
        {"Geneva Identification System", "GEN# +1.00147265"},
        {"Smithsonian Astrophysical Observation", "SAO 65227"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.80477941),
        dec: Angle.Degrees(+38.79366225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125642"},
        {"Hipparcos Number", "HIP 70029"},
        {"Geneva Identification System", "GEN# +1.00125642"},
        {"Smithsonian Astrophysical Observation", "SAO 64072"},
        {"Wilson Evans Batten Catalogue", "WEB 12179"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.94882573),
        dec: Angle.Degrees(+38.79407655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61124"},
        {"Hipparcos Number", "HIP 37291"},
        {"Smithsonian Astrophysical Observation", "SAO 60248"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.85415598),
        dec: Angle.Degrees(+38.79514574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209024"},
        {"Hipparcos Number", "HIP 108555"},
        {"Smithsonian Astrophysical Observation", "SAO 71914"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84861223),
        dec: Angle.Degrees(+38.79641315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25476"},
        {"Hipparcos Number", "HIP 19012"},
        {"Smithsonian Astrophysical Observation", "SAO 56942"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.09784279),
        dec: Angle.Degrees(+38.79668743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279853"},
        {"Hipparcos Number", "HIP 20962"},
        {"Geneva Identification System", "GEN# +1.00279853"},
        {"Smithsonian Astrophysical Observation", "SAO 57255"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.42309641),
        dec: Angle.Degrees(+38.79717391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119767"},
        {"Hipparcos Number", "HIP 67041"},
        {"Smithsonian Astrophysical Observation", "SAO 63716"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.08500812),
        dec: Angle.Degrees(+38.79779173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176132"},
        {"Hipparcos Number", "HIP 93034"},
        {"Smithsonian Astrophysical Observation", "SAO 67620"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27653910),
        dec: Angle.Degrees(+38.79847840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44605"},
        {"Cincinnati Publication", "Ci 20 508"},
        {"Geneva Identification System", "GEN# +9.80115049"},
        {"Wilson Evans Batten Catalogue", "WEB 8536"},
    },
    visualMagnitude: 11.60,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.31949264),
        dec: Angle.Degrees(+38.79963748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -466.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69311"},
        {"Hipparcos Number", "HIP 40654"},
        {"Geneva Identification System", "GEN# +1.00069311"},
        {"Smithsonian Astrophysical Observation", "SAO 60707"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.48087187),
        dec: Angle.Degrees(+38.80084826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18402"},
        {"Hipparcos Number", "HIP 13880"},
        {"Geneva Identification System", "GEN# +1.00018402"},
        {"Smithsonian Astrophysical Observation", "SAO 56049"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69490639),
        dec: Angle.Degrees(+38.80165715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12578 P"},
        {"Hipparcos Number", "HIP 96074"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00561497),
        dec: Angle.Degrees(+38.80239238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22044"},
        {"Hipparcos Number", "HIP 16692"},
        {"Geneva Identification System", "GEN# +1.00022044"},
        {"Smithsonian Astrophysical Observation", "SAO 56554"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.68710590),
        dec: Angle.Degrees(+38.80574066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198975"},
        {"Hipparcos Number", "HIP 103051"},
        {"Smithsonian Astrophysical Observation", "SAO 70620"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18031429),
        dec: Angle.Degrees(+38.80575407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47313"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.61983903),
        dec: Angle.Degrees(+38.80635201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203155"},
        {"Hipparcos Number", "HIP 105264"},
        {"Geneva Identification System", "GEN# +1.00203155"},
        {"Smithsonian Astrophysical Observation", "SAO 71202"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.83256815),
        dec: Angle.Degrees(+38.80658378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6946 AB"},
        {"Henry Draper", "HD 74073"},
        {"Hipparcos Number", "HIP 42798"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80452680),
        dec: Angle.Degrees(+38.80869934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96073",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12578 AB"},
        {"Hipparcos Number", "HIP 96073"},
        {"Smithsonian Astrophysical Observation", "SAO 68455"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)32, 01.0200),
        dec: Angle.DegreesMinutesSeconds((int)+38, (int)48, 34.400)
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
    primaryId: "HIP 55007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55007"},
        {"Smithsonian Astrophysical Observation", "SAO 62467"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.93829738),
        dec: Angle.Degrees(+38.80961108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3283 AB"},
        {"Henry Draper", "HD 28619"},
        {"Hipparcos Number", "HIP 21178"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.10594076),
        dec: Angle.Degrees(+38.80997142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10382 AB"},
        {"Hipparcos Number", "HIP 83968"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.46001805),
        dec: Angle.Degrees(+38.81087259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156891"},
        {"Hipparcos Number", "HIP 84656"},
        {"Fundamental Katalog 5th Edition", "FK5 3373"},
        {"Geneva Identification System", "GEN# +1.00156891"},
        {"Smithsonian Astrophysical Observation", "SAO 65930"},
        {"Wilson Evans Batten Catalogue", "WEB 14296"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.59700051),
        dec: Angle.Degrees(+38.81121445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76260"},
        {"Hipparcos Number", "HIP 43881"},
        {"Geneva Identification System", "GEN# +1.00076260"},
        {"Smithsonian Astrophysical Observation", "SAO 61141"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.09367329),
        dec: Angle.Degrees(+38.81179346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95549",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12446 AB"},
        {"Henry Draper", "HD 183078"},
        {"Hipparcos Number", "HIP 95549"},
        {"Smithsonian Astrophysical Observation", "SAO 68302"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52476149),
        dec: Angle.Degrees(+38.81364671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108231",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15454 AB"},
        {"Henry Draper", "HD 208490"},
        {"Hipparcos Number", "HIP 108231"},
        {"Smithsonian Astrophysical Observation", "SAO 71845"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.89129078),
        dec: Angle.Degrees(+38.81660997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214978"},
        {"Hipparcos Number", "HIP 112018"},
        {"Smithsonian Astrophysical Observation", "SAO 72624"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.34969738),
        dec: Angle.Degrees(+38.81755071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192041"},
        {"Hipparcos Number", "HIP 99486"},
        {"Geneva Identification System", "GEN# +1.00192041"},
        {"Smithsonian Astrophysical Observation", "SAO 69578"},
        {"Wilson Evans Batten Catalogue", "WEB 17789"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.85712403),
        dec: Angle.Degrees(+38.81757791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7445"},
        {"Hipparcos Number", "HIP 5864"},
        {"Geneva Identification System", "GEN# +1.00007445"},
        {"Smithsonian Astrophysical Observation", "SAO 54551"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.80093417),
        dec: Angle.Degrees(+38.81970379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124656"},
        {"Hipparcos Number", "HIP 69520"},
        {"Smithsonian Astrophysical Observation", "SAO 64007"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.46879597),
        dec: Angle.Degrees(+38.81985694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2910 AB"},
        {"Henry Draper", "HD 24982"},
        {"Hipparcos Number", "HIP 18657"},
        {"Geneva Identification System", "GEN# +1.00024982J"},
        {"Smithsonian Astrophysical Observation", "SAO 56866"},
        {"Wilson Evans Batten Catalogue", "WEB 3593"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.91659291),
        dec: Angle.Degrees(+38.82038884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163113"},
        {"Hipparcos Number", "HIP 87504"},
        {"Geneva Identification System", "GEN# +1.00163113"},
        {"Smithsonian Astrophysical Observation", "SAO 66421"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.17658309),
        dec: Angle.Degrees(+38.82064054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6401 AB"},
        {"Henry Draper", "HD 63587"},
        {"Hipparcos Number", "HIP 38353"},
        {"Smithsonian Astrophysical Observation", "SAO 60385"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.82920213),
        dec: Angle.Degrees(+38.82149923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141971"},
        {"Hipparcos Number", "HIP 77583"},
        {"Smithsonian Astrophysical Observation", "SAO 64939"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.60214571),
        dec: Angle.Degrees(+38.82161492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188256"},
        {"Hipparcos Number", "HIP 97822"},
        {"Geneva Identification System", "GEN# +1.00188256"},
        {"Smithsonian Astrophysical Observation", "SAO 69015"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.17314866),
        dec: Angle.Degrees(+38.82170405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113301"},
        {"Hipparcos Number", "HIP 63620"},
        {"Geneva Identification System", "GEN# +1.00113301"},
        {"Smithsonian Astrophysical Observation", "SAO 63311"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.58736139),
        dec: Angle.Degrees(+38.82275050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197998"},
        {"Hipparcos Number", "HIP 102481"},
        {"Geneva Identification System", "GEN# +1.00197998"},
        {"Smithsonian Astrophysical Observation", "SAO 70473"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.50858010),
        dec: Angle.Degrees(+38.82281115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200031"},
        {"Hipparcos Number", "HIP 103624"},
        {"Geneva Identification System", "GEN# +1.00200031"},
        {"Smithsonian Astrophysical Observation", "SAO 70770"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.92876576),
        dec: Angle.Degrees(+38.82292141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212732"},
        {"Hipparcos Number", "HIP 110700"},
        {"Smithsonian Astrophysical Observation", "SAO 72327"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.43205193),
        dec: Angle.Degrees(+38.82400518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22885"},
        {"Hipparcos Number", "HIP 17279"},
        {"Smithsonian Astrophysical Observation", "SAO 56639"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50207271),
        dec: Angle.Degrees(+38.82415796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104552"},
        {"Smithsonian Astrophysical Observation", "SAO 71022"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.68052429),
        dec: Angle.Degrees(+38.82424666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49405"},
        {"Hipparcos Number", "HIP 32784"},
        {"Geneva Identification System", "GEN# +1.00049405"},
        {"Smithsonian Astrophysical Observation", "SAO 59524"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.52847285),
        dec: Angle.Degrees(+38.82641155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6858"},
        {"Hipparcos Number", "HIP 5449"},
        {"Geneva Identification System", "GEN# +1.00006858"},
        {"Smithsonian Astrophysical Observation", "SAO 54472"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.43835787),
        dec: Angle.Degrees(+38.82787212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8421 AB"},
        {"Hipparcos Number", "HIP 59028"},
        {"Geneva Identification System", "GEN# +0.03902493J"},
        {"Smithsonian Astrophysical Observation", "SAO 62837"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.53603024),
        dec: Angle.Degrees(+38.82860076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145049"},
        {"Hipparcos Number", "HIP 78982"},
        {"Smithsonian Astrophysical Observation", "SAO 65093"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.83735459),
        dec: Angle.Degrees(+38.82949199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124320"},
        {"Hipparcos Number", "HIP 69366"},
        {"Geneva Identification System", "GEN# +1.00124320"},
        {"Smithsonian Astrophysical Observation", "SAO 63984"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.98881323),
        dec: Angle.Degrees(+38.83118571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196091"},
        {"Hipparcos Number", "HIP 101457"},
        {"Smithsonian Astrophysical Observation", "SAO 70199"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.42863032),
        dec: Angle.Degrees(+38.83467257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208076"},
        {"Hipparcos Number", "HIP 107997"},
        {"Geneva Identification System", "GEN# +1.00208076"},
        {"Smithsonian Astrophysical Observation", "SAO 71793"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.20028835),
        dec: Angle.Degrees(+38.83555068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11236"},
        {"Hipparcos Number", "HIP 8628"},
        {"Geneva Identification System", "GEN# +1.00011236"},
        {"Smithsonian Astrophysical Observation", "SAO 55032"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.82407867),
        dec: Angle.Degrees(+38.83562387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119424"},
        {"Hipparcos Number", "HIP 66877"},
        {"Smithsonian Astrophysical Observation", "SAO 63699"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59545070),
        dec: Angle.Degrees(+38.83737687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62158"},
        {"Hipparcos Number", "HIP 37707"},
        {"Smithsonian Astrophysical Observation", "SAO 60304"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.03953798),
        dec: Angle.Degrees(+38.83786041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157254"},
        {"Hipparcos Number", "HIP 84849"},
        {"Smithsonian Astrophysical Observation", "SAO 65964"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.12245377),
        dec: Angle.Degrees(+38.83862918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38950"},
        {"Smithsonian Astrophysical Observation", "SAO 60479"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.53096826),
        dec: Angle.Degrees(+38.83984968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24843"},
        {"Hipparcos Number", "HIP 18565"},
        {"Geneva Identification System", "GEN# +1.00024843"},
        {"Smithsonian Astrophysical Observation", "SAO 56849"},
        {"Wilson Evans Batten Catalogue", "WEB 3581"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.62139176),
        dec: Angle.Degrees(+38.84034955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14354",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gorgonea Tertia"},
        {"Henry Draper", "HD 19058"},
        {"Hipparcos Number", "HIP 14354"},
        {"Fundamental Katalog 5th Edition", "FK5 109"},
        {"Geneva Identification System", "GEN# +1.00019058"},
        {"Smithsonian Astrophysical Observation", "SAO 56138"},
        {"Wilson Evans Batten Catalogue", "WEB 2804"},
    },
    visualMagnitude: 3.32,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.29373754),
        dec: Angle.Degrees(+38.84053298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10094"},
        {"Hipparcos Number", "HIP 7727"},
        {"Geneva Identification System", "GEN# +1.00010094"},
        {"Smithsonian Astrophysical Observation", "SAO 54876"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.87172082),
        dec: Angle.Degrees(+38.84106173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1864 AB"},
        {"Henry Draper", "HD 15218"},
        {"Hipparcos Number", "HIP 11485"},
        {"Smithsonian Astrophysical Observation", "SAO 55578"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04144079),
        dec: Angle.Degrees(+38.84113457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132877"},
        {"Hipparcos Number", "HIP 73422"},
        {"Geneva Identification System", "GEN# +1.00132877"},
        {"Smithsonian Astrophysical Observation", "SAO 64459"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.07357116),
        dec: Angle.Degrees(+38.84162677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29582"},
        {"Geneva Identification System", "GEN# +9.80101026"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.50269423),
        dec: Angle.Degrees(+38.84170715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148528"},
        {"Hipparcos Number", "HIP 80568"},
        {"Geneva Identification System", "GEN# +1.00148528"},
        {"Smithsonian Astrophysical Observation", "SAO 65310"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.75595280),
        dec: Angle.Degrees(+38.84316034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2923"},
        {"Hipparcos Number", "HIP 2576"},
        {"Geneva Identification System", "GEN# +1.00002923"},
        {"Renson", "Renson 740"},
        {"Smithsonian Astrophysical Observation", "SAO 53974"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.18005439),
        dec: Angle.Degrees(+38.84382562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191138"},
        {"Hipparcos Number", "HIP 99084"},
        {"Geneva Identification System", "GEN# +1.00191138"},
        {"Smithsonian Astrophysical Observation", "SAO 69435"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.73208816),
        dec: Angle.Degrees(+38.84416708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9550"},
        {"Hipparcos Number", "HIP 7331"},
        {"Geneva Identification System", "GEN# +1.00009550"},
        {"Smithsonian Astrophysical Observation", "SAO 54790"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.59934997),
        dec: Angle.Degrees(+38.84572291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43076"},
        {"Hipparcos Number", "HIP 29774"},
        {"Smithsonian Astrophysical Observation", "SAO 58916"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.03755137),
        dec: Angle.Degrees(+38.84895317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103331"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.01316504),
        dec: Angle.Degrees(+38.84899168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 305.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141206"},
        {"Hipparcos Number", "HIP 77260"},
        {"Smithsonian Astrophysical Observation", "SAO 64894"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61357638),
        dec: Angle.Degrees(+38.85028166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31377"},
        {"Smithsonian Astrophysical Observation", "SAO 59243"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68381012),
        dec: Angle.Degrees(+38.85501755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62047"},
        {"Smithsonian Astrophysical Observation", "SAO 63153"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76786589),
        dec: Angle.Degrees(+38.85581256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92767"},
        {"Smithsonian Astrophysical Observation", "SAO 67551"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55508338),
        dec: Angle.Degrees(+38.85664651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211376"},
        {"Hipparcos Number", "HIP 109928"},
        {"Geneva Identification System", "GEN# +1.00211376"},
        {"Smithsonian Astrophysical Observation", "SAO 72190"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.97598157),
        dec: Angle.Degrees(+38.85701340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100360"},
        {"Hipparcos Number", "HIP 56362"},
        {"Geneva Identification System", "GEN# +1.00100360"},
        {"Smithsonian Astrophysical Observation", "SAO 62601"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.30545367),
        dec: Angle.Degrees(+38.85773669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11472"},
        {"Smithsonian Astrophysical Observation", "SAO 55573"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.99839955),
        dec: Angle.Degrees(+38.85879410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17157 A"},
        {"Henry Draper", "HD 224699"},
        {"Hipparcos Number", "HIP 3"},
        {"Smithsonian Astrophysical Observation", "SAO 73664"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.00500795),
        dec: Angle.Degrees(+38.85928608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127335"},
        {"Hipparcos Number", "HIP 70885"},
        {"Geneva Identification System", "GEN# +1.00127335"},
        {"Smithsonian Astrophysical Observation", "SAO 64180"},
        {"Wilson Evans Batten Catalogue", "WEB 12274"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.43856780),
        dec: Angle.Degrees(+38.86133909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194790"},
        {"Hipparcos Number", "HIP 100790"},
        {"Geneva Identification System", "GEN# +1.00194790"},
        {"Smithsonian Astrophysical Observation", "SAO 70020"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.54218033),
        dec: Angle.Degrees(+38.86142474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9849"},
        {"Smithsonian Astrophysical Observation", "SAO 55270"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67516817),
        dec: Angle.Degrees(+38.86144354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2153"},
        {"Hipparcos Number", "HIP 2033"},
        {"Smithsonian Astrophysical Observation", "SAO 53885"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.45491591),
        dec: Angle.Degrees(+38.86291779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89195"},
        {"Hipparcos Number", "HIP 50465"},
        {"Smithsonian Astrophysical Observation", "SAO 61975"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.55578086),
        dec: Angle.Degrees(+38.86411357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100311"},
        {"Hipparcos Number", "HIP 56324"},
        {"Geneva Identification System", "GEN# +1.00100311"},
        {"Smithsonian Astrophysical Observation", "SAO 62596"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20961412),
        dec: Angle.Degrees(+38.86444622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198424"},
        {"Hipparcos Number", "HIP 102729"},
        {"Celescope Catalog", "CEL 5173"},
        {"Fundamental Katalog 5th Edition", "FK5 5836"},
        {"Geneva Identification System", "GEN# +1.00198424"},
        {"Smithsonian Astrophysical Observation", "SAO 70539"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.25214848),
        dec: Angle.Degrees(+38.86512107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133405"},
        {"Hipparcos Number", "HIP 73627"},
        {"Geneva Identification System", "GEN# +1.00133405"},
        {"Smithsonian Astrophysical Observation", "SAO 64475"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.75322903),
        dec: Angle.Degrees(+38.86585385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61314"},
        {"Smithsonian Astrophysical Observation", "SAO 63071"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.42355674),
        dec: Angle.Degrees(+38.86638115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6211 AB"},
        {"Henry Draper", "HD 60694"},
        {"Hipparcos Number", "HIP 37102"},
        {"Geneva Identification System", "GEN# +1.00060694J"},
        {"Smithsonian Astrophysical Observation", "SAO 60229"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.35790739),
        dec: Angle.Degrees(+38.86820307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95884"},
        {"Hipparcos Number", "HIP 54107"},
        {"Geneva Identification System", "GEN# +1.00095884"},
        {"Smithsonian Astrophysical Observation", "SAO 62385"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.07592384),
        dec: Angle.Degrees(+38.86825501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33041",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5534 A"},
        {"Henry Draper", "HD 50018"},
        {"Hipparcos Number", "HIP 33041"},
        {"Geneva Identification System", "GEN# +1.00050018A"},
        {"Smithsonian Astrophysical Observation", "SAO 59571"},
        {"Wilson Evans Batten Catalogue", "WEB 6649"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.25588612),
        dec: Angle.Degrees(+38.86913968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32316"},
        {"Hipparcos Number", "HIP 23572"},
        {"Geneva Identification System", "GEN# +1.00032316"},
        {"Smithsonian Astrophysical Observation", "SAO 57602"},
        {"Wilson Evans Batten Catalogue", "WEB 4592"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.01981229),
        dec: Angle.Degrees(+38.86976519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71494"},
        {"Hipparcos Number", "HIP 41630"},
        {"Geneva Identification System", "GEN# +1.00071494"},
        {"Smithsonian Astrophysical Observation", "SAO 60843"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.30498896),
        dec: Angle.Degrees(+38.87392260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37103",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6211 C"},
        {"Hipparcos Number", "HIP 37103"},
    },
    visualMagnitude: 10.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.36047411),
        dec: Angle.Degrees(+38.87446533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56171"},
        {"Hipparcos Number", "HIP 35317"},
        {"Geneva Identification System", "GEN# +1.00056171"},
        {"Smithsonian Astrophysical Observation", "SAO 59955"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.42770486),
        dec: Angle.Degrees(+38.87633600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26080"},
        {"Smithsonian Astrophysical Observation", "SAO 58180"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.43609844),
        dec: Angle.Degrees(+38.87638728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18730"},
        {"Hipparcos Number", "HIP 14107"},
        {"Geneva Identification System", "GEN# +1.00018730"},
        {"Smithsonian Astrophysical Observation", "SAO 56099"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.47168886),
        dec: Angle.Degrees(+38.87822566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70029"},
        {"Hipparcos Number", "HIP 40936"},
        {"Smithsonian Astrophysical Observation", "SAO 60747"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.30680221),
        dec: Angle.Degrees(+38.87844076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60771"},
        {"Hipparcos Number", "HIP 37133"},
        {"Geneva Identification System", "GEN# +1.00060771"},
        {"Smithsonian Astrophysical Observation", "SAO 60232"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.45105363),
        dec: Angle.Degrees(+38.87880631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13495 A"},
        {"Henry Draper", "HD 192078"},
        {"Hipparcos Number", "HIP 99504"},
        {"Geneva Identification System", "GEN# +1.00192078"},
        {"Smithsonian Astrophysical Observation", "SAO 69581"},
        {"Wilson Evans Batten Catalogue", "WEB 17794"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.90698298),
        dec: Angle.Degrees(+38.87975450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189574"},
        {"Hipparcos Number", "HIP 98378"},
        {"Geneva Identification System", "GEN# +1.00189574"},
        {"Renson", "Renson 52560"},
        {"Smithsonian Astrophysical Observation", "SAO 69213"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.80283931),
        dec: Angle.Degrees(+38.88037511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116204"},
        {"Hipparcos Number", "HIP 65187"},
        {"Geneva Identification System", "GEN# +1.00116204"},
        {"Smithsonian Astrophysical Observation", "SAO 63494"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.38459795),
        dec: Angle.Degrees(+38.88045844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46857"},
        {"Smithsonian Astrophysical Observation", "SAO 61554"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23155864),
        dec: Angle.Degrees(+38.88076588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180915"},
        {"Hipparcos Number", "HIP 94742"},
        {"Geneva Identification System", "GEN# +1.00180915"},
        {"Smithsonian Astrophysical Observation", "SAO 68076"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.18163422),
        dec: Angle.Degrees(+38.88144019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161815"},
        {"Hipparcos Number", "HIP 86939"},
        {"Fundamental Katalog 5th Edition", "FK5 3411"},
        {"Smithsonian Astrophysical Observation", "SAO 66315"},
        {"Wilson Evans Batten Catalogue", "WEB 14667"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.47383486),
        dec: Angle.Degrees(+38.88146501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113300"},
        {"Hipparcos Number", "HIP 63621"},
        {"Geneva Identification System", "GEN# +1.00113300"},
        {"Smithsonian Astrophysical Observation", "SAO 63313"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.59199193),
        dec: Angle.Degrees(+38.88160670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194988"},
        {"Hipparcos Number", "HIP 100873"},
        {"Smithsonian Astrophysical Observation", "SAO 70047"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.79774158),
        dec: Angle.Degrees(+38.88175243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159026"},
        {"Hipparcos Number", "HIP 85688"},
        {"Geneva Identification System", "GEN# +1.00159026"},
        {"Smithsonian Astrophysical Observation", "SAO 66102"},
        {"Wilson Evans Batten Catalogue", "WEB 14460"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.66753462),
        dec: Angle.Degrees(+38.88217133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106378"},
        {"Smithsonian Astrophysical Observation", "SAO 71450"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.19148684),
        dec: Angle.Degrees(+38.88327390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20653"},
        {"Hipparcos Number", "HIP 15601"},
        {"Geneva Identification System", "GEN# +1.00020653"},
        {"Smithsonian Astrophysical Observation", "SAO 56365"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.22299304),
        dec: Angle.Degrees(+38.88534497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110222"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.90060865),
        dec: Angle.Degrees(+38.89060223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28927"},
        {"Hipparcos Number", "HIP 21376"},
        {"Geneva Identification System", "GEN# +1.00028927"},
        {"Smithsonian Astrophysical Observation", "SAO 57319"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.80519593),
        dec: Angle.Degrees(+38.89109355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
