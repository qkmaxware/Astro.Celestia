using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_20() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169881"},
        {"Hipparcos Number", "HIP 90585"},
        {"Geneva Identification System", "GEN# +1.00169881"},
        {"Smithsonian Astrophysical Observation", "SAO 229054"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.26548881),
        dec: Angle.Degrees(-47.18214892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224764"},
        {"Hipparcos Number", "HIP 37"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.10535190),
        dec: Angle.Degrees(-47.17958382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10101"},
        {"Hipparcos Number", "HIP 7591"},
        {"Geneva Identification System", "GEN# +1.00010101"},
        {"Smithsonian Astrophysical Observation", "SAO 215588"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.44110765),
        dec: Angle.Degrees(-47.17818463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1762"},
        {"Hipparcos Number", "HIP 1723"},
        {"Smithsonian Astrophysical Observation", "SAO 215062"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.41571102),
        dec: Angle.Degrees(-47.17771270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126062"},
        {"Hipparcos Number", "HIP 70441"},
        {"Geneva Identification System", "GEN# +1.00126062"},
        {"Smithsonian Astrophysical Observation", "SAO 224901"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.15425170),
        dec: Angle.Degrees(-47.17768560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143167"},
        {"Hipparcos Number", "HIP 78447"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.22680084),
        dec: Angle.Degrees(-47.17659567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224298"},
        {"Hipparcos Number", "HIP 118052"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.18516381),
        dec: Angle.Degrees(-47.17659566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206714"},
        {"Hipparcos Number", "HIP 107405"},
        {"Smithsonian Astrophysical Observation", "SAO 230823"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.32257029),
        dec: Angle.Degrees(-47.17502445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197713"},
        {"Hipparcos Number", "HIP 102579"},
        {"Geneva Identification System", "GEN# +1.00197713"},
        {"Smithsonian Astrophysical Observation", "SAO 230367"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.81618347),
        dec: Angle.Degrees(-47.17280705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13666"},
        {"Hipparcos Number", "HIP 10254"},
        {"Fundamental Katalog 5th Edition", "FK5 2152"},
        {"Smithsonian Astrophysical Observation", "SAO 215812"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97633594),
        dec: Angle.Degrees(-47.17025830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23494"},
        {"Hipparcos Number", "HIP 17397"},
        {"Smithsonian Astrophysical Observation", "SAO 216458"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.90851016),
        dec: Angle.Degrees(-47.16900503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112065"},
        {"Hipparcos Number", "HIP 62970"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.55426923),
        dec: Angle.Degrees(-47.16557763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20551"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.04931754),
        dec: Angle.Degrees(-47.16379386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3236"},
        {"Hipparcos Number", "HIP 2757"},
        {"Smithsonian Astrophysical Observation", "SAO 215153"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.80222348),
        dec: Angle.Degrees(-47.16287742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172607"},
        {"Hipparcos Number", "HIP 91844"},
        {"Smithsonian Astrophysical Observation", "SAO 229225"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.87576861),
        dec: Angle.Degrees(-47.16165952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153791"},
        {"Hipparcos Number", "HIP 83481"},
        {"Smithsonian Astrophysical Observation", "SAO 227588"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.92368071),
        dec: Angle.Degrees(-47.16058422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92550"},
        {"Hipparcos Number", "HIP 52230"},
        {"Geneva Identification System", "GEN# +1.00092550"},
        {"Smithsonian Astrophysical Observation", "SAO 222245"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.06227384),
        dec: Angle.Degrees(-47.16026487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178445"},
        {"Hipparcos Number", "HIP 94225"},
        {"Cincinnati Publication", "Ci 20 1133"},
        {"Geneva Identification System", "GEN# +1.00178445"},
        {"Wilson Evans Batten Catalogue", "WEB 16412"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.71798899),
        dec: Angle.Degrees(-47.15707728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -634.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28131"},
        {"Hipparcos Number", "HIP 20538"},
        {"Smithsonian Astrophysical Observation", "SAO 216781"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.01462208),
        dec: Angle.Degrees(-47.15671000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119781"},
        {"Hipparcos Number", "HIP 67202"},
        {"Smithsonian Astrophysical Observation", "SAO 224410"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57342997),
        dec: Angle.Degrees(-47.15600806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61194"},
        {"Hipparcos Number", "HIP 36957"},
        {"Smithsonian Astrophysical Observation", "SAO 218827"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.97023286),
        dec: Angle.Degrees(-47.15567785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20201"},
        {"Hipparcos Number", "HIP 14964"},
        {"Geneva Identification System", "GEN# +1.00020201"},
        {"Smithsonian Astrophysical Observation", "SAO 216214"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.22690163),
        dec: Angle.Degrees(-47.15518725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132667"},
        {"Hipparcos Number", "HIP 73556"},
        {"Geneva Identification System", "GEN# +1.00132667"},
        {"Smithsonian Astrophysical Observation", "SAO 225383"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48730460),
        dec: Angle.Degrees(-47.15331465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4365"},
        {"Geneva Identification System", "GEN# +6.20145179"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.98567842),
        dec: Angle.Degrees(-47.14959737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14843"},
        {"Hipparcos Number", "HIP 11036"},
        {"Smithsonian Astrophysical Observation", "SAO 215879"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52821857),
        dec: Angle.Degrees(-47.14851763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98636"},
        {"Hipparcos Number", "HIP 55384"},
        {"Geneva Identification System", "GEN# +1.00098636"},
        {"Smithsonian Astrophysical Observation", "SAO 222727"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.11384115),
        dec: Angle.Degrees(-47.14677472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82729"},
        {"Hipparcos Number", "HIP 46808"},
        {"Geneva Identification System", "GEN# +1.00082729"},
        {"Smithsonian Astrophysical Observation", "SAO 221265"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.07107449),
        dec: Angle.Degrees(-47.14635604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209140"},
        {"Hipparcos Number", "HIP 108792"},
        {"Smithsonian Astrophysical Observation", "SAO 230950"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.58263708),
        dec: Angle.Degrees(-47.14586528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4910"},
        {"Hipparcos Number", "HIP 3939"},
        {"Smithsonian Astrophysical Observation", "SAO 215259"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.64600613),
        dec: Angle.Degrees(-47.14309563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29691"},
        {"Hipparcos Number", "HIP 21606"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.57662056),
        dec: Angle.Degrees(-47.14156085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14953"},
        {"Hipparcos Number", "HIP 11127"},
        {"Smithsonian Astrophysical Observation", "SAO 215886"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.80302224),
        dec: Angle.Degrees(-47.14082061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165934"},
        {"Henry Draper 2", "HD 165935"},
        {"Hipparcos Number", "HIP 89064"},
        {"Smithsonian Astrophysical Observation", "SAO 228765"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.66567283),
        dec: Angle.Degrees(-47.14055471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155510"},
        {"Hipparcos Number", "HIP 84324"},
        {"Geneva Identification System", "GEN# +1.00155510"},
        {"Smithsonian Astrophysical Observation", "SAO 227730"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.58403435),
        dec: Angle.Degrees(-47.13900348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6644"},
        {"Smithsonian Astrophysical Observation", "SAO 147796"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.30324735),
        dec: Angle.Degrees(-16.91085991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157698"},
        {"Hipparcos Number", "HIP 85398"},
        {"Celescope Catalog", "CEL 4515"},
        {"Geneva Identification System", "GEN# +1.00157698"},
        {"Smithsonian Astrophysical Observation", "SAO 227974"},
        {"Wilson Evans Batten Catalogue", "WEB 14426"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.76487286),
        dec: Angle.Degrees(-47.13650841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56438"},
        {"Hipparcos Number", "HIP 35016"},
        {"Geneva Identification System", "GEN# +1.00056438"},
        {"Smithsonian Astrophysical Observation", "SAO 218565"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.65174127),
        dec: Angle.Degrees(-47.13499881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30861"},
        {"Hipparcos Number", "HIP 22370"},
        {"Smithsonian Astrophysical Observation", "SAO 217011"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.23931904),
        dec: Angle.Degrees(-47.13459876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125668"},
        {"Hipparcos Number", "HIP 70238"},
        {"Smithsonian Astrophysical Observation", "SAO 224868"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.56411707),
        dec: Angle.Degrees(-47.13320511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17741"},
        {"Hipparcos Number", "HIP 13159"},
        {"Smithsonian Astrophysical Observation", "SAO 216060"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.30733188),
        dec: Angle.Degrees(-47.13264256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6938"},
        {"Hipparcos Number", "HIP 5411"},
        {"Smithsonian Astrophysical Observation", "SAO 215385"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30130439),
        dec: Angle.Degrees(-47.13080794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159346"},
        {"Hipparcos Number", "HIP 86177"},
        {"Smithsonian Astrophysical Observation", "SAO 228179"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.15032222),
        dec: Angle.Degrees(-47.12966389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16977"},
        {"Hipparcos Number", "HIP 12573"},
        {"Smithsonian Astrophysical Observation", "SAO 216009"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.42355160),
        dec: Angle.Degrees(-47.12907477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120991"},
        {"Hipparcos Number", "HIP 67861"},
        {"Celescope Catalog", "CEL 4286"},
        {"Geneva Identification System", "GEN# +1.00120991A"},
        {"Smithsonian Astrophysical Observation", "SAO 224514"},
        {"Wilson Evans Batten Catalogue", "WEB 11930"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48852887),
        dec: Angle.Degrees(-47.12815361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99541"},
        {"Hipparcos Number", "HIP 55845"},
        {"Smithsonian Astrophysical Observation", "SAO 222801"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.68667635),
        dec: Angle.Degrees(-47.12718521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117478"},
        {"Smithsonian Astrophysical Observation", "SAO 231792"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.31669218),
        dec: Angle.Degrees(-47.12655538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73077"},
        {"Hipparcos Number", "HIP 42066"},
        {"Geneva Identification System", "GEN# +1.00073077"},
        {"Smithsonian Astrophysical Observation", "SAO 220127"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.61132689),
        dec: Angle.Degrees(-47.12616237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172580"},
        {"Hipparcos Number", "HIP 91830"},
        {"Smithsonian Astrophysical Observation", "SAO 229222"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.84342799),
        dec: Angle.Degrees(-47.12147666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68617"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69640617),
        dec: Angle.Degrees(-47.12029681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330884"},
        {"Hipparcos Number", "HIP 80979"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.05534736),
        dec: Angle.Degrees(-47.11868089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113537"},
        {"Hipparcos Number", "HIP 63849"},
        {"Fundamental Katalog 5th Edition", "FK5 3042"},
        {"Geneva Identification System", "GEN# +1.00113537"},
        {"Smithsonian Astrophysical Observation", "SAO 223885"},
        {"Wilson Evans Batten Catalogue", "WEB 11288"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.27790912),
        dec: Angle.Degrees(-47.11682708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74773"},
        {"Hipparcos Number", "HIP 42868"},
        {"Celescope Catalog", "CEL 2839"},
        {"Geneva Identification System", "GEN# +1.00074773"},
        {"Smithsonian Astrophysical Observation", "SAO 220368"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.04049264),
        dec: Angle.Degrees(-47.11612556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4715"},
        {"Hipparcos Number", "HIP 3790"},
        {"Smithsonian Astrophysical Observation", "SAO 215242"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.17614633),
        dec: Angle.Degrees(-47.11597350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109842"},
        {"Hipparcos Number", "HIP 61647"},
        {"Geneva Identification System", "GEN# +1.00109842"},
        {"Smithsonian Astrophysical Observation", "SAO 223563"},
        {"Wilson Evans Batten Catalogue", "WEB 10968"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.56819863),
        dec: Angle.Degrees(-47.11521272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128192"},
        {"Hipparcos Number", "HIP 71479"},
        {"Smithsonian Astrophysical Observation", "SAO 225058"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26510745),
        dec: Angle.Degrees(-47.11403799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57190"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90376251),
        dec: Angle.Degrees(-47.11391516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139259"},
        {"Hipparcos Number", "HIP 76644"},
        {"Smithsonian Astrophysical Observation", "SAO 226018"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.76996181),
        dec: Angle.Degrees(-47.11245866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10077"},
        {"Hipparcos Number", "HIP 7573"},
        {"Geneva Identification System", "GEN# +1.00010077"},
        {"Smithsonian Astrophysical Observation", "SAO 215586"},
        {"Wilson Evans Batten Catalogue", "WEB 1621"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.38449331),
        dec: Angle.Degrees(-47.11182627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101911"},
        {"Hipparcos Number", "HIP 57186"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89990092),
        dec: Angle.Degrees(-47.11046363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330399"},
        {"Hipparcos Number", "HIP 79456"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21872274),
        dec: Angle.Degrees(-47.10913230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59502"},
        {"Hipparcos Number", "HIP 36259"},
        {"Fundamental Katalog 5th Edition", "FK5 4671"},
        {"Smithsonian Astrophysical Observation", "SAO 218746"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.99689607),
        dec: Angle.Degrees(-47.10764772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31228"},
        {"Hipparcos Number", "HIP 22598"},
        {"Smithsonian Astrophysical Observation", "SAO 217046"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.93154446),
        dec: Angle.Degrees(-47.10749584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149900"},
        {"Hipparcos Number", "HIP 81599"},
        {"Geneva Identification System", "GEN# +1.00149900"},
        {"Smithsonian Astrophysical Observation", "SAO 227017"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.96114093),
        dec: Angle.Degrees(-47.10668561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150500"},
        {"Hipparcos Number", "HIP 81900"},
        {"Geneva Identification System", "GEN# +1.00150500"},
        {"Renson", "Renson 42580"},
        {"Smithsonian Astrophysical Observation", "SAO 227109"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.93487247),
        dec: Angle.Degrees(-47.10566546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156030"},
        {"Hipparcos Number", "HIP 84591"},
        {"Smithsonian Astrophysical Observation", "SAO 227783"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.37503417),
        dec: Angle.Degrees(-47.10412961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115510"},
        {"Hipparcos Number", "HIP 64919"},
        {"Renson", "Renson 33370"},
        {"Smithsonian Astrophysical Observation", "SAO 224049"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.59730063),
        dec: Angle.Degrees(-47.10252393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7270"},
        {"Hipparcos Number", "HIP 5624"},
        {"Smithsonian Astrophysical Observation", "SAO 215410"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.05848601),
        dec: Angle.Degrees(-47.10194481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137039"},
        {"Hipparcos Number", "HIP 75515"},
        {"Geneva Identification System", "GEN# +1.00137039"},
        {"Smithsonian Astrophysical Observation", "SAO 225763"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.40808826),
        dec: Angle.Degrees(-47.09923094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126548"},
        {"Hipparcos Number", "HIP 70690"},
        {"Geneva Identification System", "GEN# +1.00126548"},
        {"Smithsonian Astrophysical Observation", "SAO 224935"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.87801558),
        dec: Angle.Degrees(-47.09901341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89680"},
        {"Hipparcos Number", "HIP 50578"},
        {"Geneva Identification System", "GEN# +1.00089680"},
        {"Renson", "Renson 25750"},
        {"Smithsonian Astrophysical Observation", "SAO 221962"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.97290718),
        dec: Angle.Degrees(-47.09900283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96175"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.33241222),
        dec: Angle.Degrees(-47.09823362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78004"},
        {"Hipparcos Number", "HIP 44511"},
        {"Fundamental Katalog 5th Edition", "FK5 342"},
        {"Geneva Identification System", "GEN# +1.00078004"},
        {"Smithsonian Astrophysical Observation", "SAO 220803"},
        {"Wilson Evans Batten Catalogue", "WEB 8527"},
    },
    visualMagnitude: 3.75,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.03883562),
        dec: Angle.Degrees(-47.09771376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27318"},
        {"Hipparcos Number", "HIP 19942"},
        {"Smithsonian Astrophysical Observation", "SAO 216732"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.15936158),
        dec: Angle.Degrees(-47.09652772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59421"},
        {"Hipparcos Number", "HIP 36226"},
        {"Geneva Identification System", "GEN# +1.00059421"},
        {"Smithsonian Astrophysical Observation", "SAO 218740"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.89627678),
        dec: Angle.Degrees(-47.09589949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85967"},
        {"Hipparcos Number", "HIP 48551"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52694054),
        dec: Angle.Degrees(-47.09459255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35874"},
        {"Hipparcos Number", "HIP 25358"},
        {"Smithsonian Astrophysical Observation", "SAO 217330"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.34599370),
        dec: Angle.Degrees(-47.09420932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183769"},
        {"Hipparcos Number", "HIP 96170"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.31716505),
        dec: Angle.Degrees(-47.09251542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86739"},
        {"Hipparcos Number", "HIP 48955"},
        {"Geneva Identification System", "GEN# +1.00086739"},
        {"Smithsonian Astrophysical Observation", "SAO 221665"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.80158355),
        dec: Angle.Degrees(-47.09232442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121226"},
        {"Hipparcos Number", "HIP 67975"},
        {"Geneva Identification System", "GEN# +1.00121226"},
        {"Smithsonian Astrophysical Observation", "SAO 224534"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.80605043),
        dec: Angle.Degrees(-47.09219077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70084"},
        {"Hipparcos Number", "HIP 40662"},
        {"Celescope Catalog", "CEL 2341"},
        {"Geneva Identification System", "GEN# +1.00070084"},
        {"Smithsonian Astrophysical Observation", "SAO 219751"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.50480614),
        dec: Angle.Degrees(-47.09188776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74618"},
        {"Hipparcos Number", "HIP 42789"},
        {"Geneva Identification System", "GEN# +1.00074618"},
        {"Smithsonian Astrophysical Observation", "SAO 220343"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.77944966),
        dec: Angle.Degrees(-47.09025919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169977"},
        {"Hipparcos Number", "HIP 90620"},
        {"Fundamental Katalog 5th Edition", "FK5 5622"},
        {"Smithsonian Astrophysical Observation", "SAO 229058"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.36484611),
        dec: Angle.Degrees(-47.08574492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26753"},
        {"Hipparcos Number", "HIP 19577"},
        {"Geneva Identification System", "GEN# +1.00026753"},
        {"Smithsonian Astrophysical Observation", "SAO 216685"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.92884544),
        dec: Angle.Degrees(-47.08550254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130761"},
        {"Hipparcos Number", "HIP 72672"},
        {"Geneva Identification System", "GEN# +1.00130761"},
        {"Smithsonian Astrophysical Observation", "SAO 225245"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.87794515),
        dec: Angle.Degrees(-47.08328396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63744"},
        {"Hipparcos Number", "HIP 38089"},
        {"Geneva Identification System", "GEN# +1.00063744"},
        {"Smithsonian Astrophysical Observation", "SAO 219018"},
        {"Wilson Evans Batten Catalogue", "WEB 7507"},
    },
    visualMagnitude: 4.69,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.08436527),
        dec: Angle.Degrees(-47.07753199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36553"},
        {"Hipparcos Number", "HIP 25768"},
        {"Fundamental Katalog 5th Edition", "FK5 1152"},
        {"Geneva Identification System", "GEN# +1.00036553A"},
        {"Smithsonian Astrophysical Observation", "SAO 217368"},
        {"Wilson Evans Batten Catalogue", "WEB 5006"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.53942437),
        dec: Angle.Degrees(-47.07733403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36520"},
        {"Hipparcos Number", "HIP 25746"},
        {"Geneva Identification System", "GEN# +1.00036520"},
        {"Smithsonian Astrophysical Observation", "SAO 217365"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.45880477),
        dec: Angle.Degrees(-47.07627039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180236"},
        {"Hipparcos Number", "HIP 94849"},
        {"Smithsonian Astrophysical Observation", "SAO 229602"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.49656714),
        dec: Angle.Degrees(-47.07454747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171502"},
        {"Hipparcos Number", "HIP 91301"},
        {"Geneva Identification System", "GEN# +1.00171502"},
        {"Smithsonian Astrophysical Observation", "SAO 229148"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.35747037),
        dec: Angle.Degrees(-47.07454249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127977"},
        {"Hipparcos Number", "HIP 71385"},
        {"Smithsonian Astrophysical Observation", "SAO 225051"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.96503647),
        dec: Angle.Degrees(-47.07385337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104615"},
        {"Hipparcos Number", "HIP 58732"},
        {"Smithsonian Astrophysical Observation", "SAO 223184"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69927748),
        dec: Angle.Degrees(-47.07295670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103746"},
        {"Hipparcos Number", "HIP 58242"},
        {"Geneva Identification System", "GEN# +1.00103746"},
        {"Smithsonian Astrophysical Observation", "SAO 223127"},
        {"Wilson Evans Batten Catalogue", "WEB 10423"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18343317),
        dec: Angle.Degrees(-47.07243569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127154"},
        {"Hipparcos Number", "HIP 71003"},
        {"Geneva Identification System", "GEN# +1.00127154"},
        {"Renson", "Renson 36170"},
        {"Smithsonian Astrophysical Observation", "SAO 224986"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.82570672),
        dec: Angle.Degrees(-47.07212034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3887"},
        {"Hipparcos Number", "HIP 3224"},
        {"Smithsonian Astrophysical Observation", "SAO 215193"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.24560283),
        dec: Angle.Degrees(-47.06988212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154043"},
        {"Hipparcos Number", "HIP 83603"},
        {"Geneva Identification System", "GEN# +1.00154043"},
        {"Smithsonian Astrophysical Observation", "SAO 227604"},
        {"Wilson Evans Batten Catalogue", "WEB 14136"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.32866292),
        dec: Angle.Degrees(-47.06902876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225208"},
        {"Hipparcos Number", "HIP 351"},
        {"Geneva Identification System", "GEN# +1.00225208"},
        {"Smithsonian Astrophysical Observation", "SAO 214950"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.10262290),
        dec: Angle.Degrees(-47.06812971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190879"},
        {"Hipparcos Number", "HIP 99270"},
        {"Geneva Identification System", "GEN# +1.00190879"},
        {"Smithsonian Astrophysical Observation", "SAO 230067"},
        {"Wilson Evans Batten Catalogue", "WEB 17695"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.26588449),
        dec: Angle.Degrees(-47.06777265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112565"},
        {"Hipparcos Number", "HIP 63287"},
        {"Geneva Identification System", "GEN# +1.00112565"},
        {"Smithsonian Astrophysical Observation", "SAO 223793"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.54509467),
        dec: Angle.Degrees(-47.06493358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171925"},
        {"Hipparcos Number", "HIP 91508"},
        {"Smithsonian Astrophysical Observation", "SAO 229171"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.92747339),
        dec: Angle.Degrees(-47.06226108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219320"},
        {"Hipparcos Number", "HIP 114808"},
        {"Smithsonian Astrophysical Observation", "SAO 231517"},
    },
    visualMagnitude: 9.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.84549614),
        dec: Angle.Degrees(-47.06160075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141544"},
        {"Hipparcos Number", "HIP 77678"},
        {"Geneva Identification System", "GEN# +1.00141544"},
        {"Smithsonian Astrophysical Observation", "SAO 226295"},
        {"Wilson Evans Batten Catalogue", "WEB 13143"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.88131664),
        dec: Angle.Degrees(-47.06071935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 439"},
        {"Hipparcos Number", "HIP 709"},
        {"Fundamental Katalog 5th Edition", "FK5 4017"},
        {"Geneva Identification System", "GEN# +1.00000439"},
        {"Smithsonian Astrophysical Observation", "SAO 214978"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.20171313),
        dec: Angle.Degrees(-47.06066168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216973"},
        {"Hipparcos Number", "HIP 113397"},
        {"Smithsonian Astrophysical Observation", "SAO 231369"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.48290881),
        dec: Angle.Degrees(-47.06006006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100367"},
        {"Hipparcos Number", "HIP 56304"},
        {"Smithsonian Astrophysical Observation", "SAO 222855"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.14349990),
        dec: Angle.Degrees(-47.05965158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81401"},
        {"Hipparcos Number", "HIP 46084"},
        {"Geneva Identification System", "GEN# +1.00081401"},
        {"Smithsonian Astrophysical Observation", "SAO 221134"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.96176764),
        dec: Angle.Degrees(-47.05942661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62010"},
        {"Hipparcos Number", "HIP 37324"},
        {"Smithsonian Astrophysical Observation", "SAO 218880"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.93736948),
        dec: Angle.Degrees(-47.05774686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97547"},
        {"Hipparcos Number", "HIP 54795"},
        {"Smithsonian Astrophysical Observation", "SAO 222645"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27124097),
        dec: Angle.Degrees(-47.05522501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31301"},
        {"Geneva Identification System", "GEN# -0.04602512"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.46161608),
        dec: Angle.Degrees(-47.05513394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14226"},
        {"Hipparcos Number", "HIP 10620"},
        {"Smithsonian Astrophysical Observation", "SAO 215850"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.18258547),
        dec: Angle.Degrees(-47.05482714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202729"},
        {"Hipparcos Number", "HIP 105266"},
        {"Geneva Identification System", "GEN# +1.00202729"},
        {"Smithsonian Astrophysical Observation", "SAO 230628"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.83556474),
        dec: Angle.Degrees(-47.05449613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139679"},
        {"Hipparcos Number", "HIP 76845"},
        {"Smithsonian Astrophysical Observation", "SAO 226066"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.36266049),
        dec: Angle.Degrees(-47.05321770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143883"},
        {"Hipparcos Number", "HIP 78776"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23883159),
        dec: Angle.Degrees(-47.05121632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73807"},
        {"Celescope Catalog", "CEL 4336"},
        {"Geneva Identification System", "GEN# +1.00133242"},
        {"Smithsonian Astrophysical Observation", "SAO 225426"},
        {"Wilson Evans Batten Catalogue", "WEB 12611"},
    },
    visualMagnitude: 3.91,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.27960699),
        dec: Angle.Degrees(-47.05119386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176578"},
        {"Hipparcos Number", "HIP 93546"},
        {"Geneva Identification System", "GEN# +1.00176578"},
        {"Smithsonian Astrophysical Observation", "SAO 229459"},
        {"Wilson Evans Batten Catalogue", "WEB 16247"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.79382321),
        dec: Angle.Degrees(-47.05103788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173107"},
        {"Hipparcos Number", "HIP 92077"},
        {"Geneva Identification System", "GEN# +1.00173107"},
        {"Smithsonian Astrophysical Observation", "SAO 229252"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.49867944),
        dec: Angle.Degrees(-47.04928767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35116"},
        {"Hipparcos Number", "HIP 24876"},
        {"Smithsonian Astrophysical Observation", "SAO 217288"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00198605),
        dec: Angle.Degrees(-47.04879899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62755"},
        {"Hipparcos Number", "HIP 37637"},
        {"Geneva Identification System", "GEN# +1.00062755"},
        {"Smithsonian Astrophysical Observation", "SAO 218929"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.84623792),
        dec: Angle.Degrees(-47.04667410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72327"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.85079247),
        dec: Angle.Degrees(-47.04628228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78186"},
        {"Hipparcos Number", "HIP 44598"},
        {"Smithsonian Astrophysical Observation", "SAO 220821"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.28303349),
        dec: Angle.Degrees(-47.04574695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67314"},
        {"Hipparcos Number", "HIP 39576"},
        {"Geneva Identification System", "GEN# +1.00067314"},
        {"Smithsonian Astrophysical Observation", "SAO 219395"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.30412733),
        dec: Angle.Degrees(-47.04556150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109173"},
        {"Hipparcos Number", "HIP 61248"},
        {"Smithsonian Astrophysical Observation", "SAO 223503"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.27644822),
        dec: Angle.Degrees(-47.04548382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72752"},
        {"Hipparcos Number", "HIP 41905"},
        {"Geneva Identification System", "GEN# +1.00072752"},
        {"Smithsonian Astrophysical Observation", "SAO 220080"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.16880542),
        dec: Angle.Degrees(-47.04213104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89578"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.18799810),
        dec: Angle.Degrees(-47.03960097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19605"},
        {"Hipparcos Number", "HIP 14527"},
        {"Geneva Identification System", "GEN# +1.00019605"},
        {"Smithsonian Astrophysical Observation", "SAO 216175"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.89579201),
        dec: Angle.Degrees(-47.03935966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93722"},
        {"Hipparcos Number", "HIP 52852"},
        {"Smithsonian Astrophysical Observation", "SAO 222341"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.10899307),
        dec: Angle.Degrees(-47.03797653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134977"},
        {"Hipparcos Number", "HIP 74592"},
        {"Smithsonian Astrophysical Observation", "SAO 225564"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61515386),
        dec: Angle.Degrees(-47.03791475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115955"},
        {"Geneva Identification System", "GEN# -0.04714591"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.39265949),
        dec: Angle.Degrees(-47.03584483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202454"},
        {"Hipparcos Number", "HIP 105109"},
        {"Smithsonian Astrophysical Observation", "SAO 230613"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.36943982),
        dec: Angle.Degrees(-47.03302614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154811"},
        {"Hipparcos Number", "HIP 83973"},
        {"Celescope Catalog", "CEL 4481"},
        {"Geneva Identification System", "GEN# +1.00154811"},
        {"Smithsonian Astrophysical Observation", "SAO 227679"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.47119753),
        dec: Angle.Degrees(-47.03143010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58139"},
        {"Hipparcos Number", "HIP 35709"},
        {"Smithsonian Astrophysical Observation", "SAO 218674"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.51132219),
        dec: Angle.Degrees(-47.03040331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172128"},
        {"Hipparcos Number", "HIP 91589"},
        {"Smithsonian Astrophysical Observation", "SAO 229184"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.18287968),
        dec: Angle.Degrees(-47.02727395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83152"},
        {"Hipparcos Number", "HIP 47023"},
        {"Geneva Identification System", "GEN# +1.00083152"},
        {"Smithsonian Astrophysical Observation", "SAO 221302"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.75140634),
        dec: Angle.Degrees(-47.02687039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157832"},
        {"Hipparcos Number", "HIP 85467"},
        {"Celescope Catalog", "CEL 4518"},
        {"Geneva Identification System", "GEN# +1.00157832J"},
        {"Smithsonian Astrophysical Observation", "SAO 227990"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.97838303),
        dec: Angle.Degrees(-47.02621716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79772"},
        {"Hipparcos Number", "HIP 45332"},
        {"Smithsonian Astrophysical Observation", "SAO 220979"},
    },
    visualMagnitude: 9.40,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.58497526),
        dec: Angle.Degrees(-47.02400585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141297"},
        {"Hipparcos Number", "HIP 77575"},
        {"Smithsonian Astrophysical Observation", "SAO 226262"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.56845926),
        dec: Angle.Degrees(-47.02390144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52470"},
        {"Hipparcos Number", "HIP 33609"},
        {"Celescope Catalog", "CEL 1485"},
        {"Geneva Identification System", "GEN# +1.00052470"},
        {"Smithsonian Astrophysical Observation", "SAO 218362"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.74995080),
        dec: Angle.Degrees(-47.02333680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328847"},
        {"Hipparcos Number", "HIP 82084"},
        {"Geneva Identification System", "GEN# +2.62040003"},
        {"Smithsonian Astrophysical Observation", "SAO 227168"},
        {"New General Catalogue", "NGC 6204 3"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.50275923),
        dec: Angle.Degrees(-47.02209946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199675"},
        {"Hipparcos Number", "HIP 103676"},
        {"Smithsonian Astrophysical Observation", "SAO 230475"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.11530018),
        dec: Angle.Degrees(-47.02097058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193156"},
        {"Hipparcos Number", "HIP 100317"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17654083),
        dec: Angle.Degrees(-47.01974856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118320"},
        {"Hipparcos Number", "HIP 66437"},
        {"Smithsonian Astrophysical Observation", "SAO 224277"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.29842275),
        dec: Angle.Degrees(-47.01557664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24034"},
        {"Hipparcos Number", "HIP 17724"},
        {"Smithsonian Astrophysical Observation", "SAO 216490"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.92942657),
        dec: Angle.Degrees(-47.01409668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63579"},
        {"Hipparcos Number", "HIP 38028"},
        {"Celescope Catalog", "CEL 2040"},
        {"Geneva Identification System", "GEN# +1.00063579"},
        {"Smithsonian Astrophysical Observation", "SAO 219001"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89672586),
        dec: Angle.Degrees(-47.01297678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43637"},
        {"Hipparcos Number", "HIP 29643"},
        {"Smithsonian Astrophysical Observation", "SAO 217803"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70125119),
        dec: Angle.Degrees(-47.01179014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169055"},
        {"Hipparcos Number", "HIP 90268"},
        {"Smithsonian Astrophysical Observation", "SAO 228999"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.27687579),
        dec: Angle.Degrees(-47.01062364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63007"},
        {"Hipparcos Number", "HIP 37765"},
        {"Smithsonian Astrophysical Observation", "SAO 218949"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.16763314),
        dec: Angle.Degrees(-47.00849198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330570"},
        {"Hipparcos Number", "HIP 80094"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.23497136),
        dec: Angle.Degrees(-47.00815708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132648"},
        {"Hipparcos Number", "HIP 73547"},
        {"Geneva Identification System", "GEN# +1.00132648"},
        {"Smithsonian Astrophysical Observation", "SAO 225381"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.47203595),
        dec: Angle.Degrees(-47.00729487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38792"},
        {"Hipparcos Number", "HIP 27193"},
        {"Geneva Identification System", "GEN# +1.00038792"},
        {"Smithsonian Astrophysical Observation", "SAO 217517"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.45684381),
        dec: Angle.Degrees(-47.00655307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158159"},
        {"Hipparcos Number", "HIP 85629"},
        {"Geneva Identification System", "GEN# +1.00158159"},
        {"Smithsonian Astrophysical Observation", "SAO 228026"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.47594335),
        dec: Angle.Degrees(-47.00634107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33794"},
        {"Hipparcos Number", "HIP 24079"},
        {"Smithsonian Astrophysical Observation", "SAO 217216"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.59407047),
        dec: Angle.Degrees(-47.00550708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17519"},
        {"Hipparcos Number", "HIP 12980"},
        {"Smithsonian Astrophysical Observation", "SAO 216046"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.74139675),
        dec: Angle.Degrees(-47.00535536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328855"},
        {"Hipparcos Number", "HIP 82097"},
        {"Geneva Identification System", "GEN# +2.62040004"},
        {"Smithsonian Astrophysical Observation", "SAO 227173"},
        {"New General Catalogue", "NGC 6204 4"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.55131118),
        dec: Angle.Degrees(-47.00339832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91504"},
        {"Hipparcos Number", "HIP 51635"},
        {"Fundamental Katalog 5th Edition", "FK5 1273"},
        {"Geneva Identification System", "GEN# +1.00091504"},
        {"Smithsonian Astrophysical Observation", "SAO 222136"},
        {"Wilson Evans Batten Catalogue", "WEB 9419"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.23700305),
        dec: Angle.Degrees(-47.00336923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202593"},
        {"Hipparcos Number", "HIP 105185"},
        {"Smithsonian Astrophysical Observation", "SAO 230620"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61313088),
        dec: Angle.Degrees(-47.00216381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40994"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.48771098),
        dec: Angle.Degrees(-47.00100423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172606"},
        {"Hipparcos Number", "HIP 91840"},
        {"Geneva Identification System", "GEN# +1.00172606"},
        {"Smithsonian Astrophysical Observation", "SAO 229224"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.86525421),
        dec: Angle.Degrees(-47.00080899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70643"},
        {"Hipparcos Number", "HIP 40921"},
        {"Celescope Catalog", "CEL 2411"},
        {"Geneva Identification System", "GEN# +1.00070643"},
        {"Smithsonian Astrophysical Observation", "SAO 219818"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.27291528),
        dec: Angle.Degrees(-46.99932486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72252"},
        {"Hipparcos Number", "HIP 41681"},
        {"Geneva Identification System", "GEN# +1.00072252"},
        {"Smithsonian Astrophysical Observation", "SAO 220010"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.45897952),
        dec: Angle.Degrees(-46.99466388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164207"},
        {"Hipparcos Number", "HIP 88327"},
        {"Smithsonian Astrophysical Observation", "SAO 228637"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59397559),
        dec: Angle.Degrees(-46.99345697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70507"},
        {"Hipparcos Number", "HIP 40872"},
        {"Celescope Catalog", "CEL 2393"},
        {"Geneva Identification System", "GEN# +1.00070507"},
        {"Renson", "Renson 19470"},
        {"Smithsonian Astrophysical Observation", "SAO 219809"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09773673),
        dec: Angle.Degrees(-46.99227284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108159"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68992850),
        dec: Angle.Degrees(-46.99184596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -311.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69144"},
        {"Hipparcos Number", "HIP 40285"},
        {"Celescope Catalog", "CEL 2256"},
        {"Geneva Identification System", "GEN# +1.00069144A"},
        {"Smithsonian Astrophysical Observation", "SAO 219629"},
        {"Wilson Evans Batten Catalogue", "WEB 7855"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.40068034),
        dec: Angle.Degrees(-46.99165320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45750"},
        {"Hipparcos Number", "HIP 30676"},
        {"Smithsonian Astrophysical Observation", "SAO 217932"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.69086466),
        dec: Angle.Degrees(-46.98873284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51743"},
        {"Hipparcos Number", "HIP 33354"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.06069161),
        dec: Angle.Degrees(-46.98834411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169216"},
        {"Hipparcos Number", "HIP 90339"},
        {"Smithsonian Astrophysical Observation", "SAO 229011"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.48641896),
        dec: Angle.Degrees(-46.98758616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75483"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.29880329),
        dec: Angle.Degrees(-46.98685421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171309"},
        {"Hipparcos Number", "HIP 91211"},
        {"Smithsonian Astrophysical Observation", "SAO 229139"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.10500258),
        dec: Angle.Degrees(-46.98590196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189769"},
        {"Hipparcos Number", "HIP 98779"},
        {"Geneva Identification System", "GEN# +1.00189769"},
        {"Smithsonian Astrophysical Observation", "SAO 230013"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.92399304),
        dec: Angle.Degrees(-46.98488268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91590B"},
        {"Hipparcos Number", "HIP 51691"},
        {"Renson", "Renson 26348"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.38861477),
        dec: Angle.Degrees(-46.98344324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189059"},
        {"Hipparcos Number", "HIP 98451"},
        {"Smithsonian Astrophysical Observation", "SAO 229971"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05230980),
        dec: Angle.Degrees(-46.98284617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22315"},
        {"Hipparcos Number", "HIP 16595"},
        {"Smithsonian Astrophysical Observation", "SAO 216383"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.40640316),
        dec: Angle.Degrees(-46.98221523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57095"},
        {"Hipparcos Number", "HIP 35296"},
        {"Cincinnati Publication", "Ci 18 879"},
        {"Cincinnati Publication 2", "Ci 20 419"},
        {"Geneva Identification System", "GEN# +1.00057095"},
        {"Smithsonian Astrophysical Observation", "SAO 218611"},
        {"Wilson Evans Batten Catalogue", "WEB 7047"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.37323947),
        dec: Angle.Degrees(-46.98066437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 585.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75860"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43241222),
        dec: Angle.Degrees(-46.98034522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81650"},
        {"Hipparcos Number", "HIP 46222"},
        {"Geneva Identification System", "GEN# +1.00081650"},
        {"Smithsonian Astrophysical Observation", "SAO 221157"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.35024338),
        dec: Angle.Degrees(-46.97907199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22738"},
        {"Hipparcos Number", "HIP 16898"},
        {"Smithsonian Astrophysical Observation", "SAO 216410"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.35102972),
        dec: Angle.Degrees(-46.97891372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67341"},
        {"Hipparcos Number", "HIP 39584"},
        {"Celescope Catalog", "CEL 2157"},
        {"Geneva Identification System", "GEN# +1.00067341"},
        {"Renson", "Renson 18610"},
        {"Smithsonian Astrophysical Observation", "SAO 219400"},
        {"Wilson Evans Batten Catalogue", "WEB 7737"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.33461827),
        dec: Angle.Degrees(-46.97842667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91590"},
        {"Hipparcos Number", "HIP 51688"},
        {"Renson", "Renson 26350"},
        {"Smithsonian Astrophysical Observation", "SAO 222145"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.38511473),
        dec: Angle.Degrees(-46.97592047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92531"},
        {"Hipparcos Number", "HIP 52222"},
        {"Smithsonian Astrophysical Observation", "SAO 222242"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.04824992),
        dec: Angle.Degrees(-46.97553762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19141"},
        {"Hipparcos Number", "HIP 14187"},
        {"Fundamental Katalog 5th Edition", "FK5 1086"},
        {"Geneva Identification System", "GEN# +1.00019141"},
        {"Smithsonian Astrophysical Observation", "SAO 216150"},
        {"Wilson Evans Batten Catalogue", "WEB 2786"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.73267366),
        dec: Angle.Degrees(-46.97504226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2241"},
        {"Hipparcos Number", "HIP 2051"},
        {"Smithsonian Astrophysical Observation", "SAO 215090"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.49809747),
        dec: Angle.Degrees(-46.97409753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72112"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.26337433),
        dec: Angle.Degrees(-46.97393792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100607"},
        {"Hipparcos Number", "HIP 56447"},
        {"Geneva Identification System", "GEN# +1.00100607"},
        {"Smithsonian Astrophysical Observation", "SAO 222876"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.59518200),
        dec: Angle.Degrees(-46.97390369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120144"},
        {"Hipparcos Number", "HIP 67386"},
        {"Smithsonian Astrophysical Observation", "SAO 224449"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.16570996),
        dec: Angle.Degrees(-46.97369533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131145"},
        {"Hipparcos Number", "HIP 72841"},
        {"Smithsonian Astrophysical Observation", "SAO 225271"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.33564865),
        dec: Angle.Degrees(-46.97335590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118590"},
        {"Hipparcos Number", "HIP 66573"},
        {"Smithsonian Astrophysical Observation", "SAO 224302"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68843814),
        dec: Angle.Degrees(-46.97297533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330477"},
        {"Hipparcos Number", "HIP 79745"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.12594385),
        dec: Angle.Degrees(-46.97165416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153980"},
        {"Hipparcos Number", "HIP 83587"},
        {"Celescope Catalog", "CEL 4473"},
        {"Geneva Identification System", "GEN# +1.00153980"},
        {"Smithsonian Astrophysical Observation", "SAO 227599"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.25944873),
        dec: Angle.Degrees(-46.97141522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72900"},
        {"Hipparcos Number", "HIP 41986"},
        {"Geneva Identification System", "GEN# +1.00072900"},
        {"Smithsonian Astrophysical Observation", "SAO 220103"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.37615280),
        dec: Angle.Degrees(-46.97067315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21595"},
        {"Hipparcos Number", "HIP 16093"},
        {"Smithsonian Astrophysical Observation", "SAO 216328"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.82427933),
        dec: Angle.Degrees(-46.96719062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97482"},
        {"Hipparcos Number", "HIP 54750"},
        {"Geneva Identification System", "GEN# +1.00097482"},
        {"Smithsonian Astrophysical Observation", "SAO 222640"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.14653315),
        dec: Angle.Degrees(-46.96651450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100570"},
        {"Hipparcos Number", "HIP 56428"},
        {"Smithsonian Astrophysical Observation", "SAO 222871"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.53722794),
        dec: Angle.Degrees(-46.96642192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109268",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alnair"},
        {"Henry Draper", "HD 209952"},
        {"Hipparcos Number", "HIP 109268"},
        {"Celescope Catalog", "CEL 5438"},
        {"Fundamental Katalog 5th Edition", "FK5 829"},
        {"Geneva Identification System", "GEN# +1.00209952"},
        {"Smithsonian Astrophysical Observation", "SAO 230992"},
        {"Wilson Evans Batten Catalogue", "WEB 19636"},
    },
    visualMagnitude: 1.73,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.05781838),
        dec: Angle.Degrees(-46.96061593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208874"},
        {"Hipparcos Number", "HIP 108624"},
        {"Smithsonian Astrophysical Observation", "SAO 230933"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.08937141),
        dec: Angle.Degrees(-46.95861852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172779"},
        {"Hipparcos Number", "HIP 91928"},
        {"Smithsonian Astrophysical Observation", "SAO 229231"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.09885710),
        dec: Angle.Degrees(-46.95749083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71984"},
        {"Hipparcos Number", "HIP 41559"},
        {"Celescope Catalog", "CEL 2549"},
        {"Geneva Identification System", "GEN# +1.00071984"},
        {"Smithsonian Astrophysical Observation", "SAO 219971"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.10214895),
        dec: Angle.Degrees(-46.95516925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138473"},
        {"Hipparcos Number", "HIP 76222"},
        {"Smithsonian Astrophysical Observation", "SAO 225910"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.55956644),
        dec: Angle.Degrees(-46.95352563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3025"},
        {"Hipparcos Number", "HIP 2616"},
        {"Geneva Identification System", "GEN# +1.00003025"},
        {"Smithsonian Astrophysical Observation", "SAO 215139"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.29926673),
        dec: Angle.Degrees(-46.95177605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157798"},
        {"Hipparcos Number", "HIP 85454"},
        {"Geneva Identification System", "GEN# +1.00157798"},
        {"Smithsonian Astrophysical Observation", "SAO 227988"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.94357097),
        dec: Angle.Degrees(-46.95074778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147757"},
        {"Hipparcos Number", "HIP 80496"},
        {"Smithsonian Astrophysical Observation", "SAO 226753"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.47316223),
        dec: Angle.Degrees(-46.95064289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131678"},
        {"Hipparcos Number", "HIP 73115"},
        {"Geneva Identification System", "GEN# +1.00131678"},
        {"Smithsonian Astrophysical Observation", "SAO 225308"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.14333809),
        dec: Angle.Degrees(-46.95047196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80761"},
        {"Hipparcos Number", "HIP 45776"},
        {"Celescope Catalog", "CEL 3269"},
        {"Geneva Identification System", "GEN# +1.00080761"},
        {"Smithsonian Astrophysical Observation", "SAO 221073"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.00444351),
        dec: Angle.Degrees(-46.95043840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152993"},
        {"Hipparcos Number", "HIP 83122"},
        {"Smithsonian Astrophysical Observation", "SAO 227522"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.79703976),
        dec: Angle.Degrees(-46.95039146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126999"},
        {"Hipparcos Number", "HIP 70924"},
        {"Cincinnati Publication", "Ci 20 862"},
        {"Geneva Identification System", "GEN# +1.00126999"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.55997251),
        dec: Angle.Degrees(-46.94954015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -638.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -398.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41903"},
        {"Hipparcos Number", "HIP 28845"},
        {"Smithsonian Astrophysical Observation", "SAO 217713"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.32997673),
        dec: Angle.Degrees(-46.94922484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10922"},
        {"Hipparcos Number", "HIP 8251"},
        {"Fundamental Katalog 5th Edition", "FK5 4160"},
        {"Geneva Identification System", "GEN# +1.00010922"},
        {"Smithsonian Astrophysical Observation", "SAO 215642"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.55426192),
        dec: Angle.Degrees(-46.94764894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133420"},
        {"Hipparcos Number", "HIP 73885"},
        {"Geneva Identification System", "GEN# +1.00133420"},
        {"Smithsonian Astrophysical Observation", "SAO 225441"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.51678951),
        dec: Angle.Degrees(-46.93381689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220354"},
        {"Hipparcos Number", "HIP 115466"},
        {"Smithsonian Astrophysical Observation", "SAO 231584"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.84885788),
        dec: Angle.Degrees(-46.94694557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28454"},
        {"Hipparcos Number", "HIP 20781"},
        {"Fundamental Katalog 5th Edition", "FK5 2329"},
        {"Geneva Identification System", "GEN# +1.00028454"},
        {"Smithsonian Astrophysical Observation", "SAO 216809"},
        {"Wilson Evans Batten Catalogue", "WEB 3987"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.77465426),
        dec: Angle.Degrees(-46.94683571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37314"},
        {"Hipparcos Number", "HIP 26217"},
        {"Smithsonian Astrophysical Observation", "SAO 217412"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80851028),
        dec: Angle.Degrees(-46.94537239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221818"},
        {"Hipparcos Number", "HIP 116429"},
        {"Geneva Identification System", "GEN# +1.00221818"},
        {"Smithsonian Astrophysical Observation", "SAO 231680"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.89496231),
        dec: Angle.Degrees(-46.94414735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168870"},
        {"Hipparcos Number", "HIP 90194"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.06284104),
        dec: Angle.Degrees(-46.94324644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81621"},
        {"Hipparcos Number", "HIP 46204"},
        {"Geneva Identification System", "GEN# +1.00081621"},
        {"Smithsonian Astrophysical Observation", "SAO 221153"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.31494061),
        dec: Angle.Degrees(-46.94298124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215545B"},
        {"Hipparcos Number", "HIP 112450"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.68447970),
        dec: Angle.Degrees(-46.94173416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26665"},
        {"Hipparcos Number", "HIP 19528"},
        {"Geneva Identification System", "GEN# +1.00026665"},
        {"Smithsonian Astrophysical Observation", "SAO 216683"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.76296218),
        dec: Angle.Degrees(-46.94113276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161633"},
        {"Hipparcos Number", "HIP 87206"},
        {"Geneva Identification System", "GEN# +1.00161633"},
        {"Smithsonian Astrophysical Observation", "SAO 228440"},
        {"Wilson Evans Batten Catalogue", "WEB 14713"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.25005140),
        dec: Angle.Degrees(-46.94073626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215545"},
        {"Hipparcos Number", "HIP 112449"},
        {"Renson", "Renson 59540"},
        {"Smithsonian Astrophysical Observation", "SAO 231290"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.68181267),
        dec: Angle.Degrees(-46.93947890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87641"},
        {"Hipparcos Number", "HIP 49391"},
        {"Geneva Identification System", "GEN# +1.00087641"},
        {"Smithsonian Astrophysical Observation", "SAO 221757"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.24862353),
        dec: Angle.Degrees(-46.93697684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45441"},
        {"Hipparcos Number", "HIP 30522"},
        {"Smithsonian Astrophysical Observation", "SAO 217914"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.22614748),
        dec: Angle.Degrees(-46.93595736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49234"},
        {"Hipparcos Number", "HIP 32342"},
        {"Celescope Catalog", "CEL 1374"},
        {"Geneva Identification System", "GEN# +1.00049234"},
        {"Smithsonian Astrophysical Observation", "SAO 218168"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.27319010),
        dec: Angle.Degrees(-46.93586290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110827"},
        {"Hipparcos Number", "HIP 62228"},
        {"Smithsonian Astrophysical Observation", "SAO 223643"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.31123524),
        dec: Angle.Degrees(-46.93471472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85483"},
        {"Hipparcos Number", "HIP 48287"},
        {"Geneva Identification System", "GEN# +1.00085483"},
        {"Smithsonian Astrophysical Observation", "SAO 221538"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.67487458),
        dec: Angle.Degrees(-46.93400208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220710"},
        {"Hipparcos Number", "HIP 115690"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58642484),
        dec: Angle.Degrees(-46.93313410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28153"},
        {"Cincinnati Publication", "Ci 20 361"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.23372483),
        dec: Angle.Degrees(-46.93278714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 488.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94623"},
        {"Hipparcos Number", "HIP 53361"},
        {"Smithsonian Astrophysical Observation", "SAO 222419"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68709277),
        dec: Angle.Degrees(-46.93202717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149641"},
        {"Hipparcos Number", "HIP 81458"},
        {"Geneva Identification System", "GEN# +1.00149641"},
        {"Smithsonian Astrophysical Observation", "SAO 226982"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.56125158),
        dec: Angle.Degrees(-46.93159682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208215"},
        {"Hipparcos Number", "HIP 108258"},
        {"Geneva Identification System", "GEN# +1.00208215"},
        {"Smithsonian Astrophysical Observation", "SAO 230903"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.98103217),
        dec: Angle.Degrees(-46.92781895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144827"},
        {"Hipparcos Number", "HIP 79202"},
        {"Smithsonian Astrophysical Observation", "SAO 226543"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.47796684),
        dec: Angle.Degrees(-46.92587172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14630"},
        {"Hipparcos Number", "HIP 10906"},
        {"Smithsonian Astrophysical Observation", "SAO 215867"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09469211),
        dec: Angle.Degrees(-46.92488350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2145"},
        {"Hipparcos Number", "HIP 2005"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35055904),
        dec: Angle.Degrees(-46.92422590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87012"},
        {"Hipparcos Number", "HIP 49078"},
        {"Smithsonian Astrophysical Observation", "SAO 221699"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.24968530),
        dec: Angle.Degrees(-46.92373673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123549"},
        {"Hipparcos Number", "HIP 69173"},
        {"Smithsonian Astrophysical Observation", "SAO 224729"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.39116625),
        dec: Angle.Degrees(-46.92256279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160263"},
        {"Hipparcos Number", "HIP 86552"},
        {"Celescope Catalog", "CEL 4551"},
        {"Fundamental Katalog 5th Edition", "FK5 3404"},
        {"Geneva Identification System", "GEN# +1.00160263"},
        {"Smithsonian Astrophysical Observation", "SAO 228279"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.31763202),
        dec: Angle.Degrees(-46.92181116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29186"},
        {"Hipparcos Number", "HIP 21254"},
        {"Smithsonian Astrophysical Observation", "SAO 216872"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.39228634),
        dec: Angle.Degrees(-46.92170769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34448"},
        {"Hipparcos Number", "HIP 24468"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.77439525),
        dec: Angle.Degrees(-46.91798735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194531"},
        {"Hipparcos Number", "HIP 100945"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.00207843),
        dec: Angle.Degrees(-46.91783619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152149"},
        {"Hipparcos Number", "HIP 82666"},
        {"Celescope Catalog", "CEL 4438"},
        {"Geneva Identification System", "GEN# +1.00152149"},
        {"Smithsonian Astrophysical Observation", "SAO 227362"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.49032159),
        dec: Angle.Degrees(-46.91700526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84984"},
    },
    visualMagnitude: 12.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.53977742),
        dec: Angle.Degrees(-46.82412298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139414"},
        {"Hipparcos Number", "HIP 76722"},
        {"Smithsonian Astrophysical Observation", "SAO 226037"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.00700868),
        dec: Angle.Degrees(-46.91631507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117685"},
        {"Hipparcos Number", "HIP 66087"},
        {"Geneva Identification System", "GEN# +1.00117685"},
        {"Smithsonian Astrophysical Observation", "SAO 224232"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.20597348),
        dec: Angle.Degrees(-46.91279485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194642"},
        {"Hipparcos Number", "HIP 100994"},
        {"Smithsonian Astrophysical Observation", "SAO 230230"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.14522197),
        dec: Angle.Degrees(-46.91274133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3773"},
        {"Hipparcos Number", "HIP 3148"},
        {"Smithsonian Astrophysical Observation", "SAO 215186"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.00766279),
        dec: Angle.Degrees(-46.91262655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123794"},
        {"Hipparcos Number", "HIP 69287"},
        {"Smithsonian Astrophysical Observation", "SAO 224745"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74236056),
        dec: Angle.Degrees(-46.91080925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124857"},
        {"Hipparcos Number", "HIP 69802"},
        {"Smithsonian Astrophysical Observation", "SAO 224815"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.28931993),
        dec: Angle.Degrees(-46.91067177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194949"},
        {"Hipparcos Number", "HIP 101151"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.54668502),
        dec: Angle.Degrees(-46.91067122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75465"},
        {"Hipparcos Number", "HIP 43229"},
        {"Celescope Catalog", "CEL 2937"},
        {"Geneva Identification System", "GEN# +1.00075465"},
        {"Smithsonian Astrophysical Observation", "SAO 220502"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.08691519),
        dec: Angle.Degrees(-46.91054762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152148"},
        {"Hipparcos Number", "HIP 82664"},
        {"Geneva Identification System", "GEN# +1.00152148"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.48250662),
        dec: Angle.Degrees(-46.91044464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81369"},
        {"Hipparcos Number", "HIP 46067"},
        {"Geneva Identification System", "GEN# +1.00081369"},
        {"Smithsonian Astrophysical Observation", "SAO 221131"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.91571525),
        dec: Angle.Degrees(-46.90876865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137730"},
        {"Hipparcos Number", "HIP 75838"},
        {"Smithsonian Astrophysical Observation", "SAO 225830"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38124134),
        dec: Angle.Degrees(-46.90694501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12156"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.16223903),
        dec: Angle.Degrees(-46.90569323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 249.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212686"},
        {"Hipparcos Number", "HIP 110827"},
        {"Smithsonian Astrophysical Observation", "SAO 231144"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.79236320),
        dec: Angle.Degrees(-46.90383099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143362"},
        {"Hipparcos Number", "HIP 78532"},
        {"Geneva Identification System", "GEN# +1.00143362"},
        {"Smithsonian Astrophysical Observation", "SAO 226455"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.49328236),
        dec: Angle.Degrees(-46.90380462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66060"},
        {"Hipparcos Number", "HIP 39080"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.93720416),
        dec: Angle.Degrees(-46.90295595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73813B"},
        {"Hipparcos Number", "HIP 42376"},
        {"Smithsonian Astrophysical Observation", "SAO 220224"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.60523853),
        dec: Angle.Degrees(-46.77740551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330719"},
        {"Hipparcos Number", "HIP 80663"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.03465078),
        dec: Angle.Degrees(-46.90114079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120640"},
        {"Hipparcos Number", "HIP 67663"},
        {"Celescope Catalog", "CEL 4282"},
        {"Geneva Identification System", "GEN# +1.00120640"},
        {"Renson", "Renson 34740"},
        {"Smithsonian Astrophysical Observation", "SAO 224489"},
        {"Wilson Evans Batten Catalogue", "WEB 11900"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.94679307),
        dec: Angle.Degrees(-46.89863029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165271"},
        {"Hipparcos Number", "HIP 88782"},
        {"Geneva Identification System", "GEN# +1.00165271"},
        {"Smithsonian Astrophysical Observation", "SAO 228716"},
        {"Wilson Evans Batten Catalogue", "WEB 15038"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.85932138),
        dec: Angle.Degrees(-46.89855239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134655"},
        {"Hipparcos Number", "HIP 74436"},
        {"Smithsonian Astrophysical Observation", "SAO 225538"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.18904999),
        dec: Angle.Degrees(-46.89567871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24706"},
        {"Hipparcos Number", "HIP 18199"},
        {"Fundamental Katalog 5th Edition", "FK5 1108"},
        {"Geneva Identification System", "GEN# +1.00024706"},
        {"Smithsonian Astrophysical Observation", "SAO 216540"},
        {"Wilson Evans Batten Catalogue", "WEB 3514"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.38876601),
        dec: Angle.Degrees(-46.89358860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69952"},
        {"Hipparcos Number", "HIP 40594"},
        {"Celescope Catalog", "CEL 2322"},
        {"Geneva Identification System", "GEN# +1.00069952"},
        {"Smithsonian Astrophysical Observation", "SAO 219736"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31941248),
        dec: Angle.Degrees(-46.89326082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154593"},
        {"Hipparcos Number", "HIP 83877"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.14791344),
        dec: Angle.Degrees(-46.89314696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96278"},
        {"Hipparcos Number", "HIP 54209"},
        {"Smithsonian Astrophysical Observation", "SAO 222555"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.37042279),
        dec: Angle.Degrees(-46.89307753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85523"},
        {"Cincinnati Publication", "Ci 20 1038"},
        {"Geneva Identification System", "GEN# -0.04611540"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.16440365),
        dec: Angle.Degrees(-46.89305173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 573.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -879.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99485"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.85565371),
        dec: Angle.Degrees(-46.89135234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76589"},
        {"Hipparcos Number", "HIP 43812"},
        {"Celescope Catalog", "CEL 3086"},
        {"Smithsonian Astrophysical Observation", "SAO 220668"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.84603668),
        dec: Angle.Degrees(-46.89109131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76192"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.45323022),
        dec: Angle.Degrees(-46.88634947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89863"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.07592909),
        dec: Angle.Degrees(-46.88569216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14166"},
        {"Hipparcos Number", "HIP 10574"},
        {"Smithsonian Astrophysical Observation", "SAO 215843"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.02794235),
        dec: Angle.Degrees(-46.88460561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112122",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tiaki"},
        {"Henry Draper", "HD 214952"},
        {"Hipparcos Number", "HIP 112122"},
        {"Fundamental Katalog 5th Edition", "FK5 856"},
        {"Geneva Identification System", "GEN# +1.00214952"},
        {"Smithsonian Astrophysical Observation", "SAO 231258"},
        {"Wilson Evans Batten Catalogue", "WEB 20008"},
    },
    visualMagnitude: 2.07,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.66639531),
        dec: Angle.Degrees(-46.88456594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50610"},
    },
    visualMagnitude: 11.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.07037837),
        dec: Angle.Degrees(-46.44494212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207279"},
        {"Hipparcos Number", "HIP 107701"},
        {"Smithsonian Astrophysical Observation", "SAO 230849"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.25680553),
        dec: Angle.Degrees(-46.88437687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220164"},
        {"Hipparcos Number", "HIP 115361"},
        {"Geneva Identification System", "GEN# +1.00220164"},
        {"Smithsonian Astrophysical Observation", "SAO 231566"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.50969204),
        dec: Angle.Degrees(-46.88373374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184443"},
        {"Hipparcos Number", "HIP 96461"},
        {"Geneva Identification System", "GEN# +1.00184443"},
        {"Smithsonian Astrophysical Observation", "SAO 229766"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.16314478),
        dec: Angle.Degrees(-46.88268541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115912"},
        {"Hipparcos Number", "HIP 65144"},
        {"Geneva Identification System", "GEN# +1.00115912"},
        {"Smithsonian Astrophysical Observation", "SAO 224080"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.24067905),
        dec: Angle.Degrees(-46.88005836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139714"},
        {"Hipparcos Number", "HIP 76858"},
        {"Smithsonian Astrophysical Observation", "SAO 226071"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.42012235),
        dec: Angle.Degrees(-46.87932174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124907"},
        {"Hipparcos Number", "HIP 69837"},
        {"Smithsonian Astrophysical Observation", "SAO 224818"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.38670440),
        dec: Angle.Degrees(-46.87742105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116067"},
        {"Hipparcos Number", "HIP 65220"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.49037599),
        dec: Angle.Degrees(-46.87674823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145137"},
        {"Hipparcos Number", "HIP 79323"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.83919115),
        dec: Angle.Degrees(-46.87248282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157931"},
        {"Hipparcos Number", "HIP 85512"},
        {"Geneva Identification System", "GEN# +1.00157931"},
        {"Smithsonian Astrophysical Observation", "SAO 227999"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.12944206),
        dec: Angle.Degrees(-46.87242346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111636"},
        {"Hipparcos Number", "HIP 62726"},
        {"Geneva Identification System", "GEN# +1.00111636"},
        {"Smithsonian Astrophysical Observation", "SAO 223711"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.80917561),
        dec: Angle.Degrees(-46.87054699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19841"},
        {"Hipparcos Number", "HIP 14688"},
        {"Smithsonian Astrophysical Observation", "SAO 216192"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.43484855),
        dec: Angle.Degrees(-46.86873070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99525"},
        {"Hipparcos Number", "HIP 55834"},
        {"Smithsonian Astrophysical Observation", "SAO 222799"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.65462289),
        dec: Angle.Degrees(-46.86769875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204083"},
        {"Hipparcos Number", "HIP 105967"},
        {"Smithsonian Astrophysical Observation", "SAO 230697"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.92259380),
        dec: Angle.Degrees(-46.86644619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84244"},
        {"Hipparcos Number", "HIP 47608"},
        {"Smithsonian Astrophysical Observation", "SAO 221419"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.61631870),
        dec: Angle.Degrees(-46.86518609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111635"},
        {"Hipparcos Number", "HIP 62723"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.80067962),
        dec: Angle.Degrees(-46.86501211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48904"},
        {"Cincinnati Publication", "Ci 20 556"},
        {"Geneva Identification System", "GEN# -0.04505627"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.64132190),
        dec: Angle.Degrees(-46.42394529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 479.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -483.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5569"},
        {"Hipparcos Number", "HIP 4444"},
        {"Smithsonian Astrophysical Observation", "SAO 215296"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.22085770),
        dec: Angle.Degrees(-46.86400693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107965"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.09181468),
        dec: Angle.Degrees(-46.86391201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4825"},
        {"Hipparcos Number", "HIP 3880"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.45164376),
        dec: Angle.Degrees(-46.86372938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194398"},
        {"Hipparcos Number", "HIP 100871"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.79549877),
        dec: Angle.Degrees(-46.86204765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187418"},
        {"Hipparcos Number", "HIP 97756"},
        {"Geneva Identification System", "GEN# +1.00187418"},
        {"Renson", "Renson 51680"},
        {"Smithsonian Astrophysical Observation", "SAO 229902"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99554152),
        dec: Angle.Degrees(-46.86170551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105135"},
        {"Hipparcos Number", "HIP 59038"},
        {"Geneva Identification System", "GEN# +1.00105135"},
        {"Smithsonian Astrophysical Observation", "SAO 223217"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.56150346),
        dec: Angle.Degrees(-46.86111197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63949"},
        {"Hipparcos Number", "HIP 38159"},
        {"Celescope Catalog", "CEL 2051"},
        {"Geneva Identification System", "GEN# +1.00063949"},
        {"Smithsonian Astrophysical Observation", "SAO 219034"},
        {"Wilson Evans Batten Catalogue", "WEB 7523"},
    },
    visualMagnitude: 5.82,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30361005),
        dec: Angle.Degrees(-46.85774089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114949"},
        {"Hipparcos Number", "HIP 64617"},
        {"Geneva Identification System", "GEN# +1.00114949"},
        {"Smithsonian Astrophysical Observation", "SAO 223999"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66645571),
        dec: Angle.Degrees(-46.85747401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95811"},
    },
    visualMagnitude: 10.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)29, 17.6100),
        dec: Angle.DegreesMinutesSeconds((int)-46, (int)51, 18.800)
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
    primaryId: "HIP 95809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182931"},
        {"Hipparcos Number", "HIP 95809"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.31649677),
        dec: Angle.Degrees(-46.85395808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328571"},
        {"Hipparcos Number", "HIP 81382"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.31140576),
        dec: Angle.Degrees(-46.85380935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49259"},
        {"Hipparcos Number", "HIP 32356"},
        {"Celescope Catalog", "CEL 1378"},
        {"Geneva Identification System", "GEN# +1.00049259"},
        {"Smithsonian Astrophysical Observation", "SAO 218172"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.30561409),
        dec: Angle.Degrees(-46.85337141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28658"},
        {"Hipparcos Number", "HIP 20905"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.21677712),
        dec: Angle.Degrees(-46.85298358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203009"},
        {"Hipparcos Number", "HIP 105408"},
        {"Smithsonian Astrophysical Observation", "SAO 230645"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.25933697),
        dec: Angle.Degrees(-46.85252566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31274"},
        {"Hipparcos Number", "HIP 22620"},
        {"Fundamental Katalog 5th Edition", "FK5 4447"},
        {"Geneva Identification System", "GEN# +1.00031274"},
        {"Smithsonian Astrophysical Observation", "SAO 217050"},
        {"Wilson Evans Batten Catalogue", "WEB 4374"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.00837262),
        dec: Angle.Degrees(-46.85240898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62847"},
        {"Hipparcos Number", "HIP 37683"},
        {"Geneva Identification System", "GEN# +1.00062847"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.96665184),
        dec: Angle.Degrees(-46.85195137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21326"},
        {"Hipparcos Number", "HIP 15881"},
        {"Smithsonian Astrophysical Observation", "SAO 216304"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.14184797),
        dec: Angle.Degrees(-46.85049693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56455"},
        {"Hipparcos Number", "HIP 35029"},
        {"Celescope Catalog", "CEL 1716"},
        {"Geneva Identification System", "GEN# +1.00056455"},
        {"Renson", "Renson 15400"},
        {"Smithsonian Astrophysical Observation", "SAO 218570"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.69177379),
        dec: Angle.Degrees(-46.84967225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42449"},
        {"Hipparcos Number", "HIP 29103"},
        {"Smithsonian Astrophysical Observation", "SAO 217733"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07419039),
        dec: Angle.Degrees(-46.84950248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152541"},
        {"Hipparcos Number", "HIP 82874"},
        {"Celescope Catalog", "CEL 4457"},
        {"Geneva Identification System", "GEN# +1.00152541J"},
        {"Smithsonian Astrophysical Observation", "SAO 227453"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06041289),
        dec: Angle.Degrees(-46.84939784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81172"},
        {"Hipparcos Number", "HIP 45969"},
        {"Celescope Catalog", "CEL 3277"},
        {"Geneva Identification System", "GEN# +1.00081172"},
        {"Smithsonian Astrophysical Observation", "SAO 221112"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.62269964),
        dec: Angle.Degrees(-46.84721035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190541"},
        {"Hipparcos Number", "HIP 99130"},
        {"Smithsonian Astrophysical Observation", "SAO 230047"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.87912544),
        dec: Angle.Degrees(-46.84714557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27825"},
        {"Hipparcos Number", "HIP 20335"},
        {"Smithsonian Astrophysical Observation", "SAO 216761"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.34833681),
        dec: Angle.Degrees(-46.84234564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223341"},
        {"Hipparcos Number", "HIP 117453"},
        {"Smithsonian Astrophysical Observation", "SAO 231789"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.23256059),
        dec: Angle.Degrees(-46.84215484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118469"},
        {"Hipparcos Number", "HIP 66513"},
        {"Smithsonian Astrophysical Observation", "SAO 224290"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.50631216),
        dec: Angle.Degrees(-46.83733797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7719"},
        {"Hipparcos Number", "HIP 5917"},
        {"Smithsonian Astrophysical Observation", "SAO 215432"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.03085689),
        dec: Angle.Degrees(-46.83591383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89328"},
        {"Hipparcos Number", "HIP 50391"},
        {"Geneva Identification System", "GEN# +1.00089328"},
        {"Smithsonian Astrophysical Observation", "SAO 221934"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.33417110),
        dec: Angle.Degrees(-46.83494301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225102"},
        {"Hipparcos Number", "HIP 273"},
        {"Geneva Identification System", "GEN# +1.00225102"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85687021),
        dec: Angle.Degrees(-46.83096933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223937"},
        {"Hipparcos Number", "HIP 117833"},
        {"Smithsonian Astrophysical Observation", "SAO 231837"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.46828800),
        dec: Angle.Degrees(-46.83062630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109607"},
        {"Hipparcos Number", "HIP 61517"},
        {"Smithsonian Astrophysical Observation", "SAO 223548"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.06073957),
        dec: Angle.Degrees(-46.82985554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196639"},
        {"Hipparcos Number", "HIP 102019"},
        {"Smithsonian Astrophysical Observation", "SAO 230316"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.09431012),
        dec: Angle.Degrees(-46.82654074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329845"},
        {"Hipparcos Number", "HIP 84986"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.54450942),
        dec: Angle.Degrees(-46.82342967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45133"},
        {"Hipparcos Number", "HIP 30377"},
        {"Geneva Identification System", "GEN# +1.00045133"},
        {"Smithsonian Astrophysical Observation", "SAO 217900"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.81072096),
        dec: Angle.Degrees(-46.82328591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66705"},
        {"Hipparcos Number", "HIP 39349"},
        {"Geneva Identification System", "GEN# +1.00066705"},
        {"Smithsonian Astrophysical Observation", "SAO 219340"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.65309918),
        dec: Angle.Degrees(-46.82262893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3868"},
        {"Hipparcos Number", "HIP 3211"},
        {"Geneva Identification System", "GEN# +1.00003868"},
        {"Smithsonian Astrophysical Observation", "SAO 215191"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.21560254),
        dec: Angle.Degrees(-46.82203518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50547"},
        {"Hipparcos Number", "HIP 32907"},
        {"Smithsonian Astrophysical Observation", "SAO 218256"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.84429053),
        dec: Angle.Degrees(-46.81624379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13724"},
        {"Hipparcos Number", "HIP 10278"},
        {"Geneva Identification System", "GEN# +1.00013724"},
        {"Smithsonian Astrophysical Observation", "SAO 215815"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.08627004),
        dec: Angle.Degrees(-46.81622226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78133"},
        {"Hipparcos Number", "HIP 44568"},
        {"Smithsonian Astrophysical Observation", "SAO 220819"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.20843539),
        dec: Angle.Degrees(-46.81606787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127976"},
        {"Hipparcos Number", "HIP 71382"},
        {"Geneva Identification System", "GEN# +1.00127976"},
        {"Smithsonian Astrophysical Observation", "SAO 225049"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.95832382),
        dec: Angle.Degrees(-46.81574603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136281"},
        {"Hipparcos Number", "HIP 75169"},
        {"Smithsonian Astrophysical Observation", "SAO 225693"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.41403813),
        dec: Angle.Degrees(-46.81495173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122449"},
        {"Hipparcos Number", "HIP 68644"},
        {"Celescope Catalog", "CEL 4295"},
        {"Geneva Identification System", "GEN# +1.00122449"},
        {"Smithsonian Astrophysical Observation", "SAO 224637"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.77030674),
        dec: Angle.Degrees(-46.81431487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90259"},
        {"Hipparcos Number", "HIP 50934"},
        {"Smithsonian Astrophysical Observation", "SAO 222025"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.03349464),
        dec: Angle.Degrees(-46.80926284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74558"},
        {"Hipparcos Number", "HIP 42754"},
        {"Celescope Catalog", "CEL 2811"},
        {"Geneva Identification System", "GEN# +1.00074558"},
        {"Smithsonian Astrophysical Observation", "SAO 220325"},
        {"Wilson Evans Batten Catalogue", "WEB 8258"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.69770787),
        dec: Angle.Degrees(-46.80747056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106009"},
        {"Hipparcos Number", "HIP 59484"},
        {"Smithsonian Astrophysical Observation", "SAO 223273"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99675914),
        dec: Angle.Degrees(-46.80709856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219073"},
        {"Hipparcos Number", "HIP 114653"},
        {"Smithsonian Astrophysical Observation", "SAO 231497"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.38539901),
        dec: Angle.Degrees(-46.80399836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129735"},
        {"Hipparcos Number", "HIP 72178"},
        {"Geneva Identification System", "GEN# +1.00129735"},
        {"Smithsonian Astrophysical Observation", "SAO 225170"},
        {"Wilson Evans Batten Catalogue", "WEB 12417"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.44279744),
        dec: Angle.Degrees(-46.80340091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50397"},
        {"Hipparcos Number", "HIP 32832"},
        {"Smithsonian Astrophysical Observation", "SAO 218246"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.66677367),
        dec: Angle.Degrees(-46.80323244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63449"},
        {"Hipparcos Number", "HIP 37953"},
        {"Smithsonian Astrophysical Observation", "SAO 218987"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.69182798),
        dec: Angle.Degrees(-46.80168466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108413"},
        {"Hipparcos Number", "HIP 60793"},
        {"Smithsonian Astrophysical Observation", "SAO 223450"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.89471297),
        dec: Angle.Degrees(-46.79938283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11158"},
        {"Hipparcos Number", "HIP 8432"},
        {"Smithsonian Astrophysical Observation", "SAO 215662"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.17222741),
        dec: Angle.Degrees(-46.79635277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330714"},
        {"Hipparcos Number", "HIP 80715"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.19896033),
        dec: Angle.Degrees(-46.79399262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188011"},
        {"Hipparcos Number", "HIP 98023"},
        {"Geneva Identification System", "GEN# +1.00188011"},
        {"Smithsonian Astrophysical Observation", "SAO 229922"},
        {"Wilson Evans Batten Catalogue", "WEB 17264"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79368995),
        dec: Angle.Degrees(-46.79258448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87770"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.94562165),
        dec: Angle.Degrees(-46.79060510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150647"},
        {"Hipparcos Number", "HIP 81957"},
        {"Geneva Identification System", "GEN# +1.00150647"},
        {"Smithsonian Astrophysical Observation", "SAO 227137"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.14071641),
        dec: Angle.Degrees(-46.78591910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129792"},
        {"Hipparcos Number", "HIP 72204"},
        {"Geneva Identification System", "GEN# +1.00129792"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51405805),
        dec: Angle.Degrees(-46.78479036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125460"},
        {"Hipparcos Number", "HIP 70115"},
        {"Smithsonian Astrophysical Observation", "SAO 224847"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.20793248),
        dec: Angle.Degrees(-46.78425416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104212"},
        {"Hipparcos Number", "HIP 58517"},
        {"Geneva Identification System", "GEN# +1.00104212"},
        {"Smithsonian Astrophysical Observation", "SAO 223161"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.01467463),
        dec: Angle.Degrees(-46.78397375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87201"},
        {"Hipparcos Number", "HIP 49176"},
        {"Smithsonian Astrophysical Observation", "SAO 221714"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.54717086),
        dec: Angle.Degrees(-46.78298553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73847"},
        {"Hipparcos Number", "HIP 42390"},
        {"Geneva Identification System", "GEN# +1.00073847J"},
        {"Smithsonian Astrophysical Observation", "SAO 220231"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.65936735),
        dec: Angle.Degrees(-46.78183026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22263"},
        {"Hipparcos Number", "HIP 16547"},
        {"Geneva Identification System", "GEN# +1.00022263"},
        {"Smithsonian Astrophysical Observation", "SAO 216380"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.27157589),
        dec: Angle.Degrees(-46.77965932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211026"},
        {"Hipparcos Number", "HIP 109885"},
        {"Smithsonian Astrophysical Observation", "SAO 231050"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.83018930),
        dec: Angle.Degrees(-46.77830949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93840"},
        {"Hipparcos Number", "HIP 52898"},
        {"Geneva Identification System", "GEN# +1.00093840"},
        {"Smithsonian Astrophysical Observation", "SAO 222355"},
        {"Wilson Evans Batten Catalogue", "WEB 9629"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.28622571),
        dec: Angle.Degrees(-46.77829855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216224"},
        {"Hipparcos Number", "HIP 112908"},
        {"Geneva Identification System", "GEN# +1.00216224J"},
        {"Smithsonian Astrophysical Observation", "SAO 231331"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.96327096),
        dec: Angle.Degrees(-46.77689552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183671"},
        {"Hipparcos Number", "HIP 96138"},
        {"Smithsonian Astrophysical Observation", "SAO 229739"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.21995838),
        dec: Angle.Degrees(-46.77681088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73813"},
        {"Hipparcos Number", "HIP 42379"},
        {"Celescope Catalog", "CEL 2731"},
        {"Geneva Identification System", "GEN# +1.00073813"},
        {"Smithsonian Astrophysical Observation", "SAO 220225"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.61054196),
        dec: Angle.Degrees(-46.77642791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56813"},
        {"Hipparcos Number", "HIP 35181"},
        {"Geneva Identification System", "GEN# +1.00056813"},
        {"Smithsonian Astrophysical Observation", "SAO 218589"},
        {"Wilson Evans Batten Catalogue", "WEB 7030"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.06446675),
        dec: Angle.Degrees(-46.77461104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197066"},
        {"Hipparcos Number", "HIP 102247"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.77208127),
        dec: Angle.Degrees(-46.77380330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44775"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.88622948),
        dec: Angle.Degrees(-46.77290301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174543"},
        {"Hipparcos Number", "HIP 92688"},
        {"Smithsonian Astrophysical Observation", "SAO 229346"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30223288),
        dec: Angle.Degrees(-46.77158817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52026"},
        {"Hipparcos Number", "HIP 33456"},
        {"Smithsonian Astrophysical Observation", "SAO 218335"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.33716562),
        dec: Angle.Degrees(-46.77086237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185494"},
        {"Hipparcos Number", "HIP 96875"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39198414),
        dec: Angle.Degrees(-46.76995707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11264"},
        {"Hipparcos Number", "HIP 8498"},
        {"Geneva Identification System", "GEN# +1.00011264"},
        {"Smithsonian Astrophysical Observation", "SAO 215669"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.39800556),
        dec: Angle.Degrees(-46.76892974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201110"},
        {"Hipparcos Number", "HIP 104424"},
        {"Smithsonian Astrophysical Observation", "SAO 230547"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.30091155),
        dec: Angle.Degrees(-46.76792180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58230"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.15342167),
        dec: Angle.Degrees(-46.76621655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82830"},
        {"Hipparcos Number", "HIP 46876"},
        {"Geneva Identification System", "GEN# +1.00082830"},
        {"Smithsonian Astrophysical Observation", "SAO 221276"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.28789900),
        dec: Angle.Degrees(-46.76514399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181246"},
        {"Hipparcos Number", "HIP 95199"},
        {"Smithsonian Astrophysical Observation", "SAO 229641"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.50381395),
        dec: Angle.Degrees(-46.76477622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158764"},
        {"Hipparcos Number", "HIP 85907"},
        {"Smithsonian Astrophysical Observation", "SAO 228109"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.33090807),
        dec: Angle.Degrees(-46.76435610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125585"},
        {"Hipparcos Number", "HIP 70191"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.41107416),
        dec: Angle.Degrees(-46.76422089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21068"},
        {"Hipparcos Number", "HIP 15692"},
        {"Smithsonian Astrophysical Observation", "SAO 216282"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.53902369),
        dec: Angle.Degrees(-46.76318895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108523"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.78456262),
        dec: Angle.Degrees(-46.76276730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273460"},
        {"Hipparcos Number", "HIP 23870"},
        {"Smithsonian Astrophysical Observation", "SAO 217192"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.94838826),
        dec: Angle.Degrees(-46.76029902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60839"},
        {"Hipparcos Number", "HIP 36823"},
        {"Smithsonian Astrophysical Observation", "SAO 218814"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.58187251),
        dec: Angle.Degrees(-46.76012321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130932"},
        {"Hipparcos Number", "HIP 72756"},
        {"Geneva Identification System", "GEN# +1.00130932"},
        {"Smithsonian Astrophysical Observation", "SAO 225260"},
        {"Wilson Evans Batten Catalogue", "WEB 12503"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.10026328),
        dec: Angle.Degrees(-46.75993679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55892"},
        {"Hipparcos Number", "HIP 34834"},
        {"Celescope Catalog", "CEL 1681"},
        {"Fundamental Katalog 5th Edition", "FK5 275"},
        {"Geneva Identification System", "GEN# +1.00055892"},
        {"Renson", "Renson 15230"},
        {"Smithsonian Astrophysical Observation", "SAO 218537"},
        {"Wilson Evans Batten Catalogue", "WEB 6965"},
        {"Wilson Evans Batten Catalogue 2", "WEB 11597"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14058722),
        dec: Angle.Degrees(-46.75956448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86857"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.19339912),
        dec: Angle.Degrees(-46.75925809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25326"},
        {"Hipparcos Number", "HIP 18638"},
        {"Smithsonian Astrophysical Observation", "SAO 216591"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.83948118),
        dec: Angle.Degrees(-46.75648060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9184"},
        {"Hipparcos Number", "HIP 6952"},
        {"Geneva Identification System", "GEN# +1.00009184"},
        {"Smithsonian Astrophysical Observation", "SAO 215525"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.37723818),
        dec: Angle.Degrees(-46.75646248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67421"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.26579160),
        dec: Angle.Degrees(-46.75484254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153641"},
        {"Hipparcos Number", "HIP 83413"},
        {"Geneva Identification System", "GEN# +1.00153641J"},
        {"Smithsonian Astrophysical Observation", "SAO 227574"},
        {"Wilson Evans Batten Catalogue", "WEB 14099"},
        {"Wilson Evans Batten Catalogue 2", "WEB 14098"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.73650920),
        dec: Angle.Degrees(-46.75199612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134479"},
        {"Hipparcos Number", "HIP 74369"},
        {"Smithsonian Astrophysical Observation", "SAO 225523"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95983816),
        dec: Angle.Degrees(-46.75174229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96891"},
        {"Hipparcos Number", "HIP 54494"},
        {"Smithsonian Astrophysical Observation", "SAO 222596"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.23867852),
        dec: Angle.Degrees(-46.74931499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169766"},
        {"Hipparcos Number", "HIP 90546"},
        {"Geneva Identification System", "GEN# +1.00169766"},
        {"Smithsonian Astrophysical Observation", "SAO 229043"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.13795541),
        dec: Angle.Degrees(-46.74884781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75406"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.11419366),
        dec: Angle.Degrees(-46.74426447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24222"},
        {"Hipparcos Number", "HIP 17860"},
        {"Smithsonian Astrophysical Observation", "SAO 216505"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.33871536),
        dec: Angle.Degrees(-46.74373061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210783"},
        {"Hipparcos Number", "HIP 109742"},
        {"Geneva Identification System", "GEN# +1.00210783"},
        {"Smithsonian Astrophysical Observation", "SAO 231039"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.44285974),
        dec: Angle.Degrees(-46.74362737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103281"},
        {"Hipparcos Number", "HIP 57981"},
        {"Geneva Identification System", "GEN# +1.00103281"},
        {"Smithsonian Astrophysical Observation", "SAO 223089"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.39956243),
        dec: Angle.Degrees(-46.74179586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126803"},
        {"Hipparcos Number", "HIP 70829"},
        {"Geneva Identification System", "GEN# +1.00126803"},
        {"Smithsonian Astrophysical Observation", "SAO 224953"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.26451279),
        dec: Angle.Degrees(-46.74148996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -266.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213221"},
        {"Hipparcos Number", "HIP 111129"},
        {"Smithsonian Astrophysical Observation", "SAO 231171"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.69446923),
        dec: Angle.Degrees(-46.74026508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154873"},
        {"Hipparcos Number", "HIP 84010"},
        {"Celescope Catalog", "CEL 4482"},
        {"Geneva Identification System", "GEN# +1.00154873"},
        {"Wilson Evans Batten Catalogue", "WEB 14193"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.58682797),
        dec: Angle.Degrees(-46.73839868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60752"},
        {"Hipparcos Number", "HIP 36781"},
        {"Geneva Identification System", "GEN# +1.00060752"},
        {"Smithsonian Astrophysical Observation", "SAO 218802"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.47034469),
        dec: Angle.Degrees(-46.73814417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98224"},
        {"Hipparcos Number", "HIP 55150"},
        {"Smithsonian Astrophysical Observation", "SAO 222698"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.36738670),
        dec: Angle.Degrees(-46.73717296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175484"},
        {"Hipparcos Number", "HIP 93092"},
        {"Smithsonian Astrophysical Observation", "SAO 229405"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.46001696),
        dec: Angle.Degrees(-46.73623872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117484"},
        {"Hipparcos Number", "HIP 65965"},
        {"Geneva Identification System", "GEN# +1.00117484"},
        {"Smithsonian Astrophysical Observation", "SAO 224215"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.87911042),
        dec: Angle.Degrees(-46.73519473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191190"},
        {"Hipparcos Number", "HIP 99417"},
        {"Geneva Identification System", "GEN# +1.00191190"},
        {"Smithsonian Astrophysical Observation", "SAO 230083"},
        {"Wilson Evans Batten Catalogue", "WEB 17746"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.66278743),
        dec: Angle.Degrees(-46.73500559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188408"},
        {"Hipparcos Number", "HIP 98180"},
        {"Smithsonian Astrophysical Observation", "SAO 229947"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.28136034),
        dec: Angle.Degrees(-46.73473271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137709"},
        {"Hipparcos Number", "HIP 75828"},
        {"Fundamental Katalog 5th Edition", "FK5 3220"},
        {"Geneva Identification System", "GEN# +1.00137709"},
        {"Smithsonian Astrophysical Observation", "SAO 225825"},
        {"Wilson Evans Batten Catalogue", "WEB 12905"},
    },
    visualMagnitude: 5.26,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.35115072),
        dec: Angle.Degrees(-46.73269070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88875"},
        {"Hipparcos Number", "HIP 50128"},
        {"Geneva Identification System", "GEN# +1.00088875"},
        {"Smithsonian Astrophysical Observation", "SAO 221888"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.50104011),
        dec: Angle.Degrees(-46.73203116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218508"},
        {"Hipparcos Number", "HIP 114316"},
        {"Smithsonian Astrophysical Observation", "SAO 231459"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.27041191),
        dec: Angle.Degrees(-46.72577448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88839"},
        {"Hipparcos Number", "HIP 50098"},
        {"Smithsonian Astrophysical Observation", "SAO 221878"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.43370227),
        dec: Angle.Degrees(-46.72523323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18514"},
        {"Hipparcos Number", "HIP 13726"},
        {"Geneva Identification System", "GEN# +1.00018514"},
        {"Smithsonian Astrophysical Observation", "SAO 216106"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.19952003),
        dec: Angle.Degrees(-46.72389625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119380"},
        {"Hipparcos Number", "HIP 67007"},
        {"Smithsonian Astrophysical Observation", "SAO 224371"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.98850701),
        dec: Angle.Degrees(-46.72366695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221053"},
        {"Hipparcos Number", "HIP 115913"},
        {"Smithsonian Astrophysical Observation", "SAO 231623"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.26922211),
        dec: Angle.Degrees(-46.72293778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22249"},
        {"Hipparcos Number", "HIP 16544"},
        {"Geneva Identification System", "GEN# +1.00022249"},
        {"Smithsonian Astrophysical Observation", "SAO 216379"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.26575418),
        dec: Angle.Degrees(-46.72230062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221373"},
        {"Hipparcos Number", "HIP 116136"},
        {"Geneva Identification System", "GEN# +1.00221373"},
        {"Smithsonian Astrophysical Observation", "SAO 231643"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.97160314),
        dec: Angle.Degrees(-46.72185344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1308"},
        {"Geneva Identification System", "GEN# +6.20145157"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.10122696),
        dec: Angle.Degrees(-46.71986215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6595"},
        {"Hipparcos Number", "HIP 5165"},
        {"Geneva Identification System", "GEN# +1.00006595"},
        {"Smithsonian Astrophysical Observation", "SAO 215365"},
        {"Wilson Evans Batten Catalogue", "WEB 1077"},
    },
    visualMagnitude: 3.32,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52127713),
        dec: Angle.Degrees(-46.71849042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170023"},
        {"Hipparcos Number", "HIP 90640"},
        {"Smithsonian Astrophysical Observation", "SAO 229062"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.41024448),
        dec: Angle.Degrees(-46.71759295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139770"},
        {"Hipparcos Number", "HIP 76884"},
        {"Smithsonian Astrophysical Observation", "SAO 226077"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49598382),
        dec: Angle.Degrees(-46.71669788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6365"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.43952009),
        dec: Angle.Degrees(-46.71418505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220984"},
        {"Hipparcos Number", "HIP 115869"},
        {"Geneva Identification System", "GEN# +1.00220984"},
        {"Smithsonian Astrophysical Observation", "SAO 231618"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.12895944),
        dec: Angle.Degrees(-46.71394479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223161"},
        {"Hipparcos Number", "HIP 117316"},
        {"Geneva Identification System", "GEN# +1.00223161J"},
        {"Smithsonian Astrophysical Observation", "SAO 231780"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.81916600),
        dec: Angle.Degrees(-46.71257200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198765"},
        {"Hipparcos Number", "HIP 103177"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.57064676),
        dec: Angle.Degrees(-46.71144274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56709",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Przybylski's Star"},
        {"Henry Draper", "HD 101065"},
        {"Hipparcos Number", "HIP 56709"},
        {"Geneva Identification System", "GEN# +1.00101065"},
        {"Renson", "Renson 29120"},
        {"Smithsonian Astrophysical Observation", "SAO 222918"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.40450354),
        dec: Angle.Degrees(-46.70977192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50080"},
        {"Hipparcos Number", "HIP 32691"},
        {"Celescope Catalog", "CEL 1400"},
        {"Geneva Identification System", "GEN# +1.00050080"},
        {"Smithsonian Astrophysical Observation", "SAO 218225"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.30635571),
        dec: Angle.Degrees(-46.70960101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214308"},
        {"Hipparcos Number", "HIP 111738"},
        {"Geneva Identification System", "GEN# +1.00214308"},
        {"Smithsonian Astrophysical Observation", "SAO 231225"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.51832199),
        dec: Angle.Degrees(-46.70956941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35584"},
        {"Geneva Identification System", "GEN# -0.04603086"},
    },
    visualMagnitude: 11.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.14813752),
        dec: Angle.Degrees(-46.70836079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90656"},
        {"Hipparcos Number", "HIP 51176"},
        {"Smithsonian Astrophysical Observation", "SAO 222061"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.79285287),
        dec: Angle.Degrees(-46.70828845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76271"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.68702779),
        dec: Angle.Degrees(-46.70476977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31861"},
        {"Hipparcos Number", "HIP 23017"},
        {"Smithsonian Astrophysical Observation", "SAO 217076"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.25041856),
        dec: Angle.Degrees(-46.70370184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64366"},
        {"Hipparcos Number", "HIP 38359"},
        {"Smithsonian Astrophysical Observation", "SAO 219074"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.84497605),
        dec: Angle.Degrees(-46.70324423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163007"},
        {"Hipparcos Number", "HIP 87805"},
        {"Geneva Identification System", "GEN# +1.00163007"},
        {"Smithsonian Astrophysical Observation", "SAO 228556"},
        {"Wilson Evans Batten Catalogue", "WEB 14817"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.05577370),
        dec: Angle.Degrees(-46.70213126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217549"},
        {"Hipparcos Number", "HIP 113743"},
        {"Smithsonian Astrophysical Observation", "SAO 231400"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52708844),
        dec: Angle.Degrees(-46.70103426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140657"},
        {"Hipparcos Number", "HIP 77280"},
        {"Geneva Identification System", "GEN# +1.00140657"},
        {"Smithsonian Astrophysical Observation", "SAO 226176"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.67054009),
        dec: Angle.Degrees(-46.69954989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4737"},
        {"Hipparcos Number", "HIP 3807"},
        {"Fundamental Katalog 5th Edition", "FK5 2053"},
        {"Geneva Identification System", "GEN# +1.00004737"},
        {"Smithsonian Astrophysical Observation", "SAO 215245"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.23640318),
        dec: Angle.Degrees(-46.69769826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123909"},
        {"Hipparcos Number", "HIP 69343"},
        {"Smithsonian Astrophysical Observation", "SAO 224753"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.88372564),
        dec: Angle.Degrees(-46.69636550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198635"},
        {"Hipparcos Number", "HIP 103102"},
        {"Geneva Identification System", "GEN# +1.00198635"},
        {"Smithsonian Astrophysical Observation", "SAO 230420"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35256505),
        dec: Angle.Degrees(-46.69366443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105679"},
    },
    visualMagnitude: 12.45,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.07387208),
        dec: Angle.Degrees(-46.69295614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 736.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187200"},
        {"Hipparcos Number", "HIP 97666"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.73057865),
        dec: Angle.Degrees(-46.69274264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171062"},
        {"Hipparcos Number", "HIP 91096"},
        {"Geneva Identification System", "GEN# +1.00171062"},
        {"Smithsonian Astrophysical Observation", "SAO 229127"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.73096575),
        dec: Angle.Degrees(-46.69119337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115157"},
        {"Hipparcos Number", "HIP 64736"},
        {"Geneva Identification System", "GEN# +1.00115157"},
        {"Smithsonian Astrophysical Observation", "SAO 224017"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01887109),
        dec: Angle.Degrees(-46.69083120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11711"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.78362003),
        dec: Angle.Degrees(-46.69004729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59869"},
        {"Hipparcos Number", "HIP 36422"},
        {"Celescope Catalog", "CEL 1895"},
        {"Geneva Identification System", "GEN# +1.00059869"},
        {"Smithsonian Astrophysical Observation", "SAO 218762"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.43896456),
        dec: Angle.Degrees(-46.68949727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185281"},
        {"Hipparcos Number", "HIP 96790"},
        {"Smithsonian Astrophysical Observation", "SAO 229808"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.12483893),
        dec: Angle.Degrees(-46.68893288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5026"},
        {"Hipparcos Number", "HIP 4033"},
        {"Geneva Identification System", "GEN# +1.00005026"},
        {"Smithsonian Astrophysical Observation", "SAO 215268"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.91316782),
        dec: Angle.Degrees(-46.68884335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85806"},
        {"Hipparcos Number", "HIP 48473"},
        {"Smithsonian Astrophysical Observation", "SAO 221571"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.26815734),
        dec: Angle.Degrees(-46.68753624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214553"},
        {"Hipparcos Number", "HIP 111885"},
        {"Smithsonian Astrophysical Observation", "SAO 231236"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.95083218),
        dec: Angle.Degrees(-46.68588214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211615"},
        {"Hipparcos Number", "HIP 110201"},
        {"Fundamental Katalog 5th Edition", "FK5 5968"},
        {"Smithsonian Astrophysical Observation", "SAO 231080"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.83917725),
        dec: Angle.Degrees(-46.68574732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205344"},
        {"Hipparcos Number", "HIP 106640"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.00211237),
        dec: Angle.Degrees(-46.68568387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180072"},
        {"Hipparcos Number", "HIP 94800"},
        {"Smithsonian Astrophysical Observation", "SAO 229592"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.33912384),
        dec: Angle.Degrees(-46.68319508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106639"},
    },
    visualMagnitude: 12.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.00052174),
        dec: Angle.Degrees(-46.68271550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98893"},
        {"Hipparcos Number", "HIP 55529"},
        {"Smithsonian Astrophysical Observation", "SAO 222753"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.60667537),
        dec: Angle.Degrees(-46.68194514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2660"},
        {"Hipparcos Number", "HIP 2348"},
        {"Smithsonian Astrophysical Observation", "SAO 215116"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.49484345),
        dec: Angle.Degrees(-46.68194472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11794"},
        {"Hipparcos Number", "HIP 8897"},
        {"Smithsonian Astrophysical Observation", "SAO 215699"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.64652374),
        dec: Angle.Degrees(-46.68064984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221709"},
        {"Hipparcos Number", "HIP 116357"},
        {"Geneva Identification System", "GEN# +1.00221709"},
        {"Smithsonian Astrophysical Observation", "SAO 231669"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.66165945),
        dec: Angle.Degrees(-46.68020403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154426"},
        {"Hipparcos Number", "HIP 83802"},
        {"Geneva Identification System", "GEN# +1.00154426"},
        {"Smithsonian Astrophysical Observation", "SAO 227642"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.89683389),
        dec: Angle.Degrees(-46.67971735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216643"},
        {"Hipparcos Number", "HIP 113185"},
        {"Fundamental Katalog 5th Edition", "FK5 6025"},
        {"Smithsonian Astrophysical Observation", "SAO 231352"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.79640221),
        dec: Angle.Degrees(-46.67887103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44688"},
        {"Hipparcos Number", "HIP 30150"},
        {"Smithsonian Astrophysical Observation", "SAO 217870"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.17049933),
        dec: Angle.Degrees(-46.67798273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107871"},
        {"Hipparcos Number", "HIP 60480"},
        {"Smithsonian Astrophysical Observation", "SAO 223406"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.98109013),
        dec: Angle.Degrees(-46.67789088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86410"},
        {"Hipparcos Number", "HIP 48796"},
        {"Smithsonian Astrophysical Observation", "SAO 221632"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.28273049),
        dec: Angle.Degrees(-46.67783554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42666"},
        {"Hipparcos Number", "HIP 29197"},
        {"Smithsonian Astrophysical Observation", "SAO 217749"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.38529886),
        dec: Angle.Degrees(-46.67709874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82020"},
        {"Hipparcos Number", "HIP 46411"},
        {"Smithsonian Astrophysical Observation", "SAO 221188"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.96649857),
        dec: Angle.Degrees(-46.67609952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40494"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.01525124),
        dec: Angle.Degrees(-46.67528587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212180"},
        {"Hipparcos Number", "HIP 110520"},
        {"Geneva Identification System", "GEN# +1.00212180"},
        {"Smithsonian Astrophysical Observation", "SAO 231116"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.85272735),
        dec: Angle.Degrees(-46.66862352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6869"},
        {"Hipparcos Number", "HIP 5363"},
        {"Geneva Identification System", "GEN# +1.00006869J"},
        {"Smithsonian Astrophysical Observation", "SAO 215379"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.14090677),
        dec: Angle.Degrees(-46.66803915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212037"},
        {"Hipparcos Number", "HIP 110457"},
        {"Smithsonian Astrophysical Observation", "SAO 231100"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.61023034),
        dec: Angle.Degrees(-46.66772780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65187"},
        {"Hipparcos Number", "HIP 38704"},
        {"Smithsonian Astrophysical Observation", "SAO 219151"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.85731507),
        dec: Angle.Degrees(-46.66586876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28546"},
        {"Geneva Identification System", "GEN# +6.00001799"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.38856085),
        dec: Angle.Degrees(-46.66547609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125789"},
        {"Hipparcos Number", "HIP 70303"},
        {"Geneva Identification System", "GEN# +1.00125789"},
        {"Smithsonian Astrophysical Observation", "SAO 224877"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.76486331),
        dec: Angle.Degrees(-46.66533591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194188"},
        {"Hipparcos Number", "HIP 100787"},
        {"Geneva Identification System", "GEN# +1.00194188"},
        {"Smithsonian Astrophysical Observation", "SAO 230199"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.51979525),
        dec: Angle.Degrees(-46.65995609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62506"},
        {"Hipparcos Number", "HIP 37525"},
        {"Geneva Identification System", "GEN# +1.00062506"},
        {"Smithsonian Astrophysical Observation", "SAO 218912"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.53093051),
        dec: Angle.Degrees(-46.65790436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32383"},
        {"Hipparcos Number", "HIP 23290"},
        {"Smithsonian Astrophysical Observation", "SAO 217111"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.14656227),
        dec: Angle.Degrees(-46.65648460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185929"},
        {"Hipparcos Number", "HIP 97073"},
        {"Smithsonian Astrophysical Observation", "SAO 229833"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.91980474),
        dec: Angle.Degrees(-46.65548170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116600"},
        {"Hipparcos Number", "HIP 65497"},
        {"Geneva Identification System", "GEN# +1.00116600"},
        {"Smithsonian Astrophysical Observation", "SAO 224128"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.35763149),
        dec: Angle.Degrees(-46.65532802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84188"},
        {"Hipparcos Number", "HIP 47574"},
        {"Smithsonian Astrophysical Observation", "SAO 221414"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.50820742),
        dec: Angle.Degrees(-46.65430673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67362"},
        {"Hipparcos Number", "HIP 39597"},
        {"Geneva Identification System", "GEN# +1.00067362"},
        {"Smithsonian Astrophysical Observation", "SAO 219403"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.38107454),
        dec: Angle.Degrees(-46.65421111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176387"},
        {"Hipparcos Number", "HIP 93476"},
        {"Geneva Identification System", "GEN# +1.00176387"},
        {"Smithsonian Astrophysical Observation", "SAO 229444"},
        {"Wilson Evans Batten Catalogue", "WEB 16223"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.55165506),
        dec: Angle.Degrees(-46.65307916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122262"},
        {"Hipparcos Number", "HIP 68542"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.47941839),
        dec: Angle.Degrees(-46.65147482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121734"},
        {"Hipparcos Number", "HIP 68257"},
        {"Geneva Identification System", "GEN# +1.00121734"},
        {"Smithsonian Astrophysical Observation", "SAO 224579"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.60202753),
        dec: Angle.Degrees(-46.65128656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74180"},
        {"Hipparcos Number", "HIP 42570"},
        {"Celescope Catalog", "CEL 2770"},
        {"Fundamental Katalog 5th Edition", "FK5 1226"},
        {"Geneva Identification System", "GEN# +1.00074180A"},
        {"Smithsonian Astrophysical Observation", "SAO 220265"},
        {"Wilson Evans Batten Catalogue", "WEB 8213"},
    },
    visualMagnitude: 3.77,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.15656369),
        dec: Angle.Degrees(-46.64875492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198009"},
        {"Hipparcos Number", "HIP 102763"},
        {"Geneva Identification System", "GEN# +1.00198009"},
        {"Smithsonian Astrophysical Observation", "SAO 230389"},
        {"Wilson Evans Batten Catalogue", "WEB 18633"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31595642),
        dec: Angle.Degrees(-46.64874202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27543"},
        {"Hipparcos Number", "HIP 20112"},
        {"Smithsonian Astrophysical Observation", "SAO 216743"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.67792073),
        dec: Angle.Degrees(-46.64865351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150302"},
        {"Hipparcos Number", "HIP 81791"},
        {"Smithsonian Astrophysical Observation", "SAO 227071"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.58328764),
        dec: Angle.Degrees(-46.64720867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16520"},
        {"Hipparcos Number", "HIP 12229"},
        {"Smithsonian Astrophysical Observation", "SAO 215969"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.36353490),
        dec: Angle.Degrees(-46.64623744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26167"},
        {"Hipparcos Number", "HIP 19150"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.57137639),
        dec: Angle.Degrees(-46.64539250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69256"},
        {"Hipparcos Number", "HIP 40333"},
        {"Geneva Identification System", "GEN# +1.00069256"},
        {"Smithsonian Astrophysical Observation", "SAO 219644"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.53138159),
        dec: Angle.Degrees(-46.64485704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28154"},
        {"Hipparcos Number", "HIP 20561"},
        {"Geneva Identification System", "GEN# +1.00028154"},
        {"Smithsonian Astrophysical Observation", "SAO 216783"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.06656132),
        dec: Angle.Degrees(-46.64481667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68808"},
        {"Hipparcos Number", "HIP 40155"},
        {"Geneva Identification System", "GEN# +1.00068808"},
        {"Smithsonian Astrophysical Observation", "SAO 219587"},
        {"Wilson Evans Batten Catalogue", "WEB 7834"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.99988027),
        dec: Angle.Degrees(-46.64436989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40104"},
        {"Hipparcos Number", "HIP 27916"},
        {"Smithsonian Astrophysical Observation", "SAO 217611"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.61190792),
        dec: Angle.Degrees(-46.64312402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11512"},
        {"Hipparcos Number", "HIP 8707"},
        {"Geneva Identification System", "GEN# +1.00011512"},
        {"Smithsonian Astrophysical Observation", "SAO 215684"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.00782116),
        dec: Angle.Degrees(-46.64126957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67703"},
        {"Hipparcos Number", "HIP 39728"},
        {"Geneva Identification System", "GEN# +1.00067703"},
        {"Smithsonian Astrophysical Observation", "SAO 219442"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.80160770),
        dec: Angle.Degrees(-46.64086330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80571"},
        {"Hipparcos Number", "HIP 45711"},
        {"Geneva Identification System", "GEN# +1.00080571"},
        {"Smithsonian Astrophysical Observation", "SAO 221062"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.78216290),
        dec: Angle.Degrees(-46.63961993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222287"},
        {"Hipparcos Number", "HIP 116737"},
        {"Geneva Identification System", "GEN# +1.00222287J"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.86635383),
        dec: Angle.Degrees(-46.63789839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85997"},
        {"Hipparcos Number", "HIP 48571"},
        {"Geneva Identification System", "GEN# +1.00085997"},
        {"Smithsonian Astrophysical Observation", "SAO 221593"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.59611219),
        dec: Angle.Degrees(-46.63688402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131078"},
        {"Hipparcos Number", "HIP 72821"},
        {"Geneva Identification System", "GEN# +1.00131078J"},
        {"Smithsonian Astrophysical Observation", "SAO 225267"},
        {"Wilson Evans Batten Catalogue", "WEB 12509"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.27020393),
        dec: Angle.Degrees(-46.63680701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156274"},
        {"Hipparcos Number", "HIP 84720"},
        {"Cincinnati Publication", "Ci 20 1029"},
        {"Geneva Identification System", "GEN# +1.00156274A"},
        {"Geneva Identification System 2", "GEN# +1.00156274"},
        {"Smithsonian Astrophysical Observation", "SAO 227816"},
        {"Wilson Evans Batten Catalogue", "WEB 14304"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76230946),
        dec: Angle.Degrees(-46.63650010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1035.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87363"},
        {"Hipparcos Number", "HIP 49259"},
        {"Geneva Identification System", "GEN# +1.00087363"},
        {"Renson", "Renson 25000"},
        {"Smithsonian Astrophysical Observation", "SAO 221728"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.83585305),
        dec: Angle.Degrees(-46.63616508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71444"},
        {"Hipparcos Number", "HIP 41295"},
        {"Celescope Catalog", "CEL 2494"},
        {"Smithsonian Astrophysical Observation", "SAO 219906"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.37716407),
        dec: Angle.Degrees(-46.63424728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104138"},
        {"Hipparcos Number", "HIP 58482"},
        {"Geneva Identification System", "GEN# +1.00104138"},
        {"Smithsonian Astrophysical Observation", "SAO 223155"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.89692218),
        dec: Angle.Degrees(-46.63312830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131464"},
        {"Hipparcos Number", "HIP 73016"},
        {"Geneva Identification System", "GEN# +1.00131464"},
        {"Smithsonian Astrophysical Observation", "SAO 225291"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.82888777),
        dec: Angle.Degrees(-46.63124221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8050"},
        {"Hipparcos Number", "HIP 6169"},
        {"Geneva Identification System", "GEN# +1.00008050"},
        {"Smithsonian Astrophysical Observation", "SAO 215454"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.78456316),
        dec: Angle.Degrees(-46.62929890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158585"},
        {"Hipparcos Number", "HIP 85836"},
        {"Geneva Identification System", "GEN# +1.00158585J"},
        {"Smithsonian Astrophysical Observation", "SAO 228087"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.09586081),
        dec: Angle.Degrees(-46.62859720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135287"},
        {"Hipparcos Number", "HIP 74706"},
        {"Smithsonian Astrophysical Observation", "SAO 225598"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.01544438),
        dec: Angle.Degrees(-46.62534300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63869"},
        {"Hipparcos Number", "HIP 38137"},
        {"Smithsonian Astrophysical Observation", "SAO 219028"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.23610035),
        dec: Angle.Degrees(-46.62196762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198592"},
        {"Hipparcos Number", "HIP 103081"},
        {"Smithsonian Astrophysical Observation", "SAO 230414"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.28719635),
        dec: Angle.Degrees(-46.61795825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1055"},
        {"Hipparcos Number", "HIP 1171"},
        {"Smithsonian Astrophysical Observation", "SAO 215016"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66003568),
        dec: Angle.Degrees(-46.61722720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182187"},
        {"Hipparcos Number", "HIP 95515"},
        {"Smithsonian Astrophysical Observation", "SAO 229670"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.42876920),
        dec: Angle.Degrees(-46.61668252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222322"},
        {"Hipparcos Number", "HIP 116755"},
        {"Smithsonian Astrophysical Observation", "SAO 231724"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.93547322),
        dec: Angle.Degrees(-46.61565827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50223"},
        {"Hipparcos Number", "HIP 32765"},
        {"Fundamental Katalog 5th Edition", "FK5 2529"},
        {"Geneva Identification System", "GEN# +1.00050223"},
        {"Smithsonian Astrophysical Observation", "SAO 218235"},
        {"Wilson Evans Batten Catalogue", "WEB 6597"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.47757095),
        dec: Angle.Degrees(-46.61547007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 374.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169202"},
        {"Hipparcos Number", "HIP 90333"},
        {"Smithsonian Astrophysical Observation", "SAO 229010"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.46937378),
        dec: Angle.Degrees(-46.61481287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203548"},
        {"Hipparcos Number", "HIP 105685"},
        {"Geneva Identification System", "GEN# +1.00203548"},
        {"Renson", "Renson 56680"},
        {"Smithsonian Astrophysical Observation", "SAO 230665"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.08667854),
        dec: Angle.Degrees(-46.61467113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22019"},
        {"Hipparcos Number", "HIP 16391"},
        {"Geneva Identification System", "GEN# +1.00022019"},
        {"Smithsonian Astrophysical Observation", "SAO 216361"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.77062115),
        dec: Angle.Degrees(-46.61442271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206533"},
        {"Hipparcos Number", "HIP 107295"},
        {"Geneva Identification System", "GEN# +1.00206533"},
        {"Smithsonian Astrophysical Observation", "SAO 230814"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.98865008),
        dec: Angle.Degrees(-46.61361945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142319"},
        {"Hipparcos Number", "HIP 78023"},
        {"Smithsonian Astrophysical Observation", "SAO 226371"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.97632079),
        dec: Angle.Degrees(-46.61191726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207376"},
        {"Hipparcos Number", "HIP 107757"},
        {"Smithsonian Astrophysical Observation", "SAO 230854"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.43927155),
        dec: Angle.Degrees(-46.61088626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205048"},
        {"Hipparcos Number", "HIP 106483"},
        {"Fundamental Katalog 5th Edition", "FK5 5905"},
        {"Smithsonian Astrophysical Observation", "SAO 230739"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.50570038),
        dec: Angle.Degrees(-46.61061399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75968"},
        {"Hipparcos Number", "HIP 43494"},
        {"Celescope Catalog", "CEL 3006"},
        {"Geneva Identification System", "GEN# +1.00075968"},
        {"Smithsonian Astrophysical Observation", "SAO 220585"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.88674815),
        dec: Angle.Degrees(-46.60999638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63578"},
        {"Hipparcos Number", "HIP 38020"},
        {"Celescope Catalog", "CEL 2039"},
        {"Fundamental Katalog 5th Edition", "FK5 1203"},
        {"Geneva Identification System", "GEN# +1.00063578"},
        {"Smithsonian Astrophysical Observation", "SAO 219000"},
        {"Wilson Evans Batten Catalogue", "WEB 7500"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.88129103),
        dec: Angle.Degrees(-46.60850937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13074"},
        {"Hipparcos Number", "HIP 9846"},
        {"Smithsonian Astrophysical Observation", "SAO 215772"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67177226),
        dec: Angle.Degrees(-46.60783614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160717"},
        {"Hipparcos Number", "HIP 86764"},
        {"Smithsonian Astrophysical Observation", "SAO 228338"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.93454550),
        dec: Angle.Degrees(-46.60627144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95274"},
        {"Hipparcos Number", "HIP 53713"},
        {"Smithsonian Astrophysical Observation", "SAO 222475"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.85267407),
        dec: Angle.Degrees(-46.60538850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201499"},
        {"Hipparcos Number", "HIP 104633"},
        {"Smithsonian Astrophysical Observation", "SAO 230570"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.92050051),
        dec: Angle.Degrees(-46.60301321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114454"},
        {"Hipparcos Number", "HIP 64341"},
        {"Geneva Identification System", "GEN# +1.00114454"},
        {"Smithsonian Astrophysical Observation", "SAO 223964"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.82790013),
        dec: Angle.Degrees(-46.60195201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95409"},
        {"Hipparcos Number", "HIP 53783"},
        {"Smithsonian Astrophysical Observation", "SAO 222491"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.06508310),
        dec: Angle.Degrees(-46.60143514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102516"},
        {"Hipparcos Number", "HIP 57552"},
        {"Smithsonian Astrophysical Observation", "SAO 223030"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.94269279),
        dec: Angle.Degrees(-46.60133562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173066"},
        {"Hipparcos Number", "HIP 92050"},
        {"Smithsonian Astrophysical Observation", "SAO 229250"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.43028961),
        dec: Angle.Degrees(-46.60130732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158906"},
        {"Hipparcos Number", "HIP 85957"},
        {"Celescope Catalog", "CEL 4531"},
        {"Geneva Identification System", "GEN# +1.00158906"},
        {"Smithsonian Astrophysical Observation", "SAO 228123"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.51742812),
        dec: Angle.Degrees(-46.60046955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198828"},
        {"Hipparcos Number", "HIP 103230"},
        {"Geneva Identification System", "GEN# +1.00198828"},
        {"Smithsonian Astrophysical Observation", "SAO 230431"},
        {"Wilson Evans Batten Catalogue", "WEB 18754"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.70474155),
        dec: Angle.Degrees(-46.60030820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38871"},
        {"Hipparcos Number", "HIP 27243"},
        {"Fundamental Katalog 5th Edition", "FK5 2434"},
        {"Geneva Identification System", "GEN# +1.00038871"},
        {"Smithsonian Astrophysical Observation", "SAO 217521"},
        {"Wilson Evans Batten Catalogue", "WEB 5356"},
    },
    visualMagnitude: 5.31,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.61402516),
        dec: Angle.Degrees(-46.59722012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174387"},
        {"Hipparcos Number", "HIP 92630"},
        {"Geneva Identification System", "GEN# +1.00174387"},
        {"Smithsonian Astrophysical Observation", "SAO 229336"},
        {"Wilson Evans Batten Catalogue", "WEB 16024"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11335813),
        dec: Angle.Degrees(-46.59511945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65658"},
        {"Hipparcos Number", "HIP 38896"},
        {"Celescope Catalog", "CEL 2116"},
        {"Geneva Identification System", "GEN# +1.00065658J"},
        {"Smithsonian Astrophysical Observation", "SAO 219209"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.40864363),
        dec: Angle.Degrees(-46.59330954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115937"},
        {"Geneva Identification System", "GEN# +6.20145136"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.34699862),
        dec: Angle.Degrees(-45.62228520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121416"},
        {"Hipparcos Number", "HIP 68079"},
        {"Geneva Identification System", "GEN# +1.00121416"},
        {"Smithsonian Astrophysical Observation", "SAO 224555"},
        {"Wilson Evans Batten Catalogue", "WEB 11950"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.08288902),
        dec: Angle.Degrees(-46.59272882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220216"},
        {"Hipparcos Number", "HIP 115386"},
        {"Smithsonian Astrophysical Observation", "SAO 231571"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.60677009),
        dec: Angle.Degrees(-46.59250007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85853"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.17301978),
        dec: Angle.Degrees(-46.59103744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114827"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.90066457),
        dec: Angle.Degrees(-46.59091378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297178"},
        {"Hipparcos Number", "HIP 49872"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.75661430),
        dec: Angle.Degrees(-46.58798492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160648"},
        {"Hipparcos Number", "HIP 86735"},
        {"Celescope Catalog", "CEL 4556"},
        {"Geneva Identification System", "GEN# +1.00160648"},
        {"Smithsonian Astrophysical Observation", "SAO 228325"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.85117601),
        dec: Angle.Degrees(-46.58793737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123079"},
        {"Hipparcos Number", "HIP 68930"},
        {"Smithsonian Astrophysical Observation", "SAO 224679"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.66940964),
        dec: Angle.Degrees(-46.58750174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174500"},
        {"Hipparcos Number", "HIP 92669"},
        {"Geneva Identification System", "GEN# +1.00174500"},
        {"Smithsonian Astrophysical Observation", "SAO 229343"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.24957133),
        dec: Angle.Degrees(-46.58635607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13588"},
        {"Hipparcos Number", "HIP 10205"},
        {"Geneva Identification System", "GEN# +1.00013588"},
        {"Renson", "Renson 3520"},
        {"Smithsonian Astrophysical Observation", "SAO 215805"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.81929814),
        dec: Angle.Degrees(-46.58503254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159619"},
        {"Hipparcos Number", "HIP 86295"},
        {"Geneva Identification System", "GEN# +1.00159619"},
        {"Smithsonian Astrophysical Observation", "SAO 228214"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.49213396),
        dec: Angle.Degrees(-46.58502881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153552"},
        {"Hipparcos Number", "HIP 83381"},
        {"Smithsonian Astrophysical Observation", "SAO 227568"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.62386334),
        dec: Angle.Degrees(-46.58494081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108787"},
        {"Hipparcos Number", "HIP 61014"},
        {"Smithsonian Astrophysical Observation", "SAO 223476"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.56755618),
        dec: Angle.Degrees(-46.58419716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128582"},
        {"Hipparcos Number", "HIP 71639"},
        {"Geneva Identification System", "GEN# +1.00128582"},
        {"Smithsonian Astrophysical Observation", "SAO 225089"},
        {"Wilson Evans Batten Catalogue", "WEB 12347"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.79589411),
        dec: Angle.Degrees(-46.58395597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79275"},
        {"Hipparcos Number", "HIP 45122"},
        {"Celescope Catalog", "CEL 3210"},
        {"Geneva Identification System", "GEN# +1.00079275"},
        {"Smithsonian Astrophysical Observation", "SAO 220937"},
        {"Wilson Evans Batten Catalogue", "WEB 8609"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.88912076),
        dec: Angle.Degrees(-46.58392947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94642"},
        {"Hipparcos Number", "HIP 53373"},
        {"Smithsonian Astrophysical Observation", "SAO 222420"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.71777257),
        dec: Angle.Degrees(-46.58320681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166353"},
        {"Hipparcos Number", "HIP 89232"},
        {"Smithsonian Astrophysical Observation", "SAO 228800"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.14090601),
        dec: Angle.Degrees(-46.58046612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213363"},
        {"Hipparcos Number", "HIP 111211"},
        {"Geneva Identification System", "GEN# +1.00213363"},
        {"Smithsonian Astrophysical Observation", "SAO 231184"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.94920002),
        dec: Angle.Degrees(-46.57965511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74454"},
        {"Hipparcos Number", "HIP 42720"},
        {"Celescope Catalog", "CEL 2802"},
        {"Geneva Identification System", "GEN# +1.00074454"},
        {"Smithsonian Astrophysical Observation", "SAO 220315"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.59400126),
        dec: Angle.Degrees(-46.57936056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182394"},
        {"Hipparcos Number", "HIP 95603"},
        {"Smithsonian Astrophysical Observation", "SAO 229677"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.67323922),
        dec: Angle.Degrees(-46.57889912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69168"},
        {"Hipparcos Number", "HIP 40299"},
        {"Celescope Catalog", "CEL 2258"},
        {"Geneva Identification System", "GEN# +1.00069168"},
        {"Smithsonian Astrophysical Observation", "SAO 219631"},
        {"Wilson Evans Batten Catalogue", "WEB 7861"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.44024303),
        dec: Angle.Degrees(-46.57869454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61077"},
        {"Hipparcos Number", "HIP 36908"},
        {"Celescope Catalog", "CEL 1943"},
        {"Geneva Identification System", "GEN# +1.00061077"},
        {"Smithsonian Astrophysical Observation", "SAO 218821"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.81989433),
        dec: Angle.Degrees(-46.57767965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44047"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.55972950),
        dec: Angle.Degrees(-46.57704949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1271"},
        {"Hipparcos Number", "HIP 1341"},
        {"Geneva Identification System", "GEN# +1.00001271"},
        {"Smithsonian Astrophysical Observation", "SAO 215032"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.19650012),
        dec: Angle.Degrees(-46.57394836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224241"},
        {"Hipparcos Number", "HIP 118017"},
        {"Geneva Identification System", "GEN# +1.00224241"},
        {"Smithsonian Astrophysical Observation", "SAO 231855"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08587489),
        dec: Angle.Degrees(-46.56983568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125985"},
        {"Hipparcos Number", "HIP 70398"},
        {"Smithsonian Astrophysical Observation", "SAO 224894"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.04569870),
        dec: Angle.Degrees(-46.56718139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89988"},
        {"Hipparcos Number", "HIP 50777"},
        {"Geneva Identification System", "GEN# +1.00089988"},
        {"Smithsonian Astrophysical Observation", "SAO 221990"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53267668),
        dec: Angle.Degrees(-46.56667863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103207"},
        {"Hipparcos Number", "HIP 57937"},
        {"Smithsonian Astrophysical Observation", "SAO 223083"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22781166),
        dec: Angle.Degrees(-46.56598976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171631"},
        {"Hipparcos Number", "HIP 91376"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.54619889),
        dec: Angle.Degrees(-46.56406346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35159"},
        {"Hipparcos Number", "HIP 24911"},
        {"Smithsonian Astrophysical Observation", "SAO 217290"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.08874903),
        dec: Angle.Degrees(-46.56371691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113536"},
        {"Hipparcos Number", "HIP 63841"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.25771508),
        dec: Angle.Degrees(-46.56343151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55001"},
        {"Hipparcos Number", "HIP 34502"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.22907782),
        dec: Angle.Degrees(-46.56204367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77718"},
        {"Hipparcos Number", "HIP 44385"},
        {"Geneva Identification System", "GEN# +1.00077718"},
        {"Smithsonian Astrophysical Observation", "SAO 220773"},
        {"Wilson Evans Batten Catalogue", "WEB 8510"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.62393049),
        dec: Angle.Degrees(-46.56170491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101494"},
        {"Hipparcos Number", "HIP 56953"},
        {"Smithsonian Astrophysical Observation", "SAO 222947"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.12595745),
        dec: Angle.Degrees(-46.56149920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155185"},
        {"Hipparcos Number", "HIP 84164"},
        {"Cincinnati Publication", "Ci 20 1021"},
        {"Geneva Identification System", "GEN# +1.00155185"},
        {"Wilson Evans Batten Catalogue", "WEB 14214"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09145019),
        dec: Angle.Degrees(-46.56112060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -685.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90849"},
        {"Hipparcos Number", "HIP 51276"},
        {"Smithsonian Astrophysical Observation", "SAO 222083"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.10428974),
        dec: Angle.Degrees(-46.56061456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18609"},
        {"Hipparcos Number", "HIP 13814"},
        {"Smithsonian Astrophysical Observation", "SAO 216108"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.45641162),
        dec: Angle.Degrees(-46.55904141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148952"},
        {"Hipparcos Number", "HIP 81096"},
        {"Smithsonian Astrophysical Observation", "SAO 226892"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.46245382),
        dec: Angle.Degrees(-46.55871485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17355"},
        {"Hipparcos Number", "HIP 12870"},
        {"Smithsonian Astrophysical Observation", "SAO 216039"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.36353155),
        dec: Angle.Degrees(-46.55829154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188492"},
        {"Hipparcos Number", "HIP 98215"},
        {"Smithsonian Astrophysical Observation", "SAO 229950"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.37740722),
        dec: Angle.Degrees(-46.55690583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167212"},
        {"Hipparcos Number", "HIP 89557"},
        {"Smithsonian Astrophysical Observation", "SAO 228863"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.11864828),
        dec: Angle.Degrees(-46.55472846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19068"},
        {"Hipparcos Number", "HIP 14139"},
        {"Smithsonian Astrophysical Observation", "SAO 216146"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.57604770),
        dec: Angle.Degrees(-46.55226226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4358"},
        {"Hipparcos Number", "HIP 3553"},
        {"Smithsonian Astrophysical Observation", "SAO 215226"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36099989),
        dec: Angle.Degrees(-46.54893717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176725"},
        {"Hipparcos Number", "HIP 93616"},
        {"Smithsonian Astrophysical Observation", "SAO 229467"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.96565929),
        dec: Angle.Degrees(-46.54862869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89739"},
        {"Geneva Identification System", "GEN# -0.04612279"},
    },
    visualMagnitude: 10.67,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.71343339),
        dec: Angle.Degrees(-46.54815963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85622"},
        {"Hipparcos Number", "HIP 48374"},
        {"Geneva Identification System", "GEN# +1.00085622"},
        {"Smithsonian Astrophysical Observation", "SAO 221553"},
        {"Wilson Evans Batten Catalogue", "WEB 9023"},
    },
    visualMagnitude: 4.58,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.91953494),
        dec: Angle.Degrees(-46.54764424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215405"},
        {"Hipparcos Number", "HIP 112381"},
        {"Geneva Identification System", "GEN# +1.00215405"},
        {"Smithsonian Astrophysical Observation", "SAO 231278"},
        {"Wilson Evans Batten Catalogue", "WEB 20048"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.42003143),
        dec: Angle.Degrees(-46.54729992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321"},
        {"Hipparcos Number", "HIP 633"},
        {"Smithsonian Astrophysical Observation", "SAO 214974"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.92754108),
        dec: Angle.Degrees(-46.54467295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327427"},
        {"Hipparcos Number", "HIP 77190"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.42787604),
        dec: Angle.Degrees(-46.54251443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162618"},
        {"Hipparcos Number", "HIP 87653"},
        {"Smithsonian Astrophysical Observation", "SAO 228528"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55786949),
        dec: Angle.Degrees(-46.54133569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75967"},
        {"Hipparcos Number", "HIP 43493"},
        {"Smithsonian Astrophysical Observation", "SAO 220584"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.87904210),
        dec: Angle.Degrees(-46.54115802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121004"},
        {"Hipparcos Number", "HIP 67863"},
        {"Cincinnati Publication", "Ci 20 819"},
        {"Geneva Identification System", "GEN# +1.00121004"},
        {"Smithsonian Astrophysical Observation", "SAO 224515"},
        {"Wilson Evans Batten Catalogue", "WEB 11931"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.49385654),
        dec: Angle.Degrees(-46.53877950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -482.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143235"},
        {"Hipparcos Number", "HIP 78475"},
        {"Smithsonian Astrophysical Observation", "SAO 226444"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.29257209),
        dec: Angle.Degrees(-46.53826726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117250"},
        {"Hipparcos Number", "HIP 65857"},
        {"Smithsonian Astrophysical Observation", "SAO 224191"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49343758),
        dec: Angle.Degrees(-46.53777643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31839"},
        {"Hipparcos Number", "HIP 22983"},
        {"Smithsonian Astrophysical Observation", "SAO 217071"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.18141068),
        dec: Angle.Degrees(-46.53480737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20923"},
        {"Geneva Identification System", "GEN# -0.04601426"},
        {"Smithsonian Astrophysical Observation", "SAO 216829"},
        {"Wilson Evans Batten Catalogue", "WEB 4021"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.28326793),
        dec: Angle.Degrees(-46.53361429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100513"},
        {"Hipparcos Number", "HIP 56397"},
        {"Geneva Identification System", "GEN# +1.00100513J"},
        {"Smithsonian Astrophysical Observation", "SAO 222865"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.43315323),
        dec: Angle.Degrees(-46.53289973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98163"},
        {"Hipparcos Number", "HIP 55108"},
        {"Geneva Identification System", "GEN# +1.00098163"},
        {"Smithsonian Astrophysical Observation", "SAO 222692"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.24484401),
        dec: Angle.Degrees(-46.53249157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1452"},
        {"Hipparcos Number", "HIP 1487"},
        {"Geneva Identification System", "GEN# +1.00001452"},
        {"Smithsonian Astrophysical Observation", "SAO 215044"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.62305316),
        dec: Angle.Degrees(-46.53212647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150897"},
        {"Hipparcos Number", "HIP 82091"},
        {"Fundamental Katalog 5th Edition", "FK5 3331"},
        {"Geneva Identification System", "GEN# +1.00150897"},
        {"Smithsonian Astrophysical Observation", "SAO 227172"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.52656503),
        dec: Angle.Degrees(-46.53191768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211001"},
        {"Hipparcos Number", "HIP 109873"},
        {"Smithsonian Astrophysical Observation", "SAO 231047"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.79754022),
        dec: Angle.Degrees(-46.53059396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143865"},
        {"Hipparcos Number", "HIP 78766"},
        {"Geneva Identification System", "GEN# +1.00143865"},
        {"Smithsonian Astrophysical Observation", "SAO 226483"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.21362688),
        dec: Angle.Degrees(-46.52985014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171579"},
        {"Hipparcos Number", "HIP 91354"},
        {"Smithsonian Astrophysical Observation", "SAO 229156"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48740956),
        dec: Angle.Degrees(-46.52968430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195286"},
        {"Hipparcos Number", "HIP 101319"},
        {"Smithsonian Astrophysical Observation", "SAO 230258"},
    },
    visualMagnitude: 7.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.03900528),
        dec: Angle.Degrees(-45.35542327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105784"},
        {"Hipparcos Number", "HIP 59358"},
        {"Geneva Identification System", "GEN# +1.00105784"},
        {"Smithsonian Astrophysical Observation", "SAO 223260"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.66636625),
        dec: Angle.Degrees(-46.52926162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75821"},
        {"Hipparcos Number", "HIP 43413"},
        {"Celescope Catalog", "CEL 2987"},
        {"Geneva Identification System", "GEN# +1.00075821"},
        {"Smithsonian Astrophysical Observation", "SAO 220561"},
        {"Wilson Evans Batten Catalogue", "WEB 8365"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.63943261),
        dec: Angle.Degrees(-46.52919614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104663"},
        {"Hipparcos Number", "HIP 58763"},
        {"Geneva Identification System", "GEN# +1.00104663"},
        {"Smithsonian Astrophysical Observation", "SAO 223190"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.77521901),
        dec: Angle.Degrees(-46.52707683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149075"},
        {"Hipparcos Number", "HIP 81164"},
        {"Smithsonian Astrophysical Observation", "SAO 226913"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.65833065),
        dec: Angle.Degrees(-46.52629575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144399"},
        {"Hipparcos Number", "HIP 79018"},
        {"Smithsonian Astrophysical Observation", "SAO 226521"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93361637),
        dec: Angle.Degrees(-46.52524190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34244"},
        {"Hipparcos Number", "HIP 24364"},
        {"Smithsonian Astrophysical Observation", "SAO 217246"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.40832639),
        dec: Angle.Degrees(-46.52426056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17006"},
        {"Hipparcos Number", "HIP 12611"},
        {"Fundamental Katalog 5th Edition", "FK5 2189"},
        {"Geneva Identification System", "GEN# +1.00017006"},
        {"Smithsonian Astrophysical Observation", "SAO 216013"},
        {"Wilson Evans Batten Catalogue", "WEB 2570"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.53514682),
        dec: Angle.Degrees(-46.52421200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144916"},
        {"Hipparcos Number", "HIP 79232"},
        {"Geneva Identification System", "GEN# +1.00144916"},
        {"Smithsonian Astrophysical Observation", "SAO 226552"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.55474397),
        dec: Angle.Degrees(-46.52397756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32635"},
        {"Hipparcos Number", "HIP 23444"},
        {"Smithsonian Astrophysical Observation", "SAO 217133"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.59135663),
        dec: Angle.Degrees(-46.52018121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79022"},
        {"Hipparcos Number", "HIP 44989"},
        {"Smithsonian Astrophysical Observation", "SAO 220909"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.45452948),
        dec: Angle.Degrees(-46.51945663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14813"},
        {"Geneva Identification System", "GEN# -0.04600943"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.81333881),
        dec: Angle.Degrees(-46.51858820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 401.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210639"},
        {"Hipparcos Number", "HIP 109649"},
        {"Smithsonian Astrophysical Observation", "SAO 231029"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.19109707),
        dec: Angle.Degrees(-46.51706918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91892"},
        {"Hipparcos Number", "HIP 51861"},
        {"Smithsonian Astrophysical Observation", "SAO 222180"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.93419036),
        dec: Angle.Degrees(-46.51596365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28700"},
        {"Hipparcos Number", "HIP 20934"},
        {"Geneva Identification System", "GEN# +1.00028700"},
        {"Smithsonian Astrophysical Observation", "SAO 216832"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.33351038),
        dec: Angle.Degrees(-46.51535931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47949"},
        {"Hipparcos Number", "HIP 31777"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.67043158),
        dec: Angle.Degrees(-46.51521070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191849"},
        {"Hipparcos Number", "HIP 99701"},
        {"Cincinnati Publication", "Ci 20 1196"},
        {"Geneva Identification System", "GEN# +1.00191849"},
        {"Smithsonian Astrophysical Observation", "SAO 230110"},
        {"Wilson Evans Batten Catalogue", "WEB 17880"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.46980202),
        dec: Angle.Degrees(-45.16363153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 778.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223812"},
        {"Hipparcos Number", "HIP 117766"},
        {"Smithsonian Astrophysical Observation", "SAO 231822"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.24554319),
        dec: Angle.Degrees(-46.51307477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85604"},
        {"Hipparcos Number", "HIP 48371"},
        {"Smithsonian Astrophysical Observation", "SAO 221551"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.91179203),
        dec: Angle.Degrees(-46.51230357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176193"},
        {"Hipparcos Number", "HIP 93391"},
        {"Geneva Identification System", "GEN# +1.00176193"},
        {"Smithsonian Astrophysical Observation", "SAO 229439"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.31430299),
        dec: Angle.Degrees(-46.51041490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47119"},
        {"Hipparcos Number", "HIP 31369"},
        {"Geneva Identification System", "GEN# +1.00047119"},
        {"Smithsonian Astrophysical Observation", "SAO 218033"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.66470955),
        dec: Angle.Degrees(-46.51006153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7743"},
        {"Geneva Identification System", "GEN# -0.04700502"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.92397410),
        dec: Angle.Degrees(-46.50973508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84611"},
        {"Hipparcos Number", "HIP 47842"},
        {"Smithsonian Astrophysical Observation", "SAO 221457"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.27102787),
        dec: Angle.Degrees(-46.50929615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109368"},
        {"Hipparcos Number", "HIP 61363"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.60859521),
        dec: Angle.Degrees(-46.50621124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159217"},
        {"Hipparcos Number", "HIP 86092"},
        {"Celescope Catalog", "CEL 4539"},
        {"Geneva Identification System", "GEN# +1.00159217"},
        {"Smithsonian Astrophysical Observation", "SAO 228162"},
        {"Wilson Evans Batten Catalogue", "WEB 14522"},
    },
    visualMagnitude: 4.56,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.91504719),
        dec: Angle.Degrees(-46.50559076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87133"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.04602060),
        dec: Angle.Degrees(-46.50389442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74733"},
        {"Hipparcos Number", "HIP 42847"},
        {"Smithsonian Astrophysical Observation", "SAO 220363"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.96942153),
        dec: Angle.Degrees(-46.49948627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220001"},
        {"Hipparcos Number", "HIP 115266"},
        {"Smithsonian Astrophysical Observation", "SAO 231558"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.19976196),
        dec: Angle.Degrees(-46.49924977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1531"},
        {"Hipparcos Number", "HIP 1551"},
        {"Smithsonian Astrophysical Observation", "SAO 215052"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.83539793),
        dec: Angle.Degrees(-46.49905201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45440"},
        {"Hipparcos Number", "HIP 30527"},
        {"Smithsonian Astrophysical Observation", "SAO 217915"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.25118797),
        dec: Angle.Degrees(-46.49756095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212437"},
        {"Hipparcos Number", "HIP 110669"},
        {"Smithsonian Astrophysical Observation", "SAO 231131"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.30003870),
        dec: Angle.Degrees(-46.49603953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93839"},
        {"Hipparcos Number", "HIP 52909"},
        {"Smithsonian Astrophysical Observation", "SAO 222357"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.30846435),
        dec: Angle.Degrees(-46.49493644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3322"},
        {"Geneva Identification System", "GEN# +6.20145172"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.61459269),
        dec: Angle.Degrees(-44.41257870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200918"},
        {"Hipparcos Number", "HIP 104326"},
        {"Smithsonian Astrophysical Observation", "SAO 230538"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00445238),
        dec: Angle.Degrees(-46.49303480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217259"},
        {"Hipparcos Number", "HIP 113559"},
        {"Smithsonian Astrophysical Observation", "SAO 231382"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.01131140),
        dec: Angle.Degrees(-46.49210310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103423"},
        {"Hipparcos Number", "HIP 58050"},
        {"Geneva Identification System", "GEN# +1.00103423"},
        {"Smithsonian Astrophysical Observation", "SAO 223098"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.59817817),
        dec: Angle.Degrees(-46.49160297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11232"},
        {"Hipparcos Number", "HIP 8479"},
        {"Smithsonian Astrophysical Observation", "SAO 215667"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.32677650),
        dec: Angle.Degrees(-46.49150476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20130"},
        {"Hipparcos Number", "HIP 14917"},
        {"Geneva Identification System", "GEN# +1.00020130"},
        {"Smithsonian Astrophysical Observation", "SAO 216210"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.11357896),
        dec: Angle.Degrees(-46.49023448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177038"},
        {"Hipparcos Number", "HIP 93734"},
        {"Smithsonian Astrophysical Observation", "SAO 229477"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.29428165),
        dec: Angle.Degrees(-46.48957419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15313"},
        {"Hipparcos Number", "HIP 11375"},
        {"Smithsonian Astrophysical Observation", "SAO 215900"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62593281),
        dec: Angle.Degrees(-46.48674213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69404"},
        {"Hipparcos Number", "HIP 40397"},
        {"Celescope Catalog", "CEL 2281"},
        {"Geneva Identification System", "GEN# +1.00069404"},
        {"Smithsonian Astrophysical Observation", "SAO 219674"},
        {"Wilson Evans Batten Catalogue", "WEB 7874"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.71352105),
        dec: Angle.Degrees(-46.48591091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21458"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.11119609),
        dec: Angle.Degrees(-46.48547537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108182"},
        {"Hipparcos Number", "HIP 60647"},
        {"Smithsonian Astrophysical Observation", "SAO 223434"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.46314991),
        dec: Angle.Degrees(-46.48514706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91693"},
        {"Hipparcos Number", "HIP 51747"},
        {"Smithsonian Astrophysical Observation", "SAO 222156"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58218384),
        dec: Angle.Degrees(-46.48499036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222165"},
        {"Hipparcos Number", "HIP 116658"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.61040462),
        dec: Angle.Degrees(-46.48416831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97564"},
        {"Hipparcos Number", "HIP 54808"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.30447057),
        dec: Angle.Degrees(-46.48177052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199273"},
        {"Hipparcos Number", "HIP 103478"},
        {"Smithsonian Astrophysical Observation", "SAO 230460"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.47448481),
        dec: Angle.Degrees(-46.48049550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57399"},
        {"Hipparcos Number", "HIP 35430"},
        {"Smithsonian Astrophysical Observation", "SAO 218630"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71608315),
        dec: Angle.Degrees(-46.48017877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208323"},
        {"Hipparcos Number", "HIP 108329"},
        {"Geneva Identification System", "GEN# +1.00208323"},
        {"Smithsonian Astrophysical Observation", "SAO 230906"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.19831489),
        dec: Angle.Degrees(-46.47986535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115333"},
        {"Hipparcos Number", "HIP 64818"},
        {"Smithsonian Astrophysical Observation", "SAO 224031"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.29810258),
        dec: Angle.Degrees(-46.47674790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182777"},
        {"Hipparcos Number", "HIP 95745"},
        {"Geneva Identification System", "GEN# +1.00182777"},
        {"Smithsonian Astrophysical Observation", "SAO 229698"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.11018575),
        dec: Angle.Degrees(-46.47535006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140580"},
        {"Hipparcos Number", "HIP 77254"},
        {"Smithsonian Astrophysical Observation", "SAO 226170"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60826552),
        dec: Angle.Degrees(-46.47452055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167935"},
        {"Hipparcos Number", "HIP 89813"},
        {"Geneva Identification System", "GEN# +1.00167935J"},
        {"Smithsonian Astrophysical Observation", "SAO 228905"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.92686241),
        dec: Angle.Degrees(-46.47356250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48651"},
        {"Hipparcos Number", "HIP 32082"},
        {"Geneva Identification System", "GEN# +1.00048651"},
        {"Smithsonian Astrophysical Observation", "SAO 218135"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.53504769),
        dec: Angle.Degrees(-46.47344597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125637"},
        {"Hipparcos Number", "HIP 70219"},
        {"Geneva Identification System", "GEN# +1.00125637"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.49267904),
        dec: Angle.Degrees(-46.47162255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88339"},
        {"Hipparcos Number", "HIP 49808"},
        {"Smithsonian Astrophysical Observation", "SAO 221820"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.51399726),
        dec: Angle.Degrees(-46.47004633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102865"},
        {"Hipparcos Number", "HIP 57738"},
        {"Geneva Identification System", "GEN# +1.00102865"},
        {"Smithsonian Astrophysical Observation", "SAO 223052"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.60752579),
        dec: Angle.Degrees(-46.46892270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223222"},
        {"Hipparcos Number", "HIP 117362"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.95416873),
        dec: Angle.Degrees(-46.46811674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14847"},
        {"Hipparcos Number", "HIP 11054"},
        {"Geneva Identification System", "GEN# +1.00014847"},
        {"Smithsonian Astrophysical Observation", "SAO 215881"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.57087733),
        dec: Angle.Degrees(-46.46785800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21372"},
        {"Hipparcos Number", "HIP 15917"},
        {"Smithsonian Astrophysical Observation", "SAO 216306"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.24365365),
        dec: Angle.Degrees(-46.46766239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127629"},
        {"Hipparcos Number", "HIP 71219"},
        {"Geneva Identification System", "GEN# +1.00127629"},
        {"Smithsonian Astrophysical Observation", "SAO 225022"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46555186),
        dec: Angle.Degrees(-46.46484578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51579"},
        {"Hipparcos Number", "HIP 33292"},
        {"Smithsonian Astrophysical Observation", "SAO 218316"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88449584),
        dec: Angle.Degrees(-46.46461240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70849"},
        {"Geneva Identification System", "GEN# -0.04509206"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.32751069),
        dec: Angle.Degrees(-46.46332289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127864"},
        {"Hipparcos Number", "HIP 71327"},
        {"Geneva Identification System", "GEN# +1.00127864"},
        {"Smithsonian Astrophysical Observation", "SAO 225039"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.79465629),
        dec: Angle.Degrees(-46.46194747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133516"},
        {"Hipparcos Number", "HIP 73940"},
        {"Geneva Identification System", "GEN# +1.00133516"},
        {"Smithsonian Astrophysical Observation", "SAO 225443"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.64336946),
        dec: Angle.Degrees(-46.46048983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58506"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.97891554),
        dec: Angle.Degrees(-46.45599911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46289"},
        {"Hipparcos Number", "HIP 30989"},
        {"Smithsonian Astrophysical Observation", "SAO 217977"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.55096481),
        dec: Angle.Degrees(-46.45589700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206713"},
        {"Hipparcos Number", "HIP 107406"},
        {"Smithsonian Astrophysical Observation", "SAO 230824"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.32410540),
        dec: Angle.Degrees(-46.45555380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194984"},
        {"Hipparcos Number", "HIP 101168"},
        {"Smithsonian Astrophysical Observation", "SAO 230246"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.59335311),
        dec: Angle.Degrees(-46.45541822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100671"},
        {"Hipparcos Number", "HIP 56492"},
        {"Geneva Identification System", "GEN# +1.00100671"},
        {"Smithsonian Astrophysical Observation", "SAO 222880"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.71894104),
        dec: Angle.Degrees(-46.45422079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153749"},
        {"Hipparcos Number", "HIP 83460"},
        {"Smithsonian Astrophysical Observation", "SAO 227584"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.86992834),
        dec: Angle.Degrees(-46.45415565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26958"},
        {"Geneva Identification System", "GEN# -0.04601969"},
        {"Smithsonian Astrophysical Observation", "SAO 217489"},
    },
    visualMagnitude: 7.98,
    bvColour: 4.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.80763721),
        dec: Angle.Degrees(-46.45387817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17155"},
        {"Hipparcos Number", "HIP 12723"},
        {"Cincinnati Publication", "Ci 20 182"},
        {"Geneva Identification System", "GEN# +1.00017155"},
        {"Smithsonian Astrophysical Observation", "SAO 216022"},
        {"Wilson Evans Batten Catalogue", "WEB 2589"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.89230348),
        dec: Angle.Degrees(-46.45356745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -527.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274503"},
        {"Hipparcos Number", "HIP 25206"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.88034972),
        dec: Angle.Degrees(-46.45276683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67633"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.86485561),
        dec: Angle.Degrees(-46.45223271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95907"},
        {"Hipparcos Number", "HIP 54036"},
        {"Geneva Identification System", "GEN# +1.00095907"},
        {"Smithsonian Astrophysical Observation", "SAO 222527"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.84248285),
        dec: Angle.Degrees(-46.45125609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146422"},
        {"Hipparcos Number", "HIP 79880"},
        {"Smithsonian Astrophysical Observation", "SAO 226636"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.57278143),
        dec: Angle.Degrees(-46.44978106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193505"},
        {"Hipparcos Number", "HIP 100467"},
        {"Smithsonian Astrophysical Observation", "SAO 230175"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.60946536),
        dec: Angle.Degrees(-46.44946322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48731"},
        {"Hipparcos Number", "HIP 32107"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.60719460),
        dec: Angle.Degrees(-46.44620265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67635"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.87597068),
        dec: Angle.Degrees(-46.44500458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7454"},
        {"Hipparcos Number", "HIP 5761"},
        {"Smithsonian Astrophysical Observation", "SAO 215419"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.48419471),
        dec: Angle.Degrees(-46.44150488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13472"},
        {"Hipparcos Number", "HIP 10133"},
        {"Geneva Identification System", "GEN# +1.00013472"},
        {"Smithsonian Astrophysical Observation", "SAO 215797"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.57674987),
        dec: Angle.Degrees(-46.44113032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167986"},
        {"Hipparcos Number", "HIP 89830"},
        {"Smithsonian Astrophysical Observation", "SAO 228908"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.96944723),
        dec: Angle.Degrees(-46.44086534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214581"},
        {"Hipparcos Number", "HIP 111901"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.00872761),
        dec: Angle.Degrees(-46.44002347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70368"},
        {"Hipparcos Number", "HIP 40799"},
        {"Celescope Catalog", "CEL 2377"},
        {"Geneva Identification System", "GEN# +1.00070368"},
        {"Smithsonian Astrophysical Observation", "SAO 219794"},
        {"Wilson Evans Batten Catalogue", "WEB 7917"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.90379720),
        dec: Angle.Degrees(-46.43987608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95010"},
        {"Hipparcos Number", "HIP 53570"},
        {"Smithsonian Astrophysical Observation", "SAO 222451"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.38192012),
        dec: Angle.Degrees(-46.43620753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127678"},
        {"Hipparcos Number", "HIP 71233"},
        {"Smithsonian Astrophysical Observation", "SAO 225023"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.50660379),
        dec: Angle.Degrees(-46.43401552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217308"},
        {"Hipparcos Number", "HIP 113595"},
        {"Smithsonian Astrophysical Observation", "SAO 231386"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.10516236),
        dec: Angle.Degrees(-46.43383600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53277"},
        {"Hipparcos Number", "HIP 33896"},
        {"Smithsonian Astrophysical Observation", "SAO 218395"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.53442086),
        dec: Angle.Degrees(-46.43331195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215865"},
        {"Hipparcos Number", "HIP 112661"},
        {"Smithsonian Astrophysical Observation", "SAO 231310"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23920590),
        dec: Angle.Degrees(-46.43014742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7247"},
        {"Hipparcos Number", "HIP 5611"},
        {"Smithsonian Astrophysical Observation", "SAO 215407"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.99326209),
        dec: Angle.Degrees(-46.42798168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192961"},
        {"Hipparcos Number", "HIP 100223"},
        {"Geneva Identification System", "GEN# +1.00192961"},
        {"Smithsonian Astrophysical Observation", "SAO 230154"},
        {"Wilson Evans Batten Catalogue", "WEB 18057"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90522491),
        dec: Angle.Degrees(-46.42786662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -379.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118354"},
        {"Hipparcos Number", "HIP 66454"},
        {"Geneva Identification System", "GEN# +1.00118354"},
        {"Smithsonian Astrophysical Observation", "SAO 224283"},
        {"Wilson Evans Batten Catalogue", "WEB 11730"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.34790583),
        dec: Angle.Degrees(-46.42784035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112550"},
        {"Hipparcos Number", "HIP 63282"},
        {"Smithsonian Astrophysical Observation", "SAO 223791"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.51660005),
        dec: Angle.Degrees(-46.42781346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51138"},
        {"Hipparcos Number", "HIP 33114"},
        {"Smithsonian Astrophysical Observation", "SAO 218291"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.45448752),
        dec: Angle.Degrees(-46.42695382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193198"},
        {"Hipparcos Number", "HIP 100330"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.20630101),
        dec: Angle.Degrees(-46.42429529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206769"},
        {"Hipparcos Number", "HIP 107441"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.42246752),
        dec: Angle.Degrees(-46.42275489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68244"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.56243630),
        dec: Angle.Degrees(-46.41791838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53737"},
        {"Hipparcos Number", "HIP 120046"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.96931575),
        dec: Angle.Degrees(-46.41735502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327547"},
        {"Hipparcos Number", "HIP 77625"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.72119268),
        dec: Angle.Degrees(-46.41689583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24805"},
        {"Hipparcos Number", "HIP 18286"},
        {"Geneva Identification System", "GEN# +1.00024805"},
        {"Smithsonian Astrophysical Observation", "SAO 216548"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.65625533),
        dec: Angle.Degrees(-46.41687309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297369"},
        {"Hipparcos Number", "HIP 52372"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.56495167),
        dec: Angle.Degrees(-46.41552073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192254"},
        {"Hipparcos Number", "HIP 99877"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.95731081),
        dec: Angle.Degrees(-46.41502724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98162"},
        {"Hipparcos Number", "HIP 55107"},
        {"Geneva Identification System", "GEN# +1.00098162"},
        {"Smithsonian Astrophysical Observation", "SAO 222690"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.24380701),
        dec: Angle.Degrees(-46.41434805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216581"},
        {"Hipparcos Number", "HIP 113142"},
        {"Smithsonian Astrophysical Observation", "SAO 231348"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.67624909),
        dec: Angle.Degrees(-46.41346585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164892"},
        {"Hipparcos Number", "HIP 88619"},
        {"Smithsonian Astrophysical Observation", "SAO 228686"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.40115864),
        dec: Angle.Degrees(-46.40710074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151317"},
        {"Hipparcos Number", "HIP 82284"},
        {"Geneva Identification System", "GEN# +1.00151317"},
        {"Smithsonian Astrophysical Observation", "SAO 227249"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.20593703),
        dec: Angle.Degrees(-46.40087203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63743"},
        {"Hipparcos Number", "HIP 38091"},
        {"Smithsonian Astrophysical Observation", "SAO 219015"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.08677128),
        dec: Angle.Degrees(-46.40059677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196898"},
        {"Hipparcos Number", "HIP 102164"},
        {"Smithsonian Astrophysical Observation", "SAO 230328"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.51691823),
        dec: Angle.Degrees(-46.40015814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181926"},
        {"Hipparcos Number", "HIP 95410"},
        {"Smithsonian Astrophysical Observation", "SAO 229661"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.13037393),
        dec: Angle.Degrees(-46.39801229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6245"},
        {"Hipparcos Number", "HIP 4890"},
        {"Fundamental Katalog 5th Edition", "FK5 2065"},
        {"Geneva Identification System", "GEN# +1.00006245"},
        {"Smithsonian Astrophysical Observation", "SAO 215343"},
        {"Wilson Evans Batten Catalogue", "WEB 955"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.70496560),
        dec: Angle.Degrees(-46.39733801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30386"},
        {"Hipparcos Number", "HIP 22073"},
        {"Smithsonian Astrophysical Observation", "SAO 216978"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.22090549),
        dec: Angle.Degrees(-46.39660900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148973"},
        {"Hipparcos Number", "HIP 81109"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.48609128),
        dec: Angle.Degrees(-46.39579807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118543"},
        {"Hipparcos Number", "HIP 66556"},
        {"Smithsonian Astrophysical Observation", "SAO 224301"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.65151386),
        dec: Angle.Degrees(-46.39356388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52813"},
        {"Renson", "Renson 27080"},
        {"Smithsonian Astrophysical Observation", "SAO 222337"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.95175510),
        dec: Angle.Degrees(-46.39341578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9361"},
        {"Hipparcos Number", "HIP 7072"},
        {"Geneva Identification System", "GEN# +1.00009361"},
        {"Smithsonian Astrophysical Observation", "SAO 215535"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.78766646),
        dec: Angle.Degrees(-46.39208851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109063"},
        {"Hipparcos Number", "HIP 61178"},
        {"Geneva Identification System", "GEN# +1.00109063"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.03653928),
        dec: Angle.Degrees(-46.39204241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221896"},
        {"Hipparcos Number", "HIP 116484"},
        {"Smithsonian Astrophysical Observation", "SAO 231685"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.04680279),
        dec: Angle.Degrees(-46.39135708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86317"},
        {"Hipparcos Number", "HIP 48727"},
        {"Geneva Identification System", "GEN# +1.00086317J"},
        {"Smithsonian Astrophysical Observation", "SAO 221624"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.08679800),
        dec: Angle.Degrees(-46.39072593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206948"},
        {"Hipparcos Number", "HIP 107542"},
        {"Geneva Identification System", "GEN# +1.00206948"},
        {"Smithsonian Astrophysical Observation", "SAO 230836"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.71763280),
        dec: Angle.Degrees(-46.38957027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106778"},
        {"Hipparcos Number", "HIP 59886"},
        {"Smithsonian Astrophysical Observation", "SAO 223329"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.22910483),
        dec: Angle.Degrees(-46.38692395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117769"},
        {"Hipparcos Number", "HIP 66120"},
        {"Smithsonian Astrophysical Observation", "SAO 224239"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.31571912),
        dec: Angle.Degrees(-46.38664938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209085"},
        {"Hipparcos Number", "HIP 108760"},
        {"Smithsonian Astrophysical Observation", "SAO 230947"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.47246420),
        dec: Angle.Degrees(-46.38635154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121483"},
        {"Hipparcos Number", "HIP 68124"},
        {"Celescope Catalog", "CEL 4289"},
        {"Geneva Identification System", "GEN# +1.00121483"},
        {"Smithsonian Astrophysical Observation", "SAO 224560"},
        {"Wilson Evans Batten Catalogue", "WEB 11956"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19997121),
        dec: Angle.Degrees(-46.38600338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150167"},
        {"Hipparcos Number", "HIP 81711"},
        {"Smithsonian Astrophysical Observation", "SAO 227056"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34973003),
        dec: Angle.Degrees(-46.38568051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92776"},
        {"Hipparcos Number", "HIP 52342"},
        {"Smithsonian Astrophysical Observation", "SAO 222262"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.46732671),
        dec: Angle.Degrees(-46.38484902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25169"},
        {"Hipparcos Number", "HIP 18534"},
        {"Geneva Identification System", "GEN# +1.00025169"},
        {"Smithsonian Astrophysical Observation", "SAO 216579"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.46516889),
        dec: Angle.Degrees(-46.38277649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84070"},
        {"Hipparcos Number", "HIP 47517"},
        {"Geneva Identification System", "GEN# +1.00084070"},
        {"Smithsonian Astrophysical Observation", "SAO 221402"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.30544979),
        dec: Angle.Degrees(-46.38198604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327656"},
        {"Hipparcos Number", "HIP 78126"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.29240384),
        dec: Angle.Degrees(-46.37913272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144227"},
        {"Hipparcos Number", "HIP 78930"},
        {"Geneva Identification System", "GEN# +1.00144227"},
        {"Smithsonian Astrophysical Observation", "SAO 226504"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.68855666),
        dec: Angle.Degrees(-46.37907061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186134"},
        {"Hipparcos Number", "HIP 97147"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.17985871),
        dec: Angle.Degrees(-46.37885304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124232"},
        {"Hipparcos Number", "HIP 69484"},
        {"Geneva Identification System", "GEN# +1.00124232"},
        {"Smithsonian Astrophysical Observation", "SAO 224770"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.37314413),
        dec: Angle.Degrees(-46.37739150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 523"},
        {"Hipparcos Number", "HIP 776"},
        {"Geneva Identification System", "GEN# +1.00000523"},
        {"Smithsonian Astrophysical Observation", "SAO 214985"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.39552418),
        dec: Angle.Degrees(-46.37507382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12789"},
        {"Hipparcos Number", "HIP 9652"},
        {"Smithsonian Astrophysical Observation", "SAO 215756"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.02651252),
        dec: Angle.Degrees(-46.37491932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63922"},
        {"Hipparcos Number", "HIP 38164"},
        {"Celescope Catalog", "CEL 2052"},
        {"Geneva Identification System", "GEN# +1.00063922A"},
        {"Smithsonian Astrophysical Observation", "SAO 219035"},
        {"Wilson Evans Batten Catalogue", "WEB 7522"},
    },
    visualMagnitude: 4.10,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30957923),
        dec: Angle.Degrees(-46.37322729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13262"},
        {"Hipparcos Number", "HIP 9970"},
        {"Smithsonian Astrophysical Observation", "SAO 215780"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.09561661),
        dec: Angle.Degrees(-46.37301333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13337"},
        {"Hipparcos Number", "HIP 10018"},
        {"Geneva Identification System", "GEN# +1.00013337"},
        {"Smithsonian Astrophysical Observation", "SAO 215784"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.25051939),
        dec: Angle.Degrees(-46.36993825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79882"},
        {"Hipparcos Number", "HIP 45396"},
        {"Smithsonian Astrophysical Observation", "SAO 220993"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.77192823),
        dec: Angle.Degrees(-46.36779069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31587"},
        {"Hipparcos Number", "HIP 22832"},
        {"Geneva Identification System", "GEN# +1.00031587"},
        {"Smithsonian Astrophysical Observation", "SAO 217063"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.69194197),
        dec: Angle.Degrees(-46.36716075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119780"},
        {"Hipparcos Number", "HIP 67200"},
        {"Smithsonian Astrophysical Observation", "SAO 224409"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.56801249),
        dec: Angle.Degrees(-46.36645585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161973"},
        {"Hipparcos Number", "HIP 87342"},
        {"Smithsonian Astrophysical Observation", "SAO 228478"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.70558256),
        dec: Angle.Degrees(-46.36365266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215469"},
        {"Hipparcos Number", "HIP 112406"},
        {"Smithsonian Astrophysical Observation", "SAO 231283"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.51527790),
        dec: Angle.Degrees(-46.36141051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76567"},
        {"Hipparcos Number", "HIP 43794"},
        {"Celescope Catalog", "CEL 3080"},
        {"Geneva Identification System", "GEN# +1.00076567"},
        {"Smithsonian Astrophysical Observation", "SAO 220661"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.78701050),
        dec: Angle.Degrees(-46.36079522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187212"},
        {"Hipparcos Number", "HIP 97660"},
        {"Geneva Identification System", "GEN# +1.00187212"},
        {"Smithsonian Astrophysical Observation", "SAO 229891"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.72111674),
        dec: Angle.Degrees(-46.36051680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3301"},
        {"Hipparcos Number", "HIP 2803"},
        {"Smithsonian Astrophysical Observation", "SAO 215156"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.92317289),
        dec: Angle.Degrees(-46.35797377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137281"},
        {"Hipparcos Number", "HIP 75612"},
        {"Smithsonian Astrophysical Observation", "SAO 225788"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.72975268),
        dec: Angle.Degrees(-46.35776475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43661"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.41807104),
        dec: Angle.Degrees(-46.35569768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197114"},
        {"Hipparcos Number", "HIP 102268"},
        {"Smithsonian Astrophysical Observation", "SAO 230339"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.83128377),
        dec: Angle.Degrees(-46.35555744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19989"},
        {"Hipparcos Number", "HIP 14795"},
        {"Smithsonian Astrophysical Observation", "SAO 216205"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.76803971),
        dec: Angle.Degrees(-46.35054563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101708"},
        {"Hipparcos Number", "HIP 57073"},
        {"Smithsonian Astrophysical Observation", "SAO 222966"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.49573004),
        dec: Angle.Degrees(-46.35044003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146799"},
        {"Hipparcos Number", "HIP 80032"},
        {"Smithsonian Astrophysical Observation", "SAO 226666"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.05478917),
        dec: Angle.Degrees(-46.34908048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42644"},
        {"Hipparcos Number", "HIP 29195"},
        {"Smithsonian Astrophysical Observation", "SAO 217744"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.37383548),
        dec: Angle.Degrees(-46.34771645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17702"},
        {"Hipparcos Number", "HIP 13129"},
        {"Fundamental Katalog 5th Edition", "FK5 4259"},
        {"Geneva Identification System", "GEN# +1.00017702"},
        {"Smithsonian Astrophysical Observation", "SAO 216058"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.21811756),
        dec: Angle.Degrees(-46.34697872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39605"},
        {"Hipparcos Number", "HIP 27650"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.80926153),
        dec: Angle.Degrees(-46.34535347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175005"},
        {"Hipparcos Number", "HIP 92886"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89053316),
        dec: Angle.Degrees(-46.34350648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208710"},
        {"Hipparcos Number", "HIP 108547"},
        {"Geneva Identification System", "GEN# +1.00208710"},
        {"Smithsonian Astrophysical Observation", "SAO 230924"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.83735266),
        dec: Angle.Degrees(-46.34331941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6033"},
        {"Hipparcos Number", "HIP 4745"},
        {"Smithsonian Astrophysical Observation", "SAO 215327"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.25464837),
        dec: Angle.Degrees(-46.34317819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74884"},
        {"Hipparcos Number", "HIP 42926"},
        {"Geneva Identification System", "GEN# +1.00074884"},
        {"Smithsonian Astrophysical Observation", "SAO 220388"},
        {"Wilson Evans Batten Catalogue", "WEB 8298"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.22280200),
        dec: Angle.Degrees(-46.34299413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83385"},
        {"Hipparcos Number", "HIP 47163"},
        {"Geneva Identification System", "GEN# +1.00083385"},
        {"Smithsonian Astrophysical Observation", "SAO 221341"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.16071359),
        dec: Angle.Degrees(-46.33881271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114674"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.45727138),
        dec: Angle.Degrees(-46.33815436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155778"},
        {"Hipparcos Number", "HIP 84449"},
        {"Geneva Identification System", "GEN# +1.00155778"},
        {"Renson", "Renson 43990"},
        {"Smithsonian Astrophysical Observation", "SAO 227756"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.97656071),
        dec: Angle.Degrees(-46.33709529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66653"},
        {"Hipparcos Number", "HIP 39330"},
        {"Geneva Identification System", "GEN# +1.00066653"},
        {"Smithsonian Astrophysical Observation", "SAO 219334"},
        {"Wilson Evans Batten Catalogue", "WEB 7702"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61288050),
        dec: Angle.Degrees(-46.33686464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 231.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1346"},
        {"Hipparcos Number", "HIP 1395"},
        {"Smithsonian Astrophysical Observation", "SAO 215038"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.36550501),
        dec: Angle.Degrees(-46.33560634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44370"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.54760521),
        dec: Angle.Degrees(-46.33283800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184557"},
        {"Hipparcos Number", "HIP 96502"},
        {"Smithsonian Astrophysical Observation", "SAO 229769"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.28902713),
        dec: Angle.Degrees(-46.33273576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152079"},
        {"Hipparcos Number", "HIP 82632"},
        {"Geneva Identification System", "GEN# +1.00152079"},
        {"Smithsonian Astrophysical Observation", "SAO 227350"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37427908),
        dec: Angle.Degrees(-46.33272767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103977"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.01113338),
        dec: Angle.Degrees(-46.33260085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72232"},
        {"Hipparcos Number", "HIP 41674"},
        {"Celescope Catalog", "CEL 2573"},
        {"Geneva Identification System", "GEN# +1.00072232"},
        {"Smithsonian Astrophysical Observation", "SAO 220007"},
        {"Wilson Evans Batten Catalogue", "WEB 8041"},
    },
    visualMagnitude: 5.98,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.44022551),
        dec: Angle.Degrees(-46.33172799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173792"},
        {"Hipparcos Number", "HIP 92361"},
        {"Smithsonian Astrophysical Observation", "SAO 229305"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.35186971),
        dec: Angle.Degrees(-46.33082786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165392"},
        {"Hipparcos Number", "HIP 88831"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.99501722),
        dec: Angle.Degrees(-46.32951970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92154"},
        {"Hipparcos Number", "HIP 52007"},
        {"Smithsonian Astrophysical Observation", "SAO 222202"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36787937),
        dec: Angle.Degrees(-46.32908785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101707"},
        {"Hipparcos Number", "HIP 57081"},
        {"Renson", "Renson 29300"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.51652143),
        dec: Angle.Degrees(-46.32890765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216679"},
        {"Hipparcos Number", "HIP 113203"},
        {"Geneva Identification System", "GEN# +1.00216679"},
        {"Smithsonian Astrophysical Observation", "SAO 231356"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.87600217),
        dec: Angle.Degrees(-46.32822505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327420"},
        {"Hipparcos Number", "HIP 77500"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.37914006),
        dec: Angle.Degrees(-46.32719662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64248"},
        {"Hipparcos Number", "HIP 38294"},
        {"Smithsonian Astrophysical Observation", "SAO 219063"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69080178),
        dec: Angle.Degrees(-46.32675582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43034"},
        {"Hipparcos Number", "HIP 29397"},
        {"Smithsonian Astrophysical Observation", "SAO 217772"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92310827),
        dec: Angle.Degrees(-46.32671889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65622"},
        {"Hipparcos Number", "HIP 38887"},
        {"Celescope Catalog", "CEL 2114"},
        {"Geneva Identification System", "GEN# +1.00065622"},
        {"Smithsonian Astrophysical Observation", "SAO 219203"},
        {"Wilson Evans Batten Catalogue", "WEB 7619"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.36677814),
        dec: Angle.Degrees(-46.32662647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56264"},
        {"Hipparcos Number", "HIP 34974"},
        {"Smithsonian Astrophysical Observation", "SAO 218560"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54328526),
        dec: Angle.Degrees(-46.32593381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49777"},
        {"Hipparcos Number", "HIP 32574"},
        {"Smithsonian Astrophysical Observation", "SAO 218205"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.95385468),
        dec: Angle.Degrees(-46.32560984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205862"},
        {"Hipparcos Number", "HIP 106943"},
        {"Geneva Identification System", "GEN# +1.00205862"},
        {"Smithsonian Astrophysical Observation", "SAO 230772"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.88794195),
        dec: Angle.Degrees(-46.32277796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105837"},
        {"Hipparcos Number", "HIP 59380"},
        {"Geneva Identification System", "GEN# +1.00105837"},
        {"Smithsonian Astrophysical Observation", "SAO 223263"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.74107163),
        dec: Angle.Degrees(-46.32239142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219872"},
        {"Hipparcos Number", "HIP 115177"},
        {"Smithsonian Astrophysical Observation", "SAO 231549"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92704405),
        dec: Angle.Degrees(-46.32219647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44365"},
        {"Celescope Catalog", "CEL 3153"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.52402318),
        dec: Angle.Degrees(-46.32168669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223681"},
        {"Hipparcos Number", "HIP 117669"},
        {"Geneva Identification System", "GEN# +1.00223681"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.95566545),
        dec: Angle.Degrees(-46.31932505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100504"},
        {"Hipparcos Number", "HIP 56389"},
        {"Geneva Identification System", "GEN# +1.00100504"},
        {"Smithsonian Astrophysical Observation", "SAO 222864"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.40338111),
        dec: Angle.Degrees(-46.31772765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148156"},
        {"Hipparcos Number", "HIP 80680"},
        {"Geneva Identification System", "GEN# +1.00148156"},
        {"Smithsonian Astrophysical Observation", "SAO 226791"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.07185885),
        dec: Angle.Degrees(-46.31769590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159792"},
        {"Hipparcos Number", "HIP 86363"},
        {"Geneva Identification System", "GEN# +1.00159792"},
        {"Smithsonian Astrophysical Observation", "SAO 228230"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.70798886),
        dec: Angle.Degrees(-46.31587933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39244"},
        {"Hipparcos Number", "HIP 27462"},
        {"Fundamental Katalog 5th Edition", "FK5 4532"},
        {"Geneva Identification System", "GEN# +1.00039244"},
        {"Smithsonian Astrophysical Observation", "SAO 217556"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.23156191),
        dec: Angle.Degrees(-46.31566331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141388"},
        {"Hipparcos Number", "HIP 77614"},
        {"Geneva Identification System", "GEN# +1.00141388"},
        {"Smithsonian Astrophysical Observation", "SAO 226275"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.67279353),
        dec: Angle.Degrees(-46.31355502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166636"},
        {"Hipparcos Number", "HIP 89342"},
        {"Smithsonian Astrophysical Observation", "SAO 228819"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.44785105),
        dec: Angle.Degrees(-46.31246048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69650"},
        {"Hipparcos Number", "HIP 40478"},
        {"Celescope Catalog", "CEL 2297"},
        {"Smithsonian Astrophysical Observation", "SAO 219696"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.97027083),
        dec: Angle.Degrees(-46.31239782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222688"},
        {"Hipparcos Number", "HIP 116994"},
        {"Geneva Identification System", "GEN# +1.00222688J"},
        {"Smithsonian Astrophysical Observation", "SAO 231749"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77477998),
        dec: Angle.Degrees(-46.31215794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164052"},
        {"Hipparcos Number", "HIP 88280"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.40566565),
        dec: Angle.Degrees(-46.30892841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18523"},
        {"Hipparcos Number", "HIP 13746"},
        {"Smithsonian Astrophysical Observation", "SAO 216107"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.24195797),
        dec: Angle.Degrees(-46.30822699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127750"},
        {"Hipparcos Number", "HIP 71271"},
        {"Geneva Identification System", "GEN# +1.00127750"},
        {"Smithsonian Astrophysical Observation", "SAO 225031"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.63943422),
        dec: Angle.Degrees(-46.30473706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190803"},
        {"Hipparcos Number", "HIP 99245"},
        {"Geneva Identification System", "GEN# +1.00190803"},
        {"Smithsonian Astrophysical Observation", "SAO 230063"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.18108625),
        dec: Angle.Degrees(-46.30445272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99323"},
        {"Hipparcos Number", "HIP 55749"},
        {"Geneva Identification System", "GEN# +1.00099323"},
        {"Smithsonian Astrophysical Observation", "SAO 222781"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.34217717),
        dec: Angle.Degrees(-46.30437812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11695"},
        {"Hipparcos Number", "HIP 8837"},
        {"Fundamental Katalog 5th Edition", "FK5 67"},
        {"Geneva Identification System", "GEN# +1.00011695"},
        {"Smithsonian Astrophysical Observation", "SAO 215696"},
        {"Wilson Evans Batten Catalogue", "WEB 1863"},
    },
    visualMagnitude: 4.39,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.41174872),
        dec: Angle.Degrees(-46.30244631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170503"},
        {"Hipparcos Number", "HIP 90848"},
        {"Geneva Identification System", "GEN# +1.00170503"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.99320312),
        dec: Angle.Degrees(-46.30222553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22730"},
        {"Hipparcos Number", "HIP 16883"},
        {"Smithsonian Astrophysical Observation", "SAO 216407"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.32211134),
        dec: Angle.Degrees(-46.30219322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122556"},
        {"Hipparcos Number", "HIP 68694"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.91740439),
        dec: Angle.Degrees(-46.30182794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163499"},
        {"Hipparcos Number", "HIP 88021"},
        {"Geneva Identification System", "GEN# +1.00163499"},
        {"Smithsonian Astrophysical Observation", "SAO 228589"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.67919356),
        dec: Angle.Degrees(-46.30180973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190779"},
        {"Hipparcos Number", "HIP 99233"},
        {"Geneva Identification System", "GEN# +1.00190779"},
        {"Smithsonian Astrophysical Observation", "SAO 230062"},
        {"Wilson Evans Batten Catalogue", "WEB 17676"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.15780996),
        dec: Angle.Degrees(-46.30117201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128651"},
        {"Hipparcos Number", "HIP 71671"},
        {"Fundamental Katalog 5th Edition", "FK5 5301"},
        {"Smithsonian Astrophysical Observation", "SAO 225095"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.90274615),
        dec: Angle.Degrees(-46.29940868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143023"},
        {"Hipparcos Number", "HIP 78357"},
        {"Smithsonian Astrophysical Observation", "SAO 226429"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97830053),
        dec: Angle.Degrees(-46.29903699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160480"},
        {"Hipparcos Number", "HIP 86658"},
        {"Smithsonian Astrophysical Observation", "SAO 228307"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.58819981),
        dec: Angle.Degrees(-46.29886050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26263"},
        {"Hipparcos Number", "HIP 19213"},
        {"Geneva Identification System", "GEN# +1.00026263"},
        {"Smithsonian Astrophysical Observation", "SAO 216654"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.77611187),
        dec: Angle.Degrees(-46.29817803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129070"},
        {"Hipparcos Number", "HIP 71874"},
        {"Geneva Identification System", "GEN# +1.00129070"},
        {"Smithsonian Astrophysical Observation", "SAO 225132"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.51030765),
        dec: Angle.Degrees(-46.29793167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68607"},
        {"Hipparcos Number", "HIP 40072"},
        {"Geneva Identification System", "GEN# +1.00068607"},
        {"Smithsonian Astrophysical Observation", "SAO 219561"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79079030),
        dec: Angle.Degrees(-46.29736539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15657"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.40568473),
        dec: Angle.Degrees(-46.29605442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 295.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96601"},
        {"Hipparcos Number", "HIP 54357"},
        {"Smithsonian Astrophysical Observation", "SAO 222580"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.80716012),
        dec: Angle.Degrees(-46.29493607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86755"},
        {"Hipparcos Number", "HIP 48960"},
        {"Geneva Identification System", "GEN# +1.00086755"},
        {"Smithsonian Astrophysical Observation", "SAO 221666"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.81694931),
        dec: Angle.Degrees(-46.29428077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73631"},
        {"Geneva Identification System", "GEN# -0.04509610"},
        {"Wilson Evans Batten Catalogue", "WEB 12593"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.76591160),
        dec: Angle.Degrees(-46.29379766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -299.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130629"},
        {"Hipparcos Number", "HIP 72608"},
        {"Smithsonian Astrophysical Observation", "SAO 225230"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67999711),
        dec: Angle.Degrees(-46.29348665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29876"},
        {"Hipparcos Number", "HIP 21757"},
        {"Smithsonian Astrophysical Observation", "SAO 216924"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.07662295),
        dec: Angle.Degrees(-46.29321044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76060"},
        {"Hipparcos Number", "HIP 43536"},
        {"Celescope Catalog", "CEL 3018"},
        {"Geneva Identification System", "GEN# +1.00076060"},
        {"Smithsonian Astrophysical Observation", "SAO 220597"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.01024834),
        dec: Angle.Degrees(-46.28887169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124448"},
        {"Hipparcos Number", "HIP 69619"},
        {"Geneva Identification System", "GEN# +1.00124448"},
        {"Renson", "Renson 35630"},
        {"Smithsonian Astrophysical Observation", "SAO 224792"},
        {"Wilson Evans Batten Catalogue", "WEB 12125"},
    },
    visualMagnitude: 9.99,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.74431339),
        dec: Angle.Degrees(-46.28869326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17325"},
        {"Hipparcos Number", "HIP 12855"},
        {"Geneva Identification System", "GEN# +1.00017325"},
        {"Smithsonian Astrophysical Observation", "SAO 216036"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.31943956),
        dec: Angle.Degrees(-46.28697285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1859"},
        {"Hipparcos Number", "HIP 1788"},
        {"Geneva Identification System", "GEN# +1.00001859"},
        {"Smithsonian Astrophysical Observation", "SAO 215069"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.68175550),
        dec: Angle.Degrees(-46.28563047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113106"},
        {"Hipparcos Number", "HIP 63595"},
        {"Smithsonian Astrophysical Observation", "SAO 223850"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.48395801),
        dec: Angle.Degrees(-46.28510874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73658"},
        {"Hipparcos Number", "HIP 42316"},
        {"Celescope Catalog", "CEL 2721"},
        {"Geneva Identification System", "GEN# +1.00073658"},
        {"Smithsonian Astrophysical Observation", "SAO 220206"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41650782),
        dec: Angle.Degrees(-46.28272199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66814"},
        {"Hipparcos Number", "HIP 39396"},
        {"Geneva Identification System", "GEN# +1.00066814"},
        {"Smithsonian Astrophysical Observation", "SAO 219354"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.80756074),
        dec: Angle.Degrees(-46.28252258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42626"},
        {"Hipparcos Number", "HIP 29181"},
        {"Geneva Identification System", "GEN# +1.00042626"},
        {"Smithsonian Astrophysical Observation", "SAO 217741"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.34458702),
        dec: Angle.Degrees(-46.28039387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35401"},
        {"Hipparcos Number", "HIP 25080"},
        {"Smithsonian Astrophysical Observation", "SAO 217309"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.53991850),
        dec: Angle.Degrees(-46.27994540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200703"},
        {"Hipparcos Number", "HIP 104199"},
        {"Geneva Identification System", "GEN# +1.00200703"},
        {"Smithsonian Astrophysical Observation", "SAO 230524"},
        {"Wilson Evans Batten Catalogue", "WEB 18979"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.66299218),
        dec: Angle.Degrees(-46.27746187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29484"},
        {"Hipparcos Number", "HIP 21457"},
        {"Smithsonian Astrophysical Observation", "SAO 216894"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10781562),
        dec: Angle.Degrees(-46.27610869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80279"},
        {"Hipparcos Number", "HIP 45568"},
        {"Geneva Identification System", "GEN# +1.00080279"},
        {"Smithsonian Astrophysical Observation", "SAO 221029"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.31221210),
        dec: Angle.Degrees(-46.27505479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24756"},
        {"Hipparcos Number", "HIP 18241"},
        {"Smithsonian Astrophysical Observation", "SAO 216545"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.52276455),
        dec: Angle.Degrees(-46.27300726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183355"},
        {"Hipparcos Number", "HIP 96018"},
        {"Geneva Identification System", "GEN# +1.00183355"},
        {"Smithsonian Astrophysical Observation", "SAO 229728"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.84241224),
        dec: Angle.Degrees(-46.27297410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33425"},
        {"Hipparcos Number", "HIP 23881"},
        {"Smithsonian Astrophysical Observation", "SAO 217193"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.97322149),
        dec: Angle.Degrees(-46.26990474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123651"},
        {"Hipparcos Number", "HIP 69202"},
        {"Geneva Identification System", "GEN# +1.00123651"},
        {"Smithsonian Astrophysical Observation", "SAO 224736"},
        {"Wilson Evans Batten Catalogue", "WEB 12077"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.52038801),
        dec: Angle.Degrees(-46.26917918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92204"},
        {"Hipparcos Number", "HIP 52031"},
        {"Smithsonian Astrophysical Observation", "SAO 222207"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.46073809),
        dec: Angle.Degrees(-46.26821073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30305"},
        {"Hipparcos Number", "HIP 22029"},
        {"Smithsonian Astrophysical Observation", "SAO 216969"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.04265348),
        dec: Angle.Degrees(-46.26783127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97413"},
        {"Hipparcos Number", "HIP 54718"},
        {"Geneva Identification System", "GEN# +1.00097413"},
        {"Smithsonian Astrophysical Observation", "SAO 222635"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04268745),
        dec: Angle.Degrees(-46.26677462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6980"},
        {"Hipparcos Number", "HIP 5438"},
        {"Geneva Identification System", "GEN# +1.00006980"},
        {"Smithsonian Astrophysical Observation", "SAO 215389"},
        {"Wilson Evans Batten Catalogue", "WEB 1188"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.39228243),
        dec: Angle.Degrees(-46.26557954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68895"},
        {"Hipparcos Number", "HIP 40183"},
        {"Celescope Catalog", "CEL 2236"},
        {"Geneva Identification System", "GEN# +1.00068895"},
        {"Smithsonian Astrophysical Observation", "SAO 219602"},
        {"Wilson Evans Batten Catalogue", "WEB 7840"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.12831936),
        dec: Angle.Degrees(-46.26430821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12321"},
        {"Hipparcos Number", "HIP 9311"},
        {"Smithsonian Astrophysical Observation", "SAO 215728"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.90572767),
        dec: Angle.Degrees(-46.26302782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146856"},
        {"Hipparcos Number", "HIP 80064"},
        {"Geneva Identification System", "GEN# +1.00146856"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.12929184),
        dec: Angle.Degrees(-46.26266502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73386"},
        {"Hipparcos Number", "HIP 42204"},
        {"Smithsonian Astrophysical Observation", "SAO 220171"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.07906398),
        dec: Angle.Degrees(-46.26195411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68007"},
        {"Hipparcos Number", "HIP 39855"},
        {"Celescope Catalog", "CEL 2182"},
        {"Geneva Identification System", "GEN# +1.00068007"},
        {"Smithsonian Astrophysical Observation", "SAO 219475"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.13634541),
        dec: Angle.Degrees(-46.26051813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95349"},
        {"Hipparcos Number", "HIP 53757"},
        {"Smithsonian Astrophysical Observation", "SAO 222483"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.97466383),
        dec: Angle.Degrees(-46.25835031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131243"},
        {"Hipparcos Number", "HIP 72899"},
        {"Geneva Identification System", "GEN# +1.00131243"},
        {"Smithsonian Astrophysical Observation", "SAO 225279"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.48627381),
        dec: Angle.Degrees(-46.25818344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11058"},
        {"Hipparcos Number", "HIP 8344"},
        {"Smithsonian Astrophysical Observation", "SAO 215654"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.90749106),
        dec: Angle.Degrees(-46.25722174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200334"},
        {"Hipparcos Number", "HIP 104026"},
        {"Fundamental Katalog 5th Edition", "FK5 3679"},
        {"Geneva Identification System", "GEN# +1.00200334"},
        {"Smithsonian Astrophysical Observation", "SAO 230507"},
        {"Wilson Evans Batten Catalogue", "WEB 18948"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.13280962),
        dec: Angle.Degrees(-46.25541694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16380"},
        {"Hipparcos Number", "HIP 12120"},
        {"Smithsonian Astrophysical Observation", "SAO 215963"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03350362),
        dec: Angle.Degrees(-46.25449637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33812"},
        {"Hipparcos Number", "HIP 24095"},
        {"Smithsonian Astrophysical Observation", "SAO 217217"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.63964804),
        dec: Angle.Degrees(-46.25084742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148103"},
        {"Hipparcos Number", "HIP 80652"},
        {"Smithsonian Astrophysical Observation", "SAO 226784"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99629388),
        dec: Angle.Degrees(-46.25075427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75820"},
        {"Hipparcos Number", "HIP 43400"},
        {"Celescope Catalog", "CEL 2984"},
        {"Geneva Identification System", "GEN# +1.00075820"},
        {"Smithsonian Astrophysical Observation", "SAO 220559"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.60869278),
        dec: Angle.Degrees(-46.24815839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132302"},
        {"Hipparcos Number", "HIP 73393"},
        {"Celescope Catalog", "CEL 4332"},
        {"Geneva Identification System", "GEN# +1.00132302"},
        {"Smithsonian Astrophysical Observation", "SAO 225357"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.97773335),
        dec: Angle.Degrees(-46.24787884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202592"},
        {"Hipparcos Number", "HIP 105176"},
        {"Smithsonian Astrophysical Observation", "SAO 230619"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.59772607),
        dec: Angle.Degrees(-46.24779434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58871"},
        {"Hipparcos Number", "HIP 36007"},
    },
    visualMagnitude: 8.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)25, 15.8200),
        dec: Angle.DegreesMinutesSeconds((int)-46, (int)14, 50.800)
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
    primaryId: "HIP 71419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128068"},
        {"Hipparcos Number", "HIP 71419"},
        {"Geneva Identification System", "GEN# +1.00128068"},
        {"Smithsonian Astrophysical Observation", "SAO 225054"},
        {"Wilson Evans Batten Catalogue", "WEB 12325"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.07940330),
        dec: Angle.Degrees(-46.24549130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110482"},
        {"Hipparcos Number", "HIP 62021"},
        {"Smithsonian Astrophysical Observation", "SAO 223617"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.69521807),
        dec: Angle.Degrees(-46.24404919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177772"},
        {"Hipparcos Number", "HIP 94001"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08420109),
        dec: Angle.Degrees(-46.24378775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22865"},
        {"Hipparcos Number", "HIP 16984"},
        {"Geneva Identification System", "GEN# +1.00022865"},
        {"Smithsonian Astrophysical Observation", "SAO 216421"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.60956632),
        dec: Angle.Degrees(-46.24334539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148379"},
        {"Hipparcos Number", "HIP 80782"},
        {"Fundamental Katalog 5th Edition", "FK5 3301"},
        {"Geneva Identification System", "GEN# +1.00148379"},
        {"Smithsonian Astrophysical Observation", "SAO 226813"},
        {"Wilson Evans Batten Catalogue", "WEB 13662"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.42637688),
        dec: Angle.Degrees(-46.24321937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42601"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.24073979),
        dec: Angle.Degrees(-46.24131446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56857"},
        {"Hipparcos Number", "HIP 35207"},
        {"Smithsonian Astrophysical Observation", "SAO 218598"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.14987129),
        dec: Angle.Degrees(-46.23805681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329837"},
        {"Hipparcos Number", "HIP 84635"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.52539883),
        dec: Angle.Degrees(-46.23697118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71574"},
        {"Hipparcos Number", "HIP 41355"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.55424929),
        dec: Angle.Degrees(-46.23548216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79296"},
        {"Hipparcos Number", "HIP 45128"},
        {"Renson", "Renson 22510"},
        {"Smithsonian Astrophysical Observation", "SAO 220939"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.92291669),
        dec: Angle.Degrees(-46.23429434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68697"},
        {"Hipparcos Number", "HIP 40109"},
        {"Celescope Catalog", "CEL 2222"},
        {"Geneva Identification System", "GEN# +1.00068697"},
        {"Smithsonian Astrophysical Observation", "SAO 219572"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.89019726),
        dec: Angle.Degrees(-46.23292479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205155"},
        {"Hipparcos Number", "HIP 106567"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.72910101),
        dec: Angle.Degrees(-46.23272939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198908"},
        {"Hipparcos Number", "HIP 103265"},
        {"Smithsonian Astrophysical Observation", "SAO 230437"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.80741011),
        dec: Angle.Degrees(-46.23229971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167985"},
        {"Hipparcos Number", "HIP 89832"},
        {"Smithsonian Astrophysical Observation", "SAO 228909"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.97439779),
        dec: Angle.Degrees(-46.23173922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198048"},
        {"Hipparcos Number", "HIP 102790"},
        {"Fundamental Katalog 5th Edition", "FK5 3661"},
        {"Geneva Identification System", "GEN# +1.00198048"},
        {"Smithsonian Astrophysical Observation", "SAO 230391"},
        {"Wilson Evans Batten Catalogue", "WEB 18640"},
    },
    visualMagnitude: 4.90,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.37053840),
        dec: Angle.Degrees(-46.22689249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41353"},
        {"Hipparcos Number", "HIP 28610"},
        {"Smithsonian Astrophysical Observation", "SAO 217688"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.57259029),
        dec: Angle.Degrees(-46.22651915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141856"},
        {"Hipparcos Number", "HIP 77794"},
        {"Smithsonian Astrophysical Observation", "SAO 226326"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.28275993),
        dec: Angle.Degrees(-46.22167065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8382"},
        {"Hipparcos Number", "HIP 6397"},
        {"Geneva Identification System", "GEN# +1.00008382J"},
        {"Smithsonian Astrophysical Observation", "SAO 215477"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.54329750),
        dec: Angle.Degrees(-46.22155231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94326"},
        {"Hipparcos Number", "HIP 53162"},
        {"Geneva Identification System", "GEN# +1.00094326"},
        {"Smithsonian Astrophysical Observation", "SAO 222392"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13900079),
        dec: Angle.Degrees(-46.21726449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6106"},
        {"Hipparcos Number", "HIP 4807"},
        {"Geneva Identification System", "GEN# +1.00006106"},
        {"Smithsonian Astrophysical Observation", "SAO 215331"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.42939164),
        dec: Angle.Degrees(-46.21563180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222137"},
        {"Hipparcos Number", "HIP 116641"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.55894544),
        dec: Angle.Degrees(-46.21375247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126561"},
        {"Hipparcos Number", "HIP 70697"},
        {"Geneva Identification System", "GEN# +1.00126561"},
        {"Smithsonian Astrophysical Observation", "SAO 224936"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.89004907),
        dec: Angle.Degrees(-46.21347028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38568"},
        {"Hipparcos Number", "HIP 27064"},
        {"Smithsonian Astrophysical Observation", "SAO 217506"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.09773981),
        dec: Angle.Degrees(-46.21137941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112346"},
        {"Hipparcos Number", "HIP 63160"},
        {"Geneva Identification System", "GEN# +1.00112346"},
        {"Smithsonian Astrophysical Observation", "SAO 223771"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.12568867),
        dec: Angle.Degrees(-46.20940290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105671"},
        {"Hipparcos Number", "HIP 59296"},
        {"Geneva Identification System", "GEN# +1.00105671"},
        {"Smithsonian Astrophysical Observation", "SAO 223250"},
        {"Wilson Evans Batten Catalogue", "WEB 10547"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.48043398),
        dec: Angle.Degrees(-46.20818797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -382.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85351"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.61892796),
        dec: Angle.Degrees(-46.20758288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93106"},
        {"Hipparcos Number", "HIP 52523"},
        {"Smithsonian Astrophysical Observation", "SAO 222286"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.08775321),
        dec: Angle.Degrees(-46.20696348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42190"},
        {"Hipparcos Number", "HIP 28987"},
        {"Geneva Identification System", "GEN# +1.00042190"},
        {"Smithsonian Astrophysical Observation", "SAO 217725"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.74937384),
        dec: Angle.Degrees(-46.20557470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101461"},
        {"Geneva Identification System", "GEN# +6.20145057"},
    },
    visualMagnitude: 11.88,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.44004511),
        dec: Angle.Degrees(-46.20538424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18351"},
        {"Hipparcos Number", "HIP 13606"},
        {"Smithsonian Astrophysical Observation", "SAO 216097"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.83423516),
        dec: Angle.Degrees(-46.20528384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70264"},
        {"Hipparcos Number", "HIP 40755"},
        {"Geneva Identification System", "GEN# +1.00070264J"},
        {"Smithsonian Astrophysical Observation", "SAO 219783"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78764665),
        dec: Angle.Degrees(-46.20524542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115874"},
        {"Hipparcos Number", "HIP 65127"},
        {"Smithsonian Astrophysical Observation", "SAO 224076"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.19898092),
        dec: Angle.Degrees(-46.20488696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191189"},
        {"Hipparcos Number", "HIP 99406"},
        {"Smithsonian Astrophysical Observation", "SAO 230081"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.64464173),
        dec: Angle.Degrees(-46.20435435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135468"},
        {"Hipparcos Number", "HIP 74775"},
        {"Geneva Identification System", "GEN# +1.00135468"},
        {"Smithsonian Astrophysical Observation", "SAO 225614"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.22949130),
        dec: Angle.Degrees(-46.20229188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214731"},
        {"Hipparcos Number", "HIP 111983"},
        {"Geneva Identification System", "GEN# +1.00214731"},
        {"Smithsonian Astrophysical Observation", "SAO 231248"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.24422375),
        dec: Angle.Degrees(-46.20194769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157317"},
        {"Hipparcos Number", "HIP 85223"},
        {"Celescope Catalog", "CEL 4510"},
        {"Geneva Identification System", "GEN# +1.00157317"},
        {"Smithsonian Astrophysical Observation", "SAO 227923"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.21685550),
        dec: Angle.Degrees(-46.20192730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135768"},
        {"Hipparcos Number", "HIP 74919"},
        {"Smithsonian Astrophysical Observation", "SAO 225640"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.64866585),
        dec: Angle.Degrees(-46.20191347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126575"},
        {"Hipparcos Number", "HIP 70703"},
        {"Geneva Identification System", "GEN# +1.00126575"},
        {"Smithsonian Astrophysical Observation", "SAO 224939"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.91432888),
        dec: Angle.Degrees(-46.20184901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20639"},
        {"Hipparcos Number", "HIP 15316"},
        {"Smithsonian Astrophysical Observation", "SAO 216248"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.40512214),
        dec: Angle.Degrees(-46.20173802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191760"},
        {"Hipparcos Number", "HIP 99661"},
        {"Geneva Identification System", "GEN# +1.00191760"},
        {"Smithsonian Astrophysical Observation", "SAO 230105"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.36145495),
        dec: Angle.Degrees(-46.20087635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116351"},
        {"Hipparcos Number", "HIP 65377"},
        {"Smithsonian Astrophysical Observation", "SAO 224108"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.97597482),
        dec: Angle.Degrees(-46.20013683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87964"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52897215),
        dec: Angle.Degrees(-46.19885538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327540"},
        {"Hipparcos Number", "HIP 77891"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60369258),
        dec: Angle.Degrees(-46.19840386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104949"},
        {"Hipparcos Number", "HIP 58926"},
        {"Smithsonian Astrophysical Observation", "SAO 223205"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.24891572),
        dec: Angle.Degrees(-46.19631773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155115"},
        {"Hipparcos Number", "HIP 84128"},
        {"Smithsonian Astrophysical Observation", "SAO 227705"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.97778409),
        dec: Angle.Degrees(-46.19441634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85563"},
        {"Hipparcos Number", "HIP 48348"},
        {"Fundamental Katalog 5th Edition", "FK5 1256"},
        {"Geneva Identification System", "GEN# +1.00085563"},
        {"Smithsonian Astrophysical Observation", "SAO 221547"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.83234215),
        dec: Angle.Degrees(-46.19395369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52468"},
        {"Hipparcos Number", "HIP 33619"},
        {"Smithsonian Astrophysical Observation", "SAO 218365"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.77284644),
        dec: Angle.Degrees(-46.19347588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68976"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.81728139),
        dec: Angle.Degrees(-46.19342016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87950"},
        {"Hipparcos Number", "HIP 49584"},
        {"Smithsonian Astrophysical Observation", "SAO 221785"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.83337299),
        dec: Angle.Degrees(-46.19224580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197428"},
        {"Hipparcos Number", "HIP 102437"},
        {"Geneva Identification System", "GEN# +1.00197428"},
        {"Smithsonian Astrophysical Observation", "SAO 230350"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.36086698),
        dec: Angle.Degrees(-46.19081295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26981"},
        {"Hipparcos Number", "HIP 19731"},
        {"Smithsonian Astrophysical Observation", "SAO 216709"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.44469033),
        dec: Angle.Degrees(-46.18623709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200917"},
        {"Hipparcos Number", "HIP 104332"},
        {"Smithsonian Astrophysical Observation", "SAO 230540"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.01829159),
        dec: Angle.Degrees(-46.18590958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206051"},
        {"Hipparcos Number", "HIP 107044"},
        {"Smithsonian Astrophysical Observation", "SAO 230788"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.19208524),
        dec: Angle.Degrees(-46.18465645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60199"},
        {"Hipparcos Number", "HIP 36561"},
        {"Celescope Catalog", "CEL 1912"},
        {"Smithsonian Astrophysical Observation", "SAO 218776"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80835303),
        dec: Angle.Degrees(-46.18378054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117226"},
        {"Hipparcos Number", "HIP 65831"},
        {"Smithsonian Astrophysical Observation", "SAO 224184"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42477886),
        dec: Angle.Degrees(-46.18361261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100784"},
        {"Hipparcos Number", "HIP 56544"},
        {"Geneva Identification System", "GEN# +1.00100784"},
        {"Smithsonian Astrophysical Observation", "SAO 222892"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.90856858),
        dec: Angle.Degrees(-46.18354107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60967"},
    },
    visualMagnitude: 11.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.46975511),
        dec: Angle.Degrees(-46.18331981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120674"},
        {"Hipparcos Number", "HIP 67690"},
        {"Smithsonian Astrophysical Observation", "SAO 224494"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99709770),
        dec: Angle.Degrees(-46.18263206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155020"},
        {"Hipparcos Number", "HIP 84073"},
        {"Celescope Catalog", "CEL 4485"},
        {"Geneva Identification System", "GEN# +1.00155020J"},
        {"Smithsonian Astrophysical Observation", "SAO 227695"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.82565159),
        dec: Angle.Degrees(-46.18211561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186391"},
        {"Hipparcos Number", "HIP 97269"},
        {"Smithsonian Astrophysical Observation", "SAO 229856"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.52848342),
        dec: Angle.Degrees(-46.18166679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31007"},
        {"Hipparcos Number", "HIP 22464"},
        {"Smithsonian Astrophysical Observation", "SAO 217031"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.52165024),
        dec: Angle.Degrees(-46.17851881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47925"},
        {"Hipparcos Number", "HIP 31778"},
        {"Geneva Identification System", "GEN# +1.00047925"},
        {"Smithsonian Astrophysical Observation", "SAO 218089"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.67234258),
        dec: Angle.Degrees(-46.17515501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111503"},
        {"Hipparcos Number", "HIP 62649"},
        {"Geneva Identification System", "GEN# +1.00111503"},
        {"Smithsonian Astrophysical Observation", "SAO 223695"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.55663091),
        dec: Angle.Degrees(-46.17344766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7886"},
        {"Hipparcos Number", "HIP 6054"},
        {"Geneva Identification System", "GEN# +1.00007886"},
        {"Smithsonian Astrophysical Observation", "SAO 215443"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.43229870),
        dec: Angle.Degrees(-46.17233434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28432"},
        {"Hipparcos Number", "HIP 20763"},
        {"Smithsonian Astrophysical Observation", "SAO 216807"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.72815760),
        dec: Angle.Degrees(-46.17154204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54335"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.72582222),
        dec: Angle.Degrees(-46.17094264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156472"},
        {"Hipparcos Number", "HIP 84811"},
        {"Smithsonian Astrophysical Observation", "SAO 227829"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00987312),
        dec: Angle.Degrees(-46.16995449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129734"},
        {"Hipparcos Number", "HIP 72173"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43498046),
        dec: Angle.Degrees(-46.16936321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66078"},
        {"Hipparcos Number", "HIP 39098"},
        {"Geneva Identification System", "GEN# +1.00066078"},
        {"Smithsonian Astrophysical Observation", "SAO 219267"},
        {"Wilson Evans Batten Catalogue", "WEB 7668"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.97622187),
        dec: Angle.Degrees(-46.16801444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217816"},
        {"Hipparcos Number", "HIP 113901"},
        {"Geneva Identification System", "GEN# +1.00217816"},
        {"Smithsonian Astrophysical Observation", "SAO 231417"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.99847480),
        dec: Angle.Degrees(-46.16771475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108207"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83446742),
        dec: Angle.Degrees(-46.16649270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84044"},
        {"Hipparcos Number", "HIP 47497"},
        {"Geneva Identification System", "GEN# +1.00084044"},
        {"Smithsonian Astrophysical Observation", "SAO 221399"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.25559849),
        dec: Angle.Degrees(-46.16602239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75741"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11222643),
        dec: Angle.Degrees(-46.16585807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212088"},
        {"Hipparcos Number", "HIP 110484"},
        {"Smithsonian Astrophysical Observation", "SAO 231108"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.69862096),
        dec: Angle.Degrees(-46.16535794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95198"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.49598431),
        dec: Angle.Degrees(-46.16366535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221871"},
        {"Hipparcos Number", "HIP 116460"},
        {"Geneva Identification System", "GEN# +1.00221871"},
        {"Geneva Identification System 2", "GEN# +6.20145138"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.97013645),
        dec: Angle.Degrees(-46.16310189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -345.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219775"},
        {"Hipparcos Number", "HIP 115111"},
        {"Smithsonian Astrophysical Observation", "SAO 231543"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.72399872),
        dec: Angle.Degrees(-46.16261277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24499"},
        {"Hipparcos Number", "HIP 18078"},
        {"Geneva Identification System", "GEN# +1.00024499"},
        {"Smithsonian Astrophysical Observation", "SAO 216529"},
        {"Wilson Evans Batten Catalogue", "WEB 3487"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.96329977),
        dec: Angle.Degrees(-46.16253646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46624"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.61153857),
        dec: Angle.Degrees(-46.16228796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -343.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119969"},
        {"Hipparcos Number", "HIP 67298"},
        {"Smithsonian Astrophysical Observation", "SAO 224422"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.87853321),
        dec: Angle.Degrees(-46.16107996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63343"},
        {"Hipparcos Number", "HIP 37926"},
        {"Celescope Catalog", "CEL 2026"},
        {"Geneva Identification System", "GEN# +1.00063343"},
        {"Smithsonian Astrophysical Observation", "SAO 218979"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.57936695),
        dec: Angle.Degrees(-46.15965937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 296884"},
        {"Hipparcos Number", "HIP 46176"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23925608),
        dec: Angle.Degrees(-46.15872190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62525"},
        {"Geneva Identification System", "GEN# -0.04508032"},
        {"Smithsonian Astrophysical Observation", "SAO 223682"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.20249727),
        dec: Angle.Degrees(-46.15867122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130119"},
        {"Hipparcos Number", "HIP 72375"},
        {"Celescope Catalog", "CEL 4322"},
        {"Geneva Identification System", "GEN# +1.00130119"},
        {"Smithsonian Astrophysical Observation", "SAO 225190"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.98111029),
        dec: Angle.Degrees(-46.15617742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75276"},
        {"Hipparcos Number", "HIP 43148"},
        {"Celescope Catalog", "CEL 2914"},
        {"Geneva Identification System", "GEN# +1.00075276"},
        {"Smithsonian Astrophysical Observation", "SAO 220464"},
        {"Wilson Evans Batten Catalogue", "WEB 8328"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.82853523),
        dec: Angle.Degrees(-46.15542775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149609"},
        {"Hipparcos Number", "HIP 81434"},
        {"Smithsonian Astrophysical Observation", "SAO 226978"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.49889291),
        dec: Angle.Degrees(-46.15462591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109136"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.60018795),
        dec: Angle.Degrees(-46.15303257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8024"},
        {"Hipparcos Number", "HIP 6141"},
        {"Geneva Identification System", "GEN# +1.00008024"},
        {"Smithsonian Astrophysical Observation", "SAO 215451"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.71208619),
        dec: Angle.Degrees(-46.15204602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154042"},
        {"Hipparcos Number", "HIP 83602"},
        {"Geneva Identification System", "GEN# +1.00154042"},
        {"Smithsonian Astrophysical Observation", "SAO 227605"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.32769004),
        dec: Angle.Degrees(-46.15197359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8977"},
        {"Hipparcos Number", "HIP 6806"},
        {"Geneva Identification System", "GEN# +1.00008977"},
        {"Smithsonian Astrophysical Observation", "SAO 215513"},
        {"Wilson Evans Batten Catalogue", "WEB 1487"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.89682999),
        dec: Angle.Degrees(-46.15167440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138908"},
        {"Hipparcos Number", "HIP 76461"},
        {"Geneva Identification System", "GEN# +1.00138908"},
        {"Smithsonian Astrophysical Observation", "SAO 225973"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.23236277),
        dec: Angle.Degrees(-46.15129598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184349"},
        {"Hipparcos Number", "HIP 96418"},
        {"Smithsonian Astrophysical Observation", "SAO 229764"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.03620292),
        dec: Angle.Degrees(-46.15128421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16009"},
        {"Hipparcos Number", "HIP 11849"},
        {"Smithsonian Astrophysical Observation", "SAO 215939"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.23419949),
        dec: Angle.Degrees(-46.15069841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25336"},
        {"Hipparcos Number", "HIP 18648"},
        {"Smithsonian Astrophysical Observation", "SAO 216592"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.87683867),
        dec: Angle.Degrees(-46.15001925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110287"},
        {"Hipparcos Number", "HIP 61916"},
        {"Fundamental Katalog 5th Edition", "FK5 1325"},
        {"Geneva Identification System", "GEN# +1.00110287"},
        {"Smithsonian Astrophysical Observation", "SAO 223601"},
        {"Wilson Evans Batten Catalogue", "WEB 11008"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.34602074),
        dec: Angle.Degrees(-46.14572729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178732"},
        {"Hipparcos Number", "HIP 94325"},
        {"Smithsonian Astrophysical Observation", "SAO 229544"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.98689966),
        dec: Angle.Degrees(-46.14458306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220728"},
        {"Hipparcos Number", "HIP 115703"},
        {"Smithsonian Astrophysical Observation", "SAO 231607"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.63196175),
        dec: Angle.Degrees(-46.14441204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152687"},
        {"Hipparcos Number", "HIP 82952"},
        {"Geneva Identification System", "GEN# +2.62500032"},
        {"Smithsonian Astrophysical Observation", "SAO 227478"},
        {"New General Catalogue", "NGC 6250 32"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.26857308),
        dec: Angle.Degrees(-46.14372967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136607"},
        {"Hipparcos Number", "HIP 75324"},
        {"Geneva Identification System", "GEN# +1.00136607"},
        {"Smithsonian Astrophysical Observation", "SAO 225721"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.85418197),
        dec: Angle.Degrees(-46.14039293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135036"},
        {"Hipparcos Number", "HIP 74611"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.67292532),
        dec: Angle.Degrees(-46.14022838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212578"},
        {"Hipparcos Number", "HIP 110762"},
        {"Smithsonian Astrophysical Observation", "SAO 231138"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.59374206),
        dec: Angle.Degrees(-46.13826174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25537"},
        {"Hipparcos Number", "HIP 18771"},
        {"Geneva Identification System", "GEN# +1.00025537"},
        {"Smithsonian Astrophysical Observation", "SAO 216602"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.32345203),
        dec: Angle.Degrees(-46.13737515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211523"},
        {"Hipparcos Number", "HIP 110148"},
        {"Smithsonian Astrophysical Observation", "SAO 231074"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.66882502),
        dec: Angle.Degrees(-46.13710908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188071"},
        {"Hipparcos Number", "HIP 98043"},
        {"Smithsonian Astrophysical Observation", "SAO 229925"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83867981),
        dec: Angle.Degrees(-46.13414451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126504"},
        {"Hipparcos Number", "HIP 70663"},
        {"Celescope Catalog", "CEL 4320"},
        {"Geneva Identification System", "GEN# +1.00126504"},
        {"Renson", "Renson 36040"},
        {"Smithsonian Astrophysical Observation", "SAO 224929"},
        {"Wilson Evans Batten Catalogue", "WEB 12244"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.80124777),
        dec: Angle.Degrees(-46.13406420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128266"},
        {"Hipparcos Number", "HIP 71500"},
        {"Geneva Identification System", "GEN# +1.00128266"},
        {"Smithsonian Astrophysical Observation", "SAO 225062"},
        {"Wilson Evans Batten Catalogue", "WEB 12334"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.33402084),
        dec: Angle.Degrees(-46.13341306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9516"},
        {"Hipparcos Number", "HIP 7176"},
        {"Smithsonian Astrophysical Observation", "SAO 215543"},
    },
    visualMagnitude: 9.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.12715511),
        dec: Angle.Degrees(-46.13293158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27019"},
        {"Hipparcos Number", "HIP 19758"},
        {"Geneva Identification System", "GEN# +1.00027019J"},
        {"Smithsonian Astrophysical Observation", "SAO 216711"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.53978666),
        dec: Angle.Degrees(-46.13221353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43767"},
        {"Hipparcos Number", "HIP 29729"},
        {"Smithsonian Astrophysical Observation", "SAO 217813"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91857418),
        dec: Angle.Degrees(-46.13206883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81844"},
        {"Hipparcos Number", "HIP 46316"},
        {"Geneva Identification System", "GEN# +1.00081844"},
        {"Smithsonian Astrophysical Observation", "SAO 221176"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66781118),
        dec: Angle.Degrees(-46.13179911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128267"},
        {"Hipparcos Number", "HIP 71502"},
        {"Geneva Identification System", "GEN# +1.00128266C"},
        {"Geneva Identification System 2", "GEN# +1.00128267"},
        {"Smithsonian Astrophysical Observation", "SAO 225063"},
        {"Wilson Evans Batten Catalogue", "WEB 12335"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.33658656),
        dec: Angle.Degrees(-46.12960706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 339.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 803.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224597"},
        {"Hipparcos Number", "HIP 118255"},
        {"Smithsonian Astrophysical Observation", "SAO 231873"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.78796998),
        dec: Angle.Degrees(-46.12904940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152979"},
        {"Hipparcos Number", "HIP 83105"},
        {"Celescope Catalog", "CEL 4470"},
        {"Geneva Identification System", "GEN# +2.62500035"},
        {"Smithsonian Astrophysical Observation", "SAO 227517"},
        {"New General Catalogue", "NGC 6250 35"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.73669284),
        dec: Angle.Degrees(-46.12898840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223739"},
        {"Hipparcos Number", "HIP 117706"},
        {"Geneva Identification System", "GEN# +1.00223739"},
        {"Smithsonian Astrophysical Observation", "SAO 231819"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.07840472),
        dec: Angle.Degrees(-46.12856989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209316"},
        {"Hipparcos Number", "HIP 108899"},
        {"Smithsonian Astrophysical Observation", "SAO 230961"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.89210059),
        dec: Angle.Degrees(-46.12752114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122015"},
        {"Hipparcos Number", "HIP 68414"},
        {"Smithsonian Astrophysical Observation", "SAO 224606"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.07869213),
        dec: Angle.Degrees(-46.12725565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81802"},
        {"Hipparcos Number", "HIP 46293"},
        {"Geneva Identification System", "GEN# +1.00081802"},
        {"Smithsonian Astrophysical Observation", "SAO 221168"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.60580033),
        dec: Angle.Degrees(-46.12549103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203122"},
        {"Hipparcos Number", "HIP 105458"},
        {"Smithsonian Astrophysical Observation", "SAO 230648"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.41512775),
        dec: Angle.Degrees(-46.12226157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163199"},
        {"Hipparcos Number", "HIP 87887"},
        {"Smithsonian Astrophysical Observation", "SAO 228565"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.29414164),
        dec: Angle.Degrees(-46.12133960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162333"},
        {"Hipparcos Number", "HIP 87512"},
        {"Smithsonian Astrophysical Observation", "SAO 228506"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.19839108),
        dec: Angle.Degrees(-46.12110194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150702"},
        {"Hipparcos Number", "HIP 81987"},
        {"Smithsonian Astrophysical Observation", "SAO 227147"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.24023559),
        dec: Angle.Degrees(-46.11423874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89712"},
        {"Hipparcos Number", "HIP 50594"},
        {"Smithsonian Astrophysical Observation", "SAO 221967"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.02962233),
        dec: Angle.Degrees(-46.11367820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15482"},
        {"Hipparcos Number", "HIP 11489"},
        {"Smithsonian Astrophysical Observation", "SAO 215911"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04584740),
        dec: Angle.Degrees(-46.11354457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83216"},
        {"Hipparcos Number", "HIP 47065"},
        {"Geneva Identification System", "GEN# +1.00083216"},
        {"Smithsonian Astrophysical Observation", "SAO 221314"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.87543953),
        dec: Angle.Degrees(-46.11194113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220053"},
        {"Hipparcos Number", "HIP 115298"},
        {"Smithsonian Astrophysical Observation", "SAO 231561"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.28262639),
        dec: Angle.Degrees(-46.11184761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224360"},
        {"Hipparcos Number", "HIP 118091"},
        {"Geneva Identification System", "GEN# +1.00224360"},
        {"Smithsonian Astrophysical Observation", "SAO 231863"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33143758),
        dec: Angle.Degrees(-46.11033103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37706"},
        {"Hipparcos Number", "HIP 26501"},
        {"Cincinnati Publication", "Ci 20 343"},
        {"Geneva Identification System", "GEN# +1.00037706J"},
        {"Smithsonian Astrophysical Observation", "SAO 217444"},
        {"Wilson Evans Batten Catalogue", "WEB 5226"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.53956879),
        dec: Angle.Degrees(-46.10490664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -465.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183433"},
        {"Hipparcos Number", "HIP 96039"},
        {"Smithsonian Astrophysical Observation", "SAO 229729"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.91543029),
        dec: Angle.Degrees(-46.10485898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44590"},
        {"Hipparcos Number", "HIP 30111"},
        {"Geneva Identification System", "GEN# +1.00044590"},
        {"Smithsonian Astrophysical Observation", "SAO 217863"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.05516787),
        dec: Angle.Degrees(-46.10430006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75877"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.47768482),
        dec: Angle.Degrees(-46.10076066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96133"},
        {"Hipparcos Number", "HIP 54157"},
        {"Smithsonian Astrophysical Observation", "SAO 222541"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.18030205),
        dec: Angle.Degrees(-46.09916106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205805"},
        {"Hipparcos Number", "HIP 106917"},
        {"Geneva Identification System", "GEN# +1.00205805"},
        {"Smithsonian Astrophysical Observation", "SAO 230769"},
    },
    visualMagnitude: 10.18,
    bvColour: -0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.79395905),
        dec: Angle.Degrees(-46.09762333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190057"},
        {"Hipparcos Number", "HIP 98918"},
        {"Geneva Identification System", "GEN# +1.00190057"},
        {"Smithsonian Astrophysical Observation", "SAO 230031"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.28294352),
        dec: Angle.Degrees(-46.09696218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52196"},
        {"Hipparcos Number", "HIP 33517"},
        {"Celescope Catalog", "CEL 1469"},
        {"Geneva Identification System", "GEN# +1.00052196"},
        {"Smithsonian Astrophysical Observation", "SAO 218350"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50287191),
        dec: Angle.Degrees(-46.09589246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100209"},
        {"Hipparcos Number", "HIP 56220"},
        {"Smithsonian Astrophysical Observation", "SAO 222844"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.88246719),
        dec: Angle.Degrees(-46.09419358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36137"},
        {"Hipparcos Number", "HIP 25506"},
        {"Geneva Identification System", "GEN# +1.00036137"},
        {"Smithsonian Astrophysical Observation", "SAO 217342"},
        {"Wilson Evans Batten Catalogue", "WEB 4950"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.81560396),
        dec: Angle.Degrees(-46.09416877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1720"},
    },
    visualMagnitude: 12.21,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.40633478),
        dec: Angle.Degrees(-46.09173618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -301.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152295"},
        {"Hipparcos Number", "HIP 82745"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.68139274),
        dec: Angle.Degrees(-46.09002710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136391"},
        {"Hipparcos Number", "HIP 75212"},
        {"Geneva Identification System", "GEN# +1.00136391"},
        {"Smithsonian Astrophysical Observation", "SAO 225705"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.54948766),
        dec: Angle.Degrees(-46.08948750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220614"},
        {"Hipparcos Number", "HIP 115637"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.38634080),
        dec: Angle.Degrees(-46.08912726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188815"},
        {"Hipparcos Number", "HIP 98355"},
        {"Geneva Identification System", "GEN# +1.00188815"},
        {"Smithsonian Astrophysical Observation", "SAO 229960"},
        {"Wilson Evans Batten Catalogue", "WEB 17354"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.74364504),
        dec: Angle.Degrees(-46.08813309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106288"},
        {"Hipparcos Number", "HIP 59638"},
        {"Smithsonian Astrophysical Observation", "SAO 223294"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.46546738),
        dec: Angle.Degrees(-46.08703798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19960"},
        {"Hipparcos Number", "HIP 14770"},
        {"Smithsonian Astrophysical Observation", "SAO 216200"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.67211878),
        dec: Angle.Degrees(-46.08551147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 187.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3919"},
        {"Hipparcos Number", "HIP 3245"},
        {"Fundamental Katalog 5th Edition", "FK5 1015"},
        {"Geneva Identification System", "GEN# +1.00003919"},
        {"Smithsonian Astrophysical Observation", "SAO 215194"},
        {"Wilson Evans Batten Catalogue", "WEB 581"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.33156671),
        dec: Angle.Degrees(-46.08500934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144053"},
        {"Hipparcos Number", "HIP 78855"},
        {"Smithsonian Astrophysical Observation", "SAO 226495"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.45609152),
        dec: Angle.Degrees(-46.08483167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10121"},
        {"Hipparcos Number", "HIP 7610"},
        {"Fundamental Katalog 5th Edition", "FK5 2111"},
        {"Geneva Identification System", "GEN# +1.00010121"},
        {"Smithsonian Astrophysical Observation", "SAO 215589"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.51534013),
        dec: Angle.Degrees(-46.08385787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92580"},
        {"Hipparcos Number", "HIP 52245"},
        {"Smithsonian Astrophysical Observation", "SAO 222248"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.11956071),
        dec: Angle.Degrees(-46.08334228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328654"},
        {"Hipparcos Number", "HIP 81684"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.28825747),
        dec: Angle.Degrees(-46.08022824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215572"},
        {"Hipparcos Number", "HIP 112464"},
        {"Smithsonian Astrophysical Observation", "SAO 231292"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.71056923),
        dec: Angle.Degrees(-46.07749195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94519"},
        {"Hipparcos Number", "HIP 53293"},
        {"Smithsonian Astrophysical Observation", "SAO 222406"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.49326728),
        dec: Angle.Degrees(-46.07742408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103175"},
        {"Hipparcos Number", "HIP 57925"},
        {"Smithsonian Astrophysical Observation", "SAO 223081"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19651401),
        dec: Angle.Degrees(-46.07610569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156995"},
        {"Hipparcos Number", "HIP 85055"},
        {"Smithsonian Astrophysical Observation", "SAO 227883"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73999647),
        dec: Angle.Degrees(-46.07536697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83311"},
        {"Hipparcos Number", "HIP 47121"},
        {"Smithsonian Astrophysical Observation", "SAO 221331"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.03363555),
        dec: Angle.Degrees(-46.07531088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22827"},
        {"Hipparcos Number", "HIP 16951"},
        {"Smithsonian Astrophysical Observation", "SAO 216417"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.52117789),
        dec: Angle.Degrees(-46.07525991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213083"},
        {"Hipparcos Number", "HIP 111052"},
        {"Smithsonian Astrophysical Observation", "SAO 231163"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46586165),
        dec: Angle.Degrees(-46.07481294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167323"},
        {"Hipparcos Number", "HIP 89585"},
        {"Smithsonian Astrophysical Observation", "SAO 228865"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.21611373),
        dec: Angle.Degrees(-46.07415723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150421"},
        {"Hipparcos Number", "HIP 81847"},
        {"Geneva Identification System", "GEN# +1.00150421"},
        {"Smithsonian Astrophysical Observation", "SAO 227092"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.76485909),
        dec: Angle.Degrees(-46.07028333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102703"},
        {"Hipparcos Number", "HIP 57657"},
        {"Geneva Identification System", "GEN# +1.00102703J"},
        {"Renson", "Renson 29640"},
        {"Smithsonian Astrophysical Observation", "SAO 223042"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.36625561),
        dec: Angle.Degrees(-46.06753714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203934"},
        {"Hipparcos Number", "HIP 105879"},
        {"Geneva Identification System", "GEN# +1.00203934"},
        {"Smithsonian Astrophysical Observation", "SAO 230687"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.65486126),
        dec: Angle.Degrees(-46.06699179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134311"},
        {"Hipparcos Number", "HIP 74274"},
        {"Smithsonian Astrophysical Observation", "SAO 225509"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.69491413),
        dec: Angle.Degrees(-46.06687346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329137"},
        {"Hipparcos Number", "HIP 82550"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.10307869),
        dec: Angle.Degrees(-46.06682338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119985"},
        {"Hipparcos Number", "HIP 67305"},
        {"Geneva Identification System", "GEN# +1.00119985"},
        {"Smithsonian Astrophysical Observation", "SAO 224427"},
        {"Wilson Evans Batten Catalogue", "WEB 11845"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.91347333),
        dec: Angle.Degrees(-46.06348590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215801"},
        {"Hipparcos Number", "HIP 112613"},
        {"Geneva Identification System", "GEN# +1.00215801"},
        {"Smithsonian Astrophysical Observation", "SAO 231306"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.12249424),
        dec: Angle.Degrees(-46.06329558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -305.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102200"},
        {"Hipparcos Number", "HIP 57360"},
        {"Geneva Identification System", "GEN# +1.00102200"},
        {"Smithsonian Astrophysical Observation", "SAO 223001"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.39243514),
        dec: Angle.Degrees(-46.06261825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202389"},
        {"Hipparcos Number", "HIP 105062"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.24857194),
        dec: Angle.Degrees(-46.06213974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70220"},
        {"Hipparcos Number", "HIP 40731"},
        {"Smithsonian Astrophysical Observation", "SAO 219773"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.69661281),
        dec: Angle.Degrees(-46.05957346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96083"},
        {"Hipparcos Number", "HIP 54112"},
        {"Smithsonian Astrophysical Observation", "SAO 222535"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.08741869),
        dec: Angle.Degrees(-46.05830299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125238"},
        {"Hipparcos Number", "HIP 69996"},
        {"Celescope Catalog", "CEL 4311"},
        {"Geneva Identification System", "GEN# +1.00125238"},
        {"Smithsonian Astrophysical Observation", "SAO 224833"},
        {"Wilson Evans Batten Catalogue", "WEB 12172"},
    },
    visualMagnitude: 3.55,
    bvColour: -0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.85096972),
        dec: Angle.Degrees(-46.05808391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11065"},
        {"Hipparcos Number", "HIP 8355"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.92261638),
        dec: Angle.Degrees(-46.05765101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36735"},
        {"Hipparcos Number", "HIP 25882"},
        {"Smithsonian Astrophysical Observation", "SAO 217381"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.88144959),
        dec: Angle.Degrees(-46.05477021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194250"},
        {"Hipparcos Number", "HIP 100810"},
        {"Smithsonian Astrophysical Observation", "SAO 230201"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.60774353),
        dec: Angle.Degrees(-46.05341474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218975"},
        {"Hipparcos Number", "HIP 114592"},
        {"Smithsonian Astrophysical Observation", "SAO 231488"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.21577391),
        dec: Angle.Degrees(-46.04839981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
