using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_17() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90134"},
        {"Hipparcos Number", "HIP 50861"},
        {"Geneva Identification System", "GEN# +1.00090134"},
        {"Smithsonian Astrophysical Observation", "SAO 238004"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77947732),
        dec: Angle.Degrees(-50.52720774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5936"},
        {"Hipparcos Number", "HIP 4685"},
        {"Smithsonian Astrophysical Observation", "SAO 232254"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.04595136),
        dec: Angle.Degrees(-50.52413366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165025"},
        {"Hipparcos Number", "HIP 88710"},
        {"Geneva Identification System", "GEN# +1.00165025"},
        {"Smithsonian Astrophysical Observation", "SAO 245241"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.64803497),
        dec: Angle.Degrees(-50.52411788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109853"},
        {"Hipparcos Number", "HIP 61663"},
        {"Smithsonian Astrophysical Observation", "SAO 240109"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.60706381),
        dec: Angle.Degrees(-50.52395254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198532"},
        {"Hipparcos Number", "HIP 103063"},
        {"Geneva Identification System", "GEN# +1.00198532"},
        {"Smithsonian Astrophysical Observation", "SAO 246768"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.22413135),
        dec: Angle.Degrees(-50.52213589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64717"},
        {"Hipparcos Number", "HIP 38477"},
        {"Celescope Catalog", "CEL 2079"},
        {"Geneva Identification System", "GEN# +1.00064717"},
        {"Smithsonian Astrophysical Observation", "SAO 235584"},
        {"Wilson Evans Batten Catalogue", "WEB 7564"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.20932836),
        dec: Angle.Degrees(-50.52170405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68188"},
        {"Hipparcos Number", "HIP 39912"},
        {"Smithsonian Astrophysical Observation", "SAO 235774"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.27409154),
        dec: Angle.Degrees(-50.51992787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68787"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.19332252),
        dec: Angle.Degrees(-50.51918617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30095"},
        {"Hipparcos Number", "HIP 21855"},
        {"Geneva Identification System", "GEN# +1.00030095"},
        {"Smithsonian Astrophysical Observation", "SAO 233631"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.49572672),
        dec: Angle.Degrees(-50.51871834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199131"},
        {"Hipparcos Number", "HIP 103408"},
        {"Smithsonian Astrophysical Observation", "SAO 246805"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.26099221),
        dec: Angle.Degrees(-50.51866536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12672"},
        {"Smithsonian Astrophysical Observation", "SAO 232866"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.70234695),
        dec: Angle.Degrees(-50.51180624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74791"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.26966998),
        dec: Angle.Degrees(-50.51151270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44227"},
        {"Hipparcos Number", "HIP 29915"},
        {"Smithsonian Astrophysical Observation", "SAO 234429"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.47185854),
        dec: Angle.Degrees(-50.51072128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160342"},
        {"Hipparcos Number", "HIP 86628"},
        {"Geneva Identification System", "GEN# +1.00160342"},
        {"Smithsonian Astrophysical Observation", "SAO 244954"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.51507361),
        dec: Angle.Degrees(-50.51066693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110145"},
        {"Hipparcos Number", "HIP 61843"},
        {"Smithsonian Astrophysical Observation", "SAO 240136"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.11620739),
        dec: Angle.Degrees(-50.50976461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64225"},
        {"Hipparcos Number", "HIP 38267"},
        {"Geneva Identification System", "GEN# +1.00064225"},
        {"Smithsonian Astrophysical Observation", "SAO 235552"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.59951934),
        dec: Angle.Degrees(-50.50936470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169407"},
        {"Hipparcos Number", "HIP 90433"},
        {"Geneva Identification System", "GEN# +1.00169407"},
        {"Smithsonian Astrophysical Observation", "SAO 245478"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.77395826),
        dec: Angle.Degrees(-50.50905090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73849"},
        {"Hipparcos Number", "HIP 42366"},
        {"Celescope Catalog", "CEL 2732"},
        {"Geneva Identification System", "GEN# +1.00073849"},
        {"Smithsonian Astrophysical Observation", "SAO 236135"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.57924820),
        dec: Angle.Degrees(-50.50835768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25663"},
        {"Hipparcos Number", "HIP 18817"},
        {"Geneva Identification System", "GEN# +1.00025663"},
        {"Smithsonian Astrophysical Observation", "SAO 233369"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.48614214),
        dec: Angle.Degrees(-50.50813508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197341"},
        {"Hipparcos Number", "HIP 102405"},
        {"Geneva Identification System", "GEN# +1.00197341"},
        {"Smithsonian Astrophysical Observation", "SAO 246717"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.28606134),
        dec: Angle.Degrees(-50.50643244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104123"},
        {"Hipparcos Number", "HIP 58474"},
        {"Smithsonian Astrophysical Observation", "SAO 239551"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.86713067),
        dec: Angle.Degrees(-50.50308249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100075"},
        {"Hipparcos Number", "HIP 56151"},
        {"Smithsonian Astrophysical Observation", "SAO 239128"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.64205710),
        dec: Angle.Degrees(-50.50126297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125896"},
        {"Hipparcos Number", "HIP 70376"},
        {"Smithsonian Astrophysical Observation", "SAO 241692"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.98508426),
        dec: Angle.Degrees(-50.49937369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56703"},
        {"Hipparcos Number", "HIP 35115"},
        {"Smithsonian Astrophysical Observation", "SAO 235042"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.90806802),
        dec: Angle.Degrees(-50.49865945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78685"},
        {"Hipparcos Number", "HIP 44783"},
        {"Geneva Identification System", "GEN# +1.00078685"},
        {"Smithsonian Astrophysical Observation", "SAO 236625"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.91347812),
        dec: Angle.Degrees(-50.49836155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95410"},
        {"Hipparcos Number", "HIP 53768"},
        {"Smithsonian Astrophysical Observation", "SAO 238673"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.03060415),
        dec: Angle.Degrees(-50.49419576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35857"},
        {"Hipparcos Number", "HIP 25319"},
        {"Smithsonian Astrophysical Observation", "SAO 233968"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.23973027),
        dec: Angle.Degrees(-50.49369930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23970"},
        {"Hipparcos Number", "HIP 17663"},
        {"Smithsonian Astrophysical Observation", "SAO 233266"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.74120376),
        dec: Angle.Degrees(-50.49367735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65305"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.76375417),
        dec: Angle.Degrees(-50.49353500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167585"},
        {"Hipparcos Number", "HIP 89703"},
        {"Smithsonian Astrophysical Observation", "SAO 245388"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.61072002),
        dec: Angle.Degrees(-50.49318786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200014"},
        {"Hipparcos Number", "HIP 103855"},
        {"Smithsonian Astrophysical Observation", "SAO 246832"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.66400701),
        dec: Angle.Degrees(-50.49307812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193528"},
        {"Hipparcos Number", "HIP 100508"},
        {"Smithsonian Astrophysical Observation", "SAO 246553"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.70657655),
        dec: Angle.Degrees(-50.49296673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12620"},
        {"Hipparcos Number", "HIP 9503"},
        {"Geneva Identification System", "GEN# +1.00012620"},
        {"Smithsonian Astrophysical Observation", "SAO 232608"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.56841446),
        dec: Angle.Degrees(-50.49256854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185596"},
        {"Hipparcos Number", "HIP 96937"},
        {"Geneva Identification System", "GEN# +1.00185596"},
        {"Smithsonian Astrophysical Observation", "SAO 246225"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.58787622),
        dec: Angle.Degrees(-50.49196380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68116"},
        {"Hipparcos Number", "HIP 39880"},
        {"Geneva Identification System", "GEN# +1.00068116"},
        {"Smithsonian Astrophysical Observation", "SAO 235769"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.19131776),
        dec: Angle.Degrees(-50.49174942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205876"},
        {"Hipparcos Number", "HIP 106965"},
        {"Geneva Identification System", "GEN# +1.00205876"},
        {"Smithsonian Astrophysical Observation", "SAO 247124"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.96046060),
        dec: Angle.Degrees(-50.49159054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172821"},
        {"Hipparcos Number", "HIP 91979"},
        {"Geneva Identification System", "GEN# +1.00172821"},
        {"Smithsonian Astrophysical Observation", "SAO 245677"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.21283450),
        dec: Angle.Degrees(-50.49059873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88556"},
        {"Hipparcos Number", "HIP 49909"},
        {"Geneva Identification System", "GEN# +1.00088556"},
        {"Smithsonian Astrophysical Observation", "SAO 237769"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84916350),
        dec: Angle.Degrees(-50.49033797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197322"},
        {"Hipparcos Number", "HIP 102396"},
        {"Smithsonian Astrophysical Observation", "SAO 246715"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.23984188),
        dec: Angle.Degrees(-50.48790922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178845"},
        {"Hipparcos Number", "HIP 94398"},
        {"Geneva Identification System", "GEN# +1.00178845J"},
        {"Smithsonian Astrophysical Observation", "SAO 245976"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.19207229),
        dec: Angle.Degrees(-50.48631735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101410"},
        {"Hipparcos Number", "HIP 56904"},
        {"Fundamental Katalog 5th Edition", "FK5 2935"},
        {"Renson", "Renson 29230"},
        {"Smithsonian Astrophysical Observation", "SAO 239272"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.97365661),
        dec: Angle.Degrees(-50.48600661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11210"},
        {"Hipparcos Number", "HIP 8445"},
        {"Geneva Identification System", "GEN# +1.00011210"},
        {"Smithsonian Astrophysical Observation", "SAO 232531"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.21611382),
        dec: Angle.Degrees(-50.48334835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47658"},
        {"Hipparcos Number", "HIP 31625"},
        {"Smithsonian Astrophysical Observation", "SAO 234608"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.27131025),
        dec: Angle.Degrees(-50.48265164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78747"},
        {"Hipparcos Number", "HIP 44811"},
        {"Geneva Identification System", "GEN# +1.00078747"},
        {"Smithsonian Astrophysical Observation", "SAO 236632"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.98598058),
        dec: Angle.Degrees(-50.48212473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30185"},
        {"Hipparcos Number", "HIP 21914"},
        {"Fundamental Katalog 5th Edition", "FK5 2351"},
        {"Geneva Identification System", "GEN# +1.00030185"},
        {"Smithsonian Astrophysical Observation", "SAO 233638"},
        {"Wilson Evans Batten Catalogue", "WEB 4210"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.69356887),
        dec: Angle.Degrees(-50.48141805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127058"},
        {"Hipparcos Number", "HIP 70957"},
        {"Smithsonian Astrophysical Observation", "SAO 241761"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.70867563),
        dec: Angle.Degrees(-50.48130581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150425"},
        {"Hipparcos Number", "HIP 81876"},
        {"Smithsonian Astrophysical Observation", "SAO 244092"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.86591709),
        dec: Angle.Degrees(-50.48123365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29804"},
        {"Hipparcos Number", "HIP 21665"},
        {"Geneva Identification System", "GEN# +1.00029804"},
        {"Smithsonian Astrophysical Observation", "SAO 233604"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76807641),
        dec: Angle.Degrees(-50.47958530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197016"},
        {"Hipparcos Number", "HIP 102236"},
        {"Geneva Identification System", "GEN# +1.00197016"},
        {"Smithsonian Astrophysical Observation", "SAO 246703"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.74653549),
        dec: Angle.Degrees(-50.47884634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87026"},
        {"Hipparcos Number", "HIP 49076"},
        {"Geneva Identification System", "GEN# +1.00087026"},
        {"Smithsonian Astrophysical Observation", "SAO 237592"},
        {"Wilson Evans Batten Catalogue", "WEB 9101"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.24415062),
        dec: Angle.Degrees(-50.47771844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114648"},
        {"Hipparcos Number", "HIP 64447"},
        {"Smithsonian Astrophysical Observation", "SAO 240648"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.14063553),
        dec: Angle.Degrees(-50.47672317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38355"},
        {"Hipparcos Number", "HIP 26883"},
        {"Geneva Identification System", "GEN# +1.00038355"},
        {"Smithsonian Astrophysical Observation", "SAO 234103"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.61402647),
        dec: Angle.Degrees(-50.47528345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46837"},
        {"Hipparcos Number", "HIP 31211"},
        {"Geneva Identification System", "GEN# +1.00046837"},
        {"Smithsonian Astrophysical Observation", "SAO 234565"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.20726594),
        dec: Angle.Degrees(-50.47332839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172181"},
        {"Hipparcos Number", "HIP 91647"},
        {"Geneva Identification System", "GEN# +1.00172181"},
        {"Smithsonian Astrophysical Observation", "SAO 245637"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33771933),
        dec: Angle.Degrees(-50.47255005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29136"},
        {"Hipparcos Number", "HIP 21195"},
        {"Smithsonian Astrophysical Observation", "SAO 233554"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.16969033),
        dec: Angle.Degrees(-50.47166472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56318"},
        {"Hipparcos Number", "HIP 34955"},
        {"Smithsonian Astrophysical Observation", "SAO 235026"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.49148216),
        dec: Angle.Degrees(-50.47162036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12035"},
        {"Hipparcos Number", "HIP 9066"},
        {"Smithsonian Astrophysical Observation", "SAO 232577"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.17818762),
        dec: Angle.Degrees(-50.47143678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139415"},
        {"Hipparcos Number", "HIP 76731"},
        {"Smithsonian Astrophysical Observation", "SAO 242815"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.04220025),
        dec: Angle.Degrees(-50.47056215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62056"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.78359132),
        dec: Angle.Degrees(-50.47012434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65699"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.05349670),
        dec: Angle.Degrees(-50.46952021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63008B"},
        {"Hipparcos Number", "HIP 37727"},
        {"Geneva Identification System", "GEN# +1.00063008B"},
        {"Geneva Identification System 2", "GEN# -0.05002948"},
        {"Smithsonian Astrophysical Observation", "SAO 235462"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.06907597),
        dec: Angle.Degrees(-50.46696223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 142.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53142"},
        {"Hipparcos Number", "HIP 33825"},
        {"Smithsonian Astrophysical Observation", "SAO 234861"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.32625267),
        dec: Angle.Degrees(-50.46673614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150313"},
        {"Hipparcos Number", "HIP 81822"},
        {"Smithsonian Astrophysical Observation", "SAO 244086"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.69757684),
        dec: Angle.Degrees(-50.46560546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21617"},
        {"Hipparcos Number", "HIP 16087"},
        {"Smithsonian Astrophysical Observation", "SAO 233122"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.80790695),
        dec: Angle.Degrees(-50.46222853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5158"},
        {"Hipparcos Number", "HIP 4128"},
        {"Smithsonian Astrophysical Observation", "SAO 232216"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.21766176),
        dec: Angle.Degrees(-50.46182747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184713"},
        {"Hipparcos Number", "HIP 96591"},
        {"Smithsonian Astrophysical Observation", "SAO 246190"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54565530),
        dec: Angle.Degrees(-50.45934465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36749"},
        {"Hipparcos Number", "HIP 25862"},
        {"Geneva Identification System", "GEN# +1.00036749"},
        {"Smithsonian Astrophysical Observation", "SAO 234010"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.81155329),
        dec: Angle.Degrees(-50.45862970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127381"},
        {"Hipparcos Number", "HIP 71121"},
        {"Geneva Identification System", "GEN# +1.00127381"},
        {"Smithsonian Astrophysical Observation", "SAO 241781"},
        {"Wilson Evans Batten Catalogue", "WEB 12300"},
    },
    visualMagnitude: 4.44,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.15451447),
        dec: Angle.Degrees(-50.45712132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63008"},
        {"Hipparcos Number", "HIP 37718"},
        {"Geneva Identification System", "GEN# +1.00063008A"},
        {"Smithsonian Astrophysical Observation", "SAO 235458"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05256920),
        dec: Angle.Degrees(-50.45707517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53812"},
        {"Hipparcos Number", "HIP 34050"},
        {"Smithsonian Astrophysical Observation", "SAO 234892"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.95680594),
        dec: Angle.Degrees(-50.45489872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116135"},
        {"Hipparcos Number", "HIP 65260"},
        {"Smithsonian Astrophysical Observation", "SAO 240785"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.62001772),
        dec: Angle.Degrees(-50.45268607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48857"},
        {"Hipparcos Number", "HIP 32148"},
        {"Geneva Identification System", "GEN# +1.00048857A"},
        {"Smithsonian Astrophysical Observation", "SAO 234665"},
        {"Wilson Evans Batten Catalogue", "WEB 6487"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.70351624),
        dec: Angle.Degrees(-50.45181158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217794"},
        {"Hipparcos Number", "HIP 113882"},
        {"Smithsonian Astrophysical Observation", "SAO 247706"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.95177167),
        dec: Angle.Degrees(-50.44950062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157304"},
        {"Hipparcos Number", "HIP 85241"},
        {"Geneva Identification System", "GEN# +1.00157304"},
        {"Smithsonian Astrophysical Observation", "SAO 244727"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.27471494),
        dec: Angle.Degrees(-50.44943783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69596"},
        {"Hipparcos Number", "HIP 40433"},
        {"Geneva Identification System", "GEN# +1.00069596"},
        {"Smithsonian Astrophysical Observation", "SAO 235838"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.84695805),
        dec: Angle.Degrees(-50.44920558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96442"},
        {"Hipparcos Number", "HIP 54286"},
        {"Smithsonian Astrophysical Observation", "SAO 238770"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.58134402),
        dec: Angle.Degrees(-50.44754745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224821"},
        {"Hipparcos Number", "HIP 75"},
        {"Smithsonian Astrophysical Observation", "SAO 248099"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.22316216),
        dec: Angle.Degrees(-50.44646500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206683"},
        {"Hipparcos Number", "HIP 107397"},
        {"Geneva Identification System", "GEN# +1.00206683"},
        {"Smithsonian Astrophysical Observation", "SAO 247161"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.30000756),
        dec: Angle.Degrees(-50.44638647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32711"},
        {"Hipparcos Number", "HIP 23459"},
        {"Geneva Identification System", "GEN# +1.00032711"},
        {"Smithsonian Astrophysical Observation", "SAO 233795"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.63252481),
        dec: Angle.Degrees(-50.44542003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212235"},
        {"Hipparcos Number", "HIP 110558"},
        {"Smithsonian Astrophysical Observation", "SAO 247434"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.94984875),
        dec: Angle.Degrees(-50.44291039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164662"},
        {"Hipparcos Number", "HIP 88551"},
        {"Smithsonian Astrophysical Observation", "SAO 245229"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.21474133),
        dec: Angle.Degrees(-50.44072517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202295"},
        {"Hipparcos Number", "HIP 105052"},
        {"Smithsonian Astrophysical Observation", "SAO 246941"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.18159621),
        dec: Angle.Degrees(-50.44005853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93299"},
        {"Hipparcos Number", "HIP 52603"},
        {"Smithsonian Astrophysical Observation", "SAO 238434"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.35465011),
        dec: Angle.Degrees(-50.43868647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297521"},
        {"Hipparcos Number", "HIP 46944"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.51207906),
        dec: Angle.Degrees(-50.43654390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9194"},
        {"Hipparcos Number", "HIP 6955"},
        {"Smithsonian Astrophysical Observation", "SAO 232435"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.38216411),
        dec: Angle.Degrees(-50.43590466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77489"},
        {"Hipparcos Number", "HIP 44270"},
        {"Geneva Identification System", "GEN# +1.00077489"},
        {"Smithsonian Astrophysical Observation", "SAO 236503"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.22425025),
        dec: Angle.Degrees(-50.43576178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200249"},
        {"Hipparcos Number", "HIP 103998"},
        {"Smithsonian Astrophysical Observation", "SAO 246846"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.05862371),
        dec: Angle.Degrees(-50.43531687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19681"},
        {"Hipparcos Number", "HIP 14577"},
        {"Smithsonian Astrophysical Observation", "SAO 233002"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.04410581),
        dec: Angle.Degrees(-50.43057302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53348"},
        {"Hipparcos Number", "HIP 33892"},
        {"Smithsonian Astrophysical Observation", "SAO 234868"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.52896376),
        dec: Angle.Degrees(-50.42994656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95508"},
        {"Hipparcos Number", "HIP 53826"},
        {"Renson", "Renson 27520"},
        {"Smithsonian Astrophysical Observation", "SAO 238690"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.18717812),
        dec: Angle.Degrees(-50.42965381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157078"},
        {"Hipparcos Number", "HIP 85127"},
        {"Smithsonian Astrophysical Observation", "SAO 244701"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95797036),
        dec: Angle.Degrees(-50.42956302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1550"},
        {"Hipparcos Number", "HIP 1571"},
        {"Smithsonian Astrophysical Observation", "SAO 232001"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.89533903),
        dec: Angle.Degrees(-50.42942787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14239"},
        {"Hipparcos Number", "HIP 10611"},
        {"Smithsonian Astrophysical Observation", "SAO 232697"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.15061445),
        dec: Angle.Degrees(-50.42824225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55326"},
        {"Hipparcos Number", "HIP 34592"},
        {"Smithsonian Astrophysical Observation", "SAO 234976"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.47908251),
        dec: Angle.Degrees(-50.42736855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58063"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.62185884),
        dec: Angle.Degrees(-50.42606442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219975"},
        {"Hipparcos Number", "HIP 115246"},
        {"Smithsonian Astrophysical Observation", "SAO 247836"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.14633199),
        dec: Angle.Degrees(-50.42481997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82298"},
        {"Hipparcos Number", "HIP 46530"},
        {"Smithsonian Astrophysical Observation", "SAO 237030"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.35391800),
        dec: Angle.Degrees(-50.42407420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222538"},
        {"Hipparcos Number", "HIP 116894"},
        {"Smithsonian Astrophysical Observation", "SAO 247980"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.40994519),
        dec: Angle.Degrees(-50.42394195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174075"},
        {"Hipparcos Number", "HIP 92531"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.85071410),
        dec: Angle.Degrees(-50.42014749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7516"},
        {"Hipparcos Number", "HIP 5794"},
        {"Geneva Identification System", "GEN# +1.00007516"},
        {"Smithsonian Astrophysical Observation", "SAO 232350"},
        {"Wilson Evans Batten Catalogue", "WEB 1320"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.58656731),
        dec: Angle.Degrees(-50.41634750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83135"},
        {"Hipparcos Number", "HIP 46991"},
        {"Smithsonian Astrophysical Observation", "SAO 237114"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.66236432),
        dec: Angle.Degrees(-50.41517597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13357"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.96545361),
        dec: Angle.Degrees(-50.41326397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24270"},
        {"Hipparcos Number", "HIP 17870"},
        {"Smithsonian Astrophysical Observation", "SAO 233289"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.35538523),
        dec: Angle.Degrees(-50.41307678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37628"},
        {"Hipparcos Number", "HIP 26393"},
        {"Smithsonian Astrophysical Observation", "SAO 234050"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.28472157),
        dec: Angle.Degrees(-50.40875730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90395"},
        {"Hipparcos Number", "HIP 50994"},
        {"Geneva Identification System", "GEN# +1.00090395"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.24857551),
        dec: Angle.Degrees(-50.40768331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6995"},
        {"Hipparcos Number", "HIP 5433"},
        {"Smithsonian Astrophysical Observation", "SAO 232316"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.37182293),
        dec: Angle.Degrees(-50.40366290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153662"},
        {"Hipparcos Number", "HIP 83453"},
        {"Geneva Identification System", "GEN# +1.00153662"},
        {"Smithsonian Astrophysical Observation", "SAO 244391"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.83134109),
        dec: Angle.Degrees(-50.40269386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9663"},
        {"Hipparcos Number", "HIP 7275"},
        {"Smithsonian Astrophysical Observation", "SAO 232462"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.42627555),
        dec: Angle.Degrees(-50.40177174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158027"},
        {"Hipparcos Number", "HIP 85599"},
        {"Smithsonian Astrophysical Observation", "SAO 244787"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.37297382),
        dec: Angle.Degrees(-50.39841645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213241"},
        {"Hipparcos Number", "HIP 111145"},
        {"Geneva Identification System", "GEN# +1.00213241"},
        {"Smithsonian Astrophysical Observation", "SAO 247468"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.76801220),
        dec: Angle.Degrees(-50.39639773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132576"},
        {"Hipparcos Number", "HIP 73524"},
        {"Smithsonian Astrophysical Observation", "SAO 242178"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.42032270),
        dec: Angle.Degrees(-50.39510613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146479"},
        {"Hipparcos Number", "HIP 79936"},
        {"Smithsonian Astrophysical Observation", "SAO 243606"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.73073976),
        dec: Angle.Degrees(-50.39184524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62495"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.09970842),
        dec: Angle.Degrees(-50.38992179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112810"},
        {"Hipparcos Number", "HIP 63439"},
        {"Smithsonian Astrophysical Observation", "SAO 240463"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.99962053),
        dec: Angle.Degrees(-50.38954981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47989"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.71641540),
        dec: Angle.Degrees(-50.38802416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117956"},
        {"Hipparcos Number", "HIP 66268"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.72961999),
        dec: Angle.Degrees(-50.38467001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99081"},
        {"Hipparcos Number", "HIP 55612"},
        {"Smithsonian Astrophysical Observation", "SAO 239023"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.90085401),
        dec: Angle.Degrees(-50.38422810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166908"},
        {"Hipparcos Number", "HIP 89457"},
        {"Smithsonian Astrophysical Observation", "SAO 245346"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.84798848),
        dec: Angle.Degrees(-50.38160364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78475"},
        {"Hipparcos Number", "HIP 44712"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.66033068),
        dec: Angle.Degrees(-50.37915304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22231"},
        {"Hipparcos Number", "HIP 16509"},
        {"Fundamental Katalog 5th Edition", "FK5 128"},
        {"Geneva Identification System", "GEN# +1.00022231"},
        {"Smithsonian Astrophysical Observation", "SAO 233152"},
        {"Wilson Evans Batten Catalogue", "WEB 3155"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.14465247),
        dec: Angle.Degrees(-50.37884857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74650"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.79862223),
        dec: Angle.Degrees(-50.37675471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65008"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.87241102),
        dec: Angle.Degrees(-50.37660120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121853"},
        {"Hipparcos Number", "HIP 68333"},
        {"Geneva Identification System", "GEN# +1.00121853"},
        {"Smithsonian Astrophysical Observation", "SAO 241352"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.82273625),
        dec: Angle.Degrees(-50.36960607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93676"},
        {"Hipparcos Number", "HIP 52825"},
        {"Smithsonian Astrophysical Observation", "SAO 238487"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.01685171),
        dec: Angle.Degrees(-50.36952538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95473"},
        {"Hipparcos Number", "HIP 53802"},
        {"Smithsonian Astrophysical Observation", "SAO 238682"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.12597583),
        dec: Angle.Degrees(-50.36782916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147896"},
        {"Hipparcos Number", "HIP 80562"},
        {"Smithsonian Astrophysical Observation", "SAO 243814"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.73257827),
        dec: Angle.Degrees(-50.36651330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69347"},
        {"Hipparcos Number", "HIP 40353"},
        {"Smithsonian Astrophysical Observation", "SAO 235825"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.58420524),
        dec: Angle.Degrees(-50.36608059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145092"},
        {"Hipparcos Number", "HIP 79336"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.87375692),
        dec: Angle.Degrees(-50.36527573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111753"},
        {"Hipparcos Number", "HIP 62797"},
        {"Smithsonian Astrophysical Observation", "SAO 240329"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.02136849),
        dec: Angle.Degrees(-50.36404664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40105"},
        {"Hipparcos Number", "HIP 27896"},
        {"Cincinnati Publication", "Ci 20 359"},
        {"Geneva Identification System", "GEN# +1.00040105"},
        {"Smithsonian Astrophysical Observation", "SAO 234191"},
        {"Wilson Evans Batten Catalogue", "WEB 5462"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.54469795),
        dec: Angle.Degrees(-50.36388420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 548.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158279"},
        {"Hipparcos Number", "HIP 85723"},
        {"Geneva Identification System", "GEN# +1.00158279"},
        {"Smithsonian Astrophysical Observation", "SAO 244809"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.76237517),
        dec: Angle.Degrees(-50.36264468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54179"},
        {"Hipparcos Number", "HIP 34177"},
        {"Geneva Identification System", "GEN# +1.00054179"},
        {"Smithsonian Astrophysical Observation", "SAO 234907"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31830326),
        dec: Angle.Degrees(-50.36013794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44362"},
        {"Hipparcos Number", "HIP 29990"},
        {"Geneva Identification System", "GEN# +1.00044362"},
        {"Smithsonian Astrophysical Observation", "SAO 234442"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.69494763),
        dec: Angle.Degrees(-50.35911751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104213"},
        {"Hipparcos Number", "HIP 58518"},
        {"Smithsonian Astrophysical Observation", "SAO 239563"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.01835462),
        dec: Angle.Degrees(-50.35755459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297490"},
        {"Hipparcos Number", "HIP 46369"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.82380305),
        dec: Angle.Degrees(-50.35678563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76875"},
        {"Hipparcos Number", "HIP 43936"},
        {"Geneva Identification System", "GEN# +1.00076875"},
        {"Smithsonian Astrophysical Observation", "SAO 236429"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23884934),
        dec: Angle.Degrees(-50.35662518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129965"},
        {"Hipparcos Number", "HIP 72313"},
        {"Smithsonian Astrophysical Observation", "SAO 241997"},
    },
    visualMagnitude: 9.84,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.82281873),
        dec: Angle.Degrees(-50.35205100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137402"},
        {"Hipparcos Number", "HIP 75701"},
        {"Smithsonian Astrophysical Observation", "SAO 242556"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.97773379),
        dec: Angle.Degrees(-50.35146646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113933"},
        {"Hipparcos Number", "HIP 64058"},
        {"Geneva Identification System", "GEN# +1.00113933"},
        {"Smithsonian Astrophysical Observation", "SAO 240577"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.91954487),
        dec: Angle.Degrees(-50.35086491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118450"},
        {"Hipparcos Number", "HIP 66524"},
        {"Celescope Catalog", "CEL 4271"},
        {"Geneva Identification System", "GEN# +1.00118450"},
        {"Smithsonian Astrophysical Observation", "SAO 241018"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.53777084),
        dec: Angle.Degrees(-50.34988473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79774"},
        {"Hipparcos Number", "HIP 45319"},
        {"Smithsonian Astrophysical Observation", "SAO 236742"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.54448152),
        dec: Angle.Degrees(-50.34869468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90175"},
        {"Hipparcos Number", "HIP 50883"},
        {"Geneva Identification System", "GEN# +1.00090175"},
        {"Smithsonian Astrophysical Observation", "SAO 238008"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.85240142),
        dec: Angle.Degrees(-50.34861498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89053"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.64413212),
        dec: Angle.Degrees(-50.34756120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139187"},
        {"Hipparcos Number", "HIP 76625"},
        {"Smithsonian Astrophysical Observation", "SAO 242796"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.72060712),
        dec: Angle.Degrees(-50.34649517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220896"},
        {"Hipparcos Number", "HIP 115822"},
        {"Geneva Identification System", "GEN# +1.00220896J"},
        {"Smithsonian Astrophysical Observation", "SAO 247888"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.96076933),
        dec: Angle.Degrees(-50.34368099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175735"},
        {"Hipparcos Number", "HIP 93226"},
        {"Geneva Identification System", "GEN# +1.00175735"},
        {"Smithsonian Astrophysical Observation", "SAO 245848"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.85161657),
        dec: Angle.Degrees(-50.34294222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180606"},
        {"Hipparcos Number", "HIP 94984"},
        {"Smithsonian Astrophysical Observation", "SAO 246030"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91391401),
        dec: Angle.Degrees(-50.34284498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79775"},
        {"Hipparcos Number", "HIP 45321"},
        {"Smithsonian Astrophysical Observation", "SAO 236744"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.54675530),
        dec: Angle.Degrees(-50.34172577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207853"},
        {"Hipparcos Number", "HIP 108050"},
        {"Smithsonian Astrophysical Observation", "SAO 247218"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.35098766),
        dec: Angle.Degrees(-50.34074101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93574"},
        {"Hipparcos Number", "HIP 52757"},
        {"Smithsonian Astrophysical Observation", "SAO 238472"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.80811302),
        dec: Angle.Degrees(-50.34061555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224865"},
        {"Hipparcos Number", "HIP 107"},
        {"Geneva Identification System", "GEN# +1.00224865"},
        {"Smithsonian Astrophysical Observation", "SAO 248103"},
        {"Wilson Evans Batten Catalogue", "WEB 11"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.33380226),
        dec: Angle.Degrees(-50.33739907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108446"},
        {"Hipparcos Number", "HIP 60808"},
        {"Geneva Identification System", "GEN# +1.00108446"},
        {"Smithsonian Astrophysical Observation", "SAO 239966"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.95302851),
        dec: Angle.Degrees(-50.33691778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85453"},
        {"Hipparcos Number", "HIP 48265"},
        {"Celescope Catalog", "CEL 3388"},
        {"Geneva Identification System", "GEN# +1.00085453"},
        {"Renson", "Renson 24400"},
        {"Smithsonian Astrophysical Observation", "SAO 237391"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.59201148),
        dec: Angle.Degrees(-50.33566115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39726"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.79518927),
        dec: Angle.Degrees(-21.27679300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109675"},
        {"Hipparcos Number", "HIP 61557"},
        {"Geneva Identification System", "GEN# +1.00109675"},
        {"Smithsonian Astrophysical Observation", "SAO 240089"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.19435821),
        dec: Angle.Degrees(-50.33537121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176863"},
        {"Hipparcos Number", "HIP 93701"},
        {"Geneva Identification System", "GEN# +1.00176863"},
        {"Smithsonian Astrophysical Observation", "SAO 245911"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.20583172),
        dec: Angle.Degrees(-50.33251710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102803"},
        {"Hipparcos Number", "HIP 57701"},
        {"Smithsonian Astrophysical Observation", "SAO 239410"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.49878545),
        dec: Angle.Degrees(-50.33244274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70066"},
        {"Hipparcos Number", "HIP 40633"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.42932522),
        dec: Angle.Degrees(-50.32853068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211385"},
        {"Hipparcos Number", "HIP 110074"},
        {"Geneva Identification System", "GEN# +1.00211385"},
        {"Smithsonian Astrophysical Observation", "SAO 247396"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.44867554),
        dec: Angle.Degrees(-50.32494825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111452"},
        {"Hipparcos Number", "HIP 62618"},
        {"Smithsonian Astrophysical Observation", "SAO 240294"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.46476151),
        dec: Angle.Degrees(-50.32381985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47540"},
        {"Hipparcos Number", "HIP 31570"},
        {"Geneva Identification System", "GEN# +1.00047540"},
        {"Smithsonian Astrophysical Observation", "SAO 234604"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.11433984),
        dec: Angle.Degrees(-50.32310919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177365"},
        {"Hipparcos Number", "HIP 93860"},
        {"Geneva Identification System", "GEN# +1.00177365"},
        {"Smithsonian Astrophysical Observation", "SAO 245925"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.72839567),
        dec: Angle.Degrees(-50.32306734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82323"},
        {"Hipparcos Number", "HIP 46550"},
        {"Smithsonian Astrophysical Observation", "SAO 237033"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.39926133),
        dec: Angle.Degrees(-50.32238614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32821"},
        {"Hipparcos Number", "HIP 23502"},
        {"Geneva Identification System", "GEN# +1.00032821"},
        {"Smithsonian Astrophysical Observation", "SAO 233803"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.79888261),
        dec: Angle.Degrees(-50.32196474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191799"},
        {"Hipparcos Number", "HIP 99703"},
        {"Smithsonian Astrophysical Observation", "SAO 246494"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.47859705),
        dec: Angle.Degrees(-50.32081878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119971"},
        {"Hipparcos Number", "HIP 67304"},
        {"Geneva Identification System", "GEN# +1.00119971"},
        {"Smithsonian Astrophysical Observation", "SAO 241177"},
        {"Wilson Evans Batten Catalogue", "WEB 11844"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.91112414),
        dec: Angle.Degrees(-50.32066712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57988"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.41037228),
        dec: Angle.Degrees(-50.31905256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101712"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.25606653),
        dec: Angle.Degrees(-50.31873664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89044"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.61320256),
        dec: Angle.Degrees(-50.31765163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204287"},
        {"Hipparcos Number", "HIP 106078"},
        {"Geneva Identification System", "GEN# +1.00204287"},
        {"Smithsonian Astrophysical Observation", "SAO 247045"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.31008079),
        dec: Angle.Degrees(-50.31678283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209232"},
        {"Hipparcos Number", "HIP 108853"},
        {"Smithsonian Astrophysical Observation", "SAO 247289"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.77616645),
        dec: Angle.Degrees(-50.31661182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176557"},
        {"Hipparcos Number", "HIP 93568"},
        {"Geneva Identification System", "GEN# +1.00176557"},
        {"Smithsonian Astrophysical Observation", "SAO 245894"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.86393559),
        dec: Angle.Degrees(-50.31657300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96152"},
        {"Hipparcos Number", "HIP 54152"},
        {"Smithsonian Astrophysical Observation", "SAO 238737"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.16353424),
        dec: Angle.Degrees(-50.31597560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71317"},
        {"Hipparcos Number", "HIP 41219"},
        {"Celescope Catalog", "CEL 2480"},
        {"Geneva Identification System", "GEN# +1.00071317"},
        {"Smithsonian Astrophysical Observation", "SAO 235948"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.15955219),
        dec: Angle.Degrees(-50.31320642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69283"},
        {"Hipparcos Number", "HIP 40318"},
        {"Geneva Identification System", "GEN# +1.00069283"},
        {"Smithsonian Astrophysical Observation", "SAO 235821"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.48802713),
        dec: Angle.Degrees(-50.31234055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191559"},
        {"Hipparcos Number", "HIP 99595"},
        {"Geneva Identification System", "GEN# +1.00191559"},
        {"Smithsonian Astrophysical Observation", "SAO 246486"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.18013120),
        dec: Angle.Degrees(-50.31127550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123080"},
        {"Hipparcos Number", "HIP 68950"},
        {"Smithsonian Astrophysical Observation", "SAO 241452"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.72212730),
        dec: Angle.Degrees(-50.31097497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220002"},
        {"Hipparcos Number", "HIP 115269"},
        {"Geneva Identification System", "GEN# +1.00220002"},
        {"Smithsonian Astrophysical Observation", "SAO 247837"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20, 49.1600),
        dec: Angle.DegreesMinutesSeconds((int)-50, (int)18, 37.000)
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
    primaryId: "HIP 28371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28371"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.90993357),
        dec: Angle.Degrees(-50.30912063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75677"},
        {"Hipparcos Number", "HIP 43307"},
        {"Geneva Identification System", "GEN# +1.00075677"},
        {"Smithsonian Astrophysical Observation", "SAO 236307"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34113731),
        dec: Angle.Degrees(-50.30746530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297808"},
        {"Hipparcos Number", "HIP 49678"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.11829767),
        dec: Angle.Degrees(-50.30729943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220003"},
        {"Hipparcos Number", "HIP 115272"},
        {"Geneva Identification System", "GEN# +1.00220003"},
        {"Renson", "Renson 60420"},
        {"Smithsonian Astrophysical Observation", "SAO 247838"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.20889077),
        dec: Angle.Degrees(-50.30637897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38324"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.76447300),
        dec: Angle.Degrees(-50.30540088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224287"},
        {"Hipparcos Number", "HIP 118040"},
        {"Smithsonian Astrophysical Observation", "SAO 248071"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.14814262),
        dec: Angle.Degrees(-50.30340714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15520"},
        {"Hipparcos Number", "HIP 11488"},
        {"Smithsonian Astrophysical Observation", "SAO 232779"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04460326),
        dec: Angle.Degrees(-50.30278254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57019"},
        {"Hipparcos Number", "HIP 35240"},
        {"Smithsonian Astrophysical Observation", "SAO 235068"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.23652181),
        dec: Angle.Degrees(-50.30229535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14640"},
        {"Hipparcos Number", "HIP 10898"},
        {"Smithsonian Astrophysical Observation", "SAO 232718"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.06574184),
        dec: Angle.Degrees(-50.30225936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81878"},
        {"Hipparcos Number", "HIP 46307"},
        {"Smithsonian Astrophysical Observation", "SAO 236978"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.64960480),
        dec: Angle.Degrees(-50.30159697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77567"},
        {"Hipparcos Number", "HIP 44309"},
        {"Smithsonian Astrophysical Observation", "SAO 236511"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.35296370),
        dec: Angle.Degrees(-50.29887059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204946"},
        {"Hipparcos Number", "HIP 106445"},
        {"Smithsonian Astrophysical Observation", "SAO 247084"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39776390),
        dec: Angle.Degrees(-50.29853657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47371"},
        {"Hipparcos Number", "HIP 31477"},
        {"Smithsonian Astrophysical Observation", "SAO 234592"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89406447),
        dec: Angle.Degrees(-50.29615011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23189"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.85272236),
        dec: Angle.Degrees(-50.29468424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103197"},
        {"Hipparcos Number", "HIP 57931"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22105094),
        dec: Angle.Degrees(-50.29284025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161915"},
        {"Hipparcos Number", "HIP 87353"},
        {"Smithsonian Astrophysical Observation", "SAO 245070"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.74341008),
        dec: Angle.Degrees(-50.29090290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3328"},
        {"Hipparcos Number", "HIP 2810"},
        {"Smithsonian Astrophysical Observation", "SAO 232102"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.94486516),
        dec: Angle.Degrees(-50.28840318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63176"},
        {"Hipparcos Number", "HIP 37806"},
        {"Geneva Identification System", "GEN# +1.00063176"},
        {"Smithsonian Astrophysical Observation", "SAO 235480"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.27987534),
        dec: Angle.Degrees(-50.28789373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78290"},
        {"Hipparcos Number", "HIP 44618"},
        {"Celescope Catalog", "CEL 3178"},
        {"Geneva Identification System", "GEN# +1.00078290"},
        {"Smithsonian Astrophysical Observation", "SAO 236588"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.37724266),
        dec: Angle.Degrees(-50.28687033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81624"},
        {"Hipparcos Number", "HIP 46171"},
        {"Geneva Identification System", "GEN# +1.00081624"},
        {"Smithsonian Astrophysical Observation", "SAO 236940"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23460334),
        dec: Angle.Degrees(-50.28616002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11357"},
        {"Hipparcos Number", "HIP 8562"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.60832450),
        dec: Angle.Degrees(-50.28614311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74962"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.77963054),
        dec: Angle.Degrees(-50.28157751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124785"},
        {"Hipparcos Number", "HIP 69780"},
        {"Geneva Identification System", "GEN# +1.00124785"},
        {"Smithsonian Astrophysical Observation", "SAO 241593"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.24005213),
        dec: Angle.Degrees(-50.28132287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37079"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.29481925),
        dec: Angle.Degrees(-50.28082965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206585"},
        {"Hipparcos Number", "HIP 107347"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12506157),
        dec: Angle.Degrees(-50.28015310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220803"},
        {"Hipparcos Number", "HIP 115762"},
        {"Smithsonian Astrophysical Observation", "SAO 247881"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.79560996),
        dec: Angle.Degrees(-50.27962544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220815"},
        {"Hipparcos Number", "HIP 115765"},
        {"Smithsonian Astrophysical Observation", "SAO 247883"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.80832339),
        dec: Angle.Degrees(-50.27870747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60677"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.52816600),
        dec: Angle.Degrees(-50.27733000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20082"},
        {"Hipparcos Number", "HIP 14839"},
        {"Smithsonian Astrophysical Observation", "SAO 233029"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.91319974),
        dec: Angle.Degrees(-50.27215235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93870"},
        {"Hipparcos Number", "HIP 52912"},
        {"Geneva Identification System", "GEN# +1.00093870"},
        {"Smithsonian Astrophysical Observation", "SAO 238509"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.31546648),
        dec: Angle.Degrees(-50.27087756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104991"},
        {"Hipparcos Number", "HIP 58955"},
        {"Smithsonian Astrophysical Observation", "SAO 223206"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.33382550),
        dec: Angle.Degrees(-50.27056799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183011"},
        {"Hipparcos Number", "HIP 95871"},
        {"Geneva Identification System", "GEN# +1.00183011"},
        {"Smithsonian Astrophysical Observation", "SAO 246127"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48103832),
        dec: Angle.Degrees(-50.27000340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1322"},
        {"Geneva Identification System", "GEN# +6.20145158"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.15113229),
        dec: Angle.Degrees(-50.26967557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 330.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 273.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142546"},
        {"Hipparcos Number", "HIP 78150"},
        {"Renson", "Renson 40440"},
        {"Smithsonian Astrophysical Observation", "SAO 243160"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.36893642),
        dec: Angle.Degrees(-50.26958802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64061"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.93201843),
        dec: Angle.Degrees(-50.26885559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 564"},
        {"Hipparcos Number", "HIP 801"},
        {"Geneva Identification System", "GEN# +1.00000564"},
        {"Smithsonian Astrophysical Observation", "SAO 231952"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.47045485),
        dec: Angle.Degrees(-50.26778193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111637"},
        {"Hipparcos Number", "HIP 62728"},
        {"Smithsonian Astrophysical Observation", "SAO 223710"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.81518170),
        dec: Angle.Degrees(-50.26699810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217846"},
        {"Hipparcos Number", "HIP 113922"},
        {"Geneva Identification System", "GEN# +1.00217846"},
        {"Smithsonian Astrophysical Observation", "SAO 247710"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.05105188),
        dec: Angle.Degrees(-50.26633367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105916"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.76981260),
        dec: Angle.Degrees(-50.26434817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222578"},
        {"Hipparcos Number", "HIP 116919"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48631876),
        dec: Angle.Degrees(-50.26394740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196843"},
        {"Hipparcos Number", "HIP 102160"},
        {"Smithsonian Astrophysical Observation", "SAO 246699"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.50624448),
        dec: Angle.Degrees(-50.26258904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7425"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.91758265),
        dec: Angle.Degrees(-50.26180113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117213"},
        {"Hipparcos Number", "HIP 65843"},
        {"Smithsonian Astrophysical Observation", "SAO 240890"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.45731454),
        dec: Angle.Degrees(-50.26160894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75841"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38704510),
        dec: Angle.Degrees(-50.25920228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39639"},
        {"Hipparcos Number", "HIP 27647"},
        {"Smithsonian Astrophysical Observation", "SAO 234172"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.79635739),
        dec: Angle.Degrees(-50.25676913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143445"},
        {"Hipparcos Number", "HIP 78578"},
        {"Smithsonian Astrophysical Observation", "SAO 243273"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.67692139),
        dec: Angle.Degrees(-50.25669607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108749"},
        {"Hipparcos Number", "HIP 60975"},
        {"Smithsonian Astrophysical Observation", "SAO 223468"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48131029),
        dec: Angle.Degrees(-50.25620260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91720"},
        {"Hipparcos Number", "HIP 51756"},
        {"Smithsonian Astrophysical Observation", "SAO 222160"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.62439942),
        dec: Angle.Degrees(-50.25603473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213478"},
        {"Hipparcos Number", "HIP 111285"},
        {"Smithsonian Astrophysical Observation", "SAO 247481"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.16901079),
        dec: Angle.Degrees(-50.25373094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103995"},
        {"Hipparcos Number", "HIP 58394"},
        {"Smithsonian Astrophysical Observation", "SAO 223140"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.60812194),
        dec: Angle.Degrees(-50.25335462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7515"},
        {"Hipparcos Number", "HIP 5796"},
        {"Smithsonian Astrophysical Observation", "SAO 232351"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.59095410),
        dec: Angle.Degrees(-50.25140310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119938"},
        {"Hipparcos Number", "HIP 67292"},
        {"Fundamental Katalog 5th Edition", "FK5 3092"},
        {"Geneva Identification System", "GEN# +1.00119938"},
        {"Renson", "Renson 34570"},
        {"Smithsonian Astrophysical Observation", "SAO 241172"},
        {"Smithsonian Astrophysical Observation 2", "SAO 241173"},
        {"Wilson Evans Batten Catalogue", "WEB 11840"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.86493683),
        dec: Angle.Degrees(-50.24932136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77595"},
        {"Hipparcos Number", "HIP 44332"},
        {"Celescope Catalog", "CEL 3150"},
        {"Geneva Identification System", "GEN# +1.00077595"},
        {"Smithsonian Astrophysical Observation", "SAO 236515"},
    },
    visualMagnitude: 8.47,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.42235472),
        dec: Angle.Degrees(-50.24840133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102752"},
        {"Hipparcos Number", "HIP 57667"},
        {"Smithsonian Astrophysical Observation", "SAO 223043"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.41279767),
        dec: Angle.Degrees(-50.24800846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217331"},
        {"Hipparcos Number", "HIP 113604"},
        {"Smithsonian Astrophysical Observation", "SAO 247677"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15083895),
        dec: Angle.Degrees(-50.24708957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91647"},
        {"Hipparcos Number", "HIP 51706"},
        {"Smithsonian Astrophysical Observation", "SAO 222149"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.47305538),
        dec: Angle.Degrees(-50.24653176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14366"},
        {"Hipparcos Number", "HIP 10699"},
        {"Smithsonian Astrophysical Observation", "SAO 232700"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.43133368),
        dec: Angle.Degrees(-50.24508958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208758"},
        {"Hipparcos Number", "HIP 108586"},
        {"Smithsonian Astrophysical Observation", "SAO 247257"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.95596418),
        dec: Angle.Degrees(-50.24496132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105117"},
        {"Hipparcos Number", "HIP 59027"},
        {"Smithsonian Astrophysical Observation", "SAO 223216"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.53310950),
        dec: Angle.Degrees(-50.24423881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86087"},
        {"Hipparcos Number", "HIP 48613"},
        {"Celescope Catalog", "CEL 3400"},
        {"Geneva Identification System", "GEN# +1.00086087"},
        {"Renson", "Renson 24570"},
        {"Smithsonian Astrophysical Observation", "SAO 237483"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.71360230),
        dec: Angle.Degrees(-50.24397661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178679"},
        {"Hipparcos Number", "HIP 94339"},
        {"Smithsonian Astrophysical Observation", "SAO 245967"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02626265),
        dec: Angle.Degrees(-50.24395633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120326"},
        {"Hipparcos Number", "HIP 67497"},
        {"Geneva Identification System", "GEN# +1.00120326"},
        {"Smithsonian Astrophysical Observation", "SAO 224472"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.47720733),
        dec: Angle.Degrees(-50.23991480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46273"},
        {"Hipparcos Number", "HIP 30953"},
        {"Geneva Identification System", "GEN# +1.00046273"},
        {"Smithsonian Astrophysical Observation", "SAO 234539"},
        {"Wilson Evans Batten Catalogue", "WEB 6165"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.45469519),
        dec: Angle.Degrees(-50.23895882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81202"},
        {"Hipparcos Number", "HIP 45966"},
        {"Celescope Catalog", "CEL 3278"},
        {"Geneva Identification System", "GEN# +1.00081202"},
        {"Smithsonian Astrophysical Observation", "SAO 236894"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.61879307),
        dec: Angle.Degrees(-50.23536529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129203"},
        {"Hipparcos Number", "HIP 71949"},
        {"Geneva Identification System", "GEN# +1.00129203"},
        {"Smithsonian Astrophysical Observation", "SAO 241935"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.73436645),
        dec: Angle.Degrees(-50.23067844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108483"},
        {"Hipparcos Number", "HIP 60823"},
        {"Fundamental Katalog 5th Edition", "FK5 464"},
        {"Geneva Identification System", "GEN# +1.00108483"},
        {"Renson", "Renson 31508"},
        {"Smithsonian Astrophysical Observation", "SAO 223454"},
        {"Wilson Evans Batten Catalogue", "WEB 10822"},
    },
    visualMagnitude: 3.91,
    bvColour: -0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01004828),
        dec: Angle.Degrees(-50.23060480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121930"},
        {"Hipparcos Number", "HIP 68375"},
        {"Smithsonian Astrophysical Observation", "SAO 224599"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.94167075),
        dec: Angle.Degrees(-50.22791832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61238"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.23143974),
        dec: Angle.Degrees(-50.22686447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20338"},
    },
    visualMagnitude: 11.53,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.35953961),
        dec: Angle.Degrees(-20.90182181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223145"},
        {"Hipparcos Number", "HIP 117315"},
        {"Fundamental Katalog 5th Edition", "FK5 3910"},
        {"Geneva Identification System", "GEN# +1.00223145"},
        {"Smithsonian Astrophysical Observation", "SAO 248018"},
        {"Wilson Evans Batten Catalogue", "WEB 20670"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.81661487),
        dec: Angle.Degrees(-50.22640416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28359"},
        {"Hipparcos Number", "HIP 20681"},
        {"Smithsonian Astrophysical Observation", "SAO 233515"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.45188123),
        dec: Angle.Degrees(-50.22541700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171820"},
        {"Hipparcos Number", "HIP 91482"},
        {"Geneva Identification System", "GEN# +1.00171820"},
        {"Smithsonian Astrophysical Observation", "SAO 245614"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.86773795),
        dec: Angle.Degrees(-50.22525346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47078"},
        {"Smithsonian Astrophysical Observation", "SAO 221324"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91679971),
        dec: Angle.Degrees(-50.22324943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121989"},
        {"Hipparcos Number", "HIP 68410"},
        {"Smithsonian Astrophysical Observation", "SAO 224604"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.05822434),
        dec: Angle.Degrees(-50.22229988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83281"},
        {"Hipparcos Number", "HIP 47079"},
        {"Geneva Identification System", "GEN# +1.00083281"},
        {"Smithsonian Astrophysical Observation", "SAO 221325"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91753550),
        dec: Angle.Degrees(-50.22029879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30219"},
        {"Hipparcos Number", "HIP 21952"},
        {"Smithsonian Astrophysical Observation", "SAO 233642"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.77515948),
        dec: Angle.Degrees(-50.21973631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188986"},
        {"Hipparcos Number", "HIP 98444"},
        {"Geneva Identification System", "GEN# +1.00188986"},
        {"Smithsonian Astrophysical Observation", "SAO 246379"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.03472241),
        dec: Angle.Degrees(-50.21673189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88363"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65702183),
        dec: Angle.Degrees(-50.21615389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140130"},
        {"Hipparcos Number", "HIP 77067"},
        {"Geneva Identification System", "GEN# +1.00140130"},
        {"Smithsonian Astrophysical Observation", "SAO 242892"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.04323203),
        dec: Angle.Degrees(-50.21564390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15358"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.51412841),
        dec: Angle.Degrees(-50.21524176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 347.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83917"},
        {"Hipparcos Number", "HIP 47433"},
        {"Smithsonian Astrophysical Observation", "SAO 221391"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.98730232),
        dec: Angle.Degrees(-50.21499697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149835"},
        {"Hipparcos Number", "HIP 81585"},
        {"Smithsonian Astrophysical Observation", "SAO 244045"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.93039692),
        dec: Angle.Degrees(-50.21272448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88364"},
    },
    visualMagnitude: 12.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65814390),
        dec: Angle.Degrees(-50.21221926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18035"},
        {"Hipparcos Number", "HIP 13370"},
        {"Geneva Identification System", "GEN# +1.00018035"},
        {"Smithsonian Astrophysical Observation", "SAO 232922"},
        {"Wilson Evans Batten Catalogue", "WEB 2678"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.00496177),
        dec: Angle.Degrees(-50.21209293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57520"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.84114523),
        dec: Angle.Degrees(-50.21153947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170707"},
        {"Hipparcos Number", "HIP 90988"},
        {"Smithsonian Astrophysical Observation", "SAO 245551"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.38902979),
        dec: Angle.Degrees(-50.21153944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156123"},
        {"Hipparcos Number", "HIP 84657"},
        {"Smithsonian Astrophysical Observation", "SAO 244608"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.60001278),
        dec: Angle.Degrees(-50.21096611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38743"},
        {"Hipparcos Number", "HIP 27140"},
        {"Smithsonian Astrophysical Observation", "SAO 234120"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.31452892),
        dec: Angle.Degrees(-50.20919345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330346"},
        {"Hipparcos Number", "HIP 78605"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.72451948),
        dec: Angle.Degrees(-50.20856466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25440"},
        {"Hipparcos Number", "HIP 18685"},
        {"Smithsonian Astrophysical Observation", "SAO 233353"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.02956683),
        dec: Angle.Degrees(-50.20625206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11413"},
        {"Hipparcos Number", "HIP 8593"},
        {"Fundamental Katalog 5th Edition", "FK5 2123"},
        {"Geneva Identification System", "GEN# +1.00011413"},
        {"Smithsonian Astrophysical Observation", "SAO 232542"},
        {"Wilson Evans Batten Catalogue", "WEB 1823"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.72699465),
        dec: Angle.Degrees(-50.20612713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101616"},
        {"Hipparcos Number", "HIP 57010"},
        {"Smithsonian Astrophysical Observation", "SAO 222961"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.32704236),
        dec: Angle.Degrees(-50.20335480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101203"},
        {"Hipparcos Number", "HIP 56776"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.60232181),
        dec: Angle.Degrees(-50.19985723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155947"},
        {"Hipparcos Number", "HIP 84565"},
        {"Smithsonian Astrophysical Observation", "SAO 244583"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.31414847),
        dec: Angle.Degrees(-50.19814133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115416"},
        {"Hipparcos Number", "HIP 64873"},
        {"Geneva Identification System", "GEN# +1.00115416"},
        {"Smithsonian Astrophysical Observation", "SAO 224045"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.46061052),
        dec: Angle.Degrees(-50.19710843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70262"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65028879),
        dec: Angle.Degrees(-50.19631444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69194"},
        {"Hipparcos Number", "HIP 40282"},
        {"Geneva Identification System", "GEN# +1.00069194"},
        {"Smithsonian Astrophysical Observation", "SAO 235819"},
        {"Wilson Evans Batten Catalogue", "WEB 7856"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.39261076),
        dec: Angle.Degrees(-50.19606698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179676"},
        {"Hipparcos Number", "HIP 94691"},
        {"Smithsonian Astrophysical Observation", "SAO 245996"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.01705357),
        dec: Angle.Degrees(-50.19437221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107440"},
        {"Hipparcos Number", "HIP 60251"},
        {"Smithsonian Astrophysical Observation", "SAO 223371"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.31318203),
        dec: Angle.Degrees(-50.19431991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101598"},
        {"Hipparcos Number", "HIP 57006"},
        {"Smithsonian Astrophysical Observation", "SAO 222958"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.30009204),
        dec: Angle.Degrees(-50.19354099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47552"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.42184859),
        dec: Angle.Degrees(-19.88922740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108035"},
        {"Hipparcos Number", "HIP 60577"},
        {"Smithsonian Astrophysical Observation", "SAO 223422"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.24864399),
        dec: Angle.Degrees(-50.19182729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13685"},
        {"Geneva Identification System", "GEN# -0.05000869"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.06783767),
        dec: Angle.Degrees(-50.19125809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 224.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220272"},
        {"Hipparcos Number", "HIP 115427"},
        {"Smithsonian Astrophysical Observation", "SAO 247847"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.71818710),
        dec: Angle.Degrees(-50.19002187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41847"},
        {"Geneva Identification System", "GEN# -0.04903617"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.98514005),
        dec: Angle.Degrees(-50.18962093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152272"},
        {"Hipparcos Number", "HIP 82774"},
        {"Smithsonian Astrophysical Observation", "SAO 244271"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.74314193),
        dec: Angle.Degrees(-50.18913667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70840"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.29271545),
        dec: Angle.Degrees(-50.18897853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92817"},
        {"Hipparcos Number", "HIP 52365"},
        {"Renson", "Renson 26810"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.54383319),
        dec: Angle.Degrees(-50.18533782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195189"},
        {"Hipparcos Number", "HIP 101301"},
        {"Smithsonian Astrophysical Observation", "SAO 246622"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.99575804),
        dec: Angle.Degrees(-50.18487985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63531"},
        {"Hipparcos Number", "HIP 37970"},
        {"Celescope Catalog", "CEL 2033"},
        {"Geneva Identification System", "GEN# +1.00063531"},
        {"Smithsonian Astrophysical Observation", "SAO 235507"},
        {"Wilson Evans Batten Catalogue", "WEB 7492"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.74082017),
        dec: Angle.Degrees(-50.18448344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14859"},
        {"Hipparcos Number", "HIP 11055"},
        {"Smithsonian Astrophysical Observation", "SAO 232731"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.57261972),
        dec: Angle.Degrees(-50.18428415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203124"},
        {"Hipparcos Number", "HIP 105494"},
        {"Smithsonian Astrophysical Observation", "SAO 246994"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49855060),
        dec: Angle.Degrees(-50.18301096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110305"},
        {"Hipparcos Number", "HIP 61934"},
        {"Geneva Identification System", "GEN# +1.00110305"},
        {"Smithsonian Astrophysical Observation", "SAO 223604"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.38854413),
        dec: Angle.Degrees(-50.18277098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176105"},
        {"Hipparcos Number", "HIP 93390"},
        {"Geneva Identification System", "GEN# +1.00176105"},
        {"Smithsonian Astrophysical Observation", "SAO 245864"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.31393001),
        dec: Angle.Degrees(-50.18261236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63187"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.17690887),
        dec: Angle.Degrees(-50.18216672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166985"},
        {"Hipparcos Number", "HIP 89494"},
        {"Smithsonian Astrophysical Observation", "SAO 245356"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.94944908),
        dec: Angle.Degrees(-50.18121524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153411"},
        {"Hipparcos Number", "HIP 83350"},
        {"Smithsonian Astrophysical Observation", "SAO 244376"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.51165691),
        dec: Angle.Degrees(-50.18080773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174429"},
        {"Hipparcos Number", "HIP 92680"},
        {"Geneva Identification System", "GEN# +1.00174429"},
        {"Smithsonian Astrophysical Observation", "SAO 245781"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.27441318),
        dec: Angle.Degrees(-50.18031899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110892"},
        {"Hipparcos Number", "HIP 62277"},
        {"Geneva Identification System", "GEN# +1.00110892"},
        {"Smithsonian Astrophysical Observation", "SAO 223649"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.42851251),
        dec: Angle.Degrees(-50.17966062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91847"},
        {"Hipparcos Number", "HIP 51834"},
        {"Smithsonian Astrophysical Observation", "SAO 222173"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.85287202),
        dec: Angle.Degrees(-50.17920188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89157"},
        {"Hipparcos Number", "HIP 50263"},
        {"Smithsonian Astrophysical Observation", "SAO 221918"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95221507),
        dec: Angle.Degrees(-50.17773781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185831"},
        {"Hipparcos Number", "HIP 97052"},
        {"Smithsonian Astrophysical Observation", "SAO 246235"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.86051795),
        dec: Angle.Degrees(-50.17771071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26382"},
        {"Hipparcos Number", "HIP 19283"},
        {"Smithsonian Astrophysical Observation", "SAO 233406"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.99192322),
        dec: Angle.Degrees(-50.17561208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65038"},
        {"Hipparcos Number", "HIP 38612"},
        {"Celescope Catalog", "CEL 2093"},
        {"Geneva Identification System", "GEN# +1.00065038"},
        {"Smithsonian Astrophysical Observation", "SAO 235604"},
        {"Wilson Evans Batten Catalogue", "WEB 7580"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.60214298),
        dec: Angle.Degrees(-50.17070947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97313"},
        {"Hipparcos Number", "HIP 54665"},
        {"Geneva Identification System", "GEN# +1.00097313"},
        {"Renson", "Renson 28060"},
        {"Smithsonian Astrophysical Observation", "SAO 222628"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.85408883),
        dec: Angle.Degrees(-50.16908082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174761"},
        {"Hipparcos Number", "HIP 92815"},
        {"Geneva Identification System", "GEN# +1.00174761"},
        {"Smithsonian Astrophysical Observation", "SAO 245797"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.68231155),
        dec: Angle.Degrees(-50.16876230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138846"},
        {"Hipparcos Number", "HIP 76446"},
        {"Geneva Identification System", "GEN# +1.00138846J"},
        {"Smithsonian Astrophysical Observation", "SAO 242759"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.19381404),
        dec: Angle.Degrees(-50.16839328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59730"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.74903614),
        dec: Angle.Degrees(-50.16786059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1182"},
        {"Hipparcos Number", "HIP 1270"},
        {"Smithsonian Astrophysical Observation", "SAO 231982"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.98017163),
        dec: Angle.Degrees(-50.16730236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138092"},
        {"Hipparcos Number", "HIP 76055"},
        {"Geneva Identification System", "GEN# +1.00138092"},
        {"Smithsonian Astrophysical Observation", "SAO 225869"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.98282655),
        dec: Angle.Degrees(-50.16705658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 480"},
        {"Hipparcos Number", "HIP 744"},
        {"Smithsonian Astrophysical Observation", "SAO 231947"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.28568036),
        dec: Angle.Degrees(-50.16678657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121068"},
        {"Hipparcos Number", "HIP 67911"},
        {"Geneva Identification System", "GEN# +1.00121068"},
        {"Smithsonian Astrophysical Observation", "SAO 224523"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.64059904),
        dec: Angle.Degrees(-50.16461034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172582"},
        {"Hipparcos Number", "HIP 91860"},
        {"Geneva Identification System", "GEN# +1.00172582"},
        {"Smithsonian Astrophysical Observation", "SAO 245663"},
        {"Wilson Evans Batten Catalogue", "WEB 15813"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.91922748),
        dec: Angle.Degrees(-50.16457903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163341"},
        {"Hipparcos Number", "HIP 87980"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.57962848),
        dec: Angle.Degrees(-50.16101063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153579"},
        {"Hipparcos Number", "HIP 83406"},
        {"Smithsonian Astrophysical Observation", "SAO 244386"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.71882452),
        dec: Angle.Degrees(-50.16037094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97280"},
        {"Hipparcos Number", "HIP 54652"},
        {"Smithsonian Astrophysical Observation", "SAO 222626"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.80778037),
        dec: Angle.Degrees(-50.16036985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220802"},
        {"Hipparcos Number", "HIP 115759"},
        {"Fundamental Katalog 5th Edition", "FK5 3875"},
        {"Geneva Identification System", "GEN# +1.00220802"},
        {"Smithsonian Astrophysical Observation", "SAO 247880"},
        {"Wilson Evans Batten Catalogue", "WEB 20482"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.78783827),
        dec: Angle.Degrees(-50.15726501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88603"},
        {"Hipparcos Number", "HIP 49940"},
        {"Geneva Identification System", "GEN# +1.00088603"},
        {"Renson", "Renson 25360"},
        {"Smithsonian Astrophysical Observation", "SAO 221851"},
        {"Wilson Evans Batten Catalogue", "WEB 9191"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.95007109),
        dec: Angle.Degrees(-50.15672187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213868"},
        {"Hipparcos Number", "HIP 111502"},
        {"Smithsonian Astrophysical Observation", "SAO 247499"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85864297),
        dec: Angle.Degrees(-50.15584920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146686"},
        {"Hipparcos Number", "HIP 80000"},
        {"Fundamental Katalog 5th Edition", "FK5 604"},
        {"Geneva Identification System", "GEN# +1.00146686"},
        {"Smithsonian Astrophysical Observation", "SAO 243643"},
        {"Wilson Evans Batten Catalogue", "WEB 13543"},
    },
    visualMagnitude: 4.01,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96069832),
        dec: Angle.Degrees(-50.15537923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18629"},
        {"Hipparcos Number", "HIP 13815"},
        {"Smithsonian Astrophysical Observation", "SAO 232951"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.45804215),
        dec: Angle.Degrees(-50.15295414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146521"},
        {"Hipparcos Number", "HIP 79943"},
        {"Smithsonian Astrophysical Observation", "SAO 243614"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.77704677),
        dec: Angle.Degrees(-50.15293624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5043"},
        {"Hipparcos Number", "HIP 4035"},
        {"Smithsonian Astrophysical Observation", "SAO 232210"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.93545839),
        dec: Angle.Degrees(-50.15248054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134237"},
        {"Hipparcos Number", "HIP 74264"},
        {"Geneva Identification System", "GEN# +1.00134237"},
        {"Smithsonian Astrophysical Observation", "SAO 225507"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.66087680),
        dec: Angle.Degrees(-50.15172258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182949"},
        {"Hipparcos Number", "HIP 95846"},
        {"Smithsonian Astrophysical Observation", "SAO 246124"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.40302477),
        dec: Angle.Degrees(-50.15155329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187744"},
        {"Hipparcos Number", "HIP 97912"},
        {"Geneva Identification System", "GEN# +1.00187744"},
        {"Smithsonian Astrophysical Observation", "SAO 246325"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.46100290),
        dec: Angle.Degrees(-50.15110335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114196"},
        {"Hipparcos Number", "HIP 64216"},
        {"Smithsonian Astrophysical Observation", "SAO 223940"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.42235216),
        dec: Angle.Degrees(-50.14995432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50270"},
        {"Hipparcos Number", "HIP 32764"},
        {"Smithsonian Astrophysical Observation", "SAO 234734"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.47393605),
        dec: Angle.Degrees(-50.14915574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12297"},
        {"Hipparcos Number", "HIP 9276"},
        {"Smithsonian Astrophysical Observation", "SAO 232593"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.80326265),
        dec: Angle.Degrees(-50.14867324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91982"},
        {"Hipparcos Number", "HIP 51903"},
        {"Renson", "Renson 26440"},
        {"Smithsonian Astrophysical Observation", "SAO 222187"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.06528121),
        dec: Angle.Degrees(-50.14732056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120358"},
        {"Hipparcos Number", "HIP 67516"},
        {"Smithsonian Astrophysical Observation", "SAO 224473"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.51813643),
        dec: Angle.Degrees(-50.14686441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171455"},
        {"Hipparcos Number", "HIP 91324"},
        {"Geneva Identification System", "GEN# +1.00171455"},
        {"Smithsonian Astrophysical Observation", "SAO 245594"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.40636079),
        dec: Angle.Degrees(-50.14643052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112580"},
        {"Hipparcos Number", "HIP 63305"},
        {"Smithsonian Astrophysical Observation", "SAO 223796"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.59954013),
        dec: Angle.Degrees(-50.14607608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106990"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02722422),
        dec: Angle.Degrees(-50.14476699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200489"},
        {"Hipparcos Number", "HIP 104114"},
        {"Smithsonian Astrophysical Observation", "SAO 246862"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.39394755),
        dec: Angle.Degrees(-50.14470619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78326"},
        {"Hipparcos Number", "HIP 44634"},
        {"Celescope Catalog", "CEL 3180"},
        {"Smithsonian Astrophysical Observation", "SAO 220841"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.42691862),
        dec: Angle.Degrees(-50.14454426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3813"},
        {"Geneva Identification System", "GEN# +6.20145174"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25615885),
        dec: Angle.Degrees(-50.14439383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106725"},
        {"Hipparcos Number", "HIP 59854"},
        {"Smithsonian Astrophysical Observation", "SAO 223325"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.11611391),
        dec: Angle.Degrees(-50.14326130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91926"},
        {"Hipparcos Number", "HIP 51867"},
        {"Smithsonian Astrophysical Observation", "SAO 222182"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.95786547),
        dec: Angle.Degrees(-50.14291769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84315"},
        {"Hipparcos Number", "HIP 47648"},
        {"Smithsonian Astrophysical Observation", "SAO 221423"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.71594360),
        dec: Angle.Degrees(-50.14255027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32243"},
        {"Hipparcos Number", "HIP 23174"},
        {"Smithsonian Astrophysical Observation", "SAO 233772"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.77920521),
        dec: Angle.Degrees(-50.14203804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297649"},
        {"Hipparcos Number", "HIP 48481"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.31588163),
        dec: Angle.Degrees(-50.14105364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13776"},
        {"Smithsonian Astrophysical Observation", "SAO 232949"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.32574711),
        dec: Angle.Degrees(-50.14097577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122375"},
        {"Hipparcos Number", "HIP 68618"},
        {"Smithsonian Astrophysical Observation", "SAO 224630"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69758841),
        dec: Angle.Degrees(-50.13864463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330194"},
        {"Hipparcos Number", "HIP 77957"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.80465992),
        dec: Angle.Degrees(-50.13704185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201814"},
        {"Hipparcos Number", "HIP 104799"},
        {"Smithsonian Astrophysical Observation", "SAO 246916"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.46170754),
        dec: Angle.Degrees(-50.13652121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91489"},
        {"Hipparcos Number", "HIP 51625"},
        {"Geneva Identification System", "GEN# +1.00091489"},
        {"Smithsonian Astrophysical Observation", "SAO 222134"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.20299151),
        dec: Angle.Degrees(-50.13591387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98845"},
        {"Hipparcos Number", "HIP 55504"},
        {"Smithsonian Astrophysical Observation", "SAO 222747"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.50941635),
        dec: Angle.Degrees(-50.13561207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77905"},
        {"Hipparcos Number", "HIP 44449"},
        {"Smithsonian Astrophysical Observation", "SAO 220791"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.83602091),
        dec: Angle.Degrees(-50.13299849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224470"},
        {"Hipparcos Number", "HIP 118170"},
        {"Smithsonian Astrophysical Observation", "SAO 248083"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.56673956),
        dec: Angle.Degrees(-50.13090209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17372"},
        {"Hipparcos Number", "HIP 12874"},
        {"Geneva Identification System", "GEN# +1.00017372"},
        {"Smithsonian Astrophysical Observation", "SAO 232879"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.37993143),
        dec: Angle.Degrees(-50.13088315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73164"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.28454139),
        dec: Angle.Degrees(-50.13055768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36501"},
        {"Smithsonian Astrophysical Observation", "SAO 235248"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.64301078),
        dec: Angle.Degrees(-50.12803913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68203"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.44369630),
        dec: Angle.Degrees(-50.12760481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133808"},
        {"Hipparcos Number", "HIP 74078"},
        {"Smithsonian Astrophysical Observation", "SAO 225470"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.07486714),
        dec: Angle.Degrees(-50.12756178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12578"},
        {"Hipparcos Number", "HIP 9478"},
        {"Geneva Identification System", "GEN# +1.00012578"},
        {"Smithsonian Astrophysical Observation", "SAO 232606"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.47918028),
        dec: Angle.Degrees(-50.12731397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42800"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80694241),
        dec: Angle.Degrees(-50.12695926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110015"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.23648661),
        dec: Angle.Degrees(-50.12683861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99481"},
        {"Hipparcos Number", "HIP 55817"},
        {"Smithsonian Astrophysical Observation", "SAO 222797"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.57746842),
        dec: Angle.Degrees(-50.12543353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119970"},
        {"Hipparcos Number", "HIP 67306"},
        {"Smithsonian Astrophysical Observation", "SAO 224425"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.91907238),
        dec: Angle.Degrees(-50.12509096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184052"},
        {"Hipparcos Number", "HIP 96319"},
        {"Smithsonian Astrophysical Observation", "SAO 246173"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.76237913),
        dec: Angle.Degrees(-50.12466116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36762"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.40924481),
        dec: Angle.Degrees(-50.12361426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86642"},
        {"Hipparcos Number", "HIP 48896"},
        {"Smithsonian Astrophysical Observation", "SAO 221655"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.61630385),
        dec: Angle.Degrees(-50.12355143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97592"},
        {"Hipparcos Number", "HIP 54814"},
        {"Smithsonian Astrophysical Observation", "SAO 222649"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.32292631),
        dec: Angle.Degrees(-50.12251812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196667"},
        {"Hipparcos Number", "HIP 102053"},
        {"Smithsonian Astrophysical Observation", "SAO 246690"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.22627015),
        dec: Angle.Degrees(-50.12017959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9598"},
        {"Hipparcos Number", "HIP 7223"},
        {"Smithsonian Astrophysical Observation", "SAO 232459"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.27113082),
        dec: Angle.Degrees(-50.12010712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89612"},
        {"Hipparcos Number", "HIP 50537"},
        {"Smithsonian Astrophysical Observation", "SAO 221955"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.82450521),
        dec: Angle.Degrees(-50.11948753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154983"},
        {"Hipparcos Number", "HIP 84086"},
        {"Smithsonian Astrophysical Observation", "SAO 244502"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.85743023),
        dec: Angle.Degrees(-50.11910863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87916"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.39090779),
        dec: Angle.Degrees(-50.11811765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221455"},
        {"Hipparcos Number", "HIP 116194"},
        {"Renson", "Renson 60700"},
        {"Smithsonian Astrophysical Observation", "SAO 247921"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.13763636),
        dec: Angle.Degrees(-50.11555463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87389"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.88332160),
        dec: Angle.Degrees(-50.11524112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224124"},
        {"Hipparcos Number", "HIP 117941"},
        {"Smithsonian Astrophysical Observation", "SAO 248060"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84850087),
        dec: Angle.Degrees(-50.11390880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35443"},
        {"Hipparcos Number", "HIP 25076"},
        {"Smithsonian Astrophysical Observation", "SAO 233948"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.53094785),
        dec: Angle.Degrees(-50.10890623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126823"},
        {"Hipparcos Number", "HIP 70859"},
        {"Fundamental Katalog 5th Edition", "FK5 5282"},
        {"Smithsonian Astrophysical Observation", "SAO 224959"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.34739006),
        dec: Angle.Degrees(-50.10865861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79573"},
        {"Hipparcos Number", "HIP 45237"},
        {"Geneva Identification System", "GEN# +1.00079573"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.29905838),
        dec: Angle.Degrees(-50.10709936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90412"},
        {"Hipparcos Number", "HIP 51001"},
        {"Geneva Identification System", "GEN# +1.00090412"},
        {"Smithsonian Astrophysical Observation", "SAO 222040"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.27731156),
        dec: Angle.Degrees(-50.10672048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209953"},
        {"Hipparcos Number", "HIP 109277"},
        {"Geneva Identification System", "GEN# +1.00209953"},
        {"Smithsonian Astrophysical Observation", "SAO 247322"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07304349),
        dec: Angle.Degrees(-50.10547454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22102"},
        {"Hipparcos Number", "HIP 16434"},
        {"Smithsonian Astrophysical Observation", "SAO 233145"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.89867473),
        dec: Angle.Degrees(-50.10464623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110006"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.21488046),
        dec: Angle.Degrees(-50.10178649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45077"},
        {"Hipparcos Number", "HIP 30325"},
        {"Geneva Identification System", "GEN# +1.00045077"},
        {"Smithsonian Astrophysical Observation", "SAO 234471"},
        {"Wilson Evans Batten Catalogue", "WEB 6032"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.68003912),
        dec: Angle.Degrees(-50.10148526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202441"},
        {"Hipparcos Number", "HIP 105119"},
        {"Smithsonian Astrophysical Observation", "SAO 246951"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.40833138),
        dec: Angle.Degrees(-50.10113412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54966"},
        {"Hipparcos Number", "HIP 34442"},
        {"Geneva Identification System", "GEN# +1.00054966"},
        {"Smithsonian Astrophysical Observation", "SAO 234950"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09415190),
        dec: Angle.Degrees(-50.10022894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71934"},
        {"Hipparcos Number", "HIP 41501"},
        {"Celescope Catalog", "CEL 2544"},
        {"Geneva Identification System", "GEN# +1.00071934"},
        {"Smithsonian Astrophysical Observation", "SAO 219964"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.96037072),
        dec: Angle.Degrees(-50.10003866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36635"},
        {"Hipparcos Number", "HIP 25796"},
        {"Smithsonian Astrophysical Observation", "SAO 234002"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.62626112),
        dec: Angle.Degrees(-50.09991922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10779"},
        {"Hipparcos Number", "HIP 8111"},
        {"Geneva Identification System", "GEN# +1.00010779"},
        {"Renson", "Renson 2660"},
        {"Smithsonian Astrophysical Observation", "SAO 232511"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.06257594),
        dec: Angle.Degrees(-50.09921951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42219"},
        {"Geneva Identification System", "GEN# -0.04903675"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.11002901),
        dec: Angle.Degrees(-50.09830146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125099"},
        {"Hipparcos Number", "HIP 69947"},
        {"Geneva Identification System", "GEN# +1.00125099"},
        {"Smithsonian Astrophysical Observation", "SAO 224829"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.70871412),
        dec: Angle.Degrees(-50.09747691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173263"},
        {"Hipparcos Number", "HIP 92157"},
        {"Geneva Identification System", "GEN# +1.00173263"},
        {"Smithsonian Astrophysical Observation", "SAO 245702"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.74626688),
        dec: Angle.Degrees(-50.09453463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206255"},
        {"Hipparcos Number", "HIP 107160"},
        {"Fundamental Katalog 5th Edition", "FK5 5915"},
        {"Geneva Identification System", "GEN# +1.00206255"},
        {"Smithsonian Astrophysical Observation", "SAO 247140"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.59090521),
        dec: Angle.Degrees(-50.09362157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165024"},
        {"Hipparcos Number", "HIP 88714"},
        {"Fundamental Katalog 5th Edition", "FK5 1471"},
        {"Geneva Identification System", "GEN# +1.00165024"},
        {"Smithsonian Astrophysical Observation", "SAO 245242"},
        {"Wilson Evans Batten Catalogue", "WEB 15030"},
    },
    visualMagnitude: 3.65,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.65782832),
        dec: Angle.Degrees(-50.09145462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138398"},
        {"Hipparcos Number", "HIP 76197"},
        {"Geneva Identification System", "GEN# +1.00138398"},
        {"Smithsonian Astrophysical Observation", "SAO 225900"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.46641793),
        dec: Angle.Degrees(-50.08992384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10990"},
        {"Hipparcos Number", "HIP 8286"},
        {"Smithsonian Astrophysical Observation", "SAO 232523"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.69171100),
        dec: Angle.Degrees(-50.08977536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111622"},
        {"Hipparcos Number", "HIP 62717"},
        {"Geneva Identification System", "GEN# +1.00111622"},
        {"Smithsonian Astrophysical Observation", "SAO 223707"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.78993599),
        dec: Angle.Degrees(-50.08843616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51706"},
        {"Hipparcos Number", "HIP 33327"},
        {"Smithsonian Astrophysical Observation", "SAO 234787"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97370045),
        dec: Angle.Degrees(-50.08593695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128288"},
        {"Hipparcos Number", "HIP 71521"},
        {"Geneva Identification System", "GEN# +1.00128288"},
        {"Smithsonian Astrophysical Observation", "SAO 225067"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.41025216),
        dec: Angle.Degrees(-50.08574666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23420"},
        {"Hipparcos Number", "HIP 17352"},
        {"Geneva Identification System", "GEN# +1.00023420"},
        {"Smithsonian Astrophysical Observation", "SAO 233237"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.70954166),
        dec: Angle.Degrees(-50.08393563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46098"},
        {"Hipparcos Number", "HIP 30845"},
        {"Geneva Identification System", "GEN# +1.00046098"},
        {"Smithsonian Astrophysical Observation", "SAO 234526"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.16805884),
        dec: Angle.Degrees(-50.08132391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211297"},
        {"Hipparcos Number", "HIP 110043"},
        {"Smithsonian Astrophysical Observation", "SAO 247393"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.33680529),
        dec: Angle.Degrees(-50.07990230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60034"},
        {"Hipparcos Number", "HIP 36462"},
        {"Smithsonian Astrophysical Observation", "SAO 218768"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.53248865),
        dec: Angle.Degrees(-50.07892748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52027"},
        {"Hipparcos Number", "HIP 33425"},
        {"Smithsonian Astrophysical Observation", "SAO 234803"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.25925574),
        dec: Angle.Degrees(-50.07479027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30501"},
        {"Hipparcos Number", "HIP 22122"},
        {"Cincinnati Publication", "Ci 20 304"},
        {"Geneva Identification System", "GEN# +1.00030501"},
        {"Smithsonian Astrophysical Observation", "SAO 233668"},
        {"Wilson Evans Batten Catalogue", "WEB 4253"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.41243863),
        dec: Angle.Degrees(-50.07341040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -445.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -337.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153908"},
        {"Hipparcos Number", "HIP 83570"},
        {"Smithsonian Astrophysical Observation", "SAO 244411"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.19446275),
        dec: Angle.Degrees(-50.07135792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122705"},
        {"Hipparcos Number", "HIP 68781"},
        {"Geneva Identification System", "GEN# +1.00122705"},
        {"Smithsonian Astrophysical Observation", "SAO 224654"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.17572126),
        dec: Angle.Degrees(-50.07135448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72732"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.05253990),
        dec: Angle.Degrees(-50.07010939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69332"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.84682350),
        dec: Angle.Degrees(-50.06991904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146143"},
        {"Hipparcos Number", "HIP 79790"},
        {"Geneva Identification System", "GEN# +1.00146143"},
        {"Smithsonian Astrophysical Observation", "SAO 226619"},
        {"Wilson Evans Batten Catalogue", "WEB 13503"},
    },
    visualMagnitude: 4.97,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.25389798),
        dec: Angle.Degrees(-50.06811224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107718"},
        {"Hipparcos Number", "HIP 60386"},
        {"Geneva Identification System", "GEN# +1.00107718"},
        {"Smithsonian Astrophysical Observation", "SAO 223394"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.71905326),
        dec: Angle.Degrees(-50.06719222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53406"},
        {"Hipparcos Number", "HIP 33928"},
        {"Smithsonian Astrophysical Observation", "SAO 218401"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.60554594),
        dec: Angle.Degrees(-50.06705898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214218"},
        {"Hipparcos Number", "HIP 111714"},
        {"Geneva Identification System", "GEN# +1.00214218"},
        {"Smithsonian Astrophysical Observation", "SAO 247520"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44378043),
        dec: Angle.Degrees(-50.06661898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36787"},
        {"Hipparcos Number", "HIP 25885"},
        {"Smithsonian Astrophysical Observation", "SAO 234014"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.88982278),
        dec: Angle.Degrees(-50.06488045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24022"},
        {"Hipparcos Number", "HIP 17699"},
        {"Smithsonian Astrophysical Observation", "SAO 233271"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.86484421),
        dec: Angle.Degrees(-50.06479075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69448"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.28822354),
        dec: Angle.Degrees(-50.06429746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156331"},
        {"Hipparcos Number", "HIP 84759"},
        {"Geneva Identification System", "GEN# +1.00156331J"},
        {"Smithsonian Astrophysical Observation", "SAO 244631"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87712119),
        dec: Angle.Degrees(-50.06368383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64509"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.33293130),
        dec: Angle.Degrees(-50.06237414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330193"},
        {"Hipparcos Number", "HIP 78086"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.16737834),
        dec: Angle.Degrees(-50.06088939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109324"},
        {"Hipparcos Number", "HIP 61342"},
        {"Smithsonian Astrophysical Observation", "SAO 223518"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.53704531),
        dec: Angle.Degrees(-50.06025553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159463"},
        {"Hipparcos Number", "HIP 86248"},
        {"Geneva Identification System", "GEN# +1.00159463"},
        {"Smithsonian Astrophysical Observation", "SAO 244894"},
        {"Wilson Evans Batten Catalogue", "WEB 14545"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36379930),
        dec: Angle.Degrees(-50.05948478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77096"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.12855725),
        dec: Angle.Degrees(-50.05868745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54209"},
        {"Hipparcos Number", "HIP 34190"},
        {"Smithsonian Astrophysical Observation", "SAO 218443"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34619121),
        dec: Angle.Degrees(-50.05814250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118496"},
        {"Hipparcos Number", "HIP 66540"},
        {"Geneva Identification System", "GEN# +1.00118496"},
        {"Smithsonian Astrophysical Observation", "SAO 224297"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.60223848),
        dec: Angle.Degrees(-50.05531188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199931"},
        {"Hipparcos Number", "HIP 103805"},
        {"Geneva Identification System", "GEN# +1.00199931"},
        {"Smithsonian Astrophysical Observation", "SAO 246829"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.52041957),
        dec: Angle.Degrees(-50.05527129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128416"},
        {"Hipparcos Number", "HIP 71580"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.58010648),
        dec: Angle.Degrees(-50.05456231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154856"},
        {"Hipparcos Number", "HIP 84025"},
        {"Renson", "Renson 43750"},
        {"Smithsonian Astrophysical Observation", "SAO 227685"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.64315346),
        dec: Angle.Degrees(-50.05415930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171740"},
        {"Hipparcos Number", "HIP 91449"},
        {"Smithsonian Astrophysical Observation", "SAO 245609"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.76861105),
        dec: Angle.Degrees(-50.05415828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61462"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.92014720),
        dec: Angle.Degrees(-50.05391248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132156"},
        {"Hipparcos Number", "HIP 73361"},
        {"Smithsonian Astrophysical Observation", "SAO 225350"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.88075451),
        dec: Angle.Degrees(-50.05339922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181485"},
        {"Hipparcos Number", "HIP 95290"},
        {"Smithsonian Astrophysical Observation", "SAO 246060"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.79322969),
        dec: Angle.Degrees(-50.05295671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189484"},
        {"Hipparcos Number", "HIP 98679"},
        {"Geneva Identification System", "GEN# +1.00189484A"},
        {"Geneva Identification System 2", "GEN# +1.00189484J"},
        {"Smithsonian Astrophysical Observation", "SAO 246404"},
        {"Wilson Evans Batten Catalogue", "WEB 17464"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.64511032),
        dec: Angle.Degrees(-50.05178120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 402.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98681"},
    },
    visualMagnitude: 9.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.64939243),
        dec: Angle.Degrees(-50.04937722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 334.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136451"},
        {"Hipparcos Number", "HIP 75267"},
        {"Smithsonian Astrophysical Observation", "SAO 225710"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68041023),
        dec: Angle.Degrees(-50.04862170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56907"},
        {"Hipparcos Number", "HIP 35189"},
        {"Renson", "Renson 15530"},
        {"Smithsonian Astrophysical Observation", "SAO 218595"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.08235681),
        dec: Angle.Degrees(-50.04845573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82500"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.91438785),
        dec: Angle.Degrees(-50.04727822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83468"},
        {"Geneva Identification System", "GEN# -0.04911137"},
        {"Wilson Evans Batten Catalogue", "WEB 14109"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.89280455),
        dec: Angle.Degrees(-50.04592312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151566"},
        {"Hipparcos Number", "HIP 82418"},
        {"Geneva Identification System", "GEN# +1.00151566"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.65036131),
        dec: Angle.Degrees(-50.04493814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39128"},
        {"Hipparcos Number", "HIP 27367"},
        {"Smithsonian Astrophysical Observation", "SAO 234140"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.94175372),
        dec: Angle.Degrees(-50.04376258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100589"},
        {"Hipparcos Number", "HIP 56430"},
        {"Smithsonian Astrophysical Observation", "SAO 222873"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.54740464),
        dec: Angle.Degrees(-50.04372623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104869"},
        {"Hipparcos Number", "HIP 58879"},
        {"Smithsonian Astrophysical Observation", "SAO 223203"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.14421418),
        dec: Angle.Degrees(-50.03958889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113179"},
        {"Hipparcos Number", "HIP 63631"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.62350664),
        dec: Angle.Degrees(-50.03917422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10553"},
        {"Hipparcos Number", "HIP 7911"},
        {"Geneva Identification System", "GEN# +1.00010553"},
        {"Smithsonian Astrophysical Observation", "SAO 232497"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.42173306),
        dec: Angle.Degrees(-50.03860018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31634"},
        {"Geneva Identification System", "GEN# -0.04902340"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.29616953),
        dec: Angle.Degrees(-50.03829704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 371"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.16032911),
        dec: Angle.Degrees(-50.03593839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208890"},
        {"Hipparcos Number", "HIP 108651"},
        {"Smithsonian Astrophysical Observation", "SAO 247266"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.16403758),
        dec: Angle.Degrees(-50.03524591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24837"},
        {"Hipparcos Number", "HIP 18288"},
        {"Smithsonian Astrophysical Observation", "SAO 233320"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.66684313),
        dec: Angle.Degrees(-50.03461766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20012"},
        {"Hipparcos Number", "HIP 14787"},
        {"Smithsonian Astrophysical Observation", "SAO 233022"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.74296003),
        dec: Angle.Degrees(-50.03352725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110757"},
        {"Hipparcos Number", "HIP 62182"},
        {"Smithsonian Astrophysical Observation", "SAO 223639"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.15782997),
        dec: Angle.Degrees(-50.03314206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75792"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.25043899),
        dec: Angle.Degrees(-50.03193819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213867"},
        {"Hipparcos Number", "HIP 111503"},
        {"Smithsonian Astrophysical Observation", "SAO 247500"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85880176),
        dec: Angle.Degrees(-50.03040773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136249"},
        {"Hipparcos Number", "HIP 75165"},
        {"Smithsonian Astrophysical Observation", "SAO 225690"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.40392820),
        dec: Angle.Degrees(-50.02999003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106904"},
        {"Hipparcos Number", "HIP 59954"},
        {"Geneva Identification System", "GEN# +1.00106904"},
        {"Smithsonian Astrophysical Observation", "SAO 223339"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.45511731),
        dec: Angle.Degrees(-50.02524526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58431"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.71540045),
        dec: Angle.Degrees(-50.02437043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330076"},
        {"Hipparcos Number", "HIP 77498"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.36816312),
        dec: Angle.Degrees(-50.01811934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5727"},
        {"Hipparcos Number", "HIP 4543"},
        {"Smithsonian Astrophysical Observation", "SAO 232242"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54302975),
        dec: Angle.Degrees(-50.01715734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193177"},
        {"Hipparcos Number", "HIP 100349"},
        {"Smithsonian Astrophysical Observation", "SAO 246542"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.25913120),
        dec: Angle.Degrees(-50.01713200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112809"},
        {"Hipparcos Number", "HIP 63441"},
        {"Smithsonian Astrophysical Observation", "SAO 223822"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.00839249),
        dec: Angle.Degrees(-50.01564097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214416"},
        {"Hipparcos Number", "HIP 111816"},
        {"Smithsonian Astrophysical Observation", "SAO 247529"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73322043),
        dec: Angle.Degrees(-50.01498676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 479"},
        {"Hipparcos Number", "HIP 743"},
        {"Smithsonian Astrophysical Observation", "SAO 231946"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.27906762),
        dec: Angle.Degrees(-50.01362800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107735"},
        {"Hipparcos Number", "HIP 60391"},
        {"Smithsonian Astrophysical Observation", "SAO 223396"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.74687632),
        dec: Angle.Degrees(-50.01259585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143508"},
        {"Hipparcos Number", "HIP 78616"},
        {"Smithsonian Astrophysical Observation", "SAO 226462"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.74631783),
        dec: Angle.Degrees(-50.01258261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76596"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.65585208),
        dec: Angle.Degrees(-50.01091543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84598"},
        {"Hipparcos Number", "HIP 47824"},
        {"Geneva Identification System", "GEN# +1.00084598J"},
        {"Smithsonian Astrophysical Observation", "SAO 221451"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22183784),
        dec: Angle.Degrees(-50.01021365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202997"},
        {"Hipparcos Number", "HIP 105422"},
        {"Smithsonian Astrophysical Observation", "SAO 246982"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.31056531),
        dec: Angle.Degrees(-50.01017557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105854"},
        {"Hipparcos Number", "HIP 59393"},
        {"Geneva Identification System", "GEN# +1.00105854"},
        {"Smithsonian Astrophysical Observation", "SAO 223267"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.76576382),
        dec: Angle.Degrees(-50.00919794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3921"},
    },
    visualMagnitude: 11.83,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.58545399),
        dec: Angle.Degrees(-50.00601584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21373"},
        {"Hipparcos Number", "HIP 15891"},
        {"Smithsonian Astrophysical Observation", "SAO 233108"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.17401525),
        dec: Angle.Degrees(-50.00596000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74274"},
        {"Hipparcos Number", "HIP 42602"},
        {"Geneva Identification System", "GEN# +1.00074274"},
        {"Smithsonian Astrophysical Observation", "SAO 220281"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.24136368),
        dec: Angle.Degrees(-50.00531023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62756"},
        {"Hipparcos Number", "HIP 37617"},
        {"Geneva Identification System", "GEN# +1.00062756"},
        {"Smithsonian Astrophysical Observation", "SAO 218928"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.77906361),
        dec: Angle.Degrees(-49.99296045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38255"},
        {"Hipparcos Number", "HIP 26830"},
        {"Smithsonian Astrophysical Observation", "SAO 234096"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.45512595),
        dec: Angle.Degrees(-50.00445206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82811"},
        {"Hipparcos Number", "HIP 46848"},
        {"Celescope Catalog", "CEL 3320"},
        {"Geneva Identification System", "GEN# +1.00082811"},
        {"Smithsonian Astrophysical Observation", "SAO 221272"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.20002737),
        dec: Angle.Degrees(-50.00437839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27908"},
        {"Hipparcos Number", "HIP 20378"},
        {"Smithsonian Astrophysical Observation", "SAO 233494"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.45799928),
        dec: Angle.Degrees(-50.00427029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70722"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.95055972),
        dec: Angle.Degrees(-50.00386482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48928"},
        {"Geneva Identification System", "GEN# +6.10029308"},
    },
    visualMagnitude: 11.69,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.72671701),
        dec: Angle.Degrees(-50.00359639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329966"},
        {"Hipparcos Number", "HIP 77079"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.08176884),
        dec: Angle.Degrees(-50.00246141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63082"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.88075005),
        dec: Angle.Degrees(-50.00237751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77142"},
        {"Hipparcos Number", "HIP 44076"},
        {"Smithsonian Astrophysical Observation", "SAO 220713"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.68565028),
        dec: Angle.Degrees(-50.00138317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160482"},
        {"Hipparcos Number", "HIP 86690"},
        {"Geneva Identification System", "GEN# +1.00160482"},
        {"Smithsonian Astrophysical Observation", "SAO 228313"},
        {"Wilson Evans Batten Catalogue", "WEB 14617"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.69588077),
        dec: Angle.Degrees(-50.00069688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19442"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.45750279),
        dec: Angle.Degrees(-50.00034267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 297.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223938"},
        {"Hipparcos Number", "HIP 117829"},
        {"Smithsonian Astrophysical Observation", "SAO 248056"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.45763751),
        dec: Angle.Degrees(-49.99950141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169528"},
        {"Hipparcos Number", "HIP 90477"},
        {"Geneva Identification System", "GEN# +1.00169528"},
        {"Smithsonian Astrophysical Observation", "SAO 245492"},
        {"Wilson Evans Batten Catalogue", "WEB 15493"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.93190773),
        dec: Angle.Degrees(-49.99925967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193307"},
        {"Hipparcos Number", "HIP 100412"},
        {"Cincinnati Publication", "Ci 20 1201"},
        {"Fundamental Katalog 5th Edition", "FK5 3630"},
        {"Geneva Identification System", "GEN# +1.00193307"},
        {"Smithsonian Astrophysical Observation", "SAO 246546"},
        {"Wilson Evans Batten Catalogue", "WEB 18125"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42233711),
        dec: Angle.Degrees(-49.99880746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -359.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186237"},
        {"Hipparcos Number", "HIP 97221"},
        {"Smithsonian Astrophysical Observation", "SAO 246254"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.38247693),
        dec: Angle.Degrees(-49.99717789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49615"},
        {"Hipparcos Number", "HIP 32469"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.65511588),
        dec: Angle.Degrees(-49.99653595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11515"},
        {"Hipparcos Number", "HIP 8692"},
        {"Smithsonian Astrophysical Observation", "SAO 232549"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.95362252),
        dec: Angle.Degrees(-49.99493954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69653"},
        {"Hipparcos Number", "HIP 40455"},
        {"Celescope Catalog", "CEL 2296"},
        {"Geneva Identification System", "GEN# +1.00069653"},
        {"Smithsonian Astrophysical Observation", "SAO 219694"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.90638152),
        dec: Angle.Degrees(-49.99292770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21209A"},
        {"Henry Draper 2", "HD 21209"},
        {"Hipparcos Number", "HIP 15774"},
        {"Geneva Identification System", "GEN# +1.00021209A"},
        {"Smithsonian Astrophysical Observation", "SAO 233096"},
        {"Wilson Evans Batten Catalogue", "WEB 3017"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.82064550),
        dec: Angle.Degrees(-49.99257806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 266.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83529"},
        {"Henry Draper 2", "HD 83529A"},
        {"Hipparcos Number", "HIP 47225"},
        {"Geneva Identification System", "GEN# +1.00083529"},
        {"Smithsonian Astrophysical Observation", "SAO 221353"},
        {"Wilson Evans Batten Catalogue", "WEB 8882"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.36953137),
        dec: Angle.Degrees(-49.99147971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 223.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213829"},
        {"Hipparcos Number", "HIP 111485"},
        {"Smithsonian Astrophysical Observation", "SAO 247497"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.80887659),
        dec: Angle.Degrees(-49.99134173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113968"},
        {"Geneva Identification System", "GEN# +6.20145124"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.21434016),
        dec: Angle.Degrees(-49.98965947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -389.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46311"},
        {"Hipparcos Number", "HIP 30971"},
        {"Geneva Identification System", "GEN# +1.00046311"},
        {"Smithsonian Astrophysical Observation", "SAO 217976"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.51131424),
        dec: Angle.Degrees(-49.98813981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49516"},
        {"Hipparcos Number", "HIP 32429"},
        {"Smithsonian Astrophysical Observation", "SAO 218182"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.53966715),
        dec: Angle.Degrees(-49.98714944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204975"},
        {"Hipparcos Number", "HIP 106459"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.43125553),
        dec: Angle.Degrees(-49.98668110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179887"},
        {"Hipparcos Number", "HIP 94746"},
        {"Geneva Identification System", "GEN# +1.00179887J"},
        {"Smithsonian Astrophysical Observation", "SAO 246007"},
        {"Smithsonian Astrophysical Observation 2", "SAO 246009"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.19170982),
        dec: Angle.Degrees(-49.98618677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151363"},
        {"Hipparcos Number", "HIP 82335"},
        {"Renson", "Renson 42820"},
        {"Smithsonian Astrophysical Observation", "SAO 227256"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36033465),
        dec: Angle.Degrees(-49.98574390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207254"},
        {"Hipparcos Number", "HIP 107706"},
        {"Smithsonian Astrophysical Observation", "SAO 247194"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.27266839),
        dec: Angle.Degrees(-49.98373436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94748"},
        {"Smithsonian Astrophysical Observation", "SAO 246010"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.19499380),
        dec: Angle.Degrees(-49.98327627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69428"},
        {"Hipparcos Number", "HIP 40385"},
        {"Geneva Identification System", "GEN# +1.00069428"},
        {"Smithsonian Astrophysical Observation", "SAO 219673"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.67689288),
        dec: Angle.Degrees(-49.98322419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66567"},
        {"Hipparcos Number", "HIP 39270"},
        {"Smithsonian Astrophysical Observation", "SAO 219323"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.45554691),
        dec: Angle.Degrees(-49.98295209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57286"},
        {"Geneva Identification System", "GEN# -0.04906451"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.19917576),
        dec: Angle.Degrees(-49.98239382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65424"},
        {"Hipparcos Number", "HIP 38787"},
        {"Geneva Identification System", "GEN# +1.00065424"},
        {"Smithsonian Astrophysical Observation", "SAO 219177"},
    },
    visualMagnitude: 7.72,
    bvColour: 2.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.08667789),
        dec: Angle.Degrees(-49.98195721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219807"},
        {"Hipparcos Number", "HIP 115136"},
        {"Smithsonian Astrophysical Observation", "SAO 247828"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.82466619),
        dec: Angle.Degrees(-49.98159027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148519"},
        {"Hipparcos Number", "HIP 80890"},
        {"Smithsonian Astrophysical Observation", "SAO 226837"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.76828160),
        dec: Angle.Degrees(-49.98111071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50448"},
        {"Hipparcos Number", "HIP 32846"},
        {"Smithsonian Astrophysical Observation", "SAO 218248"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.69228635),
        dec: Angle.Degrees(-49.98044111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13120"},
        {"Hipparcos Number", "HIP 9866"},
        {"Smithsonian Astrophysical Observation", "SAO 232636"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.73454284),
        dec: Angle.Degrees(-49.98028977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57582"},
        {"Hipparcos Number", "HIP 35465"},
        {"Smithsonian Astrophysical Observation", "SAO 218639"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.81691098),
        dec: Angle.Degrees(-49.97829662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66005"},
        {"Hipparcos Number", "HIP 39035"},
        {"Celescope Catalog", "CEL 2128"},
        {"Geneva Identification System", "GEN# +1.00066005"},
        {"Smithsonian Astrophysical Observation", "SAO 219249"},
        {"Wilson Evans Batten Catalogue", "WEB 7653"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.80129013),
        dec: Angle.Degrees(-49.97686927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166007"},
        {"Hipparcos Number", "HIP 89119"},
        {"Smithsonian Astrophysical Observation", "SAO 228776"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.82053111),
        dec: Angle.Degrees(-49.97446785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11446"},
        {"Hipparcos Number", "HIP 8627"},
        {"Smithsonian Astrophysical Observation", "SAO 232547"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.82388023),
        dec: Angle.Degrees(-49.97391731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138725"},
        {"Hipparcos Number", "HIP 76373"},
        {"Smithsonian Astrophysical Observation", "SAO 225946"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.97277013),
        dec: Angle.Degrees(-49.97387578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66006"},
        {"Hipparcos Number", "HIP 39038"},
        {"Geneva Identification System", "GEN# +1.00066006"},
        {"Smithsonian Astrophysical Observation", "SAO 219250"},
        {"Wilson Evans Batten Catalogue", "WEB 7654"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.80652353),
        dec: Angle.Degrees(-49.97378939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80077"},
        {"Hipparcos Number", "HIP 45467"},
        {"Geneva Identification System", "GEN# +1.00080077"},
        {"Geneva Identification System 2", "GEN# +4.27110001"},
        {"Smithsonian Astrophysical Observation", "SAO 221009"},
        {"Wilson Evans Batten Catalogue", "WEB 8649"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.97829889),
        dec: Angle.Degrees(-49.97350482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104444"},
        {"Hipparcos Number", "HIP 58647"},
        {"Smithsonian Astrophysical Observation", "SAO 223173"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.38629015),
        dec: Angle.Degrees(-49.97330242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105351"},
        {"Hipparcos Number", "HIP 59155"},
        {"Smithsonian Astrophysical Observation", "SAO 223228"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.96854796),
        dec: Angle.Degrees(-49.97257838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20641"},
        {"Hipparcos Number", "HIP 15290"},
        {"Smithsonian Astrophysical Observation", "SAO 233062"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.32042856),
        dec: Angle.Degrees(-49.96856799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121485"},
        {"Hipparcos Number", "HIP 68129"},
        {"Smithsonian Astrophysical Observation", "SAO 224558"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.20971717),
        dec: Angle.Degrees(-49.96804064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87909"},
        {"Hipparcos Number", "HIP 49536"},
        {"Smithsonian Astrophysical Observation", "SAO 221780"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.71481964),
        dec: Angle.Degrees(-49.96663602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200654"},
        {"Hipparcos Number", "HIP 104191"},
        {"Geneva Identification System", "GEN# +1.00200654"},
        {"Smithsonian Astrophysical Observation", "SAO 246871"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.64406359),
        dec: Angle.Degrees(-49.96329984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330075"},
        {"Hipparcos Number", "HIP 77517"},
        {"Smithsonian Astrophysical Observation", "SAO 226248"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.40793739),
        dec: Angle.Degrees(-49.96329684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201973"},
        {"Hipparcos Number", "HIP 104892"},
        {"Smithsonian Astrophysical Observation", "SAO 246923"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.70985679),
        dec: Angle.Degrees(-49.96007265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178151"},
        {"Hipparcos Number", "HIP 94161"},
        {"Geneva Identification System", "GEN# +1.00178151"},
        {"Smithsonian Astrophysical Observation", "SAO 245950"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.50786486),
        dec: Angle.Degrees(-49.95806912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22705"},
        {"Hipparcos Number", "HIP 16853"},
        {"Fundamental Katalog 5th Edition", "FK5 4323"},
        {"Geneva Identification System", "GEN# +1.00022705"},
        {"Smithsonian Astrophysical Observation", "SAO 233181"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.22217845),
        dec: Angle.Degrees(-49.95801756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160113"},
        {"Hipparcos Number", "HIP 86516"},
        {"Geneva Identification System", "GEN# +1.00160113"},
        {"Smithsonian Astrophysical Observation", "SAO 228263"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.20875143),
        dec: Angle.Degrees(-49.95780239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137676"},
        {"Hipparcos Number", "HIP 75819"},
        {"Geneva Identification System", "GEN# +1.00137676"},
        {"Smithsonian Astrophysical Observation", "SAO 225824"},
        {"Wilson Evans Batten Catalogue", "WEB 12903"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.33014473),
        dec: Angle.Degrees(-49.95287122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27344"},
        {"Hipparcos Number", "HIP 19928"},
        {"Smithsonian Astrophysical Observation", "SAO 233461"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13351773),
        dec: Angle.Degrees(-49.95261709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160502"},
        {"Hipparcos Number", "HIP 86701"},
        {"Smithsonian Astrophysical Observation", "SAO 228314"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.72093597),
        dec: Angle.Degrees(-49.95112311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197876"},
        {"Hipparcos Number", "HIP 102676"},
        {"Smithsonian Astrophysical Observation", "SAO 246735"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.09531893),
        dec: Angle.Degrees(-49.95110418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188160"},
        {"Hipparcos Number", "HIP 98098"},
        {"Geneva Identification System", "GEN# +1.00188160"},
        {"Smithsonian Astrophysical Observation", "SAO 246346"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.04323349),
        dec: Angle.Degrees(-49.95091755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66747"},
        {"Hipparcos Number", "HIP 39355"},
        {"Geneva Identification System", "GEN# +1.00066747"},
        {"Smithsonian Astrophysical Observation", "SAO 219345"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.67065377),
        dec: Angle.Degrees(-49.95057802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118767"},
        {"Hipparcos Number", "HIP 66666"},
        {"Geneva Identification System", "GEN# +1.00118767"},
        {"Smithsonian Astrophysical Observation", "SAO 224317"},
        {"Wilson Evans Batten Catalogue", "WEB 11758"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.99957281),
        dec: Angle.Degrees(-49.95000116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185141"},
        {"Hipparcos Number", "HIP 96746"},
        {"Smithsonian Astrophysical Observation", "SAO 246203"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.01103578),
        dec: Angle.Degrees(-49.94924310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102247"},
        {"Hipparcos Number", "HIP 57382"},
        {"Smithsonian Astrophysical Observation", "SAO 223012"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.47116045),
        dec: Angle.Degrees(-49.94902687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107524"},
        {"Hipparcos Number", "HIP 60291"},
        {"Smithsonian Astrophysical Observation", "SAO 223379"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.44436310),
        dec: Angle.Degrees(-49.94897376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151476"},
        {"Hipparcos Number", "HIP 82377"},
        {"Smithsonian Astrophysical Observation", "SAO 227268"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.50035021),
        dec: Angle.Degrees(-49.94818809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29078"},
        {"Hipparcos Number", "HIP 21151"},
        {"Geneva Identification System", "GEN# +1.00029078"},
        {"Smithsonian Astrophysical Observation", "SAO 233551"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.01913847),
        dec: Angle.Degrees(-49.94796009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100331"},
        {"Hipparcos Number", "HIP 56285"},
        {"Smithsonian Astrophysical Observation", "SAO 222852"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.07883464),
        dec: Angle.Degrees(-49.94746328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144695"},
        {"Hipparcos Number", "HIP 79172"},
        {"Geneva Identification System", "GEN# +1.00144695"},
        {"Wilson Evans Batten Catalogue", "WEB 13384"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.38040567),
        dec: Angle.Degrees(-49.94731696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31660"},
        {"Hipparcos Number", "HIP 22868"},
        {"Smithsonian Astrophysical Observation", "SAO 233732"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.78999280),
        dec: Angle.Degrees(-49.94543084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124784"},
        {"Hipparcos Number", "HIP 69781"},
        {"Geneva Identification System", "GEN# +1.00124784"},
        {"Smithsonian Astrophysical Observation", "SAO 224812"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.24138654),
        dec: Angle.Degrees(-49.94504167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73155"},
        {"Hipparcos Number", "HIP 42088"},
        {"Fundamental Katalog 5th Edition", "FK5 2674"},
        {"Geneva Identification System", "GEN# +1.00073155"},
        {"Smithsonian Astrophysical Observation", "SAO 220138"},
        {"Wilson Evans Batten Catalogue", "WEB 8093"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.68170313),
        dec: Angle.Degrees(-49.94424627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85037"},
        {"Hipparcos Number", "HIP 48054"},
        {"Geneva Identification System", "GEN# +1.00085037"},
        {"Renson", "Renson 24270"},
        {"Smithsonian Astrophysical Observation", "SAO 221496"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.93317015),
        dec: Angle.Degrees(-49.94328266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71610"},
        {"Hipparcos Number", "HIP 41349"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.54018727),
        dec: Angle.Degrees(-49.94160986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24628"},
        {"Hipparcos Number", "HIP 18137"},
        {"Smithsonian Astrophysical Observation", "SAO 233309"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.16075249),
        dec: Angle.Degrees(-49.94011825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172418"},
        {"Hipparcos Number", "HIP 91757"},
        {"Smithsonian Astrophysical Observation", "SAO 229213"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.66117910),
        dec: Angle.Degrees(-49.93912851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1984"},
        {"Hipparcos Number", "HIP 1883"},
        {"Smithsonian Astrophysical Observation", "SAO 232020"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.94146656),
        dec: Angle.Degrees(-49.93904827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223026"},
        {"Hipparcos Number", "HIP 117228"},
        {"Smithsonian Astrophysical Observation", "SAO 248012"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.53543824),
        dec: Angle.Degrees(-49.93875103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203010"},
        {"Hipparcos Number", "HIP 105425"},
        {"Geneva Identification System", "GEN# +1.00203010"},
        {"Smithsonian Astrophysical Observation", "SAO 246983"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.31917813),
        dec: Angle.Degrees(-49.93785461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56287"},
        {"Hipparcos Number", "HIP 34945"},
        {"Smithsonian Astrophysical Observation", "SAO 218556"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.46733249),
        dec: Angle.Degrees(-49.93660093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84296"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.50149737),
        dec: Angle.Degrees(-49.93432905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15751"},
        {"Hipparcos Number", "HIP 11646"},
        {"Smithsonian Astrophysical Observation", "SAO 232792"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.55870030),
        dec: Angle.Degrees(-49.92837228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53494"},
        {"Hipparcos Number", "HIP 33957"},
        {"Smithsonian Astrophysical Observation", "SAO 218407"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.69069162),
        dec: Angle.Degrees(-49.92800951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160672"},
        {"Hipparcos Number", "HIP 86773"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.97051072),
        dec: Angle.Degrees(-49.92634109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330078"},
        {"Hipparcos Number", "HIP 77649"},
        {"Smithsonian Astrophysical Observation", "SAO 226281"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.78398309),
        dec: Angle.Degrees(-49.92559350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75810"},
        {"Hipparcos Number", "HIP 43380"},
        {"Smithsonian Astrophysical Observation", "SAO 220556"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.54268301),
        dec: Angle.Degrees(-49.92468057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98894"},
        {"Hipparcos Number", "HIP 55521"},
        {"Geneva Identification System", "GEN# +1.00098894"},
        {"Renson", "Renson 28500"},
        {"Smithsonian Astrophysical Observation", "SAO 222750"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.56838245),
        dec: Angle.Degrees(-49.92383602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80505"},
        {"Hipparcos Number", "HIP 45655"},
        {"Smithsonian Astrophysical Observation", "SAO 221050"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.59063433),
        dec: Angle.Degrees(-49.92118902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144143"},
        {"Hipparcos Number", "HIP 78926"},
        {"Smithsonian Astrophysical Observation", "SAO 226501"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.67963351),
        dec: Angle.Degrees(-49.91821003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156426"},
        {"Hipparcos Number", "HIP 84822"},
        {"Geneva Identification System", "GEN# +1.00156426"},
        {"Smithsonian Astrophysical Observation", "SAO 227828"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.04570509),
        dec: Angle.Degrees(-49.91743061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163729"},
        {"Hipparcos Number", "HIP 88161"},
        {"Fundamental Katalog 5th Edition", "FK5 5585"},
        {"Geneva Identification System", "GEN# +1.00163729"},
        {"Smithsonian Astrophysical Observation", "SAO 228610"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.08947803),
        dec: Angle.Degrees(-49.91685198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84847"},
        {"Hipparcos Number", "HIP 47969"},
        {"Smithsonian Astrophysical Observation", "SAO 221487"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.65009607),
        dec: Angle.Degrees(-49.91674911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70767"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.08889671),
        dec: Angle.Degrees(-49.91535182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129642"},
        {"Hipparcos Number", "HIP 72119"},
        {"Cincinnati Publication", "Ci 20 882"},
        {"Geneva Identification System", "GEN# +1.00129642"},
        {"Smithsonian Astrophysical Observation", "SAO 225161"},
        {"Wilson Evans Batten Catalogue", "WEB 12408"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.29308925),
        dec: Angle.Degrees(-49.91532856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -662.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -391.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330077"},
        {"Hipparcos Number", "HIP 77644"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.77781755),
        dec: Angle.Degrees(-49.91328191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58937"},
        {"Hipparcos Number", "HIP 36003"},
        {"Smithsonian Astrophysical Observation", "SAO 218715"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.29673374),
        dec: Angle.Degrees(-49.91291130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116053"},
        {"Hipparcos Number", "HIP 65223"},
        {"Geneva Identification System", "GEN# +1.00116053"},
        {"Smithsonian Astrophysical Observation", "SAO 224088"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.49701313),
        dec: Angle.Degrees(-49.91269137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89531"},
        {"Hipparcos Number", "HIP 50494"},
        {"Smithsonian Astrophysical Observation", "SAO 221951"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.66135261),
        dec: Angle.Degrees(-49.91259024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20302"},
        {"Hipparcos Number", "HIP 15047"},
        {"Smithsonian Astrophysical Observation", "SAO 233043"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47777044),
        dec: Angle.Degrees(-49.91197727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74844"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.42525821),
        dec: Angle.Degrees(-49.91146862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154553"},
        {"Hipparcos Number", "HIP 83883"},
        {"Smithsonian Astrophysical Observation", "SAO 227662"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.16810551),
        dec: Angle.Degrees(-49.91141871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168033"},
        {"Hipparcos Number", "HIP 89890"},
        {"Geneva Identification System", "GEN# +1.00168033"},
        {"Smithsonian Astrophysical Observation", "SAO 228923"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.12549402),
        dec: Angle.Degrees(-49.91119249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109312"},
        {"Hipparcos Number", "HIP 61328"},
        {"Geneva Identification System", "GEN# +1.00109312"},
        {"Smithsonian Astrophysical Observation", "SAO 223516"},
        {"Wilson Evans Batten Catalogue", "WEB 10916"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.49690379),
        dec: Angle.Degrees(-49.90969306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67106"},
        {"Hipparcos Number", "HIP 39479"},
        {"Smithsonian Astrophysical Observation", "SAO 219374"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.03115352),
        dec: Angle.Degrees(-49.90904088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69368"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.99601532),
        dec: Angle.Degrees(-49.90900160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211494"},
        {"Hipparcos Number", "HIP 110147"},
        {"Smithsonian Astrophysical Observation", "SAO 247401"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.66451327),
        dec: Angle.Degrees(-49.90767945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106670"},
        {"Hipparcos Number", "HIP 59837"},
        {"Geneva Identification System", "GEN# +1.00106670"},
        {"Smithsonian Astrophysical Observation", "SAO 223321"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.04982101),
        dec: Angle.Degrees(-49.90729186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80899"},
        {"Hipparcos Number", "HIP 45819"},
        {"Geneva Identification System", "GEN# +1.00080899"},
        {"Smithsonian Astrophysical Observation", "SAO 221085"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.13802091),
        dec: Angle.Degrees(-49.90722838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15645"},
        {"Hipparcos Number", "HIP 11585"},
        {"Smithsonian Astrophysical Observation", "SAO 232789"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.32675676),
        dec: Angle.Degrees(-49.90701468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53213"},
        {"Geneva Identification System", "GEN# -0.04905632"},
    },
    visualMagnitude: 11.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.26020348),
        dec: Angle.Degrees(-49.90628275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113791"},
        {"Henry Draper 2", "HD 113791A"},
        {"Hipparcos Number", "HIP 64004"},
        {"Fundamental Katalog 5th Edition", "FK5 489"},
        {"Geneva Identification System", "GEN# +1.00113791A"},
        {"Smithsonian Astrophysical Observation", "SAO 223909"},
        {"Wilson Evans Batten Catalogue", "WEB 11312"},
    },
    visualMagnitude: 4.27,
    bvColour: -0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.72776268),
        dec: Angle.Degrees(-49.90621586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1444"},
        {"Hipparcos Number", "HIP 1476"},
        {"Smithsonian Astrophysical Observation", "SAO 231993"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58631694),
        dec: Angle.Degrees(-49.90551506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89016"},
        {"Hipparcos Number", "HIP 50205"},
        {"Geneva Identification System", "GEN# +1.00089016"},
        {"Smithsonian Astrophysical Observation", "SAO 221906"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.74202971),
        dec: Angle.Degrees(-49.90505532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5350"},
        {"Hipparcos Number", "HIP 4277"},
        {"Smithsonian Astrophysical Observation", "SAO 232224"},
    },
    visualMagnitude: 9.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.68126948),
        dec: Angle.Degrees(-49.90464579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9378"},
        {"Hipparcos Number", "HIP 7086"},
        {"Geneva Identification System", "GEN# +1.00009378"},
        {"Smithsonian Astrophysical Observation", "SAO 232446"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.81891980),
        dec: Angle.Degrees(-49.90381830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5811"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.63785653),
        dec: Angle.Degrees(-49.90348805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178904"},
        {"Hipparcos Number", "HIP 94417"},
        {"Geneva Identification System", "GEN# +1.00178904"},
        {"Smithsonian Astrophysical Observation", "SAO 229552"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.25294664),
        dec: Angle.Degrees(-49.90281205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98803"},
        {"Hipparcos Number", "HIP 55478"},
        {"Smithsonian Astrophysical Observation", "SAO 222744"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.43549330),
        dec: Angle.Degrees(-49.90213879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128415"},
        {"Hipparcos Number", "HIP 71577"},
        {"Smithsonian Astrophysical Observation", "SAO 225078"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.57368579),
        dec: Angle.Degrees(-49.90109289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183119"},
        {"Hipparcos Number", "HIP 95918"},
        {"Smithsonian Astrophysical Observation", "SAO 246133"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.60206257),
        dec: Angle.Degrees(-49.90009442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134180"},
        {"Hipparcos Number", "HIP 74243"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.58516569),
        dec: Angle.Degrees(-49.89955324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106243"},
        {"Hipparcos Number", "HIP 59618"},
        {"Smithsonian Astrophysical Observation", "SAO 223292"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.39560874),
        dec: Angle.Degrees(-49.89927095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85245"},
        {"Geneva Identification System", "GEN# +3.46510056"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.28725705),
        dec: Angle.Degrees(-49.89918835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110145"},
    },
    visualMagnitude: 10.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.66316084),
        dec: Angle.Degrees(-49.89909641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134579"},
        {"Hipparcos Number", "HIP 74426"},
        {"Smithsonian Astrophysical Observation", "SAO 225534"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.16187260),
        dec: Angle.Degrees(-49.89592471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117037"},
        {"Hipparcos Number", "HIP 65743"},
        {"Smithsonian Astrophysical Observation", "SAO 224163"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.14037571),
        dec: Angle.Degrees(-49.89581417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69841"},
        {"Hipparcos Number", "HIP 40537"},
        {"Celescope Catalog", "CEL 2308"},
        {"Geneva Identification System", "GEN# +1.00069841J"},
        {"Smithsonian Astrophysical Observation", "SAO 219716"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.15613935),
        dec: Angle.Degrees(-49.89533400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86716"},
        {"Hipparcos Number", "HIP 48934"},
        {"Geneva Identification System", "GEN# +1.00086716"},
        {"Smithsonian Astrophysical Observation", "SAO 221662"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.75362779),
        dec: Angle.Degrees(-49.89531748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193853"},
        {"Hipparcos Number", "HIP 100665"},
        {"Smithsonian Astrophysical Observation", "SAO 246567"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15623928),
        dec: Angle.Degrees(-49.89303446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157556"},
        {"Hipparcos Number", "HIP 85362"},
        {"Geneva Identification System", "GEN# +1.00157556"},
        {"Smithsonian Astrophysical Observation", "SAO 227958"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.64910612),
        dec: Angle.Degrees(-49.89249653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150405"},
        {"Hipparcos Number", "HIP 81864"},
        {"Smithsonian Astrophysical Observation", "SAO 227094"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.81106617),
        dec: Angle.Degrees(-49.89172573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18242"},
        {"Hipparcos Number", "HIP 13502"},
        {"Geneva Identification System", "GEN# +1.00018242"},
        {"Wilson Evans Batten Catalogue", "WEB 2695"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.46939208),
        dec: Angle.Degrees(-49.88973319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127512"},
        {"Hipparcos Number", "HIP 71175"},
        {"Smithsonian Astrophysical Observation", "SAO 225012"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.35095242),
        dec: Angle.Degrees(-49.88887151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22153"},
        {"Hipparcos Number", "HIP 16454"},
        {"Geneva Identification System", "GEN# +1.00022153"},
        {"Smithsonian Astrophysical Observation", "SAO 233146"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.99175198),
        dec: Angle.Degrees(-49.88672108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30862"},
        {"Hipparcos Number", "HIP 22359"},
        {"Geneva Identification System", "GEN# +1.00030862J"},
        {"Smithsonian Astrophysical Observation", "SAO 217009"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.19713942),
        dec: Angle.Degrees(-49.88560083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145412"},
        {"Hipparcos Number", "HIP 79477"},
        {"Geneva Identification System", "GEN# +1.00145412"},
        {"Smithsonian Astrophysical Observation", "SAO 226576"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.29944839),
        dec: Angle.Degrees(-49.88464283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102458"},
        {"Henry Draper 2", "HD 102458A"},
        {"Hipparcos Number", "HIP 57524"},
        {"Smithsonian Astrophysical Observation", "SAO 223029"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.85239682),
        dec: Angle.Degrees(-49.88414837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212285"},
        {"Hipparcos Number", "HIP 110587"},
        {"Smithsonian Astrophysical Observation", "SAO 247437"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.05515367),
        dec: Angle.Degrees(-49.87960438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174730"},
        {"Hipparcos Number", "HIP 92799"},
        {"Geneva Identification System", "GEN# +1.00174730"},
        {"Smithsonian Astrophysical Observation", "SAO 229358"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.63516351),
        dec: Angle.Degrees(-49.87900599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115564"},
        {"Hipparcos Number", "HIP 64940"},
        {"Geneva Identification System", "GEN# +1.00115564"},
        {"Smithsonian Astrophysical Observation", "SAO 224055"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.67986753),
        dec: Angle.Degrees(-49.87827225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203075"},
        {"Hipparcos Number", "HIP 105461"},
        {"Geneva Identification System", "GEN# +1.00203075"},
        {"Smithsonian Astrophysical Observation", "SAO 246990"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.41985259),
        dec: Angle.Degrees(-49.87613228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158427"},
        {"Hipparcos Number", "HIP 85792"},
        {"Fundamental Katalog 5th Edition", "FK5 651"},
        {"Geneva Identification System", "GEN# +1.00158427A"},
        {"Smithsonian Astrophysical Observation", "SAO 228069"},
        {"Wilson Evans Batten Catalogue", "WEB 14476"},
    },
    visualMagnitude: 2.84,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.96050661),
        dec: Angle.Degrees(-49.87598159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182857"},
        {"Hipparcos Number", "HIP 95795"},
        {"Geneva Identification System", "GEN# +1.00182857"},
        {"Smithsonian Astrophysical Observation", "SAO 229705"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.26207180),
        dec: Angle.Degrees(-49.87479015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145814"},
        {"Hipparcos Number", "HIP 79646"},
        {"Geneva Identification System", "GEN# +1.00145814"},
        {"Smithsonian Astrophysical Observation", "SAO 226597"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.79722788),
        dec: Angle.Degrees(-49.87444249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131855"},
        {"Hipparcos Number", "HIP 73204"},
        {"Smithsonian Astrophysical Observation", "SAO 225322"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.42351596),
        dec: Angle.Degrees(-49.87137424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86439"},
        {"Hipparcos Number", "HIP 48800"},
        {"Celescope Catalog", "CEL 3413"},
        {"Geneva Identification System", "GEN# +1.00086439J"},
        {"Smithsonian Astrophysical Observation", "SAO 221634"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.30272308),
        dec: Angle.Degrees(-49.87039196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18023"},
        {"Hipparcos Number", "HIP 13365"},
        {"Geneva Identification System", "GEN# +1.00018023"},
        {"Smithsonian Astrophysical Observation", "SAO 232921"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.99245973),
        dec: Angle.Degrees(-49.87014055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111461"},
        {"Hipparcos Number", "HIP 62621"},
        {"Smithsonian Astrophysical Observation", "SAO 223694"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.47742677),
        dec: Angle.Degrees(-49.86891178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123227"},
        {"Hipparcos Number", "HIP 69012"},
        {"Smithsonian Astrophysical Observation", "SAO 224702"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.92316233),
        dec: Angle.Degrees(-49.86786612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117929"},
        {"Hipparcos Number", "HIP 66242"},
        {"Geneva Identification System", "GEN# +1.00117929"},
        {"Smithsonian Astrophysical Observation", "SAO 224256"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.65534033),
        dec: Angle.Degrees(-49.86663087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213045"},
        {"Hipparcos Number", "HIP 111040"},
        {"Geneva Identification System", "GEN# +1.00213045"},
        {"Smithsonian Astrophysical Observation", "SAO 247465"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.43283364),
        dec: Angle.Degrees(-49.86579433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19126"},
        {"Hipparcos Number", "HIP 14170"},
        {"Geneva Identification System", "GEN# +1.00019126"},
        {"Smithsonian Astrophysical Observation", "SAO 232970"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.67861252),
        dec: Angle.Degrees(-49.86488010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99936"},
        {"Hipparcos Number", "HIP 56066"},
        {"Smithsonian Astrophysical Observation", "SAO 222819"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.36052797),
        dec: Angle.Degrees(-49.86453161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111520"},
        {"Hipparcos Number", "HIP 62657"},
        {"Smithsonian Astrophysical Observation", "SAO 223697"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58229343),
        dec: Angle.Degrees(-49.86355953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60959"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.44316125),
        dec: Angle.Degrees(-49.86310636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13949"},
        {"Hipparcos Number", "HIP 10421"},
        {"Geneva Identification System", "GEN# +1.00013949"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.57625544),
        dec: Angle.Degrees(-49.86224232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103679"},
        {"Hipparcos Number", "HIP 58199"},
        {"Geneva Identification System", "GEN# +1.00103679"},
        {"Renson", "Renson 29920"},
        {"Smithsonian Astrophysical Observation", "SAO 223120"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.04131754),
        dec: Angle.Degrees(-49.86222694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19498"},
        {"Hipparcos Number", "HIP 14414"},
        {"Smithsonian Astrophysical Observation", "SAO 232994"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.51977726),
        dec: Angle.Degrees(-49.86040669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30721"},
        {"Hipparcos Number", "HIP 22257"},
        {"Smithsonian Astrophysical Observation", "SAO 216996"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.87534559),
        dec: Angle.Degrees(-49.85956174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146124"},
        {"Hipparcos Number", "HIP 79777"},
        {"Geneva Identification System", "GEN# +1.00146124"},
        {"Smithsonian Astrophysical Observation", "SAO 226618"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.22131071),
        dec: Angle.Degrees(-49.85667320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194969"},
        {"Hipparcos Number", "HIP 101185"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64401145),
        dec: Angle.Degrees(-49.85517057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68421"},
        {"Hipparcos Number", "HIP 39993"},
        {"Smithsonian Astrophysical Observation", "SAO 219531"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.50789207),
        dec: Angle.Degrees(-49.85434047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168804"},
        {"Hipparcos Number", "HIP 90197"},
        {"Smithsonian Astrophysical Observation", "SAO 228979"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.07191522),
        dec: Angle.Degrees(-49.85250544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113601"},
        {"Hipparcos Number", "HIP 63887"},
        {"Smithsonian Astrophysical Observation", "SAO 223891"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.38653598),
        dec: Angle.Degrees(-49.85152781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125829"},
        {"Hipparcos Number", "HIP 70337"},
        {"Geneva Identification System", "GEN# +1.00125829"},
        {"Smithsonian Astrophysical Observation", "SAO 224883"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.86263434),
        dec: Angle.Degrees(-49.85138283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60517"},
        {"Hipparcos Number", "HIP 36654"},
        {"Geneva Identification System", "GEN# +1.00060517"},
        {"Smithsonian Astrophysical Observation", "SAO 218785"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.08558984),
        dec: Angle.Degrees(-49.84864257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 233.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219410"},
        {"Hipparcos Number", "HIP 114869"},
        {"Geneva Identification System", "GEN# +1.00219410"},
        {"Smithsonian Astrophysical Observation", "SAO 247805"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.00983440),
        dec: Angle.Degrees(-49.84826691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31852"},
        {"Hipparcos Number", "HIP 22976"},
        {"Geneva Identification System", "GEN# +1.00031852"},
        {"Smithsonian Astrophysical Observation", "SAO 217073"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.16391196),
        dec: Angle.Degrees(-49.84632386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175222"},
        {"Hipparcos Number", "HIP 93010"},
        {"Geneva Identification System", "GEN# +1.00175222"},
        {"Smithsonian Astrophysical Observation", "SAO 229391"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.22169261),
        dec: Angle.Degrees(-49.84525669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80574"},
        {"Hipparcos Number", "HIP 45694"},
        {"Smithsonian Astrophysical Observation", "SAO 221057"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.72613794),
        dec: Angle.Degrees(-49.84356423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182215"},
        {"Hipparcos Number", "HIP 95532"},
        {"Smithsonian Astrophysical Observation", "SAO 229672"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.48500498),
        dec: Angle.Degrees(-49.84267118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38471"},
        {"Hipparcos Number", "HIP 26975"},
        {"Renson", "Renson 10340"},
        {"Smithsonian Astrophysical Observation", "SAO 217496"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.86114471),
        dec: Angle.Degrees(-49.84243769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93124"},
        {"Hipparcos Number", "HIP 52518"},
        {"Geneva Identification System", "GEN# +1.00093124"},
        {"Smithsonian Astrophysical Observation", "SAO 222285"},
        {"Smithsonian Astrophysical Observation 2", "SAO 222287"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.07512493),
        dec: Angle.Degrees(-49.84088479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27589"},
        {"Hipparcos Number", "HIP 20120"},
        {"Smithsonian Astrophysical Observation", "SAO 216747"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.71413096),
        dec: Angle.Degrees(-49.83891513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297543"},
        {"Hipparcos Number", "HIP 47474"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.16735108),
        dec: Angle.Degrees(-49.83780759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65114"},
        {"Hipparcos Number", "HIP 38646"},
        {"Geneva Identification System", "GEN# +1.00065114"},
        {"Smithsonian Astrophysical Observation", "SAO 219142"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.70029910),
        dec: Angle.Degrees(-49.83684369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 256.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11965"},
        {"Hipparcos Number", "HIP 9022"},
        {"Geneva Identification System", "GEN# +1.00011965"},
        {"Smithsonian Astrophysical Observation", "SAO 232574"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.03914737),
        dec: Angle.Degrees(-49.83647990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55222"},
        {"Hipparcos Number", "HIP 34544"},
        {"Smithsonian Astrophysical Observation", "SAO 218492"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.35448692),
        dec: Angle.Degrees(-49.83631697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224652"},
        {"Hipparcos Number", "HIP 118296"},
        {"Cincinnati Publication", "Ci 20 1469"},
        {"Smithsonian Astrophysical Observation", "SAO 248092"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.91048948),
        dec: Angle.Degrees(-49.83245775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61168"},
        {"Hipparcos Number", "HIP 36928"},
        {"Smithsonian Astrophysical Observation", "SAO 218823"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.86543154),
        dec: Angle.Degrees(-49.83117854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125420"},
        {"Hipparcos Number", "HIP 70107"},
        {"Smithsonian Astrophysical Observation", "SAO 224842"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.18513313),
        dec: Angle.Degrees(-49.82965394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68897"},
        {"Hipparcos Number", "HIP 40168"},
        {"Geneva Identification System", "GEN# +1.00068897"},
        {"Smithsonian Astrophysical Observation", "SAO 219596"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.05442505),
        dec: Angle.Degrees(-49.82905125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212508"},
        {"Hipparcos Number", "HIP 110703"},
        {"Smithsonian Astrophysical Observation", "SAO 247444"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.44228283),
        dec: Angle.Degrees(-49.82589656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88602"},
        {"Hipparcos Number", "HIP 49932"},
        {"Smithsonian Astrophysical Observation", "SAO 221850"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.93603860),
        dec: Angle.Degrees(-49.82505615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54041"},
        {"Hipparcos Number", "HIP 34147"},
        {"Smithsonian Astrophysical Observation", "SAO 218435"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.20739721),
        dec: Angle.Degrees(-49.82298364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74753"},
        {"Hipparcos Number", "HIP 42834"},
        {"Celescope Catalog", "CEL 2831"},
        {"Fundamental Katalog 5th Edition", "FK5 2689"},
        {"Geneva Identification System", "GEN# +1.00074753"},
        {"Smithsonian Astrophysical Observation", "SAO 220361"},
        {"Wilson Evans Batten Catalogue", "WEB 8278"},
    },
    visualMagnitude: 5.15,
    bvColour: -0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.91781669),
        dec: Angle.Degrees(-49.82281081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116338"},
        {"Hipparcos Number", "HIP 65372"},
        {"Geneva Identification System", "GEN# +1.00116338"},
        {"Smithsonian Astrophysical Observation", "SAO 224104"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.96744625),
        dec: Angle.Degrees(-49.82273441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90641"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.42058419),
        dec: Angle.Degrees(-49.82203523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106013"},
        {"Hipparcos Number", "HIP 59494"},
        {"Smithsonian Astrophysical Observation", "SAO 223275"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.01210459),
        dec: Angle.Degrees(-49.82132329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130659"},
        {"Hipparcos Number", "HIP 72643"},
        {"Smithsonian Astrophysical Observation", "SAO 225233"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.78340762),
        dec: Angle.Degrees(-49.81816350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76410"},
        {"Hipparcos Number", "HIP 43697"},
        {"Smithsonian Astrophysical Observation", "SAO 220641"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49998206),
        dec: Angle.Degrees(-49.81659746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43548"},
        {"Hipparcos Number", "HIP 29596"},
        {"Geneva Identification System", "GEN# +1.00043548"},
        {"Smithsonian Astrophysical Observation", "SAO 217797"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.55798715),
        dec: Angle.Degrees(-49.81567102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193306"},
        {"Hipparcos Number", "HIP 100414"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42786370),
        dec: Angle.Degrees(-49.81539745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165127"},
        {"Hipparcos Number", "HIP 88755"},
        {"Smithsonian Astrophysical Observation", "SAO 228709"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.78245545),
        dec: Angle.Degrees(-49.81375785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29693"},
        {"Hipparcos Number", "HIP 21580"},
        {"Smithsonian Astrophysical Observation", "SAO 216909"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.50945471),
        dec: Angle.Degrees(-49.81263504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84674"},
        {"Hipparcos Number", "HIP 47869"},
        {"Geneva Identification System", "GEN# +1.00084674"},
        {"Smithsonian Astrophysical Observation", "SAO 221464"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.34170740),
        dec: Angle.Degrees(-49.81231213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170171"},
        {"Hipparcos Number", "HIP 90730"},
        {"Geneva Identification System", "GEN# +1.00170171"},
        {"Smithsonian Astrophysical Observation", "SAO 229074"},
        {"Wilson Evans Batten Catalogue", "WEB 15539"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.67636287),
        dec: Angle.Degrees(-49.80985797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75339"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.91794800),
        dec: Angle.Degrees(-49.80523335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9809"},
        {"Hipparcos Number", "HIP 7353"},
        {"Smithsonian Astrophysical Observation", "SAO 232467"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.69302788),
        dec: Angle.Degrees(-49.80478410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184420"},
        {"Hipparcos Number", "HIP 96472"},
        {"Smithsonian Astrophysical Observation", "SAO 229767"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.19498492),
        dec: Angle.Degrees(-49.80190806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143946"},
        {"Hipparcos Number", "HIP 78831"},
        {"Smithsonian Astrophysical Observation", "SAO 226492"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.37974677),
        dec: Angle.Degrees(-49.79856085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94593"},
        {"Hipparcos Number", "HIP 53331"},
        {"Smithsonian Astrophysical Observation", "SAO 222414"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.62034004),
        dec: Angle.Degrees(-49.79839422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113552"},
        {"Hipparcos Number", "HIP 63864"},
        {"Smithsonian Astrophysical Observation", "SAO 223888"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.32236217),
        dec: Angle.Degrees(-49.79820515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80573"},
        {"Hipparcos Number", "HIP 45692"},
        {"Celescope Catalog", "CEL 3264"},
        {"Smithsonian Astrophysical Observation", "SAO 221056"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.72220673),
        dec: Angle.Degrees(-49.79630449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7912"},
        {"Hipparcos Number", "HIP 6063"},
        {"Smithsonian Astrophysical Observation", "SAO 232367"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.45518731),
        dec: Angle.Degrees(-49.79628527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54478"},
        {"Hipparcos Number", "HIP 34277"},
        {"Smithsonian Astrophysical Observation", "SAO 218458"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.59013053),
        dec: Angle.Degrees(-49.79619826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201757"},
        {"Hipparcos Number", "HIP 104768"},
        {"Geneva Identification System", "GEN# +1.00201757"},
        {"Smithsonian Astrophysical Observation", "SAO 246913"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36552237),
        dec: Angle.Degrees(-49.79466765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205156"},
        {"Hipparcos Number", "HIP 106560"},
        {"Cincinnati Publication", "Ci 20 1294"},
        {"Geneva Identification System", "GEN# +1.00205156"},
        {"Smithsonian Astrophysical Observation", "SAO 247094"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.71454398),
        dec: Angle.Degrees(-49.79279508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -581.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30850"},
        {"Hipparcos Number", "HIP 22323"},
        {"Fundamental Katalog 5th Edition", "FK5 4437"},
        {"Geneva Identification System", "GEN# +1.00030850"},
        {"Smithsonian Astrophysical Observation", "SAO 217006"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.13185938),
        dec: Angle.Degrees(-49.79272088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48235",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Natasha"},
        {"Henry Draper", "HD 85390"},
        {"Hipparcos Number", "HIP 48235"},
        {"Geneva Identification System", "GEN# +1.00085390"},
        {"Smithsonian Astrophysical Observation", "SAO 221526"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51031106),
        dec: Angle.Degrees(-49.79012085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158059"},
        {"Hipparcos Number", "HIP 85610"},
        {"Smithsonian Astrophysical Observation", "SAO 228019"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.41957714),
        dec: Angle.Degrees(-49.78987503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213630"},
        {"Hipparcos Number", "HIP 111377"},
        {"Smithsonian Astrophysical Observation", "SAO 247489"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.46205586),
        dec: Angle.Degrees(-49.78917874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56126"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57848502),
        dec: Angle.Degrees(-49.78856137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106442"},
        {"Hipparcos Number", "HIP 59713"},
        {"Smithsonian Astrophysical Observation", "SAO 223301"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.70199025),
        dec: Angle.Degrees(-49.78678026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16049"},
        {"Hipparcos Number", "HIP 11851"},
        {"Smithsonian Astrophysical Observation", "SAO 232811"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.24189712),
        dec: Angle.Degrees(-49.78640274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25504"},
        {"Hipparcos Number", "HIP 18726"},
        {"Smithsonian Astrophysical Observation", "SAO 216598"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.17269999),
        dec: Angle.Degrees(-49.78466316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128121"},
        {"Hipparcos Number", "HIP 71446"},
        {"Smithsonian Astrophysical Observation", "SAO 225056"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.17171881),
        dec: Angle.Degrees(-49.78462229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16545"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.26725246),
        dec: Angle.Degrees(-18.81792259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88224"},
        {"Hipparcos Number", "HIP 49714"},
        {"Geneva Identification System", "GEN# +1.00088224"},
        {"Smithsonian Astrophysical Observation", "SAO 221808"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.25058513),
        dec: Angle.Degrees(-49.78335673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194753"},
        {"Hipparcos Number", "HIP 101080"},
        {"Smithsonian Astrophysical Observation", "SAO 230235"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36113614),
        dec: Angle.Degrees(-49.78291144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136610"},
        {"Hipparcos Number", "HIP 75336"},
        {"Smithsonian Astrophysical Observation", "SAO 225722"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.90323583),
        dec: Angle.Degrees(-49.78271168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139809"},
        {"Hipparcos Number", "HIP 76922"},
        {"Geneva Identification System", "GEN# +1.00139809"},
        {"Smithsonian Astrophysical Observation", "SAO 226084"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.59384901),
        dec: Angle.Degrees(-49.78062718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112481"},
        {"Hipparcos Number", "HIP 63250"},
        {"Geneva Identification System", "GEN# +1.00112481"},
        {"Smithsonian Astrophysical Observation", "SAO 223789"},
        {"Wilson Evans Batten Catalogue", "WEB 11209"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.40109062),
        dec: Angle.Degrees(-49.78058319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150563"},
        {"Hipparcos Number", "HIP 81945"},
        {"Smithsonian Astrophysical Observation", "SAO 227128"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07690064),
        dec: Angle.Degrees(-49.77226586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64783"},
        {"Hipparcos Number", "HIP 38509"},
        {"Geneva Identification System", "GEN# +1.00064783"},
        {"Smithsonian Astrophysical Observation", "SAO 219109"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.29914717),
        dec: Angle.Degrees(-49.77153420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29617"},
        {"Hipparcos Number", "HIP 21524"},
        {"Smithsonian Astrophysical Observation", "SAO 216903"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.32849537),
        dec: Angle.Degrees(-49.77078968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149019"},
        {"Hipparcos Number", "HIP 81144"},
        {"Geneva Identification System", "GEN# +2.61671155"},
        {"Smithsonian Astrophysical Observation", "SAO 226901"},
        {"New General Catalogue", "NGC 6167 1155"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.59613892),
        dec: Angle.Degrees(-49.76979877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35275"},
        {"Hipparcos Number", "HIP 24972"},
        {"Smithsonian Astrophysical Observation", "SAO 217298"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.22543670),
        dec: Angle.Degrees(-49.76975401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7325"},
        {"Hipparcos Number", "HIP 5656"},
        {"Smithsonian Astrophysical Observation", "SAO 232340"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.16338210),
        dec: Angle.Degrees(-49.76845971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194437"},
        {"Hipparcos Number", "HIP 100921"},
        {"Smithsonian Astrophysical Observation", "SAO 230218"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.92165311),
        dec: Angle.Degrees(-49.76702711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126342"},
        {"Hipparcos Number", "HIP 70597"},
        {"Smithsonian Astrophysical Observation", "SAO 224921"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.59556320),
        dec: Angle.Degrees(-49.76610550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81182"},
        {"Geneva Identification System", "GEN# +2.61671159"},
        {"New General Catalogue", "NGC 6167 1159"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.72666592),
        dec: Angle.Degrees(-49.76475573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140925"},
        {"Hipparcos Number", "HIP 77421"},
        {"Geneva Identification System", "GEN# +1.00140925"},
        {"Smithsonian Astrophysical Observation", "SAO 226220"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.08485669),
        dec: Angle.Degrees(-49.76315535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188278"},
        {"Hipparcos Number", "HIP 98132"},
        {"Smithsonian Astrophysical Observation", "SAO 229939"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.15820026),
        dec: Angle.Degrees(-49.76273099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156853"},
        {"Hipparcos Number", "HIP 84997"},
        {"Geneva Identification System", "GEN# +1.00156853"},
        {"Renson", "Renson 44120"},
        {"Smithsonian Astrophysical Observation", "SAO 227872"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.59914171),
        dec: Angle.Degrees(-49.76170378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297544"},
        {"Hipparcos Number", "HIP 47345"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70813291),
        dec: Angle.Degrees(-49.76152216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146628"},
        {"Hipparcos Number", "HIP 79978"},
        {"Geneva Identification System", "GEN# +1.00146628"},
        {"Wilson Evans Batten Catalogue", "WEB 13537"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.87301156),
        dec: Angle.Degrees(-49.76130244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84774"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.92794152),
        dec: Angle.Degrees(-49.76041382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146318"},
        {"Hipparcos Number", "HIP 79857"},
        {"Smithsonian Astrophysical Observation", "SAO 226631"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.51581296),
        dec: Angle.Degrees(-49.76006639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63725"},
        {"Hipparcos Number", "HIP 38051"},
        {"Geneva Identification System", "GEN# +1.00063725"},
        {"Smithsonian Astrophysical Observation", "SAO 219010"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98713770),
        dec: Angle.Degrees(-49.75863092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25087"},
        {"Hipparcos Number", "HIP 18476"},
        {"Geneva Identification System", "GEN# +1.00025087"},
        {"Smithsonian Astrophysical Observation", "SAO 216572"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.22833173),
        dec: Angle.Degrees(-49.75849018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18936"},
        {"Hipparcos Number", "HIP 14045"},
        {"Smithsonian Astrophysical Observation", "SAO 216137"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.22047705),
        dec: Angle.Degrees(-49.75848558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189934"},
        {"Hipparcos Number", "HIP 98880"},
        {"Geneva Identification System", "GEN# +1.00189934"},
        {"Smithsonian Astrophysical Observation", "SAO 230025"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19897658),
        dec: Angle.Degrees(-49.75503254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33529"},
        {"Hipparcos Number", "HIP 23915"},
        {"Smithsonian Astrophysical Observation", "SAO 217199"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.08324570),
        dec: Angle.Degrees(-49.75489842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46526"},
        {"Hipparcos Number", "HIP 31082"},
        {"Geneva Identification System", "GEN# +1.00046526"},
        {"Smithsonian Astrophysical Observation", "SAO 217993"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.83345121),
        dec: Angle.Degrees(-49.75484892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195759"},
        {"Hipparcos Number", "HIP 101587"},
        {"Geneva Identification System", "GEN# +1.00195759"},
        {"Smithsonian Astrophysical Observation", "SAO 230284"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.82462356),
        dec: Angle.Degrees(-49.75352872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37392"},
        {"Hipparcos Number", "HIP 26270"},
        {"Geneva Identification System", "GEN# +1.00037392"},
        {"Smithsonian Astrophysical Observation", "SAO 217416"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.91461840),
        dec: Angle.Degrees(-49.75170396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60814"},
        {"Hipparcos Number", "HIP 36777"},
        {"Fundamental Katalog 5th Edition", "FK5 4680"},
        {"Smithsonian Astrophysical Observation", "SAO 218806"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.46057780),
        dec: Angle.Degrees(-49.75077511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17339"},
        {"Smithsonian Astrophysical Observation", "SAO 149127"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.66856930),
        dec: Angle.Degrees(-18.81592933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5904"},
        {"Hipparcos Number", "HIP 4658"},
        {"Smithsonian Astrophysical Observation", "SAO 232251"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.96497294),
        dec: Angle.Degrees(-49.75064597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42488"},
        {"Hipparcos Number", "HIP 29107"},
        {"Smithsonian Astrophysical Observation", "SAO 217734"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07740040),
        dec: Angle.Degrees(-49.74662106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77926"},
        {"Hipparcos Number", "HIP 44461"},
        {"Smithsonian Astrophysical Observation", "SAO 220795"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.87331990),
        dec: Angle.Degrees(-49.74652055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58929"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25070749),
        dec: Angle.Degrees(-49.74631867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152946"},
        {"Hipparcos Number", "HIP 83112"},
        {"Smithsonian Astrophysical Observation", "SAO 227514"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.75185058),
        dec: Angle.Degrees(-49.74382007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73221"},
        {"Hipparcos Number", "HIP 42117"},
        {"Smithsonian Astrophysical Observation", "SAO 220148"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.78252868),
        dec: Angle.Degrees(-49.74314189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92330"},
        {"Hipparcos Number", "HIP 52095"},
        {"Smithsonian Astrophysical Observation", "SAO 222221"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.67880442),
        dec: Angle.Degrees(-49.74215671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8296"},
        {"Hipparcos Number", "HIP 6333"},
        {"Fundamental Katalog 5th Edition", "FK5 2090"},
        {"Geneva Identification System", "GEN# +1.00008296"},
        {"Smithsonian Astrophysical Observation", "SAO 232389"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.32663354),
        dec: Angle.Degrees(-49.74163818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193406"},
        {"Hipparcos Number", "HIP 100455"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55736880),
        dec: Angle.Degrees(-49.73859934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2457"},
        {"Hipparcos Number", "HIP 2217"},
        {"Smithsonian Astrophysical Observation", "SAO 232051"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.00573566),
        dec: Angle.Degrees(-49.73631358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97550"},
        {"Hipparcos Number", "HIP 54783"},
        {"Geneva Identification System", "GEN# +1.00097550"},
        {"Smithsonian Astrophysical Observation", "SAO 222643"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.23641587),
        dec: Angle.Degrees(-49.73610537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157455"},
        {"Hipparcos Number", "HIP 85308"},
        {"Geneva Identification System", "GEN# +1.00157455"},
        {"Smithsonian Astrophysical Observation", "SAO 227944"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.49535008),
        dec: Angle.Degrees(-49.73491002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17070"},
        {"Hipparcos Number", "HIP 12664"},
        {"Geneva Identification System", "GEN# +1.00017070"},
        {"Smithsonian Astrophysical Observation", "SAO 216017"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.67373344),
        dec: Angle.Degrees(-49.72938304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6180"},
        {"Hipparcos Number", "HIP 4836"},
        {"Smithsonian Astrophysical Observation", "SAO 215336"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.54603482),
        dec: Angle.Degrees(-49.72894946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9544"},
        {"Hipparcos Number", "HIP 7189"},
        {"Geneva Identification System", "GEN# +1.00009544"},
        {"Smithsonian Astrophysical Observation", "SAO 215547"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.15163543),
        dec: Angle.Degrees(-49.72753415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63095"},
    },
    visualMagnitude: 11.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.91245754),
        dec: Angle.Degrees(-18.81321452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66612"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.81045089),
        dec: Angle.Degrees(-49.72627580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113850"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.83702657),
        dec: Angle.Degrees(-49.72585578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79232"},
        {"Hipparcos Number", "HIP 45092"},
        {"Smithsonian Astrophysical Observation", "SAO 220933"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.78144290),
        dec: Angle.Degrees(-49.72544820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82986"},
        {"Hipparcos Number", "HIP 46918"},
        {"Fundamental Katalog 5th Edition", "FK5 4849"},
        {"Geneva Identification System", "GEN# +1.00082986"},
        {"Smithsonian Astrophysical Observation", "SAO 221289"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.44388324),
        dec: Angle.Degrees(-49.72524512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204369"},
        {"Hipparcos Number", "HIP 106118"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.42281563),
        dec: Angle.Degrees(-49.72419842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 365"},
        {"Hipparcos Number", "HIP 666"},
        {"Smithsonian Astrophysical Observation", "SAO 231937"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.05676952),
        dec: Angle.Degrees(-49.72183630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8870"},
        {"Hipparcos Number", "HIP 6723"},
        {"Smithsonian Astrophysical Observation", "SAO 215505"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.63423896),
        dec: Angle.Degrees(-49.72116231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79589"},
        {"Hipparcos Number", "HIP 45250"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.34099923),
        dec: Angle.Degrees(-49.71805348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173736"},
        {"Hipparcos Number", "HIP 92365"},
        {"Smithsonian Astrophysical Observation", "SAO 229303"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36205603),
        dec: Angle.Degrees(-49.71573598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7109"},
        {"Hipparcos Number", "HIP 5507"},
        {"Smithsonian Astrophysical Observation", "SAO 215395"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.63492251),
        dec: Angle.Degrees(-49.71413249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78386"},
        {"Hipparcos Number", "HIP 44667"},
        {"Smithsonian Astrophysical Observation", "SAO 220849"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.53777349),
        dec: Angle.Degrees(-49.71159255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152220"},
        {"Hipparcos Number", "HIP 82723"},
        {"Smithsonian Astrophysical Observation", "SAO 227386"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.63147503),
        dec: Angle.Degrees(-49.71078963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210545"},
        {"Hipparcos Number", "HIP 109609"},
        {"Smithsonian Astrophysical Observation", "SAO 231025"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.06196642),
        dec: Angle.Degrees(-49.71015104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124598"},
        {"Hipparcos Number", "HIP 69693"},
        {"Geneva Identification System", "GEN# +1.00124598"},
        {"Renson", "Renson 35670"},
        {"Smithsonian Astrophysical Observation", "SAO 224802"},
    },
    visualMagnitude: 9.69,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.98746353),
        dec: Angle.Degrees(-49.70971253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82984"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.37453814),
        dec: Angle.Degrees(-49.70870276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53046"},
        {"Hipparcos Number", "HIP 33798"},
        {"Smithsonian Astrophysical Observation", "SAO 218386"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.26842265),
        dec: Angle.Degrees(-49.70850797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75571"},
        {"Hipparcos Number", "HIP 43261"},
        {"Renson", "Renson 21150"},
        {"Smithsonian Astrophysical Observation", "SAO 220515"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.18687127),
        dec: Angle.Degrees(-49.70845521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190354"},
        {"Hipparcos Number", "HIP 99065"},
        {"Smithsonian Astrophysical Observation", "SAO 230041"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.68070228),
        dec: Angle.Degrees(-49.70694966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169106"},
        {"Hipparcos Number", "HIP 90316"},
        {"Smithsonian Astrophysical Observation", "SAO 229003"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.41906036),
        dec: Angle.Degrees(-49.70674569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4251"},
        {"Hipparcos Number", "HIP 3471"},
        {"Fundamental Katalog 5th Edition", "FK5 4063"},
        {"Geneva Identification System", "GEN# +1.00004251"},
        {"Smithsonian Astrophysical Observation", "SAO 215219"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08988391),
        dec: Angle.Degrees(-49.70655123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160071"},
        {"Hipparcos Number", "HIP 86497"},
        {"Smithsonian Astrophysical Observation", "SAO 228259"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.13733974),
        dec: Angle.Degrees(-49.70443443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32760"},
        {"Hipparcos Number", "HIP 23487"},
        {"Smithsonian Astrophysical Observation", "SAO 217144"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.73374280),
        dec: Angle.Degrees(-49.70360509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76426"},
        {"Hipparcos Number", "HIP 43715"},
        {"Smithsonian Astrophysical Observation", "SAO 220645"},
    },
    visualMagnitude: 9.39,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.53898573),
        dec: Angle.Degrees(-49.70188628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82784"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.77190953),
        dec: Angle.Degrees(-49.70188393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122263"},
        {"Hipparcos Number", "HIP 68558"},
        {"Geneva Identification System", "GEN# +1.00122263"},
        {"Smithsonian Astrophysical Observation", "SAO 224623"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.51864698),
        dec: Angle.Degrees(-49.70097704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115935"},
        {"Hipparcos Number", "HIP 65160"},
        {"Smithsonian Astrophysical Observation", "SAO 224082"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.29701699),
        dec: Angle.Degrees(-49.69959365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116731"},
        {"Hipparcos Number", "HIP 65554"},
        {"Smithsonian Astrophysical Observation", "SAO 224141"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.60601548),
        dec: Angle.Degrees(-49.69936743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95351"},
        {"Hipparcos Number", "HIP 53742"},
        {"Smithsonian Astrophysical Observation", "SAO 222481"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94654349),
        dec: Angle.Degrees(-49.69927775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208360"},
        {"Hipparcos Number", "HIP 108361"},
        {"Geneva Identification System", "GEN# +1.00208360"},
        {"Smithsonian Astrophysical Observation", "SAO 230909"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.28440071),
        dec: Angle.Degrees(-49.69775888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62296"},
        {"Hipparcos Number", "HIP 37416"},
        {"Geneva Identification System", "GEN# +1.00062296"},
        {"Smithsonian Astrophysical Observation", "SAO 218898"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.22070469),
        dec: Angle.Degrees(-49.69769281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101004"},
        {"Hipparcos Number", "HIP 56667"},
        {"Smithsonian Astrophysical Observation", "SAO 222911"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.28698543),
        dec: Angle.Degrees(-49.69678355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217597"},
        {"Hipparcos Number", "HIP 113777"},
        {"Geneva Identification System", "GEN# +1.00217597"},
        {"Smithsonian Astrophysical Observation", "SAO 231403"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63009276),
        dec: Angle.Degrees(-49.69620477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28645"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.73490576),
        dec: Angle.Degrees(-49.68924474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207633"},
        {"Hipparcos Number", "HIP 107898"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.91855356),
        dec: Angle.Degrees(-49.68801532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209631"},
        {"Hipparcos Number", "HIP 109112"},
        {"Geneva Identification System", "GEN# +1.00209631"},
        {"Smithsonian Astrophysical Observation", "SAO 230975"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.53059629),
        dec: Angle.Degrees(-49.68618584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113767"},
        {"Hipparcos Number", "HIP 63973"},
        {"Geneva Identification System", "GEN# +1.00113767"},
        {"Smithsonian Astrophysical Observation", "SAO 223903"},
        {"Wilson Evans Batten Catalogue", "WEB 11309"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.64665813),
        dec: Angle.Degrees(-49.68579439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -320.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215504"},
        {"Hipparcos Number", "HIP 112432"},
        {"Geneva Identification System", "GEN# +1.00215504"},
        {"Smithsonian Astrophysical Observation", "SAO 231287"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.61756451),
        dec: Angle.Degrees(-49.68512013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184020"},
        {"Hipparcos Number", "HIP 96290"},
        {"Geneva Identification System", "GEN# +1.00184020"},
        {"Renson", "Renson 50800"},
        {"Smithsonian Astrophysical Observation", "SAO 229748"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.67823823),
        dec: Angle.Degrees(-49.68481922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167077"},
        {"Hipparcos Number", "HIP 89546"},
        {"Geneva Identification System", "GEN# +1.00167077"},
        {"Smithsonian Astrophysical Observation", "SAO 228856"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.07852734),
        dec: Angle.Degrees(-49.68408239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14883"},
        {"Hipparcos Number", "HIP 11068"},
        {"Smithsonian Astrophysical Observation", "SAO 215882"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.61927979),
        dec: Angle.Degrees(-49.68332114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12915"},
        {"Hipparcos Number", "HIP 9729"},
        {"Smithsonian Astrophysical Observation", "SAO 215763"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.28011017),
        dec: Angle.Degrees(-49.68182578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76860"},
        {"Hipparcos Number", "HIP 43938"},
        {"Geneva Identification System", "GEN# +1.00076860"},
        {"Smithsonian Astrophysical Observation", "SAO 220691"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.24395721),
        dec: Angle.Degrees(-49.68103381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48152"},
        {"Hipparcos Number", "HIP 31831"},
        {"Smithsonian Astrophysical Observation", "SAO 218104"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.83032772),
        dec: Angle.Degrees(-49.68078649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59169"},
        {"Hipparcos Number", "HIP 36108"},
        {"Smithsonian Astrophysical Observation", "SAO 218725"},
    },
    visualMagnitude: 9.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.57376603),
        dec: Angle.Degrees(-49.68074101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187498"},
        {"Hipparcos Number", "HIP 97810"},
        {"Geneva Identification System", "GEN# +1.00187498"},
        {"Smithsonian Astrophysical Observation", "SAO 229905"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.14260593),
        dec: Angle.Degrees(-49.67642250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72863"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.39654931),
        dec: Angle.Degrees(-49.67182342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74626"},
        {"Geneva Identification System", "GEN# +9.85802051"},
    },
    visualMagnitude: 11.36,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.71957409),
        dec: Angle.Degrees(-18.62980124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -377.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93818"},
        {"Hipparcos Number", "HIP 52886"},
        {"Smithsonian Astrophysical Observation", "SAO 222353"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.24919285),
        dec: Angle.Degrees(-49.66899275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60294"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.45519438),
        dec: Angle.Degrees(-49.66678280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221067"},
        {"Hipparcos Number", "HIP 115923"},
        {"Smithsonian Astrophysical Observation", "SAO 231624"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.30170351),
        dec: Angle.Degrees(-49.66650957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147070"},
        {"Hipparcos Number", "HIP 80174"},
        {"Smithsonian Astrophysical Observation", "SAO 226684"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.48953105),
        dec: Angle.Degrees(-49.66244050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123165"},
        {"Hipparcos Number", "HIP 68977"},
        {"Smithsonian Astrophysical Observation", "SAO 224689"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.82865205),
        dec: Angle.Degrees(-49.66215938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96861"},
        {"Hipparcos Number", "HIP 54472"},
        {"Smithsonian Astrophysical Observation", "SAO 222594"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.17254837),
        dec: Angle.Degrees(-49.66206458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119716"},
        {"Hipparcos Number", "HIP 67173"},
        {"Geneva Identification System", "GEN# +1.00119716"},
        {"Renson", "Renson 34530"},
        {"Smithsonian Astrophysical Observation", "SAO 224403"},
    },
    visualMagnitude: 9.24,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.48802784),
        dec: Angle.Degrees(-49.66041007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170192"},
        {"Hipparcos Number", "HIP 90731"},
        {"Smithsonian Astrophysical Observation", "SAO 229075"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.68019319),
        dec: Angle.Degrees(-49.65984851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18362"},
        {"Hipparcos Number", "HIP 13599"},
        {"Geneva Identification System", "GEN# +1.00018362"},
        {"Smithsonian Astrophysical Observation", "SAO 216098"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.81407164),
        dec: Angle.Degrees(-49.65936146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6168"},
        {"Hipparcos Number", "HIP 4830"},
        {"Geneva Identification System", "GEN# +1.00006168"},
        {"Smithsonian Astrophysical Observation", "SAO 215335"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.51506069),
        dec: Angle.Degrees(-49.65675481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174452"},
        {"Hipparcos Number", "HIP 92678"},
        {"Smithsonian Astrophysical Observation", "SAO 229340"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.26935055),
        dec: Angle.Degrees(-49.65653457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110564"},
        {"Hipparcos Number", "HIP 62085"},
        {"Smithsonian Astrophysical Observation", "SAO 223623"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.87268236),
        dec: Angle.Degrees(-49.65595477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 749"},
        {"Hipparcos Number", "HIP 944"},
        {"Geneva Identification System", "GEN# +1.00000749"},
        {"Smithsonian Astrophysical Observation", "SAO 214998"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90859695),
        dec: Angle.Degrees(-49.65588618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176815"},
        {"Hipparcos Number", "HIP 93675"},
        {"Smithsonian Astrophysical Observation", "SAO 229471"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.14602527),
        dec: Angle.Degrees(-49.65585460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46746"},
        {"Geneva Identification System", "GEN# -0.04904469"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.92074967),
        dec: Angle.Degrees(-49.65501571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82124"},
        {"Hipparcos Number", "HIP 46445"},
        {"Geneva Identification System", "GEN# +1.00082124"},
        {"Smithsonian Astrophysical Observation", "SAO 221196"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.08711772),
        dec: Angle.Degrees(-49.65475315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130332"},
        {"Hipparcos Number", "HIP 72483"},
        {"Smithsonian Astrophysical Observation", "SAO 225206"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.31639291),
        dec: Angle.Degrees(-49.65454945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104666"},
        {"Hipparcos Number", "HIP 58761"},
        {"Geneva Identification System", "GEN# +1.00104666"},
        {"Smithsonian Astrophysical Observation", "SAO 223189"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.76629922),
        dec: Angle.Degrees(-49.65387798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97185"},
        {"Hipparcos Number", "HIP 54616"},
        {"Geneva Identification System", "GEN# +1.00097185"},
        {"Smithsonian Astrophysical Observation", "SAO 222614"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.66286103),
        dec: Angle.Degrees(-49.65322312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168871"},
        {"Hipparcos Number", "HIP 90223"},
        {"Geneva Identification System", "GEN# +1.00168871"},
        {"Smithsonian Astrophysical Observation", "SAO 228983"},
        {"Wilson Evans Batten Catalogue", "WEB 15431"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.13795104),
        dec: Angle.Degrees(-49.65251379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150168"},
        {"Hipparcos Number", "HIP 81733"},
        {"Fundamental Katalog 5th Edition", "FK5 3321"},
        {"Geneva Identification System", "GEN# +1.00150168"},
        {"Smithsonian Astrophysical Observation", "SAO 227058"},
        {"Wilson Evans Batten Catalogue", "WEB 13809"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.41761484),
        dec: Angle.Degrees(-49.65154575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63011"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.67529823),
        dec: Angle.Degrees(-49.65153270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100035"},
        {"Hipparcos Number", "HIP 56116"},
        {"Smithsonian Astrophysical Observation", "SAO 222822"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.54731790),
        dec: Angle.Degrees(-49.64896338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59300"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.49400607),
        dec: Angle.Degrees(-49.64749021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32791"},
        {"Hipparcos Number", "HIP 23499"},
        {"Smithsonian Astrophysical Observation", "SAO 217149"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.78438869),
        dec: Angle.Degrees(-49.64705982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11001"},
        {"Hipparcos Number", "HIP 8290"},
        {"Geneva Identification System", "GEN# +1.00011001"},
        {"Smithsonian Astrophysical Observation", "SAO 215648"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.70305947),
        dec: Angle.Degrees(-49.64664436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98178"},
        {"Hipparcos Number", "HIP 55129"},
        {"Smithsonian Astrophysical Observation", "SAO 222696"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.30015887),
        dec: Angle.Degrees(-49.64219003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98843"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.09223799),
        dec: Angle.Degrees(-49.64107856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8285"},
        {"Hipparcos Number", "HIP 6321"},
        {"Renson", "Renson 2010"},
        {"Smithsonian Astrophysical Observation", "SAO 215469"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28973210),
        dec: Angle.Degrees(-49.64095478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81149"},
        {"Geneva Identification System", "GEN# +2.61670207"},
        {"New General Catalogue", "NGC 6167 207"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.60658212),
        dec: Angle.Degrees(-49.64091515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119381"},
        {"Hipparcos Number", "HIP 67015"},
        {"Smithsonian Astrophysical Observation", "SAO 224373"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.01490850),
        dec: Angle.Degrees(-49.64087167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206396"},
        {"Hipparcos Number", "HIP 107243"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.81820352),
        dec: Angle.Degrees(-49.63909471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40291"},
        {"Hipparcos Number", "HIP 27995"},
        {"Smithsonian Astrophysical Observation", "SAO 217621"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.81226819),
        dec: Angle.Degrees(-49.63866784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134429"},
        {"Hipparcos Number", "HIP 74362"},
        {"Smithsonian Astrophysical Observation", "SAO 225519"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95452501),
        dec: Angle.Degrees(-49.63815743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95445"},
        {"Hipparcos Number", "HIP 53788"},
        {"Smithsonian Astrophysical Observation", "SAO 222492"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.07652195),
        dec: Angle.Degrees(-49.63772691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15060"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.51327176),
        dec: Angle.Degrees(-49.63599382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 157.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198777"},
        {"Hipparcos Number", "HIP 103208"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.65153487),
        dec: Angle.Degrees(-49.63346654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330179"},
        {"Hipparcos Number", "HIP 77928"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.72205672),
        dec: Angle.Degrees(-49.63183827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173360"},
        {"Hipparcos Number", "HIP 92199"},
        {"Smithsonian Astrophysical Observation", "SAO 229277"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.85137947),
        dec: Angle.Degrees(-49.63045328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 734"},
        {"Hipparcos Number", "HIP 924"},
        {"Geneva Identification System", "GEN# +1.00000734"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.87859206),
        dec: Angle.Degrees(-49.62920981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26246"},
        {"Hipparcos Number", "HIP 19196"},
        {"Geneva Identification System", "GEN# +1.00026246"},
        {"Smithsonian Astrophysical Observation", "SAO 216651"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.71323465),
        dec: Angle.Degrees(-49.62855422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1272"},
        {"Hipparcos Number", "HIP 1345"},
        {"Fundamental Katalog 5th Edition", "FK5 4030"},
        {"Smithsonian Astrophysical Observation", "SAO 215033"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.21157217),
        dec: Angle.Degrees(-49.62769562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40200"},
        {"Hipparcos Number", "HIP 27937"},
        {"Fundamental Katalog 5th Edition", "FK5 2450"},
        {"Geneva Identification System", "GEN# +1.00040200"},
        {"Smithsonian Astrophysical Observation", "SAO 217612"},
        {"Wilson Evans Batten Catalogue", "WEB 5474"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.67134853),
        dec: Angle.Degrees(-49.62704326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7124"},
        {"Hipparcos Number", "HIP 5519"},
        {"Geneva Identification System", "GEN# +1.00007124"},
        {"Smithsonian Astrophysical Observation", "SAO 215398"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.66863644),
        dec: Angle.Degrees(-49.62601534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135899"},
        {"Hipparcos Number", "HIP 75002"},
        {"Smithsonian Astrophysical Observation", "SAO 225654"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.87953686),
        dec: Angle.Degrees(-49.62212567)
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
    primaryId: "HIP 98148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188317"},
        {"Hipparcos Number", "HIP 98148"},
        {"Smithsonian Astrophysical Observation", "SAO 229941"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.19586275),
        dec: Angle.Degrees(-49.62134434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66464"},
        {"Hipparcos Number", "HIP 39220"},
        {"Geneva Identification System", "GEN# +1.00066464"},
        {"Smithsonian Astrophysical Observation", "SAO 219314"},
        {"Wilson Evans Batten Catalogue", "WEB 7691"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.33370792),
        dec: Angle.Degrees(-49.62056960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85409"},
        {"Henry Draper 2", "HD 85409A"},
        {"Hipparcos Number", "HIP 48249"},
        {"Geneva Identification System", "GEN# +1.00085409"},
        {"Smithsonian Astrophysical Observation", "SAO 221531"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.54458765),
        dec: Angle.Degrees(-49.61984498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219023"},
        {"Hipparcos Number", "HIP 114626"},
        {"Geneva Identification System", "GEN# +1.00219023J"},
        {"Smithsonian Astrophysical Observation", "SAO 231493"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31367506),
        dec: Angle.Degrees(-49.61858917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114551"},
        {"Hipparcos Number", "HIP 64401"},
        {"Geneva Identification System", "GEN# +1.00114551"},
        {"Smithsonian Astrophysical Observation", "SAO 223969"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.99449829),
        dec: Angle.Degrees(-49.61806474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141765"},
        {"Hipparcos Number", "HIP 77778"},
        {"Smithsonian Astrophysical Observation", "SAO 226321"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.22814275),
        dec: Angle.Degrees(-49.61798210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46505"},
        {"Hipparcos Number", "HIP 31076"},
        {"Smithsonian Astrophysical Observation", "SAO 217992"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.81566071),
        dec: Angle.Degrees(-49.61687801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90769"},
        {"Hipparcos Number", "HIP 51225"},
        {"Smithsonian Astrophysical Observation", "SAO 222075"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.94430227),
        dec: Angle.Degrees(-49.61621707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150724"},
        {"Hipparcos Number", "HIP 82017"},
        {"Geneva Identification System", "GEN# +1.00150724"},
        {"Smithsonian Astrophysical Observation", "SAO 227150"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.31487415),
        dec: Angle.Degrees(-49.61580453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90174"},
        {"Hipparcos Number", "HIP 50886"},
        {"Smithsonian Astrophysical Observation", "SAO 222015"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.86258653),
        dec: Angle.Degrees(-49.61522773)
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
    primaryId: "HIP 79194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144773"},
        {"Hipparcos Number", "HIP 79194"},
        {"Smithsonian Astrophysical Observation", "SAO 226541"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.45787502),
        dec: Angle.Degrees(-49.61407019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64740"},
        {"Hipparcos Number", "HIP 38500"},
        {"Celescope Catalog", "CEL 2082"},
        {"Geneva Identification System", "GEN# +1.00064740"},
        {"Renson", "Renson 17750"},
        {"Smithsonian Astrophysical Observation", "SAO 219106"},
        {"Wilson Evans Batten Catalogue", "WEB 7569"},
    },
    visualMagnitude: 4.63,
    bvColour: -0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.26517655),
        dec: Angle.Degrees(-49.61307949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161146"},
        {"Hipparcos Number", "HIP 86979"},
        {"Smithsonian Astrophysical Observation", "SAO 228393"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.62187010),
        dec: Angle.Degrees(-49.61147284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140309"},
        {"Hipparcos Number", "HIP 77151"},
        {"Smithsonian Astrophysical Observation", "SAO 226143"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.28033098),
        dec: Angle.Degrees(-49.61019441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25245"},
        {"Hipparcos Number", "HIP 18554"},
        {"Fundamental Katalog 5th Edition", "FK5 2286"},
        {"Smithsonian Astrophysical Observation", "SAO 216584"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.56340755),
        dec: Angle.Degrees(-49.61008626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55177"},
        {"Hipparcos Number", "HIP 34530"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.32781304),
        dec: Angle.Degrees(-49.60906965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142916"},
        {"Hipparcos Number", "HIP 78318"},
        {"Smithsonian Astrophysical Observation", "SAO 226421"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87075529),
        dec: Angle.Degrees(-49.60906224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189122"},
        {"Hipparcos Number", "HIP 98500"},
        {"Smithsonian Astrophysical Observation", "SAO 229976"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.16731755),
        dec: Angle.Degrees(-49.60867512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223172"},
        {"Hipparcos Number", "HIP 117327"},
        {"Smithsonian Astrophysical Observation", "SAO 231782"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84955301),
        dec: Angle.Degrees(-49.60674441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218255"},
        {"Hipparcos Number", "HIP 114159"},
        {"Geneva Identification System", "GEN# +1.00218255"},
        {"Smithsonian Astrophysical Observation", "SAO 231445"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.78930262),
        dec: Angle.Degrees(-49.60613515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330856"},
        {"Hipparcos Number", "HIP 80559"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.70951682),
        dec: Angle.Degrees(-49.60598636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28689"},
        {"Hipparcos Number", "HIP 20911"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.22654773),
        dec: Angle.Degrees(-49.60177016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72754"},
        {"Hipparcos Number", "HIP 41882"},
        {"Celescope Catalog", "CEL 2625"},
        {"Geneva Identification System", "GEN# +1.00072754"},
        {"Smithsonian Astrophysical Observation", "SAO 220069"},
        {"Wilson Evans Batten Catalogue", "WEB 8062"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.09743552),
        dec: Angle.Degrees(-49.60133441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109093"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.48489137),
        dec: Angle.Degrees(-49.60119957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76456"},
        {"Hipparcos Number", "HIP 43725"},
        {"Smithsonian Astrophysical Observation", "SAO 220647"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.57092990),
        dec: Angle.Degrees(-49.60109683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45526"},
        {"Hipparcos Number", "HIP 30549"},
        {"Smithsonian Astrophysical Observation", "SAO 217919"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.32854167),
        dec: Angle.Degrees(-49.60036357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34694"},
        {"Hipparcos Number", "HIP 24614"},
        {"Smithsonian Astrophysical Observation", "SAO 217270"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.19662474),
        dec: Angle.Degrees(-49.59962233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111808"},
        {"Hipparcos Number", "HIP 62820"},
        {"Geneva Identification System", "GEN# +1.00111808"},
        {"Smithsonian Astrophysical Observation", "SAO 223723"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.09501144),
        dec: Angle.Degrees(-49.59880058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93852"},
        {"Hipparcos Number", "HIP 52904"},
        {"Smithsonian Astrophysical Observation", "SAO 222356"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.29831618),
        dec: Angle.Degrees(-49.59859125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214573"},
        {"Hipparcos Number", "HIP 111909"},
        {"Smithsonian Astrophysical Observation", "SAO 231240"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.02962969),
        dec: Angle.Degrees(-49.59811101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203598"},
        {"Hipparcos Number", "HIP 105736"},
        {"Smithsonian Astrophysical Observation", "SAO 230671"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.24233202),
        dec: Angle.Degrees(-49.59358500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3852"},
        {"Hipparcos Number", "HIP 3195"},
        {"Geneva Identification System", "GEN# +1.00003852"},
        {"Smithsonian Astrophysical Observation", "SAO 215187"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.18239757),
        dec: Angle.Degrees(-49.59175247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45116"},
        {"Hipparcos Number", "HIP 30345"},
        {"Smithsonian Astrophysical Observation", "SAO 217897"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.74485328),
        dec: Angle.Degrees(-49.59048230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207083"},
        {"Hipparcos Number", "HIP 107621"},
        {"Smithsonian Astrophysical Observation", "SAO 230841"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.98212808),
        dec: Angle.Degrees(-49.58988003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108196"},
        {"Hipparcos Number", "HIP 60668"},
        {"Geneva Identification System", "GEN# +1.00108196"},
        {"Smithsonian Astrophysical Observation", "SAO 223436"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.50508779),
        dec: Angle.Degrees(-49.58827282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212026"},
        {"Hipparcos Number", "HIP 110456"},
        {"Smithsonian Astrophysical Observation", "SAO 231099"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.60747157),
        dec: Angle.Degrees(-49.58772758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207736"},
        {"Hipparcos Number", "HIP 107973"},
        {"Geneva Identification System", "GEN# +1.00207736"},
        {"Smithsonian Astrophysical Observation", "SAO 230874"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12325310),
        dec: Angle.Degrees(-49.58718425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173995"},
        {"Hipparcos Number", "HIP 92484"},
        {"Smithsonian Astrophysical Observation", "SAO 229314"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.73515045),
        dec: Angle.Degrees(-49.58651138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212918"},
        {"Hipparcos Number", "HIP 110954"},
        {"Geneva Identification System", "GEN# +1.00212918"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19877056),
        dec: Angle.Degrees(-49.58522818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 374.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53811"},
        {"Hipparcos Number", "HIP 34059"},
        {"Geneva Identification System", "GEN# +1.00053811"},
        {"Renson", "Renson 14770"},
        {"Smithsonian Astrophysical Observation", "SAO 218427"},
        {"Wilson Evans Batten Catalogue", "WEB 6828"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.97356647),
        dec: Angle.Degrees(-49.58425759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185775"},
        {"Hipparcos Number", "HIP 97014"},
        {"Smithsonian Astrophysical Observation", "SAO 229827"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76266877),
        dec: Angle.Degrees(-49.58182637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37677"},
        {"Hipparcos Number", "HIP 26458"},
        {"Smithsonian Astrophysical Observation", "SAO 217438"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.42568581),
        dec: Angle.Degrees(-49.58063135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83240"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.18254903),
        dec: Angle.Degrees(-49.57982161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77566"},
        {"Hipparcos Number", "HIP 44317"},
        {"Celescope Catalog", "CEL 3149"},
        {"Geneva Identification System", "GEN# +1.00077566"},
        {"Smithsonian Astrophysical Observation", "SAO 220763"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38166927),
        dec: Angle.Degrees(-49.57932754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80210"},
        {"Hipparcos Number", "HIP 45522"},
        {"Geneva Identification System", "GEN# +1.00080210"},
        {"Smithsonian Astrophysical Observation", "SAO 221022"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16699436),
        dec: Angle.Degrees(-49.57871504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128810"},
        {"Hipparcos Number", "HIP 71752"},
        {"Smithsonian Astrophysical Observation", "SAO 225107"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.15140708),
        dec: Angle.Degrees(-49.57869589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74983"},
        {"Hipparcos Number", "HIP 42946"},
        {"Smithsonian Astrophysical Observation", "SAO 220403"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.31298609),
        dec: Angle.Degrees(-49.57861180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33042"},
        {"Hipparcos Number", "HIP 23649"},
        {"Fundamental Katalog 5th Edition", "FK5 187"},
        {"Geneva Identification System", "GEN# +1.00033042"},
        {"Smithsonian Astrophysical Observation", "SAO 217164"},
        {"Wilson Evans Batten Catalogue", "WEB 4612"},
    },
    visualMagnitude: 5.05,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.24146891),
        dec: Angle.Degrees(-49.57783014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86847"},
        {"Hipparcos Number", "HIP 49009"},
        {"Geneva Identification System", "GEN# +1.00086847"},
        {"Smithsonian Astrophysical Observation", "SAO 221679"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.97419989),
        dec: Angle.Degrees(-49.57778616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65584"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.69118744),
        dec: Angle.Degrees(-49.57759855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32544"},
        {"Hipparcos Number", "HIP 23365"},
        {"Smithsonian Astrophysical Observation", "SAO 217125"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.36129630),
        dec: Angle.Degrees(-49.57715459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3421"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.89808248),
        dec: Angle.Degrees(-49.57638162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12582"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.44628273),
        dec: Angle.Degrees(-49.57499981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75426"},
        {"Hipparcos Number", "HIP 43197"},
        {"Geneva Identification System", "GEN# +1.00075426"},
        {"Smithsonian Astrophysical Observation", "SAO 220498"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.00348499),
        dec: Angle.Degrees(-49.57468429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147152"},
        {"Hipparcos Number", "HIP 80208"},
        {"Geneva Identification System", "GEN# +1.00147152"},
        {"Smithsonian Astrophysical Observation", "SAO 226693"},
        {"Wilson Evans Batten Catalogue", "WEB 13578"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.61669217),
        dec: Angle.Degrees(-49.57229123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74772"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.22248994),
        dec: Angle.Degrees(-49.57149501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87739"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.84063638),
        dec: Angle.Degrees(-49.56953489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104329"},
        {"Hipparcos Number", "HIP 58578"},
        {"Fundamental Katalog 5th Edition", "FK5 5056"},
        {"Smithsonian Astrophysical Observation", "SAO 223167"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.20084798),
        dec: Angle.Degrees(-49.56851389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98304"},
        {"Hipparcos Number", "HIP 55190"},
        {"Smithsonian Astrophysical Observation", "SAO 222706"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.49792830),
        dec: Angle.Degrees(-49.56820133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16345"},
        {"Hipparcos Number", "HIP 12069"},
        {"Smithsonian Astrophysical Observation", "SAO 215957"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.90834925),
        dec: Angle.Degrees(-49.56443168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8213"},
        {"Hipparcos Number", "HIP 6282"},
        {"Smithsonian Astrophysical Observation", "SAO 215466"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.14330276),
        dec: Angle.Degrees(-49.56391222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42683"},
        {"Hipparcos Number", "HIP 29185"},
        {"Geneva Identification System", "GEN# +1.00042683"},
        {"Smithsonian Astrophysical Observation", "SAO 217747"},
        {"Wilson Evans Batten Catalogue", "WEB 5723"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.34764312),
        dec: Angle.Degrees(-49.56301376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106546"},
        {"Geneva Identification System", "GEN# +6.20145084"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.68033418),
        dec: Angle.Degrees(-49.56086328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216364"},
        {"Hipparcos Number", "HIP 113004"},
        {"Smithsonian Astrophysical Observation", "SAO 231340"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.28085861),
        dec: Angle.Degrees(-49.56080967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77321"},
        {"Hipparcos Number", "HIP 44181"},
        {"Geneva Identification System", "GEN# +1.00077321"},
        {"Smithsonian Astrophysical Observation", "SAO 220735"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.00455722),
        dec: Angle.Degrees(-49.55798568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185074"},
        {"Hipparcos Number", "HIP 96728"},
        {"Smithsonian Astrophysical Observation", "SAO 229797"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.95265307),
        dec: Angle.Degrees(-49.55675893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72246"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61632370),
        dec: Angle.Degrees(-49.55447670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44877"},
        {"Hipparcos Number", "HIP 30235"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.41450586),
        dec: Angle.Degrees(-49.54650698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62666"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.61425055),
        dec: Angle.Degrees(-49.54633748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101750"},
        {"Hipparcos Number", "HIP 57096"},
        {"Fundamental Katalog 5th Edition", "FK5 5037"},
        {"Smithsonian Astrophysical Observation", "SAO 222969"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.57031389),
        dec: Angle.Degrees(-49.54424851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75479"},
        {"Hipparcos Number", "HIP 43222"},
        {"Smithsonian Astrophysical Observation", "SAO 220503"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.07332699),
        dec: Angle.Degrees(-49.54396741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102814"},
        {"Hipparcos Number", "HIP 57710"},
        {"Smithsonian Astrophysical Observation", "SAO 223049"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.53003671),
        dec: Angle.Degrees(-49.54319916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38041"},
        {"Hipparcos Number", "HIP 26685"},
        {"Smithsonian Astrophysical Observation", "SAO 217473"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.06694314),
        dec: Angle.Degrees(-49.53974539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165091"},
        {"Hipparcos Number", "HIP 88723"},
        {"Smithsonian Astrophysical Observation", "SAO 228701"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.70256567),
        dec: Angle.Degrees(-49.53901679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70414"},
        {"Hipparcos Number", "HIP 40810"},
        {"Fundamental Katalog 5th Edition", "FK5 4746"},
        {"Geneva Identification System", "GEN# +1.00070414"},
        {"Smithsonian Astrophysical Observation", "SAO 219797"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.93557772),
        dec: Angle.Degrees(-49.53680287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216485"},
        {"Hipparcos Number", "HIP 113077"},
        {"Smithsonian Astrophysical Observation", "SAO 231345"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.51080340),
        dec: Angle.Degrees(-49.53660459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42732"},
        {"Hipparcos Number", "HIP 29223"},
        {"Smithsonian Astrophysical Observation", "SAO 217750"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.42733356),
        dec: Angle.Degrees(-49.53418372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95094"},
        {"Smithsonian Astrophysical Observation", "SAO 229625"},
    },
    visualMagnitude: 11.33,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19457495),
        dec: Angle.Degrees(-49.53280744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37905"},
        {"Smithsonian Astrophysical Observation", "SAO 218977"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.51488790),
        dec: Angle.Degrees(-49.53264067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63345"},
        {"Hipparcos Number", "HIP 37899"},
        {"Geneva Identification System", "GEN# +1.00063345"},
        {"Smithsonian Astrophysical Observation", "SAO 218975"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50765375),
        dec: Angle.Degrees(-49.53183621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90001"},
        {"Hipparcos Number", "HIP 50775"},
        {"Geneva Identification System", "GEN# +1.00090001"},
        {"Smithsonian Astrophysical Observation", "SAO 221992"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.52374019),
        dec: Angle.Degrees(-49.53118372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75424"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.14178596),
        dec: Angle.Degrees(-49.53094779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180907"},
        {"Hipparcos Number", "HIP 95097"},
        {"Smithsonian Astrophysical Observation", "SAO 229626"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19812920),
        dec: Angle.Degrees(-49.53091464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9528"},
        {"Hipparcos Number", "HIP 7183"},
        {"Geneva Identification System", "GEN# +1.00009528"},
        {"Smithsonian Astrophysical Observation", "SAO 215545"},
        {"Wilson Evans Batten Catalogue", "WEB 1549"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13664908),
        dec: Angle.Degrees(-49.52800433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113314"},
        {"Hipparcos Number", "HIP 63724"},
        {"Geneva Identification System", "GEN# +1.00113314"},
        {"Smithsonian Astrophysical Observation", "SAO 223870"},
        {"Wilson Evans Batten Catalogue", "WEB 11269"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.88894965),
        dec: Angle.Degrees(-49.52723627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122093"},
        {"Hipparcos Number", "HIP 68454"},
        {"Geneva Identification System", "GEN# +1.00122093"},
        {"Smithsonian Astrophysical Observation", "SAO 224615"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.21658097),
        dec: Angle.Degrees(-49.52606852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186772"},
        {"Hipparcos Number", "HIP 97481"},
        {"Smithsonian Astrophysical Observation", "SAO 229875"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.19621082),
        dec: Angle.Degrees(-49.52488310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11584"},
        {"Hipparcos Number", "HIP 8741"},
        {"Smithsonian Astrophysical Observation", "SAO 215690"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.11476774),
        dec: Angle.Degrees(-49.52364861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14834"},
        {"Hipparcos Number", "HIP 11022"},
        {"Fundamental Katalog 5th Edition", "FK5 4218"},
        {"Geneva Identification System", "GEN# +1.00014834"},
        {"Smithsonian Astrophysical Observation", "SAO 215875"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.48774139),
        dec: Angle.Degrees(-49.52060427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169643"},
        {"Hipparcos Number", "HIP 90521"},
        {"Smithsonian Astrophysical Observation", "SAO 229033"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.06831555),
        dec: Angle.Degrees(-49.51910361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126983"},
        {"Hipparcos Number", "HIP 70931"},
        {"Geneva Identification System", "GEN# +1.00126983"},
        {"Smithsonian Astrophysical Observation", "SAO 224972"},
        {"Wilson Evans Batten Catalogue", "WEB 12278"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.58746947),
        dec: Angle.Degrees(-49.51892657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15637"},
        {"Hipparcos Number", "HIP 11576"},
        {"Smithsonian Astrophysical Observation", "SAO 215918"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.30211187),
        dec: Angle.Degrees(-49.51869962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8630"},
        {"Hipparcos Number", "HIP 6545"},
        {"Smithsonian Astrophysical Observation", "SAO 215489"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.02752536),
        dec: Angle.Degrees(-49.51668021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297564"},
        {"Hipparcos Number", "HIP 47613"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.62992250),
        dec: Angle.Degrees(-49.51643225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124668"},
        {"Hipparcos Number", "HIP 69729"},
        {"Smithsonian Astrophysical Observation", "SAO 224805"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.09163349),
        dec: Angle.Degrees(-49.51604387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165002"},
        {"Hipparcos Number", "HIP 88699"},
        {"Smithsonian Astrophysical Observation", "SAO 228695"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.61276765),
        dec: Angle.Degrees(-49.51356458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85823"},
        {"Hipparcos Number", "HIP 48471"},
        {"Smithsonian Astrophysical Observation", "SAO 221572"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.26216543),
        dec: Angle.Degrees(-49.51235496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101523"},
        {"Hipparcos Number", "HIP 56963"},
        {"Smithsonian Astrophysical Observation", "SAO 222951"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.16087903),
        dec: Angle.Degrees(-49.50916956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19471"},
        {"Hipparcos Number", "HIP 14407"},
        {"Smithsonian Astrophysical Observation", "SAO 216166"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.46236663),
        dec: Angle.Degrees(-49.50892180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138743"},
        {"Hipparcos Number", "HIP 76377"},
        {"Geneva Identification System", "GEN# +1.00138743J"},
        {"Smithsonian Astrophysical Observation", "SAO 225948"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.98897821),
        dec: Angle.Degrees(-49.50795006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204350"},
        {"Hipparcos Number", "HIP 106100"},
        {"Smithsonian Astrophysical Observation", "SAO 230711"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.38293830),
        dec: Angle.Degrees(-49.50741526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52758"},
        {"Henry Draper 2", "HD 52758A"},
        {"Hipparcos Number", "HIP 33681"},
        {"Geneva Identification System", "GEN# +1.00052758"},
        {"Smithsonian Astrophysical Observation", "SAO 218377"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.95796552),
        dec: Angle.Degrees(-49.50699288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330338"},
        {"Hipparcos Number", "HIP 78808"},
    },
    visualMagnitude: 10.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.32878467),
        dec: Angle.Degrees(-49.50225511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107206"},
        {"Hipparcos Number", "HIP 60110"},
        {"Smithsonian Astrophysical Observation", "SAO 223353"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91681013),
        dec: Angle.Degrees(-49.50208457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106807"},
        {"Hipparcos Number", "HIP 59897"},
        {"Smithsonian Astrophysical Observation", "SAO 223331"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.27440477),
        dec: Angle.Degrees(-49.50069609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3634"},
        {"Hipparcos Number", "HIP 3048"},
        {"Smithsonian Astrophysical Observation", "SAO 215177"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.68460622),
        dec: Angle.Degrees(-49.49950394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206690"},
        {"Hipparcos Number", "HIP 107409"},
        {"Geneva Identification System", "GEN# +1.00206690"},
        {"Smithsonian Astrophysical Observation", "SAO 230822"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.32779480),
        dec: Angle.Degrees(-49.49887670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66940"},
        {"Hipparcos Number", "HIP 39421"},
        {"Geneva Identification System", "GEN# +1.00066940"},
        {"Smithsonian Astrophysical Observation", "SAO 219360"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87390249),
        dec: Angle.Degrees(-49.49862381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81642"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.16644656),
        dec: Angle.Degrees(-49.49782711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68074"},
        {"Hipparcos Number", "HIP 39873"},
        {"Geneva Identification System", "GEN# +2.25470008"},
        {"Renson", "Renson 18810"},
        {"Smithsonian Astrophysical Observation", "SAO 219486"},
        {"Wilson Evans Batten Catalogue", "WEB 7774"},
        {"New General Catalogue", "NGC 2547 8"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.17338976),
        dec: Angle.Degrees(-49.49724824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71695"},
        {"Hipparcos Number", "HIP 41386"},
        {"Celescope Catalog", "CEL 2518"},
        {"Geneva Identification System", "GEN# +1.00071695"},
        {"Smithsonian Astrophysical Observation", "SAO 219929"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.64880821),
        dec: Angle.Degrees(-49.49723392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161859"},
        {"Hipparcos Number", "HIP 87324"},
        {"Smithsonian Astrophysical Observation", "SAO 228468"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.64453529),
        dec: Angle.Degrees(-49.49571130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118566"},
        {"Hipparcos Number", "HIP 66576"},
        {"Smithsonian Astrophysical Observation", "SAO 224304"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.70713389),
        dec: Angle.Degrees(-49.49499269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114102"},
        {"Hipparcos Number", "HIP 64170"},
        {"Smithsonian Astrophysical Observation", "SAO 223931"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.27450123),
        dec: Angle.Degrees(-49.49495018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76437"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.17412894),
        dec: Angle.Degrees(-49.49263394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61105"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.84725215),
        dec: Angle.Degrees(-49.49249673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12705"},
        {"Hipparcos Number", "HIP 9578"},
        {"Geneva Identification System", "GEN# +1.00012705"},
        {"Smithsonian Astrophysical Observation", "SAO 215748"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.76383985),
        dec: Angle.Degrees(-49.49169343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10819"},
        {"Hipparcos Number", "HIP 8147"},
        {"Smithsonian Astrophysical Observation", "SAO 215633"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.19177065),
        dec: Angle.Degrees(-49.49125827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89621"},
        {"Geneva Identification System", "GEN# +6.20145012"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.34844512),
        dec: Angle.Degrees(-49.49080241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139871"},
        {"Hipparcos Number", "HIP 76935"},
        {"Fundamental Katalog 5th Edition", "FK5 3241"},
        {"Geneva Identification System", "GEN# +1.00139871"},
        {"Smithsonian Astrophysical Observation", "SAO 226089"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.65513075),
        dec: Angle.Degrees(-49.48949872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170091"},
        {"Hipparcos Number", "HIP 90691"},
        {"Geneva Identification System", "GEN# +1.00170091"},
        {"Smithsonian Astrophysical Observation", "SAO 229068"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.55942111),
        dec: Angle.Degrees(-49.48898897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57499"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.79025839),
        dec: Angle.Degrees(-49.48812958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84612"},
        {"Hipparcos Number", "HIP 47836"},
        {"Geneva Identification System", "GEN# +1.00084612"},
        {"Smithsonian Astrophysical Observation", "SAO 221458"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.25778423),
        dec: Angle.Degrees(-49.48739233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220127"},
        {"Hipparcos Number", "HIP 115340"},
        {"Geneva Identification System", "GEN# +1.00220127"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.43082786),
        dec: Angle.Degrees(-49.48682899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -288.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84627"},
        {"Hipparcos Number", "HIP 47839"},
        {"Geneva Identification System", "GEN# +1.00084627"},
        {"Smithsonian Astrophysical Observation", "SAO 221459"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.26533357),
        dec: Angle.Degrees(-49.48560167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52118"},
        {"Hipparcos Number", "HIP 33455"},
        {"Smithsonian Astrophysical Observation", "SAO 218338"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.33485281),
        dec: Angle.Degrees(-49.48532680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204518"},
        {"Hipparcos Number", "HIP 106207"},
        {"Geneva Identification System", "GEN# +1.00204518"},
        {"Smithsonian Astrophysical Observation", "SAO 230717"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.68542450),
        dec: Angle.Degrees(-49.48265472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60482"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.98596220),
        dec: Angle.Degrees(-49.48015950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131215"},
        {"Hipparcos Number", "HIP 72904"},
        {"Smithsonian Astrophysical Observation", "SAO 225278"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.50362262),
        dec: Angle.Degrees(-49.47792729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111074"},
        {"Hipparcos Number", "HIP 62390"},
        {"Smithsonian Astrophysical Observation", "SAO 223670"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.79672148),
        dec: Angle.Degrees(-49.47441926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2321"},
        {"Hipparcos Number", "HIP 2107"},
        {"Smithsonian Astrophysical Observation", "SAO 215097"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.68487272),
        dec: Angle.Degrees(-49.47420151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62387"},
    },
    visualMagnitude: 12.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.79002178),
        dec: Angle.Degrees(-49.47230003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27502"},
        {"Hipparcos Number", "HIP 20058"},
        {"Geneva Identification System", "GEN# +1.00027502"},
        {"Smithsonian Astrophysical Observation", "SAO 216740"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.51884634),
        dec: Angle.Degrees(-49.46926339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90202"},
        {"Hipparcos Number", "HIP 50899"},
        {"Geneva Identification System", "GEN# +1.00090202"},
        {"Smithsonian Astrophysical Observation", "SAO 222017"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.90922499),
        dec: Angle.Degrees(-49.46600062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12353"},
        {"Geneva Identification System", "GEN# -0.05000776"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.76008180),
        dec: Angle.Degrees(-49.46285505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187834"},
        {"Hipparcos Number", "HIP 97935"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.55624926),
        dec: Angle.Degrees(-49.46172627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32278"},
        {"Hipparcos Number", "HIP 23196"},
        {"Geneva Identification System", "GEN# +1.00032278"},
        {"Smithsonian Astrophysical Observation", "SAO 217101"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.87350281),
        dec: Angle.Degrees(-49.45809920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137313"},
        {"Hipparcos Number", "HIP 75638"},
        {"Smithsonian Astrophysical Observation", "SAO 225795"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.80682982),
        dec: Angle.Degrees(-49.45445645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18748"},
        {"Hipparcos Number", "HIP 13901"},
        {"Smithsonian Astrophysical Observation", "SAO 216123"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.74467267),
        dec: Angle.Degrees(-49.45384517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92999"},
        {"Hipparcos Number", "HIP 52459"},
        {"Smithsonian Astrophysical Observation", "SAO 222276"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.85915141),
        dec: Angle.Degrees(-49.45376468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175881"},
        {"Hipparcos Number", "HIP 93280"},
        {"Smithsonian Astrophysical Observation", "SAO 229422"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00338607),
        dec: Angle.Degrees(-49.45184988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217363"},
        {"Hipparcos Number", "HIP 113629"},
        {"Fundamental Katalog 5th Edition", "FK5 6038"},
        {"Smithsonian Astrophysical Observation", "SAO 231388"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.19742491),
        dec: Angle.Degrees(-49.45155899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171649"},
        {"Hipparcos Number", "HIP 91411"},
        {"Geneva Identification System", "GEN# +1.00171649"},
        {"Smithsonian Astrophysical Observation", "SAO 229163"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.64918302),
        dec: Angle.Degrees(-49.45083489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91389"},
        {"Hipparcos Number", "HIP 51580"},
        {"Geneva Identification System", "GEN# +1.00091389"},
        {"Smithsonian Astrophysical Observation", "SAO 222127"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.02891011),
        dec: Angle.Degrees(-49.45081929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78746"},
        {"Hipparcos Number", "HIP 44821"},
        {"Geneva Identification System", "GEN# +1.00078746"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.00897873),
        dec: Angle.Degrees(-49.44978315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198675"},
        {"Hipparcos Number", "HIP 103139"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.46547606),
        dec: Angle.Degrees(-49.44952880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34540"},
        {"Hipparcos Number", "HIP 24526"},
        {"Geneva Identification System", "GEN# +1.00034540"},
        {"Smithsonian Astrophysical Observation", "SAO 217257"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.92882758),
        dec: Angle.Degrees(-49.44479868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130120"},
        {"Hipparcos Number", "HIP 72385"},
        {"Smithsonian Astrophysical Observation", "SAO 225189"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.00445875),
        dec: Angle.Degrees(-49.44166056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148044"},
        {"Hipparcos Number", "HIP 80621"},
        {"Geneva Identification System", "GEN# +1.00148044"},
        {"Smithsonian Astrophysical Observation", "SAO 226779"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.93154735),
        dec: Angle.Degrees(-49.44045176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107957"},
        {"Hipparcos Number", "HIP 60534"},
        {"Geneva Identification System", "GEN# +1.00107957"},
        {"Smithsonian Astrophysical Observation", "SAO 223414"},
        {"Wilson Evans Batten Catalogue", "WEB 10765"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.14136528),
        dec: Angle.Degrees(-49.44019432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202269"},
        {"Hipparcos Number", "HIP 105027"},
        {"Geneva Identification System", "GEN# +1.00202269"},
        {"Smithsonian Astrophysical Observation", "SAO 230607"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.10011101),
        dec: Angle.Degrees(-49.43980878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26562"},
        {"Hipparcos Number", "HIP 19432"},
        {"Smithsonian Astrophysical Observation", "SAO 216675"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.42366990),
        dec: Angle.Degrees(-49.43920549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133118"},
        {"Hipparcos Number", "HIP 73752"},
        {"Smithsonian Astrophysical Observation", "SAO 225416"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.13459250),
        dec: Angle.Degrees(-49.43615928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123869"},
        {"Hipparcos Number", "HIP 69336"},
        {"Geneva Identification System", "GEN# +1.00123869"},
        {"Smithsonian Astrophysical Observation", "SAO 224751"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.87136662),
        dec: Angle.Degrees(-49.43515817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151516"},
        {"Hipparcos Number", "HIP 82401"},
        {"Smithsonian Astrophysical Observation", "SAO 227277"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.57855830),
        dec: Angle.Degrees(-49.43412786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58058"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.61031614),
        dec: Angle.Degrees(-49.40233894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100241"},
        {"Hipparcos Number", "HIP 56231"},
        {"Smithsonian Astrophysical Observation", "SAO 222848"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.91240143),
        dec: Angle.Degrees(-49.43388262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88064"},
        {"Wilson Evans Batten Catalogue", "WEB 14877"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79481093),
        dec: Angle.Degrees(-49.43343854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213240"},
        {"Hipparcos Number", "HIP 111143"},
        {"Geneva Identification System", "GEN# +1.00213240"},
        {"Smithsonian Astrophysical Observation", "SAO 231175"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.75203507),
        dec: Angle.Degrees(-49.43279854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223911"},
        {"Hipparcos Number", "HIP 117817"},
        {"Fundamental Katalog 5th Edition", "FK5 6118"},
        {"Smithsonian Astrophysical Observation", "SAO 231831"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.41674618),
        dec: Angle.Degrees(-49.43250688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56236"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.92052285),
        dec: Angle.Degrees(-49.43195026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212998"},
        {"Hipparcos Number", "HIP 111005"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34151200),
        dec: Angle.Degrees(-49.42972495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23320"},
        {"Hipparcos Number", "HIP 17294"},
        {"Geneva Identification System", "GEN# +1.00023320"},
        {"Smithsonian Astrophysical Observation", "SAO 216450"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.53564045),
        dec: Angle.Degrees(-49.42678373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55720"},
        {"Hipparcos Number", "HIP 34739"},
        {"Cincinnati Publication", "Ci 20 415"},
        {"Geneva Identification System", "GEN# +1.00055720"},
        {"Smithsonian Astrophysical Observation", "SAO 218519"},
        {"Wilson Evans Batten Catalogue", "WEB 6944"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.88197378),
        dec: Angle.Degrees(-49.42619224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 818.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128345"},
        {"Hipparcos Number", "HIP 71536"},
        {"Fundamental Katalog 5th Edition", "FK5 3158"},
        {"Geneva Identification System", "GEN# +1.00128345"},
        {"Smithsonian Astrophysical Observation", "SAO 225071"},
        {"Wilson Evans Batten Catalogue", "WEB 12339"},
    },
    visualMagnitude: 4.05,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.47187965),
        dec: Angle.Degrees(-49.42575765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73609"},
        {"Hipparcos Number", "HIP 42272"},
        {"Renson", "Renson 20440"},
        {"Smithsonian Astrophysical Observation", "SAO 220195"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.29029150),
        dec: Angle.Degrees(-49.42526216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79025"},
        {"Hipparcos Number", "HIP 44979"},
        {"Geneva Identification System", "GEN# +1.00079025"},
        {"Renson", "Renson 22400"},
        {"Smithsonian Astrophysical Observation", "SAO 220910"},
        {"Wilson Evans Batten Catalogue", "WEB 8590"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.43748594),
        dec: Angle.Degrees(-49.42431351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59168"},
        {"Hipparcos Number", "HIP 36104"},
        {"Smithsonian Astrophysical Observation", "SAO 218724"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.56200778),
        dec: Angle.Degrees(-49.42227752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93497"},
        {"Hipparcos Number", "HIP 52727"},
        {"Geneva Identification System", "GEN# +1.00093497"},
        {"Smithsonian Astrophysical Observation", "SAO 222321"},
        {"Wilson Evans Batten Catalogue", "WEB 9599"},
    },
    visualMagnitude: 2.69,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.69217542),
        dec: Angle.Degrees(-49.42012517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85306"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.48058514),
        dec: Angle.Degrees(-49.41854324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162278"},
        {"Hipparcos Number", "HIP 87514"},
        {"Smithsonian Astrophysical Observation", "SAO 228503"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.20310797),
        dec: Angle.Degrees(-49.41795515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18839"},
        {"Hipparcos Number", "HIP 13979"},
        {"Smithsonian Astrophysical Observation", "SAO 216129"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.01315399),
        dec: Angle.Degrees(-49.41794202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22532"},
        {"Hipparcos Number", "HIP 16732"},
        {"Geneva Identification System", "GEN# +1.00022532"},
        {"Smithsonian Astrophysical Observation", "SAO 216395"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.81427743),
        dec: Angle.Degrees(-49.41747409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102077"},
        {"Hipparcos Number", "HIP 57269"},
        {"Smithsonian Astrophysical Observation", "SAO 222993"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.16077651),
        dec: Angle.Degrees(-49.41731969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160032"},
        {"Hipparcos Number", "HIP 86486"},
        {"Geneva Identification System", "GEN# +1.00160032"},
        {"Smithsonian Astrophysical Observation", "SAO 228257"},
        {"Wilson Evans Batten Catalogue", "WEB 14587"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.09888468),
        dec: Angle.Degrees(-49.41515481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44205"},
        {"Hipparcos Number", "HIP 29918"},
        {"Geneva Identification System", "GEN# +1.00044205"},
        {"Smithsonian Astrophysical Observation", "SAO 217834"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.47792352),
        dec: Angle.Degrees(-49.41429372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43311"},
        {"Hipparcos Number", "HIP 29494"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.22807321),
        dec: Angle.Degrees(-49.41210748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12619"},
        {"Hipparcos Number", "HIP 9502"},
        {"Smithsonian Astrophysical Observation", "SAO 215742"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.56402140),
        dec: Angle.Degrees(-49.40917495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159462"},
        {"Hipparcos Number", "HIP 86247"},
        {"Geneva Identification System", "GEN# +1.00159462J"},
        {"Wilson Evans Batten Catalogue", "WEB 14544"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36413982),
        dec: Angle.Degrees(-49.40916647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12011"},
        {"Hipparcos Number", "HIP 9065"},
        {"Smithsonian Astrophysical Observation", "SAO 215710"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.17575474),
        dec: Angle.Degrees(-49.40762992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
