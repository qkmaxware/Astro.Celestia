using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_74() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13258"},
        {"Hipparcos Number", "HIP 10103"},
        {"Geneva Identification System", "GEN# +1.00013258"},
        {"Smithsonian Astrophysical Observation", "SAO 92815"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.48837483),
        dec: Angle.Degrees(+14.85461524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130217"},
        {"Hipparcos Number", "HIP 72251"},
        {"Smithsonian Astrophysical Observation", "SAO 101204"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.62350655),
        dec: Angle.Degrees(+14.85533090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65427"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.15428527),
        dec: Angle.Degrees(+14.85683663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -321.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73347"},
        {"Hipparcos Number", "HIP 42383"},
        {"Geneva Identification System", "GEN# +1.00073347"},
        {"Smithsonian Astrophysical Observation", "SAO 97992"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.62102056),
        dec: Angle.Degrees(+14.85821967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111764"},
        {"Hipparcos Number", "HIP 62746"},
        {"Smithsonian Astrophysical Observation", "SAO 100302"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.85335020),
        dec: Angle.Degrees(+14.85895445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32576"},
        {"Hipparcos Number", "HIP 23621"},
        {"Renson", "Renson 8290"},
        {"Smithsonian Astrophysical Observation", "SAO 94293"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.17417839),
        dec: Angle.Degrees(+14.85910367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2008"},
        {"Henry Draper", "HD 16480"},
        {"Hipparcos Number", "HIP 12349"},
        {"Geneva Identification System", "GEN# +1.00016480J"},
        {"Wilson Evans Batten Catalogue", "WEB 2532"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.74905092),
        dec: Angle.Degrees(+14.86047246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165849"},
        {"Hipparcos Number", "HIP 88779"},
        {"Smithsonian Astrophysical Observation", "SAO 103399"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.85349549),
        dec: Angle.Degrees(+14.86639410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204726"},
        {"Hipparcos Number", "HIP 106173"},
        {"Fundamental Katalog 5th Edition", "FK5 5899"},
        {"Smithsonian Astrophysical Observation", "SAO 107183"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.58868956),
        dec: Angle.Degrees(+14.86794489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13822 A"},
        {"Henry Draper", "HD 194382"},
        {"Hipparcos Number", "HIP 100690"},
        {"Smithsonian Astrophysical Observation", "SAO 106078"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.20231539),
        dec: Angle.Degrees(+14.86825086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13822 B"},
        {"Hipparcos Number", "HIP 100687"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.19788595),
        dec: Angle.Degrees(+14.86963084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217559"},
        {"Hipparcos Number", "HIP 113671"},
        {"Smithsonian Astrophysical Observation", "SAO 108334"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.33845902),
        dec: Angle.Degrees(+14.87081355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154512"},
        {"Hipparcos Number", "HIP 83617"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34692961),
        dec: Angle.Degrees(+14.87087887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109929"},
        {"Hipparcos Number", "HIP 61662"},
        {"Geneva Identification System", "GEN# +1.00109929"},
        {"Smithsonian Astrophysical Observation", "SAO 100186"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.60628223),
        dec: Angle.Degrees(+14.87243047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172045"},
        {"Hipparcos Number", "HIP 91313"},
        {"Smithsonian Astrophysical Observation", "SAO 103925"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38472634),
        dec: Angle.Degrees(+14.87397186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25966"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.09518552),
        dec: Angle.Degrees(+14.87556898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49965"},
        {"Smithsonian Astrophysical Observation", "SAO 98997"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.01204695),
        dec: Angle.Degrees(+14.87708938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49010"},
        {"Smithsonian Astrophysical Observation", "SAO 98887"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.97487981),
        dec: Angle.Degrees(+14.87760614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38963"},
        {"Hipparcos Number", "HIP 27544"},
        {"Smithsonian Astrophysical Observation", "SAO 94892"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.49203474),
        dec: Angle.Degrees(+14.88018000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11466"},
        {"Hipparcos Number", "HIP 8795"},
        {"Smithsonian Astrophysical Observation", "SAO 92676"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.26715683),
        dec: Angle.Degrees(+14.88069665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156713"},
        {"Hipparcos Number", "HIP 84682"},
        {"Geneva Identification System", "GEN# +1.00156713"},
        {"Smithsonian Astrophysical Observation", "SAO 102728"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.67684645),
        dec: Angle.Degrees(+14.88142521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215717"},
        {"Hipparcos Number", "HIP 112487"},
        {"Smithsonian Astrophysical Observation", "SAO 108171"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.76915797),
        dec: Angle.Degrees(+14.88181488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120553"},
        {"Hipparcos Number", "HIP 67493"},
        {"Geneva Identification System", "GEN# +1.00120553"},
        {"Smithsonian Astrophysical Observation", "SAO 100729"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.46357016),
        dec: Angle.Degrees(+14.88428356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45474"},
        {"Smithsonian Astrophysical Observation", "SAO 98463"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.99845713),
        dec: Angle.Degrees(+14.88452691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152481"},
        {"Hipparcos Number", "HIP 82593"},
        {"Smithsonian Astrophysical Observation", "SAO 102449"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.26549903),
        dec: Angle.Degrees(+14.88551440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47887"},
        {"Smithsonian Astrophysical Observation", "SAO 98748"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.40014688),
        dec: Angle.Degrees(+14.88692369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17232"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.35754766),
        dec: Angle.Degrees(+14.88864289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60849"},
        {"Hipparcos Number", "HIP 37066"},
        {"Smithsonian Astrophysical Observation", "SAO 97082"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.25510981),
        dec: Angle.Degrees(+14.88909522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45314"},
        {"Hipparcos Number", "HIP 30722"},
        {"Celescope Catalog", "CEL 1242"},
        {"Geneva Identification System", "GEN# +1.00045314"},
        {"Smithsonian Astrophysical Observation", "SAO 95697"},
        {"Wilson Evans Batten Catalogue", "WEB 6126"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.81573961),
        dec: Angle.Degrees(+14.88922749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100509"},
        {"Hipparcos Number", "HIP 56427"},
        {"Geneva Identification System", "GEN# +1.00100509"},
        {"Smithsonian Astrophysical Observation", "SAO 99667"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.53425685),
        dec: Angle.Degrees(+14.89154314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118245"},
        {"Hipparcos Number", "HIP 66305"},
        {"Geneva Identification System", "GEN# +1.00118245"},
        {"Smithsonian Astrophysical Observation", "SAO 100629"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.83848688),
        dec: Angle.Degrees(+14.89241497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45838"},
        {"Hipparcos Number", "HIP 30998"},
        {"Smithsonian Astrophysical Observation", "SAO 95758"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.58826678),
        dec: Angle.Degrees(+14.89444163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70165"},
        {"Geneva Identification System", "GEN# +0.01502698"},
        {"Smithsonian Astrophysical Observation", "SAO 100988"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34088701),
        dec: Angle.Degrees(+14.89497353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119850"},
        {"Hipparcos Number", "HIP 67155"},
        {"Cincinnati Publication", "Ci 20 803"},
        {"Geneva Identification System", "GEN# +1.00119850"},
        {"Smithsonian Astrophysical Observation", "SAO 100695"},
        {"Wilson Evans Batten Catalogue", "WEB 11822"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.42792982),
        dec: Angle.Degrees(+14.89505746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1778.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1455.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212501"},
        {"Hipparcos Number", "HIP 110606"},
        {"Smithsonian Astrophysical Observation", "SAO 107889"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.11836979),
        dec: Angle.Degrees(+14.89537928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69874"},
        {"Geneva Identification System", "GEN# +0.01502691"},
        {"Smithsonian Astrophysical Observation", "SAO 100963"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.48424201),
        dec: Angle.Degrees(+14.89564797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15137"},
        {"Geneva Identification System", "GEN# +7.00710001"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.78394588),
        dec: Angle.Degrees(+14.89661370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212074"},
        {"Hipparcos Number", "HIP 110382"},
        {"Geneva Identification System", "GEN# +1.00212074"},
        {"Smithsonian Astrophysical Observation", "SAO 107852"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.36651923),
        dec: Angle.Degrees(+14.89705622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91396"},
        {"Hipparcos Number", "HIP 51682"},
        {"Smithsonian Astrophysical Observation", "SAO 99183"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.37733689),
        dec: Angle.Degrees(+14.89738127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67758"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.21941338),
        dec: Angle.Degrees(+14.89808468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112791"},
        {"Hipparcos Number", "HIP 63378"},
        {"Smithsonian Astrophysical Observation", "SAO 100358"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.79290955),
        dec: Angle.Degrees(+14.89876375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106661"},
        {"Hipparcos Number", "HIP 59819"},
        {"Fundamental Katalog 5th Edition", "FK5 2981"},
        {"Geneva Identification System", "GEN# +1.00106661"},
        {"Renson", "Renson 30870"},
        {"Smithsonian Astrophysical Observation", "SAO 100012"},
        {"Wilson Evans Batten Catalogue", "WEB 10627"},
    },
    visualMagnitude: 5.09,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.00097886),
        dec: Angle.Degrees(+14.89914477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35587"},
        {"Smithsonian Astrophysical Observation", "SAO 96795"},
        {"Wilson Evans Batten Catalogue", "WEB 7090"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.15782001),
        dec: Angle.Degrees(+14.89945154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90385"},
        {"Hipparcos Number", "HIP 51080"},
        {"Geneva Identification System", "GEN# +1.00090385"},
        {"Smithsonian Astrophysical Observation", "SAO 99117"},
        {"Wilson Evans Batten Catalogue", "WEB 9337"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.54776790),
        dec: Angle.Degrees(+14.90016876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9325 B"},
        {"Hipparcos Number", "HIP 71532"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.45793689),
        dec: Angle.Degrees(+14.90037172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9325 A"},
        {"Hipparcos Number", "HIP 71531"},
        {"Smithsonian Astrophysical Observation", "SAO 101116"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.45448395),
        dec: Angle.Degrees(+14.90272581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189578"},
        {"Hipparcos Number", "HIP 98452"},
        {"Geneva Identification System", "GEN# +1.00189578"},
        {"Smithsonian Astrophysical Observation", "SAO 105524"},
        {"Wilson Evans Batten Catalogue", "WEB 17380"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05327522),
        dec: Angle.Degrees(+14.90292143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169359"},
        {"Hipparcos Number", "HIP 90144"},
        {"Geneva Identification System", "GEN# +1.00169359"},
        {"Smithsonian Astrophysical Observation", "SAO 103670"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.94577691),
        dec: Angle.Degrees(+14.90788008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14335"},
        {"Hipparcos Number", "HIP 10827"},
        {"Smithsonian Astrophysical Observation", "SAO 92886"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.83994070),
        dec: Angle.Degrees(+14.90888283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32308"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.17903665),
        dec: Angle.Degrees(+14.91038844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111012"},
        {"Fundamental Katalog 5th Edition", "FK5 5984"},
        {"Smithsonian Astrophysical Observation", "SAO 107949"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.35022387),
        dec: Angle.Degrees(+14.91055200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156144"},
        {"Hipparcos Number", "HIP 84412"},
        {"Geneva Identification System", "GEN# +1.00156144"},
        {"Smithsonian Astrophysical Observation", "SAO 102692"},
        {"Wilson Evans Batten Catalogue", "WEB 14250"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.85707538),
        dec: Angle.Degrees(+14.91139906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55685"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.14891794),
        dec: Angle.Degrees(+14.91373170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64189"},
        {"Hipparcos Number", "HIP 38524"},
        {"Geneva Identification System", "GEN# +1.00064189"},
        {"Smithsonian Astrophysical Observation", "SAO 97335"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.33338484),
        dec: Angle.Degrees(+14.91732936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107401"},
        {"Smithsonian Astrophysical Observation", "SAO 107372"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.30691219),
        dec: Angle.Degrees(+14.92037308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155421"},
        {"Hipparcos Number", "HIP 84048"},
        {"Fundamental Katalog 5th Edition", "FK5 5515"},
        {"Smithsonian Astrophysical Observation", "SAO 102635"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.73838092),
        dec: Angle.Degrees(+14.92066563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182239"},
        {"Hipparcos Number", "HIP 95287"},
        {"Geneva Identification System", "GEN# +1.00182239"},
        {"Smithsonian Astrophysical Observation", "SAO 104779"},
        {"Wilson Evans Batten Catalogue", "WEB 16649"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.78431835),
        dec: Angle.Degrees(+14.92102959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33467"},
        {"Hipparcos Number", "HIP 24132"},
        {"Geneva Identification System", "GEN# +1.00033467"},
        {"Smithsonian Astrophysical Observation", "SAO 94373"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74586346),
        dec: Angle.Degrees(+14.92181257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17281"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50686859),
        dec: Angle.Degrees(+14.92217878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139268"},
        {"Hipparcos Number", "HIP 76438"},
        {"Fundamental Katalog 5th Edition", "FK5 5379"},
        {"Geneva Identification System", "GEN# +1.00139268"},
        {"Smithsonian Astrophysical Observation", "SAO 101648"},
        {"Wilson Evans Batten Catalogue", "WEB 12979"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.17745428),
        dec: Angle.Degrees(+14.92484203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89239"},
        {"Geneva Identification System", "GEN# +6.20058071"},
        {"Wilson Evans Batten Catalogue", "WEB 15170"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.16189275),
        dec: Angle.Degrees(+14.92652958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9676"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.11725240),
        dec: Angle.Degrees(+14.92781574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81563"},
        {"Hipparcos Number", "HIP 46339"},
        {"Geneva Identification System", "GEN# +1.00081563"},
        {"Smithsonian Astrophysical Observation", "SAO 98572"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.70579626),
        dec: Angle.Degrees(+14.92820865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36337"},
        {"Hipparcos Number", "HIP 25886"},
        {"Geneva Identification System", "GEN# +1.00036337"},
        {"Smithsonian Astrophysical Observation", "SAO 94618"},
        {"Wilson Evans Batten Catalogue", "WEB 5029"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.89885747),
        dec: Angle.Degrees(+14.92891664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353500"},
        {"Hipparcos Number", "HIP 97085"},
        {"Smithsonian Astrophysical Observation", "SAO 105192"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.95355316),
        dec: Angle.Degrees(+14.93012557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26515"},
        {"Hipparcos Number", "HIP 19617"},
        {"Geneva Identification System", "GEN# +1.00026515"},
        {"Smithsonian Astrophysical Observation", "SAO 93808"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.05347341),
        dec: Angle.Degrees(+14.93261694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125504"},
        {"Hipparcos Number", "HIP 70000"},
        {"Geneva Identification System", "GEN# +1.00125504"},
        {"Smithsonian Astrophysical Observation", "SAO 100976"},
        {"Wilson Evans Batten Catalogue", "WEB 12174"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.85975459),
        dec: Angle.Degrees(+14.93570946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126031"},
        {"Hipparcos Number", "HIP 70287"},
        {"Geneva Identification System", "GEN# +1.00126031"},
        {"Renson", "Renson 35946"},
        {"Smithsonian Astrophysical Observation", "SAO 100997"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.70713405),
        dec: Angle.Degrees(+14.93894010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93591"},
        {"Geneva Identification System", "GEN# +0.01403763"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.90548513),
        dec: Angle.Degrees(+14.94015199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79554"},
        {"Hipparcos Number", "HIP 45410"},
        {"Fundamental Katalog 5th Edition", "FK5 2733"},
        {"Geneva Identification System", "GEN# +1.00079554"},
        {"Smithsonian Astrophysical Observation", "SAO 98456"},
        {"Wilson Evans Batten Catalogue", "WEB 8640"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.80781962),
        dec: Angle.Degrees(+14.94153670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152276"},
        {"Hipparcos Number", "HIP 82516"},
        {"Smithsonian Astrophysical Observation", "SAO 102434"},
        {"Wilson Evans Batten Catalogue", "WEB 13933"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.97463270),
        dec: Angle.Degrees(+14.94185779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179785"},
        {"Hipparcos Number", "HIP 94445"},
        {"Geneva Identification System", "GEN# +1.00179785"},
        {"Smithsonian Astrophysical Observation", "SAO 104618"},
        {"Wilson Evans Batten Catalogue", "WEB 16458"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.32398357),
        dec: Angle.Degrees(+14.94269234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194597"},
        {"Hipparcos Number", "HIP 100776"},
        {"Smithsonian Astrophysical Observation", "SAO 106096"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.49757786),
        dec: Angle.Degrees(+14.94305818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242881"},
        {"Hipparcos Number", "HIP 25013"},
        {"Smithsonian Astrophysical Observation", "SAO 94486"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.34001004),
        dec: Angle.Degrees(+14.94341756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194935"},
        {"Hipparcos Number", "HIP 100929"},
        {"Smithsonian Astrophysical Observation", "SAO 106132"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.95816828),
        dec: Angle.Degrees(+14.94450319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188017"},
        {"Hipparcos Number", "HIP 97808"},
        {"Renson", "Renson 51890"},
        {"Smithsonian Astrophysical Observation", "SAO 105362"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.13429721),
        dec: Angle.Degrees(+14.94587090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 889 A"},
        {"Henry Draper", "HD 6397"},
        {"Hipparcos Number", "HIP 5081"},
        {"Fundamental Katalog 5th Edition", "FK5 1028"},
        {"Geneva Identification System", "GEN# +1.00006397"},
        {"Renson", "Renson 1637"},
        {"Smithsonian Astrophysical Observation", "SAO 92230"},
        {"Wilson Evans Batten Catalogue", "WEB 1045"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.27229777),
        dec: Angle.Degrees(+14.94600386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75797"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.27135344),
        dec: Angle.Degrees(+14.94723346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66116"},
        {"Hipparcos Number", "HIP 39358"},
        {"Geneva Identification System", "GEN# +1.00066116"},
        {"Smithsonian Astrophysical Observation", "SAO 97503"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.67786895),
        dec: Angle.Degrees(+14.94931997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10310 A"},
        {"Henry Draper", "HD 153882"},
        {"Hipparcos Number", "HIP 83308"},
        {"Geneva Identification System", "GEN# +1.00153882A"},
        {"Renson", "Renson 43450"},
        {"Smithsonian Astrophysical Observation", "SAO 102536"},
        {"Wilson Evans Batten Catalogue", "WEB 14078"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.38769941),
        dec: Angle.Degrees(+14.94971947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104815"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.52429519),
        dec: Angle.Degrees(+14.94983241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3847"},
        {"Hipparcos Number", "HIP 3242"},
        {"Smithsonian Astrophysical Observation", "SAO 92026"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.31326960),
        dec: Angle.Degrees(+14.95174194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40631"},
        {"Hipparcos Number", "HIP 28473"},
        {"Smithsonian Astrophysical Observation", "SAO 95110"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.17157511),
        dec: Angle.Degrees(+14.95698451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84983"},
        {"Hipparcos Number", "HIP 48177"},
        {"Smithsonian Astrophysical Observation", "SAO 98785"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.30302437),
        dec: Angle.Degrees(+14.95750527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134151"},
        {"Hipparcos Number", "HIP 74042"},
        {"Geneva Identification System", "GEN# +1.00134151"},
        {"Smithsonian Astrophysical Observation", "SAO 101388"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98079248),
        dec: Angle.Degrees(+14.95768002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117001"},
        {"Smithsonian Astrophysical Observation", "SAO 108787"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.78854538),
        dec: Angle.Degrees(+14.95802699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218155"},
        {"Hipparcos Number", "HIP 114031"},
        {"Geneva Identification System", "GEN# +1.00218155"},
        {"Smithsonian Astrophysical Observation", "SAO 108392"},
        {"Wilson Evans Batten Catalogue", "WEB 20251"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.38763469),
        dec: Angle.Degrees(+14.95908303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155093"},
        {"Hipparcos Number", "HIP 83918"},
        {"Geneva Identification System", "GEN# +1.00155093"},
        {"Smithsonian Astrophysical Observation", "SAO 102615"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.25827521),
        dec: Angle.Degrees(+14.96111445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57249"},
        {"Smithsonian Astrophysical Observation", "SAO 99764"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.08332490),
        dec: Angle.Degrees(+14.96179527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92410"},
        {"Hipparcos Number", "HIP 52242"},
        {"Smithsonian Astrophysical Observation", "SAO 99243"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.10525188),
        dec: Angle.Degrees(+14.96348461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225241"},
        {"Hipparcos Number", "HIP 378"},
        {"Geneva Identification System", "GEN# +1.00225241"},
        {"Smithsonian Astrophysical Observation", "SAO 91690"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.17191906),
        dec: Angle.Degrees(+14.96533616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115244"},
        {"Hipparcos Number", "HIP 64710"},
        {"Geneva Identification System", "GEN# +1.00115244"},
        {"Smithsonian Astrophysical Observation", "SAO 100483"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.94337732),
        dec: Angle.Degrees(+14.96554209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64961"},
        {"Hipparcos Number", "HIP 38837"},
        {"Smithsonian Astrophysical Observation", "SAO 97397"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.21965706),
        dec: Angle.Degrees(+14.96617900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178892"},
        {"Hipparcos Number", "HIP 94155"},
        {"Renson", "Renson 49740"},
        {"Smithsonian Astrophysical Observation", "SAO 104546"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.47813687),
        dec: Angle.Degrees(+14.96626362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169820"},
        {"Hipparcos Number", "HIP 90337"},
        {"Geneva Identification System", "GEN# +1.00169820"},
        {"Renson", "Renson 47530"},
        {"Smithsonian Astrophysical Observation", "SAO 103709"},
        {"Wilson Evans Batten Catalogue", "WEB 15463"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.48014319),
        dec: Angle.Degrees(+14.96628017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184040"},
        {"Hipparcos Number", "HIP 96057"},
        {"Smithsonian Astrophysical Observation", "SAO 104939"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.97351549),
        dec: Angle.Degrees(+14.96897775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116167"},
        {"Smithsonian Astrophysical Observation", "SAO 108667"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.06121529),
        dec: Angle.Degrees(+14.96910938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90075",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11300 AB"},
        {"Aitken 2", "ADS 11300"},
        {"Hipparcos Number", "HIP 90075"},
        {"Smithsonian Astrophysical Observation", "SAO 103656"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.72848178),
        dec: Angle.Degrees(+14.96971725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21100"},
        {"Hipparcos Number", "HIP 15894"},
        {"Smithsonian Astrophysical Observation", "SAO 93420"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.18599000),
        dec: Angle.Degrees(+14.97384564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152308"},
        {"Hipparcos Number", "HIP 82526"},
        {"Fundamental Katalog 5th Edition", "FK5 629"},
        {"Geneva Identification System", "GEN# +1.00152308"},
        {"Renson", "Renson 43110"},
        {"Smithsonian Astrophysical Observation", "SAO 102435"},
        {"Wilson Evans Batten Catalogue", "WEB 13936"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.02016927),
        dec: Angle.Degrees(+14.97420124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98790",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13310 B"},
        {"Hipparcos Number", "HIP 98790"},
    },
    visualMagnitude: 11.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)03, 49.9700),
        dec: Angle.DegreesMinutesSeconds((int)+14, (int)58, 30.500)
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
    primaryId: "HIP 30417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256418"},
        {"Hipparcos Number", "HIP 30417"},
        {"Smithsonian Astrophysical Observation", "SAO 95622"},
        {"Wilson Evans Batten Catalogue", "WEB 6054"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.93808817),
        dec: Angle.Degrees(+14.97526160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122676"},
        {"Hipparcos Number", "HIP 68634"},
        {"Geneva Identification System", "GEN# +1.00122676"},
        {"Smithsonian Astrophysical Observation", "SAO 100829"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.73708244),
        dec: Angle.Degrees(+14.97533537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2787 AB"},
        {"Henry Draper", "HD 23865"},
        {"Hipparcos Number", "HIP 17836"},
        {"Smithsonian Astrophysical Observation", "SAO 93617"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.24198103),
        dec: Angle.Degrees(+14.97570640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89774"},
        {"Hipparcos Number", "HIP 50755"},
        {"Geneva Identification System", "GEN# +1.00089774"},
        {"Smithsonian Astrophysical Observation", "SAO 99080"},
        {"Wilson Evans Batten Catalogue", "WEB 9292"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.45967734),
        dec: Angle.Degrees(+14.97580063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131747"},
        {"Hipparcos Number", "HIP 72993"},
        {"Smithsonian Astrophysical Observation", "SAO 101282"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.75437248),
        dec: Angle.Degrees(+14.97932713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18752"},
        {"Hipparcos Number", "HIP 14069"},
        {"Geneva Identification System", "GEN# +1.00018752"},
        {"Smithsonian Astrophysical Observation", "SAO 93238"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.32199378),
        dec: Angle.Degrees(+14.98236712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13310 A"},
        {"Henry Draper", "HD 190323"},
        {"Hipparcos Number", "HIP 98788"},
        {"Geneva Identification System", "GEN# +1.00190323"},
        {"Smithsonian Astrophysical Observation", "SAO 105624"},
        {"Wilson Evans Batten Catalogue", "WEB 17503"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.95673265),
        dec: Angle.Degrees(+14.98299611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124626"},
        {"Hipparcos Number", "HIP 69559"},
        {"Smithsonian Astrophysical Observation", "SAO 100927"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58225355),
        dec: Angle.Degrees(+14.98466188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214435"},
        {"Hipparcos Number", "HIP 111723"},
        {"Geneva Identification System", "GEN# +1.00214435"},
        {"Smithsonian Astrophysical Observation", "SAO 108052"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.46798601),
        dec: Angle.Degrees(+14.98685323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170423"},
        {"Hipparcos Number", "HIP 90571"},
        {"Smithsonian Astrophysical Observation", "SAO 103761"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.21961359),
        dec: Angle.Degrees(+14.98954809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70421"},
        {"Hipparcos Number", "HIP 41028"},
        {"Geneva Identification System", "GEN# +1.00070421"},
        {"Smithsonian Astrophysical Observation", "SAO 97768"},
        {"Wilson Evans Batten Catalogue", "WEB 7950"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.60540532),
        dec: Angle.Degrees(+14.99225876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215676"},
        {"Hipparcos Number", "HIP 112451"},
        {"Smithsonian Astrophysical Observation", "SAO 108166"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.68686159),
        dec: Angle.Degrees(+14.99504972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79096"},
        {"Hipparcos Number", "HIP 45170"},
        {"Cincinnati Publication", "Ci 20 514"},
        {"Geneva Identification System", "GEN# +1.00079096"},
        {"Smithsonian Astrophysical Observation", "SAO 98427"},
        {"Wilson Evans Batten Catalogue", "WEB 8616"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.07443958),
        dec: Angle.Degrees(+14.99544127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -524.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 245.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21541"},
        {"Hipparcos Number", "HIP 16221"},
        {"Geneva Identification System", "GEN# +1.00021541"},
        {"Smithsonian Astrophysical Observation", "SAO 93449"},
        {"Wilson Evans Batten Catalogue", "WEB 3091"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.24374691),
        dec: Angle.Degrees(+14.99683271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169169"},
        {"Hipparcos Number", "HIP 90070"},
        {"Geneva Identification System", "GEN# +1.00169169"},
        {"Smithsonian Astrophysical Observation", "SAO 103654"},
        {"Wilson Evans Batten Catalogue", "WEB 15394"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.70664357),
        dec: Angle.Degrees(+15.00185703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8302 AB"},
        {"Henry Draper", "HD 102343"},
        {"Hipparcos Number", "HIP 57470"},
        {"Geneva Identification System", "GEN# +1.00102343J"},
        {"Renson", "Renson 29510"},
        {"Smithsonian Astrophysical Observation", "SAO 99787"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.71119052),
        dec: Angle.Degrees(+15.00192228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164924"},
        {"Hipparcos Number", "HIP 88394"},
        {"Smithsonian Astrophysical Observation", "SAO 103329"},
        {"Wilson Evans Batten Catalogue", "WEB 14944"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.75158182),
        dec: Angle.Degrees(+15.00234698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81128"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52842493),
        dec: Angle.Degrees(+15.00285033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175292"},
        {"Hipparcos Number", "HIP 92757"},
        {"Geneva Identification System", "GEN# +1.00175292"},
        {"Smithsonian Astrophysical Observation", "SAO 104236"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.53181000),
        dec: Angle.Degrees(+15.00638438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162705"},
        {"Hipparcos Number", "HIP 87409"},
        {"Geneva Identification System", "GEN# +1.00162705"},
        {"Renson", "Renson 45980"},
        {"Smithsonian Astrophysical Observation", "SAO 103156"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.94971870),
        dec: Angle.Degrees(+15.00662251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4096"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.15010961),
        dec: Angle.Degrees(+15.00681773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14098 AB"},
        {"Henry Draper", "HD 196741"},
        {"Hipparcos Number", "HIP 101886"},
        {"Smithsonian Astrophysical Observation", "SAO 106344"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.70877097),
        dec: Angle.Degrees(+15.00730670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17229"},
        {"Hipparcos Number", "HIP 12928"},
        {"Smithsonian Astrophysical Observation", "SAO 93094"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.56851749),
        dec: Angle.Degrees(+15.00779713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92032"},
        {"Hipparcos Number", "HIP 52033"},
        {"Smithsonian Astrophysical Observation", "SAO 99220"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.47362700),
        dec: Angle.Degrees(+15.00859472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79681"},
        {"Hipparcos Number", "HIP 45462"},
        {"Geneva Identification System", "GEN# +1.00079681"},
        {"Smithsonian Astrophysical Observation", "SAO 98461"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.97095718),
        dec: Angle.Degrees(+15.00868949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210822"},
        {"Hipparcos Number", "HIP 109653"},
        {"Geneva Identification System", "GEN# +1.00210822"},
        {"Smithsonian Astrophysical Observation", "SAO 107737"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.19859201),
        dec: Angle.Degrees(+15.00880063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2309"},
        {"Smithsonian Astrophysical Observation", "SAO 91921"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.36443634),
        dec: Angle.Degrees(+15.01031194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5452"},
        {"Hipparcos Number", "HIP 4400"},
        {"Smithsonian Astrophysical Observation", "SAO 92162"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.10908971),
        dec: Angle.Degrees(+15.01039575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95486"},
        {"Hipparcos Number", "HIP 53881"},
        {"Cincinnati Publication", "Ci 18 1341"},
        {"Geneva Identification System", "GEN# +1.00095486"},
        {"Smithsonian Astrophysical Observation", "SAO 99403"},
        {"Wilson Evans Batten Catalogue", "WEB 9754"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.35766881),
        dec: Angle.Degrees(+15.01046829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -320.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204701"},
        {"Hipparcos Number", "HIP 106156"},
        {"Smithsonian Astrophysical Observation", "SAO 107180"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.53385552),
        dec: Angle.Degrees(+15.01357013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161199"},
        {"Hipparcos Number", "HIP 86757"},
        {"Smithsonian Astrophysical Observation", "SAO 103059"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.91289540),
        dec: Angle.Degrees(+15.01414573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55120"},
        {"Smithsonian Astrophysical Observation", "SAO 99535"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.28047154),
        dec: Angle.Degrees(+15.01809193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106949"},
        {"Hipparcos Number", "HIP 59958"},
        {"Geneva Identification System", "GEN# +1.00106949"},
        {"Smithsonian Astrophysical Observation", "SAO 100025"},
        {"Wilson Evans Batten Catalogue", "WEB 10657"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.46209228),
        dec: Angle.Degrees(+15.01920937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229710"},
        {"Hipparcos Number", "HIP 92497"},
        {"Fundamental Katalog 5th Edition", "FK5 5658"},
        {"Smithsonian Astrophysical Observation", "SAO 104173"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.75539811),
        dec: Angle.Degrees(+15.01986052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69808"},
        {"Hipparcos Number", "HIP 40759"},
        {"Geneva Identification System", "GEN# +1.00069808"},
        {"Smithsonian Astrophysical Observation", "SAO 97726"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.79994398),
        dec: Angle.Degrees(+15.02004610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46222"},
        {"Hipparcos Number", "HIP 31191"},
        {"Geneva Identification System", "GEN# +1.00046222"},
        {"Smithsonian Astrophysical Observation", "SAO 95811"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.16533512),
        dec: Angle.Degrees(+15.02098825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9202"},
        {"Hipparcos Number", "HIP 7042"},
        {"Geneva Identification System", "GEN# +1.00009202"},
        {"Smithsonian Astrophysical Observation", "SAO 92471"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.69597457),
        dec: Angle.Degrees(+15.02169561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53476"},
        {"Hipparcos Number", "HIP 34230"},
        {"Smithsonian Astrophysical Observation", "SAO 96478"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.44837349),
        dec: Angle.Degrees(+15.02261012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115321"},
        {"Hipparcos Number", "HIP 64755"},
        {"Fundamental Katalog 5th Edition", "FK5 5170"},
        {"Geneva Identification System", "GEN# +1.00115321"},
        {"Smithsonian Astrophysical Observation", "SAO 100485"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.06759983),
        dec: Angle.Degrees(+15.02430236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105270"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.84532557),
        dec: Angle.Degrees(+15.02520813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25584"},
        {"Hipparcos Number", "HIP 18998"},
        {"Geneva Identification System", "GEN# +1.00025584"},
        {"Smithsonian Astrophysical Observation", "SAO 93746"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.05410937),
        dec: Angle.Degrees(+15.02691746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200789"},
        {"Hipparcos Number", "HIP 104087"},
        {"Smithsonian Astrophysical Observation", "SAO 106826"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.31578657),
        dec: Angle.Degrees(+15.03031164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18717"},
        {"Hipparcos Number", "HIP 14048"},
        {"Geneva Identification System", "GEN# +1.00018717"},
        {"Smithsonian Astrophysical Observation", "SAO 93235"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.22294670),
        dec: Angle.Degrees(+15.03135065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111959"},
        {"Hipparcos Number", "HIP 62852"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.24237240),
        dec: Angle.Degrees(+15.03143703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2173"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.85932867),
        dec: Angle.Degrees(+15.03165407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15814"},
        {"Hipparcos Number", "HIP 11843"},
        {"Fundamental Katalog 5th Edition", "FK5 2176"},
        {"Geneva Identification System", "GEN# +1.00015814"},
        {"Smithsonian Astrophysical Observation", "SAO 92998"},
        {"Wilson Evans Batten Catalogue", "WEB 2454"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.22562452),
        dec: Angle.Degrees(+15.03446457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161900"},
        {"Hipparcos Number", "HIP 87075"},
        {"Smithsonian Astrophysical Observation", "SAO 103111"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.90451095),
        dec: Angle.Degrees(+15.03501426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179784"},
        {"Hipparcos Number", "HIP 94436"},
        {"Geneva Identification System", "GEN# +1.00179784"},
        {"Smithsonian Astrophysical Observation", "SAO 104617"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31410237),
        dec: Angle.Degrees(+15.03564187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1528"},
        {"Smithsonian Astrophysical Observation", "SAO 91841"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.76149354),
        dec: Angle.Degrees(+15.03571035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10796 AB"},
        {"Henry Draper", "HD 161819"},
        {"Hipparcos Number", "HIP 87047"},
        {"Smithsonian Astrophysical Observation", "SAO 103105"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78815201),
        dec: Angle.Degrees(+15.03721714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96344"},
        {"Hipparcos Number", "HIP 54303"},
        {"Geneva Identification System", "GEN# +1.00096344"},
        {"Smithsonian Astrophysical Observation", "SAO 99442"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.63942208),
        dec: Angle.Degrees(+15.03802140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31373"},
        {"Hipparcos Number", "HIP 22913"},
        {"Geneva Identification System", "GEN# +1.00031373"},
        {"Renson", "Renson 8040"},
        {"Smithsonian Astrophysical Observation", "SAO 94212"},
        {"Wilson Evans Batten Catalogue", "WEB 4448"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.95898357),
        dec: Angle.Degrees(+15.04030639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40420"},
    },
    visualMagnitude: 11.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.78347285),
        dec: Angle.Degrees(+15.04045547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8073"},
        {"Smithsonian Astrophysical Observation", "SAO 92597"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.93041759),
        dec: Angle.Degrees(+15.04047587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206432"},
        {"Hipparcos Number", "HIP 107105"},
        {"Smithsonian Astrophysical Observation", "SAO 107330"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.42373928),
        dec: Angle.Degrees(+15.04232412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14909"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10354636),
        dec: Angle.Degrees(+15.04271382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222946"},
        {"Hipparcos Number", "HIP 117162"},
        {"Fundamental Katalog 5th Edition", "FK5 6106"},
        {"Smithsonian Astrophysical Observation", "SAO 108810"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.30047260),
        dec: Angle.Degrees(+15.04353535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211500"},
        {"Hipparcos Number", "HIP 110038"},
        {"Geneva Identification System", "GEN# +1.00211500"},
        {"Smithsonian Astrophysical Observation", "SAO 107796"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.31879898),
        dec: Angle.Degrees(+15.04686797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74590"},
        {"Hipparcos Number", "HIP 42950"},
        {"Geneva Identification System", "GEN# +1.00074590"},
        {"Smithsonian Astrophysical Observation", "SAO 98096"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.33211258),
        dec: Angle.Degrees(+15.04701399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188716"},
        {"Hipparcos Number", "HIP 98083"},
        {"Smithsonian Astrophysical Observation", "SAO 105434"},
        {"Wilson Evans Batten Catalogue", "WEB 17285"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.99971516),
        dec: Angle.Degrees(+15.04703705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220078"},
        {"Hipparcos Number", "HIP 115263"},
        {"Geneva Identification System", "GEN# +1.00220078"},
        {"Smithsonian Astrophysical Observation", "SAO 108555"},
        {"Wilson Evans Batten Catalogue", "WEB 20419"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.18822841),
        dec: Angle.Degrees(+15.04810489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213890"},
        {"Hipparcos Number", "HIP 111417"},
        {"Geneva Identification System", "GEN# +1.00213890"},
        {"Smithsonian Astrophysical Observation", "SAO 108006"},
        {"Wilson Evans Batten Catalogue", "WEB 19923"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.59077671),
        dec: Angle.Degrees(+15.05093608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48842"},
        {"Smithsonian Astrophysical Observation", "SAO 98867"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.43804263),
        dec: Angle.Degrees(+15.05289953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208864"},
        {"Hipparcos Number", "HIP 108498"},
        {"Smithsonian Astrophysical Observation", "SAO 107556"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.70412676),
        dec: Angle.Degrees(+15.05390819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77132"},
        {"Smithsonian Astrophysical Observation", "SAO 101714"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23734059),
        dec: Angle.Degrees(+15.05510438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3169 AB"},
        {"Henry Draper", "HD 27691"},
        {"Hipparcos Number", "HIP 20440"},
        {"Geneva Identification System", "GEN# +5.20250040"},
        {"Smithsonian Astrophysical Observation", "SAO 93896"},
        {"Wilson Evans Batten Catalogue", "WEB 3908"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.68376513),
        dec: Angle.Degrees(+15.05613981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200090"},
        {"Hipparcos Number", "HIP 103709"},
        {"Smithsonian Astrophysical Observation", "SAO 106754"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22407390),
        dec: Angle.Degrees(+15.05620100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205853"},
        {"Hipparcos Number", "HIP 106788"},
        {"Geneva Identification System", "GEN# +1.00205853"},
        {"Smithsonian Astrophysical Observation", "SAO 107285"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.44376405),
        dec: Angle.Degrees(+15.05787601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132277"},
        {"Hipparcos Number", "HIP 73214"},
        {"Smithsonian Astrophysical Observation", "SAO 101302"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.44803960),
        dec: Angle.Degrees(+15.05885153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12961 AB"},
        {"Aitken 2", "ADS 12961"},
        {"Henry Draper", "HD 187283"},
        {"Hipparcos Number", "HIP 97469"},
        {"Geneva Identification System", "GEN# +1.00187283J"},
        {"Smithsonian Astrophysical Observation", "SAO 105284"},
        {"Wilson Evans Batten Catalogue", "WEB 17132"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.16515324),
        dec: Angle.Degrees(+15.05899790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34792"},
        {"Hipparcos Number", "HIP 24942"},
        {"Smithsonian Astrophysical Observation", "SAO 94473"},
        {"Wilson Evans Batten Catalogue", "WEB 4830"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.14895437),
        dec: Angle.Degrees(+15.05933025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137369"},
        {"Hipparcos Number", "HIP 75492"},
        {"Geneva Identification System", "GEN# +1.00137369"},
        {"Smithsonian Astrophysical Observation", "SAO 101538"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.31794764),
        dec: Angle.Degrees(+15.06011358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150237"},
        {"Hipparcos Number", "HIP 81540"},
        {"Smithsonian Astrophysical Observation", "SAO 102294"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.81030754),
        dec: Angle.Degrees(+15.06056951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25391"},
        {"Hipparcos Number", "HIP 18864"},
        {"Geneva Identification System", "GEN# +1.00025391"},
        {"Smithsonian Astrophysical Observation", "SAO 93735"},
        {"Wilson Evans Batten Catalogue", "WEB 3629"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.66048904),
        dec: Angle.Degrees(+15.06217114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34054"},
        {"Hipparcos Number", "HIP 24475"},
        {"Smithsonian Astrophysical Observation", "SAO 94417"},
        {"Wilson Evans Batten Catalogue", "WEB 4739"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.78765006),
        dec: Angle.Degrees(+15.06256624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4323 AB"},
        {"Henry Draper", "HD 38182"},
        {"Hipparcos Number", "HIP 27078"},
        {"Smithsonian Astrophysical Observation", "SAO 94816"},
        {"Wilson Evans Batten Catalogue", "WEB 5326"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13059921),
        dec: Angle.Degrees(+15.06356337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35785"},
        {"Hipparcos Number", "HIP 25561"},
        {"Geneva Identification System", "GEN# +1.00035785"},
        {"Smithsonian Astrophysical Observation", "SAO 94569"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94915957),
        dec: Angle.Degrees(+15.06580814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52932"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.38043149),
        dec: Angle.Degrees(+15.06591506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12390"},
        {"Hipparcos Number", "HIP 9470"},
        {"Smithsonian Astrophysical Observation", "SAO 92756"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.46002672),
        dec: Angle.Degrees(+15.06708124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176411"},
        {"Hipparcos Number", "HIP 93244"},
        {"Fundamental Katalog 5th Edition", "FK5 712"},
        {"Geneva Identification System", "GEN# +1.00176411"},
        {"Smithsonian Astrophysical Observation", "SAO 104318"},
        {"Wilson Evans Batten Catalogue", "WEB 16166"},
    },
    visualMagnitude: 4.02,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90578844),
        dec: Angle.Degrees(+15.06847757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117417"},
        {"Smithsonian Astrophysical Observation", "SAO 108847"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13196213),
        dec: Angle.Degrees(+15.07061013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62096"},
        {"Hipparcos Number", "HIP 37585"},
        {"Geneva Identification System", "GEN# +1.00062096"},
        {"Smithsonian Astrophysical Observation", "SAO 97171"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.69214062),
        dec: Angle.Degrees(+15.07063060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17018"},
        {"Hipparcos Number", "HIP 12773"},
        {"Smithsonian Astrophysical Observation", "SAO 93080"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.04177170),
        dec: Angle.Degrees(+15.07109246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223299"},
        {"Hipparcos Number", "HIP 117409"},
        {"Smithsonian Astrophysical Observation", "SAO 108846"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.10546792),
        dec: Angle.Degrees(+15.07167846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50155"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58033939),
        dec: Angle.Degrees(+15.07249178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76065"},
        {"Smithsonian Astrophysical Observation", "SAO 101599"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.02080092),
        dec: Angle.Degrees(+15.07428048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197461"},
        {"Hipparcos Number", "HIP 102281"},
        {"Fundamental Katalog 5th Edition", "FK5 778"},
        {"Geneva Identification System", "GEN# +1.00197461"},
        {"Renson", "Renson 55050"},
        {"Smithsonian Astrophysical Observation", "SAO 106425"},
        {"Wilson Evans Batten Catalogue", "WEB 18517"},
    },
    visualMagnitude: 4.43,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.86477381),
        dec: Angle.Degrees(+15.07468224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17864"},
        {"Smithsonian Astrophysical Observation", "SAO 93620"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.34715736),
        dec: Angle.Degrees(+15.07497283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153898"},
        {"Hipparcos Number", "HIP 83316"},
        {"Smithsonian Astrophysical Observation", "SAO 102537"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.40851829),
        dec: Angle.Degrees(+15.07623020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49909"},
        {"Hipparcos Number", "HIP 32896"},
        {"Smithsonian Astrophysical Observation", "SAO 96193"},
        {"Wilson Evans Batten Catalogue", "WEB 6618"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.81199722),
        dec: Angle.Degrees(+15.07658083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112694"},
        {"Hipparcos Number", "HIP 63318"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.63526010),
        dec: Angle.Degrees(+15.07831022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202601"},
        {"Hipparcos Number", "HIP 105039"},
        {"Geneva Identification System", "GEN# +1.00202601"},
        {"Smithsonian Astrophysical Observation", "SAO 106984"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.13787035),
        dec: Angle.Degrees(+15.07884005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132486"},
        {"Hipparcos Number", "HIP 73326"},
        {"Smithsonian Astrophysical Observation", "SAO 101314"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.76167303),
        dec: Angle.Degrees(+15.07912858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116974"},
        {"Hipparcos Number", "HIP 65598"},
        {"Smithsonian Astrophysical Observation", "SAO 100570"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.74516498),
        dec: Angle.Degrees(+15.08181909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17769"},
        {"Hipparcos Number", "HIP 13327"},
        {"Fundamental Katalog 5th Edition", "FK5 1079"},
        {"Geneva Identification System", "GEN# +1.00017769"},
        {"Smithsonian Astrophysical Observation", "SAO 93144"},
        {"Wilson Evans Batten Catalogue", "WEB 2670"},
    },
    visualMagnitude: 5.52,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.87319979),
        dec: Angle.Degrees(+15.08212726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205603"},
        {"Hipparcos Number", "HIP 106643"},
        {"Geneva Identification System", "GEN# +1.00205603"},
        {"Smithsonian Astrophysical Observation", "SAO 107262"},
        {"Wilson Evans Batten Catalogue", "WEB 19291"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.02119868),
        dec: Angle.Degrees(+15.08220968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180243"},
        {"Hipparcos Number", "HIP 94613"},
        {"Geneva Identification System", "GEN# +1.00180243"},
        {"Smithsonian Astrophysical Observation", "SAO 104653"},
        {"Wilson Evans Batten Catalogue", "WEB 16489"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.80790012),
        dec: Angle.Degrees(+15.08239402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30712"},
        {"Hipparcos Number", "HIP 22505"},
        {"Geneva Identification System", "GEN# +5.20250120"},
        {"Smithsonian Astrophysical Observation", "SAO 94159"},
        {"Wilson Evans Batten Catalogue", "WEB 4342"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.64067864),
        dec: Angle.Degrees(+15.08350373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172228"},
        {"Hipparcos Number", "HIP 91408"},
        {"Fundamental Katalog 5th Edition", "FK5 3483"},
        {"Geneva Identification System", "GEN# +1.00172228"},
        {"Smithsonian Astrophysical Observation", "SAO 103942"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.64331628),
        dec: Angle.Degrees(+15.08366782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180262"},
        {"Hipparcos Number", "HIP 94624"},
        {"Geneva Identification System", "GEN# +1.00180262"},
        {"Smithsonian Astrophysical Observation", "SAO 104655"},
        {"Wilson Evans Batten Catalogue", "WEB 16490"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.83370710),
        dec: Angle.Degrees(+15.08367864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133110"},
        {"Hipparcos Number", "HIP 73574"},
        {"Geneva Identification System", "GEN# +1.00133110"},
        {"Smithsonian Astrophysical Observation", "SAO 101341"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.56277281),
        dec: Angle.Degrees(+15.08494770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216308"},
        {"Hipparcos Number", "HIP 112900"},
        {"Geneva Identification System", "GEN# +1.00216308"},
        {"Smithsonian Astrophysical Observation", "SAO 108216"},
        {"Wilson Evans Batten Catalogue", "WEB 20105"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.94220524),
        dec: Angle.Degrees(+15.08582939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24961"},
        {"Hipparcos Number", "HIP 18576"},
        {"Geneva Identification System", "GEN# +1.00024961"},
        {"Smithsonian Astrophysical Observation", "SAO 93697"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.64671120),
        dec: Angle.Degrees(+15.08620251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104604"},
        {"Hipparcos Number", "HIP 58742"},
        {"Geneva Identification System", "GEN# +1.00104604"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.72031435),
        dec: Angle.Degrees(+15.08813636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172471"},
        {"Hipparcos Number", "HIP 91518"},
        {"Smithsonian Astrophysical Observation", "SAO 103966"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95578153),
        dec: Angle.Degrees(+15.08928399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8981"},
        {"Smithsonian Astrophysical Observation", "SAO 92702"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.93609555),
        dec: Angle.Degrees(+15.09102273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164507"},
        {"Hipparcos Number", "HIP 88217"},
        {"Geneva Identification System", "GEN# +1.00164507"},
        {"Smithsonian Astrophysical Observation", "SAO 103299"},
        {"Wilson Evans Batten Catalogue", "WEB 14907"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.23875892),
        dec: Angle.Degrees(+15.09379176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7120"},
        {"Smithsonian Astrophysical Observation", "SAO 92486"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.93682337),
        dec: Angle.Degrees(+15.09408083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148286"},
        {"Hipparcos Number", "HIP 80532"},
        {"Smithsonian Astrophysical Observation", "SAO 102168"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.60450632),
        dec: Angle.Degrees(+15.09432657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27459"},
        {"Hipparcos Number", "HIP 20261"},
        {"Celescope Catalog", "CEL 387"},
        {"Geneva Identification System", "GEN# +5.20250033"},
        {"Smithsonian Astrophysical Observation", "SAO 93876"},
        {"Wilson Evans Batten Catalogue", "WEB 3871"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.15101968),
        dec: Angle.Degrees(+15.09550358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22481"},
        {"Hipparcos Number", "HIP 16891"},
        {"Geneva Identification System", "GEN# +1.00022481"},
        {"Smithsonian Astrophysical Observation", "SAO 93523"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.33623956),
        dec: Angle.Degrees(+15.09555779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4077"},
        {"Hipparcos Number", "HIP 3409"},
        {"Smithsonian Astrophysical Observation", "SAO 92049"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.85131537),
        dec: Angle.Degrees(+15.09592834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71429"},
        {"Hipparcos Number", "HIP 41506"},
        {"Smithsonian Astrophysical Observation", "SAO 97835"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98003886),
        dec: Angle.Degrees(+15.09900845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240585"},
        {"Hipparcos Number", "HIP 23702"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.42175787),
        dec: Angle.Degrees(+15.09985799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120137"},
        {"Hipparcos Number", "HIP 67280"},
        {"Smithsonian Astrophysical Observation", "SAO 100709"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.83209949),
        dec: Angle.Degrees(+15.10046602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177433"},
        {"Hipparcos Number", "HIP 93642"},
        {"Geneva Identification System", "GEN# +1.00177433"},
        {"Smithsonian Astrophysical Observation", "SAO 104433"},
        {"Wilson Evans Batten Catalogue", "WEB 16265"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.03462246),
        dec: Angle.Degrees(+15.10087985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354361"},
        {"Hipparcos Number", "HIP 98275"},
        {"Geneva Identification System", "GEN# +1.00354361"},
        {"Smithsonian Astrophysical Observation", "SAO 105478"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.52081287),
        dec: Angle.Degrees(+15.10101661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139216"},
        {"Hipparcos Number", "HIP 76423"},
        {"Geneva Identification System", "GEN# +1.00139216"},
        {"Smithsonian Astrophysical Observation", "SAO 101641"},
        {"Wilson Evans Batten Catalogue", "WEB 12975"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11745552),
        dec: Angle.Degrees(+15.10140112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44637"},
        {"Hipparcos Number", "HIP 30389"},
        {"Geneva Identification System", "GEN# +1.00044637"},
        {"Smithsonian Astrophysical Observation", "SAO 95612"},
        {"Wilson Evans Batten Catalogue", "WEB 6044"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.85284374),
        dec: Angle.Degrees(+15.10179584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61306"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40483498),
        dec: Angle.Degrees(+15.10198733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33122"},
        {"Hipparcos Number", "HIP 23939"},
        {"Smithsonian Astrophysical Observation", "SAO 94344"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.17609741),
        dec: Angle.Degrees(+15.10384538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193707"},
        {"Hipparcos Number", "HIP 100365"},
        {"Smithsonian Astrophysical Observation", "SAO 106007"},
        {"Wilson Evans Batten Catalogue", "WEB 18110"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.31449051),
        dec: Angle.Degrees(+15.10431688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109557"},
        {"Smithsonian Astrophysical Observation", "SAO 107725"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.87877866),
        dec: Angle.Degrees(+15.10444551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28595"},
        {"Hipparcos Number", "HIP 21082"},
        {"Geneva Identification System", "GEN# +1.00028595"},
        {"Smithsonian Astrophysical Observation", "SAO 93983"},
        {"Wilson Evans Batten Catalogue", "WEB 4056"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.77985394),
        dec: Angle.Degrees(+15.10516513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171570"},
        {"Hipparcos Number", "HIP 91110"},
        {"Smithsonian Astrophysical Observation", "SAO 103875"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.77873610),
        dec: Angle.Degrees(+15.10541314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242509"},
        {"Hipparcos Number", "HIP 24785"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.69749943),
        dec: Angle.Degrees(+15.10548032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103025"},
        {"Smithsonian Astrophysical Observation", "SAO 106595"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.08779456),
        dec: Angle.Degrees(+15.10627716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63496"},
        {"Hipparcos Number", "HIP 38218"},
        {"Geneva Identification System", "GEN# +1.00063496"},
        {"Smithsonian Astrophysical Observation", "SAO 97286"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.44332772),
        dec: Angle.Degrees(+15.10649368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216698"},
        {"Hipparcos Number", "HIP 113156"},
        {"Smithsonian Astrophysical Observation", "SAO 108253"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.71018248),
        dec: Angle.Degrees(+15.10764273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59059"},
        {"Hipparcos Number", "HIP 36340"},
        {"Geneva Identification System", "GEN# +1.00059059"},
        {"Smithsonian Astrophysical Observation", "SAO 96930"},
        {"Wilson Evans Batten Catalogue", "WEB 7229"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.19690819),
        dec: Angle.Degrees(+15.10985983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43212"},
        {"Smithsonian Astrophysical Observation", "SAO 98136"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.04379106),
        dec: Angle.Degrees(+15.11067756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58130"},
        {"Smithsonian Astrophysical Observation", "SAO 99866"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.84598654),
        dec: Angle.Degrees(+15.11137246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8647 AB"},
        {"Henry Draper", "HD 110703"},
        {"Hipparcos Number", "HIP 62116"},
        {"Geneva Identification System", "GEN# +1.00110703J"},
        {"Smithsonian Astrophysical Observation", "SAO 100228"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.96328012),
        dec: Angle.Degrees(+15.11226287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97833"},
        {"Hipparcos Number", "HIP 54975"},
        {"Geneva Identification System", "GEN# +1.00097833"},
        {"Smithsonian Astrophysical Observation", "SAO 99521"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.85648249),
        dec: Angle.Degrees(+15.11310129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81541"},
        {"Hipparcos Number", "HIP 46318"},
        {"Smithsonian Astrophysical Observation", "SAO 98570"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66872340),
        dec: Angle.Degrees(+15.11610126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79746"},
        {"Hipparcos Number", "HIP 45495"},
        {"Smithsonian Astrophysical Observation", "SAO 98465"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.04775774),
        dec: Angle.Degrees(+15.12114693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9952 AB"},
        {"Henry Draper", "HD 145648"},
        {"Hipparcos Number", "HIP 79333"},
        {"Smithsonian Astrophysical Observation", "SAO 101993"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.87002061),
        dec: Angle.Degrees(+15.12372330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105444"},
        {"Hipparcos Number", "HIP 59201"},
        {"Geneva Identification System", "GEN# +1.00105444"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.10694998),
        dec: Angle.Degrees(+15.12423224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187402"},
        {"Hipparcos Number", "HIP 97524"},
        {"Geneva Identification System", "GEN# +1.00187402"},
        {"Smithsonian Astrophysical Observation", "SAO 105302"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.31636288),
        dec: Angle.Degrees(+15.12457725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6732"},
        {"Hipparcos Number", "HIP 5332"},
        {"Smithsonian Astrophysical Observation", "SAO 92268"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04865689),
        dec: Angle.Degrees(+15.12592645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96923"},
        {"Hipparcos Number", "HIP 54544"},
        {"Smithsonian Astrophysical Observation", "SAO 99473"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.42664302),
        dec: Angle.Degrees(+15.12801690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148832"},
        {"Hipparcos Number", "HIP 80814"},
        {"Smithsonian Astrophysical Observation", "SAO 102212"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.54216190),
        dec: Angle.Degrees(+15.12827058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176321"},
        {"Hipparcos Number", "HIP 93211"},
        {"Smithsonian Astrophysical Observation", "SAO 104314"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.80143355),
        dec: Angle.Degrees(+15.12986947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40570"},
        {"Hipparcos Number", "HIP 28431"},
        {"Smithsonian Astrophysical Observation", "SAO 95103"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.06252142),
        dec: Angle.Degrees(+15.13108013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107838"},
        {"Smithsonian Astrophysical Observation", "SAO 107434"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.71066420),
        dec: Angle.Degrees(+15.13136188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42267"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.28347985),
        dec: Angle.Degrees(+15.13148708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -892.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130144"},
        {"Hipparcos Number", "HIP 72208"},
        {"Fundamental Katalog 5th Edition", "FK5 3168"},
        {"Geneva Identification System", "GEN# +1.00130144"},
        {"Smithsonian Astrophysical Observation", "SAO 101200"},
        {"Wilson Evans Batten Catalogue", "WEB 12424"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.52498866),
        dec: Angle.Degrees(+15.13174102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131383"},
        {"Hipparcos Number", "HIP 72814"},
        {"Smithsonian Astrophysical Observation", "SAO 101271"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.23539827),
        dec: Angle.Degrees(+15.13239541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141850"},
        {"Hipparcos Number", "HIP 77615"},
        {"Geneva Identification System", "GEN# +1.00141850"},
        {"Smithsonian Astrophysical Observation", "SAO 101771"},
        {"Wilson Evans Batten Catalogue", "WEB 13132"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.67389697),
        dec: Angle.Degrees(+15.13372732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285333"},
        {"Hipparcos Number", "HIP 18843"},
        {"Smithsonian Astrophysical Observation", "SAO 93732"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.60947037),
        dec: Angle.Degrees(+15.13388567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87390"},
        {"Hipparcos Number", "HIP 49395"},
        {"Smithsonian Astrophysical Observation", "SAO 98936"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.26444389),
        dec: Angle.Degrees(+15.13456591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89889"},
        {"Smithsonian Astrophysical Observation", "SAO 103625"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.12067271),
        dec: Angle.Degrees(+15.13592501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157393"},
        {"Hipparcos Number", "HIP 85000"},
        {"Geneva Identification System", "GEN# +1.00157393"},
        {"Smithsonian Astrophysical Observation", "SAO 102777"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.60419853),
        dec: Angle.Degrees(+15.13681814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149285"},
        {"Hipparcos Number", "HIP 81059"},
        {"Geneva Identification System", "GEN# +1.00149285"},
        {"Smithsonian Astrophysical Observation", "SAO 102241"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.33074923),
        dec: Angle.Degrees(+15.13840180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163930"},
        {"Hipparcos Number", "HIP 87965"},
        {"Geneva Identification System", "GEN# +1.00163930"},
        {"Smithsonian Astrophysical Observation", "SAO 103254"},
        {"Wilson Evans Batten Catalogue", "WEB 14851"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52914317),
        dec: Angle.Degrees(+15.13923552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3412"},
        {"Hipparcos Number", "HIP 2927"},
        {"Fundamental Katalog 5th Edition", "FK5 4055"},
        {"Smithsonian Astrophysical Observation", "SAO 91998"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.28405614),
        dec: Angle.Degrees(+15.13999011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56044"},
        {"Smithsonian Astrophysical Observation", "SAO 99625"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.29551392),
        dec: Angle.Degrees(+15.14195735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101026"},
        {"Hipparcos Number", "HIP 56720"},
        {"Smithsonian Astrophysical Observation", "SAO 99701"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.43772793),
        dec: Angle.Degrees(+15.14292899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57049"},
        {"Hipparcos Number", "HIP 35548"},
        {"Geneva Identification System", "GEN# +1.00057049"},
        {"Smithsonian Astrophysical Observation", "SAO 96783"},
        {"Wilson Evans Batten Catalogue", "WEB 7085"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.02849829),
        dec: Angle.Degrees(+15.14297247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107384"},
        {"Hipparcos Number", "HIP 60198"},
        {"Geneva Identification System", "GEN# +1.00107384"},
        {"Smithsonian Astrophysical Observation", "SAO 100052"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.17143251),
        dec: Angle.Degrees(+15.14408988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106926"},
        {"Hipparcos Number", "HIP 59941"},
        {"Geneva Identification System", "GEN# +1.00106926"},
        {"Smithsonian Astrophysical Observation", "SAO 100023"},
        {"Wilson Evans Batten Catalogue", "WEB 10650"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.43433066),
        dec: Angle.Degrees(+15.14479989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86339"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.64011930),
        dec: Angle.Degrees(+15.14557838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16755 A"},
        {"Hipparcos Number", "HIP 115718"},
        {"Smithsonian Astrophysical Observation", "SAO 108607"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.66493467),
        dec: Angle.Degrees(+15.14618180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29310"},
        {"Hipparcos Number", "HIP 21543"},
        {"Geneva Identification System", "GEN# +5.20250102"},
        {"Smithsonian Astrophysical Observation", "SAO 94040"},
        {"Wilson Evans Batten Catalogue", "WEB 4135"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.38303886),
        dec: Angle.Degrees(+15.14649776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119350"},
        {"Hipparcos Number", "HIP 66895"},
        {"Fundamental Katalog 5th Edition", "FK5 5212"},
        {"Geneva Identification System", "GEN# +1.00119350"},
        {"Smithsonian Astrophysical Observation", "SAO 100672"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.63644533),
        dec: Angle.Degrees(+15.14707504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69669"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.90737137),
        dec: Angle.Degrees(+15.14743813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16178"},
        {"Hipparcos Number", "HIP 12125"},
        {"Smithsonian Astrophysical Observation", "SAO 93018"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.04984481),
        dec: Angle.Degrees(+15.14879856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22579"},
        {"Hipparcos Number", "HIP 16985"},
        {"Geneva Identification System", "GEN# +1.00022579"},
        {"Smithsonian Astrophysical Observation", "SAO 93528"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.60988285),
        dec: Angle.Degrees(+15.14977475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45089"},
        {"Hipparcos Number", "HIP 30613"},
        {"Smithsonian Astrophysical Observation", "SAO 95674"},
        {"Wilson Evans Batten Catalogue", "WEB 6106"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.50443930),
        dec: Angle.Degrees(+15.14988800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13314"},
        {"Hipparcos Number", "HIP 10143"},
        {"Geneva Identification System", "GEN# +1.00013314"},
        {"Smithsonian Astrophysical Observation", "SAO 92821"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.62256189),
        dec: Angle.Degrees(+15.15150189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170052"},
        {"Hipparcos Number", "HIP 90417"},
        {"Geneva Identification System", "GEN# +1.00170052"},
        {"Smithsonian Astrophysical Observation", "SAO 103722"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73162696),
        dec: Angle.Degrees(+15.15171583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10277 AB"},
        {"Henry Draper", "HD 153301"},
        {"Hipparcos Number", "HIP 83034"},
        {"Smithsonian Astrophysical Observation", "SAO 102502"},
        {"Wilson Evans Batten Catalogue", "WEB 14038"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.51999699),
        dec: Angle.Degrees(+15.15308382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76959"},
        {"Hipparcos Number", "HIP 44174"},
        {"Smithsonian Astrophysical Observation", "SAO 98281"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.96236441),
        dec: Angle.Degrees(+15.15336536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64255"},
        {"Geneva Identification System", "GEN# +0.01502548"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.55415816),
        dec: Angle.Degrees(+15.15381416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77327"},
        {"Cincinnati Publication", "Ci 20 947"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.79958514),
        dec: Angle.Degrees(+15.15415538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -366.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18477"},
        {"Hipparcos Number", "HIP 13871"},
        {"Smithsonian Astrophysical Observation", "SAO 93214"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.66250423),
        dec: Angle.Degrees(+15.15453888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67089"},
        {"Hipparcos Number", "HIP 39708"},
        {"Geneva Identification System", "GEN# +1.00067089"},
        {"Smithsonian Astrophysical Observation", "SAO 97560"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.74517330),
        dec: Angle.Degrees(+15.15544014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87776"},
        {"Hipparcos Number", "HIP 49623"},
        {"Geneva Identification System", "GEN# +1.00087776"},
        {"Smithsonian Astrophysical Observation", "SAO 98960"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.91403484),
        dec: Angle.Degrees(+15.15772186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153701"},
        {"Hipparcos Number", "HIP 83221"},
        {"Geneva Identification System", "GEN# +1.00153701"},
        {"Smithsonian Astrophysical Observation", "SAO 102526"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11905016),
        dec: Angle.Degrees(+15.15906499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157068"},
        {"Hipparcos Number", "HIP 84857"},
        {"Geneva Identification System", "GEN# +1.00157068"},
        {"Smithsonian Astrophysical Observation", "SAO 102760"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.15093693),
        dec: Angle.Degrees(+15.15950666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26015"},
        {"Hipparcos Number", "HIP 19261"},
        {"Smithsonian Astrophysical Observation", "SAO 93775"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.92460942),
        dec: Angle.Degrees(+15.16284328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15789"},
        {"Hipparcos Number", "HIP 11827"},
        {"Smithsonian Astrophysical Observation", "SAO 92996"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.16094093),
        dec: Angle.Degrees(+15.16292422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229356"},
        {"Hipparcos Number", "HIP 91980"},
    },
    visualMagnitude: 11.12,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.21473068),
        dec: Angle.Degrees(+15.16306103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285931"},
        {"Hipparcos Number", "HIP 21280"},
        {"Geneva Identification System", "GEN# +5.20250096"},
        {"Smithsonian Astrophysical Observation", "SAO 94009"},
        {"Wilson Evans Batten Catalogue", "WEB 4092"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.49365197),
        dec: Angle.Degrees(+15.16370338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172170"},
        {"Hipparcos Number", "HIP 91377"},
        {"Smithsonian Astrophysical Observation", "SAO 103935"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.54644493),
        dec: Angle.Degrees(+15.16420488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81821"},
        {"Hipparcos Number", "HIP 46449"},
        {"Smithsonian Astrophysical Observation", "SAO 98590"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.10552142),
        dec: Angle.Degrees(+15.16556188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4270"},
        {"Hipparcos Number", "HIP 3545"},
        {"Geneva Identification System", "GEN# +1.00004270"},
        {"Smithsonian Astrophysical Observation", "SAO 92063"},
        {"Wilson Evans Batten Catalogue", "WEB 628"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.32582799),
        dec: Angle.Degrees(+15.16579682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74957"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.75761077),
        dec: Angle.Degrees(+15.16749065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27802"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.24861786),
        dec: Angle.Degrees(+15.17064528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51398"},
        {"Smithsonian Astrophysical Observation", "SAO 99161"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.46761103),
        dec: Angle.Degrees(+15.17448207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145515"},
        {"Hipparcos Number", "HIP 79282"},
        {"Geneva Identification System", "GEN# +1.00145515"},
        {"Smithsonian Astrophysical Observation", "SAO 101988"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.71959264),
        dec: Angle.Degrees(+15.17528860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121512"},
        {"Hipparcos Number", "HIP 67998"},
        {"Geneva Identification System", "GEN# +1.00121512"},
        {"Smithsonian Astrophysical Observation", "SAO 100774"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.87694144),
        dec: Angle.Degrees(+15.17623240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8249"},
        {"Hipparcos Number", "HIP 6380"},
        {"Geneva Identification System", "GEN# +1.00008249"},
        {"Smithsonian Astrophysical Observation", "SAO 92394"},
        {"Wilson Evans Batten Catalogue", "WEB 1415"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.49818621),
        dec: Angle.Degrees(+15.17708110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20512"},
        {"Hipparcos Number", "HIP 15394"},
        {"Cincinnati Publication", "Ci 18 439"},
        {"Geneva Identification System", "GEN# +1.00020512A"},
        {"Smithsonian Astrophysical Observation", "SAO 93377"},
        {"Wilson Evans Batten Catalogue", "WEB 2957"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.61307392),
        dec: Angle.Degrees(+15.17808022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -301.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5875 AB"},
        {"Henry Draper", "HD 55283"},
        {"Hipparcos Number", "HIP 34858"},
        {"Smithsonian Astrophysical Observation", "SAO 96630"},
        {"Wilson Evans Batten Catalogue", "WEB 6968"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20067817),
        dec: Angle.Degrees(+15.17831347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39341"},
        {"Geneva Identification System", "GEN# +0.01501733"},
        {"Smithsonian Astrophysical Observation", "SAO 97496"},
        {"Wilson Evans Batten Catalogue", "WEB 7703"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.62876102),
        dec: Angle.Degrees(+15.17832215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160765"},
        {"Hipparcos Number", "HIP 86546"},
        {"Geneva Identification System", "GEN# +1.00160765"},
        {"Renson", "Renson 45290"},
        {"Smithsonian Astrophysical Observation", "SAO 103020"},
        {"Wilson Evans Batten Catalogue", "WEB 14596"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.29582024),
        dec: Angle.Degrees(+15.17838782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65973"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.89361581),
        dec: Angle.Degrees(+15.17849558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108686"},
        {"Smithsonian Astrophysical Observation", "SAO 107586"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.25694122),
        dec: Angle.Degrees(+15.18071129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53536"},
        {"Hipparcos Number", "HIP 34241"},
        {"Smithsonian Astrophysical Observation", "SAO 96483"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.48249332),
        dec: Angle.Degrees(+15.18148164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156483"},
        {"Hipparcos Number", "HIP 84568"},
        {"Geneva Identification System", "GEN# +1.00156483"},
        {"Smithsonian Astrophysical Observation", "SAO 102714"},
        {"Wilson Evans Batten Catalogue", "WEB 14280"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.31931807),
        dec: Angle.Degrees(+15.18176150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96373"},
        {"Hipparcos Number", "HIP 54318"},
        {"Smithsonian Astrophysical Observation", "SAO 99445"},
        {"Wilson Evans Batten Catalogue", "WEB 9809"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.68287733),
        dec: Angle.Degrees(+15.18211355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1067",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Algenib"},
        {"Henry Draper", "HD 886"},
        {"Hipparcos Number", "HIP 1067"},
        {"Fundamental Katalog 5th Edition", "FK5 7"},
        {"Geneva Identification System", "GEN# +1.00000886"},
        {"Smithsonian Astrophysical Observation", "SAO 91781"},
        {"Wilson Evans Batten Catalogue", "WEB 185"},
    },
    visualMagnitude: 2.83,
    bvColour: -0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30895828),
        dec: Angle.Degrees(+15.18361593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58276"},
        {"Smithsonian Astrophysical Observation", "SAO 99880"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.27554879),
        dec: Angle.Degrees(+15.18402863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24442"},
        {"Hipparcos Number", "HIP 18228"},
        {"Geneva Identification System", "GEN# +1.00024442"},
        {"Smithsonian Astrophysical Observation", "SAO 93657"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.45311642),
        dec: Angle.Degrees(+15.18450021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183511"},
        {"Hipparcos Number", "HIP 95826"},
        {"Smithsonian Astrophysical Observation", "SAO 104897"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.35653213),
        dec: Angle.Degrees(+15.18516808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101315",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13965 AB"},
        {"Henry Draper", "HD 195651"},
        {"Hipparcos Number", "HIP 101315"},
        {"Smithsonian Astrophysical Observation", "SAO 106210"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.03169320),
        dec: Angle.Degrees(+15.18644346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91885"},
        {"Hipparcos Number", "HIP 51959"},
        {"Smithsonian Astrophysical Observation", "SAO 99208"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.21778378),
        dec: Angle.Degrees(+15.18694039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56038"},
        {"Smithsonian Astrophysical Observation", "SAO 99623"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.27730284),
        dec: Angle.Degrees(+15.18741501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138542"},
        {"Hipparcos Number", "HIP 76082"},
        {"Geneva Identification System", "GEN# +1.00138542"},
        {"Smithsonian Astrophysical Observation", "SAO 101601"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.08145377),
        dec: Angle.Degrees(+15.18841311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30390"},
        {"Hipparcos Number", "HIP 22273"},
        {"Fundamental Katalog 5th Edition", "FK5 4434"},
        {"Smithsonian Astrophysical Observation", "SAO 94126"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.93013278),
        dec: Angle.Degrees(+15.19109485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158835"},
        {"Hipparcos Number", "HIP 85713"},
        {"Smithsonian Astrophysical Observation", "SAO 102876"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.72749728),
        dec: Angle.Degrees(+15.19263440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77211"},
        {"Hipparcos Number", "HIP 44313"},
        {"Geneva Identification System", "GEN# +1.00077211"},
        {"Smithsonian Astrophysical Observation", "SAO 98301"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.37424008),
        dec: Angle.Degrees(+15.19270294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177902"},
        {"Hipparcos Number", "HIP 93793"},
        {"Smithsonian Astrophysical Observation", "SAO 104472"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.51567813),
        dec: Angle.Degrees(+15.19501064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102273"},
        {"Smithsonian Astrophysical Observation", "SAO 106424"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.83866917),
        dec: Angle.Degrees(+15.19584918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2693"},
        {"Smithsonian Astrophysical Observation", "SAO 91970"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.54150688),
        dec: Angle.Degrees(+15.19631500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94514"},
        {"Hipparcos Number", "HIP 53366"},
        {"Smithsonian Astrophysical Observation", "SAO 99352"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.69180272),
        dec: Angle.Degrees(+15.19691802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31330"},
        {"Hipparcos Number", "HIP 22886"},
        {"Smithsonian Astrophysical Observation", "SAO 94208"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.84193284),
        dec: Angle.Degrees(+15.19705141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192425"},
        {"Hipparcos Number", "HIP 99742"},
        {"Fundamental Katalog 5th Edition", "FK5 1526"},
        {"Geneva Identification System", "GEN# +1.00192425"},
        {"Smithsonian Astrophysical Observation", "SAO 105878"},
        {"Wilson Evans Batten Catalogue", "WEB 17901"},
    },
    visualMagnitude: 4.94,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.56910667),
        dec: Angle.Degrees(+15.19746767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16571"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.33815699),
        dec: Angle.Degrees(+15.19803921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173000"},
        {"Hipparcos Number", "HIP 91752"},
        {"Smithsonian Astrophysical Observation", "SAO 104008"},
        {"Wilson Evans Batten Catalogue", "WEB 15785"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.65399914),
        dec: Angle.Degrees(+15.19941373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113340"},
        {"Hipparcos Number", "HIP 63668"},
        {"Geneva Identification System", "GEN# +1.00113340"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73417751),
        dec: Angle.Degrees(+15.19978992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8568"},
        {"Smithsonian Astrophysical Observation", "SAO 92655"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62553537),
        dec: Angle.Degrees(+15.20163179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17794"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.13699453),
        dec: Angle.Degrees(+15.20221478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19361"},
        {"Hipparcos Number", "HIP 14497"},
        {"Geneva Identification System", "GEN# +1.00019361"},
        {"Smithsonian Astrophysical Observation", "SAO 93283"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.82011623),
        dec: Angle.Degrees(+15.20314487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187401"},
        {"Henry Draper 2", "HD 187401A"},
        {"Henry Draper 3", "HD 187401B"},
        {"Hipparcos Number", "HIP 97525"},
        {"Geneva Identification System", "GEN# +1.00187401"},
        {"Smithsonian Astrophysical Observation", "SAO 105304"},
        {"Wilson Evans Batten Catalogue", "WEB 17148"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.32061444),
        dec: Angle.Degrees(+15.20422921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113963",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Markab"},
        {"Henry Draper", "HD 218045"},
        {"Hipparcos Number", "HIP 113963"},
        {"Fundamental Katalog 5th Edition", "FK5 871"},
        {"Geneva Identification System", "GEN# +1.00218045"},
        {"Smithsonian Astrophysical Observation", "SAO 108378"},
        {"Wilson Evans Batten Catalogue", "WEB 20238"},
    },
    visualMagnitude: 2.49,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.19007020),
        dec: Angle.Degrees(+15.20536786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354833"},
        {"Hipparcos Number", "HIP 99020"},
        {"Geneva Identification System", "GEN# +1.00354833"},
        {"Smithsonian Astrophysical Observation", "SAO 105684"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.53470936),
        dec: Angle.Degrees(+15.20572869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47381"},
        {"Hipparcos Number", "HIP 31802"},
        {"Geneva Identification System", "GEN# +1.00047381"},
        {"Smithsonian Astrophysical Observation", "SAO 95940"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.73279333),
        dec: Angle.Degrees(+15.20695021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241914"},
        {"Hipparcos Number", "HIP 24446"},
        {"Smithsonian Astrophysical Observation", "SAO 94412"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.66391974),
        dec: Angle.Degrees(+15.20820552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100898"},
        {"Smithsonian Astrophysical Observation", "SAO 106125"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.87387359),
        dec: Angle.Degrees(+15.21034613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154892"},
        {"Hipparcos Number", "HIP 83810"},
        {"Geneva Identification System", "GEN# +1.00154892"},
        {"Smithsonian Astrophysical Observation", "SAO 102607"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.92224694),
        dec: Angle.Degrees(+15.21043854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219275"},
        {"Hipparcos Number", "HIP 114739"},
        {"Smithsonian Astrophysical Observation", "SAO 108481"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.63876374),
        dec: Angle.Degrees(+15.21173809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51690"},
        {"Smithsonian Astrophysical Observation", "SAO 99184"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.38880413),
        dec: Angle.Degrees(+15.21381405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37773"},
        {"Hipparcos Number", "HIP 26807"},
        {"Geneva Identification System", "GEN# +1.00037773"},
        {"Smithsonian Astrophysical Observation", "SAO 94765"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.39311117),
        dec: Angle.Degrees(+15.21418407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124066"},
        {"Hipparcos Number", "HIP 69281"},
        {"Geneva Identification System", "GEN# +1.00124066A"},
        {"Smithsonian Astrophysical Observation", "SAO 100896"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.73258288),
        dec: Angle.Degrees(+15.21567042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231285"},
        {"Hipparcos Number", "HIP 95307"},
        {"Geneva Identification System", "GEN# +1.00231285"},
        {"Smithsonian Astrophysical Observation", "SAO 104783"},
        {"Wilson Evans Batten Catalogue", "WEB 16658"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.84970456),
        dec: Angle.Degrees(+15.21591097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205837"},
        {"Hipparcos Number", "HIP 106775"},
        {"Smithsonian Astrophysical Observation", "SAO 107284"},
        {"Wilson Evans Batten Catalogue", "WEB 19305"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42358506),
        dec: Angle.Degrees(+15.21605469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78091"},
        {"Hipparcos Number", "HIP 44723"},
        {"Geneva Identification System", "GEN# +1.00078091"},
        {"Smithsonian Astrophysical Observation", "SAO 98365"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.69072784),
        dec: Angle.Degrees(+15.21639548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16847"},
        {"Hipparcos Number", "HIP 12646"},
        {"Smithsonian Astrophysical Observation", "SAO 93066"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.62038082),
        dec: Angle.Degrees(+15.21704589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55434"},
        {"Hipparcos Number", "HIP 34918"},
        {"Geneva Identification System", "GEN# +1.00055434"},
        {"Smithsonian Astrophysical Observation", "SAO 96641"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.36902399),
        dec: Angle.Degrees(+15.22039736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16186 AB"},
        {"Henry Draper", "HD 215014"},
        {"Hipparcos Number", "HIP 112068"},
        {"Smithsonian Astrophysical Observation", "SAO 108110"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.49482602),
        dec: Angle.Degrees(+15.22121533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86359"},
        {"Hipparcos Number", "HIP 48881"},
        {"Geneva Identification System", "GEN# +1.00086359"},
        {"Smithsonian Astrophysical Observation", "SAO 98874"},
        {"Wilson Evans Batten Catalogue", "WEB 9081"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.54887405),
        dec: Angle.Degrees(+15.22136589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176089"},
        {"Hipparcos Number", "HIP 93110"},
        {"Smithsonian Astrophysical Observation", "SAO 104295"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.51977868),
        dec: Angle.Degrees(+15.22203647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231014"},
        {"Hipparcos Number", "HIP 94665"},
        {"Geneva Identification System", "GEN# +1.00231014"},
        {"Smithsonian Astrophysical Observation", "SAO 104664"},
        {"Wilson Evans Batten Catalogue", "WEB 16505"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.95114093),
        dec: Angle.Degrees(+15.22238311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208277"},
        {"Hipparcos Number", "HIP 108166"},
        {"Fundamental Katalog 5th Edition", "FK5 5935"},
        {"Geneva Identification System", "GEN# +1.00208277"},
        {"Smithsonian Astrophysical Observation", "SAO 107499"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.72400857),
        dec: Angle.Degrees(+15.22557718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6302"},
        {"Hipparcos Number", "HIP 5009"},
        {"Geneva Identification System", "GEN# +1.00006302"},
        {"Smithsonian Astrophysical Observation", "SAO 92226"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.03180591),
        dec: Angle.Degrees(+15.22745872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353379"},
        {"Hipparcos Number", "HIP 96904"},
        {"Geneva Identification System", "GEN# +1.00353379"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.47486727),
        dec: Angle.Degrees(+15.22787893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91071"},
        {"Smithsonian Astrophysical Observation", "SAO 103866"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.64537654),
        dec: Angle.Degrees(+15.22929095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55432"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28227971),
        dec: Angle.Degrees(+15.22978496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154653"},
        {"Hipparcos Number", "HIP 83689"},
        {"Smithsonian Astrophysical Observation", "SAO 102595"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.56738530),
        dec: Angle.Degrees(+15.22983542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224186"},
        {"Hipparcos Number", "HIP 117986"},
        {"Geneva Identification System", "GEN# +1.00224186"},
        {"Smithsonian Astrophysical Observation", "SAO 108911"},
        {"Wilson Evans Batten Catalogue", "WEB 20749"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.97763328),
        dec: Angle.Degrees(+15.23030839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57635"},
        {"Smithsonian Astrophysical Observation", "SAO 99808"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.27103124),
        dec: Angle.Degrees(+15.23107886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17369"},
        {"Hipparcos Number", "HIP 13046"},
        {"Geneva Identification System", "GEN# +1.00017369"},
        {"Smithsonian Astrophysical Observation", "SAO 93108"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.90848153),
        dec: Angle.Degrees(+15.23137383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3379"},
        {"Hipparcos Number", "HIP 2903"},
        {"Fundamental Katalog 5th Edition", "FK5 2039"},
        {"Geneva Identification System", "GEN# +1.00003379"},
        {"Smithsonian Astrophysical Observation", "SAO 91995"},
        {"Wilson Evans Batten Catalogue", "WEB 525"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.19713232),
        dec: Angle.Degrees(+15.23175994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 615"},
        {"Hipparcos Number", "HIP 856"},
        {"Geneva Identification System", "GEN# +1.00000615"},
        {"Smithsonian Astrophysical Observation", "SAO 91755"},
        {"Wilson Evans Batten Catalogue", "WEB 145"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.62339153),
        dec: Angle.Degrees(+15.23192856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16246"},
        {"Smithsonian Astrophysical Observation", "SAO 93453"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.34245546),
        dec: Angle.Degrees(+15.23258168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88047"},
        {"Hipparcos Number", "HIP 49758"},
        {"Smithsonian Astrophysical Observation", "SAO 98972"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.35577167),
        dec: Angle.Degrees(+15.23348396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165826"},
        {"Hipparcos Number", "HIP 88769"},
        {"Smithsonian Astrophysical Observation", "SAO 103397"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83626331),
        dec: Angle.Degrees(+15.23472425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142093"},
        {"Hipparcos Number", "HIP 77718"},
        {"Geneva Identification System", "GEN# +1.00142093"},
        {"Smithsonian Astrophysical Observation", "SAO 101782"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.00245111),
        dec: Angle.Degrees(+15.23623506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285513"},
        {"Hipparcos Number", "HIP 19499"},
        {"Smithsonian Astrophysical Observation", "SAO 93802"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67057262),
        dec: Angle.Degrees(+15.23705549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32643"},
        {"Hipparcos Number", "HIP 23669"},
        {"Renson", "Renson 8340"},
        {"Smithsonian Astrophysical Observation", "SAO 94302"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.31901024),
        dec: Angle.Degrees(+15.23991372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78533"},
        {"Hipparcos Number", "HIP 44942"},
        {"Smithsonian Astrophysical Observation", "SAO 98391"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.31004117),
        dec: Angle.Degrees(+15.24106153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95787",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12502 AB"},
        {"Henry Draper", "HD 183420"},
        {"Hipparcos Number", "HIP 95787"},
        {"Smithsonian Astrophysical Observation", "SAO 104886"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.24052504),
        dec: Angle.Degrees(+15.24324807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32128"},
        {"Hipparcos Number", "HIP 23361"},
        {"Smithsonian Astrophysical Observation", "SAO 94270"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.35573845),
        dec: Angle.Degrees(+15.24424638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37231"},
        {"Hipparcos Number", "HIP 26447"},
        {"Geneva Identification System", "GEN# +1.00037231"},
        {"Smithsonian Astrophysical Observation", "SAO 94713"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40702588),
        dec: Angle.Degrees(+15.24465879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7508"},
        {"Smithsonian Astrophysical Observation", "SAO 92534"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.18981159),
        dec: Angle.Degrees(+15.24863996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116364"},
        {"Hipparcos Number", "HIP 65300"},
        {"Geneva Identification System", "GEN# +1.00116364"},
        {"Smithsonian Astrophysical Observation", "SAO 100541"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.74974339),
        dec: Angle.Degrees(+15.25056321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185195"},
        {"Hipparcos Number", "HIP 96518"},
        {"Geneva Identification System", "GEN# +1.00185195"},
        {"Renson", "Renson 51140"},
        {"Smithsonian Astrophysical Observation", "SAO 105059"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.32432006),
        dec: Angle.Degrees(+15.25066366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59602"},
        {"Hipparcos Number", "HIP 36564"},
        {"Smithsonian Astrophysical Observation", "SAO 96974"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.82035967),
        dec: Angle.Degrees(+15.25129787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71051"},
        {"Smithsonian Astrophysical Observation", "SAO 101066"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95438870),
        dec: Angle.Degrees(+15.25181263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108559"},
        {"Hipparcos Number", "HIP 60838"},
        {"Geneva Identification System", "GEN# +1.00108559"},
        {"Smithsonian Astrophysical Observation", "SAO 100113"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.04885957),
        dec: Angle.Degrees(+15.25249757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201640"},
        {"Hipparcos Number", "HIP 104531"},
        {"Geneva Identification System", "GEN# +1.00201640"},
        {"Smithsonian Astrophysical Observation", "SAO 106891"},
        {"Wilson Evans Batten Catalogue", "WEB 19024"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62025453),
        dec: Angle.Degrees(+15.25255422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83225"},
        {"Hipparcos Number", "HIP 47211"},
        {"Geneva Identification System", "GEN# +1.00083225"},
        {"Smithsonian Astrophysical Observation", "SAO 98676"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.32218024),
        dec: Angle.Degrees(+15.25256128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186182"},
        {"Hipparcos Number", "HIP 96939"},
        {"Geneva Identification System", "GEN# +1.00186182"},
        {"Smithsonian Astrophysical Observation", "SAO 105164"},
        {"Wilson Evans Batten Catalogue", "WEB 17013"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.59752165),
        dec: Angle.Degrees(+15.25308677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58056"},
        {"Geneva Identification System", "GEN# +0.01602316"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.60711020),
        dec: Angle.Degrees(+15.25378490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66534"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.58148277),
        dec: Angle.Degrees(+15.25615399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1307 A"},
        {"Henry Draper", "HD 10182"},
        {"Hipparcos Number", "HIP 7762"},
        {"Smithsonian Astrophysical Observation", "SAO 92560"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97872058),
        dec: Angle.Degrees(+15.25668289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144489"},
        {"Hipparcos Number", "HIP 78833"},
        {"Smithsonian Astrophysical Observation", "SAO 101914"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.39614168),
        dec: Angle.Degrees(+15.25750313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35693"},
        {"Hipparcos Number", "HIP 25502"},
        {"Geneva Identification System", "GEN# +1.00035693"},
        {"Renson", "Renson 9220"},
        {"Smithsonian Astrophysical Observation", "SAO 94556"},
        {"Wilson Evans Batten Catalogue", "WEB 4949"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.80790759),
        dec: Angle.Degrees(+15.25765500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62321"},
        {"Hipparcos Number", "HIP 37685"},
        {"Geneva Identification System", "GEN# +1.00062321"},
        {"Smithsonian Astrophysical Observation", "SAO 97192"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.97291046),
        dec: Angle.Degrees(+15.25772810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202937"},
        {"Hipparcos Number", "HIP 105221"},
        {"Geneva Identification System", "GEN# +1.00202937"},
        {"Smithsonian Astrophysical Observation", "SAO 107018"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.69212242),
        dec: Angle.Degrees(+15.25928880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1307 B"},
        {"Hipparcos Number", "HIP 7765"},
        {"Smithsonian Astrophysical Observation", "SAO 92561"},
    },
    visualMagnitude: 8.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.98327133),
        dec: Angle.Degrees(+15.25944524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175243"},
        {"Hipparcos Number", "HIP 92741"},
        {"Smithsonian Astrophysical Observation", "SAO 104235"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.48761242),
        dec: Angle.Degrees(+15.25989924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82140"},
        {"Hipparcos Number", "HIP 46635"},
        {"Geneva Identification System", "GEN# +1.00082140"},
        {"Smithsonian Astrophysical Observation", "SAO 98613"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64708032),
        dec: Angle.Degrees(+15.26015186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209150"},
        {"Hipparcos Number", "HIP 108671"},
        {"Geneva Identification System", "GEN# +1.00209150"},
        {"Smithsonian Astrophysical Observation", "SAO 107582"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.22639299),
        dec: Angle.Degrees(+15.26054078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125180"},
        {"Hipparcos Number", "HIP 69829"},
        {"Geneva Identification System", "GEN# +1.00125180"},
        {"Smithsonian Astrophysical Observation", "SAO 100956"},
        {"Wilson Evans Batten Catalogue", "WEB 12153"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.36851090),
        dec: Angle.Degrees(+15.26336094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21334"},
    },
    visualMagnitude: 12.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68046163),
        dec: Angle.Degrees(+15.26510608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229919"},
        {"Hipparcos Number", "HIP 92718"},
        {"Smithsonian Astrophysical Observation", "SAO 104227"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.39071792),
        dec: Angle.Degrees(+15.26554400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58438"},
        {"Geneva Identification System", "GEN# +0.01602323"},
        {"Smithsonian Astrophysical Observation", "SAO 99891"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.73056870),
        dec: Angle.Degrees(+15.26588155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77175"},
        {"Hipparcos Number", "HIP 44295"},
        {"Cincinnati Publication", "Ci 18 1066"},
        {"Wilson Evans Batten Catalogue", "WEB 8493"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.32313619),
        dec: Angle.Degrees(+15.26654028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191011"},
        {"Hipparcos Number", "HIP 99101"},
        {"Smithsonian Astrophysical Observation", "SAO 105709"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.78893287),
        dec: Angle.Degrees(+15.26709290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3768"},
        {"Hipparcos Number", "HIP 3189"},
        {"Smithsonian Astrophysical Observation", "SAO 92019"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.14320300),
        dec: Angle.Degrees(+15.27087592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156431"},
        {"Hipparcos Number", "HIP 84550"},
        {"Geneva Identification System", "GEN# +1.00156431"},
        {"Smithsonian Astrophysical Observation", "SAO 102709"},
        {"Wilson Evans Batten Catalogue", "WEB 14271"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.26098418),
        dec: Angle.Degrees(+15.27136187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70594"},
        {"Hipparcos Number", "HIP 41112"},
        {"Smithsonian Astrophysical Observation", "SAO 97782"},
        {"Wilson Evans Batten Catalogue", "WEB 7962"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.82944938),
        dec: Angle.Degrees(+15.27186299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5215"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.67323507),
        dec: Angle.Degrees(+15.27341418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9301"},
        {"Smithsonian Astrophysical Observation", "SAO 92740"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.88567149),
        dec: Angle.Degrees(+15.27350295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78011"},
        {"Hipparcos Number", "HIP 44682"},
        {"Smithsonian Astrophysical Observation", "SAO 98363"},
        {"Wilson Evans Batten Catalogue", "WEB 8548"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.59008219),
        dec: Angle.Degrees(+15.27458172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72325"},
        {"Hipparcos Number", "HIP 41913"},
        {"Smithsonian Astrophysical Observation", "SAO 97901"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.18091075),
        dec: Angle.Degrees(+15.27460710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216027"},
        {"Hipparcos Number", "HIP 112695"},
        {"Geneva Identification System", "GEN# +1.00216027"},
        {"Smithsonian Astrophysical Observation", "SAO 108202"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32212074),
        dec: Angle.Degrees(+15.27571097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121371"},
        {"Hipparcos Number", "HIP 67935"},
        {"Geneva Identification System", "GEN# +1.00121371"},
        {"Smithsonian Astrophysical Observation", "SAO 100767"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.68475783),
        dec: Angle.Degrees(+15.27762659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53522"},
        {"Geneva Identification System", "GEN# +0.01602188"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.24108303),
        dec: Angle.Degrees(+15.27952805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33418"},
        {"Hipparcos Number", "HIP 24104"},
        {"Geneva Identification System", "GEN# +1.00033418"},
        {"Smithsonian Astrophysical Observation", "SAO 94367"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.66651776),
        dec: Angle.Degrees(+15.27959890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13596"},
        {"Hipparcos Number", "HIP 10328"},
        {"Fundamental Katalog 5th Edition", "FK5 1057"},
        {"Geneva Identification System", "GEN# +1.00013596"},
        {"Smithsonian Astrophysical Observation", "SAO 92841"},
        {"Wilson Evans Batten Catalogue", "WEB 2155"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.26352181),
        dec: Angle.Degrees(+15.27991044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61361"},
        {"Geneva Identification System", "GEN# +9.80059024"},
        {"Wilson Evans Batten Catalogue", "WEB 10922"},
    },
    visualMagnitude: 12.01,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.60545482),
        dec: Angle.Degrees(+15.28036449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -296.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163363"},
        {"Hipparcos Number", "HIP 87732"},
        {"Geneva Identification System", "GEN# +1.00163363"},
        {"Smithsonian Astrophysical Observation", "SAO 103215"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.81442386),
        dec: Angle.Degrees(+15.28064577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29988"},
    },
    visualMagnitude: 11.75,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.68968049),
        dec: Angle.Degrees(+15.28117449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212442"},
        {"Hipparcos Number", "HIP 110573"},
        {"Fundamental Katalog 5th Edition", "FK5 3790"},
        {"Geneva Identification System", "GEN# +1.00212442"},
        {"Smithsonian Astrophysical Observation", "SAO 107884"},
        {"Wilson Evans Batten Catalogue", "WEB 19818"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.00201289),
        dec: Angle.Degrees(+15.28150493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138058"},
        {"Hipparcos Number", "HIP 75795"},
        {"Geneva Identification System", "GEN# +1.00138058"},
        {"Smithsonian Astrophysical Observation", "SAO 101575"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.26914453),
        dec: Angle.Degrees(+15.28428778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115074"},
        {"Hipparcos Number", "HIP 64615"},
        {"Geneva Identification System", "GEN# +1.00115074"},
        {"Smithsonian Astrophysical Observation", "SAO 100474"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.65616178),
        dec: Angle.Degrees(+15.28597113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52074"},
        {"Hipparcos Number", "HIP 33730"},
        {"Smithsonian Astrophysical Observation", "SAO 96368"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09941917),
        dec: Angle.Degrees(+15.28812536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43547"},
        {"Smithsonian Astrophysical Observation", "SAO 98185"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.03557251),
        dec: Angle.Degrees(+15.28961714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1975"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.25472192),
        dec: Angle.Degrees(+15.29065563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124034"},
        {"Hipparcos Number", "HIP 69260"},
        {"Geneva Identification System", "GEN# +1.00124034"},
        {"Smithsonian Astrophysical Observation", "SAO 100894"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.68075061),
        dec: Angle.Degrees(+15.29076203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97922",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13082 AB"},
        {"Henry Draper", "HD 188328"},
        {"Hipparcos Number", "HIP 97922"},
        {"Smithsonian Astrophysical Observation", "SAO 105396"},
        {"Wilson Evans Batten Catalogue", "WEB 17229"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.50820907),
        dec: Angle.Degrees(+15.29211542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140665"},
        {"Hipparcos Number", "HIP 77083"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.09067657),
        dec: Angle.Degrees(+15.29984249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88829"},
        {"Smithsonian Astrophysical Observation", "SAO 103408"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.99076724),
        dec: Angle.Degrees(+15.30031944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110660"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26368079),
        dec: Angle.Degrees(+15.30182918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8468"},
        {"Hipparcos Number", "HIP 6535"},
        {"Geneva Identification System", "GEN# +1.00008468"},
        {"Smithsonian Astrophysical Observation", "SAO 92418"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.00404947),
        dec: Angle.Degrees(+15.30532959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13005"},
        {"Smithsonian Astrophysical Observation", "SAO 93101"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.79337934),
        dec: Angle.Degrees(+15.30701949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208817"},
        {"Hipparcos Number", "HIP 108483"},
        {"Geneva Identification System", "GEN# +1.00208817"},
        {"Smithsonian Astrophysical Observation", "SAO 107554"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.63943451),
        dec: Angle.Degrees(+15.30718711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67213"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.59843532),
        dec: Angle.Degrees(+15.30940079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164254"},
        {"Hipparcos Number", "HIP 88114"},
        {"Smithsonian Astrophysical Observation", "SAO 103279"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.94002187),
        dec: Angle.Degrees(+15.30958200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159443"},
        {"Hipparcos Number", "HIP 85976"},
        {"Smithsonian Astrophysical Observation", "SAO 102924"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.57328486),
        dec: Angle.Degrees(+15.31082833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174457"},
        {"Hipparcos Number", "HIP 92418"},
        {"Geneva Identification System", "GEN# +1.00174457"},
        {"Smithsonian Astrophysical Observation", "SAO 104160"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.50831977),
        dec: Angle.Degrees(+15.31119189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17036"},
        {"Hipparcos Number", "HIP 12803"},
        {"Geneva Identification System", "GEN# +1.00017036"},
        {"Smithsonian Astrophysical Observation", "SAO 93082"},
        {"Wilson Evans Batten Catalogue", "WEB 2603"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.13737997),
        dec: Angle.Degrees(+15.31189952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354963"},
        {"Hipparcos Number", "HIP 99309"},
        {"Wilson Evans Batten Catalogue", "WEB 17716"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.37013122),
        dec: Angle.Degrees(+15.31242880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72943"},
        {"Hipparcos Number", "HIP 42187"},
        {"Geneva Identification System", "GEN# +1.00072943"},
        {"Renson", "Renson 20230"},
        {"Smithsonian Astrophysical Observation", "SAO 97950"},
        {"Wilson Evans Batten Catalogue", "WEB 8108"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.03212308),
        dec: Angle.Degrees(+15.31368827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218950"},
        {"Hipparcos Number", "HIP 114542"},
        {"Smithsonian Astrophysical Observation", "SAO 108452"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.01654733),
        dec: Angle.Degrees(+15.31395351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117435"},
        {"Hipparcos Number", "HIP 65871"},
        {"Geneva Identification System", "GEN# +1.00117435"},
        {"Smithsonian Astrophysical Observation", "SAO 100601"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.52280986),
        dec: Angle.Degrees(+15.31474213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72724"},
        {"Smithsonian Astrophysical Observation", "SAO 101258"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.02778874),
        dec: Angle.Degrees(+15.31477305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40396"},
        {"Hipparcos Number", "HIP 28323"},
        {"Geneva Identification System", "GEN# +1.00040396"},
        {"Smithsonian Astrophysical Observation", "SAO 95078"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.76171925),
        dec: Angle.Degrees(+15.31507627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6086 AB"},
        {"Henry Draper", "HD 58729"},
        {"Hipparcos Number", "HIP 36212"},
        {"Geneva Identification System", "GEN# +1.00058729J"},
        {"Smithsonian Astrophysical Observation", "SAO 96914"},
        {"Wilson Evans Batten Catalogue", "WEB 7211"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.85816003),
        dec: Angle.Degrees(+15.31642816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73003"},
        {"Smithsonian Astrophysical Observation", "SAO 101284"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.79100101),
        dec: Angle.Degrees(+15.31677597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192715"},
        {"Hipparcos Number", "HIP 99873"},
        {"Geneva Identification System", "GEN# +1.00192715"},
        {"Smithsonian Astrophysical Observation", "SAO 105905"},
        {"Wilson Evans Batten Catalogue", "WEB 17962"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.94040722),
        dec: Angle.Degrees(+15.31714115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110354"},
    },
    visualMagnitude: 11.77,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25789662),
        dec: Angle.Degrees(+15.31724442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72681",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9414 A"},
        {"Henry Draper", "HD 131177"},
        {"Hipparcos Number", "HIP 72681"},
        {"Cincinnati Publication", "Ci 18 1966"},
        {"Smithsonian Astrophysical Observation", "SAO 101254"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.90657922),
        dec: Angle.Degrees(+15.31729740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78047"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02863479),
        dec: Angle.Degrees(+15.31745526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114865"},
        {"Hipparcos Number", "HIP 64490"},
        {"Geneva Identification System", "GEN# +1.00114865"},
        {"Smithsonian Astrophysical Observation", "SAO 100465"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.28126868),
        dec: Angle.Degrees(+15.31752296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76543"},
        {"Hipparcos Number", "HIP 43970"},
        {"Geneva Identification System", "GEN# +1.00076543"},
        {"Renson", "Renson 21576"},
        {"Smithsonian Astrophysical Observation", "SAO 98247"},
        {"Wilson Evans Batten Catalogue", "WEB 8453"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.31213728),
        dec: Angle.Degrees(+15.32271727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187959"},
        {"Hipparcos Number", "HIP 97780"},
        {"Geneva Identification System", "GEN# +1.00187959"},
        {"Renson", "Renson 51860"},
        {"Smithsonian Astrophysical Observation", "SAO 105354"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.03941270),
        dec: Angle.Degrees(+15.32323400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1643"},
        {"Smithsonian Astrophysical Observation", "SAO 91855"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.14210468),
        dec: Angle.Degrees(+15.32404858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131714"},
        {"Hipparcos Number", "HIP 72976"},
        {"Smithsonian Astrophysical Observation", "SAO 101281"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.70824455),
        dec: Angle.Degrees(+15.32529585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87427",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10850 AB"},
        {"Henry Draper", "HD 162734"},
        {"Hipparcos Number", "HIP 87427"},
        {"Smithsonian Astrophysical Observation", "SAO 103161"},
        {"Wilson Evans Batten Catalogue", "WEB 14748"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.99360355),
        dec: Angle.Degrees(+15.32627417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200877"},
        {"Hipparcos Number", "HIP 104128"},
        {"Geneva Identification System", "GEN# +1.00200877"},
        {"Smithsonian Astrophysical Observation", "SAO 106829"},
        {"Wilson Evans Batten Catalogue", "WEB 18965"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.45202612),
        dec: Angle.Degrees(+15.32741269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74909"},
        {"Hipparcos Number", "HIP 43147"},
        {"Smithsonian Astrophysical Observation", "SAO 98121"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.82571644),
        dec: Angle.Degrees(+15.32922623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192126"},
        {"Hipparcos Number", "HIP 99602"},
        {"Geneva Identification System", "GEN# +1.00192126"},
        {"Smithsonian Astrophysical Observation", "SAO 105840"},
        {"Wilson Evans Batten Catalogue", "WEB 17835"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.19642093),
        dec: Angle.Degrees(+15.32984499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112128"},
        {"Hipparcos Number", "HIP 62958"},
        {"Geneva Identification System", "GEN# +1.00112128"},
        {"Smithsonian Astrophysical Observation", "SAO 100324"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.52206576),
        dec: Angle.Degrees(+15.32992481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46595"},
        {"Hipparcos Number", "HIP 31404"},
        {"Geneva Identification System", "GEN# +1.00046595"},
        {"Smithsonian Astrophysical Observation", "SAO 95862"},
        {"Wilson Evans Batten Catalogue", "WEB 6285"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.73938831),
        dec: Angle.Degrees(+15.33047723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72240"},
        {"Hipparcos Number", "HIP 41873"},
        {"Geneva Identification System", "GEN# +1.00072240"},
        {"Smithsonian Astrophysical Observation", "SAO 97892"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.07054053),
        dec: Angle.Degrees(+15.33131432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202479"},
        {"Hipparcos Number", "HIP 104979"},
        {"Geneva Identification System", "GEN# +1.00202479"},
        {"Smithsonian Astrophysical Observation", "SAO 106974"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.94094523),
        dec: Angle.Degrees(+15.33138659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54901"},
        {"Hipparcos Number", "HIP 34705"},
        {"Geneva Identification System", "GEN# +1.00054901"},
        {"Smithsonian Astrophysical Observation", "SAO 96603"},
        {"Wilson Evans Batten Catalogue", "WEB 6937"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82023624),
        dec: Angle.Degrees(+15.33228846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285507"},
        {"Hipparcos Number", "HIP 19207"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.75479366),
        dec: Angle.Degrees(+15.33507766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225002"},
        {"Hipparcos Number", "HIP 198"},
        {"Smithsonian Astrophysical Observation", "SAO 108978"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.63269567),
        dec: Angle.Degrees(+15.33519012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19518"},
        {"Hipparcos Number", "HIP 14614"},
        {"Geneva Identification System", "GEN# +1.00019518"},
        {"Smithsonian Astrophysical Observation", "SAO 93299"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.18443378),
        dec: Angle.Degrees(+15.33530084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102093"},
        {"Hipparcos Number", "HIP 57313"},
        {"Geneva Identification System", "GEN# +1.00102093"},
        {"Smithsonian Astrophysical Observation", "SAO 99772"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.26786985),
        dec: Angle.Degrees(+15.33544188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52556"},
        {"Hipparcos Number", "HIP 33914"},
        {"Smithsonian Astrophysical Observation", "SAO 96403"},
        {"Wilson Evans Batten Catalogue", "WEB 6806"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.57287660),
        dec: Angle.Degrees(+15.33606893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75413"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.12464463),
        dec: Angle.Degrees(+15.33648078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26844"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.49507883),
        dec: Angle.Degrees(+15.33733032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69035"},
        {"Smithsonian Astrophysical Observation", "SAO 100862"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.97617864),
        dec: Angle.Degrees(+15.33747586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114402"},
        {"Hipparcos Number", "HIP 64254"},
        {"Geneva Identification System", "GEN# +1.00114402"},
        {"Smithsonian Astrophysical Observation", "SAO 100445"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.55094426),
        dec: Angle.Degrees(+15.33832213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11707"},
        {"Hipparcos Number", "HIP 8947"},
        {"Smithsonian Astrophysical Observation", "SAO 92695"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.81108165),
        dec: Angle.Degrees(+15.34086335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55282"},
        {"Hipparcos Number", "HIP 34865"},
        {"Geneva Identification System", "GEN# +1.00055282"},
        {"Smithsonian Astrophysical Observation", "SAO 96631"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.21035276),
        dec: Angle.Degrees(+15.34148721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74567"},
        {"Hipparcos Number", "HIP 42943"},
        {"Geneva Identification System", "GEN# +1.00074567"},
        {"Smithsonian Astrophysical Observation", "SAO 98092"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.30010453),
        dec: Angle.Degrees(+15.34194996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175428"},
        {"Hipparcos Number", "HIP 92825"},
        {"Smithsonian Astrophysical Observation", "SAO 104253"},
        {"Wilson Evans Batten Catalogue", "WEB 16065"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.70108600),
        dec: Angle.Degrees(+15.34270055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50064"},
        {"Smithsonian Astrophysical Observation", "SAO 99009"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.32491750),
        dec: Angle.Degrees(+15.34461157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7744 AB"},
        {"Henry Draper", "HD 89906"},
        {"Hipparcos Number", "HIP 50829"},
        {"Smithsonian Astrophysical Observation", "SAO 99091"},
        {"Wilson Evans Batten Catalogue", "WEB 9301"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.68317269),
        dec: Angle.Degrees(+15.34461320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89506"},
        {"Smithsonian Astrophysical Observation", "SAO 103537"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.97266315),
        dec: Angle.Degrees(+15.34493840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7097",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alpherg"},
        {"Aitken", "ADS 1199 AB"},
        {"Henry Draper", "HD 9270"},
        {"Hipparcos Number", "HIP 7097"},
        {"Fundamental Katalog 5th Edition", "FK5 50"},
        {"Geneva Identification System", "GEN# +1.00009270J"},
        {"Smithsonian Astrophysical Observation", "SAO 92484"},
        {"Wilson Evans Batten Catalogue", "WEB 1532"},
    },
    visualMagnitude: 3.62,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87080776),
        dec: Angle.Degrees(+15.34583101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29319"},
        {"Hipparcos Number", "HIP 21554"},
        {"Smithsonian Astrophysical Observation", "SAO 94042"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.42420967),
        dec: Angle.Degrees(+15.34616961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66922"},
        {"Hipparcos Number", "HIP 39650"},
        {"Geneva Identification System", "GEN# +1.00066922"},
        {"Smithsonian Astrophysical Observation", "SAO 97556"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.53790943),
        dec: Angle.Degrees(+15.34669636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88060"},
        {"Hipparcos Number", "HIP 49771"},
        {"Geneva Identification System", "GEN# +1.00088060"},
        {"Smithsonian Astrophysical Observation", "SAO 98973"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.39657482),
        dec: Angle.Degrees(+15.34691541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176542"},
        {"Hipparcos Number", "HIP 93302"},
        {"Smithsonian Astrophysical Observation", "SAO 104339"},
        {"Wilson Evans Batten Catalogue", "WEB 16178"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.06584146),
        dec: Angle.Degrees(+15.34708811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4256 A"},
        {"Henry Draper", "HD 37603"},
        {"Hipparcos Number", "HIP 26692"},
        {"Smithsonian Astrophysical Observation", "SAO 94746"},
        {"Wilson Evans Batten Catalogue", "WEB 5261"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07854712),
        dec: Angle.Degrees(+15.35015382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4256 B"},
        {"Hipparcos Number", "HIP 26690"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07562966),
        dec: Angle.Degrees(+15.35039994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75528"},
        {"Hipparcos Number", "HIP 43454"},
        {"Fundamental Katalog 5th Edition", "FK5 2699"},
        {"Geneva Identification System", "GEN# +1.00075528"},
        {"Smithsonian Astrophysical Observation", "SAO 98168"},
        {"Wilson Evans Batten Catalogue", "WEB 8375"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.75638589),
        dec: Angle.Degrees(+15.35047458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191980"},
        {"Hipparcos Number", "HIP 99540"},
        {"Geneva Identification System", "GEN# +1.00191980"},
        {"Renson", "Renson 53520"},
        {"Smithsonian Astrophysical Observation", "SAO 105821"},
        {"Wilson Evans Batten Catalogue", "WEB 17808"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01602283),
        dec: Angle.Degrees(+15.35781342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57728"},
        {"Hipparcos Number", "HIP 35796"},
        {"Geneva Identification System", "GEN# +1.00057728"},
        {"Smithsonian Astrophysical Observation", "SAO 96838"},
        {"Wilson Evans Batten Catalogue", "WEB 7133"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.75579824),
        dec: Angle.Degrees(+15.35892961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36162"},
        {"Hipparcos Number", "HIP 25790"},
        {"Celescope Catalog", "CEL 740"},
        {"Geneva Identification System", "GEN# +1.00036162"},
        {"Smithsonian Astrophysical Observation", "SAO 94596"},
        {"Wilson Evans Batten Catalogue", "WEB 5011"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.60905551),
        dec: Angle.Degrees(+15.36054290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190068"},
        {"Hipparcos Number", "HIP 98687"},
        {"Geneva Identification System", "GEN# +1.00190068"},
        {"Renson", "Renson 52730"},
        {"Smithsonian Astrophysical Observation", "SAO 105584"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.66134079),
        dec: Angle.Degrees(+15.36062092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86927"},
        {"Hipparcos Number", "HIP 49168"},
        {"Smithsonian Astrophysical Observation", "SAO 98907"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.51291775),
        dec: Angle.Degrees(+15.36070626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194115"},
        {"Hipparcos Number", "HIP 100551"},
        {"Smithsonian Astrophysical Observation", "SAO 106051"},
        {"Wilson Evans Batten Catalogue", "WEB 18164"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.83054743),
        dec: Angle.Degrees(+15.36207905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151305"},
        {"Hipparcos Number", "HIP 82086"},
        {"Smithsonian Astrophysical Observation", "SAO 102371"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.51449788),
        dec: Angle.Degrees(+15.36309303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66553"},
        {"Hipparcos Number", "HIP 39515"},
        {"Geneva Identification System", "GEN# +1.00066553"},
        {"Smithsonian Astrophysical Observation", "SAO 97536"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.14491179),
        dec: Angle.Degrees(+15.36485387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285816"},
        {"Hipparcos Number", "HIP 20810"},
        {"Geneva Identification System", "GEN# +5.20250188"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.88457063),
        dec: Angle.Degrees(+15.36541442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67501"},
        {"Geneva Identification System", "GEN# +0.01602565"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49195913),
        dec: Angle.Degrees(+15.36541789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65450"},
        {"Hipparcos Number", "HIP 39052"},
        {"Smithsonian Astrophysical Observation", "SAO 97442"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.84480234),
        dec: Angle.Degrees(+15.36555235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175702"},
        {"Hipparcos Number", "HIP 92936"},
        {"Geneva Identification System", "GEN# +1.00175702"},
        {"Smithsonian Astrophysical Observation", "SAO 104268"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.02424069),
        dec: Angle.Degrees(+15.36571761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71930"},
        {"Smithsonian Astrophysical Observation", "SAO 101164"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.67619632),
        dec: Angle.Degrees(+15.36742649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219172"},
        {"Hipparcos Number", "HIP 114670"},
        {"Fundamental Katalog 5th Edition", "FK5 6052"},
        {"Geneva Identification System", "GEN# +1.00219172"},
        {"Smithsonian Astrophysical Observation", "SAO 108468"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.45091039),
        dec: Angle.Degrees(+15.36780808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80613"},
        {"Hipparcos Number", "HIP 45874"},
        {"Geneva Identification System", "GEN# +1.00080613"},
        {"Smithsonian Astrophysical Observation", "SAO 98517"},
        {"Wilson Evans Batten Catalogue", "WEB 8700"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.31403563),
        dec: Angle.Degrees(+15.37136629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220335"},
        {"Hipparcos Number", "HIP 115415"},
        {"Smithsonian Astrophysical Observation", "SAO 108574"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.69658284),
        dec: Angle.Degrees(+15.37189230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19618"},
        {"Hipparcos Number", "HIP 14705"},
        {"Geneva Identification System", "GEN# +1.00019618"},
        {"Smithsonian Astrophysical Observation", "SAO 93313"},
        {"Wilson Evans Batten Catalogue", "WEB 2851"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.49887372),
        dec: Angle.Degrees(+15.37391985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113879"},
        {"Hipparcos Number", "HIP 63976"},
        {"Geneva Identification System", "GEN# +1.00113879"},
        {"Smithsonian Astrophysical Observation", "SAO 100419"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.64966129),
        dec: Angle.Degrees(+15.37395777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184472"},
        {"Hipparcos Number", "HIP 96219"},
        {"Smithsonian Astrophysical Observation", "SAO 104974"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.49850799),
        dec: Angle.Degrees(+15.37441554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167217"},
        {"Hipparcos Number", "HIP 89333"},
        {"Smithsonian Astrophysical Observation", "SAO 103504"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.41704825),
        dec: Angle.Degrees(+15.37515698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74420",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9533 AB"},
        {"Henry Draper", "HD 135022"},
        {"Hipparcos Number", "HIP 74420"},
        {"Smithsonian Astrophysical Observation", "SAO 101431"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.13898108),
        dec: Angle.Degrees(+15.37619462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122301"},
        {"Hipparcos Number", "HIP 68443"},
        {"Geneva Identification System", "GEN# +1.00122301"},
        {"Smithsonian Astrophysical Observation", "SAO 100812"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.18544852),
        dec: Angle.Degrees(+15.37649327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151939"},
        {"Hipparcos Number", "HIP 82372"},
        {"Geneva Identification System", "GEN# +1.00151939"},
        {"Smithsonian Astrophysical Observation", "SAO 102415"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.48831121),
        dec: Angle.Degrees(+15.37704428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64164"},
        {"Hipparcos Number", "HIP 38503"},
        {"Smithsonian Astrophysical Observation", "SAO 97330"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.27248772),
        dec: Angle.Degrees(+15.37739448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110315"},
        {"Hipparcos Number", "HIP 61901"},
        {"Cincinnati Publication", "Ci 20 731"},
        {"Geneva Identification System", "GEN# +1.00110315"},
        {"Smithsonian Astrophysical Observation", "SAO 100205"},
        {"Wilson Evans Batten Catalogue", "WEB 11002"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.27670276),
        dec: Angle.Degrees(+15.37756957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -372.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11619"},
        {"Smithsonian Astrophysical Observation", "SAO 92975"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.46858373),
        dec: Angle.Degrees(+15.37838891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72282"},
        {"Smithsonian Astrophysical Observation", "SAO 101207"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.71976687),
        dec: Angle.Degrees(+15.37865823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62076"},
        {"Smithsonian Astrophysical Observation", "SAO 100225"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.83517166),
        dec: Angle.Degrees(+15.37912588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9595 AB"},
        {"Hipparcos Number", "HIP 75090"},
        {"Smithsonian Astrophysical Observation", "SAO 101498"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.16346865),
        dec: Angle.Degrees(+15.38075510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -460.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152972"},
        {"Hipparcos Number", "HIP 82870"},
        {"Smithsonian Astrophysical Observation", "SAO 102482"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.04009839),
        dec: Angle.Degrees(+15.38367208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263483"},
        {"Hipparcos Number", "HIP 32447"},
        {"Smithsonian Astrophysical Observation", "SAO 96091"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58410297),
        dec: Angle.Degrees(+15.38440356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197168"},
        {"Hipparcos Number", "HIP 102106"},
        {"Geneva Identification System", "GEN# +1.00197168"},
        {"Smithsonian Astrophysical Observation", "SAO 106386"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.38667683),
        dec: Angle.Degrees(+15.38586967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12015"},
        {"Smithsonian Astrophysical Observation", "SAO 93008"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.73550637),
        dec: Angle.Degrees(+15.38802220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 895 AB"},
        {"Henry Draper", "HD 6440"},
        {"Hipparcos Number", "HIP 5110"},
        {"Geneva Identification System", "GEN# +1.00006440J"},
        {"Smithsonian Astrophysical Observation", "SAO 92237"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.37462337),
        dec: Angle.Degrees(+15.39053992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199318"},
        {"Hipparcos Number", "HIP 103328"},
        {"Smithsonian Astrophysical Observation", "SAO 106675"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.00839498),
        dec: Angle.Degrees(+15.39194713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155677"},
        {"Hipparcos Number", "HIP 84189"},
        {"Geneva Identification System", "GEN# +1.00155677"},
        {"Smithsonian Astrophysical Observation", "SAO 102650"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.14312988),
        dec: Angle.Degrees(+15.39194852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174105"},
        {"Hipparcos Number", "HIP 92279"},
        {"Smithsonian Astrophysical Observation", "SAO 104118"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.09438352),
        dec: Angle.Degrees(+15.39414510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88962"},
        {"Hipparcos Number", "HIP 50282"},
        {"Smithsonian Astrophysical Observation", "SAO 99030"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.99984625),
        dec: Angle.Degrees(+15.39518847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71662"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.86489251),
        dec: Angle.Degrees(+15.39761519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131266"},
        {"Hipparcos Number", "HIP 72735"},
        {"Geneva Identification System", "GEN# +1.00131266"},
        {"Smithsonian Astrophysical Observation", "SAO 101259"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.05818718),
        dec: Angle.Degrees(+15.39819118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26911"},
        {"Hipparcos Number", "HIP 19877"},
        {"Geneva Identification System", "GEN# +5.20250020"},
        {"Smithsonian Astrophysical Observation", "SAO 93836"},
        {"Wilson Evans Batten Catalogue", "WEB 3798"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.94256020),
        dec: Angle.Degrees(+15.40074874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201118"},
        {"Hipparcos Number", "HIP 104241"},
        {"Geneva Identification System", "GEN# +1.00201118"},
        {"Smithsonian Astrophysical Observation", "SAO 106849"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.79552936),
        dec: Angle.Degrees(+15.40172227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32549"},
        {"Hipparcos Number", "HIP 23607"},
        {"Fundamental Katalog 5th Edition", "FK5 1140"},
        {"Geneva Identification System", "GEN# +1.00032549"},
        {"Renson", "Renson 8280"},
        {"Smithsonian Astrophysical Observation", "SAO 94290"},
        {"Wilson Evans Batten Catalogue", "WEB 4604"},
    },
    visualMagnitude: 4.65,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.14224320),
        dec: Angle.Degrees(+15.40418059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68939"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67508791),
        dec: Angle.Degrees(+15.40644365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15283"},
        {"Geneva Identification System", "GEN# +0.01400545"},
        {"Smithsonian Astrophysical Observation", "SAO 93371"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.29845920),
        dec: Angle.Degrees(+15.40668998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152531"},
        {"Hipparcos Number", "HIP 82615"},
        {"Smithsonian Astrophysical Observation", "SAO 102453"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.33823421),
        dec: Angle.Degrees(+15.40808869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104240",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)07, 10.7100),
        dec: Angle.DegreesMinutesSeconds((int)+15, (int)24, 29.400)
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
    primaryId: "HIP 85452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85452"},
        {"Smithsonian Astrophysical Observation", "SAO 102834"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.94028423),
        dec: Angle.Degrees(+15.41037888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99902"},
        {"Hipparcos Number", "HIP 56080"},
        {"Geneva Identification System", "GEN# +1.00099902"},
        {"Smithsonian Astrophysical Observation", "SAO 99629"},
        {"Wilson Evans Batten Catalogue", "WEB 10069"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.42442712),
        dec: Angle.Degrees(+15.41338550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111396"},
        {"Hipparcos Number", "HIP 62531"},
        {"Geneva Identification System", "GEN# +1.00111396"},
        {"Smithsonian Astrophysical Observation", "SAO 100281"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21425038),
        dec: Angle.Degrees(+15.41436980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139643"},
        {"Hipparcos Number", "HIP 76615"},
        {"Smithsonian Astrophysical Observation", "SAO 101665"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.68724084),
        dec: Angle.Degrees(+15.41450309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86601"},
        {"Smithsonian Astrophysical Observation", "SAO 103031"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.45876511),
        dec: Angle.Degrees(+15.41587240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181227"},
        {"Hipparcos Number", "HIP 94944"},
        {"Geneva Identification System", "GEN# +1.00181227"},
        {"Smithsonian Astrophysical Observation", "SAO 104716"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.80940211),
        dec: Angle.Degrees(+15.41637749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14772"},
        {"Hipparcos Number", "HIP 11134"},
        {"Cincinnati Publication", "Ci 18 305"},
        {"Geneva Identification System", "GEN# +1.00014772"},
        {"Smithsonian Astrophysical Observation", "SAO 92913"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.82096019),
        dec: Angle.Degrees(+15.41656201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14786"},
        {"Hipparcos Number", "HIP 11137"},
        {"Cincinnati Publication", "Ci 18 306"},
        {"Geneva Identification System", "GEN# +1.00014786"},
        {"Smithsonian Astrophysical Observation", "SAO 92915"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.83083587),
        dec: Angle.Degrees(+15.41811489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101180"},
        {"Hipparcos Number", "HIP 56810"},
        {"Smithsonian Astrophysical Observation", "SAO 99710"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.68997218),
        dec: Angle.Degrees(+15.41932330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214609"},
        {"Hipparcos Number", "HIP 111837"},
        {"Smithsonian Astrophysical Observation", "SAO 108070"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.80336671),
        dec: Angle.Degrees(+15.41994360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133351"},
        {"Hipparcos Number", "HIP 73673"},
        {"Geneva Identification System", "GEN# +1.00133351"},
        {"Smithsonian Astrophysical Observation", "SAO 101355"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.89542587),
        dec: Angle.Degrees(+15.42165729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77233",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Chow"},
        {"Aitken", "ADS 9778 A"},
        {"Henry Draper", "HD 141003"},
        {"Hipparcos Number", "HIP 77233"},
        {"Fundamental Katalog 5th Edition", "FK5 583"},
        {"Geneva Identification System", "GEN# +1.00141003A"},
        {"Smithsonian Astrophysical Observation", "SAO 101725"},
        {"Wilson Evans Batten Catalogue", "WEB 13088"},
    },
    visualMagnitude: 3.65,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.54672877),
        dec: Angle.Degrees(+15.42192602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46019"},
        {"Hipparcos Number", "HIP 31098"},
        {"Geneva Identification System", "GEN# +1.00046019"},
        {"Smithsonian Astrophysical Observation", "SAO 95774"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.88867152),
        dec: Angle.Degrees(+15.42225685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54351"},
        {"Hipparcos Number", "HIP 34511"},
        {"Cincinnati Publication", "Ci 18 858"},
        {"Geneva Identification System", "GEN# +1.00054351"},
        {"Smithsonian Astrophysical Observation", "SAO 96559"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.27105147),
        dec: Angle.Degrees(+15.42228551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216965"},
        {"Hipparcos Number", "HIP 113341"},
        {"Geneva Identification System", "GEN# +1.00216965"},
        {"Renson", "Renson 59900"},
        {"Smithsonian Astrophysical Observation", "SAO 108280"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.29738962),
        dec: Angle.Degrees(+15.42369855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168697"},
        {"Hipparcos Number", "HIP 89894"},
        {"Geneva Identification System", "GEN# +1.00168697"},
        {"Smithsonian Astrophysical Observation", "SAO 103628"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.14209038),
        dec: Angle.Degrees(+15.42681220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137471"},
        {"Hipparcos Number", "HIP 75530"},
        {"Fundamental Katalog 5th Edition", "FK5 570"},
        {"Geneva Identification System", "GEN# +1.00137471"},
        {"Smithsonian Astrophysical Observation", "SAO 101545"},
        {"Wilson Evans Batten Catalogue", "WEB 12871"},
    },
    visualMagnitude: 5.16,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.44752151),
        dec: Angle.Degrees(+15.42805438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54879",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Chertan"},
        {"Henry Draper", "HD 97633"},
        {"Hipparcos Number", "HIP 54879"},
        {"Fundamental Katalog 5th Edition", "FK5 423"},
        {"Geneva Identification System", "GEN# +1.00097633"},
        {"Renson", "Renson 28150"},
        {"Smithsonian Astrophysical Observation", "SAO 99512"},
        {"Wilson Evans Batten Catalogue", "WEB 9905"},
    },
    visualMagnitude: 3.33,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.56017036),
        dec: Angle.Degrees(+15.42976310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22522"},
        {"Hipparcos Number", "HIP 16924"},
        {"Geneva Identification System", "GEN# +1.00022522"},
        {"Smithsonian Astrophysical Observation", "SAO 93524"},
        {"Wilson Evans Batten Catalogue", "WEB 3221"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.44924357),
        dec: Angle.Degrees(+15.43062339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142245"},
        {"Hipparcos Number", "HIP 77783"},
        {"Smithsonian Astrophysical Observation", "SAO 101788"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.23464495),
        dec: Angle.Degrees(+15.43075795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148556"},
        {"Hipparcos Number", "HIP 80684"},
        {"Geneva Identification System", "GEN# +1.00148556"},
        {"Smithsonian Astrophysical Observation", "SAO 102191"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.10070404),
        dec: Angle.Degrees(+15.43131883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198918"},
        {"Hipparcos Number", "HIP 103083"},
        {"Fundamental Katalog 5th Edition", "FK5 5839"},
        {"Smithsonian Astrophysical Observation", "SAO 106616"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.29696730),
        dec: Angle.Degrees(+15.43187729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1503 AB"},
        {"Henry Draper", "HD 11487"},
        {"Hipparcos Number", "HIP 8810"},
        {"Smithsonian Astrophysical Observation", "SAO 92678"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.30938477),
        dec: Angle.Degrees(+15.43340274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30809"},
        {"Hipparcos Number", "HIP 22566"},
        {"Geneva Identification System", "GEN# +5.20250143"},
        {"Smithsonian Astrophysical Observation", "SAO 94165"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.84656274),
        dec: Angle.Degrees(+15.43350888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64494"},
        {"Hipparcos Number", "HIP 38638"},
        {"Geneva Identification System", "GEN# +1.00064494"},
        {"Smithsonian Astrophysical Observation", "SAO 97356"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.67505887),
        dec: Angle.Degrees(+15.43542645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103152"},
        {"Hipparcos Number", "HIP 57920"},
        {"Geneva Identification System", "GEN# +1.00103152"},
        {"Smithsonian Astrophysical Observation", "SAO 99840"},
        {"Wilson Evans Batten Catalogue", "WEB 10382"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19253055),
        dec: Angle.Degrees(+15.43647071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192686"},
        {"Hipparcos Number", "HIP 99857"},
        {"Geneva Identification System", "GEN# +1.00192686"},
        {"Renson", "Renson 53760"},
        {"Smithsonian Astrophysical Observation", "SAO 105902"},
        {"Wilson Evans Batten Catalogue", "WEB 17954"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.89034030),
        dec: Angle.Degrees(+15.43691587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52446"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.82463011),
        dec: Angle.Degrees(+15.43980824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211286"},
        {"Hipparcos Number", "HIP 109920"},
        {"Smithsonian Astrophysical Observation", "SAO 107775"},
        {"Wilson Evans Batten Catalogue", "WEB 19733"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.95569059),
        dec: Angle.Degrees(+15.44044855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170173"},
        {"Hipparcos Number", "HIP 90464"},
        {"Smithsonian Astrophysical Observation", "SAO 103736"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.89301739),
        dec: Angle.Degrees(+15.44226310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35362"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.56084038),
        dec: Angle.Degrees(+15.44308952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78634"},
        {"Hipparcos Number", "HIP 44985"},
        {"Smithsonian Astrophysical Observation", "SAO 98398"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.44933405),
        dec: Angle.Degrees(+15.44652531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188543"},
        {"Hipparcos Number", "HIP 98019"},
        {"Fundamental Katalog 5th Edition", "FK5 5758"},
        {"Smithsonian Astrophysical Observation", "SAO 105418"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.78154439),
        dec: Angle.Degrees(+15.44716115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171913"},
        {"Hipparcos Number", "HIP 91247"},
        {"Smithsonian Astrophysical Observation", "SAO 103903"},
        {"Wilson Evans Batten Catalogue", "WEB 15674"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.17548061),
        dec: Angle.Degrees(+15.44803672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41344"},
        {"Hipparcos Number", "HIP 28834"},
        {"Smithsonian Astrophysical Observation", "SAO 95208"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.29506876),
        dec: Angle.Degrees(+15.44911670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116460"},
        {"Hipparcos Number", "HIP 65349"},
        {"Geneva Identification System", "GEN# +1.00116460"},
        {"Smithsonian Astrophysical Observation", "SAO 100545"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.90209119),
        dec: Angle.Degrees(+15.45073551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95366"},
        {"Hipparcos Number", "HIP 53822"},
        {"Geneva Identification System", "GEN# +1.00095366"},
        {"Smithsonian Astrophysical Observation", "SAO 99397"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.17750535),
        dec: Angle.Degrees(+15.45302678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -302.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65080"},
        {"Geneva Identification System", "GEN# +0.01602494"},
        {"Smithsonian Astrophysical Observation", "SAO 100518"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09836040),
        dec: Angle.Degrees(+15.45332577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35522"},
        {"Hipparcos Number", "HIP 25392"},
        {"Smithsonian Astrophysical Observation", "SAO 94539"},
        {"Wilson Evans Batten Catalogue", "WEB 4920"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47648664),
        dec: Angle.Degrees(+15.45387566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153376"},
        {"Hipparcos Number", "HIP 83083"},
        {"Geneva Identification System", "GEN# +1.00153376"},
        {"Smithsonian Astrophysical Observation", "SAO 102505"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.65807327),
        dec: Angle.Degrees(+15.45402056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7460 AB"},
        {"Henry Draper", "HD 83289"},
        {"Hipparcos Number", "HIP 47233"},
        {"Smithsonian Astrophysical Observation", "SAO 98678"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.41170420),
        dec: Angle.Degrees(+15.45852940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70373"},
        {"Hipparcos Number", "HIP 41015"},
        {"Smithsonian Astrophysical Observation", "SAO 97767"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.55632635),
        dec: Angle.Degrees(+15.46098609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247567"},
        {"Hipparcos Number", "HIP 27310"},
        {"Smithsonian Astrophysical Observation", "SAO 94853"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.78318692),
        dec: Angle.Degrees(+15.46351809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106294"},
        {"Hipparcos Number", "HIP 59634"},
        {"Geneva Identification System", "GEN# +1.00106294"},
        {"Smithsonian Astrophysical Observation", "SAO 100000"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.45311130),
        dec: Angle.Degrees(+15.46367421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115040"},
        {"Geneva Identification System", "GEN# +0.01404966"},
        {"Smithsonian Astrophysical Observation", "SAO 108521"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.49322240),
        dec: Angle.Degrees(+15.46376737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213447"},
        {"Hipparcos Number", "HIP 111154"},
        {"Smithsonian Astrophysical Observation", "SAO 107973"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.79115961),
        dec: Angle.Degrees(+15.46634141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91138"},
        {"Smithsonian Astrophysical Observation", "SAO 103880"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.86694299),
        dec: Angle.Degrees(+15.46661059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184567"},
        {"Hipparcos Number", "HIP 96278"},
        {"Smithsonian Astrophysical Observation", "SAO 104989"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.65223543),
        dec: Angle.Degrees(+15.46706713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198200"},
        {"Hipparcos Number", "HIP 102663"},
        {"Smithsonian Astrophysical Observation", "SAO 106512"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.06330211),
        dec: Angle.Degrees(+15.46960011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52782"},
        {"Smithsonian Astrophysical Observation", "SAO 99293"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.87214261),
        dec: Angle.Degrees(+15.47210791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30246"},
        {"Hipparcos Number", "HIP 22203"},
        {"Geneva Identification System", "GEN# +5.20250142"},
        {"Smithsonian Astrophysical Observation", "SAO 94114"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.62639131),
        dec: Angle.Degrees(+15.47211023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116677"},
        {"Smithsonian Astrophysical Observation", "SAO 108744"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.67646360),
        dec: Angle.Degrees(+15.47450378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124000"},
        {"Hipparcos Number", "HIP 69248"},
        {"Smithsonian Astrophysical Observation", "SAO 100893"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.64294756),
        dec: Angle.Degrees(+15.47466506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25203"},
        {"Hipparcos Number", "HIP 18730"},
        {"Geneva Identification System", "GEN# +1.00025203"},
        {"Smithsonian Astrophysical Observation", "SAO 93720"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.18568375),
        dec: Angle.Degrees(+15.47538532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4408"},
        {"Hipparcos Number", "HIP 3632"},
        {"Geneva Identification System", "GEN# +1.00004408"},
        {"Smithsonian Astrophysical Observation", "SAO 92072"},
        {"Wilson Evans Batten Catalogue", "WEB 649"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.63740001),
        dec: Angle.Degrees(+15.47561194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10785"},
        {"Smithsonian Astrophysical Observation", "SAO 92881"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.71965015),
        dec: Angle.Degrees(+15.47592062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94992"},
        {"Hipparcos Number", "HIP 53616"},
        {"Smithsonian Astrophysical Observation", "SAO 99376"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.54261043),
        dec: Angle.Degrees(+15.47739703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189780"},
        {"Hipparcos Number", "HIP 98549"},
        {"Smithsonian Astrophysical Observation", "SAO 105557"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.28796926),
        dec: Angle.Degrees(+15.47995180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48750"},
        {"Hipparcos Number", "HIP 32383"},
        {"Smithsonian Astrophysical Observation", "SAO 96077"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.37706844),
        dec: Angle.Degrees(+15.47999386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223941"},
        {"Hipparcos Number", "HIP 117826"},
        {"Geneva Identification System", "GEN# +1.00223941"},
        {"Smithsonian Astrophysical Observation", "SAO 108892"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.45434544),
        dec: Angle.Degrees(+15.48030102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39793"},
        {"Smithsonian Astrophysical Observation", "SAO 97577"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.97064097),
        dec: Angle.Degrees(+15.48063067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4834"},
        {"Hipparcos Number", "HIP 3931"},
        {"Smithsonian Astrophysical Observation", "SAO 92110"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.61447747),
        dec: Angle.Degrees(+15.48421065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214883"},
        {"Hipparcos Number", "HIP 111995"},
        {"Smithsonian Astrophysical Observation", "SAO 108097"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.27863542),
        dec: Angle.Degrees(+15.48550377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8796 AB"},
        {"Henry Draper", "HD 114131"},
        {"Hipparcos Number", "HIP 64116"},
        {"Geneva Identification System", "GEN# +1.00114131J"},
        {"Smithsonian Astrophysical Observation", "SAO 100432"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.11026322),
        dec: Angle.Degrees(+15.49163919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46926"},
        {"Smithsonian Astrophysical Observation", "SAO 98643"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.46868179),
        dec: Angle.Degrees(+15.49221362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68551"},
        {"Wilson Evans Batten Catalogue", "WEB 12006"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.49451451),
        dec: Angle.Degrees(+15.49478862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162365"},
        {"Hipparcos Number", "HIP 87287"},
        {"Fundamental Katalog 5th Edition", "FK5 5568"},
        {"Geneva Identification System", "GEN# +1.00162365"},
        {"Smithsonian Astrophysical Observation", "SAO 103141"},
        {"Wilson Evans Batten Catalogue", "WEB 14723"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.53170995),
        dec: Angle.Degrees(+15.49533450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12455"},
        {"Hipparcos Number", "HIP 9522"},
        {"Smithsonian Astrophysical Observation", "SAO 92762"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.62113426),
        dec: Angle.Degrees(+15.49540520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18043"},
        {"Hipparcos Number", "HIP 13533"},
        {"Geneva Identification System", "GEN# +1.00018043"},
        {"Smithsonian Astrophysical Observation", "SAO 93173"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.57459348),
        dec: Angle.Degrees(+15.49553915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7905"},
        {"Hipparcos Number", "HIP 6143"},
        {"Smithsonian Astrophysical Observation", "SAO 92362"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.71928399),
        dec: Angle.Degrees(+15.49665642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149822"},
        {"Hipparcos Number", "HIP 81337"},
        {"Geneva Identification System", "GEN# +1.00149822"},
        {"Renson", "Renson 42390"},
        {"Smithsonian Astrophysical Observation", "SAO 102271"},
        {"Wilson Evans Batten Catalogue", "WEB 13747"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.17895487),
        dec: Angle.Degrees(+15.49752881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254241"},
        {"Hipparcos Number", "HIP 29779"},
        {"Smithsonian Astrophysical Observation", "SAO 95466"},
        {"Wilson Evans Batten Catalogue", "WEB 5880"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.05421736),
        dec: Angle.Degrees(+15.49779456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113038"},
        {"Hipparcos Number", "HIP 63508"},
        {"Smithsonian Astrophysical Observation", "SAO 100369"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.19301995),
        dec: Angle.Degrees(+15.49827354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126752"},
        {"Hipparcos Number", "HIP 70655"},
        {"Smithsonian Astrophysical Observation", "SAO 101029"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.76876952),
        dec: Angle.Degrees(+15.49858902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25788"},
        {"Hipparcos Number", "HIP 19120"},
        {"Geneva Identification System", "GEN# +1.00025788"},
        {"Smithsonian Astrophysical Observation", "SAO 93757"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.48054659),
        dec: Angle.Degrees(+15.49908712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285876"},
        {"Hipparcos Number", "HIP 21138"},
        {"Geneva Identification System", "GEN# +5.20251645"},
        {"Geneva Identification System 2", "GEN# +5.20250191"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.96836842),
        dec: Angle.Degrees(+15.49954119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13344 A"},
        {"Henry Draper", "HD 190658"},
        {"Hipparcos Number", "HIP 98954"},
        {"Geneva Identification System", "GEN# +1.00190658"},
        {"Smithsonian Astrophysical Observation", "SAO 105663"},
        {"Wilson Evans Batten Catalogue", "WEB 17565"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.36052502),
        dec: Angle.Degrees(+15.50036919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28992"},
        {"Hipparcos Number", "HIP 21317"},
        {"Geneva Identification System", "GEN# +5.20250097"},
        {"Smithsonian Astrophysical Observation", "SAO 94014"},
        {"Wilson Evans Batten Catalogue", "WEB 4099"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.64686969),
        dec: Angle.Degrees(+15.50468788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23824"},
        {"Hipparcos Number", "HIP 17804"},
        {"Smithsonian Astrophysical Observation", "SAO 93613"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16207533),
        dec: Angle.Degrees(+15.50537920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27934",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4495 A"},
        {"Henry Draper", "HD 39661"},
        {"Hipparcos Number", "HIP 27934"},
        {"Celescope Catalog", "CEL 1027"},
        {"Geneva Identification System", "GEN# +1.00039661J"},
        {"Smithsonian Astrophysical Observation", "SAO 94980"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.65598710),
        dec: Angle.Degrees(+15.50772140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17414"},
        {"Hipparcos Number", "HIP 13069"},
        {"Smithsonian Astrophysical Observation", "SAO 93113"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.99754697),
        dec: Angle.Degrees(+15.50808571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178332"},
        {"Hipparcos Number", "HIP 93940"},
        {"Geneva Identification System", "GEN# +1.00178332"},
        {"Smithsonian Astrophysical Observation", "SAO 104504"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.91573535),
        dec: Angle.Degrees(+15.50894935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29715"},
        {"Hipparcos Number", "HIP 21820"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.33231957),
        dec: Angle.Degrees(+15.51193778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173922"},
        {"Hipparcos Number", "HIP 92203"},
        {"Smithsonian Astrophysical Observation", "SAO 104103"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.87204042),
        dec: Angle.Degrees(+15.51271597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54298"},
        {"Hipparcos Number", "HIP 34496"},
        {"Smithsonian Astrophysical Observation", "SAO 96552"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.21672021),
        dec: Angle.Degrees(+15.51360733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200547"},
        {"Hipparcos Number", "HIP 103944"},
        {"Smithsonian Astrophysical Observation", "SAO 106808"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90859465),
        dec: Angle.Degrees(+15.51517483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68154"},
        {"Smithsonian Astrophysical Observation", "SAO 100789"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.29238679),
        dec: Angle.Degrees(+15.51683677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58050"},
        {"Hipparcos Number", "HIP 35933"},
        {"Geneva Identification System", "GEN# +1.00058050"},
        {"Smithsonian Astrophysical Observation", "SAO 96866"},
        {"Wilson Evans Batten Catalogue", "WEB 7156"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.11520374),
        dec: Angle.Degrees(+15.51719894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14597"},
        {"Hipparcos Number", "HIP 11007"},
        {"Smithsonian Astrophysical Observation", "SAO 92900"},
        {"Wilson Evans Batten Catalogue", "WEB 2311"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44635954),
        dec: Angle.Degrees(+15.51918720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63018"},
        {"Hipparcos Number", "HIP 38005"},
        {"Geneva Identification System", "GEN# +1.00063018"},
        {"Smithsonian Astrophysical Observation", "SAO 97243"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.84367295),
        dec: Angle.Degrees(+15.52081565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54100"},
        {"Hipparcos Number", "HIP 34426"},
        {"Cincinnati Publication", "Ci 18 856"},
        {"Geneva Identification System", "GEN# +1.00054100"},
        {"Smithsonian Astrophysical Observation", "SAO 96530"},
        {"Wilson Evans Batten Catalogue", "WEB 6897"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.05006549),
        dec: Angle.Degrees(+15.52136431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42621"},
        {"Smithsonian Astrophysical Observation", "SAO 98039"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.28699978),
        dec: Angle.Degrees(+15.52191604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54553"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.44755528),
        dec: Angle.Degrees(+15.52342107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5062 AB"},
        {"Henry Draper", "HD 45180"},
        {"Hipparcos Number", "HIP 30663"},
        {"Celescope Catalog", "CEL 1235"},
        {"Geneva Identification System", "GEN# +1.00045180J"},
        {"Smithsonian Astrophysical Observation", "SAO 95684"},
        {"Wilson Evans Batten Catalogue", "WEB 6114"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.65722547),
        dec: Angle.Degrees(+15.52370180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14887"},
        {"Hipparcos Number", "HIP 11223"},
        {"Geneva Identification System", "GEN# +1.00014887"},
        {"Smithsonian Astrophysical Observation", "SAO 92924"},
        {"Wilson Evans Batten Catalogue", "WEB 2352"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.11343708),
        dec: Angle.Degrees(+15.52492309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146873"},
        {"Hipparcos Number", "HIP 79854"},
        {"Smithsonian Astrophysical Observation", "SAO 102068"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.50851560),
        dec: Angle.Degrees(+15.52561375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141040"},
        {"Hipparcos Number", "HIP 77249"},
        {"Smithsonian Astrophysical Observation", "SAO 101729"},
        {"Wilson Evans Batten Catalogue", "WEB 13089"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60001695),
        dec: Angle.Degrees(+15.52668610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15109"},
        {"Smithsonian Astrophysical Observation", "SAO 93355"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.72114959),
        dec: Angle.Degrees(+15.52727955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58900"},
        {"Hipparcos Number", "HIP 36278"},
        {"Smithsonian Astrophysical Observation", "SAO 96922"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.03046315),
        dec: Angle.Degrees(+15.52755817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84661"},
        {"Hipparcos Number", "HIP 48006"},
        {"Smithsonian Astrophysical Observation", "SAO 98764"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.78581733),
        dec: Angle.Degrees(+15.52841396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224931"},
        {"Hipparcos Number", "HIP 148"},
        {"Geneva Identification System", "GEN# +1.00224931"},
        {"Smithsonian Astrophysical Observation", "SAO 108969"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.47879268),
        dec: Angle.Degrees(+15.52852839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54046"},
        {"Hipparcos Number", "HIP 34407"},
        {"Cincinnati Publication", "Ci 18 855"},
        {"Geneva Identification System", "GEN# +1.00054046"},
        {"Smithsonian Astrophysical Observation", "SAO 96526"},
        {"Wilson Evans Batten Catalogue", "WEB 6893"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.00113728),
        dec: Angle.Degrees(+15.52909801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70865"},
        {"Cincinnati Publication", "Ci 20 863"},
        {"Geneva Identification System", "GEN# +0.01602658"},
        {"Wilson Evans Batten Catalogue", "WEB 12271"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.37640041),
        dec: Angle.Degrees(+15.52948103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1053.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1300.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98882"},
        {"Hipparcos Number", "HIP 55567"},
        {"Geneva Identification System", "GEN# +1.00098882"},
        {"Smithsonian Astrophysical Observation", "SAO 99580"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.72379873),
        dec: Angle.Degrees(+15.53286241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50750",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 27"},
        {"Hipparcos Number", "HIP 50750"},
        {"Geneva Identification System", "GEN# +0.01602114"},
    },
    visualMagnitude: 9.98,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.44615173),
        dec: Angle.Degrees(+15.53432292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52037"},
        {"Hipparcos Number", "HIP 33718"},
        {"Smithsonian Astrophysical Observation", "SAO 96365"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.07532192),
        dec: Angle.Degrees(+15.53528821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71794"},
        {"Hipparcos Number", "HIP 41686"},
        {"Geneva Identification System", "GEN# +1.00071794"},
        {"Smithsonian Astrophysical Observation", "SAO 97855"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.46518919),
        dec: Angle.Degrees(+15.53589007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118002"},
        {"Hipparcos Number", "HIP 66184"},
        {"Geneva Identification System", "GEN# +1.00118002"},
        {"Smithsonian Astrophysical Observation", "SAO 100620"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.47524803),
        dec: Angle.Degrees(+15.53624646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16568"},
        {"Smithsonian Astrophysical Observation", "SAO 93486"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.33282056),
        dec: Angle.Degrees(+15.53700594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24771"},
        {"Hipparcos Number", "HIP 18474"},
        {"Geneva Identification System", "GEN# +1.00024771"},
        {"Smithsonian Astrophysical Observation", "SAO 93683"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.22127744),
        dec: Angle.Degrees(+15.53701883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149614"},
        {"Hipparcos Number", "HIP 81224"},
        {"Smithsonian Astrophysical Observation", "SAO 102256"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.84894401),
        dec: Angle.Degrees(+15.53877586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95156"},
        {"Hipparcos Number", "HIP 53710"},
        {"Smithsonian Astrophysical Observation", "SAO 99388"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.83762098),
        dec: Angle.Degrees(+15.54043586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107415"},
        {"Hipparcos Number", "HIP 60210"},
        {"Geneva Identification System", "GEN# +1.00107415"},
        {"Smithsonian Astrophysical Observation", "SAO 100054"},
        {"Wilson Evans Batten Catalogue", "WEB 10707"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.20311213),
        dec: Angle.Degrees(+15.54096865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135724"},
        {"Hipparcos Number", "HIP 74713"},
        {"Geneva Identification System", "GEN# +1.00135724"},
        {"Smithsonian Astrophysical Observation", "SAO 101466"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.03492254),
        dec: Angle.Degrees(+15.54150883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146961"},
        {"Hipparcos Number", "HIP 79898"},
        {"Smithsonian Astrophysical Observation", "SAO 102073"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.62117605),
        dec: Angle.Degrees(+15.54162245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108157"},
        {"Smithsonian Astrophysical Observation", "SAO 107498"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68792989),
        dec: Angle.Degrees(+15.54196415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41593"},
        {"Hipparcos Number", "HIP 28954"},
        {"Cincinnati Publication", "Ci 18 763"},
        {"Geneva Identification System", "GEN# +1.00041593"},
        {"Smithsonian Astrophysical Observation", "SAO 95235"},
        {"Wilson Evans Batten Catalogue", "WEB 5668"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66896343),
        dec: Angle.Degrees(+15.54235694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218565"},
        {"Hipparcos Number", "HIP 114300"},
        {"Smithsonian Astrophysical Observation", "SAO 108428"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.22979328),
        dec: Angle.Degrees(+15.54277889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193555"},
        {"Hipparcos Number", "HIP 100269"},
        {"Geneva Identification System", "GEN# +1.00193555"},
        {"Smithsonian Astrophysical Observation", "SAO 105984"},
        {"Wilson Evans Batten Catalogue", "WEB 18081"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.06389100),
        dec: Angle.Degrees(+15.54281115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193389"},
        {"Hipparcos Number", "HIP 100212"},
        {"Geneva Identification System", "GEN# +1.00193389"},
        {"Smithsonian Astrophysical Observation", "SAO 105962"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.88122307),
        dec: Angle.Degrees(+15.54508993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211800"},
        {"Hipparcos Number", "HIP 110204"},
        {"Smithsonian Astrophysical Observation", "SAO 107829"},
        {"Wilson Evans Batten Catalogue", "WEB 19778"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.84876220),
        dec: Angle.Degrees(+15.54579013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63633",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8747 AB"},
        {"Henry Draper", "HD 113272"},
        {"Hipparcos Number", "HIP 63633"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.62749858),
        dec: Angle.Degrees(+15.54610453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78407"},
        {"Smithsonian Astrophysical Observation", "SAO 101867"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.09553360),
        dec: Angle.Degrees(+15.54703329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113495"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.77442984),
        dec: Angle.Degrees(+15.54815375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122038"},
        {"Hipparcos Number", "HIP 68312"},
        {"Smithsonian Astrophysical Observation", "SAO 100806"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.75170870),
        dec: Angle.Degrees(+15.54869815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157895"},
        {"Hipparcos Number", "HIP 85271"},
        {"Smithsonian Astrophysical Observation", "SAO 102813"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.35455094),
        dec: Angle.Degrees(+15.54911015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2602 A"},
        {"Henry Draper", "HD 21963"},
        {"Henry Draper 2", "HD 21963A"},
        {"Hipparcos Number", "HIP 16532"},
        {"Smithsonian Astrophysical Observation", "SAO 93483"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.22343618),
        dec: Angle.Degrees(+15.54966726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182866"},
        {"Hipparcos Number", "HIP 95559"},
        {"Geneva Identification System", "GEN# +1.00182866"},
        {"Smithsonian Astrophysical Observation", "SAO 104830"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.55092901),
        dec: Angle.Degrees(+15.55189899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95542",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12435 AB"},
        {"Henry Draper", "HD 182830"},
        {"Hipparcos Number", "HIP 95542"},
        {"Geneva Identification System", "GEN# +1.00182830J"},
        {"Smithsonian Astrophysical Observation", "SAO 104826"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.50362155),
        dec: Angle.Degrees(+15.55684780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48467"},
        {"Smithsonian Astrophysical Observation", "SAO 98823"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.23727326),
        dec: Angle.Degrees(+15.55952935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 831"},
        {"Hipparcos Number", "HIP 1027"},
        {"Geneva Identification System", "GEN# +1.00000831"},
        {"Smithsonian Astrophysical Observation", "SAO 91774"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.20212287),
        dec: Angle.Degrees(+15.56037208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42421"},
        {"Hipparcos Number", "HIP 29344"},
        {"Geneva Identification System", "GEN# +1.00042421"},
        {"Smithsonian Astrophysical Observation", "SAO 95347"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80482048),
        dec: Angle.Degrees(+15.56196322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2113"},
        {"Hipparcos Number", "HIP 2015"},
        {"Smithsonian Astrophysical Observation", "SAO 91887"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.38849201),
        dec: Angle.Degrees(+15.56204900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140594"},
        {"Hipparcos Number", "HIP 77050"},
        {"Smithsonian Astrophysical Observation", "SAO 101704"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.00355727),
        dec: Angle.Degrees(+15.56223461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124928"},
        {"Hipparcos Number", "HIP 69714"},
        {"Smithsonian Astrophysical Observation", "SAO 100950"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.04335511),
        dec: Angle.Degrees(+15.56372382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115942"},
        {"Hipparcos Number", "HIP 65061"},
        {"Geneva Identification System", "GEN# +1.00115942"},
        {"Smithsonian Astrophysical Observation", "SAO 100516"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.03910993),
        dec: Angle.Degrees(+15.56405093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116784"},
        {"Hipparcos Number", "HIP 65509"},
        {"Geneva Identification System", "GEN# +1.00116784"},
        {"Smithsonian Astrophysical Observation", "SAO 100561"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.41703425),
        dec: Angle.Degrees(+15.56406652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7053"},
        {"Cincinnati Publication", "Ci 20 106"},
        {"Wilson Evans Batten Catalogue", "WEB 1524"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.72586161),
        dec: Angle.Degrees(+15.56511519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 387.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48151"},
        {"Smithsonian Astrophysical Observation", "SAO 98780"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.23124661),
        dec: Angle.Degrees(+15.56608408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63141"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.07241465),
        dec: Angle.Degrees(+15.57247568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14505 AB"},
        {"Henry Draper", "HD 199839"},
        {"Hipparcos Number", "HIP 103584"},
        {"Smithsonian Astrophysical Observation", "SAO 106732"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.81854276),
        dec: Angle.Degrees(+15.57270852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119516"},
        {"Hipparcos Number", "HIP 66959"},
        {"Geneva Identification System", "GEN# +1.00119516"},
        {"Smithsonian Astrophysical Observation", "SAO 100675"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.86148087),
        dec: Angle.Degrees(+15.57533325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165626"},
        {"Hipparcos Number", "HIP 88689"},
        {"Geneva Identification System", "GEN# +1.00165626"},
        {"Smithsonian Astrophysical Observation", "SAO 103383"},
        {"Wilson Evans Batten Catalogue", "WEB 15026"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.58401635),
        dec: Angle.Degrees(+15.57586331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25716"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.36278367),
        dec: Angle.Degrees(+15.57760123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17009"},
        {"Hipparcos Number", "HIP 12763"},
        {"Smithsonian Astrophysical Observation", "SAO 93079"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.00279359),
        dec: Angle.Degrees(+15.57916648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76582"},
        {"Hipparcos Number", "HIP 44001"},
        {"Geneva Identification System", "GEN# +1.00076582"},
        {"Smithsonian Astrophysical Observation", "SAO 98250"},
        {"Wilson Evans Batten Catalogue", "WEB 8458"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.39651273),
        dec: Angle.Degrees(+15.58123453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205240"},
        {"Hipparcos Number", "HIP 106451"},
        {"Smithsonian Astrophysical Observation", "SAO 107231"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.41039307),
        dec: Angle.Degrees(+15.58224820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61837"},
        {"Hipparcos Number", "HIP 37499"},
        {"Smithsonian Astrophysical Observation", "SAO 97150"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44653054),
        dec: Angle.Degrees(+15.58272398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36667"},
        {"Hipparcos Number", "HIP 26100"},
        {"Geneva Identification System", "GEN# +1.00036667"},
        {"Smithsonian Astrophysical Observation", "SAO 94653"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.50009064),
        dec: Angle.Degrees(+15.58461475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24378"},
        {"Hipparcos Number", "HIP 18176"},
        {"Smithsonian Astrophysical Observation", "SAO 93652"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.30798121),
        dec: Angle.Degrees(+15.58486814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78771"},
        {"Hipparcos Number", "HIP 45043"},
        {"Geneva Identification System", "GEN# +1.00078771"},
        {"Smithsonian Astrophysical Observation", "SAO 98412"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.61547570),
        dec: Angle.Degrees(+15.58679162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72523"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.42178448),
        dec: Angle.Degrees(+15.58685464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28205"},
        {"Hipparcos Number", "HIP 20815"},
        {"Celescope Catalog", "CEL 403"},
        {"Geneva Identification System", "GEN# +5.20250065"},
        {"Smithsonian Astrophysical Observation", "SAO 93944"},
        {"Wilson Evans Batten Catalogue", "WEB 3993"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.89928112),
        dec: Angle.Degrees(+15.58924926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202017"},
        {"Hipparcos Number", "HIP 104729"},
        {"Geneva Identification System", "GEN# +1.00202017"},
        {"Smithsonian Astrophysical Observation", "SAO 106921"},
        {"Wilson Evans Batten Catalogue", "WEB 19046"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22457254),
        dec: Angle.Degrees(+15.58954041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12997"},
        {"Hipparcos Number", "HIP 9912"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.89360662),
        dec: Angle.Degrees(+15.58993180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20086"},
        {"Hipparcos Number", "HIP 15064"},
        {"Smithsonian Astrophysical Observation", "SAO 93350"},
        {"Wilson Evans Batten Catalogue", "WEB 2900"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.53492821),
        dec: Angle.Degrees(+15.59044770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111163"},
        {"Hipparcos Number", "HIP 62388"},
        {"Geneva Identification System", "GEN# +1.00111163"},
        {"Smithsonian Astrophysical Observation", "SAO 100259"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.79406973),
        dec: Angle.Degrees(+15.59171041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190067"},
        {"Hipparcos Number", "HIP 98677"},
        {"Cincinnati Publication", "Ci 20 1183"},
        {"Geneva Identification System", "GEN# +1.00190067"},
        {"Smithsonian Astrophysical Observation", "SAO 105581"},
        {"Wilson Evans Batten Catalogue", "WEB 17466"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.64271983),
        dec: Angle.Degrees(+15.59348989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -582.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8782"},
        {"Smithsonian Astrophysical Observation", "SAO 92674"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.23943561),
        dec: Angle.Degrees(+15.59712294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33276"},
        {"Hipparcos Number", "HIP 24010"},
        {"Geneva Identification System", "GEN# +1.00033276"},
        {"Smithsonian Astrophysical Observation", "SAO 94359"},
        {"Wilson Evans Batten Catalogue", "WEB 4681"},
    },
    visualMagnitude: 4.81,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.42483084),
        dec: Angle.Degrees(+15.59727157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55245"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.70850536),
        dec: Angle.Degrees(+15.59760069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88031"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.71821035),
        dec: Angle.Degrees(+15.59836349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64188"},
        {"Hipparcos Number", "HIP 38517"},
        {"Smithsonian Astrophysical Observation", "SAO 97332"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.31662959),
        dec: Angle.Degrees(+15.59905844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15386"},
        {"Hipparcos Number", "HIP 11560"},
        {"Smithsonian Astrophysical Observation", "SAO 92970"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.23072592),
        dec: Angle.Degrees(+15.60014467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67715"},
        {"Geneva Identification System", "GEN# +0.01602572"},
        {"Smithsonian Astrophysical Observation", "SAO 100746"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.07685567),
        dec: Angle.Degrees(+15.60236083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219738"},
        {"Hipparcos Number", "HIP 115053"},
        {"Geneva Identification System", "GEN# +1.00219738"},
        {"Smithsonian Astrophysical Observation", "SAO 108526"},
        {"Wilson Evans Batten Catalogue", "WEB 20384"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.53722276),
        dec: Angle.Degrees(+15.60354356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15455 AB"},
        {"Hipparcos Number", "HIP 108255"},
        {"Cincinnati Publication", "Ci 18 2853"},
        {"Smithsonian Astrophysical Observation", "SAO 107515"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.97249167),
        dec: Angle.Degrees(+15.60550721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10528 AB"},
        {"Henry Draper", "HD 157741"},
        {"Hipparcos Number", "HIP 85187"},
        {"Geneva Identification System", "GEN# +1.00157741J"},
        {"Smithsonian Astrophysical Observation", "SAO 102806"},
        {"Wilson Evans Batten Catalogue", "WEB 14386"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.14081507),
        dec: Angle.Degrees(+15.60602165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207594"},
        {"Hipparcos Number", "HIP 107753"},
        {"Smithsonian Astrophysical Observation", "SAO 107418"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.43354735),
        dec: Angle.Degrees(+15.60844017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90592"},
        {"Smithsonian Astrophysical Observation", "SAO 103767"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.29528400),
        dec: Angle.Degrees(+15.60844021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224371"},
        {"Hipparcos Number", "HIP 118087"},
        {"Smithsonian Astrophysical Observation", "SAO 108925"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.31027677),
        dec: Angle.Degrees(+15.60993742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184741"},
        {"Hipparcos Number", "HIP 96353"},
        {"Smithsonian Astrophysical Observation", "SAO 105014"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.86342684),
        dec: Angle.Degrees(+15.61056859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132506"},
        {"Hipparcos Number", "HIP 73325"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.76124544),
        dec: Angle.Degrees(+15.61383543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107907"},
        {"Hipparcos Number", "HIP 60478"},
        {"Geneva Identification System", "GEN# +1.00107907"},
        {"Smithsonian Astrophysical Observation", "SAO 100078"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.97766702),
        dec: Angle.Degrees(+15.61776823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204070"},
        {"Hipparcos Number", "HIP 105810"},
        {"Smithsonian Astrophysical Observation", "SAO 107129"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.44329381),
        dec: Angle.Degrees(+15.61777012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28052"},
        {"Hipparcos Number", "HIP 20713"},
        {"Celescope Catalog", "CEL 400"},
        {"Geneva Identification System", "GEN# +5.20250141"},
        {"Smithsonian Astrophysical Observation", "SAO 93932"},
        {"Wilson Evans Batten Catalogue", "WEB 3972"},
    },
    visualMagnitude: 4.48,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.58613217),
        dec: Angle.Degrees(+15.61834620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37125"},
        {"Hipparcos Number", "HIP 26359"},
        {"Smithsonian Astrophysical Observation", "SAO 94698"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.20519413),
        dec: Angle.Degrees(+15.61837811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108548"},
        {"Hipparcos Number", "HIP 60836"},
        {"Geneva Identification System", "GEN# +1.00108548"},
        {"Smithsonian Astrophysical Observation", "SAO 100112"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.04491611),
        dec: Angle.Degrees(+15.61848965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10261"},
        {"Hipparcos Number", "HIP 7830"},
        {"Smithsonian Astrophysical Observation", "SAO 92569"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.18359700),
        dec: Angle.Degrees(+15.61951818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99503"},
        {"Smithsonian Astrophysical Observation", "SAO 105807"},
        {"Wilson Evans Batten Catalogue", "WEB 17796"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.90610447),
        dec: Angle.Degrees(+15.62071888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123845"},
        {"Hipparcos Number", "HIP 69178"},
        {"Geneva Identification System", "GEN# +1.00123845"},
        {"Smithsonian Astrophysical Observation", "SAO 100882"},
        {"Wilson Evans Batten Catalogue", "WEB 12074"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.40487983),
        dec: Angle.Degrees(+15.62170325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61642"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.54541242),
        dec: Angle.Degrees(+15.62312168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152654"},
        {"Hipparcos Number", "HIP 82692"},
        {"Geneva Identification System", "GEN# +1.00152654"},
        {"Smithsonian Astrophysical Observation", "SAO 102461"},
        {"Wilson Evans Batten Catalogue", "WEB 13970"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.54202259),
        dec: Angle.Degrees(+15.62348142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138557"},
        {"Hipparcos Number", "HIP 76088"},
        {"Geneva Identification System", "GEN# +1.00138557"},
        {"Smithsonian Astrophysical Observation", "SAO 101602"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.09846546),
        dec: Angle.Degrees(+15.62391901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265579"},
        {"Hipparcos Number", "HIP 33039"},
        {"Smithsonian Astrophysical Observation", "SAO 96227"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24898955),
        dec: Angle.Degrees(+15.62504339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16627"},
        {"Smithsonian Astrophysical Observation", "SAO 93493"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.48472465),
        dec: Angle.Degrees(+15.62569422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26399"},
        {"Hipparcos Number", "HIP 19548"},
        {"Smithsonian Astrophysical Observation", "SAO 93806"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.79374698),
        dec: Angle.Degrees(+15.62625776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168960"},
        {"Hipparcos Number", "HIP 90005"},
        {"Geneva Identification System", "GEN# +1.00168960"},
        {"Smithsonian Astrophysical Observation", "SAO 103642"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.46005652),
        dec: Angle.Degrees(+15.62640868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20205",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Prima Hyadum"},
        {"Henry Draper", "HD 27371"},
        {"Hipparcos Number", "HIP 20205"},
        {"Fundamental Katalog 5th Edition", "FK5 159"},
        {"Geneva Identification System", "GEN# +5.20250028"},
        {"Smithsonian Astrophysical Observation", "SAO 93868"},
        {"Wilson Evans Batten Catalogue", "WEB 3852"},
    },
    visualMagnitude: 3.65,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94805793),
        dec: Angle.Degrees(+15.62770031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24886"},
        {"Hipparcos Number", "HIP 18542"},
        {"Geneva Identification System", "GEN# +1.00024886"},
        {"Smithsonian Astrophysical Observation", "SAO 93692"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.49686773),
        dec: Angle.Degrees(+15.62824052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34080"},
        {"Hipparcos Number", "HIP 24508"},
        {"Geneva Identification System", "GEN# +1.00034080"},
        {"Smithsonian Astrophysical Observation", "SAO 94419"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.85745173),
        dec: Angle.Degrees(+15.63013229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111688"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.37943292),
        dec: Angle.Degrees(+15.63018940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173418"},
        {"Hipparcos Number", "HIP 91955"},
        {"Smithsonian Astrophysical Observation", "SAO 104050"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.16115358),
        dec: Angle.Degrees(+15.63318999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71232"},
        {"Smithsonian Astrophysical Observation", "SAO 101080"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.50362049),
        dec: Angle.Degrees(+15.63354105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109553"},
        {"Hipparcos Number", "HIP 61450"},
        {"Geneva Identification System", "GEN# +1.00109553"},
        {"Smithsonian Astrophysical Observation", "SAO 100163"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.88834707),
        dec: Angle.Degrees(+15.63648041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34811"},
        {"Hipparcos Number", "HIP 24958"},
        {"Geneva Identification System", "GEN# +1.00034811"},
        {"Smithsonian Astrophysical Observation", "SAO 94477"},
        {"Wilson Evans Batten Catalogue", "WEB 4834"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.18018707),
        dec: Angle.Degrees(+15.63693507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28485"},
        {"Hipparcos Number", "HIP 20995"},
        {"Celescope Catalog", "CEL 415"},
        {"Smithsonian Astrophysical Observation", "SAO 93970"},
        {"Wilson Evans Batten Catalogue", "WEB 4038"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.53555351),
        dec: Angle.Degrees(+15.63789864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110880"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.96034799),
        dec: Angle.Degrees(+15.63824608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36820"},
        {"Hipparcos Number", "HIP 26202"},
        {"Celescope Catalog", "CEL 807"},
        {"Smithsonian Astrophysical Observation", "SAO 94665"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.76952912),
        dec: Angle.Degrees(+15.63906464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60081"},
        {"Hipparcos Number", "HIP 36739"},
        {"Smithsonian Astrophysical Observation", "SAO 97012"},
        {"Wilson Evans Batten Catalogue", "WEB 7302"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.35265917),
        dec: Angle.Degrees(+15.63914844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16748"},
        {"Hipparcos Number", "HIP 12553"},
        {"Smithsonian Astrophysical Observation", "SAO 93055"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37043877),
        dec: Angle.Degrees(+15.64158627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153063"},
        {"Hipparcos Number", "HIP 82915"},
        {"Geneva Identification System", "GEN# +1.00153063"},
        {"Smithsonian Astrophysical Observation", "SAO 102489"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.16306451),
        dec: Angle.Degrees(+15.64280827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197039"},
        {"Hipparcos Number", "HIP 102029"},
        {"Geneva Identification System", "GEN# +1.00197039"},
        {"Smithsonian Astrophysical Observation", "SAO 106369"},
        {"Wilson Evans Batten Catalogue", "WEB 18447"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.14689003),
        dec: Angle.Degrees(+15.64313657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109336"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.25003273),
        dec: Angle.Degrees(+15.64316083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103578"},
        {"Hipparcos Number", "HIP 58159"},
        {"Fundamental Katalog 5th Edition", "FK5 1308"},
        {"Geneva Identification System", "GEN# +1.00103578"},
        {"Renson", "Renson 29860"},
        {"Smithsonian Astrophysical Observation", "SAO 99869"},
        {"Wilson Evans Batten Catalogue", "WEB 10410"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.91886481),
        dec: Angle.Degrees(+15.64680922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165417"},
        {"Hipparcos Number", "HIP 88590"},
        {"Smithsonian Astrophysical Observation", "SAO 103365"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.32764497),
        dec: Angle.Degrees(+15.64722875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82540"},
        {"Geneva Identification System", "GEN# +0.01503068"},
        {"Smithsonian Astrophysical Observation", "SAO 102440"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.07431638),
        dec: Angle.Degrees(+15.64898392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223167"},
        {"Hipparcos Number", "HIP 117306"},
        {"Smithsonian Astrophysical Observation", "SAO 108833"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.78534797),
        dec: Angle.Degrees(+15.65091492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212186"},
        {"Hipparcos Number", "HIP 110434"},
        {"Geneva Identification System", "GEN# +1.00212186"},
        {"Smithsonian Astrophysical Observation", "SAO 107860"},
        {"Wilson Evans Batten Catalogue", "WEB 19804"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.52168318),
        dec: Angle.Degrees(+15.65149052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150830"},
        {"Hipparcos Number", "HIP 81837"},
        {"Smithsonian Astrophysical Observation", "SAO 102339"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.73766097),
        dec: Angle.Degrees(+15.65434340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169491"},
        {"Hipparcos Number", "HIP 90205"},
        {"Geneva Identification System", "GEN# +1.00169491"},
        {"Smithsonian Astrophysical Observation", "SAO 103679"},
        {"Wilson Evans Batten Catalogue", "WEB 15430"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.09391203),
        dec: Angle.Degrees(+15.65541942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5433"},
        {"Hipparcos Number", "HIP 4387"},
        {"Smithsonian Astrophysical Observation", "SAO 92160"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.05604418),
        dec: Angle.Degrees(+15.65625615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20329"},
        {"Hipparcos Number", "HIP 15249"},
        {"Geneva Identification System", "GEN# +1.00020329"},
        {"Smithsonian Astrophysical Observation", "SAO 93369"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.17734210),
        dec: Angle.Degrees(+15.65771754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15525"},
        {"Smithsonian Astrophysical Observation", "SAO 93390"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.01048592),
        dec: Angle.Degrees(+15.65790859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201196"},
        {"Hipparcos Number", "HIP 104281"},
        {"Fundamental Katalog 5th Edition", "FK5 3689"},
        {"Geneva Identification System", "GEN# +1.00201196"},
        {"Smithsonian Astrophysical Observation", "SAO 106853"},
        {"Wilson Evans Batten Catalogue", "WEB 18994"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.89005877),
        dec: Angle.Degrees(+15.65879687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91476",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11547 AB"},
        {"Hipparcos Number", "HIP 91476"},
        {"Smithsonian Astrophysical Observation", "SAO 103956"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85624780),
        dec: Angle.Degrees(+15.65915887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58713"},
        {"Hipparcos Number", "HIP 36209"},
        {"Geneva Identification System", "GEN# +1.00058713"},
        {"Smithsonian Astrophysical Observation", "SAO 96912"},
        {"Wilson Evans Batten Catalogue", "WEB 7210"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.85070276),
        dec: Angle.Degrees(+15.65967821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67167"},
        {"Smithsonian Astrophysical Observation", "SAO 100699"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46623545),
        dec: Angle.Degrees(+15.66031124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208963"},
        {"Hipparcos Number", "HIP 108563"},
        {"Geneva Identification System", "GEN# +1.00208963"},
        {"Smithsonian Astrophysical Observation", "SAO 107568"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.87492536),
        dec: Angle.Degrees(+15.66159078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124348"},
        {"Hipparcos Number", "HIP 69411"},
        {"Geneva Identification System", "GEN# +1.00124348"},
        {"Smithsonian Astrophysical Observation", "SAO 100911"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.17523819),
        dec: Angle.Degrees(+15.66248025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80539"},
    },
    visualMagnitude: 10.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.63948899),
        dec: Angle.Degrees(+15.66431030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 264.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142860"},
        {"Hipparcos Number", "HIP 78072"},
        {"Celescope Catalog", "CEL 4406"},
        {"Cincinnati Publication", "Ci 20 953"},
        {"Fundamental Katalog 5th Edition", "FK5 591"},
        {"Geneva Identification System", "GEN# +1.00142860"},
        {"Smithsonian Astrophysical Observation", "SAO 101826"},
        {"Wilson Evans Batten Catalogue", "WEB 13203"},
    },
    visualMagnitude: 3.85,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.11247598),
        dec: Angle.Degrees(+15.66473327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 311.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1282.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78409",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9873 A"},
        {"Henry Draper", "HD 143551"},
        {"Hipparcos Number", "HIP 78409"},
        {"Smithsonian Astrophysical Observation", "SAO 101868"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.09823307),
        dec: Angle.Degrees(+15.66748585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15805"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90499629),
        dec: Angle.Degrees(+15.66780467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84375"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.74272421),
        dec: Angle.Degrees(+15.66944629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86826"},
        {"Hipparcos Number", "HIP 49108"},
        {"Smithsonian Astrophysical Observation", "SAO 98897"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.33631971),
        dec: Angle.Degrees(+15.67065081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126946"},
        {"Hipparcos Number", "HIP 70764"},
        {"Smithsonian Astrophysical Observation", "SAO 101039"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.07482773),
        dec: Angle.Degrees(+15.67090579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35533"},
        {"Hipparcos Number", "HIP 25402"},
        {"Celescope Catalog", "CEL 689"},
        {"Renson", "Renson 9145"},
        {"Smithsonian Astrophysical Observation", "SAO 94542"},
        {"Wilson Evans Batten Catalogue", "WEB 4921"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.51119335),
        dec: Angle.Degrees(+15.67179696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81626"},
        {"Geneva Identification System", "GEN# +9.80138051"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.08177116),
        dec: Angle.Degrees(+15.67228112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6966"},
        {"Hipparcos Number", "HIP 5483"},
        {"Geneva Identification System", "GEN# +1.00006966"},
        {"Smithsonian Astrophysical Observation", "SAO 92288"},
        {"Wilson Evans Batten Catalogue", "WEB 1210"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.54762035),
        dec: Angle.Degrees(+15.67397125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191262"},
        {"Hipparcos Number", "HIP 99210"},
        {"Geneva Identification System", "GEN# +1.00191262"},
        {"Smithsonian Astrophysical Observation", "SAO 105740"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.11253796),
        dec: Angle.Degrees(+15.67519064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217479"},
        {"Hipparcos Number", "HIP 113636"},
        {"Smithsonian Astrophysical Observation", "SAO 108330"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.21150924),
        dec: Angle.Degrees(+15.67782715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69629"},
        {"Hipparcos Number", "HIP 40675"},
        {"Smithsonian Astrophysical Observation", "SAO 97718"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.56013945),
        dec: Angle.Degrees(+15.67793154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50792"},
        {"Hipparcos Number", "HIP 33279"},
        {"Geneva Identification System", "GEN# +1.00050792"},
        {"Smithsonian Astrophysical Observation", "SAO 96274"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.83286368),
        dec: Angle.Degrees(+15.67923949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90214"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.11173072),
        dec: Angle.Degrees(+15.68002551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181120"},
        {"Hipparcos Number", "HIP 94894"},
        {"Geneva Identification System", "GEN# +1.00181120"},
        {"Smithsonian Astrophysical Observation", "SAO 104704"},
        {"Wilson Evans Batten Catalogue", "WEB 16566"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.66414993),
        dec: Angle.Degrees(+15.68065831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74014",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9506 AB"},
        {"Henry Draper", "HD 134084"},
        {"Hipparcos Number", "HIP 74014"},
        {"Smithsonian Astrophysical Observation", "SAO 101382"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.88199289),
        dec: Angle.Degrees(+15.68087492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43742"},
        {"Smithsonian Astrophysical Observation", "SAO 98220"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.63768964),
        dec: Angle.Degrees(+15.68195773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176733"},
        {"Hipparcos Number", "HIP 93377"},
        {"Cincinnati Publication", "Ci 18 2484"},
        {"Geneva Identification System", "GEN# +1.00176733"},
        {"Smithsonian Astrophysical Observation", "SAO 104361"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27731567),
        dec: Angle.Degrees(+15.68374735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -324.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65643"},
        {"Hipparcos Number", "HIP 39125"},
        {"Geneva Identification System", "GEN# +1.00065643"},
        {"Smithsonian Astrophysical Observation", "SAO 97457"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06347185),
        dec: Angle.Degrees(+15.68393712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14894"},
        {"Hipparcos Number", "HIP 11233"},
        {"Smithsonian Astrophysical Observation", "SAO 92925"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.14371581),
        dec: Angle.Degrees(+15.68424566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205272"},
        {"Hipparcos Number", "HIP 106469"},
        {"Smithsonian Astrophysical Observation", "SAO 107234"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.45966000),
        dec: Angle.Degrees(+15.68707568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71540"},
        {"Smithsonian Astrophysical Observation", "SAO 101118"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.48616929),
        dec: Angle.Degrees(+15.68720923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220659"},
        {"Hipparcos Number", "HIP 115627"},
        {"Geneva Identification System", "GEN# +1.00220659"},
        {"Smithsonian Astrophysical Observation", "SAO 108600"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.35490715),
        dec: Angle.Degrees(+15.68868999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68669"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.86085028),
        dec: Angle.Degrees(+15.69090091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28546"},
        {"Hipparcos Number", "HIP 21039"},
        {"Celescope Catalog", "CEL 418"},
        {"Geneva Identification System", "GEN# +5.20250083"},
        {"Renson", "Renson 7340"},
        {"Smithsonian Astrophysical Observation", "SAO 93978"},
        {"Wilson Evans Batten Catalogue", "WEB 4047"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.66177772),
        dec: Angle.Degrees(+15.69193829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205666"},
        {"Hipparcos Number", "HIP 106691"},
        {"Smithsonian Astrophysical Observation", "SAO 107273"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.14306900),
        dec: Angle.Degrees(+15.69303078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221915"},
        {"Hipparcos Number", "HIP 116471"},
        {"Smithsonian Astrophysical Observation", "SAO 108706"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.00323647),
        dec: Angle.Degrees(+15.69397803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44128"},
        {"Hipparcos Number", "HIP 30155"},
        {"Geneva Identification System", "GEN# +1.00044128"},
        {"Smithsonian Astrophysical Observation", "SAO 95560"},
        {"Wilson Evans Batten Catalogue", "WEB 5997"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.18037877),
        dec: Angle.Degrees(+15.69420865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8110"},
        {"Hipparcos Number", "HIP 6289"},
        {"Fundamental Katalog 5th Edition", "FK5 4123"},
        {"Geneva Identification System", "GEN# +1.00008110"},
        {"Smithsonian Astrophysical Observation", "SAO 92380"},
        {"Wilson Evans Batten Catalogue", "WEB 1403"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.17113200),
        dec: Angle.Degrees(+15.69606061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116256"},
        {"Geneva Identification System", "GEN# +9.80068028"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34613440),
        dec: Angle.Degrees(+15.69708599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 311.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25825"},
        {"Hipparcos Number", "HIP 19148"},
        {"Geneva Identification System", "GEN# +5.20250010"},
        {"Smithsonian Astrophysical Observation", "SAO 93760"},
        {"Wilson Evans Batten Catalogue", "WEB 3678"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.56689905),
        dec: Angle.Degrees(+15.69816786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213920"},
        {"Hipparcos Number", "HIP 111435"},
        {"Smithsonian Astrophysical Observation", "SAO 108009"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.63536257),
        dec: Angle.Degrees(+15.69921426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88233"},
        {"Hipparcos Number", "HIP 49850"},
        {"Geneva Identification System", "GEN# +1.00088233"},
        {"Smithsonian Astrophysical Observation", "SAO 98984"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.67913997),
        dec: Angle.Degrees(+15.70453146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87437"},
    },
    visualMagnitude: 10.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00406332),
        dec: Angle.Degrees(+15.70460627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41997"},
        {"Hipparcos Number", "HIP 29147"},
        {"Geneva Identification System", "GEN# +1.00041997"},
        {"Smithsonian Astrophysical Observation", "SAO 95290"},
        {"Wilson Evans Batten Catalogue", "WEB 5716"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.23259672),
        dec: Angle.Degrees(+15.70507926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9425 AB"},
        {"Henry Draper", "HD 131473"},
        {"Hipparcos Number", "HIP 72846"},
        {"Geneva Identification System", "GEN# +1.00131473J"},
        {"Smithsonian Astrophysical Observation", "SAO 101273"},
        {"Wilson Evans Batten Catalogue", "WEB 12512"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.34734286),
        dec: Angle.Degrees(+15.70511093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63062"},
        {"Hipparcos Number", "HIP 38026"},
        {"Smithsonian Astrophysical Observation", "SAO 97247"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89352343),
        dec: Angle.Degrees(+15.70564623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5168 AB"},
        {"Henry Draper", "HD 46148"},
        {"Hipparcos Number", "HIP 31164"},
        {"Geneva Identification System", "GEN# +1.00046148J"},
        {"Smithsonian Astrophysical Observation", "SAO 95800"},
        {"Wilson Evans Batten Catalogue", "WEB 6220"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08623540),
        dec: Angle.Degrees(+15.70619207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285590"},
        {"Hipparcos Number", "HIP 19862"},
        {"Geneva Identification System", "GEN# +5.20251075"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.89006144),
        dec: Angle.Degrees(+15.70632279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178635"},
        {"Hipparcos Number", "HIP 94055"},
        {"Smithsonian Astrophysical Observation", "SAO 104527"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.22082661),
        dec: Angle.Degrees(+15.70654008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65725",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8914 AB"},
        {"Henry Draper", "HD 117190"},
        {"Hipparcos Number", "HIP 65725"},
        {"Smithsonian Astrophysical Observation", "SAO 100583"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11131561),
        dec: Angle.Degrees(+15.70826814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210553"},
        {"Hipparcos Number", "HIP 109490"},
        {"Geneva Identification System", "GEN# +1.00210553"},
        {"Smithsonian Astrophysical Observation", "SAO 107716"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.71076437),
        dec: Angle.Degrees(+15.70827510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144904"},
        {"Hipparcos Number", "HIP 79022"},
        {"Geneva Identification System", "GEN# +1.00144904"},
        {"Smithsonian Astrophysical Observation", "SAO 101941"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93869496),
        dec: Angle.Degrees(+15.71039216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102017"},
        {"Smithsonian Astrophysical Observation", "SAO 106368"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.08714144),
        dec: Angle.Degrees(+15.71063297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62858"},
        {"Smithsonian Astrophysical Observation", "SAO 100316"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.26096395),
        dec: Angle.Degrees(+15.71076693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17660"},
        {"Hipparcos Number", "HIP 13258"},
        {"Cincinnati Publication", "Ci 18 365"},
        {"Cincinnati Publication 2", "Ci 20 185"},
        {"Geneva Identification System", "GEN# +1.00017660"},
        {"Smithsonian Astrophysical Observation", "SAO 93138"},
        {"Wilson Evans Batten Catalogue", "WEB 2659"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.65286081),
        dec: Angle.Degrees(+15.71087586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 339.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -395.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149932"},
        {"Hipparcos Number", "HIP 81384"},
        {"Smithsonian Astrophysical Observation", "SAO 102274"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.31660967),
        dec: Angle.Degrees(+15.71091722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8262"},
        {"Smithsonian Astrophysical Observation", "SAO 92621"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.60658179),
        dec: Angle.Degrees(+15.71320450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62111"},
        {"Smithsonian Astrophysical Observation", "SAO 100227"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.94912057),
        dec: Angle.Degrees(+15.71475236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38585"},
        {"Hipparcos Number", "HIP 27347"},
        {"Cincinnati Publication", "Ci 18 729"},
        {"Smithsonian Astrophysical Observation", "SAO 94861"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.88559524),
        dec: Angle.Degrees(+15.71477346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107303"},
        {"Hipparcos Number", "HIP 60152"},
        {"Geneva Identification System", "GEN# +1.00107303"},
        {"Smithsonian Astrophysical Observation", "SAO 100049"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.02556420),
        dec: Angle.Degrees(+15.71494965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6430 AB"},
        {"Henry Draper", "HD 64211"},
        {"Hipparcos Number", "HIP 38519"},
        {"Smithsonian Astrophysical Observation", "SAO 97334"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.32626571),
        dec: Angle.Degrees(+15.71896127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114623"},
        {"Hipparcos Number", "HIP 64361"},
        {"Geneva Identification System", "GEN# +1.00114623"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87519678),
        dec: Angle.Degrees(+15.72184585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79390"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.04004215),
        dec: Angle.Degrees(+15.72390738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76350"},
        {"Hipparcos Number", "HIP 43858"},
        {"Geneva Identification System", "GEN# +1.00076350"},
        {"Smithsonian Astrophysical Observation", "SAO 98236"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.01835591),
        dec: Angle.Degrees(+15.72396453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82138"},
        {"Smithsonian Astrophysical Observation", "SAO 102380"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.70750166),
        dec: Angle.Degrees(+15.72423403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74699"},
        {"Smithsonian Astrophysical Observation", "SAO 101463"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.98759020),
        dec: Angle.Degrees(+15.72444421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173609"},
        {"Hipparcos Number", "HIP 92047"},
        {"Smithsonian Astrophysical Observation", "SAO 104074"},
        {"Wilson Evans Batten Catalogue", "WEB 15863"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.42282857),
        dec: Angle.Degrees(+15.72539790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194319"},
        {"Hipparcos Number", "HIP 100648"},
        {"Smithsonian Astrophysical Observation", "SAO 106070"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.12492614),
        dec: Angle.Degrees(+15.72721306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43217"},
        {"Smithsonian Astrophysical Observation", "SAO 98137"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.06273522),
        dec: Angle.Degrees(+15.72758424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121801"},
        {"Hipparcos Number", "HIP 68174"},
        {"Smithsonian Astrophysical Observation", "SAO 100791"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.35247310),
        dec: Angle.Degrees(+15.72882666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102131"},
        {"Hipparcos Number", "HIP 57336"},
        {"Smithsonian Astrophysical Observation", "SAO 99777"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.34176418),
        dec: Angle.Degrees(+15.72890900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103661"},
        {"Hipparcos Number", "HIP 58203"},
        {"Geneva Identification System", "GEN# +1.00103661"},
        {"Smithsonian Astrophysical Observation", "SAO 99874"},
        {"Wilson Evans Batten Catalogue", "WEB 10417"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.05133633),
        dec: Angle.Degrees(+15.72906274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57752"},
        {"Smithsonian Astrophysical Observation", "SAO 99823"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.66469117),
        dec: Angle.Degrees(+15.72954437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42131"},
        {"Smithsonian Astrophysical Observation", "SAO 97929"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.82316473),
        dec: Angle.Degrees(+15.72997233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261579"},
        {"Hipparcos Number", "HIP 31908"},
        {"Smithsonian Astrophysical Observation", "SAO 95975"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02843202),
        dec: Angle.Degrees(+15.73080431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114639"},
        {"Hipparcos Number", "HIP 64373"},
        {"Geneva Identification System", "GEN# +1.00114639"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.90581336),
        dec: Angle.Degrees(+15.73094074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87153"},
        {"Smithsonian Astrophysical Observation", "SAO 103123"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.08776436),
        dec: Angle.Degrees(+15.73338125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162866"},
        {"Hipparcos Number", "HIP 87493"},
        {"Smithsonian Astrophysical Observation", "SAO 103169"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.15091326),
        dec: Angle.Degrees(+15.73338396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177599"},
        {"Hipparcos Number", "HIP 93708"},
        {"Geneva Identification System", "GEN# +1.00177599"},
        {"Smithsonian Astrophysical Observation", "SAO 104452"},
        {"Wilson Evans Batten Catalogue", "WEB 16282"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22129453),
        dec: Angle.Degrees(+15.73599305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16393"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.77618096),
        dec: Angle.Degrees(+15.73611197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353315"},
        {"Hipparcos Number", "HIP 96637"},
        {"Wilson Evans Batten Catalogue", "WEB 16955"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71669149),
        dec: Angle.Degrees(+15.73623742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148494"},
        {"Hipparcos Number", "HIP 80657"},
        {"Smithsonian Astrophysical Observation", "SAO 102188"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.00620279),
        dec: Angle.Degrees(+15.73657203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285589"},
        {"Hipparcos Number", "HIP 19822"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.75429715),
        dec: Angle.Degrees(+15.73776381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72306"},
        {"Hipparcos Number", "HIP 41900"},
        {"Fundamental Katalog 5th Edition", "FK5 4770"},
        {"Smithsonian Astrophysical Observation", "SAO 97900"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.15927244),
        dec: Angle.Degrees(+15.73949247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7386 AB"},
        {"Henry Draper", "HD 81706"},
        {"Hipparcos Number", "HIP 46397"},
        {"Smithsonian Astrophysical Observation", "SAO 98581"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.91444578),
        dec: Angle.Degrees(+15.74172868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40040"},
        {"Hipparcos Number", "HIP 28159"},
        {"Cincinnati Publication", "Ci 18 741"},
        {"Geneva Identification System", "GEN# +1.00040040"},
        {"Smithsonian Astrophysical Observation", "SAO 95030"},
        {"Wilson Evans Batten Catalogue", "WEB 5510"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.25717873),
        dec: Angle.Degrees(+15.74195886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49474"},
        {"Hipparcos Number", "HIP 32692"},
        {"Smithsonian Astrophysical Observation", "SAO 96148"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31281619),
        dec: Angle.Degrees(+15.74399347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89431"},
        {"Hipparcos Number", "HIP 50560"},
        {"Smithsonian Astrophysical Observation", "SAO 99062"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.91562517),
        dec: Angle.Degrees(+15.74432649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32112"},
        {"Hipparcos Number", "HIP 23353"},
        {"Smithsonian Astrophysical Observation", "SAO 94265"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.33669942),
        dec: Angle.Degrees(+15.74437849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151203"},
        {"Hipparcos Number", "HIP 82028"},
        {"Geneva Identification System", "GEN# +1.00151203"},
        {"Smithsonian Astrophysical Observation", "SAO 102365"},
        {"Wilson Evans Batten Catalogue", "WEB 13850"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.34377167),
        dec: Angle.Degrees(+15.74541189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154395"},
        {"Hipparcos Number", "HIP 83564"},
        {"Smithsonian Astrophysical Observation", "SAO 102577"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.16936998),
        dec: Angle.Degrees(+15.74608120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143293"},
        {"Hipparcos Number", "HIP 78282"},
        {"Smithsonian Astrophysical Observation", "SAO 101851"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.75738610),
        dec: Angle.Degrees(+15.74665380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2914"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.23232339),
        dec: Angle.Degrees(+15.74708999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46900"},
        {"Hipparcos Number", "HIP 31574"},
        {"Geneva Identification System", "GEN# +1.00046900"},
        {"Smithsonian Astrophysical Observation", "SAO 95895"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.12019362),
        dec: Angle.Degrees(+15.75018109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207664"},
        {"Hipparcos Number", "HIP 107790"},
        {"Geneva Identification System", "GEN# +1.00207664"},
        {"Smithsonian Astrophysical Observation", "SAO 107426"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.54003083),
        dec: Angle.Degrees(+15.75067809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9021 AB"},
        {"Henry Draper", "HD 120008"},
        {"Hipparcos Number", "HIP 67225"},
        {"Smithsonian Astrophysical Observation", "SAO 100701"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.63111205),
        dec: Angle.Degrees(+15.75136085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83891"},
        {"Hipparcos Number", "HIP 47557"},
        {"Fundamental Katalog 5th Edition", "FK5 4860"},
        {"Smithsonian Astrophysical Observation", "SAO 98717"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.44166321),
        dec: Angle.Degrees(+15.75519470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90683"},
        {"Hipparcos Number", "HIP 51279"},
        {"Fundamental Katalog 5th Edition", "FK5 4929"},
        {"Geneva Identification System", "GEN# +1.00090683"},
        {"Smithsonian Astrophysical Observation", "SAO 99145"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.11013385),
        dec: Angle.Degrees(+15.75580698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87500"},
        {"Hipparcos Number", "HIP 49445"},
        {"Geneva Identification System", "GEN# +1.00087500"},
        {"Renson", "Renson 25104"},
        {"Smithsonian Astrophysical Observation", "SAO 98944"},
        {"Wilson Evans Batten Catalogue", "WEB 9132"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.42068743),
        dec: Angle.Degrees(+15.75752363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207032"},
        {"Hipparcos Number", "HIP 107448"},
        {"Geneva Identification System", "GEN# +1.00207032"},
        {"Smithsonian Astrophysical Observation", "SAO 107380"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.45109162),
        dec: Angle.Degrees(+15.75774015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169840"},
        {"Hipparcos Number", "HIP 90345"},
        {"Geneva Identification System", "GEN# +1.00169840"},
        {"Smithsonian Astrophysical Observation", "SAO 103710"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.50415303),
        dec: Angle.Degrees(+15.75856800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231294"},
        {"Hipparcos Number", "HIP 95334"},
        {"Smithsonian Astrophysical Observation", "SAO 104786"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.92864066),
        dec: Angle.Degrees(+15.75960637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200428"},
        {"Henry Draper 2", "HD 200429"},
        {"Hipparcos Number", "HIP 103890"},
        {"Geneva Identification System", "GEN# +1.00200428"},
        {"Smithsonian Astrophysical Observation", "SAO 106797"},
        {"Wilson Evans Batten Catalogue", "WEB 18917"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.75430018),
        dec: Angle.Degrees(+15.76053531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207545"},
        {"Hipparcos Number", "HIP 107726"},
        {"Smithsonian Astrophysical Observation", "SAO 107415"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.33989922),
        dec: Angle.Degrees(+15.76115307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94927"},
        {"Hipparcos Number", "HIP 53577"},
        {"Geneva Identification System", "GEN# +1.00094927"},
        {"Smithsonian Astrophysical Observation", "SAO 99369"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.40786209),
        dec: Angle.Degrees(+15.76140144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285749"},
        {"Hipparcos Number", "HIP 20485"},
        {"Geneva Identification System", "GEN# +5.20251276"},
        {"Geneva Identification System 2", "GEN# +5.20250173"},
        {"Wilson Evans Batten Catalogue", "WEB 3919"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.85502034),
        dec: Angle.Degrees(+15.76318700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89538"},
        {"Smithsonian Astrophysical Observation", "SAO 103541"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.05387693),
        dec: Angle.Degrees(+15.76472340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96692"},
        {"Hipparcos Number", "HIP 54459"},
        {"Cincinnati Publication", "Ci 20 611"},
        {"Geneva Identification System", "GEN# +1.00096692"},
        {"Wilson Evans Batten Catalogue", "WEB 9830"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.13195199),
        dec: Angle.Degrees(+15.76853016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -375.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82332"},
        {"Hipparcos Number", "HIP 46745"},
        {"Smithsonian Astrophysical Observation", "SAO 98625"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.91265279),
        dec: Angle.Degrees(+15.77012578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7300"},
        {"Smithsonian Astrophysical Observation", "SAO 92516"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.50221207),
        dec: Angle.Degrees(+15.77037150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62299"},
        {"Smithsonian Astrophysical Observation", "SAO 100244"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.49118711),
        dec: Angle.Degrees(+15.77056566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260887"},
        {"Hipparcos Number", "HIP 31706"},
        {"Smithsonian Astrophysical Observation", "SAO 95923"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.48448680),
        dec: Angle.Degrees(+15.77184581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36283"},
        {"Hipparcos Number", "HIP 25860"},
        {"Cincinnati Publication", "Ci 18 703"},
        {"Geneva Identification System", "GEN# +1.00036283"},
        {"Smithsonian Astrophysical Observation", "SAO 94608"},
        {"Wilson Evans Batten Catalogue", "WEB 5019"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.80751760),
        dec: Angle.Degrees(+15.77435794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -373.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90538"},
        {"Hipparcos Number", "HIP 51201"},
        {"Geneva Identification System", "GEN# +1.00090538"},
        {"Smithsonian Astrophysical Observation", "SAO 99135"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.86967202),
        dec: Angle.Degrees(+15.77626333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80889"},
        {"Hipparcos Number", "HIP 45989"},
        {"Smithsonian Astrophysical Observation", "SAO 98533"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.69237304),
        dec: Angle.Degrees(+15.77677316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101060"},
        {"Hipparcos Number", "HIP 56736"},
        {"Geneva Identification System", "GEN# +1.00101060"},
        {"Smithsonian Astrophysical Observation", "SAO 99702"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.49090537),
        dec: Angle.Degrees(+15.77690908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10477"},
        {"Hipparcos Number", "HIP 7975"},
        {"Fundamental Katalog 5th Edition", "FK5 4151"},
        {"Smithsonian Astrophysical Observation", "SAO 92588"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.61207566),
        dec: Angle.Degrees(+15.77854670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86595"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44814578),
        dec: Angle.Degrees(+15.77876843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78389"},
        {"Smithsonian Astrophysical Observation", "SAO 101865"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.05511998),
        dec: Angle.Degrees(+15.77910435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16373 AB"},
        {"Hipparcos Number", "HIP 113220"},
        {"Geneva Identification System", "GEN# +0.01504729J"},
        {"Smithsonian Astrophysical Observation", "SAO 108263"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.93094076),
        dec: Angle.Degrees(+15.77924947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48858"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48356734),
        dec: Angle.Degrees(+15.78033767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133031"},
        {"Hipparcos Number", "HIP 73542"},
        {"Smithsonian Astrophysical Observation", "SAO 101333"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.46639726),
        dec: Angle.Degrees(+15.78136846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209421"},
        {"Hipparcos Number", "HIP 108842"},
        {"Geneva Identification System", "GEN# +1.00209421"},
        {"Smithsonian Astrophysical Observation", "SAO 107620"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72938719),
        dec: Angle.Degrees(+15.78247747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57337"},
        {"Smithsonian Astrophysical Observation", "SAO 99778"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.34451639),
        dec: Angle.Degrees(+15.78426295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285750"},
        {"Hipparcos Number", "HIP 20389"},
        {"Smithsonian Astrophysical Observation", "SAO 93890"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.49523523),
        dec: Angle.Degrees(+15.78496456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34636"},
        {"Hipparcos Number", "HIP 24850"},
        {"Geneva Identification System", "GEN# +1.00034636"},
        {"Smithsonian Astrophysical Observation", "SAO 94461"},
        {"Wilson Evans Batten Catalogue", "WEB 4813"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.91244334),
        dec: Angle.Degrees(+15.78600911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179218"},
        {"Hipparcos Number", "HIP 94260"},
        {"Smithsonian Astrophysical Observation", "SAO 104567"},
        {"Wilson Evans Batten Catalogue", "WEB 16418"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79687838),
        dec: Angle.Degrees(+15.78772717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112994"},
        {"Geneva Identification System", "GEN# +0.01504721"},
        {"Wilson Evans Batten Catalogue", "WEB 20118"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.25438247),
        dec: Angle.Degrees(+15.78810153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73543"},
        {"Smithsonian Astrophysical Observation", "SAO 101334"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.46777720),
        dec: Angle.Degrees(+15.78848177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8248"},
        {"Hipparcos Number", "HIP 6384"},
        {"Geneva Identification System", "GEN# +1.00008248"},
        {"Smithsonian Astrophysical Observation", "SAO 92396"},
        {"Wilson Evans Batten Catalogue", "WEB 1414"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.51020881),
        dec: Angle.Degrees(+15.78930801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5362",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 935 AB"},
        {"Henry Draper", "HD 6774"},
        {"Hipparcos Number", "HIP 5362"},
        {"Smithsonian Astrophysical Observation", "SAO 92273"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.14070459),
        dec: Angle.Degrees(+15.79026858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64960"},
        {"Hipparcos Number", "HIP 38848"},
        {"Fundamental Katalog 5th Edition", "FK5 1208"},
        {"Geneva Identification System", "GEN# +1.00064960"},
        {"Smithsonian Astrophysical Observation", "SAO 97399"},
        {"Wilson Evans Batten Catalogue", "WEB 7606"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.24778711),
        dec: Angle.Degrees(+15.79038246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152155"},
        {"Hipparcos Number", "HIP 82468"},
        {"Smithsonian Astrophysical Observation", "SAO 102429"},
        {"Wilson Evans Batten Catalogue", "WEB 13924"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.79963549),
        dec: Angle.Degrees(+15.79471062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2656"},
        {"Hipparcos Number", "HIP 2374"},
        {"Smithsonian Astrophysical Observation", "SAO 91927"},
        {"Wilson Evans Batten Catalogue", "WEB 436"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.57623035),
        dec: Angle.Degrees(+15.79532885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145147"},
        {"Hipparcos Number", "HIP 79114"},
        {"Smithsonian Astrophysical Observation", "SAO 101963"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.21523021),
        dec: Angle.Degrees(+15.79639750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30710"},
        {"Hipparcos Number", "HIP 22510"},
        {"Geneva Identification System", "GEN# +1.00030710"},
        {"Wilson Evans Batten Catalogue", "WEB 4341"},
    },
    visualMagnitude: 9.18,
    bvColour: 2.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.65695081),
        dec: Angle.Degrees(+15.79707470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120477"},
        {"Hipparcos Number", "HIP 67459"},
        {"Geneva Identification System", "GEN# +1.00120477"},
        {"Smithsonian Astrophysical Observation", "SAO 100725"},
        {"Wilson Evans Batten Catalogue", "WEB 11865"},
    },
    visualMagnitude: 4.05,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.36957439),
        dec: Angle.Degrees(+15.79780583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31649"},
        {"Hipparcos Number", "HIP 23094"},
        {"Geneva Identification System", "GEN# +1.00031649"},
        {"Smithsonian Astrophysical Observation", "SAO 94232"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54763857),
        dec: Angle.Degrees(+15.79861070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29479"},
        {"Hipparcos Number", "HIP 21673"},
        {"Celescope Catalog", "CEL 449"},
        {"Geneva Identification System", "GEN# +1.00029479"},
        {"Renson", "Renson 7550"},
        {"Smithsonian Astrophysical Observation", "SAO 94051"},
        {"Wilson Evans Batten Catalogue", "WEB 4163"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.78832206),
        dec: Angle.Degrees(+15.80003442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57063"},
        {"Geneva Identification System", "GEN# +0.01602283"},
        {"Smithsonian Astrophysical Observation", "SAO 99740"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.47336299),
        dec: Angle.Degrees(+15.80022065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354511"},
        {"Hipparcos Number", "HIP 98553"},
        {"Geneva Identification System", "GEN# +1.00354511"},
        {"Wilson Evans Batten Catalogue", "WEB 17419"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.29091445),
        dec: Angle.Degrees(+15.80353614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13057"},
        {"Hipparcos Number", "HIP 9948"},
        {"Geneva Identification System", "GEN# +1.00013057"},
        {"Smithsonian Astrophysical Observation", "SAO 92803"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.01629922),
        dec: Angle.Degrees(+15.80461233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79589"},
        {"Smithsonian Astrophysical Observation", "SAO 102029"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56909816),
        dec: Angle.Degrees(+15.80462953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89564"},
        {"Smithsonian Astrophysical Observation", "SAO 103553"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.13856939),
        dec: Angle.Degrees(+15.80597096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13944 AB"},
        {"Henry Draper", "HD 195481"},
        {"Hipparcos Number", "HIP 101223"},
        {"Geneva Identification System", "GEN# +1.00195481J"},
        {"Smithsonian Astrophysical Observation", "SAO 106194"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.77549185),
        dec: Angle.Degrees(+15.80764472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109451"},
        {"Hipparcos Number", "HIP 61385"},
        {"Geneva Identification System", "GEN# +1.00109451"},
        {"Smithsonian Astrophysical Observation", "SAO 100155"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.68557419),
        dec: Angle.Degrees(+15.80774702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112355"},
        {"Hipparcos Number", "HIP 63122"},
        {"Smithsonian Astrophysical Observation", "SAO 100339"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.00601458),
        dec: Angle.Degrees(+15.81044912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160364"},
        {"Hipparcos Number", "HIP 86367"},
        {"Smithsonian Astrophysical Observation", "SAO 102998"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.72103671),
        dec: Angle.Degrees(+15.81148214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286174"},
        {"Hipparcos Number", "HIP 22967"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.13140561),
        dec: Angle.Degrees(+15.81393648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285324"},
        {"Hipparcos Number", "HIP 18626"},
        {"Smithsonian Astrophysical Observation", "SAO 93704"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.80313305),
        dec: Angle.Degrees(+15.81458179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242851"},
        {"Hipparcos Number", "HIP 25018"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.34889366),
        dec: Angle.Degrees(+15.81497281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23042"},
        {"Hipparcos Number", "HIP 17318"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.60720335),
        dec: Angle.Degrees(+15.81537972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13914"},
        {"Hipparcos Number", "HIP 10558"},
        {"Geneva Identification System", "GEN# +1.00013914"},
        {"Smithsonian Astrophysical Observation", "SAO 92863"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.98267211),
        dec: Angle.Degrees(+15.81921544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156430"},
        {"Hipparcos Number", "HIP 84540"},
        {"Geneva Identification System", "GEN# +1.00156430"},
        {"Smithsonian Astrophysical Observation", "SAO 102708"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.24476856),
        dec: Angle.Degrees(+15.82078879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16865"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.26033658),
        dec: Angle.Degrees(+15.82241085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38478"},
        {"Hipparcos Number", "HIP 27265"},
        {"Celescope Catalog", "CEL 966"},
        {"Geneva Identification System", "GEN# +1.00038478"},
        {"Renson", "Renson 10350"},
        {"Smithsonian Astrophysical Observation", "SAO 94848"},
        {"Wilson Evans Batten Catalogue", "WEB 5358"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.68955602),
        dec: Angle.Degrees(+15.82250445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41889"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.12745292),
        dec: Angle.Degrees(+15.82417934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3727"},
        {"Hipparcos Number", "HIP 3162"},
        {"Geneva Identification System", "GEN# +1.00003727"},
        {"Smithsonian Astrophysical Observation", "SAO 92016"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.06970087),
        dec: Angle.Degrees(+15.82474585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213573"},
        {"Hipparcos Number", "HIP 111233"},
        {"Smithsonian Astrophysical Observation", "SAO 107980"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03879996),
        dec: Angle.Degrees(+15.82525639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38852"},
        {"Smithsonian Astrophysical Observation", "SAO 97402"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.26316040),
        dec: Angle.Degrees(+15.82569769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168481"},
        {"Hipparcos Number", "HIP 89777"},
        {"Geneva Identification System", "GEN# +1.00168481"},
        {"Renson", "Renson 47220"},
        {"Smithsonian Astrophysical Observation", "SAO 103606"},
        {"Wilson Evans Batten Catalogue", "WEB 15316"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.81792494),
        dec: Angle.Degrees(+15.82604593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196007"},
        {"Hipparcos Number", "HIP 101502"},
        {"Geneva Identification System", "GEN# +1.00196007"},
        {"Smithsonian Astrophysical Observation", "SAO 106254"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.53563098),
        dec: Angle.Degrees(+15.82623972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206734"},
        {"Hipparcos Number", "HIP 107279"},
        {"Smithsonian Astrophysical Observation", "SAO 107356"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.94188592),
        dec: Angle.Degrees(+15.82644785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21157"},
        {"Hipparcos Number", "HIP 15951"},
        {"Geneva Identification System", "GEN# +1.00021157"},
        {"Smithsonian Astrophysical Observation", "SAO 93425"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.34729706),
        dec: Angle.Degrees(+15.82645809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60107"},
        {"Hipparcos Number", "HIP 36760"},
        {"Geneva Identification System", "GEN# +1.00060107"},
        {"Smithsonian Astrophysical Observation", "SAO 97016"},
        {"Wilson Evans Batten Catalogue", "WEB 7306"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.40207910),
        dec: Angle.Degrees(+15.82669239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285985"},
        {"Hipparcos Number", "HIP 22004"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.95477940),
        dec: Angle.Degrees(+15.83142637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35818"},
        {"Smithsonian Astrophysical Observation", "SAO 96842"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.80904981),
        dec: Angle.Degrees(+15.83201617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66436"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.29765520),
        dec: Angle.Degrees(+15.83286685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114368"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.44544114),
        dec: Angle.Degrees(+15.83297966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145288"},
        {"Hipparcos Number", "HIP 79182"},
        {"Geneva Identification System", "GEN# +1.00145288"},
        {"Smithsonian Astrophysical Observation", "SAO 101973"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41647988),
        dec: Angle.Degrees(+15.83538810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118229"},
        {"Smithsonian Astrophysical Observation", "SAO 108942"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.71879931),
        dec: Angle.Degrees(+15.83700509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1213"},
        {"Hipparcos Number", "HIP 1320"},
        {"Geneva Identification System", "GEN# +1.00001213"},
        {"Smithsonian Astrophysical Observation", "SAO 91810"},
        {"Wilson Evans Batten Catalogue", "WEB 232"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.14465261),
        dec: Angle.Degrees(+15.83717590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50607"},
        {"Hipparcos Number", "HIP 33205"},
        {"Geneva Identification System", "GEN# +1.00050607"},
        {"Smithsonian Astrophysical Observation", "SAO 96262"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.66576734),
        dec: Angle.Degrees(+15.83797577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14106 A"},
        {"Henry Draper", "HD 196775"},
        {"Hipparcos Number", "HIP 101909"},
        {"Smithsonian Astrophysical Observation", "SAO 106347"},
        {"Wilson Evans Batten Catalogue", "WEB 18416"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.77070250),
        dec: Angle.Degrees(+15.83823558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76389"},
        {"Geneva Identification System", "GEN# +0.01602806"},
        {"Smithsonian Astrophysical Observation", "SAO 101637"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.02853008),
        dec: Angle.Degrees(+15.83934993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44197"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)00, 10.9300),
        dec: Angle.DegreesMinutesSeconds((int)+15, (int)50, 21.700)
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
    primaryId: "HIP 97172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353625"},
        {"Hipparcos Number", "HIP 97172"},
        {"Smithsonian Astrophysical Observation", "SAO 105210"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.26075790),
        dec: Angle.Degrees(+15.84168853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44585"},
        {"Hipparcos Number", "HIP 30363"},
        {"Celescope Catalog", "CEL 1206"},
        {"Geneva Identification System", "GEN# +1.00044585"},
        {"Smithsonian Astrophysical Observation", "SAO 95605"},
        {"Wilson Evans Batten Catalogue", "WEB 6040"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78815943),
        dec: Angle.Degrees(+15.84233923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217717"},
        {"Hipparcos Number", "HIP 113780"},
        {"Smithsonian Astrophysical Observation", "SAO 108355"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63338172),
        dec: Angle.Degrees(+15.84559995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103111"},
        {"Hipparcos Number", "HIP 57897"},
        {"Geneva Identification System", "GEN# +1.00103111"},
        {"Smithsonian Astrophysical Observation", "SAO 99838"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.12573208),
        dec: Angle.Degrees(+15.84596851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34937"},
        {"Hipparcos Number", "HIP 25034"},
        {"Geneva Identification System", "GEN# +1.00034937"},
        {"Smithsonian Astrophysical Observation", "SAO 94489"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.41300347),
        dec: Angle.Degrees(+15.84718321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43496"},
        {"Hipparcos Number", "HIP 29849"},
        {"Celescope Catalog", "CEL 1157"},
        {"Geneva Identification System", "GEN# +1.00043496"},
        {"Smithsonian Astrophysical Observation", "SAO 95486"},
        {"Wilson Evans Batten Catalogue", "WEB 5905"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.27619664),
        dec: Angle.Degrees(+15.85058606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44768"},
        {"Hipparcos Number", "HIP 30460"},
        {"Celescope Catalog", "CEL 1217"},
        {"Geneva Identification System", "GEN# +1.00044768"},
        {"Smithsonian Astrophysical Observation", "SAO 95627"},
        {"Wilson Evans Batten Catalogue", "WEB 6064"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.04876836),
        dec: Angle.Degrees(+15.85086717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87071"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.88954426),
        dec: Angle.Degrees(+15.85112560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28677"},
        {"Hipparcos Number", "HIP 21137"},
        {"Celescope Catalog", "CEL 426"},
        {"Geneva Identification System", "GEN# +5.20250089"},
        {"Smithsonian Astrophysical Observation", "SAO 93993"},
        {"Wilson Evans Batten Catalogue", "WEB 4065"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.96538757),
        dec: Angle.Degrees(+15.85163870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71426"},
        {"Smithsonian Astrophysical Observation", "SAO 101101"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.09154224),
        dec: Angle.Degrees(+15.85267986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36602"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.91246684),
        dec: Angle.Degrees(+15.85466174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33045"},
        {"Hipparcos Number", "HIP 23897"},
        {"Smithsonian Astrophysical Observation", "SAO 94340"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02400213),
        dec: Angle.Degrees(+15.85527033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19080"},
        {"Hipparcos Number", "HIP 14318"},
        {"Smithsonian Astrophysical Observation", "SAO 93260"},
        {"Wilson Evans Batten Catalogue", "WEB 2800"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.16938282),
        dec: Angle.Degrees(+15.85624608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15599 AB"},
        {"Henry Draper", "HD 209622"},
        {"Hipparcos Number", "HIP 108961"},
        {"Smithsonian Astrophysical Observation", "SAO 107636"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.12548654),
        dec: Angle.Degrees(+15.85795422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177983"},
        {"Hipparcos Number", "HIP 93814"},
        {"Geneva Identification System", "GEN# +1.00177983"},
        {"Renson", "Renson 49580"},
        {"Smithsonian Astrophysical Observation", "SAO 104478"},
        {"Wilson Evans Batten Catalogue", "WEB 16311"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.58246460),
        dec: Angle.Degrees(+15.86130769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77986"},
        {"Hipparcos Number", "HIP 44672"},
        {"Geneva Identification System", "GEN# +1.00077986"},
        {"Smithsonian Astrophysical Observation", "SAO 98361"},
        {"Wilson Evans Batten Catalogue", "WEB 8545"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.55242521),
        dec: Angle.Degrees(+15.86235765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30532"},
        {"Hipparcos Number", "HIP 22376"},
        {"Smithsonian Astrophysical Observation", "SAO 94145"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.25987176),
        dec: Angle.Degrees(+15.86320910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213644"},
        {"Hipparcos Number", "HIP 111296"},
        {"Fundamental Katalog 5th Edition", "FK5 3806"},
        {"Geneva Identification System", "GEN# +1.00213644"},
        {"Smithsonian Astrophysical Observation", "SAO 107989"},
        {"Wilson Evans Batten Catalogue", "WEB 19910"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.19539967),
        dec: Angle.Degrees(+15.86322196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6697"},
        {"Hipparcos Number", "HIP 5304"},
        {"Geneva Identification System", "GEN# +1.00006697"},
        {"Smithsonian Astrophysical Observation", "SAO 92262"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.96512565),
        dec: Angle.Degrees(+15.86331741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58836"},
        {"Geneva Identification System", "GEN# +0.01602332"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.01929865),
        dec: Angle.Degrees(+15.86389511)
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
    primaryId: "HIP 60672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108239"},
        {"Hipparcos Number", "HIP 60672"},
        {"Geneva Identification System", "GEN# +1.00108239"},
        {"Smithsonian Astrophysical Observation", "SAO 100095"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.51365995),
        dec: Angle.Degrees(+15.86391763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85503"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.10135312),
        dec: Angle.Degrees(+15.86401136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86706"},
        {"Hipparcos Number", "HIP 49048"},
        {"Smithsonian Astrophysical Observation", "SAO 98892"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.13175734),
        dec: Angle.Degrees(+15.86431101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285499"},
        {"Hipparcos Number", "HIP 19451"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.48454526),
        dec: Angle.Degrees(+15.86814203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29225"},
        {"Hipparcos Number", "HIP 21474"},
        {"Celescope Catalog", "CEL 443"},
        {"Geneva Identification System", "GEN# +5.20250101"},
        {"Smithsonian Astrophysical Observation", "SAO 94033"},
        {"Wilson Evans Batten Catalogue", "WEB 4122"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.16943714),
        dec: Angle.Degrees(+15.86938453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132950"},
        {"Hipparcos Number", "HIP 73512"},
        {"Geneva Identification System", "GEN# +1.00132950"},
        {"Smithsonian Astrophysical Observation", "SAO 101331"},
        {"Wilson Evans Batten Catalogue", "WEB 12578"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.37463173),
        dec: Angle.Degrees(+15.86946404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50000"},
        {"Smithsonian Astrophysical Observation", "SAO 99001"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11470014),
        dec: Angle.Degrees(+15.87009919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20894",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Chamukuy"},
        {"Henry Draper", "HD 28319"},
        {"Hipparcos Number", "HIP 20894"},
        {"Celescope Catalog", "CEL 407"},
        {"Geneva Identification System", "GEN# +1.00028319"},
        {"Geneva Identification System 2", "GEN# +5.20250072"},
        {"Renson", "Renson 7240"},
        {"Smithsonian Astrophysical Observation", "SAO 93957"},
        {"Wilson Evans Batten Catalogue", "WEB 4012"},
    },
    visualMagnitude: 3.40,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.16531219),
        dec: Angle.Degrees(+15.87094680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86389"},
        {"Smithsonian Astrophysical Observation", "SAO 103001"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.78357267),
        dec: Angle.Degrees(+15.87138437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91784"},
        {"Hipparcos Number", "HIP 51897"},
        {"Cincinnati Publication", "Ci 18 1277"},
        {"Geneva Identification System", "GEN# +1.00091784"},
        {"Smithsonian Astrophysical Observation", "SAO 99199"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.04495279),
        dec: Angle.Degrees(+15.87246305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192954"},
        {"Hipparcos Number", "HIP 99995"},
        {"Fundamental Katalog 5th Edition", "FK5 5790"},
        {"Geneva Identification System", "GEN# +1.00192954"},
        {"Smithsonian Astrophysical Observation", "SAO 105926"},
        {"Wilson Evans Batten Catalogue", "WEB 18000"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.29074643),
        dec: Angle.Degrees(+15.87269533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35770"},
        {"Hipparcos Number", "HIP 25555"},
        {"Celescope Catalog", "CEL 715"},
        {"Geneva Identification System", "GEN# +1.00035770"},
        {"Smithsonian Astrophysical Observation", "SAO 94566"},
        {"Wilson Evans Batten Catalogue", "WEB 4960"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94002438),
        dec: Angle.Degrees(+15.87410386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20605"},
        {"Geneva Identification System", "GEN# +5.20251334"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.19996915),
        dec: Angle.Degrees(+15.87478173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93701"},
        {"Hipparcos Number", "HIP 52918"},
        {"Smithsonian Astrophysical Observation", "SAO 99307"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.34250078),
        dec: Angle.Degrees(+15.87725558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9161 AB"},
        {"Henry Draper", "HD 124387"},
        {"Hipparcos Number", "HIP 69438"},
        {"Smithsonian Astrophysical Observation", "SAO 100916"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24656420),
        dec: Angle.Degrees(+15.87951340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113271"},
        {"Hipparcos Number", "HIP 63629"},
        {"Geneva Identification System", "GEN# +1.00113271"},
        {"Smithsonian Astrophysical Observation", "SAO 100387"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.62033666),
        dec: Angle.Degrees(+15.88070337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30808"},
        {"Hipparcos Number", "HIP 22568"},
        {"Geneva Identification System", "GEN# +1.00030808"},
        {"Smithsonian Astrophysical Observation", "SAO 94166"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.85961841),
        dec: Angle.Degrees(+15.88152699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248515"},
        {"Hipparcos Number", "HIP 27695"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.95252810),
        dec: Angle.Degrees(+15.88209145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216383"},
        {"Hipparcos Number", "HIP 112933"},
        {"Smithsonian Astrophysical Observation", "SAO 108224"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.09076526),
        dec: Angle.Degrees(+15.88240235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195669"},
        {"Hipparcos Number", "HIP 101320"},
        {"Geneva Identification System", "GEN# +1.00195669"},
        {"Smithsonian Astrophysical Observation", "SAO 106212"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.04263862),
        dec: Angle.Degrees(+15.88266524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99122"},
        {"Hipparcos Number", "HIP 55674"},
        {"Geneva Identification System", "GEN# +1.00099122"},
        {"Smithsonian Astrophysical Observation", "SAO 99593"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.11059853),
        dec: Angle.Degrees(+15.88403787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156989"},
        {"Hipparcos Number", "HIP 84807"},
        {"Geneva Identification System", "GEN# +1.00156989"},
        {"Smithsonian Astrophysical Observation", "SAO 102751"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00239657),
        dec: Angle.Degrees(+15.88467781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137985"},
        {"Hipparcos Number", "HIP 75776"},
        {"Smithsonian Astrophysical Observation", "SAO 101573"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.19526793),
        dec: Angle.Degrees(+15.88598670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71370"},
        {"Hipparcos Number", "HIP 41492"},
        {"Geneva Identification System", "GEN# +1.00071370"},
        {"Smithsonian Astrophysical Observation", "SAO 97830"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.93208911),
        dec: Angle.Degrees(+15.88811482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30589"},
        {"Hipparcos Number", "HIP 22422"},
        {"Geneva Identification System", "GEN# +5.20250118"},
        {"Smithsonian Astrophysical Observation", "SAO 94148"},
        {"Wilson Evans Batten Catalogue", "WEB 4326"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38363505),
        dec: Angle.Degrees(+15.88880540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121683"},
        {"Hipparcos Number", "HIP 68108"},
        {"Geneva Identification System", "GEN# +1.00121683"},
        {"Smithsonian Astrophysical Observation", "SAO 100780"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.15410933),
        dec: Angle.Degrees(+15.89095970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61142"},
        {"Geneva Identification System", "GEN# +0.01602385"},
        {"Smithsonian Astrophysical Observation", "SAO 100141"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.94156703),
        dec: Angle.Degrees(+15.89143186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184962"},
        {"Hipparcos Number", "HIP 96434"},
        {"Geneva Identification System", "GEN# +1.00184962"},
        {"Smithsonian Astrophysical Observation", "SAO 105038"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.09576188),
        dec: Angle.Degrees(+15.89218485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62523"},
        {"Hipparcos Number", "HIP 37797"},
        {"Smithsonian Astrophysical Observation", "SAO 97211"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.25248499),
        dec: Angle.Degrees(+15.89503513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43448"},
        {"Smithsonian Astrophysical Observation", "SAO 98166"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.73928580),
        dec: Angle.Degrees(+15.90122047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223972"},
        {"Hipparcos Number", "HIP 117849"},
        {"Geneva Identification System", "GEN# +1.00223972"},
        {"Smithsonian Astrophysical Observation", "SAO 108897"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.52872395),
        dec: Angle.Degrees(+15.90210425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190516"},
        {"Hipparcos Number", "HIP 98879"},
        {"Geneva Identification System", "GEN# +1.00190516"},
        {"Smithsonian Astrophysical Observation", "SAO 105650"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19517246),
        dec: Angle.Degrees(+15.90302119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46031"},
        {"Hipparcos Number", "HIP 31105"},
        {"Geneva Identification System", "GEN# +1.00046031"},
        {"Smithsonian Astrophysical Observation", "SAO 95778"},
        {"Wilson Evans Batten Catalogue", "WEB 6195"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.90599352),
        dec: Angle.Degrees(+15.90353353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3464 A"},
        {"Henry Draper", "HD 30605"},
        {"Hipparcos Number", "HIP 22441"},
        {"Geneva Identification System", "GEN# +1.00030605"},
        {"Smithsonian Astrophysical Observation", "SAO 94151"},
        {"Wilson Evans Batten Catalogue", "WEB 4327"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.43366482),
        dec: Angle.Degrees(+15.90423807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51479"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.72630976),
        dec: Angle.Degrees(+15.90639756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42233"},
        {"Hipparcos Number", "HIP 29274"},
        {"Geneva Identification System", "GEN# +1.00042233"},
        {"Smithsonian Astrophysical Observation", "SAO 95321"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.56439719),
        dec: Angle.Degrees(+15.90654071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14270"},
        {"Aitken 2", "ADS 14270 AB"},
        {"Henry Draper", "HD 197913"},
        {"Hipparcos Number", "HIP 102490"},
        {"Wilson Evans Batten Catalogue", "WEB 18564"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.55521876),
        dec: Angle.Degrees(+15.90715629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187128"},
        {"Hipparcos Number", "HIP 97392"},
        {"Geneva Identification System", "GEN# +1.00187128"},
        {"Renson", "Renson 51570"},
        {"Smithsonian Astrophysical Observation", "SAO 105262"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.91564710),
        dec: Angle.Degrees(+15.90761965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58012"},
        {"Smithsonian Astrophysical Observation", "SAO 99850"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.48452568),
        dec: Angle.Degrees(+15.90858753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117265"},
        {"Hipparcos Number", "HIP 65767"},
        {"Geneva Identification System", "GEN# +1.00117265"},
        {"Smithsonian Astrophysical Observation", "SAO 100588"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25540295),
        dec: Angle.Degrees(+15.91067119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229436"},
        {"Hipparcos Number", "HIP 92107"},
        {"Smithsonian Astrophysical Observation", "SAO 104082"},
    },
    visualMagnitude: 9.13,
    bvColour: 2.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.57945703),
        dec: Angle.Degrees(+15.91116449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101958",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sualocin"},
        {"Common Name 2", "Svalocin"},
        {"Aitken", "ADS 14121 AG"},
        {"Henry Draper", "HD 196867"},
        {"Hipparcos Number", "HIP 101958"},
        {"Fundamental Katalog 5th Edition", "FK5 774"},
        {"Geneva Identification System", "GEN# +1.00196867"},
        {"Smithsonian Astrophysical Observation", "SAO 106357"},
        {"Wilson Evans Batten Catalogue", "WEB 18427"},
    },
    visualMagnitude: 3.77,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90939395),
        dec: Angle.Degrees(+15.91205270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96975"},
        {"Hipparcos Number", "HIP 54573"},
        {"Geneva Identification System", "GEN# +1.00096975"},
        {"Smithsonian Astrophysical Observation", "SAO 99476"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.51629303),
        dec: Angle.Degrees(+15.91296476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195613"},
        {"Hipparcos Number", "HIP 101298"},
        {"Geneva Identification System", "GEN# +1.00195613"},
        {"Smithsonian Astrophysical Observation", "SAO 106205"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.97881383),
        dec: Angle.Degrees(+15.91299396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70855"},
        {"Smithsonian Astrophysical Observation", "SAO 101048"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.34143410),
        dec: Angle.Degrees(+15.91302116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52284"},
        {"Hipparcos Number", "HIP 33818"},
        {"Wilson Evans Batten Catalogue", "WEB 6788"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.30978043),
        dec: Angle.Degrees(+15.91381522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6963 AB"},
        {"Henry Draper", "HD 74406"},
        {"Hipparcos Number", "HIP 42888"},
        {"Smithsonian Astrophysical Observation", "SAO 98083"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.10365821),
        dec: Angle.Degrees(+15.91504536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66115"},
        {"Hipparcos Number", "HIP 39351"},
        {"Smithsonian Astrophysical Observation", "SAO 97500"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.65391243),
        dec: Angle.Degrees(+15.91527407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37254"},
        {"Hipparcos Number", "HIP 26475"},
        {"Geneva Identification System", "GEN# +1.00037254"},
        {"Smithsonian Astrophysical Observation", "SAO 94714"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.47210541),
        dec: Angle.Degrees(+15.91586981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31845"},
        {"Hipparcos Number", "HIP 23214"},
        {"Geneva Identification System", "GEN# +5.20250128"},
        {"Smithsonian Astrophysical Observation", "SAO 94248"},
        {"Wilson Evans Batten Catalogue", "WEB 4509"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.93445971),
        dec: Angle.Degrees(+15.91680509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165848"},
        {"Hipparcos Number", "HIP 88772"},
        {"Cincinnati Publication", "Ci 18 2398"},
        {"Fundamental Katalog 5th Edition", "FK5 5598"},
        {"Geneva Identification System", "GEN# +1.00165848"},
        {"Smithsonian Astrophysical Observation", "SAO 103398"},
        {"Wilson Evans Batten Catalogue", "WEB 15040"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83830795),
        dec: Angle.Degrees(+15.91684491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29488"},
        {"Hipparcos Number", "HIP 21683"},
        {"Celescope Catalog", "CEL 451"},
        {"Fundamental Katalog 5th Edition", "FK5 2345"},
        {"Geneva Identification System", "GEN# +5.20250108"},
        {"Smithsonian Astrophysical Observation", "SAO 94054"},
        {"Wilson Evans Batten Catalogue", "WEB 4167"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.81854938),
        dec: Angle.Degrees(+15.91802420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135221"},
        {"Hipparcos Number", "HIP 74507"},
        {"Fundamental Katalog 5th Edition", "FK5 5353"},
        {"Geneva Identification System", "GEN# +1.00135221"},
        {"Smithsonian Astrophysical Observation", "SAO 101445"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.38283240),
        dec: Angle.Degrees(+15.92226341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99811"},
        {"Hipparcos Number", "HIP 56030"},
        {"Smithsonian Astrophysical Observation", "SAO 99622"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.25605877),
        dec: Angle.Degrees(+15.92244927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117117"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.14475915),
        dec: Angle.Degrees(+15.92258070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119127"},
        {"Hipparcos Number", "HIP 66773"},
        {"Geneva Identification System", "GEN# +1.00119127"},
        {"Smithsonian Astrophysical Observation", "SAO 100662"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.29278305),
        dec: Angle.Degrees(+15.92899708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35071"},
        {"Geneva Identification System", "GEN# +9.80088016"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.78609385),
        dec: Angle.Degrees(+15.92956622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9758"},
        {"Smithsonian Astrophysical Observation", "SAO 92785"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37265482),
        dec: Angle.Degrees(+15.92966342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12053"},
        {"Hipparcos Number", "HIP 9229"},
        {"Geneva Identification System", "GEN# +1.00012053"},
        {"Smithsonian Astrophysical Observation", "SAO 92731"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.66023493),
        dec: Angle.Degrees(+15.93012016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5812 A"},
        {"Henry Draper", "HD 54131"},
        {"Hipparcos Number", "HIP 34440"},
        {"Geneva Identification System", "GEN# +1.00054131"},
        {"Smithsonian Astrophysical Observation", "SAO 96535"},
        {"Wilson Evans Batten Catalogue", "WEB 6900"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09184320),
        dec: Angle.Degrees(+15.93092642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31138"},
        {"Hipparcos Number", "HIP 22773"},
        {"Geneva Identification System", "GEN# +1.00031138"},
        {"Smithsonian Astrophysical Observation", "SAO 94185"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48185348),
        dec: Angle.Degrees(+15.93195807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208007"},
        {"Hipparcos Number", "HIP 108012"},
        {"Smithsonian Astrophysical Observation", "SAO 107465"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.24312824),
        dec: Angle.Degrees(+15.93210090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188038"},
        {"Hipparcos Number", "HIP 97817"},
        {"Smithsonian Astrophysical Observation", "SAO 105365"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.15718997),
        dec: Angle.Degrees(+15.93313464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285691"},
        {"Hipparcos Number", "HIP 20290"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22837827),
        dec: Angle.Degrees(+15.93393798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174391"},
        {"Hipparcos Number", "HIP 92393"},
        {"Geneva Identification System", "GEN# +1.00174391"},
        {"Smithsonian Astrophysical Observation", "SAO 104154"},
        {"Wilson Evans Batten Catalogue", "WEB 15957"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.42696490),
        dec: Angle.Degrees(+15.93456178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223290"},
        {"Hipparcos Number", "HIP 117396"},
        {"Smithsonian Astrophysical Observation", "SAO 108843"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.05335986),
        dec: Angle.Degrees(+15.93732501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80410"},
        {"Hipparcos Number", "HIP 45777"},
        {"Geneva Identification System", "GEN# +1.00080410"},
        {"Smithsonian Astrophysical Observation", "SAO 98504"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.00637960),
        dec: Angle.Degrees(+15.93744906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3519"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.23454099),
        dec: Angle.Degrees(+15.93992374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
