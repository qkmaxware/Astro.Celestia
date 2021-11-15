using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_90() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215927"},
        {"Hipparcos Number", "HIP 112589"},
        {"Smithsonian Astrophysical Observation", "SAO 72731"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.04506888),
        dec: Angle.Degrees(+33.03068979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6549"},
        {"Henry Draper", "HD 66299"},
        {"Hipparcos Number", "HIP 39480"},
        {"Geneva Identification System", "GEN# +1.00066299"},
        {"Smithsonian Astrophysical Observation", "SAO 60538"},
        {"Wilson Evans Batten Catalogue", "WEB 7718"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.03497213),
        dec: Angle.Degrees(+33.03073613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48497"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.35133781),
        dec: Angle.Degrees(+33.03399574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114116"},
        {"Smithsonian Astrophysical Observation", "SAO 72999"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66790292),
        dec: Angle.Degrees(+33.03600831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49170"},
        {"Smithsonian Astrophysical Observation", "SAO 61819"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.52331405),
        dec: Angle.Degrees(+33.03670764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116498"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.11073835),
        dec: Angle.Degrees(+33.03750980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177594"},
        {"Hipparcos Number", "HIP 93633"},
        {"Geneva Identification System", "GEN# +1.00177594"},
        {"Smithsonian Astrophysical Observation", "SAO 67763"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.00877946),
        dec: Angle.Degrees(+33.03769084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3062"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.71351328),
        dec: Angle.Degrees(+33.03845650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 308.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57857"},
        {"Hipparcos Number", "HIP 35934"},
        {"Smithsonian Astrophysical Observation", "SAO 60051"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.11687256),
        dec: Angle.Degrees(+33.03920538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206539"},
        {"Hipparcos Number", "HIP 107121"},
        {"Smithsonian Astrophysical Observation", "SAO 71610"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.49142527),
        dec: Angle.Degrees(+33.03999479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69565"},
        {"Geneva Identification System", "GEN# +0.03302431"},
        {"Smithsonian Astrophysical Observation", "SAO 64015"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58968599),
        dec: Angle.Degrees(+33.04047235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90510"},
        {"Hipparcos Number", "HIP 51205"},
        {"Smithsonian Astrophysical Observation", "SAO 62052"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.88813125),
        dec: Angle.Degrees(+33.04151326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94086"},
        {"Hipparcos Number", "HIP 53120"},
        {"Smithsonian Astrophysical Observation", "SAO 62287"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.00972649),
        dec: Angle.Degrees(+33.04407883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168549"},
        {"Hipparcos Number", "HIP 89740"},
        {"Smithsonian Astrophysical Observation", "SAO 66844"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.71448256),
        dec: Angle.Degrees(+33.04541485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109543"},
        {"Hipparcos Number", "HIP 61433"},
        {"Geneva Identification System", "GEN# +1.00109543"},
        {"Smithsonian Astrophysical Observation", "SAO 63083"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.82670322),
        dec: Angle.Degrees(+33.04765950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219826"},
        {"Hipparcos Number", "HIP 115090"},
        {"Geneva Identification System", "GEN# +1.00219826"},
        {"Smithsonian Astrophysical Observation", "SAO 73160"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.66021188),
        dec: Angle.Degrees(+33.05165143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80040"},
        {"Smithsonian Astrophysical Observation", "SAO 65234"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.07096500),
        dec: Angle.Degrees(+33.05329466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208749"},
        {"Hipparcos Number", "HIP 108403"},
        {"Smithsonian Astrophysical Observation", "SAO 71879"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.41543161),
        dec: Angle.Degrees(+33.05469067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19359"},
        {"Hipparcos Number", "HIP 14552"},
        {"Smithsonian Astrophysical Observation", "SAO 56182"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96252817),
        dec: Angle.Degrees(+33.05503815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41498"},
        {"Hipparcos Number", "HIP 28994"},
        {"Smithsonian Astrophysical Observation", "SAO 58757"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.77151175),
        dec: Angle.Degrees(+33.05606417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281640"},
        {"Hipparcos Number", "HIP 19444"},
        {"Smithsonian Astrophysical Observation", "SAO 57028"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.46049210),
        dec: Angle.Degrees(+33.05644872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43674",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Stribor"},
        {"Henry Draper", "HD 75898"},
        {"Hipparcos Number", "HIP 43674"},
        {"Geneva Identification System", "GEN# +1.00075898"},
        {"Smithsonian Astrophysical Observation", "SAO 61116"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46196515),
        dec: Angle.Degrees(+33.05688020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51614"},
        {"Hipparcos Number", "HIP 33661"},
        {"Geneva Identification System", "GEN# +1.00051614"},
        {"Smithsonian Astrophysical Observation", "SAO 59668"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.89184653),
        dec: Angle.Degrees(+33.05790697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223028"},
        {"Hipparcos Number", "HIP 117208"},
        {"Smithsonian Astrophysical Observation", "SAO 73493"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49004402),
        dec: Angle.Degrees(+33.05839077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81488"},
        {"Hipparcos Number", "HIP 46341"},
        {"Geneva Identification System", "GEN# +1.00081488"},
        {"Smithsonian Astrophysical Observation", "SAO 61495"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.71307690),
        dec: Angle.Degrees(+33.05861233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134494"},
        {"Hipparcos Number", "HIP 74158"},
        {"Smithsonian Astrophysical Observation", "SAO 64523"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.29118394),
        dec: Angle.Degrees(+33.06054282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83766"},
        {"Hipparcos Number", "HIP 47541"},
        {"Smithsonian Astrophysical Observation", "SAO 61632"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.39200122),
        dec: Angle.Degrees(+33.06092830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106760"},
        {"Hipparcos Number", "HIP 59856"},
        {"Fundamental Katalog 5th Edition", "FK5 2983"},
        {"Geneva Identification System", "GEN# +1.00106760"},
        {"Smithsonian Astrophysical Observation", "SAO 62928"},
        {"Wilson Evans Batten Catalogue", "WEB 10635"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.12572840),
        dec: Angle.Degrees(+33.06179861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182379"},
        {"Hipparcos Number", "HIP 95282"},
        {"Geneva Identification System", "GEN# +1.00182379"},
        {"Smithsonian Astrophysical Observation", "SAO 68232"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76922829),
        dec: Angle.Degrees(+33.06231668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219513"},
        {"Hipparcos Number", "HIP 114862"},
        {"Geneva Identification System", "GEN# +1.00219513"},
        {"Smithsonian Astrophysical Observation", "SAO 73121"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.98982451),
        dec: Angle.Degrees(+33.06655449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190001"},
        {"Hipparcos Number", "HIP 98606"},
        {"Fundamental Katalog 5th Edition", "FK5 5765"},
        {"Geneva Identification System", "GEN# +1.00190001"},
        {"Smithsonian Astrophysical Observation", "SAO 69280"},
        {"Wilson Evans Batten Catalogue", "WEB 17437"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43097225),
        dec: Angle.Degrees(+33.06695103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1763"},
        {"Fundamental Katalog 5th Edition", "FK5 4039"},
        {"Smithsonian Astrophysical Observation", "SAO 53843"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.58210255),
        dec: Angle.Degrees(+33.06837536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104726"},
        {"Hipparcos Number", "HIP 58796"},
        {"Smithsonian Astrophysical Observation", "SAO 62818"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.89814904),
        dec: Angle.Degrees(+33.06921012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83111"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.74859029),
        dec: Angle.Degrees(+33.07114965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188876"},
        {"Hipparcos Number", "HIP 98093"},
        {"Celescope Catalog", "CEL 4877"},
        {"Geneva Identification System", "GEN# +1.00188876"},
        {"Smithsonian Astrophysical Observation", "SAO 69103"},
        {"Wilson Evans Batten Catalogue", "WEB 17287"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.03234905),
        dec: Angle.Degrees(+33.07458873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332236"},
        {"Hipparcos Number", "HIP 100756"},
        {"Smithsonian Astrophysical Observation", "SAO 70000"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.42101977),
        dec: Angle.Degrees(+33.07804795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20891"},
        {"Hipparcos Number", "HIP 15767"},
        {"Geneva Identification System", "GEN# +1.00020891"},
        {"Smithsonian Astrophysical Observation", "SAO 56399"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.80027132),
        dec: Angle.Degrees(+33.07852561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134772"},
        {"Hipparcos Number", "HIP 74265"},
        {"Geneva Identification System", "GEN# +1.00134772"},
        {"Smithsonian Astrophysical Observation", "SAO 64534"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.66204343),
        dec: Angle.Degrees(+33.07888831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186177"},
        {"Hipparcos Number", "HIP 96885"},
        {"Geneva Identification System", "GEN# +1.00186177"},
        {"Smithsonian Astrophysical Observation", "SAO 68705"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.41206465),
        dec: Angle.Degrees(+33.08297165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110871"},
        {"Hipparcos Number", "HIP 62199"},
        {"Geneva Identification System", "GEN# +1.00110871"},
        {"Smithsonian Astrophysical Observation", "SAO 63176"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.22556305),
        dec: Angle.Degrees(+33.08306860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84752"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.86288314),
        dec: Angle.Degrees(+33.08610678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105632"},
        {"Hipparcos Number", "HIP 59284"},
        {"Geneva Identification System", "GEN# +1.00105632"},
        {"Smithsonian Astrophysical Observation", "SAO 62868"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.41828275),
        dec: Angle.Degrees(+33.08720419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281537"},
        {"Hipparcos Number", "HIP 19240"},
        {"Smithsonian Astrophysical Observation", "SAO 56981"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.85209561),
        dec: Angle.Degrees(+33.08797833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127599"},
        {"Hipparcos Number", "HIP 71012"},
        {"Smithsonian Astrophysical Observation", "SAO 64197"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.84799134),
        dec: Angle.Degrees(+33.08856311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107634"},
        {"Hipparcos Number", "HIP 60311"},
        {"Geneva Identification System", "GEN# +1.00107634"},
        {"Smithsonian Astrophysical Observation", "SAO 62969"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.50600881),
        dec: Angle.Degrees(+33.09068207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70467"},
        {"Smithsonian Astrophysical Observation", "SAO 64130"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20214576),
        dec: Angle.Degrees(+33.09107715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23848"},
        {"Hipparcos Number", "HIP 17886"},
        {"Geneva Identification System", "GEN# +1.00023848"},
        {"Renson", "Renson 6090"},
        {"Smithsonian Astrophysical Observation", "SAO 56727"},
        {"Wilson Evans Batten Catalogue", "WEB 3438"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.38626020),
        dec: Angle.Degrees(+33.09138142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49000"},
        {"Geneva Identification System", "GEN# +0.03301931"},
        {"Wilson Evans Batten Catalogue", "WEB 9092"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.95203844),
        dec: Angle.Degrees(+33.09179591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56124"},
        {"Hipparcos Number", "HIP 35265"},
        {"Fundamental Katalog 5th Edition", "FK5 4656"},
        {"Geneva Identification System", "GEN# +1.00056124"},
        {"Smithsonian Astrophysical Observation", "SAO 59945"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.28988811),
        dec: Angle.Degrees(+33.09247534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2637"},
        {"Smithsonian Astrophysical Observation", "SAO 53982"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.36443349),
        dec: Angle.Degrees(+33.09330705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55219",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alula Borealis"},
        {"Aitken", "ADS 8123 A"},
        {"Henry Draper", "HD 98262"},
        {"Hipparcos Number", "HIP 55219"},
        {"Fundamental Katalog 5th Edition", "FK5 425"},
        {"Geneva Identification System", "GEN# +1.00098262J"},
        {"Smithsonian Astrophysical Observation", "SAO 62486"},
        {"Wilson Evans Batten Catalogue", "WEB 9950"},
    },
    visualMagnitude: 3.49,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.61981385),
        dec: Angle.Degrees(+33.09423881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90533"},
        {"Smithsonian Astrophysical Observation", "SAO 67004"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.09356309),
        dec: Angle.Degrees(+33.09652469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46753"},
        {"Smithsonian Astrophysical Observation", "SAO 61544"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.93858837),
        dec: Angle.Degrees(+33.09658347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252349"},
        {"Hipparcos Number", "HIP 29230"},
        {"Smithsonian Astrophysical Observation", "SAO 58810"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.44441303),
        dec: Angle.Degrees(+33.09732067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195649"},
        {"Hipparcos Number", "HIP 101258"},
        {"Smithsonian Astrophysical Observation", "SAO 70147"},
        {"Wilson Evans Batten Catalogue", "WEB 18292"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.87468517),
        dec: Angle.Degrees(+33.09834866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10449 A"},
        {"Henry Draper", "HD 156633"},
        {"Hipparcos Number", "HIP 84573"},
        {"Smithsonian Astrophysical Observation", "SAO 65913"},
        {"Wilson Evans Batten Catalogue", "WEB 14281"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33154372),
        dec: Angle.Degrees(+33.10011419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38032"},
        {"Hipparcos Number", "HIP 27051"},
        {"Renson", "Renson 10237"},
        {"Smithsonian Astrophysical Observation", "SAO 58379"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.04902130),
        dec: Angle.Degrees(+33.10019689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45431"},
        {"Smithsonian Astrophysical Observation", "SAO 61367"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.88824750),
        dec: Angle.Degrees(+33.10178446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150813"},
        {"Hipparcos Number", "HIP 81763"},
        {"Geneva Identification System", "GEN# +1.00150813"},
        {"Smithsonian Astrophysical Observation", "SAO 65492"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.50888436),
        dec: Angle.Degrees(+33.10198584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197622"},
        {"Hipparcos Number", "HIP 102315"},
        {"Smithsonian Astrophysical Observation", "SAO 70431"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.96455387),
        dec: Angle.Degrees(+33.10206493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4416"},
        {"Smithsonian Astrophysical Observation", "SAO 54279"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.14559352),
        dec: Angle.Degrees(+33.10614489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99053"},
        {"Hipparcos Number", "HIP 55663"},
        {"Smithsonian Astrophysical Observation", "SAO 62536"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.06930953),
        dec: Angle.Degrees(+33.10625265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48950"},
        {"Hipparcos Number", "HIP 32546"},
        {"Smithsonian Astrophysical Observation", "SAO 59484"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86685325),
        dec: Angle.Degrees(+33.10885944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228710"},
        {"Hipparcos Number", "HIP 99963"},
        {"Smithsonian Astrophysical Observation", "SAO 69746"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.22405171),
        dec: Angle.Degrees(+33.10928347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24322"},
        {"Hipparcos Number", "HIP 18189"},
        {"Geneva Identification System", "GEN# +1.00024322"},
        {"Smithsonian Astrophysical Observation", "SAO 56792"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.37455398),
        dec: Angle.Degrees(+33.11059560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54717"},
        {"Hipparcos Number", "HIP 34714"},
        {"Geneva Identification System", "GEN# +1.00054717"},
        {"Smithsonian Astrophysical Observation", "SAO 59864"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83150360),
        dec: Angle.Degrees(+33.11188264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207058"},
        {"Hipparcos Number", "HIP 107436"},
        {"Smithsonian Astrophysical Observation", "SAO 71673"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.40162388),
        dec: Angle.Degrees(+33.11431414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7578"},
        {"Hipparcos Number", "HIP 5936"},
        {"Geneva Identification System", "GEN# +1.00007578"},
        {"Smithsonian Astrophysical Observation", "SAO 54567"},
        {"Wilson Evans Batten Catalogue", "WEB 1349"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.07875996),
        dec: Angle.Degrees(+33.11480731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83512"},
        {"Smithsonian Astrophysical Observation", "SAO 65768"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.00832660),
        dec: Angle.Degrees(+33.11717480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176466"},
        {"Hipparcos Number", "HIP 93201"},
        {"Smithsonian Astrophysical Observation", "SAO 67667"},
        {"Wilson Evans Batten Catalogue", "WEB 16155"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.76104878),
        dec: Angle.Degrees(+33.11723337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18425"},
        {"Hipparcos Number", "HIP 13882"},
        {"Smithsonian Astrophysical Observation", "SAO 56050"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69665058),
        dec: Angle.Degrees(+33.11747253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9616"},
        {"Hipparcos Number", "HIP 7370"},
        {"Celescope Catalog", "CEL 146"},
        {"Geneva Identification System", "GEN# +1.00009616"},
        {"Smithsonian Astrophysical Observation", "SAO 54801"},
        {"Wilson Evans Batten Catalogue", "WEB 1583"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.74216541),
        dec: Angle.Degrees(+33.11818983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57857"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.98520911),
        dec: Angle.Degrees(+33.11991836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75485"},
        {"Smithsonian Astrophysical Observation", "SAO 64692"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.30279940),
        dec: Angle.Degrees(+33.12129952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130189"},
        {"Hipparcos Number", "HIP 72184"},
        {"Smithsonian Astrophysical Observation", "SAO 64313"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.46695166),
        dec: Angle.Degrees(+33.12228830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205967"},
        {"Hipparcos Number", "HIP 106821"},
        {"Smithsonian Astrophysical Observation", "SAO 71541"},
        {"Wilson Evans Batten Catalogue", "WEB 19311"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.51895961),
        dec: Angle.Degrees(+33.12444217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99504"},
        {"Hipparcos Number", "HIP 55877"},
        {"Geneva Identification System", "GEN# +1.00099504"},
        {"Smithsonian Astrophysical Observation", "SAO 62559"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80065506),
        dec: Angle.Degrees(+33.12460031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3865 AB"},
        {"Henry Draper", "HD 242211"},
        {"Hipparcos Number", "HIP 24667"},
        {"Celescope Catalog", "CEL 590"},
        {"Geneva Identification System", "GEN# +1.00242211J"},
        {"Smithsonian Astrophysical Observation", "SAO 57842"},
        {"Wilson Evans Batten Catalogue", "WEB 4774"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.38481486),
        dec: Angle.Degrees(+33.12462087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88328"},
        {"Hipparcos Number", "HIP 49944"},
        {"Smithsonian Astrophysical Observation", "SAO 61922"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.95613196),
        dec: Angle.Degrees(+33.12480982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257316"},
        {"Hipparcos Number", "HIP 30748"},
        {"Smithsonian Astrophysical Observation", "SAO 59097"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91817554),
        dec: Angle.Degrees(+33.12552509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279133"},
        {"Hipparcos Number", "HIP 18132"},
        {"Geneva Identification System", "GEN# +1.00279133"},
        {"Smithsonian Astrophysical Observation", "SAO 56774"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.15401600),
        dec: Angle.Degrees(+33.12665862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94740",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12263 A"},
        {"Henry Draper", "HD 180844"},
        {"Hipparcos Number", "HIP 94740"},
        {"Celescope Catalog", "CEL 4730"},
        {"Geneva Identification System", "GEN# +1.00180844"},
        {"Smithsonian Astrophysical Observation", "SAO 68071"},
        {"Wilson Evans Batten Catalogue", "WEB 16530"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.18122025),
        dec: Angle.Degrees(+33.12757931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7012"},
        {"Smithsonian Astrophysical Observation", "SAO 54743"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.57196196),
        dec: Angle.Degrees(+33.12893918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 613"},
        {"Hipparcos Number", "HIP 858"},
        {"Geneva Identification System", "GEN# +1.00000613"},
        {"Smithsonian Astrophysical Observation", "SAO 53694"},
        {"Wilson Evans Batten Catalogue", "WEB 144"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.63506952),
        dec: Angle.Degrees(+33.13088570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188541"},
        {"Hipparcos Number", "HIP 97957"},
        {"Smithsonian Astrophysical Observation", "SAO 69059"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61998805),
        dec: Angle.Degrees(+33.13140149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100372"},
        {"Hipparcos Number", "HIP 56359"},
        {"Geneva Identification System", "GEN# +1.00100372"},
        {"Smithsonian Astrophysical Observation", "SAO 62602"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.30032226),
        dec: Angle.Degrees(+33.13293703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201858"},
        {"Hipparcos Number", "HIP 104594"},
        {"Geneva Identification System", "GEN# +1.00201858"},
        {"Smithsonian Astrophysical Observation", "SAO 71034"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.81581483),
        dec: Angle.Degrees(+33.13350533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62042"},
        {"Hipparcos Number", "HIP 37640"},
        {"Smithsonian Astrophysical Observation", "SAO 60299"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.86112004),
        dec: Angle.Degrees(+33.13396498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29495"},
        {"Hipparcos Number", "HIP 21742"},
        {"Geneva Identification System", "GEN# +1.00029495"},
        {"Smithsonian Astrophysical Observation", "SAO 57367"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.02829236),
        dec: Angle.Degrees(+33.13421952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51772"},
        {"Smithsonian Astrophysical Observation", "SAO 62132"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.69388895),
        dec: Angle.Degrees(+33.13545907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8958 AB"},
        {"Henry Draper", "HD 118179"},
        {"Hipparcos Number", "HIP 66239"},
        {"Smithsonian Astrophysical Observation", "SAO 63619"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.64441322),
        dec: Angle.Degrees(+33.13575984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40439"},
        {"Hipparcos Number", "HIP 28429"},
        {"Fundamental Katalog 5th Edition", "FK5 1162"},
        {"Geneva Identification System", "GEN# +1.00040439"},
        {"Smithsonian Astrophysical Observation", "SAO 58645"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.06009878),
        dec: Angle.Degrees(+33.13693491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74737"},
        {"Hipparcos Number", "HIP 43117"},
        {"Smithsonian Astrophysical Observation", "SAO 61048"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70794594),
        dec: Angle.Degrees(+33.14449664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73249"},
        {"Hipparcos Number", "HIP 42385"},
        {"Geneva Identification System", "GEN# +1.00073249"},
        {"Smithsonian Astrophysical Observation", "SAO 60943"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.64092850),
        dec: Angle.Degrees(+33.14667535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281460"},
        {"Hipparcos Number", "HIP 18786"},
        {"Smithsonian Astrophysical Observation", "SAO 56904"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.37628129),
        dec: Angle.Degrees(+33.14776864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18882"},
        {"Hipparcos Number", "HIP 14213"},
        {"Smithsonian Astrophysical Observation", "SAO 56112"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.81537502),
        dec: Angle.Degrees(+33.14807272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64325"},
        {"Hipparcos Number", "HIP 38637"},
        {"Smithsonian Astrophysical Observation", "SAO 60431"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.66944662),
        dec: Angle.Degrees(+33.14908986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67314"},
        {"Smithsonian Astrophysical Observation", "SAO 63749"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.96941559),
        dec: Angle.Degrees(+33.14925940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92610"},
        {"Hipparcos Number", "HIP 52359"},
        {"Fundamental Katalog 5th Edition", "FK5 4952"},
        {"Geneva Identification System", "GEN# +1.00092610"},
        {"Smithsonian Astrophysical Observation", "SAO 62205"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.51856927),
        dec: Angle.Degrees(+33.14993804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170049"},
        {"Hipparcos Number", "HIP 90343"},
        {"Smithsonian Astrophysical Observation", "SAO 66966"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.49541127),
        dec: Angle.Degrees(+33.14999848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94737",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12263 BC"},
        {"Hipparcos Number", "HIP 94737"},
    },
    visualMagnitude: 12.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.17339423),
        dec: Angle.Degrees(+33.15066707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144514"},
        {"Hipparcos Number", "HIP 78789"},
        {"Smithsonian Astrophysical Observation", "SAO 65062"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.26775315),
        dec: Angle.Degrees(+33.15238892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48003"},
        {"Smithsonian Astrophysical Observation", "SAO 61683"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.77558974),
        dec: Angle.Degrees(+33.15390492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80313"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94754414),
        dec: Angle.Degrees(+33.15429281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7228"},
        {"Hipparcos Number", "HIP 5682"},
        {"Geneva Identification System", "GEN# +1.00007228"},
        {"Smithsonian Astrophysical Observation", "SAO 54518"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.25991617),
        dec: Angle.Degrees(+33.15513449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228832"},
        {"Hipparcos Number", "HIP 100112"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.63322366),
        dec: Angle.Degrees(+33.15521051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142092"},
        {"Hipparcos Number", "HIP 77670"},
        {"Smithsonian Astrophysical Observation", "SAO 64950"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.86014475),
        dec: Angle.Degrees(+33.15767375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248573"},
        {"Hipparcos Number", "HIP 27806"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.26177751),
        dec: Angle.Degrees(+33.15768675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73375"},
        {"Smithsonian Astrophysical Observation", "SAO 64448"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.91713872),
        dec: Angle.Degrees(+33.15893763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41362"},
        {"Smithsonian Astrophysical Observation", "SAO 60810"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.57408459),
        dec: Angle.Degrees(+33.15996203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42653"},
        {"Hipparcos Number", "HIP 29534"},
        {"Smithsonian Astrophysical Observation", "SAO 58865"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.33125750),
        dec: Angle.Degrees(+33.16089167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1406 AB"},
        {"Henry Draper", "HD 10828"},
        {"Hipparcos Number", "HIP 8283"},
        {"Smithsonian Astrophysical Observation", "SAO 54973"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.68361275),
        dec: Angle.Degrees(+33.16263430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23015",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hassaleh"},
        {"Henry Draper", "HD 31398"},
        {"Hipparcos Number", "HIP 23015"},
        {"Fundamental Katalog 5th Edition", "FK5 181"},
        {"Geneva Identification System", "GEN# +1.00031398"},
        {"Smithsonian Astrophysical Observation", "SAO 57522"},
        {"Wilson Evans Batten Catalogue", "WEB 4467"},
    },
    visualMagnitude: 2.69,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24840098),
        dec: Angle.Degrees(+33.16613537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117389"},
        {"Hipparcos Number", "HIP 65812"},
        {"Geneva Identification System", "GEN# +1.00117389"},
        {"Smithsonian Astrophysical Observation", "SAO 63565"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.36554573),
        dec: Angle.Degrees(+33.16683342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8374 A"},
        {"Henry Draper", "HD 104075"},
        {"Hipparcos Number", "HIP 58460"},
        {"Geneva Identification System", "GEN# +1.00104075J"},
        {"Smithsonian Astrophysical Observation", "SAO 62784"},
        {"Wilson Evans Batten Catalogue", "WEB 10444"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.82307392),
        dec: Angle.Degrees(+33.16702114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209273"},
        {"Hipparcos Number", "HIP 108715"},
        {"Smithsonian Astrophysical Observation", "SAO 71950"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.33432865),
        dec: Angle.Degrees(+33.16963726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216005"},
        {"Hipparcos Number", "HIP 112633"},
        {"Smithsonian Astrophysical Observation", "SAO 72744"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.18012938),
        dec: Angle.Degrees(+33.17172252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15672 A"},
        {"Henry Draper", "HD 210354"},
        {"Hipparcos Number", "HIP 109352"},
        {"Fundamental Katalog 5th Edition", "FK5 833"},
        {"Geneva Identification System", "GEN# +1.00210354"},
        {"Smithsonian Astrophysical Observation", "SAO 72064"},
        {"Wilson Evans Batten Catalogue", "WEB 19649"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.30698173),
        dec: Angle.Degrees(+33.17249760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17469"},
        {"Hipparcos Number", "HIP 13148"},
        {"Smithsonian Astrophysical Observation", "SAO 55905"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.27454471),
        dec: Angle.Degrees(+33.17588611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57589"},
        {"Hipparcos Number", "HIP 35825"},
        {"Geneva Identification System", "GEN# +1.00057589"},
        {"Smithsonian Astrophysical Observation", "SAO 60034"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.82565712),
        dec: Angle.Degrees(+33.17598871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210459"},
        {"Hipparcos Number", "HIP 109410"},
        {"Fundamental Katalog 5th Edition", "FK5 835"},
        {"Geneva Identification System", "GEN# +1.00210459"},
        {"Smithsonian Astrophysical Observation", "SAO 72077"},
        {"Wilson Evans Batten Catalogue", "WEB 19658"},
    },
    visualMagnitude: 4.28,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.49688603),
        dec: Angle.Degrees(+33.17826747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40384",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6676 AB"},
        {"Hipparcos Number", "HIP 40384"},
        {"Smithsonian Astrophysical Observation", "SAO 60669"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66982766),
        dec: Angle.Degrees(+33.17858607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6328"},
        {"Hipparcos Number", "HIP 5055"},
        {"Smithsonian Astrophysical Observation", "SAO 54400"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16838819),
        dec: Angle.Degrees(+33.18305260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169748"},
        {"Hipparcos Number", "HIP 90235"},
        {"Geneva Identification System", "GEN# +1.00169748"},
        {"Smithsonian Astrophysical Observation", "SAO 66947"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.16752417),
        dec: Angle.Degrees(+33.18307029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60935"},
        {"Hipparcos Number", "HIP 37179"},
        {"Fundamental Katalog 5th Edition", "FK5 4687"},
        {"Geneva Identification System", "GEN# +1.00060935"},
        {"Smithsonian Astrophysical Observation", "SAO 60238"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.58638258),
        dec: Angle.Degrees(+33.18681222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173632"},
        {"Hipparcos Number", "HIP 91984"},
        {"Smithsonian Astrophysical Observation", "SAO 67322"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.22530077),
        dec: Angle.Degrees(+33.18757274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115684"},
        {"Smithsonian Astrophysical Observation", "SAO 73252"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.57698385),
        dec: Angle.Degrees(+33.18911529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162383"},
        {"Hipparcos Number", "HIP 87231"},
        {"Smithsonian Astrophysical Observation", "SAO 66356"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.35178729),
        dec: Angle.Degrees(+33.18964518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64618"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66732661),
        dec: Angle.Degrees(+33.19138137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13660 AB"},
        {"Henry Draper", "HD 193238"},
        {"Hipparcos Number", "HIP 100058"},
        {"Celescope Catalog", "CEL 5018"},
        {"Geneva Identification System", "GEN# +1.00193238"},
        {"Smithsonian Astrophysical Observation", "SAO 69778"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.49962657),
        dec: Angle.Degrees(+33.19140984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127788"},
        {"Hipparcos Number", "HIP 71099"},
        {"Geneva Identification System", "GEN# +1.00127788"},
        {"Smithsonian Astrophysical Observation", "SAO 64207"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.09223905),
        dec: Angle.Degrees(+33.19377533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53742"},
        {"Hipparcos Number", "HIP 34380"},
        {"Geneva Identification System", "GEN# +1.00053742"},
        {"Smithsonian Astrophysical Observation", "SAO 59796"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.92374424),
        dec: Angle.Degrees(+33.19565349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59558"},
        {"Hipparcos Number", "HIP 36625"},
        {"Smithsonian Astrophysical Observation", "SAO 60151"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.98547421),
        dec: Angle.Degrees(+33.19628936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103645"},
        {"Hipparcos Number", "HIP 58201"},
        {"Geneva Identification System", "GEN# +1.00103645"},
        {"Smithsonian Astrophysical Observation", "SAO 62761"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.04755682),
        dec: Angle.Degrees(+33.19837476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43129"},
        {"Hipparcos Number", "HIP 29760"},
        {"Smithsonian Astrophysical Observation", "SAO 58921"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.00709389),
        dec: Angle.Degrees(+33.19898665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205941"},
        {"Hipparcos Number", "HIP 106802"},
        {"Cincinnati Publication", "Ci 18 2812"},
        {"Geneva Identification System", "GEN# +1.00205941"},
        {"Smithsonian Astrophysical Observation", "SAO 71539"},
        {"Wilson Evans Batten Catalogue", "WEB 19307"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48109505),
        dec: Angle.Degrees(+33.20033769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56173"},
        {"Hipparcos Number", "HIP 35297"},
        {"Smithsonian Astrophysical Observation", "SAO 59952"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.37385931),
        dec: Angle.Degrees(+33.20053746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88867"},
        {"Smithsonian Astrophysical Observation", "SAO 66672"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14791100),
        dec: Angle.Degrees(+33.20077955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184499"},
        {"Hipparcos Number", "HIP 96185"},
        {"Cincinnati Publication", "Ci 20 1158"},
        {"Geneva Identification System", "GEN# +1.00184499"},
        {"Smithsonian Astrophysical Observation", "SAO 68491"},
        {"Wilson Evans Batten Catalogue", "WEB 16855"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.36418518),
        dec: Angle.Degrees(+33.20131999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -464.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 224.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 952"},
        {"Hipparcos Number", "HIP 1123"},
        {"Fundamental Katalog 5th Edition", "FK5 2012"},
        {"Geneva Identification System", "GEN# +1.00000952"},
        {"Renson", "Renson 150"},
        {"Smithsonian Astrophysical Observation", "SAO 53744"},
        {"Wilson Evans Batten Catalogue", "WEB 197"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.50952703),
        dec: Angle.Degrees(+33.20608481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33943"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.65926316),
        dec: Angle.Degrees(+33.20713668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117282"},
        {"Hipparcos Number", "HIP 65753"},
        {"Geneva Identification System", "GEN# +1.00117282"},
        {"Smithsonian Astrophysical Observation", "SAO 63559"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.18352786),
        dec: Angle.Degrees(+33.21030080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12051"},
        {"Hipparcos Number", "HIP 9269"},
        {"Cincinnati Publication", "Ci 20 137"},
        {"Cincinnati Publication 2", "Ci 18 263"},
        {"Geneva Identification System", "GEN# +1.00012051"},
        {"Smithsonian Astrophysical Observation", "SAO 55167"},
        {"Wilson Evans Batten Catalogue", "WEB 1946"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.77693064),
        dec: Angle.Degrees(+33.21053783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -352.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149684"},
        {"Hipparcos Number", "HIP 81191"},
        {"Smithsonian Astrophysical Observation", "SAO 65403"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.75804997),
        dec: Angle.Degrees(+33.21336543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164614"},
        {"Hipparcos Number", "HIP 88190"},
        {"Geneva Identification System", "GEN# +1.00164614"},
        {"Smithsonian Astrophysical Observation", "SAO 66551"},
        {"Wilson Evans Batten Catalogue", "WEB 14903"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.15157280),
        dec: Angle.Degrees(+33.21373928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205334"},
        {"Hipparcos Number", "HIP 106465"},
        {"Smithsonian Astrophysical Observation", "SAO 71465"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.44611096),
        dec: Angle.Degrees(+33.21446087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40815"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.95027413),
        dec: Angle.Degrees(+33.21507076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83899"},
        {"Smithsonian Astrophysical Observation", "SAO 65822"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.20515396),
        dec: Angle.Degrees(+33.21575046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20678"},
        {"Hipparcos Number", "HIP 15609"},
        {"Smithsonian Astrophysical Observation", "SAO 56366"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.24723113),
        dec: Angle.Degrees(+33.21860009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39815"},
        {"Hipparcos Number", "HIP 28102"},
        {"Geneva Identification System", "GEN# +1.00039815"},
        {"Smithsonian Astrophysical Observation", "SAO 58588"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.09888620),
        dec: Angle.Degrees(+33.21906756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182488"},
        {"Hipparcos Number", "HIP 95319"},
        {"Geneva Identification System", "GEN# +1.00182488"},
        {"Smithsonian Astrophysical Observation", "SAO 68239"},
        {"Wilson Evans Batten Catalogue", "WEB 16660"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.89148075),
        dec: Angle.Degrees(+33.22157011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172115"},
        {"Hipparcos Number", "HIP 91264"},
        {"Geneva Identification System", "GEN# +1.00172115"},
        {"Smithsonian Astrophysical Observation", "SAO 67169"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.23695141),
        dec: Angle.Degrees(+33.22389895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57380"},
        {"Hipparcos Number", "HIP 35748"},
        {"Smithsonian Astrophysical Observation", "SAO 60020"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.60475875),
        dec: Angle.Degrees(+33.22444026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161464"},
        {"Hipparcos Number", "HIP 86808"},
        {"Smithsonian Astrophysical Observation", "SAO 66290"},
        {"Wilson Evans Batten Catalogue", "WEB 14643"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.07111221),
        dec: Angle.Degrees(+33.22613185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214504"},
        {"Hipparcos Number", "HIP 111734"},
        {"Smithsonian Astrophysical Observation", "SAO 72554"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.50951975),
        dec: Angle.Degrees(+33.22630527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118096"},
        {"Hipparcos Number", "HIP 66193"},
        {"Cincinnati Publication", "Ci 20 789"},
        {"Cincinnati Publication 2", "Ci 18 1758"},
        {"Geneva Identification System", "GEN# +0.03302350"},
        {"Geneva Identification System 2", "GEN# +1.00118096"},
        {"Smithsonian Astrophysical Observation", "SAO 63611"},
        {"Wilson Evans Batten Catalogue", "WEB 11692"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.51424356),
        dec: Angle.Degrees(+33.22760202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -258.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 325.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87370"},
        {"Hipparcos Number", "HIP 49419"},
        {"Geneva Identification System", "GEN# +1.00087370"},
        {"Smithsonian Astrophysical Observation", "SAO 61849"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.31527164),
        dec: Angle.Degrees(+33.22910995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102764",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14338 A"},
        {"Hipparcos Number", "HIP 102764"},
        {"Geneva Identification System", "GEN# +0.03203954A"},
        {"Wilson Evans Batten Catalogue", "WEB 18638"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31753330),
        dec: Angle.Degrees(+33.22977739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98840"},
        {"Hipparcos Number", "HIP 55559"},
        {"Geneva Identification System", "GEN# +1.00098840"},
        {"Smithsonian Astrophysical Observation", "SAO 62522"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.70583224),
        dec: Angle.Degrees(+33.23007373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113618"},
        {"Smithsonian Astrophysical Observation", "SAO 72925"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.17429315),
        dec: Angle.Degrees(+33.23008777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168603"},
        {"Hipparcos Number", "HIP 89771"},
        {"Smithsonian Astrophysical Observation", "SAO 66851"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.78673746),
        dec: Angle.Degrees(+33.23093668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85399"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.76483507),
        dec: Angle.Degrees(+33.23119914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111899"},
        {"Smithsonian Astrophysical Observation", "SAO 72596"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.00187493),
        dec: Angle.Degrees(+33.23262275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200686"},
        {"Hipparcos Number", "HIP 103980"},
        {"Smithsonian Astrophysical Observation", "SAO 70852"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.01778996),
        dec: Angle.Degrees(+33.23336048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63589"},
        {"Hipparcos Number", "HIP 38319"},
        {"Geneva Identification System", "GEN# +1.00063589"},
        {"Renson", "Renson 17520"},
        {"Smithsonian Astrophysical Observation", "SAO 60379"},
        {"Wilson Evans Batten Catalogue", "WEB 7537"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.75987223),
        dec: Angle.Degrees(+33.23363630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205744"},
        {"Hipparcos Number", "HIP 106688"},
        {"Smithsonian Astrophysical Observation", "SAO 71514"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.13770979),
        dec: Angle.Degrees(+33.23440214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138340"},
        {"Hipparcos Number", "HIP 75917"},
        {"Geneva Identification System", "GEN# +1.00138340"},
        {"Smithsonian Astrophysical Observation", "SAO 64737"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.59197384),
        dec: Angle.Degrees(+33.23691097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56581"},
        {"Smithsonian Astrophysical Observation", "SAO 62619"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.00664901),
        dec: Angle.Degrees(+33.23717048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178912"},
        {"Hipparcos Number", "HIP 94080"},
        {"Celescope Catalog", "CEL 4707"},
        {"Geneva Identification System", "GEN# +1.00178912"},
        {"Smithsonian Astrophysical Observation", "SAO 67877"},
        {"Wilson Evans Batten Catalogue", "WEB 16380"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.27428294),
        dec: Angle.Degrees(+33.23782910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49521"},
        {"Hipparcos Number", "HIP 32791"},
        {"Smithsonian Astrophysical Observation", "SAO 59533"},
        {"Wilson Evans Batten Catalogue", "WEB 6603"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.54810441),
        dec: Angle.Degrees(+33.23911349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202049"},
        {"Hipparcos Number", "HIP 104696"},
        {"Smithsonian Astrophysical Observation", "SAO 71060"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12126678),
        dec: Angle.Degrees(+33.23938938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74484"},
        {"Hipparcos Number", "HIP 42973"},
        {"Smithsonian Astrophysical Observation", "SAO 61032"},
        {"Wilson Evans Batten Catalogue", "WEB 8306"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37661280),
        dec: Angle.Degrees(+33.23970326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244973"},
        {"Hipparcos Number", "HIP 26228"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.82502310),
        dec: Angle.Degrees(+33.24108296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54414"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.02172648),
        dec: Angle.Degrees(+33.24429180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42767"},
        {"Hipparcos Number", "HIP 29581"},
        {"Smithsonian Astrophysical Observation", "SAO 58874"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.50209075),
        dec: Angle.Degrees(+33.24429633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29834"},
        {"Hipparcos Number", "HIP 21978"},
        {"Smithsonian Astrophysical Observation", "SAO 57389"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.87179730),
        dec: Angle.Degrees(+33.24453427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115671"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.52137874),
        dec: Angle.Degrees(+33.24496840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63336"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67971220),
        dec: Angle.Degrees(+33.24571569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67009"},
        {"Hipparcos Number", "HIP 39735"},
        {"Geneva Identification System", "GEN# +1.00067009"},
        {"Smithsonian Astrophysical Observation", "SAO 60573"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82568103),
        dec: Angle.Degrees(+33.24721620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109317"},
        {"Hipparcos Number", "HIP 61309"},
        {"Fundamental Katalog 5th Edition", "FK5 1322"},
        {"Geneva Identification System", "GEN# +1.00109317"},
        {"Smithsonian Astrophysical Observation", "SAO 63070"},
        {"Wilson Evans Batten Catalogue", "WEB 10911"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.41210253),
        dec: Angle.Degrees(+33.24766003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16652 AB"},
        {"Henry Draper", "HD 219698"},
        {"Hipparcos Number", "HIP 115006"},
        {"Smithsonian Astrophysical Observation", "SAO 73147"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.39415983),
        dec: Angle.Degrees(+33.24888849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44850"},
        {"Hipparcos Number", "HIP 30573"},
        {"Smithsonian Astrophysical Observation", "SAO 59067"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.39145921),
        dec: Angle.Degrees(+33.24922310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13682 ABC"},
        {"Henry Draper", "HD 193371"},
        {"Hipparcos Number", "HIP 100127"},
        {"Smithsonian Astrophysical Observation", "SAO 69808"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.68084529),
        dec: Angle.Degrees(+33.25027293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33063"},
        {"Hipparcos Number", "HIP 23971"},
        {"Smithsonian Astrophysical Observation", "SAO 57683"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28542283),
        dec: Angle.Degrees(+33.25169190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14861 AB"},
        {"Henry Draper", "HD 203170"},
        {"Hipparcos Number", "HIP 105300"},
        {"Smithsonian Astrophysical Observation", "SAO 71208"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.91984212),
        dec: Angle.Degrees(+33.25405694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125308"},
        {"Hipparcos Number", "HIP 69857"},
        {"Geneva Identification System", "GEN# +1.00125308"},
        {"Smithsonian Astrophysical Observation", "SAO 64051"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.44484763),
        dec: Angle.Degrees(+33.25505652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106509"},
        {"Hipparcos Number", "HIP 59727"},
        {"Geneva Identification System", "GEN# +1.00106509"},
        {"Smithsonian Astrophysical Observation", "SAO 62912"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.74592587),
        dec: Angle.Degrees(+33.25631202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213339"},
        {"Hipparcos Number", "HIP 111074"},
        {"Smithsonian Astrophysical Observation", "SAO 72409"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.53325367),
        dec: Angle.Degrees(+33.25772904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76349"},
        {"Hipparcos Number", "HIP 43904"},
        {"Geneva Identification System", "GEN# +1.00076349"},
        {"Smithsonian Astrophysical Observation", "SAO 61142"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.16429955),
        dec: Angle.Degrees(+33.25783809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40001"},
        {"Hipparcos Number", "HIP 28212"},
        {"Geneva Identification System", "GEN# +1.00040001"},
        {"Smithsonian Astrophysical Observation", "SAO 58611"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.41559848),
        dec: Angle.Degrees(+33.26036875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32365"},
        {"Hipparcos Number", "HIP 23578"},
        {"Smithsonian Astrophysical Observation", "SAO 57605"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.03922618),
        dec: Angle.Degrees(+33.26216887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35521"},
        {"Hipparcos Number", "HIP 25475"},
        {"Geneva Identification System", "GEN# +1.00035521"},
        {"Smithsonian Astrophysical Observation", "SAO 58030"},
        {"Wilson Evans Batten Catalogue", "WEB 4935"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.71364799),
        dec: Angle.Degrees(+33.26228774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98466"},
    },
    visualMagnitude: 12.08,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.07968495),
        dec: Angle.Degrees(+33.26420611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134454"},
        {"Hipparcos Number", "HIP 74130"},
        {"Smithsonian Astrophysical Observation", "SAO 64519"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23889354),
        dec: Angle.Degrees(+33.26528116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53926"},
        {"Hipparcos Number", "HIP 34439"},
        {"Geneva Identification System", "GEN# +1.00053926"},
        {"Smithsonian Astrophysical Observation", "SAO 59808"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09159755),
        dec: Angle.Degrees(+33.26804854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265866"},
        {"Hipparcos Number", "HIP 33226"},
        {"Cincinnati Publication", "Ci 20 400"},
        {"Geneva Identification System", "GEN# +9.80087012"},
        {"Geneva Identification System 2", "GEN# +6.10010251"},
        {"Wilson Evans Batten Catalogue", "WEB 6685"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.70610465),
        dec: Angle.Degrees(+33.26914569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -729.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -399.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29022"},
        {"Hipparcos Number", "HIP 21390"},
        {"Smithsonian Astrophysical Observation", "SAO 57327"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.87715165),
        dec: Angle.Degrees(+33.27252691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11047 A"},
        {"Henry Draper", "HD 165504"},
        {"Hipparcos Number", "HIP 88552"},
        {"Cincinnati Publication", "Ci 18 2393"},
        {"Geneva Identification System", "GEN# +1.00165504J"},
        {"Smithsonian Astrophysical Observation", "SAO 66611"},
        {"Wilson Evans Batten Catalogue", "WEB 14992"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.21843948),
        dec: Angle.Degrees(+33.27279652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229088"},
        {"Hipparcos Number", "HIP 100424"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.45131677),
        dec: Angle.Degrees(+33.27376409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133253"},
        {"Hipparcos Number", "HIP 73586"},
        {"Smithsonian Astrophysical Observation", "SAO 64472"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.62188359),
        dec: Angle.Degrees(+33.27436389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98136"},
        {"Hipparcos Number", "HIP 55155"},
        {"Smithsonian Astrophysical Observation", "SAO 62479"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.38677023),
        dec: Angle.Degrees(+33.27650859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187639"},
        {"Hipparcos Number", "HIP 97553"},
        {"Fundamental Katalog 5th Edition", "FK5 5750"},
        {"Geneva Identification System", "GEN# +1.00187639"},
        {"Smithsonian Astrophysical Observation", "SAO 68913"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.42522389),
        dec: Angle.Degrees(+33.27688336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73638"},
        {"Hipparcos Number", "HIP 42562"},
        {"Smithsonian Astrophysical Observation", "SAO 60972"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.14032677),
        dec: Angle.Degrees(+33.27729223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98315",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13196 AB"},
        {"Henry Draper", "HD 189378"},
        {"Hipparcos Number", "HIP 98315"},
        {"Geneva Identification System", "GEN# +1.00189378"},
        {"Smithsonian Astrophysical Observation", "SAO 69186"},
        {"Wilson Evans Batten Catalogue", "WEB 17339"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63606255),
        dec: Angle.Degrees(+33.27744215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102985"},
        {"Smithsonian Astrophysical Observation", "SAO 70595"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.98261728),
        dec: Angle.Degrees(+33.27823096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117477"},
        {"Hipparcos Number", "HIP 65868"},
        {"Smithsonian Astrophysical Observation", "SAO 63570"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.50573152),
        dec: Angle.Degrees(+33.28121613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89864"},
        {"Hipparcos Number", "HIP 50837"},
        {"Smithsonian Astrophysical Observation", "SAO 62005"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71110420),
        dec: Angle.Degrees(+33.28236884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1621 A"},
        {"Henry Draper", "HD 12471"},
        {"Hipparcos Number", "HIP 9570"},
        {"Geneva Identification System", "GEN# +1.00012471"},
        {"Smithsonian Astrophysical Observation", "SAO 55218"},
        {"Wilson Evans Batten Catalogue", "WEB 2010"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.74152860),
        dec: Angle.Degrees(+33.28415151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75332"},
        {"Hipparcos Number", "HIP 43410"},
        {"Geneva Identification System", "GEN# +1.00075332"},
        {"Smithsonian Astrophysical Observation", "SAO 61074"},
        {"Wilson Evans Batten Catalogue", "WEB 8363"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.63444521),
        dec: Angle.Degrees(+33.28525915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125708"},
        {"Hipparcos Number", "HIP 70073"},
        {"Smithsonian Astrophysical Observation", "SAO 64077"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.09412901),
        dec: Angle.Degrees(+33.28558122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245637"},
        {"Hipparcos Number", "HIP 26527"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.63259561),
        dec: Angle.Degrees(+33.28653354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48106"},
        {"Wilson Evans Batten Catalogue", "WEB 8990"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.11860018),
        dec: Angle.Degrees(+33.28878596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8347"},
        {"Hipparcos Number", "HIP 6467"},
        {"Smithsonian Astrophysical Observation", "SAO 54647"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.80050379),
        dec: Angle.Degrees(+33.28989495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125799"},
        {"Hipparcos Number", "HIP 70127"},
        {"Smithsonian Astrophysical Observation", "SAO 64086"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.23769581),
        dec: Angle.Degrees(+33.29051273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223017"},
        {"Hipparcos Number", "HIP 117201"},
        {"Smithsonian Astrophysical Observation", "SAO 73487"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46539624),
        dec: Angle.Degrees(+33.29051524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181682"},
        {"Hipparcos Number", "HIP 95022"},
        {"Geneva Identification System", "GEN# +1.00181682"},
        {"Smithsonian Astrophysical Observation", "SAO 68152"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.01266267),
        dec: Angle.Degrees(+33.29104615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167063"},
        {"Hipparcos Number", "HIP 89198"},
        {"Smithsonian Astrophysical Observation", "SAO 66743"},
        {"Wilson Evans Batten Catalogue", "WEB 15157"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.04610838),
        dec: Angle.Degrees(+33.29172460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66906"},
    },
    visualMagnitude: 12.03,
    bvColour: 2.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.68061204),
        dec: Angle.Degrees(+33.29182156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -706.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116158"},
        {"Hipparcos Number", "HIP 65170"},
        {"Geneva Identification System", "GEN# +1.00116158"},
        {"Smithsonian Astrophysical Observation", "SAO 63493"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.33769864),
        dec: Angle.Degrees(+33.29326401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88202"},
        {"Smithsonian Astrophysical Observation", "SAO 66554"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.18238927),
        dec: Angle.Degrees(+33.29335027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91794"},
    },
    visualMagnitude: 11.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.76018616),
        dec: Angle.Degrees(+33.29371380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 196.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28101"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.09852043),
        dec: Angle.Degrees(+33.29400020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61878"},
    },
    visualMagnitude: 11.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20610800),
        dec: Angle.Degrees(+38.69544839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89268"},
        {"Smithsonian Astrophysical Observation", "SAO 66759"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.24165343),
        dec: Angle.Degrees(+33.29831327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155227"},
        {"Hipparcos Number", "HIP 83905"},
        {"Smithsonian Astrophysical Observation", "SAO 65824"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.22496273),
        dec: Angle.Degrees(+33.30077653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199646"},
        {"Hipparcos Number", "HIP 103453"},
        {"Smithsonian Astrophysical Observation", "SAO 70719"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.40430564),
        dec: Angle.Degrees(+33.30116699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81201"},
        {"Geneva Identification System", "GEN# +9.80180062"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.78530139),
        dec: Angle.Degrees(+33.30188524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128578"},
        {"Hipparcos Number", "HIP 71460"},
        {"Smithsonian Astrophysical Observation", "SAO 64236"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.20949402),
        dec: Angle.Degrees(+33.30327777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143761"},
        {"Hipparcos Number", "HIP 78459"},
        {"Cincinnati Publication", "Ci 20 959"},
        {"Geneva Identification System", "GEN# +1.00143761"},
        {"Smithsonian Astrophysical Observation", "SAO 65024"},
        {"Wilson Evans Batten Catalogue", "WEB 13268"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26166247),
        dec: Angle.Degrees(+33.30538815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -773.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81976"},
        {"Hipparcos Number", "HIP 46588"},
        {"Renson", "Renson 23307"},
        {"Smithsonian Astrophysical Observation", "SAO 61522"},
        {"Wilson Evans Batten Catalogue", "WEB 8790"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.50909755),
        dec: Angle.Degrees(+33.30591455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120183"},
        {"Hipparcos Number", "HIP 67268"},
        {"Smithsonian Astrophysical Observation", "SAO 63741"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80250189),
        dec: Angle.Degrees(+33.30722565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90236"},
        {"Hipparcos Number", "HIP 51033"},
        {"Smithsonian Astrophysical Observation", "SAO 62033"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.39292077),
        dec: Angle.Degrees(+33.30820193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41753"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.71124253),
        dec: Angle.Degrees(+33.30916095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4119"},
        {"Hipparcos Number", "HIP 3438"},
        {"Fundamental Katalog 5th Edition", "FK5 4062"},
        {"Geneva Identification System", "GEN# +1.00004119"},
        {"Smithsonian Astrophysical Observation", "SAO 54111"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.96776657),
        dec: Angle.Degrees(+33.31068398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10998 A"},
        {"Henry Draper", "HD 164824"},
        {"Hipparcos Number", "HIP 88277"},
        {"Fundamental Katalog 5th Edition", "FK5 3434"},
        {"Geneva Identification System", "GEN# +1.00164824"},
        {"Smithsonian Astrophysical Observation", "SAO 66562"},
        {"Wilson Evans Batten Catalogue", "WEB 14919"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.39953406),
        dec: Angle.Degrees(+33.31121818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207623"},
        {"Hipparcos Number", "HIP 107744"},
        {"Geneva Identification System", "GEN# +1.00207623"},
        {"Smithsonian Astrophysical Observation", "SAO 71742"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.39689967),
        dec: Angle.Degrees(+33.31201916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4287 A"},
        {"Henry Draper", "HD 37859"},
        {"Hipparcos Number", "HIP 26931"},
        {"Smithsonian Astrophysical Observation", "SAO 58359"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74273596),
        dec: Angle.Degrees(+33.31460846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9559 A"},
        {"Henry Draper", "HD 135722"},
        {"Hipparcos Number", "HIP 74666"},
        {"Fundamental Katalog 5th Edition", "FK5 563"},
        {"Geneva Identification System", "GEN# +1.00135722A"},
        {"Smithsonian Astrophysical Observation", "SAO 64589"},
        {"Wilson Evans Batten Catalogue", "WEB 12740"},
    },
    visualMagnitude: 3.46,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.87543241),
        dec: Angle.Degrees(+33.31510222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13727"},
        {"Hipparcos Number", "HIP 10450"},
        {"Geneva Identification System", "GEN# +1.00013727"},
        {"Smithsonian Astrophysical Observation", "SAO 55380"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.66618360),
        dec: Angle.Degrees(+33.31563355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151216"},
        {"Hipparcos Number", "HIP 81977"},
        {"Smithsonian Astrophysical Observation", "SAO 65519"},
        {"Wilson Evans Batten Catalogue", "WEB 13841"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.19135233),
        dec: Angle.Degrees(+33.31634241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95058"},
        {"Hipparcos Number", "HIP 53673"},
        {"Geneva Identification System", "GEN# +1.00095058"},
        {"Smithsonian Astrophysical Observation", "SAO 62337"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.72470273),
        dec: Angle.Degrees(+33.31697566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281952"},
        {"Hipparcos Number", "HIP 20588"},
        {"Smithsonian Astrophysical Observation", "SAO 57214"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.13981265),
        dec: Angle.Degrees(+33.31792649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33643"},
        {"Hipparcos Number", "HIP 24323"},
        {"Geneva Identification System", "GEN# +1.00033643"},
        {"Smithsonian Astrophysical Observation", "SAO 57753"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.29550690),
        dec: Angle.Degrees(+33.31828689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112422"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.57762446),
        dec: Angle.Degrees(+33.32077200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244274"},
        {"Hipparcos Number", "HIP 25847"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.76529365),
        dec: Angle.Degrees(+33.32086671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9559 B"},
        {"Hipparcos Number", "HIP 74674"},
        {"Geneva Identification System", "GEN# +0.03302562"},
        {"Smithsonian Astrophysical Observation", "SAO 64591"},
        {"Wilson Evans Batten Catalogue", "WEB 12741"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.90954478),
        dec: Angle.Degrees(+33.32118941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177645"},
        {"Hipparcos Number", "HIP 93648"},
        {"Geneva Identification System", "GEN# +1.00177645"},
        {"Renson", "Renson 49528"},
        {"Smithsonian Astrophysical Observation", "SAO 67767"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.05097287),
        dec: Angle.Degrees(+33.32130953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6150"},
        {"Hipparcos Number", "HIP 4908"},
        {"Smithsonian Astrophysical Observation", "SAO 54377"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.73744185),
        dec: Angle.Degrees(+33.32312005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23027"},
        {"Hipparcos Number", "HIP 17362"},
        {"Smithsonian Astrophysical Observation", "SAO 56658"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.75601935),
        dec: Angle.Degrees(+33.32461425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278994"},
        {"Hipparcos Number", "HIP 17700"},
        {"Geneva Identification System", "GEN# +1.00278994"},
        {"Smithsonian Astrophysical Observation", "SAO 56701"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.86568768),
        dec: Angle.Degrees(+33.32489292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179368"},
        {"Hipparcos Number", "HIP 94229"},
        {"Smithsonian Astrophysical Observation", "SAO 67924"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.73185757),
        dec: Angle.Degrees(+33.32612861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278548"},
        {"Hipparcos Number", "HIP 15447"},
        {"Smithsonian Astrophysical Observation", "SAO 56344"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.79295141),
        dec: Angle.Degrees(+33.32765329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79659"},
        {"Smithsonian Astrophysical Observation", "SAO 65175"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.84917155),
        dec: Angle.Degrees(+33.33007785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20904"},
        {"Hipparcos Number", "HIP 15787"},
        {"Geneva Identification System", "GEN# +1.00020904"},
        {"Smithsonian Astrophysical Observation", "SAO 56404"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.86857930),
        dec: Angle.Degrees(+33.33222288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113508"},
        {"Smithsonian Astrophysical Observation", "SAO 72901"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.81164933),
        dec: Angle.Degrees(+33.33316217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75757"},
        {"Smithsonian Astrophysical Observation", "SAO 64719"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.14324625),
        dec: Angle.Degrees(+33.33513067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206847"},
        {"Hipparcos Number", "HIP 107308"},
        {"Geneva Identification System", "GEN# +1.00206847"},
        {"Smithsonian Astrophysical Observation", "SAO 71650"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.01224556),
        dec: Angle.Degrees(+33.33523917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69551"},
        {"Hipparcos Number", "HIP 40716"},
        {"Smithsonian Astrophysical Observation", "SAO 60720"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.67387476),
        dec: Angle.Degrees(+33.33584954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75904"},
        {"Smithsonian Astrophysical Observation", "SAO 64734"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.55720105),
        dec: Angle.Degrees(+33.33658740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9979"},
        {"Smithsonian Astrophysical Observation", "SAO 55291"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.12876879),
        dec: Angle.Degrees(+33.34018403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145802"},
        {"Hipparcos Number", "HIP 79350"},
        {"Geneva Identification System", "GEN# +1.00145802J"},
        {"Smithsonian Astrophysical Observation", "SAO 65129"},
        {"Wilson Evans Batten Catalogue", "WEB 13415"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.91498299),
        dec: Angle.Degrees(+33.34272966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71009"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.84316381),
        dec: Angle.Degrees(+33.34303974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62181"},
    },
    visualMagnitude: 12.44,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.15341249),
        dec: Angle.Degrees(+33.34581307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185636"},
        {"Hipparcos Number", "HIP 96631"},
        {"Geneva Identification System", "GEN# +1.00185636"},
        {"Smithsonian Astrophysical Observation", "SAO 68624"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.70839685),
        dec: Angle.Degrees(+33.34629487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54561"},
        {"Hipparcos Number", "HIP 34668"},
        {"Smithsonian Astrophysical Observation", "SAO 59848"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.69365079),
        dec: Angle.Degrees(+33.34659574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65016"},
        {"Geneva Identification System", "GEN# +9.80164066"},
        {"Wilson Evans Batten Catalogue", "WEB 11490"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.91805903),
        dec: Angle.Degrees(+33.34687596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -298.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116738"},
        {"Hipparcos Number", "HIP 65461"},
        {"Geneva Identification System", "GEN# +1.00116738"},
        {"Smithsonian Astrophysical Observation", "SAO 63524"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.25293416),
        dec: Angle.Degrees(+33.35035696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196739"},
        {"Hipparcos Number", "HIP 101834"},
        {"Smithsonian Astrophysical Observation", "SAO 70313"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.55330262),
        dec: Angle.Degrees(+33.35049355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241730"},
        {"Hipparcos Number", "HIP 24433"},
        {"Smithsonian Astrophysical Observation", "SAO 57785"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.63416116),
        dec: Angle.Degrees(+33.35144266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103780"},
        {"Hipparcos Number", "HIP 58281"},
        {"Geneva Identification System", "GEN# +1.00103780"},
        {"Smithsonian Astrophysical Observation", "SAO 62770"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.28750977),
        dec: Angle.Degrees(+33.35348220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155358"},
        {"Hipparcos Number", "HIP 83949"},
        {"Geneva Identification System", "GEN# +1.00155358"},
        {"Smithsonian Astrophysical Observation", "SAO 65834"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.39488690),
        dec: Angle.Degrees(+33.35638190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92616",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11781 A"},
        {"Henry Draper", "HD 175082"},
        {"Hipparcos Number", "HIP 92616"},
        {"Smithsonian Astrophysical Observation", "SAO 67496"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.07202091),
        dec: Angle.Degrees(+33.35790807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21913"},
        {"Hipparcos Number", "HIP 16557"},
        {"Geneva Identification System", "GEN# +1.00021913"},
        {"Smithsonian Astrophysical Observation", "SAO 56534"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30069321),
        dec: Angle.Degrees(+33.35891264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13869"},
        {"Hipparcos Number", "HIP 10559"},
        {"Celescope Catalog", "CEL 234"},
        {"Geneva Identification System", "GEN# +1.00013869"},
        {"Renson", "Renson 3560"},
        {"Smithsonian Astrophysical Observation", "SAO 55397"},
        {"Wilson Evans Batten Catalogue", "WEB 2217"},
    },
    visualMagnitude: 5.25,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.98456296),
        dec: Angle.Degrees(+33.35897589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 411"},
        {"Smithsonian Astrophysical Observation", "SAO 53624"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.25663332),
        dec: Angle.Degrees(+33.36001239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10129",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1681 B"},
        {"Hipparcos Number", "HIP 10129"},
        {"Renson", "Renson 3430"},
        {"Smithsonian Astrophysical Observation", "SAO 55322"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.56683253),
        dec: Angle.Degrees(+33.36212507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92420",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sheliak"},
        {"Aitken", "ADS 11745 A"},
        {"Henry Draper", "HD 174638"},
        {"Hipparcos Number", "HIP 92420"},
        {"Celescope Catalog", "CEL 4657"},
        {"Fundamental Katalog 5th Edition", "FK5 705"},
        {"Geneva Identification System", "GEN# +1.00174638A"},
        {"Renson", "Renson 48890"},
        {"Smithsonian Astrophysical Observation", "SAO 67452"},
        {"Smithsonian Astrophysical Observation 2", "SAO 67451"},
        {"Wilson Evans Batten Catalogue", "WEB 15967"},
    },
    visualMagnitude: 3.52,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.51997462),
        dec: Angle.Degrees(+33.36267788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116850"},
        {"Smithsonian Astrophysical Observation", "SAO 73434"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.27684528),
        dec: Angle.Degrees(+33.36317506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92767"},
        {"Hipparcos Number", "HIP 52441"},
        {"Smithsonian Astrophysical Observation", "SAO 62217"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.79700394),
        dec: Angle.Degrees(+33.36349626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10130",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1681 A"},
        {"Henry Draper", "HD 13247"},
        {"Hipparcos Number", "HIP 10130"},
        {"Celescope Catalog", "CEL 215"},
        {"Geneva Identification System", "GEN# +1.00013247"},
        {"Smithsonian Astrophysical Observation", "SAO 55321"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.56707347),
        dec: Angle.Degrees(+33.36533659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208548"},
        {"Hipparcos Number", "HIP 108278"},
        {"Smithsonian Astrophysical Observation", "SAO 71856"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.05008468),
        dec: Angle.Degrees(+33.36583848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14078 AB"},
        {"Henry Draper", "HD 196673"},
        {"Hipparcos Number", "HIP 101788"},
        {"Geneva Identification System", "GEN# +1.00196673"},
        {"Smithsonian Astrophysical Observation", "SAO 70300"},
        {"Wilson Evans Batten Catalogue", "WEB 18390"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.43467476),
        dec: Angle.Degrees(+33.36650501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90693"},
        {"Smithsonian Astrophysical Observation", "SAO 67036"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.56157801),
        dec: Angle.Degrees(+33.36661373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73922"},
        {"Hipparcos Number", "HIP 42692"},
        {"Geneva Identification System", "GEN# +1.00073922"},
        {"Smithsonian Astrophysical Observation", "SAO 60992"},
        {"Wilson Evans Batten Catalogue", "WEB 8243"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.52502830),
        dec: Angle.Degrees(+33.36914481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77969"},
        {"Hipparcos Number", "HIP 44714"},
        {"Smithsonian Astrophysical Observation", "SAO 61259"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.66174468),
        dec: Angle.Degrees(+33.37058310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3872 A"},
        {"Henry Draper", "HD 34334"},
        {"Hipparcos Number", "HIP 24727"},
        {"Geneva Identification System", "GEN# +1.00034334"},
        {"Smithsonian Astrophysical Observation", "SAO 57853"},
        {"Wilson Evans Batten Catalogue", "WEB 4782"},
    },
    visualMagnitude: 4.54,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54395049),
        dec: Angle.Degrees(+33.37200411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27428"},
        {"Hipparcos Number", "HIP 20305"},
        {"Smithsonian Astrophysical Observation", "SAO 57179"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26054388),
        dec: Angle.Degrees(+33.37246729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116514"},
        {"Hipparcos Number", "HIP 65347"},
        {"Smithsonian Astrophysical Observation", "SAO 63511"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.90098888),
        dec: Angle.Degrees(+33.37371745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183364"},
        {"Hipparcos Number", "HIP 95699"},
        {"Geneva Identification System", "GEN# +1.00183364"},
        {"Smithsonian Astrophysical Observation", "SAO 68349"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.97136631),
        dec: Angle.Degrees(+33.37404655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246482"},
        {"Hipparcos Number", "HIP 26915"},
        {"Smithsonian Astrophysical Observation", "SAO 58358"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.70567242),
        dec: Angle.Degrees(+33.37441512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102942"},
        {"Hipparcos Number", "HIP 57805"},
        {"Geneva Identification System", "GEN# +1.00102942"},
        {"Renson", "Renson 29730"},
        {"Smithsonian Astrophysical Observation", "SAO 62731"},
        {"Wilson Evans Batten Catalogue", "WEB 10372"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.78964274),
        dec: Angle.Degrees(+33.37496331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213596"},
        {"Hipparcos Number", "HIP 111227"},
        {"Smithsonian Astrophysical Observation", "SAO 72442"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.02766390),
        dec: Angle.Degrees(+33.37683188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209439"},
        {"Hipparcos Number", "HIP 108812"},
        {"Smithsonian Astrophysical Observation", "SAO 71970"},
        {"Wilson Evans Batten Catalogue", "WEB 19572"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.65522274),
        dec: Angle.Degrees(+33.37938774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25012",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3928 B"},
        {"Hipparcos Number", "HIP 25012"},
        {"Smithsonian Astrophysical Observation", "SAO 57930"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.33800188),
        dec: Angle.Degrees(+33.38203302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109345"},
        {"Hipparcos Number", "HIP 61320"},
        {"Geneva Identification System", "GEN# +1.00109345"},
        {"Smithsonian Astrophysical Observation", "SAO 63072"},
        {"Wilson Evans Batten Catalogue", "WEB 10913"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.44754305),
        dec: Angle.Degrees(+33.38469496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208763"},
        {"Hipparcos Number", "HIP 108412"},
        {"Geneva Identification System", "GEN# +1.00208763"},
        {"Smithsonian Astrophysical Observation", "SAO 71881"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.43270776),
        dec: Angle.Degrees(+33.38475712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25015",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3928 A"},
        {"Henry Draper", "HD 34760"},
        {"Hipparcos Number", "HIP 25015"},
        {"Celescope Catalog", "CEL 637"},
        {"Geneva Identification System", "GEN# +1.00034760"},
        {"Smithsonian Astrophysical Observation", "SAO 57931"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.34065919),
        dec: Angle.Degrees(+33.38545709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113985",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16496 AB"},
        {"Henry Draper", "HD 218097"},
        {"Hipparcos Number", "HIP 113985"},
        {"Smithsonian Astrophysical Observation", "SAO 72984"},
        {"Wilson Evans Batten Catalogue", "WEB 20240"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25452682),
        dec: Angle.Degrees(+33.38577298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62284"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.46494361),
        dec: Angle.Degrees(+33.38723009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191568"},
        {"Hipparcos Number", "HIP 99299"},
        {"Geneva Identification System", "GEN# +4.28050017"},
        {"Geneva Identification System 2", "GEN# +1.00191568"},
        {"Smithsonian Astrophysical Observation", "SAO 69514"},
        {"Wilson Evans Batten Catalogue", "WEB 17707"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34939302),
        dec: Angle.Degrees(+33.38769834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181409"},
        {"Hipparcos Number", "HIP 94934"},
        {"Celescope Catalog", "CEL 4734"},
        {"Geneva Identification System", "GEN# +1.00181409"},
        {"Smithsonian Astrophysical Observation", "SAO 68125"},
        {"Wilson Evans Batten Catalogue", "WEB 16577"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.76562260),
        dec: Angle.Degrees(+33.38889352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13998 A"},
        {"Henry Draper", "HD 195992"},
        {"Hipparcos Number", "HIP 101430"},
        {"Geneva Identification System", "GEN# +1.00195992"},
        {"Smithsonian Astrophysical Observation", "SAO 70189"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.33285453),
        dec: Angle.Degrees(+33.38955055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51806"},
        {"Hipparcos Number", "HIP 33709"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.05595477),
        dec: Angle.Degrees(+33.38984880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46762"},
        {"Hipparcos Number", "HIP 31585"},
        {"Geneva Identification System", "GEN# +1.00046762"},
        {"Smithsonian Astrophysical Observation", "SAO 59285"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.15032682),
        dec: Angle.Degrees(+33.39056204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110757"},
        {"Smithsonian Astrophysical Observation", "SAO 72334"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.57517521),
        dec: Angle.Degrees(+33.39162130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84144"},
        {"Hipparcos Number", "HIP 47739"},
        {"Smithsonian Astrophysical Observation", "SAO 61659"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.97581481),
        dec: Angle.Degrees(+33.39449344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201345"},
        {"Hipparcos Number", "HIP 104316"},
        {"Geneva Identification System", "GEN# +1.00201345"},
        {"Smithsonian Astrophysical Observation", "SAO 70953"},
        {"Wilson Evans Batten Catalogue", "WEB 18996"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.98089189),
        dec: Angle.Degrees(+33.39702991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121105"},
        {"Hipparcos Number", "HIP 67749"},
        {"Geneva Identification System", "GEN# +1.00121105"},
        {"Smithsonian Astrophysical Observation", "SAO 63805"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.19389555),
        dec: Angle.Degrees(+33.40045977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163948"},
        {"Hipparcos Number", "HIP 87909"},
        {"Smithsonian Astrophysical Observation", "SAO 66506"},
        {"Wilson Evans Batten Catalogue", "WEB 14843"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.35125200),
        dec: Angle.Degrees(+33.40087814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89039"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.60041842),
        dec: Angle.Degrees(+33.40308241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78490"},
        {"Hipparcos Number", "HIP 44962"},
        {"Smithsonian Astrophysical Observation", "SAO 61293"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.40017463),
        dec: Angle.Degrees(+33.40488608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279128"},
        {"Hipparcos Number", "HIP 18108"},
        {"Geneva Identification System", "GEN# +1.00279128"},
        {"Smithsonian Astrophysical Observation", "SAO 56766"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.06783581),
        dec: Angle.Degrees(+33.40620802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15452"},
        {"Hipparcos Number", "HIP 11635"},
        {"Geneva Identification System", "GEN# +1.00015452"},
        {"Smithsonian Astrophysical Observation", "SAO 55607"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.53037976),
        dec: Angle.Degrees(+33.40654577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119171"},
        {"Hipparcos Number", "HIP 66760"},
        {"Geneva Identification System", "GEN# +1.00119171"},
        {"Smithsonian Astrophysical Observation", "SAO 63686"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.25069437),
        dec: Angle.Degrees(+33.40667036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12389"},
        {"Hipparcos Number", "HIP 9501"},
        {"Geneva Identification System", "GEN# +1.00012389"},
        {"Smithsonian Astrophysical Observation", "SAO 55207"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.55602313),
        dec: Angle.Degrees(+33.40890607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191334"},
        {"Hipparcos Number", "HIP 99192"},
        {"Geneva Identification System", "GEN# +4.28050010"},
        {"Geneva Identification System 2", "GEN# +1.00191334"},
        {"Smithsonian Astrophysical Observation", "SAO 69472"},
        {"Wilson Evans Batten Catalogue", "WEB 17661"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.05292483),
        dec: Angle.Degrees(+33.40900361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148910"},
        {"Hipparcos Number", "HIP 80807"},
        {"Geneva Identification System", "GEN# +1.00148910"},
        {"Smithsonian Astrophysical Observation", "SAO 65341"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.51882676),
        dec: Angle.Degrees(+33.41068085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191613"},
        {"Hipparcos Number", "HIP 99324"},
        {"Geneva Identification System", "GEN# +4.28050019J"},
        {"Geneva Identification System 2", "GEN# +1.00191613J"},
        {"Smithsonian Astrophysical Observation", "SAO 69524"},
        {"Wilson Evans Batten Catalogue", "WEB 17720"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.40496406),
        dec: Angle.Degrees(+33.41085672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36545"},
        {"Hipparcos Number", "HIP 26099"},
        {"Celescope Catalog", "CEL 784"},
        {"Smithsonian Astrophysical Observation", "SAO 58186"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.49148091),
        dec: Angle.Degrees(+33.41355108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52476"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.92817715),
        dec: Angle.Degrees(+33.41371710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210169"},
        {"Hipparcos Number", "HIP 109234"},
        {"Geneva Identification System", "GEN# +1.00210169"},
        {"Renson", "Renson 58480"},
        {"Smithsonian Astrophysical Observation", "SAO 72048"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.94011346),
        dec: Angle.Degrees(+33.41574568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6364 A"},
        {"Henry Draper", "HD 62898"},
        {"Hipparcos Number", "HIP 38016"},
        {"Fundamental Katalog 5th Edition", "FK5 296"},
        {"Geneva Identification System", "GEN# +1.00062898J"},
        {"Geneva Identification System 2", "GEN# +1.00062898A"},
        {"Smithsonian Astrophysical Observation", "SAO 60340"},
        {"Wilson Evans Batten Catalogue", "WEB 7499"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.87640290),
        dec: Angle.Degrees(+33.41576665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2004 AB"},
        {"Henry Draper", "HD 16396"},
        {"Hipparcos Number", "HIP 12328"},
        {"Smithsonian Astrophysical Observation", "SAO 55748"},
        {"Wilson Evans Batten Catalogue", "WEB 2528"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.69120664),
        dec: Angle.Degrees(+33.41911648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7781"},
        {"Smithsonian Astrophysical Observation", "SAO 54886"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.03936515),
        dec: Angle.Degrees(+33.41947137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282197"},
        {"Hipparcos Number", "HIP 21206"},
        {"Smithsonian Astrophysical Observation", "SAO 57300"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.23369857),
        dec: Angle.Degrees(+33.42045081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10903 A"},
        {"Hipparcos Number", "HIP 87773"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.95845088),
        dec: Angle.Degrees(+33.42120836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6866 A"},
        {"Henry Draper", "HD 72280"},
        {"Hipparcos Number", "HIP 41960"},
        {"Renson", "Renson 19970"},
        {"Smithsonian Astrophysical Observation", "SAO 60893"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.29348143),
        dec: Angle.Degrees(+33.43132949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187459"},
        {"Hipparcos Number", "HIP 97485"},
        {"Celescope Catalog", "CEL 4851"},
        {"Geneva Identification System", "GEN# +1.00187459"},
        {"Smithsonian Astrophysical Observation", "SAO 68895"},
        {"Wilson Evans Batten Catalogue", "WEB 17138"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.21083513),
        dec: Angle.Degrees(+33.43729726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199101"},
        {"Hipparcos Number", "HIP 103145"},
        {"Fundamental Katalog 5th Edition", "FK5 3668"},
        {"Geneva Identification System", "GEN# +1.00199101"},
        {"Smithsonian Astrophysical Observation", "SAO 70645"},
        {"Wilson Evans Batten Catalogue", "WEB 18731"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.47461043),
        dec: Angle.Degrees(+33.43780855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42636"},
        {"Smithsonian Astrophysical Observation", "SAO 60982"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.33084286),
        dec: Angle.Degrees(+33.43859797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115781"},
        {"Hipparcos Number", "HIP 64956"},
        {"Geneva Identification System", "GEN# +1.00115781"},
        {"Smithsonian Astrophysical Observation", "SAO 63466"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.71643135),
        dec: Angle.Degrees(+33.43867591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84786"},
        {"Smithsonian Astrophysical Observation", "SAO 65948"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.96400895),
        dec: Angle.Degrees(+33.43968487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105216"},
        {"Hipparcos Number", "HIP 59074"},
        {"Geneva Identification System", "GEN# +1.00105216"},
        {"Smithsonian Astrophysical Observation", "SAO 62842"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.72087149),
        dec: Angle.Degrees(+33.44209615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109010"},
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.27078296),
        dec: Angle.Degrees(+33.44266783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215991"},
        {"Hipparcos Number", "HIP 112625"},
        {"Smithsonian Astrophysical Observation", "SAO 72740"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.15108060),
        dec: Angle.Degrees(+33.44353382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8091 AB"},
        {"Henry Draper", "HD 97488"},
        {"Hipparcos Number", "HIP 54819"},
        {"Smithsonian Astrophysical Observation", "SAO 62456"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.33255389),
        dec: Angle.Degrees(+33.44389533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2990 AB"},
        {"Henry Draper", "HD 25833"},
        {"Hipparcos Number", "HIP 19201"},
        {"Geneva Identification System", "GEN# +1.00025833"},
        {"Smithsonian Astrophysical Observation", "SAO 56973"},
        {"Wilson Evans Batten Catalogue", "WEB 3686"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.73260398),
        dec: Angle.Degrees(+33.44638472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11149 ABC"},
        {"Henry Draper", "HD 166988"},
        {"Hipparcos Number", "HIP 89156"},
        {"Geneva Identification System", "GEN# +1.00166988"},
        {"Smithsonian Astrophysical Observation", "SAO 66733"},
        {"Wilson Evans Batten Catalogue", "WEB 15142"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.93796497),
        dec: Angle.Degrees(+33.44702748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78788"},
        {"Smithsonian Astrophysical Observation", "SAO 65063"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.26596436),
        dec: Angle.Degrees(+33.44730876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190336"},
        {"Hipparcos Number", "HIP 98740"},
        {"Geneva Identification System", "GEN# +1.00190336"},
        {"Smithsonian Astrophysical Observation", "SAO 69317"},
        {"Wilson Evans Batten Catalogue", "WEB 17489"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.82782634),
        dec: Angle.Degrees(+33.44993204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106383"},
        {"Hipparcos Number", "HIP 59673"},
        {"Geneva Identification System", "GEN# +1.00106383"},
        {"Smithsonian Astrophysical Observation", "SAO 62909"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.55847341),
        dec: Angle.Degrees(+33.45014458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99373"},
        {"Hipparcos Number", "HIP 55821"},
        {"Geneva Identification System", "GEN# +1.00099373"},
        {"Smithsonian Astrophysical Observation", "SAO 62551"},
        {"Wilson Evans Batten Catalogue", "WEB 10033"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.60659859),
        dec: Angle.Degrees(+33.45056520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2545"},
        {"Smithsonian Astrophysical Observation", "SAO 53970"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09202697),
        dec: Angle.Degrees(+33.45254750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36354"},
        {"Smithsonian Astrophysical Observation", "SAO 60112"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.23444513),
        dec: Angle.Degrees(+33.45538921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48725"},
        {"Smithsonian Astrophysical Observation", "SAO 61767"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.07654452),
        dec: Angle.Degrees(+33.45988515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51759"},
        {"Smithsonian Astrophysical Observation", "SAO 62129"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.62947883),
        dec: Angle.Degrees(+33.46008636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185119"},
        {"Hipparcos Number", "HIP 96430"},
        {"Celescope Catalog", "CEL 4798"},
        {"Geneva Identification System", "GEN# +1.00185119"},
        {"Smithsonian Astrophysical Observation", "SAO 68565"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.07043223),
        dec: Angle.Degrees(+33.46140331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63274"},
        {"Smithsonian Astrophysical Observation", "SAO 63270"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.49942960),
        dec: Angle.Degrees(+33.46185758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37312"},
        {"Geneva Identification System", "GEN# +9.80090016"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.89961682),
        dec: Angle.Degrees(+33.46309400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80915"},
        {"Hipparcos Number", "HIP 46042"},
        {"Geneva Identification System", "GEN# +1.00080915"},
        {"Smithsonian Astrophysical Observation", "SAO 61442"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84754943),
        dec: Angle.Degrees(+33.46399451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114622"},
        {"Hipparcos Number", "HIP 64336"},
        {"Geneva Identification System", "GEN# +1.00114622"},
        {"Smithsonian Astrophysical Observation", "SAO 63388"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.81125610),
        dec: Angle.Degrees(+33.46593496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92081"},
        {"Smithsonian Astrophysical Observation", "SAO 67358"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.50842459),
        dec: Angle.Degrees(+33.46614152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11504 A"},
        {"Henry Draper", "HD 172044"},
        {"Hipparcos Number", "HIP 91235"},
        {"Celescope Catalog", "CEL 4635"},
        {"Geneva Identification System", "GEN# +1.00172044J"},
        {"Renson", "Renson 48220"},
        {"Smithsonian Astrophysical Observation", "SAO 67164"},
        {"Wilson Evans Batten Catalogue", "WEB 15670"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.15562439),
        dec: Angle.Degrees(+33.46903738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281458"},
        {"Hipparcos Number", "HIP 18759"},
        {"Smithsonian Astrophysical Observation", "SAO 56895"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.27555247),
        dec: Angle.Degrees(+33.47055740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184057"},
        {"Hipparcos Number", "HIP 96009"},
        {"Celescope Catalog", "CEL 4779"},
        {"Geneva Identification System", "GEN# +1.00184057"},
        {"Smithsonian Astrophysical Observation", "SAO 68429"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81736863),
        dec: Angle.Degrees(+33.47077906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89653"},
        {"Hipparcos Number", "HIP 50715"},
        {"Smithsonian Astrophysical Observation", "SAO 61997"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.33143183),
        dec: Angle.Degrees(+33.47235060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2662 A"},
        {"Henry Draper", "HD 278874"},
        {"Hipparcos Number", "HIP 17102"},
        {"Geneva Identification System", "GEN# +1.00278874"},
        {"Smithsonian Astrophysical Observation", "SAO 56609"},
        {"Wilson Evans Batten Catalogue", "WEB 3246"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.95411969),
        dec: Angle.Degrees(+33.47343115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175291"},
        {"Hipparcos Number", "HIP 92696"},
        {"Smithsonian Astrophysical Observation", "SAO 67522"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.31605554),
        dec: Angle.Degrees(+33.47444318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87270"},
        {"Smithsonian Astrophysical Observation", "SAO 66365"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48545643),
        dec: Angle.Degrees(+33.47445709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191064"},
        {"Hipparcos Number", "HIP 99068"},
        {"Geneva Identification System", "GEN# +4.28050004"},
        {"Geneva Identification System 2", "GEN# +1.00191064"},
        {"Smithsonian Astrophysical Observation", "SAO 69426"},
        {"Wilson Evans Batten Catalogue", "WEB 17617"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69178005),
        dec: Angle.Degrees(+33.47663286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35670"},
        {"Hipparcos Number", "HIP 25563"},
        {"Celescope Catalog", "CEL 712"},
        {"Geneva Identification System", "GEN# +1.00035670"},
        {"Smithsonian Astrophysical Observation", "SAO 58060"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.96534891),
        dec: Angle.Degrees(+33.47806837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43645"},
        {"Hipparcos Number", "HIP 29987"},
        {"Smithsonian Astrophysical Observation", "SAO 58972"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.68861205),
        dec: Angle.Degrees(+33.48124295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204154"},
        {"Hipparcos Number", "HIP 105813"},
        {"Smithsonian Astrophysical Observation", "SAO 71326"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.44917212),
        dec: Angle.Degrees(+33.48218509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203286"},
        {"Hipparcos Number", "HIP 105352"},
        {"Smithsonian Astrophysical Observation", "SAO 71220"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.08557280),
        dec: Angle.Degrees(+33.48545852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24252"},
        {"Hipparcos Number", "HIP 18161"},
        {"Smithsonian Astrophysical Observation", "SAO 56780"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.24455230),
        dec: Angle.Degrees(+33.48654437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61140"},
        {"Geneva Identification System", "GEN# +0.03402323"},
        {"Smithsonian Astrophysical Observation", "SAO 63050"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.93646773),
        dec: Angle.Degrees(+33.48733069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224235"},
        {"Hipparcos Number", "HIP 118004"},
        {"Smithsonian Astrophysical Observation", "SAO 73619"},
        {"Wilson Evans Batten Catalogue", "WEB 20751"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.03145096),
        dec: Angle.Degrees(+33.48751672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79317"},
        {"Hipparcos Number", "HIP 45329"},
        {"Smithsonian Astrophysical Observation", "SAO 61345"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.57941486),
        dec: Angle.Degrees(+33.48912372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50080"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.37381608),
        dec: Angle.Degrees(+33.48945642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100554"},
    },
    visualMagnitude: 11.54,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.85185938),
        dec: Angle.Degrees(+33.48989365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5725"},
        {"Smithsonian Astrophysical Observation", "SAO 54527"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.39894960),
        dec: Angle.Degrees(+33.49062581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120894"},
        {"Hipparcos Number", "HIP 67650"},
        {"Geneva Identification System", "GEN# +1.00120894"},
        {"Smithsonian Astrophysical Observation", "SAO 63789"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.90633243),
        dec: Angle.Degrees(+33.49245677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188894"},
        {"Hipparcos Number", "HIP 98094"},
        {"Celescope Catalog", "CEL 4878"},
        {"Smithsonian Astrophysical Observation", "SAO 69106"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.03662784),
        dec: Angle.Degrees(+33.49286683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200892"},
        {"Hipparcos Number", "HIP 104089"},
        {"Smithsonian Astrophysical Observation", "SAO 70886"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.32823154),
        dec: Angle.Degrees(+33.49494876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192225"},
        {"Hipparcos Number", "HIP 99590"},
        {"Geneva Identification System", "GEN# +4.28050042"},
        {"Geneva Identification System 2", "GEN# +1.00192225"},
        {"Smithsonian Astrophysical Observation", "SAO 69604"},
        {"Wilson Evans Batten Catalogue", "WEB 17829"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.16592612),
        dec: Angle.Degrees(+33.49561323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221758"},
        {"Hipparcos Number", "HIP 116355"},
        {"Fundamental Katalog 5th Edition", "FK5 3891"},
        {"Geneva Identification System", "GEN# +1.00221758"},
        {"Smithsonian Astrophysical Observation", "SAO 73345"},
        {"Wilson Evans Batten Catalogue", "WEB 20559"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.65919426),
        dec: Angle.Degrees(+33.49727590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79838"},
        {"Hipparcos Number", "HIP 45572"},
        {"Geneva Identification System", "GEN# +1.00079838"},
        {"Smithsonian Astrophysical Observation", "SAO 61379"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.32476668),
        dec: Angle.Degrees(+33.50098190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63971"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.63956450),
        dec: Angle.Degrees(+33.50410815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2872"},
        {"Smithsonian Astrophysical Observation", "SAO 54026"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.10105003),
        dec: Angle.Degrees(+33.50542716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211811"},
        {"Hipparcos Number", "HIP 110191"},
        {"Smithsonian Astrophysical Observation", "SAO 72230"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.80560396),
        dec: Angle.Degrees(+33.50669810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209890"},
        {"Hipparcos Number", "HIP 109089"},
        {"Geneva Identification System", "GEN# +1.00209890A"},
        {"Wilson Evans Batten Catalogue", "WEB 19613"},
    },
    visualMagnitude: 8.47,
    bvColour: 3.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.47072523),
        dec: Angle.Degrees(+33.50690427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94600"},
        {"Hipparcos Number", "HIP 53426"},
        {"Geneva Identification System", "GEN# +1.00094600"},
        {"Smithsonian Astrophysical Observation", "SAO 62314"},
        {"Wilson Evans Batten Catalogue", "WEB 9695"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.93526063),
        dec: Angle.Degrees(+33.50699574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1824 AB"},
        {"Henry Draper", "HD 14800"},
        {"Hipparcos Number", "HIP 11178"},
        {"Geneva Identification System", "GEN# +1.00014800"},
        {"Smithsonian Astrophysical Observation", "SAO 55512"},
    },
    visualMagnitude: 7.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.97868166),
        dec: Angle.Degrees(+33.50782896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151288"},
        {"Hipparcos Number", "HIP 82003"},
        {"Cincinnati Publication", "Ci 18 2238"},
        {"Geneva Identification System", "GEN# +1.00151288"},
        {"Smithsonian Astrophysical Observation", "SAO 65525"},
        {"Wilson Evans Batten Catalogue", "WEB 13846"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.27657720),
        dec: Angle.Degrees(+33.50829750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 383.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195294"},
        {"Hipparcos Number", "HIP 101061"},
        {"Smithsonian Astrophysical Observation", "SAO 70094"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.30365500),
        dec: Angle.Degrees(+33.50874985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4191"},
        {"Smithsonian Astrophysical Observation", "SAO 54239"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.38022518),
        dec: Angle.Degrees(+33.51081467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103667"},
        {"Smithsonian Astrophysical Observation", "SAO 70776"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.06738706),
        dec: Angle.Degrees(+33.51094395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6392"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53295455),
        dec: Angle.Degrees(+33.51118370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135613"},
        {"Hipparcos Number", "HIP 74639"},
        {"Geneva Identification System", "GEN# +1.00135613"},
        {"Smithsonian Astrophysical Observation", "SAO 64583"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.75728684),
        dec: Angle.Degrees(+33.51273909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80927",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10100 A"},
        {"Henry Draper", "HD 149141"},
        {"Hipparcos Number", "HIP 80927"},
        {"Geneva Identification System", "GEN# +1.00149141"},
        {"Smithsonian Astrophysical Observation", "SAO 65360"},
        {"Wilson Evans Batten Catalogue", "WEB 13688"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87745418),
        dec: Angle.Degrees(+33.51369940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242908"},
        {"Hipparcos Number", "HIP 25103"},
        {"Celescope Catalog", "CEL 645"},
        {"Geneva Identification System", "GEN# +2.18930269"},
        {"New General Catalogue", "NGC 1893 269"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.62209542),
        dec: Angle.Degrees(+33.51401631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62593"},
        {"Geneva Identification System", "GEN# +0.03402360"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38689513),
        dec: Angle.Degrees(+33.51427607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212942"},
        {"Hipparcos Number", "HIP 110840"},
        {"Geneva Identification System", "GEN# +1.00212942"},
        {"Smithsonian Astrophysical Observation", "SAO 72355"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.83550605),
        dec: Angle.Degrees(+33.51442184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87836"},
        {"Hipparcos Number", "HIP 49680"},
        {"Geneva Identification System", "GEN# +1.00087836"},
        {"Smithsonian Astrophysical Observation", "SAO 61885"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.12394139),
        dec: Angle.Degrees(+33.51500167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7871"},
        {"Hipparcos Number", "HIP 6145"},
        {"Geneva Identification System", "GEN# +1.00007871"},
        {"Smithsonian Astrophysical Observation", "SAO 54594"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.72566818),
        dec: Angle.Degrees(+33.51582470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112779"},
        {"Smithsonian Astrophysical Observation", "SAO 72769"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.59105197),
        dec: Angle.Degrees(+33.51687303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27252"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.63968728),
        dec: Angle.Degrees(+33.51773204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76667"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.83969072),
        dec: Angle.Degrees(+33.51790181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182272"},
        {"Hipparcos Number", "HIP 95235"},
        {"Geneva Identification System", "GEN# +1.00182272"},
        {"Smithsonian Astrophysical Observation", "SAO 68215"},
        {"Wilson Evans Batten Catalogue", "WEB 16641"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.63896106),
        dec: Angle.Degrees(+33.51823541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41058"},
        {"Wilson Evans Batten Catalogue", "WEB 7954"},
    },
    visualMagnitude: 9.76,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.67853730),
        dec: Angle.Degrees(+33.51930892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14425"},
        {"Hipparcos Number", "HIP 10918"},
        {"Smithsonian Astrophysical Observation", "SAO 55469"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.13969656),
        dec: Angle.Degrees(+33.52161462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104596"},
        {"Cincinnati Publication", "Ci 20 1265"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.81958941),
        dec: Angle.Degrees(+33.52386183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 503.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20025"},
        {"Hipparcos Number", "HIP 15066"},
        {"Smithsonian Astrophysical Observation", "SAO 56275"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.54278947),
        dec: Angle.Degrees(+33.52710236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108090"},
        {"Hipparcos Number", "HIP 60569"},
        {"Geneva Identification System", "GEN# +1.00108090"},
        {"Smithsonian Astrophysical Observation", "SAO 62991"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.23214886),
        dec: Angle.Degrees(+33.52900406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112171"},
        {"Hipparcos Number", "HIP 62972"},
        {"Fundamental Katalog 5th Edition", "FK5 3027"},
        {"Geneva Identification System", "GEN# +1.00112171"},
        {"Smithsonian Astrophysical Observation", "SAO 63244"},
        {"Wilson Evans Batten Catalogue", "WEB 11166"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.55478295),
        dec: Angle.Degrees(+33.53440353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168178"},
        {"Hipparcos Number", "HIP 89602"},
        {"Smithsonian Astrophysical Observation", "SAO 66827"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.27654409),
        dec: Angle.Degrees(+33.53534449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2514 A"},
        {"Henry Draper", "HD 20995"},
        {"Hipparcos Number", "HIP 15876"},
        {"Geneva Identification System", "GEN# +1.00020995"},
        {"Smithsonian Astrophysical Observation", "SAO 56419"},
        {"Wilson Evans Batten Catalogue", "WEB 3032"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.12366306),
        dec: Angle.Degrees(+33.53601771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 558"},
        {"Hipparcos Number", "HIP 821"},
        {"Smithsonian Astrophysical Observation", "SAO 53688"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51983540),
        dec: Angle.Degrees(+33.53943767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110988"},
        {"Hipparcos Number", "HIP 62278"},
        {"Geneva Identification System", "GEN# +1.00110988"},
        {"Smithsonian Astrophysical Observation", "SAO 63182"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.43297877),
        dec: Angle.Degrees(+33.54141628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13950 AB"},
        {"Hipparcos Number", "HIP 101227"},
        {"Smithsonian Astrophysical Observation", "SAO 70137"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.78217333),
        dec: Angle.Degrees(+33.54267296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211975"},
        {"Hipparcos Number", "HIP 110297"},
        {"Smithsonian Astrophysical Observation", "SAO 72246"},
    },
    visualMagnitude: 9.13,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.11234001),
        dec: Angle.Degrees(+33.54302763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214576"},
        {"Hipparcos Number", "HIP 111796"},
        {"Geneva Identification System", "GEN# +1.00214576"},
        {"Smithsonian Astrophysical Observation", "SAO 72560"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.65902646),
        dec: Angle.Degrees(+33.54497556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282193"},
        {"Hipparcos Number", "HIP 21040"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.66451007),
        dec: Angle.Degrees(+33.54558959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176913"},
        {"Hipparcos Number", "HIP 93367"},
        {"Celescope Catalog", "CEL 4687"},
        {"Geneva Identification System", "GEN# +1.00176913"},
        {"Smithsonian Astrophysical Observation", "SAO 67702"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25869806),
        dec: Angle.Degrees(+33.54708294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190571"},
        {"Hipparcos Number", "HIP 98845"},
        {"Geneva Identification System", "GEN# +1.00190571"},
        {"Smithsonian Astrophysical Observation", "SAO 69353"},
        {"Wilson Evans Batten Catalogue", "WEB 17538"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.09813931),
        dec: Angle.Degrees(+33.55056764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202364"},
        {"Hipparcos Number", "HIP 104837"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56905057),
        dec: Angle.Degrees(+33.55115004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81964"},
        {"Hipparcos Number", "HIP 46581"},
        {"Smithsonian Astrophysical Observation", "SAO 61518"},
        {"Wilson Evans Batten Catalogue", "WEB 8786"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.48158972),
        dec: Angle.Degrees(+33.55159080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196270"},
        {"Hipparcos Number", "HIP 101569"},
        {"Celescope Catalog", "CEL 5120"},
        {"Geneva Identification System", "GEN# +1.00196270"},
        {"Renson", "Renson 54710"},
        {"Smithsonian Astrophysical Observation", "SAO 70234"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.77582404),
        dec: Angle.Degrees(+33.55236417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68563"},
        {"Hipparcos Number", "HIP 40349"},
        {"Smithsonian Astrophysical Observation", "SAO 60662"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.57149004),
        dec: Angle.Degrees(+33.55415300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89447"},
        {"Hipparcos Number", "HIP 50587"},
        {"Smithsonian Astrophysical Observation", "SAO 61986"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.01040065),
        dec: Angle.Degrees(+33.55497050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51613"},
        {"Hipparcos Number", "HIP 33655"},
        {"Fundamental Katalog 5th Edition", "FK5 4632"},
        {"Smithsonian Astrophysical Observation", "SAO 59667"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.87431109),
        dec: Angle.Degrees(+33.55514552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184847"},
        {"Hipparcos Number", "HIP 96324"},
        {"Smithsonian Astrophysical Observation", "SAO 68534"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.77192910),
        dec: Angle.Degrees(+33.55605839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75250"},
        {"Smithsonian Astrophysical Observation", "SAO 64663"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.64791120),
        dec: Angle.Degrees(+33.55611194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225702"},
        {"Hipparcos Number", "HIP 97266"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.51967012),
        dec: Angle.Degrees(+33.55723088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4870"},
        {"Hipparcos Number", "HIP 3978"},
        {"Geneva Identification System", "GEN# +1.00004870"},
        {"Smithsonian Astrophysical Observation", "SAO 54196"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.79363557),
        dec: Angle.Degrees(+33.55794682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69742",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9195 AB"},
        {"Hipparcos Number", "HIP 69742"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.11968646),
        dec: Angle.Degrees(+33.55801087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37138"},
        {"Hipparcos Number", "HIP 26463"},
        {"Geneva Identification System", "GEN# +1.00037138"},
        {"Smithsonian Astrophysical Observation", "SAO 58263"},
        {"Wilson Evans Batten Catalogue", "WEB 5216"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.44081330),
        dec: Angle.Degrees(+33.55915507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93288"},
        {"Hipparcos Number", "HIP 52732"},
        {"Geneva Identification System", "GEN# +1.00093288"},
        {"Smithsonian Astrophysical Observation", "SAO 62249"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.70427950),
        dec: Angle.Degrees(+33.55966885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12008"},
        {"Hipparcos Number", "HIP 9223"},
        {"Geneva Identification System", "GEN# +1.00012008"},
        {"Smithsonian Astrophysical Observation", "SAO 55159"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.64160224),
        dec: Angle.Degrees(+33.56084627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62856"},
        {"Hipparcos Number", "HIP 38004"},
        {"Geneva Identification System", "GEN# +1.00062856"},
        {"Smithsonian Astrophysical Observation", "SAO 60336"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.84291280),
        dec: Angle.Degrees(+33.56452053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105181"},
        {"Hipparcos Number", "HIP 59056"},
        {"Geneva Identification System", "GEN# +1.00105181"},
        {"Smithsonian Astrophysical Observation", "SAO 62839"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.66432136),
        dec: Angle.Degrees(+33.56714070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58161"},
        {"Hipparcos Number", "HIP 36053"},
        {"Smithsonian Astrophysical Observation", "SAO 60067"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.45446691),
        dec: Angle.Degrees(+33.56727903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154029"},
        {"Hipparcos Number", "HIP 83313"},
        {"Fundamental Katalog 5th Edition", "FK5 1446"},
        {"Geneva Identification System", "GEN# +1.00154029"},
        {"Smithsonian Astrophysical Observation", "SAO 65736"},
        {"Wilson Evans Batten Catalogue", "WEB 14081"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.40149728),
        dec: Angle.Degrees(+33.56826922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97243"},
        {"Hipparcos Number", "HIP 54702"},
        {"Smithsonian Astrophysical Observation", "SAO 62442"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.98671722),
        dec: Angle.Degrees(+33.56923179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85850"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.15438506),
        dec: Angle.Degrees(+33.56936266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28198"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.37970323),
        dec: Angle.Degrees(+33.56955409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133431"},
        {"Hipparcos Number", "HIP 73657"},
        {"Geneva Identification System", "GEN# +1.00133431"},
        {"Smithsonian Astrophysical Observation", "SAO 64481"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.85289795),
        dec: Angle.Degrees(+33.57115197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126210"},
        {"Hipparcos Number", "HIP 70331"},
        {"Smithsonian Astrophysical Observation", "SAO 64113"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.85027000),
        dec: Angle.Degrees(+33.57192523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211497"},
        {"Hipparcos Number", "HIP 110011"},
        {"Smithsonian Astrophysical Observation", "SAO 72200"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.22833007),
        dec: Angle.Degrees(+33.57192979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1205"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.76834130),
        dec: Angle.Degrees(+33.57215315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57308"},
        {"Smithsonian Astrophysical Observation", "SAO 62688"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.26026025),
        dec: Angle.Degrees(+33.57471537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63933"},
        {"Hipparcos Number", "HIP 38469"},
        {"Smithsonian Astrophysical Observation", "SAO 60405"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19247769),
        dec: Angle.Degrees(+33.57540718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70212"},
        {"Smithsonian Astrophysical Observation", "SAO 64096"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.47701684),
        dec: Angle.Degrees(+33.57655117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64352"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.86525629),
        dec: Angle.Degrees(+33.57711057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268193"},
        {"Hipparcos Number", "HIP 33989"},
        {"Smithsonian Astrophysical Observation", "SAO 59719"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.79078393),
        dec: Angle.Degrees(+33.57815772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125727"},
        {"Hipparcos Number", "HIP 70082"},
        {"Smithsonian Astrophysical Observation", "SAO 64080"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.12170107),
        dec: Angle.Degrees(+33.58041111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2767"},
        {"Hipparcos Number", "HIP 2475"},
        {"Geneva Identification System", "GEN# +1.00002767"},
        {"Smithsonian Astrophysical Observation", "SAO 53956"},
        {"Wilson Evans Batten Catalogue", "WEB 451"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.85668759),
        dec: Angle.Degrees(+33.58168169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90875"},
        {"Smithsonian Astrophysical Observation", "SAO 67082"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05852014),
        dec: Angle.Degrees(+33.58449917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53799"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.10875799),
        dec: Angle.Degrees(+33.58458031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204263"},
        {"Hipparcos Number", "HIP 105874"},
        {"Geneva Identification System", "GEN# +1.00204263"},
        {"Smithsonian Astrophysical Observation", "SAO 71340"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.63198924),
        dec: Angle.Degrees(+33.58622008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26311"},
        {"Hipparcos Number", "HIP 19525"},
        {"Fundamental Katalog 5th Edition", "FK5 2300"},
        {"Geneva Identification System", "GEN# +1.00026311"},
        {"Smithsonian Astrophysical Observation", "SAO 57047"},
        {"Wilson Evans Batten Catalogue", "WEB 3741"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.74592506),
        dec: Angle.Degrees(+33.58681380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74605"},
        {"Hipparcos Number", "HIP 43030"},
        {"Smithsonian Astrophysical Observation", "SAO 61041"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.51873817),
        dec: Angle.Degrees(+33.58691458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49547"},
        {"Smithsonian Astrophysical Observation", "SAO 61871"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.75189256),
        dec: Angle.Degrees(+33.58803280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248204"},
        {"Hipparcos Number", "HIP 27646"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.79653868),
        dec: Angle.Degrees(+33.58889924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224000"},
        {"Hipparcos Number", "HIP 117861"},
        {"Smithsonian Astrophysical Observation", "SAO 73601"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.59094053),
        dec: Angle.Degrees(+33.59337579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34257"},
        {"Hipparcos Number", "HIP 24672"},
        {"Celescope Catalog", "CEL 591"},
        {"Geneva Identification System", "GEN# +1.00034257"},
        {"Smithsonian Astrophysical Observation", "SAO 57845"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.39867475),
        dec: Angle.Degrees(+33.59350007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136137"},
        {"Hipparcos Number", "HIP 74858"},
        {"Geneva Identification System", "GEN# +1.00136137"},
        {"Smithsonian Astrophysical Observation", "SAO 64616"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.47108903),
        dec: Angle.Degrees(+33.59433085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212315"},
        {"Hipparcos Number", "HIP 110486"},
        {"Geneva Identification System", "GEN# +1.00212315"},
        {"Smithsonian Astrophysical Observation", "SAO 72280"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.70795336),
        dec: Angle.Degrees(+33.59587760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39392"},
        {"Geneva Identification System", "GEN# +6.20030249"},
        {"Wilson Evans Batten Catalogue", "WEB 7710"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.79732463),
        dec: Angle.Degrees(+33.59621305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282669"},
        {"Hipparcos Number", "HIP 23330"},
        {"Smithsonian Astrophysical Observation", "SAO 57571"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.28138789),
        dec: Angle.Degrees(+33.59776326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41269"},
        {"Hipparcos Number", "HIP 28861"},
        {"Geneva Identification System", "GEN# +1.00041269"},
        {"Renson", "Renson 11030"},
        {"Smithsonian Astrophysical Observation", "SAO 58727"},
        {"Wilson Evans Batten Catalogue", "WEB 5647"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.39125755),
        dec: Angle.Degrees(+33.59907187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17735",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2772 A"},
        {"Henry Draper", "HD 23625"},
        {"Henry Draper 2", "HD 23625A"},
        {"Hipparcos Number", "HIP 17735"},
        {"Geneva Identification System", "GEN# +1.00023625"},
        {"Smithsonian Astrophysical Observation", "SAO 56709"},
        {"Wilson Evans Batten Catalogue", "WEB 3392"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.96942782),
        dec: Angle.Degrees(+33.59988271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278543"},
        {"Hipparcos Number", "HIP 15495"},
        {"Cincinnati Publication", "Ci 20 223"},
        {"Geneva Identification System", "GEN# +1.00278543"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.91487149),
        dec: Angle.Degrees(+33.60000952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 404.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -556.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79045"},
        {"Hipparcos Number", "HIP 45196"},
        {"Geneva Identification System", "GEN# +1.00079045"},
        {"Smithsonian Astrophysical Observation", "SAO 61334"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.15614846),
        dec: Angle.Degrees(+33.60018184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85030"},
        {"Hipparcos Number", "HIP 48232"},
        {"Geneva Identification System", "GEN# +1.00085030"},
        {"Smithsonian Astrophysical Observation", "SAO 61706"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.50249393),
        dec: Angle.Degrees(+33.60166774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12889 AB"},
        {"Henry Draper", "HD 186858"},
        {"Hipparcos Number", "HIP 97222"},
        {"Cincinnati Publication", "Ci 18 2579"},
        {"Cincinnati Publication 2", "Ci 20 1164"},
        {"Geneva Identification System", "GEN# +1.00186858J"},
        {"Smithsonian Astrophysical Observation", "SAO 68799"},
        {"Wilson Evans Batten Catalogue", "WEB 17069"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.38968002),
        dec: Angle.Degrees(+33.60305635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -440.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210923"},
        {"Hipparcos Number", "HIP 109677"},
        {"Geneva Identification System", "GEN# +1.00210923"},
        {"Smithsonian Astrophysical Observation", "SAO 72139"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.26348541),
        dec: Angle.Degrees(+33.60319015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14275"},
        {"Hipparcos Number", "HIP 10823"},
        {"Geneva Identification System", "GEN# +1.00014275"},
        {"Smithsonian Astrophysical Observation", "SAO 55449"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.83227191),
        dec: Angle.Degrees(+33.60380736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102909"},
        {"Hipparcos Number", "HIP 57785"},
        {"Geneva Identification System", "GEN# +1.00102909"},
        {"Smithsonian Astrophysical Observation", "SAO 62725"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.74217120),
        dec: Angle.Degrees(+33.60423577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220581"},
        {"Hipparcos Number", "HIP 115575"},
        {"Smithsonian Astrophysical Observation", "SAO 73237"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.16717639),
        dec: Angle.Degrees(+33.60861909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131713"},
        {"Hipparcos Number", "HIP 72923"},
        {"Smithsonian Astrophysical Observation", "SAO 64387"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.55491408),
        dec: Angle.Degrees(+33.60866131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61556"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.19401258),
        dec: Angle.Degrees(+33.61354468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56789"},
        {"Hipparcos Number", "HIP 35526"},
        {"Smithsonian Astrophysical Observation", "SAO 59983"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98252536),
        dec: Angle.Degrees(+33.61442479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103288"},
        {"Hipparcos Number", "HIP 57998"},
        {"Geneva Identification System", "GEN# +1.00103288"},
        {"Smithsonian Astrophysical Observation", "SAO 62744"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.44828339),
        dec: Angle.Degrees(+33.61532169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104687"},
        {"Hipparcos Number", "HIP 58776"},
        {"Geneva Identification System", "GEN# +1.00104687"},
        {"Smithsonian Astrophysical Observation", "SAO 62816"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.82076283),
        dec: Angle.Degrees(+33.61706953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55406"},
        {"Smithsonian Astrophysical Observation", "SAO 62502"},
        {"Wilson Evans Batten Catalogue", "WEB 9969"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.19930139),
        dec: Angle.Degrees(+33.61750735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 618 AB"},
        {"Henry Draper", "HD 4163"},
        {"Hipparcos Number", "HIP 3473"},
        {"Smithsonian Astrophysical Observation", "SAO 54116"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.09567771),
        dec: Angle.Degrees(+33.61810674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40159"},
        {"Smithsonian Astrophysical Observation", "SAO 60633"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.02356387),
        dec: Angle.Degrees(+33.62096770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11965 A"},
        {"Henry Draper", "HD 177109"},
        {"Hipparcos Number", "HIP 93437"},
        {"Celescope Catalog", "CEL 4692"},
        {"Geneva Identification System", "GEN# +1.00177109"},
        {"Smithsonian Astrophysical Observation", "SAO 67721"},
        {"Wilson Evans Batten Catalogue", "WEB 16218"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45153751),
        dec: Angle.Degrees(+33.62125983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201457"},
        {"Hipparcos Number", "HIP 104381"},
        {"Smithsonian Astrophysical Observation", "SAO 70971"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.18890184),
        dec: Angle.Degrees(+33.62210437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54928"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.72514815),
        dec: Angle.Degrees(+33.62473546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19216"},
        {"Hipparcos Number", "HIP 14450"},
        {"Geneva Identification System", "GEN# +1.00019216"},
        {"Renson", "Renson 4800"},
        {"Smithsonian Astrophysical Observation", "SAO 56158"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63411500),
        dec: Angle.Degrees(+33.62526789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101151"},
        {"Hipparcos Number", "HIP 56784"},
        {"Geneva Identification System", "GEN# +1.00101151"},
        {"Smithsonian Astrophysical Observation", "SAO 62635"},
        {"Wilson Evans Batten Catalogue", "WEB 10218"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.63472339),
        dec: Angle.Degrees(+33.62586247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38141"},
        {"Hipparcos Number", "HIP 27123"},
        {"Geneva Identification System", "GEN# +1.00038141"},
        {"Smithsonian Astrophysical Observation", "SAO 58397"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.27801362),
        dec: Angle.Degrees(+33.62646373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117123"},
        {"Hipparcos Number", "HIP 65659"},
        {"Geneva Identification System", "GEN# +1.00117123"},
        {"Smithsonian Astrophysical Observation", "SAO 63552"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.93593991),
        dec: Angle.Degrees(+33.62653608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81677"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.27284092),
        dec: Angle.Degrees(+33.63046695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171066"},
        {"Hipparcos Number", "HIP 90781"},
        {"Smithsonian Astrophysical Observation", "SAO 67067"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.81263464),
        dec: Angle.Degrees(+33.63050421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72711"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.99097619),
        dec: Angle.Degrees(+33.63072320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99416",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13463 BC"},
        {"Henry Draper", "HD 191813"},
        {"Hipparcos Number", "HIP 99416"},
        {"Geneva Identification System", "GEN# +4.28050033J"},
        {"Geneva Identification System 2", "GEN# +1.00191813"},
        {"Smithsonian Astrophysical Observation", "SAO 69554"},
        {"Wilson Evans Batten Catalogue", "WEB 17750"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.65975688),
        dec: Angle.Degrees(+33.63075391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208973"},
        {"Hipparcos Number", "HIP 108531"},
        {"Geneva Identification System", "GEN# +1.00208973"},
        {"Smithsonian Astrophysical Observation", "SAO 71910"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.79798063),
        dec: Angle.Degrees(+33.63076277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278990"},
        {"Hipparcos Number", "HIP 17571"},
        {"Geneva Identification System", "GEN# +1.00278990"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.45141022),
        dec: Angle.Degrees(+33.63221953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106305"},
        {"Cincinnati Publication", "Ci 20 1291"},
        {"Smithsonian Astrophysical Observation", "SAO 71429"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.95729320),
        dec: Angle.Degrees(+33.63334974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 419.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2472"},
        {"Hipparcos Number", "HIP 2249"},
        {"Smithsonian Astrophysical Observation", "SAO 53924"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.15373774),
        dec: Angle.Degrees(+33.63402399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99409",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13463 A"},
        {"Henry Draper", "HD 191812"},
        {"Hipparcos Number", "HIP 99409"},
        {"Celescope Catalog", "CEL 4957"},
        {"Geneva Identification System", "GEN# +4.28050031"},
        {"Geneva Identification System 2", "GEN# +1.00191812"},
        {"Smithsonian Astrophysical Observation", "SAO 69553"},
        {"Wilson Evans Batten Catalogue", "WEB 17749"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.64636607),
        dec: Angle.Degrees(+33.63408928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278933"},
        {"Hipparcos Number", "HIP 17177"},
        {"Smithsonian Astrophysical Observation", "SAO 56624"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.18631201),
        dec: Angle.Degrees(+33.63462814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141679"},
        {"Hipparcos Number", "HIP 77469"},
        {"Smithsonian Astrophysical Observation", "SAO 64924"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.27042719),
        dec: Angle.Degrees(+33.63517135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281621"},
        {"Hipparcos Number", "HIP 19337"},
        {"Cincinnati Publication", "Ci 20 281"},
        {"Geneva Identification System", "GEN# +9.80038026"},
        {"Geneva Identification System 2", "GEN# +6.10010162"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.15429045),
        dec: Angle.Degrees(+33.63673008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 524.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87037"},
        {"Smithsonian Astrophysical Observation", "SAO 66327"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.76370948),
        dec: Angle.Degrees(+33.63790561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46840"},
        {"Hipparcos Number", "HIP 31616"},
        {"Smithsonian Astrophysical Observation", "SAO 59295"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.25758176),
        dec: Angle.Degrees(+33.63806085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282495"},
        {"Hipparcos Number", "HIP 22612"},
        {"Smithsonian Astrophysical Observation", "SAO 57462"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.97708959),
        dec: Angle.Degrees(+33.64120201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3321"},
        {"Hipparcos Number", "HIP 2868"},
        {"Smithsonian Astrophysical Observation", "SAO 54023"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.09296306),
        dec: Angle.Degrees(+33.64431368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94728"},
        {"Hipparcos Number", "HIP 53488"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.13250176),
        dec: Angle.Degrees(+33.64577448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83909"},
        {"Smithsonian Astrophysical Observation", "SAO 65825"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.23510409),
        dec: Angle.Degrees(+33.64586882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35214"},
        {"Hipparcos Number", "HIP 25296"},
        {"Geneva Identification System", "GEN# +1.00035214"},
        {"Smithsonian Astrophysical Observation", "SAO 57986"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.17156035),
        dec: Angle.Degrees(+33.64851022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178353"},
        {"Hipparcos Number", "HIP 93852"},
        {"Geneva Identification System", "GEN# +1.00178353"},
        {"Smithsonian Astrophysical Observation", "SAO 67826"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.70921955),
        dec: Angle.Degrees(+33.64879771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76731"},
        {"Hipparcos Number", "HIP 44117"},
        {"Smithsonian Astrophysical Observation", "SAO 61167"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.77540518),
        dec: Angle.Degrees(+33.65136640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42962"},
        {"Smithsonian Astrophysical Observation", "SAO 61030"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.35520472),
        dec: Angle.Degrees(+33.65304044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 545"},
        {"Smithsonian Astrophysical Observation", "SAO 53644"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.66031971),
        dec: Angle.Degrees(+33.65427137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82087"},
        {"Hipparcos Number", "HIP 46652"},
        {"Fundamental Katalog 5th Edition", "FK5 2755"},
        {"Geneva Identification System", "GEN# +1.00082087"},
        {"Smithsonian Astrophysical Observation", "SAO 61529"},
        {"Wilson Evans Batten Catalogue", "WEB 8802"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.68013936),
        dec: Angle.Degrees(+33.65582773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117981"},
        {"Hipparcos Number", "HIP 66128"},
        {"Geneva Identification System", "GEN# +1.00117981"},
        {"Smithsonian Astrophysical Observation", "SAO 63605"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.34418613),
        dec: Angle.Degrees(+33.65769805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9853"},
        {"Hipparcos Number", "HIP 7522"},
        {"Geneva Identification System", "GEN# +1.00009853"},
        {"Smithsonian Astrophysical Observation", "SAO 54836"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.21175445),
        dec: Angle.Degrees(+33.66008184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66370"},
        {"Hipparcos Number", "HIP 39501"},
        {"Geneva Identification System", "GEN# +1.00066370"},
        {"Smithsonian Astrophysical Observation", "SAO 60542"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.11298945),
        dec: Angle.Degrees(+33.66332863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226111"},
        {"Hipparcos Number", "HIP 97652"},
        {"Geneva Identification System", "GEN# +1.00226111"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69678659),
        dec: Angle.Degrees(+33.66398959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13658"},
        {"Smithsonian Astrophysical Observation", "SAO 56011"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.96737717),
        dec: Angle.Degrees(+33.66585416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117262"},
        {"Hipparcos Number", "HIP 65744"},
        {"Geneva Identification System", "GEN# +1.00117262"},
        {"Smithsonian Astrophysical Observation", "SAO 63558"},
        {"Wilson Evans Batten Catalogue", "WEB 11636"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.14961299),
        dec: Angle.Degrees(+33.66727624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57726"},
        {"Hipparcos Number", "HIP 35890"},
        {"Smithsonian Astrophysical Observation", "SAO 60046"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.98369147),
        dec: Angle.Degrees(+33.66768053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2625 AB"},
        {"Henry Draper", "HD 22160"},
        {"Hipparcos Number", "HIP 16744"},
        {"Smithsonian Astrophysical Observation", "SAO 56564"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.84530676),
        dec: Angle.Degrees(+33.67636618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128625"},
        {"Hipparcos Number", "HIP 71485"},
        {"Smithsonian Astrophysical Observation", "SAO 64238"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.28055530),
        dec: Angle.Degrees(+33.67829141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47016"},
        {"Smithsonian Astrophysical Observation", "SAO 61577"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.73547885),
        dec: Angle.Degrees(+33.67873102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1701"},
        {"Smithsonian Astrophysical Observation", "SAO 53834"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.34291628),
        dec: Angle.Degrees(+33.67998105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108634"},
        {"Cincinnati Publication", "Ci 18 2868"},
        {"Smithsonian Astrophysical Observation", "SAO 71934"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.11717310),
        dec: Angle.Degrees(+33.68000695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 712"},
        {"Hipparcos Number", "HIP 935"},
        {"Smithsonian Astrophysical Observation", "SAO 53710"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89839266),
        dec: Angle.Degrees(+33.68029254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51000"},
        {"Hipparcos Number", "HIP 33421"},
        {"Geneva Identification System", "GEN# +1.00051000"},
        {"Smithsonian Astrophysical Observation", "SAO 59631"},
        {"Wilson Evans Batten Catalogue", "WEB 6717"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.25223594),
        dec: Angle.Degrees(+33.68103629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191589"},
        {"Hipparcos Number", "HIP 99312"},
        {"Geneva Identification System", "GEN# +4.28050018"},
        {"Geneva Identification System 2", "GEN# +1.00191589"},
        {"Smithsonian Astrophysical Observation", "SAO 69522"},
        {"Wilson Evans Batten Catalogue", "WEB 17712"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.38742532),
        dec: Angle.Degrees(+33.68162267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9126 AB"},
        {"Hipparcos Number", "HIP 69102"},
        {"Smithsonian Astrophysical Observation", "SAO 63952"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.17807705),
        dec: Angle.Degrees(+33.68248483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91141"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.88379692),
        dec: Angle.Degrees(+33.68315755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172742"},
        {"Hipparcos Number", "HIP 91563"},
        {"Geneva Identification System", "GEN# +1.00172742"},
        {"Smithsonian Astrophysical Observation", "SAO 67234"},
        {"Wilson Evans Batten Catalogue", "WEB 15743"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08748592),
        dec: Angle.Degrees(+33.68467018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50057"},
        {"Hipparcos Number", "HIP 33032"},
        {"Smithsonian Astrophysical Observation", "SAO 59572"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.23630297),
        dec: Angle.Degrees(+33.68473331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71389"},
        {"Hipparcos Number", "HIP 41548"},
        {"Smithsonian Astrophysical Observation", "SAO 60840"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.08550023),
        dec: Angle.Degrees(+33.68532875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281452"},
        {"Hipparcos Number", "HIP 18920"},
        {"Geneva Identification System", "GEN# +1.00281452"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.82904539),
        dec: Angle.Degrees(+33.68593366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101459"},
        {"Hipparcos Number", "HIP 56959"},
        {"Geneva Identification System", "GEN# +1.00101459"},
        {"Smithsonian Astrophysical Observation", "SAO 62651"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.15182829),
        dec: Angle.Degrees(+33.68619132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192516"},
        {"Hipparcos Number", "HIP 99728"},
        {"Geneva Identification System", "GEN# +1.00192516"},
        {"Smithsonian Astrophysical Observation", "SAO 69654"},
        {"Wilson Evans Batten Catalogue", "WEB 17896"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.53879368),
        dec: Angle.Degrees(+33.68626866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204038"},
        {"Hipparcos Number", "HIP 105739"},
        {"Geneva Identification System", "GEN# +1.00204038"},
        {"Renson", "Renson 56830"},
        {"Smithsonian Astrophysical Observation", "SAO 71307"},
        {"Wilson Evans Batten Catalogue", "WEB 19191"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.25149510),
        dec: Angle.Degrees(+33.68754076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225435"},
        {"Hipparcos Number", "HIP 96926"},
        {"Smithsonian Astrophysical Observation", "SAO 68719"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.53893288),
        dec: Angle.Degrees(+33.68772619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110501"},
        {"Hipparcos Number", "HIP 61995"},
        {"Fundamental Katalog 5th Edition", "FK5 3014"},
        {"Geneva Identification System", "GEN# +1.00110501"},
        {"Smithsonian Astrophysical Observation", "SAO 63146"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.57453819),
        dec: Angle.Degrees(+33.68883919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202198"},
        {"Hipparcos Number", "HIP 104747"},
        {"Smithsonian Astrophysical Observation", "SAO 71077"},
        {"Wilson Evans Batten Catalogue", "WEB 19054"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.31391594),
        dec: Angle.Degrees(+33.69310360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33145",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5544 AB"},
        {"Henry Draper", "HD 50298"},
        {"Hipparcos Number", "HIP 33145"},
        {"Smithsonian Astrophysical Observation", "SAO 59593"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.52233431),
        dec: Angle.Degrees(+33.69443023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4224"},
        {"Hipparcos Number", "HIP 3528"},
        {"Smithsonian Astrophysical Observation", "SAO 54123"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.24920753),
        dec: Angle.Degrees(+33.69454776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 161"},
        {"Smithsonian Astrophysical Observation", "SAO 73700"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51248009),
        dec: Angle.Degrees(+33.69599071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80279"},
        {"Smithsonian Astrophysical Observation", "SAO 65268"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.81132696),
        dec: Angle.Degrees(+33.69683704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57559"},
        {"Hipparcos Number", "HIP 35826"},
        {"Smithsonian Astrophysical Observation", "SAO 60033"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.82649452),
        dec: Angle.Degrees(+33.69736238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12546"},
        {"Hipparcos Number", "HIP 9636"},
        {"Geneva Identification System", "GEN# +1.00012546"},
        {"Smithsonian Astrophysical Observation", "SAO 55234"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.96080514),
        dec: Angle.Degrees(+33.69812134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221380"},
        {"Hipparcos Number", "HIP 116108"},
        {"Smithsonian Astrophysical Observation", "SAO 73315"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.88489318),
        dec: Angle.Degrees(+33.69848437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153436"},
        {"Hipparcos Number", "HIP 83050"},
        {"Geneva Identification System", "GEN# +1.00153436"},
        {"Smithsonian Astrophysical Observation", "SAO 65684"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.55361640),
        dec: Angle.Degrees(+33.70065572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174530"},
        {"Hipparcos Number", "HIP 92359"},
        {"Smithsonian Astrophysical Observation", "SAO 67427"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.34993872),
        dec: Angle.Degrees(+33.70082487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57624",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8312 AB"},
        {"Hipparcos Number", "HIP 57624"},
        {"Geneva Identification System", "GEN# +0.03402259J"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.23228466),
        dec: Angle.Degrees(+33.70161729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147767"},
        {"Hipparcos Number", "HIP 80214"},
        {"Geneva Identification System", "GEN# +1.00147767"},
        {"Smithsonian Astrophysical Observation", "SAO 65259"},
        {"Wilson Evans Batten Catalogue", "WEB 13579"},
    },
    visualMagnitude: 5.40,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.62175969),
        dec: Angle.Degrees(+33.70335685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14649"},
        {"Hipparcos Number", "HIP 11086"},
        {"Smithsonian Astrophysical Observation", "SAO 55500"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.68802096),
        dec: Angle.Degrees(+33.70358122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134352"},
        {"Hipparcos Number", "HIP 74080"},
        {"Smithsonian Astrophysical Observation", "SAO 64515"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.07686712),
        dec: Angle.Degrees(+33.70648134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261309"},
        {"Hipparcos Number", "HIP 31913"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.04047060),
        dec: Angle.Degrees(+33.70750976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197261"},
        {"Hipparcos Number", "HIP 102100"},
        {"Smithsonian Astrophysical Observation", "SAO 70374"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.36394556),
        dec: Angle.Degrees(+33.70940273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57921"},
        {"Smithsonian Astrophysical Observation", "SAO 62740"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19273719),
        dec: Angle.Degrees(+33.70972085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261308"},
        {"Hipparcos Number", "HIP 31910"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.03210209),
        dec: Angle.Degrees(+33.71116946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6230 A"},
        {"Henry Draper", "HD 60987"},
        {"Henry Draper 2", "HD 60987A"},
        {"Hipparcos Number", "HIP 37197"},
        {"Smithsonian Astrophysical Observation", "SAO 60242"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.62604270),
        dec: Angle.Degrees(+33.71147646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105302"},
        {"Hipparcos Number", "HIP 59123"},
        {"Geneva Identification System", "GEN# +1.00105302"},
        {"Smithsonian Astrophysical Observation", "SAO 62847"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.86050601),
        dec: Angle.Degrees(+33.71151345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267009"},
        {"Hipparcos Number", "HIP 33585"},
        {"Smithsonian Astrophysical Observation", "SAO 59654"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.66265792),
        dec: Angle.Degrees(+33.71294270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205798"},
        {"Hipparcos Number", "HIP 106708"},
        {"Geneva Identification System", "GEN# +1.00205798"},
        {"Smithsonian Astrophysical Observation", "SAO 71525"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.22432090),
        dec: Angle.Degrees(+33.71838886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90040"},
        {"Hipparcos Number", "HIP 50935"},
        {"Geneva Identification System", "GEN# +1.00090040"},
        {"Smithsonian Astrophysical Observation", "SAO 62019"},
        {"Wilson Evans Batten Catalogue", "WEB 9317"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.03589322),
        dec: Angle.Degrees(+33.71853542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82938"},
        {"Smithsonian Astrophysical Observation", "SAO 65666"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.23097625),
        dec: Angle.Degrees(+33.71865902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247149"},
        {"Hipparcos Number", "HIP 27198"},
        {"Wilson Evans Batten Catalogue", "WEB 5348"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.47894853),
        dec: Angle.Degrees(+33.71932925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2912",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 513 A"},
        {"Henry Draper", "HD 3369"},
        {"Hipparcos Number", "HIP 2912"},
        {"Fundamental Katalog 5th Edition", "FK5 18"},
        {"Geneva Identification System", "GEN# +1.00003369A"},
        {"Smithsonian Astrophysical Observation", "SAO 54033"},
        {"Wilson Evans Batten Catalogue", "WEB 527"},
    },
    visualMagnitude: 4.34,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.22016239),
        dec: Angle.Degrees(+33.71935227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200630"},
        {"Hipparcos Number", "HIP 103939"},
        {"Smithsonian Astrophysical Observation", "SAO 70844"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90094652),
        dec: Angle.Degrees(+33.71957427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75215"},
        {"Hipparcos Number", "HIP 43353"},
        {"Smithsonian Astrophysical Observation", "SAO 61068"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.46714563),
        dec: Angle.Degrees(+33.72006022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217114"},
        {"Hipparcos Number", "HIP 113393"},
        {"Geneva Identification System", "GEN# +1.00217114"},
        {"Smithsonian Astrophysical Observation", "SAO 72887"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.47534347),
        dec: Angle.Degrees(+33.72056620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1393 AB"},
        {"Henry Draper", "HD 10793"},
        {"Hipparcos Number", "HIP 8252"},
        {"Smithsonian Astrophysical Observation", "SAO 54963"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.55570905),
        dec: Angle.Degrees(+33.72182305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114400"},
        {"Hipparcos Number", "HIP 64235"},
        {"Smithsonian Astrophysical Observation", "SAO 63376"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.48029851),
        dec: Angle.Degrees(+33.72188427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118281",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17149 AB"},
        {"Hipparcos Number", "HIP 118281"},
        {"Geneva Identification System", "GEN# +1.00224635"},
        {"Smithsonian Astrophysical Observation", "SAO 73656"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.87222432),
        dec: Angle.Degrees(+33.72413297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219844"},
        {"Hipparcos Number", "HIP 115092"},
        {"Smithsonian Astrophysical Observation", "SAO 73161"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.66257628),
        dec: Angle.Degrees(+33.72739917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183886"},
        {"Hipparcos Number", "HIP 95908"},
        {"Fundamental Katalog 5th Edition", "FK5 5716"},
        {"Smithsonian Astrophysical Observation", "SAO 68402"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.57219895),
        dec: Angle.Degrees(+33.72851303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12913 A"},
        {"Henry Draper", "HD 187013"},
        {"Hipparcos Number", "HIP 97295"},
        {"Cincinnati Publication", "Ci 20 1167"},
        {"Geneva Identification System", "GEN# +1.00187013"},
        {"Smithsonian Astrophysical Observation", "SAO 68827"},
        {"Wilson Evans Batten Catalogue", "WEB 17093"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.60659960),
        dec: Angle.Degrees(+33.72868813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -448.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71495"},
        {"Hipparcos Number", "HIP 41610"},
        {"Geneva Identification System", "GEN# +1.00071495"},
        {"Smithsonian Astrophysical Observation", "SAO 60842"},
        {"Wilson Evans Batten Catalogue", "WEB 8027"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.23610453),
        dec: Angle.Degrees(+33.72873647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26032"},
        {"Hipparcos Number", "HIP 19336"},
        {"Geneva Identification System", "GEN# +1.00026032"},
        {"Smithsonian Astrophysical Observation", "SAO 57009"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.15280414),
        dec: Angle.Degrees(+33.72905224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13596 A"},
        {"Henry Draper", "HD 192787"},
        {"Hipparcos Number", "HIP 99841"},
        {"Geneva Identification System", "GEN# +1.00192787"},
        {"Smithsonian Astrophysical Observation", "SAO 69701"},
        {"Wilson Evans Batten Catalogue", "WEB 17948"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84913091),
        dec: Angle.Degrees(+33.72937020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60171"},
        {"Geneva Identification System", "GEN# +0.03402306"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.08417741),
        dec: Angle.Degrees(+33.73191522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101262"},
        {"Geneva Identification System", "GEN# +0.03303936"},
        {"Smithsonian Astrophysical Observation", "SAO 70148"},
        {"Wilson Evans Batten Catalogue", "WEB 18295"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.88321781),
        dec: Angle.Degrees(+33.77583031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15798 A"},
        {"Henry Draper", "HD 211419"},
        {"Hipparcos Number", "HIP 109961"},
        {"Geneva Identification System", "GEN# +1.00211419"},
        {"Smithsonian Astrophysical Observation", "SAO 72193"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.07225883),
        dec: Angle.Degrees(+33.73220954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145224"},
        {"Hipparcos Number", "HIP 79068"},
        {"Geneva Identification System", "GEN# +1.00145224"},
        {"Smithsonian Astrophysical Observation", "SAO 65104"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.11236719),
        dec: Angle.Degrees(+33.73304650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41251"},
        {"Hipparcos Number", "HIP 28851"},
        {"Renson", "Renson 11026"},
        {"Smithsonian Astrophysical Observation", "SAO 58725"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.34997963),
        dec: Angle.Degrees(+33.73379977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282666"},
        {"Hipparcos Number", "HIP 23269"},
        {"Smithsonian Astrophysical Observation", "SAO 57562"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10077073),
        dec: Angle.Degrees(+33.73428969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37834"},
        {"Smithsonian Astrophysical Observation", "SAO 60317"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.34655409),
        dec: Angle.Degrees(+33.73612901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111996"},
        {"Hipparcos Number", "HIP 62847"},
        {"Geneva Identification System", "GEN# +1.00111996"},
        {"Smithsonian Astrophysical Observation", "SAO 63234"},
        {"Wilson Evans Batten Catalogue", "WEB 11142"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.20299554),
        dec: Angle.Degrees(+33.73757649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248712"},
        {"Hipparcos Number", "HIP 27860"},
        {"Smithsonian Astrophysical Observation", "SAO 58544"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.41571247),
        dec: Angle.Degrees(+33.73770149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118643"},
        {"Hipparcos Number", "HIP 66467"},
        {"Geneva Identification System", "GEN# +1.00118643"},
        {"Smithsonian Astrophysical Observation", "SAO 63649"},
        {"Wilson Evans Batten Catalogue", "WEB 11735"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.40998313),
        dec: Angle.Degrees(+33.73814922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41521"},
        {"Smithsonian Astrophysical Observation", "SAO 60831"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.02475900),
        dec: Angle.Degrees(+33.73869312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200409"},
        {"Hipparcos Number", "HIP 103818"},
        {"Geneva Identification System", "GEN# +1.00200409"},
        {"Smithsonian Astrophysical Observation", "SAO 70813"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.57115986),
        dec: Angle.Degrees(+33.73872579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246435"},
        {"Hipparcos Number", "HIP 26906"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.68085309),
        dec: Angle.Degrees(+33.73896452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279195"},
        {"Hipparcos Number", "HIP 18399"},
        {"Geneva Identification System", "GEN# +1.00279195"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.00748169),
        dec: Angle.Degrees(+33.73946572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221498"},
        {"Hipparcos Number", "HIP 116186"},
        {"Geneva Identification System", "GEN# +1.00221498"},
        {"Smithsonian Astrophysical Observation", "SAO 73327"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.11944982),
        dec: Angle.Degrees(+33.74093441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176775"},
        {"Hipparcos Number", "HIP 93314"},
        {"Smithsonian Astrophysical Observation", "SAO 67689"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.10185041),
        dec: Angle.Degrees(+33.74183466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281705"},
        {"Hipparcos Number", "HIP 19686"},
        {"Smithsonian Astrophysical Observation", "SAO 57073"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.25353765),
        dec: Angle.Degrees(+33.74225407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53314"},
        {"Hipparcos Number", "HIP 34247"},
        {"Geneva Identification System", "GEN# +1.00053314"},
        {"Smithsonian Astrophysical Observation", "SAO 59769"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.49485533),
        dec: Angle.Degrees(+33.74245728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224543"},
        {"Hipparcos Number", "HIP 118225"},
        {"Geneva Identification System", "GEN# +1.00224543"},
        {"Smithsonian Astrophysical Observation", "SAO 73649"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70837992),
        dec: Angle.Degrees(+33.74273019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120530"},
        {"Hipparcos Number", "HIP 67446"},
        {"Geneva Identification System", "GEN# +1.00120530"},
        {"Smithsonian Astrophysical Observation", "SAO 63767"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.33657071),
        dec: Angle.Degrees(+33.74275507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11635"},
        {"Hipparcos Number", "HIP 8927"},
        {"Smithsonian Astrophysical Observation", "SAO 55084"},
        {"Wilson Evans Batten Catalogue", "WEB 1876"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.73300383),
        dec: Angle.Degrees(+33.74565106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71311"},
        {"Cincinnati Publication", "Ci 18 1920"},
        {"Cincinnati Publication 2", "Ci 20 872"},
        {"Geneva Identification System", "GEN# +0.03402541"},
        {"Wilson Evans Batten Catalogue", "WEB 12317"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.74296112),
        dec: Angle.Degrees(+33.74613569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -711.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 243.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185055"},
        {"Hipparcos Number", "HIP 96411"},
        {"Geneva Identification System", "GEN# +1.00185055"},
        {"Smithsonian Astrophysical Observation", "SAO 68557"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.02290851),
        dec: Angle.Degrees(+33.74616239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160180"},
        {"Hipparcos Number", "HIP 86218"},
        {"Geneva Identification System", "GEN# +1.00160180"},
        {"Smithsonian Astrophysical Observation", "SAO 66183"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.28175915),
        dec: Angle.Degrees(+33.74660687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34452"},
        {"Hipparcos Number", "HIP 24799"},
        {"Celescope Catalog", "CEL 603"},
        {"Geneva Identification System", "GEN# +1.00034452"},
        {"Renson", "Renson 8790"},
        {"Smithsonian Astrophysical Observation", "SAO 57884"},
        {"Wilson Evans Batten Catalogue", "WEB 4797"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.75008050),
        dec: Angle.Degrees(+33.74846576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108908"},
        {"Hipparcos Number", "HIP 61039"},
        {"Geneva Identification System", "GEN# +1.00108908"},
        {"Smithsonian Astrophysical Observation", "SAO 63034"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.65384974),
        dec: Angle.Degrees(+33.74906584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104956"},
        {"Hipparcos Number", "HIP 58940"},
        {"Geneva Identification System", "GEN# +1.00104956"},
        {"Smithsonian Astrophysical Observation", "SAO 62831"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.28003837),
        dec: Angle.Degrees(+33.75004307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148995"},
        {"Hipparcos Number", "HIP 80839"},
        {"Smithsonian Astrophysical Observation", "SAO 65348"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.62389061),
        dec: Angle.Degrees(+33.75080007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118701"},
        {"Hipparcos Number", "HIP 66519"},
        {"Geneva Identification System", "GEN# +1.00118701"},
        {"Smithsonian Astrophysical Observation", "SAO 63655"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.52189301),
        dec: Angle.Degrees(+33.75611555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158654"},
        {"Hipparcos Number", "HIP 85556"},
        {"Geneva Identification System", "GEN# +1.00158654"},
        {"Smithsonian Astrophysical Observation", "SAO 66078"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.26382364),
        dec: Angle.Degrees(+33.75670771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7854"},
        {"Hipparcos Number", "HIP 6127"},
        {"Smithsonian Astrophysical Observation", "SAO 54591"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.66520212),
        dec: Angle.Degrees(+33.75703748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105123",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14829 AB"},
        {"Henry Draper", "HD 202863"},
        {"Hipparcos Number", "HIP 105123"},
        {"Smithsonian Astrophysical Observation", "SAO 71168"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.41482272),
        dec: Angle.Degrees(+33.75840883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198682"},
        {"Hipparcos Number", "HIP 102909"},
        {"Smithsonian Astrophysical Observation", "SAO 70573"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.73011975),
        dec: Angle.Degrees(+33.75953253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36448"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50400117),
        dec: Angle.Degrees(+33.75975241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80408"},
        {"Hipparcos Number", "HIP 45822"},
        {"Geneva Identification System", "GEN# +1.00080408"},
        {"Smithsonian Astrophysical Observation", "SAO 61408"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.14475853),
        dec: Angle.Degrees(+33.76072409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68405"},
        {"Geneva Identification System", "GEN# +0.03402477"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.04834282),
        dec: Angle.Degrees(+33.76133079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12436"},
        {"Hipparcos Number", "HIP 9543"},
        {"Geneva Identification System", "GEN# +1.00012436"},
        {"Smithsonian Astrophysical Observation", "SAO 55216"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.66365744),
        dec: Angle.Degrees(+33.76315795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199251"},
        {"Hipparcos Number", "HIP 103242"},
        {"Smithsonian Astrophysical Observation", "SAO 70663"},
        {"Wilson Evans Batten Catalogue", "WEB 18759"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.74054819),
        dec: Angle.Degrees(+33.76402394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4050 A"},
        {"Henry Draper", "HD 35681"},
        {"Hipparcos Number", "HIP 25580"},
        {"Smithsonian Astrophysical Observation", "SAO 58065"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00384487),
        dec: Angle.Degrees(+33.76421211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281619"},
        {"Hipparcos Number", "HIP 19416"},
        {"Smithsonian Astrophysical Observation", "SAO 57022"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.37055436),
        dec: Angle.Degrees(+33.76707032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16790"},
        {"Hipparcos Number", "HIP 12655"},
        {"Smithsonian Astrophysical Observation", "SAO 55802"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.64691760),
        dec: Angle.Degrees(+33.76738602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34364"},
        {"Hipparcos Number", "HIP 24740"},
        {"Celescope Catalog", "CEL 595"},
        {"Geneva Identification System", "GEN# +1.00034364"},
        {"Renson", "Renson 8740"},
        {"Smithsonian Astrophysical Observation", "SAO 57858"},
        {"Wilson Evans Batten Catalogue", "WEB 4787"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.57870341),
        dec: Angle.Degrees(+33.76741903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225653"},
        {"Hipparcos Number", "HIP 97208"},
        {"Geneva Identification System", "GEN# +1.00225653"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.34977026),
        dec: Angle.Degrees(+33.76758888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218742"},
        {"Hipparcos Number", "HIP 114404"},
        {"Fundamental Katalog 5th Edition", "FK5 6045"},
        {"Smithsonian Astrophysical Observation", "SAO 73052"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53690027),
        dec: Angle.Degrees(+33.76790263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84250"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.32801088),
        dec: Angle.Degrees(+33.76855892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52862"},
        {"Smithsonian Astrophysical Observation", "SAO 62261"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.16735106),
        dec: Angle.Degrees(+33.76984203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10684"},
        {"Smithsonian Astrophysical Observation", "SAO 55429"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.37524035),
        dec: Angle.Degrees(+33.77098510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63617"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.58480379),
        dec: Angle.Degrees(+33.77129786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79551",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9979 C"},
        {"Hipparcos Number", "HIP 79551"},
    },
    visualMagnitude: 12.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.48522252),
        dec: Angle.Degrees(+33.77361984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76846"},
        {"Hipparcos Number", "HIP 44172"},
        {"Geneva Identification System", "GEN# +1.00076846"},
        {"Smithsonian Astrophysical Observation", "SAO 61182"},
        {"Wilson Evans Batten Catalogue", "WEB 8484"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.95390947),
        dec: Angle.Degrees(+33.77401624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263563"},
        {"Hipparcos Number", "HIP 32551"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.87268516),
        dec: Angle.Degrees(+33.77636507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28833"},
        {"Hipparcos Number", "HIP 21285"},
        {"Geneva Identification System", "GEN# +1.00028833"},
        {"Smithsonian Astrophysical Observation", "SAO 57310"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.50813517),
        dec: Angle.Degrees(+33.77791783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155371"},
        {"Hipparcos Number", "HIP 83971"},
        {"Geneva Identification System", "GEN# +1.00155371"},
        {"Smithsonian Astrophysical Observation", "SAO 65839"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.46114662),
        dec: Angle.Degrees(+33.77867893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138304"},
        {"Hipparcos Number", "HIP 75895"},
        {"Smithsonian Astrophysical Observation", "SAO 64733"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.52890371),
        dec: Angle.Degrees(+33.77937785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11294"},
        {"Hipparcos Number", "HIP 8665"},
        {"Smithsonian Astrophysical Observation", "SAO 55039"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90804968),
        dec: Angle.Degrees(+33.77939815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77216"},
        {"Smithsonian Astrophysical Observation", "SAO 64884"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.48083179),
        dec: Angle.Degrees(+33.78012201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108120"},
        {"Smithsonian Astrophysical Observation", "SAO 71816"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57530297),
        dec: Angle.Degrees(+33.78020039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111457"},
        {"Hipparcos Number", "HIP 62554"},
        {"Geneva Identification System", "GEN# +1.00111457"},
        {"Smithsonian Astrophysical Observation", "SAO 63206"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.25786896),
        dec: Angle.Degrees(+33.78051637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188484"},
        {"Hipparcos Number", "HIP 97930"},
        {"Geneva Identification System", "GEN# +1.00188484"},
        {"Smithsonian Astrophysical Observation", "SAO 69052"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.54034912),
        dec: Angle.Degrees(+33.78091298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10202"},
        {"Smithsonian Astrophysical Observation", "SAO 55335"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.79453114),
        dec: Angle.Degrees(+33.78173318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168828"},
        {"Hipparcos Number", "HIP 89870"},
        {"Smithsonian Astrophysical Observation", "SAO 66877"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08695414),
        dec: Angle.Degrees(+33.78516709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222939"},
        {"Hipparcos Number", "HIP 117158"},
        {"Smithsonian Astrophysical Observation", "SAO 73475"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.28052441),
        dec: Angle.Degrees(+33.78535686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92932",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11858 A"},
        {"Henry Draper", "HD 175885"},
        {"Hipparcos Number", "HIP 92932"},
        {"Smithsonian Astrophysical Observation", "SAO 67597"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.00699122),
        dec: Angle.Degrees(+33.78556924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121212"},
        {"Hipparcos Number", "HIP 67803"},
        {"Geneva Identification System", "GEN# +1.00121212"},
        {"Smithsonian Astrophysical Observation", "SAO 63811"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.34639448),
        dec: Angle.Degrees(+33.78678774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53000"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.62863079),
        dec: Angle.Degrees(+33.78861945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11858 B"},
        {"Hipparcos Number", "HIP 92933"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.01387964),
        dec: Angle.Degrees(+33.78907755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48894"},
        {"Hipparcos Number", "HIP 32519"},
        {"Geneva Identification System", "GEN# +1.00048894"},
        {"Smithsonian Astrophysical Observation", "SAO 59482"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.79693104),
        dec: Angle.Degrees(+33.79129348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163947"},
        {"Hipparcos Number", "HIP 87908"},
        {"Smithsonian Astrophysical Observation", "SAO 66508"},
        {"Wilson Evans Batten Catalogue", "WEB 14842"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.35086040),
        dec: Angle.Degrees(+33.79281897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15895"},
        {"Hipparcos Number", "HIP 11956"},
        {"Smithsonian Astrophysical Observation", "SAO 55666"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.55919909),
        dec: Angle.Degrees(+33.79282571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151482"},
        {"Hipparcos Number", "HIP 82093"},
        {"Geneva Identification System", "GEN# +1.00151482"},
        {"Smithsonian Astrophysical Observation", "SAO 65542"},
        {"Wilson Evans Batten Catalogue", "WEB 13863"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.54330488),
        dec: Angle.Degrees(+33.79363778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88925"},
        {"Hipparcos Number", "HIP 50294"},
        {"Smithsonian Astrophysical Observation", "SAO 61960"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03942963),
        dec: Angle.Degrees(+33.79402397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75497"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33044928),
        dec: Angle.Degrees(+33.79412024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43692"},
        {"Hipparcos Number", "HIP 30029"},
        {"Geneva Identification System", "GEN# +1.00043692"},
        {"Smithsonian Astrophysical Observation", "SAO 58979"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.78355093),
        dec: Angle.Degrees(+33.79543322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106109"},
        {"Smithsonian Astrophysical Observation", "SAO 71392"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.40546008),
        dec: Angle.Degrees(+33.79546076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184827"},
        {"Hipparcos Number", "HIP 96310"},
        {"Geneva Identification System", "GEN# +1.00184827"},
        {"Smithsonian Astrophysical Observation", "SAO 68529"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.73371739),
        dec: Angle.Degrees(+33.79547347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90277"},
        {"Hipparcos Number", "HIP 51056"},
        {"Geneva Identification System", "GEN# +1.00090277"},
        {"Renson", "Renson 25964"},
        {"Smithsonian Astrophysical Observation", "SAO 62038"},
        {"Wilson Evans Batten Catalogue", "WEB 9333"},
    },
    visualMagnitude: 4.72,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.47861301),
        dec: Angle.Degrees(+33.79626364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152207"},
        {"Hipparcos Number", "HIP 82415"},
        {"Smithsonian Astrophysical Observation", "SAO 65592"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.63722531),
        dec: Angle.Degrees(+33.79760427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85063"},
        {"Smithsonian Astrophysical Observation", "SAO 65996"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.76135122),
        dec: Angle.Degrees(+33.79770031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3940 A"},
        {"Henry Draper", "HD 34925"},
        {"Hipparcos Number", "HIP 25090"},
        {"Celescope Catalog", "CEL 643"},
        {"Geneva Identification System", "GEN# +1.00034925A"},
        {"Geneva Identification System 2", "GEN# +1.00034925J"},
        {"Smithsonian Astrophysical Observation", "SAO 57949"},
        {"Wilson Evans Batten Catalogue", "WEB 4864"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.57538700),
        dec: Angle.Degrees(+33.79840829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2452"},
        {"Hipparcos Number", "HIP 2241"},
        {"Smithsonian Astrophysical Observation", "SAO 53920"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.11553415),
        dec: Angle.Degrees(+33.79896684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147749"},
        {"Hipparcos Number", "HIP 80197"},
        {"Geneva Identification System", "GEN# +1.00147749"},
        {"Smithsonian Astrophysical Observation", "SAO 65257"},
        {"Wilson Evans Batten Catalogue", "WEB 13576"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.58925615),
        dec: Angle.Degrees(+33.79914473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48454"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.19024487),
        dec: Angle.Degrees(+33.79968206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123757"},
        {"Hipparcos Number", "HIP 69106"},
        {"Geneva Identification System", "GEN# +1.00123757"},
        {"Smithsonian Astrophysical Observation", "SAO 63953"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.19100860),
        dec: Angle.Degrees(+33.79984851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25093",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3940 B"},
        {"Hipparcos Number", "HIP 25093"},
        {"Geneva Identification System", "GEN# +1.00034925B"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.58079280),
        dec: Angle.Degrees(+33.80012041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162197"},
        {"Hipparcos Number", "HIP 87152"},
        {"Smithsonian Astrophysical Observation", "SAO 66345"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.08485291),
        dec: Angle.Degrees(+33.80038884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176896"},
        {"Hipparcos Number", "HIP 93354"},
        {"Geneva Identification System", "GEN# +1.00176896"},
        {"Smithsonian Astrophysical Observation", "SAO 67699"},
        {"Wilson Evans Batten Catalogue", "WEB 16186"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.22998992),
        dec: Angle.Degrees(+33.80215041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205270"},
        {"Hipparcos Number", "HIP 106422"},
        {"Smithsonian Astrophysical Observation", "SAO 71457"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.33610269),
        dec: Angle.Degrees(+33.80233904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198860"},
        {"Hipparcos Number", "HIP 103009"},
        {"Smithsonian Astrophysical Observation", "SAO 70605"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.05616260),
        dec: Angle.Degrees(+33.80320867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11927"},
        {"Hipparcos Number", "HIP 9145"},
        {"Smithsonian Astrophysical Observation", "SAO 55144"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.46369151),
        dec: Angle.Degrees(+33.80621904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68145"},
        {"Geneva Identification System", "GEN# +0.03402473"},
        {"Smithsonian Astrophysical Observation", "SAO 63851"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27339801),
        dec: Angle.Degrees(+33.80689907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21402"},
        {"Hipparcos Number", "HIP 16168"},
        {"Geneva Identification System", "GEN# +1.00021402"},
        {"Smithsonian Astrophysical Observation", "SAO 56475"},
        {"Wilson Evans Batten Catalogue", "WEB 3080"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.08616659),
        dec: Angle.Degrees(+33.80769703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213643"},
        {"Hipparcos Number", "HIP 111268"},
        {"Smithsonian Astrophysical Observation", "SAO 72447"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.13193533),
        dec: Angle.Degrees(+33.81419978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8638 AB"},
        {"Henry Draper", "HD 110534"},
        {"Hipparcos Number", "HIP 62018"},
        {"Smithsonian Astrophysical Observation", "SAO 63149"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.66521599),
        dec: Angle.Degrees(+33.81423948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15060 AB"},
        {"Henry Draper", "HD 205052"},
        {"Hipparcos Number", "HIP 106303"},
        {"Smithsonian Astrophysical Observation", "SAO 71430"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.95390629),
        dec: Angle.Degrees(+33.81562809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89055"},
        {"Smithsonian Astrophysical Observation", "SAO 66714"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65002727),
        dec: Angle.Degrees(+33.81583447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79282"},
        {"Hipparcos Number", "HIP 45325"},
        {"Geneva Identification System", "GEN# +1.00079282"},
        {"Smithsonian Astrophysical Observation", "SAO 61342"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.56063302),
        dec: Angle.Degrees(+33.81709344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17555"},
        {"Hipparcos Number", "HIP 13214"},
        {"Smithsonian Astrophysical Observation", "SAO 55921"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.51807539),
        dec: Angle.Degrees(+33.81751348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193703"},
        {"Hipparcos Number", "HIP 100294"},
        {"Geneva Identification System", "GEN# +1.00193703"},
        {"Smithsonian Astrophysical Observation", "SAO 69859"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12715372),
        dec: Angle.Degrees(+33.81785949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10127 A"},
        {"Henry Draper", "HD 149930"},
        {"Hipparcos Number", "HIP 81303"},
        {"Smithsonian Astrophysical Observation", "SAO 65427"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09309520),
        dec: Angle.Degrees(+33.82177264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49140"},
        {"Hipparcos Number", "HIP 32636"},
        {"Geneva Identification System", "GEN# +1.00049140"},
        {"Smithsonian Astrophysical Observation", "SAO 59499"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.11249894),
        dec: Angle.Degrees(+33.82232105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222409"},
        {"Hipparcos Number", "HIP 116794"},
        {"Renson", "Renson 60990"},
        {"Smithsonian Astrophysical Observation", "SAO 73424"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.06236670),
        dec: Angle.Degrees(+33.82367876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56471"},
        {"Geneva Identification System", "GEN# +0.03402231"},
        {"Smithsonian Astrophysical Observation", "SAO 62606"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.67495899),
        dec: Angle.Degrees(+33.82713769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82042"},
        {"Geneva Identification System", "GEN# +0.03402835"},
        {"Smithsonian Astrophysical Observation", "SAO 65530"},
        {"Wilson Evans Batten Catalogue", "WEB 13854"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.38401856),
        dec: Angle.Degrees(+33.83045986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197549"},
        {"Hipparcos Number", "HIP 102261"},
        {"Celescope Catalog", "CEL 5150"},
        {"Geneva Identification System", "GEN# +1.00197549"},
        {"Smithsonian Astrophysical Observation", "SAO 70417"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81036625),
        dec: Angle.Degrees(+33.83154827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53899"},
        {"Hipparcos Number", "HIP 34428"},
        {"Fundamental Katalog 5th Edition", "FK5 2549"},
        {"Geneva Identification System", "GEN# +1.00053899"},
        {"Smithsonian Astrophysical Observation", "SAO 59806"},
        {"Wilson Evans Batten Catalogue", "WEB 6896"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.05532498),
        dec: Angle.Degrees(+33.83245659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15464"},
        {"Hipparcos Number", "HIP 11651"},
        {"Geneva Identification System", "GEN# +1.00015464"},
        {"Smithsonian Astrophysical Observation", "SAO 55611"},
        {"Wilson Evans Batten Catalogue", "WEB 2425"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.56899446),
        dec: Angle.Degrees(+33.83384234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9728"},
        {"Hipparcos Number", "HIP 7439"},
        {"Smithsonian Astrophysical Observation", "SAO 54817"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96030532),
        dec: Angle.Degrees(+33.83565416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221304"},
        {"Hipparcos Number", "HIP 116042"},
        {"Smithsonian Astrophysical Observation", "SAO 73309"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.69612166),
        dec: Angle.Degrees(+33.83574179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111939"},
        {"Hipparcos Number", "HIP 62828"},
        {"Geneva Identification System", "GEN# +1.00111939"},
        {"Smithsonian Astrophysical Observation", "SAO 63229"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.12753361),
        dec: Angle.Degrees(+33.83604882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89390"},
        {"Smithsonian Astrophysical Observation", "SAO 66788"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.62056000),
        dec: Angle.Degrees(+33.83713849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226453"},
        {"Hipparcos Number", "HIP 97954"},
        {"Geneva Identification System", "GEN# +1.00226453"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61389162),
        dec: Angle.Degrees(+33.83808662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78889"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.56244556),
        dec: Angle.Degrees(+33.84249360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50753"},
        {"Smithsonian Astrophysical Observation", "SAO 61999"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.45321031),
        dec: Angle.Degrees(+33.84311893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18505"},
        {"Hipparcos Number", "HIP 13943"},
        {"Smithsonian Astrophysical Observation", "SAO 56060"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.90146625),
        dec: Angle.Degrees(+33.84478398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119446"},
        {"Hipparcos Number", "HIP 66909"},
        {"Geneva Identification System", "GEN# +1.00119446"},
        {"Smithsonian Astrophysical Observation", "SAO 63700"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.68315668),
        dec: Angle.Degrees(+33.84484783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80547"},
        {"Smithsonian Astrophysical Observation", "SAO 65302"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.67230146),
        dec: Angle.Degrees(+33.84502267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3418"},
        {"Cincinnati Publication", "Ci 20 49"},
        {"Cincinnati Publication 2", "Ci 18 90"},
        {"Geneva Identification System", "GEN# +0.03300099"},
        {"Smithsonian Astrophysical Observation", "SAO 54108"},
        {"Wilson Evans Batten Catalogue", "WEB 605"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.88750898),
        dec: Angle.Degrees(+33.84543280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -356.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27730"},
        {"Hipparcos Number", "HIP 20532"},
        {"Geneva Identification System", "GEN# +1.00027730"},
        {"Smithsonian Astrophysical Observation", "SAO 57207"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.99820114),
        dec: Angle.Degrees(+33.84548934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2964"},
        {"Hipparcos Number", "HIP 2603"},
        {"Geneva Identification System", "GEN# +1.00002964"},
        {"Smithsonian Astrophysical Observation", "SAO 53978"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.26409490),
        dec: Angle.Degrees(+33.84610145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117403"},
        {"Smithsonian Astrophysical Observation", "SAO 73518"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.08511526),
        dec: Angle.Degrees(+33.84614251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163992"},
        {"Hipparcos Number", "HIP 87915"},
        {"Smithsonian Astrophysical Observation", "SAO 66510"},
        {"Wilson Evans Batten Catalogue", "WEB 14844"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.38265138),
        dec: Angle.Degrees(+33.84720231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14055"},
        {"Hipparcos Number", "HIP 10670"},
        {"Celescope Catalog", "CEL 245"},
        {"Fundamental Katalog 5th Edition", "FK5 79"},
        {"Geneva Identification System", "GEN# +1.00014055"},
        {"Smithsonian Astrophysical Observation", "SAO 55427"},
        {"Wilson Evans Batten Catalogue", "WEB 2246"},
    },
    visualMagnitude: 4.03,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.32848216),
        dec: Angle.Degrees(+33.84732099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27127"},
        {"Hipparcos Number", "HIP 20083"},
        {"Geneva Identification System", "GEN# +1.00027127"},
        {"Smithsonian Astrophysical Observation", "SAO 57140"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.58263565),
        dec: Angle.Degrees(+33.84749730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103070"},
        {"Hipparcos Number", "HIP 57874"},
        {"Geneva Identification System", "GEN# +1.00103070"},
        {"Smithsonian Astrophysical Observation", "SAO 62736"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04729627),
        dec: Angle.Degrees(+33.84780060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76080"},
        {"Hipparcos Number", "HIP 43787"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.77538608),
        dec: Angle.Degrees(+33.84858137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86900"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.33855248),
        dec: Angle.Degrees(+33.85022693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10749"},
        {"Hipparcos Number", "HIP 8214"},
        {"Smithsonian Astrophysical Observation", "SAO 54955"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.44009134),
        dec: Angle.Degrees(+33.85189831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9386"},
        {"Hipparcos Number", "HIP 7216"},
        {"Geneva Identification System", "GEN# +1.00009386"},
        {"Smithsonian Astrophysical Observation", "SAO 54775"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.24052061),
        dec: Angle.Degrees(+33.85281693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63795"},
        {"Hipparcos Number", "HIP 38405"},
        {"Geneva Identification System", "GEN# +1.00063795"},
        {"Renson", "Renson 17600"},
        {"Smithsonian Astrophysical Observation", "SAO 60395"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.01889464),
        dec: Angle.Degrees(+33.85485748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191811"},
        {"Hipparcos Number", "HIP 99415"},
        {"Celescope Catalog", "CEL 4958"},
        {"Geneva Identification System", "GEN# +1.00191811"},
        {"Geneva Identification System 2", "GEN# +4.28050034"},
        {"Smithsonian Astrophysical Observation", "SAO 69555"},
        {"Wilson Evans Batten Catalogue", "WEB 17748"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.65928109),
        dec: Angle.Degrees(+33.85570911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114498"},
        {"Geneva Identification System", "GEN# +0.03304662"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.84381194),
        dec: Angle.Degrees(+33.85612299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14783"},
        {"Hipparcos Number", "HIP 11176"},
        {"Smithsonian Astrophysical Observation", "SAO 55511"},
        {"Wilson Evans Batten Catalogue", "WEB 2347"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.97122892),
        dec: Angle.Degrees(+33.85785267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9979 AB"},
        {"Henry Draper", "HD 146361"},
        {"Hipparcos Number", "HIP 79607"},
        {"Geneva Identification System", "GEN# +1.00146361"},
        {"Smithsonian Astrophysical Observation", "SAO 65165"},
        {"Wilson Evans Batten Catalogue", "WEB 13472"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.67100328),
        dec: Angle.Degrees(+33.85882404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -266.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28172"},
        {"Geneva Identification System", "GEN# +0.03301194"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28602179),
        dec: Angle.Degrees(+33.86011345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203612"},
        {"Hipparcos Number", "HIP 105537"},
        {"Smithsonian Astrophysical Observation", "SAO 71253"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61859226),
        dec: Angle.Degrees(+33.86106888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68321"},
        {"Cincinnati Publication", "Ci 20 825"},
        {"Geneva Identification System", "GEN# +0.03402476"},
        {"Wilson Evans Batten Catalogue", "WEB 11985"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.78925302),
        dec: Angle.Degrees(+33.86197657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -429.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44092"},
        {"Smithsonian Astrophysical Observation", "SAO 61165"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.71671548),
        dec: Angle.Degrees(+33.86293227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278987"},
        {"Hipparcos Number", "HIP 17622"},
        {"Geneva Identification System", "GEN# +1.00278987"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.63191480),
        dec: Angle.Degrees(+33.86555362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14901"},
        {"Hipparcos Number", "HIP 11272"},
        {"Smithsonian Astrophysical Observation", "SAO 55527"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.29177409),
        dec: Angle.Degrees(+33.86676098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197561"},
        {"Hipparcos Number", "HIP 102275"},
        {"Celescope Catalog", "CEL 5151"},
        {"Geneva Identification System", "GEN# +1.00197561"},
        {"Smithsonian Astrophysical Observation", "SAO 70422"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.84848227),
        dec: Angle.Degrees(+33.86868921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64788"},
        {"Smithsonian Astrophysical Observation", "SAO 63441"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.18129244),
        dec: Angle.Degrees(+33.87012437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96690"},
        {"Hipparcos Number", "HIP 54471"},
        {"Smithsonian Astrophysical Observation", "SAO 62423"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.17056662),
        dec: Angle.Degrees(+33.87195353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93754",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12033 AB"},
        {"Hipparcos Number", "HIP 93754"},
        {"Smithsonian Astrophysical Observation", "SAO 67799"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.37853777),
        dec: Angle.Degrees(+33.87274096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65254"},
        {"Hipparcos Number", "HIP 39036"},
        {"Smithsonian Astrophysical Observation", "SAO 60497"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.80263727),
        dec: Angle.Degrees(+33.87342761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72201"},
        {"Smithsonian Astrophysical Observation", "SAO 64314"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51313735),
        dec: Angle.Degrees(+33.87941575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6893"},
        {"Hipparcos Number", "HIP 5465"},
        {"Geneva Identification System", "GEN# +1.00006893"},
        {"Smithsonian Astrophysical Observation", "SAO 54476"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.48702130),
        dec: Angle.Degrees(+33.88142650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78366"},
        {"Hipparcos Number", "HIP 44897"},
        {"Fundamental Katalog 5th Edition", "FK5 2723"},
        {"Geneva Identification System", "GEN# +1.00078366"},
        {"Smithsonian Astrophysical Observation", "SAO 61288"},
        {"Wilson Evans Batten Catalogue", "WEB 8578"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.21335301),
        dec: Angle.Degrees(+33.88249742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40945"},
        {"Hipparcos Number", "HIP 28698"},
        {"Smithsonian Astrophysical Observation", "SAO 58696"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.89785110),
        dec: Angle.Degrees(+33.88258529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95223"},
        {"Cincinnati Publication", "Ci 20 1151"},
        {"Wilson Evans Batten Catalogue", "WEB 16638"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.59106083),
        dec: Angle.Degrees(+33.88324642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 728.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202552"},
        {"Hipparcos Number", "HIP 104961"},
        {"Smithsonian Astrophysical Observation", "SAO 71127"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.90458367),
        dec: Angle.Degrees(+33.88528459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64157"},
    },
    visualMagnitude: 11.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.24323654),
        dec: Angle.Degrees(+33.88628057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80806",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10085 AB"},
        {"Henry Draper", "HD 148909"},
        {"Hipparcos Number", "HIP 80806"},
        {"Smithsonian Astrophysical Observation", "SAO 65340"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.51529786),
        dec: Angle.Degrees(+33.88640741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172570"},
        {"Hipparcos Number", "HIP 91497"},
        {"Smithsonian Astrophysical Observation", "SAO 67216"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.90041685),
        dec: Angle.Degrees(+33.88713815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219589"},
        {"Hipparcos Number", "HIP 114915"},
        {"Smithsonian Astrophysical Observation", "SAO 73132"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.14935337),
        dec: Angle.Degrees(+33.88743881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195102"},
        {"Hipparcos Number", "HIP 100949"},
        {"Celescope Catalog", "CEL 5071"},
        {"Geneva Identification System", "GEN# +1.00195102"},
        {"Smithsonian Astrophysical Observation", "SAO 70063"},
        {"Wilson Evans Batten Catalogue", "WEB 18236"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.01619849),
        dec: Angle.Degrees(+33.88794436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162915"},
        {"Hipparcos Number", "HIP 87441"},
        {"Smithsonian Astrophysical Observation", "SAO 66396"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01275346),
        dec: Angle.Degrees(+33.88823923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214667"},
        {"Hipparcos Number", "HIP 111842"},
        {"Smithsonian Astrophysical Observation", "SAO 72572"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.81597676),
        dec: Angle.Degrees(+33.88950395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86635"},
        {"Smithsonian Astrophysical Observation", "SAO 66267"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.52638075),
        dec: Angle.Degrees(+33.88975034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103691"},
        {"Cincinnati Publication", "Ci 18 2720"},
        {"Smithsonian Astrophysical Observation", "SAO 70784"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.18028085),
        dec: Angle.Degrees(+33.88989968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -320.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4961"},
        {"Hipparcos Number", "HIP 4058"},
        {"Smithsonian Astrophysical Observation", "SAO 54211"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.98788650),
        dec: Angle.Degrees(+33.89003340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125230"},
        {"Hipparcos Number", "HIP 69815"},
        {"Geneva Identification System", "GEN# +1.00125230"},
        {"Smithsonian Astrophysical Observation", "SAO 64047"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.32953386),
        dec: Angle.Degrees(+33.89300364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21662"},
        {"Hipparcos Number", "HIP 16381"},
        {"Smithsonian Astrophysical Observation", "SAO 56506"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.75721304),
        dec: Angle.Degrees(+33.89306007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185501"},
        {"Hipparcos Number", "HIP 96576"},
        {"Geneva Identification System", "GEN# +1.00185501"},
        {"Smithsonian Astrophysical Observation", "SAO 68602"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.49705083),
        dec: Angle.Degrees(+33.89314808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52709"},
        {"Hipparcos Number", "HIP 34043"},
        {"Smithsonian Astrophysical Observation", "SAO 59730"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.93008832),
        dec: Angle.Degrees(+33.89343459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141349"},
        {"Hipparcos Number", "HIP 77365"},
        {"Smithsonian Astrophysical Observation", "SAO 64909"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.89072543),
        dec: Angle.Degrees(+33.89424499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66850B"},
        {"Hipparcos Number", "HIP 39692"},
    },
    visualMagnitude: 12.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.67490053),
        dec: Angle.Degrees(+33.89437251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46289"},
        {"Smithsonian Astrophysical Observation", "SAO 61490"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.59954147),
        dec: Angle.Degrees(+33.89474255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105456"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.39859280),
        dec: Angle.Degrees(+33.89672474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66850"},
        {"Hipparcos Number", "HIP 39693"},
        {"Smithsonian Astrophysical Observation", "SAO 60565"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.68085668),
        dec: Angle.Degrees(+33.89690942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71756"},
        {"Cincinnati Publication", "Ci 18 1934"},
        {"Smithsonian Astrophysical Observation", "SAO 64267"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.16958923),
        dec: Angle.Degrees(+33.89781019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -327.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142845"},
        {"Hipparcos Number", "HIP 77991"},
        {"Smithsonian Astrophysical Observation", "SAO 64972"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.88866067),
        dec: Angle.Degrees(+33.90561153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80869"},
        {"Hipparcos Number", "HIP 46022"},
        {"Geneva Identification System", "GEN# +1.00080869"},
        {"Smithsonian Astrophysical Observation", "SAO 61437"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.79071863),
        dec: Angle.Degrees(+33.90561200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112070"},
        {"Hipparcos Number", "HIP 62899"},
        {"Geneva Identification System", "GEN# +1.00112070"},
        {"Smithsonian Astrophysical Observation", "SAO 63236"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.36516896),
        dec: Angle.Degrees(+33.90661630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59881"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.20370318),
        dec: Angle.Degrees(+33.90684724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110389"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.39002835),
        dec: Angle.Degrees(+33.90706188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45484"},
        {"Smithsonian Astrophysical Observation", "SAO 61370"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.02239004),
        dec: Angle.Degrees(+33.90796016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89904"},
        {"Hipparcos Number", "HIP 50860"},
        {"Fundamental Katalog 5th Edition", "FK5 1267"},
        {"Geneva Identification System", "GEN# +1.00089904"},
        {"Smithsonian Astrophysical Observation", "SAO 62010"},
        {"Wilson Evans Batten Catalogue", "WEB 9306"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77640700),
        dec: Angle.Degrees(+33.90815509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249959"},
        {"Hipparcos Number", "HIP 28423"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.03722974),
        dec: Angle.Degrees(+33.90817069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73685"},
        {"Hipparcos Number", "HIP 42589"},
        {"Smithsonian Astrophysical Observation", "SAO 60976"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.20406034),
        dec: Angle.Degrees(+33.90852176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76571"},
        {"Hipparcos Number", "HIP 44037"},
        {"Smithsonian Astrophysical Observation", "SAO 61159"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.51594785),
        dec: Angle.Degrees(+33.90983666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87446"},
        {"Smithsonian Astrophysical Observation", "SAO 66398"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.02068508),
        dec: Angle.Degrees(+33.91095264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18860"},
        {"Hipparcos Number", "HIP 14196"},
        {"Smithsonian Astrophysical Observation", "SAO 56110"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.76731104),
        dec: Angle.Degrees(+33.91290683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15924"},
        {"Hipparcos Number", "HIP 11981"},
        {"Smithsonian Astrophysical Observation", "SAO 55671"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.63744168),
        dec: Angle.Degrees(+33.91565870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39225"},
        {"Hipparcos Number", "HIP 27778"},
        {"Fundamental Katalog 5th Edition", "FK5 2443"},
        {"Geneva Identification System", "GEN# +1.00039225"},
        {"Smithsonian Astrophysical Observation", "SAO 58528"},
        {"Wilson Evans Batten Catalogue", "WEB 5446"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.16700104),
        dec: Angle.Degrees(+33.91744132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32633"},
        {"Hipparcos Number", "HIP 23733"},
        {"Celescope Catalog", "CEL 530"},
        {"Geneva Identification System", "GEN# +1.00032633"},
        {"Renson", "Renson 8320"},
        {"Smithsonian Astrophysical Observation", "SAO 57631"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53480098),
        dec: Angle.Degrees(+33.91872848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37617"},
        {"Hipparcos Number", "HIP 26774"},
        {"Smithsonian Astrophysical Observation", "SAO 58329"},
        {"Wilson Evans Batten Catalogue", "WEB 5280"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.31285029),
        dec: Angle.Degrees(+33.91895586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191530"},
        {"Hipparcos Number", "HIP 99279"},
        {"Celescope Catalog", "CEL 4949"},
        {"Geneva Identification System", "GEN# +1.00191530"},
        {"Geneva Identification System 2", "GEN# +4.28050016"},
        {"Smithsonian Astrophysical Observation", "SAO 69509"},
        {"Wilson Evans Batten Catalogue", "WEB 17701"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.29906058),
        dec: Angle.Degrees(+33.91994862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157066"},
        {"Hipparcos Number", "HIP 84776"},
        {"Geneva Identification System", "GEN# +1.00157066"},
        {"Smithsonian Astrophysical Observation", "SAO 65945"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.93018339),
        dec: Angle.Degrees(+33.92221175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109683"},
        {"Hipparcos Number", "HIP 61519"},
        {"Geneva Identification System", "GEN# +1.00109683"},
        {"Smithsonian Astrophysical Observation", "SAO 63099"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07083582),
        dec: Angle.Degrees(+33.92275064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5102"},
        {"Hipparcos Number", "HIP 4175"},
        {"Geneva Identification System", "GEN# +1.00005102"},
        {"Smithsonian Astrophysical Observation", "SAO 54234"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.33064532),
        dec: Angle.Degrees(+33.92418096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215336"},
        {"Hipparcos Number", "HIP 112227"},
        {"Smithsonian Astrophysical Observation", "SAO 72671"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.95489934),
        dec: Angle.Degrees(+33.92621478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46514"},
        {"Hipparcos Number", "HIP 31458"},
        {"Smithsonian Astrophysical Observation", "SAO 59261"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.85289970),
        dec: Angle.Degrees(+33.92679168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124697"},
        {"Hipparcos Number", "HIP 69555"},
        {"Smithsonian Astrophysical Observation", "SAO 64014"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.56835288),
        dec: Angle.Degrees(+33.92822703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15127"},
        {"Hipparcos Number", "HIP 11409"},
        {"Geneva Identification System", "GEN# +1.00015127"},
        {"Smithsonian Astrophysical Observation", "SAO 55565"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.75931392),
        dec: Angle.Degrees(+33.92861621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21950",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3397 A"},
        {"Henry Draper", "HD 29785"},
        {"Hipparcos Number", "HIP 21950"},
        {"Smithsonian Astrophysical Observation", "SAO 57387"},
        {"Wilson Evans Batten Catalogue", "WEB 4219"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.77071829),
        dec: Angle.Degrees(+33.92973699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258113"},
        {"Hipparcos Number", "HIP 30982"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.53685232),
        dec: Angle.Degrees(+33.93055590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171009"},
        {"Hipparcos Number", "HIP 90745"},
        {"Geneva Identification System", "GEN# +1.00171009"},
        {"Smithsonian Astrophysical Observation", "SAO 67052"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74020274),
        dec: Angle.Degrees(+33.93263974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85545"},
        {"Hipparcos Number", "HIP 48492"},
        {"Geneva Identification System", "GEN# +1.00085545"},
        {"Smithsonian Astrophysical Observation", "SAO 61741"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.34527533),
        dec: Angle.Degrees(+33.93276561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85614"},
        {"Smithsonian Astrophysical Observation", "SAO 66092"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.42974842),
        dec: Angle.Degrees(+33.93335464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54044"},
        {"Hipparcos Number", "HIP 34497"},
        {"Smithsonian Astrophysical Observation", "SAO 59818"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.21846523),
        dec: Angle.Degrees(+33.93391665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154878"},
        {"Hipparcos Number", "HIP 83730"},
        {"Smithsonian Astrophysical Observation", "SAO 65795"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.68816630),
        dec: Angle.Degrees(+33.93600497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13175",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2150 AB"},
        {"Henry Draper", "HD 17497"},
        {"Hipparcos Number", "HIP 13175"},
        {"Smithsonian Astrophysical Observation", "SAO 55911"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.36116107),
        dec: Angle.Degrees(+33.93625433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6757 AB"},
        {"Henry Draper", "HD 70145"},
        {"Hipparcos Number", "HIP 40966"},
        {"Smithsonian Astrophysical Observation", "SAO 60759"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.40439108),
        dec: Angle.Degrees(+33.93679517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6813"},
        {"Hipparcos Number", "HIP 5416"},
        {"Smithsonian Astrophysical Observation", "SAO 54462"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30596938),
        dec: Angle.Degrees(+33.94155069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193637"},
        {"Hipparcos Number", "HIP 100258"},
        {"Geneva Identification System", "GEN# +1.00193637"},
        {"Renson", "Renson 54040"},
        {"Smithsonian Astrophysical Observation", "SAO 69850"},
        {"Wilson Evans Batten Catalogue", "WEB 18077"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.01407116),
        dec: Angle.Degrees(+33.94305183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59276"},
        {"Smithsonian Astrophysical Observation", "SAO 62867"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.39168013),
        dec: Angle.Degrees(+33.94364846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68612"},
        {"Hipparcos Number", "HIP 40364"},
        {"Smithsonian Astrophysical Observation", "SAO 60667"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.62051080),
        dec: Angle.Degrees(+33.94383645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8666 AB"},
        {"Hipparcos Number", "HIP 62398"},
        {"Geneva Identification System", "GEN# +0.03402357J"},
        {"Smithsonian Astrophysical Observation", "SAO 63192"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.81803137),
        dec: Angle.Degrees(+33.94394175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10742 AB"},
        {"Henry Draper", "HD 161299"},
        {"Hipparcos Number", "HIP 86733"},
        {"Smithsonian Astrophysical Observation", "SAO 66284"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.84539370),
        dec: Angle.Degrees(+33.94487342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181279"},
        {"Hipparcos Number", "HIP 94877"},
        {"Geneva Identification System", "GEN# +1.00181279"},
        {"Smithsonian Astrophysical Observation", "SAO 68108"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.61957752),
        dec: Angle.Degrees(+33.94566039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35653"},
        {"Hipparcos Number", "HIP 25558"},
        {"Geneva Identification System", "GEN# +1.00035653"},
        {"Smithsonian Astrophysical Observation", "SAO 58056"},
        {"Wilson Evans Batten Catalogue", "WEB 4959"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94133395),
        dec: Angle.Degrees(+33.94595318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59798"},
        {"Hipparcos Number", "HIP 36720"},
        {"Smithsonian Astrophysical Observation", "SAO 60170"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.29027258),
        dec: Angle.Degrees(+33.94625670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99533"},
        {"Hipparcos Number", "HIP 55891"},
        {"Smithsonian Astrophysical Observation", "SAO 62560"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.83568780),
        dec: Angle.Degrees(+33.94631790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281451"},
        {"Hipparcos Number", "HIP 18971"},
        {"Geneva Identification System", "GEN# +1.00281451"},
        {"Smithsonian Astrophysical Observation", "SAO 56935"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.97317399),
        dec: Angle.Degrees(+33.94911074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2020 AB"},
        {"Henry Draper", "HD 16511"},
        {"Hipparcos Number", "HIP 12417"},
        {"Smithsonian Astrophysical Observation", "SAO 55761"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.96107240),
        dec: Angle.Degrees(+33.94927259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5608"},
        {"Hipparcos Number", "HIP 4552"},
        {"Fundamental Katalog 5th Edition", "FK5 2061"},
        {"Geneva Identification System", "GEN# +1.00005608"},
        {"Smithsonian Astrophysical Observation", "SAO 54306"},
        {"Wilson Evans Batten Catalogue", "WEB 824"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.55914315),
        dec: Angle.Degrees(+33.95105921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28046"},
        {"Hipparcos Number", "HIP 20767"},
        {"Smithsonian Astrophysical Observation", "SAO 57236"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.74904580),
        dec: Angle.Degrees(+33.95174791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60524"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.10933675),
        dec: Angle.Degrees(+33.95193143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34578"},
        {"Hipparcos Number", "HIP 24879"},
        {"Fundamental Katalog 5th Edition", "FK5 2399"},
        {"Geneva Identification System", "GEN# +1.00034578"},
        {"Smithsonian Astrophysical Observation", "SAO 57906"},
        {"Wilson Evans Batten Catalogue", "WEB 4819"},
    },
    visualMagnitude: 5.05,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00383769),
        dec: Angle.Degrees(+33.95806265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3188 AB"},
        {"Henry Draper", "HD 27786"},
        {"Hipparcos Number", "HIP 20591"},
        {"Geneva Identification System", "GEN# +1.00027786J"},
        {"Smithsonian Astrophysical Observation", "SAO 57216"},
        {"Wilson Evans Batten Catalogue", "WEB 3945"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.15593384),
        dec: Angle.Degrees(+33.95988843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13770"},
        {"Smithsonian Astrophysical Observation", "SAO 56030"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.30513319),
        dec: Angle.Degrees(+33.96044920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58494"},
        {"Geneva Identification System", "GEN# +0.03402278"},
        {"Smithsonian Astrophysical Observation", "SAO 62785"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.94968580),
        dec: Angle.Degrees(+33.96062292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5532 A"},
        {"Henry Draper", "HD 50019"},
        {"Hipparcos Number", "HIP 33018"},
        {"Fundamental Katalog 5th Edition", "FK5 261"},
        {"Geneva Identification System", "GEN# +1.00050019"},
        {"Renson", "Renson 13590"},
        {"Smithsonian Astrophysical Observation", "SAO 59570"},
        {"Wilson Evans Batten Catalogue", "WEB 6646"},
    },
    visualMagnitude: 3.60,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19725030),
        dec: Angle.Degrees(+33.96136985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38949"},
        {"Smithsonian Astrophysical Observation", "SAO 60483"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52981888),
        dec: Angle.Degrees(+33.96184711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38272"},
        {"Smithsonian Astrophysical Observation", "SAO 60370"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.61596676),
        dec: Angle.Degrees(+33.96301915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24226"},
    },
    visualMagnitude: 11.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01778433),
        dec: Angle.Degrees(+33.96304819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255447"},
        {"Hipparcos Number", "HIP 30226"},
        {"Geneva Identification System", "GEN# +1.00255447"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.38887259),
        dec: Angle.Degrees(+33.96433573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29733"},
        {"Hipparcos Number", "HIP 21898"},
        {"Smithsonian Astrophysical Observation", "SAO 57382"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.61216892),
        dec: Angle.Degrees(+33.96485763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17313",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2699 A"},
        {"Henry Draper", "HD 22951"},
        {"Hipparcos Number", "HIP 17313"},
        {"Geneva Identification System", "GEN# +1.00022951A"},
        {"Smithsonian Astrophysical Observation", "SAO 56646"},
        {"Wilson Evans Batten Catalogue", "WEB 3272"},
    },
    visualMagnitude: 4.97,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.59434812),
        dec: Angle.Degrees(+33.96503899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134129"},
        {"Hipparcos Number", "HIP 73975"},
        {"Smithsonian Astrophysical Observation", "SAO 64509"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.77620866),
        dec: Angle.Degrees(+33.96506519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75940"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.65803456),
        dec: Angle.Degrees(+33.96766907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49044"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.10523655),
        dec: Angle.Degrees(+33.96770531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92833",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11834 A"},
        {"Henry Draper", "HD 175635"},
        {"Henry Draper 2", "HD 175635A"},
        {"Hipparcos Number", "HIP 92833"},
        {"Geneva Identification System", "GEN# +1.00175635"},
        {"Smithsonian Astrophysical Observation", "SAO 67566"},
        {"Wilson Evans Batten Catalogue", "WEB 16068"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71883669),
        dec: Angle.Degrees(+33.96858048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102488",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aljanah"},
        {"Aitken", "ADS 14274 A"},
        {"Henry Draper", "HD 197989"},
        {"Hipparcos Number", "HIP 102488"},
        {"Cincinnati Publication", "Ci 20 1229"},
        {"Fundamental Katalog 5th Edition", "FK5 780"},
        {"Geneva Identification System", "GEN# +1.00197989"},
        {"Smithsonian Astrophysical Observation", "SAO 70474"},
        {"Wilson Evans Batten Catalogue", "WEB 18565"},
    },
    visualMagnitude: 2.48,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.55180091),
        dec: Angle.Degrees(+33.96945334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 356.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 330.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192021"},
        {"Hipparcos Number", "HIP 99498"},
        {"Geneva Identification System", "GEN# +4.28050040"},
        {"Geneva Identification System 2", "GEN# +1.00192021"},
        {"Smithsonian Astrophysical Observation", "SAO 69577"},
        {"Wilson Evans Batten Catalogue", "WEB 17791"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.88690261),
        dec: Angle.Degrees(+33.97605121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31381"},
        {"Hipparcos Number", "HIP 23001"},
        {"Geneva Identification System", "GEN# +1.00031381"},
        {"Smithsonian Astrophysical Observation", "SAO 57518"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21545650),
        dec: Angle.Degrees(+33.97716708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12765 AB"},
        {"Henry Draper", "HD 185837"},
        {"Hipparcos Number", "HIP 96724"},
        {"Celescope Catalog", "CEL 4813"},
        {"Geneva Identification System", "GEN# +1.00185837J"},
        {"Smithsonian Astrophysical Observation", "SAO 68654"},
        {"Wilson Evans Batten Catalogue", "WEB 16969"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.93718392),
        dec: Angle.Degrees(+33.97890836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281610"},
        {"Hipparcos Number", "HIP 19364"},
        {"Smithsonian Astrophysical Observation", "SAO 57014"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.22594671),
        dec: Angle.Degrees(+33.97908113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11834 C"},
        {"Henry Draper", "HD 175634"},
        {"Hipparcos Number", "HIP 92829"},
        {"Celescope Catalog", "CEL 4667"},
        {"Geneva Identification System", "GEN# +1.00175634"},
        {"Geneva Identification System 2", "GEN# +1.00175635C"},
        {"Smithsonian Astrophysical Observation", "SAO 67565"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71607310),
        dec: Angle.Degrees(+33.98095111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24832",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3893 A"},
        {"Henry Draper", "HD 34499"},
        {"Hipparcos Number", "HIP 24832"},
        {"Celescope Catalog", "CEL 608"},
        {"Geneva Identification System", "GEN# +1.00034499"},
        {"Smithsonian Astrophysical Observation", "SAO 57893"},
        {"Wilson Evans Batten Catalogue", "WEB 4807"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.84884980),
        dec: Angle.Degrees(+33.98543113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112360",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16247 AB"},
        {"Hipparcos Number", "HIP 112360"},
        {"Smithsonian Astrophysical Observation", "SAO 72690"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.38058115),
        dec: Angle.Degrees(+33.98621510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106780"},
        {"Smithsonian Astrophysical Observation", "SAO 71534"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42873023),
        dec: Angle.Degrees(+33.98770016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30411"},
        {"Hipparcos Number", "HIP 22363"},
        {"Geneva Identification System", "GEN# +1.00030411"},
        {"Smithsonian Astrophysical Observation", "SAO 57438"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.21798829),
        dec: Angle.Degrees(+33.98876438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83717"},
        {"Smithsonian Astrophysical Observation", "SAO 65793"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.65566446),
        dec: Angle.Degrees(+33.99092866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98411"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92739876),
        dec: Angle.Degrees(+33.99110945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120182"},
        {"Hipparcos Number", "HIP 67276"},
        {"Smithsonian Astrophysical Observation", "SAO 63745"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.81998197),
        dec: Angle.Degrees(+33.99123363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69231"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61295298),
        dec: Angle.Degrees(+33.99293734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 922 A"},
        {"Henry Draper", "HD 6625"},
        {"Hipparcos Number", "HIP 5275"},
        {"Smithsonian Astrophysical Observation", "SAO 54439"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.85548953),
        dec: Angle.Degrees(+33.99605036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173548"},
        {"Hipparcos Number", "HIP 91940"},
        {"Smithsonian Astrophysical Observation", "SAO 67311"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12803107),
        dec: Angle.Degrees(+33.99616778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158098"},
        {"Hipparcos Number", "HIP 85303"},
        {"Smithsonian Astrophysical Observation", "SAO 66039"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.47740772),
        dec: Angle.Degrees(+33.99781564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212979"},
        {"Hipparcos Number", "HIP 110858"},
        {"Smithsonian Astrophysical Observation", "SAO 72361"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.90419254),
        dec: Angle.Degrees(+34.00007918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61859"},
        {"Hipparcos Number", "HIP 37580"},
        {"Geneva Identification System", "GEN# +1.00061859"},
        {"Smithsonian Astrophysical Observation", "SAO 60291"},
        {"Wilson Evans Batten Catalogue", "WEB 7430"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.68169569),
        dec: Angle.Degrees(+34.00022479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60226"},
        {"Geneva Identification System", "GEN# +0.03402307"},
        {"Smithsonian Astrophysical Observation", "SAO 62960"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.25732574),
        dec: Angle.Degrees(+34.00103784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80571"},
        {"Smithsonian Astrophysical Observation", "SAO 65306"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.76208256),
        dec: Angle.Degrees(+34.00256649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88559"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.24164271),
        dec: Angle.Degrees(+34.00744951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211265"},
        {"Hipparcos Number", "HIP 109877"},
        {"Smithsonian Astrophysical Observation", "SAO 72173"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.81916284),
        dec: Angle.Degrees(+34.00831164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93764"},
        {"Hipparcos Number", "HIP 52974"},
        {"Smithsonian Astrophysical Observation", "SAO 62274"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.51649381),
        dec: Angle.Degrees(+34.00849388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53686"},
        {"Hipparcos Number", "HIP 34358"},
        {"Geneva Identification System", "GEN# +1.00053686"},
        {"Smithsonian Astrophysical Observation", "SAO 59794"},
        {"Wilson Evans Batten Catalogue", "WEB 6885"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84338053),
        dec: Angle.Degrees(+34.00936165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19152"},
        {"Hipparcos Number", "HIP 14412"},
        {"Smithsonian Astrophysical Observation", "SAO 56151"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.49184830),
        dec: Angle.Degrees(+34.00940532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144270"},
        {"Hipparcos Number", "HIP 78680"},
        {"Smithsonian Astrophysical Observation", "SAO 65053"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.92829258),
        dec: Angle.Degrees(+34.01290010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66861"},
        {"Smithsonian Astrophysical Observation", "SAO 63695"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56198240),
        dec: Angle.Degrees(+34.01467405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47132"},
        {"Smithsonian Astrophysical Observation", "SAO 61592"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.06473966),
        dec: Angle.Degrees(+34.01722479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113921"},
        {"Hipparcos Number", "HIP 63978"},
        {"Geneva Identification System", "GEN# +1.00113921"},
        {"Smithsonian Astrophysical Observation", "SAO 63345"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.65138801),
        dec: Angle.Degrees(+34.01929166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195966"},
        {"Hipparcos Number", "HIP 101424"},
        {"Smithsonian Astrophysical Observation", "SAO 70186"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.31153257),
        dec: Angle.Degrees(+34.02101861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49282"},
        {"Fundamental Katalog 5th Edition", "FK5 4892"},
        {"Smithsonian Astrophysical Observation", "SAO 61832"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.89494877),
        dec: Angle.Degrees(+34.02441927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105963"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.88813387),
        dec: Angle.Degrees(+34.02505987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199357"},
        {"Hipparcos Number", "HIP 103305"},
        {"Smithsonian Astrophysical Observation", "SAO 70673"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.92682785),
        dec: Angle.Degrees(+34.02644756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35647",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5999 AB"},
        {"Henry Draper", "HD 57158"},
        {"Hipparcos Number", "HIP 35647"},
        {"Smithsonian Astrophysical Observation", "SAO 59996"},
    },
    visualMagnitude: 8.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34111710),
        dec: Angle.Degrees(+34.02671089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198122"},
        {"Hipparcos Number", "HIP 102563"},
        {"Geneva Identification System", "GEN# +1.00198122"},
        {"Smithsonian Astrophysical Observation", "SAO 70495"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.76702406),
        dec: Angle.Degrees(+34.02852608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74282"},
        {"Smithsonian Astrophysical Observation", "SAO 64541"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.71076695),
        dec: Angle.Degrees(+34.03241836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67225"},
        {"Hipparcos Number", "HIP 39833"},
        {"Smithsonian Astrophysical Observation", "SAO 60592"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.07900134),
        dec: Angle.Degrees(+34.03268472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14274"},
        {"Hipparcos Number", "HIP 10820"},
        {"Geneva Identification System", "GEN# +1.00014274"},
        {"Smithsonian Astrophysical Observation", "SAO 55448"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.82099191),
        dec: Angle.Degrees(+34.03275429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104179"},
        {"Hipparcos Number", "HIP 58512"},
        {"Geneva Identification System", "GEN# +1.00104179"},
        {"Smithsonian Astrophysical Observation", "SAO 62786"},
        {"Wilson Evans Batten Catalogue", "WEB 10448"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.98918842),
        dec: Angle.Degrees(+34.03466959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94497"},
        {"Hipparcos Number", "HIP 53377"},
        {"Geneva Identification System", "GEN# +1.00094497"},
        {"Smithsonian Astrophysical Observation", "SAO 62310"},
        {"Wilson Evans Batten Catalogue", "WEB 9689"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.74258356),
        dec: Angle.Degrees(+34.03490757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56101"},
        {"Hipparcos Number", "HIP 35252"},
        {"Smithsonian Astrophysical Observation", "SAO 59942"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.26115456),
        dec: Angle.Degrees(+34.03547552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151087"},
        {"Hipparcos Number", "HIP 81911"},
        {"Fundamental Katalog 5th Edition", "FK5 3330"},
        {"Geneva Identification System", "GEN# +1.00151087"},
        {"Smithsonian Astrophysical Observation", "SAO 65512"},
        {"Wilson Evans Batten Catalogue", "WEB 13834"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.96557908),
        dec: Angle.Degrees(+34.03866333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220042"},
        {"Hipparcos Number", "HIP 115236"},
        {"Smithsonian Astrophysical Observation", "SAO 73181"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.10888273),
        dec: Angle.Degrees(+34.03889940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116351"},
        {"Geneva Identification System", "GEN# +0.03304737"},
        {"Smithsonian Astrophysical Observation", "SAO 73343"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.64954516),
        dec: Angle.Degrees(+34.03908946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 360.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 166.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73583"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.61371186),
        dec: Angle.Degrees(+34.04088932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94550"},
        {"Hipparcos Number", "HIP 53404"},
        {"Geneva Identification System", "GEN# +1.00094550"},
        {"Smithsonian Astrophysical Observation", "SAO 62313"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.84432715),
        dec: Angle.Degrees(+34.04363316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60265"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.35391953),
        dec: Angle.Degrees(+34.04543231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219712"},
        {"Hipparcos Number", "HIP 115017"},
        {"Geneva Identification System", "GEN# +1.00219712"},
        {"Smithsonian Astrophysical Observation", "SAO 73149"},
        {"Wilson Evans Batten Catalogue", "WEB 20376"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.42437326),
        dec: Angle.Degrees(+34.04659727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72185"},
        {"Hipparcos Number", "HIP 41912"},
        {"Smithsonian Astrophysical Observation", "SAO 60888"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.18056308),
        dec: Angle.Degrees(+34.04698678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52475"},
        {"Smithsonian Astrophysical Observation", "SAO 62219"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.92536689),
        dec: Angle.Degrees(+34.04704467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112871"},
        {"Hipparcos Number", "HIP 63397"},
        {"Geneva Identification System", "GEN# +1.00112871"},
        {"Smithsonian Astrophysical Observation", "SAO 63282"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.86687943),
        dec: Angle.Degrees(+34.04769562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27027"},
        {"Hipparcos Number", "HIP 20021"},
        {"Smithsonian Astrophysical Observation", "SAO 57130"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.41952207),
        dec: Angle.Degrees(+34.05117582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74914"},
        {"Smithsonian Astrophysical Observation", "SAO 64621"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63950064),
        dec: Angle.Degrees(+34.05125418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100338"},
        {"Hipparcos Number", "HIP 56346"},
        {"Geneva Identification System", "GEN# +1.00100338"},
        {"Smithsonian Astrophysical Observation", "SAO 62598"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.25866523),
        dec: Angle.Degrees(+34.05149175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23962"},
        {"Hipparcos Number", "HIP 17969"},
        {"Smithsonian Astrophysical Observation", "SAO 56737"},
        {"Wilson Evans Batten Catalogue", "WEB 3461"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.62531699),
        dec: Angle.Degrees(+34.05233191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26322"},
        {"Geneva Identification System", "GEN# +2.19600110"},
        {"New General Catalogue", "NGC 1960 110"},
    },
    visualMagnitude: 11.98,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.08826215),
        dec: Angle.Degrees(+34.05485065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64914"},
        {"Hipparcos Number", "HIP 38893"},
        {"Geneva Identification System", "GEN# +1.00064914"},
        {"Smithsonian Astrophysical Observation", "SAO 60473"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.38860165),
        dec: Angle.Degrees(+34.05780301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61059"},
        {"Hipparcos Number", "HIP 37236"},
        {"Smithsonian Astrophysical Observation", "SAO 60245"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.72014667),
        dec: Angle.Degrees(+34.05887785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109581"},
        {"Hipparcos Number", "HIP 61459"},
        {"Fundamental Katalog 5th Edition", "FK5 5109"},
        {"Geneva Identification System", "GEN# +1.00109581"},
        {"Smithsonian Astrophysical Observation", "SAO 63087"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.91234642),
        dec: Angle.Degrees(+34.05925881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1442 A"},
        {"Henry Draper", "HD 11047"},
        {"Hipparcos Number", "HIP 8468"},
        {"Smithsonian Astrophysical Observation", "SAO 54999"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.29506727),
        dec: Angle.Degrees(+34.06001033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119993"},
        {"Hipparcos Number", "HIP 67183"},
        {"Geneva Identification System", "GEN# +1.00119993"},
        {"Smithsonian Astrophysical Observation", "SAO 63731"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.52445528),
        dec: Angle.Degrees(+34.06003005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94056"},
        {"Geneva Identification System", "GEN# +0.03303339"},
        {"Smithsonian Astrophysical Observation", "SAO 67872"},
        {"Wilson Evans Batten Catalogue", "WEB 16375"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.22497194),
        dec: Angle.Degrees(+34.06211485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65202"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.43609044),
        dec: Angle.Degrees(+34.06211768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117980"},
        {"Hipparcos Number", "HIP 66145"},
        {"Geneva Identification System", "GEN# +1.00117980"},
        {"Smithsonian Astrophysical Observation", "SAO 63607"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.38219369),
        dec: Angle.Degrees(+34.06354252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262189"},
        {"Hipparcos Number", "HIP 32168"},
        {"Smithsonian Astrophysical Observation", "SAO 59403"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.75502023),
        dec: Angle.Degrees(+34.06420167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107727"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.34588961),
        dec: Angle.Degrees(+34.06487123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217241"},
        {"Hipparcos Number", "HIP 113487"},
        {"Smithsonian Astrophysical Observation", "SAO 72900"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.74561705),
        dec: Angle.Degrees(+34.06690504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222328"},
        {"Hipparcos Number", "HIP 116741"},
        {"Smithsonian Astrophysical Observation", "SAO 73413"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.88412943),
        dec: Angle.Degrees(+34.06815766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61436"},
        {"Wilson Evans Batten Catalogue", "WEB 10938"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.83231321),
        dec: Angle.Degrees(+34.06841716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206604"},
        {"Hipparcos Number", "HIP 107161"},
        {"Smithsonian Astrophysical Observation", "SAO 71622"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.59467258),
        dec: Angle.Degrees(+34.06903735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197642"},
        {"Hipparcos Number", "HIP 102319"},
        {"Smithsonian Astrophysical Observation", "SAO 70432"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.96805461),
        dec: Angle.Degrees(+34.07070185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151936"},
        {"Hipparcos Number", "HIP 82305"},
        {"Geneva Identification System", "GEN# +1.00151936"},
        {"Smithsonian Astrophysical Observation", "SAO 65573"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.25386509),
        dec: Angle.Degrees(+34.07166612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104144"},
        {"Smithsonian Astrophysical Observation", "SAO 70905"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.49673768),
        dec: Angle.Degrees(+34.07249022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81241"},
        {"Smithsonian Astrophysical Observation", "SAO 65415"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.88414774),
        dec: Angle.Degrees(+34.07656106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184484"},
        {"Hipparcos Number", "HIP 96174"},
        {"Celescope Catalog", "CEL 4784"},
        {"Geneva Identification System", "GEN# +1.00184484"},
        {"Smithsonian Astrophysical Observation", "SAO 68487"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.32925456),
        dec: Angle.Degrees(+34.07725571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39612"},
        {"Wilson Evans Batten Catalogue", "WEB 7740"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.42511082),
        dec: Angle.Degrees(+34.07811431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92000"},
        {"Hipparcos Number", "HIP 52032"},
        {"Smithsonian Astrophysical Observation", "SAO 62167"},
        {"Wilson Evans Batten Catalogue", "WEB 9489"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.46782433),
        dec: Angle.Degrees(+34.07861018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48407"},
        {"Smithsonian Astrophysical Observation", "SAO 61723"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.03860225),
        dec: Angle.Degrees(+34.08314017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15939"},
        {"Hipparcos Number", "HIP 12004"},
        {"Geneva Identification System", "GEN# +1.00015939"},
        {"Smithsonian Astrophysical Observation", "SAO 55672"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.67965170),
        dec: Angle.Degrees(+34.08417169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7520 A"},
        {"Henry Draper", "HD 84870"},
        {"Hipparcos Number", "HIP 48164"},
        {"Smithsonian Astrophysical Observation", "SAO 61697"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.26194139),
        dec: Angle.Degrees(+34.08552991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177698"},
        {"Hipparcos Number", "HIP 93658"},
        {"Smithsonian Astrophysical Observation", "SAO 67771"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.07154019),
        dec: Angle.Degrees(+34.08697895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9435 AB"},
        {"Henry Draper", "HD 131763"},
        {"Hipparcos Number", "HIP 72945"},
        {"Smithsonian Astrophysical Observation", "SAO 64392"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.62522507),
        dec: Angle.Degrees(+34.08727417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218112"},
        {"Hipparcos Number", "HIP 113991"},
        {"Geneva Identification System", "GEN# +1.00218112"},
        {"Smithsonian Astrophysical Observation", "SAO 72985"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.27306399),
        dec: Angle.Degrees(+34.08893929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33581"},
        {"Hipparcos Number", "HIP 24287"},
        {"Geneva Identification System", "GEN# +1.00033581"},
        {"Smithsonian Astrophysical Observation", "SAO 57744"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.18480468),
        dec: Angle.Degrees(+34.08956965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54241"},
        {"Hipparcos Number", "HIP 34556"},
        {"Smithsonian Astrophysical Observation", "SAO 59828"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.37967337),
        dec: Angle.Degrees(+34.08981172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6938"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.34643987),
        dec: Angle.Degrees(+34.09006372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193218"},
        {"Hipparcos Number", "HIP 100051"},
        {"Smithsonian Astrophysical Observation", "SAO 69775"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.47706976),
        dec: Angle.Degrees(+34.09034726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116633"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.53881073),
        dec: Angle.Degrees(+34.09102830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30686"},
        {"Hipparcos Number", "HIP 22558"},
        {"Smithsonian Astrophysical Observation", "SAO 57456"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.81820457),
        dec: Angle.Degrees(+34.09291566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176599"},
        {"Hipparcos Number", "HIP 93253"},
        {"Geneva Identification System", "GEN# +1.00176599"},
        {"Smithsonian Astrophysical Observation", "SAO 67679"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.92811754),
        dec: Angle.Degrees(+34.09517223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47959"},
        {"Hipparcos Number", "HIP 32124"},
        {"Smithsonian Astrophysical Observation", "SAO 59391"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64280414),
        dec: Angle.Degrees(+34.09669428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118103"},
        {"Smithsonian Astrophysical Observation", "SAO 73628"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34649515),
        dec: Angle.Degrees(+34.09701113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84106"},
        {"Hipparcos Number", "HIP 47719"},
        {"Smithsonian Astrophysical Observation", "SAO 61657"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.92820044),
        dec: Angle.Degrees(+34.09716816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152927"},
        {"Hipparcos Number", "HIP 82781"},
        {"Geneva Identification System", "GEN# +1.00152927"},
        {"Smithsonian Astrophysical Observation", "SAO 65652"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.75895229),
        dec: Angle.Degrees(+34.09796318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115723"},
        {"Hipparcos Number", "HIP 64927"},
        {"Geneva Identification System", "GEN# +1.00115723"},
        {"Smithsonian Astrophysical Observation", "SAO 63462"},
        {"Wilson Evans Batten Catalogue", "WEB 11476"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.61544766),
        dec: Angle.Degrees(+34.09829261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7254"},
        {"Hipparcos Number", "HIP 5694"},
        {"Celescope Catalog", "CEL 130"},
        {"Geneva Identification System", "GEN# +1.00007254"},
        {"Renson", "Renson 1815"},
        {"Smithsonian Astrophysical Observation", "SAO 54523"},
        {"Wilson Evans Batten Catalogue", "WEB 1298"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.31741714),
        dec: Angle.Degrees(+34.09841522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2429",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 421 AB"},
        {"Henry Draper", "HD 2731"},
        {"Hipparcos Number", "HIP 2429"},
        {"Smithsonian Astrophysical Observation", "SAO 53949"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.74381508),
        dec: Angle.Degrees(+34.09865723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172977"},
        {"Hipparcos Number", "HIP 91671"},
        {"Celescope Catalog", "CEL 4640"},
        {"Geneva Identification System", "GEN# +1.00172977"},
        {"Renson", "Renson 48501"},
        {"Smithsonian Astrophysical Observation", "SAO 67258"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.41757975),
        dec: Angle.Degrees(+34.09875064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144873"},
        {"Hipparcos Number", "HIP 78923"},
        {"Cincinnati Publication", "Ci 18 2161"},
        {"Geneva Identification System", "GEN# +1.00144873"},
        {"Smithsonian Astrophysical Observation", "SAO 65083"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.66756433),
        dec: Angle.Degrees(+34.10247627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -300.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75636"},
        {"Hipparcos Number", "HIP 43561"},
        {"Smithsonian Astrophysical Observation", "SAO 61099"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.07115578),
        dec: Angle.Degrees(+34.10271910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149524"},
        {"Hipparcos Number", "HIP 81116"},
        {"Smithsonian Astrophysical Observation", "SAO 65392"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.50654881),
        dec: Angle.Degrees(+34.10334474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110296"},
        {"Hipparcos Number", "HIP 61887"},
        {"Geneva Identification System", "GEN# +1.00110296"},
        {"Smithsonian Astrophysical Observation", "SAO 63134"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.21965604),
        dec: Angle.Degrees(+34.10458559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 51 AB"},
        {"Henry Draper", "HD 39"},
        {"Hipparcos Number", "HIP 461"},
        {"Smithsonian Astrophysical Observation", "SAO 53635"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.37106856),
        dec: Angle.Degrees(+34.10565584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35256"},
        {"Smithsonian Astrophysical Observation", "SAO 59943"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.26986475),
        dec: Angle.Degrees(+34.10593949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111912"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.03381326),
        dec: Angle.Degrees(+34.10812923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48202"},
        {"Smithsonian Astrophysical Observation", "SAO 61704"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.41159800),
        dec: Angle.Degrees(+34.10830822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8873"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.55758216),
        dec: Angle.Degrees(+34.10848849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89848"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.03091805),
        dec: Angle.Degrees(+34.10995958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40294"},
        {"Smithsonian Astrophysical Observation", "SAO 60654"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.42449616),
        dec: Angle.Degrees(+34.11142926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227463"},
        {"Hipparcos Number", "HIP 98852"},
        {"Smithsonian Astrophysical Observation", "SAO 69357"},
        {"Wilson Evans Batten Catalogue", "WEB 17540"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11067831),
        dec: Angle.Degrees(+34.11228828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19207"},
        {"Hipparcos Number", "HIP 14446"},
        {"Geneva Identification System", "GEN# +1.00019207"},
        {"Smithsonian Astrophysical Observation", "SAO 56155"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.61178547),
        dec: Angle.Degrees(+34.11405963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49139"},
        {"Hipparcos Number", "HIP 32638"},
        {"Smithsonian Astrophysical Observation", "SAO 59500"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.12621961),
        dec: Angle.Degrees(+34.11471339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23060"},
        {"Hipparcos Number", "HIP 17387"},
        {"Geneva Identification System", "GEN# +1.00023060"},
        {"Smithsonian Astrophysical Observation", "SAO 56662"},
        {"Wilson Evans Batten Catalogue", "WEB 3284"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.85003108),
        dec: Angle.Degrees(+34.11626343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17129",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2668 AB"},
        {"Henry Draper", "HD 22692"},
        {"Hipparcos Number", "HIP 17129"},
        {"Smithsonian Astrophysical Observation", "SAO 56613"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.03016874),
        dec: Angle.Degrees(+34.11646037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2126"},
        {"Hipparcos Number", "HIP 2016"},
        {"Geneva Identification System", "GEN# +1.00002126"},
        {"Smithsonian Astrophysical Observation", "SAO 53881"},
        {"Wilson Evans Batten Catalogue", "WEB 385"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.40085682),
        dec: Angle.Degrees(+34.11719650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94226"},
    },
    visualMagnitude: 11.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.72275510),
        dec: Angle.Degrees(+34.11887687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76266"},
        {"Smithsonian Astrophysical Observation", "SAO 64783"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.66731884),
        dec: Angle.Degrees(+34.12221607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84557"},
        {"Smithsonian Astrophysical Observation", "SAO 65911"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.27911012),
        dec: Angle.Degrees(+34.12523167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168621"},
        {"Hipparcos Number", "HIP 89774"},
        {"Geneva Identification System", "GEN# +1.00168621"},
        {"Smithsonian Astrophysical Observation", "SAO 66855"},
        {"Wilson Evans Batten Catalogue", "WEB 15315"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.80053259),
        dec: Angle.Degrees(+34.12606078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48054"},
        {"Hipparcos Number", "HIP 32162"},
        {"Smithsonian Astrophysical Observation", "SAO 59401"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.74455056),
        dec: Angle.Degrees(+34.12778973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71593"},
        {"Hipparcos Number", "HIP 41642"},
        {"Smithsonian Astrophysical Observation", "SAO 60850"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.36684317),
        dec: Angle.Degrees(+34.12851815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282346"},
        {"Hipparcos Number", "HIP 21697"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.87912956),
        dec: Angle.Degrees(+34.12915770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88118"},
        {"Hipparcos Number", "HIP 49830"},
        {"Geneva Identification System", "GEN# +1.00088118"},
        {"Smithsonian Astrophysical Observation", "SAO 61907"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.59434613),
        dec: Angle.Degrees(+34.13043408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27777"},
        {"Hipparcos Number", "HIP 20579"},
        {"Geneva Identification System", "GEN# +1.00027777"},
        {"Smithsonian Astrophysical Observation", "SAO 57212"},
        {"Wilson Evans Batten Catalogue", "WEB 3941"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.12141978),
        dec: Angle.Degrees(+34.13084080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94383"},
        {"Hipparcos Number", "HIP 53305"},
        {"Geneva Identification System", "GEN# +1.00094383"},
        {"Smithsonian Astrophysical Observation", "SAO 62303"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.54439645),
        dec: Angle.Degrees(+34.13149756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104210",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14645 AB"},
        {"Henry Draper", "HD 201156"},
        {"Hipparcos Number", "HIP 104210"},
        {"Smithsonian Astrophysical Observation", "SAO 70925"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.69489886),
        dec: Angle.Degrees(+34.13233322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93240"},
        {"Hipparcos Number", "HIP 52691"},
        {"Geneva Identification System", "GEN# +1.00093240"},
        {"Smithsonian Astrophysical Observation", "SAO 62244"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60925485),
        dec: Angle.Degrees(+34.13276501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101035"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.24232425),
        dec: Angle.Degrees(+34.13511040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42012"},
        {"Hipparcos Number", "HIP 29242"},
        {"Geneva Identification System", "GEN# +1.00042012"},
        {"Smithsonian Astrophysical Observation", "SAO 58811"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.48517709),
        dec: Angle.Degrees(+34.13593200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21197"},
        {"Geneva Identification System", "GEN# +9.80039019"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.17041354),
        dec: Angle.Degrees(+34.13594913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7470"},
        {"Smithsonian Astrophysical Observation", "SAO 54822"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04890853),
        dec: Angle.Degrees(+34.13602901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181209"},
        {"Hipparcos Number", "HIP 94862"},
        {"Smithsonian Astrophysical Observation", "SAO 68103"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.55048671),
        dec: Angle.Degrees(+34.13617182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193034"},
        {"Hipparcos Number", "HIP 99974"},
        {"Celescope Catalog", "CEL 5010"},
        {"Geneva Identification System", "GEN# +1.00193034"},
        {"Smithsonian Astrophysical Observation", "SAO 69748"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23646731),
        dec: Angle.Degrees(+34.13968904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196461"},
        {"Hipparcos Number", "HIP 101663"},
        {"Smithsonian Astrophysical Observation", "SAO 70258"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10589287),
        dec: Angle.Degrees(+34.14118963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90991"},
        {"Hipparcos Number", "HIP 51478"},
        {"Smithsonian Astrophysical Observation", "SAO 62090"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.71810741),
        dec: Angle.Degrees(+34.14291583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58280"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.28676033),
        dec: Angle.Degrees(+34.14302424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278818"},
        {"Hipparcos Number", "HIP 16787"},
        {"Geneva Identification System", "GEN# +1.00278818"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.00322325),
        dec: Angle.Degrees(+34.14378140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12003 A"},
        {"Henry Draper", "HD 177593"},
        {"Hipparcos Number", "HIP 93621"},
        {"Celescope Catalog", "CEL 4694"},
        {"Geneva Identification System", "GEN# +1.00177593"},
        {"Smithsonian Astrophysical Observation", "SAO 67759"},
        {"Wilson Evans Batten Catalogue", "WEB 16261"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.98168565),
        dec: Angle.Degrees(+34.15126589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84740"},
        {"Smithsonian Astrophysical Observation", "SAO 65939"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.83489003),
        dec: Angle.Degrees(+34.15139196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80572"},
        {"Smithsonian Astrophysical Observation", "SAO 65307"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.76412145),
        dec: Angle.Degrees(+34.15172876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41202"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.12209884),
        dec: Angle.Degrees(+34.15366046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75455"},
        {"Hipparcos Number", "HIP 43471"},
        {"Smithsonian Astrophysical Observation", "SAO 61086"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.82620931),
        dec: Angle.Degrees(+34.15461995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24679"},
        {"Hipparcos Number", "HIP 18458"},
        {"Smithsonian Astrophysical Observation", "SAO 56828"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.16167143),
        dec: Angle.Degrees(+34.15507946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54945"},
        {"Hipparcos Number", "HIP 34812"},
        {"Smithsonian Astrophysical Observation", "SAO 59884"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.09620488),
        dec: Angle.Degrees(+34.15563469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62855"},
        {"Hipparcos Number", "HIP 38013"},
        {"Smithsonian Astrophysical Observation", "SAO 60337"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.85997004),
        dec: Angle.Degrees(+34.15997681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8596 AB"},
        {"Henry Draper", "HD 109280"},
        {"Hipparcos Number", "HIP 61272"},
        {"Geneva Identification System", "GEN# +1.00109280J"},
        {"Smithsonian Astrophysical Observation", "SAO 63062"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.35209533),
        dec: Angle.Degrees(+34.16255295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12852 A"},
        {"Henry Draper", "HD 186568"},
        {"Hipparcos Number", "HIP 97087"},
        {"Celescope Catalog", "CEL 4830"},
        {"Geneva Identification System", "GEN# +1.00186568J"},
        {"Geneva Identification System 2", "GEN# +1.00186568A"},
        {"Renson", "Renson 51410"},
        {"Smithsonian Astrophysical Observation", "SAO 68764"},
        {"Wilson Evans Batten Catalogue", "WEB 17044"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.96436260),
        dec: Angle.Degrees(+34.16271463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41638"},
        {"Hipparcos Number", "HIP 29072"},
        {"Smithsonian Astrophysical Observation", "SAO 58772"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.98930513),
        dec: Angle.Degrees(+34.16375144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163330"},
        {"Hipparcos Number", "HIP 87645"},
        {"Smithsonian Astrophysical Observation", "SAO 66448"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.53336438),
        dec: Angle.Degrees(+34.16413129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50120"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48159871),
        dec: Angle.Degrees(+34.16591600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110194"},
        {"Hipparcos Number", "HIP 61818"},
        {"Geneva Identification System", "GEN# +1.00110194"},
        {"Smithsonian Astrophysical Observation", "SAO 63130"},
        {"Wilson Evans Batten Catalogue", "WEB 10996"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.03598876),
        dec: Angle.Degrees(+34.16616716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48299"},
        {"Hipparcos Number", "HIP 32262"},
        {"Geneva Identification System", "GEN# +1.00048299"},
        {"Smithsonian Astrophysical Observation", "SAO 59427"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04784799),
        dec: Angle.Degrees(+34.16683289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65440"},
        {"Geneva Identification System", "GEN# +0.03402419"},
        {"Smithsonian Astrophysical Observation", "SAO 63520"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.17303536),
        dec: Angle.Degrees(+34.16931012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5540"},
        {"Hipparcos Number", "HIP 4495"},
        {"Smithsonian Astrophysical Observation", "SAO 54292"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.40128138),
        dec: Angle.Degrees(+34.16992273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16868"},
        {"Hipparcos Number", "HIP 12711"},
        {"Smithsonian Astrophysical Observation", "SAO 55814"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.84158780),
        dec: Angle.Degrees(+34.17371046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9170"},
        {"Hipparcos Number", "HIP 7051"},
        {"Geneva Identification System", "GEN# +1.00009170"},
        {"Smithsonian Astrophysical Observation", "SAO 54749"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.72121766),
        dec: Angle.Degrees(+34.17392115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35314"},
        {"Hipparcos Number", "HIP 25357"},
        {"Geneva Identification System", "GEN# +1.00035314"},
        {"Smithsonian Astrophysical Observation", "SAO 58001"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.34099718),
        dec: Angle.Degrees(+34.17396236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157605"},
        {"Hipparcos Number", "HIP 85027"},
        {"Smithsonian Astrophysical Observation", "SAO 65993"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.68014756),
        dec: Angle.Degrees(+34.17560632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90068"},
        {"Hipparcos Number", "HIP 50951"},
        {"Smithsonian Astrophysical Observation", "SAO 62021"},
        {"Wilson Evans Batten Catalogue", "WEB 9320"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.09244990),
        dec: Angle.Degrees(+34.17645275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80443"},
        {"Hipparcos Number", "HIP 45835"},
        {"Geneva Identification System", "GEN# +1.00080443"},
        {"Smithsonian Astrophysical Observation", "SAO 61409"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.17882493),
        dec: Angle.Degrees(+34.17761030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218011"},
        {"Hipparcos Number", "HIP 113932"},
        {"Smithsonian Astrophysical Observation", "SAO 72976"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.07878306),
        dec: Angle.Degrees(+34.17829562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144359"},
        {"Hipparcos Number", "HIP 78722"},
        {"Geneva Identification System", "GEN# +1.00144359"},
        {"Smithsonian Astrophysical Observation", "SAO 65057"},
        {"Wilson Evans Batten Catalogue", "WEB 13308"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.05626552),
        dec: Angle.Degrees(+34.17875791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26337"},
        {"Geneva Identification System", "GEN# +2.19600061"},
        {"Smithsonian Astrophysical Observation", "SAO 58239"},
        {"Wilson Evans Batten Catalogue", "WEB 5191"},
        {"New General Catalogue", "NGC 1960 61"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.13331874),
        dec: Angle.Degrees(+34.17980456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279407"},
        {"Hipparcos Number", "HIP 19132"},
        {"Geneva Identification System", "GEN# +1.00279407"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51542032),
        dec: Angle.Degrees(+34.18024472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164851"},
        {"Hipparcos Number", "HIP 88288"},
        {"Smithsonian Astrophysical Observation", "SAO 66566"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.43131040),
        dec: Angle.Degrees(+34.18056087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209006"},
        {"Hipparcos Number", "HIP 108552"},
        {"Smithsonian Astrophysical Observation", "SAO 71913"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84353956),
        dec: Angle.Degrees(+34.18069198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115272"},
        {"Hipparcos Number", "HIP 64701"},
        {"Geneva Identification System", "GEN# +1.00115272"},
        {"Smithsonian Astrophysical Observation", "SAO 63433"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.91140063),
        dec: Angle.Degrees(+34.18255800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58272"},
        {"Hipparcos Number", "HIP 36105"},
        {"Smithsonian Astrophysical Observation", "SAO 60076"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.56929598),
        dec: Angle.Degrees(+34.18359987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2265"},
        {"Hipparcos Number", "HIP 2104"},
        {"Smithsonian Astrophysical Observation", "SAO 53899"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.67009557),
        dec: Angle.Degrees(+34.18386896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35327"},
        {"Hipparcos Number", "HIP 25363"},
        {"Geneva Identification System", "GEN# +1.00035327"},
        {"Smithsonian Astrophysical Observation", "SAO 58004"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.37499484),
        dec: Angle.Degrees(+34.18636116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188210"},
        {"Hipparcos Number", "HIP 97832"},
        {"Celescope Catalog", "CEL 4866"},
        {"Smithsonian Astrophysical Observation", "SAO 69014"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.19785564),
        dec: Angle.Degrees(+34.18682491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74011"},
        {"Hipparcos Number", "HIP 42734"},
        {"Cincinnati Publication", "Ci 18 1019"},
        {"Geneva Identification System", "GEN# +1.00074011"},
        {"Smithsonian Astrophysical Observation", "SAO 60997"},
        {"Wilson Evans Batten Catalogue", "WEB 8255"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.62832042),
        dec: Angle.Degrees(+34.18840249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -290.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158016"},
        {"Hipparcos Number", "HIP 85269"},
        {"Smithsonian Astrophysical Observation", "SAO 66033"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.35253852),
        dec: Angle.Degrees(+34.18854480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278982"},
        {"Hipparcos Number", "HIP 17425"},
        {"Geneva Identification System", "GEN# +1.00278982"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.99782512),
        dec: Angle.Degrees(+34.18876125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75526"},
        {"Hipparcos Number", "HIP 43503"},
        {"Smithsonian Astrophysical Observation", "SAO 61089"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.91137707),
        dec: Angle.Degrees(+34.18924394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143348"},
        {"Hipparcos Number", "HIP 78252"},
        {"Smithsonian Astrophysical Observation", "SAO 64996"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.65235989),
        dec: Angle.Degrees(+34.19262063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90024"},
        {"Hipparcos Number", "HIP 50929"},
        {"Smithsonian Astrophysical Observation", "SAO 62018"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.02535750),
        dec: Angle.Degrees(+34.19324984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182897"},
        {"Hipparcos Number", "HIP 95505"},
        {"Geneva Identification System", "GEN# +1.00182897"},
        {"Smithsonian Astrophysical Observation", "SAO 68290"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37827119),
        dec: Angle.Degrees(+34.19436934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15243"},
        {"Hipparcos Number", "HIP 11494"},
        {"Smithsonian Astrophysical Observation", "SAO 55579"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.06215288),
        dec: Angle.Degrees(+34.19553943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223073"},
        {"Hipparcos Number", "HIP 117241"},
        {"Smithsonian Astrophysical Observation", "SAO 73495"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.59166031),
        dec: Angle.Degrees(+34.19680017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46640"},
        {"Hipparcos Number", "HIP 31524"},
        {"Geneva Identification System", "GEN# +1.00046640"},
        {"Smithsonian Astrophysical Observation", "SAO 59269"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.00554502),
        dec: Angle.Degrees(+34.19821042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28215"},
        {"Hipparcos Number", "HIP 20883"},
        {"Geneva Identification System", "GEN# +1.00028215"},
        {"Smithsonian Astrophysical Observation", "SAO 57247"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.13303592),
        dec: Angle.Degrees(+34.19914089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216631"},
        {"Hipparcos Number", "HIP 113076"},
        {"Geneva Identification System", "GEN# +1.00216631"},
        {"Smithsonian Astrophysical Observation", "SAO 72822"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50871252),
        dec: Angle.Degrees(+34.19928019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12638 AB"},
        {"Henry Draper", "HD 184877"},
        {"Hipparcos Number", "HIP 96328"},
        {"Smithsonian Astrophysical Observation", "SAO 68535"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.78104432),
        dec: Angle.Degrees(+34.19986351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36042"},
        {"Hipparcos Number", "HIP 25787"},
        {"Geneva Identification System", "GEN# +1.00036042"},
        {"Smithsonian Astrophysical Observation", "SAO 58124"},
        {"Wilson Evans Batten Catalogue", "WEB 5010"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.59777000),
        dec: Angle.Degrees(+34.20073310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87473"},
        {"Hipparcos Number", "HIP 49461"},
        {"Geneva Identification System", "GEN# +1.00087473"},
        {"Smithsonian Astrophysical Observation", "SAO 61857"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46966414),
        dec: Angle.Degrees(+34.20111964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162949"},
        {"Hipparcos Number", "HIP 87465"},
        {"Geneva Identification System", "GEN# +1.00162949"},
        {"Smithsonian Astrophysical Observation", "SAO 66403"},
        {"Wilson Evans Batten Catalogue", "WEB 14753"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.07064418),
        dec: Angle.Degrees(+34.20118343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26354"},
        {"Geneva Identification System", "GEN# +2.19600101"},
        {"Smithsonian Astrophysical Observation", "SAO 58247"},
        {"Wilson Evans Batten Catalogue", "WEB 5196"},
        {"New General Catalogue", "NGC 1960 101"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.17625813),
        dec: Angle.Degrees(+34.20165923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106323",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15066 A"},
        {"Henry Draper", "HD 205075"},
        {"Hipparcos Number", "HIP 106323"},
        {"Geneva Identification System", "GEN# +1.00205075"},
        {"Smithsonian Astrophysical Observation", "SAO 71434"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.01914089),
        dec: Angle.Degrees(+34.20172300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117412"},
        {"Smithsonian Astrophysical Observation", "SAO 73519"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.12038987),
        dec: Angle.Degrees(+34.20173552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101501"},
        {"Hipparcos Number", "HIP 56997"},
        {"Fundamental Katalog 5th Edition", "FK5 1300"},
        {"Geneva Identification System", "GEN# +1.00101501"},
        {"Smithsonian Astrophysical Observation", "SAO 62655"},
        {"Wilson Evans Batten Catalogue", "WEB 10258"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.26260484),
        dec: Angle.Degrees(+34.20256022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -380.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105501"},
        {"Hipparcos Number", "HIP 59220"},
        {"Geneva Identification System", "GEN# +1.00105501"},
        {"Smithsonian Astrophysical Observation", "SAO 62859"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.18514735),
        dec: Angle.Degrees(+34.20431136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90581"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.25291392),
        dec: Angle.Degrees(+34.20485218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
