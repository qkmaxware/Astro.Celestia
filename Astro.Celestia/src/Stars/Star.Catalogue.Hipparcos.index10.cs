using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_10() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83679"},
        {"Hipparcos Number", "HIP 47263"},
        {"Geneva Identification System", "GEN# +1.00083679"},
        {"Smithsonian Astrophysical Observation", "SAO 237169"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.50100508),
        dec: Angle.Degrees(-59.39938672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199052"},
        {"Hipparcos Number", "HIP 103424"},
        {"Geneva Identification System", "GEN# +1.00199052"},
        {"Smithsonian Astrophysical Observation", "SAO 246803"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.31107586),
        dec: Angle.Degrees(-59.39931759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106309"},
        {"Hipparcos Number", "HIP 59653"},
        {"Celescope Catalog", "CEL 4071"},
        {"Geneva Identification System", "GEN# +1.00106309"},
        {"Smithsonian Astrophysical Observation", "SAO 239772"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.50743150),
        dec: Angle.Degrees(-59.39690362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157101"},
        {"Hipparcos Number", "HIP 85225"},
        {"Smithsonian Astrophysical Observation", "SAO 244710"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.22215916),
        dec: Angle.Degrees(-59.39619511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17502"},
        {"Hipparcos Number", "HIP 12904"},
        {"Smithsonian Astrophysical Observation", "SAO 232887"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.47286941),
        dec: Angle.Degrees(-59.39442937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54506"},
        {"Hipparcos Number", "HIP 34186"},
        {"Smithsonian Astrophysical Observation", "SAO 234917"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34181408),
        dec: Angle.Degrees(-59.39126290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12817"},
        {"Hipparcos Number", "HIP 9628"},
        {"Smithsonian Astrophysical Observation", "SAO 232615"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.93127025),
        dec: Angle.Degrees(-59.38873235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161381"},
        {"Hipparcos Number", "HIP 87203"},
        {"Smithsonian Astrophysical Observation", "SAO 245047"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.24115072),
        dec: Angle.Degrees(-59.38618486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94259"},
        {"Hipparcos Number", "HIP 53083"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.89906123),
        dec: Angle.Degrees(-59.38501029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64184"},
        {"Hipparcos Number", "HIP 38179"},
        {"Geneva Identification System", "GEN# +1.00064184"},
        {"Smithsonian Astrophysical Observation", "SAO 235545"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.35958270),
        dec: Angle.Degrees(-59.38031207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 306.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125072"},
        {"Hipparcos Number", "HIP 69972"},
        {"Cincinnati Publication", "Ci 20 845"},
        {"Geneva Identification System", "GEN# +1.00125072"},
        {"Smithsonian Astrophysical Observation", "SAO 241627"},
        {"Wilson Evans Batten Catalogue", "WEB 12169"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77231374),
        dec: Angle.Degrees(-59.37706815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -454.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -810.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302719"},
        {"Hipparcos Number", "HIP 50615"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.08490995),
        dec: Angle.Degrees(-59.37662765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189124"},
        {"Hipparcos Number", "HIP 98608"},
        {"Fundamental Katalog 5th Edition", "FK5 3598"},
        {"Geneva Identification System", "GEN# +1.00189124"},
        {"Smithsonian Astrophysical Observation", "SAO 246389"},
        {"Wilson Evans Batten Catalogue", "WEB 17435"},
    },
    visualMagnitude: 4.95,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43634274),
        dec: Angle.Degrees(-59.37582804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19818"},
        {"Hipparcos Number", "HIP 14595"},
        {"Geneva Identification System", "GEN# +1.00019818"},
        {"Smithsonian Astrophysical Observation", "SAO 233006"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10869014),
        dec: Angle.Degrees(-59.37376200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124084"},
        {"Hipparcos Number", "HIP 69456"},
        {"Smithsonian Astrophysical Observation", "SAO 241537"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30415773),
        dec: Angle.Degrees(-59.37244961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121228"},
        {"Hipparcos Number", "HIP 68034"},
        {"Geneva Identification System", "GEN# +1.00121228"},
        {"Smithsonian Astrophysical Observation", "SAO 241302"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.96802473),
        dec: Angle.Degrees(-59.37123400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218606"},
        {"Hipparcos Number", "HIP 114412"},
        {"Smithsonian Astrophysical Observation", "SAO 247764"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.56533873),
        dec: Angle.Degrees(-59.36961969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120343"},
        {"Hipparcos Number", "HIP 67552"},
        {"Geneva Identification System", "GEN# +1.00120343"},
        {"Smithsonian Astrophysical Observation", "SAO 241210"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.63044106),
        dec: Angle.Degrees(-59.36694526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124152"},
        {"Hipparcos Number", "HIP 69496"},
        {"Geneva Identification System", "GEN# +1.00124152"},
        {"Smithsonian Astrophysical Observation", "SAO 241546"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42332901),
        dec: Angle.Degrees(-59.36380370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203970"},
        {"Hipparcos Number", "HIP 105976"},
        {"Geneva Identification System", "GEN# +1.00203970"},
        {"Smithsonian Astrophysical Observation", "SAO 247035"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.94655961),
        dec: Angle.Degrees(-59.36345529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216129"},
        {"Hipparcos Number", "HIP 112869"},
        {"Smithsonian Astrophysical Observation", "SAO 247621"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.85680276),
        dec: Angle.Degrees(-59.35942168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89445"},
        {"Hipparcos Number", "HIP 50416"},
        {"Geneva Identification System", "GEN# +1.00089445"},
        {"Smithsonian Astrophysical Observation", "SAO 237883"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.40992799),
        dec: Angle.Degrees(-59.35488284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156856"},
        {"Hipparcos Number", "HIP 85101"},
        {"Smithsonian Astrophysical Observation", "SAO 244690"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.88854910),
        dec: Angle.Degrees(-59.35404098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102836"},
        {"Hipparcos Number", "HIP 57718"},
        {"Geneva Identification System", "GEN# +1.00102836"},
        {"Smithsonian Astrophysical Observation", "SAO 239416"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.55244197),
        dec: Angle.Degrees(-59.35364696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99467"},
        {"Hipparcos Number", "HIP 55801"},
        {"Celescope Catalog", "CEL 3900"},
        {"Geneva Identification System", "GEN# +1.00099467"},
        {"Smithsonian Astrophysical Observation", "SAO 239060"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.50582159),
        dec: Angle.Degrees(-59.35286733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84929"},
        {"Hipparcos Number", "HIP 47962"},
        {"Geneva Identification System", "GEN# +1.00084929"},
        {"Smithsonian Astrophysical Observation", "SAO 237332"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.61041081),
        dec: Angle.Degrees(-59.35269848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131644"},
        {"Hipparcos Number", "HIP 73179"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.34747084),
        dec: Angle.Degrees(-59.35121185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208152"},
        {"Hipparcos Number", "HIP 108288"},
        {"Geneva Identification System", "GEN# +1.00208152"},
        {"Smithsonian Astrophysical Observation", "SAO 247231"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.08427901),
        dec: Angle.Degrees(-59.35107517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90912"},
        {"Hipparcos Number", "HIP 51262"},
        {"Geneva Identification System", "GEN# +1.00090912"},
        {"Wilson Evans Batten Catalogue", "WEB 9367"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.07022226),
        dec: Angle.Degrees(-59.35019343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12191"},
        {"Hipparcos Number", "HIP 9138"},
        {"Smithsonian Astrophysical Observation", "SAO 232586"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.44515626),
        dec: Angle.Degrees(-59.34803195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108291"},
    },
    visualMagnitude: 10.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)56, 21.0100),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)20, 39.000)
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
    primaryId: "HIP 80365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80365"},
        {"Geneva Identification System", "GEN# -0.05906719"},
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.07779870),
        dec: Angle.Degrees(-59.34403486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51210"},
        {"Hipparcos Number", "HIP 33012"},
        {"Geneva Identification System", "GEN# +1.00051210"},
        {"Renson", "Renson 14120"},
        {"Smithsonian Astrophysical Observation", "SAO 234764"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.18933679),
        dec: Angle.Degrees(-59.34128772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193547"},
        {"Hipparcos Number", "HIP 100576"},
        {"Smithsonian Astrophysical Observation", "SAO 246556"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.93807786),
        dec: Angle.Degrees(-59.34124602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160906"},
        {"Hipparcos Number", "HIP 86958"},
        {"Smithsonian Astrophysical Observation", "SAO 245005"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.54378840),
        dec: Angle.Degrees(-59.33988587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8844"},
        {"Hipparcos Number", "HIP 6684"},
        {"Geneva Identification System", "GEN# +1.00008844"},
        {"Smithsonian Astrophysical Observation", "SAO 232422"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.43388582),
        dec: Angle.Degrees(-59.33461773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94142"},
        {"Hipparcos Number", "HIP 53017"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.69585799),
        dec: Angle.Degrees(-59.33329675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177569"},
        {"Hipparcos Number", "HIP 94047"},
        {"Geneva Identification System", "GEN# +1.00177569"},
        {"Smithsonian Astrophysical Observation", "SAO 245935"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.20517999),
        dec: Angle.Degrees(-59.33222531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171086"},
        {"Hipparcos Number", "HIP 91223"},
        {"Smithsonian Astrophysical Observation", "SAO 245576"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.12217856),
        dec: Angle.Degrees(-59.33059232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152923"},
        {"Hipparcos Number", "HIP 83174"},
        {"Geneva Identification System", "GEN# +1.00152923"},
        {"Smithsonian Astrophysical Observation", "SAO 244329"},
        {"Wilson Evans Batten Catalogue", "WEB 14056"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.97825595),
        dec: Angle.Degrees(-59.32943378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93943"},
        {"Hipparcos Number", "HIP 52922"},
        {"Celescope Catalog", "CEL 3728"},
        {"Geneva Identification System", "GEN# +1.00093943"},
        {"Smithsonian Astrophysical Observation", "SAO 238514"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.35190190),
        dec: Angle.Degrees(-59.32377833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75323"},
        {"Geneva Identification System", "GEN# +1.00136415"},
        {"Smithsonian Astrophysical Observation", "SAO 242463"},
    },
    visualMagnitude: 4.48,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.84440733),
        dec: Angle.Degrees(-59.32069839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209788"},
        {"Hipparcos Number", "HIP 109228"},
        {"Smithsonian Astrophysical Observation", "SAO 247314"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.91606422),
        dec: Angle.Degrees(-59.31991505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225203"},
        {"Hipparcos Number", "HIP 339"},
        {"Geneva Identification System", "GEN# +1.00225203"},
        {"Smithsonian Astrophysical Observation", "SAO 231914"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06871389),
        dec: Angle.Degrees(-59.31518062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9772"},
        {"Hipparcos Number", "HIP 7305"},
        {"Smithsonian Astrophysical Observation", "SAO 232464"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.51399986),
        dec: Angle.Degrees(-59.31246225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201867"},
        {"Hipparcos Number", "HIP 104901"},
        {"Smithsonian Astrophysical Observation", "SAO 246922"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.73626991),
        dec: Angle.Degrees(-59.31169988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49494"},
        {"Hipparcos Number", "HIP 32323"},
        {"Smithsonian Astrophysical Observation", "SAO 234691"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.21698202),
        dec: Angle.Degrees(-59.30387291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27442A"},
        {"Henry Draper 2", "HD 27442"},
        {"Hipparcos Number", "HIP 19921"},
        {"Geneva Identification System", "GEN# +1.00027442"},
        {"Smithsonian Astrophysical Observation", "SAO 233463"},
        {"Wilson Evans Batten Catalogue", "WEB 3804"},
    },
    visualMagnitude: 4.44,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.12118133),
        dec: Angle.Degrees(-59.30174841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171675"},
        {"Hipparcos Number", "HIP 91516"},
        {"Smithsonian Astrophysical Observation", "SAO 245611"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95277646),
        dec: Angle.Degrees(-59.30167150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16026"},
        {"Smithsonian Astrophysical Observation", "SAO 233118"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.59141146),
        dec: Angle.Degrees(-59.29877182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211536"},
        {"Hipparcos Number", "HIP 110206"},
        {"Smithsonian Astrophysical Observation", "SAO 247404"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.85541133),
        dec: Angle.Degrees(-59.29837506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62850"},
        {"Hipparcos Number", "HIP 37563"},
        {"Geneva Identification System", "GEN# +1.00062850"},
        {"Smithsonian Astrophysical Observation", "SAO 235436"},
        {"Wilson Evans Batten Catalogue", "WEB 7429"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.65051517),
        dec: Angle.Degrees(-59.29781346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 157.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35523"},
        {"Smithsonian Astrophysical Observation", "SAO 235109"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98160067),
        dec: Angle.Degrees(-59.29493324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210798"},
        {"Hipparcos Number", "HIP 109824"},
        {"Smithsonian Astrophysical Observation", "SAO 247370"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.65937613),
        dec: Angle.Degrees(-59.29213977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169883"},
        {"Hipparcos Number", "HIP 90714"},
        {"Smithsonian Astrophysical Observation", "SAO 245515"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.62644537),
        dec: Angle.Degrees(-59.29208029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107126"},
        {"Hipparcos Number", "HIP 60090"},
        {"Geneva Identification System", "GEN# +1.00107126"},
        {"Smithsonian Astrophysical Observation", "SAO 239845"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.83709152),
        dec: Angle.Degrees(-59.29124178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98170"},
        {"Geneva Identification System", "GEN# +6.20145047"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.25426906),
        dec: Angle.Degrees(-59.29084362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3955"},
        {"Hipparcos Number", "HIP 3263"},
        {"Smithsonian Astrophysical Observation", "SAO 232151"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.38247980),
        dec: Angle.Degrees(-59.28983394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13852"},
        {"Hipparcos Number", "HIP 10308"},
        {"Smithsonian Astrophysical Observation", "SAO 232676"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.20813165),
        dec: Angle.Degrees(-59.28942984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48368"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.90792048),
        dec: Angle.Degrees(-59.28828840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209941"},
        {"Hipparcos Number", "HIP 109308"},
        {"Smithsonian Astrophysical Observation", "SAO 247325"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.18382527),
        dec: Angle.Degrees(-59.28522824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85716"},
        {"Hipparcos Number", "HIP 48367"},
        {"Smithsonian Astrophysical Observation", "SAO 237424"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.90686723),
        dec: Angle.Degrees(-59.28508075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21596"},
        {"Hipparcos Number", "HIP 16013"},
        {"Smithsonian Astrophysical Observation", "SAO 233116"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54705978),
        dec: Angle.Degrees(-59.28500364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98159"},
        {"Geneva Identification System", "GEN# +6.20145046"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.23078787),
        dec: Angle.Degrees(-59.28420213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113557"},
        {"Hipparcos Number", "HIP 63880"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.37364490),
        dec: Angle.Degrees(-59.28077831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 482"},
        {"Hipparcos Number", "HIP 736"},
        {"Smithsonian Astrophysical Observation", "SAO 231944"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26412852),
        dec: Angle.Degrees(-59.28059246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152479"},
        {"Hipparcos Number", "HIP 82950"},
        {"Smithsonian Astrophysical Observation", "SAO 244289"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.26157859),
        dec: Angle.Degrees(-59.27909062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123335"},
        {"Hipparcos Number", "HIP 69122"},
        {"Geneva Identification System", "GEN# +1.00123335"},
        {"Renson", "Renson 35356"},
        {"Smithsonian Astrophysical Observation", "SAO 241478"},
        {"Wilson Evans Batten Catalogue", "WEB 12066"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.23444395),
        dec: Angle.Degrees(-59.27667031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45556",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aspidiske"},
        {"Henry Draper", "HD 80404"},
        {"Hipparcos Number", "HIP 45556"},
        {"Celescope Catalog", "CEL 3256"},
        {"Fundamental Katalog 5th Edition", "FK5 351"},
        {"Geneva Identification System", "GEN# +1.00080404"},
        {"Smithsonian Astrophysical Observation", "SAO 236808"},
        {"Wilson Evans Batten Catalogue", "WEB 8659"},
    },
    visualMagnitude: 2.21,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.27261834),
        dec: Angle.Degrees(-59.27526115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86909"},
        {"Hipparcos Number", "HIP 48996"},
        {"Smithsonian Astrophysical Observation", "SAO 237574"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.93974667),
        dec: Angle.Degrees(-59.27397640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198943"},
        {"Hipparcos Number", "HIP 103361"},
        {"Smithsonian Astrophysical Observation", "SAO 246799"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.11094868),
        dec: Angle.Degrees(-59.27361705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137839"},
        {"Hipparcos Number", "HIP 75990"},
        {"Smithsonian Astrophysical Observation", "SAO 242639"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.78266701),
        dec: Angle.Degrees(-59.27343444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102773"},
        {"Hipparcos Number", "HIP 57677"},
        {"Geneva Identification System", "GEN# +1.00102773"},
        {"Smithsonian Astrophysical Observation", "SAO 239406"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43614392),
        dec: Angle.Degrees(-59.27184838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302483"},
        {"Hipparcos Number", "HIP 48993"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.93324557),
        dec: Angle.Degrees(-59.27123417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133942"},
        {"Hipparcos Number", "HIP 74204"},
        {"Geneva Identification System", "GEN# +1.00133942"},
        {"Smithsonian Astrophysical Observation", "SAO 242265"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.45380775),
        dec: Angle.Degrees(-59.27043834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118832"},
        {"Hipparcos Number", "HIP 66747"},
    },
    visualMagnitude: 9.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)40, 53.7000),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)15, 59.700)
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
    primaryId: "HIP 86454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159729"},
        {"Hipparcos Number", "HIP 86454"},
        {"Smithsonian Astrophysical Observation", "SAO 244919"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98073752),
        dec: Angle.Degrees(-59.26605976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22665"},
        {"Hipparcos Number", "HIP 16756"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.89058307),
        dec: Angle.Degrees(-59.26463449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47028"},
        {"Hipparcos Number", "HIP 31198"},
        {"Smithsonian Astrophysical Observation", "SAO 234571"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.17944525),
        dec: Angle.Degrees(-59.26399082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186810"},
        {"Hipparcos Number", "HIP 97581"},
        {"Geneva Identification System", "GEN# +1.00186810"},
        {"Smithsonian Astrophysical Observation", "SAO 246284"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.51370005),
        dec: Angle.Degrees(-59.26398033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149318"},
        {"Hipparcos Number", "HIP 81397"},
        {"Smithsonian Astrophysical Observation", "SAO 243992"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.35581821),
        dec: Angle.Degrees(-59.26285230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92399"},
        {"Hipparcos Number", "HIP 52103"},
        {"Celescope Catalog", "CEL 3610"},
        {"Geneva Identification System", "GEN# +1.00092399"},
        {"Geneva Identification System 2", "GEN# +5.40990021"},
        {"Smithsonian Astrophysical Observation", "SAO 238296"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68914323),
        dec: Angle.Degrees(-59.26241970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57446"},
        {"Hipparcos Number", "HIP 35313"},
        {"Renson", "Renson 15700"},
        {"Smithsonian Astrophysical Observation", "SAO 235079"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.41314817),
        dec: Angle.Degrees(-59.26219505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155367"},
        {"Hipparcos Number", "HIP 84354"},
        {"Geneva Identification System", "GEN# +1.00155367"},
        {"Smithsonian Astrophysical Observation", "SAO 244545"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.68761448),
        dec: Angle.Degrees(-59.26140367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101764"},
        {"Hipparcos Number", "HIP 57093"},
        {"Smithsonian Astrophysical Observation", "SAO 239305"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.56188520),
        dec: Angle.Degrees(-59.26001387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109277"},
        {"Hipparcos Number", "HIP 61332"},
        {"Geneva Identification System", "GEN# +1.00109277"},
        {"Smithsonian Astrophysical Observation", "SAO 240062"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.50581638),
        dec: Angle.Degrees(-59.25788775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103513"},
        {"Hipparcos Number", "HIP 58107"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.75570306),
        dec: Angle.Degrees(-59.25377736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104900"},
        {"Hipparcos Number", "HIP 58901"},
        {"Geneva Identification System", "GEN# +1.00104900"},
        {"Smithsonian Astrophysical Observation", "SAO 239644"},
        {"Wilson Evans Batten Catalogue", "WEB 10489"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.18872296),
        dec: Angle.Degrees(-59.25324770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98782"},
        {"Hipparcos Number", "HIP 55451"},
        {"Smithsonian Astrophysical Observation", "SAO 238991"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.35277090),
        dec: Angle.Degrees(-59.25324010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88056"},
        {"Hipparcos Number", "HIP 49592"},
        {"Geneva Identification System", "GEN# +1.00088056"},
        {"Smithsonian Astrophysical Observation", "SAO 237712"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.85659298),
        dec: Angle.Degrees(-59.25208587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24594"},
        {"Hipparcos Number", "HIP 18041"},
        {"Smithsonian Astrophysical Observation", "SAO 233302"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.84333206),
        dec: Angle.Degrees(-59.25058369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68968"},
        {"Hipparcos Number", "HIP 40116"},
        {"Geneva Identification System", "GEN# +1.00068968"},
        {"Smithsonian Astrophysical Observation", "SAO 235802"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.90360079),
        dec: Angle.Degrees(-59.24935007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67535"},
        {"Hipparcos Number", "HIP 39577"},
        {"Geneva Identification System", "GEN# +1.00067535"},
        {"Smithsonian Astrophysical Observation", "SAO 235740"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.30462947),
        dec: Angle.Degrees(-59.24507728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172583"},
        {"Hipparcos Number", "HIP 91964"},
        {"Renson", "Renson 48350"},
        {"Smithsonian Astrophysical Observation", "SAO 245665"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.17352709),
        dec: Angle.Degrees(-59.24425744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223589"},
        {"Hipparcos Number", "HIP 117600"},
        {"Smithsonian Astrophysical Observation", "SAO 248039"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.74151372),
        dec: Angle.Degrees(-59.24319383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126343"},
        {"Hipparcos Number", "HIP 70645"},
        {"Smithsonian Astrophysical Observation", "SAO 241714"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74494229),
        dec: Angle.Degrees(-59.23763306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98340"},
        {"Hipparcos Number", "HIP 55181"},
        {"Geneva Identification System", "GEN# +1.00098340"},
        {"Renson", "Renson 28350"},
        {"Smithsonian Astrophysical Observation", "SAO 238948"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.47384131),
        dec: Angle.Degrees(-59.23641648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119283"},
        {"Hipparcos Number", "HIP 67008"},
        {"Smithsonian Astrophysical Observation", "SAO 241114"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.98908182),
        dec: Angle.Degrees(-59.23596153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119312"},
        {"Hipparcos Number", "HIP 67014"},
        {"Smithsonian Astrophysical Observation", "SAO 241117"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.00710726),
        dec: Angle.Degrees(-59.23593637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71698"},
        {"Hipparcos Number", "HIP 41309"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.42221125),
        dec: Angle.Degrees(-59.23501117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197827"},
        {"Hipparcos Number", "HIP 102719"},
        {"Smithsonian Astrophysical Observation", "SAO 246736"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.21097684),
        dec: Angle.Degrees(-59.23435839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211056"},
        {"Hipparcos Number", "HIP 109957"},
        {"Smithsonian Astrophysical Observation", "SAO 247384"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.05649184),
        dec: Angle.Degrees(-59.23413939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194161"},
        {"Hipparcos Number", "HIP 100860"},
        {"Smithsonian Astrophysical Observation", "SAO 246583"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.76240368),
        dec: Angle.Degrees(-59.23403244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189912"},
        {"Hipparcos Number", "HIP 98973"},
        {"Smithsonian Astrophysical Observation", "SAO 246426"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.40853535),
        dec: Angle.Degrees(-59.23083571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212896"},
        {"Hipparcos Number", "HIP 110973"},
        {"Geneva Identification System", "GEN# +1.00212896"},
        {"Smithsonian Astrophysical Observation", "SAO 247461"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.25586830),
        dec: Angle.Degrees(-59.23065315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83183"},
        {"Hipparcos Number", "HIP 46974"},
        {"Celescope Catalog", "CEL 3332"},
        {"Geneva Identification System", "GEN# +1.00083183"},
        {"Smithsonian Astrophysical Observation", "SAO 237117"},
        {"Wilson Evans Batten Catalogue", "WEB 8854"},
    },
    visualMagnitude: 4.08,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.61109601),
        dec: Angle.Degrees(-59.22976797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62338"},
        {"Hipparcos Number", "HIP 37358"},
        {"Smithsonian Astrophysical Observation", "SAO 235409"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.02671027),
        dec: Angle.Degrees(-59.22975955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82404"},
        {"Hipparcos Number", "HIP 46531"},
        {"Smithsonian Astrophysical Observation", "SAO 237037"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.35858733),
        dec: Angle.Degrees(-59.22960746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77002"},
        {"Hipparcos Number", "HIP 43937"},
        {"Celescope Catalog", "CEL 3106"},
        {"Fundamental Katalog 5th Edition", "FK5 1233"},
        {"Geneva Identification System", "GEN# +1.00077002A"},
        {"Smithsonian Astrophysical Observation", "SAO 236436"},
        {"Wilson Evans Batten Catalogue", "WEB 8449"},
    },
    visualMagnitude: 4.93,
    bvColour: -0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.24344613),
        dec: Angle.Degrees(-59.22935883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102599"},
        {"Hipparcos Number", "HIP 57596"},
        {"Geneva Identification System", "GEN# +1.00102599"},
        {"Smithsonian Astrophysical Observation", "SAO 239385"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.11180984),
        dec: Angle.Degrees(-59.22852718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118870"},
        {"Hipparcos Number", "HIP 66772"},
        {"Smithsonian Astrophysical Observation", "SAO 241067"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.29061851),
        dec: Angle.Degrees(-59.22774740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72698"},
        {"Hipparcos Number", "HIP 41793"},
        {"Geneva Identification System", "GEN# +1.00072698"},
        {"Smithsonian Astrophysical Observation", "SAO 236056"},
        {"Wilson Evans Batten Catalogue", "WEB 8049"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.82001633),
        dec: Angle.Degrees(-59.22706814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90910"},
        {"Hipparcos Number", "HIP 51256"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.04860716),
        dec: Angle.Degrees(-59.22647623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53491"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.14010847),
        dec: Angle.Degrees(-59.22609231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22204"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.62991244),
        dec: Angle.Degrees(-59.22516063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202743"},
        {"Hipparcos Number", "HIP 105358"},
        {"Smithsonian Astrophysical Observation", "SAO 246969"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.10751348),
        dec: Angle.Degrees(-59.22414856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87630"},
        {"Hipparcos Number", "HIP 49341"},
        {"Smithsonian Astrophysical Observation", "SAO 237666"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.09214988),
        dec: Angle.Degrees(-59.22414698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182970"},
        {"Hipparcos Number", "HIP 95940"},
        {"Smithsonian Astrophysical Observation", "SAO 246129"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.66771778),
        dec: Angle.Degrees(-59.22153898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136826"},
        {"Hipparcos Number", "HIP 75512"},
        {"Smithsonian Astrophysical Observation", "SAO 242494"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.40187581),
        dec: Angle.Degrees(-59.22150388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20013"},
        {"Hipparcos Number", "HIP 14717"},
        {"Smithsonian Astrophysical Observation", "SAO 233018"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.53106644),
        dec: Angle.Degrees(-59.21986813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14551"},
        {"Hipparcos Number", "HIP 10790"},
        {"Smithsonian Astrophysical Observation", "SAO 232707"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.73049971),
        dec: Angle.Degrees(-59.21973763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155976"},
        {"Hipparcos Number", "HIP 84662"},
        {"Smithsonian Astrophysical Observation", "SAO 244597"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.61572996),
        dec: Angle.Degrees(-59.21948801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44105"},
        {"Hipparcos Number", "HIP 29783"},
        {"Geneva Identification System", "GEN# +1.00044105"},
        {"Smithsonian Astrophysical Observation", "SAO 234417"},
        {"Wilson Evans Batten Catalogue", "WEB 5879"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.06322149),
        dec: Angle.Degrees(-59.21875056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92964"},
        {"Hipparcos Number", "HIP 52405"},
        {"Celescope Catalog", "CEL 3658"},
        {"Geneva Identification System", "GEN# +1.00092964"},
        {"Smithsonian Astrophysical Observation", "SAO 238379"},
        {"Wilson Evans Batten Catalogue", "WEB 9537"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.66905761),
        dec: Angle.Degrees(-59.21576469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72519"},
        {"Hipparcos Number", "HIP 41720"},
        {"Smithsonian Astrophysical Observation", "SAO 236042"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.60707254),
        dec: Angle.Degrees(-59.21407632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143754"},
        {"Hipparcos Number", "HIP 78825"},
        {"Smithsonian Astrophysical Observation", "SAO 243307"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.36660221),
        dec: Angle.Degrees(-59.21399533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157081"},
        {"Hipparcos Number", "HIP 85216"},
        {"Smithsonian Astrophysical Observation", "SAO 244705"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.19109085),
        dec: Angle.Degrees(-59.21363135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44120"},
        {"Hipparcos Number", "HIP 29788"},
        {"Smithsonian Astrophysical Observation", "SAO 234418"},
        {"Wilson Evans Batten Catalogue", "WEB 5883"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.07848864),
        dec: Angle.Degrees(-59.21273358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66340"},
        {"Hipparcos Number", "HIP 39088"},
        {"Geneva Identification System", "GEN# +1.00066340"},
        {"Smithsonian Astrophysical Observation", "SAO 235664"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.94848095),
        dec: Angle.Degrees(-59.21209683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2385"},
        {"Hipparcos Number", "HIP 2160"},
        {"Smithsonian Astrophysical Observation", "SAO 232046"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81188324),
        dec: Angle.Degrees(-59.21204346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164427"},
        {"Hipparcos Number", "HIP 88531"},
        {"Geneva Identification System", "GEN# +1.00164427"},
        {"Smithsonian Astrophysical Observation", "SAO 245217"},
        {"Wilson Evans Batten Catalogue", "WEB 14986"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.17842690),
        dec: Angle.Degrees(-59.20944895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209018"},
        {"Hipparcos Number", "HIP 108781"},
        {"Geneva Identification System", "GEN# +1.00209018"},
        {"Smithsonian Astrophysical Observation", "SAO 247278"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.53527153),
        dec: Angle.Degrees(-59.20804498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108953"},
        {"Hipparcos Number", "HIP 61123"},
        {"Geneva Identification System", "GEN# +1.00108953"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.89776779),
        dec: Angle.Degrees(-59.20798237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98329"},
        {"Hipparcos Number", "HIP 55175"},
        {"Celescope Catalog", "CEL 3874"},
        {"Geneva Identification System", "GEN# +1.00098329"},
        {"Smithsonian Astrophysical Observation", "SAO 238946"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.44930406),
        dec: Angle.Degrees(-59.20776727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139112"},
        {"Hipparcos Number", "HIP 76661"},
        {"Geneva Identification System", "GEN# +1.00139112"},
        {"Smithsonian Astrophysical Observation", "SAO 242795"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.82263125),
        dec: Angle.Degrees(-59.20683454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78568"},
        {"Hipparcos Number", "HIP 44684"},
        {"Celescope Catalog", "CEL 3187"},
        {"Geneva Identification System", "GEN# +1.00078568"},
        {"Renson", "Renson 22260"},
        {"Smithsonian Astrophysical Observation", "SAO 236610"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.59345505),
        dec: Angle.Degrees(-59.20644851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83336"},
        {"Hipparcos Number", "HIP 47057"},
        {"Smithsonian Astrophysical Observation", "SAO 237128"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.85312099),
        dec: Angle.Degrees(-59.20547597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131684"},
        {"Hipparcos Number", "HIP 73198"},
        {"Geneva Identification System", "GEN# +1.00131684"},
        {"Smithsonian Astrophysical Observation", "SAO 242130"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.39454371),
        dec: Angle.Degrees(-59.20397465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223702"},
        {"Hipparcos Number", "HIP 117688"},
        {"Smithsonian Astrophysical Observation", "SAO 248044"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.01133596),
        dec: Angle.Degrees(-59.20153156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7212"},
        {"Hipparcos Number", "HIP 5561"},
        {"Geneva Identification System", "GEN# +1.00007212"},
        {"Smithsonian Astrophysical Observation", "SAO 232331"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.82803266),
        dec: Angle.Degrees(-59.20009120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40566"},
        {"Hipparcos Number", "HIP 28052"},
        {"Geneva Identification System", "GEN# +1.00040566"},
        {"Smithsonian Astrophysical Observation", "SAO 234215"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.97976196),
        dec: Angle.Degrees(-59.19902451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60931"},
        {"Hipparcos Number", "HIP 36748"},
        {"Smithsonian Astrophysical Observation", "SAO 235299"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.37239724),
        dec: Angle.Degrees(-59.19850646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125256"},
        {"Hipparcos Number", "HIP 70070"},
        {"Geneva Identification System", "GEN# +1.00125256"},
        {"Smithsonian Astrophysical Observation", "SAO 241639"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.08605693),
        dec: Angle.Degrees(-59.19816890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126610"},
        {"Hipparcos Number", "HIP 70798"},
        {"Geneva Identification System", "GEN# +1.00126610"},
        {"Smithsonian Astrophysical Observation", "SAO 241737"},
        {"Wilson Evans Batten Catalogue", "WEB 12263"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.18126718),
        dec: Angle.Degrees(-59.19752972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187835"},
        {"Hipparcos Number", "HIP 98031"},
        {"Smithsonian Astrophysical Observation", "SAO 246334"},
        {"Wilson Evans Batten Catalogue", "WEB 17263"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.80811854),
        dec: Angle.Degrees(-59.19554240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77185"},
        {"Hipparcos Number", "HIP 44055"},
        {"Celescope Catalog", "CEL 3122"},
        {"Geneva Identification System", "GEN# +1.00077185"},
        {"Smithsonian Astrophysical Observation", "SAO 236458"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.57576413),
        dec: Angle.Degrees(-59.19392964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186957"},
        {"Hipparcos Number", "HIP 97646"},
        {"Geneva Identification System", "GEN# +1.00186957"},
        {"Renson", "Renson 51535"},
        {"Smithsonian Astrophysical Observation", "SAO 246293"},
        {"Wilson Evans Batten Catalogue", "WEB 17170"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.68657002),
        dec: Angle.Degrees(-59.19363715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6256"},
        {"Hipparcos Number", "HIP 4873"},
        {"Smithsonian Astrophysical Observation", "SAO 232272"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.66206936),
        dec: Angle.Degrees(-59.19270128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36190"},
        {"Hipparcos Number", "HIP 25425"},
        {"Smithsonian Astrophysical Observation", "SAO 233979"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56351913),
        dec: Angle.Degrees(-59.19242439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196540"},
        {"Hipparcos Number", "HIP 102058"},
        {"Smithsonian Astrophysical Observation", "SAO 246685"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.24007289),
        dec: Angle.Degrees(-59.19059564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92072"},
        {"Hipparcos Number", "HIP 51934"},
        {"Geneva Identification System", "GEN# +5.40990002"},
        {"Smithsonian Astrophysical Observation", "SAO 238247"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.13667349),
        dec: Angle.Degrees(-59.19033475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98596"},
        {"Hipparcos Number", "HIP 55342"},
        {"Celescope Catalog", "CEL 3878"},
        {"Geneva Identification System", "GEN# +1.00098596"},
        {"Smithsonian Astrophysical Observation", "SAO 238975"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.00231616),
        dec: Angle.Degrees(-59.18805188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43709"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.52433285),
        dec: Angle.Degrees(-59.18699296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161954"},
        {"Hipparcos Number", "HIP 87450"},
        {"Smithsonian Astrophysical Observation", "SAO 245076"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.03020319),
        dec: Angle.Degrees(-59.18496991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84536"},
        {"Hipparcos Number", "HIP 47729"},
        {"Smithsonian Astrophysical Observation", "SAO 237271"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.94324358),
        dec: Angle.Degrees(-59.18478993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78802"},
        {"Hipparcos Number", "HIP 44787"},
        {"Smithsonian Astrophysical Observation", "SAO 236634"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.91647310),
        dec: Angle.Degrees(-59.18477551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33390"},
    },
    visualMagnitude: 12.35,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.15593603),
        dec: Angle.Degrees(-59.18436820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 449.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92397"},
        {"Hipparcos Number", "HIP 52102"},
        {"Geneva Identification System", "GEN# +1.00092397A"},
        {"Smithsonian Astrophysical Observation", "SAO 238295"},
        {"Wilson Evans Batten Catalogue", "WEB 9497"},
    },
    visualMagnitude: 4.69,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68755215),
        dec: Angle.Degrees(-59.18299905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106552"},
        {"Hipparcos Number", "HIP 59786"},
        {"Smithsonian Astrophysical Observation", "SAO 239793"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.88757612),
        dec: Angle.Degrees(-59.18293496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64529"},
        {"Hipparcos Number", "HIP 38314"},
        {"Smithsonian Astrophysical Observation", "SAO 235563"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.74671881),
        dec: Angle.Degrees(-59.18065862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92398"},
        {"Hipparcos Number", "HIP 52106"},
        {"Geneva Identification System", "GEN# +1.00092398"},
        {"Smithsonian Astrophysical Observation", "SAO 238297"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.69038956),
        dec: Angle.Degrees(-59.17922913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53921"},
        {"Hipparcos Number", "HIP 34000"},
        {"Geneva Identification System", "GEN# +1.00053921"},
        {"Smithsonian Astrophysical Observation", "SAO 234890"},
        {"Wilson Evans Batten Catalogue", "WEB 6819"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.81295570),
        dec: Angle.Degrees(-59.17813539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164371"},
        {"Hipparcos Number", "HIP 88512"},
        {"Smithsonian Astrophysical Observation", "SAO 245211"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.11146225),
        dec: Angle.Degrees(-59.17790596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143548"},
        {"Hipparcos Number", "HIP 78710"},
        {"Smithsonian Astrophysical Observation", "SAO 243283"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.02584141),
        dec: Angle.Degrees(-59.17617237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83763"},
        {"Hipparcos Number", "HIP 47320"},
        {"Smithsonian Astrophysical Observation", "SAO 237181"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.63143216),
        dec: Angle.Degrees(-59.17525301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222912"},
        {"Hipparcos Number", "HIP 117152"},
        {"Geneva Identification System", "GEN# +1.00222912"},
        {"Smithsonian Astrophysical Observation", "SAO 248005"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.25732424),
        dec: Angle.Degrees(-59.17524335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97913"},
        {"Hipparcos Number", "HIP 54930"},
        {"Celescope Catalog", "CEL 3862"},
        {"Geneva Identification System", "GEN# +1.00097913"},
        {"Smithsonian Astrophysical Observation", "SAO 238900"},
        {"Wilson Evans Batten Catalogue", "WEB 9912"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.72766358),
        dec: Angle.Degrees(-59.17488628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205009"},
        {"Hipparcos Number", "HIP 106531"},
        {"Smithsonian Astrophysical Observation", "SAO 247089"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.64678161),
        dec: Angle.Degrees(-59.17033258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26890"},
        {"Hipparcos Number", "HIP 19579"},
        {"Smithsonian Astrophysical Observation", "SAO 233432"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.93703767),
        dec: Angle.Degrees(-59.16990366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92087"},
        {"Hipparcos Number", "HIP 51940"},
        {"Geneva Identification System", "GEN# +5.40990005"},
        {"Smithsonian Astrophysical Observation", "SAO 238250"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.16633483),
        dec: Angle.Degrees(-59.16796066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187273"},
        {"Hipparcos Number", "HIP 97803"},
        {"Smithsonian Astrophysical Observation", "SAO 246308"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.11480191),
        dec: Angle.Degrees(-59.16757446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70267"},
        {"Hipparcos Number", "HIP 40655"},
        {"Geneva Identification System", "GEN# +1.00070267"},
        {"Smithsonian Astrophysical Observation", "SAO 235872"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.48246427),
        dec: Angle.Degrees(-59.16676267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13011"},
        {"Hipparcos Number", "HIP 9747"},
        {"Smithsonian Astrophysical Observation", "SAO 232630"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34669313),
        dec: Angle.Degrees(-59.16651795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136285"},
        {"Hipparcos Number", "HIP 75252"},
        {"Smithsonian Astrophysical Observation", "SAO 242454"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65253145),
        dec: Angle.Degrees(-59.16632497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27930"},
        {"Hipparcos Number", "HIP 20304"},
        {"Smithsonian Astrophysical Observation", "SAO 233492"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.25984378),
        dec: Angle.Degrees(-59.16401528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9750"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34830122),
        dec: Angle.Degrees(-59.16153766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128382"},
        {"Hipparcos Number", "HIP 71620"},
        {"Smithsonian Astrophysical Observation", "SAO 241871"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.72725862),
        dec: Angle.Degrees(-59.16150928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78206"},
        {"Hipparcos Number", "HIP 44528"},
        {"Celescope Catalog", "CEL 3172"},
        {"Smithsonian Astrophysical Observation", "SAO 236564"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.09170234),
        dec: Angle.Degrees(-59.15691254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88542"},
        {"Hipparcos Number", "HIP 49863"},
        {"Celescope Catalog", "CEL 3458"},
        {"Geneva Identification System", "GEN# +1.00088542"},
        {"Smithsonian Astrophysical Observation", "SAO 237764"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.73254975),
        dec: Angle.Degrees(-59.15437200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44059"},
        {"Hipparcos Number", "HIP 29747"},
        {"Renson", "Renson 11680"},
        {"Smithsonian Astrophysical Observation", "SAO 234415"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.97603205),
        dec: Angle.Degrees(-59.15309090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13668"},
        {"Hipparcos Number", "HIP 10200"},
        {"Smithsonian Astrophysical Observation", "SAO 232665"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.78856416),
        dec: Angle.Degrees(-59.15193216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29447"},
        {"Hipparcos Number", "HIP 21338"},
        {"Smithsonian Astrophysical Observation", "SAO 233577"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68398489),
        dec: Angle.Degrees(-59.15185850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145343"},
        {"Hipparcos Number", "HIP 79525"},
        {"Smithsonian Astrophysical Observation", "SAO 243453"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.42378021),
        dec: Angle.Degrees(-59.15138884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82227"},
        {"Hipparcos Number", "HIP 46456"},
        {"Smithsonian Astrophysical Observation", "SAO 237018"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.11917331),
        dec: Angle.Degrees(-59.14991520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78761"},
        {"Hipparcos Number", "HIP 44764"},
        {"Smithsonian Astrophysical Observation", "SAO 236628"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.85020905),
        dec: Angle.Degrees(-59.14981380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15935"},
        {"Hipparcos Number", "HIP 11727"},
        {"Smithsonian Astrophysical Observation", "SAO 232801"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.84777586),
        dec: Angle.Degrees(-59.14910921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143386"},
        {"Hipparcos Number", "HIP 78645"},
        {"Smithsonian Astrophysical Observation", "SAO 243275"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.81138140),
        dec: Angle.Degrees(-59.14834530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136239"},
        {"Hipparcos Number", "HIP 75224"},
        {"Geneva Identification System", "GEN# +1.00136239"},
        {"Smithsonian Astrophysical Observation", "SAO 242448"},
        {"Wilson Evans Batten Catalogue", "WEB 12830"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.58368095),
        dec: Angle.Degrees(-59.14719888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112078"},
        {"Hipparcos Number", "HIP 63007"},
        {"Celescope Catalog", "CEL 4167"},
        {"Geneva Identification System", "GEN# +1.00112078"},
        {"Smithsonian Astrophysical Observation", "SAO 240368"},
        {"Wilson Evans Batten Catalogue", "WEB 11173"},
    },
    visualMagnitude: 4.62,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.66341683),
        dec: Angle.Degrees(-59.14666538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36493"},
        {"Hipparcos Number", "HIP 25610"},
        {"Smithsonian Astrophysical Observation", "SAO 233990"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.06770300),
        dec: Angle.Degrees(-59.14644393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89740"},
        {"Hipparcos Number", "HIP 50561"},
        {"Celescope Catalog", "CEL 3508"},
        {"Geneva Identification System", "GEN# +1.00089740"},
        {"Smithsonian Astrophysical Observation", "SAO 237922"},
        {"Wilson Evans Batten Catalogue", "WEB 9277"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.91962243),
        dec: Angle.Degrees(-59.14609509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105150"},
        {"Hipparcos Number", "HIP 59045"},
        {"Geneva Identification System", "GEN# +1.00105150"},
        {"Smithsonian Astrophysical Observation", "SAO 239665"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.58270812),
        dec: Angle.Degrees(-59.14463962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213516"},
        {"Hipparcos Number", "HIP 111331"},
        {"Smithsonian Astrophysical Observation", "SAO 247484"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.33574487),
        dec: Angle.Degrees(-59.14312842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133790"},
        {"Hipparcos Number", "HIP 74122"},
        {"Fundamental Katalog 5th Edition", "FK5 5345"},
        {"Smithsonian Astrophysical Observation", "SAO 242251"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.22462024),
        dec: Angle.Degrees(-59.14211890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128398"},
        {"Hipparcos Number", "HIP 71629"},
        {"Geneva Identification System", "GEN# +1.00128398"},
        {"Smithsonian Astrophysical Observation", "SAO 241873"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.74867439),
        dec: Angle.Degrees(-59.14078862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84177"},
        {"Hipparcos Number", "HIP 47509"},
        {"Smithsonian Astrophysical Observation", "SAO 237229"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29047666),
        dec: Angle.Degrees(-59.13890619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200349"},
        {"Hipparcos Number", "HIP 104108"},
        {"Geneva Identification System", "GEN# +1.00200349"},
        {"Smithsonian Astrophysical Observation", "SAO 246856"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.38155677),
        dec: Angle.Degrees(-59.13832667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30790"},
        {"Hipparcos Number", "HIP 22240"},
        {"Smithsonian Astrophysical Observation", "SAO 233682"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.77853113),
        dec: Angle.Degrees(-59.13711895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139298"},
        {"Henry Draper 2", "HD 139299"},
        {"Hipparcos Number", "HIP 76753"},
        {"Smithsonian Astrophysical Observation", "SAO 242811"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08981044),
        dec: Angle.Degrees(-59.13649765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115132"},
        {"Hipparcos Number", "HIP 64765"},
        {"Geneva Identification System", "GEN# +1.00115132"},
        {"Smithsonian Astrophysical Observation", "SAO 240702"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.09127153),
        dec: Angle.Degrees(-59.13526188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32299"},
        {"Hipparcos Number", "HIP 23121"},
        {"Smithsonian Astrophysical Observation", "SAO 233771"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63506129),
        dec: Angle.Degrees(-59.13174780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1505"},
        {"Hipparcos Number", "HIP 1518"},
        {"Smithsonian Astrophysical Observation", "SAO 231996"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.73184707),
        dec: Angle.Degrees(-59.13173280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130265"},
        {"Hipparcos Number", "HIP 72507"},
        {"Geneva Identification System", "GEN# +1.00130265"},
        {"Smithsonian Astrophysical Observation", "SAO 242035"},
        {"Wilson Evans Batten Catalogue", "WEB 12462"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.38229145),
        dec: Angle.Degrees(-59.13169352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209690"},
        {"Hipparcos Number", "HIP 109183"},
        {"Smithsonian Astrophysical Observation", "SAO 247311"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.76452655),
        dec: Angle.Degrees(-59.12697924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183436"},
        {"Hipparcos Number", "HIP 96148"},
        {"Smithsonian Astrophysical Observation", "SAO 246148"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.23937741),
        dec: Angle.Degrees(-59.12665441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8436"},
        {"Hipparcos Number", "HIP 6395"},
        {"Fundamental Katalog 5th Edition", "FK5 2092"},
        {"Geneva Identification System", "GEN# +1.00008436"},
        {"Smithsonian Astrophysical Observation", "SAO 232398"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53983077),
        dec: Angle.Degrees(-59.12635522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10703"},
        {"Hipparcos Number", "HIP 8012"},
        {"Smithsonian Astrophysical Observation", "SAO 232504"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.71690742),
        dec: Angle.Degrees(-59.12613706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65750"},
        {"Hipparcos Number", "HIP 38834"},
        {"Geneva Identification System", "GEN# +1.00065750"},
        {"Smithsonian Astrophysical Observation", "SAO 235638"},
    },
    visualMagnitude: 7.06,
    bvColour: 2.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.21229731),
        dec: Angle.Degrees(-59.12578795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140111"},
        {"Hipparcos Number", "HIP 77140"},
        {"Smithsonian Astrophysical Observation", "SAO 242901"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.25078868),
        dec: Angle.Degrees(-59.12385586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48559"},
        {"Hipparcos Number", "HIP 31929"},
        {"Celescope Catalog", "CEL 1356"},
        {"Smithsonian Astrophysical Observation", "SAO 234651"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.09118115),
        dec: Angle.Degrees(-59.12322569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35246"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.24688499),
        dec: Angle.Degrees(-59.12270230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171582"},
        {"Hipparcos Number", "HIP 91464"},
        {"Smithsonian Astrophysical Observation", "SAO 245603"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.82071025),
        dec: Angle.Degrees(-59.12155838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16000"},
        {"Hipparcos Number", "HIP 11777"},
        {"Smithsonian Astrophysical Observation", "SAO 232806"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.99330106),
        dec: Angle.Degrees(-59.11959757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192175"},
        {"Hipparcos Number", "HIP 99945"},
        {"Geneva Identification System", "GEN# +1.00192175"},
        {"Smithsonian Astrophysical Observation", "SAO 246508"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.16906152),
        dec: Angle.Degrees(-59.11737354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37933"},
        {"Hipparcos Number", "HIP 26514"},
        {"Smithsonian Astrophysical Observation", "SAO 234065"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.56832411),
        dec: Angle.Degrees(-59.11658502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31804"},
        {"Hipparcos Number", "HIP 22862"},
        {"Smithsonian Astrophysical Observation", "SAO 233735"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.77915793),
        dec: Angle.Degrees(-59.11588563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109232"},
        {"Hipparcos Number", "HIP 61312"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.41403777),
        dec: Angle.Degrees(-59.11258771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 471"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.41191024),
        dec: Angle.Degrees(-58.28951949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20399"},
        {"Hipparcos Number", "HIP 15055"},
        {"Smithsonian Astrophysical Observation", "SAO 233046"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.50376546),
        dec: Angle.Degrees(-59.11164238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86319"},
        {"Hipparcos Number", "HIP 48679"},
        {"Celescope Catalog", "CEL 3407"},
        {"Geneva Identification System", "GEN# +1.00086319"},
        {"Smithsonian Astrophysical Observation", "SAO 237506"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.92524950),
        dec: Angle.Degrees(-59.10669459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98278"},
        {"Hipparcos Number", "HIP 55149"},
        {"Celescope Catalog", "CEL 3872"},
        {"Geneva Identification System", "GEN# +1.00098278"},
        {"Smithsonian Astrophysical Observation", "SAO 238939"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.36484599),
        dec: Angle.Degrees(-59.10541162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161012"},
        {"Hipparcos Number", "HIP 87013"},
        {"Smithsonian Astrophysical Observation", "SAO 245012"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.70234052),
        dec: Angle.Degrees(-59.10390341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114837"},
        {"Hipparcos Number", "HIP 64583"},
        {"Geneva Identification System", "GEN# +1.00114837"},
        {"Smithsonian Astrophysical Observation", "SAO 240666"},
        {"Wilson Evans Batten Catalogue", "WEB 11425"},
    },
    visualMagnitude: 4.90,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.56428372),
        dec: Angle.Degrees(-59.10285946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107356"},
        {"Henry Draper 2", "HD 107356A"},
        {"Hipparcos Number", "HIP 60214"},
        {"Geneva Identification System", "GEN# +1.00107356"},
        {"Smithsonian Astrophysical Observation", "SAO 239861"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.21274223),
        dec: Angle.Degrees(-59.10165661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123041"},
        {"Hipparcos Number", "HIP 68975"},
        {"Geneva Identification System", "GEN# +1.00123041"},
        {"Smithsonian Astrophysical Observation", "SAO 241454"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.81682658),
        dec: Angle.Degrees(-59.10036613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223863"},
        {"Hipparcos Number", "HIP 117794"},
        {"Smithsonian Astrophysical Observation", "SAO 248055"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.33187879),
        dec: Angle.Degrees(-59.09956271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216099"},
        {"Hipparcos Number", "HIP 112848"},
        {"Geneva Identification System", "GEN# +1.00216099"},
        {"Smithsonian Astrophysical Observation", "SAO 247618"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.79850260),
        dec: Angle.Degrees(-59.09737146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120697"},
        {"Hipparcos Number", "HIP 67748"},
        {"Geneva Identification System", "GEN# +1.00120697"},
        {"Smithsonian Astrophysical Observation", "SAO 241247"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.18653792),
        dec: Angle.Degrees(-59.09604832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174478"},
        {"Hipparcos Number", "HIP 92774"},
        {"Smithsonian Astrophysical Observation", "SAO 245793"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.56703536),
        dec: Angle.Degrees(-59.09445728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27221"},
        {"Hipparcos Number", "HIP 19798"},
        {"Geneva Identification System", "GEN# +1.00027221"},
        {"Smithsonian Astrophysical Observation", "SAO 233448"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.65051213),
        dec: Angle.Degrees(-59.08971448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216910"},
        {"Hipparcos Number", "HIP 113402"},
        {"Geneva Identification System", "GEN# +1.00216910"},
        {"Smithsonian Astrophysical Observation", "SAO 247657"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.49721251),
        dec: Angle.Degrees(-59.08938305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55377"},
        {"Hipparcos Number", "HIP 34510"},
        {"Smithsonian Astrophysical Observation", "SAO 234969"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.26969188),
        dec: Angle.Degrees(-59.08898023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45556"},
        {"Hipparcos Number", "HIP 30470"},
        {"Smithsonian Astrophysical Observation", "SAO 234487"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.08904625),
        dec: Angle.Degrees(-59.08882982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47544"},
        {"Hipparcos Number", "HIP 31459"},
        {"Smithsonian Astrophysical Observation", "SAO 234596"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.85406524),
        dec: Angle.Degrees(-59.08758386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221582"},
        {"Hipparcos Number", "HIP 116288"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.41815190),
        dec: Angle.Degrees(-59.08657606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108689"},
        {"Hipparcos Number", "HIP 60947"},
        {"Geneva Identification System", "GEN# +1.00108689"},
        {"Smithsonian Astrophysical Observation", "SAO 239993"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.39010518),
        dec: Angle.Degrees(-59.08551072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77370"},
        {"Hipparcos Number", "HIP 44143"},
        {"Geneva Identification System", "GEN# +1.00077370"},
        {"Smithsonian Astrophysical Observation", "SAO 236475"},
        {"Wilson Evans Batten Catalogue", "WEB 8481"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85158738),
        dec: Angle.Degrees(-59.08439697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 281.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112512"},
        {"Hipparcos Number", "HIP 63275"},
        {"Geneva Identification System", "GEN# +1.00112512"},
        {"Smithsonian Astrophysical Observation", "SAO 240420"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.50349190),
        dec: Angle.Degrees(-59.08432766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219987"},
        {"Hipparcos Number", "HIP 115270"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.20459033),
        dec: Angle.Degrees(-59.07844709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199065"},
        {"Hipparcos Number", "HIP 103438"},
        {"Smithsonian Astrophysical Observation", "SAO 246804"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.34336516),
        dec: Angle.Degrees(-59.07582510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195645"},
        {"Hipparcos Number", "HIP 101603"},
        {"Smithsonian Astrophysical Observation", "SAO 246644"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.87100952),
        dec: Angle.Degrees(-59.07540894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134959"},
        {"Hipparcos Number", "HIP 74660"},
        {"Geneva Identification System", "GEN# +4.27200008"},
        {"Smithsonian Astrophysical Observation", "SAO 242348"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.85039040),
        dec: Angle.Degrees(-59.07479671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212041"},
        {"Hipparcos Number", "HIP 110499"},
        {"Smithsonian Astrophysical Observation", "SAO 247430"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.75187968),
        dec: Angle.Degrees(-59.07466372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146465"},
        {"Hipparcos Number", "HIP 79993"},
        {"Geneva Identification System", "GEN# +1.00146465"},
        {"Smithsonian Astrophysical Observation", "SAO 243625"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.93711886),
        dec: Angle.Degrees(-59.07048658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78549"},
        {"Hipparcos Number", "HIP 44676"},
        {"Smithsonian Astrophysical Observation", "SAO 236608"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.57648871),
        dec: Angle.Degrees(-59.06748572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 367"},
        {"Hipparcos Number", "HIP 661"},
        {"Smithsonian Astrophysical Observation", "SAO 231936"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.04884213),
        dec: Angle.Degrees(-59.06308248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141583"},
        {"Hipparcos Number", "HIP 77779"},
        {"Geneva Identification System", "GEN# +1.00141583"},
        {"Smithsonian Astrophysical Observation", "SAO 243067"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.22971954),
        dec: Angle.Degrees(-59.06130211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302564"},
        {"Hipparcos Number", "HIP 49609"},
        {"Smithsonian Astrophysical Observation", "SAO 237717"},
    },
    visualMagnitude: 9.22,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88336981),
        dec: Angle.Degrees(-59.06121650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 497"},
        {"Hipparcos Number", "HIP 757"},
        {"Smithsonian Astrophysical Observation", "SAO 231948"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.32739226),
        dec: Angle.Degrees(-59.06036312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141623"},
        {"Hipparcos Number", "HIP 77795"},
        {"Smithsonian Astrophysical Observation", "SAO 243072"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.28382129),
        dec: Angle.Degrees(-59.06001829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157180"},
        {"Hipparcos Number", "HIP 85263"},
        {"Geneva Identification System", "GEN# +1.00157180"},
        {"Smithsonian Astrophysical Observation", "SAO 244722"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.33783644),
        dec: Angle.Degrees(-59.05807105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6820"},
        {"Hipparcos Number", "HIP 5299"},
        {"Smithsonian Astrophysical Observation", "SAO 232302"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.94739118),
        dec: Angle.Degrees(-59.05791885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223306"},
        {"Hipparcos Number", "HIP 117431"},
        {"Smithsonian Astrophysical Observation", "SAO 248025"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.16357937),
        dec: Angle.Degrees(-59.05758503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302563"},
        {"Hipparcos Number", "HIP 49605"},
        {"Smithsonian Astrophysical Observation", "SAO 237715"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87794849),
        dec: Angle.Degrees(-59.05720714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24073"},
        {"Hipparcos Number", "HIP 17652"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.71547104),
        dec: Angle.Degrees(-59.05403764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33474"},
        {"Hipparcos Number", "HIP 23793"},
        {"Geneva Identification System", "GEN# +1.00033474"},
        {"Smithsonian Astrophysical Observation", "SAO 233830"},
        {"Wilson Evans Batten Catalogue", "WEB 4641"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.68760360),
        dec: Angle.Degrees(-59.05114755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200642"},
        {"Hipparcos Number", "HIP 104238"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.79104827),
        dec: Angle.Degrees(-59.04967078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120360"},
        {"Hipparcos Number", "HIP 67557"},
        {"Smithsonian Astrophysical Observation", "SAO 241214"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.64807448),
        dec: Angle.Degrees(-59.04945312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153262"},
        {"Hipparcos Number", "HIP 83338"},
        {"Geneva Identification System", "GEN# +1.00153262"},
        {"Smithsonian Astrophysical Observation", "SAO 244363"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.47531435),
        dec: Angle.Degrees(-59.04756975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84864"},
        {"Hipparcos Number", "HIP 47926"},
        {"Smithsonian Astrophysical Observation", "SAO 237324"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.50442371),
        dec: Angle.Degrees(-59.04645203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150775"},
        {"Hipparcos Number", "HIP 82130"},
        {"Smithsonian Astrophysical Observation", "SAO 244127"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.66888007),
        dec: Angle.Degrees(-59.04293965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151249"},
        {"Hipparcos Number", "HIP 82363"},
        {"Fundamental Katalog 5th Edition", "FK5 1435"},
        {"Geneva Identification System", "GEN# +1.00151249"},
        {"Smithsonian Astrophysical Observation", "SAO 244168"},
        {"Wilson Evans Batten Catalogue", "WEB 13905"},
    },
    visualMagnitude: 3.77,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.44629764),
        dec: Angle.Degrees(-59.04131648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44158"},
        {"Smithsonian Astrophysical Observation", "SAO 236481"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.90186985),
        dec: Angle.Degrees(-59.04047110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165497"},
        {"Hipparcos Number", "HIP 89006"},
        {"Geneva Identification System", "GEN# +1.00165497"},
        {"Smithsonian Astrophysical Observation", "SAO 245273"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.48996303),
        dec: Angle.Degrees(-59.04017540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192979"},
        {"Hipparcos Number", "HIP 100333"},
        {"Smithsonian Astrophysical Observation", "SAO 246537"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.22286707),
        dec: Angle.Degrees(-59.03566498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157801"},
        {"Hipparcos Number", "HIP 85553"},
        {"Smithsonian Astrophysical Observation", "SAO 244775"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.25910456),
        dec: Angle.Degrees(-59.03243529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97848"},
        {"Hipparcos Number", "HIP 54902"},
        {"Celescope Catalog", "CEL 3861"},
        {"Geneva Identification System", "GEN# +1.00097848"},
        {"Smithsonian Astrophysical Observation", "SAO 238893"},
        {"Wilson Evans Batten Catalogue", "WEB 9908"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63295657),
        dec: Angle.Degrees(-59.02468307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45946"},
        {"Hipparcos Number", "HIP 30671"},
        {"Geneva Identification System", "GEN# +1.00045946"},
        {"Smithsonian Astrophysical Observation", "SAO 234515"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.68162281),
        dec: Angle.Degrees(-59.02410706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179212"},
        {"Hipparcos Number", "HIP 94602"},
        {"Smithsonian Astrophysical Observation", "SAO 245986"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.77741810),
        dec: Angle.Degrees(-59.02325008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1839"},
        {"Hipparcos Number", "HIP 1775"},
        {"Smithsonian Astrophysical Observation", "SAO 232009"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.62635347),
        dec: Angle.Degrees(-59.02231479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146021"},
        {"Hipparcos Number", "HIP 79808"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.32413318),
        dec: Angle.Degrees(-59.02127896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65597"},
        {"Geneva Identification System", "GEN# +2.51380054"},
        {"New General Catalogue", "NGC 5138 54"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.74265065),
        dec: Angle.Degrees(-59.02009097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219441"},
        {"Hipparcos Number", "HIP 114901"},
        {"Smithsonian Astrophysical Observation", "SAO 247808"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.10882830),
        dec: Angle.Degrees(-59.01877123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112147"},
        {"Hipparcos Number", "HIP 63049"},
        {"Geneva Identification System", "GEN# +1.00112147"},
        {"Smithsonian Astrophysical Observation", "SAO 240375"},
        {"Wilson Evans Batten Catalogue", "WEB 11178"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.78526901),
        dec: Angle.Degrees(-59.01872596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106015"},
        {"Hipparcos Number", "HIP 59495"},
        {"Geneva Identification System", "GEN# +1.00106015"},
        {"Smithsonian Astrophysical Observation", "SAO 239743"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.01308247),
        dec: Angle.Degrees(-59.01739462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20608"},
        {"Hipparcos Number", "HIP 15212"},
        {"Smithsonian Astrophysical Observation", "SAO 233058"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.02491248),
        dec: Angle.Degrees(-59.01582121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16700"},
        {"Hipparcos Number", "HIP 12286"},
        {"Smithsonian Astrophysical Observation", "SAO 232840"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.57171045),
        dec: Angle.Degrees(-59.01566996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23640"},
        {"Hipparcos Number", "HIP 17393"},
        {"Smithsonian Astrophysical Observation", "SAO 233243"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.87703916),
        dec: Angle.Degrees(-59.01452708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86997"},
        {"Hipparcos Number", "HIP 49039"},
        {"Geneva Identification System", "GEN# +1.00086997"},
        {"Smithsonian Astrophysical Observation", "SAO 237580"},
        {"Wilson Evans Batten Catalogue", "WEB 9097"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.07814288),
        dec: Angle.Degrees(-59.01241000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208496"},
        {"Hipparcos Number", "HIP 108478"},
        {"Fundamental Katalog 5th Edition", "FK5 3752"},
        {"Geneva Identification System", "GEN# +1.00208496"},
        {"Smithsonian Astrophysical Observation", "SAO 247247"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.62530272),
        dec: Angle.Degrees(-59.01221007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31372"},
        {"Hipparcos Number", "HIP 22587"},
        {"Smithsonian Astrophysical Observation", "SAO 233718"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.91265395),
        dec: Angle.Degrees(-59.01010165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205682"},
        {"Hipparcos Number", "HIP 106904"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76887656),
        dec: Angle.Degrees(-59.00948292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185454"},
        {"Hipparcos Number", "HIP 96955"},
        {"Geneva Identification System", "GEN# +1.00185454J"},
        {"Smithsonian Astrophysical Observation", "SAO 246222"},
        {"Wilson Evans Batten Catalogue", "WEB 17014"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.63820169),
        dec: Angle.Degrees(-59.00946588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218510"},
        {"Hipparcos Number", "HIP 114333"},
        {"Geneva Identification System", "GEN# +1.00218510"},
        {"Smithsonian Astrophysical Observation", "SAO 247758"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.34123678),
        dec: Angle.Degrees(-59.00792903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46697"},
        {"Hipparcos Number", "HIP 31062"},
        {"Smithsonian Astrophysical Observation", "SAO 234554"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.77371487),
        dec: Angle.Degrees(-59.00472440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119106"},
        {"Hipparcos Number", "HIP 66913"},
        {"Smithsonian Astrophysical Observation", "SAO 241094"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.69693165),
        dec: Angle.Degrees(-59.00434125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221360"},
        {"Hipparcos Number", "HIP 116155"},
        {"Smithsonian Astrophysical Observation", "SAO 247918"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.02061868),
        dec: Angle.Degrees(-59.00372204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65618"},
        {"Geneva Identification System", "GEN# +2.51380011"},
        {"New General Catalogue", "NGC 5138 11"},
    },
    visualMagnitude: 11.63,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.80468281),
        dec: Angle.Degrees(-59.00321576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5113"},
        {"Hipparcos Number", "HIP 4070"},
        {"Smithsonian Astrophysical Observation", "SAO 232212"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.05050642),
        dec: Angle.Degrees(-59.00258772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101465"},
        {"Hipparcos Number", "HIP 56913"},
        {"Geneva Identification System", "GEN# +1.00101465"},
        {"Smithsonian Astrophysical Observation", "SAO 239273"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.01888488),
        dec: Angle.Degrees(-59.00205518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84863"},
        {"Hipparcos Number", "HIP 47920"},
        {"Geneva Identification System", "GEN# +1.00084863"},
        {"Smithsonian Astrophysical Observation", "SAO 237323"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49958258),
        dec: Angle.Degrees(-58.99711135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21327"},
        {"Hipparcos Number", "HIP 15801"},
        {"Smithsonian Astrophysical Observation", "SAO 233104"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90148677),
        dec: Angle.Degrees(-58.99404706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57130"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.70092465),
        dec: Angle.Degrees(-58.99339964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152642"},
        {"Hipparcos Number", "HIP 83040"},
        {"Smithsonian Astrophysical Observation", "SAO 244303"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53358673),
        dec: Angle.Degrees(-58.99252227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108396"},
        {"Hipparcos Number", "HIP 60781"},
        {"Geneva Identification System", "GEN# +1.00108396"},
        {"Smithsonian Astrophysical Observation", "SAO 239960"},
        {"Wilson Evans Batten Catalogue", "WEB 10812"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.87031761),
        dec: Angle.Degrees(-58.99176932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55643"},
        {"Hipparcos Number", "HIP 34618"},
        {"Geneva Identification System", "GEN# +1.00055643"},
        {"Smithsonian Astrophysical Observation", "SAO 234989"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.54110369),
        dec: Angle.Degrees(-58.99085370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164054"},
        {"Hipparcos Number", "HIP 88400"},
        {"Smithsonian Astrophysical Observation", "SAO 245189"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.76489489),
        dec: Angle.Degrees(-58.99077984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17241"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.39047947),
        dec: Angle.Degrees(-58.98754809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116199"},
        {"Hipparcos Number", "HIP 65316"},
        {"Smithsonian Astrophysical Observation", "SAO 240789"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.80368736),
        dec: Angle.Degrees(-58.98708853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165882"},
        {"Hipparcos Number", "HIP 89168"},
        {"Geneva Identification System", "GEN# +1.00165882"},
        {"Smithsonian Astrophysical Observation", "SAO 245294"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.95755696),
        dec: Angle.Degrees(-58.98582975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34186"},
        {"Hipparcos Number", "HIP 24200"},
        {"Smithsonian Astrophysical Observation", "SAO 233868"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92814608),
        dec: Angle.Degrees(-58.98558274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29877"},
        {"Hipparcos Number", "HIP 21645"},
        {"Smithsonian Astrophysical Observation", "SAO 233609"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72525283),
        dec: Angle.Degrees(-58.98062087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150885"},
        {"Hipparcos Number", "HIP 82177"},
        {"Geneva Identification System", "GEN# +1.00150885"},
        {"Smithsonian Astrophysical Observation", "SAO 244132"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84083321),
        dec: Angle.Degrees(-58.98051955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172495"},
        {"Hipparcos Number", "HIP 91907"},
        {"Smithsonian Astrophysical Observation", "SAO 245662"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.04309101),
        dec: Angle.Degrees(-58.98042664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160831"},
        {"Hipparcos Number", "HIP 86928"},
        {"Smithsonian Astrophysical Observation", "SAO 244999"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.43306529),
        dec: Angle.Degrees(-58.97961954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130380"},
        {"Hipparcos Number", "HIP 72569"},
        {"Geneva Identification System", "GEN# +1.00130380"},
        {"Smithsonian Astrophysical Observation", "SAO 242045"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56706351),
        dec: Angle.Degrees(-58.97673452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107920"},
        {"Hipparcos Number", "HIP 60513"},
        {"Geneva Identification System", "GEN# +1.00107920"},
        {"Smithsonian Astrophysical Observation", "SAO 239922"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.07623408),
        dec: Angle.Degrees(-58.97641748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96918"},
        {"Hipparcos Number", "HIP 54463"},
        {"Fundamental Katalog 5th Edition", "FK5 1289"},
        {"Geneva Identification System", "GEN# +1.00096918"},
        {"Smithsonian Astrophysical Observation", "SAO 238813"},
        {"Wilson Evans Batten Catalogue", "WEB 9832"},
    },
    visualMagnitude: 3.93,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.14748181),
        dec: Angle.Degrees(-58.97504198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125038"},
        {"Hipparcos Number", "HIP 69953"},
        {"Geneva Identification System", "GEN# +1.00125038"},
        {"Smithsonian Astrophysical Observation", "SAO 241621"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.72415398),
        dec: Angle.Degrees(-58.97259481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119033"},
        {"Hipparcos Number", "HIP 66880"},
        {"Smithsonian Astrophysical Observation", "SAO 241085"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59814932),
        dec: Angle.Degrees(-58.97154509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144263"},
        {"Hipparcos Number", "HIP 79046"},
        {"Smithsonian Astrophysical Observation", "SAO 243345"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.02131472),
        dec: Angle.Degrees(-58.97068562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197791"},
        {"Hipparcos Number", "HIP 102708"},
        {"Smithsonian Astrophysical Observation", "SAO 246734"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.15852830),
        dec: Angle.Degrees(-58.96932315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42668"},
        {"Hipparcos Number", "HIP 29089"},
        {"Smithsonian Astrophysical Observation", "SAO 234340"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.04275204),
        dec: Angle.Degrees(-58.96921485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165538"},
        {"Hipparcos Number", "HIP 89024"},
        {"Smithsonian Astrophysical Observation", "SAO 245276"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.53655336),
        dec: Angle.Degrees(-58.96831550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79351"},
        {"Hipparcos Number", "HIP 45080"},
        {"Celescope Catalog", "CEL 3206"},
        {"Geneva Identification System", "GEN# +1.00079351"},
        {"Smithsonian Astrophysical Observation", "SAO 236693"},
        {"Wilson Evans Batten Catalogue", "WEB 8604"},
    },
    visualMagnitude: 3.43,
    bvColour: -0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.74210535),
        dec: Angle.Degrees(-58.96693014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224376"},
        {"Hipparcos Number", "HIP 118106"},
        {"Geneva Identification System", "GEN# +1.00224376"},
        {"Smithsonian Astrophysical Observation", "SAO 248077"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.36546700),
        dec: Angle.Degrees(-58.96449631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65655"},
        {"Geneva Identification System", "GEN# +2.51380151"},
        {"New General Catalogue", "NGC 5138 151"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.91682374),
        dec: Angle.Degrees(-58.96411852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88775"},
    },
    visualMagnitude: 10.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.84170008),
        dec: Angle.Degrees(-58.96167708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219696"},
        {"Hipparcos Number", "HIP 115080"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.63343408),
        dec: Angle.Degrees(-58.96076036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209499"},
        {"Hipparcos Number", "HIP 109060"},
        {"Smithsonian Astrophysical Observation", "SAO 247301"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.40220394),
        dec: Angle.Degrees(-58.96053501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153261"},
        {"Hipparcos Number", "HIP 83323"},
        {"Geneva Identification System", "GEN# +1.00153261"},
        {"Smithsonian Astrophysical Observation", "SAO 244362"},
        {"Wilson Evans Batten Catalogue", "WEB 14083"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.44746025),
        dec: Angle.Degrees(-58.95822634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38042"},
        {"Hipparcos Number", "HIP 26589"},
        {"Smithsonian Astrophysical Observation", "SAO 234073"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.77917363),
        dec: Angle.Degrees(-58.95756948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63329"},
        {"Hipparcos Number", "HIP 37794"},
        {"Smithsonian Astrophysical Observation", "SAO 235484"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.24705417),
        dec: Angle.Degrees(-58.95542795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63427"},
        {"Hipparcos Number", "HIP 37846"},
        {"Geneva Identification System", "GEN# +1.00063427J"},
        {"Smithsonian Astrophysical Observation", "SAO 235492"},
        {"Wilson Evans Batten Catalogue", "WEB 7474"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.38020303),
        dec: Angle.Degrees(-58.95489289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137175"},
        {"Hipparcos Number", "HIP 75655"},
        {"Smithsonian Astrophysical Observation", "SAO 242538"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.84726900),
        dec: Angle.Degrees(-58.95468472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2417"},
        {"Hipparcos Number", "HIP 2176"},
        {"Smithsonian Astrophysical Observation", "SAO 232047"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.86766697),
        dec: Angle.Degrees(-58.95308504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26059"},
        {"Hipparcos Number", "HIP 18997"},
        {"Smithsonian Astrophysical Observation", "SAO 233389"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.05365626),
        dec: Angle.Degrees(-58.95307571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220177"},
        {"Hipparcos Number", "HIP 115380"},
        {"Geneva Identification System", "GEN# +1.00220177"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.59834613),
        dec: Angle.Degrees(-58.95107014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125533"},
        {"Hipparcos Number", "HIP 70217"},
        {"Geneva Identification System", "GEN# +1.00125533"},
        {"Smithsonian Astrophysical Observation", "SAO 241666"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.48560126),
        dec: Angle.Degrees(-58.94982983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112841"},
        {"Hipparcos Number", "HIP 63475"},
        {"Geneva Identification System", "GEN# +1.00112841"},
        {"Smithsonian Astrophysical Observation", "SAO 240468"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10417988),
        dec: Angle.Degrees(-58.94973665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122338"},
        {"Hipparcos Number", "HIP 68648"},
        {"Geneva Identification System", "GEN# +1.00122338"},
        {"Smithsonian Astrophysical Observation", "SAO 241396"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.78003446),
        dec: Angle.Degrees(-58.94842678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141946"},
        {"Hipparcos Number", "HIP 77923"},
        {"Smithsonian Astrophysical Observation", "SAO 243102"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.70639315),
        dec: Angle.Degrees(-58.94799737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173562"},
        {"Hipparcos Number", "HIP 92375"},
        {"Geneva Identification System", "GEN# +1.00173562"},
        {"Renson", "Renson 48600"},
        {"Smithsonian Astrophysical Observation", "SAO 245728"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.37930326),
        dec: Angle.Degrees(-58.94778946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30003"},
        {"Hipparcos Number", "HIP 21756"},
        {"Geneva Identification System", "GEN# +1.00030003J"},
        {"Smithsonian Astrophysical Observation", "SAO 233622"},
        {"Wilson Evans Batten Catalogue", "WEB 4183"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.07383679),
        dec: Angle.Degrees(-58.94433445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174098"},
        {"Hipparcos Number", "HIP 92625"},
        {"Smithsonian Astrophysical Observation", "SAO 245765"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.09523707),
        dec: Angle.Degrees(-58.94234918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117057"},
        {"Hipparcos Number", "HIP 65776"},
        {"Celescope Catalog", "CEL 4261"},
        {"Geneva Identification System", "GEN# +1.00117057"},
        {"Renson", "Renson 33780"},
        {"Smithsonian Astrophysical Observation", "SAO 240879"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.26612867),
        dec: Angle.Degrees(-58.94226357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53349"},
        {"Hipparcos Number", "HIP 33800"},
        {"Fundamental Katalog 5th Edition", "FK5 2546"},
        {"Geneva Identification System", "GEN# +1.00053349"},
        {"Smithsonian Astrophysical Observation", "SAO 234863"},
        {"Wilson Evans Batten Catalogue", "WEB 6786"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.27157418),
        dec: Angle.Degrees(-58.94029633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11399"},
        {"Hipparcos Number", "HIP 8547"},
        {"Smithsonian Astrophysical Observation", "SAO 232540"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.55978333),
        dec: Angle.Degrees(-58.93965030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203570"},
        {"Hipparcos Number", "HIP 105780"},
        {"Smithsonian Astrophysical Observation", "SAO 247021"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.35101440),
        dec: Angle.Degrees(-58.93796765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177721"},
        {"Hipparcos Number", "HIP 94109"},
        {"Smithsonian Astrophysical Observation", "SAO 245941"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.35154903),
        dec: Angle.Degrees(-58.93700403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164092"},
        {"Hipparcos Number", "HIP 88425"},
        {"Smithsonian Astrophysical Observation", "SAO 245194"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.80137157),
        dec: Angle.Degrees(-58.93545616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80926"},
        {"Hipparcos Number", "HIP 45787"},
        {"Smithsonian Astrophysical Observation", "SAO 236862"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.02980039),
        dec: Angle.Degrees(-58.93423301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148613"},
        {"Hipparcos Number", "HIP 81005"},
        {"Smithsonian Astrophysical Observation", "SAO 243921"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.14438619),
        dec: Angle.Degrees(-58.93345102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200203"},
        {"Hipparcos Number", "HIP 104030"},
        {"Geneva Identification System", "GEN# +1.00200203"},
        {"Smithsonian Astrophysical Observation", "SAO 246845"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.14265067),
        dec: Angle.Degrees(-58.93311250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19285"},
        {"Hipparcos Number", "HIP 14229"},
        {"Smithsonian Astrophysical Observation", "SAO 232977"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.86813121),
        dec: Angle.Degrees(-58.93301202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201933"},
        {"Hipparcos Number", "HIP 104929"},
        {"Smithsonian Astrophysical Observation", "SAO 246924"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.82187784),
        dec: Angle.Degrees(-58.92942586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80790"},
        {"Hipparcos Number", "HIP 45726"},
        {"Geneva Identification System", "GEN# +1.00080790"},
        {"Smithsonian Astrophysical Observation", "SAO 236850"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.83308846),
        dec: Angle.Degrees(-58.92934528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215905"},
        {"Hipparcos Number", "HIP 112726"},
        {"Fundamental Katalog 5th Edition", "FK5 6014"},
        {"Smithsonian Astrophysical Observation", "SAO 247603"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.42062447),
        dec: Angle.Degrees(-58.92932457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10012"},
        {"Hipparcos Number", "HIP 7472"},
        {"Smithsonian Astrophysical Observation", "SAO 232475"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.05795132),
        dec: Angle.Degrees(-58.92802141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20976"},
        {"Smithsonian Astrophysical Observation", "SAO 233543"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.48434620),
        dec: Angle.Degrees(-58.92459442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198064"},
        {"Hipparcos Number", "HIP 102873"},
        {"Smithsonian Astrophysical Observation", "SAO 246749"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.63983136),
        dec: Angle.Degrees(-58.92361406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110274"},
        {"Hipparcos Number", "HIP 61931"},
        {"Geneva Identification System", "GEN# +1.00110274"},
        {"Renson", "Renson 32040"},
        {"Smithsonian Astrophysical Observation", "SAO 240153"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.37906661),
        dec: Angle.Degrees(-58.92344659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36189"},
        {"Hipparcos Number", "HIP 25429"},
        {"Fundamental Katalog 5th Edition", "FK5 2410"},
        {"Geneva Identification System", "GEN# +1.00036189"},
        {"Smithsonian Astrophysical Observation", "SAO 233981"},
        {"Wilson Evans Batten Catalogue", "WEB 4929"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.58032066),
        dec: Angle.Degrees(-58.91259871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162381"},
        {"Hipparcos Number", "HIP 87673"},
        {"Smithsonian Astrophysical Observation", "SAO 245103"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61413941),
        dec: Angle.Degrees(-58.91150618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155100"},
        {"Hipparcos Number", "HIP 84231"},
        {"Smithsonian Astrophysical Observation", "SAO 244519"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.26199749),
        dec: Angle.Degrees(-58.91133201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131124"},
        {"Hipparcos Number", "HIP 72917"},
        {"Geneva Identification System", "GEN# +1.00131124"},
        {"Smithsonian Astrophysical Observation", "SAO 242102"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.53244725),
        dec: Angle.Degrees(-58.90995950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 741"},
        {"Hipparcos Number", "HIP 929"},
        {"Geneva Identification System", "GEN# +1.00000741"},
        {"Smithsonian Astrophysical Observation", "SAO 231962"},
        {"Wilson Evans Batten Catalogue", "WEB 164"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.88657321),
        dec: Angle.Degrees(-58.90982912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 270.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163147"},
        {"Hipparcos Number", "HIP 87979"},
        {"Smithsonian Astrophysical Observation", "SAO 245139"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.57539271),
        dec: Angle.Degrees(-58.90941773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167271"},
        {"Hipparcos Number", "HIP 89685"},
        {"Smithsonian Astrophysical Observation", "SAO 245378"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.53430262),
        dec: Angle.Degrees(-58.90896788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125345"},
        {"Hipparcos Number", "HIP 70119"},
        {"Geneva Identification System", "GEN# +1.00125345"},
        {"Smithsonian Astrophysical Observation", "SAO 241648"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.21065801),
        dec: Angle.Degrees(-58.90819434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63709"},
        {"Hipparcos Number", "HIP 37963"},
        {"Celescope Catalog", "CEL 2038"},
        {"Smithsonian Astrophysical Observation", "SAO 235513"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.72702941),
        dec: Angle.Degrees(-58.90674132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211727"},
        {"Hipparcos Number", "HIP 110328"},
        {"Smithsonian Astrophysical Observation", "SAO 247412"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.19514062),
        dec: Angle.Degrees(-58.90612027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18674"},
        {"Hipparcos Number", "HIP 13792"},
        {"Smithsonian Astrophysical Observation", "SAO 232952"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40126608),
        dec: Angle.Degrees(-58.90461799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110532"},
        {"Hipparcos Number", "HIP 62084"},
        {"Geneva Identification System", "GEN# +1.00110532J"},
        {"Smithsonian Astrophysical Observation", "SAO 240183"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.86833524),
        dec: Angle.Degrees(-58.90274136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178562"},
        {"Hipparcos Number", "HIP 94379"},
        {"Geneva Identification System", "GEN# +1.00178562"},
        {"Smithsonian Astrophysical Observation", "SAO 245966"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.14474216),
        dec: Angle.Degrees(-58.90230260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188162"},
        {"Hipparcos Number", "HIP 98174"},
        {"Geneva Identification System", "GEN# +1.00188162"},
        {"Renson", "Renson 51967"},
        {"Smithsonian Astrophysical Observation", "SAO 246349"},
        {"Wilson Evans Batten Catalogue", "WEB 17307"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.27618092),
        dec: Angle.Degrees(-58.90131541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11585"},
        {"Hipparcos Number", "HIP 8702"},
        {"Smithsonian Astrophysical Observation", "SAO 232552"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.98989238),
        dec: Angle.Degrees(-58.90040237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217990"},
        {"Hipparcos Number", "HIP 114019"},
        {"Geneva Identification System", "GEN# +1.00217990"},
        {"Smithsonian Astrophysical Observation", "SAO 247719"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.36290410),
        dec: Angle.Degrees(-58.89934169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4739"},
        {"Hipparcos Number", "HIP 3785"},
        {"Smithsonian Astrophysical Observation", "SAO 232191"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.16525669),
        dec: Angle.Degrees(-58.89585612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94491"},
        {"Hipparcos Number", "HIP 53231"},
        {"Celescope Catalog", "CEL 3756"},
        {"Geneva Identification System", "GEN# +1.00094491"},
        {"Smithsonian Astrophysical Observation", "SAO 238570"},
        {"Wilson Evans Batten Catalogue", "WEB 9665"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.33825968),
        dec: Angle.Degrees(-58.89346136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175897"},
        {"Hipparcos Number", "HIP 93378"},
        {"Geneva Identification System", "GEN# +1.00175897"},
        {"Smithsonian Astrophysical Observation", "SAO 245862"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27847103),
        dec: Angle.Degrees(-58.89163427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17451"},
        {"Hipparcos Number", "HIP 12872"},
        {"Smithsonian Astrophysical Observation", "SAO 232883"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.36843804),
        dec: Angle.Degrees(-58.89136074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70588"},
        {"Hipparcos Number", "HIP 40802"},
        {"Geneva Identification System", "GEN# +1.00070588"},
        {"Smithsonian Astrophysical Observation", "SAO 235890"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.92336303),
        dec: Angle.Degrees(-58.89080623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127112"},
        {"Hipparcos Number", "HIP 71042"},
        {"Geneva Identification System", "GEN# +1.00127112"},
        {"Smithsonian Astrophysical Observation", "SAO 241765"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.94151486),
        dec: Angle.Degrees(-58.88948247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98041"},
        {"Hipparcos Number", "HIP 55010"},
        {"Geneva Identification System", "GEN# +1.00098041"},
        {"Smithsonian Astrophysical Observation", "SAO 238916"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.94737487),
        dec: Angle.Degrees(-58.88768521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3207"},
        {"Hipparcos Number", "HIP 2726"},
        {"Smithsonian Astrophysical Observation", "SAO 232096"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.69764431),
        dec: Angle.Degrees(-58.88537925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212542"},
        {"Hipparcos Number", "HIP 110777"},
        {"Smithsonian Astrophysical Observation", "SAO 247446"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.63969133),
        dec: Angle.Degrees(-58.87791613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106342"},
        {"Hipparcos Number", "HIP 59674"},
        {"Geneva Identification System", "GEN# +1.00106342"},
        {"Smithsonian Astrophysical Observation", "SAO 239779"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.56057570),
        dec: Angle.Degrees(-58.87660802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180022"},
        {"Hipparcos Number", "HIP 94868"},
        {"Geneva Identification System", "GEN# +1.00180022"},
        {"Smithsonian Astrophysical Observation", "SAO 246016"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.58426345),
        dec: Angle.Degrees(-58.87423268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90490"},
        {"Hipparcos Number", "HIP 51011"},
        {"Celescope Catalog", "CEL 3533"},
        {"Geneva Identification System", "GEN# +1.00090490"},
        {"Smithsonian Astrophysical Observation", "SAO 238052"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.31753442),
        dec: Angle.Degrees(-58.87247729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37462"},
        {"Hipparcos Number", "HIP 26200"},
        {"Geneva Identification System", "GEN# +1.00037462"},
        {"Smithsonian Astrophysical Observation", "SAO 234037"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.76145661),
        dec: Angle.Degrees(-58.87119266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15960"},
        {"Hipparcos Number", "HIP 11753"},
        {"Geneva Identification System", "GEN# +1.00015960"},
        {"Smithsonian Astrophysical Observation", "SAO 232804"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.90789163),
        dec: Angle.Degrees(-58.87074558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62485"},
        {"Hipparcos Number", "HIP 37410"},
        {"Smithsonian Astrophysical Observation", "SAO 235415"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21086699),
        dec: Angle.Degrees(-58.87073397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145418"},
        {"Hipparcos Number", "HIP 79555"},
        {"Smithsonian Astrophysical Observation", "SAO 243463"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.50606033),
        dec: Angle.Degrees(-58.86961743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171674"},
        {"Hipparcos Number", "HIP 91512"},
        {"Smithsonian Astrophysical Observation", "SAO 245612"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.94923307),
        dec: Angle.Degrees(-58.86920774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149879"},
        {"Hipparcos Number", "HIP 81661"},
        {"Geneva Identification System", "GEN# +1.00149879"},
        {"Smithsonian Astrophysical Observation", "SAO 244055"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23048169),
        dec: Angle.Degrees(-58.86869331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138536"},
        {"Hipparcos Number", "HIP 76341"},
        {"Geneva Identification System", "GEN# +1.00138536"},
        {"Smithsonian Astrophysical Observation", "SAO 242727"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.89776757),
        dec: Angle.Degrees(-58.86611023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206910"},
        {"Hipparcos Number", "HIP 107580"},
        {"Smithsonian Astrophysical Observation", "SAO 247175"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.83556645),
        dec: Angle.Degrees(-58.86522172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162155"},
        {"Hipparcos Number", "HIP 87551"},
        {"Geneva Identification System", "GEN# +1.00162155"},
        {"Smithsonian Astrophysical Observation", "SAO 245088"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.29637397),
        dec: Angle.Degrees(-58.86431135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199390"},
        {"Hipparcos Number", "HIP 103607"},
        {"Smithsonian Astrophysical Observation", "SAO 246813"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.87339998),
        dec: Angle.Degrees(-58.85881186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136226"},
        {"Hipparcos Number", "HIP 75209"},
        {"Smithsonian Astrophysical Observation", "SAO 242446"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.54412367),
        dec: Angle.Degrees(-58.85730426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55789"},
        {"Hipparcos Number", "HIP 34674"},
        {"Smithsonian Astrophysical Observation", "SAO 234999"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.70932200),
        dec: Angle.Degrees(-58.85645484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107581"},
    },
    visualMagnitude: 10.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.83917175),
        dec: Angle.Degrees(-58.85631309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43092"},
        {"Hipparcos Number", "HIP 29297"},
        {"Smithsonian Astrophysical Observation", "SAO 234361"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.65013454),
        dec: Angle.Degrees(-58.85440613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94510"},
        {"Hipparcos Number", "HIP 53253"},
        {"Geneva Identification System", "GEN# +1.00094510"},
        {"Smithsonian Astrophysical Observation", "SAO 238574"},
        {"Wilson Evans Batten Catalogue", "WEB 9669"},
    },
    visualMagnitude: 3.78,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.37319260),
        dec: Angle.Degrees(-58.85326474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125954"},
        {"Hipparcos Number", "HIP 70454"},
        {"Geneva Identification System", "GEN# +1.00125954"},
        {"Smithsonian Astrophysical Observation", "SAO 241697"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.18292110),
        dec: Angle.Degrees(-58.85307873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148959"},
        {"Hipparcos Number", "HIP 81193"},
        {"Smithsonian Astrophysical Observation", "SAO 243960"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.76655156),
        dec: Angle.Degrees(-58.85256209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56024"},
        {"Hipparcos Number", "HIP 34766"},
        {"Smithsonian Astrophysical Observation", "SAO 235007"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.95914808),
        dec: Angle.Degrees(-58.85068538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153123"},
        {"Hipparcos Number", "HIP 83268"},
        {"Smithsonian Astrophysical Observation", "SAO 244353"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.27853112),
        dec: Angle.Degrees(-58.85006465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2030"},
        {"Hipparcos Number", "HIP 1908"},
        {"Smithsonian Astrophysical Observation", "SAO 232023"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.02932126),
        dec: Angle.Degrees(-58.83914124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223802"},
        {"Hipparcos Number", "HIP 117760"},
        {"Geneva Identification System", "GEN# +1.00223802"},
        {"Smithsonian Astrophysical Observation", "SAO 248052"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.22322254),
        dec: Angle.Degrees(-58.83833138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97082"},
        {"Hipparcos Number", "HIP 54543"},
        {"Geneva Identification System", "GEN# +1.00097082"},
        {"Smithsonian Astrophysical Observation", "SAO 238825"},
        {"Wilson Evans Batten Catalogue", "WEB 9846"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.42147326),
        dec: Angle.Degrees(-58.83773196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168128"},
        {"Hipparcos Number", "HIP 90009"},
        {"Geneva Identification System", "GEN# +1.00168128"},
        {"Smithsonian Astrophysical Observation", "SAO 245420"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.48784939),
        dec: Angle.Degrees(-58.83603868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48293"},
        {"Hipparcos Number", "HIP 31805"},
        {"Smithsonian Astrophysical Observation", "SAO 234641"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.74404279),
        dec: Angle.Degrees(-58.83597785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21300"},
        {"Hipparcos Number", "HIP 15780"},
        {"Smithsonian Astrophysical Observation", "SAO 233103"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.84220309),
        dec: Angle.Degrees(-58.83319971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206076"},
        {"Hipparcos Number", "HIP 107117"},
        {"Smithsonian Astrophysical Observation", "SAO 247136"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.45575669),
        dec: Angle.Degrees(-58.83247650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109568"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.93491209),
        dec: Angle.Degrees(-58.83215582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126164"},
        {"Hipparcos Number", "HIP 70551"},
        {"Geneva Identification System", "GEN# +1.00126164"},
        {"Smithsonian Astrophysical Observation", "SAO 241706"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.47995568),
        dec: Angle.Degrees(-58.83186422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210367"},
        {"Hipparcos Number", "HIP 109566"},
        {"Smithsonian Astrophysical Observation", "SAO 247345"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.92733681),
        dec: Angle.Degrees(-58.83149042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54264"},
        {"Hipparcos Number", "HIP 34125"},
        {"Smithsonian Astrophysical Observation", "SAO 234904"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.13945417),
        dec: Angle.Degrees(-58.82979001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20038"},
        {"Hipparcos Number", "HIP 14747"},
        {"Geneva Identification System", "GEN# +1.00020038"},
        {"Smithsonian Astrophysical Observation", "SAO 233021"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.61171789),
        dec: Angle.Degrees(-58.82791557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88647"},
        {"Hipparcos Number", "HIP 49926"},
        {"Geneva Identification System", "GEN# +1.00088647"},
        {"Smithsonian Astrophysical Observation", "SAO 237773"},
        {"Wilson Evans Batten Catalogue", "WEB 9189"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.89786643),
        dec: Angle.Degrees(-58.82782701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209552"},
        {"Hipparcos Number", "HIP 109098"},
        {"Smithsonian Astrophysical Observation", "SAO 247304"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.49654043),
        dec: Angle.Degrees(-58.82769556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224401"},
        {"Hipparcos Number", "HIP 118120"},
        {"Renson", "Renson 61470"},
        {"Smithsonian Astrophysical Observation", "SAO 248078"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39401431),
        dec: Angle.Degrees(-58.82553849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103703"},
        {"Hipparcos Number", "HIP 58220"},
        {"Geneva Identification System", "GEN# +1.00103703"},
        {"Smithsonian Astrophysical Observation", "SAO 239508"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.11085212),
        dec: Angle.Degrees(-58.82132172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160154"},
        {"Hipparcos Number", "HIP 86610"},
        {"Smithsonian Astrophysical Observation", "SAO 244946"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48205196),
        dec: Angle.Degrees(-58.82096712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213869"},
        {"Hipparcos Number", "HIP 111536"},
        {"Smithsonian Astrophysical Observation", "SAO 247504"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94813449),
        dec: Angle.Degrees(-58.82083773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127449"},
        {"Hipparcos Number", "HIP 71194"},
        {"Geneva Identification System", "GEN# +1.00127449"},
        {"Smithsonian Astrophysical Observation", "SAO 241791"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.40326763),
        dec: Angle.Degrees(-58.82078928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106034"},
        {"Hipparcos Number", "HIP 59503"},
        {"Geneva Identification System", "GEN# +1.00106034"},
        {"Smithsonian Astrophysical Observation", "SAO 239746"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.04549056),
        dec: Angle.Degrees(-58.81834508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92436"},
        {"Hipparcos Number", "HIP 52127"},
        {"Geneva Identification System", "GEN# +1.00092436"},
        {"Geneva Identification System 2", "GEN# +1.00092436A"},
        {"Smithsonian Astrophysical Observation", "SAO 238304"},
        {"Wilson Evans Batten Catalogue", "WEB 9501"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.74877044),
        dec: Angle.Degrees(-58.81688568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 303182"},
        {"Hipparcos Number", "HIP 52133"},
        {"Celescope Catalog", "CEL 3616"},
        {"Geneva Identification System", "GEN# +1.00303182"},
        {"Geneva Identification System 2", "GEN# -0.05802475"},
        {"Geneva Identification System 3", "GEN# +5.40990024"},
        {"Smithsonian Astrophysical Observation", "SAO 238305"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.76224445),
        dec: Angle.Degrees(-58.81560689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204611"},
        {"Hipparcos Number", "HIP 106316"},
        {"Smithsonian Astrophysical Observation", "SAO 247066"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.00306437),
        dec: Angle.Degrees(-58.81509469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154901"},
        {"Hipparcos Number", "HIP 84111"},
        {"Smithsonian Astrophysical Observation", "SAO 244498"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.93447925),
        dec: Angle.Degrees(-58.81499969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100122"},
        {"Hipparcos Number", "HIP 56163"},
        {"Smithsonian Astrophysical Observation", "SAO 239130"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.69291066),
        dec: Angle.Degrees(-58.81153874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207928"},
        {"Hipparcos Number", "HIP 108146"},
        {"Smithsonian Astrophysical Observation", "SAO 247222"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.65265307),
        dec: Angle.Degrees(-58.80982835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1485"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.61599568),
        dec: Angle.Degrees(-35.31207269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85469"},
        {"Hipparcos Number", "HIP 48222"},
        {"Celescope Catalog", "CEL 3386"},
        {"Smithsonian Astrophysical Observation", "SAO 237389"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.47378000),
        dec: Angle.Degrees(-58.80956000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3076"},
        {"Hipparcos Number", "HIP 2630"},
        {"Smithsonian Astrophysical Observation", "SAO 232086"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.34880794),
        dec: Angle.Degrees(-58.80911559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214392"},
        {"Hipparcos Number", "HIP 111834"},
        {"Smithsonian Astrophysical Observation", "SAO 247530"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.78699989),
        dec: Angle.Degrees(-58.80805663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147919"},
        {"Hipparcos Number", "HIP 80643"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.98674419),
        dec: Angle.Degrees(-58.80802930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18547"},
        {"Hipparcos Number", "HIP 13691"},
        {"Smithsonian Astrophysical Observation", "SAO 232943"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.08218569),
        dec: Angle.Degrees(-58.80780342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7066"},
        {"Hipparcos Number", "HIP 5463"},
        {"Smithsonian Astrophysical Observation", "SAO 232321"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.48592621),
        dec: Angle.Degrees(-58.80777786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56961"},
        {"Hipparcos Number", "HIP 35121"},
        {"Smithsonian Astrophysical Observation", "SAO 235056"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.91494804),
        dec: Angle.Degrees(-58.80555905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113782"},
        {"Hipparcos Number", "HIP 64016"},
        {"Smithsonian Astrophysical Observation", "SAO 240559"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.75999070),
        dec: Angle.Degrees(-58.80544740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138640"},
        {"Hipparcos Number", "HIP 76394"},
        {"Geneva Identification System", "GEN# +1.00138640"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.04436355),
        dec: Angle.Degrees(-58.80431266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17813"},
        {"Hipparcos Number", "HIP 13140"},
        {"Geneva Identification System", "GEN# +1.00017813"},
        {"Smithsonian Astrophysical Observation", "SAO 232905"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.24649863),
        dec: Angle.Degrees(-58.80346754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117930"},
        {"Hipparcos Number", "HIP 66278"},
        {"Smithsonian Astrophysical Observation", "SAO 240963"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.76084399),
        dec: Angle.Degrees(-58.80304449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31187"},
        {"Hipparcos Number", "HIP 22469"},
        {"Smithsonian Astrophysical Observation", "SAO 233706"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.52898569),
        dec: Angle.Degrees(-58.80122283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135379"},
        {"Hipparcos Number", "HIP 74824"},
        {"Fundamental Katalog 5th Edition", "FK5 561"},
        {"Geneva Identification System", "GEN# +1.00135379"},
        {"Renson", "Renson 38420"},
        {"Smithsonian Astrophysical Observation", "SAO 242384"},
        {"Wilson Evans Batten Catalogue", "WEB 12764"},
    },
    visualMagnitude: 4.07,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.37900090),
        dec: Angle.Degrees(-58.80087882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71085"},
        {"Hipparcos Number", "HIP 41030"},
        {"Geneva Identification System", "GEN# +1.00071085"},
        {"Smithsonian Astrophysical Observation", "SAO 235929"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.60966881),
        dec: Angle.Degrees(-58.79857640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73308"},
        {"Hipparcos Number", "HIP 42100"},
        {"Geneva Identification System", "GEN# +1.00073308"},
        {"Smithsonian Astrophysical Observation", "SAO 236099"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.71967609),
        dec: Angle.Degrees(-58.79597513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79476"},
        {"Hipparcos Number", "HIP 45144"},
        {"Celescope Catalog", "CEL 3221"},
        {"Geneva Identification System", "GEN# +1.00079476"},
        {"Smithsonian Astrophysical Observation", "SAO 236713"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.96444409),
        dec: Angle.Degrees(-58.79516702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84850"},
        {"Hipparcos Number", "HIP 47913"},
        {"Geneva Identification System", "GEN# +1.00084850"},
        {"Smithsonian Astrophysical Observation", "SAO 237321"},
        {"Wilson Evans Batten Catalogue", "WEB 8963"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.48259392),
        dec: Angle.Degrees(-58.79400021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96620"},
        {"Hipparcos Number", "HIP 54337"},
        {"Geneva Identification System", "GEN# +2.35320345"},
        {"Smithsonian Astrophysical Observation", "SAO 238785"},
        {"New General Catalogue", "NGC 3532 174"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.72749131),
        dec: Angle.Degrees(-58.79339341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129243"},
        {"Hipparcos Number", "HIP 72019"},
        {"Geneva Identification System", "GEN# +1.00129243"},
        {"Smithsonian Astrophysical Observation", "SAO 241942"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.95732990),
        dec: Angle.Degrees(-58.79330193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99893"},
        {"Hipparcos Number", "HIP 56033"},
        {"Smithsonian Astrophysical Observation", "SAO 239105"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.26619747),
        dec: Angle.Degrees(-58.79184107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30362"},
        {"Hipparcos Number", "HIP 21977"},
        {"Smithsonian Astrophysical Observation", "SAO 233649"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.86352670),
        dec: Angle.Degrees(-58.78958898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120059"},
        {"Hipparcos Number", "HIP 67393"},
        {"Geneva Identification System", "GEN# +1.00120059"},
        {"Renson", "Renson 34630"},
        {"Smithsonian Astrophysical Observation", "SAO 241187"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.17969419),
        dec: Angle.Degrees(-58.78785861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99048"},
        {"Hipparcos Number", "HIP 55594"},
        {"Smithsonian Astrophysical Observation", "SAO 239020"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.82231327),
        dec: Angle.Degrees(-58.78750511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118978"},
        {"Hipparcos Number", "HIP 66849"},
        {"Geneva Identification System", "GEN# +1.00118978"},
        {"Smithsonian Astrophysical Observation", "SAO 241080"},
        {"Wilson Evans Batten Catalogue", "WEB 11784"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.50467442),
        dec: Angle.Degrees(-58.78704974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108071"},
        {"Hipparcos Number", "HIP 60596"},
        {"Geneva Identification System", "GEN# +1.00108071"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.29995335),
        dec: Angle.Degrees(-58.78689939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114836"},
        {"Hipparcos Number", "HIP 64582"},
        {"Geneva Identification System", "GEN# +1.00114836"},
        {"Smithsonian Astrophysical Observation", "SAO 240665"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.56002582),
        dec: Angle.Degrees(-58.78371353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96305"},
        {"Hipparcos Number", "HIP 54197"},
        {"Geneva Identification System", "GEN# +2.35320049"},
        {"Smithsonian Astrophysical Observation", "SAO 238755"},
        {"New General Catalogue", "NGC 3532 82"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.31962455),
        dec: Angle.Degrees(-58.78367675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105998"},
        {"Hipparcos Number", "HIP 59483"},
        {"Geneva Identification System", "GEN# +1.00105998"},
        {"Wilson Evans Batten Catalogue", "WEB 10574"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99653645),
        dec: Angle.Degrees(-58.78353930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213415"},
        {"Hipparcos Number", "HIP 111272"},
        {"Cincinnati Publication", "Ci 20 1367"},
        {"Geneva Identification System", "GEN# +1.00213415"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.13902519),
        dec: Angle.Degrees(-58.78326929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225051"},
        {"Hipparcos Number", "HIP 231"},
        {"Smithsonian Astrophysical Observation", "SAO 231906"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.72341351),
        dec: Angle.Degrees(-58.78139077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90066"},
        {"Hipparcos Number", "HIP 50769"},
        {"Geneva Identification System", "GEN# +1.00090066"},
        {"Smithsonian Astrophysical Observation", "SAO 237986"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.51200234),
        dec: Angle.Degrees(-58.78069748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124395"},
        {"Hipparcos Number", "HIP 69648"},
        {"Geneva Identification System", "GEN# +1.00124395"},
        {"Smithsonian Astrophysical Observation", "SAO 241565"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.81784302),
        dec: Angle.Degrees(-58.78036286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171795"},
        {"Hipparcos Number", "HIP 91565"},
        {"Geneva Identification System", "GEN# +1.00171795"},
        {"Smithsonian Astrophysical Observation", "SAO 245622"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08760868),
        dec: Angle.Degrees(-58.77987032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191439"},
        {"Hipparcos Number", "HIP 99615"},
        {"Geneva Identification System", "GEN# +1.00191439"},
        {"Renson", "Renson 53340"},
        {"Smithsonian Astrophysical Observation", "SAO 246484"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.24009028),
        dec: Angle.Degrees(-58.77897843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87013"},
        {"Hipparcos Number", "HIP 49045"},
        {"Geneva Identification System", "GEN# +1.00087013"},
        {"Smithsonian Astrophysical Observation", "SAO 237585"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.11031872),
        dec: Angle.Degrees(-58.77838305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217916"},
        {"Hipparcos Number", "HIP 113982"},
        {"Smithsonian Astrophysical Observation", "SAO 247714"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25244169),
        dec: Angle.Degrees(-58.77552271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139491"},
        {"Hipparcos Number", "HIP 76841"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.34722681),
        dec: Angle.Degrees(-58.77507051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39061"},
        {"Hipparcos Number", "HIP 27233"},
        {"Smithsonian Astrophysical Observation", "SAO 234130"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.56761267),
        dec: Angle.Degrees(-58.77474062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1190"},
        {"Hipparcos Number", "HIP 1283"},
        {"Smithsonian Astrophysical Observation", "SAO 231983"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.01541270),
        dec: Angle.Degrees(-58.77389592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42524"},
        {"Hipparcos Number", "HIP 29019"},
        {"Smithsonian Astrophysical Observation", "SAO 234328"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.85163728),
        dec: Angle.Degrees(-58.77380134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194662"},
        {"Hipparcos Number", "HIP 101115"},
        {"Smithsonian Astrophysical Observation", "SAO 246607"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.44218997),
        dec: Angle.Degrees(-58.77202114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92809"},
        {"Hipparcos Number", "HIP 52331"},
        {"Celescope Catalog", "CEL 3646"},
        {"Geneva Identification System", "GEN# +1.00092809"},
        {"Smithsonian Astrophysical Observation", "SAO 238363"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.40971779),
        dec: Angle.Degrees(-58.77187678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10850"},
        {"Hipparcos Number", "HIP 8141"},
        {"Geneva Identification System", "GEN# +1.00010850"},
        {"Smithsonian Astrophysical Observation", "SAO 232513"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.16844488),
        dec: Angle.Degrees(-58.77175813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222074"},
        {"Hipparcos Number", "HIP 116597"},
        {"Geneva Identification System", "GEN# +1.00222074"},
        {"Smithsonian Astrophysical Observation", "SAO 247956"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.44716172),
        dec: Angle.Degrees(-58.76881874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214125"},
        {"Hipparcos Number", "HIP 111693"},
        {"Geneva Identification System", "GEN# +1.00214125"},
        {"Smithsonian Astrophysical Observation", "SAO 247515"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.38487138),
        dec: Angle.Degrees(-58.76528823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139506"},
        {"Hipparcos Number", "HIP 76846"},
        {"Smithsonian Astrophysical Observation", "SAO 242831"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.36497779),
        dec: Angle.Degrees(-58.76362039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9043"},
    },
    visualMagnitude: 12.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.13254018),
        dec: Angle.Degrees(-58.76356992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123347"},
        {"Hipparcos Number", "HIP 69123"},
        {"Smithsonian Astrophysical Observation", "SAO 241479"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.24242277),
        dec: Angle.Degrees(-58.76276475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163563"},
        {"Hipparcos Number", "HIP 88162"},
        {"Smithsonian Astrophysical Observation", "SAO 245160"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.09101786),
        dec: Angle.Degrees(-58.76129060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115265"},
        {"Hipparcos Number", "HIP 64821"},
        {"Smithsonian Astrophysical Observation", "SAO 240708"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.30492190),
        dec: Angle.Degrees(-58.76065482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1705"},
        {"Hipparcos Number", "HIP 1683"},
        {"Smithsonian Astrophysical Observation", "SAO 232005"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.26232052),
        dec: Angle.Degrees(-58.76053723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103636"},
        {"Cincinnati Publication", "Ci 20 1247"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.96340874),
        dec: Angle.Degrees(-58.75774035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -348.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86270"},
        {"Hipparcos Number", "HIP 48658"},
    },
    visualMagnitude: 9.64,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.84713776),
        dec: Angle.Degrees(-58.75669586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96175"},
        {"Hipparcos Number", "HIP 54147"},
        {"Geneva Identification System", "GEN# +2.35320160"},
        {"Smithsonian Astrophysical Observation", "SAO 238740"},
        {"New General Catalogue", "NGC 3532 43"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.14990045),
        dec: Angle.Degrees(-58.75581569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46860"},
        {"Henry Draper 2", "HD 46860A"},
        {"Hipparcos Number", "HIP 31137"},
        {"Geneva Identification System", "GEN# +1.00046860"},
        {"Smithsonian Astrophysical Observation", "SAO 234564"},
        {"Wilson Evans Batten Catalogue", "WEB 6210"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.99296524),
        dec: Angle.Degrees(-58.75384073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12261"},
    },
    visualMagnitude: 12.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.46958019),
        dec: Angle.Degrees(-58.75358168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204597"},
        {"Hipparcos Number", "HIP 106313"},
        {"Smithsonian Astrophysical Observation", "SAO 247065"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.98035055),
        dec: Angle.Degrees(-58.75013325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59747",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Imai"},
        {"Henry Draper", "HD 106490"},
        {"Hipparcos Number", "HIP 59747"},
        {"Celescope Catalog", "CEL 4076"},
        {"Fundamental Katalog 5th Edition", "FK5 455"},
        {"Geneva Identification System", "GEN# +1.00106490"},
        {"Smithsonian Astrophysical Observation", "SAO 239791"},
        {"Wilson Evans Batten Catalogue", "WEB 10614"},
    },
    visualMagnitude: 2.79,
    bvColour: -0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.78648733),
        dec: Angle.Degrees(-58.74890179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111791"},
        {"Hipparcos Number", "HIP 62823"},
        {"Geneva Identification System", "GEN# +1.00111791"},
        {"Smithsonian Astrophysical Observation", "SAO 240337"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.10441645),
        dec: Angle.Degrees(-58.74687173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27725"},
        {"Hipparcos Number", "HIP 20153"},
        {"Smithsonian Astrophysical Observation", "SAO 233484"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.79824021),
        dec: Angle.Degrees(-58.74666494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58806"},
        {"Smithsonian Astrophysical Observation", "SAO 239621"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93080004),
        dec: Angle.Degrees(-58.74656212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96564"},
        {"Hipparcos Number", "HIP 54306"},
        {"Celescope Catalog", "CEL 3811"},
        {"Geneva Identification System", "GEN# +2.35320215"},
        {"Smithsonian Astrophysical Observation", "SAO 238780"},
        {"New General Catalogue", "NGC 3532 163"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.64944027),
        dec: Angle.Degrees(-58.74417714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84862"},
        {"Hipparcos Number", "HIP 47928"},
        {"Smithsonian Astrophysical Observation", "SAO 237325"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.50805071),
        dec: Angle.Degrees(-58.74387262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114121"},
        {"Hipparcos Number", "HIP 64201"},
        {"Geneva Identification System", "GEN# +1.00114121"},
        {"Smithsonian Astrophysical Observation", "SAO 240602"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.36999309),
        dec: Angle.Degrees(-58.74211409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77369"},
        {"Hipparcos Number", "HIP 44149"},
        {"Smithsonian Astrophysical Observation", "SAO 236477"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.86707087),
        dec: Angle.Degrees(-58.74092214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86289"},
        {"Hipparcos Number", "HIP 48669"},
        {"Celescope Catalog", "CEL 3405"},
        {"Geneva Identification System", "GEN# +1.00086289"},
        {"Smithsonian Astrophysical Observation", "SAO 237503"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.88874148),
        dec: Angle.Degrees(-58.74080964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101683"},
        {"Hipparcos Number", "HIP 57041"},
        {"Smithsonian Astrophysical Observation", "SAO 239297"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.42200810),
        dec: Angle.Degrees(-58.74062128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87088"},
        {"Hipparcos Number", "HIP 49068"},
        {"Geneva Identification System", "GEN# +1.00087088"},
        {"Smithsonian Astrophysical Observation", "SAO 237594"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.22515485),
        dec: Angle.Degrees(-58.73943163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90853"},
        {"Hipparcos Number", "HIP 51232"},
        {"Celescope Catalog", "CEL 3546"},
        {"Fundamental Katalog 5th Edition", "FK5 393"},
        {"Geneva Identification System", "GEN# +1.00090853"},
        {"Smithsonian Astrophysical Observation", "SAO 238085"},
        {"Wilson Evans Batten Catalogue", "WEB 9364"},
    },
    visualMagnitude: 3.81,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.96977108),
        dec: Angle.Degrees(-58.73940856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121659"},
        {"Hipparcos Number", "HIP 68259"},
        {"Smithsonian Astrophysical Observation", "SAO 241335"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.60474517),
        dec: Angle.Degrees(-58.73837813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89161"},
        {"Hipparcos Number", "HIP 50235"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.84372005),
        dec: Angle.Degrees(-58.73629020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35738"},
        {"Smithsonian Astrophysical Observation", "SAO 235151"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.57767446),
        dec: Angle.Degrees(-58.73533875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81293"},
        {"Hipparcos Number", "HIP 45956"},
        {"Celescope Catalog", "CEL 3279"},
        {"Geneva Identification System", "GEN# +1.00081293"},
        {"Smithsonian Astrophysical Observation", "SAO 236897"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.58717550),
        dec: Angle.Degrees(-58.73477053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92207"},
        {"Hipparcos Number", "HIP 52004"},
        {"Celescope Catalog", "CEL 3601"},
        {"Geneva Identification System", "GEN# +2.33240001"},
        {"Smithsonian Astrophysical Observation", "SAO 238271"},
        {"Wilson Evans Batten Catalogue", "WEB 9487"},
        {"New General Catalogue", "NGC 3324 1"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36281779),
        dec: Angle.Degrees(-58.73334704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65252"},
        {"Hipparcos Number", "HIP 38631"},
        {"Geneva Identification System", "GEN# +1.00065252"},
        {"Smithsonian Astrophysical Observation", "SAO 235611"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.65562456),
        dec: Angle.Degrees(-58.73220458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86140"},
        {"Hipparcos Number", "HIP 48594"},
        {"Cincinnati Publication", "Ci 20 555"},
        {"Geneva Identification System", "GEN# +1.00086140"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64783236),
        dec: Angle.Degrees(-58.73088972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -373.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 445.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80457"},
        {"Hipparcos Number", "HIP 45580"},
        {"Geneva Identification System", "GEN# +1.00080457"},
        {"Smithsonian Astrophysical Observation", "SAO 236816"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.34787386),
        dec: Angle.Degrees(-58.72987754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192949"},
        {"Hipparcos Number", "HIP 100305"},
        {"Renson", "Renson 53860"},
        {"Smithsonian Astrophysical Observation", "SAO 246534"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.15931847),
        dec: Angle.Degrees(-58.72948607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39876"},
        {"Hipparcos Number", "HIP 27677"},
        {"Smithsonian Astrophysical Observation", "SAO 234176"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.89551880),
        dec: Angle.Degrees(-58.72691441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142758"},
        {"Hipparcos Number", "HIP 78310"},
        {"Geneva Identification System", "GEN# +1.00142758"},
        {"Smithsonian Astrophysical Observation", "SAO 243196"},
        {"Wilson Evans Batten Catalogue", "WEB 13240"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.84894100),
        dec: Angle.Degrees(-58.72620926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75086"},
        {"Hipparcos Number", "HIP 42936"},
        {"Celescope Catalog", "CEL 2868"},
        {"Geneva Identification System", "GEN# +1.00075086J"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.27312609),
        dec: Angle.Degrees(-58.72432020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180257"},
        {"Hipparcos Number", "HIP 94950"},
        {"Geneva Identification System", "GEN# +1.00180257"},
        {"Smithsonian Astrophysical Observation", "SAO 246022"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.82193982),
        dec: Angle.Degrees(-58.72186247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9424"},
        {"Hipparcos Number", "HIP 7091"},
        {"Geneva Identification System", "GEN# +1.00009424"},
        {"Smithsonian Astrophysical Observation", "SAO 232447"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.84065221),
        dec: Angle.Degrees(-58.71966965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 366.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173776"},
        {"Hipparcos Number", "HIP 92464"},
        {"Smithsonian Astrophysical Observation", "SAO 245744"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.65632811),
        dec: Angle.Degrees(-58.71028770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170525"},
        {"Hipparcos Number", "HIP 90981"},
        {"Geneva Identification System", "GEN# +1.00170525"},
        {"Smithsonian Astrophysical Observation", "SAO 245547"},
        {"Wilson Evans Batten Catalogue", "WEB 15607"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37268558),
        dec: Angle.Degrees(-58.70853166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91295"},
        {"Hipparcos Number", "HIP 51498"},
        {"Celescope Catalog", "CEL 3561"},
        {"Geneva Identification System", "GEN# +1.00091295"},
        {"Smithsonian Astrophysical Observation", "SAO 238142"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.76220839),
        dec: Angle.Degrees(-58.70777417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166476"},
        {"Hipparcos Number", "HIP 89375"},
        {"Smithsonian Astrophysical Observation", "SAO 245329"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.58376025),
        dec: Angle.Degrees(-58.70580181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98732"},
        {"Hipparcos Number", "HIP 55415"},
        {"Geneva Identification System", "GEN# +1.00098732"},
        {"Smithsonian Astrophysical Observation", "SAO 238985"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.23064758),
        dec: Angle.Degrees(-58.70367579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -302.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57291",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Uklun"},
        {"Henry Draper", "HD 102117"},
        {"Hipparcos Number", "HIP 57291"},
        {"Geneva Identification System", "GEN# +1.00102117"},
        {"Smithsonian Astrophysical Observation", "SAO 239348"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21055164),
        dec: Angle.Degrees(-58.70353973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94332"},
        {"Hipparcos Number", "HIP 53129"},
        {"Geneva Identification System", "GEN# +1.00094332"},
        {"Smithsonian Astrophysical Observation", "SAO 238548"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.02654245),
        dec: Angle.Degrees(-58.69993656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133660"},
        {"Hipparcos Number", "HIP 74076"},
        {"Geneva Identification System", "GEN# +1.00133660"},
        {"Smithsonian Astrophysical Observation", "SAO 242243"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.06758026),
        dec: Angle.Degrees(-58.69938437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21177"},
        {"Hipparcos Number", "HIP 15695"},
        {"Fundamental Katalog 5th Edition", "FK5 4307"},
        {"Smithsonian Astrophysical Observation", "SAO 233086"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.54840767),
        dec: Angle.Degrees(-58.69828129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133682"},
        {"Hipparcos Number", "HIP 74086"},
        {"Geneva Identification System", "GEN# +1.00133682"},
        {"Smithsonian Astrophysical Observation", "SAO 242246"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.09734627),
        dec: Angle.Degrees(-58.69752561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70175"},
        {"Hipparcos Number", "HIP 40621"},
        {"Geneva Identification System", "GEN# +1.00070175"},
        {"Smithsonian Astrophysical Observation", "SAO 235869"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.39254215),
        dec: Angle.Degrees(-58.69752017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86181"},
        {"Hipparcos Number", "HIP 48619"},
        {"Geneva Identification System", "GEN# +1.00086181"},
        {"Renson", "Renson 24630"},
        {"Smithsonian Astrophysical Observation", "SAO 237494"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72265569),
        dec: Angle.Degrees(-58.69597556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218090"},
        {"Hipparcos Number", "HIP 114072"},
        {"Geneva Identification System", "GEN# +1.00218090"},
        {"Smithsonian Astrophysical Observation", "SAO 247723"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.54533739),
        dec: Angle.Degrees(-58.69386109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203413"},
        {"Hipparcos Number", "HIP 105675"},
        {"Smithsonian Astrophysical Observation", "SAO 247011"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.06351940),
        dec: Angle.Degrees(-58.69225955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76718"},
        {"Hipparcos Number", "HIP 43796"},
        {"Smithsonian Astrophysical Observation", "SAO 236407"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.79522283),
        dec: Angle.Degrees(-58.69065225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81654"},
        {"Hipparcos Number", "HIP 46147"},
        {"Celescope Catalog", "CEL 3285"},
        {"Geneva Identification System", "GEN# +1.00081654"},
        {"Smithsonian Astrophysical Observation", "SAO 236941"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.16452618),
        dec: Angle.Degrees(-58.68904359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142491"},
        {"Hipparcos Number", "HIP 78189"},
        {"Smithsonian Astrophysical Observation", "SAO 243162"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.48135029),
        dec: Angle.Degrees(-58.68776618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140178"},
        {"Henry Draper 2", "HD 140179"},
        {"Hipparcos Number", "HIP 77160"},
        {"Smithsonian Astrophysical Observation", "SAO 242913"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.31759318),
        dec: Angle.Degrees(-58.68713469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125015"},
        {"Hipparcos Number", "HIP 69949"},
        {"Geneva Identification System", "GEN# +1.00125015J"},
        {"Smithsonian Astrophysical Observation", "SAO 241620"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.71243406),
        dec: Angle.Degrees(-58.68640691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215660"},
        {"Hipparcos Number", "HIP 112569"},
        {"Smithsonian Astrophysical Observation", "SAO 247586"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.98914906),
        dec: Angle.Degrees(-58.68473097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114835"},
        {"Hipparcos Number", "HIP 64580"},
        {"Fundamental Katalog 5th Edition", "FK5 3055"},
        {"Geneva Identification System", "GEN# +1.00114835"},
        {"Smithsonian Astrophysical Observation", "SAO 240663"},
        {"Wilson Evans Batten Catalogue", "WEB 11422"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.55062387),
        dec: Angle.Degrees(-58.68390821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142137"},
        {"Hipparcos Number", "HIP 78026"},
        {"Geneva Identification System", "GEN# +1.00142137"},
        {"Smithsonian Astrophysical Observation", "SAO 243127"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.98131019),
        dec: Angle.Degrees(-58.68367435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140177"},
        {"Hipparcos Number", "HIP 77156"},
        {"Geneva Identification System", "GEN# +1.00140177"},
        {"Smithsonian Astrophysical Observation", "SAO 242911"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.30200233),
        dec: Angle.Degrees(-58.68314646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99734"},
        {"Hipparcos Number", "HIP 55938"},
        {"Celescope Catalog", "CEL 3903"},
        {"Geneva Identification System", "GEN# +1.00099734"},
        {"Smithsonian Astrophysical Observation", "SAO 239091"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.96287103),
        dec: Angle.Degrees(-58.68048980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85253"},
        {"Hipparcos Number", "HIP 48108"},
        {"Smithsonian Astrophysical Observation", "SAO 237368"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.13433380),
        dec: Angle.Degrees(-58.67608478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96544"},
        {"Hipparcos Number", "HIP 54294"},
        {"Smithsonian Astrophysical Observation", "SAO 238779"},
        {"New General Catalogue", "NGC 3532 156"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.62208089),
        dec: Angle.Degrees(-58.67503584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25482"},
        {"Hipparcos Number", "HIP 18659"},
        {"Smithsonian Astrophysical Observation", "SAO 233352"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.91939532),
        dec: Angle.Degrees(-58.67484019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58092"},
        {"Hipparcos Number", "HIP 35590"},
        {"Smithsonian Astrophysical Observation", "SAO 235128"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.16310845),
        dec: Angle.Degrees(-58.67328103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27493"},
        {"Smithsonian Astrophysical Observation", "SAO 234149"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.32686877),
        dec: Angle.Degrees(-58.67119068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103415"},
        {"Hipparcos Number", "HIP 58048"},
        {"Smithsonian Astrophysical Observation", "SAO 239478"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.59168767),
        dec: Angle.Degrees(-58.66886075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218913"},
        {"Hipparcos Number", "HIP 114571"},
        {"Smithsonian Astrophysical Observation", "SAO 247771"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.14572839),
        dec: Angle.Degrees(-58.66881691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77478"},
        {"Hipparcos Number", "HIP 44195"},
        {"Smithsonian Astrophysical Observation", "SAO 236490"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.03696004),
        dec: Angle.Degrees(-58.66825304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91533"},
        {"Hipparcos Number", "HIP 51623"},
        {"Celescope Catalog", "CEL 3567"},
        {"Geneva Identification System", "GEN# +1.00091533"},
        {"Smithsonian Astrophysical Observation", "SAO 238168"},
        {"Wilson Evans Batten Catalogue", "WEB 9418"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.19923561),
        dec: Angle.Degrees(-58.66675023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96245"},
        {"Hipparcos Number", "HIP 54177"},
        {"Celescope Catalog", "CEL 3794"},
        {"Geneva Identification System", "GEN# +2.35320139"},
        {"Smithsonian Astrophysical Observation", "SAO 238742"},
        {"New General Catalogue", "NGC 3532 63"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.23523814),
        dec: Angle.Degrees(-58.66598054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156905"},
        {"Hipparcos Number", "HIP 85116"},
        {"Smithsonian Astrophysical Observation", "SAO 244693"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.93477891),
        dec: Angle.Degrees(-58.66521283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117253"},
        {"Hipparcos Number", "HIP 65891"},
        {"Geneva Identification System", "GEN# +1.00117253"},
        {"Smithsonian Astrophysical Observation", "SAO 240897"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.60542365),
        dec: Angle.Degrees(-58.66433368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25614"},
        {"Hipparcos Number", "HIP 18731"},
        {"Smithsonian Astrophysical Observation", "SAO 233362"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.18682869),
        dec: Angle.Degrees(-58.66175677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186919"},
        {"Hipparcos Number", "HIP 97615"},
        {"Smithsonian Astrophysical Observation", "SAO 246288"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.59954431),
        dec: Angle.Degrees(-58.65926904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61196"},
        {"Hipparcos Number", "HIP 36862"},
        {"Geneva Identification System", "GEN# +1.00061196"},
        {"Smithsonian Astrophysical Observation", "SAO 235322"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.67917896),
        dec: Angle.Degrees(-58.65699616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49821"},
        {"Hipparcos Number", "HIP 32472"},
        {"Fundamental Katalog 5th Edition", "FK5 4617"},
        {"Geneva Identification System", "GEN# +1.00049821"},
        {"Smithsonian Astrophysical Observation", "SAO 234706"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.65818989),
        dec: Angle.Degrees(-58.65694202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78711"},
        {"Hipparcos Number", "HIP 44742"},
        {"Smithsonian Astrophysical Observation", "SAO 236620"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.76933747),
        dec: Angle.Degrees(-58.65598419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163239"},
        {"Hipparcos Number", "HIP 88025"},
        {"Smithsonian Astrophysical Observation", "SAO 245148"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.69264263),
        dec: Angle.Degrees(-58.65595355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192255"},
        {"Hipparcos Number", "HIP 99977"},
        {"Smithsonian Astrophysical Observation", "SAO 246512"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.24037058),
        dec: Angle.Degrees(-58.65532900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130170"},
        {"Hipparcos Number", "HIP 72452"},
        {"Smithsonian Astrophysical Observation", "SAO 242018"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.23791329),
        dec: Angle.Degrees(-58.65518493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82739"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.66956073),
        dec: Angle.Degrees(-35.22473381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64676"},
        {"Hipparcos Number", "HIP 38377"},
        {"Smithsonian Astrophysical Observation", "SAO 235574"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.93621312),
        dec: Angle.Degrees(-58.65238886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123204"},
        {"Hipparcos Number", "HIP 69056"},
        {"Geneva Identification System", "GEN# +1.00123204"},
        {"Smithsonian Astrophysical Observation", "SAO 241468"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.02008876),
        dec: Angle.Degrees(-58.65076931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10470"},
        {"Hipparcos Number", "HIP 7815"},
        {"Smithsonian Astrophysical Observation", "SAO 232494"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.13522397),
        dec: Angle.Degrees(-58.64748775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67126"},
        {"Cincinnati Publication", "Ci 20 799"},
        {"Geneva Identification System", "GEN# -0.05805131"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.36996550),
        dec: Angle.Degrees(-58.64514600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -485.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97533"},
        {"Hipparcos Number", "HIP 54753"},
        {"Celescope Catalog", "CEL 3848"},
        {"Geneva Identification System", "GEN# +1.00097533"},
        {"Smithsonian Astrophysical Observation", "SAO 238862"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.15173470),
        dec: Angle.Degrees(-58.64400654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22358"},
        {"Hipparcos Number", "HIP 16542"},
        {"Smithsonian Astrophysical Observation", "SAO 233158"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.26513809),
        dec: Angle.Degrees(-58.64171188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195250"},
        {"Hipparcos Number", "HIP 101416"},
        {"Smithsonian Astrophysical Observation", "SAO 246628"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.28423631),
        dec: Angle.Degrees(-58.64154669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90657"},
        {"Hipparcos Number", "HIP 51109"},
        {"Geneva Identification System", "GEN# +1.00090657"},
        {"Wilson Evans Batten Catalogue", "WEB 9343"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.63089658),
        dec: Angle.Degrees(-58.64061326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196864"},
        {"Hipparcos Number", "HIP 102229"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.71576403),
        dec: Angle.Degrees(-58.63669356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166041"},
        {"Hipparcos Number", "HIP 89219"},
        {"Smithsonian Astrophysical Observation", "SAO 245308"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.10757436),
        dec: Angle.Degrees(-58.63494500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194274"},
        {"Hipparcos Number", "HIP 100918"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.91933801),
        dec: Angle.Degrees(-58.63190402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152641"},
        {"Hipparcos Number", "HIP 83028"},
        {"Smithsonian Astrophysical Observation", "SAO 244300"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.50439846),
        dec: Angle.Degrees(-58.63186911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62758"},
        {"Hipparcos Number", "HIP 37530"},
        {"Fundamental Katalog 5th Edition", "FK5 2600"},
        {"Geneva Identification System", "GEN# +1.00062758"},
        {"Smithsonian Astrophysical Observation", "SAO 235430"},
        {"Wilson Evans Batten Catalogue", "WEB 7425"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.54259877),
        dec: Angle.Degrees(-58.63093533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149418"},
        {"Hipparcos Number", "HIP 81431"},
        {"Smithsonian Astrophysical Observation", "SAO 244002"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.49537528),
        dec: Angle.Degrees(-58.63083885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102367"},
        {"Hipparcos Number", "HIP 57457"},
        {"Geneva Identification System", "GEN# +1.00102367"},
        {"Smithsonian Astrophysical Observation", "SAO 239370"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.67496397),
        dec: Angle.Degrees(-58.62979445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29016"},
        {"Hipparcos Number", "HIP 21048"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.68702394),
        dec: Angle.Degrees(-58.62657775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4085"},
        {"Hipparcos Number", "HIP 3336"},
        {"Smithsonian Astrophysical Observation", "SAO 232158"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.63650279),
        dec: Angle.Degrees(-58.62626734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119020"},
        {"Hipparcos Number", "HIP 66870"},
        {"Geneva Identification System", "GEN# +1.00119020"},
        {"Smithsonian Astrophysical Observation", "SAO 241084"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.57249672),
        dec: Angle.Degrees(-58.61962180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136915"},
        {"Hipparcos Number", "HIP 75540"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.48944034),
        dec: Angle.Degrees(-58.61679845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128917"},
        {"Hipparcos Number", "HIP 71861"},
        {"Geneva Identification System", "GEN# +1.00128917"},
        {"Smithsonian Astrophysical Observation", "SAO 241912"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48305391),
        dec: Angle.Degrees(-58.61573462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118569"},
        {"Hipparcos Number", "HIP 66605"},
        {"Smithsonian Astrophysical Observation", "SAO 241034"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.79670162),
        dec: Angle.Degrees(-58.61438700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107025"},
        {"Hipparcos Number", "HIP 60036"},
        {"Smithsonian Astrophysical Observation", "SAO 239832"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.68032840),
        dec: Angle.Degrees(-58.61418616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87419"},
        {"Hipparcos Number", "HIP 49238"},
        {"Smithsonian Astrophysical Observation", "SAO 237641"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.77054294),
        dec: Angle.Degrees(-58.61180527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108699"},
        {"Hipparcos Number", "HIP 60949"},
        {"Geneva Identification System", "GEN# +1.00108699"},
        {"Smithsonian Astrophysical Observation", "SAO 239994"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.41071796),
        dec: Angle.Degrees(-58.60889283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156204"},
        {"Hipparcos Number", "HIP 84777"},
        {"Smithsonian Astrophysical Observation", "SAO 244622"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.93088451),
        dec: Angle.Degrees(-58.60782660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147242"},
        {"Hipparcos Number", "HIP 80336"},
        {"Geneva Identification System", "GEN# +1.00147242"},
        {"Smithsonian Astrophysical Observation", "SAO 243736"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.00431395),
        dec: Angle.Degrees(-58.60549542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105272"},
        {"Hipparcos Number", "HIP 59106"},
        {"Geneva Identification System", "GEN# +1.00105272"},
        {"Smithsonian Astrophysical Observation", "SAO 239677"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.80774637),
        dec: Angle.Degrees(-58.60331328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104214"},
        {"Hipparcos Number", "HIP 58513"},
        {"Geneva Identification System", "GEN# +1.00104214"},
    },
    visualMagnitude: 8.89,
    bvColour: 2.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.99493129),
        dec: Angle.Degrees(-58.60078291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147977"},
        {"Hipparcos Number", "HIP 80675"},
        {"Fundamental Katalog 5th Edition", "FK5 3297"},
        {"Geneva Identification System", "GEN# +1.00147977"},
        {"Smithsonian Astrophysical Observation", "SAO 243836"},
        {"Wilson Evans Batten Catalogue", "WEB 13644"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06326516),
        dec: Angle.Degrees(-58.59970914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101314"},
        {"Hipparcos Number", "HIP 56839"},
        {"Geneva Identification System", "GEN# +1.00101314"},
        {"Smithsonian Astrophysical Observation", "SAO 239258"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.78800487),
        dec: Angle.Degrees(-58.59773364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158293"},
        {"Hipparcos Number", "HIP 85807"},
        {"Renson", "Renson 44540"},
        {"Smithsonian Astrophysical Observation", "SAO 244815"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.99488338),
        dec: Angle.Degrees(-58.59762675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155099"},
        {"Hipparcos Number", "HIP 84229"},
        {"Geneva Identification System", "GEN# +1.00155099"},
        {"Smithsonian Astrophysical Observation", "SAO 244518"},
        {"Wilson Evans Batten Catalogue", "WEB 14222"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.24672253),
        dec: Angle.Degrees(-58.59676079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174876"},
        {"Hipparcos Number", "HIP 92949"},
        {"Smithsonian Astrophysical Observation", "SAO 245812"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.06001783),
        dec: Angle.Degrees(-58.59515477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71902"},
        {"Hipparcos Number", "HIP 41416"},
        {"Smithsonian Astrophysical Observation", "SAO 235994"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.71605987),
        dec: Angle.Degrees(-58.59119151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170025"},
        {"Hipparcos Number", "HIP 90740"},
        {"Smithsonian Astrophysical Observation", "SAO 245516"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.72701347),
        dec: Angle.Degrees(-58.59069463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86691"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.70088082),
        dec: Angle.Degrees(-58.58872081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171191"},
        {"Hipparcos Number", "HIP 91261"},
        {"Smithsonian Astrophysical Observation", "SAO 245585"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.23019086),
        dec: Angle.Degrees(-58.58619483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83235"},
        {"Hipparcos Number", "HIP 47001"},
        {"Smithsonian Astrophysical Observation", "SAO 237124"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.68935837),
        dec: Angle.Degrees(-58.58616077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120577"},
        {"Hipparcos Number", "HIP 67677"},
        {"Geneva Identification System", "GEN# +1.00120577"},
        {"Smithsonian Astrophysical Observation", "SAO 241233"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.97175235),
        dec: Angle.Degrees(-58.58548409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113455"},
        {"Hipparcos Number", "HIP 63819"},
        {"Geneva Identification System", "GEN# +1.00113455"},
        {"Smithsonian Astrophysical Observation", "SAO 240523"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.19737159),
        dec: Angle.Degrees(-58.58479588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105284"},
        {"Hipparcos Number", "HIP 59116"},
        {"Geneva Identification System", "GEN# +1.00105284"},
        {"Smithsonian Astrophysical Observation", "SAO 239681"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.84006903),
        dec: Angle.Degrees(-58.58307990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64306"},
        {"Hipparcos Number", "HIP 38234"},
        {"Smithsonian Astrophysical Observation", "SAO 235551"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.49376188),
        dec: Angle.Degrees(-58.58159416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137603"},
        {"Hipparcos Number", "HIP 75863"},
        {"Geneva Identification System", "GEN# +1.00137603"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43622917),
        dec: Angle.Degrees(-58.58089551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10270"},
        {"Hipparcos Number", "HIP 7682"},
        {"Smithsonian Astrophysical Observation", "SAO 232486"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.73360331),
        dec: Angle.Degrees(-58.58024581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97512"},
        {"Hipparcos Number", "HIP 54733"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.09229546),
        dec: Angle.Degrees(-58.57659610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90454"},
        {"Hipparcos Number", "HIP 50993"},
        {"Geneva Identification System", "GEN# +1.00090454"},
        {"Smithsonian Astrophysical Observation", "SAO 238046"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.24791990),
        dec: Angle.Degrees(-58.57631762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110958"},
        {"Hipparcos Number", "HIP 62330"},
        {"Geneva Identification System", "GEN# +1.00110958"},
        {"Smithsonian Astrophysical Observation", "SAO 240233"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.59805740),
        dec: Angle.Degrees(-58.57498920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65170"},
        {"Hipparcos Number", "HIP 38600"},
        {"Geneva Identification System", "GEN# +1.00065170"},
        {"Smithsonian Astrophysical Observation", "SAO 235606"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55480960),
        dec: Angle.Degrees(-58.57449595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22069"},
        {"Hipparcos Number", "HIP 16333"},
        {"Geneva Identification System", "GEN# +1.00022069"},
        {"Smithsonian Astrophysical Observation", "SAO 233140"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.63570293),
        dec: Angle.Degrees(-58.57372197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123435"},
        {"Hipparcos Number", "HIP 69170"},
        {"Geneva Identification System", "GEN# +1.00123435"},
        {"Smithsonian Astrophysical Observation", "SAO 241485"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.37979498),
        dec: Angle.Degrees(-58.57312492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24578"},
        {"Hipparcos Number", "HIP 18043"},
        {"Smithsonian Astrophysical Observation", "SAO 233300"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.84758126),
        dec: Angle.Degrees(-58.57255339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129996"},
        {"Hipparcos Number", "HIP 72397"},
        {"Smithsonian Astrophysical Observation", "SAO 242003"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.03725505),
        dec: Angle.Degrees(-58.57169777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164806"},
        {"Hipparcos Number", "HIP 88702"},
        {"Geneva Identification System", "GEN# +1.00164806"},
        {"Smithsonian Astrophysical Observation", "SAO 245237"},
        {"Wilson Evans Batten Catalogue", "WEB 15029"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.62306865),
        dec: Angle.Degrees(-58.57092582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85120"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.94728348),
        dec: Angle.Degrees(-58.57010773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150407"},
        {"Hipparcos Number", "HIP 81937"},
        {"Smithsonian Astrophysical Observation", "SAO 244098"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.06707266),
        dec: Angle.Degrees(-58.56862396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82155"},
        {"Hipparcos Number", "HIP 46424"},
        {"Smithsonian Astrophysical Observation", "SAO 237011"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.99158964),
        dec: Angle.Degrees(-58.56827522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94409"},
        {"Hipparcos Number", "HIP 53183"},
        {"Smithsonian Astrophysical Observation", "SAO 238562"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.18158627),
        dec: Angle.Degrees(-58.56705299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36155"},
        {"Hipparcos Number", "HIP 25406"},
        {"Smithsonian Astrophysical Observation", "SAO 233977"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.51781192),
        dec: Angle.Degrees(-58.56144946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171022"},
        {"Hipparcos Number", "HIP 91173"},
        {"Renson", "Renson 47900"},
        {"Smithsonian Astrophysical Observation", "SAO 245573"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.99918715),
        dec: Angle.Degrees(-58.55914030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34376"},
        {"Hipparcos Number", "HIP 24334"},
        {"Smithsonian Astrophysical Observation", "SAO 233881"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.34117677),
        dec: Angle.Degrees(-58.55762843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158503"},
        {"Hipparcos Number", "HIP 85895"},
        {"Geneva Identification System", "GEN# +1.00158503"},
        {"Smithsonian Astrophysical Observation", "SAO 244829"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.29725549),
        dec: Angle.Degrees(-58.55755793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30387"},
        {"Hipparcos Number", "HIP 21994"},
        {"Smithsonian Astrophysical Observation", "SAO 233652"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.91145781),
        dec: Angle.Degrees(-58.55591868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89046"},
        {"Hipparcos Number", "HIP 50186"},
        {"Smithsonian Astrophysical Observation", "SAO 237827"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.67209398),
        dec: Angle.Degrees(-58.55301737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96226"},
        {"Hipparcos Number", "HIP 54174"},
        {"Celescope Catalog", "CEL 3793"},
        {"Geneva Identification System", "GEN# +2.35320409"},
        {"Smithsonian Astrophysical Observation", "SAO 238741"},
        {"New General Catalogue", "NGC 3532 60"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.22576291),
        dec: Angle.Degrees(-58.55195502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71109"},
        {"Hipparcos Number", "HIP 41054"},
        {"Smithsonian Astrophysical Observation", "SAO 235934"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65345131),
        dec: Angle.Degrees(-58.55133846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223754"},
        {"Hipparcos Number", "HIP 117716"},
        {"Geneva Identification System", "GEN# +1.00223754"},
        {"Smithsonian Astrophysical Observation", "SAO 248048"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.11853139),
        dec: Angle.Degrees(-58.55017432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31746"},
        {"Hipparcos Number", "HIP 22844"},
        {"Geneva Identification System", "GEN# +1.00031746"},
        {"Smithsonian Astrophysical Observation", "SAO 233733"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.72051578),
        dec: Angle.Degrees(-58.54781783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153447"},
        {"Hipparcos Number", "HIP 83429"},
        {"Smithsonian Astrophysical Observation", "SAO 244384"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77998199),
        dec: Angle.Degrees(-58.54719687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91477"},
        {"Hipparcos Number", "HIP 51593"},
        {"Celescope Catalog", "CEL 3565"},
        {"Geneva Identification System", "GEN# +1.00091477"},
        {"Smithsonian Astrophysical Observation", "SAO 238159"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.08790848),
        dec: Angle.Degrees(-58.54584976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45450"},
        {"Hipparcos Number", "HIP 30423"},
        {"Geneva Identification System", "GEN# +1.00045450"},
        {"Smithsonian Astrophysical Observation", "SAO 234482"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94548524),
        dec: Angle.Degrees(-58.54393301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56910"},
        {"Hipparcos Number", "HIP 35095"},
        {"Geneva Identification System", "GEN# +1.00056910"},
        {"Renson", "Renson 15540"},
        {"Smithsonian Astrophysical Observation", "SAO 235051"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87127331),
        dec: Angle.Degrees(-58.54263984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96413"},
        {"Hipparcos Number", "HIP 54237"},
        {"Geneva Identification System", "GEN# +2.35320401"},
        {"New General Catalogue", "NGC 3532 114"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45447564),
        dec: Angle.Degrees(-58.54171497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120521"},
        {"Hipparcos Number", "HIP 67642"},
        {"Geneva Identification System", "GEN# +1.00120521"},
        {"Wilson Evans Batten Catalogue", "WEB 11895"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.89162146),
        dec: Angle.Degrees(-58.53952125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59824"},
        {"Hipparcos Number", "HIP 36302"},
        {"Geneva Identification System", "GEN# +1.00059824"},
        {"Smithsonian Astrophysical Observation", "SAO 235223"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.09201790),
        dec: Angle.Degrees(-58.53610948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113556"},
        {"Hipparcos Number", "HIP 63886"},
        {"Geneva Identification System", "GEN# +1.00113556"},
        {"Smithsonian Astrophysical Observation", "SAO 240533"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.38603379),
        dec: Angle.Degrees(-58.53550418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89402"},
        {"Hipparcos Number", "HIP 50397"},
        {"Celescope Catalog", "CEL 3489"},
        {"Geneva Identification System", "GEN# +1.00089402"},
        {"Smithsonian Astrophysical Observation", "SAO 237879"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.36479126),
        dec: Angle.Degrees(-58.53264297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121487"},
        {"Hipparcos Number", "HIP 68171"},
        {"Geneva Identification System", "GEN# +1.00121487"},
        {"Smithsonian Astrophysical Observation", "SAO 241319"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.34202892),
        dec: Angle.Degrees(-58.53238575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31300"},
        {"Geneva Identification System", "GEN# +9.86182044"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.46009459),
        dec: Angle.Degrees(-58.53039331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -400.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 795.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90136"},
        {"Hipparcos Number", "HIP 50828"},
        {"Geneva Identification System", "GEN# +1.00090136"},
        {"Smithsonian Astrophysical Observation", "SAO 238002"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.68262692),
        dec: Angle.Degrees(-58.52766509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26467"},
        {"Hipparcos Number", "HIP 19277"},
        {"Fundamental Katalog 5th Edition", "FK5 4373"},
        {"Smithsonian Astrophysical Observation", "SAO 233408"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96993784),
        dec: Angle.Degrees(-58.52705617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44325"},
        {"Hipparcos Number", "HIP 29889"},
        {"Smithsonian Astrophysical Observation", "SAO 234433"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.40877269),
        dec: Angle.Degrees(-58.52563810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189972"},
        {"Hipparcos Number", "HIP 98994"},
        {"Smithsonian Astrophysical Observation", "SAO 246430"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.47314636),
        dec: Angle.Degrees(-58.52482568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 791"},
        {"Hipparcos Number", "HIP 975"},
        {"Smithsonian Astrophysical Observation", "SAO 231967"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.02160438),
        dec: Angle.Degrees(-58.52479986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201773"},
        {"Hipparcos Number", "HIP 104836"},
        {"Smithsonian Astrophysical Observation", "SAO 246917"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56881911),
        dec: Angle.Degrees(-58.52369896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31186"},
        {"Hipparcos Number", "HIP 22474"},
        {"Smithsonian Astrophysical Observation", "SAO 233707"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.53793296),
        dec: Angle.Degrees(-58.52278520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219147"},
        {"Hipparcos Number", "HIP 114728"},
        {"Smithsonian Astrophysical Observation", "SAO 247790"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.60149637),
        dec: Angle.Degrees(-58.52115820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32712"},
        {"Hipparcos Number", "HIP 23379"},
        {"Fundamental Katalog 5th Edition", "FK5 4460"},
        {"Geneva Identification System", "GEN# +1.00032712"},
        {"Smithsonian Astrophysical Observation", "SAO 233791"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.39542406),
        dec: Angle.Degrees(-58.52075535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134766"},
        {"Hipparcos Number", "HIP 74580"},
        {"Smithsonian Astrophysical Observation", "SAO 242333"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.57832414),
        dec: Angle.Degrees(-58.52005705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168617"},
        {"Hipparcos Number", "HIP 90192"},
        {"Smithsonian Astrophysical Observation", "SAO 245440"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.06106545),
        dec: Angle.Degrees(-58.51999357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76328"},
        {"Hipparcos Number", "HIP 43605"},
        {"Geneva Identification System", "GEN# +1.00076328"},
        {"Smithsonian Astrophysical Observation", "SAO 236367"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.20691464),
        dec: Angle.Degrees(-58.51697075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185711"},
        {"Hipparcos Number", "HIP 97084"},
        {"Smithsonian Astrophysical Observation", "SAO 246233"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.95280477),
        dec: Angle.Degrees(-58.51622227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222628"},
        {"Hipparcos Number", "HIP 116959"},
        {"Smithsonian Astrophysical Observation", "SAO 247990"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.63017988),
        dec: Angle.Degrees(-58.51606154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125317"},
        {"Hipparcos Number", "HIP 70091"},
        {"Smithsonian Astrophysical Observation", "SAO 241645"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.14478933),
        dec: Angle.Degrees(-58.51595437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172920"},
        {"Hipparcos Number", "HIP 92102"},
        {"Geneva Identification System", "GEN# +1.00172920"},
        {"Smithsonian Astrophysical Observation", "SAO 245691"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.56250268),
        dec: Angle.Degrees(-58.51528102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52788"},
        {"Hipparcos Number", "HIP 33616"},
        {"Geneva Identification System", "GEN# +1.00052788"},
        {"Renson", "Renson 14470"},
        {"Smithsonian Astrophysical Observation", "SAO 234839"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.76687376),
        dec: Angle.Degrees(-58.51485090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187101"},
        {"Hipparcos Number", "HIP 97705"},
        {"Geneva Identification System", "GEN# +1.00187101"},
        {"Smithsonian Astrophysical Observation", "SAO 246298"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.84839754),
        dec: Angle.Degrees(-58.50967082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202083"},
        {"Hipparcos Number", "HIP 105007"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.01566508),
        dec: Angle.Degrees(-58.50854098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100334"},
        {"Hipparcos Number", "HIP 56270"},
        {"Geneva Identification System", "GEN# +1.00100334"},
        {"Smithsonian Astrophysical Observation", "SAO 239150"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.03443650),
        dec: Angle.Degrees(-58.50478773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144508"},
        {"Hipparcos Number", "HIP 79155"},
        {"Smithsonian Astrophysical Observation", "SAO 243367"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.33440309),
        dec: Angle.Degrees(-58.50424796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150745"},
        {"Hipparcos Number", "HIP 82110"},
        {"Geneva Identification System", "GEN# +1.00150745"},
        {"Smithsonian Astrophysical Observation", "SAO 244122"},
        {"Wilson Evans Batten Catalogue", "WEB 13864"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.58844780),
        dec: Angle.Degrees(-58.50356849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141120"},
        {"Hipparcos Number", "HIP 77580"},
        {"Geneva Identification System", "GEN# +1.00141120"},
        {"Smithsonian Astrophysical Observation", "SAO 243020"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.58897820),
        dec: Angle.Degrees(-58.50185605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120359"},
        {"Hipparcos Number", "HIP 67556"},
        {"Geneva Identification System", "GEN# +1.00120359"},
        {"Smithsonian Astrophysical Observation", "SAO 241215"},
        {"Wilson Evans Batten Catalogue", "WEB 11881"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.64626026),
        dec: Angle.Degrees(-58.49916480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110878"},
        {"Hipparcos Number", "HIP 62286"},
        {"Geneva Identification System", "GEN# +1.00110878"},
        {"Smithsonian Astrophysical Observation", "SAO 240222"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.46894849),
        dec: Angle.Degrees(-58.49896433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91595"},
        {"Hipparcos Number", "HIP 51653"},
        {"Geneva Identification System", "GEN# +1.00091595"},
        {"Smithsonian Astrophysical Observation", "SAO 238178"},
        {"Wilson Evans Batten Catalogue", "WEB 9422"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.29524126),
        dec: Angle.Degrees(-58.49864559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38317"},
        {"Hipparcos Number", "HIP 26771"},
        {"Smithsonian Astrophysical Observation", "SAO 234094"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.30291701),
        dec: Angle.Degrees(-58.49862933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118196"},
        {"Hipparcos Number", "HIP 66384"},
        {"Geneva Identification System", "GEN# +1.00118196"},
        {"Smithsonian Astrophysical Observation", "SAO 240993"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.16262460),
        dec: Angle.Degrees(-58.49821114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199996"},
        {"Hipparcos Number", "HIP 103906"},
        {"Smithsonian Astrophysical Observation", "SAO 246835"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.80037290),
        dec: Angle.Degrees(-58.49754561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104875"},
        {"Hipparcos Number", "HIP 58885"},
        {"Geneva Identification System", "GEN# +1.00104875"},
        {"Smithsonian Astrophysical Observation", "SAO 239637"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16233249),
        dec: Angle.Degrees(-58.49623842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66028"},
        {"Geneva Identification System", "GEN# +5.31080006"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.05522862),
        dec: Angle.Degrees(-58.49282083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58895"},
        {"Hipparcos Number", "HIP 35910"},
        {"Fundamental Katalog 5th Edition", "FK5 2573"},
        {"Geneva Identification System", "GEN# +1.00058895"},
        {"Smithsonian Astrophysical Observation", "SAO 235171"},
        {"Wilson Evans Batten Catalogue", "WEB 7152"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.03951541),
        dec: Angle.Degrees(-58.49228286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25159"},
        {"Hipparcos Number", "HIP 18456"},
        {"Smithsonian Astrophysical Observation", "SAO 233335"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.16027664),
        dec: Angle.Degrees(-58.48770896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26564"},
        {"Hipparcos Number", "HIP 19353"},
        {"Smithsonian Astrophysical Observation", "SAO 233416"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.19097791),
        dec: Angle.Degrees(-58.48736646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33983"},
        {"Hipparcos Number", "HIP 24082"},
        {"Geneva Identification System", "GEN# +1.00033983"},
        {"Smithsonian Astrophysical Observation", "SAO 233861"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.60260558),
        dec: Angle.Degrees(-58.48646764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98722"},
        {"Hipparcos Number", "HIP 55410"},
        {"Geneva Identification System", "GEN# +1.00098722"},
        {"Smithsonian Astrophysical Observation", "SAO 238984"},
        {"Wilson Evans Batten Catalogue", "WEB 9971"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.21615511),
        dec: Angle.Degrees(-58.48641359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67932"},
        {"Hipparcos Number", "HIP 39725"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.79414441),
        dec: Angle.Degrees(-58.48546846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75483"},
        {"Hipparcos Number", "HIP 43163"},
        {"Celescope Catalog", "CEL 2930"},
        {"Smithsonian Astrophysical Observation", "SAO 236280"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.88592056),
        dec: Angle.Degrees(-58.48473598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111654"},
        {"Hipparcos Number", "HIP 62756"},
        {"Geneva Identification System", "GEN# +1.00111654"},
        {"Smithsonian Astrophysical Observation", "SAO 240323"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.89950404),
        dec: Angle.Degrees(-58.48457439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117214"},
        {"Hipparcos Number", "HIP 65875"},
        {"Geneva Identification System", "GEN# +1.00117214"},
        {"Smithsonian Astrophysical Observation", "SAO 240893"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.53754522),
        dec: Angle.Degrees(-58.48449443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49034"},
        {"Hipparcos Number", "HIP 32153"},
        {"Smithsonian Astrophysical Observation", "SAO 234672"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.71925946),
        dec: Angle.Degrees(-58.48385102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89925"},
        {"Hipparcos Number", "HIP 50695"},
        {"Geneva Identification System", "GEN# +1.00089925"},
        {"Smithsonian Astrophysical Observation", "SAO 237968"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.28449475),
        dec: Angle.Degrees(-58.48383734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29067"},
        {"Hipparcos Number", "HIP 21096"},
        {"Smithsonian Astrophysical Observation", "SAO 233549"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.80827025),
        dec: Angle.Degrees(-58.48189090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302554"},
        {"Hipparcos Number", "HIP 49644"},
        {"Geneva Identification System", "GEN# +1.00302554"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.99350459),
        dec: Angle.Degrees(-58.47964484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110447"},
        {"Hipparcos Number", "HIP 62023"},
        {"Smithsonian Astrophysical Observation", "SAO 240175"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.69978348),
        dec: Angle.Degrees(-58.47888297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211917"},
        {"Hipparcos Number", "HIP 110436"},
        {"Smithsonian Astrophysical Observation", "SAO 247422"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.53050580),
        dec: Angle.Degrees(-58.47846503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115621"},
        {"Hipparcos Number", "HIP 65007"},
        {"Smithsonian Astrophysical Observation", "SAO 240742"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.87040648),
        dec: Angle.Degrees(-58.47845492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26206"},
        {"Hipparcos Number", "HIP 19086"},
        {"Smithsonian Astrophysical Observation", "SAO 233396"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.38043714),
        dec: Angle.Degrees(-58.47838201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129462"},
        {"Hipparcos Number", "HIP 72097"},
        {"Geneva Identification System", "GEN# +1.00129462"},
        {"Smithsonian Astrophysical Observation", "SAO 241966"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23154053),
        dec: Angle.Degrees(-58.47738938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220790"},
        {"Hipparcos Number", "HIP 115769"},
        {"Fundamental Katalog 5th Edition", "FK5 3876"},
        {"Geneva Identification System", "GEN# +1.00220790"},
        {"Smithsonian Astrophysical Observation", "SAO 247882"},
        {"Wilson Evans Batten Catalogue", "WEB 20485"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.81222494),
        dec: Angle.Degrees(-58.47627854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6643"},
        {"Hipparcos Number", "HIP 5167"},
        {"Smithsonian Astrophysical Observation", "SAO 232294"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52461295),
        dec: Angle.Degrees(-58.47532704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156751"},
        {"Hipparcos Number", "HIP 85038"},
        {"Geneva Identification System", "GEN# +1.00156751"},
        {"Smithsonian Astrophysical Observation", "SAO 244675"},
        {"Wilson Evans Batten Catalogue", "WEB 14358"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.69976635),
        dec: Angle.Degrees(-58.47304207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12057"},
        {"Hipparcos Number", "HIP 9051"},
        {"Geneva Identification System", "GEN# +1.00012057"},
        {"Smithsonian Astrophysical Observation", "SAO 232579"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15524029),
        dec: Angle.Degrees(-58.47141523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150250"},
        {"Hipparcos Number", "HIP 81850"},
        {"Smithsonian Astrophysical Observation", "SAO 244084"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77144746),
        dec: Angle.Degrees(-58.47104555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112556"},
        {"Hipparcos Number", "HIP 63302"},
        {"Smithsonian Astrophysical Observation", "SAO 240428"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.58896210),
        dec: Angle.Degrees(-58.47050600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117527"},
        {"Hipparcos Number", "HIP 66027"},
        {"Geneva Identification System", "GEN# +5.31080005"},
        {"Smithsonian Astrophysical Observation", "SAO 240926"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.05103620),
        dec: Angle.Degrees(-58.47018885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185035"},
        {"Hipparcos Number", "HIP 96794"},
        {"Smithsonian Astrophysical Observation", "SAO 246205"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14323829),
        dec: Angle.Degrees(-58.46982756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215207"},
        {"Hipparcos Number", "HIP 112297"},
        {"Smithsonian Astrophysical Observation", "SAO 247563"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.19032453),
        dec: Angle.Degrees(-58.46833416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50198"},
        {"Hipparcos Number", "HIP 32643"},
        {"Geneva Identification System", "GEN# +1.00050198"},
        {"Smithsonian Astrophysical Observation", "SAO 234729"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.14974113),
        dec: Angle.Degrees(-58.46731137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3879"},
        {"Hipparcos Number", "HIP 3196"},
        {"Smithsonian Astrophysical Observation", "SAO 232147"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.18557136),
        dec: Angle.Degrees(-58.46603469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63179"},
        {"Hipparcos Number", "HIP 37724"},
        {"Smithsonian Astrophysical Observation", "SAO 235472"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.06184421),
        dec: Angle.Degrees(-58.46601228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117562"},
        {"Hipparcos Number", "HIP 66054"},
        {"Geneva Identification System", "GEN# +5.31080008"},
        {"Smithsonian Astrophysical Observation", "SAO 240930"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.13039345),
        dec: Angle.Degrees(-58.46121251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88069"},
        {"Hipparcos Number", "HIP 49607"},
        {"Geneva Identification System", "GEN# +1.00088069"},
        {"Smithsonian Astrophysical Observation", "SAO 237714"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88095700),
        dec: Angle.Degrees(-58.46117321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125628"},
        {"Hipparcos Number", "HIP 70264"},
        {"Smithsonian Astrophysical Observation", "SAO 241673"},
        {"Wilson Evans Batten Catalogue", "WEB 12199"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65467485),
        dec: Angle.Degrees(-58.45915834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163670"},
        {"Hipparcos Number", "HIP 88220"},
        {"Smithsonian Astrophysical Observation", "SAO 245168"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24050952),
        dec: Angle.Degrees(-58.45875863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151807"},
        {"Hipparcos Number", "HIP 82595"},
        {"Smithsonian Astrophysical Observation", "SAO 244228"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.26819477),
        dec: Angle.Degrees(-58.45805276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42967"},
        {"Smithsonian Astrophysical Observation", "SAO 236248"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.36782657),
        dec: Angle.Degrees(-58.45770696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97271"},
        {"Hipparcos Number", "HIP 54630"},
        {"Celescope Catalog", "CEL 3834"},
        {"Geneva Identification System", "GEN# +1.00097271"},
        {"Smithsonian Astrophysical Observation", "SAO 238839"},
        {"Wilson Evans Batten Catalogue", "WEB 9854"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.72840470),
        dec: Angle.Degrees(-58.45526667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198700"},
        {"Hipparcos Number", "HIP 103227"},
        {"Fundamental Katalog 5th Edition", "FK5 785"},
        {"Geneva Identification System", "GEN# +1.00198700"},
        {"Smithsonian Astrophysical Observation", "SAO 246784"},
        {"Wilson Evans Batten Catalogue", "WEB 18753"},
    },
    visualMagnitude: 3.67,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.70241509),
        dec: Angle.Degrees(-58.45409470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111302"},
        {"Hipparcos Number", "HIP 62560"},
        {"Smithsonian Astrophysical Observation", "SAO 240277"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.27449566),
        dec: Angle.Degrees(-58.44858924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142622"},
        {"Hipparcos Number", "HIP 78255"},
        {"Smithsonian Astrophysical Observation", "SAO 243181"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.66153686),
        dec: Angle.Degrees(-58.44648638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104071"},
        {"Hipparcos Number", "HIP 58444"},
        {"Smithsonian Astrophysical Observation", "SAO 239547"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.76391097),
        dec: Angle.Degrees(-58.44635037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32985"},
        {"Hipparcos Number", "HIP 23529"},
        {"Geneva Identification System", "GEN# +1.00032985"},
        {"Smithsonian Astrophysical Observation", "SAO 233809"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.87425161),
        dec: Angle.Degrees(-58.44629414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60321"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53230533),
        dec: Angle.Degrees(-58.44408009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5039"},
        {"Smithsonian Astrophysical Observation", "SAO 232284"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.13130053),
        dec: Angle.Degrees(-58.44108266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120859"},
        {"Hipparcos Number", "HIP 67824"},
        {"Smithsonian Astrophysical Observation", "SAO 241259"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.40616908),
        dec: Angle.Degrees(-58.43966666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217346"},
        {"Hipparcos Number", "HIP 113647"},
        {"Smithsonian Astrophysical Observation", "SAO 247681"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.25377511),
        dec: Angle.Degrees(-58.43753462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155761"},
        {"Hipparcos Number", "HIP 84547"},
        {"Smithsonian Astrophysical Observation", "SAO 244576"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.25434522),
        dec: Angle.Degrees(-58.43414742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12857"},
        {"Smithsonian Astrophysical Observation", "SAO 232880"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.32531300),
        dec: Angle.Degrees(-58.43288481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111104"},
        {"Hipparcos Number", "HIP 62431"},
        {"Smithsonian Astrophysical Observation", "SAO 240258"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.92435791),
        dec: Angle.Degrees(-58.43215114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120576"},
        {"Hipparcos Number", "HIP 67687"},
        {"Smithsonian Astrophysical Observation", "SAO 241236"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99002520),
        dec: Angle.Degrees(-58.43163959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126490"},
        {"Hipparcos Number", "HIP 70727"},
        {"Smithsonian Astrophysical Observation", "SAO 241729"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.97131043),
        dec: Angle.Degrees(-58.43090753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112044"},
        {"Hipparcos Number", "HIP 62986"},
        {"Geneva Identification System", "GEN# +1.00112044"},
        {"Geneva Identification System 2", "GEN# -0.01603503"},
        {"Smithsonian Astrophysical Observation", "SAO 240362"},
        {"Wilson Evans Batten Catalogue", "WEB 11167"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.59170179),
        dec: Angle.Degrees(-58.43060629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67693"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99843527),
        dec: Angle.Degrees(-58.42984266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302430"},
        {"Hipparcos Number", "HIP 48663"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.85902760),
        dec: Angle.Degrees(-58.42971030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144342"},
        {"Hipparcos Number", "HIP 79067"},
        {"Smithsonian Astrophysical Observation", "SAO 243354"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.10939292),
        dec: Angle.Degrees(-58.42924871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78760"},
        {"Hipparcos Number", "HIP 44767"},
        {"Smithsonian Astrophysical Observation", "SAO 236629"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.86017985),
        dec: Angle.Degrees(-58.42376371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220757"},
        {"Hipparcos Number", "HIP 115744"},
        {"Smithsonian Astrophysical Observation", "SAO 247878"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.74477076),
        dec: Angle.Degrees(-58.42367194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97451"},
        {"Hipparcos Number", "HIP 54708"},
        {"Smithsonian Astrophysical Observation", "SAO 238855"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.01498327),
        dec: Angle.Degrees(-58.42335374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71511"},
        {"Hipparcos Number", "HIP 41238"},
        {"Smithsonian Astrophysical Observation", "SAO 235956"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22082318),
        dec: Angle.Degrees(-58.42132701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86118"},
        {"Hipparcos Number", "HIP 48589"},
        {"Geneva Identification System", "GEN# +1.00086118"},
        {"Smithsonian Astrophysical Observation", "SAO 237480"},
        {"Wilson Evans Batten Catalogue", "WEB 9047"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64119790),
        dec: Angle.Degrees(-58.42127405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27661"},
        {"Hipparcos Number", "HIP 20101"},
        {"Smithsonian Astrophysical Observation", "SAO 233478"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.63613201),
        dec: Angle.Degrees(-58.41709495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111103"},
        {"Hipparcos Number", "HIP 62427"},
        {"Smithsonian Astrophysical Observation", "SAO 240255"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.91141172),
        dec: Angle.Degrees(-58.41570961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107546"},
        {"Hipparcos Number", "HIP 60309"},
        {"Celescope Catalog", "CEL 4096"},
        {"Geneva Identification System", "GEN# +1.00107546"},
        {"Smithsonian Astrophysical Observation", "SAO 239879"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.48946150),
        dec: Angle.Degrees(-58.41562021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103777"},
        {"Hipparcos Number", "HIP 58257"},
        {"Geneva Identification System", "GEN# +1.00103777"},
        {"Smithsonian Astrophysical Observation", "SAO 239514"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.21605437),
        dec: Angle.Degrees(-58.41546742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94304"},
        {"Hipparcos Number", "HIP 53109"},
        {"Geneva Identification System", "GEN# +1.00094304"},
        {"Smithsonian Astrophysical Observation", "SAO 238544"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.98419324),
        dec: Angle.Degrees(-58.41546221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118384"},
        {"Hipparcos Number", "HIP 66521"},
        {"Geneva Identification System", "GEN# +1.00118384J"},
        {"Smithsonian Astrophysical Observation", "SAO 241013"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.53178024),
        dec: Angle.Degrees(-58.41458137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10678"},
        {"Hipparcos Number", "HIP 7990"},
        {"Geneva Identification System", "GEN# +1.00010678"},
        {"Smithsonian Astrophysical Observation", "SAO 232502"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.65412355),
        dec: Angle.Degrees(-58.41305650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157220"},
        {"Hipparcos Number", "HIP 85283"},
        {"Smithsonian Astrophysical Observation", "SAO 244728"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.39362735),
        dec: Angle.Degrees(-58.41068778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51950"},
        {"Hipparcos Number", "HIP 33321"},
        {"Smithsonian Astrophysical Observation", "SAO 234793"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.96175998),
        dec: Angle.Degrees(-58.41038268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47770"},
        {"Hipparcos Number", "HIP 31589"},
        {"Smithsonian Astrophysical Observation", "SAO 234611"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.16746420),
        dec: Angle.Degrees(-58.40894017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5877"},
        {"Hipparcos Number", "HIP 4618"},
        {"Smithsonian Astrophysical Observation", "SAO 232248"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.83018924),
        dec: Angle.Degrees(-58.40478308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39275"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.46687644),
        dec: Angle.Degrees(-58.40446023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19397"},
        {"Hipparcos Number", "HIP 14304"},
        {"Geneva Identification System", "GEN# +1.00019397"},
        {"Renson", "Renson 4840"},
        {"Smithsonian Astrophysical Observation", "SAO 232986"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.11883356),
        dec: Angle.Degrees(-58.40387129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93189"},
        {"Hipparcos Number", "HIP 52522"},
        {"Smithsonian Astrophysical Observation", "SAO 238413"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.08778670),
        dec: Angle.Degrees(-58.40093149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121822"},
        {"Hipparcos Number", "HIP 68358"},
        {"Geneva Identification System", "GEN# +1.00121822"},
        {"Smithsonian Astrophysical Observation", "SAO 241353"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.89003553),
        dec: Angle.Degrees(-58.39754518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74235"},
        {"Hipparcos Number", "HIP 42512"},
        {"Smithsonian Astrophysical Observation", "SAO 236167"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.01308610),
        dec: Angle.Degrees(-58.39714857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77963"},
        {"Hipparcos Number", "HIP 44419"},
        {"Smithsonian Astrophysical Observation", "SAO 236543"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.74417553),
        dec: Angle.Degrees(-58.39437435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 304325"},
        {"Hipparcos Number", "HIP 56014"},
        {"Geneva Identification System", "GEN# +1.00304325"},
        {"Smithsonian Astrophysical Observation", "SAO 239102"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.18830685),
        dec: Angle.Degrees(-58.39430860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53166"},
        {"Hipparcos Number", "HIP 33740"},
        {"Smithsonian Astrophysical Observation", "SAO 234856"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.14417884),
        dec: Angle.Degrees(-58.39343220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146247"},
        {"Hipparcos Number", "HIP 79892"},
        {"Geneva Identification System", "GEN# +1.00146247"},
        {"Smithsonian Astrophysical Observation", "SAO 243565"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.60905059),
        dec: Angle.Degrees(-58.39270236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213286"},
        {"Hipparcos Number", "HIP 111201"},
        {"Smithsonian Astrophysical Observation", "SAO 247472"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.92452875),
        dec: Angle.Degrees(-58.39189388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80094"},
        {"Hipparcos Number", "HIP 45418"},
        {"Celescope Catalog", "CEL 3245"},
        {"Geneva Identification System", "GEN# +1.00080094"},
        {"Smithsonian Astrophysical Observation", "SAO 236772"},
        {"Wilson Evans Batten Catalogue", "WEB 8642"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.82357591),
        dec: Angle.Degrees(-58.38837967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22217"},
        {"Hipparcos Number", "HIP 16439"},
        {"Smithsonian Astrophysical Observation", "SAO 233147"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.92470450),
        dec: Angle.Degrees(-58.38836713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112484"},
        {"Hipparcos Number", "HIP 63256"},
        {"Celescope Catalog", "CEL 4178"},
        {"Geneva Identification System", "GEN# +1.00112484"},
        {"Smithsonian Astrophysical Observation", "SAO 240417"},
        {"Wilson Evans Batten Catalogue", "WEB 11210"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.43052187),
        dec: Angle.Degrees(-58.38833520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188987"},
        {"Hipparcos Number", "HIP 98536"},
        {"Fundamental Katalog 5th Edition", "FK5 5763"},
        {"Smithsonian Astrophysical Observation", "SAO 246383"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25601921),
        dec: Angle.Degrees(-58.38756901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181930"},
        {"Hipparcos Number", "HIP 95518"},
        {"Smithsonian Astrophysical Observation", "SAO 246088"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.43209512),
        dec: Angle.Degrees(-58.38729988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83032"},
        {"Hipparcos Number", "HIP 46905"},
        {"Celescope Catalog", "CEL 3329"},
        {"Geneva Identification System", "GEN# +1.00083032J"},
        {"Smithsonian Astrophysical Observation", "SAO 237101"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.37778741),
        dec: Angle.Degrees(-58.38626544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98897"},
        {"Hipparcos Number", "HIP 55518"},
        {"Smithsonian Astrophysical Observation", "SAO 239003"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.56478176),
        dec: Angle.Degrees(-58.38592745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54795"},
        {"Hipparcos Number", "HIP 34310"},
        {"Smithsonian Astrophysical Observation", "SAO 234939"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.69982849),
        dec: Angle.Degrees(-58.38099323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12859"},
        {"Cincinnati Publication", "Ci 20 184"},
        {"Geneva Identification System", "GEN# -2.05800562"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.32778357),
        dec: Angle.Degrees(-58.37898847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 425.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 239.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61576"},
        {"Hipparcos Number", "HIP 37028"},
        {"Geneva Identification System", "GEN# +1.00061576"},
        {"Smithsonian Astrophysical Observation", "SAO 235358"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13844235),
        dec: Angle.Degrees(-58.37737000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74291"},
        {"Hipparcos Number", "HIP 42551"},
        {"Smithsonian Astrophysical Observation", "SAO 236173"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.09514940),
        dec: Angle.Degrees(-58.37548912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36492"},
        {"Hipparcos Number", "HIP 25626"},
        {"Smithsonian Astrophysical Observation", "SAO 233993"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.11246872),
        dec: Angle.Degrees(-58.37361462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55196"},
        {"Hipparcos Number", "HIP 34447"},
        {"Smithsonian Astrophysical Observation", "SAO 234957"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.11303826),
        dec: Angle.Degrees(-58.37247701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181772"},
        {"Hipparcos Number", "HIP 95471"},
        {"Smithsonian Astrophysical Observation", "SAO 246076"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.29792007),
        dec: Angle.Degrees(-58.37223881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164011"},
        {"Hipparcos Number", "HIP 88360"},
        {"Geneva Identification System", "GEN# +1.00164011"},
        {"Smithsonian Astrophysical Observation", "SAO 245188"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65304402),
        dec: Angle.Degrees(-58.37183821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222999"},
        {"Hipparcos Number", "HIP 117206"},
        {"Smithsonian Astrophysical Observation", "SAO 248011"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.47961715),
        dec: Angle.Degrees(-58.36986183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72201"},
        {"Hipparcos Number", "HIP 41575"},
        {"Smithsonian Astrophysical Observation", "SAO 236019"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15423706),
        dec: Angle.Degrees(-58.36982199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135355"},
        {"Hipparcos Number", "HIP 74816"},
        {"Geneva Identification System", "GEN# +1.00135355"},
        {"Smithsonian Astrophysical Observation", "SAO 242382"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.33934061),
        dec: Angle.Degrees(-58.36795637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159115"},
        {"Hipparcos Number", "HIP 86154"},
        {"Geneva Identification System", "GEN# +1.00159115"},
        {"Smithsonian Astrophysical Observation", "SAO 244880"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.08986145),
        dec: Angle.Degrees(-58.36703268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117945"},
        {"Hipparcos Number", "HIP 66285"},
        {"Smithsonian Astrophysical Observation", "SAO 240965"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.78387529),
        dec: Angle.Degrees(-58.36644454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76163"},
        {"Hipparcos Number", "HIP 43512"},
        {"Geneva Identification System", "GEN# +1.00076163"},
        {"Smithsonian Astrophysical Observation", "SAO 236344"},
        {"Wilson Evans Batten Catalogue", "WEB 8387"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93886567),
        dec: Angle.Degrees(-58.36600267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44035"},
        {"Smithsonian Astrophysical Observation", "SAO 236452"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.50310350),
        dec: Angle.Degrees(-58.36592557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69546"},
        {"Hipparcos Number", "HIP 40365"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.62194269),
        dec: Angle.Degrees(-58.36303760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88879"},
        {"Hipparcos Number", "HIP 50068"},
        {"Geneva Identification System", "GEN# +1.00088879"},
        {"Smithsonian Astrophysical Observation", "SAO 237811"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.33875421),
        dec: Angle.Degrees(-58.36300306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82536"},
        {"Hipparcos Number", "HIP 46620"},
        {"Geneva Identification System", "GEN# +1.00082536J"},
        {"Smithsonian Astrophysical Observation", "SAO 237056"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.59772226),
        dec: Angle.Degrees(-58.36190438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30864"},
        {"Hipparcos Number", "HIP 22278"},
        {"Geneva Identification System", "GEN# +1.00030864"},
        {"Smithsonian Astrophysical Observation", "SAO 233687"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.95318034),
        dec: Angle.Degrees(-58.36151232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128937"},
        {"Hipparcos Number", "HIP 71877"},
        {"Smithsonian Astrophysical Observation", "SAO 241917"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.52345075),
        dec: Angle.Degrees(-58.35966070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67477"},
        {"Hipparcos Number", "HIP 39557"},
        {"Smithsonian Astrophysical Observation", "SAO 235737"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.24641845),
        dec: Angle.Degrees(-58.35902114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46213"},
        {"Hipparcos Number", "HIP 30811"},
        {"Smithsonian Astrophysical Observation", "SAO 234528"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.10700190),
        dec: Angle.Degrees(-58.35431789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44937"},
        {"Hipparcos Number", "HIP 30175"},
        {"Smithsonian Astrophysical Observation", "SAO 234460"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.24121837),
        dec: Angle.Degrees(-58.35209131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127801"},
        {"Hipparcos Number", "HIP 71356"},
        {"Smithsonian Astrophysical Observation", "SAO 241818"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.89141209),
        dec: Angle.Degrees(-58.35141399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137583"},
        {"Hipparcos Number", "HIP 75842"},
        {"Smithsonian Astrophysical Observation", "SAO 242593"},
    },
    visualMagnitude: 6.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38707546),
        dec: Angle.Degrees(-58.35134422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11903"},
        {"Hipparcos Number", "HIP 8945"},
        {"Smithsonian Astrophysical Observation", "SAO 232567"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.80692762),
        dec: Angle.Degrees(-58.35054106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105613"},
        {"Hipparcos Number", "HIP 59282"},
        {"Geneva Identification System", "GEN# +1.00105613"},
        {"Smithsonian Astrophysical Observation", "SAO 239707"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.41177875),
        dec: Angle.Degrees(-58.34962978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183699"},
        {"Hipparcos Number", "HIP 96230"},
        {"Smithsonian Astrophysical Observation", "SAO 246161"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.52407329),
        dec: Angle.Degrees(-58.34673312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12905"},
        {"Hipparcos Number", "HIP 9679"},
        {"Geneva Identification System", "GEN# +1.00012905"},
        {"Smithsonian Astrophysical Observation", "SAO 232622"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.12742036),
        dec: Angle.Degrees(-58.34442829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205491"},
        {"Hipparcos Number", "HIP 106797"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.46601280),
        dec: Angle.Degrees(-58.34387782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9930"},
        {"Smithsonian Astrophysical Observation", "SAO 232644"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.96005933),
        dec: Angle.Degrees(-58.34204223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150898"},
        {"Hipparcos Number", "HIP 82171"},
        {"Geneva Identification System", "GEN# +1.00150898"},
        {"Smithsonian Astrophysical Observation", "SAO 244133"},
        {"Wilson Evans Batten Catalogue", "WEB 13877"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.83193375),
        dec: Angle.Degrees(-58.34139234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64620"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66952971),
        dec: Angle.Degrees(-58.33951102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48170"},
        {"Hipparcos Number", "HIP 31745"},
        {"Geneva Identification System", "GEN# +1.00048170"},
        {"Smithsonian Astrophysical Observation", "SAO 234631"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.61064101),
        dec: Angle.Degrees(-58.33821342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186739"},
        {"Hipparcos Number", "HIP 97535"},
        {"Smithsonian Astrophysical Observation", "SAO 246279"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.35701466),
        dec: Angle.Degrees(-58.33694499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82226"},
        {"Hipparcos Number", "HIP 46458"},
        {"Celescope Catalog", "CEL 3307"},
        {"Smithsonian Astrophysical Observation", "SAO 237017"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.12497619),
        dec: Angle.Degrees(-58.33498042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9757"},
        {"Hipparcos Number", "HIP 7297"},
        {"Smithsonian Astrophysical Observation", "SAO 232463"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.49913119),
        dec: Angle.Degrees(-58.33432090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114901"},
        {"Hipparcos Number", "HIP 64616"},
        {"Geneva Identification System", "GEN# +1.00114901"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66468172),
        dec: Angle.Degrees(-58.33422850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196129"},
        {"Hipparcos Number", "HIP 101831"},
        {"Geneva Identification System", "GEN# +1.00196129"},
        {"Smithsonian Astrophysical Observation", "SAO 246667"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.54221777),
        dec: Angle.Degrees(-58.33276748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200922"},
        {"Hipparcos Number", "HIP 104400"},
        {"Geneva Identification System", "GEN# +1.00200922"},
        {"Smithsonian Astrophysical Observation", "SAO 246885"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.25288935),
        dec: Angle.Degrees(-58.33263320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79368"},
        {"Hipparcos Number", "HIP 45094"},
        {"Celescope Catalog", "CEL 3209"},
        {"Geneva Identification System", "GEN# +1.00079368"},
        {"Smithsonian Astrophysical Observation", "SAO 236700"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.78463319),
        dec: Angle.Degrees(-58.33151367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109355"},
        {"Hipparcos Number", "HIP 61365"},
        {"Geneva Identification System", "GEN# +1.00109355"},
        {"Smithsonian Astrophysical Observation", "SAO 240070"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.62424461),
        dec: Angle.Degrees(-58.33129448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102502"},
        {"Hipparcos Number", "HIP 57546"},
        {"Geneva Identification System", "GEN# +1.00102502"},
        {"Smithsonian Astrophysical Observation", "SAO 239378"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.91710592),
        dec: Angle.Degrees(-58.33072346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50903"},
        {"Hipparcos Number", "HIP 32924"},
        {"Smithsonian Astrophysical Observation", "SAO 234754"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88973815),
        dec: Angle.Degrees(-58.32829305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130981"},
        {"Hipparcos Number", "HIP 72852"},
        {"Renson", "Renson 37230"},
        {"Smithsonian Astrophysical Observation", "SAO 242089"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.35897168),
        dec: Angle.Degrees(-58.32690125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124622"},
        {"Hipparcos Number", "HIP 69766"},
        {"Smithsonian Astrophysical Observation", "SAO 241585"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.17075928),
        dec: Angle.Degrees(-58.32515765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21693"},
        {"Hipparcos Number", "HIP 16085"},
        {"Geneva Identification System", "GEN# +1.00021693"},
        {"Smithsonian Astrophysical Observation", "SAO 233126"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.80085343),
        dec: Angle.Degrees(-58.32391044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 249.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78988"},
        {"Hipparcos Number", "HIP 44884"},
        {"Geneva Identification System", "GEN# +1.00078988"},
        {"Smithsonian Astrophysical Observation", "SAO 236661"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.17997506),
        dec: Angle.Degrees(-58.32233832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103791"},
        {"Hipparcos Number", "HIP 58265"},
        {"Geneva Identification System", "GEN# +1.00103791"},
        {"Smithsonian Astrophysical Observation", "SAO 239517"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.23518372),
        dec: Angle.Degrees(-58.31802482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132137"},
        {"Hipparcos Number", "HIP 73396"},
        {"Geneva Identification System", "GEN# +1.00132137"},
        {"Smithsonian Astrophysical Observation", "SAO 242154"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.99423075),
        dec: Angle.Degrees(-58.31710337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114808"},
        {"Hipparcos Number", "HIP 64565"},
        {"Geneva Identification System", "GEN# +1.00114808"},
        {"Smithsonian Astrophysical Observation", "SAO 240660"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.51408390),
        dec: Angle.Degrees(-58.31706865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123994"},
        {"Hipparcos Number", "HIP 69413"},
        {"Geneva Identification System", "GEN# +1.00123994"},
        {"Smithsonian Astrophysical Observation", "SAO 241531"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.18243882),
        dec: Angle.Degrees(-58.31670303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98692"},
        {"Hipparcos Number", "HIP 55400"},
        {"Smithsonian Astrophysical Observation", "SAO 238981"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.17854386),
        dec: Angle.Degrees(-58.31660081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108395"},
        {"Hipparcos Number", "HIP 60780"},
        {"Smithsonian Astrophysical Observation", "SAO 239961"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.87015672),
        dec: Angle.Degrees(-58.31647941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110229"},
        {"Hipparcos Number", "HIP 61906"},
        {"Smithsonian Astrophysical Observation", "SAO 240145"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.29491905),
        dec: Angle.Degrees(-58.31647710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2883"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.13663377),
        dec: Angle.Degrees(-58.31469749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218312"},
        {"Hipparcos Number", "HIP 114216"},
        {"Smithsonian Astrophysical Observation", "SAO 247747"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.95330487),
        dec: Angle.Degrees(-58.30841396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92982"},
        {"Hipparcos Number", "HIP 52411"},
        {"Geneva Identification System", "GEN# +1.00092982"},
        {"Wilson Evans Batten Catalogue", "WEB 9539"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.71131019),
        dec: Angle.Degrees(-58.30789196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132208"},
        {"Hipparcos Number", "HIP 73420"},
        {"Smithsonian Astrophysical Observation", "SAO 242160"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.06776923),
        dec: Angle.Degrees(-58.30630317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219709"},
        {"Hipparcos Number", "HIP 115087"},
        {"Smithsonian Astrophysical Observation", "SAO 247822"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.65182275),
        dec: Angle.Degrees(-58.30597086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207377"},
        {"Hipparcos Number", "HIP 107806"},
        {"Geneva Identification System", "GEN# +1.00207377"},
        {"Smithsonian Astrophysical Observation", "SAO 247196"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.59889076),
        dec: Angle.Degrees(-58.30482369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164210"},
        {"Hipparcos Number", "HIP 88456"},
        {"Geneva Identification System", "GEN# +1.00164210"},
        {"Smithsonian Astrophysical Observation", "SAO 245202"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.90348543),
        dec: Angle.Degrees(-58.30285907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80252"},
        {"Hipparcos Number", "HIP 45500"},
        {"Smithsonian Astrophysical Observation", "SAO 236788"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.07115229),
        dec: Angle.Degrees(-58.30233430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176706"},
        {"Hipparcos Number", "HIP 93719"},
        {"Smithsonian Astrophysical Observation", "SAO 245907"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24209856),
        dec: Angle.Degrees(-58.30169189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27414"},
        {"Hipparcos Number", "HIP 19904"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.04942364),
        dec: Angle.Degrees(-58.30102556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82421"},
        {"Hipparcos Number", "HIP 46553"},
        {"Smithsonian Astrophysical Observation", "SAO 237039"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.40294791),
        dec: Angle.Degrees(-58.29918950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7029"},
        {"Hipparcos Number", "HIP 5439"},
        {"Smithsonian Astrophysical Observation", "SAO 232318"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.39284887),
        dec: Angle.Degrees(-58.29788553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111102"},
        {"Hipparcos Number", "HIP 62428"},
        {"Geneva Identification System", "GEN# +1.00111102"},
        {"Smithsonian Astrophysical Observation", "SAO 240257"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.91349571),
        dec: Angle.Degrees(-58.29753574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197529"},
        {"Hipparcos Number", "HIP 102555"},
        {"Smithsonian Astrophysical Observation", "SAO 246727"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.74547163),
        dec: Angle.Degrees(-58.29750415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8167"},
        {"Hipparcos Number", "HIP 6223"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.93961313),
        dec: Angle.Degrees(-58.29453985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209087"},
        {"Hipparcos Number", "HIP 108804"},
        {"Geneva Identification System", "GEN# +1.00209087"},
        {"Smithsonian Astrophysical Observation", "SAO 247282"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.62230728),
        dec: Angle.Degrees(-58.29450972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125545"},
        {"Hipparcos Number", "HIP 70228"},
        {"Geneva Identification System", "GEN# +1.00125545"},
        {"Smithsonian Astrophysical Observation", "SAO 241669"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.51259182),
        dec: Angle.Degrees(-58.29120937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109009"},
        {"Hipparcos Number", "HIP 61154"},
        {"Geneva Identification System", "GEN# +1.00109009"},
        {"Smithsonian Astrophysical Observation", "SAO 240032"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.97083527),
        dec: Angle.Degrees(-58.29062354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102875"},
        {"Hipparcos Number", "HIP 57739"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.60886094),
        dec: Angle.Degrees(-58.28703474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116793"},
        {"Hipparcos Number", "HIP 65619"},
        {"Smithsonian Astrophysical Observation", "SAO 240854"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.80659257),
        dec: Angle.Degrees(-58.28591048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100490"},
        {"Cincinnati Publication", "Ci 20 1202"},
        {"Geneva Identification System", "GEN# +6.00108058"},
        {"Geneva Identification System 2", "GEN# -0.05807734"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.67127784),
        dec: Angle.Degrees(-58.28460393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 757.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -434.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83866"},
        {"Hipparcos Number", "HIP 47370"},
        {"Celescope Catalog", "CEL 3354"},
        {"Geneva Identification System", "GEN# +1.00083866"},
        {"Smithsonian Astrophysical Observation", "SAO 237190"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.77198312),
        dec: Angle.Degrees(-58.28061978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222957"},
        {"Hipparcos Number", "HIP 117183"},
        {"Smithsonian Astrophysical Observation", "SAO 248008"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.39167467),
        dec: Angle.Degrees(-58.27893429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102007"},
        {"Hipparcos Number", "HIP 57226"},
        {"Geneva Identification System", "GEN# +1.00102007"},
        {"Smithsonian Astrophysical Observation", "SAO 239333"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00901065),
        dec: Angle.Degrees(-58.27795529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162297"},
        {"Hipparcos Number", "HIP 87619"},
        {"Smithsonian Astrophysical Observation", "SAO 245098"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.48082619),
        dec: Angle.Degrees(-58.27259505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10052"},
        {"Hipparcos Number", "HIP 7506"},
        {"Geneva Identification System", "GEN# +1.00010052"},
        {"Smithsonian Astrophysical Observation", "SAO 232477"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.18654178),
        dec: Angle.Degrees(-58.27096790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37965"},
        {"Hipparcos Number", "HIP 26540"},
        {"Smithsonian Astrophysical Observation", "SAO 234072"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.66369085),
        dec: Angle.Degrees(-58.26993832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185113"},
        {"Hipparcos Number", "HIP 96831"},
        {"Smithsonian Astrophysical Observation", "SAO 246207"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.22034301),
        dec: Angle.Degrees(-58.26954717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100693"},
        {"Hipparcos Number", "HIP 56475"},
        {"Geneva Identification System", "GEN# +1.00100693"},
        {"Smithsonian Astrophysical Observation", "SAO 239188"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.68249413),
        dec: Angle.Degrees(-58.26809325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4497"},
        {"Hipparcos Number", "HIP 3615"},
        {"Smithsonian Astrophysical Observation", "SAO 232175"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.58538460),
        dec: Angle.Degrees(-58.26745771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115496"},
        {"Hipparcos Number", "HIP 64941"},
        {"Geneva Identification System", "GEN# +1.00115496"},
        {"Smithsonian Astrophysical Observation", "SAO 240722"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.68525685),
        dec: Angle.Degrees(-58.26703253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129125"},
        {"Hipparcos Number", "HIP 71968"},
        {"Smithsonian Astrophysical Observation", "SAO 241933"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.78890705),
        dec: Angle.Degrees(-58.26645370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178630"},
        {"Hipparcos Number", "HIP 94400"},
        {"Geneva Identification System", "GEN# +1.00178630"},
        {"Smithsonian Astrophysical Observation", "SAO 245971"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.19447533),
        dec: Angle.Degrees(-58.26621406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2146"},
        {"Hipparcos Number", "HIP 1994"},
        {"Smithsonian Astrophysical Observation", "SAO 232032"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.31215318),
        dec: Angle.Degrees(-58.26568310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90074"},
        {"Hipparcos Number", "HIP 50785"},
        {"Smithsonian Astrophysical Observation", "SAO 237990"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.54364867),
        dec: Angle.Degrees(-58.26563700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102116"},
        {"Hipparcos Number", "HIP 57285"},
        {"Smithsonian Astrophysical Observation", "SAO 239344"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.19759557),
        dec: Angle.Degrees(-58.26473498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36352"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.22356223),
        dec: Angle.Degrees(-58.26305162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113656"},
        {"Hipparcos Number", "HIP 63940"},
        {"Geneva Identification System", "GEN# +1.00113656"},
        {"Smithsonian Astrophysical Observation", "SAO 240543"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.55933929),
        dec: Angle.Degrees(-58.26092727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97927"},
        {"Hipparcos Number", "HIP 54946"},
        {"Celescope Catalog", "CEL 3864"},
        {"Geneva Identification System", "GEN# +1.00097927"},
        {"Smithsonian Astrophysical Observation", "SAO 238902"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.77644828),
        dec: Angle.Degrees(-58.25916784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149612"},
        {"Hipparcos Number", "HIP 81520"},
        {"Geneva Identification System", "GEN# +1.00149612"},
        {"Smithsonian Astrophysical Observation", "SAO 244021"},
        {"Wilson Evans Batten Catalogue", "WEB 13770"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.76830429),
        dec: Angle.Degrees(-58.25750961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105921"},
        {"Hipparcos Number", "HIP 59437"},
        {"Smithsonian Astrophysical Observation", "SAO 239733"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.87855974),
        dec: Angle.Degrees(-58.25732724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112583"},
        {"Hipparcos Number", "HIP 63315"},
        {"Geneva Identification System", "GEN# +1.00112583"},
        {"Smithsonian Astrophysical Observation", "SAO 240431"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.63281943),
        dec: Angle.Degrees(-58.25621206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110206"},
        {"Hipparcos Number", "HIP 61898"},
        {"Smithsonian Astrophysical Observation", "SAO 240144"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.26236929),
        dec: Angle.Degrees(-58.25377763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103235"},
        {"Hipparcos Number", "HIP 57947"},
        {"Geneva Identification System", "GEN# +1.00103235"},
        {"Smithsonian Astrophysical Observation", "SAO 239458"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.26972202),
        dec: Angle.Degrees(-58.25345335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112703"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.35726267),
        dec: Angle.Degrees(-58.25296833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209256"},
        {"Hipparcos Number", "HIP 108910"},
        {"Smithsonian Astrophysical Observation", "SAO 247290"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.91383799),
        dec: Angle.Degrees(-58.25216807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36491"},
        {"Hipparcos Number", "HIP 25625"},
        {"Smithsonian Astrophysical Observation", "SAO 233992"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.11151084),
        dec: Angle.Degrees(-58.24980968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152007"},
        {"Hipparcos Number", "HIP 82698"},
        {"Smithsonian Astrophysical Observation", "SAO 244254"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.56913680),
        dec: Angle.Degrees(-58.24967447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119600"},
        {"Hipparcos Number", "HIP 67149"},
        {"Smithsonian Astrophysical Observation", "SAO 241142"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.41400390),
        dec: Angle.Degrees(-58.24288388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174785"},
        {"Hipparcos Number", "HIP 92899"},
        {"Geneva Identification System", "GEN# +1.00174785"},
        {"Smithsonian Astrophysical Observation", "SAO 245805"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.93185121),
        dec: Angle.Degrees(-58.24279026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302110"},
        {"Hipparcos Number", "HIP 45026"},
        {"Smithsonian Astrophysical Observation", "SAO 236683"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.57262740),
        dec: Angle.Degrees(-58.24184407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29416"},
        {"Hipparcos Number", "HIP 21312"},
        {"Smithsonian Astrophysical Observation", "SAO 233571"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.63844932),
        dec: Angle.Degrees(-58.24068757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113464"},
        {"Hipparcos Number", "HIP 63826"},
        {"Geneva Identification System", "GEN# +1.00113464"},
        {"Smithsonian Astrophysical Observation", "SAO 240525"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.21618642),
        dec: Angle.Degrees(-58.23991699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18913"},
        {"Hipparcos Number", "HIP 13975"},
        {"Smithsonian Astrophysical Observation", "SAO 232963"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.00328715),
        dec: Angle.Degrees(-58.23988544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76640"},
        {"Hipparcos Number", "HIP 43763"},
        {"Celescope Catalog", "CEL 3084"},
        {"Geneva Identification System", "GEN# +1.00076640"},
        {"Smithsonian Astrophysical Observation", "SAO 236402"},
        {"Wilson Evans Batten Catalogue", "WEB 8420"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.72521204),
        dec: Angle.Degrees(-58.23969727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199658"},
        {"Hipparcos Number", "HIP 103733"},
        {"Smithsonian Astrophysical Observation", "SAO 246826"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.30270482),
        dec: Angle.Degrees(-58.23853941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159604"},
        {"Hipparcos Number", "HIP 86386"},
        {"Geneva Identification System", "GEN# +1.00159604"},
        {"Smithsonian Astrophysical Observation", "SAO 244906"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77498618),
        dec: Angle.Degrees(-58.23601588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219571"},
        {"Hipparcos Number", "HIP 114996"},
        {"Fundamental Katalog 5th Edition", "FK5 877"},
        {"Geneva Identification System", "GEN# +1.00219571"},
        {"Smithsonian Astrophysical Observation", "SAO 247814"},
        {"Wilson Evans Batten Catalogue", "WEB 20372"},
    },
    visualMagnitude: 3.99,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.35755018),
        dec: Angle.Degrees(-58.23592762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184820"},
        {"Hipparcos Number", "HIP 96701"},
        {"Geneva Identification System", "GEN# +1.00184820"},
        {"Smithsonian Astrophysical Observation", "SAO 246200"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.88793421),
        dec: Angle.Degrees(-58.23182105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150978"},
        {"Hipparcos Number", "HIP 82224"},
        {"Smithsonian Astrophysical Observation", "SAO 244141"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.96194237),
        dec: Angle.Degrees(-58.23095489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62897"},
        {"Hipparcos Number", "HIP 37599"},
        {"Geneva Identification System", "GEN# +1.00062897"},
        {"Smithsonian Astrophysical Observation", "SAO 235440"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.72235259),
        dec: Angle.Degrees(-58.23015202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75643"},
        {"Hipparcos Number", "HIP 43237"},
        {"Smithsonian Astrophysical Observation", "SAO 236296"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.11275359),
        dec: Angle.Degrees(-58.22695754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73390"},
        {"Hipparcos Number", "HIP 42129"},
        {"Celescope Catalog", "CEL 2688"},
        {"Geneva Identification System", "GEN# +1.00073390"},
        {"Smithsonian Astrophysical Observation", "SAO 236105"},
        {"Wilson Evans Batten Catalogue", "WEB 8097"},
    },
    visualMagnitude: 5.27,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.81491578),
        dec: Angle.Degrees(-58.22476298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91969"},
        {"Hipparcos Number", "HIP 51866"},
        {"Celescope Catalog", "CEL 3587"},
        {"Geneva Identification System", "GEN# +2.32930004"},
        {"Smithsonian Astrophysical Observation", "SAO 238230"},
        {"Wilson Evans Batten Catalogue", "WEB 9451"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.95552555),
        dec: Angle.Degrees(-58.22429040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178025"},
        {"Hipparcos Number", "HIP 94181"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.60940447),
        dec: Angle.Degrees(-58.22412192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60422"},
    },
    visualMagnitude: 12.00,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.83487665),
        dec: Angle.Degrees(-35.05102287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45924"},
        {"Hipparcos Number", "HIP 30673"},
        {"Smithsonian Astrophysical Observation", "SAO 234512"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.68212418),
        dec: Angle.Degrees(-58.22240548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24201"},
        {"Hipparcos Number", "HIP 17760"},
        {"Smithsonian Astrophysical Observation", "SAO 233279"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.03475185),
        dec: Angle.Degrees(-58.22204721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41555"},
        {"Hipparcos Number", "HIP 28605"},
        {"Smithsonian Astrophysical Observation", "SAO 234265"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.56156855),
        dec: Angle.Degrees(-58.22156949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154027"},
        {"Hipparcos Number", "HIP 83702"},
        {"Smithsonian Astrophysical Observation", "SAO 244431"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.60195533),
        dec: Angle.Degrees(-58.21816178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128122"},
        {"Hipparcos Number", "HIP 71503"},
        {"Smithsonian Astrophysical Observation", "SAO 241847"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.34351473),
        dec: Angle.Degrees(-58.21567135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85496"},
        {"Hipparcos Number", "HIP 48251"},
        {"Celescope Catalog", "CEL 3389"},
        {"Geneva Identification System", "GEN# +1.00085496"},
        {"Smithsonian Astrophysical Observation", "SAO 237393"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.54808832),
        dec: Angle.Degrees(-58.21563744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213568"},
        {"Hipparcos Number", "HIP 111357"},
        {"Geneva Identification System", "GEN# +1.00213568"},
        {"Smithsonian Astrophysical Observation", "SAO 247487"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.40272545),
        dec: Angle.Degrees(-58.21410033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139070"},
        {"Hipparcos Number", "HIP 76623"},
        {"Smithsonian Astrophysical Observation", "SAO 242788"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.71943501),
        dec: Angle.Degrees(-58.21121014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116084",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Poerava"},
        {"Henry Draper", "HD 221287"},
        {"Hipparcos Number", "HIP 116084"},
        {"Geneva Identification System", "GEN# +1.00221287"},
        {"Smithsonian Astrophysical Observation", "SAO 247912"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83390852),
        dec: Angle.Degrees(-58.20971914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119512"},
        {"Hipparcos Number", "HIP 67100"},
        {"Geneva Identification System", "GEN# +1.00119512"},
        {"Smithsonian Astrophysical Observation", "SAO 241131"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.29758301),
        dec: Angle.Degrees(-58.20941948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3418"},
        {"Hipparcos Number", "HIP 2878"},
        {"Smithsonian Astrophysical Observation", "SAO 232110"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.11512740),
        dec: Angle.Degrees(-58.20919182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32227"},
        {"Hipparcos Number", "HIP 23081"},
        {"Geneva Identification System", "GEN# +1.00032227"},
        {"Smithsonian Astrophysical Observation", "SAO 233767"},
        {"Wilson Evans Batten Catalogue", "WEB 4479"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.50827536),
        dec: Angle.Degrees(-58.20823622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118370"},
        {"Hipparcos Number", "HIP 66505"},
        {"Geneva Identification System", "GEN# +1.00118370"},
        {"Smithsonian Astrophysical Observation", "SAO 241009"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.49216123),
        dec: Angle.Degrees(-58.20810078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204857"},
        {"Hipparcos Number", "HIP 106436"},
        {"Geneva Identification System", "GEN# +1.00204857"},
        {"Smithsonian Astrophysical Observation", "SAO 247079"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.37174917),
        dec: Angle.Degrees(-58.20546918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80212"},
        {"Hipparcos Number", "HIP 45479"},
        {"Smithsonian Astrophysical Observation", "SAO 236786"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.01117049),
        dec: Angle.Degrees(-58.20541902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29781"},
        {"Hipparcos Number", "HIP 21585"},
        {"Geneva Identification System", "GEN# +1.00029781"},
        {"Smithsonian Astrophysical Observation", "SAO 233601"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.53163115),
        dec: Angle.Degrees(-58.20387704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3137"},
        {"Hipparcos Number", "HIP 2684"},
        {"Smithsonian Astrophysical Observation", "SAO 232090"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.51435983),
        dec: Angle.Degrees(-58.20167909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122559"},
        {"Hipparcos Number", "HIP 68759"},
        {"Renson", "Renson 35170"},
        {"Smithsonian Astrophysical Observation", "SAO 241413"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.10430578),
        dec: Angle.Degrees(-58.20054907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33354"},
        {"Hipparcos Number", "HIP 23732"},
        {"Smithsonian Astrophysical Observation", "SAO 233824"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53317495),
        dec: Angle.Degrees(-58.19902484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138181"},
        {"Hipparcos Number", "HIP 76144"},
        {"Geneva Identification System", "GEN# +1.00138181"},
        {"Smithsonian Astrophysical Observation", "SAO 242679"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.28901214),
        dec: Angle.Degrees(-58.19857220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88176"},
        {"Hipparcos Number", "HIP 49662"},
        {"Geneva Identification System", "GEN# +1.00088176"},
        {"Smithsonian Astrophysical Observation", "SAO 237722"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.07552435),
        dec: Angle.Degrees(-58.19854917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161047"},
        {"Hipparcos Number", "HIP 87021"},
        {"Smithsonian Astrophysical Observation", "SAO 245013"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71682981),
        dec: Angle.Degrees(-58.19536893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138168"},
        {"Hipparcos Number", "HIP 76137"},
        {"Geneva Identification System", "GEN# +1.00138168"},
        {"Smithsonian Astrophysical Observation", "SAO 242678"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.27018374),
        dec: Angle.Degrees(-58.19399220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94113"},
        {"Hipparcos Number", "HIP 53003"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.65014045),
        dec: Angle.Degrees(-58.19383748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91943"},
        {"Hipparcos Number", "HIP 51857"},
        {"Geneva Identification System", "GEN# +2.32930003"},
        {"Smithsonian Astrophysical Observation", "SAO 238225"},
        {"Wilson Evans Batten Catalogue", "WEB 9447"},
        {"New General Catalogue", "NGC 3293 3"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.92506420),
        dec: Angle.Degrees(-58.19289036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131612"},
        {"Hipparcos Number", "HIP 73155"},
        {"Geneva Identification System", "GEN# +1.00131612"},
        {"Smithsonian Astrophysical Observation", "SAO 242126"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.26250682),
        dec: Angle.Degrees(-58.19141888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165937"},
        {"Hipparcos Number", "HIP 89173"},
        {"Fundamental Katalog 5th Edition", "FK5 5604"},
        {"Geneva Identification System", "GEN# +1.00165937"},
        {"Smithsonian Astrophysical Observation", "SAO 245297"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.98064454),
        dec: Angle.Degrees(-58.19043615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91619"},
        {"Hipparcos Number", "HIP 51676"},
        {"Celescope Catalog", "CEL 3575"},
        {"Geneva Identification System", "GEN# +1.00091619"},
        {"Smithsonian Astrophysical Observation", "SAO 238182"},
        {"Wilson Evans Batten Catalogue", "WEB 9423"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.35582196),
        dec: Angle.Degrees(-58.19015734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222081"},
        {"Hipparcos Number", "HIP 116612"},
        {"Geneva Identification System", "GEN# +1.00222081"},
        {"Smithsonian Astrophysical Observation", "SAO 247957"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.49138335),
        dec: Angle.Degrees(-58.18930681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116242"},
        {"Hipparcos Number", "HIP 65337"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.87993772),
        dec: Angle.Degrees(-58.18867339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108857"},
        {"Hipparcos Number", "HIP 61049"},
        {"Smithsonian Astrophysical Observation", "SAO 240010"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.69298534),
        dec: Angle.Degrees(-58.18796014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134958"},
        {"Hipparcos Number", "HIP 74654"},
        {"Geneva Identification System", "GEN# +1.00134958"},
        {"Smithsonian Astrophysical Observation", "SAO 242346"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.81739585),
        dec: Angle.Degrees(-58.17287617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12351"},
        {"Geneva Identification System", "GEN# -0.05800223"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.75497757),
        dec: Angle.Degrees(-58.18722018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98434"},
        {"Hipparcos Number", "HIP 55238"},
        {"Smithsonian Astrophysical Observation", "SAO 238956"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.68242974),
        dec: Angle.Degrees(-58.18642824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167238"},
        {"Hipparcos Number", "HIP 89652"},
        {"Smithsonian Astrophysical Observation", "SAO 245376"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.44459091),
        dec: Angle.Degrees(-58.18522507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166726"},
        {"Hipparcos Number", "HIP 89469"},
        {"Smithsonian Astrophysical Observation", "SAO 245345"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.87765862),
        dec: Angle.Degrees(-58.18410133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108571"},
        {"Hipparcos Number", "HIP 60884"},
        {"Smithsonian Astrophysical Observation", "SAO 239979"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.16467826),
        dec: Angle.Degrees(-58.18351669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48927"},
        {"Hipparcos Number", "HIP 32099"},
        {"Smithsonian Astrophysical Observation", "SAO 234664"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.58756802),
        dec: Angle.Degrees(-58.18301449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97965"},
        {"Hipparcos Number", "HIP 54957"},
        {"Smithsonian Astrophysical Observation", "SAO 238907"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.81721100),
        dec: Angle.Degrees(-58.18135253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98371"},
        {"Hipparcos Number", "HIP 55205"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.56397626),
        dec: Angle.Degrees(-58.17980410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15291"},
        {"Hipparcos Number", "HIP 11308"},
        {"Smithsonian Astrophysical Observation", "SAO 232764"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.39058851),
        dec: Angle.Degrees(-58.17957249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106981"},
        {"Hipparcos Number", "HIP 60010"},
        {"Geneva Identification System", "GEN# +1.00106981"},
        {"Smithsonian Astrophysical Observation", "SAO 239828"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.60934045),
        dec: Angle.Degrees(-58.17941429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45408"},
        {"Hipparcos Number", "HIP 30401"},
        {"Smithsonian Astrophysical Observation", "SAO 234479"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.88845233),
        dec: Angle.Degrees(-58.17926133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26122"},
        {"Hipparcos Number", "HIP 19045"},
        {"Smithsonian Astrophysical Observation", "SAO 233394"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.20940317),
        dec: Angle.Degrees(-58.17785143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176665"},
        {"Hipparcos Number", "HIP 93688"},
        {"Smithsonian Astrophysical Observation", "SAO 245903"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.18469486),
        dec: Angle.Degrees(-58.17591163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52552"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16747007),
        dec: Angle.Degrees(-58.17497205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 247.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155901"},
        {"Hipparcos Number", "HIP 84619"},
        {"Geneva Identification System", "GEN# +1.00155901"},
        {"Smithsonian Astrophysical Observation", "SAO 244586"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.47893152),
        dec: Angle.Degrees(-58.17485778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50244"},
        {"Wilson Evans Batten Catalogue", "WEB 9230"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.88696849),
        dec: Angle.Degrees(-58.17445560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155067"},
        {"Hipparcos Number", "HIP 84208"},
        {"Smithsonian Astrophysical Observation", "SAO 244516"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.20768544),
        dec: Angle.Degrees(-58.17256638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209367"},
        {"Hipparcos Number", "HIP 108968"},
        {"Smithsonian Astrophysical Observation", "SAO 247295"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.13843974),
        dec: Angle.Degrees(-58.17051641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222006"},
        {"Hipparcos Number", "HIP 116570"},
        {"Smithsonian Astrophysical Observation", "SAO 247952"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34380961),
        dec: Angle.Degrees(-58.16976912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35977"},
        {"Hipparcos Number", "HIP 25313"},
        {"Smithsonian Astrophysical Observation", "SAO 233971"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.21264754),
        dec: Angle.Degrees(-58.16895877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199080"},
        {"Hipparcos Number", "HIP 103430"},
        {"Geneva Identification System", "GEN# +1.00199080"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.32708420),
        dec: Angle.Degrees(-58.16723682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111538"},
        {"Hipparcos Number", "HIP 62680"},
        {"Geneva Identification System", "GEN# +1.00111538"},
        {"Smithsonian Astrophysical Observation", "SAO 240307"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.66162579),
        dec: Angle.Degrees(-58.16636769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44268"},
        {"Hipparcos Number", "HIP 29858"},
        {"Geneva Identification System", "GEN# +1.00044268"},
        {"Smithsonian Astrophysical Observation", "SAO 234423"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.31161509),
        dec: Angle.Degrees(-58.16552162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106871"},
        {"Hipparcos Number", "HIP 59935"},
        {"Celescope Catalog", "CEL 4087"},
        {"Geneva Identification System", "GEN# +1.00106871"},
        {"Smithsonian Astrophysical Observation", "SAO 239816"},
        {"Wilson Evans Batten Catalogue", "WEB 10648"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.40473593),
        dec: Angle.Degrees(-58.16456890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69597"},
        {"Hipparcos Number", "HIP 40382"},
        {"Smithsonian Astrophysical Observation", "SAO 235834"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66617535),
        dec: Angle.Degrees(-58.16399077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208150"},
        {"Hipparcos Number", "HIP 108277"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.04260168),
        dec: Angle.Degrees(-58.15817056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91824"},
        {"Hipparcos Number", "HIP 51773"},
        {"Celescope Catalog", "CEL 3584"},
        {"Geneva Identification System", "GEN# +2.32930001"},
        {"Smithsonian Astrophysical Observation", "SAO 238207"},
        {"Wilson Evans Batten Catalogue", "WEB 9432"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.69433540),
        dec: Angle.Degrees(-58.15613020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98584"},
        {"Hipparcos Number", "HIP 55336"},
        {"Celescope Catalog", "CEL 3877"},
        {"Geneva Identification System", "GEN# +1.00098584"},
        {"Smithsonian Astrophysical Observation", "SAO 238971"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.97894147),
        dec: Angle.Degrees(-58.15470026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204708"},
        {"Hipparcos Number", "HIP 106370"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.16107454),
        dec: Angle.Degrees(-58.15354585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184900"},
        {"Hipparcos Number", "HIP 96732"},
        {"Geneva Identification System", "GEN# +1.00184900"},
        {"Smithsonian Astrophysical Observation", "SAO 246201"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.96049579),
        dec: Angle.Degrees(-58.15317398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1298"},
        {"Hipparcos Number", "HIP 1356"},
        {"Smithsonian Astrophysical Observation", "SAO 231988"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.23981308),
        dec: Angle.Degrees(-58.15191785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97187"},
        {"Hipparcos Number", "HIP 54594"},
        {"Smithsonian Astrophysical Observation", "SAO 238837"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.59344607),
        dec: Angle.Degrees(-58.15099673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93307"},
        {"Hipparcos Number", "HIP 52578"},
        {"Geneva Identification System", "GEN# +1.00093307"},
        {"Smithsonian Astrophysical Observation", "SAO 238428"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.26757090),
        dec: Angle.Degrees(-58.14876458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93001"},
        {"Hipparcos Number", "HIP 52430"},
        {"Geneva Identification System", "GEN# +1.00093001"},
        {"Smithsonian Astrophysical Observation", "SAO 238384"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77492149),
        dec: Angle.Degrees(-58.14721010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219942"},
        {"Hipparcos Number", "HIP 115233"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.10417655),
        dec: Angle.Degrees(-58.14606837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46132"},
        {"Hipparcos Number", "HIP 30770"},
        {"Smithsonian Astrophysical Observation", "SAO 234522"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.98653458),
        dec: Angle.Degrees(-58.14467602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223411"},
        {"Hipparcos Number", "HIP 117487"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.35704715),
        dec: Angle.Degrees(-58.14452052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99823"},
        {"Hipparcos Number", "HIP 55999"},
        {"Smithsonian Astrophysical Observation", "SAO 239097"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.14346133),
        dec: Angle.Degrees(-58.14201214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125811"},
        {"Hipparcos Number", "HIP 70361"},
        {"Geneva Identification System", "GEN# +1.00125811"},
        {"Smithsonian Astrophysical Observation", "SAO 241689"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.94769559),
        dec: Angle.Degrees(-58.14196822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126592"},
        {"Hipparcos Number", "HIP 70780"},
        {"Geneva Identification System", "GEN# +1.00126592"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12984853),
        dec: Angle.Degrees(-58.14145231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15546"},
        {"Hipparcos Number", "HIP 11469"},
        {"Smithsonian Astrophysical Observation", "SAO 232780"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.98890041),
        dec: Angle.Degrees(-58.13953514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9896"},
        {"Hipparcos Number", "HIP 7387"},
        {"Geneva Identification System", "GEN# +1.00009896"},
        {"Smithsonian Astrophysical Observation", "SAO 232470"},
        {"Wilson Evans Batten Catalogue", "WEB 1587"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.81128987),
        dec: Angle.Degrees(-58.13939438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 284.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115473"},
        {"Hipparcos Number", "HIP 64929"},
        {"Geneva Identification System", "GEN# +1.00115473"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.61665718),
        dec: Angle.Degrees(-58.13710091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16950"},
        {"Hipparcos Number", "HIP 12494"},
        {"Geneva Identification System", "GEN# +1.00016950"},
        {"Smithsonian Astrophysical Observation", "SAO 232858"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.18179253),
        dec: Angle.Degrees(-58.13698934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71634"},
        {"Hipparcos Number", "HIP 41293"},
        {"Celescope Catalog", "CEL 2503"},
        {"Geneva Identification System", "GEN# +1.00071634"},
        {"Smithsonian Astrophysical Observation", "SAO 235968"},
        {"Wilson Evans Batten Catalogue", "WEB 7989"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.37614508),
        dec: Angle.Degrees(-58.13322837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224323"},
        {"Hipparcos Number", "HIP 118072"},
        {"Smithsonian Astrophysical Observation", "SAO 248076"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.26705259),
        dec: Angle.Degrees(-58.13214076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170258"},
        {"Hipparcos Number", "HIP 90843"},
        {"Smithsonian Astrophysical Observation", "SAO 245529"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98522100),
        dec: Angle.Degrees(-58.13070709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78883"},
        {"Hipparcos Number", "HIP 44827"},
        {"Geneva Identification System", "GEN# +1.00078883"},
        {"Smithsonian Astrophysical Observation", "SAO 236646"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02289706),
        dec: Angle.Degrees(-58.12980755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86823"},
        {"Hipparcos Number", "HIP 48956"},
        {"Geneva Identification System", "GEN# +1.00086823"},
        {"Smithsonian Astrophysical Observation", "SAO 237564"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.80446428),
        dec: Angle.Degrees(-58.12823034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85610"},
        {"Hipparcos Number", "HIP 48322"},
        {"Smithsonian Astrophysical Observation", "SAO 237407"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.75469589),
        dec: Angle.Degrees(-58.12706126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197507"},
        {"Hipparcos Number", "HIP 102548"},
        {"Geneva Identification System", "GEN# +1.00197507"},
        {"Smithsonian Astrophysical Observation", "SAO 246726"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.71262101),
        dec: Angle.Degrees(-58.12699349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160569"},
        {"Hipparcos Number", "HIP 86793"},
        {"Geneva Identification System", "GEN# +1.00160569"},
        {"Smithsonian Astrophysical Observation", "SAO 244973"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.02648576),
        dec: Angle.Degrees(-58.12568151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140504"},
        {"Hipparcos Number", "HIP 77294"},
        {"Smithsonian Astrophysical Observation", "SAO 242947"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.71236166),
        dec: Angle.Degrees(-58.12513844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95321"},
        {"Hipparcos Number", "HIP 53708"},
        {"Renson", "Renson 27480"},
        {"Smithsonian Astrophysical Observation", "SAO 238659"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.83576203),
        dec: Angle.Degrees(-58.12444514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219840"},
        {"Hipparcos Number", "HIP 115157"},
        {"Smithsonian Astrophysical Observation", "SAO 247830"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.89153135),
        dec: Angle.Degrees(-58.12422572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147799"},
        {"Hipparcos Number", "HIP 80578"},
        {"Smithsonian Astrophysical Observation", "SAO 243809"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.78726671),
        dec: Angle.Degrees(-58.12147627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107976"},
        {"Hipparcos Number", "HIP 60557"},
        {"Geneva Identification System", "GEN# +2.43370017"},
        {"Geneva Identification System 2", "GEN# +2.43370018"},
        {"Smithsonian Astrophysical Observation", "SAO 239932"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.20599889),
        dec: Angle.Degrees(-58.11964061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130169"},
        {"Hipparcos Number", "HIP 72455"},
        {"Geneva Identification System", "GEN# +1.00130169"},
        {"Smithsonian Astrophysical Observation", "SAO 242019"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.24461070),
        dec: Angle.Degrees(-58.11936009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191371"},
        {"Hipparcos Number", "HIP 99583"},
        {"Geneva Identification System", "GEN# +1.00191371"},
        {"Smithsonian Astrophysical Observation", "SAO 246481"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.14260883),
        dec: Angle.Degrees(-58.11645349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143525"},
        {"Hipparcos Number", "HIP 78698"},
        {"Smithsonian Astrophysical Observation", "SAO 243282"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.97382972),
        dec: Angle.Degrees(-58.11637910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109265"},
        {"Hipparcos Number", "HIP 61324"},
        {"Smithsonian Astrophysical Observation", "SAO 240059"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.45933327),
        dec: Angle.Degrees(-58.11571072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139792"},
        {"Hipparcos Number", "HIP 76968"},
        {"Smithsonian Astrophysical Observation", "SAO 242853"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.74271071),
        dec: Angle.Degrees(-58.11466301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195289"},
        {"Hipparcos Number", "HIP 101422"},
        {"Geneva Identification System", "GEN# +1.00195289"},
        {"Smithsonian Astrophysical Observation", "SAO 246629"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.30518225),
        dec: Angle.Degrees(-58.11227860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221252"},
        {"Hipparcos Number", "HIP 116056"},
        {"Smithsonian Astrophysical Observation", "SAO 247908"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.73542461),
        dec: Angle.Degrees(-58.11224793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110887"},
        {"Geneva Identification System", "GEN# +6.20145109"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.97375116),
        dec: Angle.Degrees(-58.11075058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157755"},
        {"Hipparcos Number", "HIP 85516"},
        {"Geneva Identification System", "GEN# +1.00157755"},
        {"Smithsonian Astrophysical Observation", "SAO 244766"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.14783654),
        dec: Angle.Degrees(-58.11043625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35460"},
        {"Hipparcos Number", "HIP 25005"},
        {"Smithsonian Astrophysical Observation", "SAO 233944"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30896362),
        dec: Angle.Degrees(-58.10686748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101544"},
        {"Hipparcos Number", "HIP 56966"},
        {"Geneva Identification System", "GEN# +1.00101544"},
        {"Smithsonian Astrophysical Observation", "SAO 239285"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17013783),
        dec: Angle.Degrees(-58.10436623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80560"},
        {"Hipparcos Number", "HIP 45642"},
        {"Smithsonian Astrophysical Observation", "SAO 236830"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.54641977),
        dec: Angle.Degrees(-58.10298421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116906"},
        {"Hipparcos Number", "HIP 65679"},
        {"Smithsonian Astrophysical Observation", "SAO 240861"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.99973365),
        dec: Angle.Degrees(-58.10280284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14860"},
        {"Hipparcos Number", "HIP 10997"},
        {"Smithsonian Astrophysical Observation", "SAO 232730"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.42903594),
        dec: Angle.Degrees(-58.10252939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41296"},
        {"Hipparcos Number", "HIP 28464"},
        {"Fundamental Katalog 5th Edition", "FK5 2462"},
        {"Geneva Identification System", "GEN# +1.00041296"},
        {"Smithsonian Astrophysical Observation", "SAO 234252"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.14886147),
        dec: Angle.Degrees(-58.10215380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22216"},
        {"Hipparcos Number", "HIP 16443"},
        {"Smithsonian Astrophysical Observation", "SAO 233149"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.94586637),
        dec: Angle.Degrees(-58.09966436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87168"},
        {"Hipparcos Number", "HIP 49117"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.36400517),
        dec: Angle.Degrees(-58.09818281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58744"},
        {"Hipparcos Number", "HIP 35863"},
        {"Smithsonian Astrophysical Observation", "SAO 235164"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.90553380),
        dec: Angle.Degrees(-58.09720479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35845"},
        {"Hipparcos Number", "HIP 25251"},
        {"Geneva Identification System", "GEN# +1.00035845"},
        {"Smithsonian Astrophysical Observation", "SAO 233963"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.00138282),
        dec: Angle.Degrees(-58.09505855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82082"},
        {"Hipparcos Number", "HIP 46388"},
        {"Geneva Identification System", "GEN# +1.00082082"},
        {"Smithsonian Astrophysical Observation", "SAO 237002"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.88248802),
        dec: Angle.Degrees(-58.09453770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203693"},
        {"Hipparcos Number", "HIP 105830"},
        {"Geneva Identification System", "GEN# +1.00203693"},
        {"Smithsonian Astrophysical Observation", "SAO 247024"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.53008073),
        dec: Angle.Degrees(-58.09426203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193833"},
        {"Hipparcos Number", "HIP 100725"},
        {"Smithsonian Astrophysical Observation", "SAO 246569"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.31320569),
        dec: Angle.Degrees(-58.09375134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156308"},
        {"Hipparcos Number", "HIP 84834"},
        {"Smithsonian Astrophysical Observation", "SAO 244634"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.08312115),
        dec: Angle.Degrees(-58.09222872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214196"},
        {"Hipparcos Number", "HIP 111731"},
        {"Geneva Identification System", "GEN# +1.00214196"},
        {"Smithsonian Astrophysical Observation", "SAO 247521"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.49710465),
        dec: Angle.Degrees(-58.09170725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146404"},
        {"Hipparcos Number", "HIP 79961"},
        {"Geneva Identification System", "GEN# +2.60870021"},
        {"Smithsonian Astrophysical Observation", "SAO 243603"},
        {"Wilson Evans Batten Catalogue", "WEB 13534"},
        {"New General Catalogue", "NGC 6087 21"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.82119474),
        dec: Angle.Degrees(-58.09134771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178084"},
        {"Hipparcos Number", "HIP 94200"},
        {"Geneva Identification System", "GEN# +1.00178084"},
        {"Smithsonian Astrophysical Observation", "SAO 245951"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.66624172),
        dec: Angle.Degrees(-58.08883261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109752"},
        {"Hipparcos Number", "HIP 61613"},
        {"Celescope Catalog", "CEL 4133"},
        {"Geneva Identification System", "GEN# +1.00109752J"},
        {"Smithsonian Astrophysical Observation", "SAO 240095"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.39140720),
        dec: Angle.Degrees(-58.08866905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161497"},
        {"Hipparcos Number", "HIP 87229"},
        {"Smithsonian Astrophysical Observation", "SAO 245051"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.34682920),
        dec: Angle.Degrees(-58.08673819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129090"},
        {"Hipparcos Number", "HIP 71942"},
        {"Geneva Identification System", "GEN# +1.00129090"},
        {"Smithsonian Astrophysical Observation", "SAO 241927"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.71637548),
        dec: Angle.Degrees(-58.08655900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219345"},
        {"Hipparcos Number", "HIP 114851"},
        {"Geneva Identification System", "GEN# +1.00219345"},
        {"Smithsonian Astrophysical Observation", "SAO 247802"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.95651866),
        dec: Angle.Degrees(-58.08255800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149040"},
        {"Hipparcos Number", "HIP 81227"},
        {"Smithsonian Astrophysical Observation", "SAO 243964"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85453658),
        dec: Angle.Degrees(-58.08204015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122936"},
        {"Hipparcos Number", "HIP 68934"},
        {"Smithsonian Astrophysical Observation", "SAO 241446"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67203757),
        dec: Angle.Degrees(-58.07945823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24101"},
        {"Hipparcos Number", "HIP 17691"},
        {"Geneva Identification System", "GEN# +1.00024101"},
        {"Smithsonian Astrophysical Observation", "SAO 233272"},
    },
    visualMagnitude: 9.93,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.83624982),
        dec: Angle.Degrees(-58.07679257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153860"},
        {"Hipparcos Number", "HIP 83618"},
        {"Smithsonian Astrophysical Observation", "SAO 244414"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34776223),
        dec: Angle.Degrees(-58.07660614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59780"},
        {"Hipparcos Number", "HIP 36287"},
        {"Smithsonian Astrophysical Observation", "SAO 235221"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.04756880),
        dec: Angle.Degrees(-58.07288277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119814"},
        {"Hipparcos Number", "HIP 67251"},
        {"Smithsonian Astrophysical Observation", "SAO 241159"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.76181432),
        dec: Angle.Degrees(-58.07111030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104346"},
        {"Hipparcos Number", "HIP 58584"},
        {"Geneva Identification System", "GEN# +1.00104346"},
        {"Smithsonian Astrophysical Observation", "SAO 239581"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.20815306),
        dec: Angle.Degrees(-58.07083390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65338"},
    },
    visualMagnitude: 12.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88033011),
        dec: Angle.Degrees(-34.90250144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32065"},
        {"Hipparcos Number", "HIP 23029"},
        {"Geneva Identification System", "GEN# +1.00032065"},
        {"Smithsonian Astrophysical Observation", "SAO 233757"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.28114987),
        dec: Angle.Degrees(-58.06987163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
