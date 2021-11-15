using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_33() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148041"},
        {"Hipparcos Number", "HIP 80552"},
        {"Geneva Identification System", "GEN# +1.00148041"},
        {"Smithsonian Astrophysical Observation", "SAO 207669"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.69413303),
        dec: Angle.Degrees(-33.07307072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113531"},
        {"Hipparcos Number", "HIP 63808"},
        {"Smithsonian Astrophysical Observation", "SAO 204100"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18384061),
        dec: Angle.Degrees(-33.07273810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51433"},
        {"Hipparcos Number", "HIP 33333"},
        {"Geneva Identification System", "GEN# +1.00051433"},
        {"Smithsonian Astrophysical Observation", "SAO 197374"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.99115510),
        dec: Angle.Degrees(-33.07177117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44643"},
        {"Hipparcos Number", "HIP 30216"},
        {"Smithsonian Astrophysical Observation", "SAO 196721"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.35694688),
        dec: Angle.Degrees(-33.07166744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31851"},
        {"Hipparcos Number", "HIP 23059"},
        {"Smithsonian Astrophysical Observation", "SAO 195435"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.43609667),
        dec: Angle.Degrees(-33.06888029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79769"},
        {"Hipparcos Number", "HIP 45388"},
        {"Smithsonian Astrophysical Observation", "SAO 200149"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.74128679),
        dec: Angle.Degrees(-33.06697066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12135"},
        {"Hipparcos Number", "HIP 9207"},
        {"Fundamental Katalog 5th Edition", "FK5 2135"},
        {"Geneva Identification System", "GEN# +1.00012135J"},
        {"Smithsonian Astrophysical Observation", "SAO 193422"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.61116045),
        dec: Angle.Degrees(-33.06673777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34485"},
        {"Hipparcos Number", "HIP 24576"},
        {"Geneva Identification System", "GEN# +1.00034485"},
        {"Smithsonian Astrophysical Observation", "SAO 195702"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.08239398),
        dec: Angle.Degrees(-33.06617140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75741"},
        {"Hipparcos Number", "HIP 43425"},
        {"Smithsonian Astrophysical Observation", "SAO 199692"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.67539380),
        dec: Angle.Degrees(-33.06570902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29853"},
        {"Hipparcos Number", "HIP 21793"},
        {"Smithsonian Astrophysical Observation", "SAO 195219"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.22715345),
        dec: Angle.Degrees(-33.06547788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179058"},
        {"Hipparcos Number", "HIP 94367"},
        {"Smithsonian Astrophysical Observation", "SAO 211041"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.10499681),
        dec: Angle.Degrees(-33.06216941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94753"},
        {"Hipparcos Number", "HIP 53438"},
        {"Geneva Identification System", "GEN# +1.00094753"},
        {"Smithsonian Astrophysical Observation", "SAO 201913"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.98323968),
        dec: Angle.Degrees(-33.06164770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125149"},
        {"Hipparcos Number", "HIP 69902"},
        {"Smithsonian Astrophysical Observation", "SAO 205409"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.59429244),
        dec: Angle.Degrees(-33.06156958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89198"},
        {"Hipparcos Number", "HIP 50339"},
        {"Smithsonian Astrophysical Observation", "SAO 201235"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.18954932),
        dec: Angle.Degrees(-33.06113837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78734"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.09718041),
        dec: Angle.Degrees(-33.06086864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103488"},
        {"Hipparcos Number", "HIP 58100"},
        {"Geneva Identification System", "GEN# +1.00103488"},
        {"Smithsonian Astrophysical Observation", "SAO 202935"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.74007539),
        dec: Angle.Degrees(-33.06023279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122087"},
        {"Hipparcos Number", "HIP 68421"},
        {"Smithsonian Astrophysical Observation", "SAO 205083"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.10374045),
        dec: Angle.Degrees(-33.05935509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56532"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.87382593),
        dec: Angle.Degrees(-33.05887066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158859"},
        {"Hipparcos Number", "HIP 85885"},
        {"Geneva Identification System", "GEN# +1.00158859"},
        {"Smithsonian Astrophysical Observation", "SAO 208945"},
        {"Wilson Evans Batten Catalogue", "WEB 14495"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.27507480),
        dec: Angle.Degrees(-33.05777691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181199B"},
        {"Hipparcos Number", "HIP 95110"},
        {"Smithsonian Astrophysical Observation", "SAO 211201"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22688340),
        dec: Angle.Degrees(-33.05480177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70555"},
        {"Hipparcos Number", "HIP 40945"},
        {"Fundamental Katalog 5th Edition", "FK5 1219"},
        {"Geneva Identification System", "GEN# +1.00070555"},
        {"Smithsonian Astrophysical Observation", "SAO 199118"},
        {"Wilson Evans Batten Catalogue", "WEB 7939"},
    },
    visualMagnitude: 4.83,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.34597645),
        dec: Angle.Degrees(-33.05437199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164107"},
        {"Hipparcos Number", "HIP 88238"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.27884281),
        dec: Angle.Degrees(-33.05420941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219180"},
        {"Hipparcos Number", "HIP 114711"},
        {"Smithsonian Astrophysical Observation", "SAO 214397"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.54316675),
        dec: Angle.Degrees(-33.05345208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123428"},
        {"Hipparcos Number", "HIP 69078"},
        {"Geneva Identification System", "GEN# +1.00123428"},
        {"Smithsonian Astrophysical Observation", "SAO 205222"},
        {"Wilson Evans Batten Catalogue", "WEB 12062"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.09049192),
        dec: Angle.Degrees(-33.05291269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181199"},
        {"Hipparcos Number", "HIP 95106"},
        {"Geneva Identification System", "GEN# +1.00181199"},
        {"Smithsonian Astrophysical Observation", "SAO 211200"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22318622),
        dec: Angle.Degrees(-33.05258846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159897"},
        {"Hipparcos Number", "HIP 86342"},
        {"Geneva Identification System", "GEN# +1.00159897"},
        {"Smithsonian Astrophysical Observation", "SAO 209062"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.65635102),
        dec: Angle.Degrees(-33.05201664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160748"},
        {"Hipparcos Number", "HIP 86716"},
        {"Geneva Identification System", "GEN# +1.00160748"},
        {"Smithsonian Astrophysical Observation", "SAO 209176"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.77860253),
        dec: Angle.Degrees(-33.05127544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112934"},
        {"Hipparcos Number", "HIP 63491"},
        {"Geneva Identification System", "GEN# +1.00112934"},
        {"Smithsonian Astrophysical Observation", "SAO 204030"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.14003738),
        dec: Angle.Degrees(-33.05118134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9182"},
        {"Hipparcos Number", "HIP 6988"},
        {"Smithsonian Astrophysical Observation", "SAO 193146"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.48925755),
        dec: Angle.Degrees(-33.05032969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19853"},
        {"Hipparcos Number", "HIP 14750"},
        {"Smithsonian Astrophysical Observation", "SAO 194131"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.61503790),
        dec: Angle.Degrees(-33.04981878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205529"},
        {"Hipparcos Number", "HIP 106703"},
        {"Geneva Identification System", "GEN# +1.00205529"},
        {"Smithsonian Astrophysical Observation", "SAO 213136"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.20312178),
        dec: Angle.Degrees(-33.04789185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218122"},
        {"Hipparcos Number", "HIP 114047"},
        {"Smithsonian Astrophysical Observation", "SAO 214305"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.44557810),
        dec: Angle.Degrees(-33.04788384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153003"},
        {"Hipparcos Number", "HIP 83062"},
        {"Geneva Identification System", "GEN# +1.00153003"},
        {"Smithsonian Astrophysical Observation", "SAO 208248"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.58636877),
        dec: Angle.Degrees(-33.04770002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202740"},
        {"Hipparcos Number", "HIP 105226"},
        {"Smithsonian Astrophysical Observation", "SAO 212891"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.72089195),
        dec: Angle.Degrees(-33.04626954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188158"},
        {"Hipparcos Number", "HIP 98012"},
        {"Geneva Identification System", "GEN# +1.00188158"},
        {"Smithsonian Astrophysical Observation", "SAO 211653"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77129973),
        dec: Angle.Degrees(-33.04624883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56752"},
        {"Hipparcos Number", "HIP 35249"},
        {"Celescope Catalog", "CEL 1741"},
        {"Geneva Identification System", "GEN# +1.00056752"},
        {"Smithsonian Astrophysical Observation", "SAO 197791"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.25272669),
        dec: Angle.Degrees(-33.04619431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1053"},
        {"Hipparcos Number", "HIP 1175"},
        {"Smithsonian Astrophysical Observation", "SAO 192414"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66693312),
        dec: Angle.Degrees(-33.04592558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17083"},
        {"Hipparcos Number", "HIP 12732"},
        {"Geneva Identification System", "GEN# +1.00017083"},
        {"Smithsonian Astrophysical Observation", "SAO 193880"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.91541727),
        dec: Angle.Degrees(-33.04554228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119756"},
        {"Hipparcos Number", "HIP 67153"},
        {"Cincinnati Publication", "Ci 20 800"},
        {"Fundamental Katalog 5th Edition", "FK5 506"},
        {"Geneva Identification System", "GEN# +1.00119756"},
        {"Smithsonian Astrophysical Observation", "SAO 204812"},
        {"Wilson Evans Batten Catalogue", "WEB 11823"},
    },
    visualMagnitude: 4.23,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.42319432),
        dec: Angle.Degrees(-33.04336606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -461.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217896"},
        {"Hipparcos Number", "HIP 113929"},
        {"Smithsonian Astrophysical Observation", "SAO 214286"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.06658635),
        dec: Angle.Degrees(-33.04195911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46494"},
        {"Smithsonian Astrophysical Observation", "SAO 200412"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.24217760),
        dec: Angle.Degrees(-33.03900255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46773"},
        {"Hipparcos Number", "HIP 31298"},
        {"Smithsonian Astrophysical Observation", "SAO 196943"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.45571892),
        dec: Angle.Degrees(-33.03841255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183717"},
        {"Hipparcos Number", "HIP 96088"},
        {"Smithsonian Astrophysical Observation", "SAO 211336"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.03910733),
        dec: Angle.Degrees(-33.03801281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 769"},
        {"Hipparcos Number", "HIP 963"},
        {"Smithsonian Astrophysical Observation", "SAO 192392"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.97800862),
        dec: Angle.Degrees(-33.03738870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130030"},
        {"Hipparcos Number", "HIP 72279"},
        {"Geneva Identification System", "GEN# +1.00130030"},
        {"Smithsonian Astrophysical Observation", "SAO 205936"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.71715894),
        dec: Angle.Degrees(-33.03216189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88742"},
        {"Hipparcos Number", "HIP 50075"},
        {"Geneva Identification System", "GEN# +1.00088742"},
        {"Smithsonian Astrophysical Observation", "SAO 201186"},
        {"Wilson Evans Batten Catalogue", "WEB 9203"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.35411361),
        dec: Angle.Degrees(-33.03187875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -369.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30316"},
        {"Hipparcos Number", "HIP 22087"},
        {"Geneva Identification System", "GEN# +1.00030316"},
        {"Smithsonian Astrophysical Observation", "SAO 195267"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.28197511),
        dec: Angle.Degrees(-33.03133234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219871"},
        {"Hipparcos Number", "HIP 115150"},
        {"Geneva Identification System", "GEN# +1.00219871"},
        {"Renson", "Renson 60390"},
        {"Smithsonian Astrophysical Observation", "SAO 214453"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.86944553),
        dec: Angle.Degrees(-33.03017809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194982"},
        {"Hipparcos Number", "HIP 101106"},
        {"Smithsonian Astrophysical Observation", "SAO 212175"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.42385039),
        dec: Angle.Degrees(-33.02649773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69741"},
        {"Hipparcos Number", "HIP 40576"},
        {"Smithsonian Astrophysical Observation", "SAO 199034"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.26420223),
        dec: Angle.Degrees(-33.00750470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206742"},
        {"Hipparcos Number", "HIP 107380"},
        {"Fundamental Katalog 5th Edition", "FK5 814"},
        {"Geneva Identification System", "GEN# +1.00206742"},
        {"Renson", "Renson 57530"},
        {"Smithsonian Astrophysical Observation", "SAO 213258"},
        {"Wilson Evans Batten Catalogue", "WEB 19391"},
    },
    visualMagnitude: 4.35,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.23661590),
        dec: Angle.Degrees(-33.02555306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189268"},
        {"Hipparcos Number", "HIP 98480"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.10450875),
        dec: Angle.Degrees(-33.02239002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155015"},
        {"Hipparcos Number", "HIP 84015"},
        {"Smithsonian Astrophysical Observation", "SAO 208492"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.60864459),
        dec: Angle.Degrees(-33.02142766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153424"},
        {"Hipparcos Number", "HIP 83252"},
        {"Smithsonian Astrophysical Observation", "SAO 208299"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.23500591),
        dec: Angle.Degrees(-33.02130590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202226"},
        {"Hipparcos Number", "HIP 104936"},
        {"Smithsonian Astrophysical Observation", "SAO 212834"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.84672702),
        dec: Angle.Degrees(-33.01989078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33228"},
        {"Smithsonian Astrophysical Observation", "SAO 197349"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.71094760),
        dec: Angle.Degrees(-33.01943694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177243"},
        {"Hipparcos Number", "HIP 93742"},
        {"Smithsonian Astrophysical Observation", "SAO 210904"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.32552935),
        dec: Angle.Degrees(-33.01792289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171034"},
        {"Hipparcos Number", "HIP 91014"},
        {"Celescope Catalog", "CEL 4630"},
        {"Fundamental Katalog 5th Edition", "FK5 3471"},
        {"Geneva Identification System", "GEN# +1.00171034"},
        {"Smithsonian Astrophysical Observation", "SAO 210312"},
        {"Wilson Evans Batten Catalogue", "WEB 15620"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.49068660),
        dec: Angle.Degrees(-33.01653262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208320"},
        {"Hipparcos Number", "HIP 108279"},
        {"Smithsonian Astrophysical Observation", "SAO 213411"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.05750553),
        dec: Angle.Degrees(-33.01569128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198102"},
        {"Hipparcos Number", "HIP 102737"},
        {"Smithsonian Astrophysical Observation", "SAO 212459"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.26636337),
        dec: Angle.Degrees(-33.01504867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191018"},
        {"Hipparcos Number", "HIP 99262"},
        {"Smithsonian Astrophysical Observation", "SAO 211853"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.24163214),
        dec: Angle.Degrees(-33.01288184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4682"},
        {"Smithsonian Astrophysical Observation", "SAO 192860"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.04211714),
        dec: Angle.Degrees(-33.01263222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143051"},
        {"Hipparcos Number", "HIP 78306"},
        {"Geneva Identification System", "GEN# +1.00143051"},
        {"Smithsonian Astrophysical Observation", "SAO 207195"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.83463351),
        dec: Angle.Degrees(-33.01214740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145838"},
        {"Hipparcos Number", "HIP 79596"},
        {"Geneva Identification System", "GEN# +1.00145838"},
        {"Smithsonian Astrophysical Observation", "SAO 207480"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.59321316),
        dec: Angle.Degrees(-33.01104217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24149"},
        {"Hipparcos Number", "HIP 17879"},
        {"Smithsonian Astrophysical Observation", "SAO 194558"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.37071447),
        dec: Angle.Degrees(-33.01089354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72776"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.14990450),
        dec: Angle.Degrees(-00.62449147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15740"},
        {"Hipparcos Number", "HIP 11688"},
        {"Geneva Identification System", "GEN# +1.00015740"},
        {"Smithsonian Astrophysical Observation", "SAO 193747"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.69358051),
        dec: Angle.Degrees(-33.00740117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2429"},
        {"Hipparcos Number", "HIP 2210"},
        {"Fundamental Katalog 5th Edition", "FK5 2026"},
        {"Geneva Identification System", "GEN# +1.00002429"},
        {"Smithsonian Astrophysical Observation", "SAO 192545"},
        {"Wilson Evans Batten Catalogue", "WEB 409"},
    },
    visualMagnitude: 4.86,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.98213606),
        dec: Angle.Degrees(-33.00704460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38195"},
        {"Hipparcos Number", "HIP 26895"},
        {"Smithsonian Astrophysical Observation", "SAO 196102"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.64106060),
        dec: Angle.Degrees(-33.00534699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10090"},
        {"Hipparcos Number", "HIP 7619"},
        {"Smithsonian Astrophysical Observation", "SAO 193221"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.53588744),
        dec: Angle.Degrees(-33.00340050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47015"},
        {"Hipparcos Number", "HIP 31419"},
        {"Geneva Identification System", "GEN# +1.00047015"},
        {"Smithsonian Astrophysical Observation", "SAO 196969"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76736717),
        dec: Angle.Degrees(-33.00300835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13240"},
        {"Smithsonian Astrophysical Observation", "SAO 193941"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.60474433),
        dec: Angle.Degrees(-33.00042613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190306"},
        {"Hipparcos Number", "HIP 98960"},
        {"Geneva Identification System", "GEN# +1.00190306J"},
        {"Smithsonian Astrophysical Observation", "SAO 211798"},
        {"Wilson Evans Batten Catalogue", "WEB 17569"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.38343150),
        dec: Angle.Degrees(-32.99981877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39512"},
        {"Smithsonian Astrophysical Observation", "SAO 198769"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.13338379),
        dec: Angle.Degrees(-32.99820835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14194"},
        {"Hipparcos Number", "HIP 10638"},
        {"Smithsonian Astrophysical Observation", "SAO 193618"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.23477807),
        dec: Angle.Degrees(-32.99681059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172059"},
        {"Hipparcos Number", "HIP 91488"},
        {"Smithsonian Astrophysical Observation", "SAO 210412"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.87629339),
        dec: Angle.Degrees(-32.99474161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21022"},
        {"Hipparcos Number", "HIP 15709"},
        {"Geneva Identification System", "GEN# +1.00021022"},
        {"Smithsonian Astrophysical Observation", "SAO 194261"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.58994053),
        dec: Angle.Degrees(-32.99436477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41667"},
        {"Hipparcos Number", "HIP 28824"},
        {"Geneva Identification System", "GEN# +1.00041667"},
        {"Smithsonian Astrophysical Observation", "SAO 196475"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26515399),
        dec: Angle.Degrees(-32.99426098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120709"},
        {"Hipparcos Number", "HIP 67669"},
        {"Geneva Identification System", "GEN# +1.00120709"},
        {"Smithsonian Astrophysical Observation", "SAO 204916"},
        {"Wilson Evans Batten Catalogue", "WEB 11901"},
    },
    visualMagnitude: 4.32,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.95677175),
        dec: Angle.Degrees(-32.99401625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60370"},
        {"Hipparcos Number", "HIP 36686"},
        {"Geneva Identification System", "GEN# +1.00060370J"},
        {"Smithsonian Astrophysical Observation", "SAO 198112"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19890989),
        dec: Angle.Degrees(-32.99141323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150036"},
        {"Hipparcos Number", "HIP 81586"},
        {"Geneva Identification System", "GEN# +1.00150036"},
        {"Smithsonian Astrophysical Observation", "SAO 207893"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.93277142),
        dec: Angle.Degrees(-32.99118551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166219"},
        {"Hipparcos Number", "HIP 89105"},
        {"Geneva Identification System", "GEN# +1.00166219"},
        {"Smithsonian Astrophysical Observation", "SAO 209821"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.78026338),
        dec: Angle.Degrees(-32.99066946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162168"},
        {"Hipparcos Number", "HIP 87361"},
        {"Geneva Identification System", "GEN# +1.00162168"},
        {"Smithsonian Astrophysical Observation", "SAO 209347"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.76343459),
        dec: Angle.Degrees(-32.98950005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170479"},
        {"Hipparcos Number", "HIP 90763"},
        {"Geneva Identification System", "GEN# +1.00170479J"},
        {"Renson", "Renson 47760"},
        {"Smithsonian Astrophysical Observation", "SAO 210257"},
        {"Wilson Evans Batten Catalogue", "WEB 15547"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.77018839),
        dec: Angle.Degrees(-32.98900140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94389"},
        {"Hipparcos Number", "HIP 53227"},
        {"Smithsonian Astrophysical Observation", "SAO 201857"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.31201996),
        dec: Angle.Degrees(-32.98860946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210049"},
        {"Hipparcos Number", "HIP 109285"},
        {"Fundamental Katalog 5th Edition", "FK5 832"},
        {"Geneva Identification System", "GEN# +1.00210049"},
        {"Smithsonian Astrophysical Observation", "SAO 213576"},
        {"Wilson Evans Batten Catalogue", "WEB 19639"},
    },
    visualMagnitude: 4.50,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.09563830),
        dec: Angle.Degrees(-32.98839827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100953"},
        {"Hipparcos Number", "HIP 56657"},
        {"Geneva Identification System", "GEN# +1.00100953"},
        {"Smithsonian Astrophysical Observation", "SAO 202634"},
        {"Wilson Evans Batten Catalogue", "WEB 10186"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.25509929),
        dec: Angle.Degrees(-32.98799577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27141"},
        {"Hipparcos Number", "HIP 19872"},
        {"Smithsonian Astrophysical Observation", "SAO 194877"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.93460840),
        dec: Angle.Degrees(-32.98226518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53440"},
        {"Hipparcos Number", "HIP 34031"},
        {"Geneva Identification System", "GEN# +1.00053440"},
        {"Smithsonian Astrophysical Observation", "SAO 197523"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90483629),
        dec: Angle.Degrees(-32.98173236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37779"},
        {"Hipparcos Number", "HIP 26630"},
        {"Smithsonian Astrophysical Observation", "SAO 196057"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.89980006),
        dec: Angle.Degrees(-32.98047311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85577"},
        {"Hipparcos Number", "HIP 48392"},
        {"Geneva Identification System", "GEN# +1.00085577"},
        {"Smithsonian Astrophysical Observation", "SAO 200820"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.98212921),
        dec: Angle.Degrees(-32.97994772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139502"},
        {"Hipparcos Number", "HIP 76701"},
        {"Geneva Identification System", "GEN# +1.00139502"},
        {"Smithsonian Astrophysical Observation", "SAO 206842"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91944816),
        dec: Angle.Degrees(-32.97698982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92087"},
        {"Smithsonian Astrophysical Observation", "SAO 210548"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51612397),
        dec: Angle.Degrees(-32.97641695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26442"},
        {"Hipparcos Number", "HIP 19423"},
        {"Smithsonian Astrophysical Observation", "SAO 194803"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.39609026),
        dec: Angle.Degrees(-32.97514783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112879"},
        {"Hipparcos Number", "HIP 63451"},
        {"Smithsonian Astrophysical Observation", "SAO 204018"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.03102558),
        dec: Angle.Degrees(-32.97441742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88138"},
        {"Hipparcos Number", "HIP 49730"},
        {"Smithsonian Astrophysical Observation", "SAO 201101"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28552609),
        dec: Angle.Degrees(-32.97231305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126313"},
        {"Hipparcos Number", "HIP 70521"},
        {"Geneva Identification System", "GEN# +1.00126313A"},
        {"Smithsonian Astrophysical Observation", "SAO 205541"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.37928397),
        dec: Angle.Degrees(-32.97206123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32853"},
        {"Smithsonian Astrophysical Observation", "SAO 197274"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.71731769),
        dec: Angle.Degrees(-32.97159340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216195"},
        {"Hipparcos Number", "HIP 112855"},
        {"Smithsonian Astrophysical Observation", "SAO 214136"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.81836669),
        dec: Angle.Degrees(-32.96962447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11954"},
        {"Hipparcos Number", "HIP 9058"},
        {"Smithsonian Astrophysical Observation", "SAO 193397"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.16000077),
        dec: Angle.Degrees(-32.96958245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157750"},
        {"Hipparcos Number", "HIP 85360"},
        {"Geneva Identification System", "GEN# +1.00157750"},
        {"Smithsonian Astrophysical Observation", "SAO 208819"},
        {"Wilson Evans Batten Catalogue", "WEB 14414"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.64535235),
        dec: Angle.Degrees(-32.96937667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68913"},
        {"Hipparcos Number", "HIP 40257"},
        {"Celescope Catalog", "CEL 2247"},
        {"Geneva Identification System", "GEN# +1.00068913"},
        {"Smithsonian Astrophysical Observation", "SAO 198948"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.33057712),
        dec: Angle.Degrees(-32.96906690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187065"},
        {"Hipparcos Number", "HIP 97523"},
        {"Smithsonian Astrophysical Observation", "SAO 211575"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.31525444),
        dec: Angle.Degrees(-32.96897430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156425"},
        {"Hipparcos Number", "HIP 84713"},
        {"Smithsonian Astrophysical Observation", "SAO 208673"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.74268948),
        dec: Angle.Degrees(-32.96549469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209565"},
        {"Hipparcos Number", "HIP 109007"},
        {"Smithsonian Astrophysical Observation", "SAO 213531"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.26253444),
        dec: Angle.Degrees(-32.96353832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171060"},
        {"Hipparcos Number", "HIP 91020"},
        {"Geneva Identification System", "GEN# +1.00171060"},
        {"Smithsonian Astrophysical Observation", "SAO 210314"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.52134181),
        dec: Angle.Degrees(-32.96111665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105113"},
        {"Hipparcos Number", "HIP 59021"},
        {"Smithsonian Astrophysical Observation", "SAO 203123"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.52187140),
        dec: Angle.Degrees(-32.96075904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146593"},
        {"Hipparcos Number", "HIP 79883"},
        {"Geneva Identification System", "GEN# +1.00146593"},
        {"Smithsonian Astrophysical Observation", "SAO 207532"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.58486788),
        dec: Angle.Degrees(-32.95995323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193230"},
        {"Hipparcos Number", "HIP 100273"},
        {"Smithsonian Astrophysical Observation", "SAO 212016"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.08501277),
        dec: Angle.Degrees(-32.95935779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103869"},
        {"Hipparcos Number", "HIP 58324"},
        {"Smithsonian Astrophysical Observation", "SAO 202985"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.39830527),
        dec: Angle.Degrees(-32.95827055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28231"},
        {"Hipparcos Number", "HIP 20685"},
        {"Smithsonian Astrophysical Observation", "SAO 195005"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.46225818),
        dec: Angle.Degrees(-32.95657980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82896"},
        {"Hipparcos Number", "HIP 46931"},
        {"Smithsonian Astrophysical Observation", "SAO 200501"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.47949129),
        dec: Angle.Degrees(-32.95242368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85416"},
        {"Smithsonian Astrophysical Observation", "SAO 141672"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.81779145),
        dec: Angle.Degrees(-00.25266341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14810"},
        {"Hipparcos Number", "HIP 11059"},
        {"Smithsonian Astrophysical Observation", "SAO 193670"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.58697857),
        dec: Angle.Degrees(-32.95197652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4111"},
        {"Hipparcos Number", "HIP 3398"},
        {"Smithsonian Astrophysical Observation", "SAO 192694"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82256487),
        dec: Angle.Degrees(-32.94825788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151108"},
        {"Hipparcos Number", "HIP 82131"},
        {"Smithsonian Astrophysical Observation", "SAO 208022"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.67313574),
        dec: Angle.Degrees(-32.94758510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71458"},
        {"Hipparcos Number", "HIP 41363"},
        {"Geneva Identification System", "GEN# +1.00071458"},
        {"Smithsonian Astrophysical Observation", "SAO 199218"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.57418530),
        dec: Angle.Degrees(-32.94686034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104135"},
        {"Hipparcos Number", "HIP 58481"},
        {"Smithsonian Astrophysical Observation", "SAO 203012"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.89197432),
        dec: Angle.Degrees(-32.94684203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100330"},
        {"Hipparcos Number", "HIP 56308"},
        {"Smithsonian Astrophysical Observation", "SAO 202550"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.15283962),
        dec: Angle.Degrees(-32.94636040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207066"},
        {"Hipparcos Number", "HIP 107578"},
        {"Smithsonian Astrophysical Observation", "SAO 213286"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.81590448),
        dec: Angle.Degrees(-32.94589061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90973"},
        {"Hipparcos Number", "HIP 51373"},
        {"Smithsonian Astrophysical Observation", "SAO 201441"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.39056798),
        dec: Angle.Degrees(-32.94174753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109602"},
        {"Hipparcos Number", "HIP 61509"},
        {"Geneva Identification System", "GEN# +1.00109602"},
        {"Smithsonian Astrophysical Observation", "SAO 203626"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.03769347),
        dec: Angle.Degrees(-32.93764977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18237"},
        {"Hipparcos Number", "HIP 13563"},
        {"Smithsonian Astrophysical Observation", "SAO 193979"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.67965682),
        dec: Angle.Degrees(-32.93529158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80541"},
        {"Hipparcos Number", "HIP 45745"},
        {"Smithsonian Astrophysical Observation", "SAO 200236"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.89551258),
        dec: Angle.Degrees(-32.93243096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317746"},
        {"Hipparcos Number", "HIP 85677"},
        {"Smithsonian Astrophysical Observation", "SAO 208894"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.63136027),
        dec: Angle.Degrees(-32.92914120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15480"},
        {"Hipparcos Number", "HIP 11523"},
        {"Smithsonian Astrophysical Observation", "SAO 193728"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14541082),
        dec: Angle.Degrees(-32.92913993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59741"},
        {"Hipparcos Number", "HIP 36450"},
        {"Geneva Identification System", "GEN# +1.00059741"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50847432),
        dec: Angle.Degrees(-32.92834630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222996"},
        {"Hipparcos Number", "HIP 117204"},
        {"Smithsonian Astrophysical Observation", "SAO 214759"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46968204),
        dec: Angle.Degrees(-32.92717078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55023"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97568804),
        dec: Angle.Degrees(-00.10042192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124764"},
        {"Hipparcos Number", "HIP 69717"},
        {"Smithsonian Astrophysical Observation", "SAO 205370"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.05624607),
        dec: Angle.Degrees(-32.92651216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20521"},
        {"Hipparcos Number", "HIP 15269"},
        {"Smithsonian Astrophysical Observation", "SAO 194209"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.24351562),
        dec: Angle.Degrees(-32.92589613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71160"},
        {"Hipparcos Number", "HIP 41222"},
        {"Smithsonian Astrophysical Observation", "SAO 199188"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.16611596),
        dec: Angle.Degrees(-32.92403582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83775"},
        {"Hipparcos Number", "HIP 47430"},
        {"Smithsonian Astrophysical Observation", "SAO 200607"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.96385290),
        dec: Angle.Degrees(-32.92114943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213866"},
        {"Hipparcos Number", "HIP 111468"},
        {"Smithsonian Astrophysical Observation", "SAO 213929"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.75071376),
        dec: Angle.Degrees(-32.91898909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39996"},
        {"Smithsonian Astrophysical Observation", "SAO 198871"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.52617531),
        dec: Angle.Degrees(-32.91838245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95262",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sika"},
        {"Henry Draper", "HD 181720"},
        {"Hipparcos Number", "HIP 95262"},
        {"Cincinnati Publication", "Ci 20 1147"},
        {"Cincinnati Publication 2", "Ci 18 2526"},
        {"Geneva Identification System", "GEN# +1.00181720"},
        {"Smithsonian Astrophysical Observation", "SAO 211218"},
        {"Wilson Evans Batten Catalogue", "WEB 16647"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.72051567),
        dec: Angle.Degrees(-32.91804318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -415.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220469"},
        {"Hipparcos Number", "HIP 115532"},
        {"Geneva Identification System", "GEN# +1.00220469"},
        {"Smithsonian Astrophysical Observation", "SAO 214520"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.04398179),
        dec: Angle.Degrees(-32.91693758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202078"},
        {"Hipparcos Number", "HIP 104875"},
        {"Smithsonian Astrophysical Observation", "SAO 212823"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.66445269),
        dec: Angle.Degrees(-32.91356265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18671"},
        {"Hipparcos Number", "HIP 13911"},
        {"Smithsonian Astrophysical Observation", "SAO 194019"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.79202201),
        dec: Angle.Degrees(-32.91293024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102634"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.95236015),
        dec: Angle.Degrees(-32.91274285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184922"},
        {"Hipparcos Number", "HIP 96577"},
        {"Smithsonian Astrophysical Observation", "SAO 211429"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.50185462),
        dec: Angle.Degrees(-32.91273014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133750"},
        {"Hipparcos Number", "HIP 73987"},
        {"Geneva Identification System", "GEN# +1.00133750"},
        {"Smithsonian Astrophysical Observation", "SAO 206315"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.80712059),
        dec: Angle.Degrees(-32.91012792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163599"},
        {"Hipparcos Number", "HIP 87985"},
        {"Smithsonian Astrophysical Observation", "SAO 209533"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.59352082),
        dec: Angle.Degrees(-32.90967630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16425"},
        {"Hipparcos Number", "HIP 12206"},
        {"Smithsonian Astrophysical Observation", "SAO 193813"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.29232480),
        dec: Angle.Degrees(-32.90609313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31063"},
        {"Hipparcos Number", "HIP 22564"},
        {"Smithsonian Astrophysical Observation", "SAO 195356"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.83776990),
        dec: Angle.Degrees(-32.90215886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71015"},
        {"Hipparcos Number", "HIP 41168"},
        {"Celescope Catalog", "CEL 2465"},
        {"Geneva Identification System", "GEN# +1.00071015"},
        {"Smithsonian Astrophysical Observation", "SAO 199176"},
        {"Wilson Evans Batten Catalogue", "WEB 7968"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.99544336),
        dec: Angle.Degrees(-32.89689914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199952"},
        {"Hipparcos Number", "HIP 103748"},
        {"Smithsonian Astrophysical Observation", "SAO 212638"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.35790051),
        dec: Angle.Degrees(-32.89560163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135449"},
        {"Hipparcos Number", "HIP 74717"},
        {"Geneva Identification System", "GEN# +1.00135449"},
        {"Smithsonian Astrophysical Observation", "SAO 206470"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.04366000),
        dec: Angle.Degrees(-32.89241651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48044"},
        {"Hipparcos Number", "HIP 31890"},
        {"Smithsonian Astrophysical Observation", "SAO 197060"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.99499652),
        dec: Angle.Degrees(-32.89173211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171296"},
        {"Hipparcos Number", "HIP 91137"},
        {"Smithsonian Astrophysical Observation", "SAO 210344"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.86071514),
        dec: Angle.Degrees(-32.89076711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157673"},
        {"Hipparcos Number", "HIP 85316"},
        {"Geneva Identification System", "GEN# +1.00157673"},
        {"Smithsonian Astrophysical Observation", "SAO 208810"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.51965364),
        dec: Angle.Degrees(-32.88919283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149665"},
        {"Hipparcos Number", "HIP 81405"},
        {"Geneva Identification System", "GEN# +1.00149665"},
        {"Smithsonian Astrophysical Observation", "SAO 207853"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.39166400),
        dec: Angle.Degrees(-32.88810388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178201"},
        {"Hipparcos Number", "HIP 94077"},
        {"Smithsonian Astrophysical Observation", "SAO 210986"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.26864850),
        dec: Angle.Degrees(-32.88161296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138221"},
        {"Hipparcos Number", "HIP 76048"},
        {"Fundamental Katalog 5th Edition", "FK5 3223"},
        {"Geneva Identification System", "GEN# +1.00138221"},
        {"Smithsonian Astrophysical Observation", "SAO 206734"},
        {"Wilson Evans Batten Catalogue", "WEB 12925"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.95933926),
        dec: Angle.Degrees(-32.88106085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222908"},
        {"Hipparcos Number", "HIP 117136"},
        {"Smithsonian Astrophysical Observation", "SAO 214748"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.20240549),
        dec: Angle.Degrees(-32.88090680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174250"},
        {"Hipparcos Number", "HIP 92504"},
        {"Smithsonian Astrophysical Observation", "SAO 210634"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77614847),
        dec: Angle.Degrees(-32.87932491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30273"},
        {"Hipparcos Number", "HIP 22068"},
        {"Smithsonian Astrophysical Observation", "SAO 195263"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.20183714),
        dec: Angle.Degrees(-32.87670308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 353.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131048"},
        {"Hipparcos Number", "HIP 72755"},
        {"Geneva Identification System", "GEN# +1.00131048"},
        {"Smithsonian Astrophysical Observation", "SAO 206026"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.09813980),
        dec: Angle.Degrees(-32.87653169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27702"},
        {"Hipparcos Number", "HIP 20301"},
        {"Geneva Identification System", "GEN# +1.00027702"},
        {"Smithsonian Astrophysical Observation", "SAO 194944"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.24607227),
        dec: Angle.Degrees(-32.87576088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216336"},
        {"Hipparcos Number", "HIP 112948"},
        {"Geneva Identification System", "GEN# +1.00216336"},
        {"Renson", "Renson 59773"},
        {"Smithsonian Astrophysical Observation", "SAO 214153"},
        {"Wilson Evans Batten Catalogue", "WEB 20112"},
    },
    visualMagnitude: 4.46,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.13149128),
        dec: Angle.Degrees(-32.87545019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37670"},
        {"Geneva Identification System", "GEN# +9.80112044"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.93410396),
        dec: Angle.Degrees(-00.06295044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204142"},
        {"Hipparcos Number", "HIP 105964"},
        {"Smithsonian Astrophysical Observation", "SAO 213017"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.88938464),
        dec: Angle.Degrees(-32.87466213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159846"},
        {"Hipparcos Number", "HIP 86322"},
        {"Geneva Identification System", "GEN# +1.00159846"},
        {"Renson", "Renson 44970"},
        {"Smithsonian Astrophysical Observation", "SAO 209059"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.56848983),
        dec: Angle.Degrees(-32.87345651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185615"},
        {"Hipparcos Number", "HIP 96854"},
        {"Geneva Identification System", "GEN# +1.00185615"},
        {"Smithsonian Astrophysical Observation", "SAO 211476"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.30720004),
        dec: Angle.Degrees(-32.87306496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187084"},
        {"Hipparcos Number", "HIP 97531"},
        {"Geneva Identification System", "GEN# +1.00187084"},
        {"Smithsonian Astrophysical Observation", "SAO 211577"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.33972747),
        dec: Angle.Degrees(-32.87267858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88100"},
        {"Hipparcos Number", "HIP 49707"},
        {"Smithsonian Astrophysical Observation", "SAO 201095"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.21812843),
        dec: Angle.Degrees(-32.87184084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96891"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.43399515),
        dec: Angle.Degrees(-32.87100125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69818"},
        {"Hipparcos Number", "HIP 40608"},
        {"Celescope Catalog", "CEL 2316"},
        {"Geneva Identification System", "GEN# +1.00069818"},
        {"Smithsonian Astrophysical Observation", "SAO 199047"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.36817300),
        dec: Angle.Degrees(-32.87009591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46347"},
        {"Hipparcos Number", "HIP 31086"},
        {"Smithsonian Astrophysical Observation", "SAO 196905"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.85002981),
        dec: Angle.Degrees(-32.86856538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75581"},
        {"Hipparcos Number", "HIP 43341"},
        {"Smithsonian Astrophysical Observation", "SAO 199676"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.43914562),
        dec: Angle.Degrees(-32.86837116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1947"},
        {"Hipparcos Number", "HIP 1863"},
        {"Geneva Identification System", "GEN# +1.00001947"},
        {"Smithsonian Astrophysical Observation", "SAO 192500"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.89034641),
        dec: Angle.Degrees(-32.86638467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139696"},
        {"Hipparcos Number", "HIP 76793"},
        {"Smithsonian Astrophysical Observation", "SAO 206864"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.18897559),
        dec: Angle.Degrees(-32.86622807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110201"},
        {"Hipparcos Number", "HIP 61863"},
        {"Geneva Identification System", "GEN# +1.00110201"},
        {"Smithsonian Astrophysical Observation", "SAO 203698"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17543955),
        dec: Angle.Degrees(-32.86572368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136124"},
        {"Hipparcos Number", "HIP 75040"},
        {"Geneva Identification System", "GEN# +1.00136124"},
        {"Smithsonian Astrophysical Observation", "SAO 206528"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.01137820),
        dec: Angle.Degrees(-32.86491234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144179"},
        {"Hipparcos Number", "HIP 78842"},
        {"Cincinnati Publication", "Ci 20 962"},
        {"Geneva Identification System", "GEN# +1.00144179J"},
        {"Smithsonian Astrophysical Observation", "SAO 207321"},
        {"Wilson Evans Batten Catalogue", "WEB 13328"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.41424717),
        dec: Angle.Degrees(-32.86182017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -361.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86376"},
        {"Hipparcos Number", "HIP 48807"},
        {"Smithsonian Astrophysical Observation", "SAO 200898"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.31907820),
        dec: Angle.Degrees(-32.85781598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26301"},
        {"Hipparcos Number", "HIP 19305"},
        {"Geneva Identification System", "GEN# +1.00026301J"},
        {"Smithsonian Astrophysical Observation", "SAO 194790"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.07149393),
        dec: Angle.Degrees(-32.85683342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117312"},
        {"Hipparcos Number", "HIP 65851"},
        {"Smithsonian Astrophysical Observation", "SAO 204526"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.48225580),
        dec: Angle.Degrees(-32.85576302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155550"},
        {"Hipparcos Number", "HIP 84282"},
        {"Geneva Identification System", "GEN# +1.00155550"},
        {"Smithsonian Astrophysical Observation", "SAO 208558"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.43746001),
        dec: Angle.Degrees(-32.85256165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13639"},
        {"Hipparcos Number", "HIP 10271"},
        {"Smithsonian Astrophysical Observation", "SAO 193569"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.06102569),
        dec: Angle.Degrees(-32.85231246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190758"},
        {"Hipparcos Number", "HIP 99155"},
        {"Smithsonian Astrophysical Observation", "SAO 211833"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.94301028),
        dec: Angle.Degrees(-32.85216744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196746"},
        {"Hipparcos Number", "HIP 102021"},
        {"Geneva Identification System", "GEN# +1.00196746"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.10736136),
        dec: Angle.Degrees(-32.85177471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6626"},
        {"Geneva Identification System", "GEN# -0.03300514"},
        {"Smithsonian Astrophysical Observation", "SAO 193103"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.25687634),
        dec: Angle.Degrees(-32.85148015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198854"},
        {"Hipparcos Number", "HIP 103173"},
        {"Smithsonian Astrophysical Observation", "SAO 212530"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.54919282),
        dec: Angle.Degrees(-32.85088310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201409"},
        {"Hipparcos Number", "HIP 104523"},
        {"Geneva Identification System", "GEN# +1.00201409"},
        {"Smithsonian Astrophysical Observation", "SAO 212768"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.58702695),
        dec: Angle.Degrees(-32.85017044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170037"},
        {"Hipparcos Number", "HIP 90573"},
        {"Smithsonian Astrophysical Observation", "SAO 210210"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.22630025),
        dec: Angle.Degrees(-32.84802370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133338"},
        {"Hipparcos Number", "HIP 73798"},
        {"Smithsonian Astrophysical Observation", "SAO 206275"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.24305309),
        dec: Angle.Degrees(-32.84741416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88201"},
        {"Hipparcos Number", "HIP 49767"},
        {"Geneva Identification System", "GEN# +1.00088201"},
        {"Smithsonian Astrophysical Observation", "SAO 201107"},
        {"Wilson Evans Batten Catalogue", "WEB 9175"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.38295357),
        dec: Angle.Degrees(-32.84675282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30787"},
        {"Smithsonian Astrophysical Observation", "SAO 196855"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.03200184),
        dec: Angle.Degrees(-32.84596468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29941"},
        {"Hipparcos Number", "HIP 21839"},
        {"Geneva Identification System", "GEN# +1.00029941"},
        {"Smithsonian Astrophysical Observation", "SAO 195231"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.42732563),
        dec: Angle.Degrees(-32.84563142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15481"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89705673),
        dec: Angle.Degrees(-32.84483843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192672"},
        {"Hipparcos Number", "HIP 100001"},
        {"Smithsonian Astrophysical Observation", "SAO 211967"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.31957341),
        dec: Angle.Degrees(-32.84412472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81346"},
        {"Hipparcos Number", "HIP 46102"},
        {"Smithsonian Astrophysical Observation", "SAO 200325"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.02339026),
        dec: Angle.Degrees(-32.84233375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61051"},
        {"Hipparcos Number", "HIP 36964"},
        {"Geneva Identification System", "GEN# +1.00061051"},
        {"Smithsonian Astrophysical Observation", "SAO 198171"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98359651),
        dec: Angle.Degrees(-32.84109152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75044"},
        {"Hipparcos Number", "HIP 43081"},
        {"Smithsonian Astrophysical Observation", "SAO 199602"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.62701938),
        dec: Angle.Degrees(-32.84078522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40539"},
        {"Hipparcos Number", "HIP 28236"},
        {"Smithsonian Astrophysical Observation", "SAO 196359"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.49141041),
        dec: Angle.Degrees(-32.83687353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134142"},
        {"Hipparcos Number", "HIP 74166"},
        {"Smithsonian Astrophysical Observation", "SAO 206342"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.31170104),
        dec: Angle.Degrees(-32.83553297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131901"},
        {"Hipparcos Number", "HIP 73174"},
        {"Geneva Identification System", "GEN# +1.00131901"},
        {"Smithsonian Astrophysical Observation", "SAO 206126"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.33279175),
        dec: Angle.Degrees(-32.83366979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100623"},
        {"Hipparcos Number", "HIP 56452"},
        {"Cincinnati Publication", "Ci 20 648"},
        {"Geneva Identification System", "GEN# +1.00100623"},
        {"Smithsonian Astrophysical Observation", "SAO 202583"},
        {"Wilson Evans Batten Catalogue", "WEB 10144"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.62480364),
        dec: Angle.Degrees(-32.83334205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -670.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 823.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91919"},
        {"Hipparcos Number", "HIP 51911"},
        {"Celescope Catalog", "CEL 3588"},
        {"Geneva Identification System", "GEN# +1.00091919"},
        {"Smithsonian Astrophysical Observation", "SAO 201552"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.07834309),
        dec: Angle.Degrees(-32.83104202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47765"},
        {"Hipparcos Number", "HIP 31794"},
        {"Smithsonian Astrophysical Observation", "SAO 197036"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.71527013),
        dec: Angle.Degrees(-32.83097842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108323"},
        {"Hipparcos Number", "HIP 60735"},
        {"Fundamental Katalog 5th Edition", "FK5 463"},
        {"Geneva Identification System", "GEN# +1.00108323"},
        {"Smithsonian Astrophysical Observation", "SAO 203477"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.71539248),
        dec: Angle.Degrees(-32.83004764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20216"},
        {"Hipparcos Number", "HIP 15043"},
        {"Smithsonian Astrophysical Observation", "SAO 194170"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47248344),
        dec: Angle.Degrees(-32.82947218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156782"},
        {"Hipparcos Number", "HIP 84891"},
        {"Smithsonian Astrophysical Observation", "SAO 208711"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.23801491),
        dec: Angle.Degrees(-32.82786365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10787"},
        {"Hipparcos Number", "HIP 8157"},
        {"Smithsonian Astrophysical Observation", "SAO 193283"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.22695334),
        dec: Angle.Degrees(-32.82676398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16032"},
        {"Hipparcos Number", "HIP 11905"},
        {"Smithsonian Astrophysical Observation", "SAO 193768"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.40313776),
        dec: Angle.Degrees(-32.82641936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200538"},
        {"Hipparcos Number", "HIP 104071"},
        {"Geneva Identification System", "GEN# +1.00200538"},
        {"Smithsonian Astrophysical Observation", "SAO 212692"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.27061232),
        dec: Angle.Degrees(-32.82615395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112618"},
        {"Hipparcos Number", "HIP 63300"},
        {"Geneva Identification System", "GEN# +1.00112618"},
        {"Smithsonian Astrophysical Observation", "SAO 203988"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.58042046),
        dec: Angle.Degrees(-32.82423325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36142"},
        {"Hipparcos Number", "HIP 25602"},
        {"Smithsonian Astrophysical Observation", "SAO 195884"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.05488973),
        dec: Angle.Degrees(-32.82292712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7381"},
        {"Hipparcos Number", "HIP 5706"},
        {"Smithsonian Astrophysical Observation", "SAO 192989"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.35068656),
        dec: Angle.Degrees(-32.82080290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217959"},
        {"Hipparcos Number", "HIP 113959"},
        {"Geneva Identification System", "GEN# +1.00217959"},
        {"Smithsonian Astrophysical Observation", "SAO 214290"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.16687127),
        dec: Angle.Degrees(-32.81938227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139035"},
        {"Hipparcos Number", "HIP 76464"},
        {"Geneva Identification System", "GEN# +1.00139035"},
        {"Smithsonian Astrophysical Observation", "SAO 206806"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.24505647),
        dec: Angle.Degrees(-32.81639039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151"},
        {"Hipparcos Number", "HIP 516"},
        {"Smithsonian Astrophysical Observation", "SAO 192357"},
        {"Wilson Evans Batten Catalogue", "WEB 86"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.55910676),
        dec: Angle.Degrees(-32.81635348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28313"},
        {"Hipparcos Number", "HIP 20727"},
        {"Geneva Identification System", "GEN# +1.00028313"},
        {"Smithsonian Astrophysical Observation", "SAO 195019"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.62706920),
        dec: Angle.Degrees(-32.81632164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125948"},
        {"Hipparcos Number", "HIP 70332"},
        {"Smithsonian Astrophysical Observation", "SAO 205507"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.85030730),
        dec: Angle.Degrees(-32.81527660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92393"},
        {"Hipparcos Number", "HIP 52165"},
        {"Smithsonian Astrophysical Observation", "SAO 201602"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.86454189),
        dec: Angle.Degrees(-32.81372539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131500"},
        {"Hipparcos Number", "HIP 72985"},
        {"Smithsonian Astrophysical Observation", "SAO 206085"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.72883667),
        dec: Angle.Degrees(-32.81310317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129787"},
        {"Hipparcos Number", "HIP 72149"},
        {"Smithsonian Astrophysical Observation", "SAO 205907"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.35866441),
        dec: Angle.Degrees(-32.81031112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25963"},
        {"Hipparcos Number", "HIP 19080"},
        {"Smithsonian Astrophysical Observation", "SAO 194751"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.35473557),
        dec: Angle.Degrees(-32.80963905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39294"},
        {"Hipparcos Number", "HIP 27555"},
        {"Smithsonian Astrophysical Observation", "SAO 196225"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.53895963),
        dec: Angle.Degrees(-32.80921962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141327"},
        {"Hipparcos Number", "HIP 77523"},
        {"Geneva Identification System", "GEN# +1.00141327"},
        {"Smithsonian Astrophysical Observation", "SAO 207020"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.42963963),
        dec: Angle.Degrees(-32.80822983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39763"},
        {"Hipparcos Number", "HIP 27821"},
        {"Smithsonian Astrophysical Observation", "SAO 196278"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.31066652),
        dec: Angle.Degrees(-32.80652860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11597"},
        {"Hipparcos Number", "HIP 8807"},
        {"Geneva Identification System", "GEN# +1.00011597"},
        {"Smithsonian Astrophysical Observation", "SAO 193364"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.29803721),
        dec: Angle.Degrees(-32.80632998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216042"},
        {"Hipparcos Number", "HIP 112746"},
        {"Geneva Identification System", "GEN# +1.00216042J"},
        {"Smithsonian Astrophysical Observation", "SAO 214119"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.49685641),
        dec: Angle.Degrees(-32.80539996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114335"},
        {"Hipparcos Number", "HIP 64264"},
        {"Geneva Identification System", "GEN# +1.00114335"},
        {"Smithsonian Astrophysical Observation", "SAO 204187"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58124970),
        dec: Angle.Degrees(-32.80537809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57349"},
        {"Hipparcos Number", "HIP 35489"},
        {"Geneva Identification System", "GEN# +1.00057349"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86863914),
        dec: Angle.Degrees(-32.80529135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211396"},
        {"Hipparcos Number", "HIP 110052"},
        {"Smithsonian Astrophysical Observation", "SAO 213702"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.36011388),
        dec: Angle.Degrees(-32.80398343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56259"},
        {"Hipparcos Number", "HIP 35058"},
        {"Geneva Identification System", "GEN# +1.00056259"},
        {"Smithsonian Astrophysical Observation", "SAO 197748"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.74908364),
        dec: Angle.Degrees(-32.80300810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55427"},
        {"Hipparcos Number", "HIP 34728"},
        {"Smithsonian Astrophysical Observation", "SAO 197676"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.86111218),
        dec: Angle.Degrees(-32.80270329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104914"},
        {"Hipparcos Number", "HIP 58912"},
        {"Geneva Identification System", "GEN# +1.00104914"},
        {"Smithsonian Astrophysical Observation", "SAO 203106"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.20839466),
        dec: Angle.Degrees(-32.80242829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168311"},
        {"Hipparcos Number", "HIP 89883"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11411097),
        dec: Angle.Degrees(-32.80138239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118163"},
        {"Hipparcos Number", "HIP 66332"},
        {"Smithsonian Astrophysical Observation", "SAO 204632"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.90926711),
        dec: Angle.Degrees(-32.80047978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 705"},
        {"Hipparcos Number", "HIP 914"},
        {"Geneva Identification System", "GEN# +1.00000705A"},
        {"Smithsonian Astrophysical Observation", "SAO 192385"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.82543312),
        dec: Angle.Degrees(-32.80041484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103465"},
        {"Smithsonian Astrophysical Observation", "SAO 212577"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.42967108),
        dec: Angle.Degrees(-32.79982748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34215"},
        {"Hipparcos Number", "HIP 24414"},
        {"Smithsonian Astrophysical Observation", "SAO 195677"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.57587852),
        dec: Angle.Degrees(-32.79530135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26799"},
        {"Hipparcos Number", "HIP 19688"},
        {"Smithsonian Astrophysical Observation", "SAO 194836"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.26026268),
        dec: Angle.Degrees(-32.79493419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218543"},
        {"Hipparcos Number", "HIP 114319"},
        {"Smithsonian Astrophysical Observation", "SAO 214343"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.27435820),
        dec: Angle.Degrees(-32.79284975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94503"},
        {"Hipparcos Number", "HIP 53303"},
        {"Smithsonian Astrophysical Observation", "SAO 201874"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.52849506),
        dec: Angle.Degrees(-32.79200877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130372"},
        {"Hipparcos Number", "HIP 72439"},
        {"Smithsonian Astrophysical Observation", "SAO 205970"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.19363780),
        dec: Angle.Degrees(-32.78921179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32405"},
        {"Smithsonian Astrophysical Observation", "SAO 197186"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.47986464),
        dec: Angle.Degrees(-32.78890479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150419"},
        {"Hipparcos Number", "HIP 81789"},
        {"Geneva Identification System", "GEN# +1.00150419"},
        {"Smithsonian Astrophysical Observation", "SAO 207941"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57348689),
        dec: Angle.Degrees(-32.78881780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203488"},
        {"Hipparcos Number", "HIP 105616"},
        {"Smithsonian Astrophysical Observation", "SAO 212966"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.87110148),
        dec: Angle.Degrees(-32.78790393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18415"},
        {"Hipparcos Number", "HIP 13711"},
        {"Geneva Identification System", "GEN# +1.00018415"},
        {"Smithsonian Astrophysical Observation", "SAO 193993"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.13180428),
        dec: Angle.Degrees(-32.78710669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112563"},
        {"Smithsonian Astrophysical Observation", "SAO 214092"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.97413840),
        dec: Angle.Degrees(-32.78573433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142770"},
        {"Hipparcos Number", "HIP 78151"},
        {"Geneva Identification System", "GEN# +1.00142770"},
        {"Smithsonian Astrophysical Observation", "SAO 207157"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.37223336),
        dec: Angle.Degrees(-32.78545696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97665"},
        {"Hipparcos Number", "HIP 54861"},
        {"Smithsonian Astrophysical Observation", "SAO 202222"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.49961057),
        dec: Angle.Degrees(-32.78439636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40610"},
        {"Hipparcos Number", "HIP 28282"},
        {"Smithsonian Astrophysical Observation", "SAO 196369"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.63948482),
        dec: Angle.Degrees(-32.78122735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95406"},
        {"Hipparcos Number", "HIP 53792"},
        {"Geneva Identification System", "GEN# +1.00095406"},
        {"Smithsonian Astrophysical Observation", "SAO 201996"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.08923951),
        dec: Angle.Degrees(-32.78074429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75605"},
        {"Hipparcos Number", "HIP 43352"},
        {"Fundamental Katalog 5th Edition", "FK5 2696"},
        {"Geneva Identification System", "GEN# +1.00075605"},
        {"Smithsonian Astrophysical Observation", "SAO 199678"},
        {"Wilson Evans Batten Catalogue", "WEB 8352"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.46458755),
        dec: Angle.Degrees(-32.78040797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20011"},
        {"Hipparcos Number", "HIP 14858"},
        {"Smithsonian Astrophysical Observation", "SAO 194146"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.96933484),
        dec: Angle.Degrees(-32.78004080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48186"},
        {"Hipparcos Number", "HIP 31958"},
        {"Smithsonian Astrophysical Observation", "SAO 197079"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.18451066),
        dec: Angle.Degrees(-32.77825100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108401"},
        {"Hipparcos Number", "HIP 60767"},
        {"Smithsonian Astrophysical Observation", "SAO 203489"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.84376587),
        dec: Angle.Degrees(-32.77713534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11573"},
        {"Hipparcos Number", "HIP 8784"},
        {"Geneva Identification System", "GEN# +1.00011573"},
        {"Smithsonian Astrophysical Observation", "SAO 193361"},
        {"Wilson Evans Batten Catalogue", "WEB 1849"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.24830556),
        dec: Angle.Degrees(-32.77691841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169541"},
        {"Hipparcos Number", "HIP 90386"},
        {"Smithsonian Astrophysical Observation", "SAO 210154"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.64593477),
        dec: Angle.Degrees(-32.77519302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213954"},
        {"Hipparcos Number", "HIP 111510"},
        {"Smithsonian Astrophysical Observation", "SAO 213934"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.88034848),
        dec: Angle.Degrees(-32.77248155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151889"},
        {"Hipparcos Number", "HIP 82494"},
        {"Smithsonian Astrophysical Observation", "SAO 208098"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.89446619),
        dec: Angle.Degrees(-32.77155715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129216"},
        {"Hipparcos Number", "HIP 71890"},
        {"Fundamental Katalog 5th Edition", "FK5 3164"},
        {"Geneva Identification System", "GEN# +1.00129216"},
        {"Smithsonian Astrophysical Observation", "SAO 205846"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.55502723),
        dec: Angle.Degrees(-32.76999952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1620"},
        {"Hipparcos Number", "HIP 1625"},
        {"Geneva Identification System", "GEN# +1.00001620J"},
        {"Smithsonian Astrophysical Observation", "SAO 192468"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.07658522),
        dec: Angle.Degrees(-32.76912947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 252.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50863"},
        {"Smithsonian Astrophysical Observation", "SAO 201341"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.78920915),
        dec: Angle.Degrees(-32.76822941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3846"},
        {"Hipparcos Number", "HIP 3200"},
        {"Smithsonian Astrophysical Observation", "SAO 192675"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19431069),
        dec: Angle.Degrees(-32.76663850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87604"},
        {"Hipparcos Number", "HIP 49421"},
        {"Smithsonian Astrophysical Observation", "SAO 201035"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.32075426),
        dec: Angle.Degrees(-32.76638605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187154"},
        {"Hipparcos Number", "HIP 97557"},
        {"Geneva Identification System", "GEN# +1.00187154"},
        {"Smithsonian Astrophysical Observation", "SAO 211583"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.43341688),
        dec: Angle.Degrees(-32.76381290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145132"},
        {"Hipparcos Number", "HIP 79258"},
        {"Smithsonian Astrophysical Observation", "SAO 207419"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.64984125),
        dec: Angle.Degrees(-32.76183770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71445"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.16929570),
        dec: Angle.Degrees(-32.76173738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1233"},
        {"Hipparcos Number", "HIP 1315"},
        {"Fundamental Katalog 5th Edition", "FK5 4028"},
        {"Smithsonian Astrophysical Observation", "SAO 192437"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.13517115),
        dec: Angle.Degrees(-32.76040365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61558"},
        {"Hipparcos Number", "HIP 37188"},
        {"Smithsonian Astrophysical Observation", "SAO 198223"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60593709),
        dec: Angle.Degrees(-32.76036223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183766"},
        {"Hipparcos Number", "HIP 96103"},
        {"Smithsonian Astrophysical Observation", "SAO 211342"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.09410626),
        dec: Angle.Degrees(-32.75889274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94"},
        {"Smithsonian Astrophysical Observation", "SAO 214921"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.29485302),
        dec: Angle.Degrees(-32.75680569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122194"},
        {"Hipparcos Number", "HIP 68468"},
        {"Geneva Identification System", "GEN# +1.00122194"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26539276),
        dec: Angle.Degrees(-32.75666115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3729"},
        {"Geneva Identification System", "GEN# -0.03300302"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.96915044),
        dec: Angle.Degrees(-32.75569200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 246.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6671"},
        {"Hipparcos Number", "HIP 5234"},
        {"Smithsonian Astrophysical Observation", "SAO 192932"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.73154646),
        dec: Angle.Degrees(-32.75454723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114852"},
        {"Smithsonian Astrophysical Observation", "SAO 146597"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.95850397),
        dec: Angle.Degrees(-00.04067863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88429"},
        {"Hipparcos Number", "HIP 49883"},
        {"Geneva Identification System", "GEN# +1.00088429"},
        {"Smithsonian Astrophysical Observation", "SAO 201136"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79138168),
        dec: Angle.Degrees(-32.75385771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3849"},
        {"Hipparcos Number", "HIP 3219"},
        {"Smithsonian Astrophysical Observation", "SAO 192676"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.23253645),
        dec: Angle.Degrees(-32.75119249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215936"},
        {"Hipparcos Number", "HIP 112688"},
        {"Smithsonian Astrophysical Observation", "SAO 214107"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.30043494),
        dec: Angle.Degrees(-32.75073474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41670"},
        {"Smithsonian Astrophysical Observation", "SAO 199292"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.43548120),
        dec: Angle.Degrees(-32.74968849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172702"},
        {"Hipparcos Number", "HIP 91791"},
        {"Geneva Identification System", "GEN# +1.00172702"},
        {"Smithsonian Astrophysical Observation", "SAO 210492"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.75769991),
        dec: Angle.Degrees(-32.74946606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59593"},
        {"Hipparcos Number", "HIP 36373"},
        {"Smithsonian Astrophysical Observation", "SAO 198044"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30279419),
        dec: Angle.Degrees(-32.74618706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191826"},
        {"Hipparcos Number", "HIP 99620"},
        {"Geneva Identification System", "GEN# +1.00191826"},
        {"Smithsonian Astrophysical Observation", "SAO 211906"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.25086750),
        dec: Angle.Degrees(-32.74502885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6270"},
        {"Hipparcos Number", "HIP 4921"},
        {"Geneva Identification System", "GEN# +1.00006270"},
        {"Smithsonian Astrophysical Observation", "SAO 192892"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.79522525),
        dec: Angle.Degrees(-32.74280625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222335"},
        {"Hipparcos Number", "HIP 116763"},
        {"Geneva Identification System", "GEN# +1.00222335"},
        {"Smithsonian Astrophysical Observation", "SAO 214692"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.96338890),
        dec: Angle.Degrees(-32.74266588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22729"},
        {"Hipparcos Number", "HIP 16946"},
        {"Geneva Identification System", "GEN# +1.00022729"},
        {"Smithsonian Astrophysical Observation", "SAO 194414"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51417238),
        dec: Angle.Degrees(-32.74118873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193402"},
        {"Hipparcos Number", "HIP 100358"},
        {"Geneva Identification System", "GEN# +1.00193402"},
        {"Smithsonian Astrophysical Observation", "SAO 212030"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.30048460),
        dec: Angle.Degrees(-32.73930705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53990"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.66559806),
        dec: Angle.Degrees(-32.73819794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121354"},
        {"Hipparcos Number", "HIP 68008"},
        {"Smithsonian Astrophysical Observation", "SAO 204991"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.91147229),
        dec: Angle.Degrees(-32.73684820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119870"},
        {"Hipparcos Number", "HIP 67224"},
        {"Smithsonian Astrophysical Observation", "SAO 204828"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.62846284),
        dec: Angle.Degrees(-32.73608827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89596"},
        {"Hipparcos Number", "HIP 50565"},
        {"Smithsonian Astrophysical Observation", "SAO 201286"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.93765749),
        dec: Angle.Degrees(-32.73369959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41684"},
        {"Hipparcos Number", "HIP 28836"},
        {"Renson", "Renson 11120"},
        {"Smithsonian Astrophysical Observation", "SAO 196479"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.29700698),
        dec: Angle.Degrees(-32.73088795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141684"},
        {"Hipparcos Number", "HIP 77672"},
        {"Smithsonian Astrophysical Observation", "SAO 207047"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.86214703),
        dec: Angle.Degrees(-32.72946040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97631"},
        {"Smithsonian Astrophysical Observation", "SAO 211592"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.64642415),
        dec: Angle.Degrees(-32.72913587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28161"},
        {"Hipparcos Number", "HIP 20622"},
        {"Smithsonian Astrophysical Observation", "SAO 194998"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.27821002),
        dec: Angle.Degrees(-32.72711484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71922"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.65146888),
        dec: Angle.Degrees(-32.72626880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109988"},
        {"Hipparcos Number", "HIP 61743"},
        {"Geneva Identification System", "GEN# +1.00109988"},
        {"Smithsonian Astrophysical Observation", "SAO 203669"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81580894),
        dec: Angle.Degrees(-32.72591770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1681"},
        {"Hipparcos Number", "HIP 1679"},
        {"Smithsonian Astrophysical Observation", "SAO 192476"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.25310687),
        dec: Angle.Degrees(-32.72346591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2697"},
        {"Hipparcos Number", "HIP 2380"},
        {"Smithsonian Astrophysical Observation", "SAO 192572"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.59110136),
        dec: Angle.Degrees(-32.72317549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52220"},
        {"Hipparcos Number", "HIP 33610"},
        {"Geneva Identification System", "GEN# +1.00052220"},
        {"Smithsonian Astrophysical Observation", "SAO 197436"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.75176078),
        dec: Angle.Degrees(-32.72226518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5355"},
        {"Geneva Identification System", "GEN# +6.10080192"},
        {"Geneva Identification System 2", "GEN# -0.03300417"},
    },
    visualMagnitude: 12.23,
    bvColour: -0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.11158161),
        dec: Angle.Degrees(-32.71990145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165978"},
        {"Hipparcos Number", "HIP 89010"},
        {"Geneva Identification System", "GEN# +1.00165978"},
        {"Smithsonian Astrophysical Observation", "SAO 209794"},
        {"Wilson Evans Batten Catalogue", "WEB 15104"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.49984266),
        dec: Angle.Degrees(-32.71927087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16119"},
        {"Hipparcos Number", "HIP 11970"},
        {"Smithsonian Astrophysical Observation", "SAO 193779"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.60663379),
        dec: Angle.Degrees(-32.71841823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42431"},
        {"Smithsonian Astrophysical Observation", "SAO 199468"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.78419799),
        dec: Angle.Degrees(-32.71817061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4748"},
        {"Smithsonian Astrophysical Observation", "SAO 192867"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.25776305),
        dec: Angle.Degrees(-32.71788545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7704"},
        {"Hipparcos Number", "HIP 5937"},
        {"Geneva Identification System", "GEN# +1.00007704"},
        {"Smithsonian Astrophysical Observation", "SAO 193016"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.08729644),
        dec: Angle.Degrees(-32.71662814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46936"},
        {"Hipparcos Number", "HIP 31362"},
        {"Celescope Catalog", "CEL 1308"},
        {"Fundamental Katalog 5th Edition", "FK5 2506"},
        {"Geneva Identification System", "GEN# +1.00046936"},
        {"Smithsonian Astrophysical Observation", "SAO 196955"},
        {"Wilson Evans Batten Catalogue", "WEB 6276"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.64720407),
        dec: Angle.Degrees(-32.71626113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64222"},
        {"Hipparcos Number", "HIP 38367"},
        {"Smithsonian Astrophysical Observation", "SAO 198526"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.88815804),
        dec: Angle.Degrees(-32.71610860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92845"},
        {"Hipparcos Number", "HIP 52407"},
        {"Celescope Catalog", "CEL 3653"},
        {"Fundamental Katalog 5th Edition", "FK5 1277"},
        {"Geneva Identification System", "GEN# +1.00092845"},
        {"Smithsonian Astrophysical Observation", "SAO 201665"},
        {"Wilson Evans Batten Catalogue", "WEB 9536"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.68003687),
        dec: Angle.Degrees(-32.71567314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164270"},
        {"Hipparcos Number", "HIP 88287"},
        {"Geneva Identification System", "GEN# +1.00164270"},
        {"Smithsonian Astrophysical Observation", "SAO 209609"},
        {"Wilson Evans Batten Catalogue", "WEB 14921"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.42976685),
        dec: Angle.Degrees(-32.71532090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206958"},
        {"Hipparcos Number", "HIP 107504"},
        {"Smithsonian Astrophysical Observation", "SAO 213273"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.60048209),
        dec: Angle.Degrees(-32.71463715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48581"},
        {"Hipparcos Number", "HIP 32140"},
        {"Geneva Identification System", "GEN# +1.00048581"},
        {"Smithsonian Astrophysical Observation", "SAO 197115"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.68076977),
        dec: Angle.Degrees(-32.71277178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190332"},
        {"Hipparcos Number", "HIP 98977"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.41856504),
        dec: Angle.Degrees(-32.71250364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39128"},
        {"Smithsonian Astrophysical Observation", "SAO 198682"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06627257),
        dec: Angle.Degrees(-32.71172697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173875"},
        {"Hipparcos Number", "HIP 92329"},
        {"Smithsonian Astrophysical Observation", "SAO 210597"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.26292816),
        dec: Angle.Degrees(-32.71042949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193616"},
        {"Hipparcos Number", "HIP 100460"},
        {"Smithsonian Astrophysical Observation", "SAO 212054"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.58105518),
        dec: Angle.Degrees(-32.70850074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21149"},
        {"Hipparcos Number", "HIP 15816"},
        {"Geneva Identification System", "GEN# +1.00021149"},
        {"Smithsonian Astrophysical Observation", "SAO 194268"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.93586228),
        dec: Angle.Degrees(-32.70709299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183092"},
        {"Hipparcos Number", "HIP 95804"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.30378848),
        dec: Angle.Degrees(-32.70672987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 364"},
        {"Hipparcos Number", "HIP 673"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.07755792),
        dec: Angle.Degrees(-32.70083924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193994"},
        {"Hipparcos Number", "HIP 100635"},
        {"Geneva Identification System", "GEN# +1.00193994"},
        {"Smithsonian Astrophysical Observation", "SAO 212086"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.08525671),
        dec: Angle.Degrees(-32.70036208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132686"},
        {"Hipparcos Number", "HIP 73505"},
        {"Geneva Identification System", "GEN# +1.00132686"},
        {"Smithsonian Astrophysical Observation", "SAO 206213"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.35795680),
        dec: Angle.Degrees(-32.69817256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121036"},
        {"Hipparcos Number", "HIP 67843"},
        {"Geneva Identification System", "GEN# +1.00121036"},
        {"Smithsonian Astrophysical Observation", "SAO 204960"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.45139820),
        dec: Angle.Degrees(-32.69787490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19046"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.20941475),
        dec: Angle.Degrees(-32.69599726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143337"},
        {"Hipparcos Number", "HIP 78466"},
        {"Geneva Identification System", "GEN# +1.00143337"},
        {"Smithsonian Astrophysical Observation", "SAO 207230"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.27017126),
        dec: Angle.Degrees(-32.69501918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206725"},
        {"Hipparcos Number", "HIP 107370"},
        {"Smithsonian Astrophysical Observation", "SAO 213253"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.20845103),
        dec: Angle.Degrees(-32.69432231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184597"},
        {"Hipparcos Number", "HIP 96453"},
        {"Smithsonian Astrophysical Observation", "SAO 211406"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15030530),
        dec: Angle.Degrees(-32.69085841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16416"},
        {"Hipparcos Number", "HIP 12179"},
        {"Geneva Identification System", "GEN# +1.00016416"},
        {"Smithsonian Astrophysical Observation", "SAO 193809"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.23619722),
        dec: Angle.Degrees(-32.68982137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88619"},
        {"Hipparcos Number", "HIP 49997"},
        {"Smithsonian Astrophysical Observation", "SAO 201167"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.10928381),
        dec: Angle.Degrees(-32.68945893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163274"},
        {"Hipparcos Number", "HIP 87853"},
        {"Geneva Identification System", "GEN# +1.00163274"},
        {"Smithsonian Astrophysical Observation", "SAO 209503"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.20844882),
        dec: Angle.Degrees(-32.68887137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1259"},
        {"Hipparcos Number", "HIP 1330"},
        {"Smithsonian Astrophysical Observation", "SAO 192442"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17534757),
        dec: Angle.Degrees(-32.68837302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141698"},
        {"Hipparcos Number", "HIP 77679"},
        {"Smithsonian Astrophysical Observation", "SAO 207050"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.88382443),
        dec: Angle.Degrees(-32.68608960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171840"},
        {"Hipparcos Number", "HIP 91386"},
        {"Smithsonian Astrophysical Observation", "SAO 210384"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.58249229),
        dec: Angle.Degrees(-32.68550599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84580"},
        {"Hipparcos Number", "HIP 47873"},
        {"Geneva Identification System", "GEN# +1.00084580"},
        {"Smithsonian Astrophysical Observation", "SAO 200699"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.35144473),
        dec: Angle.Degrees(-32.68263182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211956"},
        {"Hipparcos Number", "HIP 110384"},
        {"Smithsonian Astrophysical Observation", "SAO 213761"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.37399870),
        dec: Angle.Degrees(-32.68254101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122916"},
        {"Hipparcos Number", "HIP 68821"},
        {"Geneva Identification System", "GEN# +1.00122916"},
        {"Smithsonian Astrophysical Observation", "SAO 205161"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.35142994),
        dec: Angle.Degrees(-32.67726605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215641"},
        {"Hipparcos Number", "HIP 112491"},
        {"Geneva Identification System", "GEN# +1.00215641"},
        {"Smithsonian Astrophysical Observation", "SAO 214078"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.78817781),
        dec: Angle.Degrees(-32.67523321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66888"},
        {"Hipparcos Number", "HIP 39487"},
        {"Geneva Identification System", "GEN# +1.00066888"},
        {"Smithsonian Astrophysical Observation", "SAO 198764"},
        {"Wilson Evans Batten Catalogue", "WEB 7720"},
    },
    visualMagnitude: 5.25,
    bvColour: 1.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.06747264),
        dec: Angle.Degrees(-32.67484684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156438"},
        {"Hipparcos Number", "HIP 84718"},
        {"Geneva Identification System", "GEN# +1.00156438"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76012442),
        dec: Angle.Degrees(-32.67292609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109038"},
        {"Hipparcos Number", "HIP 61159"},
        {"Smithsonian Astrophysical Observation", "SAO 203563"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.98529290),
        dec: Angle.Degrees(-32.67273731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89245"},
        {"Hipparcos Number", "HIP 50373"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.27592677),
        dec: Angle.Degrees(-32.67268190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317856"},
        {"Hipparcos Number", "HIP 86035"},
        {"Geneva Identification System", "GEN# +2.63830010"},
        {"New General Catalogue", "NGC 6383 10"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.73840542),
        dec: Angle.Degrees(-32.67247476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63464"},
        {"Hipparcos Number", "HIP 38035"},
        {"Geneva Identification System", "GEN# +1.00063464"},
        {"Smithsonian Astrophysical Observation", "SAO 198445"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.93035151),
        dec: Angle.Degrees(-32.67148896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161665"},
        {"Hipparcos Number", "HIP 87144"},
        {"Smithsonian Astrophysical Observation", "SAO 209277"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.07006410),
        dec: Angle.Degrees(-32.67106166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153764"},
        {"Hipparcos Number", "HIP 83404"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.69281688),
        dec: Angle.Degrees(-32.67072039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119267"},
        {"Hipparcos Number", "HIP 66916"},
        {"Fundamental Katalog 5th Edition", "FK5 5213"},
        {"Geneva Identification System", "GEN# +1.00119267"},
        {"Smithsonian Astrophysical Observation", "SAO 204759"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.70821759),
        dec: Angle.Degrees(-32.67019512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85061"},
        {"Hipparcos Number", "HIP 48116"},
        {"Renson", "Renson 24290"},
        {"Smithsonian Astrophysical Observation", "SAO 200756"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14847963),
        dec: Angle.Degrees(-32.66990873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116535"},
        {"Hipparcos Number", "HIP 65441"},
        {"Smithsonian Astrophysical Observation", "SAO 204437"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.17643799),
        dec: Angle.Degrees(-32.66928637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165184"},
        {"Hipparcos Number", "HIP 88677"},
        {"Geneva Identification System", "GEN# +1.00165184"},
        {"Smithsonian Astrophysical Observation", "SAO 209707"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.54641081),
        dec: Angle.Degrees(-32.66576808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120427"},
        {"Hipparcos Number", "HIP 67508"},
        {"Smithsonian Astrophysical Observation", "SAO 204884"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49743802),
        dec: Angle.Degrees(-32.66517640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213711"},
        {"Hipparcos Number", "HIP 111386"},
        {"Smithsonian Astrophysical Observation", "SAO 213915"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.49359351),
        dec: Angle.Degrees(-32.66297267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160840"},
        {"Hipparcos Number", "HIP 86751"},
        {"Smithsonian Astrophysical Observation", "SAO 209188"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.89662530),
        dec: Angle.Degrees(-32.66276161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156098"},
        {"Hipparcos Number", "HIP 84551"},
        {"Fundamental Katalog 5th Edition", "FK5 1452"},
        {"Geneva Identification System", "GEN# +1.00156098"},
        {"Smithsonian Astrophysical Observation", "SAO 208626"},
        {"Wilson Evans Batten Catalogue", "WEB 14275"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.26547645),
        dec: Angle.Degrees(-32.66270528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187910"},
        {"Hipparcos Number", "HIP 97896"},
        {"Smithsonian Astrophysical Observation", "SAO 211634"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.41256066),
        dec: Angle.Degrees(-32.66192421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105295"},
        {"Hipparcos Number", "HIP 59119"},
        {"Smithsonian Astrophysical Observation", "SAO 203147"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.84515964),
        dec: Angle.Degrees(-32.66182534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143134"},
        {"Hipparcos Number", "HIP 78350"},
        {"Smithsonian Astrophysical Observation", "SAO 207204"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.96579086),
        dec: Angle.Degrees(-32.66088153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7897"},
        {"Hipparcos Number", "HIP 6086"},
        {"Geneva Identification System", "GEN# +1.00007897"},
        {"Smithsonian Astrophysical Observation", "SAO 193039"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.53895204),
        dec: Angle.Degrees(-32.66021340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182417"},
        {"Hipparcos Number", "HIP 95531"},
        {"Smithsonian Astrophysical Observation", "SAO 211255"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.47954959),
        dec: Angle.Degrees(-32.65949988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5134"},
        {"Hipparcos Number", "HIP 4145"},
        {"Geneva Identification System", "GEN# +1.00005134"},
        {"Smithsonian Astrophysical Observation", "SAO 192794"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.24737703),
        dec: Angle.Degrees(-32.65853426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3561"},
        {"Hipparcos Number", "HIP 3011"},
        {"Smithsonian Astrophysical Observation", "SAO 192646"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.57852439),
        dec: Angle.Degrees(-32.65771937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96747"},
        {"Hipparcos Number", "HIP 54427"},
        {"Smithsonian Astrophysical Observation", "SAO 202119"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.05947480),
        dec: Angle.Degrees(-32.65537763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135487"},
        {"Hipparcos Number", "HIP 74736"},
        {"Smithsonian Astrophysical Observation", "SAO 206476"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.11234750),
        dec: Angle.Degrees(-32.65314427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139766"},
        {"Hipparcos Number", "HIP 76826"},
        {"Smithsonian Astrophysical Observation", "SAO 206868"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.28637186),
        dec: Angle.Degrees(-32.65291952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201990"},
        {"Hipparcos Number", "HIP 104820"},
        {"Smithsonian Astrophysical Observation", "SAO 212816"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54126402),
        dec: Angle.Degrees(-32.65198076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166425"},
        {"Hipparcos Number", "HIP 89176"},
        {"Geneva Identification System", "GEN# +1.00166425"},
        {"Smithsonian Astrophysical Observation", "SAO 209837"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.98597308),
        dec: Angle.Degrees(-32.65167113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79173"},
        {"Geneva Identification System", "GEN# +1.00144927J"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.38232104),
        dec: Angle.Degrees(-32.64893835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173556"},
        {"Hipparcos Number", "HIP 92197"},
        {"Smithsonian Astrophysical Observation", "SAO 210575"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.84876484),
        dec: Angle.Degrees(-32.64764297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148335"},
        {"Hipparcos Number", "HIP 80699"},
        {"Smithsonian Astrophysical Observation", "SAO 207694"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14850999),
        dec: Angle.Degrees(-32.64761100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132379"},
        {"Hipparcos Number", "HIP 73387"},
        {"Smithsonian Astrophysical Observation", "SAO 206180"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.96496943),
        dec: Angle.Degrees(-32.64585442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7631"},
        {"Hipparcos Number", "HIP 5893"},
        {"Geneva Identification System", "GEN# +1.00007631"},
        {"Smithsonian Astrophysical Observation", "SAO 193011"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.92768467),
        dec: Angle.Degrees(-32.64426505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62150"},
        {"Hipparcos Number", "HIP 37444"},
        {"Geneva Identification System", "GEN# +1.00062150"},
        {"Smithsonian Astrophysical Observation", "SAO 198293"},
        {"Wilson Evans Batten Catalogue", "WEB 7406"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.30552389),
        dec: Angle.Degrees(-32.64395550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132955"},
        {"Hipparcos Number", "HIP 73624"},
        {"Fundamental Katalog 5th Edition", "FK5 3186"},
        {"Geneva Identification System", "GEN# +1.00132955"},
        {"Smithsonian Astrophysical Observation", "SAO 206239"},
        {"Wilson Evans Batten Catalogue", "WEB 12589"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.74704341),
        dec: Angle.Degrees(-32.64324605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222607"},
        {"Hipparcos Number", "HIP 116934"},
        {"Smithsonian Astrophysical Observation", "SAO 214718"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.53894549),
        dec: Angle.Degrees(-32.64210236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92585"},
        {"Smithsonian Astrophysical Observation", "SAO 210649"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.99022724),
        dec: Angle.Degrees(-32.64146902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53067"},
        {"Smithsonian Astrophysical Observation", "SAO 201830"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.86144563),
        dec: Angle.Degrees(-32.64101424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89691"},
    },
    visualMagnitude: 11.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.56327210),
        dec: Angle.Degrees(-32.64044580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214674"},
        {"Hipparcos Number", "HIP 111933"},
        {"Geneva Identification System", "GEN# +1.00214674"},
        {"Smithsonian Astrophysical Observation", "SAO 213999"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.09329959),
        dec: Angle.Degrees(-32.63860639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21817"},
        {"Hipparcos Number", "HIP 16278"},
        {"Renson", "Renson 5470"},
        {"Smithsonian Astrophysical Observation", "SAO 194336"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.46651396),
        dec: Angle.Degrees(-32.63832574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23638"},
        {"Hipparcos Number", "HIP 17542"},
        {"Smithsonian Astrophysical Observation", "SAO 194505"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.34646599),
        dec: Angle.Degrees(-32.63735122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142077"},
        {"Hipparcos Number", "HIP 77844"},
        {"Smithsonian Astrophysical Observation", "SAO 207092"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.41666266),
        dec: Angle.Degrees(-32.63713608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131774"},
        {"Hipparcos Number", "HIP 73107"},
        {"Geneva Identification System", "GEN# +1.00131774"},
        {"Smithsonian Astrophysical Observation", "SAO 206112"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.12862034),
        dec: Angle.Degrees(-32.63670976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126686"},
        {"Hipparcos Number", "HIP 70719"},
        {"Smithsonian Astrophysical Observation", "SAO 205581"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.94777970),
        dec: Angle.Degrees(-32.63593035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206454"},
        {"Hipparcos Number", "HIP 107227"},
        {"Smithsonian Astrophysical Observation", "SAO 213229"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.76339063),
        dec: Angle.Degrees(-32.63587321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186403"},
        {"Hipparcos Number", "HIP 97214"},
        {"Smithsonian Astrophysical Observation", "SAO 211536"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.36109439),
        dec: Angle.Degrees(-32.63414887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105904"},
        {"Hipparcos Number", "HIP 59420"},
        {"Geneva Identification System", "GEN# +1.00105904"},
        {"Smithsonian Astrophysical Observation", "SAO 203213"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84020568),
        dec: Angle.Degrees(-32.63267563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137412"},
        {"Hipparcos Number", "HIP 75618"},
        {"Smithsonian Astrophysical Observation", "SAO 206659"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.76174845),
        dec: Angle.Degrees(-32.63247892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2438"},
        {"Smithsonian Astrophysical Observation", "SAO 192583"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76293624),
        dec: Angle.Degrees(-32.63181615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65924"},
        {"Geneva Identification System", "GEN# +9.85911024"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.72078963),
        dec: Angle.Degrees(-32.62931409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -581.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37811"},
        {"Hipparcos Number", "HIP 26649"},
        {"Geneva Identification System", "GEN# +1.00037811"},
        {"Smithsonian Astrophysical Observation", "SAO 196061"},
        {"Wilson Evans Batten Catalogue", "WEB 5255"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.95771446),
        dec: Angle.Degrees(-32.62913912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188884"},
        {"Hipparcos Number", "HIP 98319"},
        {"Geneva Identification System", "GEN# +1.00188884"},
        {"Smithsonian Astrophysical Observation", "SAO 211701"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.64161195),
        dec: Angle.Degrees(-32.62909660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100156"},
        {"Hipparcos Number", "HIP 56212"},
        {"Smithsonian Astrophysical Observation", "SAO 202529"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.85280591),
        dec: Angle.Degrees(-32.62736293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205220"},
        {"Hipparcos Number", "HIP 106549"},
        {"Smithsonian Astrophysical Observation", "SAO 213107"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.68771325),
        dec: Angle.Degrees(-32.62511695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138220"},
        {"Hipparcos Number", "HIP 76037"},
        {"Smithsonian Astrophysical Observation", "SAO 206729"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93664352),
        dec: Angle.Degrees(-32.62351607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221882"},
        {"Hipparcos Number", "HIP 116475"},
        {"Smithsonian Astrophysical Observation", "SAO 214646"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.01486218),
        dec: Angle.Degrees(-32.62340194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36925"},
        {"Hipparcos Number", "HIP 26068"},
        {"Smithsonian Astrophysical Observation", "SAO 195960"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.40619566),
        dec: Angle.Degrees(-32.62237075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155014"},
        {"Hipparcos Number", "HIP 84013"},
        {"Smithsonian Astrophysical Observation", "SAO 208493"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.60618113),
        dec: Angle.Degrees(-32.62108253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35023"},
        {"Hipparcos Number", "HIP 24912"},
        {"Smithsonian Astrophysical Observation", "SAO 195761"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.08918356),
        dec: Angle.Degrees(-32.61978585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5331"},
        {"Hipparcos Number", "HIP 4282"},
        {"Smithsonian Astrophysical Observation", "SAO 192814"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.71057969),
        dec: Angle.Degrees(-32.61931789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193174"},
        {"Hipparcos Number", "HIP 100253"},
        {"Geneva Identification System", "GEN# +1.00193174"},
        {"Smithsonian Astrophysical Observation", "SAO 212012"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.99238895),
        dec: Angle.Degrees(-32.61651020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99428"},
        {"Hipparcos Number", "HIP 55814"},
        {"Smithsonian Astrophysical Observation", "SAO 202442"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.56446481),
        dec: Angle.Degrees(-32.61619758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96307"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.72198191),
        dec: Angle.Degrees(-32.61573153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140900"},
        {"Hipparcos Number", "HIP 77330"},
        {"Smithsonian Astrophysical Observation", "SAO 206974"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.81582828),
        dec: Angle.Degrees(-32.61494709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33739"},
        {"Hipparcos Number", "HIP 24134"},
        {"Smithsonian Astrophysical Observation", "SAO 195624"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74834785),
        dec: Angle.Degrees(-32.61484660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38553"},
        {"Hipparcos Number", "HIP 27137"},
        {"Smithsonian Astrophysical Observation", "SAO 196137"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.31013731),
        dec: Angle.Degrees(-32.61448293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153888"},
        {"Hipparcos Number", "HIP 83465"},
        {"Smithsonian Astrophysical Observation", "SAO 208354"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.88850397),
        dec: Angle.Degrees(-32.61400634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77331"},
    },
    visualMagnitude: 10.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.81870623),
        dec: Angle.Degrees(-32.61328047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101656"},
        {"Smithsonian Astrophysical Observation", "SAO 212276"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.09520608),
        dec: Angle.Degrees(-32.61113247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195282"},
        {"Hipparcos Number", "HIP 101253"},
        {"Smithsonian Astrophysical Observation", "SAO 212197"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.86183018),
        dec: Angle.Degrees(-32.61012317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192614"},
        {"Hipparcos Number", "HIP 99966"},
        {"Smithsonian Astrophysical Observation", "SAO 211959"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.22801013),
        dec: Angle.Degrees(-32.60751054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49779"},
        {"Geneva Identification System", "GEN# -0.03108004"},
        {"Smithsonian Astrophysical Observation", "SAO 201113"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.42033768),
        dec: Angle.Degrees(-32.60706620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190757"},
        {"Hipparcos Number", "HIP 99148"},
        {"Smithsonian Astrophysical Observation", "SAO 211831"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93189622),
        dec: Angle.Degrees(-32.60654916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15875"},
        {"Hipparcos Number", "HIP 11794"},
        {"Smithsonian Astrophysical Observation", "SAO 193757"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.04719534),
        dec: Angle.Degrees(-32.60632444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182464"},
        {"Hipparcos Number", "HIP 95555"},
        {"Smithsonian Astrophysical Observation", "SAO 211259"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.53298687),
        dec: Angle.Degrees(-32.60632236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68364"},
        {"Hipparcos Number", "HIP 40044"},
        {"Celescope Catalog", "CEL 2206"},
        {"Geneva Identification System", "GEN# +1.00068364J"},
        {"Smithsonian Astrophysical Observation", "SAO 198888"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.69860073),
        dec: Angle.Degrees(-32.60403609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44463"},
        {"Hipparcos Number", "HIP 30135"},
        {"Smithsonian Astrophysical Observation", "SAO 196703"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.12803845),
        dec: Angle.Degrees(-32.60226719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109326"},
        {"Smithsonian Astrophysical Observation", "SAO 213588"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23208012),
        dec: Angle.Degrees(-32.60061195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95090"},
        {"Hipparcos Number", "HIP 53628"},
        {"Geneva Identification System", "GEN# +1.00095090"},
        {"Smithsonian Astrophysical Observation", "SAO 201954"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.57023766),
        dec: Angle.Degrees(-32.59960432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115392"},
        {"Hipparcos Number", "HIP 64824"},
        {"Smithsonian Astrophysical Observation", "SAO 204321"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.32972152),
        dec: Angle.Degrees(-32.59958682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101347"},
        {"Hipparcos Number", "HIP 56880"},
        {"Smithsonian Astrophysical Observation", "SAO 202678"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90872814),
        dec: Angle.Degrees(-32.59901475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32999"},
        {"Hipparcos Number", "HIP 23705"},
        {"Smithsonian Astrophysical Observation", "SAO 195550"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.43600488),
        dec: Angle.Degrees(-32.59882852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72954"},
        {"Hipparcos Number", "HIP 42075"},
        {"Geneva Identification System", "GEN# +1.00072954J"},
        {"Smithsonian Astrophysical Observation", "SAO 199388"},
        {"Wilson Evans Batten Catalogue", "WEB 8089"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.63313216),
        dec: Angle.Degrees(-32.59839612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176495"},
        {"Hipparcos Number", "HIP 93446"},
        {"Geneva Identification System", "GEN# +1.00176495"},
        {"Smithsonian Astrophysical Observation", "SAO 210836"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.46941160),
        dec: Angle.Degrees(-32.59723662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210284"},
        {"Hipparcos Number", "HIP 109407"},
        {"Smithsonian Astrophysical Observation", "SAO 213600"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.49028810),
        dec: Angle.Degrees(-32.59244081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25419"},
        {"Hipparcos Number", "HIP 18760"},
        {"Smithsonian Astrophysical Observation", "SAO 194696"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.27612603),
        dec: Angle.Degrees(-32.58949156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107183"},
        {"Hipparcos Number", "HIP 60102"},
        {"Fundamental Katalog 5th Edition", "FK5 5090"},
        {"Smithsonian Astrophysical Observation", "SAO 203351"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.88394219),
        dec: Angle.Degrees(-32.58883396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96006"},
        {"Hipparcos Number", "HIP 54092"},
        {"Smithsonian Astrophysical Observation", "SAO 202051"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.02695515),
        dec: Angle.Degrees(-32.58862502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200187"},
        {"Hipparcos Number", "HIP 103883"},
        {"Smithsonian Astrophysical Observation", "SAO 212667"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74272960),
        dec: Angle.Degrees(-32.58800488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207508"},
        {"Hipparcos Number", "HIP 107795"},
        {"Smithsonian Astrophysical Observation", "SAO 213326"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.55135757),
        dec: Angle.Degrees(-32.58762845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57945"},
        {"Hipparcos Number", "HIP 35716"},
        {"Geneva Identification System", "GEN# +5.11400006"},
        {"Smithsonian Astrophysical Observation", "SAO 197900"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.53444547),
        dec: Angle.Degrees(-32.58732974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96557"},
        {"Hipparcos Number", "HIP 54349"},
        {"Geneva Identification System", "GEN# +1.00096557"},
        {"Smithsonian Astrophysical Observation", "SAO 202100"},
        {"Wilson Evans Batten Catalogue", "WEB 9815"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.78504233),
        dec: Angle.Degrees(-32.58691701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86124"},
        {"Hipparcos Number", "HIP 48690"},
        {"Smithsonian Astrophysical Observation", "SAO 200872"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.94476560),
        dec: Angle.Degrees(-32.58635611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157793"},
        {"Hipparcos Number", "HIP 85383"},
        {"Geneva Identification System", "GEN# +1.00157793"},
        {"Smithsonian Astrophysical Observation", "SAO 208825"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.70192656),
        dec: Angle.Degrees(-32.58240806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159176"},
        {"Hipparcos Number", "HIP 86011"},
        {"Geneva Identification System", "GEN# +2.63830001"},
        {"Smithsonian Astrophysical Observation", "SAO 208977"},
        {"Wilson Evans Batten Catalogue", "WEB 14510"},
        {"New General Catalogue", "NGC 6383 1"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.67704498),
        dec: Angle.Degrees(-32.58165772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76444"},
        {"Smithsonian Astrophysical Observation", "SAO 206802"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.18990370),
        dec: Angle.Degrees(-32.58142583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45813"},
        {"Hipparcos Number", "HIP 30788"},
        {"Celescope Catalog", "CEL 1258"},
        {"Geneva Identification System", "GEN# +1.00045813"},
        {"Smithsonian Astrophysical Observation", "SAO 196857"},
        {"Wilson Evans Batten Catalogue", "WEB 6139"},
    },
    visualMagnitude: 4.47,
    bvColour: -0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.04257272),
        dec: Angle.Degrees(-32.58012947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177871"},
        {"Hipparcos Number", "HIP 93955"},
        {"Geneva Identification System", "GEN# +1.00177871"},
        {"Smithsonian Astrophysical Observation", "SAO 210957"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.95468682),
        dec: Angle.Degrees(-32.57993864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61827"},
        {"Hipparcos Number", "HIP 37334"},
        {"Geneva Identification System", "GEN# +1.00061827"},
        {"Smithsonian Astrophysical Observation", "SAO 198264"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.95558127),
        dec: Angle.Degrees(-32.57837840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146218"},
        {"Hipparcos Number", "HIP 79738"},
        {"Smithsonian Astrophysical Observation", "SAO 207502"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.10357349),
        dec: Angle.Degrees(-32.57800023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46966"},
        {"Smithsonian Astrophysical Observation", "SAO 200512"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.59012291),
        dec: Angle.Degrees(-32.57769409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73139"},
        {"Hipparcos Number", "HIP 42155"},
        {"Smithsonian Astrophysical Observation", "SAO 199407"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.90312922),
        dec: Angle.Degrees(-32.57239583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2615"},
        {"Hipparcos Number", "HIP 2319"},
        {"Cincinnati Publication", "Ci 18 51"},
        {"Geneva Identification System", "GEN# +1.00002615"},
        {"Smithsonian Astrophysical Observation", "SAO 192565"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.39497842),
        dec: Angle.Degrees(-32.56943621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141093"},
        {"Hipparcos Number", "HIP 77420"},
        {"Smithsonian Astrophysical Observation", "SAO 206996"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.08205171),
        dec: Angle.Degrees(-32.56788337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9652"},
        {"Hipparcos Number", "HIP 7308"},
        {"Cincinnati Publication", "Ci 18 213"},
        {"Geneva Identification System", "GEN# +1.00009652"},
        {"Smithsonian Astrophysical Observation", "SAO 193181"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.52058117),
        dec: Angle.Degrees(-32.56506873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97145"},
        {"Hipparcos Number", "HIP 54611"},
        {"Smithsonian Astrophysical Observation", "SAO 202165"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.64433384),
        dec: Angle.Degrees(-32.56392623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56186"},
        {"Hipparcos Number", "HIP 35024"},
        {"Geneva Identification System", "GEN# +1.00056186"},
        {"Smithsonian Astrophysical Observation", "SAO 197740"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.67067272),
        dec: Angle.Degrees(-32.56291563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86766"},
        {"Hipparcos Number", "HIP 49012"},
        {"Smithsonian Astrophysical Observation", "SAO 200945"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.98311813),
        dec: Angle.Degrees(-32.56253258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215983"},
        {"Hipparcos Number", "HIP 112709"},
        {"Renson", "Renson 59660"},
        {"Smithsonian Astrophysical Observation", "SAO 214113"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.36959680),
        dec: Angle.Degrees(-32.55964292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91400"},
        {"Hipparcos Number", "HIP 51618"},
        {"Smithsonian Astrophysical Observation", "SAO 201498"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.18212292),
        dec: Angle.Degrees(-32.55962359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113084"},
        {"Hipparcos Number", "HIP 63562"},
        {"Geneva Identification System", "GEN# +1.00113084"},
        {"Smithsonian Astrophysical Observation", "SAO 204047"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.38915312),
        dec: Angle.Degrees(-32.55918637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66673"},
        {"Geneva Identification System", "GEN# +9.80064012"},
        {"Geneva Identification System 2", "GEN# +7.01050815"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.01094127),
        dec: Angle.Degrees(-00.03834680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217392"},
        {"Hipparcos Number", "HIP 113615"},
        {"Smithsonian Astrophysical Observation", "SAO 214242"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.16993704),
        dec: Angle.Degrees(-32.55833733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39004"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.72900017),
        dec: Angle.Degrees(-32.55769900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19237"},
        {"Hipparcos Number", "HIP 14324"},
        {"Smithsonian Astrophysical Observation", "SAO 194070"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.18626858),
        dec: Angle.Degrees(-32.55764525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90072"},
        {"Hipparcos Number", "HIP 50862"},
        {"Smithsonian Astrophysical Observation", "SAO 201340"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.78038480),
        dec: Angle.Degrees(-32.55730845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79613"},
        {"Hipparcos Number", "HIP 45335"},
        {"Smithsonian Astrophysical Observation", "SAO 200135"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.58936857),
        dec: Angle.Degrees(-32.55684701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114348"},
        {"Hipparcos Number", "HIP 64282"},
        {"Smithsonian Astrophysical Observation", "SAO 204190"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.61271468),
        dec: Angle.Degrees(-32.55663644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127360"},
        {"Hipparcos Number", "HIP 71047"},
        {"Smithsonian Astrophysical Observation", "SAO 205648"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.94723032),
        dec: Angle.Degrees(-32.55646139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212745"},
        {"Hipparcos Number", "HIP 110818"},
        {"Smithsonian Astrophysical Observation", "SAO 213822"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77383454),
        dec: Angle.Degrees(-32.55337624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209536"},
        {"Hipparcos Number", "HIP 108992"},
        {"Smithsonian Astrophysical Observation", "SAO 213525"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.19783724),
        dec: Angle.Degrees(-32.55331941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156325"},
        {"Hipparcos Number", "HIP 84650"},
        {"Geneva Identification System", "GEN# +1.00156325A"},
        {"Smithsonian Astrophysical Observation", "SAO 208657"},
        {"Wilson Evans Batten Catalogue", "WEB 14294"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.58546532),
        dec: Angle.Degrees(-32.55308889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8833"},
        {"Hipparcos Number", "HIP 6719"},
        {"Geneva Identification System", "GEN# +1.00008833"},
        {"Smithsonian Astrophysical Observation", "SAO 193117"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.61988791),
        dec: Angle.Degrees(-32.55184181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113789"},
        {"Hipparcos Number", "HIP 63965"},
        {"Smithsonian Astrophysical Observation", "SAO 204126"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.62697900),
        dec: Angle.Degrees(-32.54969018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210302"},
        {"Hipparcos Number", "HIP 109422"},
        {"Cincinnati Publication", "Ci 20 1341"},
        {"Geneva Identification System", "GEN# +1.00210302"},
        {"Smithsonian Astrophysical Observation", "SAO 213602"},
        {"Wilson Evans Batten Catalogue", "WEB 19659"},
    },
    visualMagnitude: 4.94,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.53534803),
        dec: Angle.Degrees(-32.54844042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 428.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89550"},
        {"Hipparcos Number", "HIP 50544"},
        {"Smithsonian Astrophysical Observation", "SAO 201280"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.86050334),
        dec: Angle.Degrees(-32.54817734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116743"},
        {"Hipparcos Number", "HIP 65539"},
        {"Smithsonian Astrophysical Observation", "SAO 204469"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53396914),
        dec: Angle.Degrees(-32.54727080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157884"},
        {"Hipparcos Number", "HIP 85422"},
        {"Geneva Identification System", "GEN# +1.00157884"},
        {"Smithsonian Astrophysical Observation", "SAO 208835"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.83714253),
        dec: Angle.Degrees(-32.54640957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209428"},
        {"Hipparcos Number", "HIP 108927"},
        {"Smithsonian Astrophysical Observation", "SAO 213511"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.99274999),
        dec: Angle.Degrees(-32.54468452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8879"},
        {"Hipparcos Number", "HIP 6759"},
        {"Geneva Identification System", "GEN# +1.00008879"},
        {"Smithsonian Astrophysical Observation", "SAO 193122"},
        {"Wilson Evans Batten Catalogue", "WEB 1476"},
    },
    visualMagnitude: 6.57,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.74208376),
        dec: Angle.Degrees(-32.54310029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175128"},
        {"Hipparcos Number", "HIP 92864"},
        {"Geneva Identification System", "GEN# +1.00175128"},
        {"Smithsonian Astrophysical Observation", "SAO 210717"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.83559609),
        dec: Angle.Degrees(-32.54233983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49961"},
        {"Hipparcos Number", "HIP 32716"},
        {"Smithsonian Astrophysical Observation", "SAO 197253"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.38251855),
        dec: Angle.Degrees(-32.54218415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217460"},
        {"Hipparcos Number", "HIP 113662"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.29684830),
        dec: Angle.Degrees(-32.54131866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11481"},
        {"Hipparcos Number", "HIP 8721"},
        {"Geneva Identification System", "GEN# +1.00011481"},
        {"Smithsonian Astrophysical Observation", "SAO 193344"},
        {"Wilson Evans Batten Catalogue", "WEB 1838"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04804969),
        dec: Angle.Degrees(-32.53987434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216763"},
        {"Hipparcos Number", "HIP 113246"},
        {"Geneva Identification System", "GEN# +1.00216763J"},
        {"Smithsonian Astrophysical Observation", "SAO 214189"},
        {"Wilson Evans Batten Catalogue", "WEB 20151"},
    },
    visualMagnitude: 4.20,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.98705005),
        dec: Angle.Degrees(-32.53970196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132262"},
        {"Hipparcos Number", "HIP 73331"},
        {"Smithsonian Astrophysical Observation", "SAO 206166"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.77706267),
        dec: Angle.Degrees(-32.53944604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93477"},
    },
    visualMagnitude: 11.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.55372091),
        dec: Angle.Degrees(-32.53908757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202041"},
        {"Hipparcos Number", "HIP 104851"},
        {"Geneva Identification System", "GEN# +1.00202041"},
        {"Smithsonian Astrophysical Observation", "SAO 212820"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.59748155),
        dec: Angle.Degrees(-32.53880446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56528"},
        {"Cincinnati Publication", "Ci 20 649"},
        {"Geneva Identification System", "GEN# -0.03109113"},
        {"Smithsonian Astrophysical Observation", "SAO 202602"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.86248684),
        dec: Angle.Degrees(-32.53790001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -852.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154262"},
        {"Hipparcos Number", "HIP 83653"},
        {"Smithsonian Astrophysical Observation", "SAO 208398"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.46057354),
        dec: Angle.Degrees(-32.53748736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210613"},
        {"Hipparcos Number", "HIP 109605"},
        {"Smithsonian Astrophysical Observation", "SAO 213635"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.04088427),
        dec: Angle.Degrees(-32.53611863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43574"},
        {"Hipparcos Number", "HIP 29710"},
        {"Smithsonian Astrophysical Observation", "SAO 196631"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.87163941),
        dec: Angle.Degrees(-32.53475960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17407"},
        {"Hipparcos Number", "HIP 12954"},
        {"Smithsonian Astrophysical Observation", "SAO 193907"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.64275284),
        dec: Angle.Degrees(-32.53456190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207681"},
        {"Hipparcos Number", "HIP 107881"},
        {"Smithsonian Astrophysical Observation", "SAO 213341"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.88067820),
        dec: Angle.Degrees(-32.53391195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109074"},
        {"Hipparcos Number", "HIP 61172"},
        {"Geneva Identification System", "GEN# +1.00109074"},
        {"Smithsonian Astrophysical Observation", "SAO 203567"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01835363),
        dec: Angle.Degrees(-32.53373156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219784"},
        {"Hipparcos Number", "HIP 115102"},
        {"Fundamental Katalog 5th Edition", "FK5 879"},
        {"Geneva Identification System", "GEN# +1.00219784"},
        {"Smithsonian Astrophysical Observation", "SAO 214444"},
        {"Wilson Evans Batten Catalogue", "WEB 20389"},
    },
    visualMagnitude: 4.41,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.70594501),
        dec: Angle.Degrees(-32.53183574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206252"},
        {"Hipparcos Number", "HIP 107103"},
        {"Smithsonian Astrophysical Observation", "SAO 213206"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.41398784),
        dec: Angle.Degrees(-32.53085387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43313"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.35419535),
        dec: Angle.Degrees(-32.53066814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23331"},
        {"Hipparcos Number", "HIP 17372"},
        {"Smithsonian Astrophysical Observation", "SAO 194478"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.79012324),
        dec: Angle.Degrees(-32.52935326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85464"},
        {"Hipparcos Number", "HIP 48335"},
        {"Smithsonian Astrophysical Observation", "SAO 200806"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.78454836),
        dec: Angle.Degrees(-32.52478662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17168"},
        {"Hipparcos Number", "HIP 12786"},
        {"Geneva Identification System", "GEN# +1.00017168"},
        {"Smithsonian Astrophysical Observation", "SAO 193888"},
        {"Wilson Evans Batten Catalogue", "WEB 2601"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.08550087),
        dec: Angle.Degrees(-32.52466200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199981"},
        {"Hipparcos Number", "HIP 103768"},
        {"Geneva Identification System", "GEN# +1.00199981"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.41221731),
        dec: Angle.Degrees(-32.52418210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160589"},
        {"Hipparcos Number", "HIP 86650"},
        {"Geneva Identification System", "GEN# +1.00160589"},
        {"Smithsonian Astrophysical Observation", "SAO 209160"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.57001693),
        dec: Angle.Degrees(-32.52327405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186057"},
        {"Hipparcos Number", "HIP 97055"},
        {"Smithsonian Astrophysical Observation", "SAO 211505"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.87030658),
        dec: Angle.Degrees(-32.52185916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28871"},
        {"Hipparcos Number", "HIP 21114"},
        {"Geneva Identification System", "GEN# +1.00028871"},
        {"Smithsonian Astrophysical Observation", "SAO 195099"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.87802103),
        dec: Angle.Degrees(-32.51866093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12733"},
        {"Hipparcos Number", "HIP 9648"},
        {"Geneva Identification System", "GEN# +1.00012733"},
        {"Smithsonian Astrophysical Observation", "SAO 193483"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.00044973),
        dec: Angle.Degrees(-32.51856978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88670"},
        {"Hipparcos Number", "HIP 50030"},
        {"Smithsonian Astrophysical Observation", "SAO 201178"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.21019454),
        dec: Angle.Degrees(-32.51561083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200332"},
        {"Hipparcos Number", "HIP 103959"},
        {"Smithsonian Astrophysical Observation", "SAO 212678"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96023002),
        dec: Angle.Degrees(-32.51361303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183151"},
        {"Hipparcos Number", "HIP 95827"},
        {"Smithsonian Astrophysical Observation", "SAO 211301"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.35749405),
        dec: Angle.Degrees(-32.51358555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34484"},
        {"Hipparcos Number", "HIP 24578"},
        {"Geneva Identification System", "GEN# +1.00034484"},
        {"Smithsonian Astrophysical Observation", "SAO 195704"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.10053420),
        dec: Angle.Degrees(-32.51349383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132801"},
        {"Hipparcos Number", "HIP 73560"},
        {"Smithsonian Astrophysical Observation", "SAO 206225"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.50162926),
        dec: Angle.Degrees(-32.51304857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76001"},
        {"Hipparcos Number", "HIP 43573"},
        {"Geneva Identification System", "GEN# +1.00076001"},
        {"Smithsonian Astrophysical Observation", "SAO 199728"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.10893590),
        dec: Angle.Degrees(-32.50930296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58767"},
        {"Hipparcos Number", "HIP 36038"},
        {"Celescope Catalog", "CEL 1845"},
        {"Geneva Identification System", "GEN# +5.11400015"},
        {"Smithsonian Astrophysical Observation", "SAO 197985"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.40361240),
        dec: Angle.Degrees(-32.50926426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50013"},
        {"Hipparcos Number", "HIP 32759"},
        {"Fundamental Katalog 5th Edition", "FK5 1180"},
        {"Geneva Identification System", "GEN# +1.00050013"},
        {"Smithsonian Astrophysical Observation", "SAO 197258"},
        {"Wilson Evans Batten Catalogue", "WEB 6594"},
    },
    visualMagnitude: 3.50,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.46027285),
        dec: Angle.Degrees(-32.50848752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18735"},
        {"Hipparcos Number", "HIP 13947"},
        {"Fundamental Katalog 5th Edition", "FK5 2211"},
        {"Geneva Identification System", "GEN# +1.00018735"},
        {"Smithsonian Astrophysical Observation", "SAO 194023"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.90958178),
        dec: Angle.Degrees(-32.50722144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98474"},
        {"Hipparcos Number", "HIP 55291"},
        {"Smithsonian Astrophysical Observation", "SAO 202321"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.85643508),
        dec: Angle.Degrees(-32.50717541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206342"},
        {"Hipparcos Number", "HIP 107149"},
        {"Smithsonian Astrophysical Observation", "SAO 213215"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.55228347),
        dec: Angle.Degrees(-32.50660705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102788"},
        {"Hipparcos Number", "HIP 57692"},
        {"Smithsonian Astrophysical Observation", "SAO 202850"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.47501816),
        dec: Angle.Degrees(-32.50582374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22188"},
        {"Hipparcos Number", "HIP 16567"},
        {"Smithsonian Astrophysical Observation", "SAO 194369"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.32841811),
        dec: Angle.Degrees(-32.50547642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21909"},
        {"Hipparcos Number", "HIP 16366"},
        {"Smithsonian Astrophysical Observation", "SAO 194346"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.71060812),
        dec: Angle.Degrees(-32.50544909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35854"},
        {"Hipparcos Number", "HIP 25421"},
        {"Geneva Identification System", "GEN# +1.00035854"},
        {"Smithsonian Astrophysical Observation", "SAO 195854"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56070096),
        dec: Angle.Degrees(-32.50454389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 246.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319134"},
        {"Hipparcos Number", "HIP 89334"},
        {"Smithsonian Astrophysical Observation", "SAO 209875"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.41836664),
        dec: Angle.Degrees(-32.50451068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317844"},
        {"Hipparcos Number", "HIP 85985"},
        {"Geneva Identification System", "GEN# +2.63830100"},
        {"Geneva Identification System 2", "GEN# +2.63830701"},
        {"Smithsonian Astrophysical Observation", "SAO 208972"},
        {"Wilson Evans Batten Catalogue", "WEB 14507"},
        {"New General Catalogue", "NGC 6383 100"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.60212905),
        dec: Angle.Degrees(-32.50443594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39148"},
        {"Hipparcos Number", "HIP 27479"},
        {"Smithsonian Astrophysical Observation", "SAO 196206"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.28042147),
        dec: Angle.Degrees(-32.50434791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13483"},
        {"Geneva Identification System", "GEN# -0.00000447"},
        {"Smithsonian Astrophysical Observation", "SAO 130172"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.40970483),
        dec: Angle.Degrees(+00.05453626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181700"},
        {"Hipparcos Number", "HIP 95252"},
        {"Smithsonian Astrophysical Observation", "SAO 211217"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.69948599),
        dec: Angle.Degrees(-32.50321173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46248"},
        {"Hipparcos Number", "HIP 31048"},
        {"Smithsonian Astrophysical Observation", "SAO 196889"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.71975665),
        dec: Angle.Degrees(-32.50308438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177950"},
        {"Hipparcos Number", "HIP 93981"},
        {"Smithsonian Astrophysical Observation", "SAO 210969"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.02864421),
        dec: Angle.Degrees(-32.50273859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58581"},
    },
    visualMagnitude: 12.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.20410098),
        dec: Angle.Degrees(-32.50095451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61539"},
        {"Hipparcos Number", "HIP 37183"},
        {"Smithsonian Astrophysical Observation", "SAO 198222"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.59765739),
        dec: Angle.Degrees(-32.50093224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26131"},
        {"Smithsonian Astrophysical Observation", "SAO 195970"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.57558794),
        dec: Angle.Degrees(-32.50016397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101666"},
        {"Hipparcos Number", "HIP 57047"},
        {"Geneva Identification System", "GEN# +1.00101666"},
        {"Smithsonian Astrophysical Observation", "SAO 202717"},
        {"Wilson Evans Batten Catalogue", "WEB 10269"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43313494),
        dec: Angle.Degrees(-32.49932237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25061"},
        {"Smithsonian Astrophysical Observation", "SAO 195780"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48227264),
        dec: Angle.Degrees(-32.49433795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223699"},
        {"Hipparcos Number", "HIP 117680"},
        {"Smithsonian Astrophysical Observation", "SAO 214830"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.98580080),
        dec: Angle.Degrees(-32.49340426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12757"},
        {"Hipparcos Number", "HIP 9660"},
        {"Smithsonian Astrophysical Observation", "SAO 193486"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.06971636),
        dec: Angle.Degrees(-32.49105672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64824"},
        {"Hipparcos Number", "HIP 38622"},
        {"Smithsonian Astrophysical Observation", "SAO 198576"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.62021074),
        dec: Angle.Degrees(-32.48972147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317543"},
        {"Hipparcos Number", "HIP 85043"},
        {"Geneva Identification System", "GEN# +1.00317543"},
        {"Smithsonian Astrophysical Observation", "SAO 208749"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.71716621),
        dec: Angle.Degrees(-32.48916850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172834"},
        {"Hipparcos Number", "HIP 91866"},
        {"Geneva Identification System", "GEN# +1.00172834"},
        {"Smithsonian Astrophysical Observation", "SAO 210502"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.93066778),
        dec: Angle.Degrees(-32.48901977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109338"},
        {"Hipparcos Number", "HIP 61337"},
        {"Geneva Identification System", "GEN# +1.00109338"},
        {"Smithsonian Astrophysical Observation", "SAO 203590"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.52323613),
        dec: Angle.Degrees(-32.48888358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181198"},
        {"Hipparcos Number", "HIP 95102"},
        {"Smithsonian Astrophysical Observation", "SAO 211199"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.21366780),
        dec: Angle.Degrees(-32.48848048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219595"},
        {"Hipparcos Number", "HIP 114973"},
        {"Smithsonian Astrophysical Observation", "SAO 214431"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.29144223),
        dec: Angle.Degrees(-32.48599051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208273"},
        {"Hipparcos Number", "HIP 108254"},
        {"Smithsonian Astrophysical Observation", "SAO 213403"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.96749433),
        dec: Angle.Degrees(-32.48543408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11911"},
        {"Hipparcos Number", "HIP 9030"},
        {"Smithsonian Astrophysical Observation", "SAO 193392"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.07652521),
        dec: Angle.Degrees(-32.48538821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139124"},
        {"Hipparcos Number", "HIP 76501"},
        {"Smithsonian Astrophysical Observation", "SAO 206813"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.36637782),
        dec: Angle.Degrees(-32.48495631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150805"},
        {"Hipparcos Number", "HIP 81965"},
        {"Smithsonian Astrophysical Observation", "SAO 207981"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.15839407),
        dec: Angle.Degrees(-32.48148038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23668"},
        {"Hipparcos Number", "HIP 17569"},
        {"Smithsonian Astrophysical Observation", "SAO 194510"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.44017560),
        dec: Angle.Degrees(-32.48132221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211467"},
        {"Hipparcos Number", "HIP 110084"},
        {"Geneva Identification System", "GEN# +1.00211467"},
        {"Smithsonian Astrophysical Observation", "SAO 213708"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.47731670),
        dec: Angle.Degrees(-32.47834360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162722"},
        {"Hipparcos Number", "HIP 87613"},
        {"Smithsonian Astrophysical Observation", "SAO 209429"},
        {"Wilson Evans Batten Catalogue", "WEB 14785"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.46867836),
        dec: Angle.Degrees(-32.47808196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11109"},
        {"Hipparcos Number", "HIP 8422"},
        {"Smithsonian Astrophysical Observation", "SAO 193309"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.15717185),
        dec: Angle.Degrees(-32.47729372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57637"},
        {"Hipparcos Number", "HIP 35605"},
        {"Geneva Identification System", "GEN# +5.11400007"},
        {"Smithsonian Astrophysical Observation", "SAO 197876"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.20981023),
        dec: Angle.Degrees(-32.47667579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180862"},
        {"Hipparcos Number", "HIP 94965"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.87875139),
        dec: Angle.Degrees(-32.47660605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163181"},
        {"Hipparcos Number", "HIP 87810"},
        {"Fundamental Katalog 5th Edition", "FK5 3424"},
        {"Geneva Identification System", "GEN# +1.00163181A"},
        {"Smithsonian Astrophysical Observation", "SAO 209489"},
        {"Wilson Evans Batten Catalogue", "WEB 14818"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.06698420),
        dec: Angle.Degrees(-32.47498877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224007"},
        {"Hipparcos Number", "HIP 117869"},
        {"Smithsonian Astrophysical Observation", "SAO 214851"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.62049343),
        dec: Angle.Degrees(-32.47175946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142820"},
        {"Hipparcos Number", "HIP 78185"},
        {"Smithsonian Astrophysical Observation", "SAO 207165"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.45887394),
        dec: Angle.Degrees(-32.47170710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75413"},
        {"Hipparcos Number", "HIP 43267"},
        {"Smithsonian Astrophysical Observation", "SAO 199651"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.20644183),
        dec: Angle.Degrees(-32.47068065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16155"},
        {"Hipparcos Number", "HIP 12000"},
        {"Smithsonian Astrophysical Observation", "SAO 193785"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.67170181),
        dec: Angle.Degrees(-32.46875439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177895"},
        {"Hipparcos Number", "HIP 93964"},
        {"Smithsonian Astrophysical Observation", "SAO 210965"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.98391604),
        dec: Angle.Degrees(-32.46861353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21"},
        {"Hipparcos Number", "HIP 430"},
        {"Smithsonian Astrophysical Observation", "SAO 192350"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29294285),
        dec: Angle.Degrees(-32.46851165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49773"},
        {"Hipparcos Number", "HIP 32649"},
        {"Geneva Identification System", "GEN# +1.00049773"},
        {"Smithsonian Astrophysical Observation", "SAO 197236"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.16135248),
        dec: Angle.Degrees(-32.46752457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13991"},
        {"Hipparcos Number", "HIP 10493"},
        {"Geneva Identification System", "GEN# +1.00013991"},
        {"Smithsonian Astrophysical Observation", "SAO 193603"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.81840959),
        dec: Angle.Degrees(-32.46623978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130714"},
        {"Hipparcos Number", "HIP 72600"},
        {"Geneva Identification System", "GEN# +1.00130714"},
        {"Smithsonian Astrophysical Observation", "SAO 206000"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.65835240),
        dec: Angle.Degrees(-32.46615765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28534"},
        {"Hipparcos Number", "HIP 20888"},
        {"Geneva Identification System", "GEN# +1.00028534"},
        {"Smithsonian Astrophysical Observation", "SAO 195053"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.15206137),
        dec: Angle.Degrees(-32.46573788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109134"},
        {"Hipparcos Number", "HIP 61211"},
        {"Smithsonian Astrophysical Observation", "SAO 203574"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.14614339),
        dec: Angle.Degrees(-32.46416824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66598"},
        {"Hipparcos Number", "HIP 39380"},
        {"Geneva Identification System", "GEN# +1.00066598A"},
        {"Smithsonian Astrophysical Observation", "SAO 198743"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.76737445),
        dec: Angle.Degrees(-32.46357097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62751"},
        {"Hipparcos Number", "HIP 37713"},
        {"Geneva Identification System", "GEN# +1.00062751"},
        {"Smithsonian Astrophysical Observation", "SAO 198361"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04710536),
        dec: Angle.Degrees(-32.46279566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205389"},
        {"Hipparcos Number", "HIP 106623"},
        {"Smithsonian Astrophysical Observation", "SAO 213120"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.94447718),
        dec: Angle.Degrees(-32.46142359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220558"},
        {"Hipparcos Number", "HIP 115593"},
        {"Smithsonian Astrophysical Observation", "SAO 214532"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.22158219),
        dec: Angle.Degrees(-32.46096015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208486"},
        {"Hipparcos Number", "HIP 108365"},
        {"Smithsonian Astrophysical Observation", "SAO 213431"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.29696305),
        dec: Angle.Degrees(-32.46090233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149531"},
        {"Hipparcos Number", "HIP 81343"},
        {"Smithsonian Astrophysical Observation", "SAO 207828"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.19059501),
        dec: Angle.Degrees(-32.45596294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78739"},
        {"Hipparcos Number", "HIP 44900"},
        {"Smithsonian Astrophysical Observation", "SAO 200027"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.21768069),
        dec: Angle.Degrees(-32.45422241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33096"},
        {"Smithsonian Astrophysical Observation", "SAO 197322"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.40223550),
        dec: Angle.Degrees(-32.45398298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110368"},
        {"Hipparcos Number", "HIP 61964"},
        {"Smithsonian Astrophysical Observation", "SAO 203720"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.47938684),
        dec: Angle.Degrees(-32.45351123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127378"},
        {"Hipparcos Number", "HIP 71059"},
        {"Smithsonian Astrophysical Observation", "SAO 205650"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.97447375),
        dec: Angle.Degrees(-32.45274211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109805"},
        {"Hipparcos Number", "HIP 61627"},
        {"Smithsonian Astrophysical Observation", "SAO 203647"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.46429421),
        dec: Angle.Degrees(-32.45161826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143879"},
        {"Hipparcos Number", "HIP 78714"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.03742228),
        dec: Angle.Degrees(-32.44938328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77938"},
        {"Hipparcos Number", "HIP 44538"},
        {"Geneva Identification System", "GEN# +1.00077938"},
        {"Smithsonian Astrophysical Observation", "SAO 199952"},
        {"Wilson Evans Batten Catalogue", "WEB 8528"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.12304723),
        dec: Angle.Degrees(-32.44840339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219641"},
        {"Hipparcos Number", "HIP 115010"},
        {"Smithsonian Astrophysical Observation", "SAO 214433"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.40268386),
        dec: Angle.Degrees(-32.44624669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145968"},
        {"Hipparcos Number", "HIP 79630"},
        {"Smithsonian Astrophysical Observation", "SAO 207488"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.73779253),
        dec: Angle.Degrees(-32.44564855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121139"},
        {"Hipparcos Number", "HIP 67892"},
        {"Geneva Identification System", "GEN# +1.00121139"},
        {"Smithsonian Astrophysical Observation", "SAO 204972"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.58384910),
        dec: Angle.Degrees(-32.44543795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14567"},
        {"Hipparcos Number", "HIP 10910"},
        {"Geneva Identification System", "GEN# +1.00014567"},
        {"Smithsonian Astrophysical Observation", "SAO 193648"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.10478131),
        dec: Angle.Degrees(-32.44516295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134858"},
        {"Hipparcos Number", "HIP 74486"},
        {"Smithsonian Astrophysical Observation", "SAO 206422"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.30551803),
        dec: Angle.Degrees(-32.44399017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102750"},
        {"Hipparcos Number", "HIP 57672"},
        {"Smithsonian Astrophysical Observation", "SAO 202843"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.42975269),
        dec: Angle.Degrees(-32.44393421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100650"},
        {"Hipparcos Number", "HIP 56484"},
        {"Smithsonian Astrophysical Observation", "SAO 202588"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.70140141),
        dec: Angle.Degrees(-32.44380017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33429"},
        {"Smithsonian Astrophysical Observation", "SAO 197395"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.27241846),
        dec: Angle.Degrees(-32.44094923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77645"},
        {"Hipparcos Number", "HIP 44415"},
        {"Fundamental Katalog 5th Edition", "FK5 2715"},
        {"Geneva Identification System", "GEN# +1.00077645"},
        {"Smithsonian Astrophysical Observation", "SAO 199917"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.71596340),
        dec: Angle.Degrees(-32.44004737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29802"},
        {"Smithsonian Astrophysical Observation", "SAO 196640"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.11609000),
        dec: Angle.Degrees(-32.43978039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202870"},
        {"Hipparcos Number", "HIP 105296"},
    },
    visualMagnitude: 13.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)19, 38.1300),
        dec: Angle.DegreesMinutesSeconds((int)-32, (int)26, 21.900)
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
    primaryId: "HIP 46087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46087"},
        {"Geneva Identification System", "GEN# +9.80048010"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.96958345),
        dec: Angle.Degrees(+00.13871724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128030"},
        {"Hipparcos Number", "HIP 71351"},
        {"Smithsonian Astrophysical Observation", "SAO 205727"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.87643185),
        dec: Angle.Degrees(-32.43911217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155450"},
        {"Hipparcos Number", "HIP 84226"},
        {"Geneva Identification System", "GEN# +1.00155450"},
        {"Smithsonian Astrophysical Observation", "SAO 208539"},
        {"Wilson Evans Batten Catalogue", "WEB 14223"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.24398720),
        dec: Angle.Degrees(-32.43832730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120824"},
        {"Hipparcos Number", "HIP 67727"},
        {"Smithsonian Astrophysical Observation", "SAO 204932"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11780730),
        dec: Angle.Degrees(-32.43759902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196982"},
        {"Hipparcos Number", "HIP 102141"},
        {"Smithsonian Astrophysical Observation", "SAO 212355"},
        {"Wilson Evans Batten Catalogue", "WEB 18475"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46238529),
        dec: Angle.Degrees(-32.43434165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 269.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97393"},
        {"Hipparcos Number", "HIP 54725"},
        {"Fundamental Katalog 5th Edition", "FK5 1290"},
        {"Geneva Identification System", "GEN# +1.00097393"},
        {"Smithsonian Astrophysical Observation", "SAO 202197"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.06159256),
        dec: Angle.Degrees(-32.43382529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48835"},
        {"Hipparcos Number", "HIP 32248"},
        {"Smithsonian Astrophysical Observation", "SAO 197142"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.99385296),
        dec: Angle.Degrees(-32.43123567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223655"},
        {"Hipparcos Number", "HIP 117640"},
        {"Geneva Identification System", "GEN# +1.00223655"},
        {"Smithsonian Astrophysical Observation", "SAO 214820"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.86716637),
        dec: Angle.Degrees(-32.43029335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94093"},
        {"Hipparcos Number", "HIP 53048"},
        {"Geneva Identification System", "GEN# +1.00094093"},
        {"Smithsonian Astrophysical Observation", "SAO 201825"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.80549779),
        dec: Angle.Degrees(-32.43007220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120036"},
        {"Hipparcos Number", "HIP 67308"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.92542634),
        dec: Angle.Degrees(-32.42997584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184096"},
        {"Hipparcos Number", "HIP 96235"},
        {"Smithsonian Astrophysical Observation", "SAO 211371"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.53738448),
        dec: Angle.Degrees(-32.42951832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5260"},
        {"Geneva Identification System", "GEN# -0.03300408"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80665675),
        dec: Angle.Degrees(-32.42929737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130539"},
        {"Hipparcos Number", "HIP 72536"},
        {"Geneva Identification System", "GEN# +1.00130539"},
        {"Smithsonian Astrophysical Observation", "SAO 205988"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.45532576),
        dec: Angle.Degrees(-32.42705629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188864"},
        {"Hipparcos Number", "HIP 98310"},
        {"Smithsonian Astrophysical Observation", "SAO 211699"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.62899991),
        dec: Angle.Degrees(-32.42685083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39086"},
        {"Hipparcos Number", "HIP 27457"},
        {"Geneva Identification System", "GEN# +1.00039086"},
        {"Smithsonian Astrophysical Observation", "SAO 196200"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.21445000),
        dec: Angle.Degrees(-32.42664514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83107"},
        {"Hipparcos Number", "HIP 47042"},
        {"Smithsonian Astrophysical Observation", "SAO 200530"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.80794307),
        dec: Angle.Degrees(-32.42663078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63447",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00, 04.8800),
        dec: Angle.DegreesMinutesSeconds((int)+00, (int)17, 58.200)
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
    primaryId: "HIP 69939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125218"},
        {"Hipparcos Number", "HIP 69939"},
        {"Geneva Identification System", "GEN# +1.00125218"},
        {"Smithsonian Astrophysical Observation", "SAO 205418"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.68574563),
        dec: Angle.Degrees(-32.42627528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70021"},
        {"Hipparcos Number", "HIP 40707"},
        {"Geneva Identification System", "GEN# +1.00070021"},
        {"Smithsonian Astrophysical Observation", "SAO 199067"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.64455545),
        dec: Angle.Degrees(-32.42611982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6817"},
        {"Hipparcos Number", "HIP 5351"},
        {"Smithsonian Astrophysical Observation", "SAO 192945"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.10063557),
        dec: Angle.Degrees(-32.42572456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169044"},
        {"Hipparcos Number", "HIP 90178"},
        {"Smithsonian Astrophysical Observation", "SAO 210092"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.03184021),
        dec: Angle.Degrees(-32.42219194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17493"},
        {"Hipparcos Number", "HIP 13019"},
        {"Smithsonian Astrophysical Observation", "SAO 193915"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.84756036),
        dec: Angle.Degrees(-32.42096359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36094"},
        {"Hipparcos Number", "HIP 25562"},
        {"Geneva Identification System", "GEN# +1.00036094"},
        {"Smithsonian Astrophysical Observation", "SAO 195875"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.96063241),
        dec: Angle.Degrees(-32.41758804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94595"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.75517275),
        dec: Angle.Degrees(-32.41640270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 376.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89949"},
        {"Hipparcos Number", "HIP 50795"},
        {"Smithsonian Astrophysical Observation", "SAO 201325"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.57395994),
        dec: Angle.Degrees(-32.41565706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161434"},
        {"Hipparcos Number", "HIP 87030"},
        {"Geneva Identification System", "GEN# +1.00161434"},
        {"Smithsonian Astrophysical Observation", "SAO 209247"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.73903960),
        dec: Angle.Degrees(-32.41429761)
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
    primaryId: "HIP 68839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122998"},
        {"Hipparcos Number", "HIP 68839"},
        {"Smithsonian Astrophysical Observation", "SAO 205167"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.43611746),
        dec: Angle.Degrees(-32.41162105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130029"},
        {"Hipparcos Number", "HIP 72276"},
        {"Geneva Identification System", "GEN# +1.00130029"},
        {"Smithsonian Astrophysical Observation", "SAO 205933"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.70682828),
        dec: Angle.Degrees(-32.41108704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104745"},
        {"Hipparcos Number", "HIP 58802"},
        {"Smithsonian Astrophysical Observation", "SAO 203085"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.91153151),
        dec: Angle.Degrees(-32.41088118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28428"},
        {"Hipparcos Number", "HIP 20819"},
        {"Geneva Identification System", "GEN# +1.00028428"},
        {"Smithsonian Astrophysical Observation", "SAO 195034"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.91932264),
        dec: Angle.Degrees(-32.40869190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17652"},
        {"Hipparcos Number", "HIP 13147"},
        {"Fundamental Katalog 5th Edition", "FK5 101"},
        {"Geneva Identification System", "GEN# +1.00017652J"},
        {"Smithsonian Astrophysical Observation", "SAO 193931"},
        {"Wilson Evans Batten Catalogue", "WEB 2647"},
    },
    visualMagnitude: 4.45,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.27233113),
        dec: Angle.Degrees(-32.40628403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219692"},
        {"Hipparcos Number", "HIP 115049"},
        {"Smithsonian Astrophysical Observation", "SAO 214437"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.52021946),
        dec: Angle.Degrees(-32.40474854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46655"},
        {"Geneva Identification System", "GEN# +9.80048020"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.68715327),
        dec: Angle.Degrees(+00.32400295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -569.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -552.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100388"},
        {"Smithsonian Astrophysical Observation", "SAO 212035"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37909754),
        dec: Angle.Degrees(-32.40449203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79486"},
        {"Hipparcos Number", "HIP 45269"},
        {"Smithsonian Astrophysical Observation", "SAO 200120"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.38973713),
        dec: Angle.Degrees(-32.40398390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 704"},
        {"Hipparcos Number", "HIP 915"},
        {"Geneva Identification System", "GEN# +1.00000704"},
        {"Smithsonian Astrophysical Observation", "SAO 192386"},
        {"Wilson Evans Batten Catalogue", "WEB 159"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.83158469),
        dec: Angle.Degrees(-32.40387891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161275"},
        {"Hipparcos Number", "HIP 86953"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.52607317),
        dec: Angle.Degrees(-32.40372773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118318"},
        {"Hipparcos Number", "HIP 66394"},
        {"Smithsonian Astrophysical Observation", "SAO 204651"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.19457435),
        dec: Angle.Degrees(-32.40345151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54694"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.95744556),
        dec: Angle.Degrees(-32.40073962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12105"},
        {"Hipparcos Number", "HIP 9175"},
        {"Smithsonian Astrophysical Observation", "SAO 193415"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.52863012),
        dec: Angle.Degrees(-32.40058272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124282"},
        {"Hipparcos Number", "HIP 69465"},
        {"Smithsonian Astrophysical Observation", "SAO 205319"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.32331947),
        dec: Angle.Degrees(-32.40002499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177738"},
        {"Hipparcos Number", "HIP 93911"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.83339813),
        dec: Angle.Degrees(-32.39949282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32194"},
        {"Hipparcos Number", "HIP 23242"},
        {"Smithsonian Astrophysical Observation", "SAO 195468"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.01098026),
        dec: Angle.Degrees(-32.39743584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20071"},
        {"Hipparcos Number", "HIP 14925"},
        {"Smithsonian Astrophysical Observation", "SAO 194153"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.12880398),
        dec: Angle.Degrees(-32.39666811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115256"},
        {"Smithsonian Astrophysical Observation", "SAO 214475"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.17078775),
        dec: Angle.Degrees(-32.39641370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169735"},
        {"Hipparcos Number", "HIP 90465"},
        {"Smithsonian Astrophysical Observation", "SAO 210179"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.89873646),
        dec: Angle.Degrees(-32.39343466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54500"},
        {"Hipparcos Number", "HIP 34382"},
        {"Smithsonian Astrophysical Observation", "SAO 197606"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.93616915),
        dec: Angle.Degrees(-32.39331578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178652"},
        {"Hipparcos Number", "HIP 94217"},
        {"Smithsonian Astrophysical Observation", "SAO 211016"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.70245480),
        dec: Angle.Degrees(-32.39194576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2404"},
        {"Hipparcos Number", "HIP 2194"},
        {"Geneva Identification System", "GEN# +1.00002404"},
        {"Smithsonian Astrophysical Observation", "SAO 192543"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.93039386),
        dec: Angle.Degrees(-32.38721604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 328.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106336"},
        {"Hipparcos Number", "HIP 59652"},
        {"Geneva Identification System", "GEN# +1.00106336"},
        {"Smithsonian Astrophysical Observation", "SAO 203259"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.50483989),
        dec: Angle.Degrees(-32.38693547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43310"},
        {"Geneva Identification System", "GEN# -0.03106576A"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34504089),
        dec: Angle.Degrees(-32.38388326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -383.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210005"},
        {"Hipparcos Number", "HIP 109256"},
        {"Smithsonian Astrophysical Observation", "SAO 213570"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.00299242),
        dec: Angle.Degrees(-32.38023265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22790"},
        {"Hipparcos Number", "HIP 16993"},
        {"Smithsonian Astrophysical Observation", "SAO 194423"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.63859123),
        dec: Angle.Degrees(-32.38003132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68363"},
        {"Hipparcos Number", "HIP 40049"},
        {"Geneva Identification System", "GEN# +1.00068363"},
        {"Smithsonian Astrophysical Observation", "SAO 198891"},
        {"Wilson Evans Batten Catalogue", "WEB 7811"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.71434663),
        dec: Angle.Degrees(-32.37966195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17682"},
        {"Hipparcos Number", "HIP 13166"},
        {"Smithsonian Astrophysical Observation", "SAO 193932"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.32480910),
        dec: Angle.Degrees(-32.37799014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84446"},
        {"Hipparcos Number", "HIP 47782"},
        {"Smithsonian Astrophysical Observation", "SAO 200685"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.12948892),
        dec: Angle.Degrees(-32.37694859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197173"},
        {"Hipparcos Number", "HIP 102244"},
        {"Smithsonian Astrophysical Observation", "SAO 212374"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.76620697),
        dec: Angle.Degrees(-32.37247103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45871"},
        {"Hipparcos Number", "HIP 30840"},
        {"Celescope Catalog", "CEL 1262"},
        {"Geneva Identification System", "GEN# +1.00045871J"},
        {"Smithsonian Astrophysical Observation", "SAO 196861"},
        {"Wilson Evans Batten Catalogue", "WEB 6146"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.16351878),
        dec: Angle.Degrees(-32.37129738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204108"},
        {"Hipparcos Number", "HIP 105938"},
        {"Smithsonian Astrophysical Observation", "SAO 213012"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82565507),
        dec: Angle.Degrees(-32.37077008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167505"},
        {"Hipparcos Number", "HIP 89593"},
        {"Smithsonian Astrophysical Observation", "SAO 209947"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.24378895),
        dec: Angle.Degrees(-32.37051888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43929"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.22986180),
        dec: Angle.Degrees(-32.36859360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97023"},
        {"Hipparcos Number", "HIP 54561"},
        {"Geneva Identification System", "GEN# +1.00097023"},
        {"Smithsonian Astrophysical Observation", "SAO 202149"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47242253),
        dec: Angle.Degrees(-32.36745668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172535"},
        {"Hipparcos Number", "HIP 91713"},
        {"Celescope Catalog", "CEL 4638"},
        {"Geneva Identification System", "GEN# +1.00172535J"},
        {"Smithsonian Astrophysical Observation", "SAO 210478"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54208284),
        dec: Angle.Degrees(-32.36709349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153044"},
        {"Hipparcos Number", "HIP 83074"},
        {"Smithsonian Astrophysical Observation", "SAO 208253"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.63178060),
        dec: Angle.Degrees(-32.36505380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117091"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.06186685),
        dec: Angle.Degrees(-32.36428257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66155"},
        {"Hipparcos Number", "HIP 39192"},
        {"Smithsonian Astrophysical Observation", "SAO 198698"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.23923057),
        dec: Angle.Degrees(-32.36173342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225265"},
        {"Hipparcos Number", "HIP 382"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.18816317),
        dec: Angle.Degrees(-32.36102308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49990"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.08188962),
        dec: Angle.Degrees(-32.35965604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118464"},
        {"Hipparcos Number", "HIP 66469"},
        {"Geneva Identification System", "GEN# +1.00118464"},
        {"Renson", "Renson 34200"},
        {"Smithsonian Astrophysical Observation", "SAO 204670"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.41083237),
        dec: Angle.Degrees(-32.35962727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14497"},
        {"Hipparcos Number", "HIP 10846"},
        {"Smithsonian Astrophysical Observation", "SAO 193641"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.90135047),
        dec: Angle.Degrees(-32.35671406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202774"},
        {"Hipparcos Number", "HIP 105244"},
        {"Smithsonian Astrophysical Observation", "SAO 212895"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76305497),
        dec: Angle.Degrees(-32.35607108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208674"},
        {"Hipparcos Number", "HIP 108487"},
        {"Smithsonian Astrophysical Observation", "SAO 213445"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.66004164),
        dec: Angle.Degrees(-32.35546292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175459"},
        {"Hipparcos Number", "HIP 93009"},
        {"Geneva Identification System", "GEN# +1.00175459"},
        {"Smithsonian Astrophysical Observation", "SAO 210746"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.21519271),
        dec: Angle.Degrees(-32.35286679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106789"},
        {"Hipparcos Number", "HIP 59888"},
        {"Smithsonian Astrophysical Observation", "SAO 203308"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.23096544),
        dec: Angle.Degrees(-32.35141964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19515"},
        {"Hipparcos Number", "HIP 14495"},
        {"Smithsonian Astrophysical Observation", "SAO 194097"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.80385406),
        dec: Angle.Degrees(-32.35136369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199860"},
        {"Hipparcos Number", "HIP 103711"},
        {"Smithsonian Astrophysical Observation", "SAO 212628"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22634276),
        dec: Angle.Degrees(-32.34767906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57122"},
        {"Hipparcos Number", "HIP 35385"},
        {"Celescope Catalog", "CEL 1762"},
        {"Geneva Identification System", "GEN# +1.00057122"},
        {"Renson", "Renson 15600"},
        {"Smithsonian Astrophysical Observation", "SAO 197828"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63376743),
        dec: Angle.Degrees(-32.34685346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213398"},
        {"Hipparcos Number", "HIP 111188"},
        {"Fundamental Katalog 5th Edition", "FK5 1592"},
        {"Geneva Identification System", "GEN# +1.00213398"},
        {"Smithsonian Astrophysical Observation", "SAO 213883"},
        {"Wilson Evans Batten Catalogue", "WEB 19896"},
    },
    visualMagnitude: 4.29,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.87620651),
        dec: Angle.Degrees(-32.34602798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59756"},
        {"Hipparcos Number", "HIP 36459"},
        {"Geneva Identification System", "GEN# +1.00059756"},
        {"Smithsonian Astrophysical Observation", "SAO 198058"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.53102860),
        dec: Angle.Degrees(-32.34468033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200552"},
        {"Hipparcos Number", "HIP 104081"},
        {"Renson", "Renson 55900"},
        {"Smithsonian Astrophysical Observation", "SAO 212693"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.29770077),
        dec: Angle.Degrees(-32.34458254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8453"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.24349162),
        dec: Angle.Degrees(-32.34456510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152242"},
        {"Hipparcos Number", "HIP 82639"},
        {"Smithsonian Astrophysical Observation", "SAO 208150"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39166891),
        dec: Angle.Degrees(-32.34454523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207212"},
        {"Hipparcos Number", "HIP 107630"},
        {"Renson", "Renson 57650"},
        {"Smithsonian Astrophysical Observation", "SAO 213294"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.01516929),
        dec: Angle.Degrees(-32.34267369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167208"},
        {"Hipparcos Number", "HIP 89480"},
        {"Geneva Identification System", "GEN# +1.00167208"},
        {"Smithsonian Astrophysical Observation", "SAO 209918"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.90450611),
        dec: Angle.Degrees(-32.34267007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74352"},
        {"Hipparcos Number", "HIP 42733"},
        {"Geneva Identification System", "GEN# +1.00074352"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.62766138),
        dec: Angle.Degrees(-32.34224197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200763"},
        {"Hipparcos Number", "HIP 104174"},
        {"Geneva Identification System", "GEN# +1.00200763"},
        {"Smithsonian Astrophysical Observation", "SAO 212716"},
        {"Wilson Evans Batten Catalogue", "WEB 18974"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.60283819),
        dec: Angle.Degrees(-32.34163849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47536"},
        {"Hipparcos Number", "HIP 31688"},
        {"Geneva Identification System", "GEN# +1.00047536"},
        {"Smithsonian Astrophysical Observation", "SAO 197019"},
        {"Wilson Evans Batten Catalogue", "WEB 6353"},
    },
    visualMagnitude: 5.25,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.44809882),
        dec: Angle.Degrees(-32.33989066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39706"},
        {"Hipparcos Number", "HIP 27789"},
        {"Geneva Identification System", "GEN# +1.00039706"},
        {"Smithsonian Astrophysical Observation", "SAO 196268"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.20930468),
        dec: Angle.Degrees(-32.33924142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14852"},
        {"Hipparcos Number", "HIP 11091"},
        {"Smithsonian Astrophysical Observation", "SAO 193676"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71000836),
        dec: Angle.Degrees(-32.33590539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39741"},
        {"Smithsonian Astrophysical Observation", "SAO 198818"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.84528227),
        dec: Angle.Degrees(-32.33584207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4632"},
        {"Hipparcos Number", "HIP 3735"},
        {"Smithsonian Astrophysical Observation", "SAO 192749"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.99199906),
        dec: Angle.Degrees(-32.33526571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5271"},
        {"Hipparcos Number", "HIP 4236"},
        {"Fundamental Katalog 5th Edition", "FK5 4076"},
        {"Geneva Identification System", "GEN# +1.00005271"},
        {"Smithsonian Astrophysical Observation", "SAO 192804"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.51650270),
        dec: Angle.Degrees(-32.33487997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149791"},
        {"Hipparcos Number", "HIP 81466"},
        {"Smithsonian Astrophysical Observation", "SAO 207864"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.58636958),
        dec: Angle.Degrees(-32.33384881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28739"},
        {"Hipparcos Number", "HIP 21026"},
        {"Smithsonian Astrophysical Observation", "SAO 195084"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.62671862),
        dec: Angle.Degrees(-32.33172616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169143"},
        {"Hipparcos Number", "HIP 90229"},
        {"Smithsonian Astrophysical Observation", "SAO 210107"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.15358691),
        dec: Angle.Degrees(-32.29110882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147298"},
        {"Hipparcos Number", "HIP 80199"},
        {"Smithsonian Astrophysical Observation", "SAO 207596"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.59119457),
        dec: Angle.Degrees(-32.33140242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13616"},
        {"Hipparcos Number", "HIP 10259"},
        {"Geneva Identification System", "GEN# +1.00013616"},
        {"Smithsonian Astrophysical Observation", "SAO 193568"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.00498141),
        dec: Angle.Degrees(-32.32889554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194396"},
        {"Hipparcos Number", "HIP 100811"},
        {"Smithsonian Astrophysical Observation", "SAO 212120"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.60787963),
        dec: Angle.Degrees(-32.32888147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83594"},
        {"Hipparcos Number", "HIP 47346"},
        {"Smithsonian Astrophysical Observation", "SAO 200591"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70845724),
        dec: Angle.Degrees(-32.32857546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70910"},
        {"Hipparcos Number", "HIP 41116"},
        {"Smithsonian Astrophysical Observation", "SAO 199164"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.83677538),
        dec: Angle.Degrees(-32.32815239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95334"},
        {"Hipparcos Number", "HIP 53764"},
        {"Geneva Identification System", "GEN# +1.00095334"},
        {"Smithsonian Astrophysical Observation", "SAO 201994"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.00333841),
        dec: Angle.Degrees(-32.32790329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171449"},
        {"Hipparcos Number", "HIP 91206"},
        {"Smithsonian Astrophysical Observation", "SAO 210362"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.08702502),
        dec: Angle.Degrees(-32.32727817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10537"},
        {"Hipparcos Number", "HIP 7955"},
        {"Fundamental Katalog 5th Edition", "FK5 1048"},
        {"Geneva Identification System", "GEN# +1.00010537"},
        {"Smithsonian Astrophysical Observation", "SAO 193263"},
        {"Wilson Evans Batten Catalogue", "WEB 1700"},
    },
    visualMagnitude: 5.25,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.53602338),
        dec: Angle.Degrees(-32.32685759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94461"},
        {"Hipparcos Number", "HIP 53279"},
        {"Geneva Identification System", "GEN# +1.00094461"},
        {"Smithsonian Astrophysical Observation", "SAO 201867"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.44945147),
        dec: Angle.Degrees(-32.32675955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96997"},
        {"Hipparcos Number", "HIP 54547"},
        {"Smithsonian Astrophysical Observation", "SAO 202146"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43520212),
        dec: Angle.Degrees(-32.32653954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155161"},
        {"Hipparcos Number", "HIP 84071"},
        {"Geneva Identification System", "GEN# +1.00155161"},
        {"Smithsonian Astrophysical Observation", "SAO 208506"},
    },
    visualMagnitude: 7.06,
    bvColour: 2.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.82092503),
        dec: Angle.Degrees(-32.32519220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111262"},
        {"Hipparcos Number", "HIP 62485"},
        {"Smithsonian Astrophysical Observation", "SAO 203823"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.07435820),
        dec: Angle.Degrees(-32.32471091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206907"},
        {"Hipparcos Number", "HIP 107470"},
        {"Smithsonian Astrophysical Observation", "SAO 213270"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.51303898),
        dec: Angle.Degrees(-32.32414929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13096"},
        {"Hipparcos Number", "HIP 9895"},
        {"Smithsonian Astrophysical Observation", "SAO 193516"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.83249720),
        dec: Angle.Degrees(-32.32368052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36824"},
        {"Smithsonian Astrophysical Observation", "SAO 198142"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.59628286),
        dec: Angle.Degrees(-32.32359323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191407"},
        {"Hipparcos Number", "HIP 99430"},
        {"Geneva Identification System", "GEN# +1.00191407"},
        {"Smithsonian Astrophysical Observation", "SAO 211883"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.72631142),
        dec: Angle.Degrees(-32.32341217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34800"},
        {"Hipparcos Number", "HIP 24772"},
        {"Smithsonian Astrophysical Observation", "SAO 195737"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.66963536),
        dec: Angle.Degrees(-32.32282851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194590"},
        {"Hipparcos Number", "HIP 100905"},
        {"Smithsonian Astrophysical Observation", "SAO 212135"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.89028690),
        dec: Angle.Degrees(-32.32133405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108230"},
        {"Hipparcos Number", "HIP 60683"},
        {"Geneva Identification System", "GEN# +1.00108230"},
        {"Smithsonian Astrophysical Observation", "SAO 203466"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.54841472),
        dec: Angle.Degrees(-32.32120030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 824"},
        {"Hipparcos Number", "HIP 1001"},
        {"Smithsonian Astrophysical Observation", "SAO 192398"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.12892949),
        dec: Angle.Degrees(-32.32082372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160124"},
        {"Hipparcos Number", "HIP 86432"},
        {"Geneva Identification System", "GEN# +2.64050100"},
        {"Smithsonian Astrophysical Observation", "SAO 209092"},
        {"New General Catalogue", "NGC 6405 100"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.90662995),
        dec: Angle.Degrees(-32.32012330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140304"},
        {"Hipparcos Number", "HIP 77057"},
        {"Smithsonian Astrophysical Observation", "SAO 206918"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01559397),
        dec: Angle.Degrees(-32.31973780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69018"},
        {"Hipparcos Number", "HIP 40303"},
        {"Geneva Identification System", "GEN# +1.00069018"},
        {"Smithsonian Astrophysical Observation", "SAO 198963"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.45512759),
        dec: Angle.Degrees(-32.31942775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150310"},
        {"Hipparcos Number", "HIP 81719"},
        {"Geneva Identification System", "GEN# +1.00150310"},
        {"Smithsonian Astrophysical Observation", "SAO 207927"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.38050902),
        dec: Angle.Degrees(-32.31849479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219034"},
        {"Hipparcos Number", "HIP 114601"},
        {"Smithsonian Astrophysical Observation", "SAO 214386"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.24777906),
        dec: Angle.Degrees(-32.31681344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132762"},
        {"Hipparcos Number", "HIP 73538"},
        {"Smithsonian Astrophysical Observation", "SAO 206221"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.45575972),
        dec: Angle.Degrees(-32.31619649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47434"},
        {"Smithsonian Astrophysical Observation", "SAO 200608"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.98764174),
        dec: Angle.Degrees(-32.31582437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136714"},
        {"Hipparcos Number", "HIP 75319"},
        {"Smithsonian Astrophysical Observation", "SAO 206582"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.82592476),
        dec: Angle.Degrees(-32.31339234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147312"},
        {"Hipparcos Number", "HIP 80216"},
        {"Smithsonian Astrophysical Observation", "SAO 207601"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.62566573),
        dec: Angle.Degrees(-32.31063129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210975"},
        {"Hipparcos Number", "HIP 109816"},
        {"Geneva Identification System", "GEN# +1.00210975"},
        {"Smithsonian Astrophysical Observation", "SAO 213660"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.64502103),
        dec: Angle.Degrees(-32.30798672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22055"},
        {"Hipparcos Number", "HIP 16480"},
        {"Smithsonian Astrophysical Observation", "SAO 194361"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.05432677),
        dec: Angle.Degrees(-32.30796395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162186"},
        {"Hipparcos Number", "HIP 87368"},
        {"Geneva Identification System", "GEN# +1.00162186"},
        {"Smithsonian Astrophysical Observation", "SAO 209352"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.77854561),
        dec: Angle.Degrees(-32.30761304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64534"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.41417839),
        dec: Angle.Degrees(-32.30744520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46997"},
        {"Hipparcos Number", "HIP 31402"},
        {"Celescope Catalog", "CEL 1310"},
        {"Geneva Identification System", "GEN# +1.00046997J"},
        {"Smithsonian Astrophysical Observation", "SAO 196963"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.73401413),
        dec: Angle.Degrees(-32.30665945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38666"},
        {"Hipparcos Number", "HIP 27204"},
        {"Geneva Identification System", "GEN# +1.00038666"},
        {"Smithsonian Astrophysical Observation", "SAO 196149"},
        {"Wilson Evans Batten Catalogue", "WEB 5351"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.49955386),
        dec: Angle.Degrees(-32.30637997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25085"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.55578530),
        dec: Angle.Degrees(-32.30593064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44253"},
        {"Smithsonian Astrophysical Observation", "SAO 199880"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.18834362),
        dec: Angle.Degrees(-32.30540890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138009"},
        {"Hipparcos Number", "HIP 75924"},
        {"Smithsonian Astrophysical Observation", "SAO 206708"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.60940056),
        dec: Angle.Degrees(-32.30350995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112521"},
        {"Hipparcos Number", "HIP 63251"},
        {"Fundamental Katalog 5th Edition", "FK5 5143"},
        {"Geneva Identification System", "GEN# +1.00112521"},
        {"Smithsonian Astrophysical Observation", "SAO 203973"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.40290105),
        dec: Angle.Degrees(-32.30029648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8371"},
        {"Hipparcos Number", "HIP 6421"},
        {"Smithsonian Astrophysical Observation", "SAO 193075"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.61068056),
        dec: Angle.Degrees(-32.29886531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30750"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91927219),
        dec: Angle.Degrees(-32.29862192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222234"},
        {"Hipparcos Number", "HIP 116706"},
        {"Smithsonian Astrophysical Observation", "SAO 214684"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.76229965),
        dec: Angle.Degrees(-32.29809042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9961"},
        {"Hipparcos Number", "HIP 7517"},
        {"Geneva Identification System", "GEN# +1.00009961"},
        {"Smithsonian Astrophysical Observation", "SAO 193207"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20349107),
        dec: Angle.Degrees(-32.29714386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204107"},
        {"Hipparcos Number", "HIP 105940"},
        {"Smithsonian Astrophysical Observation", "SAO 213013"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.83400083),
        dec: Angle.Degrees(-32.29689238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197189"},
        {"Hipparcos Number", "HIP 102256"},
        {"Smithsonian Astrophysical Observation", "SAO 212377"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.80202139),
        dec: Angle.Degrees(-32.29316870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102647"},
        {"Smithsonian Astrophysical Observation", "SAO 212445"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.99783556),
        dec: Angle.Degrees(-32.29291803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47944"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.54944533),
        dec: Angle.Degrees(-32.28998815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170500"},
        {"Hipparcos Number", "HIP 90772"},
        {"Geneva Identification System", "GEN# +1.00170500"},
        {"Smithsonian Astrophysical Observation", "SAO 210259"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79403626),
        dec: Angle.Degrees(-32.28991550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13615"},
        {"Hipparcos Number", "HIP 10260"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.00547000),
        dec: Angle.Degrees(-32.28764383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74379"},
        {"Smithsonian Astrophysical Observation", "SAO 206393"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.98903648),
        dec: Angle.Degrees(-32.28749038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193071"},
        {"Hipparcos Number", "HIP 100205"},
        {"Smithsonian Astrophysical Observation", "SAO 212001"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.86370894),
        dec: Angle.Degrees(-32.28642058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17550"},
        {"Hipparcos Number", "HIP 13073"},
        {"Smithsonian Astrophysical Observation", "SAO 193920"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.00396355),
        dec: Angle.Degrees(-32.28632318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3101"},
        {"Hipparcos Number", "HIP 2685"},
        {"Geneva Identification System", "GEN# +1.00003101J"},
        {"Smithsonian Astrophysical Observation", "SAO 192614"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.52233094),
        dec: Angle.Degrees(-32.28555767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20684"},
        {"Smithsonian Astrophysical Observation", "SAO 195004"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.46209374),
        dec: Angle.Degrees(-32.28544120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24248"},
        {"Hipparcos Number", "HIP 17951"},
        {"Geneva Identification System", "GEN# +1.00024248"},
        {"Smithsonian Astrophysical Observation", "SAO 194564"},
        {"Wilson Evans Batten Catalogue", "WEB 3457"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.56895860),
        dec: Angle.Degrees(-32.28541714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166484"},
        {"Hipparcos Number", "HIP 89199"},
        {"Smithsonian Astrophysical Observation", "SAO 209846"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.05599765),
        dec: Angle.Degrees(-32.28158023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73982"},
        {"Hipparcos Number", "HIP 42517"},
        {"Smithsonian Astrophysical Observation", "SAO 199488"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.03074630),
        dec: Angle.Degrees(-32.27360800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2643"},
        {"Hipparcos Number", "HIP 2342"},
        {"Geneva Identification System", "GEN# +1.00002643"},
        {"Smithsonian Astrophysical Observation", "SAO 192570"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.47913671),
        dec: Angle.Degrees(-32.27327542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133379"},
        {"Hipparcos Number", "HIP 73805"},
        {"Smithsonian Astrophysical Observation", "SAO 206278"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.27650398),
        dec: Angle.Degrees(-32.27131260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12170"},
        {"Hipparcos Number", "HIP 9235"},
        {"Smithsonian Astrophysical Observation", "SAO 193426"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.68625676),
        dec: Angle.Degrees(-32.27064328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199148"},
        {"Hipparcos Number", "HIP 103350"},
        {"Smithsonian Astrophysical Observation", "SAO 212556"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.08362289),
        dec: Angle.Degrees(-32.27001236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4276"},
        {"Hipparcos Number", "HIP 3514"},
        {"Smithsonian Astrophysical Observation", "SAO 192713"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.21174110),
        dec: Angle.Degrees(-32.26875652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114176"},
    },
    visualMagnitude: 12.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.83136570),
        dec: Angle.Degrees(-32.26819891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103742"},
        {"Hipparcos Number", "HIP 58240"},
        {"Geneva Identification System", "GEN# +1.00103742"},
        {"Smithsonian Astrophysical Observation", "SAO 202965"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.17678672),
        dec: Angle.Degrees(-32.26813704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3812"},
        {"Hipparcos Number", "HIP 3177"},
        {"Geneva Identification System", "GEN# +1.00003812"},
        {"Smithsonian Astrophysical Observation", "SAO 192670"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.12223462),
        dec: Angle.Degrees(-32.26788141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103743"},
        {"Hipparcos Number", "HIP 58241"},
        {"Geneva Identification System", "GEN# +1.00103743"},
        {"Smithsonian Astrophysical Observation", "SAO 202966"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18292571),
        dec: Angle.Degrees(-32.26739752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212906"},
        {"Hipparcos Number", "HIP 110904"},
        {"Smithsonian Astrophysical Observation", "SAO 213845"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.04229418),
        dec: Angle.Degrees(-32.26585104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73257"},
        {"Hipparcos Number", "HIP 42207"},
        {"Smithsonian Astrophysical Observation", "SAO 199419"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09051205),
        dec: Angle.Degrees(-32.26194978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90530"},
        {"Hipparcos Number", "HIP 51115"},
        {"Geneva Identification System", "GEN# +1.00090530"},
        {"Smithsonian Astrophysical Observation", "SAO 201392"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.65132306),
        dec: Angle.Degrees(-32.26155611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81571"},
        {"Hipparcos Number", "HIP 46231"},
        {"Smithsonian Astrophysical Observation", "SAO 200348"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.38420568),
        dec: Angle.Degrees(-32.26036178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145378"},
        {"Hipparcos Number", "HIP 79355"},
        {"Geneva Identification System", "GEN# +1.00145378"},
        {"Smithsonian Astrophysical Observation", "SAO 207440"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.94552928),
        dec: Angle.Degrees(-32.25999628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218318"},
        {"Hipparcos Number", "HIP 114177"},
        {"Geneva Identification System", "GEN# +1.00218318"},
        {"Smithsonian Astrophysical Observation", "SAO 214321"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.83258534),
        dec: Angle.Degrees(-32.25990628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164997"},
        {"Hipparcos Number", "HIP 88585"},
        {"Smithsonian Astrophysical Observation", "SAO 209680"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.30749252),
        dec: Angle.Degrees(-32.25979819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147596"},
        {"Hipparcos Number", "HIP 80341"},
        {"Smithsonian Astrophysical Observation", "SAO 207628"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.01776679),
        dec: Angle.Degrees(-32.25874460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104730"},
        {"Hipparcos Number", "HIP 58793"},
        {"Smithsonian Astrophysical Observation", "SAO 203083"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.88580078),
        dec: Angle.Degrees(-32.25785890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199951"},
        {"Hipparcos Number", "HIP 103738"},
        {"Fundamental Katalog 5th Edition", "FK5 1550"},
        {"Geneva Identification System", "GEN# +1.00199951"},
        {"Smithsonian Astrophysical Observation", "SAO 212636"},
        {"Wilson Evans Batten Catalogue", "WEB 18881"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.32275695),
        dec: Angle.Degrees(-32.25776681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30141"},
        {"Hipparcos Number", "HIP 21997"},
        {"Smithsonian Astrophysical Observation", "SAO 195253"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.92162449),
        dec: Angle.Degrees(-32.25738943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176128"},
        {"Hipparcos Number", "HIP 93289"},
        {"Geneva Identification System", "GEN# +1.00176128"},
        {"Smithsonian Astrophysical Observation", "SAO 210800"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.01861950),
        dec: Angle.Degrees(-32.25582475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114918"},
        {"Hipparcos Number", "HIP 64570"},
        {"Smithsonian Astrophysical Observation", "SAO 204263"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.52085827),
        dec: Angle.Degrees(-32.25418984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217594"},
        {"Hipparcos Number", "HIP 113757"},
        {"Smithsonian Astrophysical Observation", "SAO 214258"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.56328961),
        dec: Angle.Degrees(-32.25305234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85126"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95559928),
        dec: Angle.Degrees(-32.25302066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -615.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220663"},
        {"Hipparcos Number", "HIP 115659"},
        {"Smithsonian Astrophysical Observation", "SAO 214540"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.45449683),
        dec: Angle.Degrees(-32.25172033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30684"},
        {"Smithsonian Astrophysical Observation", "SAO 196829"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.72106957),
        dec: Angle.Degrees(-32.25004330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74822"},
        {"Hipparcos Number", "HIP 42937"},
        {"Smithsonian Astrophysical Observation", "SAO 199578"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.28670150),
        dec: Angle.Degrees(-32.24906563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7136"},
        {"Hipparcos Number", "HIP 5547"},
        {"Geneva Identification System", "GEN# +1.00007136"},
        {"Smithsonian Astrophysical Observation", "SAO 192968"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.78932513),
        dec: Angle.Degrees(-32.24769705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130223"},
        {"Hipparcos Number", "HIP 72372"},
        {"Smithsonian Astrophysical Observation", "SAO 205953"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.97338446),
        dec: Angle.Degrees(-32.24707987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171079"},
        {"Hipparcos Number", "HIP 91030"},
        {"Smithsonian Astrophysical Observation", "SAO 210315"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.54035778),
        dec: Angle.Degrees(-32.24527841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11340"},
        {"Hipparcos Number", "HIP 8589"},
        {"Smithsonian Astrophysical Observation", "SAO 193331"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.71663610),
        dec: Angle.Degrees(-32.24494124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116016"},
        {"Hipparcos Number", "HIP 65177"},
        {"Smithsonian Astrophysical Observation", "SAO 204381"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.35314365),
        dec: Angle.Degrees(-32.24437815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115986"},
        {"Hipparcos Number", "HIP 65164"},
        {"Smithsonian Astrophysical Observation", "SAO 204377"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.30199654),
        dec: Angle.Degrees(-32.24285245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155448"},
        {"Hipparcos Number", "HIP 84228"},
        {"Smithsonian Astrophysical Observation", "SAO 208540"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.24485869),
        dec: Angle.Degrees(-32.24265600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21573"},
        {"Hipparcos Number", "HIP 16125"},
        {"Smithsonian Astrophysical Observation", "SAO 194313"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.92296433),
        dec: Angle.Degrees(-32.24167642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155600"},
        {"Hipparcos Number", "HIP 84292"},
        {"Geneva Identification System", "GEN# +1.00155600"},
        {"Smithsonian Astrophysical Observation", "SAO 208562"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.48902823),
        dec: Angle.Degrees(-32.24124878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185884"},
        {"Hipparcos Number", "HIP 96964"},
        {"Smithsonian Astrophysical Observation", "SAO 211491"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64779980),
        dec: Angle.Degrees(-32.23928853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32079"},
        {"Hipparcos Number", "HIP 23183"},
        {"Smithsonian Astrophysical Observation", "SAO 195455"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.82996424),
        dec: Angle.Degrees(-32.23925907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76785"},
        {"Smithsonian Astrophysical Observation", "SAO 206861"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.16157860),
        dec: Angle.Degrees(-32.23868391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118539"},
        {"Hipparcos Number", "HIP 66527"},
        {"Smithsonian Astrophysical Observation", "SAO 204680"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.54535999),
        dec: Angle.Degrees(-32.23833287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144137"},
        {"Hipparcos Number", "HIP 78830"},
        {"Geneva Identification System", "GEN# +1.00144137J"},
        {"Smithsonian Astrophysical Observation", "SAO 207319"},
        {"Wilson Evans Batten Catalogue", "WEB 13326"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.37879497),
        dec: Angle.Degrees(-32.23796428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5252"},
        {"Hipparcos Number", "HIP 4225"},
        {"Smithsonian Astrophysical Observation", "SAO 192802"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.47332905),
        dec: Angle.Degrees(-32.23756604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221454"},
        {"Hipparcos Number", "HIP 116189"},
        {"Smithsonian Astrophysical Observation", "SAO 214609"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.12333901),
        dec: Angle.Degrees(-32.23712724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75101"},
        {"Hipparcos Number", "HIP 43120"},
        {"Smithsonian Astrophysical Observation", "SAO 199610"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.72805567),
        dec: Angle.Degrees(-32.23516611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68650"},
    },
    visualMagnitude: 11.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.78589556),
        dec: Angle.Degrees(-32.23370607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34938"},
        {"Smithsonian Astrophysical Observation", "SAO 197720"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.44790709),
        dec: Angle.Degrees(-32.23364774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74300"},
        {"Hipparcos Number", "HIP 42707"},
        {"Celescope Catalog", "CEL 2789"},
        {"Geneva Identification System", "GEN# +1.00074300"},
        {"Smithsonian Astrophysical Observation", "SAO 199516"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.55246654),
        dec: Angle.Degrees(-32.23135128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29873"},
        {"Hipparcos Number", "HIP 21799"},
        {"Smithsonian Astrophysical Observation", "SAO 195221"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.25188100),
        dec: Angle.Degrees(-32.22658313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46694"},
        {"Hipparcos Number", "HIP 31269"},
        {"Smithsonian Astrophysical Observation", "SAO 196933"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36391791),
        dec: Angle.Degrees(-32.22638214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47391"},
        {"Hipparcos Number", "HIP 31623"},
        {"Geneva Identification System", "GEN# +1.00047391"},
        {"Smithsonian Astrophysical Observation", "SAO 197008"},
        {"Wilson Evans Batten Catalogue", "WEB 6328"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.26558178),
        dec: Angle.Degrees(-32.22506176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 352.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43032"},
        {"Hipparcos Number", "HIP 29475"},
        {"Smithsonian Astrophysical Observation", "SAO 196586"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.15764423),
        dec: Angle.Degrees(-32.22354295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31534"},
        {"Smithsonian Astrophysical Observation", "SAO 196989"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.02356105),
        dec: Angle.Degrees(-32.22193322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167708"},
        {"Hipparcos Number", "HIP 89661"},
        {"Smithsonian Astrophysical Observation", "SAO 209967"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46454269),
        dec: Angle.Degrees(-32.21934894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116015"},
        {"Hipparcos Number", "HIP 65171"},
        {"Smithsonian Astrophysical Observation", "SAO 204379"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.34199703),
        dec: Angle.Degrees(-32.21602514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160371"},
        {"Hipparcos Number", "HIP 86527"},
        {"Geneva Identification System", "GEN# +2.64050001"},
        {"Smithsonian Astrophysical Observation", "SAO 209132"},
        {"New General Catalogue", "NGC 6405 1"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.24394821),
        dec: Angle.Degrees(-32.21444835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168684"},
        {"Hipparcos Number", "HIP 90043"},
        {"Smithsonian Astrophysical Observation", "SAO 210055"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.60290508),
        dec: Angle.Degrees(-32.21429177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73151"},
        {"Hipparcos Number", "HIP 42162"},
        {"Fundamental Katalog 5th Edition", "FK5 4774"},
        {"Smithsonian Astrophysical Observation", "SAO 199408"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.92815887),
        dec: Angle.Degrees(-32.21392570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185537"},
        {"Hipparcos Number", "HIP 96819"},
        {"Smithsonian Astrophysical Observation", "SAO 211469"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.19732014),
        dec: Angle.Degrees(-32.21388337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41671"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.43599838),
        dec: Angle.Degrees(-32.21270511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118084"},
        {"Hipparcos Number", "HIP 66292"},
        {"Geneva Identification System", "GEN# +1.00118084"},
        {"Smithsonian Astrophysical Observation", "SAO 204623"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.80120588),
        dec: Angle.Degrees(-32.21232053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37017"},
        {"Geneva Identification System", "GEN# -0.03104800"},
        {"Renson", "Renson 16720"},
    },
    visualMagnitude: 10.53,
    bvColour: -0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.12588626),
        dec: Angle.Degrees(-32.21223352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90765"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.77447521),
        dec: Angle.Degrees(-32.21203837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23783"},
        {"Hipparcos Number", "HIP 17630"},
        {"Smithsonian Astrophysical Observation", "SAO 194520"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.66639406),
        dec: Angle.Degrees(-32.21144951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18586"},
        {"Smithsonian Astrophysical Observation", "SAO 194665"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65921641),
        dec: Angle.Degrees(-32.21091174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224663"},
        {"Hipparcos Number", "HIP 118304"},
        {"Geneva Identification System", "GEN# +1.00224663"},
        {"Smithsonian Astrophysical Observation", "SAO 214904"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.93608971),
        dec: Angle.Degrees(-32.21064241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40718"},
        {"Hipparcos Number", "HIP 28335"},
        {"Geneva Identification System", "GEN# +1.00040718"},
        {"Smithsonian Astrophysical Observation", "SAO 196380"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.81794351),
        dec: Angle.Degrees(-32.20969223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35811"},
        {"Hipparcos Number", "HIP 25399"},
        {"Smithsonian Astrophysical Observation", "SAO 195848"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.50378909),
        dec: Angle.Degrees(-32.20919394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91047"},
        {"Hipparcos Number", "HIP 51418"},
        {"Smithsonian Astrophysical Observation", "SAO 201453"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52518646),
        dec: Angle.Degrees(-32.20750965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196189"},
        {"Hipparcos Number", "HIP 101693"},
        {"Geneva Identification System", "GEN# +1.00196189"},
        {"Smithsonian Astrophysical Observation", "SAO 212279"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.18757823),
        dec: Angle.Degrees(-32.20724108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210974"},
        {"Hipparcos Number", "HIP 109823"},
        {"Smithsonian Astrophysical Observation", "SAO 213661"},
    },
    visualMagnitude: 9.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.65951288),
        dec: Angle.Degrees(-32.20630317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61005"},
        {"Hipparcos Number", "HIP 36948"},
        {"Geneva Identification System", "GEN# +1.00061005"},
        {"Smithsonian Astrophysical Observation", "SAO 198166"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.94791807),
        dec: Angle.Degrees(-32.20408225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58286"},
        {"Hipparcos Number", "HIP 35855"},
        {"Celescope Catalog", "CEL 1823"},
        {"Geneva Identification System", "GEN# +5.11400002"},
        {"Smithsonian Astrophysical Observation", "SAO 197938"},
        {"Wilson Evans Batten Catalogue", "WEB 7144"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.88291983),
        dec: Angle.Degrees(-32.20207858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160202"},
        {"Hipparcos Number", "HIP 86468"},
        {"Fundamental Katalog 5th Edition", "FK5 3403"},
        {"Geneva Identification System", "GEN# +2.64050032"},
        {"Smithsonian Astrophysical Observation", "SAO 209105"},
        {"Wilson Evans Batten Catalogue", "WEB 14584"},
        {"New General Catalogue", "NGC 6405 32"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.00434366),
        dec: Angle.Degrees(-32.20105310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42619"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.28443244),
        dec: Angle.Degrees(-32.20082835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208709"},
        {"Hipparcos Number", "HIP 108499"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.70523581),
        dec: Angle.Degrees(-32.20067038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16065"},
        {"Hipparcos Number", "HIP 11928"},
        {"Geneva Identification System", "GEN# +1.00016065"},
        {"Smithsonian Astrophysical Observation", "SAO 193773"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.48190677),
        dec: Angle.Degrees(-32.19747766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84086"},
        {"Hipparcos Number", "HIP 47562"},
        {"Smithsonian Astrophysical Observation", "SAO 200643"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.45714664),
        dec: Angle.Degrees(-32.19172398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57912"},
        {"Hipparcos Number", "HIP 35700"},
        {"Celescope Catalog", "CEL 1806"},
        {"Geneva Identification System", "GEN# +5.11400019"},
        {"Smithsonian Astrophysical Observation", "SAO 197896"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.48926025),
        dec: Angle.Degrees(-32.19111792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152433"},
        {"Hipparcos Number", "HIP 82738"},
        {"Geneva Identification System", "GEN# +1.00152433"},
        {"Smithsonian Astrophysical Observation", "SAO 208177"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.66842733),
        dec: Angle.Degrees(-32.19008201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136501"},
        {"Hipparcos Number", "HIP 75207"},
        {"Smithsonian Astrophysical Observation", "SAO 206560"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.53670184),
        dec: Angle.Degrees(-32.18960260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117324"},
        {"Hipparcos Number", "HIP 65861"},
        {"Smithsonian Astrophysical Observation", "SAO 204528"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49957721),
        dec: Angle.Degrees(-32.18942798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27793"},
        {"Hipparcos Number", "HIP 20383"},
        {"Smithsonian Astrophysical Observation", "SAO 194955"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.47162016),
        dec: Angle.Degrees(-32.18799067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140037"},
        {"Hipparcos Number", "HIP 76943"},
        {"Geneva Identification System", "GEN# +1.00140037"},
        {"Smithsonian Astrophysical Observation", "SAO 206892"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.66708767),
        dec: Angle.Degrees(-32.18601154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127407"},
        {"Hipparcos Number", "HIP 71066"},
        {"Smithsonian Astrophysical Observation", "SAO 205656"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00061251),
        dec: Angle.Degrees(-32.18557983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81631"},
        {"Hipparcos Number", "HIP 46257"},
        {"Smithsonian Astrophysical Observation", "SAO 200360"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.46438888),
        dec: Angle.Degrees(-32.18548529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9833"},
        {"Hipparcos Number", "HIP 7410"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.87824988),
        dec: Angle.Degrees(-32.18509391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159682"},
        {"Hipparcos Number", "HIP 86244"},
        {"Geneva Identification System", "GEN# +1.00159682"},
        {"Smithsonian Astrophysical Observation", "SAO 209040"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.35991092),
        dec: Angle.Degrees(-32.18470009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50331"},
        {"Hipparcos Number", "HIP 32905"},
        {"Smithsonian Astrophysical Observation", "SAO 197284"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.84145230),
        dec: Angle.Degrees(-32.18368422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71583"},
        {"Hipparcos Number", "HIP 41438"},
        {"Geneva Identification System", "GEN# +1.00071583"},
        {"Smithsonian Astrophysical Observation", "SAO 199239"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.76739275),
        dec: Angle.Degrees(-32.18346337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176538"},
        {"Hipparcos Number", "HIP 93467"},
        {"Smithsonian Astrophysical Observation", "SAO 210845"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.53242540),
        dec: Angle.Degrees(-32.18248203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76531"},
        {"Hipparcos Number", "HIP 43838"},
        {"Smithsonian Astrophysical Observation", "SAO 199797"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.92711755),
        dec: Angle.Degrees(-32.17963117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159175"},
        {"Hipparcos Number", "HIP 85999"},
        {"Geneva Identification System", "GEN# +1.00159175"},
        {"Smithsonian Astrophysical Observation", "SAO 208974"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.65298379),
        dec: Angle.Degrees(-32.17895913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83380"},
        {"Hipparcos Number", "HIP 47199"},
        {"Fundamental Katalog 5th Edition", "FK5 1248"},
        {"Geneva Identification System", "GEN# +1.00083380"},
        {"Smithsonian Astrophysical Observation", "SAO 200561"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.29112334),
        dec: Angle.Degrees(-32.17861272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218748"},
        {"Hipparcos Number", "HIP 114447"},
        {"Geneva Identification System", "GEN# +1.00218748"},
        {"Smithsonian Astrophysical Observation", "SAO 214363"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.67083570),
        dec: Angle.Degrees(-32.17816054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89060"},
        {"Hipparcos Number", "HIP 50268"},
        {"Smithsonian Astrophysical Observation", "SAO 201225"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.96142731),
        dec: Angle.Degrees(-32.17623919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189328"},
        {"Hipparcos Number", "HIP 98499"},
        {"Geneva Identification System", "GEN# +1.00189328"},
        {"Smithsonian Astrophysical Observation", "SAO 211729"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.16153597),
        dec: Angle.Degrees(-32.17562434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175778"},
        {"Hipparcos Number", "HIP 93126"},
        {"Smithsonian Astrophysical Observation", "SAO 210771"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.57196398),
        dec: Angle.Degrees(-32.17553665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221066"},
        {"Hipparcos Number", "HIP 115914"},
        {"Smithsonian Astrophysical Observation", "SAO 214574"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.27024609),
        dec: Angle.Degrees(-32.17526035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41534"},
        {"Hipparcos Number", "HIP 28756"},
        {"Fundamental Katalog 5th Edition", "FK5 2464"},
        {"Smithsonian Astrophysical Observation", "SAO 196459"},
        {"Wilson Evans Batten Catalogue", "WEB 5625"},
    },
    visualMagnitude: 5.65,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08448552),
        dec: Angle.Degrees(-32.17272393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318327"},
        {"Hipparcos Number", "HIP 86961"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.55276344),
        dec: Angle.Degrees(-32.10277328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202627"},
        {"Hipparcos Number", "HIP 105140"},
        {"Fundamental Katalog 5th Edition", "FK5 801"},
        {"Geneva Identification System", "GEN# +1.00202627"},
        {"Renson", "Renson 56450"},
        {"Smithsonian Astrophysical Observation", "SAO 212874"},
        {"Wilson Evans Batten Catalogue", "WEB 19094"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.48436063),
        dec: Angle.Degrees(-32.17248551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129981"},
        {"Hipparcos Number", "HIP 72257"},
        {"Geneva Identification System", "GEN# +1.00129981"},
        {"Smithsonian Astrophysical Observation", "SAO 205930"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.64013579),
        dec: Angle.Degrees(-32.17090264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173682"},
        {"Hipparcos Number", "HIP 92238"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.97916009),
        dec: Angle.Degrees(-32.17008772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71381"},
        {"Hipparcos Number", "HIP 41335"},
        {"Geneva Identification System", "GEN# +1.00071381"},
        {"Smithsonian Astrophysical Observation", "SAO 199215"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.50255962),
        dec: Angle.Degrees(-32.17004472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10149"},
        {"Hipparcos Number", "HIP 7661"},
        {"Geneva Identification System", "GEN# +1.00010149"},
        {"Smithsonian Astrophysical Observation", "SAO 193226"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.65953398),
        dec: Angle.Degrees(-32.16930201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123990"},
        {"Hipparcos Number", "HIP 69337"},
        {"Fundamental Katalog 5th Edition", "FK5 5255"},
        {"Geneva Identification System", "GEN# +1.00123990"},
        {"Renson", "Renson 35470"},
        {"Smithsonian Astrophysical Observation", "SAO 205284"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.87218466),
        dec: Angle.Degrees(-32.16850477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63986"},
        {"Hipparcos Number", "HIP 38264"},
        {"Geneva Identification System", "GEN# +1.00063986"},
        {"Smithsonian Astrophysical Observation", "SAO 198501"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.59033384),
        dec: Angle.Degrees(-32.16684501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45610"},
        {"Hipparcos Number", "HIP 30705"},
        {"Geneva Identification System", "GEN# +1.00045610"},
        {"Smithsonian Astrophysical Observation", "SAO 196834"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.77800031),
        dec: Angle.Degrees(-32.16659503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74005"},
        {"Hipparcos Number", "HIP 42533"},
        {"Smithsonian Astrophysical Observation", "SAO 199492"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07337444),
        dec: Angle.Degrees(-32.16531342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120411"},
    },
    visualMagnitude: 11.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)47, 58.1800),
        dec: Angle.DegreesMinutesSeconds((int)-32, (int)09, 54.200)
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
    primaryId: "HIP 114331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218569"},
        {"Hipparcos Number", "HIP 114331"},
        {"Smithsonian Astrophysical Observation", "SAO 214346"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.32928212),
        dec: Angle.Degrees(-32.16447332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223317"},
        {"Hipparcos Number", "HIP 117429"},
        {"Smithsonian Astrophysical Observation", "SAO 214786"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.16114358),
        dec: Angle.Degrees(-32.16410389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74948"},
        {"Hipparcos Number", "HIP 43013"},
        {"Smithsonian Astrophysical Observation", "SAO 199589"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.48595317),
        dec: Angle.Degrees(-32.16385057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143673"},
        {"Hipparcos Number", "HIP 78609"},
        {"Geneva Identification System", "GEN# +1.00143673"},
        {"Smithsonian Astrophysical Observation", "SAO 207269"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.73730184),
        dec: Angle.Degrees(-32.16195313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72227"},
        {"Hipparcos Number", "HIP 41723"},
        {"Geneva Identification System", "GEN# +1.00072227J"},
        {"Smithsonian Astrophysical Observation", "SAO 199308"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.61924898),
        dec: Angle.Degrees(-32.15928753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137055"},
        {"Hipparcos Number", "HIP 75472"},
        {"Geneva Identification System", "GEN# +1.00137055"},
        {"Smithsonian Astrophysical Observation", "SAO 206608"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.26373010),
        dec: Angle.Degrees(-32.15615230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68886"},
        {"Hipparcos Number", "HIP 40250"},
        {"Celescope Catalog", "CEL 2246"},
        {"Geneva Identification System", "GEN# +1.00068886"},
        {"Smithsonian Astrophysical Observation", "SAO 198947"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.31261701),
        dec: Angle.Degrees(-32.15614862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76278"},
        {"Hipparcos Number", "HIP 43716"},
        {"Smithsonian Astrophysical Observation", "SAO 199765"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.54125425),
        dec: Angle.Degrees(-32.15566838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160335"},
        {"Hipparcos Number", "HIP 86508"},
        {"Geneva Identification System", "GEN# +2.64050002"},
        {"Smithsonian Astrophysical Observation", "SAO 209125"},
        {"New General Catalogue", "NGC 6405 2"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.18064862),
        dec: Angle.Degrees(-32.15564903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1078"},
        {"Hipparcos Number", "HIP 1190"},
        {"Smithsonian Astrophysical Observation", "SAO 192417"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.72251371),
        dec: Angle.Degrees(-32.15269910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27950"},
        {"Hipparcos Number", "HIP 20474"},
        {"Smithsonian Astrophysical Observation", "SAO 194972"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.82418902),
        dec: Angle.Degrees(-32.15196303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108241"},
        {"Hipparcos Number", "HIP 60687"},
        {"Smithsonian Astrophysical Observation", "SAO 203467"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.56756543),
        dec: Angle.Degrees(-32.15127630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99639"},
        {"Hipparcos Number", "HIP 55921"},
        {"Geneva Identification System", "GEN# +1.00099639"},
        {"Smithsonian Astrophysical Observation", "SAO 202464"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91881248),
        dec: Angle.Degrees(-32.14959173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134231"},
        {"Hipparcos Number", "HIP 74200"},
        {"Geneva Identification System", "GEN# +1.00134231"},
        {"Smithsonian Astrophysical Observation", "SAO 206347"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.44326138),
        dec: Angle.Degrees(-32.14933484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81044"},
        {"Hipparcos Number", "HIP 45957"},
        {"Cincinnati Publication", "Ci 20 521"},
        {"Geneva Identification System", "GEN# +1.00081044"},
        {"Smithsonian Astrophysical Observation", "SAO 200286"},
        {"Wilson Evans Batten Catalogue", "WEB 8715"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.58725624),
        dec: Angle.Degrees(-32.14917867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -627.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 291.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54892"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.59663996),
        dec: Angle.Degrees(-32.14748298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149600"},
        {"Hipparcos Number", "HIP 81374"},
        {"Geneva Identification System", "GEN# +1.00149600"},
        {"Smithsonian Astrophysical Observation", "SAO 207840"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.28388707),
        dec: Angle.Degrees(-32.14586389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166003"},
        {"Hipparcos Number", "HIP 89016"},
        {"Smithsonian Astrophysical Observation", "SAO 209799"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.51288862),
        dec: Angle.Degrees(-32.14371835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153613"},
        {"Hipparcos Number", "HIP 83336"},
        {"Fundamental Katalog 5th Edition", "FK5 3354"},
        {"Geneva Identification System", "GEN# +1.00153613A"},
        {"Smithsonian Astrophysical Observation", "SAO 208324"},
        {"Wilson Evans Batten Catalogue", "WEB 14085"},
    },
    visualMagnitude: 5.03,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46937192),
        dec: Angle.Degrees(-32.14340148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76950"},
        {"Hipparcos Number", "HIP 44058"},
        {"Geneva Identification System", "GEN# +1.00076950"},
        {"Smithsonian Astrophysical Observation", "SAO 199838"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.58601761),
        dec: Angle.Degrees(-32.14211749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213728"},
        {"Hipparcos Number", "HIP 111397"},
        {"Geneva Identification System", "GEN# +1.00213728"},
        {"Smithsonian Astrophysical Observation", "SAO 213918"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.52175047),
        dec: Angle.Degrees(-32.14209680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137013"},
        {"Hipparcos Number", "HIP 75445"},
        {"Smithsonian Astrophysical Observation", "SAO 206604"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.19954001),
        dec: Angle.Degrees(-32.14144820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69080"},
        {"Hipparcos Number", "HIP 40341"},
        {"Celescope Catalog", "CEL 2261"},
        {"Fundamental Katalog 5th Edition", "FK5 2644"},
        {"Geneva Identification System", "GEN# +1.00069080"},
        {"Smithsonian Astrophysical Observation", "SAO 198972"},
        {"Wilson Evans Batten Catalogue", "WEB 7869"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.54599673),
        dec: Angle.Degrees(-32.14072755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117548"},
        {"Hipparcos Number", "HIP 65972"},
        {"Geneva Identification System", "GEN# +1.00117548"},
        {"Smithsonian Astrophysical Observation", "SAO 204552"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.89319675),
        dec: Angle.Degrees(-32.14068578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148846"},
        {"Hipparcos Number", "HIP 80980"},
        {"Smithsonian Astrophysical Observation", "SAO 207747"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.05855565),
        dec: Angle.Degrees(-32.13958171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11943"},
        {"Hipparcos Number", "HIP 9049"},
        {"Geneva Identification System", "GEN# +1.00011943"},
        {"Smithsonian Astrophysical Observation", "SAO 193396"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.14425058),
        dec: Angle.Degrees(-32.13834694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92946"},
        {"Hipparcos Number", "HIP 52453"},
        {"Celescope Catalog", "CEL 3663"},
        {"Geneva Identification System", "GEN# +1.00092946"},
        {"Smithsonian Astrophysical Observation", "SAO 201674"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.84269652),
        dec: Angle.Degrees(-32.13720180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14507"},
        {"Hipparcos Number", "HIP 10858"},
        {"Smithsonian Astrophysical Observation", "SAO 193643"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.93818802),
        dec: Angle.Degrees(-32.13527754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209253"},
        {"Hipparcos Number", "HIP 108809"},
        {"Fundamental Katalog 5th Edition", "FK5 3762"},
        {"Geneva Identification System", "GEN# +1.00209253"},
        {"Smithsonian Astrophysical Observation", "SAO 213495"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.63740680),
        dec: Angle.Degrees(-32.13380356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61431"},
        {"Hipparcos Number", "HIP 37145"},
        {"Smithsonian Astrophysical Observation", "SAO 198212"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.48986714),
        dec: Angle.Degrees(-32.13117905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145658"},
        {"Hipparcos Number", "HIP 79496"},
        {"Geneva Identification System", "GEN# +1.00145658"},
        {"Smithsonian Astrophysical Observation", "SAO 207466"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.34319284),
        dec: Angle.Degrees(-32.13005747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196648"},
        {"Hipparcos Number", "HIP 101964"},
        {"Smithsonian Astrophysical Observation", "SAO 212322"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.94894784),
        dec: Angle.Degrees(-32.12844126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103450"},
        {"Hipparcos Number", "HIP 58078"},
        {"Smithsonian Astrophysical Observation", "SAO 202930"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.65782821),
        dec: Angle.Degrees(-32.12776493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30514"},
        {"Cincinnati Publication", "Ci 20 386"},
        {"Geneva Identification System", "GEN# -0.03203010"},
        {"Smithsonian Astrophysical Observation", "SAO 196792"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.21406643),
        dec: Angle.Degrees(-32.12291952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 413.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2632"},
        {"Hipparcos Number", "HIP 2330"},
        {"Geneva Identification System", "GEN# +1.00002632"},
        {"Smithsonian Astrophysical Observation", "SAO 192567"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.45413735),
        dec: Angle.Degrees(-32.11592585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162909"},
        {"Hipparcos Number", "HIP 87700"},
        {"Smithsonian Astrophysical Observation", "SAO 209454"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.70227931),
        dec: Angle.Degrees(-32.11525628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107075"},
        {"Hipparcos Number", "HIP 60045"},
        {"Smithsonian Astrophysical Observation", "SAO 203335"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.71128970),
        dec: Angle.Degrees(-32.11511123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160491"},
        {"Hipparcos Number", "HIP 86580"},
        {"Geneva Identification System", "GEN# +2.64050009"},
        {"Smithsonian Astrophysical Observation", "SAO 209147"},
        {"New General Catalogue", "NGC 6405 9"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.40809715),
        dec: Angle.Degrees(-32.11213312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23126"},
        {"Geneva Identification System", "GEN# -0.03202069"},
        {"Smithsonian Astrophysical Observation", "SAO 195448"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.64353519),
        dec: Angle.Degrees(-32.11186285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36517"},
        {"Hipparcos Number", "HIP 25832"},
        {"Smithsonian Astrophysical Observation", "SAO 195917"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.72699238),
        dec: Angle.Degrees(-32.11167311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133396"},
        {"Hipparcos Number", "HIP 73813"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.29987752),
        dec: Angle.Degrees(-32.11157833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217839"},
        {"Hipparcos Number", "HIP 113886"},
        {"Smithsonian Astrophysical Observation", "SAO 214279"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96652804),
        dec: Angle.Degrees(-32.11018035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23236"},
        {"Hipparcos Number", "HIP 17310"},
        {"Smithsonian Astrophysical Observation", "SAO 194468"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.58273698),
        dec: Angle.Degrees(-32.10926769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149530"},
        {"Hipparcos Number", "HIP 81334"},
        {"Geneva Identification System", "GEN# +1.00149530"},
        {"Smithsonian Astrophysical Observation", "SAO 207826"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.17080676),
        dec: Angle.Degrees(-32.10921189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215436"},
        {"Hipparcos Number", "HIP 112365"},
        {"Fundamental Katalog 5th Edition", "FK5 6004"},
        {"Smithsonian Astrophysical Observation", "SAO 214058"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.38948737),
        dec: Angle.Degrees(-32.10634331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38940"},
        {"Geneva Identification System", "GEN# -0.03105309"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.51801909),
        dec: Angle.Degrees(-32.10628238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104837"},
        {"Hipparcos Number", "HIP 58857"},
        {"Geneva Identification System", "GEN# +1.00104837"},
        {"Smithsonian Astrophysical Observation", "SAO 203097"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.06686351),
        dec: Angle.Degrees(-32.10597479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150638"},
        {"Hipparcos Number", "HIP 81891"},
        {"Fundamental Katalog 5th Edition", "FK5 3325"},
        {"Geneva Identification System", "GEN# +1.00150638"},
        {"Smithsonian Astrophysical Observation", "SAO 207967"},
        {"Wilson Evans Batten Catalogue", "WEB 13832"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91137378),
        dec: Angle.Degrees(-32.10588875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82342"},
        {"Hipparcos Number", "HIP 46626"},
        {"Geneva Identification System", "GEN# +1.00082342A"},
        {"Smithsonian Astrophysical Observation", "SAO 200438"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.61722412),
        dec: Angle.Degrees(-32.10416827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 315.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75532"},
        {"Hipparcos Number", "HIP 43320"},
        {"Smithsonian Astrophysical Observation", "SAO 199669"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.37749918),
        dec: Angle.Degrees(-32.10353870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61675"},
        {"Hipparcos Number", "HIP 37262"},
        {"Smithsonian Astrophysical Observation", "SAO 198243"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.77989734),
        dec: Angle.Degrees(-32.10351780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23070"},
        {"Hipparcos Number", "HIP 17198"},
        {"Smithsonian Astrophysical Observation", "SAO 194448"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.23625717),
        dec: Angle.Degrees(-32.10314492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85820"},
        {"Hipparcos Number", "HIP 48517"},
        {"Smithsonian Astrophysical Observation", "SAO 200844"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.42254035),
        dec: Angle.Degrees(-32.10265390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98609"},
        {"Hipparcos Number", "HIP 55388"},
        {"Smithsonian Astrophysical Observation", "SAO 202339"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.12998825),
        dec: Angle.Degrees(-32.10210291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86963"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.56028243),
        dec: Angle.Degrees(-32.10165681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144880"},
        {"Hipparcos Number", "HIP 79138"},
        {"Geneva Identification System", "GEN# +1.00144880"},
        {"Smithsonian Astrophysical Observation", "SAO 207388"},
        {"Wilson Evans Batten Catalogue", "WEB 13378"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.29637914),
        dec: Angle.Degrees(-32.09958918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121287"},
        {"Hipparcos Number", "HIP 67980"},
        {"Geneva Identification System", "GEN# +1.00121287"},
        {"Smithsonian Astrophysical Observation", "SAO 204988"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.81800944),
        dec: Angle.Degrees(-32.09920526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24774"},
        {"Hipparcos Number", "HIP 18328"},
        {"Smithsonian Astrophysical Observation", "SAO 194622"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.77692180),
        dec: Angle.Degrees(-32.09877892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194832"},
        {"Hipparcos Number", "HIP 101028"},
        {"Smithsonian Astrophysical Observation", "SAO 212166"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.21834335),
        dec: Angle.Degrees(-32.09658109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114334"},
        {"Hipparcos Number", "HIP 64260"},
        {"Smithsonian Astrophysical Observation", "SAO 204185"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.56190629),
        dec: Angle.Degrees(-32.09460141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109352"},
        {"Hipparcos Number", "HIP 61347"},
        {"Geneva Identification System", "GEN# +1.00109352"},
        {"Smithsonian Astrophysical Observation", "SAO 203596"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.54933793),
        dec: Angle.Degrees(-32.09275962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169379"},
        {"Hipparcos Number", "HIP 90319"},
        {"Smithsonian Astrophysical Observation", "SAO 210131"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.42853871),
        dec: Angle.Degrees(-32.09155749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183312"},
        {"Hipparcos Number", "HIP 95905"},
        {"Geneva Identification System", "GEN# +1.00183312"},
        {"Smithsonian Astrophysical Observation", "SAO 211315"},
        {"Wilson Evans Batten Catalogue", "WEB 16790"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.56178392),
        dec: Angle.Degrees(-32.09130942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10531"},
        {"Hipparcos Number", "HIP 7945"},
        {"Smithsonian Astrophysical Observation", "SAO 193260"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.52267984),
        dec: Angle.Degrees(-32.09084335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20494"},
        {"Hipparcos Number", "HIP 15254"},
        {"Smithsonian Astrophysical Observation", "SAO 194204"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.19029614),
        dec: Angle.Degrees(-32.08934192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189929"},
        {"Hipparcos Number", "HIP 98782"},
        {"Geneva Identification System", "GEN# +1.00189929"},
        {"Smithsonian Astrophysical Observation", "SAO 211776"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.92920957),
        dec: Angle.Degrees(-32.08803009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12348"},
        {"Hipparcos Number", "HIP 9365"},
        {"Geneva Identification System", "GEN# +1.00012348"},
        {"Smithsonian Astrophysical Observation", "SAO 193446"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.08122361),
        dec: Angle.Degrees(-32.08728484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96746"},
        {"Hipparcos Number", "HIP 54429"},
        {"Geneva Identification System", "GEN# +1.00096746"},
        {"Smithsonian Astrophysical Observation", "SAO 202120"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.06479554),
        dec: Angle.Degrees(-32.08667412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141133"},
        {"Hipparcos Number", "HIP 77441"},
        {"Geneva Identification System", "GEN# +1.00141133"},
        {"Smithsonian Astrophysical Observation", "SAO 207000"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.12713093),
        dec: Angle.Degrees(-32.08647867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19914"},
        {"Hipparcos Number", "HIP 14801"},
        {"Smithsonian Astrophysical Observation", "SAO 194138"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.78774953),
        dec: Angle.Degrees(-32.08501879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28012"},
        {"Hipparcos Number", "HIP 20536"},
        {"Smithsonian Astrophysical Observation", "SAO 194983"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.01277350),
        dec: Angle.Degrees(-32.08005693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41351"},
        {"Hipparcos Number", "HIP 28679"},
        {"Smithsonian Astrophysical Observation", "SAO 196446"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.82601686),
        dec: Angle.Degrees(-32.07965035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62316"},
        {"Hipparcos Number", "HIP 37519"},
        {"Geneva Identification System", "GEN# +1.00062316"},
        {"Smithsonian Astrophysical Observation", "SAO 198311"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.50492813),
        dec: Angle.Degrees(-32.07959844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 521"},
        {"Hipparcos Number", "HIP 783"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.41558741),
        dec: Angle.Degrees(-32.07892872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106080"},
        {"Hipparcos Number", "HIP 59521"},
        {"Smithsonian Astrophysical Observation", "SAO 203230"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.09973041),
        dec: Angle.Degrees(-32.07853475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131255"},
        {"Hipparcos Number", "HIP 72857"},
        {"Smithsonian Astrophysical Observation", "SAO 206055"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.37727247),
        dec: Angle.Degrees(-32.07837844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123328"},
        {"Hipparcos Number", "HIP 69003"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.90146716),
        dec: Angle.Degrees(-32.07828838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32166"},
        {"Hipparcos Number", "HIP 23218"},
        {"Smithsonian Astrophysical Observation", "SAO 195463"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.94646145),
        dec: Angle.Degrees(-32.07817978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6289"},
        {"Hipparcos Number", "HIP 4939"},
        {"Smithsonian Astrophysical Observation", "SAO 192893"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85047350),
        dec: Angle.Degrees(-32.07785252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201745"},
        {"Hipparcos Number", "HIP 104700"},
        {"Smithsonian Astrophysical Observation", "SAO 212787"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12647550),
        dec: Angle.Degrees(-32.07769915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147857"},
        {"Hipparcos Number", "HIP 80475"},
        {"Geneva Identification System", "GEN# +1.00147857"},
        {"Smithsonian Astrophysical Observation", "SAO 207654"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.40240032),
        dec: Angle.Degrees(-32.07662186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123888"},
        {"Hipparcos Number", "HIP 69271"},
        {"Smithsonian Astrophysical Observation", "SAO 205270"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.71610247),
        dec: Angle.Degrees(-32.07570349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77735"},
        {"Geneva Identification System", "GEN# -0.03112353"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06146034),
        dec: Angle.Degrees(-32.04983495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222433"},
        {"Hipparcos Number", "HIP 116820"},
        {"Fundamental Katalog 5th Edition", "FK5 1618"},
        {"Geneva Identification System", "GEN# +1.00222433"},
        {"Smithsonian Astrophysical Observation", "SAO 214701"},
        {"Wilson Evans Batten Catalogue", "WEB 20611"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.15921709),
        dec: Angle.Degrees(-32.07299489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100394"},
        {"Hipparcos Number", "HIP 56336"},
        {"Geneva Identification System", "GEN# +1.00100394"},
        {"Smithsonian Astrophysical Observation", "SAO 202555"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.23156871),
        dec: Angle.Degrees(-32.07294261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222480"},
        {"Hipparcos Number", "HIP 116852"},
        {"Geneva Identification System", "GEN# +1.00222480"},
        {"Smithsonian Astrophysical Observation", "SAO 214707"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.28446570),
        dec: Angle.Degrees(-32.07133043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111880"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.93402602),
        dec: Angle.Degrees(-32.07124923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152978"},
        {"Hipparcos Number", "HIP 83035"},
        {"Smithsonian Astrophysical Observation", "SAO 208243"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.52535483),
        dec: Angle.Degrees(-32.06770910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219705"},
        {"Hipparcos Number", "HIP 115055"},
        {"Smithsonian Astrophysical Observation", "SAO 214438"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.54467024),
        dec: Angle.Degrees(-32.06754093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34104"},
        {"Hipparcos Number", "HIP 24362"},
        {"Smithsonian Astrophysical Observation", "SAO 195665"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.40537666),
        dec: Angle.Degrees(-32.06717827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42487"},
        {"Hipparcos Number", "HIP 29206"},
        {"Smithsonian Astrophysical Observation", "SAO 196538"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39429718),
        dec: Angle.Degrees(-32.06705609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152606"},
        {"Hipparcos Number", "HIP 82834"},
        {"Smithsonian Astrophysical Observation", "SAO 208197"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.90810507),
        dec: Angle.Degrees(-32.06689988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -328.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142148"},
        {"Hipparcos Number", "HIP 77870"},
        {"Smithsonian Astrophysical Observation", "SAO 207096"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.52264043),
        dec: Angle.Degrees(-32.06605307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156152"},
        {"Hipparcos Number", "HIP 84572"},
        {"Geneva Identification System", "GEN# +1.00156152"},
        {"Smithsonian Astrophysical Observation", "SAO 208633"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.32970730),
        dec: Angle.Degrees(-32.06561823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21148"},
        {"Hipparcos Number", "HIP 15817"},
        {"Smithsonian Astrophysical Observation", "SAO 194269"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.94433724),
        dec: Angle.Degrees(-32.06513957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112664"},
        {"Smithsonian Astrophysical Observation", "SAO 214103"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.24438018),
        dec: Angle.Degrees(-32.06469071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16564"},
        {"Hipparcos Number", "HIP 12299"},
        {"Smithsonian Astrophysical Observation", "SAO 193832"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.60022280),
        dec: Angle.Degrees(-32.06397655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210636"},
        {"Hipparcos Number", "HIP 109615"},
        {"Geneva Identification System", "GEN# +1.00210636"},
        {"Smithsonian Astrophysical Observation", "SAO 213640"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.07854635),
        dec: Angle.Degrees(-32.06217365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13471"},
        {"Hipparcos Number", "HIP 10182"},
        {"Geneva Identification System", "GEN# +1.00013471"},
        {"Smithsonian Astrophysical Observation", "SAO 193556"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72699096),
        dec: Angle.Degrees(-32.06192247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209137"},
        {"Hipparcos Number", "HIP 108755"},
        {"Smithsonian Astrophysical Observation", "SAO 213484"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.45481776),
        dec: Angle.Degrees(-32.06065945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191114"},
        {"Hipparcos Number", "HIP 99304"},
        {"Smithsonian Astrophysical Observation", "SAO 211864"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.35769256),
        dec: Angle.Degrees(-32.06045216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108781"},
        {"Hipparcos Number", "HIP 60991"},
        {"Smithsonian Astrophysical Observation", "SAO 203534"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.51454729),
        dec: Angle.Degrees(-32.05960385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87999"},
        {"Hipparcos Number", "HIP 49647"},
        {"Smithsonian Astrophysical Observation", "SAO 201080"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.00789762),
        dec: Angle.Degrees(-32.05935027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33668"},
        {"Hipparcos Number", "HIP 24087"},
        {"Smithsonian Astrophysical Observation", "SAO 195616"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.61595687),
        dec: Angle.Degrees(-32.05922505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29075"},
        {"Hipparcos Number", "HIP 21228"},
        {"Smithsonian Astrophysical Observation", "SAO 195120"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.31144042),
        dec: Angle.Degrees(-32.05826706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117680"},
        {"Hipparcos Number", "HIP 66046"},
        {"Smithsonian Astrophysical Observation", "SAO 204569"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.10264858),
        dec: Angle.Degrees(-32.05784900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139095"},
        {"Hipparcos Number", "HIP 76485"},
        {"Geneva Identification System", "GEN# +1.00139095"},
        {"Smithsonian Astrophysical Observation", "SAO 206810"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.32069586),
        dec: Angle.Degrees(-32.05726510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2936"},
        {"Hipparcos Number", "HIP 2551"},
        {"Geneva Identification System", "GEN# +1.00002936"},
        {"Smithsonian Astrophysical Observation", "SAO 192594"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.10877518),
        dec: Angle.Degrees(-32.05672016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190056"},
        {"Hipparcos Number", "HIP 98842"},
        {"Fundamental Katalog 5th Edition", "FK5 3606"},
        {"Geneva Identification System", "GEN# +1.00190056"},
        {"Smithsonian Astrophysical Observation", "SAO 211782"},
        {"Wilson Evans Batten Catalogue", "WEB 17532"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.08151239),
        dec: Angle.Degrees(-32.05626941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198356"},
        {"Hipparcos Number", "HIP 102901"},
        {"Geneva Identification System", "GEN# +1.00198356"},
        {"Smithsonian Astrophysical Observation", "SAO 212487"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.69647274),
        dec: Angle.Degrees(-32.05445023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162347"},
        {"Hipparcos Number", "HIP 87438"},
        {"Smithsonian Astrophysical Observation", "SAO 209377"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00736486),
        dec: Angle.Degrees(-32.05394541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113431"},
    },
    visualMagnitude: 11.59,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.59290389),
        dec: Angle.Degrees(-32.05262848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142992"},
        {"Hipparcos Number", "HIP 78263"},
        {"Geneva Identification System", "GEN# +1.00142992"},
        {"Smithsonian Astrophysical Observation", "SAO 207189"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.70896160),
        dec: Angle.Degrees(-32.05224055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101455"},
        {"Smithsonian Astrophysical Observation", "SAO 212232"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.42823655),
        dec: Angle.Degrees(-32.05153989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110652"},
        {"Hipparcos Number", "HIP 62118"},
        {"Geneva Identification System", "GEN# +1.00110652"},
        {"Smithsonian Astrophysical Observation", "SAO 203754"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.96805713),
        dec: Angle.Degrees(-32.05091345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124377"},
        {"Hipparcos Number", "HIP 69524"},
        {"Smithsonian Astrophysical Observation", "SAO 205329"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.48013118),
        dec: Angle.Degrees(-32.04862046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58216"},
        {"Hipparcos Number", "HIP 35822"},
        {"Celescope Catalog", "CEL 1820"},
        {"Geneva Identification System", "GEN# +5.11400011"},
        {"Smithsonian Astrophysical Observation", "SAO 197927"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.81401933),
        dec: Angle.Degrees(-32.04671729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13192"},
        {"Hipparcos Number", "HIP 9957"},
        {"Smithsonian Astrophysical Observation", "SAO 193529"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.04472502),
        dec: Angle.Degrees(-32.04638043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88441"},
        {"Hipparcos Number", "HIP 49897"},
        {"Smithsonian Astrophysical Observation", "SAO 201141"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.81619176),
        dec: Angle.Degrees(-32.04617278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58063"},
        {"Hipparcos Number", "HIP 35761"},
        {"Celescope Catalog", "CEL 1812"},
        {"Geneva Identification System", "GEN# +5.11400005"},
        {"Smithsonian Astrophysical Observation", "SAO 197914"},
        {"Wilson Evans Batten Catalogue", "WEB 7126"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.64856824),
        dec: Angle.Degrees(-32.04602490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15799"},
        {"Hipparcos Number", "HIP 11742"},
        {"Smithsonian Astrophysical Observation", "SAO 193751"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.88444364),
        dec: Angle.Degrees(-32.04539653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1115"},
        {"Hipparcos Number", "HIP 1236"},
        {"Smithsonian Astrophysical Observation", "SAO 192424"},
        {"Wilson Evans Batten Catalogue", "WEB 222"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.84266286),
        dec: Angle.Degrees(-32.04526865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111738"},
        {"Hipparcos Number", "HIP 62765"},
        {"Smithsonian Astrophysical Observation", "SAO 203874"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.92882395),
        dec: Angle.Degrees(-32.04516022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70639"},
        {"Hipparcos Number", "HIP 40985"},
        {"Celescope Catalog", "CEL 2414"},
        {"Geneva Identification System", "GEN# +1.00070639"},
        {"Smithsonian Astrophysical Observation", "SAO 199130"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.46591299),
        dec: Angle.Degrees(-32.04458706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155910"},
        {"Hipparcos Number", "HIP 84437"},
        {"Geneva Identification System", "GEN# +1.00155910J"},
        {"Smithsonian Astrophysical Observation", "SAO 208602"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.94206027),
        dec: Angle.Degrees(-32.04440818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36171"},
        {"Hipparcos Number", "HIP 25619"},
        {"Smithsonian Astrophysical Observation", "SAO 195886"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.09887787),
        dec: Angle.Degrees(-32.04397145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26921"},
        {"Hipparcos Number", "HIP 19743"},
        {"Geneva Identification System", "GEN# +1.00026921"},
        {"Smithsonian Astrophysical Observation", "SAO 194848"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.49501544),
        dec: Angle.Degrees(-32.04203055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56621"},
        {"Hipparcos Number", "HIP 35188"},
        {"Smithsonian Astrophysical Observation", "SAO 197777"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.08079341),
        dec: Angle.Degrees(-32.04174658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10395"},
        {"Geneva Identification System", "GEN# -0.03200828"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.47126642),
        dec: Angle.Degrees(-32.03994906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 759.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -534.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9084"},
        {"Hipparcos Number", "HIP 6905"},
        {"Geneva Identification System", "GEN# +1.00009084"},
        {"Smithsonian Astrophysical Observation", "SAO 193138"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.23009692),
        dec: Angle.Degrees(-32.03967390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52091"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.65908470),
        dec: Angle.Degrees(-31.75538431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25095"},
        {"Hipparcos Number", "HIP 18541"},
        {"Smithsonian Astrophysical Observation", "SAO 194651"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.49166889),
        dec: Angle.Degrees(-32.03927603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78522"},
        {"Hipparcos Number", "HIP 44803"},
        {"Geneva Identification System", "GEN# +1.00078522J"},
        {"Smithsonian Astrophysical Observation", "SAO 200007"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.96116373),
        dec: Angle.Degrees(-32.03801293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199185"},
        {"Hipparcos Number", "HIP 103369"},
        {"Smithsonian Astrophysical Observation", "SAO 212561"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.14161668),
        dec: Angle.Degrees(-32.03672452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3560"},
        {"Hipparcos Number", "HIP 3012"},
        {"Geneva Identification System", "GEN# +1.00003560"},
        {"Smithsonian Astrophysical Observation", "SAO 192647"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.58435619),
        dec: Angle.Degrees(-32.03493886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172057"},
        {"Hipparcos Number", "HIP 91475"},
        {"Geneva Identification System", "GEN# +1.00172057"},
        {"Smithsonian Astrophysical Observation", "SAO 210410"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85468713),
        dec: Angle.Degrees(-32.03427116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94942"},
        {"Hipparcos Number", "HIP 53543"},
        {"Geneva Identification System", "GEN# +1.00094942"},
        {"Smithsonian Astrophysical Observation", "SAO 201934"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29785834),
        dec: Angle.Degrees(-32.03347555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12283"},
        {"Hipparcos Number", "HIP 9329"},
        {"Smithsonian Astrophysical Observation", "SAO 193439"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.94707756),
        dec: Angle.Degrees(-32.03326341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138515"},
        {"Hipparcos Number", "HIP 76190"},
        {"Smithsonian Astrophysical Observation", "SAO 206759"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.42793216),
        dec: Angle.Degrees(-32.03241756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162585"},
        {"Hipparcos Number", "HIP 87555"},
        {"Geneva Identification System", "GEN# +1.00162585"},
        {"Smithsonian Astrophysical Observation", "SAO 209410"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.30201823),
        dec: Angle.Degrees(-32.03234198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6062"},
        {"Smithsonian Astrophysical Observation", "SAO 193033"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.45007763),
        dec: Angle.Degrees(-32.03162366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46547"},
        {"Hipparcos Number", "HIP 31190"},
        {"Celescope Catalog", "CEL 1296"},
        {"Geneva Identification System", "GEN# +1.00046547A"},
        {"Geneva Identification System 2", "GEN# +1.00046547J"},
        {"Smithsonian Astrophysical Observation", "SAO 196919"},
        {"Wilson Evans Batten Catalogue", "WEB 6230"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.16241008),
        dec: Angle.Degrees(-32.03045378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57759"},
        {"Hipparcos Number", "HIP 35641"},
        {"Geneva Identification System", "GEN# +5.11400031"},
        {"Smithsonian Astrophysical Observation", "SAO 197882"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.31595369),
        dec: Angle.Degrees(-32.02668453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107062"},
        {"Hipparcos Number", "HIP 60032"},
        {"Smithsonian Astrophysical Observation", "SAO 203333"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.67254941),
        dec: Angle.Degrees(-32.02593351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126235"},
        {"Hipparcos Number", "HIP 70495"},
        {"Smithsonian Astrophysical Observation", "SAO 205536"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.28593107),
        dec: Angle.Degrees(-32.02572623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9152"},
        {"Hipparcos Number", "HIP 6953"},
        {"Smithsonian Astrophysical Observation", "SAO 193143"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.37927890),
        dec: Angle.Degrees(-32.02400787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201263"},
        {"Hipparcos Number", "HIP 104439"},
        {"Smithsonian Astrophysical Observation", "SAO 212754"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.34026417),
        dec: Angle.Degrees(-32.02354463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203087"},
        {"Hipparcos Number", "HIP 105402"},
        {"Smithsonian Astrophysical Observation", "SAO 212933"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.24342514),
        dec: Angle.Degrees(-32.02340345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104360"},
        {"Hipparcos Number", "HIP 58597"},
        {"Smithsonian Astrophysical Observation", "SAO 203035"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.23950522),
        dec: Angle.Degrees(-32.02300213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82913"},
        {"Hipparcos Number", "HIP 46942"},
        {"Smithsonian Astrophysical Observation", "SAO 200505"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.50302414),
        dec: Angle.Degrees(-32.02282139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53114"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.99599209),
        dec: Angle.Degrees(-32.02237614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74710"},
        {"Hipparcos Number", "HIP 42893"},
        {"Smithsonian Astrophysical Observation", "SAO 199567"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.11647718),
        dec: Angle.Degrees(-32.02097250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127341"},
        {"Hipparcos Number", "HIP 71033"},
        {"Smithsonian Astrophysical Observation", "SAO 205644"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.91686750),
        dec: Angle.Degrees(-32.02055233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42014"},
    },
    visualMagnitude: 10.00,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.45930448),
        dec: Angle.Degrees(-32.01989213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114183"},
        {"Hipparcos Number", "HIP 64189"},
        {"Smithsonian Astrophysical Observation", "SAO 204174"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.33167868),
        dec: Angle.Degrees(-32.01980879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217237"},
        {"Hipparcos Number", "HIP 113539"},
        {"Smithsonian Astrophysical Observation", "SAO 214224"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.92863460),
        dec: Angle.Degrees(-32.01963114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187198"},
        {"Hipparcos Number", "HIP 97577"},
        {"Smithsonian Astrophysical Observation", "SAO 211587"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.49696107),
        dec: Angle.Degrees(-32.01881261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46688"},
        {"Smithsonian Astrophysical Observation", "SAO 200450"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.77220998),
        dec: Angle.Degrees(-32.01761070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140654"},
        {"Hipparcos Number", "HIP 77217"},
        {"Smithsonian Astrophysical Observation", "SAO 206949"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.48143862),
        dec: Angle.Degrees(-32.01714622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50518"},
        {"Hipparcos Number", "HIP 32985"},
        {"Geneva Identification System", "GEN# +1.00050518"},
        {"Smithsonian Astrophysical Observation", "SAO 197298"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.08248881),
        dec: Angle.Degrees(-32.01446487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100892"},
        {"Hipparcos Number", "HIP 56616"},
        {"Smithsonian Astrophysical Observation", "SAO 202621"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.13996111),
        dec: Angle.Degrees(-32.01383054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131095"},
        {"Hipparcos Number", "HIP 72767"},
        {"Smithsonian Astrophysical Observation", "SAO 206031"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12920070),
        dec: Angle.Degrees(-32.00982087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67578"},
        {"Hipparcos Number", "HIP 39748"},
        {"Smithsonian Astrophysical Observation", "SAO 198819"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85604476),
        dec: Angle.Degrees(-32.00913185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57218"},
        {"Hipparcos Number", "HIP 35432"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.72300090),
        dec: Angle.Degrees(-32.00847902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53676"},
        {"Hipparcos Number", "HIP 34127"},
        {"Celescope Catalog", "CEL 1557"},
        {"Smithsonian Astrophysical Observation", "SAO 197540"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.14882867),
        dec: Angle.Degrees(-32.00805277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7866"},
        {"Hipparcos Number", "HIP 6067"},
        {"Smithsonian Astrophysical Observation", "SAO 193034"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.46606199),
        dec: Angle.Degrees(-32.00800270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97927"},
        {"Smithsonian Astrophysical Observation", "SAO 211638"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.52392292),
        dec: Angle.Degrees(-32.00307110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31377"},
        {"Hipparcos Number", "HIP 22781"},
        {"Smithsonian Astrophysical Observation", "SAO 195385"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51194371),
        dec: Angle.Degrees(-32.00207112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
