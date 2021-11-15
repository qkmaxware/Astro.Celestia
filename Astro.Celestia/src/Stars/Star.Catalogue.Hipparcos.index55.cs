using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_55() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176159"},
        {"Hipparcos Number", "HIP 93215"},
        {"Geneva Identification System", "GEN# +1.00176159"},
        {"Smithsonian Astrophysical Observation", "SAO 142881"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.81329299),
        dec: Angle.Degrees(-07.13358886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34814"},
        {"Hipparcos Number", "HIP 24868"},
        {"Celescope Catalog", "CEL 623"},
        {"Geneva Identification System", "GEN# +1.00034814"},
        {"Smithsonian Astrophysical Observation", "SAO 131992"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.96617958),
        dec: Angle.Degrees(-07.13260354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50253"},
        {"Hipparcos Number", "HIP 32975"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.03986609),
        dec: Angle.Degrees(-07.12901018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169751"},
        {"Hipparcos Number", "HIP 90379"},
        {"Smithsonian Astrophysical Observation", "SAO 142316"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.62407074),
        dec: Angle.Degrees(-07.12686762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84685"},
        {"Hipparcos Number", "HIP 47977"},
        {"Smithsonian Astrophysical Observation", "SAO 137120"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.69016416),
        dec: Angle.Degrees(-07.12651660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13916"},
        {"Hipparcos Number", "HIP 10499"},
        {"Smithsonian Astrophysical Observation", "SAO 129779"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.83890107),
        dec: Angle.Degrees(-07.12626649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111944"},
        {"Hipparcos Number", "HIP 62851"},
        {"Smithsonian Astrophysical Observation", "SAO 139016"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.24083871),
        dec: Angle.Degrees(-07.12572528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4997"},
        {"Hipparcos Number", "HIP 4054"},
        {"Smithsonian Astrophysical Observation", "SAO 128998"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.97823894),
        dec: Angle.Degrees(-07.12499969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143332"},
        {"Hipparcos Number", "HIP 78380"},
        {"Geneva Identification System", "GEN# +1.00143332"},
        {"Smithsonian Astrophysical Observation", "SAO 140888"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.01107941),
        dec: Angle.Degrees(-07.12266258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22492"},
        {"Hipparcos Number", "HIP 16842"},
        {"Geneva Identification System", "GEN# +1.00022492"},
    },
    visualMagnitude: 9.85,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.19303238),
        dec: Angle.Degrees(-07.12127017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72333"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.87013272),
        dec: Angle.Degrees(-07.12081982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165807"},
        {"Hipparcos Number", "HIP 88843"},
        {"Smithsonian Astrophysical Observation", "SAO 142105"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.03605126),
        dec: Angle.Degrees(-07.11988870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12213"},
        {"Hipparcos Number", "HIP 9334"},
        {"Smithsonian Astrophysical Observation", "SAO 129614"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.96013650),
        dec: Angle.Degrees(-07.11920929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16858 AB"},
        {"Henry Draper", "HD 221925"},
        {"Hipparcos Number", "HIP 116488"},
        {"Smithsonian Astrophysical Observation", "SAO 146801"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.07292776),
        dec: Angle.Degrees(-07.11717123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122287"},
        {"Hipparcos Number", "HIP 68471"},
        {"Geneva Identification System", "GEN# +1.00122287"},
        {"Smithsonian Astrophysical Observation", "SAO 139681"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.27385994),
        dec: Angle.Degrees(-07.11540364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3841"},
        {"Hipparcos Number", "HIP 3220"},
        {"Smithsonian Astrophysical Observation", "SAO 128896"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.23425568),
        dec: Angle.Degrees(-07.11353963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198000"},
        {"Hipparcos Number", "HIP 102614"},
        {"Fundamental Katalog 5th Edition", "FK5 5833"},
        {"Smithsonian Astrophysical Observation", "SAO 144812"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91494233),
        dec: Angle.Degrees(-07.11111936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173219"},
        {"Hipparcos Number", "HIP 91946"},
        {"Geneva Identification System", "GEN# +1.00173219"},
        {"Smithsonian Astrophysical Observation", "SAO 142567"},
        {"Wilson Evans Batten Catalogue", "WEB 15834"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.13892001),
        dec: Angle.Degrees(-07.11059423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30619"},
        {"Hipparcos Number", "HIP 22369"},
        {"Geneva Identification System", "GEN# +1.00030619"},
        {"Smithsonian Astrophysical Observation", "SAO 131510"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.23712708),
        dec: Angle.Degrees(-07.11012196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79193"},
        {"Hipparcos Number", "HIP 45184"},
        {"Geneva Identification System", "GEN# +1.00079193"},
        {"Renson", "Renson 22490"},
        {"Smithsonian Astrophysical Observation", "SAO 136662"},
        {"Wilson Evans Batten Catalogue", "WEB 8617"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.10856189),
        dec: Angle.Degrees(-07.10987965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51959"},
        {"Hipparcos Number", "HIP 33628"},
        {"Geneva Identification System", "GEN# +1.00051959"},
        {"Smithsonian Astrophysical Observation", "SAO 133994"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.79214612),
        dec: Angle.Degrees(-07.10888573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130485"},
        {"Hipparcos Number", "HIP 72433"},
        {"Geneva Identification System", "GEN# +1.00130485"},
        {"Smithsonian Astrophysical Observation", "SAO 140149"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.16946254),
        dec: Angle.Degrees(-07.10701161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10480 AB"},
        {"Henry Draper", "HD 156952"},
        {"Hipparcos Number", "HIP 84866"},
        {"Geneva Identification System", "GEN# +1.00156952J"},
        {"Smithsonian Astrophysical Observation", "SAO 141620"},
        {"Wilson Evans Batten Catalogue", "WEB 14328"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.17945535),
        dec: Angle.Degrees(-07.10661444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42411"},
        {"Hipparcos Number", "HIP 29264"},
        {"Smithsonian Astrophysical Observation", "SAO 132910"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.54495845),
        dec: Angle.Degrees(-07.10567161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157348"},
        {"Hipparcos Number", "HIP 85064"},
        {"Geneva Identification System", "GEN# +1.00157348"},
        {"Smithsonian Astrophysical Observation", "SAO 141643"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.76837387),
        dec: Angle.Degrees(-07.10445549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34861"},
        {"Hipparcos Number", "HIP 24899"},
        {"Celescope Catalog", "CEL 630"},
        {"Geneva Identification System", "GEN# +1.00034861"},
        {"Smithsonian Astrophysical Observation", "SAO 131996"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.05231206),
        dec: Angle.Degrees(-07.10391595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151008"},
        {"Hipparcos Number", "HIP 81994"},
        {"Smithsonian Astrophysical Observation", "SAO 141341"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.25248550),
        dec: Angle.Degrees(-07.09929521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47612"},
        {"Hipparcos Number", "HIP 31823"},
        {"Renson", "Renson 12770"},
        {"Smithsonian Astrophysical Observation", "SAO 133528"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.80705728),
        dec: Angle.Degrees(-07.09856288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86795"},
        {"Hipparcos Number", "HIP 49064"},
        {"Smithsonian Astrophysical Observation", "SAO 137285"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.18233348),
        dec: Angle.Degrees(-07.09781589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224432"},
        {"Hipparcos Number", "HIP 118146"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.47920649),
        dec: Angle.Degrees(-07.09261536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65880"},
        {"Hipparcos Number", "HIP 39168"},
        {"Smithsonian Astrophysical Observation", "SAO 135369"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.17082153),
        dec: Angle.Degrees(-07.09065637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216133"},
        {"Hipparcos Number", "HIP 112774"},
        {"Geneva Identification System", "GEN# +1.00216133"},
        {"Wilson Evans Batten Catalogue", "WEB 20093"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.58119552),
        dec: Angle.Degrees(-07.09035755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218647"},
        {"Hipparcos Number", "HIP 114370"},
        {"Smithsonian Astrophysical Observation", "SAO 146539"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.45400676),
        dec: Angle.Degrees(-07.09011846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2596 A"},
        {"Henry Draper", "HD 21978"},
        {"Hipparcos Number", "HIP 16485"},
        {"Geneva Identification System", "GEN# +1.00021978"},
        {"Smithsonian Astrophysical Observation", "SAO 130551"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.06417390),
        dec: Angle.Degrees(-07.09001689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211276"},
        {"Hipparcos Number", "HIP 109951"},
        {"Geneva Identification System", "GEN# +1.00211276"},
        {"Smithsonian Astrophysical Observation", "SAO 145984"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.02717218),
        dec: Angle.Degrees(-07.08988402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -347.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2596 B"},
        {"Hipparcos Number", "HIP 16486"},
        {"Smithsonian Astrophysical Observation", "SAO 130553"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.06943307),
        dec: Angle.Degrees(-07.08984438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 778"},
        {"Hipparcos Number", "HIP 976"},
        {"Smithsonian Astrophysical Observation", "SAO 128635"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.02287137),
        dec: Angle.Degrees(-07.08866665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202279"},
        {"Hipparcos Number", "HIP 104897"},
        {"Geneva Identification System", "GEN# +1.00202279"},
        {"Smithsonian Astrophysical Observation", "SAO 145232"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.72710204),
        dec: Angle.Degrees(-07.08746216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187987"},
        {"Hipparcos Number", "HIP 97860"},
        {"Geneva Identification System", "GEN# +1.00187987"},
        {"Smithsonian Astrophysical Observation", "SAO 143879"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29689585),
        dec: Angle.Degrees(-07.08743212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144363"},
        {"Hipparcos Number", "HIP 78850"},
        {"Smithsonian Astrophysical Observation", "SAO 140944"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.43640748),
        dec: Angle.Degrees(-07.08490896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161056"},
        {"Hipparcos Number", "HIP 86768"},
        {"Geneva Identification System", "GEN# +1.00161056"},
        {"Smithsonian Astrophysical Observation", "SAO 141832"},
        {"Wilson Evans Batten Catalogue", "WEB 14630"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.94593637),
        dec: Angle.Degrees(-07.07958249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214103"},
        {"Hipparcos Number", "HIP 111557"},
        {"Smithsonian Astrophysical Observation", "SAO 146186"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.00915116),
        dec: Angle.Degrees(-07.07603872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169370"},
        {"Hipparcos Number", "HIP 90238"},
        {"Geneva Identification System", "GEN# +1.00169370"},
        {"Smithsonian Astrophysical Observation", "SAO 142288"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.17520437),
        dec: Angle.Degrees(-07.07587257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172831"},
        {"Hipparcos Number", "HIP 91751"},
        {"Geneva Identification System", "GEN# +1.00172831"},
        {"Smithsonian Astrophysical Observation", "SAO 142525"},
        {"Wilson Evans Batten Catalogue", "WEB 15784"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.65050619),
        dec: Angle.Degrees(-07.07363239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24449",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3825 AB"},
        {"Henry Draper", "HD 34121"},
        {"Hipparcos Number", "HIP 24449"},
        {"Smithsonian Astrophysical Observation", "SAO 131910"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.67212847),
        dec: Angle.Degrees(-07.07164154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127186"},
        {"Hipparcos Number", "HIP 70913"},
        {"Smithsonian Astrophysical Observation", "SAO 139970"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.53463354),
        dec: Angle.Degrees(-07.07150114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3740 A"},
        {"Henry Draper", "HD 33449"},
        {"Hipparcos Number", "HIP 24037"},
        {"Geneva Identification System", "GEN# +1.00033449"},
        {"Smithsonian Astrophysical Observation", "SAO 131836"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.50880111),
        dec: Angle.Degrees(-07.07117285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34526"},
        {"Smithsonian Astrophysical Observation", "SAO 134262"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.31182250),
        dec: Angle.Degrees(-07.07046166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15751"},
        {"Smithsonian Astrophysical Observation", "SAO 130453"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.72902005),
        dec: Angle.Degrees(-07.07014920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27215"},
        {"Smithsonian Astrophysical Observation", "SAO 132516"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.51892108),
        dec: Angle.Degrees(-07.07001328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210703"},
        {"Hipparcos Number", "HIP 109616"},
        {"Smithsonian Astrophysical Observation", "SAO 145936"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.08140447),
        dec: Angle.Degrees(-07.06472620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75622"},
        {"Hipparcos Number", "HIP 43435"},
        {"Geneva Identification System", "GEN# +1.00075622"},
        {"Smithsonian Astrophysical Observation", "SAO 136331"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69838235),
        dec: Angle.Degrees(-07.06403117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24042",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3740 B"},
        {"Hipparcos Number", "HIP 24042"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)10, 03.4500),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)03, 48.600)
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
    primaryId: "HIP 14761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14761"},
        {"Smithsonian Astrophysical Observation", "SAO 130324"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.65986064),
        dec: Angle.Degrees(-07.06249117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9186 AB"},
        {"Henry Draper", "HD 124851"},
        {"Hipparcos Number", "HIP 69700"},
        {"Geneva Identification System", "GEN# +1.00124851"},
        {"Smithsonian Astrophysical Observation", "SAO 139823"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.00169489),
        dec: Angle.Degrees(-07.06186818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110138"},
        {"Hipparcos Number", "HIP 61815"},
        {"Smithsonian Astrophysical Observation", "SAO 138901"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.02516771),
        dec: Angle.Degrees(-07.06121591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217531"},
        {"Hipparcos Number", "HIP 113674"},
        {"Geneva Identification System", "GEN# +1.00217531"},
        {"Smithsonian Astrophysical Observation", "SAO 146447"},
        {"Wilson Evans Batten Catalogue", "WEB 20199"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.34854619),
        dec: Angle.Degrees(-07.06113357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90362"},
        {"Hipparcos Number", "HIP 51046"},
        {"Fundamental Katalog 5th Edition", "FK5 2836"},
        {"Geneva Identification System", "GEN# +1.00090362"},
        {"Smithsonian Astrophysical Observation", "SAO 137557"},
        {"Wilson Evans Batten Catalogue", "WEB 9331"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.43479445),
        dec: Angle.Degrees(-07.06014256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137571"},
        {"Hipparcos Number", "HIP 75615"},
        {"Smithsonian Astrophysical Observation", "SAO 140538"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.74690434),
        dec: Angle.Degrees(-07.05766440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124518"},
        {"Hipparcos Number", "HIP 69556"},
        {"Smithsonian Astrophysical Observation", "SAO 139804"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.56916825),
        dec: Angle.Degrees(-07.05604413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95076"},
        {"Hipparcos Number", "HIP 53645"},
        {"Smithsonian Astrophysical Observation", "SAO 137917"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.62467615),
        dec: Angle.Degrees(-07.05515619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188335"},
        {"Hipparcos Number", "HIP 97998"},
        {"Smithsonian Astrophysical Observation", "SAO 143902"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.73425542),
        dec: Angle.Degrees(-07.05491087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75426"},
        {"Geneva Identification System", "GEN# -0.00604196"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.14827807),
        dec: Angle.Degrees(-07.05485861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64144"},
        {"Smithsonian Astrophysical Observation", "SAO 139177"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.19160531),
        dec: Angle.Degrees(-07.05479180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213131"},
        {"Hipparcos Number", "HIP 111014"},
        {"Smithsonian Astrophysical Observation", "SAO 146118"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.35526015),
        dec: Angle.Degrees(-07.05277533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107813"},
        {"Hipparcos Number", "HIP 60428"},
        {"Geneva Identification System", "GEN# +1.00107813"},
        {"Smithsonian Astrophysical Observation", "SAO 138753"},
        {"Wilson Evans Batten Catalogue", "WEB 10745"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.85398859),
        dec: Angle.Degrees(-07.05263992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114610"},
        {"Hipparcos Number", "HIP 64383"},
        {"Smithsonian Astrophysical Observation", "SAO 139209"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.93704390),
        dec: Angle.Degrees(-07.05045415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36487"},
        {"Hipparcos Number", "HIP 25898"},
        {"Celescope Catalog", "CEL 760"},
        {"Geneva Identification System", "GEN# +1.00036487"},
        {"Smithsonian Astrophysical Observation", "SAO 132218"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.92267672),
        dec: Angle.Degrees(-07.04864644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88358"},
        {"Hipparcos Number", "HIP 49887"},
        {"Smithsonian Astrophysical Observation", "SAO 137399"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79612349),
        dec: Angle.Degrees(-07.04462258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12503 AB"},
        {"Henry Draper", "HD 183344"},
        {"Hipparcos Number", "HIP 95820"},
        {"Geneva Identification System", "GEN# +1.00183344"},
        {"Smithsonian Astrophysical Observation", "SAO 143454"},
        {"Wilson Evans Batten Catalogue", "WEB 16775"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33900410),
        dec: Angle.Degrees(-07.04406367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56493"},
        {"Hipparcos Number", "HIP 35237"},
        {"Smithsonian Astrophysical Observation", "SAO 134450"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22693673),
        dec: Angle.Degrees(-07.04289632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72025"},
        {"Hipparcos Number", "HIP 41717"},
        {"Smithsonian Astrophysical Observation", "SAO 135988"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.60189995),
        dec: Angle.Degrees(-07.04006764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30049"},
        {"Hipparcos Number", "HIP 22010"},
        {"Smithsonian Astrophysical Observation", "SAO 131448"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.96634086),
        dec: Angle.Degrees(-07.03895415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59559"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21640586),
        dec: Angle.Degrees(-07.03844043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63821"},
        {"Hipparcos Number", "HIP 38283"},
        {"Smithsonian Astrophysical Observation", "SAO 135165"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.65498282),
        dec: Angle.Degrees(-07.03443333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30867",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5107 ABC"},
        {"Hipparcos Number", "HIP 30867"},
        {"Geneva Identification System", "GEN# +1.00045725J"},
    },
    visualMagnitude: 3.76,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.20447548),
        dec: Angle.Degrees(-07.03305042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9278"},
        {"Hipparcos Number", "HIP 7075"},
        {"Smithsonian Astrophysical Observation", "SAO 129345"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.79458726),
        dec: Angle.Degrees(-07.03278538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1203"},
        {"Hipparcos Number", "HIP 1303"},
        {"Smithsonian Astrophysical Observation", "SAO 128672"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.09065413),
        dec: Angle.Degrees(-07.03004676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153688"},
        {"Hipparcos Number", "HIP 83282"},
        {"Smithsonian Astrophysical Observation", "SAO 141484"},
        {"Wilson Evans Batten Catalogue", "WEB 14074"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30620512),
        dec: Angle.Degrees(-07.02811922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184915"},
        {"Hipparcos Number", "HIP 96483"},
        {"Fundamental Katalog 5th Edition", "FK5 737"},
        {"Geneva Identification System", "GEN# +1.00184915"},
        {"Smithsonian Astrophysical Observation", "SAO 143600"},
        {"Wilson Evans Batten Catalogue", "WEB 16928"},
    },
    visualMagnitude: 4.93,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22270240),
        dec: Angle.Degrees(-07.02747069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11700"},
        {"Hipparcos Number", "HIP 8910"},
        {"Smithsonian Astrophysical Observation", "SAO 129561"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.67515157),
        dec: Angle.Degrees(-07.02719447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143297"},
        {"Hipparcos Number", "HIP 78349"},
        {"Smithsonian Astrophysical Observation", "SAO 140886"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.96579768),
        dec: Angle.Degrees(-07.02673777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23810"},
        {"Hipparcos Number", "HIP 17733"},
        {"Smithsonian Astrophysical Observation", "SAO 130727"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.95640032),
        dec: Angle.Degrees(-07.02590468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9562"},
        {"Hipparcos Number", "HIP 7276"},
        {"Geneva Identification System", "GEN# +1.00009562"},
        {"Smithsonian Astrophysical Observation", "SAO 129371"},
        {"Wilson Evans Batten Catalogue", "WEB 1567"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.42805448),
        dec: Angle.Degrees(-07.02514279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21119"},
        {"Smithsonian Astrophysical Observation", "SAO 131266"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.89642532),
        dec: Angle.Degrees(-07.02380898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36814"},
        {"Hipparcos Number", "HIP 26104"},
        {"Smithsonian Astrophysical Observation", "SAO 132271"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.51033175),
        dec: Angle.Degrees(-07.02365188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10092 AB"},
        {"Henry Draper", "HD 148931"},
        {"Hipparcos Number", "HIP 80954"},
        {"Geneva Identification System", "GEN# +1.00148931J"},
        {"Smithsonian Astrophysical Observation", "SAO 141223"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.94981600),
        dec: Angle.Degrees(-07.02322941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220121"},
        {"Hipparcos Number", "HIP 115309"},
        {"Geneva Identification System", "GEN# +1.00220121"},
        {"Smithsonian Astrophysical Observation", "SAO 146657"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.31102423),
        dec: Angle.Degrees(-07.02308813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31543"},
        {"Hipparcos Number", "HIP 22960"},
        {"Geneva Identification System", "GEN# +1.00031543"},
        {"Smithsonian Astrophysical Observation", "SAO 131615"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.10329044),
        dec: Angle.Degrees(-07.02308211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52682"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.58035161),
        dec: Angle.Degrees(-07.02086115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191148"},
        {"Hipparcos Number", "HIP 99242"},
        {"Smithsonian Astrophysical Observation", "SAO 144109"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.17908270),
        dec: Angle.Degrees(-07.02050342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181077"},
        {"Hipparcos Number", "HIP 94955"},
        {"Smithsonian Astrophysical Observation", "SAO 143260"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.83830707),
        dec: Angle.Degrees(-07.02048927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186575"},
        {"Hipparcos Number", "HIP 97216"},
        {"Geneva Identification System", "GEN# +1.00186575"},
        {"Smithsonian Astrophysical Observation", "SAO 143767"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.36809925),
        dec: Angle.Degrees(-07.01939191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195023"},
        {"Hipparcos Number", "HIP 101051"},
        {"Smithsonian Astrophysical Observation", "SAO 144485"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.27167372),
        dec: Angle.Degrees(-07.01745242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180193"},
        {"Hipparcos Number", "HIP 94681"},
        {"Smithsonian Astrophysical Observation", "SAO 143196"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.99035514),
        dec: Angle.Degrees(-07.01739248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178459"},
        {"Hipparcos Number", "HIP 94072"},
        {"Geneva Identification System", "GEN# +1.00178459"},
        {"Smithsonian Astrophysical Observation", "SAO 143071"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.25853583),
        dec: Angle.Degrees(-07.01727490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12221"},
        {"Hipparcos Number", "HIP 9338"},
        {"Smithsonian Astrophysical Observation", "SAO 129617"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.98050875),
        dec: Angle.Degrees(-07.01668626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204236"},
        {"Hipparcos Number", "HIP 105947"},
        {"Fundamental Katalog 5th Edition", "FK5 5891"},
        {"Geneva Identification System", "GEN# +1.00204236"},
        {"Smithsonian Astrophysical Observation", "SAO 145409"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.84686396),
        dec: Angle.Degrees(-07.01559639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23937"},
        {"Hipparcos Number", "HIP 17821"},
        {"Geneva Identification System", "GEN# +1.00023937"},
        {"Smithsonian Astrophysical Observation", "SAO 130743"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.19804679),
        dec: Angle.Degrees(-07.01491497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125310"},
        {"Hipparcos Number", "HIP 69933"},
        {"Smithsonian Astrophysical Observation", "SAO 139859"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.67166823),
        dec: Angle.Degrees(-07.01365312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94605"},
        {"Renson", "Renson 49980"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.78223331),
        dec: Angle.Degrees(-07.01363346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9497 AB"},
        {"Henry Draper", "HD 133584"},
        {"Hipparcos Number", "HIP 73846"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.37936306),
        dec: Angle.Degrees(-07.01356805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75320"},
        {"Hipparcos Number", "HIP 43291"},
        {"Geneva Identification System", "GEN# +1.00075320"},
        {"Smithsonian Astrophysical Observation", "SAO 136304"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.27596763),
        dec: Angle.Degrees(-07.00910325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96311"},
        {"Hipparcos Number", "HIP 54265"},
        {"Smithsonian Astrophysical Observation", "SAO 137987"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.52416394),
        dec: Angle.Degrees(-07.00812774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30521"},
        {"Hipparcos Number", "HIP 22301"},
        {"Smithsonian Astrophysical Observation", "SAO 131499"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.03988026),
        dec: Angle.Degrees(-07.00747469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18840",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2949 AB"},
        {"Henry Draper", "HD 25458"},
        {"Hipparcos Number", "HIP 18840"},
        {"Smithsonian Astrophysical Observation", "SAO 130892"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.59393684),
        dec: Angle.Degrees(-07.00514226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14161"},
        {"Smithsonian Astrophysical Observation", "SAO 130253"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.64537027),
        dec: Angle.Degrees(-07.00480345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24949"},
        {"Hipparcos Number", "HIP 18523"},
        {"Smithsonian Astrophysical Observation", "SAO 130846"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.40952930),
        dec: Angle.Degrees(-07.00278524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106060"},
        {"Hipparcos Number", "HIP 59507"},
        {"Smithsonian Astrophysical Observation", "SAO 138645"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.06192139),
        dec: Angle.Degrees(-07.00107763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10136"},
        {"Smithsonian Astrophysical Observation", "SAO 129729"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.59835603),
        dec: Angle.Degrees(-07.00061413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39870"},
        {"Hipparcos Number", "HIP 27981"},
    },
    visualMagnitude: 12.75,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)55, 02.8300),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)59, 54.300)
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
    primaryId: "HIP 51489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91105"},
        {"Hipparcos Number", "HIP 51489"},
        {"Geneva Identification System", "GEN# +1.00091105"},
        {"Smithsonian Astrophysical Observation", "SAO 137613"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.74331255),
        dec: Angle.Degrees(-06.99805871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29133"},
        {"Hipparcos Number", "HIP 21356"},
        {"Smithsonian Astrophysical Observation", "SAO 131329"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.73544188),
        dec: Angle.Degrees(-06.99626176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17339"},
        {"Hipparcos Number", "HIP 12962"},
        {"Smithsonian Astrophysical Observation", "SAO 130107"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.67989941),
        dec: Angle.Degrees(-06.99305732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108797"},
        {"Hipparcos Number", "HIP 60995"},
        {"Smithsonian Astrophysical Observation", "SAO 138817"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.52087155),
        dec: Angle.Degrees(-06.99253320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174700"},
        {"Hipparcos Number", "HIP 92601"},
        {"Smithsonian Astrophysical Observation", "SAO 142726"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.03297686),
        dec: Angle.Degrees(-06.99196658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28961"},
        {"Hipparcos Number", "HIP 21249"},
        {"Smithsonian Astrophysical Observation", "SAO 131298"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.38183670),
        dec: Angle.Degrees(-06.98814050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3430 AB"},
        {"Henry Draper", "HD 30301"},
        {"Hipparcos Number", "HIP 22151"},
        {"Smithsonian Astrophysical Observation", "SAO 131476"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.49874137),
        dec: Angle.Degrees(-06.98802504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21717"},
        {"Hipparcos Number", "HIP 16288"},
        {"Smithsonian Astrophysical Observation", "SAO 130521"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.48895304),
        dec: Angle.Degrees(-06.98786257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201284"},
        {"Hipparcos Number", "HIP 104380"},
        {"Smithsonian Astrophysical Observation", "SAO 145137"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.18605150),
        dec: Angle.Degrees(-06.98647714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8600"},
        {"Hipparcos Number", "HIP 6606"},
        {"Smithsonian Astrophysical Observation", "SAO 129281"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20349209),
        dec: Angle.Degrees(-06.98586089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63996"},
        {"Hipparcos Number", "HIP 38366"},
        {"Renson", "Renson 17643"},
        {"Smithsonian Astrophysical Observation", "SAO 135181"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.88213080),
        dec: Angle.Degrees(-06.98323118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214630"},
        {"Hipparcos Number", "HIP 111873"},
        {"Smithsonian Astrophysical Observation", "SAO 146227"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.90661222),
        dec: Angle.Degrees(-06.98000879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15459 AB"},
        {"Henry Draper", "HD 208420"},
        {"Hipparcos Number", "HIP 108280"},
        {"Smithsonian Astrophysical Observation", "SAO 145754"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.05755913),
        dec: Angle.Degrees(-06.97999870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79097"},
        {"Hipparcos Number", "HIP 45143"},
        {"Geneva Identification System", "GEN# +1.00079097"},
        {"Smithsonian Astrophysical Observation", "SAO 136651"},
        {"Wilson Evans Batten Catalogue", "WEB 8613"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.96381067),
        dec: Angle.Degrees(-06.97956469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65445"},
        {"Wilson Evans Batten Catalogue", "WEB 11550"},
    },
    visualMagnitude: 11.62,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.20004193),
        dec: Angle.Degrees(-06.97924253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137930"},
        {"Hipparcos Number", "HIP 75805"},
        {"Smithsonian Astrophysical Observation", "SAO 140563"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.29100810),
        dec: Angle.Degrees(-06.97915489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74702"},
        {"Hipparcos Number", "HIP 42949"},
        {"Smithsonian Astrophysical Observation", "SAO 136244"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.32262020),
        dec: Angle.Degrees(-06.97850540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182246"},
        {"Hipparcos Number", "HIP 95363"},
        {"Geneva Identification System", "GEN# +1.00182246"},
        {"Smithsonian Astrophysical Observation", "SAO 143353"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01392655),
        dec: Angle.Degrees(-06.97730576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58289"},
        {"Geneva Identification System", "GEN# -0.00603481"},
        {"Smithsonian Astrophysical Observation", "SAO 138499"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31506858),
        dec: Angle.Degrees(-06.97723319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 142.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206173"},
        {"Hipparcos Number", "HIP 107015"},
        {"Smithsonian Astrophysical Observation", "SAO 145578"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.10771237),
        dec: Angle.Degrees(-06.97506752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26827"},
        {"Hipparcos Number", "HIP 19778"},
        {"Smithsonian Astrophysical Observation", "SAO 131048"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60270314),
        dec: Angle.Degrees(-06.97440092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75807"},
    },
    visualMagnitude: 12.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.29248547),
        dec: Angle.Degrees(-06.97344635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45709"},
        {"Hipparcos Number", "HIP 30852"},
        {"Smithsonian Astrophysical Observation", "SAO 133313"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17880096),
        dec: Angle.Degrees(-06.97003070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119219"},
        {"Hipparcos Number", "HIP 66853"},
        {"Smithsonian Astrophysical Observation", "SAO 139496"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.50911102),
        dec: Angle.Degrees(-06.96900423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118129"},
        {"Hipparcos Number", "HIP 66280"},
        {"Geneva Identification System", "GEN# +1.00118129"},
        {"Smithsonian Astrophysical Observation", "SAO 139423"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.76745442),
        dec: Angle.Degrees(-06.96772992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92868"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.85524616),
        dec: Angle.Degrees(-06.96733673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50138"},
        {"Hipparcos Number", "HIP 32923"},
        {"Geneva Identification System", "GEN# +1.00050138"},
        {"Smithsonian Astrophysical Observation", "SAO 133781"},
        {"Wilson Evans Batten Catalogue", "WEB 6628"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88917145),
        dec: Angle.Degrees(-06.96652374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225211"},
        {"Hipparcos Number", "HIP 356"},
        {"Geneva Identification System", "GEN# +1.00225211"},
        {"Smithsonian Astrophysical Observation", "SAO 128564"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.12570193),
        dec: Angle.Degrees(-06.96533727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106299"},
    },
    visualMagnitude: 11.86,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.94119430),
        dec: Angle.Degrees(-06.96408157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35659"},
        {"Hipparcos Number", "HIP 25398"},
        {"Celescope Catalog", "CEL 692"},
        {"Geneva Identification System", "GEN# +1.00035659"},
        {"Smithsonian Astrophysical Observation", "SAO 132099"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.49914707),
        dec: Angle.Degrees(-06.96344732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215143"},
        {"Hipparcos Number", "HIP 112179"},
        {"Fundamental Katalog 5th Edition", "FK5 3819"},
        {"Geneva Identification System", "GEN# +1.00215143"},
        {"Smithsonian Astrophysical Observation", "SAO 146273"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.80936458),
        dec: Angle.Degrees(-06.96291246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220531"},
        {"Hipparcos Number", "HIP 115557"},
        {"Smithsonian Astrophysical Observation", "SAO 146690"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.11265614),
        dec: Angle.Degrees(-06.96208307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94637"},
        {"Hipparcos Number", "HIP 53406"},
        {"Smithsonian Astrophysical Observation", "SAO 137890"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.84778817),
        dec: Angle.Degrees(-06.96057903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217572"},
        {"Hipparcos Number", "HIP 113709"},
        {"Smithsonian Astrophysical Observation", "SAO 146454"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.44115635),
        dec: Angle.Degrees(-06.96038265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56333"},
        {"Hipparcos Number", "HIP 35192"},
        {"Smithsonian Astrophysical Observation", "SAO 134443"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.09633693),
        dec: Angle.Degrees(-06.95938549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69485"},
        {"Geneva Identification System", "GEN# -0.00603950"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.37970418),
        dec: Angle.Degrees(-06.95931422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61202"},
        {"Hipparcos Number", "HIP 37138"},
        {"Smithsonian Astrophysical Observation", "SAO 134918"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.46486601),
        dec: Angle.Degrees(-06.95800046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199323"},
        {"Hipparcos Number", "HIP 103377"},
        {"Geneva Identification System", "GEN# +1.00199323"},
        {"Smithsonian Astrophysical Observation", "SAO 144963"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.16254862),
        dec: Angle.Degrees(-06.95685440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114595"},
        {"Smithsonian Astrophysical Observation", "SAO 146562"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.22331955),
        dec: Angle.Degrees(-06.95140641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149145"},
        {"Hipparcos Number", "HIP 81049"},
        {"Smithsonian Astrophysical Observation", "SAO 141233"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30470464),
        dec: Angle.Degrees(-06.94947271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112679"},
        {"Hipparcos Number", "HIP 63325"},
        {"Fundamental Katalog 5th Edition", "FK5 5145"},
        {"Smithsonian Astrophysical Observation", "SAO 139071"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.64968815),
        dec: Angle.Degrees(-06.94836138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148099"},
        {"Hipparcos Number", "HIP 80509"},
        {"Smithsonian Astrophysical Observation", "SAO 141169"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.52394640),
        dec: Angle.Degrees(-06.94564374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111693"},
        {"Hipparcos Number", "HIP 62727"},
        {"Smithsonian Astrophysical Observation", "SAO 138998"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.81019895),
        dec: Angle.Degrees(-06.94497184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101659"},
        {"Hipparcos Number", "HIP 57062"},
        {"Smithsonian Astrophysical Observation", "SAO 138355"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.46952995),
        dec: Angle.Degrees(-06.94245696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76770"},
        {"Hipparcos Number", "HIP 44036"},
        {"Smithsonian Astrophysical Observation", "SAO 136451"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.50815208),
        dec: Angle.Degrees(-06.94159223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128956"},
        {"Hipparcos Number", "HIP 71707"},
        {"Smithsonian Astrophysical Observation", "SAO 140058"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.01872655),
        dec: Angle.Degrees(-06.94120844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52564"},
        {"Hipparcos Number", "HIP 33840"},
        {"Smithsonian Astrophysical Observation", "SAO 134065"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.37280359),
        dec: Angle.Degrees(-06.93886772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222902"},
        {"Hipparcos Number", "HIP 117131"},
        {"Smithsonian Astrophysical Observation", "SAO 146884"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.19727292),
        dec: Angle.Degrees(-06.93671953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34417"},
        {"Hipparcos Number", "HIP 24627"},
        {"Celescope Catalog", "CEL 592"},
        {"Geneva Identification System", "GEN# +1.00034417"},
        {"Smithsonian Astrophysical Observation", "SAO 131943"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.23635794),
        dec: Angle.Degrees(-06.93635356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150558"},
        {"Hipparcos Number", "HIP 81766"},
        {"Smithsonian Astrophysical Observation", "SAO 141319"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.52962604),
        dec: Angle.Degrees(-06.93591573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127764"},
        {"Hipparcos Number", "HIP 71169"},
        {"Smithsonian Astrophysical Observation", "SAO 139994"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33842556),
        dec: Angle.Degrees(-06.93585814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37889"},
        {"Hipparcos Number", "HIP 26785"},
        {"Celescope Catalog", "CEL 934"},
        {"Geneva Identification System", "GEN# +1.00037889"},
        {"Smithsonian Astrophysical Observation", "SAO 132458"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.34335306),
        dec: Angle.Degrees(-06.93519766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115353"},
        {"Hipparcos Number", "HIP 64796"},
        {"Geneva Identification System", "GEN# +1.00115353"},
        {"Smithsonian Astrophysical Observation", "SAO 139257"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.20668527),
        dec: Angle.Degrees(-06.93476502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34813"},
        {"Hipparcos Number", "HIP 24867"},
        {"Celescope Catalog", "CEL 624"},
        {"Geneva Identification System", "GEN# +1.00034813"},
        {"Smithsonian Astrophysical Observation", "SAO 131991"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.96318915),
        dec: Angle.Degrees(-06.93109353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7240 AB"},
        {"Henry Draper", "HD 79179"},
        {"Hipparcos Number", "HIP 45180"},
        {"Smithsonian Astrophysical Observation", "SAO 136661"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.10537241),
        dec: Angle.Degrees(-06.93059006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110049"},
        {"Hipparcos Number", "HIP 61762"},
        {"Smithsonian Astrophysical Observation", "SAO 138896"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.87665287),
        dec: Angle.Degrees(-06.92890264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58824"},
        {"Smithsonian Astrophysical Observation", "SAO 138558"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.97138467),
        dec: Angle.Degrees(-06.92870422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15299"},
        {"Hipparcos Number", "HIP 11445"},
        {"Geneva Identification System", "GEN# +1.00015299"},
        {"Smithsonian Astrophysical Observation", "SAO 129918"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.91020856),
        dec: Angle.Degrees(-06.92863611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182556"},
        {"Hipparcos Number", "HIP 95499"},
        {"Smithsonian Astrophysical Observation", "SAO 143382"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37099030),
        dec: Angle.Degrees(-06.92827503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35885"},
        {"Hipparcos Number", "HIP 25522"},
        {"Geneva Identification System", "GEN# +1.00035885"},
        {"Smithsonian Astrophysical Observation", "SAO 132128"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.87178514),
        dec: Angle.Degrees(-06.92818903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121981"},
        {"Hipparcos Number", "HIP 68309"},
        {"Geneva Identification System", "GEN# +1.00121981"},
        {"Smithsonian Astrophysical Observation", "SAO 139660"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.74959833),
        dec: Angle.Degrees(-06.92505944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26409"},
        {"Hipparcos Number", "HIP 19483"},
        {"Geneva Identification System", "GEN# +1.00026409"},
        {"Smithsonian Astrophysical Observation", "SAO 131001"},
        {"Wilson Evans Batten Catalogue", "WEB 3734"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.59383269),
        dec: Angle.Degrees(-06.92382327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28384"},
        {"Hipparcos Number", "HIP 20874"},
        {"Smithsonian Astrophysical Observation", "SAO 131235"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09743364),
        dec: Angle.Degrees(-06.92361913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52186"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.92077456),
        dec: Angle.Degrees(-06.92349597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -715.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108521"},
        {"Hipparcos Number", "HIP 60827"},
        {"Smithsonian Astrophysical Observation", "SAO 138802"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01551075),
        dec: Angle.Degrees(-06.92262257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114916"},
        {"Hipparcos Number", "HIP 64547"},
        {"Smithsonian Astrophysical Observation", "SAO 139232"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.44719560),
        dec: Angle.Degrees(-06.92042000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53119"},
        {"Hipparcos Number", "HIP 34027"},
        {"Smithsonian Astrophysical Observation", "SAO 134126"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.89675992),
        dec: Angle.Degrees(-06.91881238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69076"},
        {"Hipparcos Number", "HIP 40419"},
        {"Geneva Identification System", "GEN# +1.00069076"},
        {"Smithsonian Astrophysical Observation", "SAO 135680"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.78223821),
        dec: Angle.Degrees(-06.91851209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10060"},
        {"Hipparcos Number", "HIP 7624"},
        {"Smithsonian Astrophysical Observation", "SAO 129420"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.54961329),
        dec: Angle.Degrees(-06.91675893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6564",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1123 AB"},
        {"Henry Draper", "HD 8556"},
        {"Hipparcos Number", "HIP 6564"},
        {"Geneva Identification System", "GEN# +1.00008556J"},
        {"Smithsonian Astrophysical Observation", "SAO 129277"},
        {"Wilson Evans Batten Catalogue", "WEB 1442"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.08535375),
        dec: Angle.Degrees(-06.91466853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216143"},
        {"Hipparcos Number", "HIP 112796"},
        {"Geneva Identification System", "GEN# +1.00216143"},
        {"Smithsonian Astrophysical Observation", "SAO 146344"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.62971229),
        dec: Angle.Degrees(-06.91350676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164762"},
        {"Hipparcos Number", "HIP 88392"},
        {"Smithsonian Astrophysical Observation", "SAO 142048"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.74535538),
        dec: Angle.Degrees(-06.91206101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158510"},
        {"Hipparcos Number", "HIP 85631"},
        {"Smithsonian Astrophysical Observation", "SAO 141693"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.49142028),
        dec: Angle.Degrees(-06.91177079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98355"},
        {"Hipparcos Number", "HIP 55239"},
        {"Smithsonian Astrophysical Observation", "SAO 138124"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.68324331),
        dec: Angle.Degrees(-06.91013474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145937"},
        {"Hipparcos Number", "HIP 79545"},
        {"Geneva Identification System", "GEN# +1.00145937"},
        {"Smithsonian Astrophysical Observation", "SAO 141044"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.47455623),
        dec: Angle.Degrees(-06.90849123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199702"},
        {"Hipparcos Number", "HIP 103575"},
        {"Geneva Identification System", "GEN# +1.00199702"},
        {"Smithsonian Astrophysical Observation", "SAO 145002"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77768715),
        dec: Angle.Degrees(-06.90666461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215389"},
        {"Hipparcos Number", "HIP 112308"},
        {"Geneva Identification System", "GEN# +1.00215389"},
        {"Smithsonian Astrophysical Observation", "SAO 146289"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.22495048),
        dec: Angle.Degrees(-06.90325466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126927"},
        {"Hipparcos Number", "HIP 70794"},
        {"Fundamental Katalog 5th Edition", "FK5 3143"},
        {"Geneva Identification System", "GEN# +1.00126927"},
        {"Smithsonian Astrophysical Observation", "SAO 139957"},
        {"Wilson Evans Batten Catalogue", "WEB 12265"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.17387790),
        dec: Angle.Degrees(-06.90041401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90976"},
        {"Cincinnati Publication", "Ci 20 1092"},
    },
    visualMagnitude: 12.21,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.36564501),
        dec: Angle.Degrees(-06.89965687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -652.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98489"},
        {"Hipparcos Number", "HIP 55322"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.93323063),
        dec: Angle.Degrees(-06.89858525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11713"},
        {"Smithsonian Astrophysical Observation", "SAO 129953"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.79692040),
        dec: Angle.Degrees(-06.89796747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35319"},
        {"Hipparcos Number", "HIP 25214"},
        {"Smithsonian Astrophysical Observation", "SAO 132058"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90574883),
        dec: Angle.Degrees(-06.89784344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60491"},
        {"Hipparcos Number", "HIP 36827"},
        {"Geneva Identification System", "GEN# +1.00060491"},
        {"Smithsonian Astrophysical Observation", "SAO 134849"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.60922880),
        dec: Angle.Degrees(-06.89657277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48978"},
        {"Hipparcos Number", "HIP 32403"},
        {"Smithsonian Astrophysical Observation", "SAO 133647"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.47394702),
        dec: Angle.Degrees(-06.89629048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102676"},
        {"Hipparcos Number", "HIP 57648"},
        {"Smithsonian Astrophysical Observation", "SAO 138425"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.31366468),
        dec: Angle.Degrees(-06.89490505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107307"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00946513),
        dec: Angle.Degrees(-06.89454117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129870"},
        {"Hipparcos Number", "HIP 72120"},
        {"Smithsonian Astrophysical Observation", "SAO 140115"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.29477231),
        dec: Angle.Degrees(-06.89363969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14699"},
    },
    visualMagnitude: 10.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.46970181),
        dec: Angle.Degrees(-06.89264578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91934"},
        {"Hipparcos Number", "HIP 51950"},
        {"Smithsonian Astrophysical Observation", "SAO 137675"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19274950),
        dec: Angle.Degrees(-06.89251429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173033"},
        {"Hipparcos Number", "HIP 91853"},
        {"Smithsonian Astrophysical Observation", "SAO 142551"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.90494702),
        dec: Angle.Degrees(-06.89185329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198949"},
        {"Hipparcos Number", "HIP 103154"},
        {"Geneva Identification System", "GEN# +1.00198949"},
        {"Smithsonian Astrophysical Observation", "SAO 144915"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.49321699),
        dec: Angle.Degrees(-06.88940714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83792"},
        {"Hipparcos Number", "HIP 47478"},
        {"Geneva Identification System", "GEN# +1.00083792"},
        {"Smithsonian Astrophysical Observation", "SAO 137050"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.17350347),
        dec: Angle.Degrees(-06.88904061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138777"},
        {"Hipparcos Number", "HIP 76245"},
        {"Renson", "Renson 39530"},
        {"Smithsonian Astrophysical Observation", "SAO 140615"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.61568040),
        dec: Angle.Degrees(-06.88789458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9492 A"},
        {"Henry Draper", "HD 133352"},
        {"Hipparcos Number", "HIP 73717"},
        {"Smithsonian Astrophysical Observation", "SAO 140297"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.02946396),
        dec: Angle.Degrees(-06.88733463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219448"},
        {"Hipparcos Number", "HIP 114860"},
        {"Smithsonian Astrophysical Observation", "SAO 146599"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.98645417),
        dec: Angle.Degrees(-06.88723934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28208"},
        {"Hipparcos Number", "HIP 20747"},
        {"Smithsonian Astrophysical Observation", "SAO 131213"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.69193828),
        dec: Angle.Degrees(-06.88240362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9339"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.98111579),
        dec: Angle.Degrees(-06.88153331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111488"},
        {"Hipparcos Number", "HIP 62605"},
        {"Smithsonian Astrophysical Observation", "SAO 138984"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.42800397),
        dec: Angle.Degrees(-06.88014658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14635"},
        {"Hipparcos Number", "HIP 11000"},
        {"Smithsonian Astrophysical Observation", "SAO 129851"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.43434853),
        dec: Angle.Degrees(-06.87965555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 296.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35901"},
        {"Hipparcos Number", "HIP 25536"},
        {"Geneva Identification System", "GEN# +1.00035901"},
        {"Renson", "Renson 9255"},
        {"Smithsonian Astrophysical Observation", "SAO 132133"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90558086),
        dec: Angle.Degrees(-06.87638659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146949"},
        {"Hipparcos Number", "HIP 79948"},
        {"Fundamental Katalog 5th Edition", "FK5 5438"},
        {"Geneva Identification System", "GEN# +1.00146949"},
        {"Smithsonian Astrophysical Observation", "SAO 141096"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.78924182),
        dec: Angle.Degrees(-06.87609160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11365"},
        {"Hipparcos Number", "HIP 8664"},
        {"Smithsonian Astrophysical Observation", "SAO 129539"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90749014),
        dec: Angle.Degrees(-06.87411986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215032"},
        {"Hipparcos Number", "HIP 112100"},
        {"Smithsonian Astrophysical Observation", "SAO 146256"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.59150167),
        dec: Angle.Degrees(-06.87116943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121894"},
        {"Hipparcos Number", "HIP 68254"},
        {"Smithsonian Astrophysical Observation", "SAO 139657"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.59839065),
        dec: Angle.Degrees(-06.87070207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127826"},
        {"Hipparcos Number", "HIP 71199"},
        {"Smithsonian Astrophysical Observation", "SAO 139997"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42147113),
        dec: Angle.Degrees(-06.87047680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60156"},
        {"Hipparcos Number", "HIP 36703"},
        {"Geneva Identification System", "GEN# +1.00060156"},
        {"Smithsonian Astrophysical Observation", "SAO 134826"},
        {"Wilson Evans Batten Catalogue", "WEB 7297"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.24617579),
        dec: Angle.Degrees(-06.86600496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38312"},
        {"Hipparcos Number", "HIP 27083"},
        {"Celescope Catalog", "CEL 958"},
        {"Geneva Identification System", "GEN# +1.00038312"},
        {"Renson", "Renson 10313"},
        {"Smithsonian Astrophysical Observation", "SAO 132505"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13829709),
        dec: Angle.Degrees(-06.86427477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162488"},
        {"Hipparcos Number", "HIP 87396"},
        {"Smithsonian Astrophysical Observation", "SAO 141909"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.90226397),
        dec: Angle.Degrees(-06.86325633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161607"},
        {"Hipparcos Number", "HIP 87016"},
        {"Smithsonian Astrophysical Observation", "SAO 141868"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71082355),
        dec: Angle.Degrees(-06.86249665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163998"},
        {"Hipparcos Number", "HIP 88078"},
        {"Smithsonian Astrophysical Observation", "SAO 142008"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.82538138),
        dec: Angle.Degrees(-06.85590210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105463"},
        {"Hipparcos Number", "HIP 59209"},
        {"Fundamental Katalog 5th Edition", "FK5 5075"},
        {"Smithsonian Astrophysical Observation", "SAO 138608"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.14672847),
        dec: Angle.Degrees(-06.85444694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56522"},
        {"Hipparcos Number", "HIP 35254"},
        {"Smithsonian Astrophysical Observation", "SAO 134458"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.26649273),
        dec: Angle.Degrees(-06.85165886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73580"},
        {"Hipparcos Number", "HIP 42412"},
        {"Smithsonian Astrophysical Observation", "SAO 136130"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.73463711),
        dec: Angle.Degrees(-06.84831228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39419"},
        {"Hipparcos Number", "HIP 27722"},
        {"Celescope Catalog", "CEL 1013"},
        {"Geneva Identification System", "GEN# +1.00039419"},
        {"Smithsonian Astrophysical Observation", "SAO 132604"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.05568851),
        dec: Angle.Degrees(-06.84801812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9060"},
        {"Hipparcos Number", "HIP 6920"},
        {"Smithsonian Astrophysical Observation", "SAO 129320"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.27694288),
        dec: Angle.Degrees(-06.84792410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138104"},
        {"Hipparcos Number", "HIP 75892"},
        {"Smithsonian Astrophysical Observation", "SAO 140569"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.52047726),
        dec: Angle.Degrees(-06.84501969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3877 A"},
        {"Henry Draper", "HD 34503"},
        {"Hipparcos Number", "HIP 24674"},
        {"Celescope Catalog", "CEL 598"},
        {"Fundamental Katalog 5th Edition", "FK5 195"},
        {"Geneva Identification System", "GEN# +1.00034503A"},
        {"Smithsonian Astrophysical Observation", "SAO 131952"},
        {"Wilson Evans Batten Catalogue", "WEB 4776"},
    },
    visualMagnitude: 3.59,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.40166225),
        dec: Angle.Degrees(-06.84438616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105932"},
        {"Cincinnati Publication", "Ci 20 1282"},
        {"Geneva Identification System", "GEN# +9.80026002"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82016620),
        dec: Angle.Degrees(-06.84330192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -403.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73861"},
        {"Smithsonian Astrophysical Observation", "SAO 140316"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.42713744),
        dec: Angle.Degrees(-06.84329104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176158"},
        {"Hipparcos Number", "HIP 93212"},
        {"Celescope Catalog", "CEL 4674"},
        {"Geneva Identification System", "GEN# +1.00176158"},
        {"Smithsonian Astrophysical Observation", "SAO 142879"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.80309215),
        dec: Angle.Degrees(-06.84205442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 533"},
        {"Hipparcos Number", "HIP 792"},
        {"Geneva Identification System", "GEN# +1.00000533"},
        {"Smithsonian Astrophysical Observation", "SAO 128617"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.45274609),
        dec: Angle.Degrees(-06.84116094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145733"},
        {"Hipparcos Number", "HIP 79447"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.19930443),
        dec: Angle.Degrees(-06.84038469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116610"},
        {"Hipparcos Number", "HIP 65447"},
        {"Smithsonian Astrophysical Observation", "SAO 139327"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.20108852),
        dec: Angle.Degrees(-06.84033431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36813"},
        {"Hipparcos Number", "HIP 26112"},
        {"Geneva Identification System", "GEN# +1.00036813"},
        {"Smithsonian Astrophysical Observation", "SAO 132273"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.52279120),
        dec: Angle.Degrees(-06.83809169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19587",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Beid"},
        {"Henry Draper", "HD 26574"},
        {"Hipparcos Number", "HIP 19587"},
        {"Fundamental Katalog 5th Edition", "FK5 154"},
        {"Geneva Identification System", "GEN# +1.00026574"},
        {"Smithsonian Astrophysical Observation", "SAO 131019"},
        {"Wilson Evans Batten Catalogue", "WEB 3747"},
    },
    visualMagnitude: 4.04,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.96638834),
        dec: Angle.Degrees(-06.83777870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29063"},
        {"Hipparcos Number", "HIP 21298"},
        {"Geneva Identification System", "GEN# +1.00029063"},
        {"Smithsonian Astrophysical Observation", "SAO 131317"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.55919586),
        dec: Angle.Degrees(-06.83771702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192770"},
        {"Hipparcos Number", "HIP 99962"},
        {"Smithsonian Astrophysical Observation", "SAO 144236"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.22140586),
        dec: Angle.Degrees(-06.83758564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120235"},
        {"Hipparcos Number", "HIP 67355"},
        {"Smithsonian Astrophysical Observation", "SAO 139559"},
        {"Wilson Evans Batten Catalogue", "WEB 11848"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.07503797),
        dec: Angle.Degrees(-06.83733465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221149"},
        {"Hipparcos Number", "HIP 115958"},
        {"Geneva Identification System", "GEN# +1.00221149"},
        {"Smithsonian Astrophysical Observation", "SAO 146737"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.40142167),
        dec: Angle.Degrees(-06.83574430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99968"},
        {"Hipparcos Number", "HIP 56108"},
        {"Smithsonian Astrophysical Observation", "SAO 138237"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.51308059),
        dec: Angle.Degrees(-06.83447204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35334"},
        {"Hipparcos Number", "HIP 25232"},
        {"Smithsonian Astrophysical Observation", "SAO 132062"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.94227466),
        dec: Angle.Degrees(-06.83436153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84210"},
        {"Hipparcos Number", "HIP 47687"},
        {"Smithsonian Astrophysical Observation", "SAO 137079"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.85160125),
        dec: Angle.Degrees(-06.83427796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142865"},
        {"Hipparcos Number", "HIP 78121"},
        {"Geneva Identification System", "GEN# +1.00142865"},
        {"Smithsonian Astrophysical Observation", "SAO 140852"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.28120420),
        dec: Angle.Degrees(-06.82817013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11982"},
        {"Hipparcos Number", "HIP 9117"},
        {"Smithsonian Astrophysical Observation", "SAO 129580"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.38000589),
        dec: Angle.Degrees(-06.82781097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18280"},
        {"Cincinnati Publication", "Ci 20 270"},
        {"Geneva Identification System", "GEN# -0.00700699"},
        {"Smithsonian Astrophysical Observation", "SAO 130811"},
        {"Wilson Evans Batten Catalogue", "WEB 3531"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64778859),
        dec: Angle.Degrees(-06.82729666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 529.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13616"},
        {"Smithsonian Astrophysical Observation", "SAO 130189"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.85667105),
        dec: Angle.Degrees(-06.82722212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136544"},
        {"Hipparcos Number", "HIP 75158"},
        {"Geneva Identification System", "GEN# +1.00136544"},
        {"Smithsonian Astrophysical Observation", "SAO 140480"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.38683413),
        dec: Angle.Degrees(-06.82653333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41007",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6768 AB"},
        {"Henry Draper", "HD 70497"},
        {"Hipparcos Number", "HIP 41007"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53496422),
        dec: Angle.Degrees(-06.82464725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43065"},
        {"Hipparcos Number", "HIP 29578"},
        {"Smithsonian Astrophysical Observation", "SAO 132995"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.48447915),
        dec: Angle.Degrees(-06.82314946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43844"},
        {"Hipparcos Number", "HIP 29937"},
        {"Smithsonian Astrophysical Observation", "SAO 133077"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.53680647),
        dec: Angle.Degrees(-06.82227391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94280"},
        {"Hipparcos Number", "HIP 53196"},
        {"Fundamental Katalog 5th Edition", "FK5 2867"},
        {"Geneva Identification System", "GEN# +1.00094280"},
        {"Smithsonian Astrophysical Observation", "SAO 137858"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20444839),
        dec: Angle.Degrees(-06.82153375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42132"},
        {"Hipparcos Number", "HIP 29140"},
        {"Geneva Identification System", "GEN# +1.00042132"},
        {"Smithsonian Astrophysical Observation", "SAO 132884"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.19883451),
        dec: Angle.Degrees(-06.82139251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173093"},
        {"Hipparcos Number", "HIP 91880"},
        {"Geneva Identification System", "GEN# +1.00173093"},
        {"Smithsonian Astrophysical Observation", "SAO 142557"},
        {"Wilson Evans Batten Catalogue", "WEB 15818"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.96340419),
        dec: Angle.Degrees(-06.81801161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117031"},
        {"Hipparcos Number", "HIP 65656"},
        {"Smithsonian Astrophysical Observation", "SAO 139348"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.92217095),
        dec: Angle.Degrees(-06.81586290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23925"},
        {"Hipparcos Number", "HIP 17806"},
        {"Geneva Identification System", "GEN# +1.00023925"},
        {"Smithsonian Astrophysical Observation", "SAO 130741"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16272768),
        dec: Angle.Degrees(-06.81581061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40986"},
        {"Hipparcos Number", "HIP 28585"},
        {"Smithsonian Astrophysical Observation", "SAO 132760"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.51891363),
        dec: Angle.Degrees(-06.81579224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216905"},
        {"Hipparcos Number", "HIP 113329"},
        {"Smithsonian Astrophysical Observation", "SAO 146400"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26903993),
        dec: Angle.Degrees(-06.81567941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206158"},
        {"Hipparcos Number", "HIP 107009"},
        {"Geneva Identification System", "GEN# +1.00206158"},
        {"Smithsonian Astrophysical Observation", "SAO 145576"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.09173256),
        dec: Angle.Degrees(-06.81321565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35413"},
        {"Hipparcos Number", "HIP 25271"},
        {"Geneva Identification System", "GEN# +1.00035413"},
        {"Smithsonian Astrophysical Observation", "SAO 132069"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.06781467),
        dec: Angle.Degrees(-06.81063645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6900 A"},
        {"Henry Draper", "HD 73350"},
        {"Hipparcos Number", "HIP 42333"},
        {"Geneva Identification System", "GEN# +1.00073350"},
        {"Smithsonian Astrophysical Observation", "SAO 136111"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.46028541),
        dec: Angle.Degrees(-06.80699027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -298.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17711"},
        {"Hipparcos Number", "HIP 13231"},
        {"Smithsonian Astrophysical Observation", "SAO 130140"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.58418893),
        dec: Angle.Degrees(-06.80661673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171999"},
        {"Hipparcos Number", "HIP 91360"},
        {"Cincinnati Publication", "Ci 20 1096"},
        {"Cincinnati Publication 2", "Ci 18 2444"},
        {"Geneva Identification System", "GEN# +1.00171999"},
        {"Smithsonian Astrophysical Observation", "SAO 142451"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.49539281),
        dec: Angle.Degrees(-06.80451053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64148"},
        {"Hipparcos Number", "HIP 38428"},
        {"Smithsonian Astrophysical Observation", "SAO 135194"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.08209589),
        dec: Angle.Degrees(-06.80437222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21665"},
        {"Hipparcos Number", "HIP 16266"},
        {"Geneva Identification System", "GEN# +1.00021665"},
        {"Smithsonian Astrophysical Observation", "SAO 130520"},
        {"Wilson Evans Batten Catalogue", "WEB 3101"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.41328224),
        dec: Angle.Degrees(-06.80423924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32841"},
        {"Hipparcos Number", "HIP 23706"},
        {"Smithsonian Astrophysical Observation", "SAO 131759"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.44509508),
        dec: Angle.Degrees(-06.80182739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47273"},
        {"Smithsonian Astrophysical Observation", "SAO 137013"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.51795963),
        dec: Angle.Degrees(-06.80129973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6031"},
        {"Hipparcos Number", "HIP 4796"},
        {"Fundamental Katalog 5th Edition", "FK5 4097"},
        {"Smithsonian Astrophysical Observation", "SAO 129088"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.39296248),
        dec: Angle.Degrees(-06.79952311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19912"},
        {"Hipparcos Number", "HIP 14866"},
        {"Smithsonian Astrophysical Observation", "SAO 130339"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98711788),
        dec: Angle.Degrees(-06.79852812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52919"},
        {"Hipparcos Number", "HIP 33955"},
        {"Geneva Identification System", "GEN# +1.00052919"},
        {"Smithsonian Astrophysical Observation", "SAO 134098"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.67931488),
        dec: Angle.Degrees(-06.79846402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177532"},
        {"Hipparcos Number", "HIP 93751"},
        {"Smithsonian Astrophysical Observation", "SAO 143004"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.35995076),
        dec: Angle.Degrees(-06.79781878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196944"},
        {"Hipparcos Number", "HIP 102042"},
        {"Geneva Identification System", "GEN# +1.00196944"},
        {"Smithsonian Astrophysical Observation", "SAO 144688"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.19192138),
        dec: Angle.Degrees(-06.79733654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171955"},
        {"Hipparcos Number", "HIP 91342"},
        {"Fundamental Katalog 5th Edition", "FK5 5639"},
        {"Geneva Identification System", "GEN# +1.00171955"},
        {"Smithsonian Astrophysical Observation", "SAO 142447"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.46293941),
        dec: Angle.Degrees(-06.79681187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4299 AB"},
        {"Henry Draper", "HD 38089"},
        {"Hipparcos Number", "HIP 26926"},
        {"Celescope Catalog", "CEL 940"},
        {"Geneva Identification System", "GEN# +1.00038089J"},
        {"Smithsonian Astrophysical Observation", "SAO 132477"},
        {"Wilson Evans Batten Catalogue", "WEB 5308"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.72461574),
        dec: Angle.Degrees(-06.79631491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187305"},
        {"Hipparcos Number", "HIP 97549"},
        {"Smithsonian Astrophysical Observation", "SAO 143822"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.40738936),
        dec: Angle.Degrees(-06.79628527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100698",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13816 AB"},
        {"Henry Draper", "HD 194265"},
        {"Hipparcos Number", "HIP 100698"},
        {"Smithsonian Astrophysical Observation", "SAO 144401"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.22739145),
        dec: Angle.Degrees(-06.79566237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83038"},
        {"Hipparcos Number", "HIP 47075"},
        {"Smithsonian Astrophysical Observation", "SAO 136987"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91085012),
        dec: Angle.Degrees(-06.79538139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 391"},
        {"Hipparcos Number", "HIP 692"},
        {"Smithsonian Astrophysical Observation", "SAO 128605"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.12860271),
        dec: Angle.Degrees(-06.79215910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41044"},
        {"Hipparcos Number", "HIP 28616"},
        {"Smithsonian Astrophysical Observation", "SAO 132768"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.60685324),
        dec: Angle.Degrees(-06.79034990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14906"},
        {"Hipparcos Number", "HIP 11199"},
        {"Smithsonian Astrophysical Observation", "SAO 129875"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.05290096),
        dec: Angle.Degrees(-06.78843291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134828"},
        {"Hipparcos Number", "HIP 74393"},
        {"Smithsonian Astrophysical Observation", "SAO 140376"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.05636827),
        dec: Angle.Degrees(-06.78712742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184388"},
        {"Hipparcos Number", "HIP 96269"},
        {"Smithsonian Astrophysical Observation", "SAO 143545"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.62599316),
        dec: Angle.Degrees(-06.78641925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156318"},
        {"Hipparcos Number", "HIP 84563"},
        {"Smithsonian Astrophysical Observation", "SAO 141590"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.29678282),
        dec: Angle.Degrees(-06.78545317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43511",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7053 AB"},
        {"Henry Draper", "HD 75770"},
        {"Hipparcos Number", "HIP 43511"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93741576),
        dec: Angle.Degrees(-06.78430867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7268"},
        {"Hipparcos Number", "HIP 5666"},
        {"Geneva Identification System", "GEN# +1.00007268"},
        {"Smithsonian Astrophysical Observation", "SAO 129177"},
        {"Wilson Evans Batten Catalogue", "WEB 1283"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.19889658),
        dec: Angle.Degrees(-06.78333777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194229"},
        {"Hipparcos Number", "HIP 100676"},
        {"Smithsonian Astrophysical Observation", "SAO 144393"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17926221),
        dec: Angle.Degrees(-06.78261410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91624"},
        {"Geneva Identification System", "GEN# -0.00604834"},
        {"Wilson Evans Batten Catalogue", "WEB 15757"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.29260053),
        dec: Angle.Degrees(-06.78228445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103409"},
        {"Hipparcos Number", "HIP 58051"},
        {"Smithsonian Astrophysical Observation", "SAO 138472"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.59922465),
        dec: Angle.Degrees(-06.78111785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167353"},
        {"Hipparcos Number", "HIP 89427"},
        {"Geneva Identification System", "GEN# +1.00167353"},
        {"Smithsonian Astrophysical Observation", "SAO 142179"},
    },
    visualMagnitude: 8.73,
    bvColour: 2.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.76781929),
        dec: Angle.Degrees(-06.78100170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109331"},
        {"Hipparcos Number", "HIP 61326"},
        {"Geneva Identification System", "GEN# +1.00109331"},
        {"Smithsonian Astrophysical Observation", "SAO 138847"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.48067080),
        dec: Angle.Degrees(-06.77784595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22820"},
        {"Hipparcos Number", "HIP 17101"},
        {"Smithsonian Astrophysical Observation", "SAO 130642"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.94649566),
        dec: Angle.Degrees(-06.77720997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37663"},
        {"Hipparcos Number", "HIP 26659"},
        {"Geneva Identification System", "GEN# +1.00037663"},
        {"Smithsonian Astrophysical Observation", "SAO 132430"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.98663337),
        dec: Angle.Degrees(-06.77528307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63355"},
        {"Hipparcos Number", "HIP 38083"},
        {"Smithsonian Astrophysical Observation", "SAO 135118"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.06635664),
        dec: Angle.Degrees(-06.77381794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62902"},
        {"Hipparcos Number", "HIP 37901"},
        {"Geneva Identification System", "GEN# +1.00062902"},
        {"Smithsonian Astrophysical Observation", "SAO 135079"},
        {"Wilson Evans Batten Catalogue", "WEB 7480"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50900614),
        dec: Angle.Degrees(-06.77228458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93800"},
        {"Hipparcos Number", "HIP 52933"},
        {"Smithsonian Astrophysical Observation", "SAO 137812"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.38254048),
        dec: Angle.Degrees(-06.76972862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37888"},
        {"Hipparcos Number", "HIP 26797"},
        {"Geneva Identification System", "GEN# +1.00037888"},
        {"Smithsonian Astrophysical Observation", "SAO 132459"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.36478416),
        dec: Angle.Degrees(-06.76874402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1376 AB"},
        {"Henry Draper", "HD 10725"},
        {"Hipparcos Number", "HIP 8143"},
        {"Smithsonian Astrophysical Observation", "SAO 129482"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.18195961),
        dec: Angle.Degrees(-06.76617551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105266"},
        {"Hipparcos Number", "HIP 59108"},
        {"Geneva Identification System", "GEN# +1.00105266"},
        {"Smithsonian Astrophysical Observation", "SAO 138594"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.81216556),
        dec: Angle.Degrees(-06.76561392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83971"},
        {"Hipparcos Number", "HIP 47561"},
        {"Smithsonian Astrophysical Observation", "SAO 137058"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.45649092),
        dec: Angle.Degrees(-06.76127771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191030"},
        {"Hipparcos Number", "HIP 99179"},
        {"Smithsonian Astrophysical Observation", "SAO 144096"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03155212),
        dec: Angle.Degrees(-06.76124432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10008"},
        {"Hipparcos Number", "HIP 7576"},
        {"Geneva Identification System", "GEN# +1.00010008"},
        {"Smithsonian Astrophysical Observation", "SAO 129411"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.39735704),
        dec: Angle.Degrees(-06.76018613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149144"},
        {"Hipparcos Number", "HIP 81046"},
        {"Geneva Identification System", "GEN# +1.00149144"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30049093),
        dec: Angle.Degrees(-06.75989204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56204"},
        {"Hipparcos Number", "HIP 35144"},
        {"Smithsonian Astrophysical Observation", "SAO 134427"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.97190672),
        dec: Angle.Degrees(-06.75708444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1345"},
        {"Aitken 2", "ADS 1345 AB"},
        {"Henry Draper", "HD 10508"},
        {"Hipparcos Number", "HIP 7968"},
        {"Smithsonian Astrophysical Observation", "SAO 129462"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.59833948),
        dec: Angle.Degrees(-06.75480098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42536"},
        {"Hipparcos Number", "HIP 29323"},
        {"Geneva Identification System", "GEN# +1.00042536"},
        {"Renson", "Renson 11340"},
        {"Smithsonian Astrophysical Observation", "SAO 132924"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.75506934),
        dec: Angle.Degrees(-06.75419311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89964"},
        {"Hipparcos Number", "HIP 50833"},
        {"Smithsonian Astrophysical Observation", "SAO 137525"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.69536245),
        dec: Angle.Degrees(-06.75358521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38275"},
        {"Hipparcos Number", "HIP 27061"},
        {"Smithsonian Astrophysical Observation", "SAO 132500"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.08130072),
        dec: Angle.Degrees(-06.75241538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39716"},
        {"Hipparcos Number", "HIP 27884"},
        {"Celescope Catalog", "CEL 1025"},
        {"Geneva Identification System", "GEN# +1.00039716"},
        {"Smithsonian Astrophysical Observation", "SAO 132628"},
        {"Wilson Evans Batten Catalogue", "WEB 5459"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.51387133),
        dec: Angle.Degrees(-06.75230512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214060"},
        {"Hipparcos Number", "HIP 111531"},
        {"Smithsonian Astrophysical Observation", "SAO 146183"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94042852),
        dec: Angle.Degrees(-06.75228115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33994"},
        {"Hipparcos Number", "HIP 24378"},
        {"Celescope Catalog", "CEL 576"},
        {"Geneva Identification System", "GEN# +1.00033994"},
        {"Smithsonian Astrophysical Observation", "SAO 131893"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.44869682),
        dec: Angle.Degrees(-06.74827095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68145"},
        {"Hipparcos Number", "HIP 40057"},
        {"Smithsonian Astrophysical Observation", "SAO 135592"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.74359954),
        dec: Angle.Degrees(-06.74796115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181394"},
        {"Henry Draper 2", "HD 181395"},
        {"Hipparcos Number", "HIP 95068"},
        {"Smithsonian Astrophysical Observation", "SAO 143287"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.14193592),
        dec: Angle.Degrees(-06.74766985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29765"},
        {"Hipparcos Number", "HIP 21808"},
        {"Smithsonian Astrophysical Observation", "SAO 131405"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.27073102),
        dec: Angle.Degrees(-06.74750463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125490"},
        {"Hipparcos Number", "HIP 70038"},
        {"Geneva Identification System", "GEN# +1.00125490"},
        {"Smithsonian Astrophysical Observation", "SAO 139868"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.97189100),
        dec: Angle.Degrees(-06.74610982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122255"},
        {"Hipparcos Number", "HIP 68458"},
        {"Geneva Identification System", "GEN# +1.00122255"},
        {"Smithsonian Astrophysical Observation", "SAO 139678"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.22518683),
        dec: Angle.Degrees(-06.74596889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67939"},
        {"Hipparcos Number", "HIP 39997"},
        {"Smithsonian Astrophysical Observation", "SAO 135580"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.52692696),
        dec: Angle.Degrees(-06.74514584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203719"},
        {"Hipparcos Number", "HIP 105667"},
        {"Geneva Identification System", "GEN# +1.00203719"},
        {"Smithsonian Astrophysical Observation", "SAO 145365"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.04577733),
        dec: Angle.Degrees(-06.74379714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171610"},
        {"Hipparcos Number", "HIP 91185"},
        {"Smithsonian Astrophysical Observation", "SAO 142415"},
        {"Wilson Evans Batten Catalogue", "WEB 15657"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03266994),
        dec: Angle.Degrees(-06.74201793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21278",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3305 A"},
        {"Henry Draper", "HD 29009"},
        {"Hipparcos Number", "HIP 21278"},
        {"Geneva Identification System", "GEN# +1.00029009J"},
        {"Renson", "Renson 7420"},
        {"Smithsonian Astrophysical Observation", "SAO 131309"},
        {"Wilson Evans Batten Catalogue", "WEB 4090"},
    },
    visualMagnitude: 5.71,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.47804057),
        dec: Angle.Degrees(-06.73889608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53639"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.60251805),
        dec: Angle.Degrees(-06.73718245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -405.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153759"},
        {"Hipparcos Number", "HIP 83311"},
        {"Renson", "Renson 43420"},
        {"Smithsonian Astrophysical Observation", "SAO 141489"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.39533914),
        dec: Angle.Degrees(-06.73640699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135579"},
        {"Hipparcos Number", "HIP 74708"},
        {"Smithsonian Astrophysical Observation", "SAO 140423"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.01715840),
        dec: Angle.Degrees(-06.73632876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21216"},
        {"Hipparcos Number", "HIP 15929"},
        {"Geneva Identification System", "GEN# +1.00021216"},
        {"Smithsonian Astrophysical Observation", "SAO 130475"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.29432743),
        dec: Angle.Degrees(-06.73568066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211099"},
        {"Hipparcos Number", "HIP 109849"},
        {"Geneva Identification System", "GEN# +1.00211099"},
        {"Renson", "Renson 58630"},
        {"Smithsonian Astrophysical Observation", "SAO 145968"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.72520528),
        dec: Angle.Degrees(-06.73546367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13104 AB"},
        {"Henry Draper", "HD 188405"},
        {"Hipparcos Number", "HIP 98038"},
        {"Geneva Identification System", "GEN# +1.00188405J"},
        {"Smithsonian Astrophysical Observation", "SAO 143911"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83121009),
        dec: Angle.Degrees(-06.73463769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129903"},
        {"Hipparcos Number", "HIP 72138"},
        {"Geneva Identification System", "GEN# +1.00129903"},
        {"Smithsonian Astrophysical Observation", "SAO 140120"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33463975),
        dec: Angle.Degrees(-06.73459629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38239"},
        {"Hipparcos Number", "HIP 27035"},
        {"Celescope Catalog", "CEL 952"},
        {"Geneva Identification System", "GEN# +1.00038239"},
        {"Smithsonian Astrophysical Observation", "SAO 132495"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.01055313),
        dec: Angle.Degrees(-06.73335469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215718"},
        {"Hipparcos Number", "HIP 112507"},
        {"Fundamental Katalog 5th Edition", "FK5 6009"},
        {"Geneva Identification System", "GEN# +1.00215718"},
        {"Smithsonian Astrophysical Observation", "SAO 146308"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.84291503),
        dec: Angle.Degrees(-06.73032670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94471"},
        {"Hipparcos Number", "HIP 53309"},
        {"Smithsonian Astrophysical Observation", "SAO 137874"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.54930638),
        dec: Angle.Degrees(-06.72962433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209907"},
        {"Hipparcos Number", "HIP 109167"},
        {"Smithsonian Astrophysical Observation", "SAO 145871"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.69345473),
        dec: Angle.Degrees(-06.72935265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145125"},
        {"Hipparcos Number", "HIP 79174"},
        {"Smithsonian Astrophysical Observation", "SAO 140995"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.38374817),
        dec: Angle.Degrees(-06.72773507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27092"},
        {"Hipparcos Number", "HIP 19933"},
        {"Geneva Identification System", "GEN# +1.00027092"},
        {"Smithsonian Astrophysical Observation", "SAO 131083"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13922816),
        dec: Angle.Degrees(-06.72758079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43843"},
        {"Hipparcos Number", "HIP 29936"},
        {"Smithsonian Astrophysical Observation", "SAO 133076"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.53518877),
        dec: Angle.Degrees(-06.72546865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126249"},
        {"Hipparcos Number", "HIP 70433"},
        {"Smithsonian Astrophysical Observation", "SAO 139914"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.12782376),
        dec: Angle.Degrees(-06.72528247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24068"},
        {"Smithsonian Astrophysical Observation", "SAO 131840"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.57447973),
        dec: Angle.Degrees(-06.72171571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5472"},
        {"Hipparcos Number", "HIP 4403"},
        {"Smithsonian Astrophysical Observation", "SAO 129042"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.11695537),
        dec: Angle.Degrees(-06.72105884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165439"},
        {"Hipparcos Number", "HIP 88692"},
        {"Renson", "Renson 46645"},
        {"Smithsonian Astrophysical Observation", "SAO 142087"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.58819485),
        dec: Angle.Degrees(-06.71978280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61811"},
        {"Hipparcos Number", "HIP 37420"},
        {"Geneva Identification System", "GEN# +1.00061811"},
        {"Smithsonian Astrophysical Observation", "SAO 134976"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.22619219),
        dec: Angle.Degrees(-06.71967627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8190 A"},
        {"Henry Draper", "HD 100070"},
        {"Hipparcos Number", "HIP 56166"},
        {"Geneva Identification System", "GEN# +1.00100070"},
        {"Smithsonian Astrophysical Observation", "SAO 138243"},
        {"Wilson Evans Batten Catalogue", "WEB 10085"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.71249480),
        dec: Angle.Degrees(-06.71901284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9359"},
        {"Hipparcos Number", "HIP 7140"},
        {"Smithsonian Astrophysical Observation", "SAO 129352"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.00373135),
        dec: Angle.Degrees(-06.71870411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59670"},
        {"Hipparcos Number", "HIP 36517"},
        {"Smithsonian Astrophysical Observation", "SAO 134771"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.68841208),
        dec: Angle.Degrees(-06.71792905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134409"},
        {"Hipparcos Number", "HIP 74213"},
        {"Geneva Identification System", "GEN# +1.00134409"},
        {"Smithsonian Astrophysical Observation", "SAO 140357"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.48369937),
        dec: Angle.Degrees(-06.71770262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35223"},
        {"Hipparcos Number", "HIP 25153"},
        {"Celescope Catalog", "CEL 664"},
        {"Geneva Identification System", "GEN# +1.00035223"},
        {"Smithsonian Astrophysical Observation", "SAO 132043"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.74265205),
        dec: Angle.Degrees(-06.71755598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11205"},
        {"Hipparcos Number", "HIP 8531"},
        {"Fundamental Katalog 5th Edition", "FK5 4168"},
        {"Smithsonian Astrophysical Observation", "SAO 129525"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.50424058),
        dec: Angle.Degrees(-06.71673133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4209 A"},
        {"Hipparcos Number", "HIP 26327"},
        {"Geneva Identification System", "GEN# -0.00601253"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.10595561),
        dec: Angle.Degrees(-06.71601525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79911"},
        {"Hipparcos Number", "HIP 45530"},
        {"Smithsonian Astrophysical Observation", "SAO 136727"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.17857249),
        dec: Angle.Degrees(-06.71571126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203793"},
        {"Hipparcos Number", "HIP 105705"},
        {"Geneva Identification System", "GEN# +1.00203793"},
        {"Smithsonian Astrophysical Observation", "SAO 145370"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.14987594),
        dec: Angle.Degrees(-06.71518592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152556"},
        {"Hipparcos Number", "HIP 82699"},
        {"Smithsonian Astrophysical Observation", "SAO 141428"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57470956),
        dec: Angle.Degrees(-06.71178840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58527"},
        {"Hipparcos Number", "HIP 36052"},
        {"Smithsonian Astrophysical Observation", "SAO 134653"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.45260925),
        dec: Angle.Degrees(-06.71060574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41335"},
        {"Hipparcos Number", "HIP 28744"},
        {"Geneva Identification System", "GEN# +1.00041335"},
        {"Smithsonian Astrophysical Observation", "SAO 132793"},
        {"Wilson Evans Batten Catalogue", "WEB 5624"},
    },
    visualMagnitude: 5.19,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.05626466),
        dec: Angle.Degrees(-06.70895020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185511"},
        {"Hipparcos Number", "HIP 96718"},
        {"Smithsonian Astrophysical Observation", "SAO 143658"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.91752119),
        dec: Angle.Degrees(-06.70855693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36430"},
        {"Hipparcos Number", "HIP 25869"},
        {"Celescope Catalog", "CEL 754"},
        {"Geneva Identification System", "GEN# +1.00036430"},
        {"Smithsonian Astrophysical Observation", "SAO 132210"},
        {"Wilson Evans Batten Catalogue", "WEB 5023"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.83705135),
        dec: Angle.Degrees(-06.70838162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36541"},
        {"Hipparcos Number", "HIP 25937"},
        {"Celescope Catalog", "CEL 768"},
        {"Geneva Identification System", "GEN# +1.00036541"},
        {"Smithsonian Astrophysical Observation", "SAO 132225"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.02928967),
        dec: Angle.Degrees(-06.70830650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7606 AB"},
        {"Henry Draper", "HD 86710"},
        {"Hipparcos Number", "HIP 49031"},
        {"Smithsonian Astrophysical Observation", "SAO 137279"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.05535034),
        dec: Angle.Degrees(-06.70578267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120088"},
        {"Hipparcos Number", "HIP 67289"},
        {"Smithsonian Astrophysical Observation", "SAO 139548"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.85585318),
        dec: Angle.Degrees(-06.70538619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11226"},
        {"Hipparcos Number", "HIP 8548"},
        {"Geneva Identification System", "GEN# +1.00011226"},
        {"Smithsonian Astrophysical Observation", "SAO 129526"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.56381549),
        dec: Angle.Degrees(-06.70418331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143080"},
        {"Hipparcos Number", "HIP 78247"},
        {"Smithsonian Astrophysical Observation", "SAO 140870"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64705281),
        dec: Angle.Degrees(-06.70362704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84391"},
        {"Hipparcos Number", "HIP 47825"},
        {"Smithsonian Astrophysical Observation", "SAO 137098"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22295245),
        dec: Angle.Degrees(-06.70356707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20215"},
        {"Hipparcos Number", "HIP 15093"},
        {"Smithsonian Astrophysical Observation", "SAO 130376"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.67586362),
        dec: Angle.Degrees(-06.70245182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17310"},
        {"Hipparcos Number", "HIP 12953"},
        {"Geneva Identification System", "GEN# +1.00017310"},
        {"Smithsonian Astrophysical Observation", "SAO 130106"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.64155914),
        dec: Angle.Degrees(-06.70186038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168159"},
        {"Hipparcos Number", "HIP 89728"},
        {"Geneva Identification System", "GEN# +1.00168159"},
        {"Smithsonian Astrophysical Observation", "SAO 142214"},
        {"Wilson Evans Batten Catalogue", "WEB 15297"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66965807),
        dec: Angle.Degrees(-06.70100658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188844"},
        {"Hipparcos Number", "HIP 98210"},
        {"Geneva Identification System", "GEN# +1.00188844"},
        {"Smithsonian Astrophysical Observation", "SAO 143942"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.35300325),
        dec: Angle.Degrees(-06.69754483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198334"},
        {"Hipparcos Number", "HIP 102820"},
        {"Geneva Identification System", "GEN# +1.00198334"},
        {"Smithsonian Astrophysical Observation", "SAO 144849"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.45323215),
        dec: Angle.Degrees(-06.69696737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21251"},
        {"Hipparcos Number", "HIP 15962"},
        {"Geneva Identification System", "GEN# +1.00021251"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.37970897),
        dec: Angle.Degrees(-06.69547933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70631"},
        {"Hipparcos Number", "HIP 41073"},
        {"Geneva Identification System", "GEN# +1.00070631"},
        {"Smithsonian Astrophysical Observation", "SAO 135836"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.70445732),
        dec: Angle.Degrees(-06.69471279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44321"},
        {"Hipparcos Number", "HIP 30176"},
        {"Celescope Catalog", "CEL 1192"},
        {"Geneva Identification System", "GEN# +1.00044321"},
        {"Smithsonian Astrophysical Observation", "SAO 133142"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.24282413),
        dec: Angle.Degrees(-06.69196383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92439"},
        {"Hipparcos Number", "HIP 52233"},
        {"Smithsonian Astrophysical Observation", "SAO 137716"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.06510589),
        dec: Angle.Degrees(-06.69051270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217951"},
        {"Hipparcos Number", "HIP 113936"},
        {"Smithsonian Astrophysical Observation", "SAO 146488"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.09513670),
        dec: Angle.Degrees(-06.68960721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97055"},
        {"Hipparcos Number", "HIP 54589"},
        {"Smithsonian Astrophysical Observation", "SAO 138024"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.57673673),
        dec: Angle.Degrees(-06.68874668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129656"},
        {"Hipparcos Number", "HIP 72020"},
        {"Smithsonian Astrophysical Observation", "SAO 140098"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.96223103),
        dec: Angle.Degrees(-06.68816478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146623"},
        {"Hipparcos Number", "HIP 79821"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.37544434),
        dec: Angle.Degrees(-06.68789777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4425"},
        {"Hipparcos Number", "HIP 3622"},
        {"Smithsonian Astrophysical Observation", "SAO 128947"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.61482586),
        dec: Angle.Degrees(-06.68512855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101644"},
        {"Hipparcos Number", "HIP 57051"},
        {"Smithsonian Astrophysical Observation", "SAO 138353"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43823436),
        dec: Angle.Degrees(-06.68445477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106431"},
        {"Hipparcos Number", "HIP 59703"},
        {"Smithsonian Astrophysical Observation", "SAO 138668"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.66128464),
        dec: Angle.Degrees(-06.68203256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56614"},
        {"Hipparcos Number", "HIP 35301"},
        {"Geneva Identification System", "GEN# +1.00056614"},
        {"Smithsonian Astrophysical Observation", "SAO 134474"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.38198949),
        dec: Angle.Degrees(-06.68002620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12520"},
        {"Hipparcos Number", "HIP 9551"},
        {"Smithsonian Astrophysical Observation", "SAO 129648"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.68177691),
        dec: Angle.Degrees(-06.67828484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13155"},
        {"Hipparcos Number", "HIP 9981"},
        {"Geneva Identification System", "GEN# +1.00013155"},
        {"Smithsonian Astrophysical Observation", "SAO 129717"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.13246416),
        dec: Angle.Degrees(-06.67801595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59540"},
        {"Hipparcos Number", "HIP 36466"},
        {"Smithsonian Astrophysical Observation", "SAO 134761"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.55325480),
        dec: Angle.Degrees(-06.67707629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101933"},
        {"Hipparcos Number", "HIP 57214"},
        {"Geneva Identification System", "GEN# +1.00101933"},
        {"Smithsonian Astrophysical Observation", "SAO 138375"},
        {"Wilson Evans Batten Catalogue", "WEB 10291"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.97953127),
        dec: Angle.Degrees(-06.67706055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93918"},
        {"Hipparcos Number", "HIP 52995"},
        {"Smithsonian Astrophysical Observation", "SAO 137824"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.61562905),
        dec: Angle.Degrees(-06.67490592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194795"},
        {"Hipparcos Number", "HIP 100930"},
        {"Smithsonian Astrophysical Observation", "SAO 144455"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.96165601),
        dec: Angle.Degrees(-06.67371561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142684"},
        {"Hipparcos Number", "HIP 78049"},
        {"Geneva Identification System", "GEN# +1.00142684"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.03105204),
        dec: Angle.Degrees(-06.67356377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163366"},
        {"Hipparcos Number", "HIP 87799"},
        {"Geneva Identification System", "GEN# +1.00163366"},
        {"Smithsonian Astrophysical Observation", "SAO 141965"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.03603091),
        dec: Angle.Degrees(-06.67224056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80747"},
        {"Hipparcos Number", "HIP 45887"},
        {"Geneva Identification System", "GEN# +1.00080747"},
        {"Smithsonian Astrophysical Observation", "SAO 136779"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.34518862),
        dec: Angle.Degrees(-06.67218785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10724"},
        {"Hipparcos Number", "HIP 8144"},
        {"Geneva Identification System", "GEN# +1.00010724"},
        {"Smithsonian Astrophysical Observation", "SAO 129483"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.18306284),
        dec: Angle.Degrees(-06.66923806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114007"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.33436350),
        dec: Angle.Degrees(-06.66841835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20127"},
        {"Hipparcos Number", "HIP 15049"},
        {"Fundamental Katalog 5th Edition", "FK5 4296"},
        {"Geneva Identification System", "GEN# +1.00020127"},
        {"Smithsonian Astrophysical Observation", "SAO 130367"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47857470),
        dec: Angle.Degrees(-06.66438032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73451"},
        {"Hipparcos Number", "HIP 42368"},
        {"Geneva Identification System", "GEN# +1.00073451"},
        {"Smithsonian Astrophysical Observation", "SAO 136117"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.58451027),
        dec: Angle.Degrees(-06.66231240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165914"},
        {"Hipparcos Number", "HIP 88873"},
        {"Geneva Identification System", "GEN# +1.00165914"},
        {"Smithsonian Astrophysical Observation", "SAO 142112"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15693748),
        dec: Angle.Degrees(-06.66226830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113479"},
        {"Hipparcos Number", "HIP 63766"},
        {"Smithsonian Astrophysical Observation", "SAO 139134"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.05065049),
        dec: Angle.Degrees(-06.66225497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74406"},
        {"Smithsonian Astrophysical Observation", "SAO 140377"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.09899074),
        dec: Angle.Degrees(-06.66001629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207745"},
        {"Hipparcos Number", "HIP 107871"},
        {"Smithsonian Astrophysical Observation", "SAO 145704"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.83980523),
        dec: Angle.Degrees(-06.65487033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104057"},
        {"Hipparcos Number", "HIP 58440"},
        {"Geneva Identification System", "GEN# +1.00104057"},
        {"Smithsonian Astrophysical Observation", "SAO 138516"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.75426120),
        dec: Angle.Degrees(-06.65373154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118527"},
        {"Hipparcos Number", "HIP 66468"},
        {"Geneva Identification System", "GEN# +1.00118527"},
        {"Smithsonian Astrophysical Observation", "SAO 139448"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.40999089),
        dec: Angle.Degrees(-06.65223704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24408"},
        {"Smithsonian Astrophysical Observation", "SAO 131902"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.54637010),
        dec: Angle.Degrees(-06.65215909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152677"},
        {"Hipparcos Number", "HIP 82790"},
        {"Smithsonian Astrophysical Observation", "SAO 141437"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.78298166),
        dec: Angle.Degrees(-06.65093068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13860"},
        {"Hipparcos Number", "HIP 10467"},
        {"Smithsonian Astrophysical Observation", "SAO 129776"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.73130582),
        dec: Angle.Degrees(-06.65067951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223859"},
        {"Hipparcos Number", "HIP 117777"},
        {"Fundamental Katalog 5th Edition", "FK5 6117"},
        {"Smithsonian Astrophysical Observation", "SAO 146956"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.27930385),
        dec: Angle.Degrees(-06.64988610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14653"},
        {"Hipparcos Number", "HIP 11008"},
        {"Geneva Identification System", "GEN# +1.00014653"},
        {"Smithsonian Astrophysical Observation", "SAO 129852"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44658933),
        dec: Angle.Degrees(-06.64582610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4404 AB"},
        {"Henry Draper", "HD 38840"},
        {"Hipparcos Number", "HIP 27418"},
        {"Smithsonian Astrophysical Observation", "SAO 132551"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.08497579),
        dec: Angle.Degrees(-06.64582577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163932"},
        {"Hipparcos Number", "HIP 88050"},
        {"Smithsonian Astrophysical Observation", "SAO 142005"},
    },
    visualMagnitude: 7.77,
    bvColour: 2.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.75824532),
        dec: Angle.Degrees(-06.64434905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1824"},
        {"Hipparcos Number", "HIP 1778"},
        {"Smithsonian Astrophysical Observation", "SAO 128721"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.64480462),
        dec: Angle.Degrees(-06.64308598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19365"},
        {"Hipparcos Number", "HIP 14462"},
        {"Smithsonian Astrophysical Observation", "SAO 130286"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.66472033),
        dec: Angle.Degrees(-06.64257116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16972"},
        {"Hipparcos Number", "HIP 12699"},
        {"Smithsonian Astrophysical Observation", "SAO 130072"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.78049226),
        dec: Angle.Degrees(-06.64239827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50934"},
        {"Hipparcos Number", "HIP 33252"},
        {"Smithsonian Astrophysical Observation", "SAO 133895"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.76939905),
        dec: Angle.Degrees(-06.63981029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102254"},
        {"Hipparcos Number", "HIP 57405"},
        {"Geneva Identification System", "GEN# +1.00102254"},
        {"Smithsonian Astrophysical Observation", "SAO 138393"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.53324099),
        dec: Angle.Degrees(-06.63908786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48058"},
        {"Hipparcos Number", "HIP 32008"},
        {"Geneva Identification System", "GEN# +1.00048058"},
        {"Smithsonian Astrophysical Observation", "SAO 133572"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.30937296),
        dec: Angle.Degrees(-06.63873832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87197"},
        {"Hipparcos Number", "HIP 49252"},
        {"Smithsonian Astrophysical Observation", "SAO 137320"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80517771),
        dec: Angle.Degrees(-06.63850635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193146"},
        {"Hipparcos Number", "HIP 100153"},
        {"Geneva Identification System", "GEN# +1.00193146"},
        {"Smithsonian Astrophysical Observation", "SAO 144278"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.73552141),
        dec: Angle.Degrees(-06.63847632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34453"},
        {"Smithsonian Astrophysical Observation", "SAO 134246"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.13387528),
        dec: Angle.Degrees(-06.63660737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57981"},
        {"Hipparcos Number", "HIP 35838"},
        {"Renson", "Renson 15800"},
        {"Smithsonian Astrophysical Observation", "SAO 134606"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.85193812),
        dec: Angle.Degrees(-06.63613480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211629"},
        {"Hipparcos Number", "HIP 110124"},
        {"Smithsonian Astrophysical Observation", "SAO 146009"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.61197645),
        dec: Angle.Degrees(-06.63613305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36107"},
        {"Hipparcos Number", "HIP 25681"},
        {"Smithsonian Astrophysical Observation", "SAO 132165"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27430920),
        dec: Angle.Degrees(-06.63488978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24446"},
        {"Hipparcos Number", "HIP 18169"},
        {"Fundamental Katalog 5th Edition", "FK5 1107"},
        {"Geneva Identification System", "GEN# +1.00024446"},
        {"Smithsonian Astrophysical Observation", "SAO 130796"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.28485839),
        dec: Angle.Degrees(-06.63373929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155361"},
        {"Hipparcos Number", "HIP 84083"},
        {"Smithsonian Astrophysical Observation", "SAO 141545"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.84505404),
        dec: Angle.Degrees(-06.63116793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41609"},
        {"Hipparcos Number", "HIP 28889"},
        {"Smithsonian Astrophysical Observation", "SAO 132827"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.49099141),
        dec: Angle.Degrees(-06.63057780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17836"},
        {"Hipparcos Number", "HIP 13334"},
        {"Smithsonian Astrophysical Observation", "SAO 130153"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.90785642),
        dec: Angle.Degrees(-06.62881623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10265"},
        {"Hipparcos Number", "HIP 7789"},
        {"Smithsonian Astrophysical Observation", "SAO 129436"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.06553238),
        dec: Angle.Degrees(-06.62839367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12314 A"},
        {"Henry Draper", "HD 181255"},
        {"Hipparcos Number", "HIP 95021"},
        {"Smithsonian Astrophysical Observation", "SAO 143275"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.01165753),
        dec: Angle.Degrees(-06.62797206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70183"},
        {"Hipparcos Number", "HIP 40880"},
        {"Smithsonian Astrophysical Observation", "SAO 135790"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.12288007),
        dec: Angle.Degrees(-06.62714698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13646"},
        {"Smithsonian Astrophysical Observation", "SAO 130192"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.92438371),
        dec: Angle.Degrees(-06.62679880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220036"},
        {"Hipparcos Number", "HIP 115260"},
        {"Smithsonian Astrophysical Observation", "SAO 146653"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.17970691),
        dec: Angle.Degrees(-06.62407041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178954"},
        {"Hipparcos Number", "HIP 94236"},
        {"Smithsonian Astrophysical Observation", "SAO 143104"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.74270190),
        dec: Angle.Degrees(-06.62180763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124915"},
        {"Hipparcos Number", "HIP 69727"},
        {"Geneva Identification System", "GEN# +1.00124915"},
        {"Renson", "Renson 35713"},
        {"Smithsonian Astrophysical Observation", "SAO 139828"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.08919485),
        dec: Angle.Degrees(-06.62151816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164220"},
        {"Hipparcos Number", "HIP 88164"},
        {"Smithsonian Astrophysical Observation", "SAO 142024"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.09947110),
        dec: Angle.Degrees(-06.61600036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17052 AB"},
        {"Henry Draper", "HD 223688"},
        {"Hipparcos Number", "HIP 117666"},
        {"Geneva Identification System", "GEN# +1.00223688J"},
        {"Smithsonian Astrophysical Observation", "SAO 146941"},
        {"Wilson Evans Batten Catalogue", "WEB 20706"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.94489938),
        dec: Angle.Degrees(-06.61304557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136480"},
        {"Hipparcos Number", "HIP 75131"},
        {"Fundamental Katalog 5th Edition", "FK5 5361"},
        {"Geneva Identification System", "GEN# +1.00136480"},
        {"Smithsonian Astrophysical Observation", "SAO 140475"},
        {"Wilson Evans Batten Catalogue", "WEB 12817"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.28906869),
        dec: Angle.Degrees(-06.61267117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136905"},
        {"Hipparcos Number", "HIP 75325"},
        {"Geneva Identification System", "GEN# +1.00136905"},
        {"Smithsonian Astrophysical Observation", "SAO 140499"},
        {"Wilson Evans Batten Catalogue", "WEB 12850"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.85857537),
        dec: Angle.Degrees(-06.61018981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76083"},
        {"Hipparcos Number", "HIP 43677"},
        {"Smithsonian Astrophysical Observation", "SAO 136380"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46889028),
        dec: Angle.Degrees(-06.60924234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220774"},
        {"Hipparcos Number", "HIP 115705"},
        {"Smithsonian Astrophysical Observation", "SAO 146707"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64290482),
        dec: Angle.Degrees(-06.60760427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217249"},
        {"Hipparcos Number", "HIP 113522"},
        {"Smithsonian Astrophysical Observation", "SAO 146428"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.87136230),
        dec: Angle.Degrees(-06.60751023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14282"},
        {"Hipparcos Number", "HIP 10758"},
        {"Cincinnati Publication", "Ci 18 296"},
        {"Geneva Identification System", "GEN# +1.00014282"},
        {"Smithsonian Astrophysical Observation", "SAO 129814"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.60777992),
        dec: Angle.Degrees(-06.60575161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 296.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11318 AB"},
        {"Henry Draper", "HD 169392"},
        {"Hipparcos Number", "HIP 90239"},
        {"Smithsonian Astrophysical Observation", "SAO 142290"},
        {"Smithsonian Astrophysical Observation 2", "SAO 142289"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.17927537),
        dec: Angle.Degrees(-06.60370437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57319"},
        {"Hipparcos Number", "HIP 35572"},
        {"Geneva Identification System", "GEN# +1.00057319"},
        {"Smithsonian Astrophysical Observation", "SAO 134538"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.12635142),
        dec: Angle.Degrees(-06.60339675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125354"},
        {"Hipparcos Number", "HIP 69962"},
        {"Cincinnati Publication", "Ci 20 848"},
        {"Geneva Identification System", "GEN# +1.00125354"},
        {"Wilson Evans Batten Catalogue", "WEB 12168"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.74284788),
        dec: Angle.Degrees(-06.60259565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -432.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90711"},
        {"Hipparcos Number", "HIP 51257"},
        {"Cincinnati Publication", "Ci 20 579"},
        {"Geneva Identification System", "GEN# +1.00090711"},
        {"Smithsonian Astrophysical Observation", "SAO 137585"},
        {"Wilson Evans Batten Catalogue", "WEB 9366"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.05153259),
        dec: Angle.Degrees(-06.59989496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -374.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40637"},
        {"Hipparcos Number", "HIP 28391"},
        {"Smithsonian Astrophysical Observation", "SAO 132728"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.95163387),
        dec: Angle.Degrees(-06.59735623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147254"},
        {"Hipparcos Number", "HIP 80097"},
        {"Smithsonian Astrophysical Observation", "SAO 141113"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.25460481),
        dec: Angle.Degrees(-06.59718813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49715"},
        {"Hipparcos Number", "HIP 32717"},
        {"Smithsonian Astrophysical Observation", "SAO 133726"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.38370690),
        dec: Angle.Degrees(-06.59632968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68730"},
        {"Hipparcos Number", "HIP 40281"},
        {"Smithsonian Astrophysical Observation", "SAO 135649"},
        {"Wilson Evans Batten Catalogue", "WEB 7853"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.39254944),
        dec: Angle.Degrees(-06.59440884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156698"},
        {"Hipparcos Number", "HIP 84739"},
        {"Smithsonian Astrophysical Observation", "SAO 141605"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.83303741),
        dec: Angle.Degrees(-06.59256731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11699"},
        {"Hipparcos Number", "HIP 8918"},
        {"Geneva Identification System", "GEN# +1.00011699"},
        {"Smithsonian Astrophysical Observation", "SAO 129562"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.70165032),
        dec: Angle.Degrees(-06.59212750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73856"},
        {"Smithsonian Astrophysical Observation", "SAO 140313"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.41409993),
        dec: Angle.Degrees(-06.59066154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34353"},
        {"Hipparcos Number", "HIP 24600"},
        {"Smithsonian Astrophysical Observation", "SAO 131935"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.15204449),
        dec: Angle.Degrees(-06.58916146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31298"},
        {"Hipparcos Number", "HIP 22798"},
        {"Smithsonian Astrophysical Observation", "SAO 131583"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.56361601),
        dec: Angle.Degrees(-06.58705030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217020"},
        {"Hipparcos Number", "HIP 113379"},
        {"Smithsonian Astrophysical Observation", "SAO 146408"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.43185306),
        dec: Angle.Degrees(-06.58573005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190453"},
        {"Hipparcos Number", "HIP 98944"},
        {"Smithsonian Astrophysical Observation", "SAO 144053"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.33411268),
        dec: Angle.Degrees(-06.58490309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182085"},
        {"Hipparcos Number", "HIP 95299"},
        {"Geneva Identification System", "GEN# +1.00182085"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.81902531),
        dec: Angle.Degrees(-06.58486014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203667"},
        {"Hipparcos Number", "HIP 105641"},
        {"Geneva Identification System", "GEN# +1.00203667"},
        {"Smithsonian Astrophysical Observation", "SAO 145361"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.96216389),
        dec: Angle.Degrees(-06.58394292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26403"},
        {"Geneva Identification System", "GEN# -0.00601259"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.30525750),
        dec: Angle.Degrees(-06.58349290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157841"},
        {"Hipparcos Number", "HIP 85311"},
        {"Smithsonian Astrophysical Observation", "SAO 141660"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.49774986),
        dec: Angle.Degrees(-06.58180058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14030"},
        {"Smithsonian Astrophysical Observation", "SAO 130241"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15987873),
        dec: Angle.Degrees(-06.58145519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14115"},
        {"Hipparcos Number", "HIP 10640"},
        {"Smithsonian Astrophysical Observation", "SAO 129797"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.23898876),
        dec: Angle.Degrees(-06.57828737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74125",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9516 AB"},
        {"Henry Draper", "HD 134230"},
        {"Hipparcos Number", "HIP 74125"},
        {"Smithsonian Astrophysical Observation", "SAO 140344"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23025952),
        dec: Angle.Degrees(-06.57729636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92674"},
        {"Hipparcos Number", "HIP 52347"},
        {"Geneva Identification System", "GEN# +1.00092674"},
        {"Smithsonian Astrophysical Observation", "SAO 137735"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.47384720),
        dec: Angle.Degrees(-06.57479080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37481"},
        {"Hipparcos Number", "HIP 26535"},
        {"Celescope Catalog", "CEL 889"},
        {"Geneva Identification System", "GEN# +1.00037481"},
        {"Smithsonian Astrophysical Observation", "SAO 132405"},
        {"Wilson Evans Batten Catalogue", "WEB 5230"},
    },
    visualMagnitude: 5.96,
    bvColour: -0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65821979),
        dec: Angle.Degrees(-06.57395768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217701"},
        {"Hipparcos Number", "HIP 113781"},
        {"Geneva Identification System", "GEN# +1.00217701"},
        {"Smithsonian Astrophysical Observation", "SAO 146465"},
        {"Wilson Evans Batten Catalogue", "WEB 20213"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63567045),
        dec: Angle.Degrees(-06.57392844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212122"},
        {"Hipparcos Number", "HIP 110435"},
        {"Geneva Identification System", "GEN# +1.00212122"},
        {"Smithsonian Astrophysical Observation", "SAO 146051"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.52151725),
        dec: Angle.Degrees(-06.56943074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121969"},
        {"Hipparcos Number", "HIP 68301"},
        {"Smithsonian Astrophysical Observation", "SAO 139659"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.72297845),
        dec: Angle.Degrees(-06.56750559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193709"},
        {"Hipparcos Number", "HIP 100427"},
        {"Geneva Identification System", "GEN# +1.00193709"},
        {"Smithsonian Astrophysical Observation", "SAO 144341"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.47600972),
        dec: Angle.Degrees(-06.56674824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49121"},
        {"Hipparcos Number", "HIP 32473"},
        {"Smithsonian Astrophysical Observation", "SAO 133661"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.65916548),
        dec: Angle.Degrees(-06.56674801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4393"},
        {"Hipparcos Number", "HIP 3612"},
        {"Smithsonian Astrophysical Observation", "SAO 128945"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.56711403),
        dec: Angle.Degrees(-06.56623101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3416"},
        {"Hipparcos Number", "HIP 2916"},
        {"Smithsonian Astrophysical Observation", "SAO 128858"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.23370508),
        dec: Angle.Degrees(-06.56382171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55239"},
        {"Hipparcos Number", "HIP 34772"},
        {"Smithsonian Astrophysical Observation", "SAO 134332"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.97757082),
        dec: Angle.Degrees(-06.56215732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39664"},
        {"Hipparcos Number", "HIP 27862"},
        {"Smithsonian Astrophysical Observation", "SAO 132623"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.42715309),
        dec: Angle.Degrees(-06.56123660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123919"},
        {"Hipparcos Number", "HIP 69236"},
        {"Smithsonian Astrophysical Observation", "SAO 139770"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61981477),
        dec: Angle.Degrees(-06.55959347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75140"},
        {"Hipparcos Number", "HIP 43204"},
        {"Geneva Identification System", "GEN# +1.00075140"},
        {"Smithsonian Astrophysical Observation", "SAO 136287"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.02028845),
        dec: Angle.Degrees(-06.55876125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61285"},
        {"Smithsonian Astrophysical Observation", "SAO 138844"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37541181),
        dec: Angle.Degrees(-06.55845842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107329"},
        {"Hipparcos Number", "HIP 60177"},
        {"Renson", "Renson 31090"},
        {"Smithsonian Astrophysical Observation", "SAO 138726"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.10055765),
        dec: Angle.Degrees(-06.55702185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213429"},
        {"Hipparcos Number", "HIP 111170"},
        {"Geneva Identification System", "GEN# +1.00213429"},
        {"Smithsonian Astrophysical Observation", "SAO 146135"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82590786),
        dec: Angle.Degrees(-06.55488734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8442 AB"},
        {"Henry Draper", "HD 105869"},
        {"Hipparcos Number", "HIP 59402"},
        {"Smithsonian Astrophysical Observation", "SAO 138633"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.78614991),
        dec: Angle.Degrees(-06.55312004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9100 A"},
        {"Henry Draper", "HD 122911"},
        {"Hipparcos Number", "HIP 68789"},
        {"Renson", "Renson 35220"},
        {"Smithsonian Astrophysical Observation", "SAO 139718"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.20320504),
        dec: Angle.Degrees(-06.55239908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163446"},
        {"Hipparcos Number", "HIP 87830"},
        {"Smithsonian Astrophysical Observation", "SAO 141973"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.11789651),
        dec: Angle.Degrees(-06.55169206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215827"},
        {"Hipparcos Number", "HIP 112576"},
        {"Smithsonian Astrophysical Observation", "SAO 146321"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.01855308),
        dec: Angle.Degrees(-06.55096449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42690"},
        {"Hipparcos Number", "HIP 29417"},
        {"Geneva Identification System", "GEN# +1.00042690"},
        {"Smithsonian Astrophysical Observation", "SAO 132944"},
        {"Wilson Evans Batten Catalogue", "WEB 5778"},
    },
    visualMagnitude: 5.06,
    bvColour: -0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96590078),
        dec: Angle.Degrees(-06.55028276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145168"},
        {"Hipparcos Number", "HIP 79188"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.42589193),
        dec: Angle.Degrees(-06.54975857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42051"},
        {"Hipparcos Number", "HIP 29115"},
        {"Geneva Identification System", "GEN# +1.00042051"},
        {"Smithsonian Astrophysical Observation", "SAO 132875"},
        {"Wilson Evans Batten Catalogue", "WEB 5702"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.09817826),
        dec: Angle.Degrees(-06.54865175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45659"},
        {"Hipparcos Number", "HIP 30812"},
        {"Celescope Catalog", "CEL 1257"},
        {"Geneva Identification System", "GEN# +1.00045659"},
        {"Smithsonian Astrophysical Observation", "SAO 133303"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.10872146),
        dec: Angle.Degrees(-06.54787814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84516"},
        {"Hipparcos Number", "HIP 47900"},
        {"Smithsonian Astrophysical Observation", "SAO 137106"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.43727066),
        dec: Angle.Degrees(-06.54747116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5918"},
        {"Smithsonian Astrophysical Observation", "SAO 129201"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.03495841),
        dec: Angle.Degrees(-06.54707017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216834"},
        {"Hipparcos Number", "HIP 113279"},
        {"Geneva Identification System", "GEN# +1.00216834"},
        {"Smithsonian Astrophysical Observation", "SAO 146397"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.08518185),
        dec: Angle.Degrees(-06.54579276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9657"},
        {"Smithsonian Astrophysical Observation", "SAO 129674"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.05708614),
        dec: Angle.Degrees(-06.54564709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205786"},
        {"Hipparcos Number", "HIP 106779"},
        {"Smithsonian Astrophysical Observation", "SAO 145536"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42687571),
        dec: Angle.Degrees(-06.54482486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80402"},
        {"Wilson Evans Batten Catalogue", "WEB 13605"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.17173778),
        dec: Angle.Degrees(-06.54166366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115811"},
        {"Hipparcos Number", "HIP 65025"},
        {"Geneva Identification System", "GEN# +1.00115811"},
        {"Smithsonian Astrophysical Observation", "SAO 139281"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.93725998),
        dec: Angle.Degrees(-06.54161126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12393"},
        {"Hipparcos Number", "HIP 9447"},
        {"Smithsonian Astrophysical Observation", "SAO 129638"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.36426209),
        dec: Angle.Degrees(-06.54033206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74796"},
        {"Hipparcos Number", "HIP 43019"},
        {"Smithsonian Astrophysical Observation", "SAO 136255"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.49996620),
        dec: Angle.Degrees(-06.53953004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149911"},
        {"Hipparcos Number", "HIP 81440"},
        {"Fundamental Katalog 5th Edition", "FK5 3315"},
        {"Geneva Identification System", "GEN# +1.00149911"},
        {"Renson", "Renson 42420"},
        {"Smithsonian Astrophysical Observation", "SAO 141284"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50649344),
        dec: Angle.Degrees(-06.53799188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141612"},
        {"Hipparcos Number", "HIP 77568"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.54734827),
        dec: Angle.Degrees(-06.53735679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100457"},
        {"Hipparcos Number", "HIP 56392"},
        {"Smithsonian Astrophysical Observation", "SAO 138270"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.40765175),
        dec: Angle.Degrees(-06.53694736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173278"},
        {"Hipparcos Number", "HIP 91960"},
        {"Geneva Identification System", "GEN# +1.00173278"},
        {"Smithsonian Astrophysical Observation", "SAO 142572"},
        {"Wilson Evans Batten Catalogue", "WEB 15837"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.17016835),
        dec: Angle.Degrees(-06.53613416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214722"},
        {"Hipparcos Number", "HIP 111915"},
        {"Geneva Identification System", "GEN# +1.00214722"},
        {"Smithsonian Astrophysical Observation", "SAO 146232"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.05190179),
        dec: Angle.Degrees(-06.53438312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183519"},
        {"Hipparcos Number", "HIP 95910"},
        {"Smithsonian Astrophysical Observation", "SAO 143473"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.57852218),
        dec: Angle.Degrees(-06.53326958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31624"},
        {"Hipparcos Number", "HIP 23026"},
        {"Smithsonian Astrophysical Observation", "SAO 131624"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.27661712),
        dec: Angle.Degrees(-06.53193609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21543"},
        {"Hipparcos Number", "HIP 16169"},
        {"Cincinnati Publication", "Ci 18 457"},
        {"Geneva Identification System", "GEN# +1.00021543"},
        {"Smithsonian Astrophysical Observation", "SAO 130509"},
        {"Wilson Evans Batten Catalogue", "WEB 3081"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.08697465),
        dec: Angle.Degrees(-06.53044612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 359.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108643"},
        {"Hipparcos Number", "HIP 60900"},
        {"Smithsonian Astrophysical Observation", "SAO 138811"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.21525413),
        dec: Angle.Degrees(-06.53031074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24556"},
        {"Hipparcos Number", "HIP 18245"},
        {"Smithsonian Astrophysical Observation", "SAO 130804"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.53226226),
        dec: Angle.Degrees(-06.52716068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64891"},
        {"Hipparcos Number", "HIP 38743"},
        {"Smithsonian Astrophysical Observation", "SAO 135267"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.97576252),
        dec: Angle.Degrees(-06.52671315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19773"},
        {"Hipparcos Number", "HIP 14774"},
        {"Geneva Identification System", "GEN# +1.00019773"},
        {"Smithsonian Astrophysical Observation", "SAO 130325"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.68041309),
        dec: Angle.Degrees(-06.52601128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51127"},
        {"Geneva Identification System", "GEN# -0.00503063"},
        {"Smithsonian Astrophysical Observation", "SAO 137566"},
        {"Wilson Evans Batten Catalogue", "WEB 9346"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.67198589),
        dec: Angle.Degrees(-06.52480328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -643.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126034"},
        {"Hipparcos Number", "HIP 70316"},
        {"Smithsonian Astrophysical Observation", "SAO 139907"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.79879566),
        dec: Angle.Degrees(-06.52336101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27410"},
        {"Hipparcos Number", "HIP 20158"},
        {"Smithsonian Astrophysical Observation", "SAO 131109"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.80802086),
        dec: Angle.Degrees(-06.52280276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209396"},
        {"Hipparcos Number", "HIP 108868"},
        {"Geneva Identification System", "GEN# +1.00209396"},
        {"Smithsonian Astrophysical Observation", "SAO 145836"},
        {"Wilson Evans Batten Catalogue", "WEB 19581"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.81846358),
        dec: Angle.Degrees(-06.52242698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22201"},
        {"Hipparcos Number", "HIP 16653"},
        {"Smithsonian Astrophysical Observation", "SAO 130581"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.56635934),
        dec: Angle.Degrees(-06.52074198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36286"},
        {"Smithsonian Astrophysical Observation", "SAO 134713"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.04514134),
        dec: Angle.Degrees(-06.51540396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208080"},
        {"Hipparcos Number", "HIP 108089"},
        {"Smithsonian Astrophysical Observation", "SAO 145730"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.48918312),
        dec: Angle.Degrees(-06.51504847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2581"},
        {"Hipparcos Number", "HIP 2302"},
        {"Smithsonian Astrophysical Observation", "SAO 128783"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.33876925),
        dec: Angle.Degrees(-06.51460344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138632"},
        {"Hipparcos Number", "HIP 76168"},
        {"Geneva Identification System", "GEN# +1.00138632"},
        {"Smithsonian Astrophysical Observation", "SAO 140601"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.36267277),
        dec: Angle.Degrees(-06.51450155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95962",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12529 A"},
        {"Henry Draper", "HD 183658"},
        {"Hipparcos Number", "HIP 95962"},
        {"Geneva Identification System", "GEN# +1.00183658"},
        {"Smithsonian Astrophysical Observation", "SAO 143485"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.72000978),
        dec: Angle.Degrees(-06.51407984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122606"},
        {"Hipparcos Number", "HIP 68636"},
        {"Geneva Identification System", "GEN# +1.00122606"},
        {"Smithsonian Astrophysical Observation", "SAO 139698"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.74447291),
        dec: Angle.Degrees(-06.51046670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156003"},
        {"Hipparcos Number", "HIP 84411"},
        {"Smithsonian Astrophysical Observation", "SAO 141576"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.85508427),
        dec: Angle.Degrees(-06.50866895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102133"},
        {"Hipparcos Number", "HIP 57330"},
        {"Smithsonian Astrophysical Observation", "SAO 138391"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.32354297),
        dec: Angle.Degrees(-06.50813095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77326"},
        {"Geneva Identification System", "GEN# -0.00604279"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.80361578),
        dec: Angle.Degrees(-06.50788499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96145"},
        {"Hipparcos Number", "HIP 54200"},
        {"Smithsonian Astrophysical Observation", "SAO 137982"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.32120941),
        dec: Angle.Degrees(-06.50610896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81928"},
        {"Smithsonian Astrophysical Observation", "SAO 141334"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00864470),
        dec: Angle.Degrees(-06.50460159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3126"},
        {"Hipparcos Number", "HIP 2710"},
        {"Geneva Identification System", "GEN# +1.00003126"},
        {"Smithsonian Astrophysical Observation", "SAO 128830"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.61338867),
        dec: Angle.Degrees(-06.50369569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87115"},
        {"Hipparcos Number", "HIP 49212"},
        {"Smithsonian Astrophysical Observation", "SAO 137311"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.67827694),
        dec: Angle.Degrees(-06.50361615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22735"},
        {"Hipparcos Number", "HIP 17035"},
        {"Smithsonian Astrophysical Observation", "SAO 130635"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.77809200),
        dec: Angle.Degrees(-06.49970684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94885"},
        {"Hipparcos Number", "HIP 53529"},
        {"Smithsonian Astrophysical Observation", "SAO 137905"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.27995722),
        dec: Angle.Degrees(-06.49751267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37527"},
        {"Hipparcos Number", "HIP 26577"},
        {"Geneva Identification System", "GEN# +1.00037527"},
        {"Smithsonian Astrophysical Observation", "SAO 132415"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.75389679),
        dec: Angle.Degrees(-06.49731525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121548"},
        {"Hipparcos Number", "HIP 68063"},
        {"Smithsonian Astrophysical Observation", "SAO 139631"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.03986434),
        dec: Angle.Degrees(-06.49488855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18894"},
        {"Hipparcos Number", "HIP 14124"},
        {"Geneva Identification System", "GEN# +1.00018894"},
        {"Smithsonian Astrophysical Observation", "SAO 130251"},
        {"Wilson Evans Batten Catalogue", "WEB 2778"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.53845132),
        dec: Angle.Degrees(-06.49419402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2075 AB"},
        {"Henry Draper", "HD 16945"},
        {"Hipparcos Number", "HIP 12677"},
        {"Smithsonian Astrophysical Observation", "SAO 130070"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.71855995),
        dec: Angle.Degrees(-06.48906809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120968"},
        {"Hipparcos Number", "HIP 67765"},
        {"Fundamental Katalog 5th Edition", "FK5 5225"},
        {"Geneva Identification System", "GEN# +1.00120968"},
        {"Smithsonian Astrophysical Observation", "SAO 139601"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22570127),
        dec: Angle.Degrees(-06.48860034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46341"},
        {"Hipparcos Number", "HIP 31188"},
        {"Geneva Identification System", "GEN# +1.00046341"},
        {"Smithsonian Astrophysical Observation", "SAO 133386"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.15767232),
        dec: Angle.Degrees(-06.48849089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2201"},
        {"Geneva Identification System", "GEN# +9.80031052"},
    },
    visualMagnitude: 11.59,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.95739605),
        dec: Angle.Degrees(-06.48384114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -927.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75026"},
        {"Smithsonian Astrophysical Observation", "SAO 140459"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.95786892),
        dec: Angle.Degrees(-06.48350351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72663"},
        {"Hipparcos Number", "HIP 42025"},
        {"Smithsonian Astrophysical Observation", "SAO 136046"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.50120453),
        dec: Angle.Degrees(-06.48199038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160367"},
        {"Hipparcos Number", "HIP 86447"},
        {"Smithsonian Astrophysical Observation", "SAO 141792"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.95091391),
        dec: Angle.Degrees(-06.47886813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222492"},
        {"Hipparcos Number", "HIP 116854"},
        {"Fundamental Katalog 5th Edition", "FK5 6096"},
        {"Geneva Identification System", "GEN# +1.00222492"},
        {"Smithsonian Astrophysical Observation", "SAO 146844"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.29204753),
        dec: Angle.Degrees(-06.47796028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42507"},
        {"Geneva Identification System", "GEN# -0.00502603"},
        {"Smithsonian Astrophysical Observation", "SAO 136147"},
        {"Wilson Evans Batten Catalogue", "WEB 8191"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.00083240),
        dec: Angle.Degrees(-06.47549499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83007"},
        {"Hipparcos Number", "HIP 47059"},
        {"Smithsonian Astrophysical Observation", "SAO 136983"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.85750157),
        dec: Angle.Degrees(-06.47411167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186106"},
        {"Hipparcos Number", "HIP 96980"},
        {"Smithsonian Astrophysical Observation", "SAO 143719"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.69258997),
        dec: Angle.Degrees(-06.47374729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40353"},
        {"Hipparcos Number", "HIP 28234"},
        {"Smithsonian Astrophysical Observation", "SAO 132695"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.48363541),
        dec: Angle.Degrees(-06.47307476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71279"},
        {"Hipparcos Number", "HIP 41370"},
        {"Smithsonian Astrophysical Observation", "SAO 135915"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.59491851),
        dec: Angle.Degrees(-06.47297725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6896 AB"},
        {"Henry Draper", "HD 73263"},
        {"Hipparcos Number", "HIP 42292"},
        {"Smithsonian Astrophysical Observation", "SAO 136100"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.33757566),
        dec: Angle.Degrees(-06.47290079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27179"},
        {"Hipparcos Number", "HIP 19996"},
        {"Geneva Identification System", "GEN# +1.00027179"},
        {"Smithsonian Astrophysical Observation", "SAO 131092"},
        {"Wilson Evans Batten Catalogue", "WEB 3816"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33012941),
        dec: Angle.Degrees(-06.47215975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29971"},
        {"Hipparcos Number", "HIP 21957"},
        {"Smithsonian Astrophysical Observation", "SAO 131432"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.78181752),
        dec: Angle.Degrees(-06.47092775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199382"},
        {"Hipparcos Number", "HIP 103406"},
        {"Smithsonian Astrophysical Observation", "SAO 144972"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.25943778),
        dec: Angle.Degrees(-06.47060950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100238"},
        {"Hipparcos Number", "HIP 56260"},
        {"Geneva Identification System", "GEN# +1.00100238"},
        {"Smithsonian Astrophysical Observation", "SAO 138251"},
        {"Wilson Evans Batten Catalogue", "WEB 10116"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.98594360),
        dec: Angle.Degrees(-06.47031998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8924 A"},
        {"Henry Draper", "HD 117436"},
        {"Hipparcos Number", "HIP 65892"},
        {"Geneva Identification System", "GEN# +1.00117436A"},
        {"Smithsonian Astrophysical Observation", "SAO 139370"},
        {"Wilson Evans Batten Catalogue", "WEB 11657"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.60707597),
        dec: Angle.Degrees(-06.47029456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13140"},
        {"Hipparcos Number", "HIP 9975"},
        {"Smithsonian Astrophysical Observation", "SAO 129716"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.11036762),
        dec: Angle.Degrees(-06.46955019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210752"},
        {"Hipparcos Number", "HIP 109646"},
        {"Geneva Identification System", "GEN# +1.00210752"},
        {"Smithsonian Astrophysical Observation", "SAO 145939"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.18086457),
        dec: Angle.Degrees(-06.46896918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102446"},
        {"Hipparcos Number", "HIP 57538"},
        {"Geneva Identification System", "GEN# +1.00102446"},
        {"Smithsonian Astrophysical Observation", "SAO 138406"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.88871341),
        dec: Angle.Degrees(-06.46826405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68738"},
        {"Smithsonian Astrophysical Observation", "SAO 139710"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.05390527),
        dec: Angle.Degrees(-06.46750612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213575"},
        {"Hipparcos Number", "HIP 111274"},
        {"Geneva Identification System", "GEN# +1.00213575"},
        {"Smithsonian Astrophysical Observation", "SAO 146142"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14120137),
        dec: Angle.Degrees(-06.46724792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 291.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104592"},
        {"Hipparcos Number", "HIP 58728"},
        {"Geneva Identification System", "GEN# +1.00104592"},
        {"Smithsonian Astrophysical Observation", "SAO 138549"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69125694),
        dec: Angle.Degrees(-06.46584393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202034"},
        {"Hipparcos Number", "HIP 104783"},
        {"Smithsonian Astrophysical Observation", "SAO 145217"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.40548577),
        dec: Angle.Degrees(-06.46582127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173987"},
        {"Hipparcos Number", "HIP 92289"},
        {"Geneva Identification System", "GEN# +1.00173987"},
        {"Smithsonian Astrophysical Observation", "SAO 142635"},
        {"Wilson Evans Batten Catalogue", "WEB 15926"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.14005917),
        dec: Angle.Degrees(-06.46498526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207300"},
        {"Hipparcos Number", "HIP 107627"},
        {"Smithsonian Astrophysical Observation", "SAO 145675"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.00245613),
        dec: Angle.Degrees(-06.46298623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1868"},
        {"Hipparcos Number", "HIP 1812"},
        {"Smithsonian Astrophysical Observation", "SAO 128728"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.75013325),
        dec: Angle.Degrees(-06.46298109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51623"},
        {"Hipparcos Number", "HIP 33508"},
        {"Smithsonian Astrophysical Observation", "SAO 133962"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.47724833),
        dec: Angle.Degrees(-06.46268705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143669"},
        {"Hipparcos Number", "HIP 78535"},
        {"Smithsonian Astrophysical Observation", "SAO 140905"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.50472308),
        dec: Angle.Degrees(-06.46193387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179405"},
        {"Hipparcos Number", "HIP 94384"},
        {"Geneva Identification System", "GEN# +1.00179405"},
        {"Smithsonian Astrophysical Observation", "SAO 143135"},
        {"Wilson Evans Batten Catalogue", "WEB 16449"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.16772691),
        dec: Angle.Degrees(-06.45879164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129137"},
        {"Hipparcos Number", "HIP 71779"},
        {"Smithsonian Astrophysical Observation", "SAO 140065"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.24712738),
        dec: Angle.Degrees(-06.45830487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93259"},
        {"Hipparcos Number", "HIP 52654"},
        {"Smithsonian Astrophysical Observation", "SAO 137769"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.50673649),
        dec: Angle.Degrees(-06.45725880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54598"},
        {"Hipparcos Number", "HIP 34525"},
        {"Smithsonian Astrophysical Observation", "SAO 134261"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.30698409),
        dec: Angle.Degrees(-06.45663185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173477"},
        {"Hipparcos Number", "HIP 92054"},
        {"Smithsonian Astrophysical Observation", "SAO 142594"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.43879806),
        dec: Angle.Degrees(-06.45501781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78620"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.75128604),
        dec: Angle.Degrees(-06.45320403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220018"},
        {"Hipparcos Number", "HIP 115252"},
        {"Smithsonian Astrophysical Observation", "SAO 146651"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.16018611),
        dec: Angle.Degrees(-06.45133321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55238"},
        {"Hipparcos Number", "HIP 34774"},
        {"Geneva Identification System", "GEN# +1.00055238"},
        {"Smithsonian Astrophysical Observation", "SAO 134334"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.97814644),
        dec: Angle.Degrees(-06.45069138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40475"},
        {"Hipparcos Number", "HIP 28291"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.67116888),
        dec: Angle.Degrees(-06.45036878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67011"},
        {"Hipparcos Number", "HIP 39626"},
        {"Smithsonian Astrophysical Observation", "SAO 135493"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.45804815),
        dec: Angle.Degrees(-06.44492786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188957"},
        {"Hipparcos Number", "HIP 98259"},
        {"Smithsonian Astrophysical Observation", "SAO 143952"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48951911),
        dec: Angle.Degrees(-06.44474035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140029"},
        {"Hipparcos Number", "HIP 76865"},
        {"Fundamental Katalog 5th Edition", "FK5 5390"},
        {"Smithsonian Astrophysical Observation", "SAO 140702"},
        {"Wilson Evans Batten Catalogue", "WEB 13038"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.43916187),
        dec: Angle.Degrees(-06.44439055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9670"},
        {"Smithsonian Astrophysical Observation", "SAO 129676"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.08991628),
        dec: Angle.Degrees(-06.44301859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114148"},
        {"Hipparcos Number", "HIP 64151"},
        {"Smithsonian Astrophysical Observation", "SAO 139179"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.21534452),
        dec: Angle.Degrees(-06.44179717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8052 AB"},
        {"Henry Draper", "HD 96183"},
        {"Hipparcos Number", "HIP 54207"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.35899265),
        dec: Angle.Degrees(-06.44151896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44518"},
        {"Hipparcos Number", "HIP 30262"},
        {"Smithsonian Astrophysical Observation", "SAO 133161"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.48896151),
        dec: Angle.Degrees(-06.44120159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87838"},
        {"Hipparcos Number", "HIP 49615"},
        {"Geneva Identification System", "GEN# +1.00087838"},
        {"Smithsonian Astrophysical Observation", "SAO 137363"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.89177338),
        dec: Angle.Degrees(-06.43945455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -371.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202868"},
        {"Hipparcos Number", "HIP 105225"},
        {"Smithsonian Astrophysical Observation", "SAO 145288"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.71721010),
        dec: Angle.Degrees(-06.43916002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33316"},
        {"Hipparcos Number", "HIP 23969"},
        {"Celescope Catalog", "CEL 548"},
        {"Geneva Identification System", "GEN# +1.00033316"},
        {"Smithsonian Astrophysical Observation", "SAO 131823"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28472654),
        dec: Angle.Degrees(-06.43822372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137795"},
        {"Hipparcos Number", "HIP 75728"},
        {"Geneva Identification System", "GEN# +1.00137795"},
        {"Smithsonian Astrophysical Observation", "SAO 140553"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05693270),
        dec: Angle.Degrees(-06.43773835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38755"},
        {"Hipparcos Number", "HIP 27368"},
        {"Celescope Catalog", "CEL 975"},
        {"Geneva Identification System", "GEN# +1.00038755"},
        {"Smithsonian Astrophysical Observation", "SAO 132539"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.94494239),
        dec: Angle.Degrees(-06.43498729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55607"},
        {"Hipparcos Number", "HIP 34908"},
        {"Geneva Identification System", "GEN# +1.00055607"},
        {"Smithsonian Astrophysical Observation", "SAO 134370"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.33761523),
        dec: Angle.Degrees(-06.43459354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106952"},
        {"Hipparcos Number", "HIP 59961"},
        {"Geneva Identification System", "GEN# +1.00106952"},
        {"Smithsonian Astrophysical Observation", "SAO 138701"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.47268986),
        dec: Angle.Degrees(-06.43099104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45953"},
        {"Hipparcos Number", "HIP 30993"},
        {"Celescope Catalog", "CEL 1267"},
        {"Geneva Identification System", "GEN# +1.00045953"},
        {"Smithsonian Astrophysical Observation", "SAO 133344"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.57492688),
        dec: Angle.Degrees(-06.43012107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132308"},
        {"Hipparcos Number", "HIP 73280"},
        {"Smithsonian Astrophysical Observation", "SAO 140249"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.65377120),
        dec: Angle.Degrees(-06.42768699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90430"},
        {"Hipparcos Number", "HIP 51090"},
        {"Geneva Identification System", "GEN# +1.00090430"},
        {"Smithsonian Astrophysical Observation", "SAO 137563"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.57696465),
        dec: Angle.Degrees(-06.42719954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88898"},
        {"Hipparcos Number", "HIP 50220"},
        {"Smithsonian Astrophysical Observation", "SAO 137440"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.78138139),
        dec: Angle.Degrees(-06.42353957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50450",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7720 A"},
        {"Henry Draper", "HD 89310"},
        {"Hipparcos Number", "HIP 50450"},
        {"Smithsonian Astrophysical Observation", "SAO 137474"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.52139581),
        dec: Angle.Degrees(-06.42300962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14129"},
        {"Hipparcos Number", "HIP 10642"},
        {"Fundamental Katalog 5th Edition", "FK5 80"},
        {"Geneva Identification System", "GEN# +1.00014129"},
        {"Smithsonian Astrophysical Observation", "SAO 129798"},
        {"Wilson Evans Batten Catalogue", "WEB 2240"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.24578955),
        dec: Angle.Degrees(-06.42185630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65938"},
        {"Hipparcos Number", "HIP 39198"},
        {"Geneva Identification System", "GEN# +1.00065938"},
        {"Smithsonian Astrophysical Observation", "SAO 135379"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.26436586),
        dec: Angle.Degrees(-06.41908231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23064"},
        {"Hipparcos Number", "HIP 17274"},
        {"Smithsonian Astrophysical Observation", "SAO 130671"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.49021787),
        dec: Angle.Degrees(-06.41857323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96743"},
        {"Hipparcos Number", "HIP 54458"},
        {"Smithsonian Astrophysical Observation", "SAO 138008"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.13162953),
        dec: Angle.Degrees(-06.41762467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174281"},
        {"Hipparcos Number", "HIP 92422"},
        {"Smithsonian Astrophysical Observation", "SAO 142671"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.52298887),
        dec: Angle.Degrees(-06.41704473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30700"},
        {"Hipparcos Number", "HIP 22440"},
        {"Geneva Identification System", "GEN# +1.00030700"},
        {"Smithsonian Astrophysical Observation", "SAO 131526"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42753580),
        dec: Angle.Degrees(-06.41673091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39383",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6547 AB"},
        {"Hipparcos Number", "HIP 39383"},
        {"Geneva Identification System", "GEN# -0.00602423"},
        {"Smithsonian Astrophysical Observation", "SAO 135422"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.77757123),
        dec: Angle.Degrees(-06.41446654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110383"},
        {"Hipparcos Number", "HIP 61949"},
        {"Smithsonian Astrophysical Observation", "SAO 138919"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.44945868),
        dec: Angle.Degrees(-06.41402684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121563"},
        {"Hipparcos Number", "HIP 68083"},
        {"Smithsonian Astrophysical Observation", "SAO 139635"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.09523048),
        dec: Angle.Degrees(-06.41243845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71433"},
        {"Hipparcos Number", "HIP 41452"},
        {"Geneva Identification System", "GEN# +1.00071433"},
        {"Smithsonian Astrophysical Observation", "SAO 135931"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.82204199),
        dec: Angle.Degrees(-06.40963438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9864"},
        {"Hipparcos Number", "HIP 7464"},
        {"Smithsonian Astrophysical Observation", "SAO 129395"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.03765851),
        dec: Angle.Degrees(-06.40605916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65410"},
        {"Hipparcos Number", "HIP 38968"},
        {"Smithsonian Astrophysical Observation", "SAO 135315"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.60001380),
        dec: Angle.Degrees(-06.40471869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81421"},
        {"Hipparcos Number", "HIP 46223"},
        {"Renson", "Renson 23144"},
        {"Smithsonian Astrophysical Observation", "SAO 136833"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.36272544),
        dec: Angle.Degrees(-06.40448383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192919"},
        {"Hipparcos Number", "HIP 100025"},
        {"Geneva Identification System", "GEN# +1.00192919"},
        {"Smithsonian Astrophysical Observation", "SAO 144256"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.40461001),
        dec: Angle.Degrees(-06.40417103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39749"},
        {"Hipparcos Number", "HIP 27899"},
        {"Smithsonian Astrophysical Observation", "SAO 132629"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.55313822),
        dec: Angle.Degrees(-06.40416284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28194"},
        {"Hipparcos Number", "HIP 20742"},
        {"Geneva Identification System", "GEN# +1.00028194"},
        {"Smithsonian Astrophysical Observation", "SAO 131210"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.67107241),
        dec: Angle.Degrees(-06.40412943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221561"},
        {"Hipparcos Number", "HIP 116242"},
        {"Geneva Identification System", "GEN# +1.00221561"},
        {"Smithsonian Astrophysical Observation", "SAO 146771"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.29991093),
        dec: Angle.Degrees(-06.40061535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211062"},
        {"Hipparcos Number", "HIP 109828"},
        {"Smithsonian Astrophysical Observation", "SAO 145963"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.67507218),
        dec: Angle.Degrees(-06.40042414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215152"},
        {"Hipparcos Number", "HIP 112190"},
        {"Geneva Identification System", "GEN# +1.00215152"},
        {"Smithsonian Astrophysical Observation", "SAO 146275"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.83913863),
        dec: Angle.Degrees(-06.40011587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -290.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74679"},
        {"Smithsonian Astrophysical Observation", "SAO 140418"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.93551129),
        dec: Angle.Degrees(-06.39871970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36550"},
        {"Hipparcos Number", "HIP 25955"},
        {"Geneva Identification System", "GEN# +1.00036550"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.06692295),
        dec: Angle.Degrees(-06.39636763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44111"},
        {"Geneva Identification System", "GEN# -0.00502678"},
        {"Wilson Evans Batten Catalogue", "WEB 8474"},
    },
    visualMagnitude: 12.00,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.76348628),
        dec: Angle.Degrees(-06.39496975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -490.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41225"},
        {"Hipparcos Number", "HIP 28690"},
        {"Smithsonian Astrophysical Observation", "SAO 132786"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.86167836),
        dec: Angle.Degrees(-06.39464890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95713"},
        {"Hipparcos Number", "HIP 53995"},
        {"Smithsonian Astrophysical Observation", "SAO 137954"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.69161394),
        dec: Angle.Degrees(-06.39367870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47539"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.38141641),
        dec: Angle.Degrees(-06.39344434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210315"},
        {"Hipparcos Number", "HIP 109385"},
        {"Smithsonian Astrophysical Observation", "SAO 145909"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.41132033),
        dec: Angle.Degrees(-06.39326394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30949"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.43831415),
        dec: Angle.Degrees(-06.39303762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36560"},
        {"Hipparcos Number", "HIP 25962"},
        {"Celescope Catalog", "CEL 771"},
        {"Geneva Identification System", "GEN# +1.00036560"},
        {"Smithsonian Astrophysical Observation", "SAO 132230"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.07884740),
        dec: Angle.Degrees(-06.39252507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154932"},
        {"Hipparcos Number", "HIP 83890"},
        {"Smithsonian Astrophysical Observation", "SAO 141532"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.18665215),
        dec: Angle.Degrees(-06.39201753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52021",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.98,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37, 41.6300),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)23, 22.600)
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
    primaryId: "HIP 33175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50751"},
        {"Hipparcos Number", "HIP 33175"},
        {"Smithsonian Astrophysical Observation", "SAO 133871"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.57827547),
        dec: Angle.Degrees(-06.38924647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26663"},
        {"Hipparcos Number", "HIP 19677"},
        {"Smithsonian Astrophysical Observation", "SAO 131033"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.23429001),
        dec: Angle.Degrees(-06.38804034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139059"},
        {"Hipparcos Number", "HIP 76400"},
        {"Geneva Identification System", "GEN# +1.00139059"},
        {"Smithsonian Astrophysical Observation", "SAO 140631"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.05361286),
        dec: Angle.Degrees(-06.38801989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138252"},
        {"Hipparcos Number", "HIP 75987"},
        {"Smithsonian Astrophysical Observation", "SAO 140579"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.76756417),
        dec: Angle.Degrees(-06.38497219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25241"},
        {"Hipparcos Number", "HIP 18694"},
        {"Smithsonian Astrophysical Observation", "SAO 130870"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.07739791),
        dec: Angle.Degrees(-06.38429615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12188"},
        {"Hipparcos Number", "HIP 9304"},
        {"Smithsonian Astrophysical Observation", "SAO 129610"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.89036747),
        dec: Angle.Degrees(-06.38254202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223311"},
        {"Hipparcos Number", "HIP 117420"},
        {"Fundamental Katalog 5th Edition", "FK5 3912"},
        {"Geneva Identification System", "GEN# +1.00223311"},
        {"Smithsonian Astrophysical Observation", "SAO 146919"},
        {"Wilson Evans Batten Catalogue", "WEB 20678"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13533084),
        dec: Angle.Degrees(-06.38037699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91484"},
        {"Hipparcos Number", "HIP 51698"},
        {"Smithsonian Astrophysical Observation", "SAO 137642"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.43523510),
        dec: Angle.Degrees(-06.37960241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176699"},
        {"Hipparcos Number", "HIP 93441"},
        {"Smithsonian Astrophysical Observation", "SAO 142934"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45557954),
        dec: Angle.Degrees(-06.37944549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14516"},
        {"Hipparcos Number", "HIP 10915"},
        {"Geneva Identification System", "GEN# +1.00014516"},
        {"Smithsonian Astrophysical Observation", "SAO 129841"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.12832949),
        dec: Angle.Degrees(-06.37886193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189714"},
        {"Hipparcos Number", "HIP 98596"},
        {"Smithsonian Astrophysical Observation", "SAO 143996"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.39905173),
        dec: Angle.Degrees(-06.37476592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13748"},
        {"Hipparcos Number", "HIP 10397"},
        {"Smithsonian Astrophysical Observation", "SAO 129764"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.47535961),
        dec: Angle.Degrees(-06.37469275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205163"},
        {"Hipparcos Number", "HIP 106455"},
        {"Smithsonian Astrophysical Observation", "SAO 145486"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.41426685),
        dec: Angle.Degrees(-06.37378562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1867"},
        {"Hipparcos Number", "HIP 1815"},
        {"Smithsonian Astrophysical Observation", "SAO 128729"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.75369400),
        dec: Angle.Degrees(-06.37002835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206157"},
        {"Hipparcos Number", "HIP 107007"},
        {"Smithsonian Astrophysical Observation", "SAO 145575"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.08447144),
        dec: Angle.Degrees(-06.36886722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191949"},
        {"Hipparcos Number", "HIP 99588"},
        {"Smithsonian Astrophysical Observation", "SAO 144170"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.16087567),
        dec: Angle.Degrees(-06.36609394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46850"},
    },
    visualMagnitude: 11.60,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.21021035),
        dec: Angle.Degrees(-06.36532297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47091"},
        {"Hipparcos Number", "HIP 31591"},
        {"Smithsonian Astrophysical Observation", "SAO 133474"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.17012415),
        dec: Angle.Degrees(-06.36349028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35627"},
        {"Hipparcos Number", "HIP 25388"},
        {"Geneva Identification System", "GEN# +1.00035627"},
        {"Smithsonian Astrophysical Observation", "SAO 132095"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47203874),
        dec: Angle.Degrees(-06.36262758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193429"},
        {"Hipparcos Number", "HIP 100283"},
        {"Fundamental Katalog 5th Edition", "FK5 3628"},
        {"Geneva Identification System", "GEN# +1.00193429"},
        {"Smithsonian Astrophysical Observation", "SAO 144313"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.10914384),
        dec: Angle.Degrees(-06.36151378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29082"},
        {"Smithsonian Astrophysical Observation", "SAO 132868"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.02159443),
        dec: Angle.Degrees(-06.36126073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106092"},
        {"Hipparcos Number", "HIP 59519"},
        {"Geneva Identification System", "GEN# +1.00106092"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.09543867),
        dec: Angle.Degrees(-06.35883442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -315.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31100"},
        {"Hipparcos Number", "HIP 22690"},
        {"Smithsonian Astrophysical Observation", "SAO 131564"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19139061),
        dec: Angle.Degrees(-06.35811633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193582"},
        {"Hipparcos Number", "HIP 100352"},
        {"Geneva Identification System", "GEN# +1.00193582"},
        {"Smithsonian Astrophysical Observation", "SAO 144328"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.28669601),
        dec: Angle.Degrees(-06.35539985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119038"},
        {"Hipparcos Number", "HIP 66764"},
        {"Smithsonian Astrophysical Observation", "SAO 139486"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.26361896),
        dec: Angle.Degrees(-06.35449678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90246"},
        {"Geneva Identification System", "GEN# -0.00604756A"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.20500512),
        dec: Angle.Degrees(-06.35369838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79910"},
        {"Hipparcos Number", "HIP 45527"},
        {"Fundamental Katalog 5th Edition", "FK5 2739"},
        {"Geneva Identification System", "GEN# +1.00079910J"},
        {"Smithsonian Astrophysical Observation", "SAO 136725"},
        {"Wilson Evans Batten Catalogue", "WEB 8655"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.17384091),
        dec: Angle.Degrees(-06.35315487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174553"},
        {"Hipparcos Number", "HIP 92517"},
        {"Geneva Identification System", "GEN# +1.00174553"},
        {"Geneva Identification System 2", "GEN# +2.67050624"},
        {"Smithsonian Astrophysical Observation", "SAO 142702"},
        {"New General Catalogue", "NGC 6705 624"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.82033820),
        dec: Angle.Degrees(-06.35306232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206812"},
        {"Hipparcos Number", "HIP 107365"},
        {"Smithsonian Astrophysical Observation", "SAO 145632"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.19401751),
        dec: Angle.Degrees(-06.35239960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153974"},
        {"Hipparcos Number", "HIP 83414"},
        {"Smithsonian Astrophysical Observation", "SAO 141499"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.74026730),
        dec: Angle.Degrees(-06.35236858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189025"},
        {"Hipparcos Number", "HIP 98290"},
        {"Smithsonian Astrophysical Observation", "SAO 143957"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.55871233),
        dec: Angle.Degrees(-06.35060275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165177"},
        {"Hipparcos Number", "HIP 88561"},
        {"Smithsonian Astrophysical Observation", "SAO 142070"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.24475560),
        dec: Angle.Degrees(-06.35058932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8840"},
        {"Hipparcos Number", "HIP 6763"},
        {"Smithsonian Astrophysical Observation", "SAO 129306"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.75530816),
        dec: Angle.Degrees(-06.34900425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47821"},
        {"Hipparcos Number", "HIP 31925"},
        {"Geneva Identification System", "GEN# +1.00047821"},
        {"Smithsonian Astrophysical Observation", "SAO 133552"},
        {"Wilson Evans Batten Catalogue", "WEB 6418"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.07857811),
        dec: Angle.Degrees(-06.34630258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17038"},
        {"Hipparcos Number", "HIP 12761"},
        {"Smithsonian Astrophysical Observation", "SAO 130085"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.00128575),
        dec: Angle.Degrees(-06.34557511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186908"},
        {"Hipparcos Number", "HIP 97361"},
        {"Smithsonian Astrophysical Observation", "SAO 143798"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.83701546),
        dec: Angle.Degrees(-06.34295301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63025"},
        {"Hipparcos Number", "HIP 37940"},
        {"Renson", "Renson 17355"},
        {"Smithsonian Astrophysical Observation", "SAO 135086"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.64254343),
        dec: Angle.Degrees(-06.34007877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6727"},
        {"Geneva Identification System", "GEN# -0.00700230"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.66015977),
        dec: Angle.Degrees(-06.33852018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63023"},
        {"Geneva Identification System", "GEN# -0.00503596"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73408633),
        dec: Angle.Degrees(-06.33817645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -298.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66242"},
        {"Hipparcos Number", "HIP 39326"},
        {"Fundamental Katalog 5th Edition", "FK5 1213"},
        {"Geneva Identification System", "GEN# +1.00066242"},
        {"Smithsonian Astrophysical Observation", "SAO 135406"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.60819024),
        dec: Angle.Degrees(-06.33710792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4097"},
        {"Hipparcos Number", "HIP 3402"},
        {"Smithsonian Astrophysical Observation", "SAO 128917"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82846505),
        dec: Angle.Degrees(-06.33680517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157299"},
        {"Hipparcos Number", "HIP 85025"},
        {"Geneva Identification System", "GEN# +1.00157299"},
        {"Smithsonian Astrophysical Observation", "SAO 141637"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.67582288),
        dec: Angle.Degrees(-06.33093079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15585"},
        {"Hipparcos Number", "HIP 11659"},
        {"Smithsonian Astrophysical Observation", "SAO 129944"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.58980981),
        dec: Angle.Degrees(-06.32957635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201311"},
        {"Hipparcos Number", "HIP 104394"},
        {"Smithsonian Astrophysical Observation", "SAO 145144"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.23343537),
        dec: Angle.Degrees(-06.32957374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141754"},
        {"Hipparcos Number", "HIP 77633"},
        {"Geneva Identification System", "GEN# +1.00141754"},
        {"Smithsonian Astrophysical Observation", "SAO 140798"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.73866590),
        dec: Angle.Degrees(-06.32831116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112400"},
        {"Hipparcos Number", "HIP 63161"},
        {"Smithsonian Astrophysical Observation", "SAO 139055"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.12838875),
        dec: Angle.Degrees(-06.32699308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13783"},
        {"Smithsonian Astrophysical Observation", "SAO 130207"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.35217733),
        dec: Angle.Degrees(-06.32666662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23516"},
        {"Hipparcos Number", "HIP 17560"},
        {"Smithsonian Astrophysical Observation", "SAO 130707"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.41059963),
        dec: Angle.Degrees(-06.32340791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66351"},
        {"Hipparcos Number", "HIP 39362"},
        {"Smithsonian Astrophysical Observation", "SAO 135416"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.69344642),
        dec: Angle.Degrees(-06.32249697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14447"},
        {"Hipparcos Number", "HIP 10872"},
        {"Geneva Identification System", "GEN# +1.00014447"},
        {"Smithsonian Astrophysical Observation", "SAO 129833"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.98303426),
        dec: Angle.Degrees(-06.32177166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14504"},
        {"Hipparcos Number", "HIP 10905"},
        {"Smithsonian Astrophysical Observation", "SAO 129840"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09348133),
        dec: Angle.Degrees(-06.31965623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72257"},
        {"Hipparcos Number", "HIP 41834"},
        {"Geneva Identification System", "GEN# +1.00072257"},
        {"Smithsonian Astrophysical Observation", "SAO 136006"},
        {"Wilson Evans Batten Catalogue", "WEB 8054"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.92255680),
        dec: Angle.Degrees(-06.31879588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71887"},
        {"Hipparcos Number", "HIP 41664"},
        {"Geneva Identification System", "GEN# +1.00071887"},
        {"Smithsonian Astrophysical Observation", "SAO 135976"},
        {"Wilson Evans Batten Catalogue", "WEB 8038"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.42144618),
        dec: Angle.Degrees(-06.31868094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103800"},
        {"Cincinnati Publication", "Ci 20 1251"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.49490141),
        dec: Angle.Degrees(-06.31766657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -445.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139515"},
        {"Hipparcos Number", "HIP 76616"},
        {"Geneva Identification System", "GEN# +1.00139515"},
        {"Smithsonian Astrophysical Observation", "SAO 140674"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.69109461),
        dec: Angle.Degrees(-06.31739390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73169"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.30332315),
        dec: Angle.Degrees(-06.31677897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56183"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.74360322),
        dec: Angle.Degrees(-06.31408604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32925"},
        {"Hipparcos Number", "HIP 23759"},
        {"Geneva Identification System", "GEN# +1.00032925"},
        {"Smithsonian Astrophysical Observation", "SAO 131769"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.60044101),
        dec: Angle.Degrees(-06.31397163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193018"},
        {"Hipparcos Number", "HIP 100082"},
        {"Geneva Identification System", "GEN# +1.00193018"},
        {"Smithsonian Astrophysical Observation", "SAO 144268"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55844812),
        dec: Angle.Degrees(-06.31231067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54433"},
        {"Smithsonian Astrophysical Observation", "SAO 138002"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.07157850),
        dec: Angle.Degrees(-06.31056001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62408"},
        {"Hipparcos Number", "HIP 37661"},
        {"Smithsonian Astrophysical Observation", "SAO 135035"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.91387458),
        dec: Angle.Degrees(-06.30976466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204998"},
        {"Hipparcos Number", "HIP 106359"},
        {"Smithsonian Astrophysical Observation", "SAO 145472"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.12548097),
        dec: Angle.Degrees(-06.30873652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130008"},
        {"Hipparcos Number", "HIP 72195"},
        {"Smithsonian Astrophysical Observation", "SAO 140125"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.49408894),
        dec: Angle.Degrees(-06.30850904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173820"},
        {"Hipparcos Number", "HIP 92210"},
        {"Geneva Identification System", "GEN# +1.00173820"},
        {"Wilson Evans Batten Catalogue", "WEB 15905"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.89454434),
        dec: Angle.Degrees(-06.30754238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11966"},
        {"Smithsonian Astrophysical Observation", "SAO 129982"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59642199),
        dec: Angle.Degrees(-06.30619570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90750"},
        {"Hipparcos Number", "HIP 51287"},
        {"Smithsonian Astrophysical Observation", "SAO 137589"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.14151941),
        dec: Angle.Degrees(-06.30330269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209645"},
        {"Hipparcos Number", "HIP 109008"},
        {"Smithsonian Astrophysical Observation", "SAO 145854"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.26397133),
        dec: Angle.Degrees(-06.30255017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111199"},
        {"Hipparcos Number", "HIP 62421"},
        {"Geneva Identification System", "GEN# +1.00111199"},
        {"Smithsonian Astrophysical Observation", "SAO 138967"},
        {"Wilson Evans Batten Catalogue", "WEB 11082"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.88925076),
        dec: Angle.Degrees(-06.30164895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32043"},
        {"Hipparcos Number", "HIP 23250"},
        {"Smithsonian Astrophysical Observation", "SAO 131675"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.04916740),
        dec: Angle.Degrees(-06.30097395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34881"},
        {"Hipparcos Number", "HIP 24916"},
        {"Smithsonian Astrophysical Observation", "SAO 132001"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.09625273),
        dec: Angle.Degrees(-06.29958673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207004"},
        {"Hipparcos Number", "HIP 107475"},
        {"Smithsonian Astrophysical Observation", "SAO 145647"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.53115543),
        dec: Angle.Degrees(-06.29894040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142864"},
        {"Hipparcos Number", "HIP 78124"},
        {"Geneva Identification System", "GEN# +1.00142864"},
        {"Smithsonian Astrophysical Observation", "SAO 140853"},
        {"Wilson Evans Batten Catalogue", "WEB 13212"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.28593518),
        dec: Angle.Degrees(-06.29662508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7948"},
        {"Hipparcos Number", "HIP 6146"},
        {"Smithsonian Astrophysical Observation", "SAO 129220"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.72678063),
        dec: Angle.Degrees(-06.29434916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149724"},
        {"Hipparcos Number", "HIP 81347"},
        {"Fundamental Katalog 5th Edition", "FK5 5469"},
        {"Geneva Identification System", "GEN# +1.00149724"},
        {"Smithsonian Astrophysical Observation", "SAO 141271"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.20237454),
        dec: Angle.Degrees(-06.29429847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197774"},
        {"Hipparcos Number", "HIP 102478"},
        {"Smithsonian Astrophysical Observation", "SAO 144783"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.50205044),
        dec: Angle.Degrees(-06.29330173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78849",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9918 AB"},
        {"Henry Draper", "HD 144362"},
        {"Hipparcos Number", "HIP 78849"},
        {"Geneva Identification System", "GEN# +1.00144362"},
        {"Smithsonian Astrophysical Observation", "SAO 140945"},
        {"Wilson Evans Batten Catalogue", "WEB 13330"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.43552422),
        dec: Angle.Degrees(-06.29114310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144309"},
        {"Hipparcos Number", "HIP 78822"},
        {"Geneva Identification System", "GEN# +1.00144309"},
        {"Smithsonian Astrophysical Observation", "SAO 140942"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.36305050),
        dec: Angle.Degrees(-06.29048354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221308"},
        {"Hipparcos Number", "HIP 116060"},
        {"Geneva Identification System", "GEN# +1.00221308"},
        {"Smithsonian Astrophysical Observation", "SAO 146748"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.75478141),
        dec: Angle.Degrees(-06.28800944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189987"},
        {"Hipparcos Number", "HIP 98723"},
        {"Geneva Identification System", "GEN# +1.00189987"},
        {"Smithsonian Astrophysical Observation", "SAO 144028"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.77177030),
        dec: Angle.Degrees(-06.28773593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27660"},
        {"Hipparcos Number", "HIP 20360"},
        {"Geneva Identification System", "GEN# +1.00027660"},
        {"Smithsonian Astrophysical Observation", "SAO 131143"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.40629627),
        dec: Angle.Degrees(-06.28413788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21716"},
        {"Hipparcos Number", "HIP 16293"},
        {"Smithsonian Astrophysical Observation", "SAO 130522"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.50127674),
        dec: Angle.Degrees(-06.28405766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104486"},
        {"Hipparcos Number", "HIP 58677"},
        {"Smithsonian Astrophysical Observation", "SAO 138544"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.48001802),
        dec: Angle.Degrees(-06.28259530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92507",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11752 A"},
        {"Henry Draper", "HD 174512"},
        {"Hipparcos Number", "HIP 92507"},
        {"Smithsonian Astrophysical Observation", "SAO 142695"},
        {"Wilson Evans Batten Catalogue", "WEB 15992"},
    },
    visualMagnitude: 8.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.78323682),
        dec: Angle.Degrees(-06.27916826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29651",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4853 A"},
        {"Henry Draper", "HD 43232"},
        {"Hipparcos Number", "HIP 29651"},
        {"Fundamental Katalog 5th Edition", "FK5 2475"},
        {"Geneva Identification System", "GEN# +1.00043232"},
        {"Smithsonian Astrophysical Observation", "SAO 133012"},
        {"Wilson Evans Batten Catalogue", "WEB 5841"},
    },
    visualMagnitude: 3.99,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.71390194),
        dec: Angle.Degrees(-06.27472737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49740"},
        {"Hipparcos Number", "HIP 32732"},
        {"Smithsonian Astrophysical Observation", "SAO 133733"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.41746144),
        dec: Angle.Degrees(-06.27374987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208921"},
        {"Hipparcos Number", "HIP 108574"},
        {"Smithsonian Astrophysical Observation", "SAO 145794"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.91235249),
        dec: Angle.Degrees(-06.27368608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222814"},
        {"Hipparcos Number", "HIP 117056"},
        {"Geneva Identification System", "GEN# +1.00222814"},
        {"Smithsonian Astrophysical Observation", "SAO 146870"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.96093474),
        dec: Angle.Degrees(-06.27333418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9625"},
        {"Hipparcos Number", "HIP 7320"},
        {"Smithsonian Astrophysical Observation", "SAO 129376"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.56812303),
        dec: Angle.Degrees(-06.27252304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76450"},
        {"Hipparcos Number", "HIP 43857"},
        {"Smithsonian Astrophysical Observation", "SAO 136417"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.01808333),
        dec: Angle.Degrees(-06.27187494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11691"},
        {"Hipparcos Number", "HIP 8899"},
        {"Geneva Identification System", "GEN# +1.00011691"},
        {"Smithsonian Astrophysical Observation", "SAO 129560"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.65538535),
        dec: Angle.Degrees(-06.27182291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77194"},
        {"Hipparcos Number", "HIP 44273"},
        {"Smithsonian Astrophysical Observation", "SAO 136493"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.22987353),
        dec: Angle.Degrees(-06.27074807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137913"},
        {"Hipparcos Number", "HIP 75789"},
        {"Smithsonian Astrophysical Observation", "SAO 140562"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.24188072),
        dec: Angle.Degrees(-06.26932425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161114"},
        {"Hipparcos Number", "HIP 86777"},
        {"Geneva Identification System", "GEN# +1.00161114"},
        {"Smithsonian Astrophysical Observation", "SAO 141834"},
        {"Wilson Evans Batten Catalogue", "WEB 14632"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.98539904),
        dec: Angle.Degrees(-06.26908168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115631"},
        {"Hipparcos Number", "HIP 64932"},
        {"Smithsonian Astrophysical Observation", "SAO 139272"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.63793116),
        dec: Angle.Degrees(-06.26575188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221195"},
        {"Hipparcos Number", "HIP 115988"},
        {"Smithsonian Astrophysical Observation", "SAO 146740"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.49247418),
        dec: Angle.Degrees(-06.26396817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75687"},
        {"Hipparcos Number", "HIP 43470"},
        {"Smithsonian Astrophysical Observation", "SAO 136338"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.82262679),
        dec: Angle.Degrees(-06.26303387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 552"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.68869427),
        dec: Angle.Degrees(-06.26131902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224335"},
        {"Hipparcos Number", "HIP 118070"},
        {"Smithsonian Astrophysical Observation", "SAO 146991"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.26407206),
        dec: Angle.Degrees(-06.25717600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117675"},
        {"Hipparcos Number", "HIP 66006"},
        {"Fundamental Katalog 5th Edition", "FK5 3079"},
        {"Geneva Identification System", "GEN# +1.00117675"},
        {"Smithsonian Astrophysical Observation", "SAO 139390"},
        {"Wilson Evans Batten Catalogue", "WEB 11670"},
    },
    visualMagnitude: 4.68,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.99144179),
        dec: Angle.Degrees(-06.25571065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173532"},
        {"Hipparcos Number", "HIP 92082"},
        {"Smithsonian Astrophysical Observation", "SAO 142598"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.50867823),
        dec: Angle.Degrees(-06.25203105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169155"},
        {"Hipparcos Number", "HIP 90131"},
        {"Geneva Identification System", "GEN# +1.00169155"},
        {"Smithsonian Astrophysical Observation", "SAO 142266"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.89558778),
        dec: Angle.Degrees(-06.25079837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107668",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15337 A"},
        {"Henry Draper", "HD 207373"},
        {"Hipparcos Number", "HIP 107668"},
        {"Smithsonian Astrophysical Observation", "SAO 145680"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.14445565),
        dec: Angle.Degrees(-06.24908854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6262 B"},
        {"Hipparcos Number", "HIP 37333"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.95450084),
        dec: Angle.Degrees(-06.24856566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3965"},
        {"Hipparcos Number", "HIP 3313"},
        {"Smithsonian Astrophysical Observation", "SAO 128910"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.54793439),
        dec: Angle.Degrees(-06.24674947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27536"},
        {"Hipparcos Number", "HIP 20263"},
        {"Geneva Identification System", "GEN# +1.00027536"},
        {"Smithsonian Astrophysical Observation", "SAO 131129"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.16078257),
        dec: Angle.Degrees(-06.24585928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137241"},
        {"Hipparcos Number", "HIP 75474"},
        {"Geneva Identification System", "GEN# +1.00137241"},
        {"Smithsonian Astrophysical Observation", "SAO 140519"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.26882853),
        dec: Angle.Degrees(-06.24578253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156227"},
        {"Hipparcos Number", "HIP 84524"},
        {"Fundamental Katalog 5th Edition", "FK5 3371"},
        {"Geneva Identification System", "GEN# +1.00156227"},
        {"Smithsonian Astrophysical Observation", "SAO 141585"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.17813721),
        dec: Angle.Degrees(-06.24495690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27008"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.93787290),
        dec: Angle.Degrees(-06.24455318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37332",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6262 A"},
        {"Henry Draper", "HD 61583"},
        {"Hipparcos Number", "HIP 37332"},
        {"Geneva Identification System", "GEN# +1.00061583"},
        {"Smithsonian Astrophysical Observation", "SAO 134950"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.95361788),
        dec: Angle.Degrees(-06.24428587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212022"},
        {"Hipparcos Number", "HIP 110378"},
        {"Smithsonian Astrophysical Observation", "SAO 146041"},
        {"Wilson Evans Batten Catalogue", "WEB 19794"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.34951545),
        dec: Angle.Degrees(-06.24310519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200454"},
        {"Hipparcos Number", "HIP 103947"},
        {"Smithsonian Astrophysical Observation", "SAO 145061"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.91894992),
        dec: Angle.Degrees(-06.24249634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56492"},
        {"Hipparcos Number", "HIP 35251"},
        {"Smithsonian Astrophysical Observation", "SAO 134455"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.25513327),
        dec: Angle.Degrees(-06.23812175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17515"},
        {"Hipparcos Number", "HIP 13096"},
        {"Smithsonian Astrophysical Observation", "SAO 130120"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.09773359),
        dec: Angle.Degrees(-06.23659680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66587"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.74430485),
        dec: Angle.Degrees(-06.23635436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18765"},
        {"Smithsonian Astrophysical Observation", "SAO 130875"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.30033598),
        dec: Angle.Degrees(-06.23454901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203540"},
        {"Hipparcos Number", "HIP 105575"},
        {"Smithsonian Astrophysical Observation", "SAO 145352"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.74668282),
        dec: Angle.Degrees(-06.23265849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126033"},
        {"Hipparcos Number", "HIP 70314"},
        {"Smithsonian Astrophysical Observation", "SAO 139906"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.79242253),
        dec: Angle.Degrees(-06.23238755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145914"},
        {"Hipparcos Number", "HIP 79528"},
        {"Smithsonian Astrophysical Observation", "SAO 141041"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.43309544),
        dec: Angle.Degrees(-06.22933973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39230"},
        {"Hipparcos Number", "HIP 27624"},
        {"Geneva Identification System", "GEN# +1.00039230"},
        {"Smithsonian Astrophysical Observation", "SAO 132586"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.72725444),
        dec: Angle.Degrees(-06.22763572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60276"},
        {"Hipparcos Number", "HIP 36754"},
        {"Smithsonian Astrophysical Observation", "SAO 134835"},
        {"Wilson Evans Batten Catalogue", "WEB 7307"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.38988563),
        dec: Angle.Degrees(-06.22697926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151393"},
        {"Hipparcos Number", "HIP 82183"},
        {"Smithsonian Astrophysical Observation", "SAO 141360"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.85018769),
        dec: Angle.Degrees(-06.22498837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113665"},
        {"Hipparcos Number", "HIP 63871"},
        {"Smithsonian Astrophysical Observation", "SAO 139143"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.35857238),
        dec: Angle.Degrees(-06.22349704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195767"},
        {"Hipparcos Number", "HIP 101436"},
        {"Smithsonian Astrophysical Observation", "SAO 144563"},
        {"Wilson Evans Batten Catalogue", "WEB 18325"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.35641371),
        dec: Angle.Degrees(-06.21940534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33158"},
        {"Hipparcos Number", "HIP 23893"},
        {"Smithsonian Astrophysical Observation", "SAO 131799"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.01559030),
        dec: Angle.Degrees(-06.21888607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209195"},
        {"Hipparcos Number", "HIP 108735"},
        {"Smithsonian Astrophysical Observation", "SAO 145813"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.39773840),
        dec: Angle.Degrees(-06.21302188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76013"},
        {"Hipparcos Number", "HIP 43648"},
        {"Smithsonian Astrophysical Observation", "SAO 136370"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.35302790),
        dec: Angle.Degrees(-06.21189497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102858"},
        {"Hipparcos Number", "HIP 57745"},
        {"Smithsonian Astrophysical Observation", "SAO 138438"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.62239832),
        dec: Angle.Degrees(-06.21089089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212443"},
        {"Hipparcos Number", "HIP 110597"},
        {"Smithsonian Astrophysical Observation", "SAO 146071"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.08945529),
        dec: Angle.Degrees(-06.21077720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161639"},
        {"Hipparcos Number", "HIP 87034"},
        {"Geneva Identification System", "GEN# +1.00161639"},
        {"Smithsonian Astrophysical Observation", "SAO 141870"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.74186589),
        dec: Angle.Degrees(-06.20892290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43411"},
        {"Hipparcos Number", "HIP 29738"},
        {"Smithsonian Astrophysical Observation", "SAO 133039"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.94352224),
        dec: Angle.Degrees(-06.20845829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2566"},
        {"Smithsonian Astrophysical Observation", "SAO 128816"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14619664),
        dec: Angle.Degrees(-06.20702753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45216"},
        {"Hipparcos Number", "HIP 30607"},
        {"Smithsonian Astrophysical Observation", "SAO 133243"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49407016),
        dec: Angle.Degrees(-06.20510904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7675 AB"},
        {"Henry Draper", "HD 88478"},
        {"Hipparcos Number", "HIP 49961"},
        {"Smithsonian Astrophysical Observation", "SAO 137406"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.00531371),
        dec: Angle.Degrees(-06.20291059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41794"},
        {"Hipparcos Number", "HIP 28985"},
        {"Geneva Identification System", "GEN# +1.00041794"},
        {"Smithsonian Astrophysical Observation", "SAO 132848"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.74400175),
        dec: Angle.Degrees(-06.20263698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116249"},
        {"Hipparcos Number", "HIP 65265"},
        {"Smithsonian Astrophysical Observation", "SAO 139304"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.62912461),
        dec: Angle.Degrees(-06.20180359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159612"},
        {"Hipparcos Number", "HIP 86108"},
        {"Smithsonian Astrophysical Observation", "SAO 141749"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.96227745),
        dec: Angle.Degrees(-06.20173122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25836"},
        {"Renson", "Renson 9390"},
    },
    visualMagnitude: 12.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30, 57.1800),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)11, 41.600)
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
    primaryId: "HIP 3915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4822"},
        {"Hipparcos Number", "HIP 3915"},
        {"Geneva Identification System", "GEN# +1.00004822"},
        {"Smithsonian Astrophysical Observation", "SAO 128976"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.56191859),
        dec: Angle.Degrees(-06.19424277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40212"},
        {"Hipparcos Number", "HIP 28174"},
        {"Smithsonian Astrophysical Observation", "SAO 132686"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.29084484),
        dec: Angle.Degrees(-06.19387337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89670"},
        {"Hipparcos Number", "HIP 50649"},
        {"Geneva Identification System", "GEN# +1.00089670"},
        {"Smithsonian Astrophysical Observation", "SAO 137503"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.16186605),
        dec: Angle.Degrees(-06.19281396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49886"},
        {"Hipparcos Number", "HIP 32807"},
        {"Geneva Identification System", "GEN# +1.00049886"},
        {"Smithsonian Astrophysical Observation", "SAO 133752"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.58764065),
        dec: Angle.Degrees(-06.19279270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14840"},
        {"Hipparcos Number", "HIP 11139"},
        {"Geneva Identification System", "GEN# +1.00014840"},
        {"Smithsonian Astrophysical Observation", "SAO 129868"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84268764),
        dec: Angle.Degrees(-06.19265901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176630"},
        {"Hipparcos Number", "HIP 93411"},
        {"Smithsonian Astrophysical Observation", "SAO 142927"},
        {"Wilson Evans Batten Catalogue", "WEB 16207"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.36379447),
        dec: Angle.Degrees(-06.19259535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32057"},
        {"Hipparcos Number", "HIP 23264"},
        {"Geneva Identification System", "GEN# +1.00032057"},
        {"Smithsonian Astrophysical Observation", "SAO 131677"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.08224564),
        dec: Angle.Degrees(-06.19248978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220120"},
        {"Hipparcos Number", "HIP 115311"},
        {"Smithsonian Astrophysical Observation", "SAO 146658"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.31397558),
        dec: Angle.Degrees(-06.19245701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36366"},
        {"Hipparcos Number", "HIP 25841"},
        {"Geneva Identification System", "GEN# +1.00036366"},
        {"Smithsonian Astrophysical Observation", "SAO 132203"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.75047974),
        dec: Angle.Degrees(-06.19133595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196713"},
        {"Hipparcos Number", "HIP 101925"},
        {"Smithsonian Astrophysical Observation", "SAO 144667"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.82412634),
        dec: Angle.Degrees(-06.19095947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1423"},
        {"Smithsonian Astrophysical Observation", "SAO 128686"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.45115744),
        dec: Angle.Degrees(-06.18826139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121111"},
        {"Hipparcos Number", "HIP 67825"},
        {"Geneva Identification System", "GEN# +1.00121111"},
        {"Smithsonian Astrophysical Observation", "SAO 139605"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.40874912),
        dec: Angle.Degrees(-06.18786278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43513"},
        {"Hipparcos Number", "HIP 29797"},
        {"Smithsonian Astrophysical Observation", "SAO 133049"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.09907420),
        dec: Angle.Degrees(-06.18615022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85380"},
        {"Hipparcos Number", "HIP 48351"},
        {"Geneva Identification System", "GEN# +1.00085380"},
        {"Smithsonian Astrophysical Observation", "SAO 137185"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.84037715),
        dec: Angle.Degrees(-06.18205868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176714"},
        {"Hipparcos Number", "HIP 93451"},
        {"Smithsonian Astrophysical Observation", "SAO 142937"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.48227196),
        dec: Angle.Degrees(-06.18164364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69848"},
        {"Hipparcos Number", "HIP 40722"},
        {"Smithsonian Astrophysical Observation", "SAO 135758"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68242519),
        dec: Angle.Degrees(-06.18157950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212081"},
        {"Hipparcos Number", "HIP 110406"},
        {"Smithsonian Astrophysical Observation", "SAO 146045"},
        {"Wilson Evans Batten Catalogue", "WEB 19800"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.44333783),
        dec: Angle.Degrees(-06.18132076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84283"},
        {"Hipparcos Number", "HIP 47757"},
        {"Smithsonian Astrophysical Observation", "SAO 137090"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.03885087),
        dec: Angle.Degrees(-06.18070999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20699"},
        {"Geneva Identification System", "GEN# -0.00600904"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.50865326),
        dec: Angle.Degrees(-06.18031131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70574"},
        {"Hipparcos Number", "HIP 41036"},
        {"Fundamental Katalog 5th Edition", "FK5 2650"},
        {"Geneva Identification System", "GEN# +1.00070574"},
        {"Smithsonian Astrophysical Observation", "SAO 135832"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.62582952),
        dec: Angle.Degrees(-06.17915957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73767"},
        {"Smithsonian Astrophysical Observation", "SAO 140304"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.18595921),
        dec: Angle.Degrees(-06.17561124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6788"},
        {"Hipparcos Number", "HIP 5356"},
        {"Geneva Identification System", "GEN# +1.00006788"},
        {"Smithsonian Astrophysical Observation", "SAO 129140"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.11175119),
        dec: Angle.Degrees(-06.17509386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199551"},
        {"Hipparcos Number", "HIP 103495"},
        {"Smithsonian Astrophysical Observation", "SAO 144986"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.52340093),
        dec: Angle.Degrees(-06.17505599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25709"},
        {"Hipparcos Number", "HIP 19022"},
        {"Smithsonian Astrophysical Observation", "SAO 130919"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.12423108),
        dec: Angle.Degrees(-06.17283143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110816"},
        {"Hipparcos Number", "HIP 62190"},
        {"Smithsonian Astrophysical Observation", "SAO 138947"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.18120696),
        dec: Angle.Degrees(-06.17274509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4721"},
        {"Hipparcos Number", "HIP 3837"},
        {"Smithsonian Astrophysical Observation", "SAO 128967"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.31149408),
        dec: Angle.Degrees(-06.17002948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154518"},
        {"Hipparcos Number", "HIP 83676"},
        {"Geneva Identification System", "GEN# +1.00154518"},
        {"Smithsonian Astrophysical Observation", "SAO 141515"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.53441033),
        dec: Angle.Degrees(-06.16708953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37470"},
        {"Hipparcos Number", "HIP 26530"},
        {"Celescope Catalog", "CEL 886"},
        {"Geneva Identification System", "GEN# +1.00037470"},
        {"Renson", "Renson 10070"},
        {"Smithsonian Astrophysical Observation", "SAO 132402"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.64468942),
        dec: Angle.Degrees(-06.16387412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191500"},
        {"Hipparcos Number", "HIP 99396"},
        {"Geneva Identification System", "GEN# +1.00191500"},
        {"Smithsonian Astrophysical Observation", "SAO 144133"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.62354814),
        dec: Angle.Degrees(-06.16347634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119668"},
        {"Hipparcos Number", "HIP 67072"},
        {"Smithsonian Astrophysical Observation", "SAO 139525"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.19279095),
        dec: Angle.Degrees(-06.16305263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10338"},
        {"Hipparcos Number", "HIP 7843"},
        {"Smithsonian Astrophysical Observation", "SAO 129445"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21722422),
        dec: Angle.Degrees(-06.16262014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106622"},
        {"Hipparcos Number", "HIP 59808"},
        {"Smithsonian Astrophysical Observation", "SAO 138680"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.96978341),
        dec: Angle.Degrees(-06.16025356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78851"},
        {"Hipparcos Number", "HIP 45034"},
        {"Smithsonian Astrophysical Observation", "SAO 136636"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.58719814),
        dec: Angle.Degrees(-06.15970639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8202"},
        {"Hipparcos Number", "HIP 6331"},
        {"Geneva Identification System", "GEN# +1.00008202"},
        {"Smithsonian Astrophysical Observation", "SAO 129246"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.32292445),
        dec: Angle.Degrees(-06.15943607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9515 AB"},
        {"Henry Draper", "HD 134213"},
        {"Hipparcos Number", "HIP 74116"},
        {"Smithsonian Astrophysical Observation", "SAO 140343"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.20805084),
        dec: Angle.Degrees(-06.15914011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194548"},
        {"Hipparcos Number", "HIP 100806"},
        {"Smithsonian Astrophysical Observation", "SAO 144425"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.59478135),
        dec: Angle.Degrees(-06.15789254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197658"},
        {"Hipparcos Number", "HIP 102421"},
        {"Geneva Identification System", "GEN# +1.00197658"},
        {"Smithsonian Astrophysical Observation", "SAO 144765"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.31580949),
        dec: Angle.Degrees(-06.15782139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118246"},
        {"Hipparcos Number", "HIP 66339"},
        {"Geneva Identification System", "GEN# +1.00118246"},
        {"Smithsonian Astrophysical Observation", "SAO 139430"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.93052715),
        dec: Angle.Degrees(-06.15610353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1370"},
        {"Hipparcos Number", "HIP 1422"},
        {"Smithsonian Astrophysical Observation", "SAO 128684"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.44860817),
        dec: Angle.Degrees(-06.15451622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152601"},
        {"Hipparcos Number", "HIP 82730"},
        {"Fundamental Katalog 5th Edition", "FK5 3342"},
        {"Geneva Identification System", "GEN# +1.00152601"},
        {"Smithsonian Astrophysical Observation", "SAO 141431"},
        {"Wilson Evans Batten Catalogue", "WEB 13984"},
    },
    visualMagnitude: 5.23,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.64879810),
        dec: Angle.Degrees(-06.15392897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97156"},
        {"Hipparcos Number", "HIP 54635"},
        {"Smithsonian Astrophysical Observation", "SAO 138033"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.73704728),
        dec: Angle.Degrees(-06.15167005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170117"},
        {"Hipparcos Number", "HIP 90512"},
        {"Smithsonian Astrophysical Observation", "SAO 142334"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02804570),
        dec: Angle.Degrees(-06.15132043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140732"},
        {"Hipparcos Number", "HIP 77174"},
        {"Smithsonian Astrophysical Observation", "SAO 140734"},
        {"Wilson Evans Batten Catalogue", "WEB 13081"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.36530230),
        dec: Angle.Degrees(-06.14531612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85588"},
        {"Hipparcos Number", "HIP 48446"},
        {"Smithsonian Astrophysical Observation", "SAO 137201"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.16158908),
        dec: Angle.Degrees(-06.14485453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5445 A"},
        {"Henry Draper", "HD 49145"},
        {"Hipparcos Number", "HIP 32483"},
        {"Smithsonian Astrophysical Observation", "SAO 133664"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.69388699),
        dec: Angle.Degrees(-06.14476595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15873"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.11619540),
        dec: Angle.Degrees(-06.14442445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185125"},
        {"Hipparcos Number", "HIP 96560"},
        {"Smithsonian Astrophysical Observation", "SAO 143623"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.46072869),
        dec: Angle.Degrees(-06.14372640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162714"},
        {"Hipparcos Number", "HIP 87495"},
        {"Geneva Identification System", "GEN# +1.00162714"},
        {"Smithsonian Astrophysical Observation", "SAO 141926"},
        {"Wilson Evans Batten Catalogue", "WEB 14757"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.16126597),
        dec: Angle.Degrees(-06.14356506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117966"},
        {"Geneva Identification System", "GEN# -0.00606318"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91691017),
        dec: Angle.Degrees(-06.14162219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -476.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -391.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3243"},
        {"Hipparcos Number", "HIP 2785"},
        {"Smithsonian Astrophysical Observation", "SAO 128844"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.88093133),
        dec: Angle.Degrees(-06.14091322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144390"},
        {"Hipparcos Number", "HIP 78870"},
        {"Geneva Identification System", "GEN# +1.00144390"},
        {"Smithsonian Astrophysical Observation", "SAO 140947"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.49930167),
        dec: Angle.Degrees(-06.13974091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200845"},
        {"Hipparcos Number", "HIP 104157"},
        {"Smithsonian Astrophysical Observation", "SAO 145091"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.53445657),
        dec: Angle.Degrees(-06.13963357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103972"},
        {"Cincinnati Publication", "Ci 20 1253"},
        {"Geneva Identification System", "GEN# -0.00605663"},
        {"Wilson Evans Batten Catalogue", "WEB 18937"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.99371010),
        dec: Angle.Degrees(-06.13962895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1100"},
        {"Hipparcos Number", "HIP 1230"},
        {"Smithsonian Astrophysical Observation", "SAO 128662"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81786872),
        dec: Angle.Degrees(-06.13809070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57252"},
        {"Hipparcos Number", "HIP 35556"},
        {"Smithsonian Astrophysical Observation", "SAO 134529"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.05471957),
        dec: Angle.Degrees(-06.13804401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149363"},
        {"Hipparcos Number", "HIP 81153"},
        {"Geneva Identification System", "GEN# +1.00149363"},
        {"Smithsonian Astrophysical Observation", "SAO 141251"},
        {"Wilson Evans Batten Catalogue", "WEB 13723"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.61784712),
        dec: Angle.Degrees(-06.13615439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57385"},
        {"Hipparcos Number", "HIP 35602"},
        {"Smithsonian Astrophysical Observation", "SAO 134545"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.20783631),
        dec: Angle.Degrees(-06.13550801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67285"},
        {"Cincinnati Publication", "Ci 20 806"},
        {"Geneva Identification System", "GEN# -0.00503763"},
        {"Wilson Evans Batten Catalogue", "WEB 11839"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.84852038),
        dec: Angle.Degrees(-06.13547638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -338.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -575.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13497"},
        {"Hipparcos Number", "HIP 10239"},
        {"Geneva Identification System", "GEN# +1.00013497"},
        {"Smithsonian Astrophysical Observation", "SAO 129743"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.92290031),
        dec: Angle.Degrees(-06.13451411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8687 A"},
        {"Henry Draper", "HD 111767"},
        {"Hipparcos Number", "HIP 62761"},
        {"Smithsonian Astrophysical Observation", "SAO 139004"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.91808902),
        dec: Angle.Degrees(-06.13310829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139426"},
        {"Hipparcos Number", "HIP 76571"},
        {"Smithsonian Astrophysical Observation", "SAO 140667"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56840816),
        dec: Angle.Degrees(-06.13146010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138954"},
        {"Hipparcos Number", "HIP 76331"},
        {"Geneva Identification System", "GEN# +1.00138954"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.87917287),
        dec: Angle.Degrees(-06.13061371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222890"},
        {"Hipparcos Number", "HIP 117124"},
        {"Smithsonian Astrophysical Observation", "SAO 146881"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.16647824),
        dec: Angle.Degrees(-06.13055885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38800"},
        {"Hipparcos Number", "HIP 27395"},
        {"Celescope Catalog", "CEL 980"},
        {"Geneva Identification System", "GEN# +1.00038800"},
        {"Smithsonian Astrophysical Observation", "SAO 132545"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.02667473),
        dec: Angle.Degrees(-06.12939162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159611"},
        {"Hipparcos Number", "HIP 86114"},
        {"Geneva Identification System", "GEN# +1.00159611"},
        {"Smithsonian Astrophysical Observation", "SAO 141751"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.97599545),
        dec: Angle.Degrees(-06.12883205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143296"},
        {"Hipparcos Number", "HIP 78341"},
        {"Smithsonian Astrophysical Observation", "SAO 140885"},
        {"Wilson Evans Batten Catalogue", "WEB 13244"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.94504178),
        dec: Angle.Degrees(-06.12748063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72089"},
        {"Smithsonian Astrophysical Observation", "SAO 140110"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.21140020),
        dec: Angle.Degrees(-06.12727871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124159"},
        {"Hipparcos Number", "HIP 69361"},
        {"Geneva Identification System", "GEN# +1.00124159"},
        {"Smithsonian Astrophysical Observation", "SAO 139780"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.96769617),
        dec: Angle.Degrees(-06.12678529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152796"},
        {"Hipparcos Number", "HIP 82845"},
        {"Smithsonian Astrophysical Observation", "SAO 141443"},
        {"Wilson Evans Batten Catalogue", "WEB 14002"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.95475812),
        dec: Angle.Degrees(-06.12327838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219349"},
        {"Hipparcos Number", "HIP 114795"},
        {"Geneva Identification System", "GEN# +1.00219349"},
        {"Smithsonian Astrophysical Observation", "SAO 146591"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80399756),
        dec: Angle.Degrees(-06.12184355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159564"},
        {"Hipparcos Number", "HIP 86097"},
        {"Smithsonian Astrophysical Observation", "SAO 141748"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.92732080),
        dec: Angle.Degrees(-06.12043162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140986"},
        {"Hipparcos Number", "HIP 77287"},
        {"Fundamental Katalog 5th Edition", "FK5 3250"},
        {"Geneva Identification System", "GEN# +1.00140986"},
        {"Smithsonian Astrophysical Observation", "SAO 140751"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.68929693),
        dec: Angle.Degrees(-06.12035820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126722"},
        {"Hipparcos Number", "HIP 70680"},
        {"Geneva Identification System", "GEN# +1.00126722"},
        {"Smithsonian Astrophysical Observation", "SAO 139942"},
        {"Wilson Evans Batten Catalogue", "WEB 12247"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.85176863),
        dec: Angle.Degrees(-06.12019140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43654"},
        {"Hipparcos Number", "HIP 29847"},
        {"Smithsonian Astrophysical Observation", "SAO 133058"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.27256101),
        dec: Angle.Degrees(-06.11909563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107830"},
        {"Hipparcos Number", "HIP 60436"},
        {"Geneva Identification System", "GEN# +1.00107830"},
        {"Smithsonian Astrophysical Observation", "SAO 138754"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86489971),
        dec: Angle.Degrees(-06.11893119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34775"},
        {"Hipparcos Number", "HIP 24854"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.92082673),
        dec: Angle.Degrees(-06.11538901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170883"},
        {"Hipparcos Number", "HIP 90847"},
        {"Smithsonian Astrophysical Observation", "SAO 142370"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.99225088),
        dec: Angle.Degrees(-06.11448382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48215"},
        {"Hipparcos Number", "HIP 32080"},
        {"Geneva Identification System", "GEN# +1.00048215"},
        {"Smithsonian Astrophysical Observation", "SAO 133587"},
        {"Wilson Evans Batten Catalogue", "WEB 6476"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.53047650),
        dec: Angle.Degrees(-06.11426992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12618"},
        {"Smithsonian Astrophysical Observation", "SAO 130064"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.54974232),
        dec: Angle.Degrees(-06.11204078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150078"},
        {"Hipparcos Number", "HIP 81509"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.72735931),
        dec: Angle.Degrees(-06.11156921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41569"},
        {"Hipparcos Number", "HIP 28870"},
        {"Smithsonian Astrophysical Observation", "SAO 132824"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.42596402),
        dec: Angle.Degrees(-06.11100539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3415"},
        {"Hipparcos Number", "HIP 2919"},
        {"Cincinnati Publication", "Ci 18 77"},
        {"Smithsonian Astrophysical Observation", "SAO 128860"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.23832629),
        dec: Angle.Degrees(-06.11087379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5565"},
        {"Hipparcos Number", "HIP 4474"},
        {"Smithsonian Astrophysical Observation", "SAO 129046"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.32764269),
        dec: Angle.Degrees(-06.11003618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216515"},
        {"Hipparcos Number", "HIP 113045"},
        {"Smithsonian Astrophysical Observation", "SAO 146374"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.40781276),
        dec: Angle.Degrees(-06.10874311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168134"},
        {"Hipparcos Number", "HIP 89712"},
        {"Smithsonian Astrophysical Observation", "SAO 142210"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.63741857),
        dec: Angle.Degrees(-06.10782849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13846"},
        {"Hipparcos Number", "HIP 10460"},
        {"Smithsonian Astrophysical Observation", "SAO 129775"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.71697727),
        dec: Angle.Degrees(-06.10593708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123212"},
        {"Hipparcos Number", "HIP 68892"},
        {"Smithsonian Astrophysical Observation", "SAO 139733"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.58317194),
        dec: Angle.Degrees(-06.10253390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164378"},
        {"Hipparcos Number", "HIP 88229"},
        {"Smithsonian Astrophysical Observation", "SAO 142033"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.25990489),
        dec: Angle.Degrees(-06.10224371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31712"},
        {"Hipparcos Number", "HIP 23076"},
        {"Smithsonian Astrophysical Observation", "SAO 131635"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.47654316),
        dec: Angle.Degrees(-06.10216591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99763"},
        {"Hipparcos Number", "HIP 55996"},
        {"Smithsonian Astrophysical Observation", "SAO 138225"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.13329809),
        dec: Angle.Degrees(-06.10182355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110069"},
        {"Hipparcos Number", "HIP 61763"},
        {"Smithsonian Astrophysical Observation", "SAO 138897"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.87893541),
        dec: Angle.Degrees(-06.10055593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4982"},
        {"Hipparcos Number", "HIP 4036"},
        {"Geneva Identification System", "GEN# +1.00004982"},
        {"Smithsonian Astrophysical Observation", "SAO 128994"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.93566969),
        dec: Angle.Degrees(-06.10010154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15230"},
        {"Hipparcos Number", "HIP 11412"},
        {"Smithsonian Astrophysical Observation", "SAO 129909"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.77089347),
        dec: Angle.Degrees(-06.09807837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91613"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.25276328),
        dec: Angle.Degrees(-06.09722355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148071"},
        {"Hipparcos Number", "HIP 80494"},
        {"Smithsonian Astrophysical Observation", "SAO 141166"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.46132069),
        dec: Angle.Degrees(-06.09500279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40301"},
        {"Hipparcos Number", "HIP 28215"},
        {"Smithsonian Astrophysical Observation", "SAO 132692"},
        {"Wilson Evans Batten Catalogue", "WEB 5522"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.42264416),
        dec: Angle.Degrees(-06.09468667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148741"},
        {"Hipparcos Number", "HIP 80834"},
        {"Geneva Identification System", "GEN# +1.00148741"},
        {"Smithsonian Astrophysical Observation", "SAO 141205"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.61415975),
        dec: Angle.Degrees(-06.09272597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112741"},
        {"Hipparcos Number", "HIP 63363"},
        {"Smithsonian Astrophysical Observation", "SAO 139079"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.75077390),
        dec: Angle.Degrees(-06.09090384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111846"},
        {"Hipparcos Number", "HIP 62810"},
        {"Smithsonian Astrophysical Observation", "SAO 139009"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.05261634),
        dec: Angle.Degrees(-06.09010668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19349"},
        {"Hipparcos Number", "HIP 14456"},
        {"Fundamental Katalog 5th Edition", "FK5 2221"},
        {"Geneva Identification System", "GEN# +1.00019349"},
        {"Smithsonian Astrophysical Observation", "SAO 130284"},
        {"Wilson Evans Batten Catalogue", "WEB 2816"},
    },
    visualMagnitude: 5.23,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63953388),
        dec: Angle.Degrees(-06.08854227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191619"},
        {"Hipparcos Number", "HIP 99450"},
        {"Smithsonian Astrophysical Observation", "SAO 144142"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.77479946),
        dec: Angle.Degrees(-06.08768956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100800"},
        {"Hipparcos Number", "HIP 56580"},
        {"Smithsonian Astrophysical Observation", "SAO 138290"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.00247266),
        dec: Angle.Degrees(-06.08713476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7025"},
        {"Hipparcos Number", "HIP 5504"},
        {"Geneva Identification System", "GEN# +1.00007025"},
        {"Renson", "Renson 1775"},
        {"Smithsonian Astrophysical Observation", "SAO 129157"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.62740189),
        dec: Angle.Degrees(-06.08462407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8429 A"},
        {"Henry Draper", "HD 105265"},
        {"Hipparcos Number", "HIP 59104"},
        {"Smithsonian Astrophysical Observation", "SAO 138592"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.80476994),
        dec: Angle.Degrees(-06.08409698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113939"},
        {"Hipparcos Number", "HIP 64023"},
        {"Geneva Identification System", "GEN# +1.00113939"},
        {"Smithsonian Astrophysical Observation", "SAO 139166"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.79708142),
        dec: Angle.Degrees(-06.08199482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150258"},
        {"Hipparcos Number", "HIP 81608"},
        {"Geneva Identification System", "GEN# +1.00150258"},
        {"Smithsonian Astrophysical Observation", "SAO 141302"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.00753203),
        dec: Angle.Degrees(-06.08101871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92956"},
        {"Hipparcos Number", "HIP 52492"},
        {"Smithsonian Astrophysical Observation", "SAO 137756"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.97409003),
        dec: Angle.Degrees(-06.07832672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13996"},
        {"Smithsonian Astrophysical Observation", "SAO 130236"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.04912453),
        dec: Angle.Degrees(-06.07800015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90617"},
    },
    visualMagnitude: 11.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.35705114),
        dec: Angle.Degrees(-06.07701142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25509"},
        {"Smithsonian Astrophysical Observation", "SAO 132124"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.82006431),
        dec: Angle.Degrees(-06.07612257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51602",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7822 AB"},
        {"Henry Draper", "HD 91318"},
        {"Hipparcos Number", "HIP 51602"},
        {"Smithsonian Astrophysical Observation", "SAO 137628"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.11895023),
        dec: Angle.Degrees(-06.07499483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177793"},
        {"Hipparcos Number", "HIP 93821"},
        {"Smithsonian Astrophysical Observation", "SAO 143027"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.59385873),
        dec: Angle.Degrees(-06.07455607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27651"},
        {"Hipparcos Number", "HIP 20344"},
        {"Smithsonian Astrophysical Observation", "SAO 131141"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.37689345),
        dec: Angle.Degrees(-06.07309172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81809"},
        {"Hipparcos Number", "HIP 46404"},
        {"Geneva Identification System", "GEN# +1.00081809J"},
        {"Smithsonian Astrophysical Observation", "SAO 136872"},
        {"Wilson Evans Batten Catalogue", "WEB 8769"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.94548780),
        dec: Angle.Degrees(-06.07102871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83405"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.70691778),
        dec: Angle.Degrees(-06.06819877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2194"},
        {"Hipparcos Number", "HIP 2044"},
        {"Smithsonian Astrophysical Observation", "SAO 128759"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.48405087),
        dec: Angle.Degrees(-06.06777496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214301"},
        {"Hipparcos Number", "HIP 111668"},
        {"Smithsonian Astrophysical Observation", "SAO 146205"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.32461609),
        dec: Angle.Degrees(-06.06736956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109685"},
        {"Hipparcos Number", "HIP 61542"},
        {"Smithsonian Astrophysical Observation", "SAO 138870"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.14168517),
        dec: Angle.Degrees(-06.06557334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37209"},
        {"Hipparcos Number", "HIP 26345"},
        {"Celescope Catalog", "CEL 859"},
        {"Geneva Identification System", "GEN# +9.00011017"},
        {"Smithsonian Astrophysical Observation", "SAO 132359"},
        {"Wilson Evans Batten Catalogue", "WEB 5193"},
    },
    visualMagnitude: 5.71,
    bvColour: -0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.14872314),
        dec: Angle.Degrees(-06.06475248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185510"},
        {"Hipparcos Number", "HIP 96714"},
        {"Geneva Identification System", "GEN# +1.00185510"},
        {"Smithsonian Astrophysical Observation", "SAO 143657"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.91168365),
        dec: Angle.Degrees(-06.06367153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24207"},
        {"Hipparcos Number", "HIP 18015"},
        {"Geneva Identification System", "GEN# +1.00024207"},
        {"Smithsonian Astrophysical Observation", "SAO 130769"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.75740106),
        dec: Angle.Degrees(-06.06202182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111646"},
        {"Hipparcos Number", "HIP 62701"},
        {"Smithsonian Astrophysical Observation", "SAO 138994"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.73030174),
        dec: Angle.Degrees(-06.06096001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80917"},
        {"Hipparcos Number", "HIP 45961"},
        {"Smithsonian Astrophysical Observation", "SAO 136792"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.59607581),
        dec: Angle.Degrees(-06.06065549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63843"},
        {"Hipparcos Number", "HIP 38291"},
        {"Renson", "Renson 17630"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.67418811),
        dec: Angle.Degrees(-06.06064237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224997"},
        {"Hipparcos Number", "HIP 187"},
        {"Smithsonian Astrophysical Observation", "SAO 147050"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.60211418),
        dec: Angle.Degrees(-06.05918213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64451"},
        {"Hipparcos Number", "HIP 38570"},
        {"Smithsonian Astrophysical Observation", "SAO 135225"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.45370840),
        dec: Angle.Degrees(-06.05898294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26387"},
        {"Hipparcos Number", "HIP 19469"},
        {"Fundamental Katalog 5th Edition", "FK5 4377"},
        {"Smithsonian Astrophysical Observation", "SAO 130998"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.54648270),
        dec: Angle.Degrees(-06.05809561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33833"},
        {"Hipparcos Number", "HIP 24294"},
        {"Geneva Identification System", "GEN# +1.00033833"},
        {"Smithsonian Astrophysical Observation", "SAO 131873"},
        {"Wilson Evans Batten Catalogue", "WEB 4713"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.20048421),
        dec: Angle.Degrees(-06.05711381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17913"},
        {"Hipparcos Number", "HIP 13403"},
        {"Smithsonian Astrophysical Observation", "SAO 130159"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.13289748),
        dec: Angle.Degrees(-06.05516468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166785"},
        {"Hipparcos Number", "HIP 89226"},
        {"Geneva Identification System", "GEN# +1.00166785"},
        {"Smithsonian Astrophysical Observation", "SAO 142152"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.12555695),
        dec: Angle.Degrees(-06.05508961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178548"},
        {"Hipparcos Number", "HIP 94089"},
        {"Smithsonian Astrophysical Observation", "SAO 143077"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31073572),
        dec: Angle.Degrees(-06.05502091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28864"},
        {"Smithsonian Astrophysical Observation", "SAO 132822"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.41446621),
        dec: Angle.Degrees(-06.05417204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25648"},
        {"Hipparcos Number", "HIP 18977"},
        {"Renson", "Renson 6527"},
        {"Smithsonian Astrophysical Observation", "SAO 130907"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.99445656),
        dec: Angle.Degrees(-06.05181456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8844"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.43900321),
        dec: Angle.Degrees(-06.05059131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162283"},
        {"Hipparcos Number", "HIP 87322"},
        {"Geneva Identification System", "GEN# +1.00162283"},
        {"Wilson Evans Batten Catalogue", "WEB 14733"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.64187182),
        dec: Angle.Degrees(-06.04996555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180086"},
        {"Hipparcos Number", "HIP 94627"},
        {"Geneva Identification System", "GEN# +1.00180086"},
        {"Smithsonian Astrophysical Observation", "SAO 143183"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.84283842),
        dec: Angle.Degrees(-06.04978928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219215"},
        {"Hipparcos Number", "HIP 114724"},
        {"Fundamental Katalog 5th Edition", "FK5 1607"},
        {"Geneva Identification System", "GEN# +1.00219215"},
        {"Smithsonian Astrophysical Observation", "SAO 146585"},
        {"Wilson Evans Batten Catalogue", "WEB 20341"},
    },
    visualMagnitude: 4.22,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.58055219),
        dec: Angle.Degrees(-06.04852680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171150"},
        {"Hipparcos Number", "HIP 90964"},
        {"Smithsonian Astrophysical Observation", "SAO 142385"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.33465828),
        dec: Angle.Degrees(-06.04799471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13552 A"},
        {"Henry Draper", "HD 192290"},
        {"Hipparcos Number", "HIP 99753"},
        {"Geneva Identification System", "GEN# +1.00192290"},
        {"Smithsonian Astrophysical Observation", "SAO 144199"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60140049),
        dec: Angle.Degrees(-06.04738763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181807"},
        {"Hipparcos Number", "HIP 95212"},
        {"Geneva Identification System", "GEN# +1.00181807"},
        {"Smithsonian Astrophysical Observation", "SAO 143319"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.54837323),
        dec: Angle.Degrees(-06.04532278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54658"},
        {"Hipparcos Number", "HIP 34559"},
        {"Geneva Identification System", "GEN# +1.00054658"},
        {"Smithsonian Astrophysical Observation", "SAO 134269"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.38465190),
        dec: Angle.Degrees(-06.04391808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99756",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13552 B"},
        {"Hipparcos Number", "HIP 99756"},
        {"Smithsonian Astrophysical Observation", "SAO 144201"},
    },
    visualMagnitude: 9.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60489156),
        dec: Angle.Degrees(-06.04339492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60702"},
        {"Smithsonian Astrophysical Observation", "SAO 138779"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.61707309),
        dec: Angle.Degrees(-06.04064807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 600"},
        {"Hipparcos Number", "HIP 849"},
        {"Smithsonian Astrophysical Observation", "SAO 128622"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.60385459),
        dec: Angle.Degrees(-06.03970203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12038"},
        {"Hipparcos Number", "HIP 9178"},
        {"Smithsonian Astrophysical Observation", "SAO 129590"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.53204427),
        dec: Angle.Degrees(-06.03618852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130220"},
        {"Hipparcos Number", "HIP 72295"},
        {"Smithsonian Astrophysical Observation", "SAO 140136"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.76587086),
        dec: Angle.Degrees(-06.03466354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41802"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.84111183),
        dec: Angle.Degrees(-06.03369607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -470.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212458"},
        {"Hipparcos Number", "HIP 110601"},
        {"Smithsonian Astrophysical Observation", "SAO 146072"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.10999315),
        dec: Angle.Degrees(-06.03248297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3662"},
        {"Aitken 2", "ADS 3662 AB"},
        {"Henry Draper", "HD 32622"},
        {"Hipparcos Number", "HIP 23586"},
        {"Smithsonian Astrophysical Observation", "SAO 131738"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.07499402),
        dec: Angle.Degrees(-06.03131539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47035"},
        {"Hipparcos Number", "HIP 31563"},
        {"Smithsonian Astrophysical Observation", "SAO 133463"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.09403914),
        dec: Angle.Degrees(-06.02954750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72661"},
        {"Hipparcos Number", "HIP 42018"},
        {"Smithsonian Astrophysical Observation", "SAO 136042"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.47870264),
        dec: Angle.Degrees(-06.02796953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33610"},
        {"Hipparcos Number", "HIP 24146"},
        {"Celescope Catalog", "CEL 560"},
        {"Geneva Identification System", "GEN# +1.00033610"},
        {"Smithsonian Astrophysical Observation", "SAO 131850"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.78580591),
        dec: Angle.Degrees(-06.02357829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108796"},
        {"Hipparcos Number", "HIP 60987"},
        {"Smithsonian Astrophysical Observation", "SAO 138816"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.50828307),
        dec: Angle.Degrees(-06.02324308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139554"},
        {"Hipparcos Number", "HIP 76638"},
        {"Geneva Identification System", "GEN# +1.00139554"},
        {"Smithsonian Astrophysical Observation", "SAO 140678"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.75841771),
        dec: Angle.Degrees(-06.02300641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198093"},
        {"Hipparcos Number", "HIP 102655"},
        {"Smithsonian Astrophysical Observation", "SAO 144821"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.04477298),
        dec: Angle.Degrees(-06.02275870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52719"},
        {"Hipparcos Number", "HIP 33894"},
        {"Smithsonian Astrophysical Observation", "SAO 134083"},
        {"Wilson Evans Batten Catalogue", "WEB 6804"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.53163771),
        dec: Angle.Degrees(-06.02233823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50730"},
        {"Henry Draper 2", "HD 50731"},
        {"Hipparcos Number", "HIP 33168"},
        {"Geneva Identification System", "GEN# +1.00050731"},
        {"Smithsonian Astrophysical Observation", "SAO 133864"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55796577),
        dec: Angle.Degrees(-06.01850475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14281"},
        {"Hipparcos Number", "HIP 10756"},
        {"Smithsonian Astrophysical Observation", "SAO 129811"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.60000116),
        dec: Angle.Degrees(-06.01743088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68287"},
        {"Hipparcos Number", "HIP 40110"},
        {"Geneva Identification System", "GEN# +2.25480366"},
        {"Smithsonian Astrophysical Observation", "SAO 135610"},
        {"New General Catalogue", "NGC 2548 366"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.89039586),
        dec: Angle.Degrees(-06.01593789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117636"},
        {"Hipparcos Number", "HIP 66000"},
        {"Smithsonian Astrophysical Observation", "SAO 139388"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.96750557),
        dec: Angle.Degrees(-06.01467498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224935"},
        {"Hipparcos Number", "HIP 154"},
        {"Fundamental Katalog 5th Edition", "FK5 1630"},
        {"Geneva Identification System", "GEN# +1.00224935"},
        {"Smithsonian Astrophysical Observation", "SAO 147042"},
        {"Wilson Evans Batten Catalogue", "WEB 26"},
    },
    visualMagnitude: 4.37,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.48996506),
        dec: Angle.Degrees(-06.01397169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21055"},
        {"Hipparcos Number", "HIP 15806"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90706814),
        dec: Angle.Degrees(-06.01017206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220660"},
        {"Hipparcos Number", "HIP 115639"},
        {"Smithsonian Astrophysical Observation", "SAO 146699"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.39202451),
        dec: Angle.Degrees(-06.00988831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17037"},
        {"Hipparcos Number", "HIP 12764"},
        {"Geneva Identification System", "GEN# +1.00017037"},
        {"Smithsonian Astrophysical Observation", "SAO 130084"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.00359859),
        dec: Angle.Degrees(-06.00937192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4182 B"},
        {"Henry Draper", "HD 36959"},
        {"Hipparcos Number", "HIP 26197"},
        {"Geneva Identification System", "GEN# +9.00010482"},
        {"Geneva Identification System 2", "GEN# +2.19760482"},
        {"Smithsonian Astrophysical Observation", "SAO 132298"},
        {"Wilson Evans Batten Catalogue", "WEB 5107"},
    },
    visualMagnitude: 5.67,
    bvColour: -0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.75419279),
        dec: Angle.Degrees(-06.00926927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81344"},
        {"Hipparcos Number", "HIP 46163"},
        {"Smithsonian Astrophysical Observation", "SAO 136823"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.21893174),
        dec: Angle.Degrees(-06.00889521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202353"},
        {"Hipparcos Number", "HIP 104939"},
        {"Geneva Identification System", "GEN# +1.00202353"},
        {"Smithsonian Astrophysical Observation", "SAO 145239"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.84939319),
        dec: Angle.Degrees(-06.00825269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221877"},
        {"Hipparcos Number", "HIP 116462"},
        {"Smithsonian Astrophysical Observation", "SAO 146798"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.97730572),
        dec: Angle.Degrees(-06.00814358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26066"},
        {"Hipparcos Number", "HIP 19249"},
        {"Geneva Identification System", "GEN# +1.00026066"},
        {"Smithsonian Astrophysical Observation", "SAO 130963"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.87197809),
        dec: Angle.Degrees(-06.00743101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15970"},
        {"Hipparcos Number", "HIP 11921"},
        {"Smithsonian Astrophysical Observation", "SAO 129975"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.46956326),
        dec: Angle.Degrees(-06.00568213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205632"},
        {"Hipparcos Number", "HIP 106702"},
        {"Geneva Identification System", "GEN# +1.00205632"},
        {"Smithsonian Astrophysical Observation", "SAO 145525"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.19865422),
        dec: Angle.Degrees(-06.00481358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11695 A"},
        {"Henry Draper", "HD 174005"},
        {"Hipparcos Number", "HIP 92296"},
        {"Geneva Identification System", "GEN# +1.00174005A"},
        {"Renson", "Renson 48736"},
        {"Smithsonian Astrophysical Observation", "SAO 142640"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.16453153),
        dec: Angle.Degrees(-06.00438915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137831"},
        {"Hipparcos Number", "HIP 75739"},
        {"Smithsonian Astrophysical Observation", "SAO 140555"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.09602618),
        dec: Angle.Degrees(-06.00295744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119705"},
        {"Hipparcos Number", "HIP 67083"},
        {"Smithsonian Astrophysical Observation", "SAO 139528"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.23758144),
        dec: Angle.Degrees(-06.00228045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82142"},
        {"Hipparcos Number", "HIP 46602"},
        {"Smithsonian Astrophysical Observation", "SAO 136908"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.54130201),
        dec: Angle.Degrees(-06.00221469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12195"},
        {"Smithsonian Astrophysical Observation", "SAO 130018"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.26679119),
        dec: Angle.Degrees(-06.00214130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26199",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4182 A"},
        {"Henry Draper", "HD 36960"},
        {"Hipparcos Number", "HIP 26199"},
        {"Celescope Catalog", "CEL 819"},
        {"Geneva Identification System", "GEN# +9.00010493"},
        {"Geneva Identification System 2", "GEN# +2.19760493"},
        {"Renson", "Renson 9780"},
        {"Smithsonian Astrophysical Observation", "SAO 132301"},
        {"Wilson Evans Batten Catalogue", "WEB 5108"},
    },
    visualMagnitude: 4.78,
    bvColour: -0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.76117163),
        dec: Angle.Degrees(-06.00202867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204105"},
        {"Hipparcos Number", "HIP 105877"},
        {"Geneva Identification System", "GEN# +1.00204105"},
        {"Smithsonian Astrophysical Observation", "SAO 145399"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.64777680),
        dec: Angle.Degrees(-06.00131278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5020"},
        {"Hipparcos Number", "HIP 4068"},
        {"Smithsonian Astrophysical Observation", "SAO 129000"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.04798615),
        dec: Angle.Degrees(-06.00090941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69701",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Syrma"},
        {"Henry Draper", "HD 124850"},
        {"Hipparcos Number", "HIP 69701"},
        {"Cincinnati Publication", "Ci 20 842"},
        {"Fundamental Katalog 5th Edition", "FK5 525"},
        {"Geneva Identification System", "GEN# +1.00124850"},
        {"Smithsonian Astrophysical Observation", "SAO 139824"},
        {"Wilson Evans Batten Catalogue", "WEB 12135"},
    },
    visualMagnitude: 4.07,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.00368717),
        dec: Angle.Degrees(-05.99952622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -419.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197058"},
        {"Hipparcos Number", "HIP 102095"},
        {"Smithsonian Astrophysical Observation", "SAO 144702"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.35225358),
        dec: Angle.Degrees(-05.99795531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3505"},
        {"Hipparcos Number", "HIP 2980"},
        {"Smithsonian Astrophysical Observation", "SAO 128867"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48695803),
        dec: Angle.Degrees(-05.99795363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114147"},
        {"Hipparcos Number", "HIP 64147"},
        {"Geneva Identification System", "GEN# +1.00114147"},
        {"Smithsonian Astrophysical Observation", "SAO 139178"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.20549951),
        dec: Angle.Degrees(-05.99564978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79924"},
        {"Smithsonian Astrophysical Observation", "SAO 141090"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.70191934),
        dec: Angle.Degrees(-05.99411124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27803"},
        {"Geneva Identification System", "GEN# -0.00601339"},
        {"Wilson Evans Batten Catalogue", "WEB 5448"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.25118913),
        dec: Angle.Degrees(-05.99400202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -346.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223782"},
        {"Hipparcos Number", "HIP 117736"},
        {"Cincinnati Publication", "Ci 20 1460"},
        {"Geneva Identification System", "GEN# +1.00223782"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.16872110),
        dec: Angle.Degrees(-05.99364120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 431.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4593"},
        {"Hipparcos Number", "HIP 3727"},
        {"Smithsonian Astrophysical Observation", "SAO 128959"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.96680011),
        dec: Angle.Degrees(-05.99268163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80464"},
        {"Hipparcos Number", "HIP 45755"},
        {"Smithsonian Astrophysical Observation", "SAO 136761"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.95104424),
        dec: Angle.Degrees(-05.99179105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172105"},
        {"Hipparcos Number", "HIP 91415"},
        {"Smithsonian Astrophysical Observation", "SAO 142463"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.65886034),
        dec: Angle.Degrees(-05.99025746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216503"},
        {"Hipparcos Number", "HIP 113028"},
        {"Renson", "Renson 59800"},
        {"Smithsonian Astrophysical Observation", "SAO 146371"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.36497124),
        dec: Angle.Degrees(-05.98792845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222582"},
        {"Hipparcos Number", "HIP 116906"},
        {"Geneva Identification System", "GEN# +1.00222582"},
        {"Smithsonian Astrophysical Observation", "SAO 146849"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.46506334),
        dec: Angle.Degrees(-05.98548732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127119"},
        {"Hipparcos Number", "HIP 70879"},
        {"Smithsonian Astrophysical Observation", "SAO 139967"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.42648108),
        dec: Angle.Degrees(-05.98298486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57749"},
        {"Hipparcos Number", "HIP 35749"},
        {"Geneva Identification System", "GEN# +1.00057749"},
        {"Smithsonian Astrophysical Observation", "SAO 134588"},
        {"Wilson Evans Batten Catalogue", "WEB 7122"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.60582057),
        dec: Angle.Degrees(-05.98280807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222112"},
        {"Hipparcos Number", "HIP 116608"},
        {"Smithsonian Astrophysical Observation", "SAO 146811"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.47029150),
        dec: Angle.Degrees(-05.97823211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224266"},
        {"Hipparcos Number", "HIP 118026"},
        {"Smithsonian Astrophysical Observation", "SAO 146986"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.11276510),
        dec: Angle.Degrees(-05.97801864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59513"},
        {"Geneva Identification System", "GEN# -0.00503449"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.08244522),
        dec: Angle.Degrees(-05.97459856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123982"},
        {"Hipparcos Number", "HIP 69282"},
        {"Geneva Identification System", "GEN# +1.00123982"},
        {"Smithsonian Astrophysical Observation", "SAO 139773"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.73784380),
        dec: Angle.Degrees(-05.97391300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2470 AB"},
        {"Hipparcos Number", "HIP 15480"},
        {"Smithsonian Astrophysical Observation", "SAO 130420"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89610514),
        dec: Angle.Degrees(-05.97230174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125183"},
        {"Hipparcos Number", "HIP 69875"},
        {"Smithsonian Astrophysical Observation", "SAO 139853"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.48782031),
        dec: Angle.Degrees(-05.97149520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184809"},
        {"Hipparcos Number", "HIP 96439"},
        {"Smithsonian Astrophysical Observation", "SAO 143592"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.10750962),
        dec: Angle.Degrees(-05.96992579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75736"},
        {"Hipparcos Number", "HIP 43498"},
        {"Smithsonian Astrophysical Observation", "SAO 136343"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.89660722),
        dec: Angle.Degrees(-05.96985575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129431B"},
        {"Hipparcos Number", "HIP 71928"},
        {"Smithsonian Astrophysical Observation", "SAO 140088"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.67211916),
        dec: Angle.Degrees(-05.96921810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217591"},
        {"Hipparcos Number", "HIP 113723"},
        {"Smithsonian Astrophysical Observation", "SAO 146457"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.47616887),
        dec: Angle.Degrees(-05.96620894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129431"},
        {"Hipparcos Number", "HIP 71926"},
        {"Smithsonian Astrophysical Observation", "SAO 140087"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.66668568),
        dec: Angle.Degrees(-05.96447027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201781"},
        {"Hipparcos Number", "HIP 104658"},
        {"Geneva Identification System", "GEN# +1.00201781"},
        {"Smithsonian Astrophysical Observation", "SAO 145192"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99503131),
        dec: Angle.Degrees(-05.96375129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202221"},
        {"Hipparcos Number", "HIP 104869"},
        {"Geneva Identification System", "GEN# +1.00202221"},
        {"Smithsonian Astrophysical Observation", "SAO 145227"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.64778709),
        dec: Angle.Degrees(-05.96327665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78611"},
        {"Hipparcos Number", "HIP 44922"},
        {"Fundamental Katalog 5th Edition", "FK5 4814"},
        {"Renson", "Renson 22280"},
        {"Smithsonian Astrophysical Observation", "SAO 136611"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.26649895),
        dec: Angle.Degrees(-05.96133845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218769"},
        {"Hipparcos Number", "HIP 114445"},
        {"Geneva Identification System", "GEN# +1.00218769"},
        {"Smithsonian Astrophysical Observation", "SAO 146543"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.66506587),
        dec: Angle.Degrees(-05.96027730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117231"},
        {"Hipparcos Number", "HIP 65772"},
        {"Smithsonian Astrophysical Observation", "SAO 139358"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.26163925),
        dec: Angle.Degrees(-05.95551087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197436"},
        {"Hipparcos Number", "HIP 102322"},
        {"Smithsonian Astrophysical Observation", "SAO 144742"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.97416983),
        dec: Angle.Degrees(-05.95407424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135282"},
        {"Hipparcos Number", "HIP 74594"},
        {"Geneva Identification System", "GEN# +1.00135282"},
        {"Smithsonian Astrophysical Observation", "SAO 140402"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61800627),
        dec: Angle.Degrees(-05.94963966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124553"},
        {"Hipparcos Number", "HIP 69564"},
        {"Geneva Identification System", "GEN# +1.00124553"},
        {"Smithsonian Astrophysical Observation", "SAO 139806"},
        {"Wilson Evans Batten Catalogue", "WEB 12114"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58953291),
        dec: Angle.Degrees(-05.94792042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -306.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73536"},
        {"Hipparcos Number", "HIP 42408"},
        {"Geneva Identification System", "GEN# +1.00073536"},
        {"Smithsonian Astrophysical Observation", "SAO 136125"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.70582633),
        dec: Angle.Degrees(-05.94789394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -338.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8627"},
        {"Hipparcos Number", "HIP 6624"},
        {"Geneva Identification System", "GEN# +1.00008627J"},
        {"Smithsonian Astrophysical Observation", "SAO 129283"},
        {"Wilson Evans Batten Catalogue", "WEB 1449"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.25240598),
        dec: Angle.Degrees(-05.94640949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73488"},
        {"Smithsonian Astrophysical Observation", "SAO 140273"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.28708179),
        dec: Angle.Degrees(-05.94608964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48809"},
        {"Hipparcos Number", "HIP 32338"},
        {"Smithsonian Astrophysical Observation", "SAO 133636"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.24901003),
        dec: Angle.Degrees(-05.94267853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59929"},
        {"Hipparcos Number", "HIP 36629"},
        {"Smithsonian Astrophysical Observation", "SAO 134797"},
        {"Wilson Evans Batten Catalogue", "WEB 7282"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.99243757),
        dec: Angle.Degrees(-05.94264599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17266"},
        {"Geneva Identification System", "GEN# -0.00600727"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47163623),
        dec: Angle.Degrees(-05.93990897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 209.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77589"},
        {"Hipparcos Number", "HIP 44454"},
        {"Smithsonian Astrophysical Observation", "SAO 136535"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.84722260),
        dec: Angle.Degrees(-05.93887411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212946"},
        {"Hipparcos Number", "HIP 110891"},
        {"Geneva Identification System", "GEN# +1.00212946"},
        {"Smithsonian Astrophysical Observation", "SAO 146105"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.99840217),
        dec: Angle.Degrees(-05.93865907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37303"},
        {"Hipparcos Number", "HIP 26427"},
        {"Celescope Catalog", "CEL 867"},
        {"Geneva Identification System", "GEN# +9.00011098"},
        {"Geneva Identification System 2", "GEN# +2.19761098"},
        {"Smithsonian Astrophysical Observation", "SAO 132375"},
        {"Wilson Evans Batten Catalogue", "WEB 5211"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.36398372),
        dec: Angle.Degrees(-05.93838575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98428"},
        {"Hipparcos Number", "HIP 55285"},
        {"Smithsonian Astrophysical Observation", "SAO 138128"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.83980737),
        dec: Angle.Degrees(-05.93770182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106579"},
        {"Hipparcos Number", "HIP 59787"},
        {"Smithsonian Astrophysical Observation", "SAO 138677"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.88945614),
        dec: Angle.Degrees(-05.93485537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198656"},
        {"Hipparcos Number", "HIP 102995"},
        {"Geneva Identification System", "GEN# +1.00198656"},
        {"Smithsonian Astrophysical Observation", "SAO 144886"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.00611375),
        dec: Angle.Degrees(-05.93301640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159525"},
        {"Hipparcos Number", "HIP 86078"},
        {"Smithsonian Astrophysical Observation", "SAO 141746"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.87526771),
        dec: Angle.Degrees(-05.93154940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116914"},
        {"Hipparcos Number", "HIP 65590"},
        {"Smithsonian Astrophysical Observation", "SAO 139342"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.72301068),
        dec: Angle.Degrees(-05.93068059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161131"},
        {"Hipparcos Number", "HIP 86786"},
        {"Smithsonian Astrophysical Observation", "SAO 141836"},
        {"Wilson Evans Batten Catalogue", "WEB 14634"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.00342896),
        dec: Angle.Degrees(-05.92954985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8381"},
    },
    visualMagnitude: 12.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.01533649),
        dec: Angle.Degrees(-05.92921214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87559",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10861 A"},
        {"Henry Draper", "HD 162834"},
        {"Hipparcos Number", "HIP 87559"},
        {"Geneva Identification System", "GEN# +1.00162834"},
        {"Smithsonian Astrophysical Observation", "SAO 141942"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.31405480),
        dec: Angle.Degrees(-05.92882003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91716"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54395341),
        dec: Angle.Degrees(-05.92731458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105901"},
        {"Hipparcos Number", "HIP 59417"},
        {"Geneva Identification System", "GEN# +1.00105901"},
        {"Smithsonian Astrophysical Observation", "SAO 138636"},
        {"Wilson Evans Batten Catalogue", "WEB 10564"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.82509672),
        dec: Angle.Degrees(-05.92582266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22655"},
        {"Hipparcos Number", "HIP 16988"},
        {"Smithsonian Astrophysical Observation", "SAO 130626"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.62037134),
        dec: Angle.Degrees(-05.92147114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48631"},
        {"Smithsonian Astrophysical Observation", "SAO 137223"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.75064438),
        dec: Angle.Degrees(-05.92080411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10583 AB"},
        {"Henry Draper", "HD 158463"},
        {"Hipparcos Number", "HIP 85622"},
        {"Geneva Identification System", "GEN# +1.00158463"},
        {"Smithsonian Astrophysical Observation", "SAO 141691"},
        {"Wilson Evans Batten Catalogue", "WEB 14450"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.44736311),
        dec: Angle.Degrees(-05.91932263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15203",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2440 AB"},
        {"Henry Draper", "HD 20319"},
        {"Hipparcos Number", "HIP 15203"},
        {"Geneva Identification System", "GEN# +1.00020319"},
        {"Smithsonian Astrophysical Observation", "SAO 130388"},
        {"Wilson Evans Batten Catalogue", "WEB 2930"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.00353799),
        dec: Angle.Degrees(-05.91869682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156826"},
        {"Hipparcos Number", "HIP 84801"},
        {"Geneva Identification System", "GEN# +1.00156826"},
        {"Smithsonian Astrophysical Observation", "SAO 141611"},
        {"Wilson Evans Batten Catalogue", "WEB 14316"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.99803077),
        dec: Angle.Degrees(-05.91703822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207235"},
        {"Hipparcos Number", "HIP 107596"},
        {"Geneva Identification System", "GEN# +1.00207235"},
        {"Smithsonian Astrophysical Observation", "SAO 145671"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.90916827),
        dec: Angle.Degrees(-05.91684000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20515"},
        {"Hipparcos Number", "HIP 15344"},
        {"Geneva Identification System", "GEN# +1.00020515"},
        {"Smithsonian Astrophysical Observation", "SAO 130404"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.46589711),
        dec: Angle.Degrees(-05.91659439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82870"},
        {"Hipparcos Number", "HIP 46982"},
        {"Fundamental Katalog 5th Edition", "FK5 2763"},
        {"Geneva Identification System", "GEN# +1.00082870"},
        {"Smithsonian Astrophysical Observation", "SAO 136964"},
        {"Wilson Evans Batten Catalogue", "WEB 8856"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.63600852),
        dec: Angle.Degrees(-05.91480636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92391",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11719 A"},
        {"Henry Draper", "HD 174208"},
        {"Hipparcos Number", "HIP 92391"},
        {"Geneva Identification System", "GEN# +1.00174208A"},
        {"Smithsonian Astrophysical Observation", "SAO 142661"},
        {"Wilson Evans Batten Catalogue", "WEB 15955"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.42064627),
        dec: Angle.Degrees(-05.91283415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171149"},
        {"Hipparcos Number", "HIP 90967"},
        {"Celescope Catalog", "CEL 4631"},
        {"Geneva Identification System", "GEN# +1.00171149"},
        {"Smithsonian Astrophysical Observation", "SAO 142386"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.34464313),
        dec: Angle.Degrees(-05.91164933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202019"},
        {"Hipparcos Number", "HIP 104774"},
        {"Geneva Identification System", "GEN# +1.00202019"},
        {"Smithsonian Astrophysical Observation", "SAO 145215"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.37543810),
        dec: Angle.Degrees(-05.91150617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2567"},
        {"Hipparcos Number", "HIP 2292"},
        {"Geneva Identification System", "GEN# +1.00002567"},
        {"Smithsonian Astrophysical Observation", "SAO 128781"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.31739732),
        dec: Angle.Degrees(-05.90995058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26241",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hatysa"},
        {"Aitken", "ADS 4193 A"},
        {"Henry Draper", "HD 37043"},
        {"Hipparcos Number", "HIP 26241"},
        {"Celescope Catalog", "CEL 829"},
        {"Fundamental Katalog 5th Edition", "FK5 209"},
        {"Geneva Identification System", "GEN# +9.00010721"},
        {"Geneva Identification System 2", "GEN# +9.00010721D"},
        {"Geneva Identification System 3", "GEN# +2.19760721"},
        {"Smithsonian Astrophysical Observation", "SAO 132323"},
        {"Wilson Evans Batten Catalogue", "WEB 5136"},
        {"New General Catalogue", "NGC 1976 721"},
    },
    visualMagnitude: 2.75,
    bvColour: -0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.85825475),
        dec: Angle.Degrees(-05.90989984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99126"},
        {"Hipparcos Number", "HIP 55666"},
        {"Geneva Identification System", "GEN# +1.00099126"},
        {"Smithsonian Astrophysical Observation", "SAO 138184"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.09086074),
        dec: Angle.Degrees(-05.90974645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220035"},
        {"Hipparcos Number", "HIP 115257"},
        {"Geneva Identification System", "GEN# +1.00220035"},
        {"Smithsonian Astrophysical Observation", "SAO 146652"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.17061468),
        dec: Angle.Degrees(-05.90782893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12977"},
        {"Smithsonian Astrophysical Observation", "SAO 130110"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.73010030),
        dec: Angle.Degrees(-05.90722766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212927"},
        {"Hipparcos Number", "HIP 110883"},
        {"Geneva Identification System", "GEN# +1.00212927"},
        {"Smithsonian Astrophysical Observation", "SAO 146101"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.96543650),
        dec: Angle.Degrees(-05.90586454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84881"},
        {"Hipparcos Number", "HIP 48080"},
        {"Smithsonian Astrophysical Observation", "SAO 137140"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.02795261),
        dec: Angle.Degrees(-05.90345661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68879"},
        {"Hipparcos Number", "HIP 40348"},
        {"Geneva Identification System", "GEN# +2.25481560"},
        {"Smithsonian Astrophysical Observation", "SAO 135668"},
        {"New General Catalogue", "NGC 2548 1560"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.57097207),
        dec: Angle.Degrees(-05.90017433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72412"},
        {"Hipparcos Number", "HIP 41896"},
        {"Geneva Identification System", "GEN# +1.00072412"},
        {"Smithsonian Astrophysical Observation", "SAO 136017"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.14708162),
        dec: Angle.Degrees(-05.89948676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63317"},
        {"Hipparcos Number", "HIP 38069"},
        {"Smithsonian Astrophysical Observation", "SAO 135116"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.02077156),
        dec: Angle.Degrees(-05.89924125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
